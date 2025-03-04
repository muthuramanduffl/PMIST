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
using System.Data;

public partial class UCAdmission : System.Web.UI.UserControl
{
    pmutelecounsellor telecounsellor = new pmutelecounsellor();
    pmulead lead = new pmulead();
    ApplicationForm _form = new ApplicationForm();
    leadassigned leadassigned = new leadassigned();
    pmureferrals referral = new pmureferrals();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        bool IsValidCode = true;
        string stReferral = string.Empty;
        bool IsEmailExists = false;
        bool IsMobileNoExists = false;
        lblErrMesg1.Text = "";
        if (!string.IsNullOrEmpty(txtReferenceCode.Text))
        {
            GetRefCodeValid(txtReferenceCode.Text.Trim(), ref IsValidCode, ref stReferral);
        }
        if (IsValidCode)
        {
            btnsubmit.Text = "Please Wait...";
            btnsubmit.Enabled = false;
            string stMobileNo = string.Empty;
            string Tomail = string.Empty;
            string strName = string.Empty;
            string SerialNo = string.Empty;


            ApplicationForm _form = new ApplicationForm();

            _form.NameOfApplicant = txtName.Text;
            _form.EmailID = txtEmailId.Text;
            _form.DateOfBirth = DateTime.ParseExact(txtDateofBirth.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            _form.CandidateMobileNo = txtMobileNo.Text;
            _form.CourseType = rbCourseType.SelectedItem.Text;
            _form.Course = rbCourse.SelectedItem.Text;
            _form.ApplicationFor = ddlApplicationFor.SelectedItem.Text;
            _form.Choice = ddlChoice1.SelectedItem.Text;
            _form.ChoiceTwo = ddlChoice2.SelectedItem.Text;
            _form.ChoiceThree = ddlChoice3.SelectedItem.Text;
            _form.ChoiceThree = ddlChoice3.SelectedItem.Text;
            _form.PostedDate = Utility.IndianTime;

            _form.ApplicationNo = _form.NewApplicationNo(_form.CourseType, _form.ApplicationFor);

            Session["ApplicationNo"] = _form.ApplicationNo;

            SerialNo = _form.ApplicationNo;

            //if (_form.ISStudentExist(txtEmailId.Text))
            //{
            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Sorry!, This EmailID already used.Please choose another one');</script>");

            //}

            _form.AppliedFrom = getFileName();
            if (IsEmailIdExistsInForm(txtEmailId.Text))
                IsEmailExists = true;
            if (IMobileNoExistsInForm(txtMobileNo.Text))
                IsMobileNoExists = true;
            if (!IsEmailExists && !IsMobileNoExists)
            {
                if (_form.CreateForm() > 0)
                {
                    if (!IsEmailIdExistsInLead(txtEmailId.Text) && !IMobileNoExistsinLead(txtMobileNo.Text))
                    {
                        AddLead(_form.ApplicationNo, stReferral, _form.CourseType);
                    }
                    else
                    {
                        lead.UpdateApplicationNo(_form.ApplicationNo, txtMobileNo.Text.Trim());
                    }
                    stMobileNo = txtMobileNo.Text;
                    strName = txtName.Text;
                    SerialNo = _form.ApplicationNo;
                    Tomail = txtEmailId.Text;
                    string emailbody = this.PopulateEmailBody(SerialNo);
                    SendNewSMS(txtMobileNo.Text, _form.ApplicationNo, txtName.Text);
                    SendMails(txtEmailId.Text, _form.ApplicationNo, txtMobileNo.Text, emailbody);
                    Response.Redirect("/admission/welcome.aspx");
                }

                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Something Went Wrong!!');</script>");

                }
                txtName.Text = "";
                txtMobileNo.Text = "";
                txtEmailId.Text = "";
                txtDateofBirth.Text = "";
                rbCourse.ClearSelection();
                ddlApplicationFor.ClearSelection();
                ddlChoice1.ClearSelection();
                ddlChoice2.ClearSelection();
                ddlChoice3.ClearSelection();
                rbCourseType.ClearSelection();
                txtCity.Text = "";
                dddlSource.ClearSelection();
                ddlState.SelectedIndex = 0;
                ddlEntranceExam.SelectedIndex = 0;
                btnsubmit.Text = "Submit";
                btnsubmit.Enabled = true;
            }
            else
            {
                if (IsEmailExists)
                    lblErrMesg1.Text = "Email Id already exists";
                else if (IsMobileNoExists)
                    lblErrMesg1.Text = "Mobile no already exists";
                btnsubmit.Text = "Submit";
                btnsubmit.Enabled = true;
            }
            
        }
        else
        {
            lblErrMesg.Text = "Invalid Reference Code";
            btnsubmit.Text = "Submit";
            btnsubmit.Enabled = true;
        }
    }
    

    private string PopulateEmailBody(string serialno)
    {

        string body = string.Empty;

        using (StreamReader reader = new StreamReader(Server.MapPath("/admission/mailtemplate/PMU.html")))
        {
            body = reader.ReadToEnd();
        }
        body = body.Replace("{Dear}", txtName.Text);
        body = body.Replace("{UserName}", serialno);
        body = body.Replace("{Password}", txtMobileNo.Text.Trim());
        body = body.Replace("{Click Here}", "Click here to complete Admission https://pmu.edu/admission/login.aspx");



        return body;
    }

    public void SendMails(string ToMail, string SerailNo, string MobileNo, string body)
    {
        try
        {
            using (System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("PMU Application<applications@pmu.edu>", txtEmailId.Text))
            {

                mm.Subject = "PMU-Admission";
                mm.Body = body;
                //MailAddress Bcopy = new MailAddress("admission@pmu.edu");
                //mm.Bcc.Add(Bcopy);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = " relay-hosting.secureserver.net";
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
    public string getFileName()
    {
        string stFileName = "Index";
        string path = HttpContext.Current.Request.Url.AbsoluteUri;
        if (string.Equals(path, "https://pmu.edu/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Index";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-architecture/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Architecture Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-aerospace/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Aerospace Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-biotechnology/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Biotechnology Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-civil-engineering/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Civil Engineering Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-electronics-and-communication/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Electronics and Communication Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-electrical-and-electronics/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Electrical and Electronics Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-mechanical-engineering/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Mechanical Engineering Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-nano-technology/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Nano Technology Department";
        else if (string.Equals(path, "https://www.pmu.edu/cse/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "CSE Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-computer-science-applications/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Compter Application Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-software-engineering/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Software Engineering Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-chemistry/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Chemistry Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-commerce/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Commerce Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-english/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "English Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-education/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Education Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-mathematics/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Mathematics Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-management-studies/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Management Studies Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-physics/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Physics Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-political-science/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Political Science Department";
        else if (string.Equals(path, "https://www.pmu.edu/department-of-social-work/default.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Social Work Department";
        else if (string.Equals(path, "https://pmu.edu/admission/index.aspx", StringComparison.OrdinalIgnoreCase))
            stFileName = "Admission";
        else if (!string.IsNullOrEmpty(path) && path.Contains("admissioncamp"))
            stFileName = "Campaign";

        // else if (string.Equals(path, "https://pmu.edu/admissioncamp/index.aspx", StringComparison.OrdinalIgnoreCase))
        //   stFileName = "Campaign";
        return stFileName;

    }
    #region Send SMS Notifications


    private void SendNewSMS(string stMobileNo, string SerialNo, string strName)
    {
        try
        {
            string Message = "Dear " + strName + ", \n"
                           + "Thanks for your Registration. To complete your admission, please login with the following credentials \n" + "Application No :" + SerialNo + "" + " | Password is:" + stMobileNo + "\n Best Wishes, \n" + "Team PMIST";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://alerts.qikberry.com/api/v2/sms/send?access_token=2640d057bd8f5408f35f5bfd3106fc81&message=" + Message + "&sender=PMUADM&to=" + stMobileNo + "&service=T");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(responseStream, Encoding.UTF8);
            var _Result = readStream.ReadToEnd();
        }
        catch (Exception ex)
        {
        }
    }
    #endregion
    public bool IsEmailIdExistsInForm(string stEmailId)
    {
        bool IsExists = false;
        if (string.IsNullOrEmpty(stEmailId))
            IsExists = false;
        else
        {
            DataSet ds = _form.ViewRegByEmailId(stEmailId);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                IsExists = true;
        }
        return IsExists;
    }
    public bool IMobileNoExistsInForm(string stMobileNo)
    {
        bool IsExists = false;
        if (string.IsNullOrEmpty(stMobileNo))
            IsExists = false;
        else
        {
            DataSet ds = _form.ViewRegByMobileNo(stMobileNo);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                IsExists = true;
        }
        return IsExists;
    }
    public bool IsEmailIdExistsInLead(string stEmailId)
    {
        bool IsExists = false;
        if (string.IsNullOrEmpty(stEmailId))
            IsExists = false;
        else
        {
            DataSet ds = lead.ViewLeadByEmailId(stEmailId);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                IsExists = true;
        }
        return IsExists;
    }
    public bool IMobileNoExistsinLead(string stMobileNo)
    {
        bool IsExists = false;
        if (string.IsNullOrEmpty(stMobileNo))
            IsExists = false;
        else
        {
            DataSet ds = lead.ViewLeadByMobileNo(stMobileNo);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                IsExists = true;
        }
        return IsExists;
    }
    public void GetRefCodeValid(string stRefCode,ref bool IsRefCodeValid, ref string stRefType)
    {
        DataSet ds = referral.ViewReferralByCode(stRefCode);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            IsRefCodeValid = true;
            stRefType= Convert.ToString(ds.Tables[0].Rows[0]["RefType"]);
        }
        else
        {
            IsRefCodeValid = false;
            stRefType = string.Empty;
        }
    }
    public void AddLead(string stApplicationNo, string stReferral, string stCourseType)
    {
       
        string stApplicationFor = ddlApplicationFor.SelectedItem.Text.Trim();
        string ststate = ddlState.SelectedItem.Text.Trim();
        string sEntranceExam = string.Empty;
        string stLeadId = string.Empty;
        string stAssignedTo = string.Empty;
        if (!string.Equals(ddlEntranceExam.SelectedItem.Text, "Select"))
            sEntranceExam = ddlEntranceExam.SelectedItem.Text;
        stLeadId= GenerateLeadNo(stApplicationFor, stCourseType);
        lead.LeadId = stLeadId;
        lead.Name = (!string.IsNullOrEmpty(txtName.Text)) ? txtName.Text.Trim() : string.Empty;
        lead.EmailId = (!string.IsNullOrEmpty(txtEmailId.Text)) ? txtEmailId.Text.Trim() : string.Empty;
        lead.MobileNo = (!string.IsNullOrEmpty(txtMobileNo.Text)) ? txtMobileNo.Text.Trim() : string.Empty;
        lead.Location = (!string.IsNullOrEmpty(txtCity.Text)) ? txtCity.Text.Trim() : string.Empty;
        lead.State = ststate;
        lead.ApplicationFor = stApplicationFor;
        lead.CourseMode = rbCourseType.SelectedItem.Text; 
        lead.CourseType = rbCourse.SelectedItem.Text;
        lead.BranchChoice1 = ddlChoice1.SelectedItem.Text;
        lead.BranchChoice2 = ddlChoice2.SelectedItem.Text;
        lead.BranchChoice3 = ddlChoice3.SelectedItem.Text;
        lead.EntranceExam = sEntranceExam;
        lead.RefCode=(!string.IsNullOrEmpty(txtReferenceCode.Text)) ? txtReferenceCode.Text.Trim() : string.Empty;
        lead.ApplicaionNo = stApplicationNo;
        lead.SourceEntered= dddlSource.SelectedItem.Text;
        lead.SourceCaptured = dddlSource.SelectedItem.Text;// "Website Form";
        lead.AssignedTo = stAssignedTo;
        lead.AssignedRole = string.Empty;
        lead.LeadStatus = "Active";
        lead.AdmissionLevel = "Interested";
        lead.LeadGeneratedFrom = "App";
        lead.LeadGeneratedDate = Utility.IndianTime;
        lead.LeadGeneratedBy = "User";
        lead.BulkUpload = "N";
        lead.Referral = stReferral;
        lead.AddAppLead(lead);
      
    }

    public string GenerateLeadNo(string stApplicationFor, string stCourseType)
    {
        string stLeadNo = string.Empty;
        bool IsExists = false;

        do
        {
            stLeadNo = Util.GetDateFormat(Utility.IndianTime) + Util.GetApplicationFor(stApplicationFor, stCourseType) + Util.GenerateOTP();
            IsExists = ILeadIdExists(stLeadNo);

        } while (IsExists);
        return stLeadNo;
    }
    public bool ILeadIdExists(string stLeadNo)
    {
        bool IsExists = false;
        DataSet ds = lead.ViewLeadByLeadId(stLeadNo);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            IsExists = true;
        return IsExists;
    }
    protected void ddlApplicationFor_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlChoice1.Enabled = true;
        ddlChoice2.Enabled = true;
        ddlChoice3.Enabled = true;

        //ddlChoice1.Items.Clear();
        //ddlChoice2.Items.Clear();
        //ddlChoice3.Items.Clear();

        string stCourseType = rbCourseType.SelectedItem.Text.Trim();
        string stCourse = Convert.ToString(rbCourse.SelectedValue);

        if (ddlApplicationFor.SelectedValue.Equals("B.Arch"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Architecture", "Architecture"));
                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Architecture", "Architecture"));

                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Architecture", "Architecture"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }

            }

        }
        else if (ddlApplicationFor.SelectedValue.Equals("M.Arch"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "PG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Architecture", "Architecture"));
                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Architecture", "Architecture"));

                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Architecture", "Architecture"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }

            }

        }
        else if (ddlApplicationFor.SelectedValue.Equals("B.Tech"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
                    //ddlChoice1.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
                    ddlChoice1.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
                    ddlChoice1.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
                    //ddlChoice1.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
                    ddlChoice2.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
                    ddlChoice2.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));

                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
                    //ddlChoice1.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
                    ddlChoice3.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
                    ddlChoice3.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }


            }
            else if (string.Equals(stCourseType, "Part Time"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));


                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));


                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));


                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }

            }
            else if (string.Equals(stCourseType, "Lateral"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));

                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }

            }
        }
        else if (ddlApplicationFor.SelectedValue.Equals("M.Tech"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "PG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Environmental Engineering", "Environmental Engineering"));
                    //ddlChoice1.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
                    ddlChoice1.Items.Add(new ListItem("Nano Technology", "Nano Technology"));
                    ddlChoice1.Items.Add(new ListItem("Renewable Energy", "Renewable Energy"));
                    ddlChoice1.Items.Add(new ListItem("Wireless Communications", "Wireless Communications"));


                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Environmental Engineering", "Environmental Engineering"));
                    //ddlChoice1.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
                    ddlChoice2.Items.Add(new ListItem("Nano Technology", "Nano Technology"));
                    ddlChoice2.Items.Add(new ListItem("Renewable Energy", "Renewable Energy"));
                    ddlChoice2.Items.Add(new ListItem("Wireless Communications", "Wireless Communications"));

                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Environmental Engineering", "Environmental Engineering"));
                    //ddlChoice1.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
                    ddlChoice3.Items.Add(new ListItem("Nano Technology", "Nano Technology"));
                    ddlChoice3.Items.Add(new ListItem("Renewable Energy", "Renewable Energy"));
                    ddlChoice3.Items.Add(new ListItem("Wireless Communications", "Wireless Communications"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }


            }
            else if (string.Equals(stCourseType, "Part Time"))
            {
                if (string.Equals(stCourse, "PG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Environmental Engineering", "Environmental Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Nano Technology", "Nano Technology"));
                    ddlChoice1.Items.Add(new ListItem("Renewable Energy", "Renewable Energy"));
                    ddlChoice1.Items.Add(new ListItem("Wireless Communications", "Wireless Communications"));
                    ddlChoice1.Items.Add(new ListItem("Power Electronics & Drives", "Power Electronics & Drives"));


                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Environmental Engineering", "Environmental Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Nano Technology", "Nano Technology"));
                    ddlChoice2.Items.Add(new ListItem("Renewable Energy", "Renewable Energy"));
                    ddlChoice2.Items.Add(new ListItem("Wireless Communications", "Wireless Communications"));
                    ddlChoice2.Items.Add(new ListItem("Power Electronics & Drives", "Power Electronics & Drives"));


                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Environmental Engineering", "Environmental Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Nano Technology", "Nano Technology"));
                    ddlChoice3.Items.Add(new ListItem("Renewable Energy", "Renewable Energy"));
                    ddlChoice3.Items.Add(new ListItem("Wireless Communications", "Wireless Communications"));
                    ddlChoice3.Items.Add(new ListItem("Power Electronics & Drives", "Power Electronics & Drives"));


                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }

            }
            else if (string.Equals(stCourseType, "Lateral"))
            {
                if (string.Equals(stCourse, "PG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));
                    ddlChoice1.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));
                    ddlChoice2.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));

                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));
                    ddlChoice3.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }

            }
        }
        else if (ddlApplicationFor.SelectedValue.Equals("B.Com"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Bachelor of Commerce", "Bachelor of Commerce"));
                    ddlChoice1.Items.Add(new ListItem("Honours", "Honours"));
                    ddlChoice1.Items.Add(new ListItem("Computer Applications", "Computer Applications"));
                    ddlChoice1.Items.Add(new ListItem("Corporate Secretaryship", "Corporate Secretaryship"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Bachelor of Commerce", "Bachelor of Commerce"));
                    ddlChoice2.Items.Add(new ListItem("Honours", "Honours"));
                    ddlChoice2.Items.Add(new ListItem("Computer Applications", "Computer Applications"));
                    ddlChoice2.Items.Add(new ListItem("Corporate Secretaryship", "Corporate Secretaryship"));
                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Bachelor of Commerce", "Bachelor of Commerce"));
                    ddlChoice3.Items.Add(new ListItem("Honours", "Honours"));
                    ddlChoice3.Items.Add(new ListItem("Computer Applications", "Computer Applications"));
                    ddlChoice3.Items.Add(new ListItem("Corporate Secretaryship", "Corporate Secretaryship"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }

        else if (ddlApplicationFor.SelectedValue.Equals("BBA"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Bachelor of Business Administration", "Bachelor of Business Administration"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Bachelor of Business Administration", "Bachelor of Business Administration"));
                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Bachelor of Business Administration", "Bachelor of Business Administration"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }

        else if (ddlApplicationFor.SelectedValue.Equals("B.Sc"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Animation and Multimedia", "Animation and Multimedia"));
                    ddlChoice1.Items.Add(new ListItem("Computer Science", "Computer Science"));
                    ddlChoice1.Items.Add(new ListItem("Artificial Intelligence", "Artificial Intelligence"));
                    ddlChoice1.Items.Add(new ListItem("Physics", "Physics"));
                    ddlChoice1.Items.Add(new ListItem("Chemistry", "Chemistry"));
                    ddlChoice1.Items.Add(new ListItem("Maths", "Maths"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Animation and Multimedia", "Animation and Multimedia"));
                    ddlChoice2.Items.Add(new ListItem("Computer Science", "Computer Science"));
                    ddlChoice2.Items.Add(new ListItem("Artificial Intelligence", "Artificial Intelligence"));
                    ddlChoice2.Items.Add(new ListItem("Physics", "Physics"));
                    ddlChoice2.Items.Add(new ListItem("Chemistry", "Chemistry"));
                    ddlChoice2.Items.Add(new ListItem("Maths", "Maths"));
                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Animation and Multimedia", "Animation and Multimedia"));
                    ddlChoice3.Items.Add(new ListItem("Computer Science", "Computer Science"));
                    ddlChoice3.Items.Add(new ListItem("Artificial Intelligence", "Artificial Intelligence"));
                    ddlChoice3.Items.Add(new ListItem("Physics", "Physics"));
                    ddlChoice3.Items.Add(new ListItem("Chemistry", "Chemistry"));
                    ddlChoice3.Items.Add(new ListItem("Maths", "Maths"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }

        else if (ddlApplicationFor.SelectedValue.Equals("BCA"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Bachelor of Computer Applications", "Bachelor of Computer Applications"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();


                    ddlChoice2.Items.Add(new ListItem("Bachelor of Computer Applications", "Bachelor of Computer Applications"));
                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Bachelor of Computer Applications", "Bachelor of Computer Applications"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }
        else if (ddlApplicationFor.SelectedValue.Equals("MCA"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "PG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Master of Computer Applications", "Master of Computer Applications"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();


                    ddlChoice2.Items.Add(new ListItem("Master of Computer Applications", "Master of Computer Applications"));
                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Master of Computer Applications", "Master of Computer Applications"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }

        else if (ddlApplicationFor.SelectedValue.Equals("B.A"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("English", "English"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();


                    ddlChoice2.Items.Add(new ListItem("English", "English"));
                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("English", "English"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }

        else if (ddlApplicationFor.SelectedValue.Equals("B.Sc B.Ed"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("B.Sc B.Ed", "B.Sc B.Ed"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();


                    ddlChoice2.Items.Add(new ListItem("B.Sc B.Ed", "B.Sc B.Ed"));
                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("B.Sc B.Ed", "B.Sc B.Ed"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }

        else if (ddlApplicationFor.SelectedValue.Equals("B.Ed"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "UG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("B.Ed", "B.Ed"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();


                    ddlChoice2.Items.Add(new ListItem("B.Ed", "B.Ed"));
                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("B.Ed", "B.Ed"));

                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }

        else if (ddlApplicationFor.SelectedValue.Equals("M.Sc"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "PG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Physics", "Physics"));
                    ddlChoice1.Items.Add(new ListItem("Chemistry", "Chemistry"));
                    ddlChoice1.Items.Add(new ListItem("Maths", "Maths"));
                    ddlChoice1.Items.Add(new ListItem("Computer Science", "Computer Science"));


                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Physics", "Physics"));
                    ddlChoice2.Items.Add(new ListItem("Chemistry", "Chemistry"));
                    ddlChoice2.Items.Add(new ListItem("Maths", "Maths"));
                    ddlChoice2.Items.Add(new ListItem("Computer Science", "Computer Science"));

                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();
                    ddlChoice3.Items.Add(new ListItem("Physics", "Physics"));
                    ddlChoice3.Items.Add(new ListItem("Chemistry", "Chemistry"));
                    ddlChoice3.Items.Add(new ListItem("Maths", "Maths"));
                    ddlChoice3.Items.Add(new ListItem("Computer Science", "Computer Science"));


                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }
        else if (ddlApplicationFor.SelectedValue.Equals("M.A"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "PG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Political Science", "Political Science"));
                    ddlChoice1.Items.Add(new ListItem("Periyar Thought", "Periyar Thought"));
                    ddlChoice1.Items.Add(new ListItem("History", "History"));
                    ddlChoice1.Items.Add(new ListItem("English", "English"));
                    ddlChoice1.Items.Add(new ListItem("Tamil", "Tamil"));

                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();


                    ddlChoice2.Items.Add(new ListItem("Political Science", "Political Science"));
                    ddlChoice2.Items.Add(new ListItem("Periyar Thought", "Periyar Thought"));
                    ddlChoice2.Items.Add(new ListItem("History", "History"));
                    ddlChoice2.Items.Add(new ListItem("English", "English"));
                    ddlChoice2.Items.Add(new ListItem("Tamil", "Tamil"));

                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();

                    ddlChoice3.Items.Add(new ListItem("Political Science", "Political Science"));
                    ddlChoice3.Items.Add(new ListItem("Periyar Thought", "Periyar Thought"));
                    ddlChoice3.Items.Add(new ListItem("History", "History"));
                    ddlChoice3.Items.Add(new ListItem("English", "English"));
                    ddlChoice3.Items.Add(new ListItem("Tamil", "Tamil"));


                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }

        else if (ddlApplicationFor.SelectedValue.Equals("MBA"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "PG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Master of Business Administration", "Master of Business Administration"));


                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Master of Business Administration", "Master of Business Administration"));
                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();
                    ddlChoice3.Items.Add(new ListItem("Master of Business Administration", "Master of Business Administration"));


                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }

        else if (ddlApplicationFor.SelectedValue.Equals("M.Com"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "PG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Master of Commerce", "Master of Commerce"));


                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Master of Commerce", "Master of Commerce"));

                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();
                    ddlChoice3.Items.Add(new ListItem("Master of Commerce", "Master of Commerce"));



                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }

        else if (ddlApplicationFor.SelectedValue.Equals("MSW"))
        {
            if (string.Equals(stCourseType, "Regular"))
            {
                if (string.Equals(stCourse, "PG"))
                {
                    ddlChoice1.Items.Clear();

                    ddlChoice1.Items.Add(new ListItem("Master of Social Work", "Master of Social Work"));


                    ddlChoice1.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice2.Items.Clear();

                    ddlChoice2.Items.Add(new ListItem("Master of Social Work", "Master of Social Work"));

                    ddlChoice2.Items.Insert(0, new ListItem("Select", "Select"));

                    ddlChoice3.Items.Clear();
                    ddlChoice3.Items.Add(new ListItem("Master of Social Work", "Master of Social Work"));



                    ddlChoice3.Items.Insert(0, new ListItem("Select", "Select"));
                }
            }
        }
        //else if (ddlApplicationFor.SelectedValue.Equals("B.Voc"))
        //{
        //    ddlChoice1.Items.Clear();
        //    ddlChoice2.Items.Clear();
        //    ddlChoice3.Items.Clear();

        //    ddlChoice1.Items.Insert(0, new ListItem("Medical Instrumentation", "Medical Instrumentation"));


        //    ddlChoice1.Items.Insert(0, new ListItem("Select", "0"));
        //    ddlChoice2.Items.Insert(0, new ListItem("NA", "0"));
        //    ddlChoice3.Items.Insert(0, new ListItem("NA", "0"));


        //}


    }


    protected void rbCourseType_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlApplicationFor.Enabled = true;
        ddlApplicationFor.Items.Clear();
        if (rbCourseType.SelectedItem.Text.Equals("Regular"))
        {

            if (rbCourse.SelectedValue.Equals("UG"))
            {

                ddlApplicationFor.Items.Add(new ListItem("B.Arch", "B.Arch"));
                ddlApplicationFor.Items.Add(new ListItem("B.Tech", "B.Tech"));
                ddlApplicationFor.Items.Add(new ListItem("B.Com", "B.Com"));
                //ddlApplicationFor.Items.Add(new ListItem("B.COM", "B.COM"));
                ddlApplicationFor.Items.Add(new ListItem("BBA", "BBA"));
                ddlApplicationFor.Items.Add(new ListItem("B.Sc", "B.Sc"));
                ddlApplicationFor.Items.Add(new ListItem("BCA", "BCA"));
                ddlApplicationFor.Items.Add(new ListItem("B.A", "B.A"));
                ddlApplicationFor.Items.Add(new ListItem("B.Sc B.Ed", "B.Sc B.Ed"));
                ddlApplicationFor.Items.Add(new ListItem("B.Ed", "B.Ed"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }

            else if (rbCourse.SelectedValue.Equals("PG"))
            {

                ddlApplicationFor.Items.Add(new ListItem("M.Arch", "M.Arch"));
                ddlApplicationFor.Items.Add(new ListItem("M.Tech", "M.Tech"));
                ddlApplicationFor.Items.Add(new ListItem("MCA", "MCA"));
                ddlApplicationFor.Items.Add(new ListItem("M.Sc", "M.Sc"));
                ddlApplicationFor.Items.Add(new ListItem("M.A", "M.A"));
                ddlApplicationFor.Items.Add(new ListItem("MBA", "MBA"));
                ddlApplicationFor.Items.Add(new ListItem("M.Com", "M.Com"));
                ddlApplicationFor.Items.Add(new ListItem("MSW", "MSW"));
                //ddlApplicationFor.Items.Add(new ListItem("M.S.C (Integerated)", "M.S.C (Integerated)"));

                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));

            }

            else
            {
                ddlApplicationFor.Items.Add(new ListItem("B.Arch", "B.Arch"));
                ddlApplicationFor.Items.Add(new ListItem("B.Tech", "B.Tech"));
                ddlApplicationFor.Items.Add(new ListItem("B.Com", "B.Com"));
                //ddlApplicationFor.Items.Add(new ListItem("B.COM", "B.COM"));
                ddlApplicationFor.Items.Add(new ListItem("BBA", "BBA"));
                ddlApplicationFor.Items.Add(new ListItem("B.Sc", "B.Sc"));
                ddlApplicationFor.Items.Add(new ListItem("BCA", "BCA"));
                ddlApplicationFor.Items.Add(new ListItem("B.A", "B.A"));
                ddlApplicationFor.Items.Add(new ListItem("B.Sc B.Ed", "B.Sc B.Ed"));
                ddlApplicationFor.Items.Add(new ListItem("B.Ed", "B.Ed"));
                ddlApplicationFor.Items.Add(new ListItem("M.Arch", "M.Arch"));
                ddlApplicationFor.Items.Add(new ListItem("M.Tech", "M.Tech"));
                ddlApplicationFor.Items.Add(new ListItem("MCA", "MCA"));
                ddlApplicationFor.Items.Add(new ListItem("M.Sc", "M.Sc"));
                ddlApplicationFor.Items.Add(new ListItem("M.A", "M.A"));
                ddlApplicationFor.Items.Add(new ListItem("MBA", "MBA"));
                ddlApplicationFor.Items.Add(new ListItem("M.Com", "M.Com"));
                ddlApplicationFor.Items.Add(new ListItem("MSW", "MSW"));
                //ddlApplicationFor.Items.Add(new ListItem("M.S.C (Integerated)", "M.S.C (Integerated)"));

                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }
        }
        else if (rbCourseType.SelectedItem.Text.Equals("Part Time"))
        {
            if (rbCourse.SelectedValue.Equals("UG"))
            {

                ddlApplicationFor.Items.Add(new ListItem("B.Tech", "B.Tech"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }

            else if (rbCourse.SelectedValue.Equals("PG"))
            {

                ddlApplicationFor.Items.Add(new ListItem("M.Tech", "M.Tech"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }

            else
            {
                ddlApplicationFor.Items.Add(new ListItem("B.Tech", "B.Tech"));
                ddlApplicationFor.Items.Add(new ListItem("M.Tech", "M.Tech"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }

        }
        else if (rbCourseType.SelectedItem.Text.Equals("Lateral"))
        {
            if (rbCourse.SelectedValue.Equals("UG"))
            {

                ddlApplicationFor.Items.Add(new ListItem("B.Tech", "B.Tech"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }

            //else if (rbCourse.SelectedValue.Equals("PG"))
            //{

            //    ddlApplicationFor.Items.Add(new ListItem("B. Tech Lateral Entry", "B. Tech Lateral Entry"));
            //    ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            //}

            //else
            //{

            //    ddlApplicationFor.Items.Add(new ListItem("M.C.A", "M.C.A"));
            //    ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            //}

        }

    }
    protected void rbCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlApplicationFor.Enabled = true;

        if (rbCourse.SelectedValue.Equals("UG"))
        {
            ddlApplicationFor.Items.Clear();
            if (rbCourseType.SelectedItem.Text.Equals("Regular"))
            {
                ddlApplicationFor.Items.Add(new ListItem("B.Arch", "B.Arch"));
                ddlApplicationFor.Items.Add(new ListItem("B.Tech", "B.Tech"));
                ddlApplicationFor.Items.Add(new ListItem("B.Com", "B.Com"));
                //ddlApplicationFor.Items.Add(new ListItem("B.COM", "B.COM"));
                ddlApplicationFor.Items.Add(new ListItem("BBA", "BBA"));
                ddlApplicationFor.Items.Add(new ListItem("B.Sc", "B.Sc"));
                ddlApplicationFor.Items.Add(new ListItem("BCA", "BCA"));
                ddlApplicationFor.Items.Add(new ListItem("B.A", "B.A"));
                ddlApplicationFor.Items.Add(new ListItem("B.Sc B.Ed", "B.Sc B.Ed"));
                ddlApplicationFor.Items.Add(new ListItem("B.Ed", "B.Ed"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }
            else if (rbCourseType.SelectedItem.Text.Equals("Part Time"))
            {

                ddlApplicationFor.Items.Add(new ListItem("B.Tech", "B.Tech"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }
            else if (rbCourseType.SelectedItem.Text.Equals("Lateral"))
            {
                ddlApplicationFor.Items.Add(new ListItem("B.Tech", "B.Tech"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }

            else
            {
                ddlApplicationFor.Items.Add(new ListItem("B.Arch", "B.Arch"));
                ddlApplicationFor.Items.Add(new ListItem("B.Tech", "B.Tech"));
                ddlApplicationFor.Items.Add(new ListItem("B.Com", "B.Com"));
                //ddlApplicationFor.Items.Add(new ListItem("B.COM", "B.COM"));
                ddlApplicationFor.Items.Add(new ListItem("BBA", "BBA"));
                ddlApplicationFor.Items.Add(new ListItem("B.Sc", "B.Sc"));
                ddlApplicationFor.Items.Add(new ListItem("BCA", "BCA"));
                ddlApplicationFor.Items.Add(new ListItem("B.A", "B.A"));
                ddlApplicationFor.Items.Add(new ListItem("B.Sc B.Ed", "B.Sc B.Ed"));
                ddlApplicationFor.Items.Add(new ListItem("B.Ed", "B.Ed"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));

            }
        }

        else if (rbCourse.SelectedValue.Equals("PG"))
        {
            ddlApplicationFor.Items.Clear();
            if (rbCourseType.SelectedItem.Text.Equals("Regular"))
            {
                ddlApplicationFor.Items.Add(new ListItem("M.Arch", "M.Arch"));
                ddlApplicationFor.Items.Add(new ListItem("M.Tech", "M.Tech"));
                ddlApplicationFor.Items.Add(new ListItem("MCA", "MCA"));
                ddlApplicationFor.Items.Add(new ListItem("M.Sc", "M.Sc"));
                ddlApplicationFor.Items.Add(new ListItem("M.A", "M.A"));
                ddlApplicationFor.Items.Add(new ListItem("MBA", "MBA"));
                ddlApplicationFor.Items.Add(new ListItem("M.Com", "M.Com"));
                ddlApplicationFor.Items.Add(new ListItem("MSW", "MSW"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }
            else if (rbCourseType.SelectedItem.Text.Equals("Part Time"))
            {
                ddlApplicationFor.Items.Add(new ListItem("M.Tech", "M.Tech"));
                ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            }
            // else if (rbCourseType.SelectedItem.Text.Equals("Lateral"))
            // {
            //     ddlApplicationFor.Items.Add(new ListItem("M.C.A", "M.C.A"));
            //     ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
            // }
            // else if (rbCourseType.SelectedItem.Text.Equals("Integrated"))
            // {
            //     ddlApplicationFor.Enabled = false;
            //     ddlApplicationFor.Items.Insert(0, new ListItem("No Course Available", "0"));

            //}
            else if (rbCourseType.SelectedItem.Text.Equals("Lateral"))
            {
                ddlApplicationFor.Enabled = false;
                ddlApplicationFor.Items.Insert(0, new ListItem("No Course Available", "0"));
            }
        }

        else
        {
            ddlApplicationFor.Items.Add(new ListItem("B.Arch", "B.Arch"));
            ddlApplicationFor.Items.Add(new ListItem("B.Tech", "B.Tech"));
            ddlApplicationFor.Items.Add(new ListItem("B.Com", "B.Com"));
            //ddlApplicationFor.Items.Add(new ListItem("B.COM", "B.COM"));
            ddlApplicationFor.Items.Add(new ListItem("BBA", "BBA"));
            ddlApplicationFor.Items.Add(new ListItem("B.Sc", "B.Sc"));
            ddlApplicationFor.Items.Add(new ListItem("BCA", "BCA"));
            ddlApplicationFor.Items.Add(new ListItem("B.A", "B.A"));
            ddlApplicationFor.Items.Add(new ListItem("B.Sc B.Ed", "B.Sc B.Ed"));
            ddlApplicationFor.Items.Add(new ListItem("B.Ed", "B.Ed"));
            ddlApplicationFor.Items.Add(new ListItem("M.Arch", "M.Arch"));
            ddlApplicationFor.Items.Add(new ListItem("M.Tech", "M.Tech"));
            ddlApplicationFor.Items.Add(new ListItem("MCA", "MCA"));
            ddlApplicationFor.Items.Add(new ListItem("M.Sc", "M.Sc"));
            ddlApplicationFor.Items.Add(new ListItem("M.A", "M.A"));
            ddlApplicationFor.Items.Add(new ListItem("MBA", "MBA"));
            ddlApplicationFor.Items.Add(new ListItem("M.Com", "M.Com"));
            ddlApplicationFor.Items.Add(new ListItem("MSW", "MSW"));
            ddlApplicationFor.Items.Insert(0, new ListItem("Select", "0"));
        }
    }

    public string GetCounsellorId()
    {
        string stCounsellorId = string.Empty;
        string strCurrentDate = Utility.IndianTime.ToString("yyyy-MM-dd");
        DataSet ds = lead.ViewLeadGeneratedByDate(strCurrentDate);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            int i = 1;
            int PreviousId = Convert.ToInt32(ds.Tables[0].Rows[0]["AssignedTo"]);
            while (i <= telecounsellor.ActiveTeleCallerCount())
            {
                if (telecounsellor.IsTeleCounsellorActive(PreviousId + i))
                {
                    stCounsellorId = Convert.ToString(PreviousId + i);
                    break;
                }
                i++;
            }
        }
        else
        {
            stCounsellorId = "1";
        }
        if (string.IsNullOrEmpty(stCounsellorId))
            stCounsellorId = "1";
        return stCounsellorId;
    }
    
}