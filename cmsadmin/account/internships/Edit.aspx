<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="admin_account_Slider_AddSlider" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Internships <small>(Page Content)</small> </h1>
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
                                         
                                        <hr class="uk-grid-divider uk-hidden-large">
                                    </div>


                                    <!--Right Side Contents-->
                                    <div class="uk-width-large-1-3">
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
                                                    
                                                    <label style="top:10px">Mobile No </label>
                                                    <br />
                                                
                                                     <asp:TextBox ID="txtMobileNo" runat="server" CssClass="md-input" maxlength="10"
                                                   
                                                 autocomplete="off"></asp:TextBox>
                                         <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                                                    ValidationGroup="val" Display="Dynamic"
                                                    ControlToValidate="txtMobileNo" ErrorMessage="Enter your mobile number">
                                                </asp:RequiredFieldValidator>--%>
                                            
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                       <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvCompanyName" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Company Name *</label>
                                                    <br />
                                                
                                                     <asp:TextBox ID="txtCompanyName" runat="server" CssClass="md-input"
                                                 autocomplete="off"></asp:TextBox>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                                    ValidationGroup="val" Display="Dynamic" ControlToValidate="txtCompanyName"
                                                    ErrorMessage="Enter your company name"></asp:RequiredFieldValidator>
                                            
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvCompanyEmailId" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Company Email ID *</label>
                                                    <br />
                                                
                                                     <asp:TextBox ID="txtCompanyEmailId" runat="server" CssClass="md-input"
                                                 autocomplete="off"></asp:TextBox>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                                                    ValidationGroup="val" Display="Dynamic"
                                                    ControlToValidate="txtCompanyEmailId" ErrorMessage="Enter your company Email Id">
                                                </asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                                                    runat="server" ValidationGroup="val" Display="Dynamic"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                                    ControlToValidate="txtCompanyEmailId"
                                                    ErrorMessage="Please Enter Valid company Email Id">
                                                </asp:RegularExpressionValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvCompanyMobile" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Company Contact No </label>
                                                    <br />
                                                
                                                     <asp:TextBox ID="txtCompanyContactNo" runat="server" CssClass="md-input" maxlength="10"
                                                autocomplete="off"></asp:TextBox>
                                           <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                                                    ValidationGroup="val" Display="Dynamic"
                                                    ControlToValidate="txtCompanyContactNo" ErrorMessage="Enter your Company Contact No">
                                                </asp:RequiredFieldValidator>--%>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvDuration" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Designation *</label>
                                                    <br />
                                                
                                                   <asp:TextBox ID="txtDuration" runat="server" CssClass="md-input"
                                                 autocomplete="off"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                                                    ValidationGroup="val" Display="Dynamic" ControlToValidate="txtDuration"
                                                    ErrorMessage="Enter the duration"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                         <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvDeliverables" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Job Details *</label>
                                                    <br />
                                                
                                                   <asp:TextBox ID="txtDeliverables" runat="server" CssClass="md-input" TextMode="MultiLine"
                                                 autocomplete="off"></asp:TextBox>
                                              <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"
                                                    ValidationGroup="val" Display="Dynamic" ControlToValidate="txtDeliverables"
                                                    ErrorMessage="Enter the deliverables"></asp:RequiredFieldValidator>
                                              
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
                      if (r >= 10) {
                          alert("File size is too high , please select image lesser than 6 MB");
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
                  else {
                      var videoallowedExtensions = /(\.mp4)$/i;
                      var pdfallowedExtensions = /(\.pdf)$/i;
                      if (videoallowedExtensions.exec(filePath) || pdfallowedExtensions.exec(filePath)) {
                          var r = (size / 1024).toFixed(2);
                          if (r >= 10) {
                              alert("File size is too high , please select image lesser than 6 MB");
                          }
                      }
                  }
              }
          }
        
        $(".remove").click(function () {
            document.getElementById("dvEventImage").style.display = "none";
             document.getElementById("spRemove").style.display = "none";
            $('#imgEventImage').attr('src', '');      
            $('#flFile').val("");
        }); 
</script>
</asp:Content>

