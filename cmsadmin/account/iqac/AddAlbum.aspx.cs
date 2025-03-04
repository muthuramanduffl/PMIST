using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
public partial class admin_account_gallery_AddAlbum : System.Web.UI.Page
{
    pmuAlbum album = new pmuAlbum();
    pmuGallery gallery = new pmuGallery();
    pmuLogin login = new pmuLogin();
    //bvmLogin login = new bvmLogin();
    protected void Page_Load(object sender, EventArgs e)
    {

        lblDisplayText.Text = "Dashboard / Gallery / <b>Add/Edit Album</b>";


        if (!IsPostBack)
        {
            BindAlbum();
            //BindLiveUrl();
        }

    }

    
    
    protected void btnPublish_Click(object sender, EventArgs e)
    {
        string stErrorText = string.Empty;

        if (string.IsNullOrEmpty(txtAlbumName.Text))
        {
            stErrorText = "Please enter Album Name";
        }
        
        if (string.IsNullOrEmpty(stErrorText))
        {
            InsertAlbum();
           
        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
    }
    
    public void BindAlbum()
    {
        //try
        //{
        DataSet dsAlbum = album.ViewAlbumByOnlyDepartment("Iqac");
            if (dsAlbum.Tables.Count > 0 && dsAlbum.Tables[0].Rows.Count > 0)
            {
                lblcheck.Text = "";
                grvAlbum.Visible = true;
                grvAlbum.DataSource = dsAlbum;
                grvAlbum.DataBind();
            }
            else
            {
                lblcheck.Visible = true;
                grvAlbum.Visible = false;
                lblcheck.Text = "No Records Found";
            }
        //}

        //catch (Exception ex)
        //{
        //}
    }
    protected void Button_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton btnDelete = sender as LinkButton;
            GridViewRow row = (GridViewRow)btnDelete.NamingContainer;
            string[] args = btnDelete.CommandArgument.Split(',');
            int AlbumID = Convert.ToInt16(args[0]);
            string AlbumName = Convert.ToString(args[1]);
            int galleryDelete = 0;
            galleryDelete = DeleteGallery(AlbumID);

            if (galleryDelete == 1 || galleryDelete == 0)
            {
                int albumDelete = album.DeleteAlbumByID(AlbumID);
                if (albumDelete == -1)
                    clearFolder(AlbumName);
            }
            BindAlbum();
        }
        catch (Exception ex)
        {
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string stErrorText = string.Empty;
        
        if (string.IsNullOrEmpty(txtAlbumName.Text))
        {
            stErrorText = "Please enter Album Name";
        }
       
        if (string.IsNullOrEmpty(stErrorText))
        {
            InsertAlbum();

        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
    }


    public void InsertAlbum()
    {
        try
        {
            
            bool blnStatus = false;
            if (chkStatus.Checked)
                blnStatus = true;
          
            List<pmuAlbum> lstContent = new List<pmuAlbum> {
            new pmuAlbum{
                AlbumName=(!string.IsNullOrEmpty(txtAlbumName.Text.Trim()))?txtAlbumName.Text.Trim():string.Empty,
              
                Status=blnStatus,
                CreatedDateTime=Utility.IndianTime,
                CreatedBy=login.GetUserName(),
                UpdatedDateTime=Utility.IndianTime,
                UpdatedBy=login.GetUserName(),
                Department="Iqac"

              }
        };
            
            bool DirectotyExists = CreateFolder(txtAlbumName.Text.Trim().ToLower());
            if (!DirectotyExists)
            {
                int InsAlbum = album.AddAlbum(lstContent);
                if (InsAlbum == -1)
                {

                    dvAlbumName.Attributes["class"] = "md-input-wrapper md-input-filled";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Inserted');</script>");
                    txtAlbumName.Text = "";
                    BindAlbum();
                    
                   
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Album Name alreday Exists');</script>");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }
    }
   
    public bool CreateFolder(string foldername)
    {
        bool DirectotyExists = false;

        string path = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["IQACimage"]);

        if (!System.IO.Directory.Exists(path + "\\" +  foldername.Trim()))
        {

            System.IO.Directory.CreateDirectory(path + "\\" + foldername.Trim());


        }

        else
        {
            DirectotyExists = true;

        }
        return DirectotyExists;
       
    }

    public bool IsDirectotyExists(string foldername)
    {
        bool DirectotyExists = false;
        string path = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["IQACimage"]);

        if (!System.IO.Directory.Exists(path + "\\" +  foldername.Trim()))
        {

            DirectotyExists = false;


        }

        else
        {
            DirectotyExists = true;

        }
        return DirectotyExists;
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtAlbumName.Text = "";      
        Response.Redirect("AddAlbum.aspx");
       
    }
    
    
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindAlbum();

        grvAlbum.PageIndex = e.NewPageIndex;

        grvAlbum.DataBind();

    }
    protected void Statusimg_click(object sender, EventArgs e)
    {
        try
        {
            ImageButton imgRead = sender as ImageButton;
            GridViewRow row = (GridViewRow)imgRead.NamingContainer;
            int Sno = int.Parse(imgRead.CommandArgument);
            string stUpdatedBy = "admin";
            DateTime dtUpdatedTime = Utility.IndianTime;
            album.UpdateAlbumSatus(Sno, stUpdatedBy, dtUpdatedTime);
            BindAlbum();
        }
        catch (Exception ex)
        {
        }
    }
    protected void grvAlbum_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvAlbum.EditIndex = e.NewEditIndex;
        BindAlbum();
    }
    protected void grvAlbum_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //try
        //{
            int Albumid = Convert.ToInt32(grvAlbum.DataKeys[e.RowIndex].Value.ToString());
            TextBox txtAlbum = (TextBox)grvAlbum.Rows[e.RowIndex].FindControl("txtEditAlbumName");
            HiddenField hiddenAlbum = (HiddenField)grvAlbum.Rows[e.RowIndex].FindControl("hiddenAlbumName");
            HiddenField hiddenStatus = (HiddenField)grvAlbum.Rows[e.RowIndex].FindControl("hiddenStatus");
          
