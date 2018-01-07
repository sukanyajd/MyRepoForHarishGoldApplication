using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gold
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
            lblCurrentDate.Text = DateTime.Now.ToString("dd-MM-yyyy");

            lblFormNo.Text = new BAL().GetFormNo();
        }

        private void txtBoxWithOnlyNumericValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+") && (e.KeyChar != Convert.ToChar(Keys.Back)))
                e.Handled = true;
        }

        private void txtBoxWithOnlyDecimalValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+") && (e.KeyChar != Convert.ToChar(Keys.Back)) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void btnLoanIssueSubmit_Click(object sender, EventArgs e)
        {
            BAL objBAL = new BAL();
            if (txtName.Text != "" && txtRelationOf.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "" && txtArticalDescription.Text != "" && txtGrossWeight.Text != "" && txtNetWeight.Text != "" && (Convert.ToString(dlGender.SelectedItem) != ""))
            {
                DataTable dtTable = objBAL.InsertLoanIssue(txtName.Text, txtRelationOf.Text, Convert.ToDouble(txtMobileNo.Text), txtIdProof.Text,
                      txtAddress.Text, Convert.ToString(dlGender.SelectedItem), Convert.ToInt32(lblFormNo.Text), txtArticalDescription.Text, Convert.ToDecimal(txtQuantity.Text), Convert.ToDecimal(txtGrossWeight.Text),
                      Convert.ToDecimal(txtNetWeight.Text), LandingPage.LoginUserId);

                //Set AutoGenerateColumns False
                gvArticelsSold.AutoGenerateColumns = false;

                //Set Columns Count
                gvArticelsSold.ColumnCount = 5;

                ////adding column
                gvArticelsSold.Columns[0].Name = "ArticleDescription";
                gvArticelsSold.Columns[0].HeaderText = "Article Description";
                gvArticelsSold.Columns[0].DataPropertyName = "ArticleDescription";

                gvArticelsSold.Columns[1].Name = "quantity";
                gvArticelsSold.Columns[1].HeaderText = "Quantity";
                gvArticelsSold.Columns[1].DataPropertyName = "uantity";

                gvArticelsSold.Columns[2].Name = "GrossWeight";
                gvArticelsSold.Columns[2].HeaderText = "Gross Weight(grams)";
                gvArticelsSold.Columns[2].DataPropertyName = "GrossWeight";

                gvArticelsSold.Columns[3].Name = "NetWeight";
                gvArticelsSold.Columns[3].HeaderText = "Net Weight(grams)";
                gvArticelsSold.Columns[3].DataPropertyName = "NetWeight";

                //gridView binding
                gvArticelsSold.DataSource = dtTable;


                //foreach (DataRow dtRow in dtTable.Rows)
                //{
                //    TotalAmount += Convert.ToDecimal(dtRow["Amount"]);
                //}
                //lblTotalAmount.Text = Convert.ToString(TotalAmount);
                txtArticalDescription.Text = txtQuantity.Text = txtGrossWeight.Text = txtNetWeight.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please fill all the mandatory feilds");
            }
        }

        private void btnCaculateNetAmount_Click(object sender, EventArgs e)
        {
            //if (txtRateOfIntreat.Text != "" && txtPeriodLoan.Text != "" && lblTotalAmount.Text != "")
            //{
            //    lblNetAmount.Text = Convert.ToString((
            //        (
            //        Convert.ToDecimal(lblTotalAmount.Text) *
            //        Convert.ToDecimal(txtRateOfIntreat.Text) *
            //        Convert.ToDecimal(txtPeriodLoan.Text)) / 100
            //        ) + Convert.ToDecimal(lblTotalAmount.Text));
            //}
            //else
            //{
            //   lblNetAmount.Text = string.Empty;
            //}

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)

        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+") && (e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != '.'))
                e.Handled = true;

            if (e.KeyChar == '\r')
            {
                decimal TotalAmount = 0;
                BAL objBAL = new BAL();
                if (txtName.Text != "" && txtRelationOf.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "" && txtArticalDescription.Text != "" && txtGrossWeight.Text != "" && txtNetWeight.Text != "" && (Convert.ToString(dlGender.SelectedItem) != null))
                {
                    DataTable dtTable = objBAL.InsertLoanIssue(txtName.Text, txtRelationOf.Text, Convert.ToDouble(txtMobileNo.Text), txtIdProof.Text,
                          txtAddress.Text, Convert.ToString(dlGender.SelectedItem), Convert.ToInt32(lblFormNo.Text), txtArticalDescription.Text, Convert.ToDecimal(txtQuantity.Text), Convert.ToDecimal(txtGrossWeight.Text),
                          Convert.ToDecimal(txtNetWeight.Text), LandingPage.LoginUserId);

                    gvArticelsSold.DataSource = null;
                    //Set AutoGenerateColumns False
                    gvArticelsSold.AutoGenerateColumns = false;

                    //Set Columns Count
                    gvArticelsSold.ColumnCount = 6;

                    ////adding column
                    gvArticelsSold.Columns[0].Name = "SlNo";
                    gvArticelsSold.Columns[0].HeaderText = "Sl.No";
                    gvArticelsSold.Columns[0].DataPropertyName = "SlNo";

                    gvArticelsSold.Columns[1].Name = "ArticleDescription";
                    gvArticelsSold.Columns[1].HeaderText = "Article Description";
                    gvArticelsSold.Columns[1].DataPropertyName = "ArticleDescription";
                    gvArticelsSold.Columns[1].Width = 360;

                    gvArticelsSold.Columns[2].Name = "quantity";
                    gvArticelsSold.Columns[2].HeaderText = "Quantity";
                    gvArticelsSold.Columns[2].DataPropertyName = "quantity";

                    gvArticelsSold.Columns[3].Name = "GrossWeight";
                    gvArticelsSold.Columns[3].HeaderText = "Gross Weight(grams)";
                    gvArticelsSold.Columns[3].DataPropertyName = "GrossWeight";

                    gvArticelsSold.Columns[4].Name = "NetWeight";
                    gvArticelsSold.Columns[4].HeaderText = "Net Weight(grams)";
                    gvArticelsSold.Columns[4].DataPropertyName = "NetWeight";

                    //gvArticelsSold.Columns[5].Name = "Amount";
                    //gvArticelsSold.Columns[5].HeaderText = "Amount";
                    //gvArticelsSold.Columns[5].DataPropertyName = "Amount";


                    gvArticelsSold.Columns[5].Name = "SoldArticleId";
                    gvArticelsSold.Columns[5].HeaderText = "SoldArticleId";
                    gvArticelsSold.Columns[5].DataPropertyName = "SoldArticleId";
                    gvArticelsSold.Columns[5].Visible = false;

                    var deleteButton = new DataGridViewButtonColumn();
                    deleteButton.Name = "dataGridViewDeleteButton";
                    deleteButton.HeaderText = "Delete";
                    deleteButton.Text = "X";
                    deleteButton.UseColumnTextForButtonValue = true;
                    this.gvArticelsSold.Columns.Add(deleteButton);

#warning removed if not required
                    //this is for the image when ever requerire
                    //var image = Properties.Resources.DeleteImage; //An image
                    //e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    //var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                    //var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                    //e.Graphics.DrawImage(image, new Point(x, y));

                    //e.Handled = true;

                    gvArticelsSold.DataSource = dtTable;

                    //foreach (DataRow dtRow in dtTable.Rows)
                    //{
                    //    TotalAmount += Convert.ToDecimal(dtRow["Amount"]);
                    //}
                    txtArticalDescription.Text = txtQuantity.Text = txtGrossWeight.Text = txtNetWeight.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please fill all the mandatory feilds");
                }
            }
        }

        private void gvArticelsSold_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BAL objBAL = new BAL();
            //if click is on new row or header row
            if (e.RowIndex == gvArticelsSold.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == gvArticelsSold.Columns["dataGridViewDeleteButton"].Index)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = gvArticelsSold.Rows[rowIndex];
                gvArticelsSold.DataSource = objBAL.DeleteArticel(Convert.ToInt32(row.Cells[5].Value), Convert.ToInt32(lblFormNo.Text));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime datepicker = datePicker.Value;

            BAL objBAL = new Gold.BAL();
            if ((!string.IsNullOrEmpty(lblFormNo.Text)) && (!string.IsNullOrEmpty(txtTotalAmount.Text)) &&
                (!string.IsNullOrEmpty(txtRateOfIntreat.Text))
                && (!string.IsNullOrEmpty(dlPeriodOfExpire.SelectedItem.ToString())) &&
                (!string.IsNullOrEmpty(txtName.Text)) && (!string.IsNullOrEmpty(txtRelationOf.Text))
                && (!string.IsNullOrEmpty(txtMobileNo.Text)) && (!string.IsNullOrEmpty(txtIdProof.Text)) &&
                (!string.IsNullOrEmpty(txtAddress.Text))
                && (!string.IsNullOrEmpty(dlGender.SelectedItem.ToString())) && (!string.IsNullOrEmpty(lblCurrentDate.Text)))
            {
                objBAL.IssueLoan(Convert.ToInt32(lblFormNo.Text), Convert.ToDouble(txtTotalAmount.Text),
                    Convert.ToDecimal(txtRateOfIntreat.Text), Convert.ToDecimal(dlPeriodOfExpire.SelectedItem),
                     txtName.Text, txtRelationOf.Text, Convert.ToDouble(txtMobileNo.Text),
                     txtIdProof.Text, txtAddress.Text, Convert.ToString(dlGender.SelectedItem), Convert.ToString(lblCurrentDate.Text));
                MessageBox.Show("Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Please fill all the feilds");
            }
        }

        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            BAL objBAL = new Gold.BAL();
            if ((!string.IsNullOrEmpty(lblFormNo.Text)) && (!string.IsNullOrEmpty(txtTotalAmount.Text)) &&
               (!string.IsNullOrEmpty(txtRateOfIntreat.Text)) && (!string.IsNullOrEmpty(dlPeriodOfExpire.SelectedItem.ToString()))
               && (!string.IsNullOrEmpty(txtName.Text)) && (!string.IsNullOrEmpty(txtRelationOf.Text))
                && (!string.IsNullOrEmpty(txtMobileNo.Text)) && (!string.IsNullOrEmpty(txtIdProof.Text))
                && (!string.IsNullOrEmpty(txtAddress.Text)) && (!string.IsNullOrEmpty(dlGender.SelectedItem.ToString()))
                && (!string.IsNullOrEmpty(lblCurrentDate.Text))
                )
            {
                objBAL.IssueLoan(Convert.ToInt32(lblFormNo.Text), Convert.ToDouble(txtTotalAmount.Text),
                   Convert.ToDecimal(txtRateOfIntreat.Text), Convert.ToDecimal(dlPeriodOfExpire.SelectedItem),
                    txtName.Text, txtRelationOf.Text, Convert.ToDouble(txtMobileNo.Text),
                    txtIdProof.Text, txtAddress.Text, Convert.ToString(dlGender.SelectedItem), Convert.ToString(lblCurrentDate.Text));

                // calling a previou page
                this.Hide();
                Print objLandingPage = new Print();
                objLandingPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill all the feilds");
            }


        }


    }
}
