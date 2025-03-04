using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using System.ServiceModel.Activities;

public partial class cmsadmin_account_Default : System.Web.UI.Page
{
    private static int deptid;
    private static int ret;
    CMSDepartment De = new CMSDepartment();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblDisplayText.Text = "Add Department Course";
            DataTable dt = De.ViewDepartment();
            if (dt.Rows.Count > 0)
            {
                ddlDepartment.DataSource = dt;
                ddlDepartment.DataTextField = "DepartmentName";
                ddlDepartment.DataValueField = "DepartmentID";
                ddlDepartment.DataBind();
                ddlDepartment.Items.Insert(0, new ListItem("Select Department", ""));
            }
            if (Request.QueryString["Dept"] != null)
            {
                string dept = Convert.ToString(Request.QueryString["Dept"]);
                ddlDepartment.SelectedValue = dept;
                ddlDepartment.Enabled = false;

                // doctoratebutton.Visible = false;
                //doctoratebuttonpo.Visible = false;
                // doctoratebuttonPEO.Visible = false;
                //doctoratebuttonPSO.Visible = false;
                //addFileUploadBtn.Visible = false;
                divplus.Visible = false;
                Divpo.Visible = false;
                divpeo.Visible = false;
                divpso.Visible = false;


                divfileadd.Visible = false;
                divPOintro.Visible = false;
                divPEOintro.Visible = false;
                divPSOintro.Visible = false;

                RequiredFieldValidator3.Visible = false;
                RequiredFieldValidator8.Visible = false;
                RequiredFieldValidator9.Visible = false;
            }
            else
            {
                ddlDepartment.Enabled = true;


                divplus.Visible = true;
                Divpo.Visible = true;
                divpeo.Visible = true;
                divpso.Visible = true;
                divfileadd.Visible = true;

                divPOintro.Visible = true;
                divPEOintro.Visible = true;
                divPSOintro.Visible = true;

                RequiredFieldValidator3.Visible = true;
                RequiredFieldValidator8.Visible = true;
                RequiredFieldValidator9.Visible = true;
            }

        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        bool isavail = true;

        deptid = Convert.ToInt32(ddlDepartment.SelectedValue);

        if (Request.QueryString["Dept"] != null)
        {
            string str = txtProgrammeOffered.Text;
            if (!string.IsNullOrEmpty(str))
            {
                GetProgrammeOffered("txtProgrammeOffered");
            }
            else
            {
                lblmessage.Text = "Enter Programme Offered ";
            }

            string po = txtpo.Text;
            if (!string.IsNullOrEmpty(po))
            {
                GetProgrammeOffered("txtpo");
            }
            else
            {
                lblmessage.Text = "Enter PO ";
            }
            string PEO = TXTPEO.Text;
            if (!string.IsNullOrEmpty(PEO))
            {
                GetProgrammeOffered("TXTPEO");
            }
            else
            {
                lblmessage.Text = "Enter PEO ";
            }

            string PSO = TXTPSO.Text;
            if (!string.IsNullOrEmpty(PSO))
            {
                GetProgrammeOffered("TXTPSO");
            }
            else
            {
                lblmessage.Text = "Enter PSO ";
            }


            string title = textBox.Text;
            if (!string.IsNullOrEmpty(title) && fileUpload.HasFile)
            {
                Get();
            }
            else
            {
                lblmessage.Text = "please file curriculum";
            }
        }
        else
        {
            if (!AlreadyExist(deptid))
            {
                string str = txtProgrammeOffered.Text;
                if (!string.IsNullOrEmpty(str))
                {
                    GetProgrammeOffered("txtProgrammeOffered");
                }
                else
                {
                    lblmessage.Text = "Enter Programme Offered ";
                }

                string po = txtpo.Text;
                if (!string.IsNullOrEmpty(po))
                {
                    GetProgrammeOffered("txtpo");
                }
                else
                {
                    lblmessage.Text = "Enter PO ";
                }
                string PEO = TXTPEO.Text;
                if (!string.IsNullOrEmpty(PEO))
                {
                    GetProgrammeOffered("TXTPEO");
                }
                else
                {
                    lblmessage.Text = "Enter PEO ";
                }

                string PSO = TXTPSO.Text;
                if (!string.IsNullOrEmpty(PSO))
                {
                    GetProgrammeOffered("TXTPSO");
                }
                else
                {
                    lblmessage.Text = "Enter PSO ";
                }


                string title = textBox.Text;
                if (!string.IsNullOrEmpty(title) && fileUpload.HasFile)
                {
                    Get();
                }
                else
                {
                    lblmessage.Text = "please file curriculum";
                }
            }
            else
            {
                lblmessage.Text = "Department Already Exist";
            }
        }

