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
public class pmuLogin
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
    public pmuLogin()
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
    public int AddUsers(List<pmuLogin> LstUsers)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstUsers != null && LstUsers.Count > 0)
            {
                foreach (pmuLogin login in LstUsers)
                {
                    using (SqlCommand command = new SqlCommand("spAddUsers", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                       new SqlParameter("@UserName", login.Username.Trim()));
                        command.Parameters.Add(
                           new SqlParameter("@Password", login.Password));
                        command.Parameters.Add(
                           new SqlParameter("@Status", login.Status));                  
                        command.Parameters.Add(
                      new SqlParameter("@CreatedBy", login.PostedBy));
                        command.Parameters.Add(
                          new SqlParameter("@CreatedDate", login.PostedDateTime));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", login.UpdatedBy));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDate", login.UpdatedDateTime));
                        command.Parameters.Add(
                        new SqlParameter("@EmailId", login.EmailId));
                        
                          rowsAffected = command.ExecuteNonQuery();


                    }
                    cnn.Close();
                }


            }
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateUsers(List<pmuLogin> LstUsers, int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstUsers != null && LstUsers.Count > 0)
            {
                foreach (pmuLogin login in LstUsers)
                {
                    using (SqlCommand command = new SqlCommand("spUpdateUsers", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                      new SqlParameter("@UserName", login.Username.Trim()));
                        command.Parameters.Add(
                           new SqlParameter("@Password", login.Password));
                        command.Parameters.Add(
                           new SqlParameter("@Status", login.Status));
                               command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", login.UpdatedBy));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDate", login.UpdatedDateTime));
                        command.Parameters.Add(
                        new SqlParameter("@Sno", ID));
                        command.Parameters.Add(
                       new SqlParameter("@EmailId", login.EmailId));
                        rowsAffected = command.ExecuteNonQuery();


                    }
                    cnn.Close();
                }


            }
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeleteUsers(int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsDetail = new DataSet();
        int rowsAffected = 0;
        try
        {
            if (ID > 0)
            {

                cnn.Open();
                using (SqlCommand command = new SqlCommand("spDeleteLogin", cnn))
                {

                    // Add new SqlParameter to the command.

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@Sno", ID));
                    rowsAffected = command.ExecuteNonQuery();


                }
                cnn.Close();

            }
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateStatus(int ID,string updatedBy)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateLoginStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Sno", ID));
                command.Parameters.Add(
               new SqlParameter("@UpdatedBy", updatedBy));
                command.Parameters.Add(
               new SqlParameter("@UpdatedDateTime", DateTime.Now));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return rowsAffected;

    }
    public int DeletePaaswordReset(string ID)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("spDeletePasswordReset", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ResetID", ID));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return rowsAffected;

    }
    public int AddPasswordReset(string ResetID,string ResetDate, int Id)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("spAddPasswordReset", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ResetID", ResetID));
                command.Parameters.Add(
               new SqlParameter("@AdminID", Id));
                command.Parameters.Add(
               new SqlParameter("@ResetDate", ResetDate));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return rowsAffected;

    }
    public DataSet ViewLogin()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("spviewLogin", cnn))
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
    public DataSet ViewLoginByID(int ID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("spviewLoginByID", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Sno", ID));
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
    public DataSet ViewPaaswordReset(string ID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("spViewPasswordResetByID", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ResetID", ID));
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