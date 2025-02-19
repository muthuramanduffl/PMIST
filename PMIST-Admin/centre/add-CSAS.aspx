<%@ Page Title="" Language="C#" MasterPageFile="~/PMIST-Admin/Admin.master" AutoEventWireup="true" CodeFile="add-CSAS.aspx.cs" Inherits="PMIST_Admin_Mcentre_CSAS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="panel-header bg-primary-gradient">
            <div class="page-inner py-5">
                <div class="d-flex pb-2 align-items-left align-items-md-center flex-column flex-md-row justify-content-between">
                    <div class="d-flex">
                        <h2 class="text-white mb-0 fw-bold text-uppercase">
                            <asp:Label ID="lbldisplayText" runat="server" Text=""></asp:Label></h2>
                        <ul class="breadcrumbs">
                            <li class="nav-home pt-1">
                                <a href="dashboard.html">
                                    <i class="fa fa-home"></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class="page-inner mt--5">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-body">
                            <asp:HiddenField ID="hdnID" ClientIDMode="Static" runat="server" />
                            <div class="form-group">

                                <div class="form-border margin-top20">
                                    <div class="form-title">
                                        <h3>CSAS Details</h3>
                                    </div>

                                    <div class="row mx-0 margin-top20 mb-4">

                                        <div class="col-md-3 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Centre Name <span class="text-danger">*</span></label>
                                                <i class="bi bi-journal-bookmark-fill b5-icon"></i>
                                                <asp:DropDownList ID="ddltype" class="bs-select form-control input-sm" runat="server">
                                                    <asp:ListItem Selected="True" Value=""></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <span class="error">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="ddltype" ValidationGroup="CSASVals" InitialValue="" runat="server" ErrorMessage="Select centre type"></asp:RequiredFieldValidator>
                                            </span>
                                        </div>

                                        <div class="col-md-4 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Title <span class="text-danger">*</span></label>
                                                <i class="bi bi-journal-bookmark-fill b5-icon"></i>
                                                <asp:TextBox ID="txtTitle" class="form-control capitalize-input" ClientIDMode="Static" Rows="3" cols="50" placeholder="" TextMode="MultiLine" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtTitle" ValidationGroup="CSASVal" InitialValue="" runat="server" ErrorMessage="Enter title"></asp:RequiredFieldValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-5 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Content <span class="text-danger">*</span></label>
                                                <i class="bi bi-body-text b5-icon"></i>
                                                <asp:TextBox class="form-control capitalize-input editor" ClientIDMode="Static" ValidateRequestMode="Disabled" Rows="4" ID="txtContent" cols="50" placeholder="" TextMode="MultiLine" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtContent" ValidationGroup="CSASVal" runat="server" ErrorMessage="Enter content"></asp:RequiredFieldValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-3 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Display Status <span class="text-danger">*</span></label>
                                                <div class="toggle-container">
                                                    <div class="toggle-switch">
                                                        <asp:CheckBox ID="toggleActiveInactive" ClientIDMode="Static" Checked="true" runat="server" />
                                                        <label for="toggleActiveInactive" class="toggle-label mt-1">
                                                            <span class="toggle-text-active">Active</span>
                                                            <span class="toggle-text-inactive">Inactive</span>
                                                        </label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                                <div class="form-border margin-top20">
                                    <div class="form-title">
                                        <h3>Contact Details</h3>
                                    </div>
                                    <div class="row mx-0 margin-top20 mb-4">
                                        <div class="col-md-3 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Contact:1 Name </label>
                                                <i class="bi bi-person-square b5-icon"></i>
                                                <asp:TextBox ID="txtC1Name" MaxLength="75" class="form-control capitalize-input" ClientIDMode="Static" placeholder="" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ClientIDMode="Static" ID="RegularExpressionValidator8" Display="Dynamic" runat="server"
                                                    ValidationGroup="CSASVal" ControlToValidate="txtC1Name" ValidationExpression="^[A-Za-z\s.]+$" ErrorMessage="Enter valid name">
                                                </asp:RegularExpressionValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-3 col-6 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Designation </label>
                                                <i class="bi bi-person-workspace b5-icon"></i>
                                                <asp:TextBox ID="txtC1Designation" MaxLength="75" class="form-control capitalize-input" ClientIDMode="Static" placeholder="" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ClientIDMode="Static" ID="RegularExpressionValidator1" Display="Dynamic" runat="server"
                                                    ValidationGroup="CSASVal" ControlToValidate="txtC1Designation" ValidationExpression="^[A-Za-z\s]+$" ErrorMessage="Enter valid designation">
                                                </asp:RegularExpressionValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-3 col-6 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Mobile Number </label>
                                                <i class="bi bi-telephone b5-icon"></i>
                                                <asp:TextBox runat="server" ID="txtC1MobileNo" ClientIDMode="Static" MaxLength="10" class="form-control input-sm" autocomplete="off" placeholder=""></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txtC1MobileNo" ValidationGroup="CSASVal"
                                                    ValidationExpression="^(?![0-5])\d{10}$" ErrorMessage="Enter valid mobile no." Display="Dynamic"></asp:RegularExpressionValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-3 col-6 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Email ID </label>
                                                <i class="bi bi-envelope b5-icon"></i>
                                                <asp:TextBox ID="txtC1Emailid" class="form-control input-sm" MaxLength="50" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtC1Emailid" ValidationGroup="CSASVal"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Enter valid email id" Display="Dynamic"></asp:RegularExpressionValidator>
                                            </span>
                                        </div>

                                        <div class="col-md-3 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Contact:2 Name </label>
                                                <i class="bi bi-person-square b5-icon"></i>
                                                <asp:TextBox ID="txtC2Name" MaxLength="75" class="form-control capitalize-input" ClientIDMode="Static" placeholder="" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ClientIDMode="Static" ID="RegularExpressionValidator2" Display="Dynamic" runat="server"
                                                    ValidationGroup="CSASVal" ControlToValidate="txtC2Name" ValidationExpression="^[A-Za-z\s.]+$" ErrorMessage="Enter valid name">
                                                </asp:RegularExpressionValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-3 col-6 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Designation </label>
                                                <i class="bi bi-person-workspace b5-icon"></i>
                                                <asp:TextBox ID="txtC2Designation" MaxLength="75" class="form-control capitalize-input" ClientIDMode="Static" placeholder="" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ClientIDMode="Static" ID="RegularExpressionValidator3" Display="Dynamic" runat="server"
                                                    ValidationGroup="CSASVal" ControlToValidate="txtC2Designation" ValidationExpression="^[A-Za-z\s]+$" ErrorMessage="Enter valid designation">
                                                </asp:RegularExpressionValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-3 col-6 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Mobile Number </label>
                                                <i class="bi bi-telephone b5-icon"></i>
                                                <asp:TextBox runat="server" ID="txtC2MobileNo" ClientIDMode="Static" MaxLength="10" class="form-control input-sm" autocomplete="off" placeholder=""></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtC2MobileNo" ValidationGroup="CSASVal"
                                                    ValidationExpression="^(?![0-5])\d{10}$" ErrorMessage="Enter valid mobile no." Display="Dynamic"></asp:RegularExpressionValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-3 col-6 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Email ID </label>
                                                <i class="bi bi-envelope b5-icon"></i>
                                                <asp:TextBox ID="txtC2Emailid" class="form-control input-sm" MaxLength="50" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtC2Emailid" ValidationGroup="CSASVal"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Enter valid email id" Display="Dynamic"></asp:RegularExpressionValidator>
                                            </span>
                                        </div>

                                        <div class="col-md-3 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Contact:3 Name </label>
                                                <i class="bi bi-person-square b5-icon"></i>
                                                <asp:TextBox ID="txtC3Name" MaxLength="75" class="form-control capitalize-input" ClientIDMode="Static" placeholder="" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ClientIDMode="Static" ID="RegularExpressionValidator9" Display="Dynamic" runat="server"
                                                    ValidationGroup="CSASVal" ControlToValidate="txtC3Name" ValidationExpression="^[A-Za-z\s.]+$" ErrorMessage="Enter valid name">
                                                </asp:RegularExpressionValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-3 col-6 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Designation </label>
                                                <i class="bi bi-person-workspace b5-icon"></i>
                                                <asp:TextBox ID="txtC3Designation" MaxLength="75" class="form-control capitalize-input" ClientIDMode="Static" placeholder="" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ClientIDMode="Static" ID="RegularExpressionValidator10" Display="Dynamic" runat="server"
                                                    ValidationGroup="CSASVal" ControlToValidate="txtC3Designation" ValidationExpression="^[A-Za-z\s]+$" ErrorMessage="Enter valid designation">
                                                </asp:RegularExpressionValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-3 col-6 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Mobile Number </label>
                                                <i class="bi bi-telephone b5-icon"></i>
                                                <asp:TextBox runat="server" ID="txtC3MobileNo" ClientIDMode="Static" MaxLength="10" class="form-control input-sm" autocomplete="off" placeholder=""></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="txtC3MobileNo" ValidationGroup="CSASVal"
                                                    ValidationExpression="^(?![0-5])\d{10}$" ErrorMessage="Enter valid mobile no." Display="Dynamic"></asp:RegularExpressionValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-3 col-6 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Email ID </label>
                                                <i class="bi bi-envelope b5-icon"></i>
                                                <asp:TextBox ID="txtC3Emailid" class="form-control input-sm" MaxLength="50" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator12" runat="server" ControlToValidate="txtC3Emailid" ValidationGroup="CSASVal"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Enter valid email id" Display="Dynamic"></asp:RegularExpressionValidator>
                                            </span>
                                        </div>
                                    </div>
                                </div>






                                <div class="form-border margin-top20" runat="server" clientidmode="static" id="Divimageupload" style="display: block">
                                    <div class="form-title">
                                        <h3>Upload images <span class="text-danger">*</span></h3>
                                    </div>
                                    <div class="row mx-0 margin-top20 mb-4">
                                        <div class="col-md-4 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Multi-Image Upload </label>
                                                <asp:FileUpload ID="flUpload" ClientIDMode="static" runat="server" accept=".jpeg, .jpg, .png" class="form-control input-sm " onchange="return fileValidation()" AllowMultiple="True" />

                                                <%-- <asp:FileUpload ID="imgupload"  onchange="showMyImage(this)" runat="server" />--%>
                                                <label class="custom-file-label pt-2" clientidmode="Static" id="customFile" for="customFile"></label>
                                                <span class=" small">(.jpeg, .jpg, .png - max 10 images,<br>
                                                    image size to be 450KB (Upload Multiple Images))</span>
                                                <br>
                                                <div>(Dimensions : 610(w) x 409(h) in Pixel)</div>
                                                <asp:HiddenField ClientIDMode="Static" ID="hiddenBlogImage" runat="server" />
                                                <asp:HiddenField ID="hfFileCount" ClientIDMode="Static" Value="0" runat="server" />
                                                <asp:HiddenField ClientIDMode="Static" ID="HDTITLE" Value="0" runat="server" />
                                                <asp:HiddenField ClientIDMode="Static" ID="hdnaddremiderimages" Value="0" runat="server" />
                                                <%--                                                        <asp:Button ID="btnUpload" runat="server"  Text="Upload Files" OnClick="UploadButton_Click" CssClass="hidden-button" />--%>
                                                <asp:HiddenField ID="hdnimage" ClientIDMode="Static" Value="" runat="server" />
                                                <div id="labelmsg" class="d-none" runat="server"></div>
                                                <div id="imageGallery"></div>
                                                <div id="imagePreviewContainer"></div>

                                                <div id="lbluploade"></div>
                                                <asp:Label ID="lblErrorMessage" CssClass="lblErrorMessage" runat="server" Text="" ForeColor="#D41111"></asp:Label>
                                                <div id="plabel"></div>
                                                <div id="dvoldImage" class="dvoldImage" style="display: none !important" runat="server" clientidmode="static">
                                                    <img id="imgTherapyImage" runat="server" clientidmode="static" src="" alt="image" style="width: 150px;" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <span class="error">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="CSASVal" ControlToValidate="flUpload" ForeColor="Red" runat="server" ErrorMessage="Upload images"></asp:RequiredFieldValidator>
                                        <%--  <span id="Requiredsingle" style="display: none;">upload image</span>--%>
                                            
                                    </span>

                                </div>
                            </div>
                        </div>

                        <div class="card-footer">
                            <div class="d-flex justify-content-center">
                                <asp:Button
                                    ID="btnSave" ClientIDMode="Static"
                                    runat="server" OnClick="btnSave_Click"
                                    Text="Submit" ValidationGroup="FaqsVal"
                                    class="btn btn-sm btn-success handle-btn-success me-1"
                                    OnClientClick="if (validatePage()) { this.value='Please wait..'; this.style.display='none'; document.getElementById('bWait').style.display = ''; } else { return false; }" Style="min-width: 67px;" />
                                <button type="button" style="display: none" id="bWait" class="btn btn-secondary btn-sm me-1"><i class='fa fa-spinner fa-spin'></i>Please wait</button>
                                <div class="btn btn-sm handle-btn-danger swtAltCancel">Cancel</div>
                                <asp:Button ID="btnCancel" runat="server" ClientIDMode="Static" Text="Cancel Project" OnClick="btnCancel_Click" Style="display: none;" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="https://cdn.ckeditor.com/ckeditor5/32.0.0/classic/ckeditor.js"></script>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            ClassicEditor
                .create(document.querySelector('.editor'), {
                    toolbar: [
                        'bold', 'italic', 'link', 'undo', 'redo',
                        'bulletedList', 'numberedList',
                        'specialCharacters', 'code'
                    ],
                    language: 'en', // Ensure language support
                    removePlugins: ['MediaEmbed'] // If media embedding causes issues
                })
                .then(editor => {
                    editor.model.document.on('change:data', () => {
                        document.getElementById('<%= txtContent.ClientID %>').value = editor.getData();
                    });
                })
                .catch(error => console.error(error));
        });
    </script>

    <script type="text/javascript">
        function validatePage() {
            var flag = Page_ClientValidate('CSASVal')
            return flag;
        }

        document.addEventListener('DOMContentLoaded', function () {
            var ids = [
                '<%= txtC1Name.ClientID %>', '<%= txtC2Name.ClientID %>', '<%= txtC3Name.ClientID %>',
                '<%= txtC1Designation.ClientID %>', '<%= txtC2Designation.ClientID %>', '<%= txtC3Designation.ClientID %>'
            ];

            ids.forEach(function (id) {
                var element = document.getElementById(id);
                if (element) {
                    element.addEventListener('keypress', allowOnlyLettersAndSpaces);
                }
            });
        });

        function allowOnlyLettersAndSpaces(e) {
            if (!/^[A-Za-z\s]+$/.test(e.key)) {
                e.preventDefault();
            }
        }

        document.addEventListener('DOMContentLoaded', function () {
            var idsno = [ '<%= txtC1MobileNo.ClientID %>', '<%= txtC2MobileNo.ClientID %>', '<%= txtC3MobileNo.ClientID %>'];

            idsno.forEach(function (id) {
                var element = document.getElementById(id);
                if (element) {
                    element.addEventListener('keypress', allowOnlyNumbers);
                }
            });
        });

        function allowOnlyNumbers(e) {
            if (!/^\d+$/.test(e.key)) {
                e.preventDefault();
            }
        }


    </script>

    <script type="text/javascript">
        document.addEventListener('DOMContentLoaded', function () {
            const cancelButton = document.querySelector('.swtAltCancel');
            cancelButton.addEventListener('click', function () {
                Swal.fire({
                    title: 'Are you sure you want to cancel?',
                    showCancelButton: true,
                    confirmButtonText: 'Yes',
                    cancelButtonText: 'No',
                    customClass: {
                        confirmButton: 'handle-btn-danger',
                        cancelButton: 'handle-btn-success',
                    }
                }).then((result) => {
                    if (result.isConfirmed) {
                        document.getElementById('<%= btnCancel.ClientID %>').click();
                    } else if (result.dismiss === Swal.DismissReason.cancel) {
                    }
                });
            });
        });

        // toggleActiveInactive
        document.addEventListener("DOMContentLoaded", function () {
            var checkbox = document.getElementById('<%= toggleActiveInactive.ClientID %>');
            var labelActive = document.querySelector('.toggle-text-active');
            var labelInactive = document.querySelector('.toggle-text-inactive');

            function updateToggleText() {
                if (checkbox.checked) {
                    labelActive.style.display = 'inline';
                    labelInactive.style.display = 'none';
                } else {
                    labelActive.style.display = 'none';
                    labelInactive.style.display = 'inline';
                }
            }

            checkbox.addEventListener("change", updateToggleText);

            // Set initial state
            updateToggleText();
        });
    </script>




    <script>
        //$(document).ready(function () {
        //    // Initialize the label message
        //    updateImageLabel();
        //});

        function fileValidation() {
            var fileInput = document.getElementById('flUpload');
            var files = fileInput.files;
            var hfFileCount = document.getElementById('hfFileCount').value;  // Get the value of hfFileCount
            var hdnaddremiderimages = document.getElementById('hdnaddremiderimages').value;  // Get the value of already uploaded images
            var lblErrorMessage = document.querySelector('.lblErrorMessage');  // Use querySelector to select the first element with this class
            document.getElementById("dvoldImage").style.display = "none";
            document.getElementById("imgTherapyImage").src = '';

            var allowedImageTypes = ['image/jpeg', 'image/jpg', 'image/png'];
            var allowedExtensions = ['jpg', 'jpeg', 'png'];
            var maxFileSize = 450 * 1024; // 450 KB
            var maxFileCount;

            if (hfFileCount == 1) {
                maxFileCount = 1;
            } else if (hfFileCount == 0 && hdnaddremiderimages != 0) {
                maxFileCount = 10 - hdnaddremiderimages;
            } else {
                maxFileCount = 10;
            }

            if (files.length === 0) {
                updateImageLabel();
                return;
            }

            if (files.length > maxFileCount) {
                lblErrorMessage.textContent = 'You can only upload ' + maxFileCount + ' more image(s).';
                fileInput.value = '';
                updateImageLabel();
                return false;
            }

            for (var i = 0; i < files.length; i++) {
                var file = files[i];

                var fileExtension = file.name.split('.').pop().toLowerCase();
                if (allowedExtensions.indexOf(fileExtension) === -1) {
                    lblErrorMessage.textContent = 'Invalid file extension. Only JPG, JPEG, and PNG files are allowed.';
                    fileInput.value = '';
                    updateImageLabel();
                    return false;
                }

                if (allowedImageTypes.indexOf(file.type) === -1) {
                    lblErrorMessage.textContent = 'Please upload only images in JPEG, JPG, or PNG format.';
                    fileInput.value = '';
                    updateImageLabel();
                    return false;
                }

                if (file.size > maxFileSize) {
                    lblErrorMessage.textContent = 'File size is too high, please select a file smaller than 450 KB.';
                    fileInput.value = '';
                    updateImageLabel();
                    return false;
                }
            }

            updateImageLabel();
            return true;
        }


        function updateImageLabel() {
            var fileInput = document.getElementById('flUpload');
            var files = fileInput.files;
            var imageCount = files.length;

            $('#labelmsg').text('Total images uploaded: ' + imageCount);

            var label = $('.custom-file-label');
            if (imageCount > 0) {
                label.addClass('selected').html(imageCount + ' file(s) selected');
            } else {
                label.removeClass('selected').html('');
            }
        }
    </script>





    <script type="text/javascript"> 
        function bindImageToPreviewphoto(imagePath) {
            var viewLogoBtn = document.querySelector('.btn-view-Photo1');
            var lbl = document.querySelector('.lblFluploadImageUpload');
            if (imagePath) {
                viewLogoBtn.src = imagePath;
                viewLogoBtn.style.display = 'inline-block';
                lbl.textContent = "";
                viewLogoBtn.onclick = function () {
                    var imageSrc = imagePath || 'assets/img/logo.png';
                    Swal.fire({
                        html: `
                        <div style="position: relative;">
                            <div class="btn-close-icon" 
                                 style="cursor: pointer; position: absolute; top: -15px; right: -25px;">
                                 &times;
                            </div>
                            <h2 class="fw-bold">View Image</h2>
                            <img src="${imageSrc}" alt="Image" class="img-fluid mt-3">
                        </div>
                    `,
                        showConfirmButton: false,
                        didOpen: () => {
                            document.querySelector('.btn-close-icon').addEventListener('click', () => Swal.close());
                        }
                    });
                };

            } else {
                viewLogoBtn.src = "";
                viewLogoBtn.style.display = 'none';
                lbl.textContent = "No image available.";
            }
        }
    </script>


</asp:Content>

