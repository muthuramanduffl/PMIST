using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

public partial class admin_account_User_ChangePassword : System.Web.UI.Page
{
    pmuLogin login = new pmuLogin();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        lblDisplayText.Text = "Dashboard - Settings - <b>Reset Password</b>";
        if (Request.QueryString["reset_id"] != null && Request.QueryString["rp_t"] != null)
        {
            string resetDate = Convert.ToString(Request.QueryString["rp_t"]);
            if (!IsValidDate(resetDate))
            {
                lblError.Text = "Invalid Url";
                dvChangePassword.Visible = false;
                dvPasswordError.Visible = true;

            }
            else
            {
                dvChangePassword.Visible = true;
                dvPasswordError.Visible = false;
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            string stErrorText = string.Empty;

            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()) && string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                stErrorText = "Please Enter all the Fields";
            }

            else if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                stErrorText = "Please Enter New Password";
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                stErrorText = "Please Enter Confirm Password";
            }

            if (!string.Equals(txtNewPassword.Text.Trim().ToUpper(), txtConfirmPassword.Text.Trim().ToUpper()))
            {
                stErrorText = "New Password and confirm password does not match";
            }
            if (string.IsNullOrEmpty(stErrorText))
            {
                if (Request.QueryString["ID"] != null)
                {
                    int AdminID = Convert.ToInt16(Request.QueryString["ID"]);
                    UpdatePassword(AdminID, txtNewPassword.Text.Trim());
                }                
                else
                {
                    int AdminID = Convert.ToInt16(GetUserID());
                    UpdatePassword(AdminID, txtNewPassword.Text.Trim());
                }


            }
            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
        }
        catch (Exception ex)
        {
        }
    }
   
    public void CreateCookies(string strUsername, string IsSuperAdmin, string AdminID, string SchoolId)
    {
        if (Request.Browser.Cookies)
        {
            HttpCookie LoginCookie = Request.Cookies["LOGIN"];
            if (LoginCookie == null)
            {
                LoginCookie = new HttpCookie("LOGIN");
            }
            LoginCookie["UserName"] = strUsername.Trim();            
            LoginCookie["AdminId"] = AdminID.Trim();
           
            Response.Cookies.Add(LoginCookie);

        }
        Session["UserName"] = strUsername.Trim();        
        Session["AdminId"] = AdminID.Trim();
        
    }
    public bool IsValidDate(string stDate)
    {
        bool Valid =false;
        string year = stDate.Trim().Substring(0, 4);
        string month = stDate.Trim().Substring(4, 2);
        string day = stDate.Trim().Substring(6, 2);
        string stCurrentDate = DateTime.Now.ToString("yyyyMMdd");
        string stCurrentyear = stCurrentDate.Trim().Substring(0, 4);
        string stCurrentmonth = stCurrentDate.Trim().Substring(4, 2);
        string stCurrentday = stCurrentDate.Trim().Substring(6, 2);
        if (year == stCurrentyear && month == stCurrentmonth && day == stCurrentday)
            Valid = true;
        else
            Valid = false;
        return Valid;
    }
    public string GetUserID()
    {
        string strUserID = string.Empty;
        try
        {


            if (HttpContext.Current.Session["AdminId"] != null)
            {
                strUserID = Convert.ToString(HttpContext.Current.Session["AdminId"]);

            }
            else
            {
                if (HttpContext.Current.Request.Cookies["LOGIN"] != null)
                {
                    HttpCookie Logincookie = HttpContext.Current.Request.Cookies["LOGIN"];
                    strUserID = Logincookie["AdminId"];
                }
            }
        }
        catch
        {
        }
        return strUserID;
    }
    public void UpdatePassword(int AdminID, string password)
    {
        try
        {

            int UpdateLogin = login.ChangePassword(AdminID, password);
            if (UpdateLogin == -1)
            {

                lblSucess.Text = "Password Changed Successfully";
            }
        }
        catch (Exception ex)
        {
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtNewPassword.Text = "";
        txtConfirmPassword.Text = "";
    }
   
}