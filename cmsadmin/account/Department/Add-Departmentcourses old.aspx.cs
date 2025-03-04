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
                ddlDepartment.Items.Insert(0, new ListItem("Select Faculty", ""));
            }

        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {


        deptid = Convert.ToInt32(ddlDepartment.SelectedValue);

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


        if (ret == 5)
        {
            Clear();
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
                                Introduction = txtindroduction.Text
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

                    ret += De.AddPO(PO1);
                }


                List<CMSDepartment> PEO1 = new List<CMSDepartment>();

                if (PEOList.Count > 0)
                {
                    foreach (string PEO in PEOList)
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
                    ret += De.AddPO(PEO1);
                }

                List<CMSDepartment> PSO = new List<CMSDepartment>();
                if (PSOList.Count > 0)
                {
                    foreach (string strpso in PSOList)
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
                    ret += De.AddPO(PSO);
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
                            curriculum = textBoxValue,
                            SectionName = "curriculum",
                            PDFFilename = savedFileName,
                            Departmentid = deptid,
                        };
                        programmeFiles.Add(programmeFile);
                    }
                }

                ret += De.Addcurriculum(programmeFiles);


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
    }

    public void Clear()
    {
        ddlDepartment.SelectedIndex = 0;
        txtProgrammeOffered.Text = "";
        txtpo.Text = "";
        TXTPEO.Text = "";
        TXTPSO.Text = "";
        txtindroduction.Text = "";
        textBox.Text = "";

    }



    //public bool AlreadyExist(int ID, string name)
    //{
    //    bool isAvail = false;
    //    DataTable dt = De.Viewdepartmentbyfacultyidandname(ID, name);
    //    if (dt.Rows.Count > 0)
    //    {
    //        isAvail = true;
    //    }

    //    return isAvail;
    //}
    protected void btnView_Click(object sender, EventArgs e)
    {


    }
}