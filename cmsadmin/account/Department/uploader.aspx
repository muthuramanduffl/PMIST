<%@ Page Title="" Language="C#" MasterPageFile="~/cmsadmin/account/accountMaster.master" AutoEventWireup="true" CodeFile="uploader.aspx.cs" Inherits="cmsadmin_account_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Deparment</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="uk-grid">

        <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
            <div class="md-card">
                <div class="md-card-toolbar">
                    <h3 class="md-card-toolbar-heading-text">
                        <asp:Label ID="lblDisplayText" runat="server"></asp:Label>
                        <b style="padding-left: 420px">
                            <asp:Label ID="lblStatus" runat="server"></asp:Label></b>
                        <b style="padding-left: 120px">
                            <asp:PlaceHolder ID="phLiveUrl" runat="server"></asp:PlaceHolder>
                        </b>

                    </h3>
                </div>
                <div class="md-card-content large-padding">
                    <div class="uk-grid uk-grid-divider uk-grid-medium">
                        <div class="uk-width-large-2-3">

                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3"
                                    <label>Faculty *</label>
                                    <div class="md-input-wrapper" id="dvTitle" runat="server" style="padding-top: 9px">
                                        <asp:DropDownList ID="ddlFaculty" CssClass="md-input" AutoPostBack="true" OnSelectedIndexChanged= "ddlFaculty_SelectedIndexChanged" Style="border-width: 2px 2px 2px;" runat="server">
                                            <asp:ListItem Value="">Select</asp:ListItem>
                                        </asp:DropDownList>


<%--                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" CssClass="mt-2" runat="server" ErrorMessage="Select Faculty"  InitialValue="" ControlToValidate="ddlFaculty" ValidationGroup="val"></asp:RequiredFieldValidator>--%>
                                        <span class="md-input-bar"></span>
                                    </div>
                                </div>
                            </div>
                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3">
                                    <label>Department *</label>
                                    <div class="md-input-wrapper" id="dvDate" runat="server" style="padding-top: 12px">
                                        <asp:TextBox ID="Txtdepartment" ClientIDMode="Static" runat="server" CssClass="md-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>
<%--                                          <asp:RequiredFieldValidator  ID="RequiredFieldValidator2" ForeColor="Red" CssClass="mt-2" runat="server" ErrorMessage="Enter Department"  ControlToValidate="Txtdepartment" ValidationGroup="val"></asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                            </div>


                            <div class="uk-grid uk-grid-small " >
                                <div class="uk-width-medium-3-3">
                                    <asp:CheckBox ID="chkStatus" runat="server" Text="Status" data-switchery="false" Checked="true" />
                                    <%--<input type="checkbox" data-switchery="false" id="chkStatus" runat="server" style="display: none;" checked="checked" />--%>

                                    <br />
                                </div>
                            </div>

                            <div>
                                <h1>Hariti Study Hub</h1>
                                <h4>How to Preview and Upload Multiple Images in Asp.Net with jQuery</h4>
                                <hr />
                            </div><div>
    <h1>Hariti Study Hub</h1>
    <h4>How to Preview and Upload Multiple Images in Asp.Net with jQuery</h4>
    <hr />
</div>
<div id="form1" runat="server" enctype="multipart/form-data">
    Upload Images:
    <asp:FileUpload ID="FileUpload1" runat="server"  AllowMultiple="true" accept="image/*" />
    <br /><br />
    <asp:HiddenField ID="HiddenUploadedImages" runat="server" />
    <div id="showimage"></div>
    <hr />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload and Save"  />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</div>

                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3">

                                    <asp:Button ID="btnSave" runat="server"
                                        CssClass="md-btn md-btn-small md-btn-flat md-btn-success" Text=" Save "
                                        OnClick="btnSave_Click"   OnClientClick="if (validatePage()) { this.value='Please wait..';this.style.display='none';getElementById('bWait').style.display = '';} else { return false; }"   
                                        ValidationGroup="val" />

            <input type="button" id="bWait" class="md-btn md-btn-small md-btn-flat md-btn-success" value="Please wait ..." disabled="disabled" style="display: none" />
                                    <asp:Button ID="btnClear" runat="server"
                                        CssClass="md-btn md-btn-small md-btn-flat md-btn-warning" Text=" Clear "
                                        OnClick="btnClear_Click" />
                                    <a  class="md-btn md-btn-small md-btn-flat md-btn-warning"  href="viewDepartment.aspx"   >View</a>
                                </div>
                            </div>
                            <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
                        </div>


                        <!--Right Side Contents-->
                        <div class="uk-width-large-1-3">
                        </div>

                        <!--End of Right Side-->
                    </div>
                </div>
            </div>


        </div>

    </div>

</asp:Content>




<asp:Content ID="Content4" ContentPlaceHolderID="PageScript" runat="Server">

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>


   <script>
       $(document).ready(function () {
           const previewContainer = $("#showimage");
           const fileUploadControl = $("#<%= FileUpload1.ClientID %>");
           const hiddenUploadedImages = $("#<%= HiddenUploadedImages.ClientID %>");

           // Load existing images from the hidden field
           const loadExistingImages = () => {
               const existingImages = hiddenUploadedImages.val();
               if (existingImages) {
                   const imageArray = existingImages.split(",");
                   previewContainer.html("");
                   imageArray.forEach((imagePath) => {
                       if (imagePath.trim() !== "") {
                           addImageToPreview(imagePath, true);
                       }
                   });
               }
           };

           // Add an image to the preview
           const addImageToPreview = (imageSrc, isUploaded = false) => {
               const previewDiv = $("<div />").attr("style", "display:inline-block; margin:10px; position:relative;");
               const img = $("<img />").attr("style", "height:150px;width:150px;").attr("src", imageSrc);
               const removeBtn = $("<span />")
                   .text("x")
                   .attr("style", "position:absolute; top:0; left:0; color:red; cursor:pointer; font-size:16px;")
                   .click(function () {
                       previewDiv.remove();
                       if (isUploaded) {
                           const updatedImages = hiddenUploadedImages.val().split(",").filter((img) => img !== imageSrc);
                           hiddenUploadedImages.val(updatedImages.join(","));
                       }
                   });

               previewDiv.append(removeBtn).append(img);
               previewContainer.append(previewDiv);
           };

           // Handle new file uploads
           fileUploadControl.change(function () {
               const files = $(this)[0].files;

               $(files).each(function (index, file) {
                   const reader = new FileReader();
                   reader.onload = function (e) {
                       addImageToPreview(e.target.result);
                   };
                   reader.readAsDataURL(file);
               });
           });

           // Load existing images on page load
           loadExistingImages();
       });
   </script>



    <script>

        function validatePage() {
            // alert("hi");
            var flag = window.Page_ClientValidate('val');

            //alert(flag);
            return flag;
        }

    </script>


          <script type="text/javascript">

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
          </script>

</asp:Content>



