using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gold
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
            this.BindDataGridView();
        }

        private void Print_Load(object sender, EventArgs e)
        {

        }

        private void BindDataGridView()
        {

            BAL objBAL = new BAL();
            DataSet dsPrintPreview = new DataSet();
            Loan objLoan = new Loan();
            var test = objLoan.lblFormNo.Text;
            dsPrintPreview = objBAL.PrintPreview(Convert.ToInt32(objLoan.lblFormNo.Text)-1);//objLoan.lblFormNo.Text));
            if (dsPrintPreview.Tables.Count > 0)
            {
                DataTable dtCustomerDetails = new DataTable();
                dtCustomerDetails = dsPrintPreview.Tables[0];
                if (dtCustomerDetails.Rows.Count > 0)
                {
                    lblCustomerNo.Text = Convert.ToString(dtCustomerDetails.Rows[0].ItemArray[0]);
                    lblCustomerName.Text = Convert.ToString(dtCustomerDetails.Rows[0].ItemArray[1]);
                    lblRelationShipOf.Text = Convert.ToString(dtCustomerDetails.Rows[0].ItemArray[2]);
                    lblPhoneNo.Text = Convert.ToString(dtCustomerDetails.Rows[0].ItemArray[3]);
                    lbladharNo.Text = Convert.ToString(dtCustomerDetails.Rows[0].ItemArray[4]);
                    lblCustomerAddress.Text = Convert.ToString(dtCustomerDetails.Rows[0].ItemArray[5]);
                }
                DataTable dtSoldArticles = new DataTable();
                dtSoldArticles = dsPrintPreview.Tables[1];
                lblSoldArticle.Text = string.Empty;
                if (dtSoldArticles.Rows.Count > 0)
                {
                    StringBuilder builder = new StringBuilder();
                    foreach (DataRow row in dtSoldArticles.Rows)
                    {
                        foreach (string item in row.ItemArray)
                        {
                            lblSoldArticle.Text = Convert.ToString(builder.AppendLine(item.ToString()));
                        }
                    }
                }
                DataTable dtTotalAmount = new DataTable();
                dtTotalAmount = dsPrintPreview.Tables[2];
                lblTotalAmount.Text = lblRateOfIntrest.Text = lblPeriodOfLoan.Text = lblNetTotalAmount.Text = string.Empty;
                if (dtTotalAmount.Rows.Count > 0)
                {
                    lblTotalAmount.Text = Convert.ToString(dtTotalAmount.Rows[0]["TotalAmount"]);
                    lblRateOfIntrest.Text = Convert.ToString(dtTotalAmount.Rows[0]["RateOfIntrest"]);
                    lblPeriodOfLoan.Text = Convert.ToString(dtTotalAmount.Rows[0]["PeriodOfExpire"]);
                    //lblNetTotalAmount.Text = Convert.ToString(dtTotalAmount.Rows[0]["NetAmount"]);
                }
            }
        }
        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            //Resize DataGridView to full height.
            int height = panel1.Height;
            // panel1.Height = panel1.RowCount * panel1.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.panel1.Width, this.panel1.Height);
            panel1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));

            //Resize DataGridView back to original height.
            panel1.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
