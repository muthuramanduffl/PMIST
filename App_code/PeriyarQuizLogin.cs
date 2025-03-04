using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

/// <summary>
/// Summary description for etihadlogin
/// </summary>
public class PeriyarQuizLogin
{
    public int ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool Status { get; set; }
    public DateTime PostedDateTime { get; set; }
    public string PostedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public string UpdatedBy { get; set; }
   public string EmailId { get; set; }
    public PeriyarQuizLogin()
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

            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["Periyar1000English"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connetionString;
    }
   
    
    public DataSet SpPeriyarQuizAdminLogin(string UserName,string stPassword)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SpLogin", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@UserName", UserName));
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
    public DataSet ViewUserName(string UserName)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("spViewUserName", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@UserName", UserName));
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
    public DataSet viewLoginByEmail(string EmailId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("spviewLoginByEmail", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@EmailID", EmailId));
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
    public int GetUserId()
    {
        int strAdminID = 0;
        try
        {


            if (HttpContext.Current.Session["Sno"] != null)
            {
                strAdminID = Convert.ToInt32(HttpContext.Current.Session["Sno"]);

            }
            else
            {
                if (HttpContext.Current.Request.Cookies["LOGIN"] != null)
                {
                    HttpCookie Logincookie = HttpContext.Current.Request.Cookies["LOGIN"];
                    strAdminID = Convert.ToInt32(Logincookie["Sno"]);
                }
            }
        }
        catch
        {
        }
        return strAdminID;
    }
   
    public string GetUserName()
    {
        string strUserName = string.Empty;
        try
        {


            if (HttpContext.Current.Session["UserName"] != null)
            {
                strUserName = Convert.ToString(HttpContext.Current.Session["UserName"]);

            }
            else
            {
                if (HttpContext.Current.Request.Cookies["LOGIN"] != null)
                {
                    HttpCookie Logincookie = HttpContext.Current.Request.Cookies["LOGIN"];
                    strUserName = Logincookie["UserName"];
                }
            }
        }
        catch
        {
        }
        return strUserName;
    }
    public int ChangePassword(int Id, string Password)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("spChangePassword", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@NewPassword", Password));
                command.Parameters.Add(
                new SqlParameter("@Sno", Id));
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