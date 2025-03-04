using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for GrievUser
/// </summary>
public class StaffGrievUserlogin
{
    public int id { get; set; }
    public string Role { get; set; }
    public string Category { get; set; }
    public string EmpId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Department { get; set; }
    public string FacultyPost { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDate { get; set; }

    public StaffGrievUserlogin()
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

    public DataSet ViewValidAdminLoginStaffGriev(string stUserName, string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidAdminLoginStaffGriev", cnn))
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

    public DataSet ViewValidTeamLoginGriev(string stUserName, string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidTeamLoginGriev", cnn))
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
    public int AddStaffGrievUser(StaffGrievUserlogin user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddStaffGrievUser", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                  new SqlParameter("@Role", user.Role));
                command.Parameters.Add(
                  new SqlParameter("@Category", user.Category));
                  command.Parameters.Add(
                    new SqlParameter("@EmpId", user.EmpId));
                command.Parameters.Add(
                    new SqlParameter("@Name", user.Name));
                command.Parameters.Add(
                    new SqlParameter("@Email", user.Email));
                command.Parameters.Add(
                    new SqlParameter("@Mobile", user.Mobile));
                command.Parameters.Add(
                   new SqlParameter("@Department", user.Department));
                command.Parameters.Add(
                   new SqlParameter("@FacultyPost", user.FacultyPost));
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

    public DataSet ViewStaffGrievUserList()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStaffGrievUserList", cnn))
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

    public DataSet ViewStaffGrievUserById(string Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStaffGrievUserById", cnn))
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

    public DataSet ViewStaffGrievUserExist(string Uname, string EmpId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStaffGrievUserExist", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@uname", Uname));
                command.Parameters.Add(
                    new SqlParameter("@EmpId", EmpId));
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

    public int UpdateStaffGrievUser(StaffGrievUserlogin user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateStaffGrievUser", cnn))
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

    public int DeleteStaffGrievUser(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteStaffGrievUser", cnn))
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
