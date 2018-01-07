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
    public partial class CustomerDetail : Form
    {
        public static string renewedAmountData = "0";
        public CustomerDetail()
        {
            InitializeComponent();
            string selectedCustomerId = string.Empty;
            string selectedCustIdFromSearchLoan = SearchLoan.setCustmVal;
            string selectedCustIdFromLandingPage = LandingPage.setCustomerVal;
            lblCurrentDateData.Text = DateTime.Now.ToString("dd-MM-yyyy");
            BAL objBal = new BAL();
            if (selectedCustIdFromSearchLoan != "")
            {
                selectedCustomerId = selectedCustIdFromSearchLoan;
            }
            if (selectedCustIdFromLandingPage != "")
            {
                selectedCustomerId = selectedCustIdFromLandingPage;
            }
            if (selectedCustomerId != "")
            {
                DataSet CustomerDetail = objBal.SearchDetail(Convert.ToInt32(selectedCustomerId));
                if (CustomerDetail.Tables.Count > 0)
                {

                    DataTable dtRenewDetails = new DataTable();
                    dtRenewDetails = CustomerDetail.Tables[3];
                    if (dtRenewDetails.Rows.Count > 0)
                    {
                        renewedAmountData = Convert.ToString(dtRenewDetails.Rows[0]["Amount"]);
                    }
                    else
                    {
                        //do nothing
                    }
                    DataTable dtCloseDetails = new DataTable();
                    dtCloseDetails = CustomerDetail.Tables[4];
                    if (dtCloseDetails.Rows.Count > 0)
                    {
                        btnClose.Visible = false;
                        btnRenew.Visible = false;
                        lblClosedDate.Visible = true;
                        lblClosedDateData.Visible = true;
                        lblClosedDateData.Text = Convert.ToString(dtCloseDetails.Rows[0]["CloseDate"]);
                        lblClosedPayableAmount.Visible = true;
                        lblClosedPayableAmountData.Visible = true;
                        lblClosedPayableAmountData.Text = Convert.ToString(dtCloseDetails.Rows[0]["PayableAmount"]);
                    }
                    else
                    {
                        //do nothing
                    }
                    DataTable dtCustomerDetails = new DataTable();
                    dtCustomerDetails = CustomerDetail.Tables[0];
                    if (dtCustomerDetails.Rows.Count > 0)
                    {
                        lblCustomerIdData.Text = Convert.ToString(dtCustomerDetails.Rows[0]["CustomerDetailsId"]);
                        lblCustomerNameData.Text = Convert.ToString(dtCustomerDetails.Rows[0]["Name"]);
                        lblCustomerAddressData.Text = Convert.ToString(dtCustomerDetails.Rows[0]["Address"]);
                        LblGenderData.Text = Convert.ToString(dtCustomerDetails.Rows[0]["Gender"]);
                        lblRelationShipOfData.Text = Convert.ToString(dtCustomerDetails.Rows[0]["RelationName"]);
                        lblMobileNoData.Text = Convert.ToString(dtCustomerDetails.Rows[0]["MobileNo"]);
                        lblIdProofData.Text = Convert.ToString(dtCustomerDetails.Rows[0]["IdProofNo"]);
                    }
                    DataTable dtSoldArticleDetails = new DataTable();
                    dtSoldArticleDetails = CustomerDetail.Tables[1];
                    if (dtSoldArticleDetails.Rows.Count > 0)
                    {
                        StringBuilder builder = new StringBuilder();
                        foreach (DataRow row in dtSoldArticleDetails.Rows)
                        {
                            foreach (string item in row.ItemArray)
                            {
                                lblSoldData.Text = Convert.ToString(builder.AppendLine(item.ToString()));
                            }
                        }
                    }
                    DataTable dtTotalAmountDetails = new DataTable();
                    dtTotalAmountDetails = CustomerDetail.Tables[2];
                    decimal netAmoutValue = 0;
                    if (dtTotalAmountDetails.Rows.Count > 0)
                    {

                        lblTotalAmountData.Text = Convert.ToString(dtTotalAmountDetails.Rows[0]["TotalAmount"]);
                        lblRateOfIntrestData.Text = Convert.ToString(dtTotalAmountDetails.Rows[0]["RateOfIntrest"]);

                        DateTime IssueDate = DateTime.ParseExact((Convert.ToString(dtTotalAmountDetails.Rows[0]["LoanDate"]).Replace("-", "/")), "dd/MM/yyyy", CultureInfo.InvariantCulture); //"19-11-2017"; //Convert.ToString(dtTotalAmountDetails.Rows[0]["LoanDate"]);//"09-11-2017";
                        if (dtCloseDetails.Rows.Count == 0)
                        {
                            DateTime ClosingDate = DateTime.Now;
                            DateDifference objDateDifference = new DateDifference(IssueDate, ClosingDate);
                            if (objDateDifference.Years.ToString() == "0")
                            {
                                if (objDateDifference.Days.ToString() != "0")
                                {
                                    int monthDuration = Convert.ToInt32(objDateDifference.Months.ToString()) + 1;
                                    //if the year is "0" only then this calculation is valid, if excedes a year
                                    netAmoutValue = SimpleIntrest(Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"]), Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["RateOfIntrest"]), monthDuration);
                                    //decimal intrestAmount = ((Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"]) * (Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["RateOfIntrest"]) * monthDuration) / 100));
                                    //netAmoutValue = ((Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"])) + intrestAmount);
                                }
                                else
                                {
                                    int monthDuration = Convert.ToInt32(objDateDifference.Months.ToString());
                                    netAmoutValue = SimpleIntrest(Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"]), Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["RateOfIntrest"]), monthDuration);
                                    //decimal intrestAmount = ((Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"]) * Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["RateOfIntrest"]) * monthDuration) / 100);
                                    //netAmoutValue = (Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"])) + intrestAmount;
                                }
                            }
                            else
                            {
                                int year = objDateDifference.Years;

                                if (Convert.ToString(objDateDifference.Years) == "1" && Convert.ToString(objDateDifference.Months) == "0" && Convert.ToString(objDateDifference.Days) == "0")
                                {
                                    netAmoutValue = SimpleIntrest(Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"]), Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["RateOfIntrest"]), 12);
                                    //decimal intrestAmount = ((Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"]) * Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["RateOfIntrest"]) * convertingYearToMonth) / 100);
                                    //netAmoutValue = (Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"])) + intrestAmount;
                                }
                                else
                                {
                                    decimal currentNetAmount = Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"]);
                                    decimal someValue = 0;
                                    while (year != 0)
                                    {
                                        //Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"]
                                        someValue += SimpleIntrest(currentNetAmount, Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["RateOfIntrest"]), 12);
                                        year--;
                                    }
                                    int monthDuration = 1;
                                    if (objDateDifference.Days.ToString() != "0")
                                    {
                                        monthDuration = Convert.ToInt32(objDateDifference.Months.ToString()) + 1;
                                    }
                                    else
                                    {
                                        monthDuration = Convert.ToInt32(objDateDifference.Months.ToString());
                                    }
                                    netAmoutValue = ComplexIntrest(someValue, Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["RateOfIntrest"]), monthDuration);
                                }
                            }

                            lblNetTotalData.Text = Convert.ToString(netAmoutValue);
                        }
                        else
                        {
                            lblNetTotalData.Text = Convert.ToString(Convert.ToInt32(dtCloseDetails.Rows[0]["PayableAmount"]) + Convert.ToInt32(dtRenewDetails.Rows[0]["Amount"]));
                        }
                    }
                }
            }
        }

        public decimal ComplexIntrest(decimal simpleIntrestValue, decimal rateOfIntrestValue, decimal durationValue)
        {
            decimal simpleIntrestAmount = simpleIntrestValue;
            decimal rateOfIntrest = rateOfIntrestValue;
            decimal duration = durationValue;
            return simpleIntrestAmount + ((simpleIntrestAmount * rateOfIntrest * duration) / 100);
        }

        public decimal SimpleIntrest(decimal totalAmount, decimal rateOfIntrest, int duration)
        {
            decimal intrestAmount = (totalAmount * rateOfIntrest * duration) / 100;
            return (totalAmount + intrestAmount);
            //decimal intrestAmount = ((Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"]) * (Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["RateOfIntrest"]) * monthDuration) / 100));
            //return ((Convert.ToDecimal(dtTotalAmountDetails.Rows[0]["TotalAmount"])) + intrestAmount);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            CloseDetail objCloseDetail = new CloseDetail();
            objCloseDetail.ShowDialog();
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            this.Hide();
            Renew objRenew = new Renew();
            objRenew.ShowDialog();
            this.Close();
        }
    }
}