            string stUpdatedBy =  login.GetUserName();
            bool blnStatus = Convert.ToBoolean(hiddenStatus.Value);
            string stDepartment = "Iqac";
            
            if (IsValidAlbum(txtAlbum.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(txtAlbum.Text) && !string.IsNullOrEmpty(hiddenAlbum.Value))
                {

                    if (!IsDirectotyExists(txtAlbum.Text.Trim()))
                    {
                        CreateAlbum(hiddenAlbum.Value.ToString().ToLower(), txtAlbum.Text.Trim().ToLower());
                        album.UpdateAlbum(txtAlbum.Text.Trim(), Albumid, stUpdatedBy, blnStatus, Utility.IndianTime, stDepartment);
                        clearFolder(hiddenAlbum.Value.ToString().ToLower());
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
                    }
                    else if (IsDirectotyExists(txtAlbum.Text.Trim()))
                    {
                        if (IsAlbumExists(txtAlbum.Text.Trim(),Albumid))
                            //if (!string.Equals(txtAlbum.Text.Trim(), hiddenAlbum.Value.Trim()))
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Album Name alreday Exists');</script>");
                        else
                        {
                            album.UpdateAlbum(txtAlbum.Text.Trim(), Albumid, stUpdatedBy, blnStatus, Utility.IndianTime, stDepartment);
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
                        }
                    }
                    else
                       if (IsAlbumExists(txtAlbum.Text.Trim(), Albumid))
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Album Name alreday Exists');</script>");
                }
            }
            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Please enter valid Albumn Name');</script>");
            grvAlbum.EditIndex = -1;
            BindAlbum();
        //}
        //catch (Exception ex)
        //{
        //}
    }
    public bool IsAlbumExists(string stAlbumName,int AlbumId)
    {
        bool IsExist = false;
        DataSet ds = gallery.ViewAlbumByDepartment("Iqac", stAlbumName);
        if(ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
        {
            int Id = Convert.ToInt32(ds.Tables[0].Rows[0]["AlbumId"]);
            if (Id != AlbumId)
                IsExist = true;
        }
        return IsExist;

    }
    public bool IsAlbumExistsForCrearte(string stAlbumName, string stDepartment)
    {
        bool IsExist = false;
        DataSet ds = gallery.ViewAlbumByDepartment("Iqac", stAlbumName);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            IsExist = true;
        return IsExist;

    }
    public bool IsValidAlbum(string strAlbum)
    {
        bool blValid = false;

        if (System.Text.RegularExpressions.Regex.IsMatch(strAlbum.Trim(), "^[a-zA-Z0-9-_\x20]+$"))
            blValid = true;
        else
            blValid = false;
        return blValid;

    }
    public string GetDepartmentAlbum(string stDepartment)
    {
        string stAlbum = string.Empty;
        if (string.Equals(stDepartment, "General"))
            stAlbum = "general";
        else if (string.Equals(stDepartment, "PMIST"))
            stAlbum = "pmist";
        else if (string.Equals(stDepartment, "Centre for Institute Industry Interactions"))
            stAlbum = "general";
        else if(string.Equals(stDepartment, "Department of Architecture"))
            stAlbum = "architecture";
        else if(string.Equals(stDepartment, "Department of Aerospace Engineering"))
            stAlbum = "aerospace";
        else if(string.Equals(stDepartment, "Department of Bio-Technology"))
            stAlbum = "biotechnology";
        if (string.Equals(stDepartment, "Department of Chemical Engineering"))
            stAlbum = "chemical";
        if (string.Equals(stDepartment, "Department of Civil Engineering"))
            stAlbum = "civil";
        if (string.Equals(stDepartment, "Department of Electronics and Communication Engineering"))
            stAlbum = "electronics";
        if (string.Equals(stDepartment, "Department of Electrical and Electronics Engineering"))
            stAlbum = "electrical";
        if (string.Equals(stDepartment, "Department of Mechanical Engineering"))
            stAlbum = "mechanical";
        if (string.Equals(stDepartment, "Division of Nanotechnology"))
            stAlbum = "nanotechnology";
        if (string.Equals(stDepartment, "Department of Computer Science and Engineering"))
            stAlbum = "computerscience";
        if (string.Equals(stDepartment, "Department of Computer Science & Application"))
            stAlbum = "computerapplication";
        if (string.Equals(stDepartment, "Department of Software Engineering"))
            stAlbum = "softwareengineering";
        if (string.Equals(stDepartment, "Department of Chemistry"))
            stAlbum = "chemistry";
        if (string.Equals(stDepartment, "Department of Commerce"))
            stAlbum = "commerce";
        if (string.Equals(stDepartment, "Department of English"))
            stAlbum = "english";
        if (string.Equals(stDepartment, "Department of Education"))
            stAlbum = "education";
        if (string.Equals(stDepartment, "Department of Mathematics"))
            stAlbum = "mathematics";
        if (string.Equals(stDepartment, "Department of Management Studies"))
            stAlbum = "management";
        if (string.Equals(stDepartment, "Department of Physics"))
            stAlbum = "physics";
        if (string.Equals(stDepartment, "Department of Political Science"))
            stAlbum = "politicalscience";
        if (string.Equals(stDepartment, "Department of Social Work"))
            stAlbum = "socialwork";
        if (string.Equals(stDepartment, "Department of MBA"))
            stAlbum = "mba";
        if (string.Equals(stDepartment, "Department of MBA"))
            stAlbum = "iqac";
        return stAlbum;

    }
    private void clearFolder(string FolderName)
    {

        string path = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["IQACimage"]);
        DirectoryInfo dir = new DirectoryInfo(path + "\\" + FolderName.Trim());
        
        if (dir != null)
        {
            string[] files = System.IO.Directory.GetFiles(path + "\\" + FolderName.Trim());
            if (files!= null)
            {
                foreach (FileInfo fi in dir.GetFiles())
                {
                    fi.Delete();
                }
                dir.Delete();
            }

        }
    }
    public void CreateAlbum(string strAlbum, string newAlubum)
    {
        try
        {
            string path = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["IQACimage"]);
            DirectoryInfo src = new DirectoryInfo(path + "\\" + strAlbum.Trim());
            DirectoryInfo dest = new DirectoryInfo(path + "\\" + newAlubum.Trim());
            CopyDirectory(src, dest);
        }
        catch (Exception ex)
        {
        }
    }
   

    public void CopyDirectory(DirectoryInfo source, DirectoryInfo destination)
    {
        try
        {
            if (!destination.Exists)
            {
                destination.Create();
            }

            FileInfo[] files = source.GetFiles();
            foreach (FileInfo file in files)
            {
                file.CopyTo(Path.Combine(destination.FullName,
                    file.Name));
            }

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
    protected void grvAlbum_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvAlbum.EditIndex = -1;
        BindAlbum();
    }
    public int DeleteGallery(int id)
    {
        int del = 0;
        try
        {
            DataSet ds = gallery.ViewGalleryByAlbumID(id);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int GalleryID = Convert.ToInt16(ds.Tables[0].Rows[i]["GalleryId"]);
                    gallery.DeleteGalleryByID(GalleryID);

                }
                del = 1;
            }
        }
        catch (Exception ex)
        {
            del = -1;
        }
        return del;
    }
    
    public string bindDate(DateTime dt)
    {

        return dt.ToShortDateString();
    }
    

}