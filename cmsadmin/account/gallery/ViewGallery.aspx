<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="ViewGallery.aspx.cs" Inherits="admin_account_gallery_AddGallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">

    <h1><asp:Label ID="lblSchoolName" runat="server"></asp:Label>Gallery List </h1>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" runat="Server">
<script type="text/javascript">
    function confirmDelete() {
        return confirm('Are you sure you wish to delete this entry?');

    }
   
</script>
<style>
    .page_navigation{font-family:Arial, Helvetica, Sans-Serif; font-size:12px;}
.page_navigation li{
list-style-type: none;
display: inline;
padding-bottom: 1px;
}

.page_navigation a, .page_navigation a:visited{
color:#1659a7; padding:3px 5px; background:#e7fbff; border:1px solid #d6d5d5; display:inline-block;margin:0 0 0 2px;
}

.page_navigation a:hover, .page_navigation a:active_page{
padding: 0 5px;
border: 1px solid #9aafe5;
text-decoration: none; 
color: #2e6ab1;
}

.page_navigation a.active_page{
background-color: #2e6ab1;
color: #FFF !important;
border-color: #2b66a5;
font-weight: bold;
cursor: default;
}

.page_navigation a.disablelink, .page_navigation a.disablelink:hover{
background-color: white;
cursor: default;
color: #929292;
border-color: #929292;
font-weight: normal !important;
}

.page_navigation a.previous_link{
font-weight: bold;
}
.page_navigation a.next_link{
font-weight: bold;
}

