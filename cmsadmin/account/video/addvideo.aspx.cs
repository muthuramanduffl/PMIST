using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_account_video_addvideo : System.Web.UI.Page
{
    pmuvideo video = new pmuvideo();
    pmuLogin login = new pmuLogin();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / Video / <b>Edit</b>";
            video.VideoId = Convert.ToInt32(Request.QueryString["ID"]);
            if (!IsPostBack)
            {
                RequiredFieldValidator6.Enabled = false;
                BindVideo(video.VideoId);


            }
        }
        else
        {
            if (!IsPostBack)
            { }
                lblDisplayText.Text = "Dashboard / Video / <b>Add</b>";
            
        }
    }

    public void BindVideo(int ID)
    {
        try
        {
            DataSet dsContent = video.ViewVideoById(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";                
                dvDate.Attributes["class"] = "md-input-wrapper md-input-filled";
               
               
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["VideoTitle"])))
                    txtTitle.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["VideoTitle"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Department"])))
                {
                    string stDepartment = Convert.ToString(dsContent.Tables[0].Rows[0]["Department"]);
                    ddlDepartment.Items.FindByText(ddlDepartment.SelectedItem.Text).Selected = false;
                    ddlDepartment.Items.FindByText(stDepartment).Selected = true;
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["VdeoThumbImage"])))
                {
                    string CoverImagefilePath = System.Configuration.ConfigurationManager.AppSettings["VideoImages"];
                    hiddenEventImage.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["VdeoThumbImage"]);
                    imgoldImage.Src = CoverImagefilePath + @"\" + hiddenEventImage.Value.ToString().Trim();
                    dvoldImage.Style.Add("display", "block");
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["VideoUrl"])))
                    txtVideoUrl.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["VideoUrl"]);
               
               
                bool Status = Convert.ToBoolean(dsContent.Tables[0].Rows[0]["Active"]);
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

        if (string.IsNullOrEmpty(txtVideoUrl.Text))
        {
            stErrorText = "Please enter video url";
        }
        else if (string.IsNullOrEmpty(txtTitle.Text))
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
                video.VideoId = Convert.ToInt32(Request.QueryString["ID"]);
                UpdateContent(video.VideoId);
            }

        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
    }


    public void InsertContent()
    {
        //try
        //{
            bool status = false;
            if (chkStatus.Checked)
                status = true;
            string steventImage = string.Empty;
            if (flEventImage.HasFile)
                steventImage = flEventImage.FileName.Trim();
            string stdepartment = string.Empty;
            if (!string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
                stdepartment = ddlDepartment.SelectedItem.Text.Trim();
            List<pmuvideo> lstContent = new List<pmuvideo> {
            new pmuvideo{
                VideoTitle=(!string.IsNullOrEmpty(txtTitle.Text))?txtTitle.Text.Trim():string.Empty,
                VideoUrl=(!string.IsNullOrEmpty(txtVideoUrl.Text))?txtVideoUrl.Text.Trim():string.Empty,
                VideoThumbImage=steventImage,                
                Status=status,
                CreatedDate=Utility.IndianTime,
                CreatedBy= login.GetUserName(),
                UpdatedDate=Utility.IndianTime,
                UpdatedBy=login.GetUserName(),
                Department=stdepartment
              }
        };
            if (!string.IsNullOrEmpty(steventImage))
                SaveImageFile();
           
            int InsContent = video.AddVideo(lstContent);
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
        //}
        //catch (Exception ex)
        //{
        //    Response.Write(ex.ToString());
        //}
    }
    
    public void UpdateContent(int ID)
    {
        try
        {
            bool status = false;
            if (chkStatus.Checked)
                status = true;
            string steventImage = string.Empty;
            if (flEventImage.HasFile)
            {
                SaveImageFile();
                steventImage = flEventImage.FileName.Trim();
            }
            if (flEventImage.HasFile && !string.IsNullOrEmpty(hiddenEventImage.Value))
            {
                SaveImageFile();
                steventImage = flEventImage.FileName.Trim();
            }
            else if (!flEventImage.HasFile && !string.IsNullOrEmpty(hiddenEventImage.Value))
            {

                steventImage = hiddenEventImage.Value.Trim();
            }
            string stdepartment = string.Empty;
            if (!string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
                stdepartment = ddlDepartment.SelectedItem.Text.Trim();
            List<pmuvideo> lstContent = new List<pmuvideo> {
            new pmuvideo{
               VideoTitle=(!string.IsNullOrEmpty(txtTitle.Text))?txtTitle.Text.Trim():string.Empty,
                VideoUrl=(!string.IsNullOrEmpty(txtVideoUrl.Text))?txtVideoUrl.Text.Trim():string.Empty,
                VideoThumbImage=steventImage,
                Status=status,               
                UpdatedDate=Utility.IndianTime,
                UpdatedBy=login.GetUserName(),
                 Department=stdepartment
              }
        };

            int UpdateContent = video.UpdateVideo(lstContent, ID);
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
                BindVideo(ID);
            }
        }
        catch (Exception ex)
        {
        }
    }
    public int SaveImageFile()
    {
        int savefile = 0;
        try
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["VideoImages"];
            string temppath = filePath.Trim() + @"\" + flEventImage.FileName;
            string savepath = Server.MapPath(temppath);
            flEventImage.SaveAs(savepath);
            string strPath = flEventImage.FileName;
            savefile = 1;
        }
        catch (Exception ex)
        {
            savefile = 0;
            Response.Write(ex.ToString());
        }
        return savefile;
    }
    
    
   
    protected void btnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }
    public void Clear()
    {
        txtTitle.Text = "";
        txtVideoUrl.Text = "";
        flEventImage.Dispose();

    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewvideo.aspx", true);
    }

    
}