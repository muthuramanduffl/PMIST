using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

/// <summary>
/// Summary description for Mock
/// </summary>
public class Mock
{
    public int Id;
    public string Name;
    public string EmailId;
    public string Mobile;
    public string WhatsAppNo;
    public string Gender;
    public string School;
    public string State;
    public string City;
    public string Subgroup;
    public string Aim;
    public string Medium;
    public string CampaignName;
    public DateTime RegDate;
    public Mock()
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


    public DataSet ChkemailRegistered(string EmailID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewEmailExistMocktest", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(new SqlParameter("@email", EmailID));
                da.Fill(ds);
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }

    public DataSet ChkphonenoRegistered(string phoneno)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMobileNoExistMocktest", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(new SqlParameter("@phoneno", phoneno));
                da.Fill(ds);
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }

    public int AddMockRegistration(Mock moc)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddMockRegistration", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
               
            command.Parameters.Add(new SqlParameter("@name", moc.Name));
            command.Parameters.Add(new SqlParameter("@email", moc.EmailId));
            command.Parameters.Add(new SqlParameter("@phoneno", moc.Mobile));
            command.Parameters.Add(new SqlParameter("@whatsappno", moc.WhatsAppNo));
            command.Parameters.Add(new SqlParameter("@gender", moc.Gender));
            command.Parameters.Add(new SqlParameter("@schoolname", moc.School));
            command.Parameters.Add(new SqlParameter("@state", moc.State));
            command.Parameters.Add(new SqlParameter("@city", moc.City));
            command.Parameters.Add(new SqlParameter("@medium", moc.Medium));
            command.Parameters.Add(new SqlParameter("@subjgroup", moc.Subgroup));
            command.Parameters.Add(new SqlParameter("@reg_date", moc.RegDate));
            command.Parameters.Add(new SqlParameter("@aim", moc.Aim));
            command.Parameters.Add(new SqlParameter("@CampaignName", moc.CampaignName));

            //command.Parameters.Add("@ID", SqlDbType.Int);
            //command.Parameters["@ID"].Direction = ParameterDirection.Output;
            rowsAffected = command.ExecuteNonQuery();
            //RegID = Convert.ToInt32(command.Parameters["@ID"].Value);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet GetLoginDetails(string UserName, string Password)
    {
        string connectionString = null;
        SqlConnection cnn;
        connectionString = GetSqlConnection();
        cnn = new SqlConnection(connectionString);
        DataSet dsDetail = new DataSet();
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMocktestLogin", cnn))
            {
                // Add new SqlParameter to the command.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@email", UserName));
                command.Parameters.Add(
                       new SqlParameter("@pwd", Password));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dsDetail);
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return dsDetail;
    }

    public DataSet GetPwd(string EmailID)
    {
        DataSet ds = new DataSet();
        string connectionString = null;
        SqlConnection cnn;
        connectionString = GetSqlConnection();
        cnn = new SqlConnection(connectionString);
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMocktestPassword", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(new SqlParameter("@email", EmailID));
                da.Fill(ds);
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }

    public void SendMocktestMail(string ToMail, string Subject, string body)
    {
        try
        {
            using (System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("PMIST +2 Mock Test<updates@pmu.edu>", ToMail))
            {

                mm.Subject = Subject;
                mm.Body = body;
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "relay-hosting.secureserver.net";
                NetworkCredential NetworkCred = new NetworkCredential("formtest.ppweb@gmail.com", "info2023##");
                smtp.Credentials = NetworkCred;
                smtp.Port = 25;
                smtp.UseDefaultCredentials = true;
                smtp.EnableSsl = false;
                smtp.Send(mm);

            }
        }
        catch (Exception ex)
        {

        }

    }

    public DataSet ViewRegistration()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMocktestRegistration", cnn))
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
    public string GetEmailId()
    {
        string strEmailId = string.Empty;
        try
        {
            if (HttpContext.Current.Session["PeriyarMocktestEmail"] != null)
            {
                strEmailId = Convert.ToString(HttpContext.Current.Session["PeriyarMocktestEmail"]);

            }
            else
            {
                if (HttpContext.Current.Request.Cookies["PERIYARMOCKTESTLOGIN"] != null)
                {
                    HttpCookie Logincookie = HttpContext.Current.Request.Cookies["PERIYARMOCKTESTLOGIN"];
                    strEmailId = Logincookie["PeriyarMocktestEmail"];
                }
            }
        }
        catch
        {
        }
        return strEmailId;
    }
  
    public string GetRegId()
    {
        string strRegId = string.Empty;
        try
        {


            if (HttpContext.Current.Session["PeriyarMocktestRegId"] != null)
            {
                strRegId = Convert.ToString(HttpContext.Current.Session["PeriyarMocktestRegId"]);

            }
            else
            {
                if (HttpContext.Current.Request.Cookies["PERIYARMOCKTESTLOGIN"] != null)
                {
                    HttpCookie Logincookie = HttpContext.Current.Request.Cookies["PERIYARMOCKTESTLOGIN"];
                    strRegId = Logincookie["PeriyarMocktestRegId"];
                }
            }
        }
        catch
        {
        }
        return strRegId;
    }

    public string GetUserName()
    {
        string strUname = string.Empty;
        try
        {
            if (HttpContext.Current.Session["PeriyarMocktestUserName"] != null)
            {
                strUname = Convert.ToString(HttpContext.Current.Session["PeriyarMocktestUserName"]);

            }
            else
            {
                if (HttpContext.Current.Request.Cookies["PERIYARMOCKTESTLOGIN"] != null)
                {
                    HttpCookie Logincookie = HttpContext.Current.Request.Cookies["PERIYARMOCKTESTLOGIN"];
                    strUname = Logincookie["PeriyarMocktestUserName"];
                }
            }
        }
        catch
        {
        }
        return strUname;
    }

    public DataSet ViewMocktestRegByRegID(string RegId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMocktestRegByRegID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                          new SqlParameter("@RegId", RegId));
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

	public DataSet ViewMocktestRegNoByEmail(string EmailID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMocktestRegNoByEmail", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(new SqlParameter("@email", EmailID));
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