using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_account_events_addevents : System.Web.UI.Page
{
    pmuevents events = new pmuevents();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / Events / <b>Edit</b>";
            events.EventId = Convert.ToInt32(Request.QueryString["ID"]);
            if (!IsPostBack)
            {
                RequiredFieldValidator6.Enabled = false;
                BindEvents(events.EventId);


            }
        }
        else
        {

            lblDisplayText.Text = "Dashboard / Events / <b>Add</b>";
            
        }
    }

    public void BindEvents(int ID)
    {
        try
        {
            DataSet dsContent = events.ViewEventsById(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvHeaderTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDate.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvContent.Attributes["class"] = "md-input-wrapper md-input-filled";
               
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Title"])))
                    txtTitle.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Title"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Department"])))
                {
                    string stDepartment= Convert.ToString(dsContent.Tables[0].Rows[0]["Department"]);
                    ddlDepartment.Items.FindByText(ddlDepartment.SelectedItem.Text).Selected = false;
                    ddlDepartment.Items.FindByText(stDepartment).Selected = true;
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["NewsImage"])))
                {
                    string CoverImagefilePath = System.Configuration.ConfigurationManager.AppSettings["EventImages"];
                    hiddenEventImage.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["NewsImage"]);
                    imgoldImage.Src = CoverImagefilePath + @"\" + hiddenEventImage.Value.ToString().Trim();
                    dvoldImage.Style.Add("display", "block");
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["NewsContent"])))
                    txtContent.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["NewsContent"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["ShortAbstract"])))
                    txtShortDesc.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["ShortAbstract"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["EventStartDate"])))
                {
                    DateTime dtEventStartDate = Convert.ToDateTime(dsContent.Tables[0].Rows[0]["EventStartDate"]);
                    txtEventStartDate.Text = dtEventStartDate.ToString("dd/MM/yyyy");
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["EventEndDate"])))
                {
                    DateTime dtEventEndDate = Convert.ToDateTime(dsContent.Tables[0].Rows[0]["EventEndDate"]);
                    txtEventEndDate.Text = dtEventEndDate.ToString("dd/MM/yyyy");
                }
                bool Status = Convert.ToBoolean(dsContent.Tables[0].Rows[0]["Active"]);
                chkStatus.Checked = Status;
                bool ShowHomePage = Convert.ToBoolean(dsContent.Tables[0].Rows[0]["ShowHomePage"]);
                chkShowHome.Checked = ShowHomePage;


                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["pdf1"])))
                {
                    hlPDF1.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["pdf1"]);
                    string path = System.Configuration.ConfigurationManager.AppSettings["Eventpdf"];
                    string pdf1path = path +  hlPDF1.Value;
                    phpdf1.Controls.Add(new LiteralControl("PDF 1: <a href='" + pdf1path + "' target='_balnk'>View PDF 1</a>"));
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["pdf2"])))
                {
                    hlPDF2.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["pdf2"]);
                    string path = System.Configuration.ConfigurationManager.AppSettings["Eventpdf"];
                    string pdf2path = path +  hlPDF2.Value;
                    phpdf2.Controls.Add(new LiteralControl("PDF 2: <a href='" + pdf2path + "' target='_balnk'>View PDF 2</a>"));
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["pdf3"])))
                {
                    hlPDF3.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["pdf3"]);
                    string path = System.Configuration.ConfigurationManager.AppSettings["Eventpdf"];
                    string pdf3path = path +  hlPDF3.Value;
                    phpdf3.Controls.Add(new LiteralControl("PDF 3: <a href='" + pdf3path + "' target='_balnk'>View PDF 3</a>"));
                }

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
        else if (string.IsNullOrEmpty(txtShortDesc.Text))
        {
            stErrorText = "Please enter short description";
        }
        else if (string.IsNullOrEmpty(txtEventStartDate.Text))
        {
            stErrorText = "Please enter event start date";
        }
        else if (string.IsNullOrEmpty(txtEventEndDate.Text))
        {
            stErrorText = "Please enter event end description";
        }
        if (string.IsNullOrEmpty(stErrorText))
        {
            if (Request.QueryString["ID"] == null)
            {

                InsertContent();
            }
            else
            {
                events.EventId = Convert.ToInt32(Request.QueryString["ID"]);
                UpdateContent(events.EventId);
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

            bool showHomePage = false;
            if (chkShowHome.Checked)
                showHomePage = true;

            string steventImage = string.Empty;
            string stpdf1 = string.Empty;
            string stpdf2 = string.Empty;
            string stpdf3 = string.Empty;
            string stdepartment = string.Empty;
            if (!string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
                stdepartment = ddlDepartment.SelectedItem.Text.Trim();
            if (flEventImage.HasFile)
                steventImage = flEventImage.FileName.Trim();
            if (flPDF1.HasFile)
                stpdf1 = flPDF1.FileName.Trim();
            if (flPDF2.HasFile)
                stpdf2 = flPDF2.FileName.Trim();
            if (flPDF3.HasFile)
                stpdf3 = flPDF3.FileName.Trim();
            List<pmuevents> lstContent = new List<pmuevents> {
            new pmuevents{
                Title=(!string.IsNullOrEmpty(txtTitle.Text))?txtTitle.Text.Trim():string.Empty,
                ShortAbstract=(!string.IsNullOrEmpty(txtShortDesc.Text))?txtShortDesc.Text.Trim():string.Empty,
                Department=(!string.IsNullOrEmpty(stdepartment))?stdepartment:string.Empty,
                NewsImage=steventImage,
                NewsContent=(!string.IsNullOrEmpty(txtContent.Text))?txtContent.Text.Trim():string.Empty,
                EventStartDate=(!string.IsNullOrEmpty(txtEventStartDate.Text))?DateTime.ParseExact(txtEventStartDate.Text.Trim(), "dd/MM/yyyy", null):Utility.IndianTime,
                EventEndDate=(!string.IsNullOrEmpty(txtEventEndDate.Text))?DateTime.ParseExact(txtEventEndDate.Text.Trim(), "dd/MM/yyyy", null):Utility.IndianTime,
                Status=status,
                PostedDate=Utility.IndianTime,
                PostedBy="admin",// login.GetUserName(),
                UpdatedDate=Utility.IndianTime,
                UpdatedBy="admin",
                pdf1=stpdf1,
                pdf2=stpdf2,
                pdf3=stpdf3,
                ShowHomePage=showHomePage
              }
        };
            if (!string.IsNullOrEmpty(steventImage))
                SaveImageFile();
            if (!string.IsNullOrEmpty(stpdf1))
                Savepdf1File();
            if (!string.IsNullOrEmpty(stpdf2))
                Savepdf2File();
            if (!string.IsNullOrEmpty(stpdf3))
                Savepdf3File();
            int InsContent = events.AddEvents(lstContent);
            if (InsContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvHeaderTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDate.Attributes["class"] = "md-input-wrapper md-input-filled";
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
        try
        {
            bool status = false;
            if (chkStatus.Checked)
                status = true;
            bool showHomePage = false;
            if (chkShowHome.Checked)
                showHomePage = true;

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
            string stpdf1 = string.Empty;
            if (flPDF1.HasFile)
            {
                Savepdf1File();
                stpdf1 = flPDF1.FileName.Trim();
            }
            if (flPDF1.HasFile && !string.IsNullOrEmpty(hlPDF1.Value))
            {
                Savepdf1File();
                stpdf1 = flPDF1.FileName.Trim();
            }
            else if (!flPDF1.HasFile && !string.IsNullOrEmpty(hlPDF1.Value))
            {

                stpdf1 = hlPDF1.Value.Trim();
            }
            string stpdf2 = string.Empty;
            if (flPDF2.HasFile)
            {
                Savepdf2File();
                stpdf2 = flPDF2.FileName.Trim();
            }
            if (flPDF2.HasFile && !string.IsNullOrEmpty(hlPDF2.Value))
            {
                Savepdf2File();
                stpdf2 = flPDF2.FileName.Trim();
            }
            else if (!flPDF2.HasFile && !string.IsNullOrEmpty(hlPDF2.Value))
            {

                stpdf2 = hlPDF2.Value.Trim();
            }
            string stpdf3 = string.Empty;
            if (flPDF3.HasFile)
            {
                Savepdf3File();
                stpdf3 = flPDF3.FileName.Trim();
            }
            if (flPDF3.HasFile && !string.IsNullOrEmpty(hlPDF3.Value))
            {
                Savepdf3File();
                stpdf3 = flPDF3.FileName.Trim();
            }
            else if (!flPDF3.HasFile && !string.IsNullOrEmpty(hlPDF3.Value))
            {

                stpdf3 = hlPDF3.Value.Trim();
            }
            string stdepartment = string.Empty;
            if (!string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
                stdepartment = ddlDepartment.SelectedItem.Text.Trim();
            List<pmuevents> lstContent = new List<pmuevents> {
            new pmuevents{
               Title=(!string.IsNullOrEmpty(txtTitle.Text))?txtTitle.Text.Trim():string.Empty,
                ShortAbstract=(!string.IsNullOrEmpty(txtShortDesc.Text))?txtShortDesc.Text.Trim():string.Empty,
                Department=(!string.IsNullOrEmpty(stdepartment))?stdepartment:string.Empty,
                NewsImage=steventImage,
                NewsContent=(!string.IsNullOrEmpty(txtContent.Text))?txtContent.Text.Trim():string.Empty,
                EventStartDate=(!string.IsNullOrEmpty(txtEventStartDate.Text))?DateTime.ParseExact(txtEventStartDate.Text.Trim(), "dd/MM/yyyy", null):Utility.IndianTime,
                EventEndDate=(!string.IsNullOrEmpty(txtEventEndDate.Text))?DateTime.ParseExact(txtEventEndDate.Text.Trim(), "dd/MM/yyyy", null):Utility.IndianTime,
                Status=status,
                PostedDate=Utility.IndianTime,
                PostedBy="admin",// login.GetUserName(),
                UpdatedDate=Utility.IndianTime,
                UpdatedBy="admin",
                pdf1=stpdf1,
                pdf2=stpdf2,
                pdf3=stpdf3,
                ShowHomePage=showHomePage
              }
        };

            int UpdateContent = events.UpdateEvents(lstContent, ID);
            if (UpdateContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvHeaderTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvContent.Attributes["class"] = "md-input-wrapper md-input-filled";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
                if (status)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
                // string stUrl = "<a href='/news-details.aspx?ID=" + ID + "' target='_blank'>Live Url :News</a>";
                //phLiveUrl.Controls.Add(new LiteralControl(stUrl.Trim()));
                BindEvents(ID);
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
            string filePath = System.Configuration.ConfigurationManager.AppSettings["EventImages"];
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
    public int Savepdf1File()
    {
        int savefile = 0;
        try
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["Eventpdf"];
            string temppath = filePath.Trim() + @"\" + flPDF1.FileName;
            string savepath = Server.MapPath(temppath);
            flPDF1.SaveAs(savepath);
            string strPath = flPDF1.FileName;
            savefile = 1;
        }
        catch (Exception ex)
        {
            savefile = 0;
            Response.Write(ex.ToString());
        }
        return savefile;
    }
    public int Savepdf2File()
    {
        int savefile = 0;
        try
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["Eventpdf"];
            string temppath = filePath.Trim() + @"\" + flPDF2.FileName;
            string savepath = Server.MapPath(temppath);
            flPDF2.SaveAs(savepath);
            string strPath = flPDF2.FileName;
            savefile = 1;
        }
        catch (Exception ex)
        {
            savefile = 0;
            Response.Write(ex.ToString());
        }
        return savefile;
    }
    public int Savepdf3File()
    {
        int savefile = 0;
        try
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["Eventpdf"];
            string temppath = filePath.Trim() + @"\" + flPDF3.FileName;
            string savepath = Server.MapPath(temppath);
            flPDF3.SaveAs(savepath);
            string strPath = flPDF3.FileName;
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
        txtShortDesc.Text = "";
        txtEventStartDate.Text = "";
        txtEventEndDate.Text = "";
        ddlDepartment.SelectedIndex = 0;
        flEventImage.Dispose();
        flPDF1.Dispose();
        flPDF2.Dispose();
        flPDF3.Dispose();
        chkShowHome.Checked = true;
        chkStatus.Checked = true;
        
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewevents.aspx", true);
    }

    
}