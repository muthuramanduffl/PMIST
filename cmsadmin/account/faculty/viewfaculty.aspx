<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="viewfaculty.aspx.cs" Inherits="admin_account_about_ViewNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" Runat="Server">
 <h1> Faculty List </h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" Runat="Server">
<script type="text/javascript">
    function confirmDelete() {
        return confirm('Are you sure you wish to delete this entry?');

    }
    function newPopup(url) {
        popupWindow = window.open(
            url, 'popUpWindow', 'height=700,width=800,left=10,top=10,resizable=yes,scrollbars=no,toolbar=no,menubar=no,location=no,directories=no,status=yes')
        return false;
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
    /* height: 90vh; */
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
.w-auto {
    width: auto !important;
}
</style>

<div class="uk-grid">

                    <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
                        <div class="md-card">
                            <div class="md-card-toolbar">
                                <h3 class="md-card-toolbar-heading-text">Dashboard / Faculty / <b>View Faculty List <asp:Label ID="lblDisplayText" runat="server"></asp:Label></b>
                                 <b style="padding-left:120px"><asp:PlaceHolder ID="phLiveUrl" runat="server"></asp:PlaceHolder></b>
                                </h3>
                            </div>
                            <div class="md-card-content large-padding" height="750px">
                                <div class="uk-grid uk-grid-divider uk-grid-medium">
                                    <div class="uk-width-large-2-3">
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3 w-auto">
                                                <div class="md-input-wrapper md-input-filled" style="">
                                                    <span>Department</span>
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" 
                                                        OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged" AutoPostBack="true" CssClass="select-list">
                                                            <asp:ListItem Value="All">All</asp:ListItem>
                                                        <asp:ListItem Value="PMIST">PMIST</asp:ListItem>
                                                        <asp:ListItem Value="Alumni">Alumni</asp:ListItem>
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

                                                        <asp:ListItem Value="Department of Computer Science">Department of Computer Science</asp:ListItem>
                                                        <asp:ListItem Value="Department of Software Engineering">Department of Software Engineering</asp:ListItem>
                                                        <asp:ListItem Value="Department of Chemistry">Department of Chemistry</asp:ListItem>
                                                        <asp:ListItem Value="Department of Commerce">Department of Commerce</asp:ListItem>
                                                        <asp:ListItem Value="Department of English">Department of English</asp:ListItem>
                                                        <asp:ListItem Value="Department of Education">Department of Education</asp:ListItem>
                                                        <asp:ListItem Value="Department of Informatics">Department of Informatics</asp:ListItem>
                                                        <asp:ListItem Value="Department of Foundation Courses">Department of Foundation Courses</asp:ListItem>
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
                                                        <asp:ListItem Value="IQAC">IQAC</asp:ListItem>
                                                        </asp:DropDownList>
                                                      
                                                </div>
                                              </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper md-input-filled" style="">
                                               <asp:Label ID="lblcheck" runat="server"></asp:Label>
                                               <div class="table-responsive">
                                                <asp:GridView ID="grvFaculty" runat="server"  DataKeyNames="Sno" AllowPaging="True" AutoGenerateColumns="False"
                            CellPadding="4" PagerSettings-Mode="NumericFirstLast"  GridLines="None"
                             CssClass="PrettyGridView"
                            PageSize="15"  OnPageIndexChanging="OnPaging" Width="1220px"  >
                             <AlternatingRowStyle BackColor="White" ForeColor="#284775" Width="920px" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#a59c85" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#004a8f" Font-Bold="True" ForeColor="White" Font-Size="13px"  />
        <PagerStyle BackColor="White" ForeColor="#00000" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" Font-Size="13px" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
       
              <Columns>   

                 <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Name" >
                <ItemTemplate>
              <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                
                  <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Designation" >
                <ItemTemplate>
              <asp:Label ID="lblDesignation" runat="server" Text='<%# Eval("Designation")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                  <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Department" >
                <ItemTemplate>
              <asp:Label ID="lblDepartment" runat="server" Text='<%# Eval("Department")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>

                 <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Display Order" >
                    <ItemTemplate>
                  <asp:Label ID="lblDisplayOrder" runat="server" Text='<%# Eval("DisplayOrder")%>'></asp:Label>
                    </ItemTemplate>
                    
                     </asp:TemplateField>


                  <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Head of Depertment" >
                <ItemTemplate>
                   <asp:Image ID="Depertmentimg" ImageUrl='<%# bindImage( System.Convert.ToInt16(DataBinder.Eval(Container.DataItem, "IsHod"))) %>' runat="server"></asp:Image>
                   </ItemTemplate>
                   </asp:TemplateField>  
                  
                 <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Posted On" >
                <ItemTemplate>
                    <asp:Label ID="lblDateTime" runat="server" Text='<%# bindDate( System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "PostedDateTime"))) %>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                   <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Posted By" >
                <ItemTemplate>
                    <asp:Label ID="lblPostedBy" runat="server" Text='<%# Eval("PostedBy")%>'></asp:Label>
                </ItemTemplate>
                
                 </asp:TemplateField>
                 
                    
                 <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Status" >
                <ItemTemplate>
                   <asp:ImageButton ID="Archiveimg" ImageUrl='<%# bindImage( System.Convert.ToInt16(DataBinder.Eval(Container.DataItem, "Status"))) %>' CommandArgument='<%# Eval("Sno") %>'  OnClick="Statusimg_click" runat="server"></asp:ImageButton>
                   </ItemTemplate>
                   </asp:TemplateField>  
                    
               <asp:TemplateField AccessibleHeaderText="" HeaderText="Edit" >
                   <ItemTemplate>  
        <a href='addfaculty.aspx?ID=<%# Eval("Sno") %>'">Edit</a>
                   </ItemTemplate>
                   </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="" HeaderText="Delete" >
                <ItemTemplate>
                   <asp:LinkButton ID="lbdel" runat="server" CssClass="body" 
                       CommandArgument='<%# Eval("Sno")+";"+ Eval("ThumbNailImage")+ ";"+ Eval("PdfName")%>' OnClientClick="javascript:return confirmDelete();" Font-Underline="false" CommandName="deleterow" Text="Delete" OnClick="Button_Click">Delete</asp:LinkButton>
                   </ItemTemplate>
                   </asp:TemplateField> 
                    <asp:TemplateField AccessibleHeaderText="" HeaderText="View" ItemStyle-Width="75px" >
                   <ItemTemplate>                  

        <a target="_blank" href='<%# bindUrl(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "Department"))) %>'>Live View</a>

                   </ItemTemplate>
                   </asp:TemplateField>
            </Columns>
        </asp:GridView></div>
        <div style="padding-top:25px"></div>
        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <asp:Button ID="btnAdd" runat="server" CssClass="md-btn md-btn-small md-btn-flat md-btn-success" Text=" Add Faculty " OnClick="btnAdd_Click" />
                                               
                                               
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

