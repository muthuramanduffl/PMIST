using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class admin_account_events_addevents : System.Web.UI.Page
{
    pmualum alum = new pmualum();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / Alumni Meet / <b>Edit</b>";
            alum.EventId = Convert.ToInt32(Request.QueryString["ID"]);
            if (!IsPostBack)
            {
                //RequiredFieldValidator6.Enabled = false;
                BindEvents(alum.EventId);


            }
        }
        else
        {

            lblDisplayText.Text = "Dashboard / Alumni Meet / <b>Add</b>";
            
        }
    }

    public void BindEvents(int ID)
    {
        try
        {
            DataSet dsContent = alum.ViewAlumniMeetById(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                
                dvDate.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvContent.Attributes["class"] = "md-input-wrapper md-input-filled";
               
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Title"])))
                    txtTitle.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Title"]);
               
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Venue"])))
                    txtVenue.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Venue"]);
               
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Description"])))
                    txtContent.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Description"]);

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["EventStartDate"])))
                {
                    DateTime dtEventStartDate = Convert.ToDateTime(dsContent.Tables[0].Rows[0]["EventStartDate"]);
                    txtEventStartDate.Text = dtEventStartDate.ToString("dd/MM/yyyy");
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Album"])))
                {
                    string[] album = Convert.ToString(dsContent.Tables[0].Rows[0]["Album"]).Split(',');
                    string strimage1 = "";
                    string strimage2 = "";
                    string strimage3 = "";
                    string strimage4 = "";
                    string strimage5 = "";
                    string strimage6 = "";

                    for (int i = 0; i < album.Length; i++)
                    {
                        if (i == 0)
                        {
                            strimage1 = Convert.ToString(album[i]);
                            Image1.ImageUrl = "https://pmu.edu/AlumniMeet_Images/" + strimage1;
                        }
                        if (i == 1)
                        { 
                            strimage2 = Convert.ToString(album[i]);
                            Image2.ImageUrl = "https://pmu.edu/AlumniMeet_Images/" + strimage2;
                        }
                         if (i == 2)
                        {
                            strimage3 = Convert.ToString(album[i]);
                            Image3.ImageUrl = "https://pmu.edu/AlumniMeet_Images/" + strimage3;
                        }
                        if (i == 3)
                        { 
                            strimage4 = Convert.ToString(album[i]);
                            Image4.ImageUrl = "https://pmu.edu/AlumniMeet_Images/" + strimage4;
                        }
                         if (i == 4)
                        {
                            strimage5 = Convert.ToString(album[i]);
                            Image5.ImageUrl = "https://pmu.edu/AlumniMeet_Images/" + strimage5;
                        }
                        if (i == 5)
                        { 
                            strimage6 = Convert.ToString(album[i]);
                            Image6.ImageUrl = "https://pmu.edu/AlumniMeet_Images/" + strimage6;
                        }
                        //if (i == 2) Image3.ImageUrl = Server.MapPath("~/AlumniMeet_Images/") + strimage;
                        //if (i == 3) Image4.ImageUrl = Server.MapPath("~/AlumniMeet_Images/") + strimage;
                        //if (i == 4) Image5.ImageUrl = Server.MapPath("~/AlumniMeet_Images/") + strimage;
                        //if (i == 5) Image6.ImageUrl = Server.MapPath("~/AlumniMeet_Images/") + strimage;
                    }
                }
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
         else if (string.IsNullOrEmpty(txtVenue.Text))
        {
            stErrorText = "Please enter Venue";
        }
       
        else if (string.IsNullOrEmpty(txtEventStartDate.Text))
        {
            stErrorText = "Please enter event start date";
        }
        else if (string.IsNullOrEmpty(fImage.FileName))
        {
            stErrorText = "Please upload the Image";
        }

        bool blnValidExtension = false;
        if (fImage.HasFile)
        {
            HttpFileCollection hfc = Request.Files;
            if (hfc.Count <= 6)
            {
                for (int i = 0; i <= hfc.Count - 1; i++)
                {
                    HttpPostedFile hpf = hfc[i];

                    if (hpf.ContentLength > 0)
                    {
                        blnValidExtension = IsValidExtension(hpf.FileName.Trim());
                        if (!blnValidExtension)
                            break;
                    }
                }

            }
            else
                stErrorText = "Maximum 6 files will be allowed at a time";
        }

        if (string.IsNullOrEmpty(stErrorText))
        {
            if (Request.QueryString["ID"] == null)
            {

                InsertContent();
            }
            else
            {
                alum.EventId = Convert.ToInt32(Request.QueryString["ID"]);
                UpdateContent(alum.EventId);
            }

        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
        btnSave.Text = "Save";
    }

    public bool IsValidExtension(string strfilename)
    {
        bool IsValid = false;
        string ext = Path.GetExtension(strfilename);
        if (ext.ToLower().Equals(".png"))
            IsValid = true;
        else if (ext.ToLower().Equals(".jpg"))
            IsValid = true;
        else if (ext.ToLower().Equals(".gif"))
            IsValid = true;
        else if (ext.ToLower().Equals(".jpeg"))
            IsValid = true;
        else
            IsValid = false;
        return IsValid;
    }

    public void InsertContent()
    {
        try
        {
            bool status = false;
            if (chkStatus.Checked)
                status = true;

            HttpFileCollection _HttpFileCollection = Request.Files;
            string images = "";
            for (int i = 0; i < _HttpFileCollection.Count; i++)
            {
                HttpPostedFile _HttpPostedFile = _HttpFileCollection[i];
                string ext = Path.GetExtension(_HttpPostedFile.FileName);
                string fname = i +"_"+_HttpPostedFile.FileName;
                if (_HttpPostedFile.ContentLength > 0) _HttpPostedFile.SaveAs(Server.MapPath("~/AlumniMeet_Images/" + Path.GetFileName(fname)));
                if(images=="")
                    images = fname;
                else
                    images = images + ","+ fname;
            }

            List<pmualum> lstContent = new List<pmualum> {
            new pmualum{
                Title=(!string.IsNullOrEmpty(txtTitle.Text))?txtTitle.Text.Trim():string.Empty,
                Description=(!string.IsNullOrEmpty(txtContent.Text))?txtContent.Text.Trim():string.Empty,
                Venue=(!string.IsNullOrEmpty(txtVenue.Text))?txtVenue.Text.Trim():string.Empty,
        

                EventStartDate=(!string.IsNullOrEmpty(txtEventStartDate.Text))?DateTime.ParseExact(txtEventStartDate.Text.Trim(), "dd/MM/yyyy", null):Utility.IndianTime,
                PostedDate=Utility.IndianTime,
                PostedBy="admin",// login.GetUserName(),
                Status=status,

                UpdatedDate=Utility.IndianTime,
                UpdatedBy="admin",

                Album = images
                }
            };

            int InsContent = alum.AddAlumniMeet(lstContent);
            if (InsContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvVenue.Attributes["class"] = "md-input-wrapper md-input-filled";
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

            HttpFileCollection _HttpFileCollection = Request.Files;
            string images = "";
            for (int i = 0; i < _HttpFileCollection.Count; i++)
            {
                HttpPostedFile _HttpPostedFile = _HttpFileCollection[i];
                string ext = Path.GetExtension(_HttpPostedFile.FileName);
                string fname = i + "_" + _HttpPostedFile.FileName;
                if (_HttpPostedFile.ContentLength > 0) _HttpPostedFile.SaveAs(Server.MapPath("~/AlumniMeet_Images/" + Path.GetFileName(fname)));
                if (images == "")
                    images = fname;
                else
                    images = images + "," + fname;
            }
            List<pmualum> lstContent = new List<pmualum> {
            new pmualum{
               Title=(!string.IsNullOrEmpty(txtTitle.Text))?txtTitle.Text.Trim():string.Empty,
               Description=(!string.IsNullOrEmpty(txtContent.Text))?txtContent.Text.Trim():string.Empty,
             Venue=(!string.IsNullOrEmpty(txtVenue.Text))?txtVenue.Text.Trim():string.Empty,
                
                EventStartDate=(!string.IsNullOrEmpty(txtEventStartDate.Text))?DateTime.ParseExact(txtEventStartDate.Text.Trim(), "dd/MM/yyyy", null):Utility.IndianTime,
                PostedDate=Utility.IndianTime,
                PostedBy="admin",// login.GetUserName(),
                Status=status,
        
                UpdatedDate=Utility.IndianTime,
                UpdatedBy="admin",
                Album = images

              }
            };

            int UpdateContent = alum.UpdateAlumniMeet(lstContent, ID);
            if (UpdateContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvVenue.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDate.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvContent.Attributes["class"] = "md-input-wrapper md-input-filled";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
                if (status)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
               
                BindEvents(ID);
            }
        }
        catch (Exception ex)
        {
        }
    }


   
    protected void btnClear_Click(object sender, EventArgs e)
    {

        txtTitle.Text = "";
        txtVenue.Text = "";
        txtContent.Text = "";
  
        txtEventStartDate.Text = "";
  

        chkStatus.Checked = true;
        
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewalumnimeet.aspx", true);
    }

    
}