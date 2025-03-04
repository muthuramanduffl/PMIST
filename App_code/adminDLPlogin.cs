using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for adminDLPlogin
/// </summary>
public class adminDLPlogin
{
    public adminDLPlogin()
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
    public DataSet ViewDLPStudentLogin(string stuname, string stpwd)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPStudentLogin", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Uname", stuname));
                cmd.Parameters.Add(new SqlParameter("@Pwd", stpwd));
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public DataSet ViewDLPFacultyLogin(string stuname, string stpwd)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPFacultyLogin", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Uname", stuname));
                cmd.Parameters.Add(new SqlParameter("@Pwd", stpwd));
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public string GetLoginUserName()
    {
        string strname = string.Empty;
        try
        {
            if (HttpContext.Current.Session["DLPUserName"] != null)
            {
                strname = Convert.ToString(HttpContext.Current.Session["DLPUserName"]);
            }
            else
            {
                if (HttpContext.Current.Request.Cookies["DLPLOGIN"] != null)
                {
                    HttpCookie Logincookie = HttpContext.Current.Request.Cookies["DLPLOGIN"];
                    strname = Logincookie["DLPUserName"];
                }
            }
        }
        catch
        {
        }
        return strname;
    }

    public DataSet ViewDLPAdminLogin(string stuname, string stpwd)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPAdminLogin", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Uname", stuname));
                cmd.Parameters.Add(new SqlParameter("@Pwd", stpwd));
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