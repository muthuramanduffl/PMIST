

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using System.Text.RegularExpressions;


public partial class resourceforresearchers : System.Web.UI.Page
{

    pmistresourceofresources PMROR = new pmistresourceofresources();
    protected void Page_Load(object sender, EventArgs e)
    {


        Bind();
    }


    public void Bind()
    {
        try
        {
            DataTable dt = Get();
            if (dt != null && dt.Rows.Count > 0)
            {
                rprresource.Visible = true;
                rprresource.DataSource = dt;
                rprresource.DataBind();


            }
            else
            {
                rprresource.Visible = false;

            }
        }
        catch (Exception ex)
        {
        }
    }


    public DataTable Get()
    {
        DataTable dt = new DataTable();
        try
        {
            dt = PMROR.ViewAllResearchRFRFilter("1", "1", "");//computer science id 5 only shows
        }
        catch (Exception ex)
        {
        }
        return dt;
    }


    protected void rprresource_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            string urlAndNotes = DataBinder.Eval(e.Item.DataItem, "URL_AND_Notes").ToString();

            string modifiedHtml = urlAndNotes; // Default value

            // Check if the content contains <a> tag
            if (Regex.IsMatch(urlAndNotes, @"<a[^>]*>"))
            {
                // Insert <img> inside <a> while keeping existing attributes
                modifiedHtml = Regex.Replace(urlAndNotes, @"(<a[^>]*>)", "$1<img src=\"../assets/img/icon/link.svg\" alt=\"img\" class=\"img-fluid pe-2\" width=\"26px\">");
            }

            // Find the Literal control and set its text
            Literal litContent = (Literal)e.Item.FindControl("litContent");
            if (litContent != null)
            {
                litContent.Text = modifiedHtml;
            }
        }
    }


}