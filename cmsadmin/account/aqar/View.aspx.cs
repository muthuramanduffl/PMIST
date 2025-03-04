using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_account_slider_Viewslider : System.Web.UI.Page
{
    naaccontentiqac content = new naaccontentiqac();
    naacmetriciqac metric = new naacmetriciqac();
    naacsubmetriciqac submetric = new naacsubmetriciqac();
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
        string stFlter = ddlFilter.SelectedItem.Text.Trim();
        int CriteriaNo = 0;
        int MetricId = 0;
        int SubMetricId = 0;
        if (!string.Equals(stFlter, "All"))
        {
            CriteriaNo = Convert.ToInt32(ddlFilter.SelectedItem.Text.Trim());
            string stMetricFlter = ddlFilterMetric.SelectedItem.Text.Trim();
            if (!string.Equals(stMetricFlter, "All"))
                MetricId = Convert.ToInt32(ddlFilterMetric.SelectedValue);
            string stSubMetricFlter = ddlFilterSubMetric.SelectedItem.Text.Trim();
            if (!string.Equals(stSubMetricFlter, "All"))
                SubMetricId = Convert.ToInt32(ddlFilterSubMetric.SelectedValue);
            dsContent = content.ViewNaac(CriteriaNo, MetricId, SubMetricId);
        }
        else
        dsContent = content.ViewAllNaac();
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

        //}
        //catch (Exception ex)
        //{
        //}
    }
    public void BindMetric(int CriteriaId)
    {
        DataSet ds = metric.ViewActiveMetric(CriteriaId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            ddlFilterMetric.Items.Clear();
            ddlFilterMetric.Items.Add(new ListItem("All", "All"));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string stText = Convert.ToString(ds.Tables[0].Rows[i]["MetricNo"]);
                string stValue = Convert.ToString(ds.Tables[0].Rows[i]["Sno"]);
                ddlFilterMetric.Items.Add(new ListItem(stText, stValue));
            }
            ddlFilterMetric.DataBind();

        }
        else
        {
            ddlFilterMetric.Items.Clear();

            ddlFilterMetric.Items.Add(new ListItem("All", "All"));
            BindSubMetric(0, 0);
        }
    }
    protected void ddlFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Critera = 0;
        if (!string.Equals(ddlFilter.SelectedItem.Text, "All"))
        {
            Critera = Convert.ToInt32(ddlFilter.SelectedItem.Text);
            BindMetric(Critera);
        }
        else
        {
            BindMetric(0);
            
        }
        BindContent();
    }
    protected void ddlSubMetric_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Critera = 0;
        int metricId = 0;
        int submetricId = 0;
        if (!string.Equals(ddlFilter.SelectedItem.Text, "All"))
        {
            Critera = Convert.ToInt32(ddlFilter.SelectedItem.Text);
            if (!string.Equals(ddlFilterMetric.SelectedItem.Text, "All"))
            {
                metricId = Convert.ToInt32(ddlFilterMetric.SelectedValue);

                if (!string.Equals(ddlFilterSubMetric.SelectedItem.Text, "All"))
                {
                    submetricId = Convert.ToInt32(ddlFilterSubMetric.SelectedValue);
                   
                }
               
            }

        }
        BindContent();

    }
    protected void ddlMetric_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Critera = 0;
        int metricId = 0;
        if (!string.Equals(ddlFilter.SelectedItem.Text, "All"))
        {
            Critera = Convert.ToInt32(ddlFilter.SelectedItem.Text);
            if (!string.Equals(ddlFilterMetric.SelectedItem.Text, "All"))
            {
                metricId = Convert.ToInt32(ddlFilterMetric.SelectedValue);
                BindSubMetric(Critera, metricId);
            }
            else
            {
                BindSubMetric(0, 0);
               
            }
        }
        BindContent();
    }
    public void BindSubMetric(int CriteriaId, int metricId)
    {
        DataSet ds = submetric.ViewActiveSubMetric(CriteriaId, metricId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            ddlFilterSubMetric.Items.Clear();
            ddlFilterSubMetric.Items.Add(new ListItem("All", "All"));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string stText = Convert.ToString(ds.Tables[0].Rows[i]["SubMetricNo"]);
                string stValue = Convert.ToString(ds.Tables[0].Rows[i]["Sno"]);
                ddlFilterSubMetric.Items.Add(new ListItem(stText, stValue));
            }
            ddlFilterSubMetric.DataBind();

        }
        else
        {
            ddlFilterSubMetric.Items.Clear();
            ddlFilterSubMetric.Items.Add(new ListItem("All", "All"));

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
           int DisplayOrder= Convert.ToInt32(args[1]);
            int CriteriaId = Convert.ToInt32(args[2]);
            int MetricId = Convert.ToInt32(args[3]);
            int SubMetricId = Convert.ToInt32(args[4]);
            content.DeleteNaac(ID);
            UpdateDisplayOrder(DisplayOrder, CriteriaId, MetricId, SubMetricId);
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
            if (string.Equals(Type, "Image"))
            {
                string filePath = System.Configuration.ConfigurationManager.AppSettings["NaacImage"];
                url = filePath + @"/" + ImageUrl.Trim();

            }
            if (string.Equals(Type, "Video"))
            {
                string filePath = System.Configuration.ConfigurationManager.AppSettings["NaacVideo"];
                url = filePath + @"/" + ImageUrl.Trim();

            }
            if (string.Equals(Type, "PDF"))
            {
                string filePath = System.Configuration.ConfigurationManager.AppSettings["Naacpdf"];
                url = filePath + @"/" + ImageUrl.Trim();

            }

        }
        return url;
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
        Response.Redirect("Addnaac.aspx", true);
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
            content.UpdateNaacStatus(Sno,UpdatedBy, Utility.IndianTime);

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
    public void UpdateDisplayOrder(int displayOrder,int CriteriaId,int metricId, int submetricId)
    {
        int toDisplayOrder = GetMaxDisplayOrder(CriteriaId, metricId, submetricId);
        DataSet ds = content.GetNaacDisplayOrderForDelete(displayOrder, toDisplayOrder, CriteriaId, metricId, submetricId);
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
                content.UpdateNaacDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

            }
            
        }
    }
    public int GetMaxDisplayOrder(int CriteriaId, int metricId, int submetricId)
    {
        int DisplayOrder = 0;
        DataSet ds = content.ViewMaxNaac(CriteriaId, metricId, submetricId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stDisplayOrder = Convert.ToString(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
            if (!string.IsNullOrEmpty(stDisplayOrder))
                DisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
        }
        return DisplayOrder;
    }
    
}