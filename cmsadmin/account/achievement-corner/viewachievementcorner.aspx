<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="viewachievementcorner.aspx.cs" Inherits="admin_account_viewachievementcorner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" Runat="Server">
 <h1>Achievement Corner</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" Runat="Server">
<script type="text/javascript">
    function confirmDelete() {
        return confirm('Are you sure you wish to delete this entry?');

    }
   
</script>
<%--<style>
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
   tr:last-child td {
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
   }
   tr td:nth-child(2) {
       text-align: left;
       padding-left: 7px;
   }
</style>--%>
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
                                <h3 class="md-card-toolbar-heading-text">Dashboard / Achievement Corner / <b>View List <asp:Label ID="lblDisplayText" runat="server"></asp:Label></b>
                                 <b style="padding-left:120px"><asp:PlaceHolder ID="phLiveUrl" runat="server"></asp:PlaceHolder></b>
                                </h3>
                            </div>
                            
                            <div class="col-lg-10 row" style="font-size: 16px; padding-left: 20px; padding-top: 20px;">Total Achievements : <asp:Label ID="lbl" runat="server"></asp:Label></div>

                            <div class="md-card-content large-padding" height="750px">
                                <div class="uk-grid uk-grid-divider uk-grid-medium">
                                    <div class="uk-width-large-2-3">
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper md-input-filled" style="">
                                               <asp:Label ID="lblcheck" runat="server"></asp:Label>
                                               <div class="table-responsive">
                                                <asp:GridView ID="grvContent" runat="server"  DataKeyNames="Sno" AllowPaging="True" AutoGenerateColumns="False"
                            CellPadding="4" PagerSettings-Mode="NumericFirstLast"  GridLines="None"
                             CssClass="PrettyGridView"
                            PageSize="5"  OnPageIndexChanging="OnPaging">
                             <AlternatingRowStyle BackColor="White" ForeColor="#284775" Width="720px" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#a59c85" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#004a8f" Font-Bold="True" ForeColor="White" Font-Size="13px"  />
        <PagerStyle BackColor="White" ForeColor="#00000" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" Font-Size="13px" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
       
              <Columns>   
                <asp:TemplateField AccessibleHeaderText="Name" HeaderText="S.No" >
                <ItemTemplate>
             <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                </ItemTemplate>
                
               
                
                 </asp:TemplateField>
                 <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Title" >
                <ItemTemplate>
              <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title")%>'></asp:Label>
                </ItemTemplate>
                
               
                
                 </asp:TemplateField>
         
                 <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Posted On" >
                <ItemTemplate>
                    <asp:Label ID="lblDateTime" runat="server" Text='<%# bindDate( System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "AddedDate"))) %>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                   <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Posted By" >
                <ItemTemplate>
                    <asp:Label ID="lblPostedBy" runat="server" Text='<%# Eval("AddedBy")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                
                 <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Status" >
                <ItemTemplate>
                   <asp:ImageButton ID="Archiveimg" ImageUrl='<%# bindImage( System.Convert.ToInt16(DataBinder.Eval(Container.DataItem, "Active"))) %>' CommandArgument='<%# Eval("Sno") %>'  OnClick="Statusimg_click" runat="server"></asp:ImageButton>
                   </ItemTemplate>
                   </asp:TemplateField>  
                    
               <asp:TemplateField AccessibleHeaderText="" HeaderText="Edit" >
                   <ItemTemplate>                  

        <a href='addachievementcorner.aspx?ID=<%# Eval("Sno") %>'">Edit</a>

                   </ItemTemplate>
                   </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="" HeaderText="Delete" >
                <ItemTemplate>
                   <asp:LinkButton ID="lbdel" runat="server" CssClass="body" 
                       CommandArgument='<%# Eval("Sno")%>' OnClientClick="javascript:return confirmDelete();" Font-Underline="false" CommandName="deleterow" Text="Delete" OnClick="Button_Click">Delete</asp:LinkButton>
                   </ItemTemplate>
                   </asp:TemplateField> 
                
            </Columns>
        </asp:GridView></div>
        <div style="padding-top:25px"></div>
        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <asp:Button ID="btnAdd" runat="server" CssClass="md-btn md-btn-small md-btn-flat md-btn-success" Text=" Add Achievements " OnClick="btnAdd_Click" ValidationGroup="val" />
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

