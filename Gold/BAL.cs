using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold
{
    public class BAL
    {
        public static int LoginUserId;
        public static string ShopName;
        public DAL objDAL = new DAL();
        public int loginAuthentication(string loginName, string loginPwd, string MacAddress)
        {
            DataTable dtLoginDetails = new DataTable();
            dtLoginDetails = objDAL.loginAuthentication(loginName, loginPwd, MacAddress);

            if (dtLoginDetails.Rows.Count > 0)
            {
                LoginUserId = Convert.ToInt32(dtLoginDetails.Rows[0].ItemArray[0]);
                ShopName = dtLoginDetails.Rows[0].ItemArray[8].ToString();
                TimeSpan expireOn = Convert.ToDateTime(dtLoginDetails.Rows[0].ItemArray[6]) - Convert.ToDateTime(DateTime.Now);
                if (expireOn.Days <= 10)
                {
                    return expireOn.Days;
                }
                // DateTime expireOn=Convert.ToDateTime(dtLoginDetails.Rows[0].ItemArray[6]) - DateTime.Now;
                // DateTime expireOn = Convert.ToDateTime(dtLoginDetails.Rows[0].ItemArray[6]);
                // string expireDate = dtLoginDetails.Columns["ExpireOn"].ToString();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string GetFormNo()
        {
            DAL objDAL = new DAL();
            return Convert.ToString(objDAL.GetFormNo() + 1);
        }
        public DataTable InsertLoanIssue(string name, string relationOf, double phoneNo, string IdProofNo, String address, string gender, int CurrentformNo, string articelDescription, decimal quantity, decimal grossWeight, decimal netWeight,int LoginMasterId)
        {
            DataTable dt = new DataTable();
            if (CurrentformNo != objDAL.GetFormNo())
            {
                objDAL.InsertLoanIssue(name, relationOf, phoneNo, IdProofNo, address, gender, LoginMasterId);
            }
            else
            {
                //Do Nothing
            }
            dt = objDAL.InsertSoldArticles(CurrentformNo, articelDescription, quantity, grossWeight, netWeight);

            return dt;

        }

        public DataTable DeleteArticel(int soldArticelId, int CurrentFormNo)
        {
#warning remove the dt was kept for testing the data 
            DataTable dt = objDAL.DeleteArticles(soldArticelId, CurrentFormNo);
            return objDAL.DeleteArticles(soldArticelId, CurrentFormNo);

        }

        public void IssueLoan(int currentFormNumber, double totalAmount, Decimal rateOfIntrest, Decimal periodOfExpire, string name, string relationOf, double phoneNo, String idProof, String address, string gender, string date)
        {
            objDAL.InsertTotalArticelValue(currentFormNumber, totalAmount, rateOfIntrest, periodOfExpire, name, relationOf, phoneNo, idProof, address, gender, date);
        }

        public DataSet PrintPreview(int customerNo)
        {
            return objDAL.PrintPreview(customerNo);
        }

        public DataTable Search(string searchData)
        {
            DataTable dt = objDAL.Search(searchData);
            return dt;
        }

        public DataSet SearchDetail(int customerId)
        {
            DataSet dsCustomerDetail = objDAL.SearchDetail(customerId);
            return dsCustomerDetail;
        }

        public void InsertRenewData(int formNumber, string reissuedDate, decimal amount)
        {
            objDAL.InsertRenewDetail(formNumber, reissuedDate, amount);
        }
        public void InsertCloseDetail(int formNumber, string closedDate, decimal payableAmount)
        {
            objDAL.InsertCloseDetail(formNumber, closedDate, payableAmount);
        }
        public DataTable GetRenewedDetails(int formNumber)
        {
            return objDAL.GetRenewedDetails(formNumber);
        }

        public DataTable GetExpireShortFall(int loginMasterId)
        {
            return objDAL.GetExpireShortFall(loginMasterId);
        }
    }
}
