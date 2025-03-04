<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="Viewslider.aspx.cs" Inherits="admin_account_slider_Viewslider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" Runat="Server">
<h1>Slider <small>(Page View)</small> </h1>
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
</style>

<div class="uk-grid">

                    <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
                        <div class="md-card">
                            <div class="md-card-toolbar">
                                <h3 class="md-card-toolbar-heading-text">Dashboard - Slider - <b>View Slider</b>
                                </h3>
                            </div>
                            <div class="md-card-content large-padding" height="750px">
                                <div class="uk-grid uk-grid-divider uk-grid-medium">
                                    <div class="uk-width-large-2-3">
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper md-input-filled" style="">
                                               <asp:Label ID="lblcheck" runat="server"></asp:Label>
                                               <div class="table-responsive">
                                                <asp:GridView ID="grvSlider" runat="server"  DataKeyNames="SliderId" AllowPaging="True" AutoGenerateColumns="False"
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
                  <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Slider Image">
                <ItemTemplate>
                    <a id="A1" href='<%# bindImageHref(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "SliderImage")))%>' onclick='<%# BindPopup( System.Convert.ToString(DataBinder.Eval(Container.DataItem, "SliderImage"))) %>' runat="server">
                         <asp:Label ID="lblSliderImage" runat="server" Text=' <%# bindImageTitle(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "SliderImage")))%>' Width="70px"></asp:Label>
                       </a>
                </ItemTemplate>
                
                 </asp:TemplateField>
                 <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Slider Text">
                <ItemTemplate>
              <asp:Label ID="lblTitle" runat="server" Text='<%# bindTitle( System.Convert.ToString(DataBinder.Eval(Container.DataItem, "SliderText1"))) %>' Width="170px"></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                
                
              
                  <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Status" >
                <ItemTemplate>
                   <asp:ImageButton ID="Archiveimg" ImageUrl='<%# bindImage( System.Convert.ToInt16(DataBinder.Eval(Container.DataItem, "Status"))) %>' CommandArgument='<%# Eval("SliderId")+";"+ Eval("Status") %>'  OnClick="Publishimg_click" runat="server"></asp:ImageButton>
                   </ItemTemplate>
                   </asp:TemplateField>  
                     
                 <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Added On">
                <ItemTemplate>
                    <asp:Label ID="lblDateTime" runat="server" Text='<%# bindDate( System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "AddedDateTime"))) %>' Width="70px"></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                   <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Added By">
                <ItemTemplate>
                    <asp:Label ID="lblPostedBy" runat="server" Text='<%# Eval("AddedBy")%>' Width="70px"></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                 
               
                  <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Updated On" >
                <ItemTemplate>
                    <asp:Label ID="lblUpdatedDateTime" runat="server" Text='<%# bindUpdatedDate(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "UpdatedBy")), System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "UpdatedDateTime"))) %>' Width="70px"></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                   <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Updated By">
                <ItemTemplate>
                    <asp:Label ID="lblUpdatedBy" runat="server" Text='<%# bindUpdatedBy( System.Convert.ToString(DataBinder.Eval(Container.DataItem, "UpdatedBy"))) %>' Width="70px"></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                  <asp:TemplateField AccessibleHeaderText="" HeaderText="Edit" >
                <ItemTemplate>
                   <a href='AddSlider.aspx?ID=<%# Eval("SliderId") %>'">Edit</a>
                   </ItemTemplate>
                   </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="" HeaderText="Delete">
                <ItemTemplate>
                   <asp:LinkButton ID="lbdel" runat="server" CssClass="body" CommandArgument='<%# Eval("SliderId") +"," + Eval("SliderImage")+"," + Eval("DisplayOrder") %>' OnClientClick="javascript:return confirmDelete();" Font-Underline="false" CommandName="deleterow" Text="Delete" OnClick="Button_Click">Delete</asp:LinkButton>
                   </ItemTemplate>
                   </asp:TemplateField> 
                
            </Columns>
        </asp:GridView></div>
        <div style="padding-top:25px"></div>
        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <asp:Button ID="btnAdd" runat="server" CssClass="md-btn md-btn-small md-btn-flat md-btn-success" Text=" Add Slider Content " OnClick="btnAdd_Click" ValidationGroup="val" />
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

