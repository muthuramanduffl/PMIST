using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Security.Cryptography;
public partial class admin_account_departmentabout : System.Web.UI.Page
{

    CMSDepartment D = new CMSDepartment();
    CMSDepartmentabout DA = new CMSDepartmentabout();

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
                ddlDepartment.Items.Insert(0, new ListItem("Select Department", ""));
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
        UpdatePanel1.Update();
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
            int ret = 0;
            try
            {
                ret = DA.DeleteDepartmentAbout(Convert.ToInt32(e.CommandArgument));
                if (ret == 1)
                {
                    string script = string.Format("alert('{0}'); window.location.reload();", "Row deleted successfully.");
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);


                }
                else
                {
              
                    string script = string.Format("alert('{0}'); window.location.reload();", "Row could not be deleted. Please try again.");
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);

                }
            }
            catch (Exception ex)
            {

            }
      //      BindContent();
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
                        TextBox txtContent = item.FindControl("txtContent") as TextBox;
                        LinkButton btnSave = item.FindControl("btnSave") as LinkButton;
                        LinkButton editButton = item.FindControl("Editbtn") as LinkButton;
                        HiddenField IdHiddenField = item.FindControl("HiddenField2") as HiddenField;
                        HiddenField File = item.FindControl("hdnfile") as HiddenField;
                        Label lblcontent = item.FindControl("lblcontent") as Label;
                        if (IdHiddenField != null)
                        {
                            string sectionname = string.Empty;
                            string Id = IdHiddenField.Value;
                            if (Id == Convert.ToString(e.CommandArgument))
                            {
                                DataTable dt = DA.ViewCMSDeptAboutByID(Convert.ToInt32(Id));
                                if (dt.Rows.Count > 0)
                                {
                                    sectionname = Convert.ToString(dt.Rows[0]["SectionName"]);
                                }
                              
                                if (txtContent.ReadOnly == false)
                                {
                                    DA.DSno = Convert.ToInt32(Id);
                                    DA.Content = txtContent.Text;
                                    DA.SectionName = sectionname;

                                }
                                else
                                {
                                    DA.DSno = Convert.ToInt32(Id);
                                    DA.Content = txtContent.Text;
                                    DA.SectionName = sectionname;
                                }
                                int RET = 0;
                                RET = DA.UpdateDepartmenntAbout(DA);
                                if (RET == 1)
                                {
                                    lblcontent.Visible = true;
                                    if (txtContent != null)
                                    {
                                        txtContent.Visible = false;
                                        txtContent.Focus();
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
                LinkButton btnSave = item.FindControl("btnSave") as LinkButton;
                LinkButton editButton = item.FindControl("Editbtn") as LinkButton;
                TextBox txtContent = item.FindControl("txtContent") as TextBox;
                Label lblcontent = item.FindControl("lblcontent") as Label;
                HiddenField IdHiddenField = item.FindControl("HiddenField1") as HiddenField;
                if (IdHiddenField != null)
                {
                    string sectionname = string.Empty;
                    string Id = IdHiddenField.Value;
                    if (Id == targetId)
                    {
                        DataTable dt = DA.ViewCMSDeptAboutByID(Convert.ToInt32(Id));
                        if (dt.Rows.Count > 0)
                        {
                            sectionname = Convert.ToString(dt.Rows[0]["SectionName"]);
                        }
                        if (sectionname == "Intro content")
                        {
                            lblcontent.Visible = false;
                            txtContent.Visible = true;
                            txtContent.CssClass += " editor"; // Add the 'editor' class dynamically

                            if (txtContent != null)
                            {
                                txtContent.ReadOnly = false;
                            }
                        }
                        else
                        {
                            if (txtContent != null)
                            {
                                txtContent.ReadOnly = false;
                                txtContent.Visible = true;
                            }
                            lblcontent.Visible = false;

                        }


                        if (btnSave != null)
                        {
                            btnSave.Enabled = true;
                            btnSave.Visible = true;
                            btnSave.Focus();
                        }
                        if (editButton != null)
                        {
                            editButton.Enabled = false;
                            editButton.Visible = false;
                        }
                    }
                    txtContent.Focus();
                }
            }
        }
    }


    protected void rpruser_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            TextBox txtContent = e.Item.FindControl("txtContent") as TextBox;
            HiddenField hiddenSectionName = e.Item.FindControl("HiddenField3") as HiddenField; // Ensure you have a HiddenField for SectionName
            if (txtContent != null && hiddenSectionName != null)
            {
                string sectionName = hiddenSectionName.Value;
                if (sectionName == "Intro content")
                {
                    txtContent.CssClass += " editor"; // Append 'editor' class
                    txtContent.Visible = false;
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
                    LinkButton1.Visible = dt.Rows.Count <= 31;
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

        DataTable dt = DA.viewAlltblDepartmentabout(dept);


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
        Response.Redirect("add-about.aspx?Dept=" + ddlDepartment.SelectedValue + "");
    }
}