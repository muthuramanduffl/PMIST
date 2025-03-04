using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

public partial class includes_UCAdmissionCampaign :  System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        btnsubmit.Text = "Please Wait...";
        btnsubmit.Enabled = false;
        string stMobileNo = string.Empty;
        string Tomail = string.Empty;
        string strName = string.Empty;
        string SerialNo = string.Empty;


        ApplicationForm _form = new ApplicationForm();
        _form.AppliedFrom = getFileName();
        _form.NameOfApplicant = txtName.Text;
        _form.EmailID = txtEmailId.Text;
        _form.DateOfBirth = DateTime.ParseExact(txtDateofBirth.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        _form.CandidateMobileNo = txtMobileNo.Text;
        _form.CourseType = "Regular";
        _form.Course = "UG";
        _form.ApplicationFor = getCourseName();
        _form.Choice = getChoiceName();
        _form.PostedDate = Utility.IndianTime;
        _form.ApplicationNo = _form.NewApplicationNoForCampaign(_form.AppliedFrom);
        

        SerialNo = _form.ApplicationNo;

        //if (_form.ISStudentExist(txtEmailId.Text))
        //{
        //    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Sorry!, This EmailID already used.Please choose another one');</script>");

        //}

        

        if (_form.CreateCampaignForm(txtLocation.Text) ==-1)
        {
            string emailbody = this.PopulateEmailBody(txtName.Text);
            SendMails(txtEmailId.Text, emailbody);
            string emailbody1 = PopulateEmailBody1();            
            SendMails1("education@pmu.edu", emailbody1);
            Response.Redirect(getRedirectFileName(),true);
        }

        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Something Went Wrong!!');</script>");

        }

        txtName.Text = "";
        txtMobileNo.Text = "";
        txtEmailId.Text = "";
        txtDateofBirth.Text = "";
        txtLocation.Text = "";
        //rbCourseType.ClearSelection();
        btnsubmit.Text = "Submit";
        btnsubmit.Enabled = true;

    }
    private string PopulateEmailBody(string usrname)
    {

        string body = string.Empty;

        using (StreamReader reader = new StreamReader(Server.MapPath("/admission/mailtemplate/PMUCampaign.html")))
        {
            body = reader.ReadToEnd();
        }
        body = body.Replace("{Dear}", txtName.Text);
        body = body.Replace("{UserName}", usrname);
       
        return body;
    }
    private string PopulateEmailBody1()
    {

        string body = string.Empty;

        using (StreamReader reader = new StreamReader(Server.MapPath("/admission/mailtemplate/PMUCampaignContact.html")))
        {
            body = reader.ReadToEnd();
        }
        body = body.Replace("{Name}", txtName.Text);
        body = body.Replace("{Email}", txtEmailId.Text);
        body = body.Replace("{DOB}", txtDateofBirth.Text);
        body = body.Replace("{Mobile}", txtMobileNo.Text);
        body = body.Replace("{Course}", "Regular");
        body = body.Replace("{CourseType}", "UG");
        body = body.Replace("{ApplicationFor}", "B.Sc.B.Ed");
        body = body.Replace("{Choice}", "B.Sc.B.Ed");
        body = body.Replace("{PostedDate}", Utility.IndianTime.ToString());
        return body;
    }
    public string getCourseName()
    {
        string stFileName = string.Empty;
        string path = HttpContext.Current.Request.Url.AbsoluteUri;
        if (!string.IsNullOrEmpty(path))
        {
            if (string.Equals(path, "https://pmu.edu/aerospacecampaign.aspx", StringComparison.OrdinalIgnoreCase))
                stFileName = "B. Tech Full Time";
            else if (string.Equals(path, "https://pmu.edu/educationcampaign.aspx", StringComparison.OrdinalIgnoreCase) || path.Contains("https://pmu.edu/educationcampaign.aspx"))
                stFileName = "B.Sc.B.Ed";
        }
        return stFileName;

    }
    public void SendMails(string ToMail,string body)
    {
        try
        {
            using (System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("PMU Application<applications@pmu.edu>", ToMail))
            {

                mm.Subject = "From PMIST | Thank you for your enquiry!";
                mm.Body = body;
                //MailAddress Bcopy = new MailAddress("admission@pmu.edu");
                //mm.Bcc.Add(Bcopy);
                MailAddress Bcopy = new MailAddress("asmvelan@parampriti.com");
               mm.Bcc.Add(Bcopy);
                MailAddress Bcopy1 = new MailAddress("veni@parampriti.com");
                mm.Bcc.Add(Bcopy1);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "relay-hosting.secureserver.net";
                NetworkCredential NetworkCred = new NetworkCredential("applications@pmu.edu", "periyar2020");
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
    public void SendMails1(string ToMail, string body)
    {
        //try
        //{
            using (System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("PMU Application<applications@pmu.edu>", ToMail))
            {

                mm.Subject = "PMIST | New enquiry for B.Sc.B.Ed";
                mm.Body = body;
                //MailAddress Bcopy = new MailAddress("admission@pmu.edu");
                //mm.Bcc.Add(Bcopy);
                MailAddress Bcopy = new MailAddress("asmvelan@parampriti.com");
                mm.Bcc.Add(Bcopy);
                MailAddress Bcopy1 = new MailAddress("veni@parampriti.com");
                mm.Bcc.Add(Bcopy1);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "relay-hosting.secureserver.net";
                NetworkCredential NetworkCred = new NetworkCredential("applications@pmu.edu", "periyar2020");
                smtp.Credentials = NetworkCred;
                smtp.Port = 25;
                smtp.UseDefaultCredentials = true;
                smtp.EnableSsl = false;
                smtp.Send(mm);

            }
        //}
        //catch (Exception ex)
        //{

        //}

    }
    public string getChoiceName()
    {
        string stFileName = string.Empty;
        string path = HttpContext.Current.Request.Url.AbsoluteUri;
        if (!string.IsNullOrEmpty(path))
        {
            if (string.Equals(path, "https://pmu.edu/aerospacecampaign.aspx", StringComparison.OrdinalIgnoreCase))
                stFileName = "Aerospace Engineering";
            else if (string.Equals(path, "https://pmu.edu/educationcampaign.aspx", StringComparison.OrdinalIgnoreCase) || path.Contains("https://pmu.edu/educationcampaign.aspx"))
                stFileName = "B.Sc.B.Ed";
        }
        return stFileName;

    }

    public string getFileName()
    {
        string stFileName = "Index";
        string path = HttpContext.Current.Request.Url.AbsoluteUri;
        if (!string.IsNullOrEmpty(path))
        {
            
            if (string.Equals(path, "https://pmu.edu/aerospacecampaign.aspx", StringComparison.OrdinalIgnoreCase))
                stFileName = "aerospacecampaign";
            else if (string.Equals(path, "https://pmu.edu/educationcampaign.aspx", StringComparison.OrdinalIgnoreCase) || path.Contains("https://pmu.edu/educationcampaign.aspx"))
                stFileName = "educationcampaign";
        }
        return stFileName;

    }
    public string getRedirectFileName()
    {
        string stFileName = string.Empty;
        string path = HttpContext.Current.Request.Url.AbsoluteUri;
        if (!string.IsNullOrEmpty(path))
        {
            if (string.Equals(path, "https://pmu.edu/aerospacecampaign.aspx", StringComparison.OrdinalIgnoreCase))
                stFileName = "https://pmu.edu/aerospacecampaign-Thankyoupage.aspx";
            else if (string.Equals(path, "https://pmu.edu/educationcampaign.aspx", StringComparison.OrdinalIgnoreCase) || path.Contains("https://pmu.edu/educationcampaign.aspx"))
                stFileName = "https://pmu.edu/educationcampaign-Thankyoupage.aspx";
        }
        return stFileName;

    }
}