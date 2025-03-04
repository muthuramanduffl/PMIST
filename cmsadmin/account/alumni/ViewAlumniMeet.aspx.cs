using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_account_about_ViewNews : System.Web.UI.Page
{
    pmualum alum = new pmualum();
   
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


   
    public void BindContent()
    {
        try
        {
           
            DataSet dsContent = new DataSet();
        
         
                dsContent = alum.ViewAlumniMeet();

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
                lblcheck.Text = "No Alumni Meet Details Added";
            }

        }
        catch (Exception ex)
        {
        }
    }

    protected void Statusimg_click(object sender, EventArgs e)
    {
        try
        {
            ImageButton imgRead = sender as ImageButton;
            GridViewRow row = (GridViewRow)imgRead.NamingContainer;
            int Sno = int.Parse(imgRead.CommandArgument);
            alum.UpdateAlumniMeetStatus(Sno,"admin",Utility.IndianTime);
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
        Response.Redirect("addalumnimeet.aspx", true);
    }


    public string bindUrl(int Id, string title)
    {
        string url = string.Empty;
        string stTitle = string.Empty;
        if (title.Contains("&"))
            title = title.Replace("&", "-");
        if (title.Contains(" "))
            url = "/alumni/" + Id + "/" + title.Trim().ToLower().Replace(" ", "-") + ".aspx";
        else
            url = "/alumni/" + Id + "/" + title.Trim().ToLower() + ".aspx";
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


}