using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Admin_UserControls_UCLogin : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string strUsername = string.Empty;
        strUsername = GetLoginUserName();

        if (!string.IsNullOrEmpty(strUsername))
        {
            //if (!IsPostBack)
            //{

                lblLoginUserName.Text = "Welcome " + strUsername.Trim() + " |";
            //}
        }
        else
        {
            //Response.Redirect("Login.aspx", true);

        }
    }
    
    public string GetLoginUserName()
    {
        string strUsername = string.Empty;
        try
        {

            
            if (Session["UserName"] != null)
            {
                strUsername = Convert.ToString(Session["UserName"]);

            }
            else
            {
                if (Request.Cookies["LOGIN"] != null)
                {
                    HttpCookie Logincookie = Request.Cookies["LOGIN"];
                    strUsername = Logincookie["UserName"];
                }
            }
        }
        catch
        {
        }
        return strUsername;
    }
    
}