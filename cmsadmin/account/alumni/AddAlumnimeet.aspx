<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="AddAlumnimeet.aspx.cs" Inherits="admin_account_events_addevents" ValidateRequest="false" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Alumni Meet </h1>
    <style>
    .remove {
  display: block;
  background: #444;
  border: 1px solid black;
  color: white;
  text-align: center;
  cursor: pointer;
  width:175px;
}
.remove:hover {
  background: white;
  color: black;
}
        </style>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" runat="Server">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="errormsg" ShowSummary="false" ShowMessageBox="true" Display="None" ValidationGroup="val"/>
      
                <div class="uk-grid">

                    <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
                        <div class="md-card">
                            <div class="md-card-toolbar">
                                <h3 class="md-card-toolbar-heading-text"><asp:Label ID="lblDisplayText" runat="server"></asp:Label>
                                <b style="padding-left:420px"><asp:Label  ID="lblStatus" runat="server"></asp:Label></b>
                                 <b style="padding-left:120px"><asp:PlaceHolder ID="phLiveUrl" runat="server"></asp:PlaceHolder></b>
                             
                                </h3>
                            </div>
                            <div class="md-card-content large-padding">
                                <div class="uk-grid uk-grid-divider uk-grid-medium">
                                    <div class="uk-width-large-2-3">
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                              <label>Content *</label>
                                                <div class="md-input-wrapper"  runat="server" id="dvContent" style="padding-top:11px">
                                                   
                                                    <asp:TextBox ID="txtContent" ClientIDMode="Static" runat="server" TextMode="MultiLine" Height="270px" Width="680px"
                                                        Rows="8"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter content" Display="None" ControlToValidate="txtContent"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                    
                                   


                                        <hr class="uk-grid-divider uk-hidden-large">
                               
                                
                               
                                    </div>


                                    <!--Right Side Contents-->
                                    <div class="uk-width-large-1-3">
                                    <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                 <label>Title *</label>
                                                <div class="md-input-wrapper" id="dvTitle" runat="server" style="padding-top:9px">
                                                   
                                                    <asp:TextBox ID="txtTitle"  runat="server" CssClass="md-input" style="border-width:2px 2px 2px;"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter Title" Display="None" ControlToValidate="txtTitle"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                 <label>Venue *</label>
                                                <div class="md-input-wrapper" id="dvVenue" runat="server" style="padding-top:9px">
                                                   
                                                    <asp:TextBox ID="txtVenue"  runat="server" CssClass="md-input" style="border-width:2px 2px 2px;"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter Venue" Display="None" ControlToValidate="txtVenue"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>



                                         <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                  <label>Alumni Meet Date *</label>
                                                <div class="md-input-wrapper" id="dvDate" runat="server"  style="padding-top:12px">
                                               
                                                   <asp:TextBox ID="txtEventStartDate" ClientIDMode="Static" runat="server"  CssClass="md-input" style="width:75%;border-width:2px 2px 2px;"></asp:TextBox>
                                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter event start date" Display="None" ControlToValidate="txtEventStartDate"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                        </div>
                                 

                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-medium-3-3">
                                            <asp:CheckBox ID="chkStatus" runat="server" Text="Status" data-switchery="false" Checked="true" />
                                                <%--<input type="checkbox" data-switchery="false" id="chkStatus" runat="server" style="display: none;" checked="checked" />--%>
                                                
                                                <br />
                                            </div>
                                        </div>
                                         <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-medium-3-3">
                                                  <label> Image (max 6 files)*</label>
                                                 <asp:FileUpload ID="fImage" runat="server" ClientIDMode="Static" multiple="true" name="fImage[]" />
                                                  <asp:RequiredFieldValidator ID="rvImage" runat="server" ErrorMessage="Please Upload image" Display="None" ControlToValidate="fImage"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator id="Validator" runat="server" ErrorMessage="Images must be of type jpeg or gif or png!" Display="None" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.|jpeg|.gif)$" ValidationGroup="val" ControlToValidate="fImage" />
                                            </div>
                                        </div>

                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-medium-3-3">
                                                <asp:Image ID="Image1" runat="server" />
                                                <asp:Image ID="Image2" runat="server" />
                                                <asp:Image ID="Image3" runat="server" />
                                                <asp:Image ID="Image4" runat="server" />
                                                <asp:Image ID="Image5" runat="server" />
                                                <asp:Image ID="Image6" runat="server" />
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
                                                <asp:Button ID="btnView" runat="server" CssClass="md-btn md-btn-small md-btn-flat md-btn-warning" Text=" View " OnClick="btnView_Click" />
                                            </div>                                        </div>

                                    </div>
                                    
                                    <!--End of Right Side-->
                                </div>
                            </div>
                        </div>


                    </div>

                </div>
       
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="PageScript" runat="Server">

<link rel="stylesheet"
    href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.6/themes/base/jquery-ui.css"
        type="text/css" media="all" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.4.4/jquery.min.js"
    type="text/javascript"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.6/jquery-ui.min.js"
        type="text/javascript"></script>
       
    <script type="text/javascript">
      
        //        $(function () {
        var $j = jQuery.noConflict();
        $j('#<%= txtEventStartDate.ClientID  %>').datepicker({
            buttonImage: '/cmsadmin/images/calendar.png',
            buttonImageOnly: true,
            changeMonth: true,
            changeYear: true,
            showOn: 'button',
            dateFormat: "dd/mm/yy",

            beforeShow: function (input, inst) {
                var rect = input.getBoundingClientRect();
                setTimeout(function () {
                    inst.dpDiv.css({ top: rect.top + 40, left: rect.left + 0 });
                }, 0);
            }
        });

    
     

    </script>
</asp:Content>



