﻿using SalesPro.Helpers;
using SalesPro.Helpers.UiHelpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SalesPro.Forms.Reports
{
    public partial class ReportsForm : Form
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private DateTime _curDate;

        private readonly ReportService _reportService;
        public ReportsForm()
        {
            InitializeComponent();
            _reportService = new ReportService();
        }

        private async Task GetReportSummary()
        {
            decimal totalSales = await _reportService.GetTotalSalesByDate(_startDate, _endDate);
            decimal totalExpenses = await _reportService.GetTotalExpensesByDate(_startDate, _endDate);
            decimal totalCustomerCreditPayment = await _reportService.GetTotalCustomerCreditPaymentByDate(_startDate, _endDate);
            decimal totalPaymentToSuppliers = await _reportService.GetTotalPaymentToSuppliersByDate(_startDate, _endDate);
            decimal overAllSales = _reportService.GetOverAllSales();

            totalSales_tx.Text = totalSales.ToString("N2");
            totalExpenses_tx.Text = totalExpenses.ToString("N2");
            customerCreditTotal_tx.Text = totalCustomerCreditPayment.ToString("N2");
            paymentToSupplier_tx.Text = totalPaymentToSuppliers.ToString("N2");
            overAllSales_tx.Text = overAllSales.ToString("N2");
            if (overAllSales < 0)
            {
                overAllSales_tx.ForeColor = Color.Yellow;
            }
        }

        private async void findBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _startDate = startDate_dt.Value.Date;
                _endDate = endDate_dt.Value.Date;

                if (_startDate > _endDate)
                {
                    MessageHandler.ShowWarning("Start date cannot be greater than end date");
                    return;
                }
                await LoadAllReports();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error getting reports: {ex.Message}");
            }
        }

        private async Task LoadProductReport(bool getTopSelling)
        {
            var products = await _reportService.GetSellingProducts(_startDate.Date, _endDate.Date, getTopSelling);
            dgProducts.DataSource = products;
            DgExtensions.ConfigureDataGrid(dgProducts, false, 0, notFound_lbl, "ProductName", "TotalProductOrdered");
        }

        private async Task LoadHighPayingCustomers()
        {
            var customers = await _reportService.GetHighPayingCustomers(_startDate.Date, _endDate.Date);
            dgCustomers.DataSource = customers;
            DgExtensions.ConfigureDataGrid(dgCustomers, false, 0, noRecordCustomer, "FullName", "TotalAmountPaid");
        }

        private async void ReportsForm_Load(object sender, EventArgs e)
        {
            try
            {
                _curDate = await ClockHelper.GetServerDateTime();

                startDate_dt.Value = DateTime.Now;
                endDate_dt.Value = DateTime.Now;
                movement_cb.SelectedIndex = 0;
                viewByCb.SelectedIndex = 0;
                analytics_cb.SelectedIndex = 1;
                await LoadHighPayingCustomers();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error reports load: {ex.Message}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void viewByCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _endDate = _curDate.Date;

            if (viewByCb.SelectedIndex == 0)
                _startDate = _curDate.Date.AddDays(-30);
            else if (viewByCb.SelectedIndex == 1)
                _startDate = _curDate.Date.AddDays(-60);
            else if (viewByCb.SelectedIndex == 2)
                _startDate = _curDate.Date.AddDays(-90);
            else
            {
                customDatePanel.Visible = true;
                _startDate = _curDate.Date;
                findBtn.PerformClick();
                return;
            }

            customDatePanel.Visible = false;
            await LoadAllReports();
            reportDate_lbl.Text = $"Report Date : {_startDate.ToString("MMMM dd, yyyy")} - {_endDate.ToString("MMMM dd, yyyy")}";
        }

        private async Task LoadAllReports()
        {
            await GetReportSummary();
            movement_cb.SelectedIndex = 0;
            await LoadProductReport(true);
            await LoadHighPayingCustomers();
        }

        private async void movement_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (movement_cb.SelectedIndex == 0)
                {
                    await LoadProductReport(true);
                }
                else
                {
                    await LoadProductReport(false);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error movement_cb_SelectedIndexChanged: {ex.Message}");
            }
        }

        private async Task DisplayYearlyChart()
        {
            try
            {
                var data = await _reportService.GetYearlySalesForChart();

                if (data == null || !data.Any()) return;

                // Clear previous data
                analyticsChart.Series.Clear();

                // Create a new series
                Series series = new Series("Yearly Sales")
                {
                    ChartType = SeriesChartType.Column
                };

                // Add data to series
                foreach (var item in data)
                {
                    series.Points.AddXY(item.Year, item.Total);
                }

                // Add series to chart
                analyticsChart.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error DisplayYearlyChart: {ex.Message}");
            }

        }

        private async Task DisplayMonthlyChart()
        {
            try
            {
                var data = await _reportService.GetMonthlySalesForChart();

                if (data == null || !data.Any()) return;

                // Clear previous data
                analyticsChart.Series.Clear();

                // Create a new series
                Series series = new Series("Monthly Sales")
                {
                    ChartType = SeriesChartType.Column
                };

                // Add data to series
                foreach (var item in data)
                {
                    series.Points.AddXY(item.Month, item.Total);
                }

                // Add series to chart
                analyticsChart.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error DisplayMonthlyChart: {ex.Message}");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private async void analytics_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (analytics_cb.SelectedIndex == 0)
            {
                await DisplayYearlyChart();
            }
            else
            {
                await DisplayMonthlyChart();
            }
        }

        private void overAllSales_tx_Click(object sender, EventArgs e)
        {

        }
    }
}
