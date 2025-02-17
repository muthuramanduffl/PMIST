using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    pmistcmslogin CMSL=new pmistcmslogin();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        string labelerror = string.Empty;

        if (string.IsNullOrEmpty(txtusername.Text) && string.IsNullOrEmpty(txtpassword.Text))
        {
            labelerror = "Fill all the field";
        }
        else if (string.IsNullOrEmpty(txtusername.Text))
        {
            labelerror = "Enter name";
        }
        else if (string.IsNullOrEmpty(txtpassword.Text))
        {
            labelerror = "Enter password";
        }
        if (string.IsNullOrEmpty(labelerror))
        {
            try
            {
                CMSL.strusername = txtusername.Text.Trim();
                CMSL.strpassword = Encrypt(txtpassword.Text.Trim());
                DataTable dt = CMSL.CheckLogin(CMSL);
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(dt.Rows[0]["Status"]) == true)
                    {
                        string username = Convert.ToString(dt.Rows[0]["UserName"]);
                        string password = decrypt(Convert.ToString(dt.Rows[0]["Password"]));
                        int LoginID = Convert.ToInt32(dt.Rows[0]["LID"]);
                        string strEmailid = Convert.ToString(dt.Rows[0]["EmailID"]);
                        string strname = Convert.ToString(dt.Rows[0]["Username"]);
                        string strRole = Convert.ToString(dt.Rows[0]["Role"]);
                        StringComparer ordCmp = StringComparer.Ordinal;
                        if (string.Equals(password, txtpassword.Text.Trim(), StringComparison.Ordinal) && string.Equals(username.ToLower(), txtusername.Text.Trim().ToLower(), StringComparison.Ordinal))
                        {
                            CreateCookies(strname, LoginID, strEmailid, strRole);
                            FormsAuthentication.SetAuthCookie(txtusername.Text.Trim(), true);
                            Response.Redirect("add-faqs.aspx", false);
                            HttpContext.Current.ApplicationInstance.CompleteRequest();
                        }
                        else
                        {
                            txtusername.Text = "";
                            labelerror = "Check the username, password combination.";
                            ShowInvalidLoginAlert(labelerror);
                        }
                    }
                    else
                    {
                        labelerror = "Login credentials are not active. Please contact your administrator.";
                        ShowInvalidLoginAlert(labelerror);
                    }
                }
                else
                {
                    txtusername.Text = "";
                    labelerror = "Check the username, password combination.";
                    ShowInvalidLoginAlert(labelerror);
                }
            }
            catch (Exception ex)
            {
                //CI.StoreExceptionMessage("index.aspx", "AddData", ex.Message, "Not Fixed");
            }
        }
        else
        {
            ShowInvalidLoginAlert(labelerror);
        }
    }




    public string Encrypt(string encrypt)
    {
        string finalencrypt = string.Empty;
        byte[] encode = new byte[encrypt.Length];
        encode = Encoding.UTF8.GetBytes(encrypt);
        finalencrypt = Convert.ToBase64String(encode);
        return finalencrypt;
    }
    public string decrypt(string encryptpswd)
    {
        string strDecrypt = string.Empty;
        UTF8Encoding Encode = new UTF8Encoding();
        Decoder Decod = Encode.GetDecoder();
        byte[] todecode = Convert.FromBase64String(encryptpswd);
        int charcount = Decod.GetCharCount(todecode, 0, todecode.Length);
        char[] chardecode = new char[charcount];
        Decod.GetChars(todecode, 0, todecode.Length, chardecode, 0);

        strDecrypt = new string(chardecode);
        return strDecrypt;
    }

    private void ShowInvalidLoginAlert(string LABELERROR)
    {
        string script = @"
           <script src='https://cdn.jsdelivr.net/npm/sweetalert2@11'></script>
             <script>
                 Swal.fire({
                 title: 'Invalid Details',
                 text: '" + LABELERROR + @"', 
                 confirmButtonText: 'OK',
                 customClass: {
                 popup: 'swal-popup',
                 title: 'swal-title',
                 content: 'swal-content',
                 confirmButton: 'handle-btn-success'  
                 }
                 }).then(function() {  
                 });

                 </script>";
        string css = @"
                 <style>
                 .swal-content { color: yellow !important; }   
                 .swal-title { font-size: 22px !important; }    
                 </style>";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlertCSS", css);
        Page.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", script);
    }
    public void CreateCookies(string strUsername, int LoginID, string strEmailID, string Role)
    {
        if (Request.Browser.Cookies)
        {
            HttpCookie EmailidCookie = Request.Cookies["EmailID"];
            HttpCookie LoginIDCookie = Request.Cookies["LoginID"];
            HttpCookie UsernameCookie = Request.Cookies["Username"];
            HttpCookie UsernameRole = Request.Cookies["Role"];

           
            if (EmailidCookie == null)
            {
                EmailidCookie = new HttpCookie("EmailID");
            }
            if (LoginIDCookie == null)
            {
                LoginIDCookie = new HttpCookie("clientid");
            }

            if (UsernameCookie == null)
            {
                UsernameCookie = new HttpCookie("Username");
            }

            if (UsernameRole == null)
            {
                UsernameRole = new HttpCookie("Role");
            }

           
            LoginIDCookie["clientid"] = Convert.ToString(LoginID);
            EmailidCookie["EmailID"] = Convert.ToString(strEmailID);
            UsernameCookie["Username"] = Convert.ToString(strUsername);
            UsernameRole["Role"] = Convert.ToString(Role);

          
            Response.Cookies.Add(EmailidCookie);
            Response.Cookies.Add(LoginIDCookie);
            Response.Cookies.Add(UsernameCookie);
            Response.Cookies.Add(UsernameRole);
        }

        Session["CLIENTDASHBOARDLOGIN"] = strUsername.Trim();
        Session["LoginID"] = LoginID;
    }
}