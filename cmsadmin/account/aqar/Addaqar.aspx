<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="Addaqar.aspx.cs" Inherits="admin_account_Slider_AddSlider" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>AQAR <small>(Page Content)</small> </h1>
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
                                                                            
                                                    <img id="imgSliderImage" runat="server" clientidmode="static" src="" alt="image"/>
                                                    
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
                                                <div class="md-input-wrapper" id="dvCriteria" runat="server" style="padding-top:9px">
                                                    
                                                    <label>Criteria *</label>
                                                    <br />
                                                    <br />
                                                   <asp:DropDownList ID="ddlCriteria" runat="server" CssClass="select-list" AutoPostBack="true" OnSelectedIndexChanged="ddlCriteria_SelectedIndexChanged">
                                                            <asp:ListItem Value="Select Criteria">Select Criteria</asp:ListItem>
                                                        <asp:ListItem Value="1">1</asp:ListItem>
                                                        <asp:ListItem Value="2">2</asp:ListItem>
                                                         <asp:ListItem Value="3">3</asp:ListItem>
                                                        <asp:ListItem Value="4">4</asp:ListItem> 
                                                        <asp:ListItem Value="5">5</asp:ListItem>
                                                        <asp:ListItem Value="6">6</asp:ListItem>
                                                        <asp:ListItem Value="7">7</asp:ListItem>
                                                        <asp:ListItem Value="8">8</asp:ListItem>
                                                        <asp:ListItem Value="9">9</asp:ListItem>
                                                        <asp:ListItem Value="10">10</asp:ListItem>
                                                        </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please select criteria"
                                                        Display="None" ControlToValidate="ddlCriteria" InitialValue="Select Criteria"  ValidationGroup="val"></asp:RequiredFieldValidator>                                               
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                          <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="true">
                                                          <ContentTemplate>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvMetric" runat="server" style="padding-top:12px">
                                                 
                                                    <label  style="top:10px">Metric *</label>
                                                     <br />
                                                    <asp:DropDownList ID="ddlMetricNo" runat="server" CssClass="select-list" AutoPostBack="true" OnSelectedIndexChanged="ddlMetricNo_SelectedIndexChanged">
                                                        <asp:ListItem Value="Select Metric">Select Metric</asp:ListItem>
                                                        </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please select metric no"
                                                        Display="None" ControlToValidate="ddlMetricNo" InitialValue="Select Metric"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                                              </ContentTemplate>
                              <Triggers>
       
          <asp:AsyncPostBackTrigger ControlID="ddlCriteria" EventName="SelectedIndexChanged" />
                    
      </Triggers>
                             </asp:UpdatePanel>                      
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server" ChildrenAsTriggers="true">
                                                          <ContentTemplate>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                               
                                                <div class="md-input-wrapper" id="dvSubMetric" runat="server" style="padding-top:12px">
                                                 
                                                    <label style="top:10px">Sub Metric *</label>
                                                   <br />
                                                    
                                                    <asp:DropDownList ID="ddlSubMetric" runat="server" CssClass="select-list"  AutoPostBack="true" OnSelectedIndexChanged="ddlSubMetric_SelectedIndexChanged">
                                                        <asp:ListItem Value="Select Metric">Select Sub Metric</asp:ListItem>
                                                        </asp:DropDownList>
                                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please select sub metric no"
                                                        Display="None" ControlToValidate="ddlSubMetric" InitialValue="Select Metric"  ValidationGroup="val"></asp:RequiredFieldValidator>--%>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                                              </ContentTemplate>
                              <Triggers>
       
          <asp:AsyncPostBackTrigger ControlID="ddlCriteria" EventName="SelectedIndexChanged" />
               <asp:AsyncPostBackTrigger ControlID="ddlMetricNo" EventName="SelectedIndexChanged" />       
      </Triggers>
                             </asp:UpdatePanel>
                                      <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvType" runat="server" style="padding-top:12px">
                                                  
                                                    <label style="top:10px">File Type *</label>
                                                    <br />
                                                    <asp:DropDownList ID="ddlType" runat="server" CssClass="select-list" >
                                                            <asp:ListItem Value="Select Type">Select Type</asp:ListItem>
                                                        <asp:ListItem Value="Image">Image</asp:ListItem>
                                                        <asp:ListItem Value="PDF">PDF</asp:ListItem>
                                                         <asp:ListItem Value="Video">Video</asp:ListItem>
                                                        </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please select type"
                                                        Display="None" ControlToValidate="ddlType" InitialValue="Select Type"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>  
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvTitle" runat="server" style="padding-top:12px">
                                                    
                                                    <label style="top:10px">Title *</label>
                                                    <br />
                                                
                                                     <asp:TextBox ID="txtTitle" runat="server" CssClass="md-input" style="border-width:2px 2px 2px;"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter title" Display="None" ControlToValidate="txtTitle" ValidationGroup="val">
                                                     </asp:RequiredFieldValidator>
                                                   
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                       <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvUplodFile" runat="server" style="padding-top:9px">
                                                 <br />
                                                    <label style="position:static">Upload File *</label>
                                                     <br />
                                                    <asp:FileUpload ID="flFile" runat="server"  CssClass="ajax__fileupload" ClientIDMode="Static" onchange="showMyImage(this)"  />
                                                   <asp:HiddenField ID="hiddenFile" runat="server" />
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please choose file" Display="None" ControlToValidate="flFile"  ValidationGroup="val"></asp:RequiredFieldValidator>                    
                      <%--   <asp:RegularExpressionValidator id="rvImage" runat="server" ErrorMessage="Images must be of type jpeg or gif or png!" Display="None" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif|.jpeg|.JPG)$" ValidationGroup="val" ControlToValidate="flFile" />
                                                    <asp:RegularExpressionValidator id="rvPdf" runat="server" ErrorMessage="File must be of type pdf" Display="None" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.pdf|.PDF)$" ValidationGroup="val" ControlToValidate="flFile" />
                                                    <asp:RegularExpressionValidator id="rvVideo" runat="server" ErrorMessage="Video file must be of type mp4!" Display="None" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.mp4|.MP4)$" ValidationGroup="val" ControlToValidate="flFile" />--%>
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
                                                     <br />
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
       <asp:AsyncPostBackTrigger ControlID="ddlSubMetric" EventName="SelectedIndexChanged" />
          <asp:AsyncPostBackTrigger ControlID="ddlMetricNo" EventName="SelectedIndexChanged" />
          
      </Triggers>
                             </asp:UpdatePanel>
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
                          if (r >= 25) {
                              alert("File size is too high , please select image lesser 20 MB");
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

