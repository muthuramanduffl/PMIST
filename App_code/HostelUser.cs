using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for pmuUser
/// </summary>
public class HostelUser
{
    public int Sno { get; set; }
    public string Role { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string MobileNo { get; set; }
    public string Department { get; set; }
    public string Designation { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool Active { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string UniqueId { get; set; }

    public HostelUser()
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

    public DataSet ViewValidAdminLoginHostelmgmt(string stUserName, string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidAdminLoginHostelmgmt", cnn))
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
    public int AddHostelUserLogin(HostelUser user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddHostelUserLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                  new SqlParameter("@Role", user.Role));
                command.Parameters.Add(
                    new SqlParameter("@Name", user.Name));
                command.Parameters.Add(
                    new SqlParameter("@EmailId", user.EmailId));
                command.Parameters.Add(
                    new SqlParameter("@MobileNo", user.MobileNo));
                command.Parameters.Add(
                    new SqlParameter("@UserName", user.UserName));
                command.Parameters.Add(
                    new SqlParameter("@Password", user.Password));
                command.Parameters.Add(
                    new SqlParameter("@Active", user.Active));
                command.Parameters.Add(
                    new SqlParameter("@AddedBy", user.CreatedBy));
                command.Parameters.Add(
                    new SqlParameter("@AddedDate", user.CreatedDate));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewHostelUserList()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelUserList", cnn))
            {
                cnn.Open();
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

    public DataSet ViewHostelUserById(string Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelUserById", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@Sno", Sno));
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

    public DataSet ViewHostelUserExist(string Uname)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelUserExist", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@uname", Uname));
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


    public int UpdateHostelUserLogin(HostelUser user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateHostelUserLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                  new SqlParameter("@Role", user.Role));
                command.Parameters.Add(
                    new SqlParameter("@Name", user.Name));
                command.Parameters.Add(
                    new SqlParameter("@EmailId", user.EmailId));
                command.Parameters.Add(
                    new SqlParameter("@MobileNo", user.MobileNo));
                command.Parameters.Add(
                    new SqlParameter("@UserName", user.UserName));
                command.Parameters.Add(
                    new SqlParameter("@Password", user.Password));
                command.Parameters.Add(
                   new SqlParameter("@Sno", user.Sno));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeleteHostelUserLogin(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteHostelUserLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@Sno", Sno));

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