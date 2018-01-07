namespace Gold
{
    partial class LoginMessageBox
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
            this.lblMessageData = new System.Windows.Forms.Label();
            this.plnOk = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblMessageData
            // 
            this.lblMessageData.AutoSize = true;
            this.lblMessageData.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageData.ForeColor = System.Drawing.Color.White;
            this.lblMessageData.Location = new System.Drawing.Point(172, 31);
            this.lblMessageData.Name = "lblMessageData";
            this.lblMessageData.Size = new System.Drawing.Size(83, 13);
            this.lblMessageData.TabIndex = 0;
            this.lblMessageData.Text = "lblMessageData";
            // 
            // plnOk
            // 
            this.plnOk.BackColor = System.Drawing.Color.Transparent;
            this.plnOk.BackgroundImage = global::Gold.Properties.Resources.OkBtn;
            this.plnOk.Location = new System.Drawing.Point(175, 70);
            this.plnOk.Name = "plnOk";
            this.plnOk.Size = new System.Drawing.Size(74, 23);
            this.plnOk.TabIndex = 2;
            this.plnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // LoginMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gold.Properties.Resources.MesssageBoxBackground;
            this.ClientSize = new System.Drawing.Size(429, 114);
            this.Controls.Add(this.plnOk);
            this.Controls.Add(this.lblMessageData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "LoginMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblMessageData;
        private System.Windows.Forms.Panel plnOk;
    }
}