using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;


public partial class department_of_architecture_new_event_detail : System.Web.UI.Page
{
    pmuevents pmuevent = new pmuevents();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.RouteData.Values["ID"] != null)
        {
            int Id = Convert.ToInt32(Page.RouteData.Values["ID"]);
            BindEventDetail(Id);

        }
    }
    public void BindEventDetail(int EventId)
    {
        DataSet dsEvents = pmuevent.ViewEventsById(EventId);
        if (dsEvents.Tables.Count > 0 && dsEvents.Tables[0].Rows.Count > 0)
        {
            DateTime dtEventStartDate = Convert.ToDateTime(dsEvents.Tables[0].Rows[0]["EventStartDate"]);
            DateTime dtEventEndDate = Convert.ToDateTime(dsEvents.Tables[0].Rows[0]["EventEndDate"]);
            lblEventMonthYear.Text = bindEventMonthYear(dtEventStartDate);
            lblEventDate.Text = bindEventDate(dtEventStartDate, dtEventEndDate);
            lblTitle.Text = Convert.ToString(dsEvents.Tables[0].Rows[0]["Title"]);
            lblDepartment.Text = Convert.ToString(dsEvents.Tables[0].Rows[0]["Department"]);
            string stContent = Convert.ToString(dsEvents.Tables[0].Rows[0]["NewsContent"]);
            StringBuilder sbpdf = new StringBuilder();
            if (!string.IsNullOrEmpty(stContent))
            {
                phContent.Controls.Add(new LiteralControl(stContent.Trim()));
            }
            if (!string.IsNullOrEmpty(Convert.ToString(dsEvents.Tables[0].Rows[0]["NewsImage"])))
            {
                string imgfile = Convert.ToString(dsEvents.Tables[0].Rows[0]["NewsImage"]);
                string CoverImagefilePath = System.Configuration.ConfigurationManager.AppSettings["EventImages"];
                string stpath = CoverImagefilePath + imgfile.Trim();
                phEventImage.Controls.Add(new LiteralControl("<img src='" + stpath + "' class='eventsImage w-100' />"));

            }
            if (!string.IsNullOrEmpty(Convert.ToString(dsEvents.Tables[0].Rows[0]["pdf1"])))
            {
                string stpdf1 = Convert.ToString(dsEvents.Tables[0].Rows[0]["pdf1"]);
                string path = System.Configuration.ConfigurationManager.AppSettings["Eventpdf"];
                string pdf2path = path + stpdf1;
                sbpdf.Append("<div class=''>");
                sbpdf.AppendLine("<a target='_blank' href = '" + pdf2path + "' class='textdecorationNone blackColor f-14'>");
                sbpdf.AppendLine("<div class='d-flex align-items-center'>");
                sbpdf.AppendLine("<div><img src = 'https://pmu.edu/images/file.svg'> </div>");
                sbpdf.AppendLine("<div class='pl-2'>" + stpdf1.Replace(".pdf", "") + "</div>");
                sbpdf.AppendLine("</div></a></div>");
                phPdf.Controls.Add(new LiteralControl(sbpdf.ToString()));
            }
            if (!string.IsNullOrEmpty(Convert.ToString(dsEvents.Tables[0].Rows[0]["pdf2"])))
            {
                string stpdf2 = Convert.ToString(dsEvents.Tables[0].Rows[0]["pdf2"]);
                string path = System.Configuration.ConfigurationManager.AppSettings["Eventpdf"];
                string pdf2path = path + stpdf2;
                sbpdf.Append("<div class='pt-3'>");
                sbpdf.Append("<a target='_blank' href = '#' class='textdecorationNone blackColor f-14 '>");
                sbpdf.Append("<div class='d-flex align-items-center'>");
                sbpdf.Append("<div><img src = 'https://pmu.edu/images/file.svg'> </div>");
                sbpdf.Append("<div class='pl-2'>" + stpdf2.Replace(".pdf", "") + "</div>");
                sbpdf.Append("</div></a></div>");
                phPdf.Controls.Add(new LiteralControl(sbpdf.ToString()));
            }
            if (!string.IsNullOrEmpty(Convert.ToString(dsEvents.Tables[0].Rows[0]["pdf3"])))
            {
                string stpdf3 = Convert.ToString(dsEvents.Tables[0].Rows[0]["pdf3"]);
                string path = System.Configuration.ConfigurationManager.AppSettings["Eventpdf"];
                string pdf2path = path + stpdf3;
                sbpdf.Append("<div class='pt-3'>");
                sbpdf.Append("<a target='_blank' href = '#' class='textdecorationNone blackColor f-14 '>");
                sbpdf.Append("<div class='d-flex align-items-center'>");
                sbpdf.Append("<div><img src = 'https://pmu.edu/images/file.svg' > </div>");
                sbpdf.Append("<div class='pl-2'>" + stpdf3.Replace(".pdf", "") + "</div>");
                sbpdf.Append("</div></a></div>");
                phPdf.Controls.Add(new LiteralControl(sbpdf.ToString()));
            }
            DateTime dtPostedTime = Convert.ToDateTime(dsEvents.Tables[0].Rows[0]["PostedDate"]);
            int PreviousID, NextID;
            string strPrevTitle, strNextTitle;
            string stDepartment = Convert.ToString(dsEvents.Tables[0].Rows[0]["Department"]);
            BindPreviousAndNextLinks(dtPostedTime, out PreviousID, out NextID, out strPrevTitle, out strNextTitle, stDepartment);
        }
    }
    public void BindPreviousAndNextLinks(DateTime dt, out int PreviousID, out int NextID, out string strPrevTitle, out string strNextTitle,string stDepartment)
    {

        pmuevent.GetPreviousAndNextArticlesByDepartment(dt, out PreviousID, out NextID, out strPrevTitle, out strNextTitle, stDepartment);

        if (PreviousID != 0)
        {
            StringBuilder sbPrevious = new StringBuilder();
            sbPrevious.Append("<a class='textdecorationNone blackColor upperCase Oswald OswaldR' href=\"" + bindUrl(PreviousID, strPrevTitle) + "\">Prev</a>");
            phPrevious.Controls.Add(new LiteralControl(sbPrevious.ToString()));
        }
        if (NextID != 0)
        {
            StringBuilder sbNext = new StringBuilder();
            sbNext.Append("<a class='textdecorationNone blackColor upperCase Oswald OswaldR' href=\"" + bindUrl(NextID, strNextTitle) + "\">Next</a>");
            phNext.Controls.Add(new LiteralControl(sbNext.ToString()));
        }

    }
    public string bindUrl(int Id, string title)
    {
        string url = string.Empty;
        string stTitle = string.Empty;
        if (title.Contains("&"))
            title = title.Replace("&", "-");
        if (title.Contains(" "))
            url = "/cse/" + Id + "/" + title.Trim().ToLower().Replace(" ", "-") + ".aspx";
        else
            url = "/cse/" + Id + "/" + title.Trim().ToLower() + ".aspx";
        return url;
    }
    public string bindEventMonthYear(DateTime dtEvenStartDate)
    {
        string stMonthYear = string.Empty;
        string Month = dtEvenStartDate.ToString("MMM");
        string Year = dtEvenStartDate.ToString("yy");
        stMonthYear = Month + " - " + Year;
        return stMonthYear;
    }
    public string bindEventDate(DateTime dtEvenStartDate, DateTime dtEvenEndDate)
    {
        string stFromAndToDate = string.Empty;
        string fromDate = dtEvenStartDate.ToString("dd");
        string toDate = dtEvenEndDate.ToString("dd");
        if (string.Equals(fromDate, toDate))
            stFromAndToDate = fromDate;
        else
            stFromAndToDate = fromDate + " - " + toDate;
        return stFromAndToDate;
    }

}