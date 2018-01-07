namespace Gold
{
    partial class CloseDetail
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateData = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.lblNetAmountData = new System.Windows.Forms.Label();
            this.lblRenewedAmount = new System.Windows.Forms.Label();
            this.lblRenewedAmountData = new System.Windows.Forms.Label();
            this.lblPayableAmount = new System.Windows.Forms.Label();
            this.lblPayableAmountData = new System.Windows.Forms.Label();
            this.lblFormNo = new System.Windows.Forms.Label();
            this.lblFormNoData = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(32, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date :";
            // 
            // lblDateData
            // 
            this.lblDateData.AutoSize = true;
            this.lblDateData.Location = new System.Drawing.Point(141, 42);
            this.lblDateData.Name = "lblDateData";
            this.lblDateData.Size = new System.Drawing.Size(63, 13);
            this.lblDateData.TabIndex = 1;
            this.lblDateData.Text = "lblDateData";
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Location = new System.Drawing.Point(32, 73);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(69, 13);
            this.lblNetAmount.TabIndex = 2;
            this.lblNetAmount.Text = "Net Amount :";
            // 
            // lblNetAmountData
            // 
            this.lblNetAmountData.AutoSize = true;
            this.lblNetAmountData.Location = new System.Drawing.Point(141, 73);
            this.lblNetAmountData.Name = "lblNetAmountData";
            this.lblNetAmountData.Size = new System.Drawing.Size(93, 13);
            this.lblNetAmountData.TabIndex = 3;
            this.lblNetAmountData.Text = "lblNetAmountData";
            // 
            // lblRenewedAmount
            // 
            this.lblRenewedAmount.AutoSize = true;
            this.lblRenewedAmount.Location = new System.Drawing.Point(32, 105);
            this.lblRenewedAmount.Name = "lblRenewedAmount";
            this.lblRenewedAmount.Size = new System.Drawing.Size(98, 13);
            this.lblRenewedAmount.TabIndex = 4;
            this.lblRenewedAmount.Text = "Renewed Amount :";
            // 
            // lblRenewedAmountData
            // 
            this.lblRenewedAmountData.AutoSize = true;
            this.lblRenewedAmountData.Location = new System.Drawing.Point(141, 105);
            this.lblRenewedAmountData.Name = "lblRenewedAmountData";
            this.lblRenewedAmountData.Size = new System.Drawing.Size(122, 13);
            this.lblRenewedAmountData.TabIndex = 5;
            this.lblRenewedAmountData.Text = "lblRenewedAmountData";
            // 
            // lblPayableAmount
            // 
            this.lblPayableAmount.AutoSize = true;
            this.lblPayableAmount.Location = new System.Drawing.Point(32, 134);
            this.lblPayableAmount.Name = "lblPayableAmount";
            this.lblPayableAmount.Size = new System.Drawing.Size(90, 13);
            this.lblPayableAmount.TabIndex = 6;
            this.lblPayableAmount.Text = "Payable Amount :";
            // 
            // lblPayableAmountData
            // 
            this.lblPayableAmountData.AutoSize = true;
            this.lblPayableAmountData.Location = new System.Drawing.Point(141, 134);
            this.lblPayableAmountData.Name = "lblPayableAmountData";
            this.lblPayableAmountData.Size = new System.Drawing.Size(114, 13);
            this.lblPayableAmountData.TabIndex = 7;
            this.lblPayableAmountData.Text = "lblPayableAmountData";
            // 
            // lblFormNo
            // 
            this.lblFormNo.AutoSize = true;
            this.lblFormNo.Location = new System.Drawing.Point(32, 18);
            this.lblFormNo.Name = "lblFormNo";
            this.lblFormNo.Size = new System.Drawing.Size(53, 13);
            this.lblFormNo.TabIndex = 8;
            this.lblFormNo.Text = "Form No :";
            // 
            // lblFormNoData
            // 
            this.lblFormNoData.AutoSize = true;
            this.lblFormNoData.Location = new System.Drawing.Point(141, 18);
            this.lblFormNoData.Name = "lblFormNoData";
            this.lblFormNoData.Size = new System.Drawing.Size(77, 13);
            this.lblFormNoData.TabIndex = 9;
            this.lblFormNoData.Text = "lblFormNoData";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(90, 182);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Update";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CloseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFormNoData);
            this.Controls.Add(this.lblFormNo);
            this.Controls.Add(this.lblPayableAmountData);
            this.Controls.Add(this.lblPayableAmount);
            this.Controls.Add(this.lblRenewedAmountData);
            this.Controls.Add(this.lblRenewedAmount);
            this.Controls.Add(this.lblNetAmountData);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.lblDateData);
            this.Controls.Add(this.lblDate);
            this.Name = "CloseDetail";
            this.Text = "CloseDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateData;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label lblNetAmountData;
        private System.Windows.Forms.Label lblRenewedAmount;
        private System.Windows.Forms.Label lblRenewedAmountData;
        private System.Windows.Forms.Label lblPayableAmount;
        private System.Windows.Forms.Label lblPayableAmountData;
        private System.Windows.Forms.Label lblFormNo;
        private System.Windows.Forms.Label lblFormNoData;
        private System.Windows.Forms.Button btnClose;
    }
}