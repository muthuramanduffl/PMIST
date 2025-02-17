
using System;
using System.Data;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public partial class PMIST_Admin_Mcentre_CSAS : System.Web.UI.Page
{
    Bindddl Ddl = new Bindddl();
    //pmistCSAS CSAS = new pmistCSAS();
    pmistcentrecsas csas = new pmistcentrecsas();
    string lastfilename = string.Empty;
    int count = 0;
    int retcount = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
    


        hdnID.Value = null;
        int value = 0;
        if (Request.QueryString["TCCID"] != null)
        {
            if (int.TryParse(Request.QueryString["TCCID"], out value))
            {
                //edit
                btnSave.Text = "Update";
                lbldisplayText.Text = "Edit Centre For Students and Administrative Services";
                hdnID.Value = Convert.ToString(value);
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
                            window.location.href = 'view-CSAS.aspx';   
                    }}); 
                    </script>");
                ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);
            }
        }
        else
        {
            lbldisplayText.Text = "Add Centre For Students and Administrative Services";
            btnSave.Text = "Submit";
            //add
        }

        if (!IsPostBack)
        {
            Ddl.Getcentertypeddl(ddltype);
            ddltype.Items.Insert(0, new ListItem("", ""));
            if (hdnID.Value != null && !string.IsNullOrEmpty(hdnID.Value))
            {
                Bind(Convert.ToInt32(hdnID.Value));
            }
        }


    }

    public void Bind(int ID)
    {
        DataTable Dt = csas.viewAllcentrecontenttype1("","",Convert.ToString(ID));

        if (Dt.Rows.Count > 0)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["CentreID"])))
            {
                ddltype.SelectedValue = Convert.ToString(Dt.Rows[0]["CentreID"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Title"])))
            {
                txtTitle.Text = Convert.ToString(Dt.Rows[0]["Title"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["DisplayStatus"])))
            {
                toggleActiveInactive.Checked = Convert.ToBoolean(Dt.Rows[0]["DisplayStatus"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Content"])))
            {
                txtContent.Text = Convert.ToString(Dt.Rows[0]["Content"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Cname_one"])))
            {
                txtC1Name.Text = Convert.ToString(Dt.Rows[0]["Cname_one"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Designamtion_one"])))
            {
                txtC1Designation.Text = Convert.ToString(Dt.Rows[0]["Designamtion_one"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Mobilenumber_one"])))
            {
                txtC1MobileNo.Text = Convert.ToString(Dt.Rows[0]["Mobilenumber_one"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["EmailID_one"])))
            {
                txtC1Emailid.Text = Convert.ToString(Dt.Rows[0]["EmailID_one"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Cname_two"])))
            {
                txtC2Name.Text = Convert.ToString(Dt.Rows[0]["Cname_two"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Designamtion_two"])))
            {
                txtC2Designation.Text = Convert.ToString(Dt.Rows[0]["Designamtion_two"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Mobilenumber_two"])))
            {
                txtC2MobileNo.Text = Convert.ToString(Dt.Rows[0]["Mobilenumber_two"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["EmailID_two"])))
            {
                txtC2Emailid.Text = Convert.ToString(Dt.Rows[0]["EmailID_two"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Cname_three"])))
            {
                txtC3Name.Text = Convert.ToString(Dt.Rows[0]["Cname_three"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Designamtion_three"])))
            {
                txtC3Designation.Text = Convert.ToString(Dt.Rows[0]["Designamtion_three"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Mobilenumber_three"])))
            {
                txtC3MobileNo.Text = Convert.ToString(Dt.Rows[0]["Mobilenumber_three"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["EmailID_three"])))
            {
                txtC3Emailid.Text = Convert.ToString(Dt.Rows[0]["EmailID_three"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Imges"])))
            {
                hdnimage.Value = Convert.ToString(Dt.Rows[0]["Imges"]);
                Divimageupload.Style.Add("display", "none");
                RequiredFieldValidator2.Enabled = false;
                RequiredFieldValidator2.Visible = false;
            }
            
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["TCCID"] == null)
        {
            Clear();
            Response.Redirect(Request.Url.GetLeftPart(UriPartial.Path));
        }
        else
        {
            Response.Redirect("");
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string lblerror = string.Empty;
        if (string.IsNullOrEmpty(txtTitle.Text) && string.IsNullOrEmpty(txtContent.Text))
        {
            lblerror = "Fill all the field";
        }
        else if (string.IsNullOrEmpty(txtTitle.Text))
        {
            lblerror = "Select title";
        }
        else if (string.IsNullOrEmpty(txtContent.Text))
        {
            lblerror = "Enter content";
        }

        if (string.IsNullOrEmpty(lblerror))
        {
            if (Request.QueryString["TCCID"] == null)
            {
                int ret = 0;
                ret = AddData();
                if (ret == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                            "Swal.fire({ " +
                            "  title: 'Centre for students and administrative services details has been added successfully.', " +
                            "  icon: 'success', " +
                            "  allowOutsideClick: 'true', " +
                            "  customClass: { " +
                            "    icon: 'handle-icon-clr', " +
                            "    confirmButton: 'handle-btn-success' " +
                            "  } " +
                            "}).then((result) => { " +
                            "  window.location.href = '" + "add-csas.aspx" + "'; " +
                            "});", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
      "Swal.fire({ " +
      "  title: 'Centre for students and administrative services details has not been added due to a server issue.', " +  // Corrected the title string
      "  icon: 'success', " +
      "  allowOutsideClick: true, " +  // No need for quotes around true
      "  customClass: { " +
      "    icon: 'handle-icon-clr', " +
      "    confirmButton: 'handle-btn-success' " +
      "  } " +
      "});", true);

                }
            }
            else
            {
                int ret = 0;
                ret = Updatedata();
                if (ret == 1)
                {
                   
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'Centre for students and administrative services details has been updated successfully.', " +
                           "  icon: 'success', " +
                           "  allowOutsideClick: 'true', " +
                           "  customClass: { " +
                           "    icon: 'handle-icon-clr', " +
                           "    confirmButton: 'handle-btn-success' " +
                           "  } " +
                           "}).then((result) => { " +
                           "  window.location.href = '" + "add-CSAS.aspx" + "'; " +
                           "});", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                          "Swal.fire({ " +
                          "  title: 'Centre for students and administrative services details has not been update due to a server issue.', " +
                          "  icon: 'success', " +
                          "  allowOutsideClick: 'true', " +
                          "  customClass: { " +
                          "    icon: 'handle-icon-clr', " +
                          "    confirmButton: 'handle-btn-success' " +
                          "  } " +
                          "}).then((result) => { " +
                          "  window.location.href = '" + "view-CSAS.aspx" + "'; " +
                          "});", true);
                }
            }
        }
    }

    public int AddData()
    {
        int rowaffected = 0;
        //try
        //{

            csas.strcentreID = ddltype.SelectedValue;
            csas.strtitle = txtTitle.Text;
            string encodedText = HttpUtility.HtmlEncode(txtContent.Text);
            string decodedText = HttpUtility.HtmlDecode(encodedText);
            csas.strcontent = decodedText;
            csas.booldisplaystatus = toggleActiveInactive.Checked;
            csas.strCnameOne = txtC1Name.Text;
            csas.strDesignationOne = txtC1Designation.Text;
            csas.strMobilenumberOne = txtC1MobileNo.Text;
            csas.strEmailiDOne = txtC1Emailid.Text;

            csas.strCnametwo = txtC2Name.Text;
            csas.strDesignationtwo = txtC2Designation.Text;
            csas.strMobilenumbertwo = txtC2MobileNo.Text;
            csas.strEmailiDtwo = txtC2Emailid.Text;

            csas.strCnamethree = txtC3Name.Text;
            csas.strDesignationthree = txtC3Designation.Text;
            csas.strMobilenumberthree = txtC3MobileNo.Text;
            csas.strEmailiDthree = txtC3Emailid.Text;

            csas.strPageType = "type1";

            List<string> uploadedFileNames = new List<string>();

            if (flUpload.HasFiles)
            {
                foreach (HttpPostedFile uploadedFile in flUpload.PostedFiles)
                {
                    if (uploadedFile.ContentLength > 0)
                    {
                        // Get the file name and create a unique file name using a GUID
                        string fileName = Path.GetFileName(uploadedFile.FileName);

                        string strfilename = SaveFile(flUpload, "Centreimages", ddltype.SelectedValue);
                        uploadedFileNames.Add(strfilename);
                    }
                }


                string concatenatedFileNames = string.Join(",", uploadedFileNames);
                string[] fileNamesArray = concatenatedFileNames.Split(',');

                csas.strimages = concatenatedFileNames;

            }
            csas.straddedBy = "admin";
            rowaffected = csas.addcentrecontenttype1(csas);
        //}
        //catch (Exception ex)
        //{
        //    //
        //}

        return rowaffected;

    }

    public int Updatedata()
    {
        int rowaffected = 0;
        try
        {
            csas.intTCCID = Convert.ToInt32(hdnID.Value);
            csas.strcentreID = ddltype.SelectedValue;
            csas.strtitle = txtTitle.Text;
            string encodedText = HttpUtility.HtmlEncode(txtContent.Text);
            string decodedText = HttpUtility.HtmlDecode(encodedText);
            csas.strcontent = decodedText;
            csas.booldisplaystatus = toggleActiveInactive.Checked;
            csas.strCnameOne = txtC1Name.Text;
            csas.strDesignationOne = txtC1Designation.Text;
            csas.strMobilenumberOne = txtC1MobileNo.Text;
            csas.strEmailiDOne = txtC1Emailid.Text;

            csas.strCnametwo = txtC2Name.Text;
            csas.strDesignationtwo = txtC2Designation.Text;
            csas.strMobilenumbertwo = txtC2MobileNo.Text;
            csas.strEmailiDtwo = txtC2Emailid.Text;

            csas.strCnamethree = txtC3Name.Text;
            csas.strDesignationthree = txtC3Designation.Text;
            csas.strMobilenumberthree = txtC3MobileNo.Text;
            csas.strEmailiDthree = txtC3Emailid.Text;

            csas.strPageType = "type1";
            csas.strimages = hdnimage.Value;
            csas.straddedBy = "admin";

            rowaffected = csas.Updatecentrecontenttype1(csas);



        }
        catch (Exception ex)
        {
            //
        }

        return rowaffected;
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
}