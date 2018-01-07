using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gold
{
    public partial class LandingPage : Form
    {
        public static string setCustomerVal = "";
        public static int LoginUserId;
        BAL objBAL = new BAL();
        public LandingPage()
        {
            InitializeComponent();
            LoginUserId = BAL.LoginUserId;
            lblShopName.Text = BAL.ShopName;
            dgvExpireShortFall.DataSource = objBAL.GetExpireShortFall(LoginUserId);
        }
        private void dgvExpireShortFall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setCustomerVal = dgvExpireShortFall.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
            CustomerDetail obj = new CustomerDetail();
            obj.ShowDialog();
        }
        private void btnLoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loan objLoan = new Loan();
            objLoan.ShowDialog();
            this.Close();
        }

        private void btnSearchLoanDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchLoan objSearchLoan = new SearchLoan();
            objSearchLoan.ShowDialog();
            this.Close();
        }
    }
}
