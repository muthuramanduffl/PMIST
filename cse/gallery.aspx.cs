using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class department_of_architecture_new_gallery : System.Web.UI.Page
{
    pmuAlbum album = new pmuAlbum();
    pmuGallery gallery = new pmuGallery();
    pmuvideo video = new pmuvideo();
    int AlbumCount;
    int VideoCount;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindAlbum();
            BindMoreAlbum();
            BindVideo();
        }
    }
    public void BindAlbum()
    {
        DataSet ds = new DataSet();
        ds = album.ViewTop3AlbumByDepartment("Department of Computer Science and Engineering");
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            dvGallery1.Attributes.Add("style", "display:block");
            dvGallery.Attributes.Add("style", "display:none");
            rprTopAlbums.Visible = true;
            rprTopAlbums.DataSource = ds.Tables[0];
            rprTopAlbums.DataBind();
        }
        else
        {
            dvGallery1.Attributes.Add("style", "display:none");
            dvGallery.Attributes.Add("style", "display:block");
            rprTopAlbums.Visible = false;
        }

    }
    public void BindVideo()
    {
        DataSet ds = new DataSet();
        ds = video.ViewActiveVideoByDepartment("Department of Computer Science and Engineering");
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            VideoCount = ds.Tables[0].Rows.Count;
            rprVideo.DataSource = ds.Tables[0];
            rprVideo.DataBind();
        }

    }
    public void BindMoreAlbum()
    {
        DataSet ds = new DataSet();
        ds = album.ViewMoreAlbumByDepartment("Department of Computer Science and Engineering");
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            AlbumCount = ds.Tables[0].Rows.Count;
            rprMoreAlbums.DataSource = ds.Tables[0];
            rprMoreAlbums.DataBind();
        }

    }
    protected void OnItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            string AlbumId = (e.Item.FindControl("hdnAlbumId") as HiddenField).Value;
            Repeater rprTopGallery = e.Item.FindControl("rprTopGallery") as Repeater;
            rprTopGallery.DataSource = gallery.ViewTopGalleryByAlbum(Convert.ToInt32(AlbumId));
            rprTopGallery.DataBind();
        }
    }
    protected void OnItemDataBound1(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            string AlbumId = (e.Item.FindControl("hdnMoreAlbumId") as HiddenField).Value;
            Repeater rprTopGallery = e.Item.FindControl("rprMoreGallery") as Repeater;
            rprTopGallery.DataSource = gallery.ViewTopGalleryByAlbum(Convert.ToInt32(AlbumId));
            rprTopGallery.DataBind();
        }
    }
    public string bindCSS(int index)
    {
        if (index == 0)
            return "";
        else
            return "d-none";
    }
    public string bindImageUrl(string ImgUrl, string stAlbumName,string stDepartment)
    {
        string Url = string.Empty;
        string filePath = System.Configuration.ConfigurationManager.AppSettings["Gallery"];
        string departAlbum = GetDepartmentAlbum(stDepartment);
        if (!string.IsNullOrEmpty(ImgUrl))
        {
            Url = filePath +"/"+ departAlbum + "/" + stAlbumName + "/" + ImgUrl.Trim();
        }
        return Url;
    }
    public string bindVideoImageUrl(string ImgUrl)
    {
        string Url = string.Empty;
        string filePath = System.Configuration.ConfigurationManager.AppSettings["VideoImages"];
        if (!string.IsNullOrEmpty(ImgUrl))
        {
            Url = filePath + "/" + ImgUrl.Trim();
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
        return stAlbum;

    }
    public string bindopndiv(int index)
    {
        if (index == 0)
            return "<div class='row mx-0'>";
        else if ((index) % 4 == 0)
            return "<div class='row mx-0'>";
        else
            return "";
    }
    public string bindopndiv1(int index)
    {
        if (index == 0)
            return "<div class='listData'>";
        else if ((index) % 4 == 0)
            return "<div class='listData'>";
        else
            return "";
    }
    public string bindclosediv(int index)
    {
        if ((index + 1) % 4 == 0)
            return "</div>";
        else if (AlbumCount == (index + 1))
            return "</div>";
        else
            return "";
    }
    public string bindclosediv1(int index)
    {
        if ((index + 1) % 4 == 0)
            return "</div>";
        else if (AlbumCount == (index + 1))
            return "</div>";
        else
            return "";
    }
    public string bindvideopndiv1(int index)
    {
        if (index == 0)
            return "<div class='listData1'>";
        else if ((index) % 3 == 0)
            return "<div class='listData1'>";
        else
            return "";
    }
    public string bindvideoopndiv(int index)
    {
        if (index == 0)
            return "<div class='pt-3 row'>";
        else if ((index) % 3 == 0)
            return "<div class='pt-3 row'>";
        else
            return "";
    }
    public string bindvideoclosediv1(int index)
    {
        if ((index + 1) % 3 == 0)
            return "</div>";
        else if (VideoCount == (index + 1))
            return "</div>";
        else
            return "";
    }
    public string bindvideoclosediv(int index)
    {
        if ((index + 1) % 3 == 0)
            return "</div>";
        else if (VideoCount == (index + 1))
            return "</div>";
        else
            return "";
    }
}