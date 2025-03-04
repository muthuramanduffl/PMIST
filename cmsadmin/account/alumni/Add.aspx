<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="admin_account_Slider_AddSlider" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Alumni <small>(Page Content)</small> </h1>
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
                                                            <asp:HiddenField ID="hiddenFile" runat="server" />                 
                                                    
                                                    <span class="md-input-bar"></span>
                                                </div>
                                                <asp:PlaceHolder ID="phType" runat="server"></asp:PlaceHolder>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small" id="dvEventImage" style="display:none" runat="server" clientidmode="static">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                    <label><asp:Label ID="lblText" runat="server"></asp:Label></label>
                                                    <br />
                                                    
                                                    <br />
                                                     <span class="remove" id="spRemove">Remove image</span>
                                                    <br />
                                                    <img id="imgEventImage" runat="server" clientidmode="static" src="" alt="image"/>
                                                    
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                         <div class="uk-grid uk-grid-small" id="dvIDCard" style="display:none" runat="server" clientidmode="static">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                     <asp:PlaceHolder ID="phpdf" runat="server"></asp:PlaceHolder> 
                                                </div>
                                            </div>
                                        </div>
                                        <hr class="uk-grid-divider uk-hidden-large">
                                    </div>


                                    <!--Right Side Contents-->
                                    <div class="uk-width-large-1-3">
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvRegistration" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Registration No </label>
                                                    <br />
                                                <asp:TextBox ID="txtRegistrationNo" runat="server" CssClass="md-input"
                                                 autocomplete="off"></asp:TextBox>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                    <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvName" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Name *</label>
                                                    <br />
                                                <asp:TextBox ID="txtName" runat="server" CssClass="md-input"
                                                 autocomplete="off"></asp:TextBox>
                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                                    ValidationGroup="val" Display="Dynamic" ControlToValidate="txtName"
                                                    ErrorMessage="Enter name"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="regv" runat="server"
                                                    ControlToValidate="txtName" ValidationGroup="val"
                                                    ValidationExpression="^[a-zA-Z'.\s]{3,54}"
                                                    ErrorMessage="Enter valid name" Display="Dynamic">
                                                </asp:RegularExpressionValidator>
                                                   
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dVEmailId" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Email ID *</label>
                                                    <br />
                                              <asp:TextBox ID="txtEmailId" runat="server" CssClass="md-input"
                                                autocomplete="off"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                                    ValidationGroup="val" Display="Dynamic"
                                                    ControlToValidate="txtEmailId" ErrorMessage="Enter your Email Id">
                                                </asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                                                    runat="server" ValidationGroup="val" Display="Dynamic"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                                    ControlToValidate="txtEmailId"
                                                    ErrorMessage="Please Enter Valid Email Id">
                                                </asp:RegularExpressionValidator>
                                                   
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                         <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvMobile" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Mobile No *</label>
                                                    <br />
                                                
                                                     <asp:TextBox ID="txtMobileNo" runat="server" CssClass="md-input"
                                                 autocomplete="off"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                                                    ValidationGroup="val" Display="Dynamic"
                                                    ControlToValidate="txtMobileNo" ErrorMessage="Enter your mobile number">
                                                </asp:RequiredFieldValidator>
                                            
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                       <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvBatch" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Batch *</label>
                                                    <br />
                                                
                                                     <asp:TextBox ID="txtBatch" runat="server" CssClass="md-input"
                                                 autocomplete="off"></asp:TextBox>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                                    ValidationGroup="val" Display="Dynamic" ControlToValidate="txtBatch"
                                                    ErrorMessage="Enter your Batch"></asp:RequiredFieldValidator>
                                            
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvDepartment" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Department *</label>
                                                    <br />
                                                
                                                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="select-list">
                                                   <asp:ListItem Value="Select Department">Select Department</asp:ListItem>
                                                   <asp:ListItem value="Department of Architecture">Department of Architecture</asp:ListItem>
                                                <asp:ListItem value="Department of Aerospace Engineering">Department of Aerospace Engineering</asp:ListItem>
                                                <asp:ListItem value="Department of Bio-Technology">Department of Bio-Technology</asp:ListItem>
                                                <asp:ListItem value="Department of Chemical Engineering">Department of Chemical Engineering</asp:ListItem>
                                                <asp:ListItem value="Department of Civil Engineering">Department of Civil Engineering</asp:ListItem>
                                                <asp:ListItem value="Department of Electronics and Communication Engineering">Department of Electronics and Communication Engineering</asp:ListItem>
                                                <asp:ListItem value="Department of Electrical and Electronics Engineering">Department of Electrical and Electronics Engineering</asp:ListItem>
                                               <asp:ListItem value="Department of Mechanical Engineering">Department of Mechanical Engineering</asp:ListItem>
                                               <asp:ListItem value="Division of Nanotechnology">Division of Nanotechnology</asp:ListItem>
                                               <asp:ListItem value="Department of Computer Science and Engineering">Department of Computer Science and Engineering</asp:ListItem>
                                               <asp:ListItem value="Department of Computer Science &amp; Application">Department of Computer Science &amp; Application</asp:ListItem>
                                               <asp:ListItem value="Department of Software Engineering">Department of Software Engineering</asp:ListItem>
                                               <asp:ListItem value="Department of Chemistry">Department of Chemistry</asp:ListItem>
                                               <asp:ListItem value="Department of Commerce">Department of Commerce</asp:ListItem>
                                               <asp:ListItem value="Department of English">Department of English</asp:ListItem>
                                               <asp:ListItem value="Department of Education">Department of Education</asp:ListItem>
                                               <asp:ListItem value="Department of Mathematics">Department of Mathematics</asp:ListItem>
                                               <asp:ListItem value="Department of Management Studies">Department of Management Studies</asp:ListItem>
                                               <asp:ListItem value="Department of Physics">Department of Physics</asp:ListItem>
                                               <asp:ListItem value="Department of Political Science">Department of Political Science</asp:ListItem>
                                               <asp:ListItem value="Department of Social Work">Department of Social Work</asp:ListItem>
                                               <asp:ListItem value="Department of MBA">Department of MBA</asp:ListItem>
                                               </asp:DropDownList>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                                                    ValidationGroup="val" Display="Dynamic"
                                                  ControlToValidate="ddlDepartment" InitialValue="Select Department" ErrorMessage="Select Department">
                                                </asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvCurrentStatus" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Current Status *</label>
                                                    <br />
                                                
                                                 <asp:DropDownList ID="ddlCurrentStatus" runat="server" CssClass="select-list" ClientIDMode="Static">
                                                      <asp:ListItem value="Select Current Status">Select Current Status</asp:ListItem>
                                                     <asp:ListItem value="Job">Job</asp:ListItem>
                                               <asp:ListItem value="HigherStudies">Higher Studies</asp:ListItem>
                                               <asp:ListItem value="Entrpreneur">Enterpreneur</asp:ListItem>
                                               <asp:ListItem value="JobSeeking">Job Seeking</asp:ListItem>
                                               <asp:ListItem value="HomeMaker">Home Maker</asp:ListItem>
                                               </asp:DropDownList>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                                                    ValidationGroup="val" Display="Dynamic"
                                                    ControlToValidate="ddlCurrentStatus" InitialValue="Select Current Status"
                                              ErrorMessage="Select your current status">
                                                </asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>

                                        </div>
                                     
                                        <div class="Job box" id="dvJob" runat="server" style="display:none">
                                            <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvJobDesignation" runat="server" style="padding-top:12px">
                                              
                                                      <label style="top:10px">Designation</label>
                                                   
                                                       <asp:TextBox ID="txtJobDesignation" runat="server" CssClass="md-input" 
                                                autocomplete="off"></asp:TextBox>
                                                      <span class="md-input-bar"></span>
                                                </div>
                                                 </div>
                                                </div>
                                            <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvJobCompanyName" runat="server" style="padding-top:12px">
                                               
                                                      <label style="top:10px">Company Name</label>
                                                     <asp:TextBox ID="txtJobCompanyName" runat="server" CssClass="md-input"
                                                autocomplete="off"></asp:TextBox>
                                                      <span class="md-input-bar"></span>
                                                </div>
                                                 </div>
                                                </div>
                                             <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvJobPlace" runat="server" style="padding-top:12px">
                                               
                                                      <label style="top:10px">Place</label>
                                                     <asp:TextBox ID="txtJobPlace" runat="server" CssClass="md-input"
                                                autocomplete="off"></asp:TextBox>
                                                      <span class="md-input-bar"></span>
                                                </div>
                                                 </div>
                                                </div>
                                            <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvJobUpload" runat="server" style="padding-top:12px">
                                               
                                                      <label style="top:10px">Upload (Max 4 MB)</label>
                                                        <br />
                                                      <asp:HiddenField ID="hdnJobUpload" runat="server" />
                                                     <asp:FileUpload id ="flJobUpload" runat="server" ClientIDMode="Static"  CssClass="ajax__fileupload" onchange="return fileJobValidation()" />     
                                               <span class="md-input-bar"></span>
                                                    </div>
                                                 </div>
                                                </div>
                                            </div>   
                                             
                                        <div class="HigherStudies box" id="dvHigherStudies" runat="server" style="display:none">
                                           <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvDegree" runat="server" style="padding-top:12px">
                                               
                                                      <label style="top:10px">Degree</label>
                                                     <asp:TextBox ID="txtDegree" runat="server" CssClass="md-input" 
                                                autocomplete="off"></asp:TextBox>
                                                  </div>
                                                 </div>
                                                </div>
                                                  <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvCourse" runat="server" style="padding-top:12px">
                                               
                                                      <label style="top:10px">Course of Study</label>
                                                      <asp:TextBox ID="txtCourse" runat="server" CssClass="md-input" 
                                                autocomplete="off"></asp:TextBox>
                                                    </div>
                                                 </div>
                                                </div>
                                                <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvInstituteName" runat="server" style="padding-top:12px">
                                               
                                                      <label style="top:10px">Institute Name</label>
                                                       <asp:TextBox ID="txtInstituteName" runat="server" CssClass="md-input" 
                                                autocomplete="off"></asp:TextBox>
                                                  </div>
                                                 </div>
                                                </div>
                                                     <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvPlace" runat="server" style="padding-top:12px">
                                               
                                                      <label style="top:10px">Place</label>
                                                     <asp:TextBox ID="txtPlace" runat="server" CssClass="md-input" 
                                                autocomplete="off"></asp:TextBox>
                                                  </div>
                                                 </div>
                                                </div>
                                              <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvDegreeUpload" runat="server" style="padding-top:12px">
                                                      <label style="top:10px">Upload (Max 4 MB)</label>
                                                        <br />
                                                 <asp:HiddenField ID="hdnDegree" runat="server" />
                                                           <asp:FileUpload id ="flDegree" runat="server" ClientIDMode="Static"  CssClass="ajax__fileupload" onchange="return fileDegreeValidation()" />          
                                                </div>
                                                 </div>
                                                 </div>
                                                </div>
                                          
                                        <div class="Entrpreneur box" id="dvEntrpreneur" runat="server" style="display:none">
                                           <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvEntrCompanyName" runat="server" style="padding-top:12px">
                                               
                                                      <label style="top:10px">Company Name</label>
                                                      <asp:TextBox ID="txtEntrCompanyName" runat="server" CssClass="md-input" 
                                                autocomplete="off"></asp:TextBox>
                                                   </div>
                                                 </div>
                                                </div>
                                                   <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvEntrDesignation" runat="server" style="padding-top:12px">
                                               
                                                      <label style="top:10px">Designation</label>
                                                       <asp:TextBox ID="txtEntrDesignation" runat="server" CssClass="md-input" 
                                                autocomplete="off"></asp:TextBox>
                                                  </div>
                                                 </div>
                                                </div>
                                                <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvEntrPlace" runat="server" style="padding-top:12px">
                                               
                                                      <label style="top:10px">Place</label>
                                                      <asp:TextBox ID="txtEntrPlace" runat="server" CssClass="md-input" 
                                                autocomplete="off"></asp:TextBox>
                                                  </div>
                                                 </div>
                                                </div>
                                                    <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvEntrfile" runat="server" style="padding-top:12px">
                                                <label style="top:10px">Upload (Max 4 MB)</label>
                                                        <br />
                                                           <asp:HiddenField ID="hdnEntr" runat="server" />
                                                           <asp:FileUpload id ="flEntrfile" runat="server" ClientIDMode="Static"  CssClass="ajax__fileupload" onchange="return fileEntrValidation()" />     
                                                      
                                                     </div>
                                                 </div>
                                                </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvPhoto" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Photo Upload (Max 4 MB) *</label>
                                                    <br />
                                                 <asp:HiddenField ID="hdnPhoto" runat="server" />
                                                  <asp:FileUpload id ="flPhoto" runat="server" ClientIDMode="Static"  CssClass="ajax__fileupload" onchange="return showMyImage(this)" />     
                                           <asp:RequiredFieldValidator ID="rvImage" runat="server" ErrorMessage="Please Upload image" Display="None" ControlToValidate="flPhoto"  ValidationGroup="val"></asp:RequiredFieldValidator>
                         <asp:RegularExpressionValidator id="Validator" runat="server" ErrorMessage="Images must be of type jpeg or gif or png!" Display="None" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.|jpeg|.gif)$" ValidationGroup="val" ControlToValidate="flPhoto" />
                         
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                         <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvTestimonial" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Testimonial Content *</label>
                                                    <br />
                                                
                                                   <asp:TextBox ID="txtTestimonial" runat="server" CssClass="md-input" TextMode="MultiLine"
                                                autocomplete="off"></asp:TextBox>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
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
          function showMyImage(fileInput) {
              var files = fileInput.files;
              for (var i = 0; i < files.length; i++) {
                  var file = files[i];
                  var size = parseFloat(files[i].size / 1024).toFixed(2);
                  var filePath = fileInput.value;
                  var blvideo = false;
                  var blpdf = false;
                  var allowedExtensions = /(\.jpg|\.jpeg|\.png|\.gif)$/i;
                 
                  if (allowedExtensions.exec(filePath)) {
                      var r = (size / 1024).toFixed(2);
                      if (r >= 4) {
                          alert("File size is too high , please select image lesser than 5 MB");
                          var hdn = $('#hiddenFile').val();
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
          }
        
        $(".remove").click(function () {
            document.getElementById("dvEventImage").style.display = "none";
             document.getElementById("spRemove").style.display = "none";
            $('#imgEventImage').attr('src', '');      
            $('#flPhoto').val("");
          }); 
            $("#ddlCurrentStatus").change(function(){
            var optionValue = $("#ddlCurrentStatus option:selected").val();
            if (optionValue == "Job") {
                $(".Job").show();
                $(".HigherStudies").hide();
                $(".Entrpreneur").hide();
            }
            else if (optionValue == "HigherStudies") {
                $(".Job").hide();
                $(".HigherStudies").show();
                $(".Entrpreneur").hide();
            }
            else if (optionValue == "Entrpreneur") {
                $(".Job").hide();
                $(".HigherStudies").hide();
                $(".Entrpreneur").show();
            }
        });
</script>
     <script> 
   
        function fileDegreeValidation() { 
            var fileInput =  
                document.getElementById('flDegree'); 
              
            var filePath = fileInput.value; 
          
            // Allowing file type 
            var allowedExtensions =  
                    /(\.pdf|\.PDF)$/i; 
              
            if (!allowedExtensions.exec(filePath)) { 
                // document.getElementById("lblResErr").innerText = "Please upload resume in doc or pdf format";
                alert('Please upload file in valid format');
                fileInput.value = ''; 
                return false; 
            }  
            else  
            { 
              var files = fileInput.files;
               var file = files[0];
                var size = parseFloat(files[0].size / 1024).toFixed(2);
                var r = (size / 1024).toFixed(2);
                if (r >= 4) {
                    alert("File size is too high , please select file lesser than 5 MB");
                    document.getElementById("flDegree").value = null;
                   return false; 
                }
                else {
                    return false; 
                    
                }
            } 
        } 
         function fileEntrValidation() { 
            var fileInput =  
                document.getElementById('flEntrfile'); 
              
            var filePath = fileInput.value; 
          
            // Allowing file type 
            var allowedExtensions =  
                    /(\.pdf|\.PDF)$/i; 
              
            if (!allowedExtensions.exec(filePath)) { 
                // document.getElementById("lblResErr").innerText = "Please upload resume in doc or pdf format";
                alert('Please upload file in valid format');
                fileInput.value = ''; 
                return false; 
            }  
            else  
            { 
              var files = fileInput.files;
               var file = files[0];
                var size = parseFloat(files[0].size / 1024).toFixed(2);
                var r = (size / 1024).toFixed(2);
                if (r >= 4) {
                    alert("File size is too high , please select file lesser than 5 MB");
                    document.getElementById("flEntrfile").value = null;
                   return false; 
                }
                else {
                    return false; 
                    
                }
            } 
        } 
         function fileJobValidation() { 
            var fileInput =  
                document.getElementById('flJobUpload'); 
              
            var filePath = fileInput.value; 
          
            // Allowing file type 
            var allowedExtensions =  
                    /(\.pdf|\.PDF|\.DOC|\.doc|\.DOCX|\.docx)$/i; 
              
            if (!allowedExtensions.exec(filePath)) { 
                // document.getElementById("lblResErr").innerText = "Please upload resume in doc or pdf format";
                alert('Please upload file in valid format');
                fileInput.value = ''; 
                return false; 
            }  
            else  
            { 
              var files = fileInput.files;
               var file = files[0];
                var size = parseFloat(files[0].size / 1024).toFixed(2);
                var r = (size / 1024).toFixed(2);
                if (r >= 4) {
                    alert("File size is too high , please select file lesser than 5 MB");
                    document.getElementById("flJobUpload").value = null;
                   return false; 
                }
                else {
                    return false; 
                    
                }
            } 
        } 
    </script>
</asp:Content>

