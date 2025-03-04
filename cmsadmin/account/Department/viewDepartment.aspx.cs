using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_account_about_ViewNews : System.Web.UI.Page
{

    CMSDepartment D = new CMSDepartment();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
            BindContent();
    }

    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindContent();



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
        if (e.CommandName == "Edit")
        {
            try
            {
                int ID = Convert.ToInt32(e.CommandArgument);

                Response.Redirect("AddDepartment.aspx?DepartmentID=" + ID, false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();

            }
            catch (Exception ex)
            {
            }
        }


        if (e.CommandName == "ToggleStatus")
        {
            int id = Convert.ToInt32(e.CommandArgument);

            try
            {
                DataTable dsContent = D.ViewDepartmentByID(id);
                if (dsContent.Rows.Count > 0)
                {
                    DataTable dt = dsContent;


                    var filteredRows = dt.AsEnumerable()
                                         .Where(row => row.Field<int>("DepartmentID") == id)
                                         .ToList();
                    if (filteredRows.Count > 0)
                    {
                        string displayStatus = filteredRows[0].Field<string>("Status");
                        UpdateStatusInDatabase(id, displayStatus);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        BindContent();
    }


    protected void UpdateStatusInDatabase(int ID, string newStatus)
    {

        if (newStatus == "1")
        {
            newStatus = "0";
        }
        else
        {
            newStatus = "1";
        }

        try
        {

            D.UpdateDepartmentStatus(ID, newStatus);
            
        }
        catch (Exception ex)
        {
        }

        BindContent();
    }


    public void BindContent()
    {
        try
        {

            DataTable dt = D.ViewDepartment();

            if (dt.Rows.Count > 0)
            {
                lblcheck.Text = "";
                rpruser.Visible = true;
                DataView dv = dt.DefaultView;
                dv.Sort = "AddedDate Desc";
                rpruser.DataSource = dv;
                rpruser.DataBind();
            }
            else
            {
                lblcheck.Visible = true;
                rpruser.Visible = false;
                lblcheck.Text = "No Events Added";
            }

        }
        catch (Exception ex)
        {
        }
    }





    public string bindImage(int imgId)
    {

        if (imgId == 1)
        {
            return "/cmsadmin/images/tick.png";
        }
        else
        {

            return "/cmsadmin/images/untick.png";
        }
    }
    public string bindDate(DateTime dt)
    {

        return dt.ToShortDateString();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("addevents.aspx", true);
    }
    protected void btnLiveView_Click(object sender, EventArgs e)
    {
        Response.Redirect("/events/", true);
    }
    public string bindImageHref(string ImageUrl)
    {

        if (!string.IsNullOrEmpty(ImageUrl))
        {
            return "javascript:void(0);";
        }
        else
        {

            return " ";
        }
    }
    public string bindUrl(int Id, string title)
    {
        string url = string.Empty;
        string stTitle = string.Empty;
        if (title.Contains("&"))
            title = title.Replace("&", "-");
        if (title.Contains(" "))
            url = "/events/" + Id + "/" + title.Trim().ToLower().Replace(" ", "-") + ".aspx";
        else
            url = "/events/" + Id + "/" + title.Trim().ToLower() + ".aspx";
        return url;
    }
    public string bindImageTitle(string Image)
    {

        if (!string.IsNullOrEmpty(Image))
        {
            return Image.Trim();
        }
        else
        {

            return "No Image";
        }
    }
    public void FileDelete(string ImageName)
    {

        string filePath = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["EventImages"]);
        filePath += "//" + ImageName.Trim();

        // Delete a file by using File class static method... 
        if (System.IO.File.Exists(filePath))
        {
            // Use a try block to catch IOExceptions, to 
            // handle the case of the file already being 
            // opened by another process. 
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

        // Delete a file by using File class static method... 
        if (System.IO.File.Exists(filePath))
        {
            // Use a try block to catch IOExceptions, to 
            // handle the case of the file already being 
            // opened by another process. 
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
}