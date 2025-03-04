using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_account_about_ViewNews : System.Web.UI.Page
{
    pmuevents events = new pmuevents();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
            BindContent();
    }
  
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindContent();

        grvContent.PageIndex = e.NewPageIndex;

        grvContent.DataBind();

    }
    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindContent();
    }
    public string BindPopup(string Image)
    {
        if (!string.IsNullOrEmpty(Image))
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["EventImages"];
            string temppath = filePath.Trim() +"/" + Image;
            string newpath = "newPopup('" + temppath + "')";
            return newpath;
        }
        else
            return "";
    }
   
    public void BindContent()
    {
        try
        {
           
            DataSet dsContent = new DataSet();
            string stDepartment = ddlDepartment.SelectedItem.Text.Trim();
            if (!string.Equals(stDepartment,"All"))
                dsContent = events.ViewAllEventsByDepartment(stDepartment);
            else
                dsContent = events.ViewEvents();

            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                lblcheck.Text = "";
                grvContent.Visible = true;
                grvContent.DataSource = dsContent;
                grvContent.DataBind();
            }
            else
            {
                lblcheck.Visible = true;
                grvContent.Visible = false;
                lblcheck.Text = "No Events Added";
            }

        }
        catch (Exception ex)
        {
        }
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        //try
        //{
            LinkButton btnDelete = sender as LinkButton;
            GridViewRow row = (GridViewRow)btnDelete.NamingContainer;
            string[] args = btnDelete.CommandArgument.Split(';');
            int ID = Convert.ToInt16(args[0]);
            string HeaderImage = Convert.ToString(args[1]);
            if (!string.IsNullOrEmpty(HeaderImage))
                FileDelete(HeaderImage);
            string pdf1Image = Convert.ToString(args[2]);
            if (!string.IsNullOrEmpty(pdf1Image))
                FilePDFDelete(pdf1Image);
            string pdf2Image = Convert.ToString(args[3]);
            if (!string.IsNullOrEmpty(pdf2Image))
                FilePDFDelete(pdf2Image);
            string pdf3Image = Convert.ToString(args[4]);
            if (!string.IsNullOrEmpty(pdf3Image))
                FilePDFDelete(pdf3Image);
            events.DeleteEvents(ID);
            BindContent();
        //}
        //catch (Exception ex)
        //{
        //}
    }
    protected void Statusimg_click(object sender, EventArgs e)
    {
        try
        {
            ImageButton imgRead = sender as ImageButton;
            GridViewRow row = (GridViewRow)imgRead.NamingContainer;
            int Sno = int.Parse(imgRead.CommandArgument);
            events.UpdateEventStatus(Sno,"admin",Utility.IndianTime);
            BindContent();
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