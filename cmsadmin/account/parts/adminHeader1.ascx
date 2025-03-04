<%@ Control Language="C#" ClassName="COLAdminHeader" %>

<%--<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["UserName"] == null)
        {
            Response.Redirect("login.aspx");


        }
        else
        {
            lblName.Text = "Welcome " + Session["UserName"].ToString();
        }
    }


    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session["UserName"] = "";
        Session.Abandon();

        Response.Redirect("Login.aspx");
    }
</script>--%>
<link rel="stylesheet" type="text/css" href="/admin/styles/ddcolortabs.css">
<script language="JavaScript" type="text/javascript" src="/admin/js/home_menu.js"></script>
<div id="menu"></div>

<div class="datesheet">
<asp:Label ID="lblName" runat="server"></asp:Label>
	| <%--<asp:LinkButton id="lnklogout" runat="server" Text="Logout" OnClick="lnklogout_Click"></asp:LinkButton>--%>
	</div>


