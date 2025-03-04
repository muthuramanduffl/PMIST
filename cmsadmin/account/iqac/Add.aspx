<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="admin_account_iqac_Add" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>IQAC <small>(Page Content)</small> </h1>
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
                            <div class="md-card-content large-padding">
                                <div class="uk-grid uk-grid-divider uk-grid-medium">
                                    <div class="uk-width-large-2-3">
                                            <div class="uk-grid uk-grid-small" id="dvoldImage" style="display:none" runat="server" clientidmode="static">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                                            
                                                 
                                                    
                                                    <span class="md-input-bar"></span>
                                                </div>
                                                <asp:PlaceHolder ID="phType" runat="server"></asp:PlaceHolder>
                                            </div>
                                        </div>
                                      
                                         
                                        <hr class="uk-grid-divider uk-hidden-large">
                                    </div>


                                    <!--Right Side Contents-->
                                    <div class="uk-width-large-1-3">
                                    <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvCriteria" runat="server" style="padding-top:9px">
                                                    
                                                    <label>Section *</label>
                                                    <br />
                                                    <br />
                                                    <asp:DropDownList ID="ddlMainSection" runat="server" CssClass="select-list" AutoPostBack="true" OnSelectedIndexChanged="ddlMainSection_SelectedIndexChanged">
                                                            <asp:ListItem Value="Select Section">Select Section</asp:ListItem>
                                                        <asp:ListItem Value="Meeting">Meeting</asp:ListItem>
                                                        <asp:ListItem Value="Nirf">Nirf</asp:ListItem>
                                                         <asp:ListItem Value="Aqar">Aqar</asp:ListItem>
                                                        <asp:ListItem Value="Pmist Annual Report">Pmist Annual Report</asp:ListItem> 
                                                       
                                                        </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please select section"
                                                        Display="None" ControlToValidate="ddlMainSection" InitialValue="Select Section"  ValidationGroup="val"></asp:RequiredFieldValidator>                                               
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                          <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="true">
                                                          <ContentTemplate>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvMetric" runat="server" style="padding-top:12px">
                                                 
                                                    <label  style="top:10px">Sub Section *</label>
                                                     <br />
                                                    <asp:DropDownList ID="ddlSubSection" runat="server" CssClass="select-list" AutoPostBack="true" OnSelectedIndexChanged="ddlSubSection_SelectedIndexChanged">
                                                        <asp:ListItem Value="Select Sub Section">Select Sub Section</asp:ListItem>
                                                        </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please select sub section"
                                                        Display="None" ControlToValidate="ddlSubSection" InitialValue="Select Sub Section"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                                              </ContentTemplate>
                              <Triggers>
       
          <asp:AsyncPostBackTrigger ControlID="ddlMainSection" EventName="SelectedIndexChanged" />
                    
      </Triggers>
                             </asp:UpdatePanel>                      
                                        
                                        
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvTitle" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Title *</label>
                                                    <br />
                                                
                                                     <asp:TextBox ID="txtTitle" runat="server" CssClass="md-input" style="border-width:2px 2px 2px;"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter title" Display="None" ControlToValidate="txtTitle" ValidationGroup="val">
                                                     </asp:RequiredFieldValidator>
                                                   
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                       <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvUplodFile" runat="server" style="padding-top:9px">
                                                 <br />
                                                    <label style="position:static">Upload File *</label>
                                                     <br />
                                                    <asp:FileUpload ID="flFile" runat="server"  CssClass="ajax__fileupload" ClientIDMode="Static"  />
                                                   <asp:HiddenField ID="hiddenFile" runat="server" />
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please choose file" Display="None" ControlToValidate="flFile"  ValidationGroup="val"></asp:RequiredFieldValidator>                    
                    
                                                    <asp:RegularExpressionValidator id="rvPdf" runat="server" ErrorMessage="File must be of type pdf" Display="None" ValidationExpression="([a-zA-Z0-9\s_\\.,\-:])+(.pdf|.PDF|.png|.jpg|.gif|.jpeg|.JPG|.mp4|.MP4)$" ValidationGroup="val" ControlToValidate="flFile" />
                                                   
                                                </div>
                                            </div>
                                        </div>
                                         <br />
                                                     <br />
                                          <asp:UpdatePanel ID="UpdatePanel3" runat="server" ChildrenAsTriggers="true">
                                                          <ContentTemplate>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper md-input-filled" id="dvDisplayOrder" runat="server" style="padding-top:15px">
                                                     <br />
                                                    <label>Display Order</label>
                                                     <asp:TextBox ID="txtDisplayOrder" runat="server" CssClass="md-input"></asp:TextBox>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtDisplayOrder"
ErrorMessage="Please Enter Only Numbers" Display="None" ValidationExpression="^\d+$" ValidationGroup="val"></asp:RegularExpressionValidator>
                                                    <asp:HiddenField ID="hdnDisplayOrder" runat="server" />
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                          </ContentTemplate>
                              <Triggers>
      
          <asp:AsyncPostBackTrigger ControlID="ddlSubSection" EventName="SelectedIndexChanged" />
          
      </Triggers>
                             </asp:UpdatePanel>
                                          <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-medium-3-3">
                                                <input type="checkbox" data-switchery="false" id="chkStatus" runat="server" style="display: none;" checked="checked" />
                                                <asp:HiddenField ID="hdnStatus" runat="server" />
                                                <label for="chkStatus" class="inline-label">Active</label>
                                                <br />
                                            </div>
                                        </div>
                                        
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3" style="width:1500px">
                                               <%-- <asp:Button ID="btnPublish" runat="server" 
                                                    CssClass="md-btn md-btn-small md-btn-flat md-btn-primary" Text=" Publish " 
                                                    onclick="btnPublish_Click" OnClientClick="tinyMCE.triggerSave(false,true);" ValidationGroup="val"  />--%>
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
           <%-- </ContentTemplate>
        </asp:UpdatePanel>--%>
   
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="PageScript" runat="Server">
      <script type="text/javascript">
        
        $(".remove").click(function () {
            document.getElementById("dvEventImage").style.display = "none";
             document.getElementById("spRemove").style.display = "none";
            $('#imgEventImage').attr('src', '');      
            $('#flFile').val("");
        }); 
</script>
</asp:Content>

