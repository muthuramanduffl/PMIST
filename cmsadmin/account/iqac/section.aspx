<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="section.aspx.cs" Inherits="admin_account_iqac_section" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>IQAC Section </h1>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" runat="Server">
   <script type="text/javascript">
       function confirmDelete() {
           return confirm('Are you sure you wish to delete this entry?');

       }
       
</script>
<style>
    table tbody tr th {
        padding-left: 10px;
        text-align:center;
        padding-top: 12px;
   padding-bottom: 12px;
   padding-right: 10px;
   }
    table tbody tr td {
        /* padding-left: 11px; */
        text-align:center;
        word-break: break-word;
        padding: 15px 0px;
   }
   table {
       border-collapse: separate !important;
       border-spacing: 2px 0;
       width: 100%;
   }
   table table {
       width: auto;
       margin-top: 2%;
       margin-bottom: 3%;
   }
   .table-responsive {
       display: block;
       width: 100%;
       overflow-x: auto;
       /* height: 50vh; */
       /* overflow-y: hidden; */
   }
   /* .uk-width-large-3-3, .uk-width-large-2-3 {
       width: 100%;
   } */

   tr table tr:last-child td {
       padding: 0px !important;
       margin: auto 2px;
   }
   tr table tr:last-child td a {
       color: #000;
       padding: .5rem .75rem;
       border: 1px solid #e2e5e9;
       border-radius: 100px;
   }
 tr table tr:last-child td span {
       background: #004A8F;
       color: #fff;
       padding: .5rem .75rem;
       border: 1px solid #004A8F;
       border-radius: 100px;
   }

   /* tr:last-child td {
       padding: 0px !important;
       margin: auto 2px;
   }
   tr:last-child td a {
       color: #000;
       padding: .5rem .75rem;
       border: 1px solid #e2e5e9;
       border-radius: 100px;
   }
   tr:last-child td span {
       background: #004A8F;
       color: #fff;
       padding: .5rem .75rem;
       border: 1px solid #004A8F;
       border-radius: 100px;
   } */
</style>
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
                                <asp:PlaceHolder ID="phLiveUrl" runat="server"></asp:PlaceHolder>
                               
                                </h3>
                            </div>
                            <div class="md-card-content large-padding">
                                <div class="uk-grid uk-grid-divider uk-grid-medium">
                                    <div class="uk-width-large-2-3">
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                    <asp:PlaceHolder ID="PhImg" runat="server"></asp:PlaceHolder>
                                                    <div class="md-input-wrapper md-input-filled" style="">
                                                     Section:
                                                        <asp:DropDownList ID="ddlFilter" runat="server" AutoPostBack="true" CssClass="select-list" Width="150px" OnSelectedIndexChanged="ddlFilter_SelectedIndexChanged">
                                                         <asp:ListItem Value="All">All</asp:ListItem>
                                                          <asp:ListItem Value="Meeting">Meeting</asp:ListItem>
                                                        <asp:ListItem Value="Nirf">Nirf</asp:ListItem>
                                                         <asp:ListItem Value="Aqar">Aqar</asp:ListItem>
                                                        <asp:ListItem Value="Pmist Annual Report">Pmist Annual Report</asp:ListItem> 
                                                        </asp:DropDownList>
                                                        <br />
                                                         <br />
                                                         <asp:Label ID="lblcheck" runat="server"></asp:Label>
                                                         <div class="table-responsive">
                                                <asp:GridView ID="grvSection" runat="server"  DataKeyNames="Sno" AllowPaging="True" AutoGenerateColumns="False"
                            CellPadding="4" PagerSettings-Mode="NumericFirstLast"  GridLines="None"
                             onrowcancelingedit="grvSection_RowCancelingEdit"
 onrowediting="grvSection_RowEditing"
