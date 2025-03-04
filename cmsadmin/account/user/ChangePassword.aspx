<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="admin_account_User_ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Reset Password</h1>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" runat="Server">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="errormsg" ShowSummary="false" ShowMessageBox="true" Display="None" ValidationGroup="val"/>
        <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
            <ContentTemplate>--%>

                <div class="uk-grid">

                    <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
                        <div class="md-card">
                            <div class="md-card-toolbar">
                                <h3 class="md-card-toolbar-heading-text"><asp:Label ID="lblDisplayText" runat="server"></asp:Label>
                                <b style="padding-left:420px"><asp:Label  ID="lblStatus" runat="server"></asp:Label></b>
                                </h3>
                            </div>
                            <div class="md-card-content large-padding" id="dvPasswordError" runat="server">
                            <asp:Label  ID="lblError" runat="server"></asp:Label>
                            </div>

                            <div class="md-card-content large-padding" id="dvChangePassword" runat="server">
                                <div class="uk-grid uk-grid-divider uk-grid-medium">
                                    <div class="uk-width-large-2-3">
                                       
                                         <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper"  style="padding-top:29px">
                                               
                                                   <asp:Label ID="lblSucess" runat="server"></asp:Label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvPassword" runat="server" style="padding-top:29px">
                                               
                                                    <label>New Password *</label>
                                                     <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" CssClass="md-input"></asp:TextBox>
                                                     
                                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter new password" Display="None" ControlToValidate="txtNewPassword"  ValidationGroup="val"></asp:RequiredFieldValidator>
                       <asp:RegularExpressionValidator
id="RegularExpressionValidator2"
runat="server"
ErrorMessage="Password minimum length should be 6 characters" Display="None" ValidationGroup="val"
ControlToValidate="txtNewPassword"
ValidationExpression="^.{6,}$" />
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="Div1" runat="server" style="padding-top:29px">
                                                    <label>Confirm Password *</label>
                                                     <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="md-input"></asp:TextBox>
                                                     
                                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter confirm password" Display="None" ControlToValidate="txtConfirmPassword"  ValidationGroup="val"></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator
id="RegularExpressionValidator1"
runat="server"
ErrorMessage="Password minimum length should be 6 characters" Display="None" ValidationGroup="val"
ControlToValidate="txtConfirmPassword"
ValidationExpression="^.{6,}$" />
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                     <asp:Button ID="btnSave" runat="server" 
                                                    CssClass="md-btn md-btn-small md-btn-flat md-btn-success" Text=" Save " 
                                                    onclick="btnSave_Click" ValidationGroup="val" />
                                                <asp:Button ID="btnClear" runat="server" 
                                                    CssClass="md-btn md-btn-small md-btn-flat md-btn-warning" Text=" Clear " 
                                                    onclick="btnClear_Click" />
                                                
                                            </div>                                        </div>
                                    </div>


                                </div>
                            </div>
                        </div>


                    </div>

                </div>
           <%-- </ContentTemplate>
        </asp:UpdatePanel>--%>
    

</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="PageScript" runat="Server">

    <script type="text/javascript" src="admin/js/admin/tinymce/tinymce.min.js"></script>
    <script type="text/javascript">



        tinyMCE.init({
            // General options            
            selector: 'textarea',
            theme: 'modern',

            menu: { // this is the complete default configuration
                file: { title: 'File', items: 'newdocument' },
                edit: { title: 'Edit', items: 'undo redo | cut copy paste pastetext | selectall' },
                insert: { title: 'Insert', items: 'link media | template hr' },
                view: { title: 'View', items: 'visualaid' },
                format: { title: 'Format', items: 'bold italic underline strikethrough superscript subscript | formats | removeformat' },
                table: { title: 'Table', items: 'inserttable tableprops deletetable | cell row column' },
                tools: { title: 'Tools', items: 'spellchecker code' }
            },
            plugins: 'advlist autolink link image lists charmap print preview table'
        });


    </script>

</asp:Content>


