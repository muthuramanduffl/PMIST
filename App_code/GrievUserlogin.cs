using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for GrievUser
/// </summary>
public class GrievUserlogin
{
    public int id { get; set; }
    public string Role { get; set; }
    public string Category { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Department { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDate { get; set; }

    public GrievUserlogin()
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

    public DataSet ViewValidAdminLoginGriev(string stUserName, string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidAdminLoginGriev", cnn))
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

    public DataSet ViewValidFacultyLoginGriev(string stUserName, string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidFacultyLoginGriev", cnn))
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
    public int AddStudGrievUser(GrievUserlogin user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddStudGrievUser", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                  new SqlParameter("@Role", user.Role));
                command.Parameters.Add(
                  new SqlParameter("@Category", user.Category));
                command.Parameters.Add(
                    new SqlParameter("@Name", user.Name));
                command.Parameters.Add(
                    new SqlParameter("@Email", user.Email));
                command.Parameters.Add(
                    new SqlParameter("@Mobile", user.Mobile));
                command.Parameters.Add(
                   new SqlParameter("@Department", user.Department));
                command.Parameters.Add(
                    new SqlParameter("@UserName", user.UserName));
                command.Parameters.Add(
                    new SqlParameter("@Password", user.Password));
                command.Parameters.Add(
                    new SqlParameter("@Active", user.Active));
                command.Parameters.Add(
                    new SqlParameter("@AddedBy", user.AddedBy));
                command.Parameters.Add(
                    new SqlParameter("@AddedDate", user.AddedDate));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewStudGrievUserList()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStudGrievUserList", cnn))
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

    public DataSet ViewStudGrievUserById(string Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStudGrievUserById", cnn))
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

    public DataSet ViewStudGrievUserExist(string Uname)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStudGrievUserExist", cnn))
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

    public int UpdateStudGrievUser(GrievUserlogin user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateStudGrievUser", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                  new SqlParameter("@Role", user.Role));
                command.Parameters.Add(
                  new SqlParameter("@Category", user.Category));
                command.Parameters.Add(
                    new SqlParameter("@Name", user.Name));
                command.Parameters.Add(
                    new SqlParameter("@EmailId", user.Email));
                command.Parameters.Add(
                    new SqlParameter("@MobileNo", user.Mobile));
                command.Parameters.Add(
                   new SqlParameter("@Department", user.Department));
                command.Parameters.Add(
                    new SqlParameter("@UserName", user.UserName));
                command.Parameters.Add(
                    new SqlParameter("@Password", user.Password));
                command.Parameters.Add(
                   new SqlParameter("@Sno", user.id));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeleteStudGrievUser(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteStudGrievUser", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@ID", Sno));

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
