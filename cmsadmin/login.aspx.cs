using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;

public partial class account_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public DataSet GetLoginExecuteDataSet(string UserName, string Password)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMU"].ConnectionString; //"Data Source=50.97.96.71;Initial Catalog=pratipriiti_com_ocp;User Id=dbusrocp;Password=ocpdbusr";
        cnn = new SqlConnection(connetionString);
        DataSet dsDetail = new DataSet();
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SpCMSAdminLogin", cnn))
            {

                // Add new SqlParameter to the command.

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@UserName", UserName));
                command.Parameters.Add(
            new SqlParameter("@Password", Password));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dsDetail);


            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return dsDetail;
    }

    public DataSet GetLoginDetails(string username, string pwd)
    {
        DataSet dsLogin = GetLoginExecuteDataSet(username, pwd);
        return dsLogin;
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

       string FailureText = "";

        if (string.IsNullOrEmpty(txtUsername.Text.Trim()) && string.IsNullOrEmpty(txtPassword.Text.Trim()))
        {
            FailureText = "Please Enter all fields";
            lblDisplay.Text = "Please Enter all fields";
        }
        else if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
        {
            FailureText = "Please Enter Username";
            lblDisplay.Text = "Please Enter Username";
        }
        else if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
        {
            FailureText = "Please Enter Password";
            lblDisplay.Text = "Please Enter Password";
        }
        if (string.IsNullOrEmpty(FailureText))
        {
            //login.UserName = txtUserName.Text.Trim();
            //login.Password = txtPassword.Text.Trim();
            DataSet ds = GetLoginDetails(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                
                string username= Convert.ToString(ds.Tables[0].Rows[0]["UserName"]);

                string password = Convert.ToString(ds.Tables[0].Rows[0]["Password"]);
                string AdminID = Convert.ToString(ds.Tables[0].Rows[0]["Sno"]);
                
                StringComparer ordCmp = StringComparer.Ordinal;
                if (string.Equals(password, txtPassword.Text.Trim(), StringComparison.Ordinal) && string.Equals(username, txtUsername.Text.Trim(), StringComparison.Ordinal))
                {
                    CreateCookies(txtUsername.Text.Trim(), AdminID);
                    FormsAuthentication.SetAuthCookie(txtUsername.Text.Trim(), true);
                    Response.Redirect("/cmsadmin/account/dashboard/default.aspx", true);
                    lblDisplay.Text = "";
                }
                else
                {

                    FailureText = "Invalid Username and Password";
                    lblDisplay.Text = "Invalid Username and Password";
                   // Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Invalid Username and Password');</script>");
                }
            }
            else
            {
                //divmsgError.Visible = true;
                FailureText = "Invalid Username and Password";
                lblDisplay.Text = "Invalid Username and Password";

                //Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + FailureText + "');</script>");
            }


        }

    }
    public void CreateCookies(string strUsername, string AdminID)
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        txtUsername.Text = "";
        txtPassword.Text = "";
    }
}