onrowupdating="grvSection_RowUpdating"
                            PageSize="10"  OnPageIndexChanging="OnPaging" onrowdatabound="gv_RowDataBound" >
                             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#F7F6F3" />
        <FooterStyle BackColor="#a59c85" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#004a8f" Font-Bold="True" ForeColor="White" Font-Size="13px"  />
        <PagerStyle BackColor="White" ForeColor="#00000" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" Font-Size="13px" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
       
              <Columns>   
                  <asp:TemplateField AccessibleHeaderText="Section" HeaderText="Section" >
                <ItemTemplate>
              <asp:Label ID="lblSection" runat="server" Text='<%# Eval("Section")%>'></asp:Label>
                </ItemTemplate>
               <EditItemTemplate>
                   <asp:Label ID="lblEditSection" runat="server" Text='<%# Eval("Section")%>'></asp:Label>
                     <%--<asp:DropDownList ID="ddlUpdateSection" runat="server" CssClass="select-list">
                                                        <asp:ListItem Value="Meeting">Meeting</asp:ListItem>
                                                        <asp:ListItem Value="Nirf">Nirf</asp:ListItem>
                                                         <asp:ListItem Value="Aqar">Aqar</asp:ListItem>
                                                        <asp:ListItem Value="Pmist Annual Report">Pmist Annual Report</asp:ListItem> 
                                                        </asp:DropDownList>--%>
                  </EditItemTemplate>
                 </asp:TemplateField>
                  <asp:TemplateField AccessibleHeaderText="Title" HeaderText="Title" >
                <ItemTemplate>
              <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("SubSection")%>'></asp:Label>
                </ItemTemplate>
                 <EditItemTemplate>
                   <asp:HiddenField ID="hiddenTitle" runat="server" Value='<%#Eval("SubSection") %>' />
                  <asp:TextBox ID="txtEditTitle" MaxLength="150" Width="150px" runat="server" Text='<%#Eval("SubSection") %>'/>
                    
                </EditItemTemplate>
                 </asp:TemplateField>
                   <asp:TemplateField AccessibleHeaderText="DisplayOrder" HeaderText="Display Order" >
                <ItemTemplate>
              <asp:Label ID="lblDisplayOrder" runat="server" style="word-wrap: break-word;" Text='<%# Eval("DisplayOrder")%>'></asp:Label>
                </ItemTemplate>
                 <EditItemTemplate>
                   <asp:HiddenField ID="hiddenDisplayOrder" runat="server" Value='<%#Eval("DisplayOrder") %>' />
                   <asp:HiddenField ID="hiddenStatus" runat="server" Value='<%#Eval("Active") %>' />
                  <asp:TextBox ID="txtEditDisplayOrder" MaxLength="150" Width="100px" runat="server" Text='<%#Eval("DisplayOrder") %>'/>
                    
                </EditItemTemplate>
                 </asp:TemplateField>
                  
                   <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Status" >
                <ItemTemplate>
                   <asp:ImageButton ID="Archiveimg" ImageUrl='<%# bindImage( System.Convert.ToInt16(DataBinder.Eval(Container.DataItem, "Active"))) %>' CommandArgument='<%# Eval("Sno")%>'  OnClick="Statusimg_click" runat="server"></asp:ImageButton>
                   </ItemTemplate>
                   </asp:TemplateField>  
                 <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Created On" >
                <ItemTemplate>
                    <asp:Label ID="lblDateTime" runat="server" Text='<%# bindDate( System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "AddedDateTime"))) %>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                   <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Created By" >
                <ItemTemplate>
                    <asp:Label ID="lblPostedBy" runat="server" Text='<%# Eval("AddedBy")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                 <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Updated On" >
                <ItemTemplate>
                    <asp:Label ID="lblUpdatedDateTime" runat="server" Text='<%# bindDate( System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "UpdatedDateTime"))) %>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                   <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Updated By" >
                <ItemTemplate>
                    <asp:Label ID="lblUpdatedBy" runat="server" Text='<%# Eval("UpdatedBy")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
               <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Edit" >
          <ItemTemplate>
        <asp:Button ID="btn_Edit"  CssClass="body" runat="server" Text="Edit" CommandName="Edit" />  
  
</ItemTemplate>
 <EditItemTemplate>
  <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Edit" >
          <ItemTemplate>
          <asp:LinkButton ID="lnkUpdatee" runat="server"
          CommandName="Update"
    
        Text = "Update"  ></asp:LinkButton>
           <asp:LinkButton ID="lnkCancel" runat="server"
          CommandName="Cancel"
    
        Text = "Cancel" ></asp:LinkButton>
</EditItemTemplate>
   </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="" HeaderText="Delete" >
                <ItemTemplate>
              
                   <asp:LinkButton ID="lbdel" runat="server" CssClass="body" CommandArgument='<%# Eval("Sno") +"," + Eval("DisplayOrder")+"," + Eval("Section")%>' OnClientClick="javascript:return confirmDelete();" Font-Underline="false" CommandName="deleterow" Text="Delete" OnClick="Button_Click">Delete</asp:LinkButton>
                   </ItemTemplate>
                   </asp:TemplateField> 
                
            </Columns>
        </asp:GridView></div>
        <div style="padding-top:25px"></div>
        <div class="uk-grid uk-grid-small">
                                         
                                        </div>
        
                                                </div>
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
                                                <div class="md-input-wrapper" id="dvMainSection" runat="server" style="padding-top:12px">
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
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <label>Title *</label>
                                                <div class="md-input-wrapper" id="dvTitle" runat="server" style="padding-top:19px">
                                                    
                                                    <asp:TextBox ID="txtTitle" MaxLength="150" runat="server" CssClass="md-input" style="border-width:2px 2px 2px;"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter title" Display="None" ControlToValidate="txtTitle" ValidationGroup="val">
                                                     </asp:RequiredFieldValidator>
                                                   
                                                    <span class="md-input-bar"></span>
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
       <asp:AsyncPostBackTrigger ControlID="ddlMainSection" EventName="SelectedIndexChanged" />
        
      </Triggers>
                             </asp:UpdatePanel>

                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-medium-3-3">
                                            <asp:CheckBox ID="chkStatus" runat="server" Text="Status" data-switchery="false" Checked="true" />
                                                <%--<input type="checkbox" data-switchery="false" id="chkStatus" runat="server" style="display: none;" checked="checked" />--%>
                                                
                                                <br />
                                            </div>
                                        </div>
                                         
                                                                           
                                       
                                        
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3" style="width:1500px">
                                                <asp:Button ID="btnPublish" runat="server" 
                                                    CssClass="md-btn md-btn-small md-btn-flat md-btn-primary" Text=" Save " 
                                                    onclick="btnPublish_Click"  ValidationGroup="val"  />
                                                  <asp:Button ID="btnClear" runat="server" 
                                                    CssClass="md-btn md-btn-small md-btn-flat md-btn-warning" Text=" Clear " 
                                                    onclick="btnClear_Click" />
                                                    
                                               
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

   

</asp:Content>

