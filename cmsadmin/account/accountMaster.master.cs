using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Text;

public partial class account_accountMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string url = HttpContext.Current.Request.Url.AbsoluteUri.ToString();


        if (Session["UserName"] == null)
        {
            if (Request.Cookies["LOGIN"] != null)
            {
                HttpCookie Logincookie = Request.Cookies["LOGIN"];
                string strUsername = Logincookie["UserName"];
                Session["UserName"] = strUsername.Trim();
            }

        }
        if (Session["UserName"] == null && Request.Cookies["LOGIN"] == null)
        {
            if (url.Contains("ChangePassword.aspx"))
                lklogout.Visible = false;
            if (!url.Contains("ChangePassword.aspx"))
            {
                Response.Redirect("/cmsadmin/login.aspx");
            }
        }




    }
    protected void lnkSignOut_Click(object sender, EventArgs e)
    {
        Session["UserName"] = null;
        Session["AdminId"] = null;
        Session.Abandon();
        FormsAuthentication.SignOut();
        if (Request.Cookies["LOGIN"] != null)
        {
            var c = new HttpCookie("LOGIN");
            c.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(c);

        }
        Response.Redirect("/cmsadmin/Login.aspx", true);

    }

    public string GetCss(string stUrl)
    {
        string Url = HttpContext.Current.Request.Url.AbsolutePath.Trim();
        string filename = System.IO.Path.GetFileName(Url);

        if (string.Equals(stUrl.Trim(), "gallery") && Url.Contains("gallery") && string.Equals(filename.ToLower().Trim(), "addalbum.aspx"))
        {
            ulGallery.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }

        else if (string.Equals(stUrl.Trim(), "department") && Url.Contains("department") && string.Equals(filename.ToLower().Trim(), "AddDepartment.aspx"))
        {
            uldepartment.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "department") && Url.Contains("department") && string.Equals(filename.ToLower().Trim(), "viewDepartment.aspx"))
        {
            uldepartment.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "about") && Url.Contains("about") && string.Equals(filename.ToLower().Trim(), "Add-Departmentcourses.aspx"))
        {
            ulcourses.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "about") && Url.Contains("about") && string.Equals(filename.ToLower().Trim(), "add-about.aspx"))
        {
            uldepartmentAbout.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "about") && Url.Contains("about") && string.Equals(filename.ToLower().Trim(), "viewabout.aspx"))
        {
            uldepartmentAbout.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "courses") && Url.Contains("courses") && string.Equals(filename.ToLower().Trim(), "viewDepartmentcourses.aspx"))
        {
            ulcourses.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }


        else if (string.Equals(stUrl.Trim(), "gallery") && Url.Contains("gallery") && string.Equals(filename.ToLower().Trim(), "addgallery.aspx"))
        {
            ulGallery.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "gallery") && Url.Contains("gallery") && string.Equals(filename.ToLower().Trim(), "viewgallery.aspx"))
        {
            ulGallery.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        if (string.Equals(stUrl.Trim(), "achivement-corner") && Url.Contains("achivement-corner") && string.Equals(filename.ToLower().Trim(), "addachievementcorner.aspx"))
        {
            ulAchievement.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "achivement-corner") && Url.Contains("achivement-corner") && string.Equals(filename.ToLower().Trim(), "viewachievementcorner.aspx"))
        {
            ulAchievement.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }


        if (string.Equals(stUrl.Trim(), "events") && string.Equals(filename.ToLower().Trim(), "addevents.aspx"))
        {
            ulEvents.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "events") && string.Equals(filename.ToLower().Trim(), "viewevents.aspx"))
        {
            ulEvents.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        if (string.Equals(stUrl.Trim(), "video") && string.Equals(filename.ToLower().Trim(), "addvideo.aspx"))
        {
            ulVideo.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "video") && string.Equals(filename.ToLower().Trim(), "viewvideo.aspx"))
        {
            ulVideo.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        if (string.Equals(stUrl.Trim(), "news") && string.Equals(filename.ToLower().Trim(), "addnewsslider.aspx"))
        {
            ulNews.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "news") && string.Equals(filename.ToLower().Trim(), "viewnewsslider.aspx"))
        {
            ulNews.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        if (string.Equals(stUrl.Trim(), "slider") && string.Equals(filename.ToLower().Trim(), "addslider.aspx"))
        {
            ulSlider.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "slider") && string.Equals(filename.ToLower().Trim(), "viewslider.aspx"))
        {
            ulSlider.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        if (string.Equals(stUrl.Trim(), "faculty") && string.Equals(filename.ToLower().Trim(), "addfaculty.aspx"))
        {
            ulfaculty.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "faculty") && string.Equals(filename.ToLower().Trim(), "viewfaculty.aspx"))
        {
            ulfaculty.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        if (string.Equals(stUrl.Trim(), "naac") && string.Equals(filename.ToLower().Trim(), "Addnaac.aspx"))
        {
            ulNaac.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "naac") && string.Equals(filename.ToLower().Trim(), "criteria.aspx"))
        {
            ulNaac.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "naac") && string.Equals(filename.ToLower().Trim(), "metric.aspx"))
        {
            ulNaac.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "naac") && string.Equals(filename.ToLower().Trim(), "submetric.aspx"))
        {
            ulNaac.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "naac") && Url.Contains("naac") && string.Equals(filename.ToLower().Trim(), "view.aspx"))
        {
            ulNaac.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }


        if (string.Equals(stUrl.Trim(), "aqar") && string.Equals(filename.ToLower().Trim(), "Addaqar.aspx"))
        {
            ulaqar.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "aqar") && string.Equals(filename.ToLower().Trim(), "criteria.aspx"))
        {
            ulaqar.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "aqar") && string.Equals(filename.ToLower().Trim(), "metric.aspx"))
        {
            ulaqar.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "aqar") && string.Equals(filename.ToLower().Trim(), "submetric.aspx"))
        {
            ulaqar.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "aqar") && Url.Contains("aqar") && string.Equals(filename.ToLower().Trim(), "view.aspx"))
        {
            ulaqar.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }


        if (string.Equals(stUrl.Trim(), "iqac") && string.Equals(filename.ToLower().Trim(), "section.aspx"))
        {
            uliqac.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "iqac") && Url.Contains("iqac") && string.Equals(filename.ToLower().Trim(), "add.aspx"))
        {
            uliqac.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "iqac") && Url.Contains("iqac") && string.Equals(filename.ToLower().Trim(), "view.aspx"))
        {
            uliqac.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "iqac") && Url.Contains("iqac") && string.Equals(filename.ToLower().Trim(), "addalbum.aspx"))
        {
            uliqac.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "iqac") && Url.Contains("iqac") && string.Equals(filename.ToLower().Trim(), "addiqacgallery.aspx"))
        {
            uliqac.Style.Add("display", "block");
            ulGallery.Style.Add("display", "none");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "iqac") && Url.Contains("iqac") && string.Equals(filename.ToLower().Trim(), "viewiqacgallery.aspx"))
        {
            uliqac.Style.Add("display", "block");
            ulGallery.Style.Add("display", "none");
            return "submenu_trigger act_section current_section";
        }
        if (string.Equals(stUrl.Trim(), "recuritment") && Url.Contains("recuritment") && string.Equals(filename.ToLower().Trim(), "view.aspx"))
        {
            ulrecuritment.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        if (string.Equals(stUrl.Trim(), "internships") && Url.Contains("internships") && string.Equals(filename.ToLower().Trim(), "view.aspx"))
        {
            ulinternships.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        if (string.Equals(stUrl.Trim(), "alumni") && Url.Contains("alumni") && string.Equals(filename.ToLower().Trim(), "add.aspx"))
        {
            ulalumni.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "alumni") && Url.Contains("alumni") && string.Equals(filename.ToLower().Trim(), "view.aspx"))
        {
            ulalumni.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "alumni") && Url.Contains("alumni") && string.Equals(filename.ToLower().Trim(), "addalbum.aspx"))
        {
            ulalumni.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "alumni") && Url.Contains("alumni") && string.Equals(filename.ToLower().Trim(), "addalumnigallery.aspx"))
        {
            ulalumni.Style.Add("display", "block");
            ulGallery.Style.Add("display", "none");
            return "submenu_trigger act_section current_section";
        }
        else if (string.Equals(stUrl.Trim(), "alumni") && Url.Contains("alumni") && string.Equals(filename.ToLower().Trim(), "viewalumnigallery.aspx"))
        {
            ulalumni.Style.Add("display", "block");
            ulGallery.Style.Add("display", "none");
            return "submenu_trigger act_section current_section";
        }
        if (string.Equals(stUrl.Trim(), "settings") && string.Equals(filename.ToLower().Trim(), "changepassword.aspx"))
        {
            ulUser.Style.Add("display", "block");
            return "submenu_trigger act_section current_section";
        }
        return "submenu_trigger";
    }

}
