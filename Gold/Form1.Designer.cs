namespace Gold
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.lblMacAddressData = new System.Windows.Forms.Label();
            this.imgLogin = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtLoginName
            // 
            this.txtLoginName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginName.Font = new System.Drawing.Font("Goudy Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.Location = new System.Drawing.Point(265, 172);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(166, 25);
            this.txtLoginName.TabIndex = 2;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPwd.Font = new System.Drawing.Font("Goudy Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPwd.Location = new System.Drawing.Point(264, 215);
            this.txtLoginPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Size = new System.Drawing.Size(167, 25);
            this.txtLoginPwd.TabIndex = 4;
            // 
            // lblMacAddressData
            // 
            this.lblMacAddressData.AutoSize = true;
            this.lblMacAddressData.BackColor = System.Drawing.Color.Transparent;
            this.lblMacAddressData.Font = new System.Drawing.Font("Goudy Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacAddressData.ForeColor = System.Drawing.Color.White;
            this.lblMacAddressData.Location = new System.Drawing.Point(260, 135);
            this.lblMacAddressData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMacAddressData.Name = "lblMacAddressData";
            this.lblMacAddressData.Size = new System.Drawing.Size(171, 23);
            this.lblMacAddressData.TabIndex = 6;
            this.lblMacAddressData.Text = "lblMacAddressData";
            // 
            // imgLogin
            // 
            this.imgLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgLogin.BackgroundImage = global::Gold.Properties.Resources.login;
            this.imgLogin.Location = new System.Drawing.Point(431, 263);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(88, 26);
            this.imgLogin.TabIndex = 7;
            this.imgLogin.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Gold.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(672, 366);
            this.Controls.Add(this.imgLogin);
            this.Controls.Add(this.lblMacAddressData);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginName);
            this.Font = new System.Drawing.Font("Ostrich Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lavenir Technologies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Label lblMacAddressData;
        private System.Windows.Forms.Panel imgLogin;
    }
}

