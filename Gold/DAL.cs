using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold
{
    public class DAL
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\TestApplicationFolder\\Gold\\Gold\\Gold\\Database.mdf;Integrated Security = True");
        //("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Gold\\Database.mdf;Integrated Security = True");

        public DataTable loginAuthentication(string loginName, string loginPwd, string MacAddress)
        {
            DataTable dtLoginData = new DataTable();
            string query = "select * from loginMaster WHERE loginName='" + loginName + "' AND LoginPwd='" + loginPwd + "' AND IsActive=1 AND expireOn >= CONVERT(date, getdate()) AND MacAddress='" + MacAddress + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dtLoginData);
            conn.Close();
            da.Dispose();
            return dtLoginData;
        }

        public void InsertGoldPrice(DateTime dateTime, int price, String createdBy)
        {
            SqlCommand cmd = new SqlCommand("Proc_InsertGoldPrice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dateTime", dateTime);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@isActiveStatus", 1);
            cmd.Parameters.AddWithValue("@createdBy", createdBy);
            conn.Open();

            conn.Close();
        }

        public int GetFormNo()
        {
            try
            {
                string query = "SELECT  ISNULL(MAX(CustomerDetailsId),1954)  FROM CustomersDetail";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                // create data adapter
                return (int)cmd.ExecuteScalar();
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetRenewedDetails(int formNumber)
        {
            string query = string.Empty;
            DataTable dtRenewedDetails = new DataTable();

            query = "SELECT Amount, RenewDate FROM reneweddetails where customerDetailsId = " + formNumber;
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dtRenewedDetails);
            conn.Close();
            da.Dispose();
            return dtRenewedDetails;
        }
        public void InsertLoanIssue(string name, string relationOf, double phoneNo, String idProofNo, String address, string gender, int LoginMasterId)
        {
            string query = string.Empty;
            DataTable dtLoginData = new DataTable();

            query = "INSERT INTO Customersdetail VALUES('" + name + "','" + relationOf + "'," + phoneNo + ",'" + idProofNo + "','" + address + "','" + gender + "',1,"+LoginMasterId+")";
            //getting the max value and inserting in the article sold table having the reference of customer ID
            //query = query + "SELECT MAX(CustomerDetailsId) FROM CustomerDetails";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteScalar();
            conn.Close();
        }

        public void UpdateCustomerDetails(int CurrentFormNumber, string name, string relationOf, double phoneNo, String idProof, String address, string gender)
        {
            string query = string.Empty;
            DataTable dtLoginData = new DataTable();
            query = "UPDATE Customersdetail SET Name='" + name + "' ,RelationName='" + relationOf + "',MobileNo=" + phoneNo + ",IdProofNo='" + idProof + "',Address='" + address + "',Gender='" + gender + "' WHERE  CustomerdetailsId=" + CurrentFormNumber;
            //query = "INSERT INTO Customerdetails VALUES('" + name + "','" + relationOf + "'," + phoneNo + ",'" + adharNo + "','" + address + "',1)";
            //getting the max value and inserting in the article sold table having the reference of customer ID
            //query = query + "SELECT MAX(CustomerDetailsId) FROM CustomerDetails";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable GetExpireShortFall(int loginMasterId)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Proc_ExpireShortFall", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@param", loginMasterId);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            return dt;
        }

        public DataTable InsertSoldArticles(int currentFormNo, string ArticleDescription, decimal quantity, decimal grossWeight, decimal netWeight)
        {
            string query = string.Empty;
            DataTable dtSoldArticles = new DataTable();

            query = "INSERT INTO SoldArticle VALUES(" + currentFormNo + ",'" + ArticleDescription + "'," + quantity + "," + grossWeight + "," + netWeight + ",1)";
            query = query + "SELECT ROW_NUMBER() over (ORDER BY SoldArticleId) AS SlNo,SoldArticleId,ArticleDescription,quantity,grossWeight,netWeight FROM SoldArticle WHERE CustomerDetailsId=" + currentFormNo;
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dtSoldArticles);
            conn.Close();
            da.Dispose();
            return dtSoldArticles;
        }

        public DataTable DeleteArticles(int soldArticleId, int currentFormNo)
        {
            string query = string.Empty;
            DataTable dtSoldArticles = new DataTable();

            query = "delete from soldarticle where SoldArticleId=" + soldArticleId;
            query = query + "SELECT ROW_NUMBER() over (ORDER BY SoldArticleId) AS SlNo,SoldArticleId,ArticleDescription,quantity,grossWeight FROM SoldArticle WHERE CustomerDetailsId=" + currentFormNo;
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dtSoldArticles);
            conn.Close();
            da.Dispose();
            return dtSoldArticles;
        }
        public void InsertTotalArticelValue(int currentFormNumber, double totalAmount, decimal rateOfIntrest,
            decimal periodOfExpire, string name, string relationOf, double phoneNo, string idProof,
            string address, string gender, string date)
        {
            string query = string.Empty;
            UpdateCustomerDetails(currentFormNumber, name, relationOf, phoneNo, idProof, address, gender);
            int articelValue = CheckArticelValue(currentFormNumber);
            if (articelValue == 0)
            {
                query = "INSERT INTO TotalArticelVaule VALUES(" + currentFormNumber + "," + totalAmount + ","
                    + rateOfIntrest + "," + periodOfExpire + ",'" + date + "',1)";
            }
            else
            {
                query = "UPDATE TotalArticelVaule SET TotalAmount=" + totalAmount +
                    ",RateOfIntrest=" + rateOfIntrest + ",PeriodOfExpire=" + periodOfExpire + ",LoanDate='" + date + "'"
                    + " WHERE TotalArticelVauleId=" + articelValue;
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int CheckArticelValue(int currentFormNumber)
        {
            try
            {
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append(" IF EXISTS(SELECT 0 FROM TotalArticelVaule WHERE CustomerDetailsId=" + currentFormNumber + ") ");
                queryBuilder.Append(" BEGIN ");
                queryBuilder.Append(" SELECT TotalArticelVauleId FROM TotalArticelVaule WHERE CustomerDetailsId =" + currentFormNumber);
                queryBuilder.Append(" END ");
                queryBuilder.Append(" ELSE ");
                queryBuilder.Append(" BEGIN ");
                queryBuilder.Append(" SELECT 0 ");
                queryBuilder.Append(" END ");
                string query = Convert.ToString(queryBuilder);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
            finally
            {
                conn.Close();
            }
        }

        public DataSet PrintPreview(int customerNo)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("Proc_PrintPreview", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@param", customerNo);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(ds);
            da.Dispose();
            conn.Close();
            return ds;
        }

        public DataTable Search(string data)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Proc_Search", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@param", data);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            return dt;
        }

        public DataSet SearchDetail(int customerId)
        {
            DataSet dsCustomerDetail = new DataSet();
            SqlCommand cmd = new SqlCommand("Proc_SearchDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@param", customerId);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsCustomerDetail);
            da.Dispose();
            conn.Close();
            return dsCustomerDetail;
        }

        public void InsertRenewDetail(int formNumber, string renewDate, decimal amount)
        {
            string query = string.Empty;
            query = "INSERT INTO RenewedDetails VALUES(" + amount + "," + formNumber + ",'" + renewDate + "',1)";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void InsertCloseDetail(int formNumber, string closedDate, decimal payableAmount)
        {
            string query = string.Empty;
            query = "INSERT INTO CloseDetails VALUES(" + formNumber + ",'" + closedDate + "','" + payableAmount + "',1)";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
