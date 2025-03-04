using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_account_slider_Viewslider : System.Web.UI.Page
{
    pmuslider slider = new pmuslider();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {

            BindContent();
            
        }
    }
    public string bindUpdatedBy(string updatedBy)
    {
        if (string.Equals(updatedBy, "NONE", StringComparison.OrdinalIgnoreCase))
            return " - ";
        else
            return updatedBy.Trim();
    }
    public string bindUpdatedDate(string updatedBy,DateTime dt)
    {
        if (string.Equals(updatedBy, "NONE", StringComparison.OrdinalIgnoreCase))
            return " - ";
        else
           return dt.ToShortDateString();
    }
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindContent();

        grvSlider.PageIndex = e.NewPageIndex;

        grvSlider.DataBind();

    }

    public string BindPopup(string Image)
    {
        if (!string.IsNullOrEmpty(Image))
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["SliderImages"];
            string temppath = filePath.Trim() + @"/" + Image;
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
            dsContent = slider.ViewSlider();
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                grvSlider.Visible = true;
                grvSlider.DataSource = dsContent;
                grvSlider.DataBind();
            }
            else
            {
                lblcheck.Visible = true;
                grvSlider.Visible = false;
                lblcheck.Text = "No Slider Added";
            }

        }
        catch (Exception ex)
        {
        }
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton btnDelete = sender as LinkButton;
            GridViewRow row = (GridViewRow)btnDelete.NamingContainer;
            string[] args = btnDelete.CommandArgument.Split(',');
            int ID = Convert.ToInt16(args[0]);
            string TopImage = Convert.ToString(args[1]);
            if(!string.IsNullOrEmpty(TopImage))
                FileDelete(TopImage);
           int DisplayOrder= Convert.ToInt32(args[2]);
            slider.DeleteSlider(ID);
            UpdateDisplayOrder(DisplayOrder);
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
            // return "Show Image";
            return Image.Trim();
        }
        else
        {

            return "No Image";
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
        Response.Redirect("AddSlider.aspx", true);
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
            string UpdatedBy = "admin";// login.GetUserName();
            slider.UpdateStatus(Sno,UpdatedBy);

            BindContent();
        }
        catch (Exception ex)
        {
        }

    }
    protected void btnLiveView_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.pmu.edu", true);
    }
    public void UpdateDisplayOrder(int displayOrder)
    {
        int toDisplayOrder = GetMaxDisplayOrder();
        DataSet ds = slider.GetSliderDisplayOrderForDelete(displayOrder, toDisplayOrder);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            int oldDisplayOrder = 0;
            int NewDisplayOrder = 0;
            int SliderId = 0;
            string updatedBy = "admin";// login.GetUserName();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                SliderId = Convert.ToInt32(ds.Tables[0].Rows[i]["SliderId"]);
                NewDisplayOrder = oldDisplayOrder - 1;
                slider.UpdateSliderDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

            }
            
        }
    }
    public int GetMaxDisplayOrder()
    {
        int DisplayOrder = 0;
        DataSet ds = slider.ViewMaxSlider();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stDisplayOrder = Convert.ToString(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
            if (!string.IsNullOrEmpty(stDisplayOrder))
                DisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
        }
        return DisplayOrder;
    }
    public void FileDelete(string ImageName)
    {

        string filePath = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["SliderImages"].ToString());
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
}