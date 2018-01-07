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
    public partial class SearchLoan : Form
    {
        public static string setCustmVal = "";
        public SearchLoan()
        {
            InitializeComponent();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BAL objBAL = new BAL();


                gvSearchView.DataSource = null;
                //Set AutoGenerateColumns False
                gvSearchView.AutoGenerateColumns = false;

                //Set Columns Count
                gvSearchView.ColumnCount = 7;

                ////adding column
                gvSearchView.Columns[0].Name = "CustomerID";
                gvSearchView.Columns[0].HeaderText = "CustomerID";
                gvSearchView.Columns[0].DataPropertyName = "CustomerDetailsId";

                gvSearchView.Columns[1].Name = "Name";
                gvSearchView.Columns[1].HeaderText = "Name";
                gvSearchView.Columns[1].DataPropertyName = "Name";

                gvSearchView.Columns[2].Name = "RelationName";
                gvSearchView.Columns[2].HeaderText = "RelationName";
                gvSearchView.Columns[2].DataPropertyName = "RelationName";

                gvSearchView.Columns[3].Name = "MobileNo";
                gvSearchView.Columns[3].HeaderText = "MobileNo";
                gvSearchView.Columns[3].DataPropertyName = "MobileNo";

                gvSearchView.Columns[4].Name = "Id Proof";
                gvSearchView.Columns[4].HeaderText = "Id Proof";
                gvSearchView.Columns[4].DataPropertyName = "IdProofNo";

                gvSearchView.Columns[5].Name = "Address";
                gvSearchView.Columns[5].HeaderText = "Address";
                gvSearchView.Columns[5].DataPropertyName = "Address";

                gvSearchView.Columns[6].Name = "Gender";
                gvSearchView.Columns[6].HeaderText = "Gender";
                gvSearchView.Columns[6].DataPropertyName = "Gender";

                gvSearchView.DataSource = objBAL.Search(txtSearch.Text);
            }
        }

        private void gvSearchView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gvSearchView.Columns["CustomerID"].Index)
            {
                setCustmVal = Convert.ToString(gvSearchView.SelectedCells[0].Value);
                CustomerDetail obj = new CustomerDetail();
                obj.ShowDialog();
            }
        }

        private void btnApplyNewLoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loan objLoan = new Loan();
            objLoan.ShowDialog();
            this.Close();
        }
    }
}
