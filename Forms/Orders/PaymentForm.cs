﻿using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesPro.Forms.Orders
{
    public partial class PaymentForm : Form
    {
        public int _orderId;
        public int _rowVersion;
        private decimal _amountDue;
        private decimal _totalAmtDue;
        private DateTime _curDate;

        private readonly OrderService _service;
        private readonly OrderForm _orderForm;
        public PaymentForm(OrderForm orderForm)
        {
            InitializeComponent();
            _service = new OrderService();
            TextBoxHelper.FormatDecimalTextbox(cash_tx);
            TextBoxHelper.FormatPercentageTextbox(discRate_tx);
            _orderForm = orderForm;
            KeyPreview = true;
        }

        private async void PayForm_Load(object sender, EventArgs e)
        {
            try
            {
                var filteredPaymentMethods = PaymentMethodHelper.GetFilteredPaymentMethods();
                paymentMethod_cb.DataSource = filteredPaymentMethods;

                _curDate = await ClockHelper.GetServerDateTime();
                var order = await _service.GetOrderById(_orderId);
                if (order != null)
                {
                    total_tx.ForeColor = order.AmountDue < 0 ? System.Drawing.Color.Red : System.Drawing.Color.Black;
                    total_tx.Text = $"{order.AmountDue.ToString("N2")}";
                    _amountDue = order.AmountDue;
                    customer_tx.Text = order.CustomerName;
                    SetControls(order.PaymentStatus);
                }
                CalculateOrderPayment(_amountDue);
                cash_tx.Select();
                cash_tx.Focus();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error pay load: {ex.Message}");
            }
        }

        private async void pay_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var cash = decimal.Parse(cash_tx.Text);
                if (_totalAmtDue > 0 && cash == 0)
                {
                    MessageHandler.ShowWarning("Please enter cash amount. Cash cannot be 0");
                    return;
                }
                if (cash < _totalAmtDue)
                {
                    MessageHandler.ShowWarning("Cash amount is less than the total amount due");
                    return;
                }
                if (MessageHandler.ShowQuestionGeneric("Are you sure you want to pay this order?"))
                {
                    var order = CalculateOrderPayment(_amountDue);
                    var (invalidOrdersDetected, successUpdate) = await _service.PayOrder(_orderId, cash, _curDate, _rowVersion, order);
                    if (invalidOrdersDetected.Count() == 0 && successUpdate)
                    {
                        cash_tx.ReadOnly = true;
                        discRate_tx.ReadOnly = true;
                        paymentMethod_cb.Enabled = false;
                        pay_btn.Enabled = false;
                        paymentPhoto.Image = Properties.Resources.paid;
                        pressEsc_lbl.Visible = true;
                    }
                    await _orderForm.LoadOrderedItems(_orderId, invalidOrdersDetected);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error pay button click: {ex.Message}");
            }
        }

        private void SetControls(PaymentStatus status)
        {
            bool isPaid = (status == PaymentStatus.Paid);

            bool isEditable = isPaid || _amountDue > 0;

            cash_tx.ReadOnly = !isEditable;
            discRate_tx.ReadOnly = !isEditable;
            paymentMethod_cb.Enabled = isEditable;
            pay_btn.Enabled = !isPaid;
            paymentPhoto.Image = isPaid ? Properties.Resources.paid : Properties.Resources.payment;
        }


        private OrderModel CalculateOrderPayment(decimal total)
        {
            var orderModel = new OrderModel();
            try
            {
                decimal cashTendered = decimal.Parse(cash_tx.Text);
                decimal discountRate = decimal.Parse(discRate_tx.Text);
                // Calculate the discount amount
                decimal discountAmount = (total * discountRate) / 100;

                // Calculate the final total after discount
                decimal totalmtDue = total - discountAmount;

                // Calculate the change
                decimal change = cashTendered - totalmtDue;

                // Controls
                discountAmount_lbl.Text = discountAmount.ToString("N2");
                totalAmountDue_tx.Text = totalmtDue.ToString("N2");
                change_tx.Text = change.ToString("N2");

                // Props
                _totalAmtDue = totalmtDue;

                // model
                orderModel.AmountPaid = cashTendered;
                orderModel.DiscountRate = discountRate;
                orderModel.DiscountAmount = discountAmount;
                orderModel.Change = change;
                orderModel.AmountDue = totalmtDue;
                orderModel.PaymentMethod = (PaymentMethod)paymentMethod_cb.SelectedValue;
                orderModel.OrderStatus = OrderStatus.Completed;
                orderModel.DatePaid = _curDate;

                // forecolor
                if (change < 0)
                {
                    change_tx.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    change_tx.ForeColor = System.Drawing.Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error calculating order payment: {ex.Message}");
            }
            return orderModel;
        }


        private void cash_tx_ValueChanged(object sender, EventArgs e)
        {
            CalculateOrderPayment(_amountDue);
        }


        private void discRate_tx_ValueChanged(object sender, EventArgs e)
        {
            CalculateOrderPayment(_amountDue);
        }

        private void cash_tx_KeyDown(object sender, KeyEventArgs e)
        {
            CalculateOrderPayment(_amountDue);
        }

        private void c_TextChanged(object sender, EventArgs e)
        {
            TextBoxHelper.HandleEmptyDecimalTextbox(cash_tx);
            CalculateOrderPayment(_amountDue);

        }

        private void discRate_tx_TextChanged(object sender, EventArgs e)
        {
            if (discRate_tx.Text == string.Empty)
            {
                discRate_tx.Text = "0";
            }
            CalculateOrderPayment(_amountDue);
        }

        private async void PaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var order = await _service.GetOrderById(_orderId);
                if (order != null && order.PaymentStatus == PaymentStatus.Paid)
                {
                    await _orderForm.CreateNewOrder();
                }
                else
                {
                    await _orderForm.InitializeOrderDisplay(order);
                    await _orderForm.ReloadRowVersion();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error on payment closing: {ex.Message}");
            }
        }

        private void PaymentForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }


        private void cash_tx_Click(object sender, EventArgs e)
        {
            if (cash_tx.Text == "0.00" || cash_tx.Text == "0")
            {
                cash_tx.SelectAll();
            }
        }

        private void discRate_tx_Click(object sender, EventArgs e)
        {
            if (discRate_tx.Text == "0.00" || discRate_tx.Text == "0")
            {
                discRate_tx.SelectAll();
            }
        }

        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _orderForm.barcode_tx.Select();
        }
    }
}
