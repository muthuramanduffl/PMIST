using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for MarathonRegistration
/// </summary>
public class MarathonRegistration
{
    public string Name { get; set; }
    public string fname { get; set; }
    public string ClassStd { get; set; }
    public string Institution { get; set; }
    public string DOB { get; set; }
    public string MobileNo { get; set; }
    public string WhatsAppNo { get; set; }
    public string EmailId { get; set; }
    public string Address { get; set; }
    public string Pincode { get; set; }
    public string Category { get; set; }
    public string Tshirtsize { get; set; }
    public DateTime regDate { get; set; }
    public string Password { get; set; }
    public string Pgsource { get; set; }

    public MarathonRegistration()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string GetSqlConnection()
    {
        string connectionString = null;
        try
        {

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connectionString;
    }

    public DataSet ViewMarathonRegistrationByEmailID(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMarathonRegistrationByEmailID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@EmailID", stEmailId));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public int AddMarathonRegistration(MarathonRegistration reg)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        int RegID = 0;
        try
        {
            if (reg != null)
            {
                using (SqlCommand command = new SqlCommand("AddMarathonRegistration", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(
                        new SqlParameter("@Name", reg.Name));
                    command.Parameters.Add(
                        new SqlParameter("@fname", reg.fname));
                    command.Parameters.Add(
                        new SqlParameter("@Class", reg.ClassStd));
                    command.Parameters.Add(
                        new SqlParameter("@InstitutionName", reg.Institution));
                    command.Parameters.Add(
                        new SqlParameter("@DOB", reg.DOB));
                    command.Parameters.Add(
                        new SqlParameter("@MobileNo", reg.MobileNo));
                    command.Parameters.Add(
                        new SqlParameter("@WhatsAppNo", reg.WhatsAppNo));
                    command.Parameters.Add(
                        new SqlParameter("@EmailId", reg.EmailId));
                    command.Parameters.Add(
                        new SqlParameter("@Password", reg.Password));
                    command.Parameters.Add(
                        new SqlParameter("@Address", reg.Address));
                    command.Parameters.Add(
                        new SqlParameter("@Pincode", reg.Pincode));
                    command.Parameters.Add(
                        new SqlParameter("@Categories", reg.Category));
                    command.Parameters.Add(
                        new SqlParameter("@Tshirtsize", reg.Tshirtsize));
                    command.Parameters.Add(
                        new SqlParameter("@RegistrationDate", reg.regDate));
                    command.Parameters.Add(
                        new SqlParameter("@Pgsource", reg.Pgsource));

                    command.Parameters.Add("@ID", SqlDbType.Int);
                    command.Parameters["@ID"].Direction = ParameterDirection.Output;

                    rowsAffected = command.ExecuteNonQuery();
                    RegID = Convert.ToInt32(command.Parameters["@ID"].Value);

                }
                cnn.Close();
            }
        }

        catch (Exception ex)
        {
        }
        return RegID;
    }

    public int InsertMarathonPayment(int ID, string Fees, string transStatus, string clnttxnref, string tpslbankcd, string tpsltxnid, string transerrmsg)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("spMarathonPayment", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RegId", ID));
                command.Parameters.Add(new SqlParameter("@Fees", Fees));
                command.Parameters.Add(new SqlParameter("@PaymentDateTime", Utility.IndianTime));
                command.Parameters.Add(new SqlParameter("@TransactionStatus", transStatus));
                command.Parameters.Add(new SqlParameter("@ClientTxnRef", clnttxnref));
                command.Parameters.Add(new SqlParameter("@TpslBankCd", tpslbankcd));
                command.Parameters.Add(new SqlParameter("@TpsltxnId", tpsltxnid));
                command.Parameters.Add(new SqlParameter("@TransErrorMessage", transerrmsg));
                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int UpdateChestNo(string chestNo, int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("spMarathonUpdateChestNo", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Sno", ID));
                command.Parameters.Add(new SqlParameter("@chestNo", chestNo));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewMarathonLogin(string stEmail, string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMarathonLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@EmailID", stEmail));
                command.Parameters.Add(new SqlParameter("@Password", stPassword));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dsNews);

            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public DataTable spMarathonPaymentIsSuccess(int stRegID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataTable dsNews = new DataTable();
        try
        {
            using (SqlCommand command = new SqlCommand("spMarathonPaymentIsSuccess", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RegID", stRegID));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
}