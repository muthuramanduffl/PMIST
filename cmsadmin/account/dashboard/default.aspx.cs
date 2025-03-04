using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_account_dashboard_default : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindCount();
    }
    public void BindCount()
    {
        pmuevents events = new pmuevents();
        pmuAlbum album = new pmuAlbum();
        pmuvideo video = new pmuvideo();
        DataSet dsContent = new DataSet();
        dsContent = events.ViewEventsByDate();
        if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
        {
            lblEventsCount.Text = Convert.ToString(dsContent.Tables[0].Rows.Count);
        }
        else
        {
            lblEventsCount.Text = "0";
        }
        DataSet dsAlbum = new DataSet();
        dsAlbum = album.ViewActiveAlbum();
        if (dsAlbum.Tables.Count > 0 && dsAlbum.Tables[0].Rows.Count > 0)
        {
            lblAlbumCount.Text = Convert.ToString(dsAlbum.Tables[0].Rows.Count);
        }
        else
        {
            lblAlbumCount.Text = "0";
        }
        DataSet dsVideo = new DataSet();
        dsVideo = video.ViewActiveVideo();
        if (dsVideo.Tables.Count > 0 && dsVideo.Tables[0].Rows.Count > 0)
        {
            lblVideo.Text = Convert.ToString(dsVideo.Tables[0].Rows.Count);
        }
        else
        {
            lblVideo.Text = "0";
        }
    }
}