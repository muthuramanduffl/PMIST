<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="account_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="UTF-8" />
    <meta name="viewport" content="initial-scale=1.0,maximum-scale=1.0,user-scalable=no" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <!-- Remove Tap Highlight on Windows Phone IE -->
    <meta name="msapplication-tap-highlight" content="no" />

    <link rel="icon" type="image/png" href="assets/img/favicon-16x16.png" sizes="16x16" />
    <link rel="icon" type="image/png" href="assets/img/favicon-32x32.png" sizes="32x32" />

    <title>PMU CMS - Login Page</title>

    <link href='http://fonts.googleapis.com/css?family=Roboto:300,400,500' rel='stylesheet' type='text/css' />

    <!-- uikit -->
    <link rel="stylesheet" href="/cmsadmin/css/admin/uikit.almost-flat.min.css" />
    <!-- altair admin login page -->
    <link rel="stylesheet" href="/cmsadmin/css/admin/login_page.min.css" />

    <link rel="stylesheet" href="/cmsadmin/css/admin/checkbox.css" />
    <link rel="stylesheet" href="/cmsadmin/css/admin/util.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css" />

</head>
<body class="login_page">
    <form id="form1" runat="server">
        <div class="login_page_wrapper">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <div class="md-card" id="login_card">
                        <div class="md-card-content large-padding" id="login_form">
                            <div class="login_heading">
                                <img src="/images/Logo.png" alt="IF" width="165px" />
                            </div>
                            <div>
                                <asp:Label ID="lblDisplay" runat="server" ForeColor="Red"></asp:Label>
                                <br />
                                <br />
                             <%--   <asp:ValidationSummary ID="ValidationSummary1"
                                    HeaderText="You must enter a value in the following fields:" ValidationGroup="val"
                                    DisplayMode="BulletList"
                                    EnableClientScript="true"
                                    ShowMessageBox="true"
                                    ShowSummary="false"
                                    runat="server" />--%>
                                <div class="uk-form-row">
                                    <div class="md-input-wrapper md-input-focus" id="dvUsername" runat="server" style="padding-top: 9px">

                                        <label for="login_username">Username * </label>
                                        <asp:TextBox ID="txtUsername" runat="server" CssClass="md-input" AutoCompleteType="None" autocomplete="off"></asp:TextBox>
<%--                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter your UserName" ValidationGroup="val" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                                <div class="uk-form-row">
                                    <div class="md-input-wrapper md-input-focus" id="dvPassword" runat="server" style="padding-top: 9px">

                                        <label for="login_password">Password * </label>
                                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="md-input" AutoCompleteType="None" autocomplete="off"></asp:TextBox>
<%--                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter your Password" ValidationGroup="val" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                                <div class="uk-margin-medium-top">
                                    <span style="position: absolute">
                                        <asp:UpdateProgress ID="UpdateProgress1" runat="server" DynamicLayout="true">
                                            <ProgressTemplate>
                                                <img src="/cmsadmin/images/admin/ajax-loader.gif" alt="loading-image" style="width: 35px" />
                                            </ProgressTemplate>
                                        </asp:UpdateProgress>
                                    </span>
                                    <asp:Button ID="btnLogin" runat="server" CssClass="md-btn md-btn-primary md-btn-block" Text="Login" ValidationGroup="val" OnClick="btnLogin_Click" />
                                </div>
                                <div class="uk-margin-top">
                                    <%--<a href="forgot-password.aspx" id="login_help_show1" class="uk-float-right">Forgot password?</a>--%>
                                    <%--  <span class="icheck-inline">
                                        <asp:CheckBox ID="cheStayLoggedIn" runat="server" Text="Stay signed in" CssClass="css-label-checkbox" />
                                    </span>--%>
                                </div>
                            </div>
                        </div>

                    </div>
                    <%-- <div class="uk-margin-top uk-text-center">
                <a href="CreateAccount.aspx" id="signup_form_showf">Create an account</a>
            </div>--%>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>


    <!-- common functions -->
    <script src="/cmsadmin/js/admin/common.min.js"></script>
    <!-- core functions -->
    <script src="/cmsadmin/js/admin/altair_admin_common.min.js"></script>
    <!-- login page functions -->
    <script src="/cmsadmin/js/admin/login.min.js"></script>
</body>
</html>
