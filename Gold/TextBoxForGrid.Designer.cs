namespace Gold
{
    partial class TextBoxForGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtArticalDescription = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtNetWeight = new System.Windows.Forms.TextBox();
            this.txtGrossWeight = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtArticalDescription
            // 
            this.txtArticalDescription.Location = new System.Drawing.Point(3, 3);
            this.txtArticalDescription.Name = "txtArticalDescription";
            this.txtArticalDescription.Size = new System.Drawing.Size(290, 20);
            this.txtArticalDescription.TabIndex = 22;
            this.txtArticalDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticalDescription_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(692, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 26;
            // 
            // txtNetWeight
            // 
            this.txtNetWeight.Location = new System.Drawing.Point(565, 2);
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.Size = new System.Drawing.Size(121, 20);
            this.txtNetWeight.TabIndex = 25;
            // 
            // txtGrossWeight
            // 
            this.txtGrossWeight.Location = new System.Drawing.Point(438, 3);
            this.txtGrossWeight.Name = "txtGrossWeight";
            this.txtGrossWeight.Size = new System.Drawing.Size(121, 20);
            this.txtGrossWeight.TabIndex = 24;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(299, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(133, 20);
            this.txtQuantity.TabIndex = 23;
            // 
            // TextBoxForGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtArticalDescription);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtNetWeight);
            this.Controls.Add(this.txtGrossWeight);
            this.Controls.Add(this.txtQuantity);
            this.Name = "TextBoxForGrid";
            this.Size = new System.Drawing.Size(817, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArticalDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtNetWeight;
        private System.Windows.Forms.TextBox txtGrossWeight;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}
