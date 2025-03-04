<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="admin_account_slider_Viewslider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" Runat="Server">
<h1>Recuritment <small>(Page View)</small> </h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" Runat="Server">
<script type="text/javascript">
    function confirmDelete() {
        return confirm('Are you sure you wish to delete this entry?');

    }
    function newPopup(url) {
        popupWindow = window.open(
        url, 'popUpWindow', 'height=700,width=800,left=10,top=10,resizable=yes,scrollbars=no,toolbar=no,menubar=no,location=no,directories=no,status=yes')
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
   .uk-width-large-3-3, .uk-width-large-2-3 {
       width: 100%;
   }
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
</style>

<div class="uk-grid">

                    <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
                        <div class="md-card">
                            <div class="md-card-toolbar">
                                <h3 class="md-card-toolbar-heading-text">Dashboard - Recuritment - <b>View</b>
                                </h3>
                            </div>
                            <div class="md-card-content large-padding" height="750px">
                                <div class="uk-grid uk-grid-divider uk-grid-medium">
                                    <div class="uk-width-large-2-3">
                                          Filter:
                                                        <asp:DropDownList ID="ddlFilter" runat="server" AutoPostBack="true" CssClass="select-list" Width="150px" OnSelectedIndexChanged="ddlFilter_SelectedIndexChanged">
                                                         <asp:ListItem Value="All">All</asp:ListItem>
                                                            <asp:ListItem Value="Active">Active</asp:ListItem>
                                                        <asp:ListItem Value="In Active">In Active</asp:ListItem>
                                                       
                                                        </asp:DropDownList>
                                                       
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper md-input-filled" style="">
                                               <asp:Label ID="lblcheck" runat="server"></asp:Label>
                                                    <br />
                                                     <br />
                                                     <div class="table-responsive">
                                                <asp:GridView ID="grvContent" runat="server"  DataKeyNames="Sno" AllowPaging="True" AutoGenerateColumns="False"
                            CellPadding="4" PagerSettings-Mode="NumericFirstLast"  GridLines="None"
                             CssClass="PrettyGridView"
                            PageSize="5"  OnPageIndexChanging="OnPaging"  >

                            <AlternatingRowStyle BackColor="White" ForeColor="#284775"  />
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#a59c85" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#004a8f" Font-Bold="True" ForeColor="White" Font-Size="13px"  />
                            <PagerStyle BackColor="White" ForeColor="#00000" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" Font-Size="13px" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />

       
              <Columns> 
                  <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Name">
                <ItemTemplate>
                   <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name")%>' Width="120px"></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>

               
                 <asp:TemplateField AccessibleHeaderText="EmailId" HeaderText="Email Id">
                <ItemTemplate>
                   <asp:Label ID="lblEmailId" runat="server" Text='<%# Eval("EmailId")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                    <asp:TemplateField AccessibleHeaderText="MobileNo" HeaderText="Mobile No">
                <ItemTemplate>
                   <asp:Label ID="lblMobileNo" runat="server" Text='<%# Eval("MobileNo")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                    <asp:TemplateField AccessibleHeaderText="CompanyName" HeaderText="Company Name">
                <ItemTemplate>
                   <asp:Label ID="lblCompanyName" runat="server" Text='<%# Eval("CompanyName")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                      <asp:TemplateField AccessibleHeaderText="CompanyEmailId" HeaderText="Company Email Id">
                <ItemTemplate>
                   <asp:Label ID="lblCompanyEmailId" runat="server" Text='<%# Eval("CompanyEmailId")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                    <asp:TemplateField AccessibleHeaderText="MobileNo" HeaderText="Company Contact No">
                <ItemTemplate>
                   <asp:Label ID="lblCompanyContactNo" runat="server" Text='<%# Eval("CompanyContactNo")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                   
                    <asp:TemplateField AccessibleHeaderText="Designation" HeaderText="Designation">
                <ItemTemplate>
                   <asp:Label ID="lblDesignation" runat="server" Text='<%# Eval("Designation")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                   <asp:TemplateField AccessibleHeaderText="JobDetails" HeaderText="JobDetails">
                <ItemTemplate>
                   <asp:Label ID="lblJobDetails" runat="server" Text='<%# Eval("JobDetails")%>' Width="170px"></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                  <asp:TemplateField AccessibleHeaderText="Name" HeaderText="JD">
                <ItemTemplate>
                    <%# bindImageHref(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "JDUrl")))%>
                   
                </ItemTemplate>
                
                 </asp:TemplateField>
                  <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Status" >
                <ItemTemplate>
                   <asp:ImageButton ID="Archiveimg" ImageUrl='<%# bindImage( System.Convert.ToInt16(DataBinder.Eval(Container.DataItem, "Active"))) %>' CommandArgument='<%# Eval("Sno")+";"+ Eval("Active") %>'  OnClick="Publishimg_click" runat="server"></asp:ImageButton>
                   </ItemTemplate>
                   </asp:TemplateField>  
                    
                 <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Posted On">
                <ItemTemplate>
                    <asp:Label ID="lblDateTime" runat="server" Text='<%# bindDate( System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "PostedDate"))) %>' Width="70px"></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                
                  <asp:TemplateField AccessibleHeaderText="" HeaderText="Edit" >
                <ItemTemplate>
                   <a href='Edit.aspx?ID=<%# Eval("Sno") %>'">Edit</a>
                   </ItemTemplate>
                   </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="" HeaderText="Delete">
                <ItemTemplate>
                   <asp:LinkButton ID="lbdel" runat="server" CssClass="body" CommandArgument='<%# Eval("Sno") %>' OnClientClick="javascript:return confirmDelete();" Font-Underline="false" CommandName="deleterow" Text="Delete" OnClick="Button_Click">Delete</asp:LinkButton>
                   </ItemTemplate>
                   </asp:TemplateField> 
                
            </Columns>
        </asp:GridView>
        </div>
        <div style="padding-top:25px"></div>
        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                              
                                               <asp:Button ID="btnView" runat="server" CssClass="md-btn md-btn-small md-btn-flat md-btn-success" Text=" Live View " OnClick="btnLiveView_Click" OnClientClick="target ='_blank';"  />
                                            </div>
                                        </div>
        
                                                </div>
                                            </div>
                                        </div>


                                    </div>


                                </div>
                            </div>
                        </div>


                    </div>

                </div>
                 
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="PageScript" Runat="Server">
</asp:Content>

