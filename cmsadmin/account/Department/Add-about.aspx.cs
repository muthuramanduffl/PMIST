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

public partial class cmsadmin_account_about : System.Web.UI.Page
{
    private static int deptid;
    private static int ret;
    CMSDepartment d = new CMSDepartment();
    CMSDepartmentabout De = new CMSDepartmentabout();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblDisplayText.Text = "Add Department About";
            DataTable dt = d.ViewDepartment();
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


                Divpo.Visible = false;
                divpeo.Visible = false;
                divpso.Visible = false;


                // divfileadd.Visible = false;

            }
            else
            {
                ddlDepartment.Enabled = true;



                Divpo.Visible = true;
                divpeo.Visible = true;
                divpso.Visible = true;
                //  divfileadd.Visible = true;


            }

        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        bool isavail = true;

        deptid = Convert.ToInt32(ddlDepartment.SelectedValue);
        string str = txtIntroContent.Text;
        if (Request.QueryString["Dept"] != null)
        {
            if (!string.IsNullOrEmpty(str))
            {
                De.Departmentid = Convert.ToInt32(ddlDepartment.SelectedValue);
                De.SectionName = "Intro content";
                string encodedText = HttpUtility.HtmlEncode(txtIntroContent.Text);
                string decodedText = HttpUtility.HtmlDecode(encodedText);
                De.Content = decodedText;
                // add function
                ret = De.AddDepartmenntAboutSingle(De);
            }
            else
            {
                lblmessage.Text = "Enter Intro Content ";
            }

            string po = txtpo.Text;
            if (!string.IsNullOrEmpty(po))
            {
                GetIntroContent("txtpo");
            }
            else
            {
                lblmessage.Text = "Enter Vision ";
            }
            string PEO = TXTPEO.Text;
            if (!string.IsNullOrEmpty(PEO))
            {
                GetIntroContent("TXTPEO");
            }
            else
            {
                lblmessage.Text = "Enter Mission ";
            }

            string PSO = TXTPSO.Text;
            if (!string.IsNullOrEmpty(PSO))
            {
                GetIntroContent("TXTPSO");
            }
            else
            {
                lblmessage.Text = "Enter Objective ";
            }
        }
        else
        {
            if (!AlreadyExist(deptid))
            {
                De.Departmentid = Convert.ToInt32(ddlDepartment.SelectedValue);
            
                string encodedText = HttpUtility.HtmlEncode(txtIntroContent.Text);
                string decodedText = HttpUtility.HtmlDecode(encodedText);
                De.Content = decodedText;
                De.SectionName = "Intro content";
                // add function
                ret = De.AddDepartmenntAboutSingle(De);

                string po = txtpo.Text;
                if (!string.IsNullOrEmpty(po))
                {
                    GetIntroContent("txtpo");
                }
                else
                {
                    lblmessage.Text = "Enter Vision ";
                }
                string PEO = TXTPEO.Text;
                if (!string.IsNullOrEmpty(PEO))
                {
                    GetIntroContent("TXTPEO");
                }
                else
                {
                    lblmessage.Text = "Enter Mission ";
                }
                string PSO = TXTPSO.Text;
                if (!string.IsNullOrEmpty(PSO))
                {
                    GetIntroContent("TXTPSO");
                }
                else
                {
                    lblmessage.Text = "Enter Objective ";
                }

            }
            else
            {
                lblmessage.Text = "Department Already Exist";
            }
        }

        if (ret == 4)
        {
            Clear();
            lblmessage.Text = "";
            lblmessage.Text = "your data saved successfully!";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CustomSuccessPopup",
        "Swal.fire({ title: 'Well Done!', text: 'Your data has been saved.', icon: 'success', confirmButtonText: 'OK' });", true);

        }
    }

    public void GetIntroContent(string id)
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

                            if (id == "txtpo")
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

                List<CMSDepartmentabout> programmeOfferedList1 = new List<CMSDepartmentabout>();


                //if (programmeOfferedList.Count > 0)
                //{
                //    foreach (string programme in programmeOfferedList)
                //    {
                //        CMSDepartmentabout de = new CMSDepartmentabout
                //        {
                //            Departmentid = Convert.ToInt32(ddlDepartment.SelectedValue),
                //            SectionName = "Introcontent",
                //            Content = programme
                //        };
                //        programmeOfferedList1.Add(de);
                //    }

                //    ret = De.AddDepartmenntAbout(programmeOfferedList1);
                //}
                List<CMSDepartmentabout> PO1 = new List<CMSDepartmentabout>();
                int count = 0;
                if (poList.Count > 0)
                {
                    foreach (string p1 in poList)
                    {

                        if (count == 0)
                        {
                            count++;
                            CMSDepartmentabout PO = new CMSDepartmentabout
                            {
                                Departmentid = Convert.ToInt32(ddlDepartment.SelectedValue),
                                SectionName = "Vision",
                                Content = p1,
                                Introduction = ""
                            };
                            PO1.Add(PO);
                        }
                        else
                        {
                            CMSDepartmentabout PO = new CMSDepartmentabout
                            {
                                Departmentid = Convert.ToInt32(ddlDepartment.SelectedValue),
                                SectionName = "Vision",
                                Content = p1,
                                Introduction = ""
                            };
                            PO1.Add(PO);
                        }
                    }
                    if (ret == 1)// about add ret get to check
                    {
                        ret += De.AddDepartmenntAbout(PO1);

                    }
                    else
                    {
                        lblmessage.Text = "Intro Section not added please try again.";
                    }
                }


                List<CMSDepartmentabout> PEO1 = new List<CMSDepartmentabout>();

                if (PEOList.Count > 0)
                {
                    int countPEO = 0;
                    foreach (string PEO in PEOList)
                    {

                        if (countPEO == 0)
                        {
                            countPEO++;
                            CMSDepartmentabout PEOCMS = new CMSDepartmentabout
                            {
                                Departmentid = Convert.ToInt32(ddlDepartment.SelectedValue),
                                SectionName = "Mission",
                                Content = PEO,
                                Introduction = ""
                            };
                            PEO1.Add(PEOCMS);
                        }
                        else
                        {
                            CMSDepartmentabout PEOCMS = new CMSDepartmentabout
                            {
                                Departmentid = Convert.ToInt32(ddlDepartment.SelectedValue),
                                SectionName = "Mission",
                                Content = PEO,
                                Introduction = ""
                            };
                            PEO1.Add(PEOCMS);
                        }
                    }
                    if (ret == 2)
                    {
                        ret += De.AddDepartmenntAbout(PEO1);
                    }
                    else
                    {
                        lblmessage.Text = "Vision Section not added please try again.";
                    }
                }

                List<CMSDepartmentabout> PSO = new List<CMSDepartmentabout>();
                if (PSOList.Count > 0)
                {
                    int countPSO = 0;
                    foreach (string strpso in PSOList)
                    {
                        if (countPSO == 0)
                        {
                            countPSO++;
                            CMSDepartmentabout PSOCMS = new CMSDepartmentabout
                            {
                                Departmentid = Convert.ToInt32(ddlDepartment.SelectedValue),
                                SectionName = "Objective",
                                Content = strpso,
                                Introduction = ""
                            };
                            PSO.Add(PSOCMS);
                        }
                        else
                        {

                            CMSDepartmentabout PSOCMS = new CMSDepartmentabout
                            {
                                Departmentid = Convert.ToInt32(ddlDepartment.SelectedValue),
                                SectionName = "Objective",
                                Content = strpso,
                                Introduction = ""
                            };
                            PSO.Add(PSOCMS);
                        }

                    }
                    if (ret == 3)
                    {
                        ret += De.AddDepartmenntAbout(PSO);
                    }
                    else
                    {
                        lblmessage.Text = "Mission Section not added please try again.";
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
        txtIntroContent.Text = "";
        txtpo.Text = "";
        TXTPEO.Text = "";
        TXTPSO.Text = "";


        ddlDepartment.Enabled = true;


        Divpo.Visible = true;
        divpeo.Visible = true;
        divpso.Visible = true;
        //  divfileadd.Visible = true;



        //string urlWithoutQueryString = Request.Url.GetLeftPart(UriPartial.Path);
        //Response.Redirect(urlWithoutQueryString, false);
    }



    public bool AlreadyExist(int ID)
    {
        bool isAvail = false;
        DataTable dt = De.viewAlltblDepartmentabout(ID);
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