        if (ret == 5)
        {
            Clear();
            lblmessage.Text = "";
            lblmessage.Text = "your data saved successfully!";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CustomSuccessPopup",
        "Swal.fire({ title: 'Well Done!', text: 'Your data has been saved.', icon: 'success', confirmButtonText: 'OK' });", true);

        }
    }

    public void GetProgrammeOffered(string id)
    {
        try
        {
            List<string> programmeOfferedList = new List<string>();
            List<string> poList = new List<string>();
            List<string> PEOList = new List<string>();
            List<string> PSOList = new List<string>();

            List<int> certRowCount = GetRowCount(id);

            if (certRowCount != null && certRowCount.Count > 0)
            {
                foreach (int row in certRowCount)
                {
                    string key = id + (row == 0 ? "" : row.ToString());

                    string normalizedKey = Request.Form.AllKeys
                        .FirstOrDefault(k => k.EndsWith(key, StringComparison.OrdinalIgnoreCase));

                    if (normalizedKey != null)
                    {
                        string value = Request.Form[normalizedKey];

                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            if (id == "txtProgrammeOffered")
                            {
                                programmeOfferedList.Add(value);
                            }
                            else if (id == "txtpo")
                            {
                                poList.Add(value);
                            }
                            else if (id == "TXTPEO")
                            {
                                PEOList.Add(value);
                            }
                            else if (id == "TXTPSO")
                            {
                                PSOList.Add(value);
                            }
                        }
                    }
                }

                List<CMSDepartment> programmeOfferedList1 = new List<CMSDepartment>();


                if (programmeOfferedList.Count > 0)
                {
                    foreach (string programme in programmeOfferedList)
                    {
                        CMSDepartment de = new CMSDepartment
                        {
                            Departmentid = deptid,
                            SectionName = "ProgrammeOffered",
                            Content = programme
                        };
                        programmeOfferedList1.Add(de);
                    }

                    ret = De.AddProgrammedoffered(programmeOfferedList1);
                }
                List<CMSDepartment> PO1 = new List<CMSDepartment>();
                int count = 0;
                if (poList.Count > 0)
                {
                    foreach (string p1 in poList)
                    {

                        if (count == 0)
                        {
                            count++;
                            CMSDepartment PO = new CMSDepartment
                            {
                                Departmentid = deptid,
                                SectionName = "PO",
                                Content = p1,
                                Introduction = txtindroductionPO.Text
                            };
                            PO1.Add(PO);
                        }
                        else
                        {
                            CMSDepartment PO = new CMSDepartment
                            {
                                Departmentid = deptid,
                                SectionName = "PO",
                                Content = p1,
                                Introduction = ""
                            };
                            PO1.Add(PO);
                        }
                    }
                    if (ret == 1)
                    {
                        ret += De.AddPO(PO1);

                    }
                    else
                    {
                        lblmessage.Text = "programmed offered Section not added please try again.";
                    }


                }


                List<CMSDepartment> PEO1 = new List<CMSDepartment>();

                if (PEOList.Count > 0)
                {
                    int countPEO = 0;
                    foreach (string PEO in PEOList)
                    {

                        if (countPEO == 0)
                        {
                            countPEO++;
                            CMSDepartment PEOCMS = new CMSDepartment
                            {
                                Departmentid = deptid,
                                SectionName = "PEO",
                                Content = PEO,
                                Introduction = txtindroductionPSO.Text
                            };
                            PEO1.Add(PEOCMS);
                        }
                        else
                        {
                            CMSDepartment PEOCMS = new CMSDepartment
                            {
                                Departmentid = deptid,
                                SectionName = "PEO",
                                Content = PEO,
                                Introduction = ""
                            };
                            PEO1.Add(PEOCMS);
                        }
                    }
                    if (ret == 2)
                    {
                        ret += De.AddPO(PEO1);
                    }
                    else
                    {
                        lblmessage.Text = "PO Section not added please try again.";
                    }
                }

                List<CMSDepartment> PSO = new List<CMSDepartment>();
                if (PSOList.Count > 0)
                {
                    int countPSO = 0;
                    foreach (string strpso in PSOList)
                    {
                        if (countPSO == 0)
                        {
                            countPSO++;
                            CMSDepartment PSOCMS = new CMSDepartment
                            {
                                Departmentid = deptid,
                                SectionName = "PSO",
                                Content = strpso,
                                Introduction = txtindroductionPSO.Text
                            };
                            PSO.Add(PSOCMS);
                        }
                        else
                        {

                            CMSDepartment PSOCMS = new CMSDepartment
                            {
                                Departmentid = deptid,
                                SectionName = "PSO",
                                Content = strpso,
                                Introduction = ""
                            };
                            PSO.Add(PSOCMS);
                        }

                    }
                    if (ret == 3)
                    {
                        ret += De.AddPO(PSO);
                    }
                    else
                    {
                        lblmessage.Text = "PEO Section not added please try again.";
                    }
                }

            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public List<int> GetRowCount(string prefix)
    {
        List<int> rowIndexes = new List<int>();

        if (Request != null && Request.Form != null)
        {
            foreach (string key in Request.Form.AllKeys)
            {
                string normalizedKey = key.Contains('$') ? key.Substring(key.LastIndexOf('$') + 1) : key;

                if (normalizedKey.StartsWith(prefix))
                {
                    string rowIndexString = normalizedKey.Replace(prefix, "");
                    int rowIndex = 0;

                    if (string.IsNullOrEmpty(rowIndexString))
                    {
                        rowIndexes.Add(0);
                    }
                    else if (int.TryParse(rowIndexString, out rowIndex))
                    {
                        rowIndexes.Add(rowIndex);
                    }
                }
            }
        }

        return rowIndexes;
    }

    public void Get()
    {
        try
        {
            List<CMSDepartment> programmeFiles = new List<CMSDepartment>();

            List<int> rowIndexes = GetRowCount("textBox");

            if (rowIndexes != null && rowIndexes.Count > 0)
            {
                foreach (int rowIndex in rowIndexes)
                {
                    string baseTextBoxKey = "textBox" + (rowIndex == 0 ? "" : rowIndex.ToString());
                    string baseFileUploadKey = "fileUpload" + (rowIndex == 0 ? "" : rowIndex.ToString());

                    string normalizedTextBoxKey = Request.Form.AllKeys
                        .FirstOrDefault(k => k.EndsWith(baseTextBoxKey, StringComparison.OrdinalIgnoreCase));
                    string normalizedFileUploadKey = Request.Files.AllKeys
                        .FirstOrDefault(k => k.EndsWith(baseFileUploadKey, StringComparison.OrdinalIgnoreCase));

                    string textBoxValue = normalizedTextBoxKey != null ? Request.Form[normalizedTextBoxKey].Trim() : null;
                    HttpPostedFile uploadedFile = normalizedFileUploadKey != null ? Request.Files[normalizedFileUploadKey] : null;
                    if (!string.IsNullOrWhiteSpace(textBoxValue) && uploadedFile != null && uploadedFile.ContentLength > 0)
                    {
                        string savedFileName = SaveFile(uploadedFile, "CSMDepartmentPDF");

                        CMSDepartment programmeFile = new CMSDepartment
                        {
                            Content = textBoxValue,
                            SectionName = "curriculum",
                            PDFFilename = savedFileName,
                            Departmentid = deptid,
                        };
                        programmeFiles.Add(programmeFile);
                    }
                }

                if (ret == 4)
                {
                    ret += De.Addcurriculum(programmeFiles);
                }
                else
                {
                    lblmessage.Text = "PSO Section not added please try again.";
                }
            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public string SaveFile(HttpPostedFile uploadedFile, string appkey)
    {
        int savefile = 0;
        string filename = string.Empty;
        try
        {
            string filepath = System.Configuration.ConfigurationManager.AppSettings[appkey];

            string fileName = Path.GetFileName(uploadedFile.FileName);

            string fileExtension = Path.GetExtension(fileName);

            filename = GenerateFileName(Convert.ToString(deptid), fileExtension).Trim('-');

            string temppath = filepath.Trim() + @"\" + filename.Trim();

            string savepath = Server.MapPath(temppath);

            uploadedFile.SaveAs(savepath);

            savefile = 1;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        return filename;
    }

    public string GenerateFileName(string strcat, string fileExtension)
    {
        string randomString = GenerateRandomString(4);
        string newFileName = strcat + randomString + fileExtension;
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

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //lblDisplayText.Text = "Add Department";
        lblmessage.Text = "";
        Clear();
        ddlDepartment.Enabled = true;


        // doctoratebutton.Visible = true;
        // doctoratebuttonpo.Visible = true;
        // doctoratebuttonPEO.Visible = true;
        // doctoratebuttonPSO.Visible = true;
        // addFileUploadBtn.Visible = true;


    }

    public void Clear()
    {
        ddlDepartment.SelectedIndex = 0;
        txtProgrammeOffered.Text = "";
        txtpo.Text = "";
        TXTPEO.Text = "";
        TXTPSO.Text = "";
        txtindroductionPO.Text = "";
        txtindroductionPEO.Text = "";
        txtindroductionPSO.Text = "";
        textBox.Text = "";
        ddlDepartment.Enabled = true;


        divplus.Visible = true;
        Divpo.Visible = true;
        divpeo.Visible = true;
        divpso.Visible = true;
        divfileadd.Visible = true;

        divPOintro.Visible = true;
        divPEOintro.Visible = true;
        divPSOintro.Visible = true;

        RequiredFieldValidator3.Visible = true;
        RequiredFieldValidator8.Visible = true;
        RequiredFieldValidator9.Visible = true;

        //string urlWithoutQueryString = Request.Url.GetLeftPart(UriPartial.Path);
        //Response.Redirect(urlWithoutQueryString, false);
    }



    public bool AlreadyExist(int ID)
    {
        bool isAvail = false;
        DataTable dt = De.ViewDepartmentCourses(ID);
        if (dt.Rows.Count > 0)
        {
            isAvail = true;
        }

        return isAvail;
    }
    protected void btnView_Click(object sender, EventArgs e)
    {


    }

    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (AlreadyExist(Convert.ToInt32(ddlDepartment.SelectedValue)))
        {
            string message = "Department Already exist!";
            string script = String.Format("alert('{0}');", message);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);

        }
    }
}