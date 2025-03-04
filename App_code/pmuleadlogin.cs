using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

/// <summary>
/// Summary description for Album
/// </summary>
public class pmuleadlogin
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool Active { get; set; }
    public string Role { get; set; }
    public string UniqueId { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public string MobileNo { get; set; }
    public string EmailId { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string UpdatedBy { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public pmuleadlogin()
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
   
    public DataSet ViewValidTeleCounselorLogin(string stUserName,string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidTeleCounselorLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@UserName", stUserName));
                command.Parameters.Add(
                                      new SqlParameter("@Password", stPassword));
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
    public DataSet ViewValidTeamLeadLogin(string stUserName, string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidTeamLeadLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@UserName", stUserName));
                command.Parameters.Add(
                                      new SqlParameter("@Password", stPassword));
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
    public int AddTeamLead(pmuleadlogin users)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddTeamLead", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@Name", users.UserName));
                command.Parameters.Add(
             new SqlParameter("@EmailId", users.EmailId));
                command.Parameters.Add(
            new SqlParameter("@MobileNo", users.MobileNo));
                command.Parameters.Add(
           new SqlParameter("@CounsellorId", users.UniqueId));
                command.Parameters.Add(
                  new SqlParameter("@Active", users.Active));
                command.Parameters.Add(
                 new SqlParameter("@AddedBy", users.CreatedBy));
                command.Parameters.Add(
                 new SqlParameter("@AddedDate", users.CreatedDate));
                command.Parameters.Add(
                   new SqlParameter("@UpdatedBy", users.UpdatedBy));
                command.Parameters.Add(
                  new SqlParameter("@UpdatedDate", users.UpdatedDate));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddLeadLogin(pmuleadlogin login)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddLeadLogin", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@UserName", login.UserName));
                command.Parameters.Add(
             new SqlParameter("@Name", login.Name));
                command.Parameters.Add(
             new SqlParameter("@Password", login.Password));
                command.Parameters.Add(
            new SqlParameter("@Active", login.Active));
                command.Parameters.Add(
           new SqlParameter("@Role", login.Role));
                command.Parameters.Add(
                  new SqlParameter("@UniqueId", login.UniqueId));
                command.Parameters.Add(
                 new SqlParameter("@CreatedBy", login.CreatedBy));
                command.Parameters.Add(
                 new SqlParameter("@CreatedDate", login.CreatedDate));
                command.Parameters.Add(
                   new SqlParameter("@EmailId", login.EmailId));
                command.Parameters.Add(
                   new SqlParameter("@Department", login.Department));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewLeadLogin()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
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
    public DataSet ViewMaxUniqueId(string stRole)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMaxUniqueId", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                     new SqlParameter("@Role", stRole));
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
    public int UpdatePassword(pmuleadlogin users)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdatePassword", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@Sno", users.Id));
                command.Parameters.Add(
             new SqlParameter("@Password", users.Password));
                command.Parameters.Add(
            new SqlParameter("@UpdatedDate", users.UpdatedDate));
                command.Parameters.Add(
           new SqlParameter("@UpdatedBy", users.UpdatedBy));
                
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
}