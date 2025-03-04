using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_account_slider_Viewslider : System.Web.UI.Page
{
    iqaccontent content = new iqaccontent();
    iqacsection section = new iqacsection();
    pmuLogin login = new pmuLogin();
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

        grvContent.PageIndex = e.NewPageIndex;

        grvContent.DataBind();

    }

    
    public void BindContent()
    {
        //try
        //{
            
            DataSet dsContent = new DataSet();
        string stFlter = string.Empty;
        int subSectionId = 0;
        
        if (!string.Equals(ddlFilter.SelectedItem.Text, "All"))
        {
            stFlter = Convert.ToString(ddlFilter.SelectedItem.Text.Trim());
            string stMetricFlter = ddlFilterMetric.SelectedItem.Text.Trim();
            if (!string.Equals(stMetricFlter, "All"))
                subSectionId = Convert.ToInt32(ddlFilterMetric.SelectedValue);
           
            dsContent = content.ViewIqacContent(stFlter, subSectionId);
        }
        else
        dsContent = content.ViewAllIqacContent();
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                lblcheck.Text = "";
                grvContent.Visible = true;
                grvContent.DataSource = dsContent;
                grvContent.DataBind();
            lblTotal.Text = "Total no of Records: " + dsContent.Tables[0].Rows.Count;
        }
            else
            {
                lblcheck.Visible = true;
                grvContent.Visible = false;
                lblcheck.Text = "No Records found";
            lblTotal.Text = "";
            }
      
        //}
        //catch (Exception ex)
        //{
        //}
    }
    public void BindSubSection(string stSection)
    {
        DataSet ds = section.ViewActiveIqacSection(stSection);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            ddlFilterMetric.Items.Clear();
            ddlFilterMetric.Items.Add(new ListItem("All", "All"));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string stText = Convert.ToString(ds.Tables[0].Rows[i]["SubSection"]);
                string stValue = Convert.ToString(ds.Tables[0].Rows[i]["Sno"]);
                ddlFilterMetric.Items.Add(new ListItem(stText, stValue));
            }
            ddlFilterMetric.DataBind();

        }
        else
        {
            ddlFilterMetric.Items.Clear();

            ddlFilterMetric.Items.Add(new ListItem("All", "All"));

        }
    }
    protected void ddlFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        if (!string.Equals(ddlFilter.SelectedItem.Text, "All"))
        {
            string stSection = ddlFilter.SelectedItem.Text;
            BindSubSection(stSection);
           
        }
        else
        {
            ddlFilterMetric.Items.Clear();

            ddlFilterMetric.Items.Add(new ListItem("All", "All"));

        }
        BindContent();
    }
   
    protected void ddlFilterMetric_SelectedIndexChanged(object sender, EventArgs e)
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
           int DisplayOrder= Convert.ToInt32(args[1]);
            string section = Convert.ToString(args[2]);
            int subSectionId = Convert.ToInt16(args[3]);
            content.DeleteIqacContent(ID);
            UpdateDisplayOrder(DisplayOrder, section, subSectionId);
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
    public string bindImageHref(string Type,string ImageUrl)
    {
        string url = string.Empty;
        if (!string.IsNullOrEmpty(ImageUrl))
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["IQACpdf"];
            url = filePath + Getpdfpath(Type) + @"/" + ImageUrl.Trim();

        }
        return url;
    }
    public string Getpdfpath(string stSection)
    {
        string stUrl = string.Empty;
        if (string.Equals(stSection, "Meeting", StringComparison.OrdinalIgnoreCase))
            stUrl = "meeting";
        else if (string.Equals(stSection, "Nirf", StringComparison.OrdinalIgnoreCase))
            stUrl = "nirf";
        else if (string.Equals(stSection, "Aqar", StringComparison.OrdinalIgnoreCase))
            stUrl = "aqar";
        else if (string.Equals(stSection, "Pmist Annual Report", StringComparison.OrdinalIgnoreCase))
            stUrl = "report";
        return stUrl;
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
        Response.Redirect("Add.aspx", true);
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
            content.UpdateIqacContentStatus(Sno,UpdatedBy, Utility.IndianTime);

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
    public void UpdateDisplayOrder(int displayOrder, string stSection, int subSectionId)
    {
        int toDisplayOrder = GetMaxDisplayOrder(stSection, subSectionId);
        DataSet ds = content.GetIqaccontentDisplayOrderForDelete(displayOrder, toDisplayOrder, stSection, subSectionId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            int oldDisplayOrder = 0;
            int NewDisplayOrder = 0;
            int SliderId = 0;
            string updatedBy = login.GetUserName();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                SliderId = Convert.ToInt32(ds.Tables[0].Rows[i]["Sno"]);
                NewDisplayOrder = oldDisplayOrder - 1;
                content.UpdateIqacContentDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

            }
            
        }
    }
    public int GetMaxDisplayOrder(string stSection, int subSectionId)
    {
        int DisplayOrder = 0;
        DataSet ds = content.ViewMaxIqaccontent(stSection, subSectionId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stDisplayOrder = Convert.ToString(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
            if (!string.IsNullOrEmpty(stDisplayOrder))
                DisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
        }
        return DisplayOrder;
    }
    
}