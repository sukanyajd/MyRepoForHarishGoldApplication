namespace Gold
{
    partial class LandingPage
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
        public void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.lblShopName = new System.Windows.Forms.Label();
            this.dgvExpireShortFall = new System.Windows.Forms.DataGridView();
            this.btnApplyNewLoan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpireShortFall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.BackColor = System.Drawing.Color.Transparent;
            this.lblShopName.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopName.ForeColor = System.Drawing.Color.White;
            this.lblShopName.Location = new System.Drawing.Point(690, 49);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(222, 53);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "LandingPage";
            this.lblShopName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblShopName.UseCompatibleTextRendering = true;
            // 
            // dgvExpireShortFall
            // 
            this.dgvExpireShortFall.AllowUserToAddRows = false;
            this.dgvExpireShortFall.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Goudy Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExpireShortFall.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpireShortFall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpireShortFall.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExpireShortFall.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvExpireShortFall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpireShortFall.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpireShortFall.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpireShortFall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Goudy Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpireShortFall.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpireShortFall.GridColor = System.Drawing.Color.White;
            this.dgvExpireShortFall.Location = new System.Drawing.Point(-2, 246);
            this.dgvExpireShortFall.Name = "dgvExpireShortFall";
            this.dgvExpireShortFall.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpireShortFall.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpireShortFall.Size = new System.Drawing.Size(642, 585);
            this.dgvExpireShortFall.TabIndex = 4;
            this.dgvExpireShortFall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpireShortFall_CellClick);
            // 
            // btnApplyNewLoan
            // 
            this.btnApplyNewLoan.BackColor = System.Drawing.Color.Transparent;
            this.btnApplyNewLoan.BackgroundImage = global::Gold.Properties.Resources.apply;
            this.btnApplyNewLoan.Location = new System.Drawing.Point(83, 114);
            this.btnApplyNewLoan.Name = "btnApplyNewLoan";
            this.btnApplyNewLoan.Size = new System.Drawing.Size(147, 41);
            this.btnApplyNewLoan.TabIndex = 5;
            this.btnApplyNewLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Gold.Properties.Resources.search;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(339, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 41);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.btnSearchLoanDetails_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Gold.Properties.Resources.landingPageBackGround;
            this.ClientSize = new System.Drawing.Size(1486, 865);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnApplyNewLoan);
            this.Controls.Add(this.dgvExpireShortFall);
            this.Controls.Add(this.lblShopName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LandingPage";
            this.Text = "Lavenir Technology";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.btnLoan_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpireShortFall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.DataGridView dgvExpireShortFall;
        private System.Windows.Forms.Panel btnApplyNewLoan;
        private System.Windows.Forms.Panel panel1;
    }
}