using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_account_events_adddachievementcorner : System.Web.UI.Page
{
    pmuachievement achievements = new pmuachievement();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / Achievement Corner / <b>Edit</b>";
            achievements.Id = Convert.ToInt32(Request.QueryString["ID"]);
            if (!IsPostBack)
            {
                RequiredFieldValidator6.Enabled = false;
                BindAchievements(achievements.Id);


            }
        }
        else
        {

            lblDisplayText.Text = "Dashboard / Achievement Corner / <b>Add</b>";
            
        }
    }

    public void BindAchievements(int ID)
    {
        try
        {
            DataSet dsContent = achievements.ViewAchievementById(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
            
               
                dvContent.Attributes["class"] = "md-input-wrapper md-input-filled";
               
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Title"])))
                    txtTitle.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Title"]);

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["mainContent"])))
                    txtContent.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["mainContent"]);

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["BigImage"])))
                {
                    string CoverImagefilePath = System.Configuration.ConfigurationManager.AppSettings["achievementImages"];
                    hiddenEventImage.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["BigImage"]);
                    imgoldImage.Src = CoverImagefilePath + @"\" + hiddenEventImage.Value.ToString().Trim();
                    dvoldImage.Style.Add("display", "block");
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["AddlImage"])))
                {
                    string CoverImagefilePath = System.Configuration.ConfigurationManager.AppSettings["achievementImages"];
                    hiddenAddlImage.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["AddlImage"]);
                    imgoldAddlImage.Src = CoverImagefilePath + @"\" + hiddenAddlImage.Value.ToString().Trim();
                    dvoldAddlImage.Style.Add("display", "block");
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["NewsContent"])))
                    txtContent.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["NewsContent"]);
                
               
               
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

        if (string.IsNullOrEmpty(txtContent.Text))
        {
            stErrorText = "Please enter Content";
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
                txtTitle.Text = "";
                txtContent.Text = "";

            }
            else
            {
                achievements.Id = Convert.ToInt32(Request.QueryString["ID"]);
                UpdateContent(achievements.Id);
            }

        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
        btnSave.Text = "Save";
    }


    public void InsertContent()
    {
        try
        {
            bool status = false;
            if (chkStatus.Checked)
                status = true;

            string stBigImage = string.Empty;

            if (flEventImage.HasFile)
                stBigImage = flEventImage.FileName.Trim();

            string stAddlImage = string.Empty;
            if (flAddlImage.HasFile)
                stAddlImage = flAddlImage.FileName.Trim();

            List<pmuachievement> lstContent = new List<pmuachievement> {
            new pmuachievement{
                Title=(!string.IsNullOrEmpty(txtTitle.Text))?txtTitle.Text.Trim():string.Empty,
                BigImage=stBigImage,
                AddlImage=stAddlImage,
                mainContent=(!string.IsNullOrEmpty(txtContent.Text))?txtContent.Text.Trim():string.Empty,
                Active=status,
                AddedDate=Utility.IndianTime,
                AddedBy="admin",// login.GetUserName(),
                UpdatedDate=Utility.IndianTime,
                UpdatedBy="admin",

              }
        };
            if (!string.IsNullOrEmpty(stBigImage))
                SaveImageFile();


            if (!string.IsNullOrEmpty(stAddlImage))
                SaveAddlImageFile();

            int InsContent = achievements.AddAchievement(lstContent);
            if (InsContent == -1)
            {
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvContent.Attributes["class"] = "md-input-wrapper md-input-filled";
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
        //try
        //{
            bool status = false;
            if (chkStatus.Checked)
                status = true;


            string stBigImage = string.Empty;
            if (flEventImage.HasFile)
            {
                SaveImageFile();
                stBigImage = flEventImage.FileName.Trim();
            }
           
            else if (!flEventImage.HasFile && !string.IsNullOrEmpty(hiddenEventImage.Value))
            {

                stBigImage = hiddenEventImage.Value.Trim();
            }

            string stAddlImage = string.Empty;
            if (flAddlImage.HasFile)
            {
                SaveAddlImageFile();
                stAddlImage = flAddlImage.FileName.Trim();
            }
            
            else if (!flAddlImage.HasFile && !string.IsNullOrEmpty(hiddenAddlImage.Value))
            {

                stAddlImage = hiddenAddlImage.Value.Trim();
            }

            List<pmuachievement> lstContent = new List<pmuachievement> {
            new pmuachievement{
                Title=(!string.IsNullOrEmpty(txtTitle.Text))?txtTitle.Text.Trim():string.Empty,
                BigImage=stBigImage,
                AddlImage=stAddlImage,
                mainContent=(!string.IsNullOrEmpty(txtContent.Text))?txtContent.Text.Trim():string.Empty,              
                UpdatedDate=Utility.IndianTime,
                UpdatedBy="admin",
                Active=status

              }
        };

            int UpdateContent = achievements.UpdateAchievement(lstContent, ID);
            if (UpdateContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvContent.Attributes["class"] = "md-input-wrapper md-input-filled";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
                if (status)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
                // string stUrl = "<a href='/news-details.aspx?ID=" + ID + "' target='_blank'>Live Url :News</a>";
                //phLiveUrl.Controls.Add(new LiteralControl(stUrl.Trim()));
                BindAchievements(ID);
            }
        //}
        //catch (Exception ex)
        //{
        //}
    }
    public int SaveImageFile()
    {
        int savefile = 0;
        try
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["achievementImages"];
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
    public int SaveAddlImageFile()
    {
        int savefile = 0;
        try
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["achievementImages"];
            string temppath = filePath.Trim() + @"\" + flAddlImage.FileName;
            string savepath = Server.MapPath(temppath);
            flAddlImage.SaveAs(savepath);
            string strPath = flAddlImage.FileName;
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

        txtTitle.Text = "";
        txtContent.Text = "";

        flAddlImage.Dispose();
        flEventImage.Dispose();
      

        chkStatus.Checked = true;
        
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewachievementcorner.aspx", true);
    }

    
}