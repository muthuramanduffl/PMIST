using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mail;
using System.Net.Mail;
using System.Text;
using System.IO;
public partial class account_login : System.Web.UI.Page
{
    pmuLogin login = new pmuLogin();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }


    public void sendGodaddyMail(string Tomail, string subject, string body)
    {
        try
        {
            var SmtpClient = new SmtpClient();
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.From = new MailAddress("inputsfrom@sitequery.info");
            message.Subject = subject;
            message.To.Add(Tomail);
            // message.Bcc.Add("asmvelan@gmail.com");
            message.Body = body;
            message.IsBodyHtml = true;
            //SmtpClient.Port = 25; 
            SmtpClient.EnableSsl = false;
            SmtpClient.Send(message);
        }
        catch (Exception ex)
        {
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        string stPassword = string.Empty;

        //Validate user credentials
        if (IsEmailExist(txtEmail.Text.Trim(), ref stPassword))
        {
            //Send Password


            string body = string.Empty;
            using (StreamReader reader = new
                StreamReader(Server.MapPath("email-templates/user-password.html")))
            {
                body = reader.ReadToEnd();
            }


            body = body.Replace("{password}", stPassword);

            #region Send Email to User
            sendGodaddyMail("preethisampath@parampriti.com", body);
            #endregion


        }
        else
        {
            //Invalid User Credentials
            lblDisplay.Visible = true;
            lblDisplay.Text = "Sorry!, this email id has not been registered with us";
        }

    }
    public bool IsEmailExist(string stEmailId, ref string stPassword)
    {
        DataSet ds = login.viewLoginByEmail(stEmailId);
        bool IsExist = false;
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {

            stPassword = Convert.ToString(ds.Tables[0].Rows[0]["Password"]);
            IsExist = true;
        }
        return IsExist;
    }

    public static bool sendGodaddyMail(string Tomail, string body)
    {
        bool Isent = false;
        //try
        //{
        var SmtpClient = new SmtpClient();
        System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
        message.From = new MailAddress("sitequery<inputsfrom@sitequery.info>");
        message.Subject = "Re: Your Lenco Watches admin Password";
        message.To.Add(Tomail);
        message.Body = body;
        message.IsBodyHtml = true;
        SmtpClient.EnableSsl = false;
        SmtpClient.Send(message);
        Isent = true;

        //}
        //catch (Exception ex)
        //{
        //    Isent = false;

        //}
        return Isent;
    }
}