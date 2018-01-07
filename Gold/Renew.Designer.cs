namespace Gold
{
    partial class Renew
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateData = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblFormNo = new System.Windows.Forms.Label();
            this.lblFormNoData = new System.Windows.Forms.Label();
            this.btnRenew = new System.Windows.Forms.Button();
            this.gvRenwedDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRenewAmountData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvRenwedDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(129, 105);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(71, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            // 
            // lblDateData
            // 
            this.lblDateData.AutoSize = true;
            this.lblDateData.Location = new System.Drawing.Point(126, 39);
            this.lblDateData.Name = "lblDateData";
            this.lblDateData.Size = new System.Drawing.Size(63, 13);
            this.lblDateData.TabIndex = 2;
            this.lblDateData.Text = "lblDateData";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(58, 108);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount :";
            // 
            // lblFormNo
            // 
            this.lblFormNo.AutoSize = true;
            this.lblFormNo.Location = new System.Drawing.Point(52, 9);
            this.lblFormNo.Name = "lblFormNo";
            this.lblFormNo.Size = new System.Drawing.Size(55, 13);
            this.lblFormNo.TabIndex = 4;
            this.lblFormNo.Text = "FromNO : ";
            // 
            // lblFormNoData
            // 
            this.lblFormNoData.AutoSize = true;
            this.lblFormNoData.Location = new System.Drawing.Point(126, 9);
            this.lblFormNoData.Name = "lblFormNoData";
            this.lblFormNoData.Size = new System.Drawing.Size(54, 13);
            this.lblFormNoData.TabIndex = 5;
            this.lblFormNoData.Text = "lblFormNo";
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(80, 145);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(75, 23);
            this.btnRenew.TabIndex = 6;
            this.btnRenew.Text = "Update";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // gvRenwedDetail
            // 
            this.gvRenwedDetail.AllowUserToAddRows = false;
            this.gvRenwedDetail.AllowUserToDeleteRows = false;
            this.gvRenwedDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvRenwedDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvRenwedDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvRenwedDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRenwedDetail.GridColor = System.Drawing.SystemColors.Control;
            this.gvRenwedDetail.Location = new System.Drawing.Point(12, 190);
            this.gvRenwedDetail.Name = "gvRenwedDetail";
            this.gvRenwedDetail.ReadOnly = true;
            this.gvRenwedDetail.Size = new System.Drawing.Size(259, 175);
            this.gvRenwedDetail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Renewed Amount :";
            // 
            // lblRenewAmountData
            // 
            this.lblRenewAmountData.AutoSize = true;
            this.lblRenewAmountData.Location = new System.Drawing.Point(126, 70);
            this.lblRenewAmountData.Name = "lblRenewAmountData";
            this.lblRenewAmountData.Size = new System.Drawing.Size(110, 13);
            this.lblRenewAmountData.TabIndex = 9;
            this.lblRenewAmountData.Text = "lblRenewAmountData";
            // 
            // Renew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 377);
            this.Controls.Add(this.lblRenewAmountData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvRenwedDetail);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.lblFormNoData);
            this.Controls.Add(this.lblFormNo);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDateData);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtAmount);
            this.Name = "Renew";
            this.Text = "Renew";
            ((System.ComponentModel.ISupportInitialize)(this.gvRenwedDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateData;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblFormNo;
        public System.Windows.Forms.Label lblFormNoData;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.DataGridView gvRenwedDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRenewAmountData;
    }
}