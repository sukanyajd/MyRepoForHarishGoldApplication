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
    public partial class Renew : Form
    {
        public Renew()
        {
            InitializeComponent();
            BAL objBAL = new Gold.BAL();
            lblDateData.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblFormNoData.Text = new CustomerDetail().lblCustomerIdData.Text;
            lblRenewAmountData.Text = CustomerDetail.renewedAmountData != "" ? CustomerDetail.renewedAmountData : "0";
            DataTable dtRenewedData = objBAL.GetRenewedDetails(Convert.ToInt32(lblFormNoData.Text));
            if (dtRenewedData.Rows.Count > 0)
            {
                gvRenwedDetail.Visible = true;
                RenwedDetail();
            }
            else
            {
                gvRenwedDetail.Visible = false;
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            BAL objBAL = new Gold.BAL();
            objBAL.InsertRenewData(Convert.ToInt32(lblFormNoData.Text), lblDateData.Text, Convert.ToDecimal(txtAmount.Text));
            // calling a previou page
            this.Close();
        }

        private void RenwedDetail()
        {
            BAL objBAL = new BAL();
            gvRenwedDetail.DataSource = null;
            //Set AutoGenerateColumns False
            gvRenwedDetail.AutoGenerateColumns = false;

            //Set Columns Count
            gvRenwedDetail.ColumnCount = 2;

            ////adding column
            gvRenwedDetail.Columns[0].Name = "Amount";
            gvRenwedDetail.Columns[0].HeaderText = "Amount";
            gvRenwedDetail.Columns[0].DataPropertyName = "amount";

            gvRenwedDetail.Columns[1].Name = "renewdate";
            gvRenwedDetail.Columns[1].HeaderText = "Renew Date";
            gvRenwedDetail.Columns[1].DataPropertyName = "renewdate";

            gvRenwedDetail.DataSource = objBAL.GetRenewedDetails(Convert.ToInt32(lblFormNoData.Text));

        }
    }
}
