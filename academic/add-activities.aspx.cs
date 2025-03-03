using System;
using System.Data;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections.Generic;

public partial class activities : System.Web.UI.Page
{

    Bindddl Ddl = new Bindddl();
    pmistactivities PMA = new pmistactivities();
    protected void Page_Load(object sender, EventArgs e)
    {
        hdnID.Value = null;
        int value = 0;
        if (Request.QueryString["ACTID"] != null)
        {
            if (int.TryParse(Request.QueryString["ACTID"], out value))
            {
                //edit
                btnSave.Text = "Update";
                // lbldisplayText.Text = "Edit FAQ's";
                hdnID.Value = Convert.ToString(value);
                hdnID1.Value = Convert.ToString(value);
            }
            else
            {
                string script = string.Format(@" 
                    <script> 
                    Swal.fire({{ 
                        title: ' URL is incorrect. please try again', 
                        confirmButtonText: 'OK', 
                        customClass: {{ 
                            confirmButton: 'handle-btn-success'  
                        }} 
                    }}).then((result) => {{  
                            window.location.href = 'view-faqs.aspx';   
                    }}); 
                    </script>");
                ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);
            }
        }
        else
        {
            //  lbldisplayText.Text = "Add FAQ's";
            btnSave.Text = "Submit";
            //add
        }

        if (!IsPostBack)
        {
            Ddl.GetDepartmentddl(ddldepartment);
            Ddl.GetDepartmentddl(ddldepartmentIVI);
            ddldepartment.Items.Insert(0, new ListItem("", ""));
            ddldepartmentIVI.Items.Insert(0, new ListItem("", ""));
            if (hdnID.Value != null && !string.IsNullOrEmpty(hdnID.Value))
            {
                Bind(Convert.ToInt32(hdnID.Value));
            }
        }
    }
    public void Bind(int ID)
    {
        DataTable Dt = PMA.ViewAllDepartmentActivities("", "", Convert.ToString(ID));

        if (Dt.Rows.Count > 0)
        {
            if (!Convert.ToBoolean(Dt.Rows[0]["AVI"]))
            {
                divIVI.Style.Add("display", "none");
                divACD.Style.Add("display", "block");
                if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Department"])))
                {
                    ddldepartment.SelectedValue = Convert.ToString(Dt.Rows[0]["Department"]);
                }

                if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Title"])))
                {
                    txtTitle.Text = Convert.ToString(Dt.Rows[0]["Title"]);
                }

                if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["PdfFilename"])))
                {
                    RequiredFieldValidator2.Enabled = false;
                    hdnFileUpload.Value = Convert.ToString(Dt.Rows[0]["PdfFilename"]);
                    string applicantPhoto = Dt.Rows[0]["PdfFilename"].ToString();
                    string filepath = System.Configuration.ConfigurationManager.AppSettings["ActivitiesDoc"];
                    string fullFilePath = Path.Combine(filepath.Trim(), applicantPhoto);

                    // Determine the file extension to decide how to handle the file
                    string fileExtension = Path.GetExtension(fullFilePath).ToLower();
                    string fileType = fileExtension == ".pdf" ? "application/pdf" : "image/jpeg"; // Assuming it's an image for other extensions
                    string fileBase64 = string.Empty;

                    if (fileType == "application/pdf")
                    {
                        fileBase64 = fullFilePath;
                    }
                    else
                    {
                        byte[] fileBytes = File.ReadAllBytes(fullFilePath);
                        fileBase64 = Convert.ToBase64String(fileBytes);
                    }

                    string formattedImagePath = fileType == "application/pdf"
                        ? fullFilePath
                        : string.Format("data:{0};base64,{1}", fileType, fileBase64);

                    string script = string.Format("bindImageToPreview('{0}', 0, '{1}');", formattedImagePath, fileType);
                    ClientScript.RegisterStartupScript(this.GetType(), "bindImage0", script, true);

                }
            }
            else
            {
                divIVI.Style.Add("display", "Block");
                divACD.Style.Add("display", "none");
                if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Department"])))
                {
                    ddldepartmentIVI.SelectedValue = Convert.ToString(Dt.Rows[0]["Department"]);
                }

                if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Title"])))
                {
                    txtTitleIVI.Text = Convert.ToString(Dt.Rows[0]["Title"]);
                }
                if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Content"])))
                {
                    txtContentIVI.Text = Convert.ToString(Dt.Rows[0]["Content"]);
                }

                if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["PdfFilename"])))
                {
                    RequiredFieldValidator202.Enabled = false;
                    hdnFileUploadIVI.Value = Convert.ToString(Dt.Rows[0]["PdfFilename"]);
                    string applicantPhoto = Dt.Rows[0]["PdfFilename"].ToString();
                    string filepath = System.Configuration.ConfigurationManager.AppSettings["ActivitiesDoc"];
                    string fullFilePath = Path.Combine(filepath.Trim(), applicantPhoto);

                    // Determine the file extension to decide how to handle the file
                    string fileExtension = Path.GetExtension(fullFilePath).ToLower();
                    string fileType = fileExtension == ".pdf" ? "application/pdf" : "image/jpeg"; // Assuming it's an image for other extensions
                    string fileBase64 = string.Empty;

                    if (fileType == "application/pdf")
                    {
                        fileBase64 = fullFilePath;
                    }
                    else
                    {
                        byte[] fileBytes = File.ReadAllBytes(fullFilePath);
                        fileBase64 = Convert.ToBase64String(fileBytes);
                    }

                    string formattedImagePath = fileType == "application/pdf"
                        ? fullFilePath
                        : string.Format("data:{0};base64,{1}", fileType, fileBase64);

                    string script = string.Format("bindImageToPreviewIVI('{0}', 0, '{1}');", formattedImagePath, fileType);
                    ClientScript.RegisterStartupScript(this.GetType(), "bindImage01", script, true);

                }
            }
        }
    }



    protected void btnSave_Click(object sender, EventArgs e)
    {
        string labelerror = string.Empty;
        if (string.IsNullOrEmpty(ddldepartment.SelectedValue) && string.IsNullOrEmpty(txtTitle.Text))
        {
            labelerror = "Fill the mandatory fields.";
        }
        else if (string.IsNullOrEmpty(ddldepartment.SelectedValue))
        {
            labelerror = "Select department";
        }
        else if (string.IsNullOrEmpty(txtTitle.Text))
        {
            labelerror = "Enter title";
        }


        if (string.IsNullOrEmpty(labelerror))
        {
            if (Request.QueryString["ACTID"] == null)
            {
                int ret = 0;
                ret = AddDate();
                if (ret == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'Activity details has been added successfully', " +
                           "  icon: 'success', " +
                           "  allowOutsideClick: 'true', " +
                           "  customClass: { " +
                           "    icon: 'handle-icon-clr', " +
                           "    confirmButton: 'handle-btn-success' " +
                           "  } " +
                           "}).then((result) => { " +
                           "  window.location.href = '" + "add-activities.aspx" + "'; " +
                           "});", true);

                }
                else
                {
                    string script = string.Format(@" <script>
                        Swal.fire({{ 
                            title: 'Activities details couldn't be added due to a server or network issue. Please try again in some time!', 
                            confirmButtonText: 'OK', 
                            customClass: {{ 
                                confirmButton: 'handle-btn-success' 
                            }} 
                        }}).then((result) => {{  
                                window.location.href = 'add-activities.aspx';  
                            }} 
                        }});
                        </script>");
                    ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);
                    divIVI.Style.Add("Display", "none");
                    divACD.Style.Add("Display", "block");
                }
            }
            else
            {
                int ret = 0;
                ret = UpdateData();
                if (ret == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                            "Swal.fire({ " +
                            "  title: 'Activity details has been added successfully', " +
                            "  icon: 'success', " +
                            "  allowOutsideClick: 'true', " +
                            "  customClass: { " +
                            "    icon: 'handle-icon-clr', " +
                            "    confirmButton: 'handle-btn-success' " +
                            "  } " +
                            "}).then((result) => { " +
                            "  window.location.href = '" + "view-activities.aspx" + "'; " +
                            "});", true);
                }
                else
                {
                    string script = string.Format(@" <script>
                        Swal.fire({{ 
                            title: 'Activities details couldn't be added due to a server or network issue. Please try again in some time!', 
                            confirmButtonText: 'OK', 
                            customClass: {{ 
                                confirmButton: 'handle-btn-success' 
                            }} 
                        }}).then((result) => {{  
                                window.location.href = 'view-activities.aspx';  
                            }} 
                        }});
                        </script>");
                    ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);

                }
            }
        }
        else
        {
            //alert labelerror
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
            //"Swal.fire('Validation Alert', '" + labelerror + "!.', 'success');", true);
        }
    }

    public string Bindprojectname(int Prid)
    {
        string strname = string.Empty;
        try
        {
            DataTable dt = new DataTable();
            if (dt.Rows.Count > 0)
            {
                strname = Convert.ToString(dt.Rows[0]["ProjectName"]);
            }
        }
        catch (Exception ex)
        {
            //CI.StoreExceptionMessage("add-floor-plan.aspx", "Bindprojectname", ex.Message, "Not Fixed");
        }
        return strname;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ACTID"] == null)
        {
            Clear();
        }
        else
        {
            Response.Redirect("view-Activities.aspx");
        }
    }
    public int AddDate()
    {
        int ret = 0;
        //try
        //{
        PMA.strDepartment = ddldepartment.SelectedValue;
        PMA.strTitle = txtTitle.Text;
        PMA.strPdfFilename = SaveFile(FileUpload, "ActivitiesDoc", ddldepartment.SelectedValue);
        PMA.ActivitiyStatus = true;
        PMA.AVIStatus = false;
        PMA.strContent = "";
        PMA.strAddedBy = "Admin";
        ret = PMA.AddDepartmentActivities(PMA);
        //}
        //catch (Exception ex)
        //{
        //    // CI.StoreExceptionMessage("add-floor-plan.aspx", "AddProjectFloorPlan", ex.Message, "Not Fixed");
        //}
        return ret;
    }


    public int AddDateIVI()
    {
        int ret = 0;
        //try
        //{
        PMA.strDepartment = ddldepartmentIVI.SelectedValue;
        PMA.strTitle = txtTitleIVI.Text;
        PMA.strPdfFilename = SaveFile(FileUploadIVI, "ActivitiesDoc", ddldepartmentIVI.SelectedValue);
        PMA.ActivitiyStatus = true;
        PMA.strContent = txtContentIVI.Text;
        PMA.AVIStatus = true;
        PMA.strAddedBy = "Admin";
        ret = PMA.AddDepartmentActivities(PMA);
        //}
        //catch (Exception ex)
        //{
        //    // CI.StoreExceptionMessage("add-floor-plan.aspx", "AddProjectFloorPlan", ex.Message, "Not Fixed");
        //}
        return ret;
    }
    public int UpdateData()
    {
        int ret = 0;
        //try
        //{
        PMA.intACTID = Convert.ToInt32(hdnID.Value);
        PMA.strDepartment = ddldepartment.SelectedValue;
        PMA.strTitle = txtTitle.Text;
        if (FileUpload.HasFile)
        {
            PMA.strPdfFilename = SaveFile(FileUpload, "ActivitiesDoc", ddldepartment.SelectedValue);
        }
        else
        {
            PMA.strPdfFilename = hdnFileUpload.Value;
        }
        PMA.strContent = "";
        PMA.ActivitiyStatus = true;
        PMA.strUpdatedBy = "Admin";
        ret = PMA.UpdateDepartmentActivities(PMA);
        //}
        //catch (Exception ex)
        //{
        //    //CI.StoreExceptionMessage("add-floor-plan.aspx", "UpdateProjectFloorPlan", ex.Message, "Not Fixed");
        //}
        return ret;
    }

    public int UpdateDataIVI()
    {
        int ret = 0;
        try
        {
            PMA.intACTID = Convert.ToInt32(hdnID1.Value);
        PMA.strDepartment = ddldepartmentIVI.SelectedValue;
        PMA.strTitle = txtTitleIVI.Text;
        if (FileUploadIVI.HasFile)
        {
            PMA.strPdfFilename = SaveFile(FileUploadIVI, "ActivitiesDoc", ddldepartmentIVI.SelectedValue);
        }
        else
        {
            PMA.strPdfFilename = hdnFileUploadIVI.Value;
        }
        PMA.strContent = txtContentIVI.Text;
        PMA.ActivitiyStatus = true;
        PMA.strUpdatedBy = "Admin";
        ret = PMA.UpdateDepartmentActivities(PMA);
    }
        catch (Exception ex)
        {
        }
return ret;
    }
    public string SaveFile(FileUpload uploadedFile, string appkey, string Projectname)
    {
        int savefile = 0;
        string filename = string.Empty;
        //try
        //{
        if (uploadedFile.HasFile)
        {
            string filepath = System.Configuration.ConfigurationManager.AppSettings[appkey];
            string fileName = Path.GetFileName(uploadedFile.FileName);
            string fileExtension = Path.GetExtension(fileName);
            filename = GenerateFileName(Projectname.Trim(), fileExtension).Trim('-');
            string temppath = filepath.Trim() + @"\" + filename.Trim().Replace(" ", "");
            string savepath = Server.MapPath(temppath);
            uploadedFile.SaveAs(savepath);
            savefile = 1;
        }
        else
        {
            filename = "";
        }
        //}
        //catch (Exception ex)
        //{
        //    // CI.StoreExceptionMessage("add-floor-plan.aspx", "SaveFile", ex.Message, "Not Fixed");
        //}
        return filename.Contains(" ") ? filename.Replace(" ", "") : filename;
    }
    public string GenerateFileName(string Projectname, string fileExtension)
    {
        string randomString = GenerateRandomString(4);
        string newFileName = Projectname + randomString + fileExtension;
        return newFileName;
    }
    private string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var byteArray = new byte[length];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(byteArray);
        }
        var randomString = new char[length];
        for (int i = 0; i < length; i++)
        {
            randomString[i] = chars[byteArray[i] % chars.Length];
        }
        return new string(randomString);
    }
    public void Clear()
    {
        Response.Redirect(Request.Url.AbsolutePath);
    }





    protected void btnSaveIVI_Click(object sender, EventArgs e)
    {
        string labelerror = string.Empty;
        if (string.IsNullOrEmpty(ddldepartmentIVI.SelectedValue) && string.IsNullOrEmpty(txtTitleIVI.Text))
        {
            labelerror = "Fill the mandatory fields.";
        }
        else if (string.IsNullOrEmpty(ddldepartmentIVI.SelectedValue))
        {
            labelerror = "Select department";
        }
        else if (string.IsNullOrEmpty(txtTitleIVI.Text))
        {
            labelerror = "Enter title";
        }
        else if (string.IsNullOrEmpty(txtContentIVI.Text))
        {
            labelerror = "Enter content";
        }


        if (string.IsNullOrEmpty(labelerror))
        {
            if (Request.QueryString["ACTID"] == null)
            {
                int ret = 0;
                ret = AddDateIVI();
                if (ret == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'Activity details has been added successfully', " +
                           "  icon: 'success', " +
                           "  allowOutsideClick: 'true', " +
                           "  customClass: { " +
                           "    icon: 'handle-icon-clr', " +
                           "    confirmButton: 'handle-btn-success' " +
                           "  } " +
                           "}).then((result) => { " +
                           "  window.location.href = '" + "add-activities.aspx" + "'; " +
                           "});", true);
                    divIVI.Style.Add("Display", "Block");
                    divACD.Style.Add("Display", "none");

                }
                else
                {
                    string script = string.Format(@" <script>
                        Swal.fire({{ 
                            title: 'Activities details couldn't be added due to a server or network issue. Please try again in some time!', 
                            confirmButtonText: 'OK', 
                            customClass: {{ 
                                confirmButton: 'handle-btn-success' 
                            }} 
                        }}).then((result) => {{  
                                window.location.href = 'add-floor-plan.aspx';  
                            }} 
                        }});
                        </script>");
                    ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);

                }
            }
            else
            {
                int ret = 0;
                ret = UpdateDataIVI();
                if (ret == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                            "Swal.fire({ " +
                            "  title: 'Activity details has been added successfully', " +
                            "  icon: 'success', " +
                            "  allowOutsideClick: 'true', " +
                            "  customClass: { " +
                            "    icon: 'handle-icon-clr', " +
                            "    confirmButton: 'handle-btn-success' " +
                            "  } " +
                            "}).then((result) => { " +
                            "  window.location.href = '" + "view-activities.aspx" + "'; " +
                            "});", true);
                }
                else
                {
                    string script = string.Format(@" <script>
                        Swal.fire({{ 
                            title: 'Activities details couldn't be added due to a server or network issue. Please try again in some time!', 
                            confirmButtonText: 'OK', 
                            customClass: {{ 
                                confirmButton: 'handle-btn-success' 
                            }} 
                        }}).then((result) => {{  
                                window.location.href = 'add-activities.aspx';  
                            }} 
                        }});
                        </script>");
                    ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);

                }
            }
        }
        else
        {
            //alert labelerror
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
            //"Swal.fire('Validation Alert', '" + labelerror + "!.', 'success');", true);
        }

    }

    protected void btnCancelIVI_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ACTID"] == null)
        {
            Clear();
        }
        else
        {
            Response.Redirect("view-Activities.aspx");
        }
    }
}
