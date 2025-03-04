<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="addfaculty.aspx.cs" Inherits="admin_account_faculty_addfaculty" ValidateRequest="false" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Faculty
    </h1>
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
                                      
                                        <div class="uk-grid uk-grid-small" id="dvoldImage" style="display:none" runat="server" clientidmode="static">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                                            
                                                    <img id="imgoldImage" runat="server" clientidmode="static" src="" alt="image"/>
                                                    
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small" id="dvEventImage" style="display:none" runat="server" clientidmode="static">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                    <label>Image</label>
                                                    <br />
                                                    
                                                    <br />
                                                     <span class="remove" id="spRemove">Remove image</span>
                                                    <br />
                                                    <img id="imgEventImage" runat="server" clientidmode="static" src="" alt="image"/>
                                                    
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>


                                        <hr class="uk-grid-divider uk-hidden-large">
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" style="padding-top:9px">
                                                <label style="position:static"> </label>
                                                    
                                                   
                                                    <br />  
                                                    <br />  
                                                  <%--  <span id="removepdf1" style="cursor:pointer;border: 1px solid black;display:none;width:150px;text-align: center;">Remove PDF1</span>--%>
                                                    
                                                
                                                     
                                                 <%--<asp:Label ID="lblPDF1" runat="server"></asp:Label>--%>
                                                </div>
                                            </div>
                                        </div>
                                        
                                       
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" style="padding-top:9px">
                                                    
                                               <asp:PlaceHolder ID="phpdf1" runat="server"></asp:PlaceHolder>  
                                                   
                                                </div>
                                            </div>
                                        </div>
                                    </div>


                                    <!--Right Side Contents-->
                                    <div class="uk-width-large-1-3">
                                    <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                 <label>Name *</label>
                                                <div class="md-input-wrapper" id="dvTitle" runat="server" style="padding-top:9px">
                                                   
                                                    <asp:TextBox ID="txtName"  runat="server" CssClass="md-input" style="border-width:2px 2px 2px;"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter name" Display="None" ControlToValidate="txtName"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="Div2" runat="server" style="padding-top:12px">
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="select-list">
                                                        <asp:ListItem Value="Select Department">Select Department</asp:ListItem>
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
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please select department"
                                                        Display="None" ControlToValidate="ddlDepartment" InitialValue="Select Department"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                         
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                  <label>Designation *</label>
                                                <div class="md-input-wrapper" id="dvHeaderTitle" runat="server" style="padding-top:12px">
                                                  
                                                    <asp:TextBox ID="txtDesignation" runat="server" MaxLength="250"  CssClass="md-input" style="border-width:2px 2px 2px;"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter designation" Display="None" ControlToValidate="txtDesignation"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        
                                       <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" style="padding-top:12px">
                                                <label style="position:static">ThumbNail Image: (70 * 83 )</label>
                                                    <asp:FileUpload ID="flEventImage" runat="server" ClientIDMode="Static"  CssClass="ajax__fileupload" onchange="showCoverImage(this)" />
                                                  <asp:HiddenField ID="hiddenEventImage" runat="server" />
                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please choose image"
                                  Display="None" ControlToValidate="flEventImage"  ValidationGroup="val"></asp:RequiredFieldValidator>                    
                         <asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" 
                             ErrorMessage="Images must be of type jpeg or gif or png!" Display="None" 
                             ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif|.jpeg|.JPEG |.JPG)$" ValidationGroup="val"
                             ControlToValidate="flEventImage" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" style="padding-top:12px">
                                                <label style="position:static">PDF: (MAX 1Mb)</label>
                                                     <asp:FileUpload ID="flPDF1" ClientIDMode="Static" onchange="showpdf(this)"  runat="server" />
                                                  <asp:HiddenField ID="hlPDF1" runat="server" />                                                                  
                         <asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" 
                             ErrorMessage="Please upload pdf file" Display="None" 
                             ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.pdf|.PDF|)$" ValidationGroup="val"
                             ControlToValidate="flPDF1" />
                                                </div>
                                            </div>
                                        </div>
                                        
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper md-input-filled" id="dvDisplayOrder" runat="server" style="padding-top:9px">
                                                    <label>Display Order</label>
                                                     <asp:TextBox ID="txtDisplayOrder" runat="server" CssClass="md-input"></asp:TextBox>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator21" runat="server" ControlToValidate="txtDisplayOrder"
ErrorMessage="Please Enter Only Numbers" Display="None" ValidationExpression="^\d+$" ValidationGroup="val"></asp:RegularExpressionValidator>
                                                    <asp:HiddenField ID="hdnDisplayOrder" runat="server" />
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-medium-3-3">
                                            <asp:CheckBox ID="chkIshod" runat="server" Text="HOD" data-switchery="false" Checked="false" />
                                                <%--<input type="checkbox" data-switchery="false" id="chkStatus" runat="server" style="display: none;" checked="checked" />--%>
                                                
                                                <br />
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
     <script type="text/javascript">
      
        //        $(function () {
        
        function showCoverImage(fileInput) {
            
            var files = fileInput.files;
            for (var i = 0; i < files.length; i++) {
                var file = files[i];
                var size = parseFloat(files[i].size / 1024).toFixed(2);
                var r = 1;// (size / 1024).toFixed(2);
                if (r >= 2) {
                    alert("File size is too high , please select image lesser than 2 MB");
                    var hdn = $('#hiddenEventImage').val();
                    if (hdn == "undefined") {
                        document.getElementById("dvEventImage").style.display = "none";
                         document.getElementById("spRemove").style.display = "none";
                    }
                    else {
                        document.getElementById("dvEventImage").style.display = "block";
                         document.getElementById("spRemove").style.display = "block";
                    }


                }
                else {
                    document.getElementById("dvEventImage").style.display = "block";
                     document.getElementById("spRemove").style.display = "block";
                    var imageType = /image.*/;
                    if (!file.type.match(imageType)) {
                        continue;
                    }
                    var img = document.getElementById("imgEventImage");
                    img.file = file;
                    var reader = new FileReader();
                    reader.onload = (function (aImg) {
                        return function (e) {
                            aImg.src = e.target.result;
                        };
                    })(img);
                    reader.readAsDataURL(file);
                }
            }
        }
        $(".remove").click(function () {
            document.getElementById("dvEventImage").style.display = "none";
             document.getElementById("spRemove").style.display = "none";
            $('#imgEventImage').attr('src', '');      
            $('#flEventImage').val("");
        });  
        
         $("#removepdf1").click(function () {     
             $('#flPDF1').val("");
              document.getElementById("removepdf1").style.display = "none";
        }); 
       
        function showpdf(fileInput) {
            var files = fileInput.files;
            if (files.length > 0) {
                document.getElementById("removepdf1").style.display = "block";
            }
        }
        
    </script>
</asp:Content>



