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
                                <div class="form-border margin-top20">
    <div class="form-title">
        <h3>Images Details</h3>
    </div>
    <div class="row mx-0 margin-top20 mb-4">
        <div class="col-md-4 pt-3">
            <div class="input-icon input-icon-sm right">
                <label>Multi-Image Upload </label>
                <i class="bi bi-images b5-icon"></i>
                    <asp:FileUpload ID="FluploadImageUpload" ClientIDMode="Static" accept=".jpeg, .jpg, .png" onchange="showMyImage1(this)" class="form-control input-sm FluploadImageUpload" autocomplete="off" placeholder="" runat="server" />
    <span class="handle-file-request">(max file size of 500 KB)</span>
    <asp:HiddenField ID="hdnImageUpload" runat="server" />
</div> 
<span class="error">
    <asp:Label ID="lblFluploadImageUpload" CssClass="lblFluploadImageUpload" runat="server" ForeColor="#d41111" Text=""></asp:Label>
 </span>
<span class="error">
    <asp:RequiredFieldValidator EnableClientScript="true" SetFocusOnError="true" ControlToValidate="FluploadImageUpload" ValidationGroup="projval" ID="RequiredFieldValidator5" runat="server" ErrorMessage=" Upload image "></asp:RequiredFieldValidator>
</span> 
<div class="view-pro-screen-img view-pro-screen btn-view-pop btn-view-Photo1" runat="server" id="viewpflphoto" style="display: none">
    <i class="bi bi-eye"></i>View Image
</div>
        </div>
        
    </div>
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
            var idsno = [ '<%= txtC1MobileNo.ClientID %>', '<%= txtC2MobileNo.ClientID %>', '<%= txtC3MobileNo.ClientID %>' ];

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

            //logo fileupload
        function showMyImage1(fileInput) {
            var lbl = document.querySelector('.lblFluploadImageUpload');
            var files = fileInput.files;
            var allowedFiles = [".png", ".jpg", ".jpeg"];

            if (files.length === 0) {
                //resetImageDisplay();
                var viewLogoBtn = document.querySelector('.view-pro-screen-img');
                viewLogoBtn.style.display = 'none';
                return;
            }

            for (var i = 0; i < files.length; i++) {
                var file = files[i];
                var ext = file.name.split('.').pop().toLowerCase(); 
                if (allowedFiles.includes("." + ext)) {
                    var size = parseFloat(file.size / 1024).toFixed(2); // Size in KB
                    if (size > 500) {
                        lbl.textContent = "Image size must be under 500 KB";
                        //alert();
                        resetFileInput(fileInput);
                        var viewLogoBtn = document.querySelector('.view-pro-screen-img');
                        viewLogoBtn.style.display = 'none';
                        //resetImageDisplay();
                        return;
                    } else {
                        var lbl = document.querySelector('.lblFluploadImageUpload');
                        lbl.textContent = "";
                        var viewLogoBtn = document.querySelector('.view-pro-screen-img');
                        viewLogoBtn.style.display = 'inline-block';
                    }
                } else {
                    alert("Select .png, .jpg, or .jpeg files only.");
                    resetFileInput(fileInput);
                    //resetImageDisplay();
                }
            }
        }

        function resetFileInput(fileInput) {
            fileInput.value = ''; 
        }

    </script>

    <script type="text/javascript">
        //-- view pro-screen img with popup  
        document.addEventListener('DOMContentLoaded', function () {
            var fileUploader = document.querySelector('.FluploadImageUpload');
            var viewLogoBtn = document.querySelector('.view-pro-screen-img');
            var screensrc;
            if (!fileUploader || !viewLogoBtn) {
                console.error("Required elements not found in the DOM.");
                return;
            }
            screensrc = null;
            fileUploader.addEventListener('change', function (event) {
                var file = event.target.files[0];
                if (file) {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        screensrc = e.target.result;
                        viewLogoBtn.src = screensrc;
                        viewLogoBtn.style.display = 'inline-block';
                    };
                    reader.onerror = function (err) {
                        console.error("Error reading file:", err);
                        screensrc = null;
                    };
                    reader.readAsDataURL(file);
                } else {
                    screensrc = null;
                    viewLogoBtn.src = '';
                    viewLogoBtn.style.display = 'none';
                    //alert("No file selected.");
                }
            });
            viewLogoBtn.addEventListener('click', function () {
                if (!screensrc) {
                    // alert("No image uploaded yet!");
                    return;
                }
                Swal.fire({
                    html: `
             <div style="position: relative;">
                 <div class="btn-close-icon" style="cursor: pointer; position: absolute; top: -15px; right: -25px;">&times;</div>
                 <h2 class="fw-bold">Image</h2>
                 <img id="swalImage" src="" alt="Image" class="img-fluid mt-3">
             </div>
         `,
                    showConfirmButton: false,
                    didOpen: () => {
                        document.getElementById('swalImage').src = screensrc;
                        document.querySelector('.btn-close-icon').addEventListener('click', () => Swal.close());
                    }
                });
            });
        });
        //--// view pro-screen img with popup 
    </script>

     <script>
         function setupFileUploader(fileUploaderSelector, viewButtonSelector, labelSelector) {
             const fileUploader = document.querySelector(fileUploaderSelector);
             const viewButton = document.querySelector(viewButtonSelector);
             const label = document.querySelector(labelSelector);
             let screensrc = null;
             if (!fileUploader || !viewButton || !label) {
                 console.error("Required elements not found for selectors:", { fileUploaderSelector, viewButtonSelector, labelSelector });
                 return;
             }
             function resetFileInput() {
                 fileUploader.value = '';
                 screensrc = null;
                 viewButton.style.display = 'none';
             }
             fileUploader.addEventListener('change', function () {
                 const file = fileUploader.files[0];
                 const allowedFiles = [".png", ".jpg", ".jpeg"];
                 if (file) {
                     const ext = file.name.split('.').pop().toLowerCase();
                     if (!allowedFiles.includes("." + ext)) {
                         alert("Select .png, .jpg, or .jpeg files only.");
                         resetFileInput();
                         return;
                     }
                     const size = parseFloat(file.size / 1024).toFixed(2); // Size in KB
                     if (size > 500) {
                         label.textContent = "Image size must be under 500 KB";
                         resetFileInput();
                         return;
                     }
                     label.textContent = "";
                     const reader = new FileReader();
                     reader.onload = function (e) {
                         screensrc = e.target.result;
                         viewButton.style.display = 'inline-block';
                     };
                     reader.onerror = function () {
                         screensrc = null;
                         console.error("Error reading file.");
                     };
                     reader.readAsDataURL(file);
                 } else {
                     resetFileInput();
                 }
             });

             viewButton.addEventListener('click', function () {
                 if (!screensrc) {
                     return;
                 }
                 Swal.fire({
                     html: `
            <div style="position: relative;">
                <div class="btn-close-icon" style="cursor: pointer; position: absolute; top: -15px; right: -25px;">&times;</div>
                <h2 class="fw-bold">Photo</h2>
                <img id="swalImage" src="" alt="Photo" class="img-fluid mt-3">
            </div>
        `,
                     showConfirmButton: false,
                     didOpen: () => {
                         document.getElementById('swalImage').src = screensrc;
                         document.querySelector('.btn-close-icon').addEventListener('click', () => Swal.close());
                     }
                 });
             });
         }

         // Initialize file uploaders with unique selectors
         document.addEventListener('DOMContentLoaded', function () {
             setupFileUploader('.FluploadImageUpload', '.btn-view-Photo1', '.lblFluploadImageUpload');
         });

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

