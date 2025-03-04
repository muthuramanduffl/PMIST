<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="addachievementcorner.aspx.cs" Inherits="admin_account_events_adddachievementcorner" ValidateRequest="false" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Achievement Corner </h1>
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
.remove::after {
    color: #949494;
    padding-left: 10px;
}

 .remove1 {
  display: block;
  background: #444;
  border: 1px solid black;
  color: white;
  text-align: center;
  cursor: pointer;
  width:175px;
}
.remove1:hover {
  background: white;
  color: black;
}
.remove1::after {
    color: #949494;
    padding-left: 10px;
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
                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                                              <label>Content * </br>[preferrably 250 characters]</label>
                                                <div class="md-input-wrapper"  runat="server" id="dvContent" style="padding-top:11px">
                                                   
                                                    <asp:TextBox ID="txtContent" ClientIDMode="Static" runat="server" TextMode="MultiLine" Height="270px" Width="680px"
                                                        Rows="8"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter content" Display="None" ControlToValidate="txtContent"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="uk-grid uk-grid-small" id="dvoldImage" style="display:none" runat="server" clientidmode="static">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                                            
                                                    <img id="imgoldImage" runat="server" clientidmode="static" src="" alt="image"/>
                                                    
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                         <div class="uk-grid uk-grid-small" id="dvoldAddlImage" style="display:none" runat="server" clientidmode="static">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                                            
                                                    <img id="imgoldAddlImage" runat="server" clientidmode="static" src="" alt="image"/>
                                                    
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small" id="dvEventImage" style="display:none" runat="server" clientidmode="static">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                    <label>Main Image</label>
                                                    <br />
                                                    
                                                    <br />
                                                     <span class="remove" id="spRemove" style="padding: 5px 0px">Remove image</span>
                                                    <br />
                                                    <img id="imgEventImage" runat="server" clientidmode="static" src="" alt="image"/>
                                                    
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="uk-grid uk-grid-small" id="dvAddlImage" style="display:none" runat="server" clientidmode="static">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" >
                                                    <label>Additional Image</label>
                                                    <br />
                                                    
                                                    <br />
                                                     <span class="remove1" id="spAddlRemove" style="padding: 5px 0px">Remove image</span>
                                                    <br />
                                                    <img id="imgAddlImage" runat="server" clientidmode="static" src="" alt="image"/>
                                                    
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
                                                 <label>Title * </br>[preferrably 110 characters]</label>
                                                <div class="md-input-wrapper" id="dvTitle" runat="server" style="padding-top:9px">
                                                   
                                                    <asp:TextBox ID="txtTitle"  runat="server" CssClass="md-input" style="border-width:2px 2px 2px;"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter Title" Display="None" ControlToValidate="txtTitle"  ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    <span class="md-input-bar"></span>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="uk-grid uk-grid-small">
                                            <div class="uk-width-large-3-3">
                             
                                            </div>
                                        </div>
                                         
                                
                                        
                                       <div class="uk-grid uk-grid-small" style="padding-bottom: 12px;">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" style="padding-top:12px; padding-bottom: 30px;">
                                                <label style="position:static">Main Image* : (575 * 350 ) </br>[in .jpg/.png/.jpeg format - max size 5MB]</label>
                                                    <asp:FileUpload ID="flEventImage" runat="server" ClientIDMode="Static"  CssClass="ajax__fileupload" onchange="showCoverImage(this)" />
                                                  <asp:HiddenField ID="hiddenEventImage" runat="server" />
                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please choose image"
                                  Display="None" ControlToValidate="flEventImage"  ValidationGroup="val"></asp:RequiredFieldValidator>                    
                         <asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" 
                             ErrorMessage="Images must be of type jpeg or gif or png!" Display="None" 
                             ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.jpeg|.JPEG |.JPG)$" ValidationGroup="val"
                             ControlToValidate="flEventImage" />
                                                </div>
                                            </div>
                                        </div>


                                        <div class="uk-grid uk-grid-small" style="padding-bottom: 12px;">
                                            <div class="uk-width-large-3-3">
                                                <div class="md-input-wrapper" style="padding-top:12px">
                                     
                                            <label class="custom-file-label" for="customFile" style="position: absolute; top:-30px;">Additional Image </br>[in .jpg/.png/.jpeg format - max size 5MB]</label>    
                                                
                                                     <asp:FileUpload ID="flAddlImage" runat="server" ClientIDMode="Static"  CssClass="custom-file-input" onchange="showAddlImage(this)" />
                                                  <asp:HiddenField ID="hiddenAddlImage" runat="server" />                                                               
                         <asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" 
                             ErrorMessage="Images must be of type jpeg or gif or png!" Display="None" 
                             ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.jpeg|.JPEG |.JPG)$" ValidationGroup="val"
                             ControlToValidate="flAddlImage" />
                                                  
   
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

<link rel="stylesheet"
    href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.6/themes/base/jquery-ui.css"
        type="text/css" media="all" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.4.4/jquery.min.js"
    type="text/javascript"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.6/jquery-ui.min.js"
        type="text/javascript"></script>
       
    <script type="text/javascript">
      
        //        $(function () {
        var $j = jQuery.noConflict();
    

        //        });
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

        function showAddlImage(fileInput) {
            
            var files = fileInput.files;
            for (var i = 0; i < files.length; i++) {
                var file = files[i];
                var size = parseFloat(files[i].size / 1024).toFixed(2);
                var r = 1;// (size / 1024).toFixed(2);
                if (r >= 2) {
                    alert("File size is too high , please select image lesser than 2 MB");
                    var hdn = $('#hiddenAddlImage').val();
                    if (hdn == "undefined") {
                        document.getElementById("dvAddlImage").style.display = "none";
                         document.getElementById("spAddlRemove").style.display = "none";
                    }
                    else {
                        document.getElementById("dvAddlImage").style.display = "block";
                         document.getElementById("spAddlRemove").style.display = "block";
                    }


                }
                else {
                    document.getElementById("dvAddlImage").style.display = "block";
                     document.getElementById("spAddlRemove").style.display = "block";
                    var imageType = /image.*/;
                    if (!file.type.match(imageType)) {
                        continue;
                    }
                    var img = document.getElementById("imgAddlImage");
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
        
        $(".remove1").click(function () {
            document.getElementById("dvAddlImage").style.display = "none";
             document.getElementById("spAddlRemove").style.display = "none";
            $('#imgAddlImage').attr('src', '');      
            $('#flAddlImage').val("");
        });  
    </script>
</asp:Content>



