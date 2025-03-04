using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class admin_account_gallery_AddGallery : System.Web.UI.Page
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
        Response.Redirect("/gallery-new/", true);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       
        lblDisplayText.Text = "Dashboard - Gallery - <b>View Gallery </b>";
        if (!IsPostBack)
        {
            BindAlbum();
            BindGalleryByAlbum(0);
            
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
                FileDelete(stImage, stAlbumName.ToLower().Trim(),GetDepartmentAlbum(stdepartment));
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
    
    public void FileDelete(string ImageName,string AlbumName,string stDepart)
    {

        string filePath = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["Gallery"]); 
        filePath += stDepart + "/" + AlbumName.Trim() +"/" + ImageName.Trim();

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
        string filePath = System.Configuration.ConfigurationManager.AppSettings["Gallery"];
        string stdepqart = GetDepartmentAlbum(stDepartment);
        if (!string.IsNullOrEmpty(ImgUrl))
        {
            Url = filePath + "/" + stdepqart + "/" + stAlbumName + "/" + ImgUrl.Trim();
        }
        return Url;
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
        else if (string.Equals(stDepartment, "Department of Architecture"))
            stAlbum = "architecture";
        else if (string.Equals(stDepartment, "Department of Aerospace Engineering"))
            stAlbum = "aerospace";
        else if (string.Equals(stDepartment, "Department of Bio-Technology"))
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
        if (string.Equals(stDepartment, "Centre for Institute Industry Interaction"))
            stAlbum = "ciii";
        if (string.Equals(stDepartment, "Centre for Student and Administrative Services"))
            stAlbum = "csas";  
        if (string.Equals(stDepartment, "Dr.Kalaingar M.Karunanidhi Centre for Political Science"))
            stAlbum = "dkcps";
        if (string.Equals(stDepartment, "Veeramani Mohana Centre for Quality of Life Engineering Research"))
            stAlbum = "vmcqler"; 
         if (string.Equals(stDepartment, "Periyar Pura Centre for Rural Development"))
            stAlbum = "ppcrd";  
        if (string.Equals(stDepartment, "Centre of Excellence of Training and Research in Automation Technology"))
            stAlbum = "cetrat";
        if (string.Equals(stDepartment, "Centre of Excellence for Next Generation Networks"))
            stAlbum = "cengn"; 
        if (string.Equals(stDepartment, "Centre of Excellence for Periyar Thought"))
            stAlbum = "cept";  
        if (string.Equals(stDepartment, "Centre for Energy and Environment"))
            stAlbum = "cee";
        if (string.Equals(stDepartment, "Institution Innovation Council"))
            stAlbum = "iic"; 
        return stAlbum;

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
    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        string department = ddlDepartment.SelectedItem.Text;
        BindAlbum(department);
        BindGalleryByAlbum(0);
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
            if (!string.Equals(ddlDepartment.SelectedItem.Text, "All"))
                ds = gallery.ViewAllGalleryByDepartment(ddlDepartment.SelectedItem.Text.Trim());
            else
            ds = gallery.ViewAllGallery();

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
