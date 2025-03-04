using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_account_news_viewnewsslider : System.Web.UI.Page
{
    pmunewsslider slider = new pmunewsslider();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
            BindNews();
    }
    protected void btnLiveView_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.pmu.edu", true);
    }
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindNews();

        grvContent.PageIndex = e.NewPageIndex;

        grvContent.DataBind();

    }

    public string BindPopup(string Image)
    {
        if (!string.IsNullOrEmpty(Image))
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["VideoImages"];
            string temppath = filePath.Trim() +"/" + Image;
            string newpath = "newPopup('" + temppath + "')";
            return newpath;
        }
        else
            return "";
    }
   
    public void BindNews()
    {
        try
        {
           
            DataSet dsContent = new DataSet();
            dsContent = slider.ViewAllNewsSlier();
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                grvContent.Visible = true;
                grvContent.DataSource = dsContent;
                grvContent.DataBind();
            }
            else
            {
                lblcheck.Visible = true;
                grvContent.Visible = false;
                lblcheck.Text = "No News Added";
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
            slider.DeleteNewsSlider(ID);
            BindNews();
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
            slider.UpdateNewsSliderStatus(Sno,"admin",Utility.IndianTime);
            BindNews();
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
        Response.Redirect("addnewsslider.aspx", true);
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