using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Security.Cryptography;
public partial class admin_account_about_ViewNews : System.Web.UI.Page
{

    CMSDepartment D = new CMSDepartment();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            DataTable dt = D.ViewDepartment();
            if (dt.Rows.Count > 0)
            {

                ddlDepartment.DataSource = dt;
                ddlDepartment.DataTextField = "DepartmentName";
                ddlDepartment.DataValueField = "DepartmentID";
                ddlDepartment.DataBind();
                ddlDepartment.Items.Insert(0, new ListItem("Select Faculty", ""));
            }
            BindContent();
           
        }
            




    }

    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindContent();
    }



    public string Binddepartment(int ID)
    {
        string dept = string.Empty;

        DataTable dt = D.ViewDepartmentByID(ID);
        if (dt.Rows.Count > 0)
        {
            dept = dt.Rows[0]["DepartmentName"].ToString();
        }



        return dept;
    }



    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindContent();
    }


    protected string GetRowNo(string itemIndex)
    {

        return PageIndex > 1 ? (((PageIndex - 1) * 10) + Convert.ToInt32(itemIndex)).ToString() : itemIndex;
    }


    public int PageIndex
    {
        get { return ViewState["PageIndex"] != null ? (int)ViewState["PageIndex"] : 1; }
        set { ViewState["PageIndex"] = value; }
    }




    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        if (e.CommandName == "Delete")
        {
            try
            {
                D.DeleteDepartmentCoursesbyID(Convert.ToInt32(e.CommandArgument));
            }
            catch (Exception ex)
            {

            }
            BindContent();
        }

        if (e.CommandName == "ViewPDF")
        {
            try
            {
                int ID = Convert.ToInt32(e.CommandArgument);
                DataTable dt = D.ViewDepartmentCoursesByID(ID);
                if (dt.Rows.Count > 0)
                {
                    DateTime today = DateTime.Today;
                    string filepath = System.Configuration.ConfigurationManager.AppSettings["CSMDepartmentPDF"];
                    string fullFilePath = Path.Combine(filepath.Trim(), dt.Rows[0]["PDFName"].ToString());
                    string fileUrl = "https://pmu.edu/" + fullFilePath.TrimStart('/');
                    ScriptManager.RegisterStartupScript(this, GetType(), "redirect", "window.open('" + fileUrl + "', '_blank');", true);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(
                           this.GetType(),
                           "Alert",
                           "<script type='text/javascript'>alert('Pdf file does not exist.');</script>"
                       );
                }
            }
            catch (Exception ex)
            {
            }



        }


        if (e.CommandName == "Edit")
        {

            try
            {
                SetControlsInRepeater(Convert.ToString(e.CommandArgument));
                //PT.DeleteprductdetailsByID(Convert.ToString(e.CommandArgument));
            }
            catch (Exception ex)
            {
            }
        }
        if (e.CommandName == "Save")
        {
            try
            {
                foreach (RepeaterItem item in rpruser.Items)
                {
                    if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
                    {
                        TextBox txtIntroduction = item.FindControl("txtIntroduction") as TextBox;
                        TextBox txtContent = item.FindControl("txtContent") as TextBox;
                        TextBox txtCurriculum = item.FindControl("txtCurriculum") as TextBox;
                        LinkButton btnSave = item.FindControl("btnSave") as LinkButton;
                        LinkButton editButton = item.FindControl("Editbtn") as LinkButton;
                        FileUpload Fileupload = item.FindControl("FileUpload1") as FileUpload;
                        HiddenField IdHiddenField = item.FindControl("HiddenField2") as HiddenField;
                        HiddenField File = item.FindControl("hdnfile") as HiddenField;
                        if (IdHiddenField != null)
                        {
                            string Id = IdHiddenField.Value;
                            if (Id == Convert.ToString(e.CommandArgument))
                            {
                                // PT.TextArea = textBox.Text;
                                //  PT.BENEFITSID = Convert.ToString(e.CommandArgument);

                                if (txtIntroduction.ReadOnly == false)
                                {
                                    D.DSno = Convert.ToInt32(Id);
                                    D.Content = txtContent.Text;
                                    D.Introduction = txtIntroduction.Text;
                                }
                                else
                                {
                                    D.DSno = Convert.ToInt32(Id);
                                    D.Content = txtContent.Text;
                                    D.Introduction = "";
                                }




                                int RET = 0;

                                if (txtContent.Text != "-" && txtCurriculum.Text == "-")
                                {
                                    RET = D.UpdateCMSDepartmentCourses(D);
                                }
                                else
                                {
                                    D.DSno = Convert.ToInt32(Id);
                                    D.curriculum = txtCurriculum.Text;
                                    if (Fileupload.HasFile)
                                    {
                                        D.PDFFilename = SaveFile(Fileupload, "CSMDepartmentPDF", Id);
                                    }
                                    else
                                    {
                                        D.PDFFilename = File.Value;
                                    }

                                    RET = D.UpdateCMSDepartmentCoursesWithcurriculum(D);
                                }



                                // RET = PT.UpdateproductdetailsBYBENEFITSID(PT);
                                if (RET == 1)
                                {
                                    if (txtIntroduction != null)
                                    {
                                        txtIntroduction.ReadOnly = true;
                                        txtIntroduction.Focus();
                                    }




                                    if (btnSave != null)
                                    {
                                        btnSave.Enabled = false;
                                        btnSave.Visible = false;
                                    }
                                    if (editButton != null)
                                    {
                                        editButton.Enabled = true;
                                        editButton.Visible = true;
                                    }


                                    success.Style.Add("Display", "Block");

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            BindContent();

        }
    }


    public string SaveFile(FileUpload uploadedFile, string appkey, string ID)
    {
        int savefile = 0;
        string filename = string.Empty;
        try
        {
            string filepath = System.Configuration.ConfigurationManager.AppSettings[appkey];

            string fileName = Path.GetFileName(uploadedFile.FileName);

            string fileExtension = Path.GetExtension(fileName);

            filename = GenerateFileName(ID, fileExtension).Trim('-');

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

    public string GenerateFileName(string id, string fileExtension)
    {
        string randomString = GenerateRandomString(4);
        string newFileName = id + randomString + fileExtension;
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



    protected void SetControlsInRepeater(string targetId)
    {
        foreach (RepeaterItem item in rpruser.Items)
        {
            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {
                // Find the controls inside the repeater item
                LinkButton btnSave = item.FindControl("btnSave") as LinkButton;
                LinkButton editButton = item.FindControl("Editbtn") as LinkButton;
                TextBox txtIntroduction = item.FindControl("txtIntroduction") as TextBox;
                TextBox txtContent = item.FindControl("txtContent") as TextBox;
                TextBox txtCurriculum = item.FindControl("txtCurriculum") as TextBox;
                FileUpload Fileupload = item.FindControl("FileUpload1") as FileUpload;
                LinkButton BtnView = item.FindControl("btnview") as LinkButton;

                // Assuming you have a HiddenField containing the product ID
                HiddenField IdHiddenField = item.FindControl("HiddenField1") as HiddenField;
                if (IdHiddenField != null)
                {
                    string sectionname = string.Empty;
                    string Id = IdHiddenField.Value;
                    if (Id == targetId)
                    {

                        DataTable dt = D.ViewDepartmentCoursesByID(Convert.ToInt32(Id));
                        if (dt.Rows.Count > 0)
                        {
                            sectionname = Convert.ToString(dt.Rows[0]["SectionName"]);
                        }
                        if (sectionname == "curriculum")
                        {
                            if (txtCurriculum != null)
                            {
                                txtCurriculum.ReadOnly = false;
                            }
                            if (txtCurriculum.Text != "-")
                            {
                                Fileupload.Visible = true;
                            }
                            BtnView.Visible = false;
                        }
                        else
                        {
                            if (txtContent != null)
                            {
                                txtContent.ReadOnly = false;
                            }


                            Fileupload.Visible = false;
                            BtnView.Visible = false;
                        }

                        if (txtIntroduction != null)
                        {
                            if (txtIntroduction.Text != "-")
                            {

                                txtIntroduction.ReadOnly = false;
                            }
                            else
                            {
                                if (txtIntroduction != null)
                                {
                                    txtIntroduction.ReadOnly = true;
                                }
                            }
                        }
                        if (btnSave != null)
                        {
                            btnSave.Enabled = true;
                            btnSave.Visible = true;

                            //  BtnView.Visible = true;
                            //Fileupload.Visible = false;
                        }
                        if (editButton != null)
                        {
                            editButton.Enabled = false;
                            editButton.Visible = false;

                            // BtnView.Visible = false;
                        }

                    }




                    txtContent.Focus();
                    txtCurriculum.Focus();
                    txtIntroduction.Focus();

                    //if (Fileupload.Visible == true)
                    //{
                    //    BtnView.Visible = false;
                    //}
                    //else
                    //{
                    //    BtnView.Visible = true;
                    //}


                }
            }
        }
    }














    //protected void UpdateStatusInDatabase(int ID, string newStatus)
    //{

    //    if (newStatus == "1")
    //    {
    //        newStatus = "0";
    //    }
    //    else
    //    {
    //        newStatus = "1";
    //    }

    //    try
    //    {

    //        D.UpdateDepartmentStatus(ID, newStatus);

    //    }
    //    catch (Exception ex)
    //    {
    //    }

    //    BindContent();
    //}


    public void BindContent()
    {
        try
        {

            DataTable dt = Get();

            if (dt.Rows.Count > 0)
            {
                lblcheck.Text = "";
                rpruser.Visible = true;
                // DataView dv = dt.DefaultView;
                //dv.Sort = "AddedDate Desc";
                Lblcount.Text = dt.Rows.Count.ToString();
                if (!string.IsNullOrEmpty(ddlDepartment.SelectedValue))
                {
                    LinkButton1.Visible = dt.Rows.Count < 10;
                }
                else
                {
                    LinkButton1.Visible = false;

                }

                rpruser.DataSource = dt;
                rpruser.DataBind();
            }
            else
            {
                lblcheck.Visible = true;
                rpruser.Visible = false;
                Lblcount.Text = "0";
                lblcheck.Text = "No Recods Found!.";
            }

        }
        catch (Exception ex)
        {
        }
    }


    public DataTable Get()
    {
        int dept = 0;

        if (!string.IsNullOrEmpty(ddlDepartment.SelectedValue))
        {
            dept = Convert.ToInt32(ddlDepartment.SelectedValue);
            LinkButton1.Visible = true;
        }
        else
        {
            LinkButton1.Visible = false;
        }

        DataTable dt= D.ViewDepartmentCourses(dept);


        return dt;
    }




    public void FileDelete(string ImageName)
    {

        string filePath = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["EventImages"]);
        filePath += "//" + ImageName.Trim();
        if (System.IO.File.Exists(filePath))
        {
            try
            {
                System.IO.File.Delete(filePath);

            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
    public void FilePDFDelete(string pdfName)
    {
        string filePath = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["Eventpdf"]);
        filePath += "//" + pdfName.Trim();
        if (System.IO.File.Exists(filePath))
        {
            try
            {
                System.IO.File.Delete(filePath);

            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }

    protected void BTNGo_Click(object sender, EventArgs e)
    {
        BindContent();
    }

    protected void ddlDepartment_SelectedIndexChanged1(object sender, EventArgs e)
    {
        BindContent();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add-Departmentcourses.aspx?Dept="+ddlDepartment.SelectedValue+"");
    }
}