<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="AddAlbum.aspx.cs" Inherits="admin_account_gallery_AddAlbum" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1><asp:Label ID="lblSchoolName" runat="server"></asp:Label> Album </h1>
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
                                                <div class="md-input-wrapper">
                                                    <asp:PlaceHolder ID="PhImg" runat="server"></asp:PlaceHolder>
                                                    <div class="md-input-wrapper md-input-filled" style="">
                                                        <asp:Label ID="lblcheck" runat="server"></asp:Label>
                                                        <div class="table-responsive">
                                                            <asp:GridView ID="grvAlbum" runat="server" DataKeyNames="AlbumId" AllowPaging="True" AutoGenerateColumns="False"
                                                                CellPadding="4" PagerSettings-Mode="NumericFirstLast" GridLines="None"
                                                                OnRowCancelingEdit="grvAlbum_RowCancelingEdit"
                                                                OnRowEditing="grvAlbum_RowEditing"
                                                                OnRowUpdating="grvAlbum_RowUpdating"
                                                                PageSize="10" OnPageIndexChanging="OnPaging" OnRowDataBound="gv_RowDataBound">
                                                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" Width="720px" />
                                                                <EditRowStyle BackColor="#F7F6F3" />
                                                                <FooterStyle BackColor="#a59c85" Font-Bold="True" ForeColor="White" />
                                                                <HeaderStyle BackColor="#004a8f" Font-Bold="True" ForeColor="White" Font-Size="13px" />
                                                                <PagerStyle BackColor="White" ForeColor="#00000" HorizontalAlign="Center" />
                                                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" Font-Size="13px" />
                                                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />

                                                                <Columns>

                                                                    <asp:TemplateField AccessibleHeaderText="Album Name" HeaderText="Album Name">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lblAlbumName" runat="server" Text='<%# Eval("AlbumName")%>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:HiddenField ID="hiddenAlbumName" runat="server" Value='<%#Eval("AlbumName") %>' />
                                                                            <asp:HiddenField ID="hiddenStatus" runat="server" Value='<%#Eval("Status") %>' />
                                                                            <asp:TextBox ID="txtEditAlbumName" MaxLength="150" Width="100px" runat="server" Text='<%#Eval("AlbumName") %>' />

                                                                        </EditItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField AccessibleHeaderText="Department" HeaderText="Department">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lblDepartment" runat="server" Text='<%# Eval("Department")%>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:DropDownList ID="ddlUpdateDepartment" runat="server" CssClass="select-list">
                                                                                <asp:ListItem Value="General">General</asp:ListItem>
                                                                                <asp:ListItem Value="PMIST">PMIST</asp:ListItem>
                                                                                <asp:ListItem Value="Centre for Institute Industry Interactions">Centre for Institute Industry Interactions</asp:ListItem>
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
                                                                        </EditItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Status">
                                                                        <ItemTemplate>
                                                                            <asp:ImageButton ID="Archiveimg" ImageUrl='<%# bindImage( System.Convert.ToInt16(DataBinder.Eval(Container.DataItem, "Status"))) %>' CommandArgument='<%# Eval("AlbumID")%>' OnClick="Statusimg_click" runat="server"></asp:ImageButton>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Created On">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lblDateTime" runat="server" Text='<%# bindDate( System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "CreatedDate"))) %>'></asp:Label>
                                                                        </ItemTemplate>

                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Created By">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lblPostedBy" runat="server" Text='<%# Eval("CreatedBy")%>'></asp:Label>
                                                                        </ItemTemplate>

                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Updated On">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lblUpdatedDateTime" runat="server" Text='<%# bindDate( System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "UpdatedDate"))) %>'></asp:Label>
                                                                        </ItemTemplate>

                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField AccessibleHeaderText="Name" HeaderText="Updated By">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="lblUpdatedBy" runat="server" Text='<%# Eval("UodatedBy")%>'></asp:Label>
                                                                        </ItemTemplate>

                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Edit">
                                                                        <ItemTemplate>
                                                                            <asp:Button ID="btn_Edit" CssClass="body" runat="server" Text="Edit" CommandName="Edit" />

                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:TemplateField AccessibleHeaderText="Archive" HeaderText="Edit">
                                                                                <itemtemplate>
                                                                                    <asp:LinkButton ID="lnkUpdatee" runat="server"
                                                                                        CommandName="Update"
                                                                                        Text="Update">
                                                                                    </asp:LinkButton>
                                                                                    <asp:LinkButton ID="lnkCancel" runat="server"
                                                                                        CommandName="Cancel"
                                                                                        Text="Cancel">
                                                                                    </asp:LinkButton>
                                                                        </EditItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField AccessibleHeaderText="" HeaderText="Delete">
                                                                        <ItemTemplate>

                                                                            <asp:LinkButton ID="lbdel" runat="server" CssClass="body" CommandArgument='<%# Eval("AlbumID") + "," + Eval("AlbumName")%>' OnClientClick="javascript:return confirmDelete();" Font-Underline="false" CommandName="deleterow" Text="Delete" OnClick="Button_Click">Delete</asp:LinkButton>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>

                                                                </Columns>
                                                            </asp:GridView>
                                                        </div>
                                                        <div style="padding-top: 25px"></div>
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
                                                <div class="md-input-wrapper" id="dvDepartment" runat="server" style="padding-top: 12px">
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="select-list">
                                                        <asp:ListItem Value="Select Department">Select Department</asp:ListItem>
                                                        <asp:ListItem Value="General">General</asp:ListItem>

                                                        <asp:ListItem Value="PMIST">PMIST</asp:ListItem>
                                                        <asp:ListItem Value="Centre for Institute Industry Interactions">Centre for Institute Industry Interactions</asp:ListItem>
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
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please select department"
                                                        Display="None" ControlToValidate="ddlDepartment" InitialValue="Select Department" ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <label>Album Name *</label>
                                                <div class="md-input-wrapper" id="dvAlbumName" runat="server" style="padding-top: 19px">

                                                    <asp:HiddenField ID="hiddenAlbum" runat="server" />
                                                    <asp:TextBox ID="txtAlbumName" MaxLength="150" runat="server" CssClass="md-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter Album Name" Display="None" ControlToValidate="txtAlbumName" ValidationGroup="val">
                                                    </asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" Display="None" SetFocusOnError="true" runat="server" ValidationGroup="val" ControlToValidate="txtAlbumName" ErrorMessage="Please enter a valid Album Name" ValidationExpression="^([a-zA-Z0-9-_\s]*)$">
                                                    </asp:RegularExpressionValidator>
                                                    <span class="md-input-bar"></span>
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
                                            <div class="uk-width-large-3-3" style="width: 1500px">
                                                <asp:Button ID="btnPublish" runat="server"
                                                    CssClass="md-btn md-btn-small md-btn-flat md-btn-primary" Text=" Save "
                                                    OnClick="btnPublish_Click" ValidationGroup="val" />
                                                <asp:Button ID="btnClear" runat="server"
                                                    CssClass="md-btn md-btn-small md-btn-flat md-btn-warning" Text=" Clear "
                                                    OnClick="btnClear_Click" />


                                            </div>
                                        </div>

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

