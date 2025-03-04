using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_account_slider_Viewslider : System.Web.UI.Page
{
   
    internships recurit = new internships();
    pmuLogin login = new pmuLogin();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {

            BindContent();
            
        }
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
        string stFlter = ddlFilter.SelectedItem.Text.Trim();

        if (!string.Equals(stFlter, "All"))
        {

            if (string.Equals(stFlter, "Active"))
                dsContent = recurit.ViewActiveInternships();
            else if (string.Equals(stFlter, "In Active"))
                dsContent = recurit.ViewInactiveInternships();
        }
        else
            dsContent = recurit.ViewAllInternships();
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
                lblcheck.Text = "No Records found";
            }

        }
        catch (Exception ex)
        {
        }
    }
    
    protected void ddlFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindContent();

    }
    
    protected void Button_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton btnDelete = sender as LinkButton;
            GridViewRow row = (GridViewRow)btnDelete.NamingContainer;
            string[] args = btnDelete.CommandArgument.Split(',');
            int ID = Convert.ToInt16(args[0]);
            recurit.DeleteInternships(ID);
            BindContent();
        }
        catch (Exception ex)
        {
        }
    }
   
    public string bindTitle(string Title)
    {

        if (!string.IsNullOrEmpty(Title))
        {
            return Title.Trim();
        }
        else
        {

            return "No Title";
        }
    }
    public string bindImageHref(string ImageUrl)
    {
        string url = " - ";
        if (!string.IsNullOrEmpty(ImageUrl))
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["Internships"];
            string sturl = filePath + @"/" + ImageUrl.Trim();
            url = "<a target='_blank' href='" + sturl + "'>" + ImageUrl + "</a>";
            

        }
        return url;
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
   
    protected void Publishimg_click(object sender, EventArgs e)
    {
        try
        {
            ImageButton imgRead = sender as ImageButton;
            GridViewRow row = (GridViewRow)imgRead.NamingContainer;
            string[] arg = new string[2];
            arg = imgRead.CommandArgument.ToString().Split(';');
            int Sno = Convert.ToInt16(arg[0]);
            bool Status = Convert.ToBoolean(arg[1]);
            string UpdatedBy = login.GetUserName();
            recurit.UpdateInternshipStatus(Sno,UpdatedBy, Utility.IndianTime);

            BindContent();
        }
        catch (Exception ex)
        {
        }

    }
    protected void btnLiveView_Click(object sender, EventArgs e)
    {
        //Response.Redirect("http://www.pmu.edu", true);
    }
   
}