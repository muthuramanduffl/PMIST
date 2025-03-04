using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class department_of_architecture_new_events : System.Web.UI.Page
{
    pmuevents pmuevent = new pmuevents();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindEvents();

    }
    public void BindEvents()
    {
        DataSet dsEvents = pmuevent.ViewEventsByDepartment("Department of Computer Science and Engineering");
        if (dsEvents.Tables.Count > 0 && dsEvents.Tables[0].Rows.Count > 0)
        {
            dvEvents1.Attributes.Add("style", "display:block");
            dvEvents.Attributes.Add("style", "display:none");
            rprEvents.Visible = true;
            rprEvents.DataSource = dsEvents.Tables[0];
            rprEvents.DataBind();
        }
        else
        {
            dvEvents1.Attributes.Add("style", "display:none");
            dvEvents.Attributes.Add("style", "display:block");
            rprEvents.Visible = false;
        }
    }
    public string bindEventMonthYear(DateTime dtEvenStartDate)
    {
        string stMonthYear = string.Empty;
        string Month = dtEvenStartDate.ToString("MMM");
        string Year = dtEvenStartDate.ToString("yy");
        stMonthYear = Month + " - " + Year;
        return stMonthYear;
    }
    public string bindMore(int EventId, string stTitle)
    {
        string stUrl = string.Empty;
        stUrl = "<a  href='/" + bindUrl(EventId, stTitle) + "'><span class='position-relative moreLinkAfter blackColor textdecorationNone'>More</span></a>";
        //stUrl = "More";
        return stUrl;
    }
    public string bindEventDate(DateTime dtEvenStartDate, DateTime dtEvenEndDate)
    {
        string stFromAndToDate = string.Empty;
        string fromDate = dtEvenStartDate.ToString("dd");
        string toDate = dtEvenEndDate.ToString("dd");
        stFromAndToDate = fromDate + " - " + toDate;
        return stFromAndToDate;
    }
    public string bindUrl(int Id, string title)
    {
        string url = string.Empty;
        string stTitle = string.Empty;
        if (title.Contains("&"))
            title = title.Replace("&", "-");
        if (title.Contains("'"))
            title = title.Replace("'", "");
        if (title.Contains(":"))
            title = title.Replace(":", "");
        if (title.Contains("#"))
            title = title.Replace("#", "");

        if (title.Contains(" "))
            url = "cse/" + Id + "/" + title.Trim().ToLower().Replace(" ", "-") + ".aspx";
        else
            url = "cse/" + Id + "/" + title.Trim().ToLower() + ".aspx";
        return url;
    }

}