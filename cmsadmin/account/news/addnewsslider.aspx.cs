using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_account_news_addnewsslider : System.Web.UI.Page
{
    pmunewsslider news = new pmunewsslider();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / News / <b>Edit</b>";
            news.SliderId = Convert.ToInt32(Request.QueryString["ID"]);
            if (!IsPostBack)
            {
               
                BindNews(news.SliderId);


            }
        }
        else
        {

            lblDisplayText.Text = "Dashboard / News / <b>Add</b>";
            
        }
    }

    public void BindNews(int ID)
    {
        try
        {
            DataSet dsContent = news.ViewNewsSliderById(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";                
                dvDate.Attributes["class"] = "md-input-wrapper md-input-filled";
               
               
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Title"])))
                    txtTitle.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Title"]);
               
               
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["LinkUrl"])))
                    txtUrl.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["LinkUrl"]);
               
               
                bool Status = Convert.ToBoolean(dsContent.Tables[0].Rows[0]["Status"]);
                chkStatus.Checked = Status;

                
                //BindLiveUrl(ID);
                if (Status)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
            }

        }

        catch (Exception ex)
        {
        }
    }
    
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string stErrorText = string.Empty;
        if (string.IsNullOrEmpty(txtTitle.Text))
        {
            stErrorText = "Please enter Title";
        }
        
        
        if (string.IsNullOrEmpty(stErrorText))
        {
            if (Request.QueryString["ID"] == null)
            {

                InsertContent();
                Clear();
            }
            else
            {
                news.SliderId = Convert.ToInt32(Request.QueryString["ID"]);
                UpdateContent(news.SliderId);
            }

        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
    }


    public void InsertContent()
    {
        try
        {
            bool status = false;
            if (chkStatus.Checked)
                status = true;
           
            List<pmunewsslider> lstContent = new List<pmunewsslider> {
            new pmunewsslider{
                Title=(!string.IsNullOrEmpty(txtTitle.Text))?txtTitle.Text.Trim():string.Empty,
                LinkUrl=(!string.IsNullOrEmpty(txtUrl.Text))?txtUrl.Text.Trim():string.Empty,                          
                Status=status,
                PostedDate=Utility.IndianTime,
                PostedBy="admin",// login.GetUserName(),
                UpdatedDate=Utility.IndianTime,
                UpdatedBy="admin"
              }
        };
           
            int InsContent = news.AddNewsSlider(lstContent);
            if (InsContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";                
                dvDate.Attributes["class"] = "md-input-wrapper md-input-filled";
                
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Inserted');</script>");
                if (status)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
                // string stUrl = "<a href='/news-details.aspx?ID=" + ID + "' target='_blank'>Live Url :News</a>";
                //phLiveUrl.Controls.Add(new LiteralControl(stUrl.Trim()));
               

            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }
    }
    
    public void UpdateContent(int ID)
    {
        try
        {
            bool status = false;
            if (chkStatus.Checked)
                status = true;
            List<pmunewsslider> lstContent = new List<pmunewsslider> {
            new pmunewsslider{
                Title=(!string.IsNullOrEmpty(txtTitle.Text))?txtTitle.Text.Trim():string.Empty,
                LinkUrl=(!string.IsNullOrEmpty(txtUrl.Text))?txtUrl.Text.Trim():string.Empty,
                Status=status,               
                UpdatedDate=Utility.IndianTime,
                UpdatedBy="admin"
              }
        };

            int UpdateContent = news.UpdateNewsSlider(lstContent, ID);
            if (UpdateContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
               
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
                if (status)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
                // string stUrl = "<a href='/news-details.aspx?ID=" + ID + "' target='_blank'>Live Url :News</a>";
                //phLiveUrl.Controls.Add(new LiteralControl(stUrl.Trim()));
                BindNews(ID);
            }
        }
        catch (Exception ex)
        {
        }
    }
    
    protected void btnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }
    public void Clear()
    {
        txtTitle.Text = "";
        txtUrl.Text = "";

    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewnewsslider.aspx", true);
    }

    
}