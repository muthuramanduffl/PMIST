using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Data;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Net.Mail;
using System.Net;

public partial class admin_account_Slider_AddSlider : System.Web.UI.Page
{
    alumini alum = new alumini();
    pmuLogin login = new pmuLogin();
    private static string _numbers = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    Random random = new Random();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / Alumni / <b>Edit</b>";
            alum.Id = Convert.ToInt32(Request.QueryString["ID"]);
            rvImage.Enabled = false;
            if (!IsPostBack)
            {

                BindContent(alum.Id);

            }
        }
        else
        {
           if(!IsPostBack)
            { }
            lblDisplayText.Text = "Dashboard / Alumni / <b>Add</b>";
        }

    }

    public void BindContent(int ID)
    {
        try
        {


            DataSet dsContent = alum.ViewAluminiById(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {

               
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["RegistrationNo"])))
                    txtRegistrationNo.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["RegistrationNo"]);

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Name"])))
                    txtName.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Name"]);

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["EmailId"])))
                    txtEmailId.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["EmailId"]);

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["MobileNo"])))
                    txtMobileNo.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["MobileNo"]);

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Batch"])))
                    txtBatch.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Batch"]);

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Department"])))
                {
                    string stDepartment = Convert.ToString(dsContent.Tables[0].Rows[0]["Department"]);
                    ddlDepartment.Items.FindByText(ddlDepartment.SelectedItem.Text).Selected = false;
                    ddlDepartment.Items.FindByText(stDepartment).Selected = true;

                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["CurrentStatus"])))
                {
                    dvIDCard.Attributes.Add("style", "display:block");
                    string stCurrentStatus = Convert.ToString(dsContent.Tables[0].Rows[0]["CurrentStatus"]);
                    ddlCurrentStatus.Items.FindByText(ddlCurrentStatus.SelectedItem.Text).Selected = false;
                    ddlCurrentStatus.Items.FindByText(stCurrentStatus).Selected = true;
                    if (string.Equals(stCurrentStatus, "Job"))
                    {
                        dvJob.Attributes.Add("style", "display:block");
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Designation"])))
                            txtJobDesignation.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Designation"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["CompanyName"])))
                            txtJobCompanyName.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["CompanyName"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Place"])))
                            txtJobPlace.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Place"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["IDCardUrl"])))
                        {
                            hdnJobUpload.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["IDCardUrl"]);
                            string filePath = System.Configuration.ConfigurationManager.AppSettings["Alumini"];
                            string url = "<a href = '" + filePath + hdnJobUpload.Value.ToString().Trim() + "' target = '_blank'>View Appointment order or Company ID card</a>";
                            phpdf.Controls.Add(new LiteralControl(url));
                        }
                        dvJobDesignation.Attributes["class"] = "md-input-wrapper md-input-filled";
                        dvJobCompanyName.Attributes["class"] = "md-input-wrapper md-input-filled";
                        dvJobPlace.Attributes["class"] = "md-input-wrapper md-input-filled";
                        dvJobUpload.Attributes["class"] = "md-input-wrapper md-input-filled";
                       
                    }
                    else if (string.Equals(stCurrentStatus, "Higher Studies"))
                    {
                        dvHigherStudies.Attributes.Add("style", "display:block");
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Degree"])))
                            txtDegree.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Degree"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["StudyCourse"])))
                            txtCourse.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["StudyCourse"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["InstituteName"])))
                            txtInstituteName.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["InstituteName"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Place"])))
                            txtPlace.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Place"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["IDCardUrl"])))
                        {
                            hdnDegree.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["IDCardUrl"]);
                            string filePath = System.Configuration.ConfigurationManager.AppSettings["Alumini"];
                            string url = "<a href = '" + filePath + hdnDegree.Value.ToString().Trim() + "' target = '_blank'>View Institute ID card or Admit card</a>";
                            phpdf.Controls.Add(new LiteralControl(url));
                        }
                        dvDegree.Attributes["class"] = "md-input-wrapper md-input-filled";
                        dvCourse.Attributes["class"] = "md-input-wrapper md-input-filled";
                        dvInstituteName.Attributes["class"] = "md-input-wrapper md-input-filled";
                        dvPlace.Attributes["class"] = "md-input-wrapper md-input-filled";
                        dvDegreeUpload.Attributes["class"] = "md-input-wrapper md-input-filled";
                    }
                    else if (string.Equals(stCurrentStatus, "Enterpreneur"))
                    {
                        dvEntrpreneur.Attributes.Add("style", "display:block");
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Designation"])))
                            txtEntrDesignation.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Designation"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["CompanyName"])))
                            txtEntrCompanyName.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["CompanyName"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Place"])))
                            txtEntrPlace.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Place"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["IDCardUrl"])))
                        {
                            hdnEntr.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["IDCardUrl"]);
                            string filePath = System.Configuration.ConfigurationManager.AppSettings["Alumini"];
                            string url = "<a href = '" + filePath + hdnEntr.Value.ToString().Trim() + "' target = '_blank'>View Company visiting card or ID card</a>";
                            phpdf.Controls.Add(new LiteralControl(url));
                        }
                        dvEntrCompanyName.Attributes["class"] = "md-input-wrapper md-input-filled";
                        dvEntrDesignation.Attributes["class"] = "md-input-wrapper md-input-filled";
                        dvEntrPlace.Attributes["class"] = "md-input-wrapper md-input-filled";
                        dvEntrfile.Attributes["class"] = "md-input-wrapper md-input-filled";
                        
                    }

                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["PhotoUrl"])))
                {
                    hdnPhoto.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["PhotoUrl"]);
                    string filePath = System.Configuration.ConfigurationManager.AppSettings["Alumini"];
                    string url = "<img src = '" + filePath + hdnPhoto.Value.ToString().Trim() + "'/>";
                    phType.Controls.Add(new LiteralControl(url));
                    dvoldImage.Attributes.Add("style", "display:block");
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["TestimonialContent"])))
                    txtTestimonial.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["TestimonialContent"]);
                chkStatus.Checked = Convert.ToBoolean(dsContent.Tables[0].Rows[0]["Active"]);
            }

        }

        catch (Exception ex)
        {
        }
    }
    public void SendThankyouMail(string stUserName, string stPassword, string stMobileNo, string stEmailId)
    {


        string filePath = System.Web.HttpRuntime.AppDomainAppPath + "\\alumni-new\\mailtemplate\\regform.html";
        string body = string.Empty;

        using (StreamReader reader = new StreamReader(filePath))
        {
            body = reader.ReadToEnd();
        }

        body = body.Replace("{UserName}", stUserName.Trim() ?? string.Empty);
        body = body.Replace("{MobileNo}", stMobileNo.Trim() ?? string.Empty);
        body = body.Replace("{Password}", stPassword.Trim());
        SendMails(stEmailId, "PMU Alumni - Thanks for Registration", body);


    }
    public void SendMails(string ToMail, string subject, string body)
    {

        using (System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("PMU Alumni<pmistalumni@pmu.edu>", ToMail))
        {

            mm.Subject = subject;
            mm.Body = body;
            MailAddress Bcopy = new MailAddress("pmistalumni@pmu.edu");
            mm.Bcc.Add(Bcopy);
            mm.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = " relay-hosting.secureserver.net";
            NetworkCredential NetworkCred = new NetworkCredential("pmistalumni@pmu.edu", "periyar2020");
            smtp.Credentials = NetworkCred;
            smtp.Port = 25;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = false;
            smtp.Send(mm);

        }


    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string stErrorText = string.Empty;
        if (string.IsNullOrEmpty(txtName.Text))
        {
            stErrorText = "Please enter name";
        }
        if (string.IsNullOrEmpty(txtMobileNo.Text))
        {
            stErrorText = "Please enter mobile no";
        }
        if (string.IsNullOrEmpty(txtEmailId.Text))
        {
            stErrorText = "Please enter email id";
        }
        if (string.IsNullOrEmpty(txtBatch.Text))
        {
            stErrorText = "Please enter batch";
        }
        if (string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
        {
            stErrorText = "Please select Department";
        }
        if (string.Equals(ddlCurrentStatus.SelectedItem.Text, "Select Current Status"))
        {
            stErrorText = "Please select Current Status";
        }
        else if (Request.QueryString["ID"] == null && !flPhoto.HasFile)
        {
            stErrorText = "Please upload file";
        }

        if (string.IsNullOrEmpty(stErrorText))
        {

            if (Request.QueryString["ID"] == null)
            {
                if (!IsEmailIdExists(txtEmailId.Text))
                {
                    if (!IsMobileNoExists(txtMobileNo.Text))
                    {
                        InsertContent();
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Mobile No already Exists');</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Email Id already Exists');</script>");

                }
                clear();
            }
            else
            {
                alum.Id = Convert.ToInt32(Request.QueryString["ID"]);
                if (!IsEmailIdExistsForUpdate(txtEmailId.Text, alum.Id))
                {
                    if (!IsMobileNoExistsForUpdate(txtMobileNo.Text, alum.Id))
                    {
                        UpdateContent(alum.Id);
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Mobile No already Exists');</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Email Id already Exists');</script>");

                }
                BindContent(alum.Id);
            }
            dvName.Attributes["class"] = "md-input-wrapper md-input-filled";
            dVEmailId.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvMobile.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvBatch.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvDepartment.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvCurrentStatus.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvTestimonial.Attributes["class"] = "md-input-wrapper md-input-filled";

        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
            dvName.Attributes["class"] = "md-input-wrapper md-input-filled";
            dVEmailId.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvMobile.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvBatch.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvDepartment.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvCurrentStatus.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvTestimonial.Attributes["class"] = "md-input-wrapper md-input-filled";
        }
    }
    public void clear()
    {
        txtName.Text = "";
        txtMobileNo.Text = "";
        txtEmailId.Text = "";
        txtBatch.Text = "";
        txtRegistrationNo.Text = "";
        txtTestimonial.Text = "";
        ddlCurrentStatus.SelectedIndex = 0;
        ddlDepartment.SelectedIndex = 0;
    }
    public bool IsEmailIdExists(string stEmailId)
    {
        bool IsExist = false;
        DataSet ds = alum.ViewAluminiByEmailId(stEmailId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            IsExist = true;
        return IsExist;

    }
    public bool IsEmailIdExistsForUpdate(string stEmailId, int Sno)
    {
        bool IsExist = false;
        DataSet ds = alum.ViewAluminiByEmailId(stEmailId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            if (Sno != Convert.ToInt32(ds.Tables[0].Rows[0]["Sno"]))
            {
                IsExist = true;
            }
            else
            {
                IsExist = false;
            }
        }

        return IsExist;

    }
    public bool IsMobileNoExistsForUpdate(string stMobileNo, int Sno)
    {
        bool IsExist = false;
        DataSet ds = alum.ViewAluminiByMobileNo(stMobileNo);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            if (Sno != Convert.ToInt32(ds.Tables[0].Rows[0]["Sno"]))
            {
                IsExist = true;
            }
            else
            {
                IsExist = false;
            }
        }
        return IsExist;

    }
    public bool IsMobileNoExists(string stMobileNo)
    {
        bool IsExist = false;
        DataSet ds = alum.ViewAluminiByMobileNo(stMobileNo);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            IsExist = true;
        return IsExist;

    }
    public string GeneratePassword()
    {
        StringBuilder builder = new StringBuilder(6);
        string Password = "";
        for (var i = 0; i < 6; i++)
        {
            builder.Append(_numbers[random.Next(0, _numbers.Length)]);
        }
        Password = builder.ToString();
        return Password;
    }
    public void InsertContent()
    {
        try
        {
            string stfile = string.Empty;
            string stError = string.Empty;
            if (string.IsNullOrEmpty(txtName.Text))
                stError = "Enter your name";
            else if (string.IsNullOrEmpty(txtEmailId.Text))
                stError = "Enter your Email Id";
            else if (string.IsNullOrEmpty(txtMobileNo.Text))
                stError = "Enter your mobile number";
            else if (string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
                stError = "please select department";
            else if (string.Equals(ddlCurrentStatus.SelectedItem.Text, "Select Current Status"))
                stError = "please select Status";

            string stDesignation = string.Empty;
            string stCompanyName = string.Empty;
            string stPlace = string.Empty;
            string stIdCardFile = string.Empty;
            string stDegree = string.Empty;
            string stCourse = string.Empty;
            string stInstituteName = string.Empty;
            string stDepartment = string.Empty;
            string stStatus = string.Empty;
            string stPassword = GeneratePassword();
            int seqNo = GetNextSequenceNo();

            if (string.IsNullOrEmpty(stError))
            {
                if (flPhoto.HasFile)
                    stfile = "P" + seqNo + flPhoto.FileName.Trim();
                if (!string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
                    stDepartment = ddlDepartment.SelectedItem.Text;
                if (!string.Equals(ddlCurrentStatus.SelectedItem.Text, "Select Current Status"))
                    stStatus = ddlCurrentStatus.SelectedItem.Text;
                if (string.Equals(ddlCurrentStatus.SelectedItem.Text, "Job"))
                {
                    if (!string.IsNullOrEmpty(txtJobDesignation.Text))
                        stDesignation = txtJobDesignation.Text.Trim();
                    if (!string.IsNullOrEmpty(txtJobCompanyName.Text))
                        stCompanyName = txtJobCompanyName.Text.Trim();
                    if (!string.IsNullOrEmpty(txtJobPlace.Text))
                        stPlace = txtJobPlace.Text.Trim();
                    if (flJobUpload != null && flJobUpload.HasFile)
                    {
                        stIdCardFile = "J" + seqNo + flJobUpload.FileName.Trim();
                        SaveFile(flJobUpload, seqNo, "J");
                    }
                }
                else if (string.Equals(ddlCurrentStatus.SelectedItem.Text, "Higher Studies"))
                {
                    if (!string.IsNullOrEmpty(txtDegree.Text))
                        stDegree = txtDegree.Text.Trim();
                    if (!string.IsNullOrEmpty(txtCourse.Text))
                        stCourse = txtCourse.Text.Trim();
                    if (!string.IsNullOrEmpty(txtPlace.Text))
                        stPlace = txtJobPlace.Text.Trim();
                    if (!string.IsNullOrEmpty(txtInstituteName.Text))
                        stInstituteName = txtInstituteName.Text.Trim();
                    if (flDegree != null && flDegree.HasFile)
                    {
                        stIdCardFile = "S" + seqNo + flDegree.FileName.Trim();
                        SaveFile(flDegree, seqNo, "S");
                    }
                }
                else if (string.Equals(ddlCurrentStatus.SelectedItem.Text, "Enterpreneur"))
                {
                    if (!string.IsNullOrEmpty(txtEntrDesignation.Text))
                        stDesignation = txtEntrDesignation.Text.Trim();
                    if (!string.IsNullOrEmpty(txtEntrCompanyName.Text))
                        stCompanyName = txtEntrCompanyName.Text.Trim();
                    if (!string.IsNullOrEmpty(txtEntrPlace.Text))
                        stPlace = txtEntrPlace.Text.Trim();
                    if (flEntrfile != null && flEntrfile.HasFile)
                    {
                        stIdCardFile = "E" + seqNo + flEntrfile.FileName.Trim();
                        SaveFile(flEntrfile, seqNo, "E");
                    }
                }
                List<alumini> lstContent = new List<alumini> {
            new alumini{
                RegistrationNo=(!string.IsNullOrEmpty(txtRegistrationNo.Text.Trim()))?txtRegistrationNo.Text.Trim():string.Empty,
                Name=(!string.IsNullOrEmpty(txtName.Text.Trim()))?txtName.Text.Trim():string.Empty,
                EmailId=(!string.IsNullOrEmpty(txtEmailId.Text.Trim()))?txtEmailId.Text.Trim():string.Empty,
                MobileNo=(!string.IsNullOrEmpty(txtMobileNo.Text.Trim()))?txtMobileNo.Text.Trim():string.Empty,
                Batch=(!string.IsNullOrEmpty(txtBatch.Text.Trim()))?txtBatch.Text.Trim():string.Empty,
                Department=stDepartment,
                CurrentStatus=stStatus,
                CompanyName=stCompanyName,
                Designation=stDesignation,
                Place=stPlace,
                IDCardUrl=stIdCardFile,
                Degree=stDegree,
                StudyCourse=stCourse,
                InstituteName=stInstituteName,
                PhotoUrl=stfile,
                Password=stPassword,
                TestimonialContent=(!string.IsNullOrEmpty(txtTestimonial.Text.Trim()))?txtTestimonial.Text.Trim():string.Empty,
                Active=chkStatus.Checked,
                PostedDate=Utility.IndianTime,
                PostedBy=login.GetUserName(),
                UpdatedDate=Utility.IndianTime,
                UpdatedBy="NONE"

              }
        };
                int save = 0;
                if (!string.IsNullOrEmpty(stfile))
                    save = SaveFile(flPhoto, seqNo, "P");
                else
                    save = 1;
                if (save == 1)
                {

                    int InsContent = alum.AddAlumini(lstContent);
                    SendThankyouMail(txtName.Text.Trim(), stPassword, txtMobileNo.Text.Trim(), txtEmailId.Text.Trim());
                    if (InsContent == -1)
                    {

                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Added Successfully');</script>");

                    }
                }
            }

        }

        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }

    }
    public int SaveFile(FileUpload fl, int seqNo, string filestart)
    {
        int savefile = 0;
        try
        {
            string filePath = string.Empty;
        filePath = System.Configuration.ConfigurationManager.AppSettings["Alumini"];
        string stFileName = filestart + seqNo.ToString() + fl.FileName;
        string temppath = filePath.Trim() + @"\" + stFileName;
        string savepath = Server.MapPath(temppath);
        fl.SaveAs(savepath);
        string strPath = stFileName;
        savefile = 1;
        }
        catch (Exception ex)
        {
            savefile = 0;
            Response.Write(ex.ToString());
        }
        return savefile;
    }
    public int GetNextSequenceNo()
    {
        int sqno = 0;
        DataSet ds = alum.ViewMaxAlumni();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stValue = Convert.ToString(ds.Tables[0].Rows[0]["MaxSno"]);
            if (string.IsNullOrEmpty(stValue))
            {
                sqno = 1;
            }
            else
            {
                sqno = Convert.ToInt32(ds.Tables[0].Rows[0]["MaxSno"]) + 1;
            }
        }
        return sqno;
    }
    public void UpdateContent(int Sno)
    {
        //    try
        //    {
        string stfile = string.Empty;
        string stError = string.Empty;
        if (string.IsNullOrEmpty(txtName.Text))
            stError = "Enter your name";
        else if (string.IsNullOrEmpty(txtEmailId.Text))
            stError = "Enter your Email Id";
        else if (string.IsNullOrEmpty(txtMobileNo.Text))
            stError = "Enter your mobile number";
        else if (string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
            stError = "please select department";
        else if (string.Equals(ddlCurrentStatus.SelectedItem.Text, "Select Current Status"))
            stError = "please select Status";

        string stDesignation = string.Empty;
        string stCompanyName = string.Empty;
        string stPlace = string.Empty;
        string stIdCardFile = string.Empty;
        string stDegree = string.Empty;
        string stCourse = string.Empty;
        string stInstituteName = string.Empty;
        string stDepartment = string.Empty;
        string stStatus = string.Empty;

        if (string.IsNullOrEmpty(stError))
        {
            if (flPhoto.HasFile)
                stfile = "P" + Sno + flPhoto.FileName.Trim();
            if (!string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
                stDepartment = ddlDepartment.SelectedItem.Text;
            if (!string.Equals(ddlCurrentStatus.SelectedItem.Text, "Select Current Status"))
                stStatus = ddlCurrentStatus.SelectedItem.Text;
            if (string.Equals(ddlCurrentStatus.SelectedItem.Text, "Job"))
            {
                if (!string.IsNullOrEmpty(txtJobDesignation.Text))
                    stDesignation = txtJobDesignation.Text.Trim();
                if (!string.IsNullOrEmpty(txtJobCompanyName.Text))
                    stCompanyName = txtJobCompanyName.Text.Trim();
                if (!string.IsNullOrEmpty(txtJobPlace.Text))
                    stPlace = txtJobPlace.Text.Trim();
                if (flJobUpload.HasFile)
                {

                    stIdCardFile = "J" + Sno + flJobUpload.FileName.Trim();
                    SaveFile(flJobUpload, Sno, "J");
                }
                else if (!flJobUpload.HasFile && !string.IsNullOrEmpty(hdnJobUpload.Value))
                {

                    stIdCardFile = hdnJobUpload.Value.Trim();

                }

            }
            else if (string.Equals(ddlCurrentStatus.SelectedItem.Text, "Higher Studies"))
            {
                if (!string.IsNullOrEmpty(txtDegree.Text))
                    stDegree = txtDegree.Text.Trim();
                if (!string.IsNullOrEmpty(txtCourse.Text))
                    stCourse = txtCourse.Text.Trim();
                if (!string.IsNullOrEmpty(txtPlace.Text))
                    stPlace = txtJobPlace.Text.Trim();
                if (!string.IsNullOrEmpty(txtInstituteName.Text))
                    stInstituteName = txtInstituteName.Text.Trim();
                if (flDegree.HasFile)
                {

                    stIdCardFile = "J" + Sno + flDegree.FileName.Trim();
                    SaveFile(flDegree, Sno, "S");
                }
                else if (!flDegree.HasFile && !string.IsNullOrEmpty(hdnDegree.Value))
                {

                    stIdCardFile = hdnDegree.Value.Trim();

                }

            }
            else if (string.Equals(ddlCurrentStatus.SelectedItem.Text, "Enterpreneur"))
            {
                if (!string.IsNullOrEmpty(txtEntrDesignation.Text))
                    stDesignation = txtEntrDesignation.Text.Trim();
                if (!string.IsNullOrEmpty(txtEntrCompanyName.Text))
                    stCompanyName = txtEntrCompanyName.Text.Trim();
                if (!string.IsNullOrEmpty(txtEntrPlace.Text))
                    stPlace = txtEntrPlace.Text.Trim();
                if (flEntrfile.HasFile)
                {

                    stIdCardFile = "E" + Sno + flEntrfile.FileName.Trim();
                    SaveFile(flEntrfile, Sno, "E");
                }
                else if (!flDegree.HasFile && !string.IsNullOrEmpty(hdnEntr.Value))
                {

                    stIdCardFile = hdnEntr.Value.Trim();

                }

            }
            int save = 0;
            if (flPhoto.HasFile)
            {
                save = SaveFile(flPhoto, Sno, "P");
                stfile = "P" + Sno + flPhoto.FileName.Trim();
            }
            else if (flPhoto.HasFile && !string.IsNullOrEmpty(hdnPhoto.Value))
            {
                save = SaveFile(flPhoto, Sno, "P");
                stfile = "P" + Sno + flPhoto.FileName.Trim();
            }
            else if (!flPhoto.HasFile && !string.IsNullOrEmpty(hdnPhoto.Value))
            {

                stfile = hdnPhoto.Value.Trim();
                save = 1;
            }
            List<alumini> lstContent = new List<alumini> {
            new alumini{
                 Name=(!string.IsNullOrEmpty(txtName.Text.Trim()))?txtName.Text.Trim():string.Empty,
                RegistrationNo=(!string.IsNullOrEmpty(txtRegistrationNo.Text.Trim()))?txtRegistrationNo.Text.Trim():string.Empty,
                EmailId=(!string.IsNullOrEmpty(txtEmailId.Text.Trim()))?txtEmailId.Text.Trim():string.Empty,
                MobileNo=(!string.IsNullOrEmpty(txtMobileNo.Text.Trim()))?txtMobileNo.Text.Trim():string.Empty,
                Batch=(!string.IsNullOrEmpty(txtBatch.Text.Trim()))?txtBatch.Text.Trim():string.Empty,
                Department=stDepartment,
                CurrentStatus=stStatus,
                CompanyName=stCompanyName,
                Designation=stDesignation,
                Place=stPlace,
                IDCardUrl=stIdCardFile,
                Degree=stDegree,
                StudyCourse=stCourse,
                InstituteName=stInstituteName,
                PhotoUrl=stfile,
                TestimonialContent=(!string.IsNullOrEmpty(txtTestimonial.Text.Trim()))?txtTestimonial.Text.Trim():string.Empty,
                UpdatedDate=Utility.IndianTime,
                UpdatedBy=login.GetUserName(),
                Active=chkStatus.Checked

              }
        };

            if (save == 1)
            {

                int InsContent = alum.UpdateAlumini(lstContent, Sno);
                if (InsContent == -1)
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Updated Successfully');</script>");

                }
            }
        }

        //}

        //catch (Exception ex)
        //{
        //    Response.Write(ex.ToString());
        //}

    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("view.aspx", true);
    }
   
}