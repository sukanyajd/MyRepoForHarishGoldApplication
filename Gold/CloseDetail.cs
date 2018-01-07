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
    public partial class CloseDetail : Form
    {
        public CloseDetail()
        {
            InitializeComponent();
            lblDateData.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblFormNoData.Text = new CustomerDetail().lblCustomerIdData.Text;
            lblNetAmountData.Text = new CustomerDetail().lblNetTotalData.Text;
            lblRenewedAmountData.Text = CustomerDetail.renewedAmountData != "" ? CustomerDetail.renewedAmountData : "0";
            lblPayableAmountData.Text = Convert.ToString(Convert.ToDecimal(lblNetAmountData.Text) - Convert.ToDecimal(lblRenewedAmountData.Text));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            BAL objBAL = new Gold.BAL();
            objBAL.InsertCloseDetail(Convert.ToInt32(lblFormNoData.Text), lblDateData.Text, Convert.ToDecimal(lblPayableAmountData.Text));
            // calling a previou page
            this.Close();
        }
    }
}