</style>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="errormsg" ShowSummary="false" ShowMessageBox="true" Display="None" ValidationGroup="val"/>						
       <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
            <ContentTemplate>--%>

                <div class="uk-grid">

                    <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
                        <div class="md-card">
                            <div class="md-card-toolbar">
                                <h3 class="md-card-toolbar-heading-text"><asp:Label ID="lblDisplayText" runat="server"></asp:Label>
                                <b style="padding-left:220px"><asp:Label  ID="lblTotolImages" runat="server"></asp:Label></b>
                                 <b style="padding-left:120px"><asp:Button ID="btnLiveView" runat="server" CssClass="md-btn md-btn-small md-btn-flat md-btn-success" Text="Live View" OnClick="btnLiveView_Click" OnClientClick="target ='_blank';"  /></b>
                                </h3>
                                 
                            </div>
                            
                                  
                            <div class="md-card-content large-padding">
                                <h3 class="md-card-toolbar-heading-text"><asp:Label ID="lblText" runat="server"></asp:Label>
                                </h3>
                                
                                <div class="uk-grid uk-grid-divider uk-grid-medium">
                                    <div class="uk-width-large-2-3">
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper md-input-filled" style="">
                                                
                                                <div class="uk-grid-width-small-1-2 uk-grid-width-medium-1-3 uk-grid-width-large-1-4" data-uk-grid="{gutter: 20, controls: '#products_sort'}" style="position: relative; margin-left: -20px; height: 2374px;">
                                                 <asp:Label ID="lblCheck" runat="server"></asp:Label>
                                                <asp:Repeater ID="rprGallery" runat="server">
                                                <ItemTemplate>
                                                <div class="salemainwrap" data-product-name="Et quis." data-grid-prepared="true" style="position: absolute; box-sizing: border-box; padding-left: 20px; padding-bottom: 20px; top: 0px; left: 0px; opacity: 1;">
                        <div class="md-card md-card-hover-img">
                            <div class="md-card-head uk-text-center uk-position-relative">
                                <div class="uk-badge uk-badge-<%# bindStatusCSS(System.Convert.ToBoolean(DataBinder.Eval(Container.DataItem, "Status")))%> uk-position-absolute uk-position-top-left uk-margin-left uk-margin-top"><%# bindStatusText1(System.Convert.ToBoolean(DataBinder.Eval(Container.DataItem, "Status")))%></div>
                                <img class="md-card-head-img" src='<%# bindImageUrl(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "GalleryImage")),System.Convert.ToInt32(DataBinder.Eval(Container.DataItem, "AlbumId")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "Department")))%>' alt="">
                            </div>
                            <div class="md-card-content">
                                <asp:LinkButton ID="lbdel" runat="server" CssClass="md-btn md-btn-small" CommandArgument='<%# Eval("GalleryId") +"," + Eval("GalleryImage")+","+Eval("AlbumId")+","+Eval("Department")%>' OnClientClick="javascript:return confirmDelete();" Font-Underline="false" CommandName="deleterow" Text="Delete" OnClick="Button_Click">Delete</asp:LinkButton>
                                <div style="padding-top:20px"></div>
                                <asp:LinkButton ID="lbStatus" runat="server" CssClass="md-btn md-btn-small" CommandArgument='<%# Eval("GalleryId")+","+Eval("AlbumId")%>' Font-Underline="false" CommandName="Statusrow" OnClick="StatusButton_Click"><%# bindStatusText(System.Convert.ToBoolean(DataBinder.Eval(Container.DataItem, "Status")))%></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                                                 </ItemTemplate>
                                                </asp:Repeater>
                                               
                                                </div>
                                                
                                                 <div style="margin-top: 20px;" class="page_navigation">
                    <table style="width: 50px;">
                        <tr>
                           
                            <td>
                                <asp:LinkButton ID="lbPrevious" runat="server" 
				OnClick="lbPrevious_Click">Previous</asp:LinkButton>
                            </td>
                            
                            <td>
                                <asp:LinkButton ID="lbNext" runat="server" 
				OnClick="lbNext_Click">Next</asp:LinkButton>
                            </td>
                          
                            
                        </tr>
                    </table>

                </div>
             
                                                </div>
                                            </div>
                                        </div>



                                        <hr class="uk-grid-divider uk-hidden-large">
                                    </div>
                                      

                                    <!--Right Side Contents-->
                                    <div class="uk-width-large-1-3">
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvDepartment" runat="server" style="padding-top:12px">
                                                      <label>Department</label>
                                                     <br />
                                                <br />
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="select-list" AutoPostBack="true"
                                                        OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged">
                                                            <asp:ListItem Value="All">All</asp:ListItem>
                                                        <asp:ListItem Value="General">General</asp:ListItem>
                                                        <asp:ListItem Value="Centre for Institute Industry Interactions">Centre for Institute Industry Interactions</asp:ListItem>
                                                        <asp:ListItem Value="PMIST">PMIST</asp:ListItem>
                                                            <asp:ListItem Value="Department of Architecture">Department of Architecture</asp:ListItem>
                                                        <asp:ListItem Value="Department of Aerospace Engineering">Department of Aerospace Engineering</asp:ListItem> 
                                                        <asp:ListItem Value="Department of Bio-Technology">Department of Bio-Technology</asp:ListItem>
                                                        <asp:ListItem Value="Department of Chemical Engineering">Department of Chemical Engineering</asp:ListItem>
                                                        <asp:ListItem Value="Department of Civil Engineering">Department of Civil Engineering</asp:ListItem>
                                                        <asp:ListItem Value="Department of Electronics and Communication Engineering">Department of Electronics and Communication Engineering</asp:ListItem>
                                                        <asp:ListItem Value="Department of Electrical and Electronics Engineering">Department of Electrical and Electronics Engineering</asp:ListItem>
                                                        <asp:ListItem Value="Department of Mechanical Engineering">Department of Mechanical Engineering</asp:ListItem>
                                                        <asp:ListItem Value="Division of Nanotechnology">Division of Nanotechnology</asp:ListItem>
                                                        <asp:ListItem Value="Department of Computer Science and Engineering">Department of Computer Science and Engineering</asp:ListItem>
                                                        <asp:ListItem Value="Department of Computer Science & Application">Department of Computer Science & Application</asp:ListItem>
                                                        <asp:ListItem Value="Department of Software Engineering">Department of Software Engineering</asp:ListItem>
                                                        <asp:ListItem Value="Department of Chemistry">Department of Chemistry</asp:ListItem>
                                                        <asp:ListItem Value="Department of Commerce">Department of Commerce</asp:ListItem>
                                                        <asp:ListItem Value="Department of English">Department of English</asp:ListItem>
                                                        <asp:ListItem Value="Department of Education">Department of Education</asp:ListItem>
                                                        <asp:ListItem Value="Department of Mathematics">Department of Mathematics</asp:ListItem>
                                                        <asp:ListItem Value="Department of Management Studies">Department of Management Studies</asp:ListItem>
                                                        <asp:ListItem Value="Department of Physics">Department of Physics</asp:ListItem>
                                                        <asp:ListItem Value="Department of Political Science">Department of Political Science</asp:ListItem>
                                                        <asp:ListItem Value="Department of Social Work">Department of Social Work</asp:ListItem>
                                                        <asp:ListItem Value="Department of MBA">Department of MBA</asp:ListItem>
                                                        <asp:ListItem Value="Centre for Institute Industry Interaction">Centre for Institute Industry Interaction</asp:ListItem>
                                                        <asp:ListItem Value="Centre for Student and Administrative Services">Centre for Student and Administrative Services</asp:ListItem>
                                                        <asp:ListItem Value="Dr.Kalaingar M.Karunanidhi Centre for Political Science">Dr.Kalaingar M.Karunanidhi Centre for Political Science</asp:ListItem>
                                                        <asp:ListItem Value="Veeramani Mohana Centre for Quality of Life Engineering Research">Veeramani Mohana Centre for Quality of Life Engineering Research</asp:ListItem>
                                                        <asp:ListItem Value="Periyar Pura Centre for Rural Development">Periyar Pura Centre for Rural Development</asp:ListItem>
                                                        <asp:ListItem Value="Centre of Excellence of Training and Research in Automation Technology">Centre of Excellence of Training and Research in Automation Technology</asp:ListItem>
                                                        <asp:ListItem Value="Centre of Excellence for Next Generation Networks">Centre of Excellence for Next Generation Networks</asp:ListItem>
                                                        <asp:ListItem Value="Centre of Excellence for Periyar Thought">Centre of Excellence for Periyar Thought</asp:ListItem>
                                                        <asp:ListItem Value="Centre for Energy and Environment">Centre for Energy and Environment</asp:ListItem>
                                                        <asp:ListItem Value="Institution Innovation Council">Institution Innovation Council</asp:ListItem>

                                                        </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please select department"
                                                        Display="None" ControlToValidate="ddlDepartment" InitialValue="Select Department"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                       <%--   <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="true" >
      <ContentTemplate>--%>
                                    <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvCategory" runat="server">
                                                    <label>Album *</label>
                                                     <br />
                                                <br />
                                                    <asp:DropDownList ID="ddlAlbum" runat="server"  AutoPostBack="true"
                                                        CssClass="select-list" 
                                                        onselectedindexchanged="ddlAlbum_SelectedIndexChanged1">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please select Album" Display="None" ControlToValidate="ddlAlbum" InitialValue="Select"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                         <%-- </ContentTemplate>
                              <Triggers>
       
          <asp:AsyncPostBackTrigger ControlID="ddlDepartment" EventName="SelectedIndexChanged" />
                    
      </Triggers>
                             </asp:UpdatePanel>--%>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                               
                                              <%--  <asp:Button ID="btnSave" runat="server" 
                                                    CssClass="md-btn md-btn-small md-btn-flat md-btn-success" Text=" Search " 
                                                    onclick="btnSave_Click" ValidationGroup="val" />--%>
                                               
                                            </div>
                                        </div>

                                    </div>
                                    <!--End of Right Side-->
                                </div>
                               
                            </div>
                        </div>


                    </div>

                </div>
            <%--</ContentTemplate>
        </asp:UpdatePanel>--%>
    

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="PageScript" runat="Server">
</asp:Content>



