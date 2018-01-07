namespace Gold
{
    partial class Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNetTotalAmount = new System.Windows.Forms.Label();
            this.lblPeriodOfLoan = new System.Windows.Forms.Label();
            this.lblRateOfIntrest = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblSoldArticle = new System.Windows.Forms.Label();
            this.lbladharNo = new System.Windows.Forms.Label();
            this.lblRelationShipOf = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(432, 469);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(202, 55);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage);
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Location = new System.Drawing.Point(110, 35);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(75, 13);
            this.lblCustomerNo.TabIndex = 2;
            this.lblCustomerNo.Text = "lblCustomerNo";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(110, 58);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(89, 13);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "lblCustomerName";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(110, 83);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(99, 13);
            this.lblCustomerAddress.TabIndex = 4;
            this.lblCustomerAddress.Text = "lblCustomerAddress";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNetTotalAmount);
            this.panel1.Controls.Add(this.lblPeriodOfLoan);
            this.panel1.Controls.Add(this.lblRateOfIntrest);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.lblSoldArticle);
            this.panel1.Controls.Add(this.lbladharNo);
            this.panel1.Controls.Add(this.lblCustomerAddress);
            this.panel1.Controls.Add(this.lblRelationShipOf);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.lblPhoneNo);
            this.panel1.Controls.Add(this.lblCustomerNo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 438);
            this.panel1.TabIndex = 5;
            // 
            // lblNetTotalAmount
            // 
            this.lblNetTotalAmount.AutoSize = true;
            this.lblNetTotalAmount.Location = new System.Drawing.Point(401, 402);
            this.lblNetTotalAmount.Name = "lblNetTotalAmount";
            this.lblNetTotalAmount.Size = new System.Drawing.Size(94, 13);
            this.lblNetTotalAmount.TabIndex = 13;
            this.lblNetTotalAmount.Text = "lblNetTotalAmount";
            // 
            // lblPeriodOfLoan
            // 
            this.lblPeriodOfLoan.AutoSize = true;
            this.lblPeriodOfLoan.Location = new System.Drawing.Point(401, 375);
            this.lblPeriodOfLoan.Name = "lblPeriodOfLoan";
            this.lblPeriodOfLoan.Size = new System.Drawing.Size(82, 13);
            this.lblPeriodOfLoan.TabIndex = 12;
            this.lblPeriodOfLoan.Text = "lblPeriodOfLoan";
            // 
            // lblRateOfIntrest
            // 
            this.lblRateOfIntrest.AutoSize = true;
            this.lblRateOfIntrest.Location = new System.Drawing.Point(401, 348);
            this.lblRateOfIntrest.Name = "lblRateOfIntrest";
            this.lblRateOfIntrest.Size = new System.Drawing.Size(80, 13);
            this.lblRateOfIntrest.TabIndex = 11;
            this.lblRateOfIntrest.Text = "lblRateOfIntrest";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(404, 316);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(77, 13);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "lblTotalAmount";
            // 
            // lblSoldArticle
            // 
            this.lblSoldArticle.AutoSize = true;
            this.lblSoldArticle.Location = new System.Drawing.Point(110, 188);
            this.lblSoldArticle.Name = "lblSoldArticle";
            this.lblSoldArticle.Size = new System.Drawing.Size(67, 13);
            this.lblSoldArticle.TabIndex = 9;
            this.lblSoldArticle.Text = "lblSoldArticle";
            // 
            // lbladharNo
            // 
            this.lbladharNo.AutoSize = true;
            this.lbladharNo.Location = new System.Drawing.Point(337, 58);
            this.lbladharNo.Name = "lbladharNo";
            this.lbladharNo.Size = new System.Drawing.Size(58, 13);
            this.lbladharNo.TabIndex = 8;
            this.lbladharNo.Text = "lbladharNo";
            // 
            // lblRelationShipOf
            // 
            this.lblRelationShipOf.AutoSize = true;
            this.lblRelationShipOf.Location = new System.Drawing.Point(337, 35);
            this.lblRelationShipOf.Name = "lblRelationShipOf";
            this.lblRelationShipOf.Size = new System.Drawing.Size(88, 13);
            this.lblRelationShipOf.TabIndex = 7;
            this.lblRelationShipOf.Text = "lblRelationShipOf";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(110, 110);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(62, 13);
            this.lblPhoneNo.TabIndex = 6;
            this.lblPhoneNo.Text = "lblPhoneNo";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(134, 469);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(202, 55);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 527);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Name = "Print";
            this.Text = "Print";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRelationShipOf;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lbladharNo;
        private System.Windows.Forms.Label lblSoldArticle;
        private System.Windows.Forms.Label lblNetTotalAmount;
        private System.Windows.Forms.Label lblPeriodOfLoan;
        private System.Windows.Forms.Label lblRateOfIntrest;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnBack;
    }
}