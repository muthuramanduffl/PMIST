using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_account_viewachievementcorner : System.Web.UI.Page
{
    pmuachievement achievements = new pmuachievement();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
            BindAchievements();
    }
    protected void btnLiveView_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://www.pmu.edu/achievements-corner/", true);
    }
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindAchievements();

        grvContent.PageIndex = e.NewPageIndex;

        grvContent.DataBind();

    }

    
   
    public void BindAchievements()
    {
        //try
        //{
           
            DataSet dsContent = new DataSet();
     
            dsContent = achievements.ViewAllAchievement();
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                grvContent.Visible = true;
                grvContent.DataSource = dsContent;
                grvContent.DataBind();
                 lbl.Text = dsContent.Tables[0].Rows.Count.ToString();
            }
            else
            {
                lblcheck.Visible = true;
                grvContent.Visible = false;
                lblcheck.Text = "No Achievement Added";
                lbl.Text = "0";
            }

        //}
        //catch (Exception eeex)
        //{
        //}
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton btnDelete = sender as LinkButton;
            GridViewRow row = (GridViewRow)btnDelete.NamingContainer;
            string[] args = btnDelete.CommandArgument.Split(';');
            int ID = Convert.ToInt16(args[0]);               
            achievements.DeleteAchievement(ID);
            BindAchievements();
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
            achievements.UpdateAchievementStatus(Sno,"admin",Utility.IndianTime);
            BindAchievements();
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
        Response.Redirect("addachievementcorner.aspx", true);
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