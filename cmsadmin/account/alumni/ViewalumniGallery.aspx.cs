using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class admin_account_alumni_ViewGallery : System.Web.UI.Page
{
    pmuAlbum album = new pmuAlbum();
    pmuGallery gallery = new pmuGallery();
    readonly PagedDataSource _pgsource = new PagedDataSource();
    private int _pageSize = 15;
   // bvmLogin login = new bvmLogin();
    private int CurrentPage
    {
        get
        {
            if (ViewState["CurrentPage"] == null)
            {
                return 0;
            }
            return ((int)ViewState["CurrentPage"]);
        }
        set
        {
            ViewState["CurrentPage"] = value;
        }
    }
    protected void btnLiveView_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://pmu.edu/alumni/gallery.aspx", true);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       
        lblDisplayText.Text = "Dashboard - Alumni - <b>View Gallery </b>";
        if (!IsPostBack)
        {
            
            BindGalleryByAlbum(0);
            BindAlbum("Alumni");
            
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
            string stdepartment = Convert.ToString(args[3]);
            if (!string.IsNullOrEmpty(stImage))
            {
                stAlbumName = GetAlbumName(AlbumID);
                FileDelete(stImage, stAlbumName.ToLower().Trim());
            }
            gallery.DeleteGalleryByID(ID);
            string stTitle = string.Empty;
            lblText.Text = "";
            int GalleryID = 0;
           if (Request.QueryString["ID"] != null)
               GalleryID = Convert.ToInt16(Request.QueryString["ID"]);
           BindGalleryByAlbum(AlbumID);
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
            int ID = Convert.ToInt32(args[0]);
            int AlbumID = Convert.ToInt32(args[1]);
            gallery.UpdateGallerySatus(ID);
            string stTitle = string.Empty;
            int GalleryID = 0;
             if (Request.QueryString["ID"] != null)
                GalleryID = Convert.ToInt16(Request.QueryString["ID"]);
             BindGalleryByAlbum(AlbumID);
        }
        catch (Exception ex)
        {
        }
    }
    
    public void FileDelete(string ImageName,string AlbumName)
    {

        string filePath = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["Alumniimage"]); 
        filePath +=  "/" + AlbumName.Trim() +"/" + ImageName.Trim();

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

    public string bindImageUrl(string ImgUrl,int AlbumID,string stDepartment)
    {
        string Url = string.Empty;
        string stAlbumName = string.Empty;
        stAlbumName = GetAlbumName(AlbumID);
        string filePath = System.Configuration.ConfigurationManager.AppSettings["Alumniimage"];
        
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

   
   
    protected void btnView_Click(object sender, EventArgs e)
    {
      //  Response.Redirect("ViewFloorPlans.aspx", true);
    }

    public void BindAlbum()
    {
        DataSet ds = album.ViewActiveAlbum();
        string AlbumName = string.Empty;
        int AlbumID = 0;
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            ddlAlbum.Items.Add(new ListItem("All", "0"));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                AlbumID = Convert.ToInt32(ds.Tables[0].Rows[i]["AlbumID"]);
                AlbumName = Convert.ToString(ds.Tables[0].Rows[i]["AlbumName"]);
                ddlAlbum.Items.Add(new ListItem(AlbumName.Trim(),AlbumID.ToString()));
            }
            ddlAlbum.DataBind();
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
    public void BindAlbum(string stDepartment)
    {
        ddlAlbum.Items.Clear();
        if (!string.IsNullOrEmpty(stDepartment))
        {
            if (!string.Equals(stDepartment, "All"))
            {
                DataSet ds = gallery.ViewActiveAlbumByDepartment(stDepartment);
                string AlbumName = string.Empty;
                int AlbumID = 0;
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    ddlAlbum.Items.Add(new ListItem("All", "0"));
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
                ddlAlbum.Items.Add(new ListItem("All", "0"));
            }
        }
        else
        {
            ddlAlbum.Items.Add(new ListItem("All", "0"));
        }
    }
    public void BindGalleryByAlbum(int AlbumID)
    {
        DataSet ds = new DataSet();
        string stName = string.Empty;

        if (AlbumID == 0)
        {
            ds = gallery.ViewAllGalleryByDepartmentIQAC("Alumni");
        }

        else
        {
            stName = ddlAlbum.SelectedItem.Text.Trim();
            ds = gallery.ViewGalleryByAlbumID(AlbumID);
        }
        int TotalNoOfPages = 0;
       
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            TotalNoOfPages = Convert.ToInt32(ds.Tables[0].Rows.Count) / _pageSize;
            if(string.IsNullOrEmpty(stName))
               lblTotolImages.Text = "<b>Total No Of Images: </b>" + ds.Tables[0].Rows.Count.ToString();
            else
                lblTotolImages.Text = "<b>Album Name: " + ddlAlbum.SelectedItem.Text.Trim() + " | Total No Of Images: </b>" + ds.Tables[0].Rows.Count.ToString();
            if (ds.Tables[0].Rows.Count > _pageSize)
            {
                lbPrevious.Visible = true;
                lbNext.Visible = true;
                if (TotalNoOfPages == CurrentPage)
                {
                    lbNext.Enabled = false;
                    lbNext.CssClass = "disablelink";
                }
                else
                {
                    lbNext.Enabled = true;
                    lbNext.CssClass = "next_link";
                }
                if (CurrentPage == 0)
                {
                    lbPrevious.Enabled = false;
                    lbPrevious.CssClass = "disablelink";
                }
                else
                {
                    lbPrevious.Enabled = true;
                    lbPrevious.CssClass = "previous_link";
                }
            }
            else
            {
                lbPrevious.Visible = false;
                lbNext.Visible = false;
            }
            var dt = ds.Tables[0];
            _pgsource.DataSource = dt.DefaultView;
            _pgsource.AllowPaging = true;
            // Number of items to be displayed in the Repeater
            _pgsource.PageSize = _pageSize;
            _pgsource.CurrentPageIndex = CurrentPage;
            // Keep the Total pages in View State
            ViewState["TotalPages"] = _pgsource.PageCount;
            // Example: "Page 1 of 10"

            // Enable First, Last, Previous, Next buttons
            lbPrevious.Enabled = !_pgsource.IsFirstPage;
            lbNext.Enabled = !_pgsource.IsLastPage;
            lblCheck.Text = "";
            rprGallery.Visible = true;
            // Bind data into repeater
            rprGallery.DataSource = _pgsource;
            rprGallery.DataBind();

        }
        else
        {
            lblTotolImages.Text = "";
            lblCheck.Text = "No Images added";
            lbPrevious.Visible = false;
            lbNext.Visible = false;
            rprGallery.Visible = false;
        }
    }
    protected void lbPrevious_Click(object sender, EventArgs e)
    {
        int AlbumID = Convert.ToInt32(ddlAlbum.SelectedValue.ToString());
        CurrentPage -= 1;
        BindGalleryByAlbum(AlbumID);
    }
    protected void lbNext_Click(object sender, EventArgs e)
    {
        int AlbumID = Convert.ToInt32(ddlAlbum.SelectedValue.ToString());
        CurrentPage += 1;
        
        BindGalleryByAlbum(AlbumID);
    }

   
    //public void BindGalleryByAlbum(int AlbumID)
    //{
    //    DataSet dsGallery = gallery.ViewGalleryByAlbumID("bl01", AlbumID);
    //    if (dsGallery.Tables.Count > 0 && dsGallery.Tables[0].Rows.Count > 0)
    //    {
    //        lblText.Text = " ";
    //        rprGallery.Visible = true;
    //        rprGallery.DataSource = dsGallery.Tables[0].DefaultView;
    //        rprGallery.DataBind();

    //    }
    //    else
    //    {
    //        rprGallery.Visible = false;
    //        lblText.Text = "No Images Added";
    //    }
    //}
    protected void ddlAlbum_SelectedIndexChanged1(object sender, EventArgs e)
    {
        int AlbumID = Convert.ToInt32(ddlAlbum.SelectedValue.ToString());
        BindGalleryByAlbum(AlbumID);
    }
}
