using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for GrievUser
/// </summary>
public class CareerUserlogin
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

    public CareerUserlogin()
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

    public DataSet ViewValidAdminLoginCareerCounsel(string stUserName, string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidAdminLoginCareerCounsel", cnn))
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
    public int AddCareerGrievUser(CareerUserlogin user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddCareerGrievUser", cnn))
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

    public DataSet ViewCareerCounselRegUserList()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCareerCounselRegUserList", cnn))
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

    public int UpdateCareerGrievUser(CareerUserlogin user)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateCareerGrievUser", cnn))
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

    public int DeleteCareerGrievUser(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteCareerGrievUser", cnn))
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

    public DataSet ViewTeamCC()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTeamCC", cnn))
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

    public DataSet ViewCCUserById(string Id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCCUserById", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@Id", Id));
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
    public DataSet ViewValidTeamCCLogin(string stUserName, string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidTeamCCLogin", cnn))
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
    public string GetTeamId()
    {
        string strFacultyId = string.Empty;
        try
        {
            if (HttpContext.Current.Session["CCQTeamID"] != null)
            {
                strFacultyId = Convert.ToString(HttpContext.Current.Session["CCQTeamID"]);
            }
            else
            {
                if (HttpContext.Current.Request.Cookies["CCQTeamLOGIN"] != null)
                {
                    HttpCookie Logincookie = HttpContext.Current.Request.Cookies["CCQTeamLOGIN"];
                    strFacultyId = Logincookie["CCQTeamID"];
                }
            }
        }
        catch
        {
        }
        return strFacultyId;
    }
    public string GetTeamEmail()
    {
        string strFacultyId = string.Empty;
        try
        {
            if (HttpContext.Current.Session["CCQTeamEmailId"] != null)
            {
                strFacultyId = Convert.ToString(HttpContext.Current.Session["CCQTeamEmailId"]);
            }
            else
            {
                if (HttpContext.Current.Request.Cookies["CCQTeamLOGIN"] != null)
                {
                    HttpCookie Logincookie = HttpContext.Current.Request.Cookies["CCQTeamLOGIN"];
                    strFacultyId = Logincookie["CCQTeamEmailId"];
                }
            }
        }
        catch
        {
        }
        return strFacultyId;
    }

    public string GetTeamName()
    {
        string strFacultyId = string.Empty;
        try
        {
            if (HttpContext.Current.Session["CCQTeamUserName"] != null)
            {
                strFacultyId = Convert.ToString(HttpContext.Current.Session["CCQTeamUserName"]);
            }
            else
            {
                if (HttpContext.Current.Request.Cookies["CCQTeamLOGIN"] != null)
                {
                    HttpCookie Logincookie = HttpContext.Current.Request.Cookies["CCQTeamLOGIN"];
                    strFacultyId = Logincookie["CCQTeamUserName"];
                }
            }
        }
        catch
        {
        }
        return strFacultyId;
    }
    public DataSet ViewCareerGrievUserById(string Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCareerGrievUserById", cnn))
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

    public DataSet ViewCareerGrievUserExist(string Uname)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCareerGrievUserExist", cnn))
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
    public DataSet ViewCareerGrievUserList()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCareerGrievUserList", cnn))
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

    public DataSet ViewCareerCounselRegUserListFilter(string stcity, string stdegree, string stsrchval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCareerCounselRegUserListFilter", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@City", stcity));
                command.Parameters.Add(
                                      new SqlParameter("@Degree", stdegree));
                command.Parameters.Add(
                                      new SqlParameter("@srchval", stsrchval));
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
