namespace Gold
{
    partial class SearchLoan
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gvSearchView = new System.Windows.Forms.DataGridView();
            this.btnApplyNewLoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(212, 58);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "SEARCH :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(275, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(347, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // gvSearchView
            // 
            this.gvSearchView.AllowUserToAddRows = false;
            this.gvSearchView.AllowUserToDeleteRows = false;
            this.gvSearchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearchView.Location = new System.Drawing.Point(3, 81);
            this.gvSearchView.Name = "gvSearchView";
            this.gvSearchView.ReadOnly = true;
            this.gvSearchView.Size = new System.Drawing.Size(958, 362);
            this.gvSearchView.TabIndex = 3;
            this.gvSearchView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearchView_CellClick);
            // 
            // btnApplyNewLoan
            // 
            this.btnApplyNewLoan.Location = new System.Drawing.Point(3, 3);
            this.btnApplyNewLoan.Name = "btnApplyNewLoan";
            this.btnApplyNewLoan.Size = new System.Drawing.Size(104, 23);
            this.btnApplyNewLoan.TabIndex = 4;
            this.btnApplyNewLoan.Text = "Apply New Loan";
            this.btnApplyNewLoan.UseVisualStyleBackColor = true;
            this.btnApplyNewLoan.Click += new System.EventHandler(this.btnApplyNewLoan_Click);
            // 
            // SearchLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 446);
            this.Controls.Add(this.btnApplyNewLoan);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gvSearchView);
            this.Name = "SearchLoan";
            this.Text = "Search Loan";
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView gvSearchView;
        private System.Windows.Forms.Button btnApplyNewLoan;
    }
}