using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class UserDetails
{
    public int Sno { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNo { get; set; }
    public string EmailId { get; set; }
    public string Gender { get; set; }
    public string Password { get; set; }
    public bool Active { get; set; }
    public bool OTPstatus { get; set; }
    public DateTime RegisteredDate { get; set; }
    public string DOB { get; set; }
    public string WhatsAppNo { get; set; }
    public string EmerContactPerson { get; set; }
    public string EmerContactPersonName { get; set; }
    public string EmerContactPersonNo { get; set; }
    public string EmailOTP { get; set; }
    public string MobileOTP { get; set; }
    public string AddedBy { get; set; }
    public string LastUpdatedBy { get; set; }
    public UserDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string GetSqlConnection()
    {
        string connetionString = null;
        try
        {

            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMULead"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connetionString;
    }
    public int AddUserDetails(UserDetails user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddUserDetails", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@FirstName", user.FirstName));
                command.Parameters.Add(
                   new SqlParameter("@LastName", user.LastName));
                command.Parameters.Add(
                 new SqlParameter("@PhoneNo", user.PhoneNo));
                command.Parameters.Add(
             new SqlParameter("@EmailId", user.EmailId));
                command.Parameters.Add(
                 new SqlParameter("@Gender", user.Gender));
                command.Parameters.Add(
                 new SqlParameter("@Password", user.Password));
                command.Parameters.Add(
               new SqlParameter("@Active", user.Active));
                command.Parameters.Add(
              new SqlParameter("@RegisteredDate", user.RegisteredDate));
                command.Parameters.Add(
               new SqlParameter("@DOB", user.DOB));
                command.Parameters.Add(
              new SqlParameter("@WhatsAppNo", user.WhatsAppNo));
                command.Parameters.Add(
               new SqlParameter("@EmerContactPerson", user.EmerContactPerson));
                command.Parameters.Add(
               new SqlParameter("@EmerContactPersonName", user.EmerContactPersonName));
                command.Parameters.Add(
               new SqlParameter("@EmerContactPersonNo", user.EmerContactPersonNo));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddAdminUserDetails(UserDetails user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddAdminUserDetails", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@FirstName", user.FirstName));
                command.Parameters.Add(
                   new SqlParameter("@LastName", user.LastName));
                command.Parameters.Add(
                 new SqlParameter("@PhoneNo", user.PhoneNo));
                command.Parameters.Add(
             new SqlParameter("@EmailId", user.EmailId));
                command.Parameters.Add(
                 new SqlParameter("@Gender", user.Gender));
                command.Parameters.Add(
                 new SqlParameter("@Password", user.Password));
                command.Parameters.Add(
               new SqlParameter("@Active", user.Active));
                command.Parameters.Add(
              new SqlParameter("@RegisteredDate", user.RegisteredDate));
                command.Parameters.Add(
               new SqlParameter("@DOB", user.DOB));
                command.Parameters.Add(
              new SqlParameter("@WhatsAppNo", user.WhatsAppNo));
                command.Parameters.Add(
               new SqlParameter("@EmerContactPerson", user.EmerContactPerson));
                command.Parameters.Add(
               new SqlParameter("@EmerContactPersonName", user.EmerContactPersonName));
                command.Parameters.Add(
               new SqlParameter("@EmerContactPersonNo", user.EmerContactPersonNo));
                command.Parameters.Add(
              new SqlParameter("@AddedBy", "Admin"));
                command.Parameters.Add(
             new SqlParameter("@LastUpdatedBy", user.LastUpdatedBy));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateUserDetails(UserDetails user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateUserDetails", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@FirstName", user.FirstName));
                command.Parameters.Add(
                   new SqlParameter("@LastName", user.LastName));
                command.Parameters.Add(
                 new SqlParameter("@PhoneNo", user.PhoneNo));
                command.Parameters.Add(
             new SqlParameter("@EmailId", user.EmailId));
                command.Parameters.Add(
                 new SqlParameter("@Gender", user.Gender));
                command.Parameters.Add(
                 new SqlParameter("@Password", user.Password));
                command.Parameters.Add(
               new SqlParameter("@Sno", user.Sno));
                command.Parameters.Add(
              new SqlParameter("@DOB", user.DOB));
                command.Parameters.Add(
             new SqlParameter("@WhatsAppNo", user.WhatsAppNo));
                command.Parameters.Add(
               new SqlParameter("@EmerContactPerson", user.EmerContactPerson));
                command.Parameters.Add(
               new SqlParameter("@EmerContactPersonName", user.EmerContactPersonName));
                command.Parameters.Add(
               new SqlParameter("@EmerContactPersonNo", user.EmerContactPersonNo));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewLoginDetails(string stUserName,string stPassword)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewLoginDetails", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
              new SqlParameter("@UserName", stUserName));
                command.Parameters.Add(
                   new SqlParameter("@Password", stPassword));
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
   
    public DataSet ViewUserDetailsByEmailId(string stEmailId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewUserDetailsByEmailId", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@EmailId", stEmailId));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);


            }
            cnn.Close();

        //}
        //catch (Exception ex)
        //{
        //}
        return ds;
    }

    public DataSet ViewUserDetailsByMobileNo(string stPhoneNo)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
        cnn.Open();
        using (SqlCommand command = new SqlCommand("ViewUserDetailsByMobileNo", cnn))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
            new SqlParameter("@PhoneNo", stPhoneNo));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);


        }
        cnn.Close();

        //}
        //catch (Exception ex)
        //{
        //}
        return ds;
    }
    public DataSet ViewUserDetailsByUserId(string stUserId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
        cnn.Open();
        using (SqlCommand command = new SqlCommand("ViewUserDetailsByUserId", cnn))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
            new SqlParameter("@UserId", stUserId));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);


        }
        cnn.Close();

        //}
        //catch (Exception ex)
        //{
        //}
        return ds;
    }
    public DataSet ViewClientSearchCriteria(string stGender,string stClientId,string stClientEmail,string stFromDate,string stToDate)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
        using (SqlCommand command = new SqlCommand("ViewClientSearchCriteria", cnn))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
            new SqlParameter("@Gender", stGender));
                command.Parameters.Add(
            new SqlParameter("@ClientId", stClientId));
                command.Parameters.Add(
            new SqlParameter("@ClientEmail", stClientEmail));
                command.Parameters.Add(
            new SqlParameter("@FromDate", stFromDate));
                command.Parameters.Add(
            new SqlParameter("@ToDate", stToDate));
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
    public DataSet ViewAdminGlobalClientSessionsSearchCriteria(string SearchCriteria)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAdminGlobalClientSessionsSearchCriteria", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@SearchCriteria", SearchCriteria));
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
    public DataSet ViewAllClientDetails()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllClientDetails", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;              
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
    public DataSet ViewAllClientDetailsByName()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllClientDetailsByName", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
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
    public int AddPasswordReset(string stResetId, string stTHID, string stResetDate)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("spUserAddPasswordReset", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@ResetID", stResetId));
                command.Parameters.Add(
                   new SqlParameter("@AdminID", stTHID));
                command.Parameters.Add(
                 new SqlParameter("@ResetDate", stResetDate));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeletePasswordReset(string stResetId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("spUserDeletePasswordReset", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@ResetID", stResetId));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewPasswordResetByID(string stResetId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewUserPasswordResetByID", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ResetID", stResetId));
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
    public int ChangePassword(string stPassword, string stsno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("spUserChangePassword", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@Password", stPassword));
                command.Parameters.Add(
                   new SqlParameter("@Sno", stsno));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewAdminClientSearchCriteria(string stClientId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAdminClientSearchCriteria", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ClientId", stClientId));
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
    public int UpdateEmailOTP(string stEmailId, string stEmailOTP,DateTime time_Stamp, bool status)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateEmailOTP", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@EmailOTP", stEmailOTP));
                command.Parameters.Add(
               new SqlParameter("@EmailId", stEmailId));
                command.Parameters.Add(
               new SqlParameter("@time_Stamp", time_Stamp));
                command.Parameters.Add(
              new SqlParameter("@OTPstatus", status));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

        public int updateEmailOTPstatus(string stRegNo, bool status)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("updateEmailOTPstatus", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@RegNo", stRegNo));
                command.Parameters.Add(
              new SqlParameter("@OTPstatus", status));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateMobileOTP(string stMobileNo, string stMobileOTP)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateMobileOTP", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@MobileOTP", stMobileOTP));
                command.Parameters.Add(
               new SqlParameter("@MobileNo", stMobileNo));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewLoginDetailsByEmailOTP(string stRegNo,string stEmailOTP)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewLoginDetailsByEmailOTP", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@RegNo", stRegNo));
                command.Parameters.Add(
               new SqlParameter("@EmailOTP", stEmailOTP));
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
    public DataSet ViewLoginDetailsByMobileOTP(string stUserName, string stEmailOTP)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewLoginDetailsByMobileOTP", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@UserName", stUserName));
                command.Parameters.Add(
               new SqlParameter("@MobileOTP", stEmailOTP));
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
    public DataSet ViewNewAllClientDetailsByTherapy(string stThid)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewNewAllClientDetailsByTherapy", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@THID", stThid));
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

    public DataSet ViewRegNameByEmailId(string stEmailId)
    {
        string connectionString = null;
        SqlConnection cnn;
        connectionString = GetSqlConnection();
        cnn = new SqlConnection(connectionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegNameByEmailId", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@email", stEmailId));
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

    public DataSet ViewEmailByEmailId(string stRegNo)
    {
        string connectionString = null;
        SqlConnection cnn;
        connectionString = GetSqlConnection();
        cnn = new SqlConnection(connectionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewEmailByEmailId", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RegNo", stRegNo));
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

}