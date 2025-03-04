<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="AddSlider.aspx.cs" Inherits="admin_account_Slider_AddSlider" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Home Page Slider <small>(Page Content)</small> </h1>
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
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small" id="dvEventImage" style="display:none" runat="server" clientidmode="static">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                    <label>Slider Image</label>
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
                                                <div class="md-input-wrapper" id="dvTitle" runat="server" style="padding-top:9px">
                                                    <label>Slider Text 1 </label>                                                    
                                                    <asp:TextBox ID="txtSliderText1" autocomplete="off"
                                                          runat="server" CssClass="md-input"></asp:TextBox>                                                    
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                          <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="Div1" runat="server" style="padding-top:22px">
                                                    <label>Slider Text 2 </label>                                                    
                                                    <asp:TextBox ID="txtSliderText2" autocomplete="off"
                                                          runat="server" CssClass="md-input"></asp:TextBox>                                                    
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>                      

                                        
                                       <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" style="padding-top:9px">
                                                <label style="position:static">Slider Image (1366 * 650 px)</label>
                                                    <asp:FileUpload ID="flSliderImage" runat="server"  CssClass="ajax__fileupload" ClientIDMode="Static" onchange="showMyImage(this)"  />
                                                   <asp:HiddenField ID="hiddenSliderImage" runat="server" />
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please choose slider image" Display="None" ControlToValidate="flSliderImage"  ValidationGroup="val"></asp:RequiredFieldValidator>                    
                         <asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ErrorMessage="Images must be of type jpeg or gif or png!" Display="None" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif|.jpeg|.JPG)$" ValidationGroup="val" ControlToValidate="flSliderImage" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" id="dvProjectLink" runat="server" style="padding-top:9px">
                                                    <div class="">
                                                        <span> Url</span>
                                                        <asp:TextBox ID="txtLinkUrl" autocomplete="off"
                                                          runat="server" CssClass="md-input"></asp:TextBox>                                                    
                                                  </div>
                                                    </div>
                                   
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper md-input-filled" id="dvDisplayOrder" runat="server" style="padding-top:9px">
                                                    <label>Display Order</label>
                                                     <asp:TextBox ID="txtDisplayOrder" runat="server" CssClass="md-input"></asp:TextBox>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtDisplayOrder"
ErrorMessage="Please Enter Only Numbers" Display="None" ValidationExpression="^\d+$" ValidationGroup="val"></asp:RegularExpressionValidator>
                                                    <asp:HiddenField ID="hdnDisplayOrder" runat="server" />
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
            $('#flSliderImage').val("");
        }); 
</script>
</asp:Content>

