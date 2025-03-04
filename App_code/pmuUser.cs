using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for pmuUser
/// </summary>
public class pmuUser
{
    public int Sno { get; set; }
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

    public pmuUser()
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

            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connetionString;
    }
    public DataSet ViewMaxUserUniqueId()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMaxUserUniqueId", cnn))
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

    public int AddUserLogin(pmuUser Ulogin)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddUserLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@Name", Ulogin.Name));
                command.Parameters.Add(
                    new SqlParameter("@EmailId", Ulogin.EmailId));
                command.Parameters.Add(
                    new SqlParameter("@MobileNo", Ulogin.MobileNo));
                command.Parameters.Add(
                    new SqlParameter("@Department", Ulogin.Department));
                command.Parameters.Add(
                    new SqlParameter("@Designation", Ulogin.Designation));
                command.Parameters.Add(
                    new SqlParameter("@UserName", Ulogin.UserName));
                command.Parameters.Add(
                    new SqlParameter("@Password", Ulogin.Password));
                command.Parameters.Add(
                    new SqlParameter("@Active", Ulogin.Active));
                command.Parameters.Add(
                    new SqlParameter("@AddedBy", Ulogin.CreatedBy));
                command.Parameters.Add(
                    new SqlParameter("@AddedDate", Ulogin.CreatedDate));
                command.Parameters.Add(
                   new SqlParameter("@UpdatedBy", Ulogin.UpdatedBy));
                command.Parameters.Add(
                    new SqlParameter("@UpdatedDate", Ulogin.UpdatedDate));
                command.Parameters.Add(
                   new SqlParameter("@UniqueId", Ulogin.UniqueId));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewUserList(string dept)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewUserList", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                   new SqlParameter("@dept", dept));
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

    public DataSet ViewUserById(string Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewUserById", cnn))
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

    public DataSet ViewUnameExist(string Uname, string strmode, string sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewUnameExist", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@UserName", Uname));
                command.Parameters.Add(
                    new SqlParameter("@flag", strmode));
                command.Parameters.Add(
                   new SqlParameter("@sno", Convert.ToInt32(sno)));
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

    public DataSet ViewUserExistForDesignation(string design, string strmode, string sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewUserExistForDesignation", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@design", design));
                command.Parameters.Add(
                   new SqlParameter("@flag", strmode));
                command.Parameters.Add(
                   new SqlParameter("@sno", Convert.ToInt32(sno)));
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
    public int UpdateUserLogin(pmuUser Ulogin)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateUserLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@Name", Ulogin.Name));
                command.Parameters.Add(
                    new SqlParameter("@EmailId", Ulogin.EmailId));
                command.Parameters.Add(
                    new SqlParameter("@MobileNo", Ulogin.MobileNo));
                command.Parameters.Add(
                    new SqlParameter("@Department", Ulogin.Department));
                command.Parameters.Add(
                    new SqlParameter("@Designation", Ulogin.Designation));
                command.Parameters.Add(
                    new SqlParameter("@UserName", Ulogin.UserName));
                command.Parameters.Add(
                    new SqlParameter("@Password", Ulogin.Password));
                command.Parameters.Add(
                   new SqlParameter("@UpdatedBy", Ulogin.UpdatedBy));
                command.Parameters.Add(
                    new SqlParameter("@UpdatedDate", Ulogin.UpdatedDate));
                command.Parameters.Add(
                   new SqlParameter("@Sno", Ulogin.Sno));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeleteUserLogin(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteUserLogin", cnn))
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