using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class admin_account_iqac_AddGallery : System.Web.UI.Page
{
    pmuAlbum album = new pmuAlbum();
    pmuGallery gallery = new pmuGallery();
    //bvmLogin login = new bvmLogin();
    protected void Page_Load(object sender, EventArgs e)
    {

        lblDisplayText.Text = "Dashboard - Gallery - <b>Add Gallery </b>";
        //lblText.Text = "No Images Added";
        if (!IsPostBack)
        {

            BindAlbum("Iqac");
        }
    }
    
    public void BindGallery(int ID)
    {
        try
        {
            DataSet dsGallery = gallery.ViewGalleryByAlbumID(ID);
            if (dsGallery.Tables.Count > 0 && dsGallery.Tables[0].Rows.Count > 0)
            {
                
                
                lblTotolImages.Text = "<b>Total No Of Images: </b>" + dsGallery.Tables[0].Rows.Count.ToString();
                lblText.Text = "";
                //rprGallery.Visible = true;
                //rprGallery.DataSource = dsGallery.Tables[0].DefaultView;
                //rprGallery.DataBind();


            }
            else
            {
                lblText.Text = "No Images Added";
               // rprGallery.Visible = false;
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
            RepeaterItem item = btnDelete.NamingContainer as RepeaterItem;
            int index = item.ItemIndex;
            string[] args = btnDelete.CommandArgument.Split(',');
            int ID = Convert.ToInt16(args[0]);
            string stImage = Convert.ToString(args[1]);
            int AlbumID = Convert.ToInt16(args[2]);
            string stAlbumName = string.Empty;
            if (!string.IsNullOrEmpty(stImage))
            {
                stAlbumName = GetAlbumName(AlbumID);
                FileDelete(stImage, stAlbumName.Trim().ToLower());
            }
            gallery.DeleteGalleryByID(ID);
            string stTitle = string.Empty;
            lblText.Text = "";
            int GalleryID = 0;
           if (Request.QueryString["ID"] != null)
               GalleryID = Convert.ToInt16(Request.QueryString["ID"]);
           BindGallery(GalleryID);
           
        }
        catch (Exception ex)
        {
        }
    }
    protected void StatusButton_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton btnStatus = sender as LinkButton;
            RepeaterItem item = btnStatus.NamingContainer as RepeaterItem;
            int index = item.ItemIndex;
            string[] args = btnStatus.CommandArgument.Split(',');
            int ID = Convert.ToInt16(args[0]);
            gallery.UpdateGallerySatus(ID);
            string stTitle = string.Empty;
            int GalleryID = 0;
             if (Request.QueryString["ID"] != null)
                GalleryID = Convert.ToInt16(Request.QueryString["ID"]);
             BindGallery(GalleryID);
        }
        catch (Exception ex)
        {
        }
    }
    
    public void FileDelete(string ImageName,string AlbumName)
    {

        string filePath = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["IQACimage"]);
        filePath += "//"+AlbumName.Trim()+"//" + ImageName.Trim();

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

    public string bindImageUrl(string ImgUrl,int AlbumID)
    {
        string Url = string.Empty;
        string stAlbumName = string.Empty;
        stAlbumName = GetAlbumName(AlbumID);
        string filePath = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["IQACimage"]);
        if (!string.IsNullOrEmpty(ImgUrl))
        {
            Url = filePath + "/" + stAlbumName + "/" + ImgUrl.Trim();
        }
        return Url;
    }
    public string bindStatusText(bool Status)
    {
        string StatusText = string.Empty;
        if (Status)
            StatusText = "In Active";
        else
            StatusText = "Active";
        return StatusText;

    }
    public string bindStatusText1(bool Status)
    {
        string StatusText = string.Empty;
        if (Status)
            StatusText = "Active";
        else
            StatusText = "In Active";
        return StatusText;

    }
    public string bindStatusCSS(bool Status)
    {
        string StatusText = string.Empty;
        if (Status)
            StatusText = "success";
        else
            StatusText = "warning";
        return StatusText;

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string stErrorText = string.Empty;
        if (rvImage.Enabled && string.IsNullOrEmpty(flFloorbigImage.FileName))
        {
            stErrorText = "Please upload the Image";
        }
        bool blnValidExtension = false;
        int AlbumID=Convert.ToInt16(ddlAlbum.SelectedValue.ToString());
        if (string.IsNullOrEmpty(stErrorText))
        {
            if (flFloorbigImage.HasFile)
            {
                HttpFileCollection hfc = Request.Files;
                if (hfc.Count <= 20)
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
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Maximum 20 files will be allowed at a time');</script>");

            }
            if (blnValidExtension)
            {
                if (flFloorbigImage.HasFile)
                {
                    HttpFileCollection hfc = Request.Files;
                    if (hfc.Count <= 20)
                    {
                        for (int i = 0; i <= hfc.Count - 1; i++)
                        {
                            HttpPostedFile hpf = hfc[i];

                            if (hpf.ContentLength > 0)
                            {

                                InsertGallery(hpf);
                                BindGalleryByAlbum(AlbumID);
                            }

                            else
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Maximum 20 files will be allowed at a time');</script>");
                        }
                    }

                }
            }
            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Please upload only image files');</script>");


        }

        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
    }

    public bool IsValidExtension(string strfilename)
    {
        bool IsValid = false;
        string ext = Path.GetExtension(strfilename);
        if(ext.ToLower().Equals(".png"))
            IsValid=true;
        else if(ext.ToLower().Equals(".jpg"))
            IsValid=true;
        else if (ext.ToLower().Equals(".gif"))
            IsValid = true;
        else if (ext.ToLower().Equals(".jpeg"))
            IsValid = true;
        else
            IsValid = false;
        return IsValid;
    }
    public void InsertGallery(HttpPostedFile hpf)
    {
        try
        {
            
            int AlbumID = 0;
            bool status = false;
            if (chkStatus.Checked)
                status = true;
            string stAlbumName = string.Empty;
            string stDepartment = "Iqac";
            if (!string.Equals(ddlAlbum.SelectedItem.Text, "Select"))
            {
                AlbumID = Convert.ToInt32(ddlAlbum.SelectedItem.Value.Trim());
                stAlbumName = Convert.ToString(ddlAlbum.SelectedItem.Text.Trim());
            }
           
            if (flFloorbigImage.HasFile)
            {
                
                SaveImageFile(hpf, stAlbumName, stDepartment);
            }
           
            List<pmuGallery> lstGallery = new List<pmuGallery> {
            new pmuGallery{                
                ImageUrl=hpf.FileName.Trim(),
                AlbumID=AlbumID,
                Status=status
                
              }
        };

            int InsGallery = gallery.AddGallery(lstGallery);
            if (InsGallery == -1)
            {

               
                dvCategory.Attributes["class"] = "md-input-wrapper md-input-filled";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Inserted');</script>");
               // BindGalleryByAlbum(AlbumID);

            }  
        }
       
    
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }
    }
   
    public int SaveImageFile(HttpPostedFile hpf, string stAlbumName,string stDepartment)
    {
        int savefile = 0;
        try
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["IQACimage"];
            string temppath = filePath.Trim() + @"\" +  stAlbumName.ToLower().Trim() + @"\" + hpf.FileName.Trim();
            string savepath = Server.MapPath(temppath);
            hpf.SaveAs(savepath);
            string strPath = hpf.FileName.Trim();
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
        ddlAlbum.SelectedIndex = 0;

    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewiqacgallery.aspx", true);
    }

    public void BindAlbum(string stDepartment)
    {
        ddlAlbum.Items.Clear();
        if (!string.IsNullOrEmpty(stDepartment))
        {
            DataSet ds = gallery.ViewActiveAlbumByDepartment(stDepartment);
            string AlbumName = string.Empty;
            int AlbumID = 0;
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ddlAlbum.Items.Add(new ListItem("Select", "Select"));
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    AlbumID = Convert.ToInt32(ds.Tables[0].Rows[i]["AlbumID"]);
                    AlbumName = Convert.ToString(ds.Tables[0].Rows[i]["AlbumName"]);
                    ddlAlbum.Items.Add(new ListItem(AlbumName.Trim(), AlbumID.ToString()));
                }
                ddlAlbum.DataBind();
            }
        }
        else
        {
            ddlAlbum.Items.Add(new ListItem("Select", "Select"));
        }
    }
    public string GetAlbumName(int AlbumID)
    {
        DataSet ds = album.ViewAlbumByID(AlbumID);
        string AlbumName = string.Empty;
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            AlbumName = Convert.ToString(ds.Tables[0].Rows[0]["AlbumName"]);
        return AlbumName.Trim();
    }
    public void BindGalleryByAlbum(int AlbumID)
    {
        DataSet dsGallery = gallery.ViewGalleryByAlbumID(AlbumID);
        if (dsGallery.Tables.Count > 0 && dsGallery.Tables[0].Rows.Count > 0)
        {
            lblText.Text = " ";
            //rprGallery.Visible = true;
            //rprGallery.DataSource = dsGallery.Tables[0].DefaultView;
            //rprGallery.DataBind();

        }
        else
        {
            //rprGallery.Visible = false;
            //lblText.Text = "No Images Added";
        }
    }
    
}
