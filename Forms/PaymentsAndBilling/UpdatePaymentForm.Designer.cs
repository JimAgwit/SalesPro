﻿namespace SalesPro.Forms.PaymentsAndBilling
{
    partial class UpdatePaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notes_tx = new System.Windows.Forms.TextBox();
            this.orNunber_tx = new System.Windows.Forms.TextBox();
            this.reference_tx = new System.Windows.Forms.TextBox();
            this.bank_cb = new System.Windows.Forms.ComboBox();
            this.paymentMethod_cb = new System.Windows.Forms.ComboBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.terms_tx = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.supplier_tx = new System.Windows.Forms.Label();
            this.supplierCustomer_tx = new System.Windows.Forms.Label();
            this.total_tx = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.paymentDate_tx = new System.Windows.Forms.Label();
            this.processedBy_tx = new System.Windows.Forms.Label();
            this.referenceId_tx = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentType_tx = new System.Windows.Forms.Label();
            this.paid_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 599;
            this.label1.Text = "Notes :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 93);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 598;
            this.label11.Text = "Or Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 597;
            this.label5.Text = "Reference No. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 596;
            this.label2.Text = "Bank :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 595;
            this.label4.Text = "Payment Method :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notes_tx);
            this.groupBox1.Controls.Add(this.orNunber_tx);
            this.groupBox1.Controls.Add(this.reference_tx);
            this.groupBox1.Controls.Add(this.bank_cb);
            this.groupBox1.Controls.Add(this.paymentMethod_cb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 251);
            this.groupBox1.TabIndex = 605;
            this.groupBox1.TabStop = false;
            // 
            // notes_tx
            // 
            this.notes_tx.BackColor = System.Drawing.Color.White;
            this.notes_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.notes_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_tx.Location = new System.Drawing.Point(136, 159);
            this.notes_tx.Margin = new System.Windows.Forms.Padding(2);
            this.notes_tx.MaxLength = 100;
            this.notes_tx.Multiline = true;
            this.notes_tx.Name = "notes_tx";
            this.notes_tx.Size = new System.Drawing.Size(296, 72);
            this.notes_tx.TabIndex = 604;
            // 
            // orNunber_tx
            // 
            this.orNunber_tx.BackColor = System.Drawing.Color.White;
            this.orNunber_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.orNunber_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orNunber_tx.Location = new System.Drawing.Point(136, 89);
            this.orNunber_tx.Margin = new System.Windows.Forms.Padding(2);
            this.orNunber_tx.MaxLength = 20;
            this.orNunber_tx.Name = "orNunber_tx";
            this.orNunber_tx.Size = new System.Drawing.Size(296, 25);
            this.orNunber_tx.TabIndex = 603;
            // 
            // reference_tx
            // 
            this.reference_tx.BackColor = System.Drawing.Color.White;
            this.reference_tx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.reference_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reference_tx.Location = new System.Drawing.Point(136, 54);
            this.reference_tx.Margin = new System.Windows.Forms.Padding(2);
            this.reference_tx.MaxLength = 20;
            this.reference_tx.Name = "reference_tx";
            this.reference_tx.Size = new System.Drawing.Size(296, 25);
            this.reference_tx.TabIndex = 602;
            // 
            // bank_cb
            // 
            this.bank_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bank_cb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_cb.FormattingEnabled = true;
            this.bank_cb.Items.AddRange(new object[] {
            "CASH",
            "CHECK",
            "BANK TRANSFER",
            "E-PAYMENT"});
            this.bank_cb.Location = new System.Drawing.Point(136, 124);
            this.bank_cb.Name = "bank_cb";
            this.bank_cb.Size = new System.Drawing.Size(296, 25);
            this.bank_cb.TabIndex = 601;
            // 
            // paymentMethod_cb
            // 
            this.paymentMethod_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethod_cb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethod_cb.FormattingEnabled = true;
            this.paymentMethod_cb.Location = new System.Drawing.Point(136, 19);
            this.paymentMethod_cb.Margin = new System.Windows.Forms.Padding(2);
            this.paymentMethod_cb.Name = "paymentMethod_cb";
            this.paymentMethod_cb.Size = new System.Drawing.Size(296, 25);
            this.paymentMethod_cb.TabIndex = 600;
            this.paymentMethod_cb.SelectedIndexChanged += new System.EventHandler(this.paymentMethod_cb_SelectedIndexChanged);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(291, 458);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(172, 34);
            this.update_btn.TabIndex = 606;
            this.update_btn.Text = "Update Payment";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.terms_tx);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.supplier_tx);
            this.panel1.Controls.Add(this.supplierCustomer_tx);
            this.panel1.Controls.Add(this.total_tx);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.paymentDate_tx);
            this.panel1.Controls.Add(this.processedBy_tx);
            this.panel1.Controls.Add(this.referenceId_tx);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 144);
            this.panel1.TabIndex = 607;
            // 
            // terms_tx
            // 
            this.terms_tx.AutoSize = true;
            this.terms_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terms_tx.Location = new System.Drawing.Point(108, 114);
            this.terms_tx.Name = "terms_tx";
            this.terms_tx.Size = new System.Drawing.Size(37, 17);
            this.terms_tx.TabIndex = 609;
            this.terms_tx.Text = "Totla";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label13.Location = new System.Drawing.Point(13, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 608;
            this.label13.Text = "Credit Terms :";
            // 
            // supplier_tx
            // 
            this.supplier_tx.AutoSize = true;
            this.supplier_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_tx.Location = new System.Drawing.Point(108, 93);
            this.supplier_tx.Name = "supplier_tx";
            this.supplier_tx.Size = new System.Drawing.Size(37, 17);
            this.supplier_tx.TabIndex = 607;
            this.supplier_tx.Text = "Totla";
            // 
            // supplierCustomer_tx
            // 
            this.supplierCustomer_tx.AutoSize = true;
            this.supplierCustomer_tx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.supplierCustomer_tx.Location = new System.Drawing.Point(12, 93);
            this.supplierCustomer_tx.Name = "supplierCustomer_tx";
            this.supplierCustomer_tx.Size = new System.Drawing.Size(63, 17);
            this.supplierCustomer_tx.TabIndex = 606;
            this.supplierCustomer_tx.Text = "Supplier :";
            // 
            // total_tx
            // 
            this.total_tx.AutoSize = true;
            this.total_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tx.Location = new System.Drawing.Point(108, 73);
            this.total_tx.Name = "total_tx";
            this.total_tx.Size = new System.Drawing.Size(37, 17);
            this.total_tx.TabIndex = 605;
            this.total_tx.Text = "Totla";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label10.Location = new System.Drawing.Point(12, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 604;
            this.label10.Text = "Total :";
            // 
            // paymentDate_tx
            // 
            this.paymentDate_tx.AutoSize = true;
            this.paymentDate_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDate_tx.Location = new System.Drawing.Point(108, 52);
            this.paymentDate_tx.Name = "paymentDate_tx";
            this.paymentDate_tx.Size = new System.Drawing.Size(101, 17);
            this.paymentDate_tx.TabIndex = 603;
            this.paymentDate_tx.Text = "Payment Date :";
            // 
            // processedBy_tx
            // 
            this.processedBy_tx.AutoSize = true;
            this.processedBy_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processedBy_tx.Location = new System.Drawing.Point(108, 31);
            this.processedBy_tx.Name = "processedBy_tx";
            this.processedBy_tx.Size = new System.Drawing.Size(95, 17);
            this.processedBy_tx.TabIndex = 602;
            this.processedBy_tx.Text = "Processed By :";
            // 
            // referenceId_tx
            // 
            this.referenceId_tx.AutoSize = true;
            this.referenceId_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceId_tx.Location = new System.Drawing.Point(108, 11);
            this.referenceId_tx.Name = "referenceId_tx";
            this.referenceId_tx.Size = new System.Drawing.Size(90, 17);
            this.referenceId_tx.TabIndex = 600;
            this.referenceId_tx.Text = "Reference Id :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 599;
            this.label8.Text = "Payment Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(12, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 598;
            this.label7.Text = "Processed By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 596;
            this.label3.Text = "Reference Id :";
            // 
            // paymentType_tx
            // 
            this.paymentType_tx.AutoSize = true;
            this.paymentType_tx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentType_tx.Location = new System.Drawing.Point(12, 8);
            this.paymentType_tx.Name = "paymentType_tx";
            this.paymentType_tx.Size = new System.Drawing.Size(120, 21);
            this.paymentType_tx.TabIndex = 601;
            this.paymentType_tx.Text = "Payment Type :";
            // 
            // paid_lbl
            // 
            this.paid_lbl.AutoSize = true;
            this.paid_lbl.BackColor = System.Drawing.Color.Green;
            this.paid_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_lbl.ForeColor = System.Drawing.Color.White;
            this.paid_lbl.Location = new System.Drawing.Point(405, 7);
            this.paid_lbl.Name = "paid_lbl";
            this.paid_lbl.Size = new System.Drawing.Size(57, 22);
            this.paid_lbl.TabIndex = 608;
            this.paid_lbl.Text = "PAID";
            // 
            // UpdatePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 504);
            this.Controls.Add(this.paid_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paymentType_tx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatePaymentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.ViewPaymentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button update_btn;
        public System.Windows.Forms.TextBox notes_tx;
        public System.Windows.Forms.TextBox orNunber_tx;
        public System.Windows.Forms.TextBox reference_tx;
        public System.Windows.Forms.ComboBox bank_cb;
        private System.Windows.Forms.ComboBox paymentMethod_cb;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label paymentDate_tx;
        internal System.Windows.Forms.Label processedBy_tx;
        internal System.Windows.Forms.Label paymentType_tx;
        internal System.Windows.Forms.Label referenceId_tx;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label total_tx;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label terms_tx;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label supplier_tx;
        internal System.Windows.Forms.Label supplierCustomer_tx;
        internal System.Windows.Forms.Label paid_lbl;
    }
}