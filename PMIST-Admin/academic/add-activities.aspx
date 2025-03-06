<%@ Page Title="" Language="C#" MasterPageFile="~/PMIST-Admin/Admin.master" AutoEventWireup="true" CodeFile="add-activities.aspx.cs" Inherits="activities" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .btn-view-pop {
            top: 5px;
        }
    </style>
    <style>
        .active-blue {
            background-color: #575962;
            color: white;
        }

        .active-black {
            background-color: black;
            color: #202225;
        }

    
    .btn-view-pop {
        top: 5px;
    }
    </style>
    <style>
        /* Popup styling */
        .sweet-popup-style {
            max-width: 90%;
            max-height: 80vh;
            height: auto;
            overflow: auto;
            border-radius: 15px;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.2);
            position: relative;
        }

        /* Image container */
        .image-container {
            text-align: center;
            background-color: #ffffff;
            padding: 20px;
            border-radius: 10px;
            position: relative;
            overflow: hidden;
            height: 90vh;
            display: flex;
            justify-content: center; /* Center the image horizontally */
            align-items: center; /* Center the image vertically */
        }

        /* Image styling */
        .image-preview {
            max-width: 100%;
            max-height: 90vh; /* Restrict height to 70% of viewport */
            object-fit: contain;
            transition: transform 0.3s ease;
            position: absolute; /* Absolute position to allow dragging */
            cursor: grab; /* Cursor style when hovering over the image */
            top: 50%; /* Position image vertically at 50% */
            left: 50%; /* Position image horizontally at 50% */
            transform: translate(-50%, -50%); /* Center the image */
            transform-origin: center center; /* Ensure zoom happens from the center */
        }

        /* Zoom controls */
        .zoom-controls {
            margin-top: 10px;
            display: flex;
            justify-content: center;
            gap: 10px; /* Space between buttons */
            position: absolute;
            bottom: 10px;
            left: 50%;
            transform: translateX(-50%);
            z-index: 10; /* Ensure buttons are always on top */
        }

        /* Zoom buttons */
        .zoom-btn {
            padding: 10px 15px;
            font-size: 18px;
            border: none;
            border-radius: 5px;
            background-color: #d3d3d3; /* Light gray */
            color: #000; /* White text */
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

            .zoom-btn:hover {
                background-color: #b1b1b1; /* Darker gray */
            }

        /* Reset image drag position after zoom */
        .image-preview {
            transition: transform 0.3s ease, left 0.3s ease, top 0.3s ease;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="panel-header bg-primary-gradient">
            <div class="page-inner py-5">
                <div class="d-flex pb-2 align-items-left align-items-sm-center flex-column flex-sm-row justify-content-between">
                    <div class="d-flex">
                        <h2 class="text-white mb-0 fw-bold text-uppercase">
                            <asp:Label ID="lbldisplaymsg" runat="server" Text=""></asp:Label>
                        </h2>
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
                            <div class="form-group">
                                <div class="slider-section position-relative py-sm--5 py-5">
                                    <div class="d-flex w-100">
                                        <div id="box1" class="w-25 active-blue text-center p-3 ACD">Activities Details</div>
                                        <div id="box2" class="w-25 text-center p-3 IVI">INDUSTRIAL VISITS/ INTERNSHIPS</div>
                                    </div>
                                    <div id="slider-container" class="slider">
                                        <div class="form-border margin-top20" clientidmode="Static" runat="server" id="divACD" style="display: block">
                                            <div class="form-title">
                                                <h3>Activities Details</h3>
                                            </div>
                                            <div class="row mx-0 margin-top20 mb-4">
                                                <div class="col-sm-4 col-xl-3 pt-3">
                                                    <div class="input-icon input-icon-sm right">
                                                        <label>Department <span class="text-danger">*</span></label>
                                                        <i class="bi bi-journal-bookmark-fill b5-icon"></i>
                                                        <asp:DropDownList ID="ddldepartment" class="bs-select form-control input-sm" runat="server">
                                                            <asp:ListItem Selected="True" Value=""></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </div>
                                                    <span class="error">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddldepartment" ValidationGroup="actval" InitialValue="" runat="server" ErrorMessage="Select department"></asp:RequiredFieldValidator>
                                                    </span>
                                                </div>
                                                <asp:HiddenField ID="hdnID" ClientIDMode="Static" runat="server" />
                                                <div class="col-sm-4 col-xl-3 pt-3">
                                                    <div class="input-icon input-icon-sm right">
                                                        <label>Title <span class="text-danger">*</span></label>
                                                        <i class="bi bi-journal-text b5-icon"></i>
                                                        <asp:TextBox runat="server" ID="txtTitle" MaxLength="50" class="form-control input-sm capitalize-input" autocomplete="off" placeholder=""></asp:TextBox>
                                                    </div>
                                                    <span class="error">
                                                        <asp:RequiredFieldValidator ClientIDMode="Static" EnableClientScript="true" SetFocusOnError="true" ControlToValidate="txtTitle" Display="Dynamic" ValidationGroup="actval" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter title"></asp:RequiredFieldValidator>
<%--                                                        <asp:RegularExpressionValidator ClientIDMode="Static" ID="RegularExpressionValidator1" Display="Dynamic" runat="server" ValidationGroup="actval" ControlToValidate="txtTitle" ValidationExpression="^[A-Za-z -]+$" ErrorMessage="Enter valid title"></asp:RegularExpressionValidator>--%>
                                                    </span>
                                                </div>
                                                <div class="col-sm-4 col-xl-3 pt-4">
                                                    <div class="input-icon input-icon-sm right">
                                                        <label>Activities Upload <span class="text-danger">*</span></label>
                                                        <i class="bi bi-images b5-icon"></i>
                                                        <asp:FileUpload ID="FileUpload" ClientIDMode="Static" runat="server" CssClass="form-control input-sm file-upload" accept=".pdf" />
                                                        <span class="handle-file-request">(upload max file size,pdf-2 MB)</span>
                                                        <asp:HiddenField ID="hdnFileUpload" runat="server" />
                                                    </div>
                                                    <span class="error">
                                                        <asp:RequiredFieldValidator ClientIDMode="Static" EnableClientScript="true" SetFocusOnError="true" ControlToValidate="FileUpload" Display="Dynamic" ValidationGroup="actval" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Upload File"></asp:RequiredFieldValidator>

                                                        <asp:Label ID="lblFileUpload" CssClass="lblFileUpload" runat="server" ForeColor="#d41111" Text=""></asp:Label>
                                                    </span>
                                                    <div class="btn-view btn-view-pop btn-view-pop" clientidmode="Static" id="DivSaleDeedDraft" style="display: none">
                                                        <i class="bi bi-eye"></i>View 
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="card-footer mx-2 pb-4">
                                                <div class="d-flex justify-content-center">
                                                    <asp:Button
                                                        ID="btnSave" ClientIDMode="Static"
                                                        runat="server" OnClick="btnSave_Click"
                                                        Text="Add" ValidationGroup="actval"
                                                        class="btn btn-sm handle-btn-success me-1 swtAltSubmit btnSave"
                                                        OnClientClick="if (validatePage()) { this.value='Please wait..'; this.style.display='none'; document.getElementById('bWait').style.display = ''; } else { return false; }" Style="min-width: 67px;" />
                                                    <button type="button" style="display: none" id="bWait" class="btn btn-secondary btn-sm me-1"><i class='fa fa-spinner fa-spin'></i>Please wait</button>
                                                    <div class="btn btn-sm handle-btn-danger swtAltCancel-Refresh">Cancel</div>
                                                    <asp:Button ID="btnCancel" ClientIDMode="Static" runat="server" Text="Cancel Project" OnClick="btnCancel_Click" Style="display: none;" />
                                                </div>
                                            </div>
                                        </div>

                                        <div class="form-border margin-top20" runat="server" clientidmode="Static" id="divIVI" style="display: none">
                                            <div class="form-title">
                                                <h3>INDUSTRIAL VISITS/ INTERNSHIPS</h3>
                                            </div>
                                            <div class="row mx-0 margin-top20 mb-4">
                                                <div class="col-sm-4 col-xl-3 pt-3">
                                                    <div class="input-icon input-icon-sm right">
                                                        <label>Department <span class="text-danger">*</span></label>
                                                        <i class="bi bi-journal-bookmark-fill b5-icon"></i>
                                                        <asp:DropDownList ID="ddldepartmentIVI" ClientIDMode="Static" class="bs-select form-control input-sm" runat="server">
                                                            <asp:ListItem Selected="True" Value=""></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </div>
                                                    <span class="error">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator101" ControlToValidate="ddldepartmentIVI" ValidationGroup="actvalIVI" InitialValue="" runat="server" ErrorMessage="Select department"></asp:RequiredFieldValidator>
                                                    </span>
                                                </div>
                                                <asp:HiddenField ID="hdnID1" ClientIDMode="Static" runat="server" />
                                                <div class="col-sm-4 col-xl-3 pt-3">
                                                    <div class="input-icon input-icon-sm right">
                                                        <label>Title <span class="text-danger">*</span></label>
                                                        <i class="bi bi-journal-text b5-icon"></i>
                                                        <asp:TextBox runat="server" ID="txtTitleIVI" MaxLength="50" class="form-control input-sm capitalize-input" autocomplete="off" placeholder=""></asp:TextBox>
                                                    </div>
                                                    <span class="error">
                                                        <asp:RequiredFieldValidator ClientIDMode="Static" EnableClientScript="true" SetFocusOnError="true" ControlToValidate="txtTitleIVI" Display="Dynamic" ValidationGroup="actvalIVI" ID="RequiredFieldValidator301" runat="server" ErrorMessage="Enter title"></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ClientIDMode="Static" ID="RegularExpressionValidator103" Display="Dynamic" runat="server" ValidationGroup="actvalIVI" ControlToValidate="txtTitleIVI" ValidationExpression="^[A-Za-z -]+$" ErrorMessage="Enter valid title"></asp:RegularExpressionValidator>
                                                    </span>
                                                </div>
                                                <div class="col-md-7 pt-3">
                                                    <div class="input-icon input-icon-sm right">
                                                        <label>Content <span class="text-danger">*</span></label>
                                                        <i class="bi bi-body-text b5-icon"></i>
                                                        <asp:TextBox class="form-control capitalize-input editor" ClientIDMode="Static" ValidateRequestMode="Disabled" Rows="4" ID="txtContentIVI" cols="50" placeholder="" TextMode="MultiLine" runat="server"></asp:TextBox>
                                                    </div>
                                                    <span class="error">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtContentIVI" ValidationGroup="actvalIVI" runat="server" ErrorMessage="Enter content"></asp:RequiredFieldValidator>
                                                    </span>
                                                </div>
                                                <div class="col-sm-4 col-xl-3 pt-4">
                                                    <div class="input-icon input-icon-sm right">
                                                        <label>Activities Upload <span class="text-danger">*</span></label>
                                                        <i class="bi bi-images b5-icon"></i>
                                                        <asp:FileUpload ID="FileUploadIVI" ClientIDMode="Static" runat="server" CssClass="form-control input-sm file-upload" accept=".pdf" />
                                                        <span class="handle-file-request">(upload max file size,pdf-2 MB)</span>
                                                        <asp:HiddenField ID="hdnFileUploadIVI" runat="server" />
                                                    </div>
                                                    <span class="error">
                                                        <asp:RequiredFieldValidator ClientIDMode="Static" EnableClientScript="true" SetFocusOnError="true" ControlToValidate="FileUploadIVI" Display="Dynamic" ValidationGroup="actvalIVI" ID="RequiredFieldValidator202" runat="server" ErrorMessage="Upload File"></asp:RequiredFieldValidator>

                                                        <asp:Label ID="lblFileUploadIVI" CssClass="lblFileUpload" runat="server" ForeColor="#d41111" Text=""></asp:Label>
                                                    </span>
                                                    <div class="btn-view btn-view-pop btn-view-pop btn-viewIVI" clientidmode="Static" id="DivSaleDeedDraftIVI" style="display: none">
                                                        <i class="bi bi-eye"></i>View 
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="card-footer mx-2 pb-4">
                                                <div class="d-flex justify-content-center">
                                                    <asp:Button
                                                        ID="btnSaveIVI" ClientIDMode="Static"
                                                        runat="server" OnClick="btnSaveIVI_Click"
                                                        Text="Add" ValidationGroup="actvalIVI"
                                                        class="btn btn-sm handle-btn-success me-1 swtAltSubmit btnSave"
                                                        OnClientClick="if (validatePageIVI()) { this.value='Please wait..'; this.style.display='none'; document.getElementById('bWait').style.display = ''; } else { return false; }" Style="min-width: 67px;" />
                                                    <button type="button" style="display: none" id="bWaitIVI" class="btn btn-secondary btn-sm me-1"><i class='fa fa-spinner fa-spin'></i>Please wait</button>
                                                    <div class="btn btn-sm handle-btn-danger swtAltCancel-RefreshIVI">Cancel</div>
                                                    <asp:Button ID="btnCancelIVI" ClientIDMode="Static" runat="server" Text="Cancel Project" OnClick="btnCancelIVI_Click" Style="display: none;" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <footer class="footer">
        <div class="container-fluid">
            <nav class="pull-left">
                &copy;
       <script type="text/javascript">
           var today = new Date()
           var year = today.getFullYear()
           document.write(year)
       </script>
            </nav>
            <div class="copyright ml-auto">
                Powered by <a class="text-uppercase" href="https://duffldigital.com/" target="_blank">Duffl
       Digital</a>
            </div>
        </div>
    </footer>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function () {
            $(".ACD").click(function () {
                $("#divACD").show();
                $("#divIVI").hide();
            });

            $(".IVI").click(function () {
                $("#divACD").hide();
                $("#divIVI").show();
            });
        });
</script>




    <script>
        $(document).ready(function () {
            $("#box1").click(function () {
                $("#box2").addClass("active-black").removeClass("active-blue");
                $("#box1").addClass("active-blue").removeClass("active-black");
            });

            $("#box2").click(function () {
                $("#box1").addClass("active-black").removeClass("active-blue");
                $("#box2").addClass("active-blue").removeClass("active-black");
            });
        });
</script>


    <script src="https://cdn.ckeditor.com/ckeditor5/32.0.0/classic/ckeditor.js"></script>

      <script>
          document.addEventListener('DOMContentLoaded', function () {
              ClassicEditor
                  .create(document.querySelector('.editor'), {
                      toolbar: [
                          'heading', '|', 'bold', 'italic', 'link', 'undo', 'redo',
                          'bulletedList', 'numberedList', 'specialCharacters', 'code'
                      ],
                      heading: {
                          options: [
                              { model: 'paragraph', title: 'Paragraph', class: 'ck-heading_paragraph' },
                              { model: 'heading1', view: 'h1', title: 'Heading 1', class: 'ck-heading_heading1' },
                             
                          ]
                      },
                      language: 'en',
                      removePlugins: ['MediaEmbed']
                  })
                  .then(editor => {
                      editor.model.document.on('change:data', () => {
                          document.getElementById('<%= txtContentIVI.ClientID %>').value = editor.getData();
                   });
               })
               .catch(error => console.error(error));
       });
      </script>


    <script type="text/javascript">
        function attachSweetAlert() {
            const cancelButton = document.querySelector('.swtAltCancel-Refresh');

            if (cancelButton) {
                
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
                            const cancelBtn = document.getElementById('<%= btnCancel.ClientID %>');
                            if (cancelBtn) {
                                cancelBtn.click();
                            }
                        }
                    });
                });
            }
        }

        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
            attachSweetAlert();
        });

        document.addEventListener('DOMContentLoaded', function () {
            attachSweetAlert();
        });

    </script>

      <script type="text/javascript">
        function attachSweetAlertIVI() {
            const cancelButton = document.querySelector('.swtAltCancel-RefreshIVI');

            if (cancelButton) {
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
                            const cancelBtn = document.getElementById('<%= btnCancelIVI.ClientID %>');
                            if (cancelBtn) {
                                cancelBtn.click();
                            }
                        }
                    });
                });
            }
        }

        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
            attachSweetAlertIVI()
        });

        document.addEventListener('DOMContentLoaded', function () {
            attachSweetAlertIVI()
        });

      </script>




    <script>
        function validatePage() {
            var flag = window.Page_ClientValidate('actval');
            return flag;
        }
        function validatePageIVI() {
            var flag = window.Page_ClientValidate('actvalIVI');
            return flag;
        }

       <%-- document.getElementById('<%= txtTitle.ClientID %>').addEventListener('keypress', function (e) {
            if (!/^[A-Za-z -]+$/.test(e.key)) {
                e.preventDefault();
            }
        });--%>
    </script>



    <script type="text/javascript">
        document.addEventListener('DOMContentLoaded', function () {
            var fileUploaders = document.querySelectorAll('.file-upload');
            var viewLogoBtns = document.querySelectorAll('.btn-view');
            var errorLabels = document.querySelectorAll('.lblFileUpload');
            var screensrc = {};
            var fileType = {};
            var fileTitles = ['', 'Sale Deed Final', 'Sale Agreement Draft', 'Sale Agreement Final', 'Allotment Letter', 'Welcome Letter', 'Demand Letter', 'Payment Receipt', 'Bill', 'Payment Schedule', 'EB card', 'NOC for Handing over', 'CC Updation', 'Bank Documents', 'Handing Over Documents', 'Other Documents'];

            if (!fileUploaders || !viewLogoBtns || !errorLabels) {
                console.error("Required elements not found in the DOM.");
                return;
            }

            fileUploaders.forEach(function (fileUploader, index) {
                // Show file when selected
                fileUploader.addEventListener('change', function (event) {
                    var input = event.target;
                    var file = input.files[0];
                    var validFileTypes = ['application/pdf']; // Only PDF files allowed
                    var isValidFileType = validFileTypes.includes(file.type);
                    var viewLogoBtn = viewLogoBtns[index];
                    var errorLabel = errorLabels[index];
                    fileType[index] = file.type;
                    errorLabel.textContent = ''; // Clear any previous error messages

                    if (!file) {
                        resetUploader(viewLogoBtn, errorLabel, index);
                        errorLabel.textContent = "No file selected.";
                        return;
                    }

                    if (!isValidFileType) {
                        resetUploader(viewLogoBtn, errorLabel, index);
                        errorLabel.textContent = "Invalid file type. Only PDF files are allowed.";
                        return;
                    }
                    if (file.type === 'application/pdf' && file.size >= 2 * 1024 * 1024) {
                        resetUploader(viewLogoBtn, errorLabel, index);
                        errorLabel.textContent = "PDF size must be under 2 MB";
                        return;
                    }


                    var reader = new FileReader();
                    reader.onload = function (e) {
                        screensrc[index] = e.target.result;
                        viewLogoBtn.style.display = 'inline-block'; // Show the view button
                    };

                    reader.onerror = function (err) {
                        console.error("Error reading file:", err);
                        screensrc[index] = null;
                    };
                    reader.readAsDataURL(file);
                });

                // Reset the uploader when no file is chosen on click
                fileUploader.addEventListener('click', function () {
                    var errorLabel = errorLabels[index];
                    resetUploader(viewLogoBtns[index], errorLabel, index);
                });

                // Open file in new tab or SweetAlert modal
                viewLogoBtns[index].addEventListener('click', function () {
                    if (!screensrc[index]) {
                        var errorLabel = errorLabels[index];
                        errorLabel.textContent = "No file uploaded yet!";
                        resetUploader(viewLogoBtns[index], errorLabel, index); // Reset the file uploader if no file is uploaded
                        return;
                    }

                    var fileTitle = fileTitles[index];
                    if (fileType[index] === 'application/pdf') {
                        var newWindow = window.open();
                        newWindow.document.write(`<embed src="${screensrc[index]}" width="100%" height="100%">`);
                    }
                });
            });

            // Reset the uploader
            function resetUploader(viewLogoBtn, errorLabel, index) {
                screensrc[index] = null;
                document.querySelectorAll('.file-upload')[index].value = '';
                viewLogoBtn.style.display = 'none';
                errorLabel.textContent = ''; // Clear error message
            }
        });
    </script>



    <script type="text/javascript">
        function bindImageToPreview(srclogo, index, fileType) {
            var viewLogoBtns = document.querySelectorAll('.btn-view');

            if (index !== -1 && viewLogoBtns[index]) {
                var viewLogoBtn = viewLogoBtns[index];

                // Ensure button visibility is set correctly
                viewLogoBtn.style.display = 'inline-block';

                // Attach event listener only once
                viewLogoBtn.removeEventListener('click', handleClick); // Remove any existing listeners
                viewLogoBtn.addEventListener('click', handleClick);

                function handleClick() {
                    if (fileType === 'application/pdf') {
                        setButtonStyle(viewLogoBtn); // Pass the actual button element
                        window.open(srclogo, '_blank'); // Open the PDF in a new tab

                        // Reload the page with query string
                        var currentUrl = window.location.href;
                        var newUrl = addQueryStringToUrl(currentUrl);
                        window.location.href = newUrl; // Reload the page with updated URL
                    }
                }
            }
        }

        function setButtonStyle(viewLogoBtn) {
            // Apply the style to the passed button element
            viewLogoBtn.style.display = 'inline-block';
        }

        function addQueryStringToUrl(url, queryString) {
            var separator = url.indexOf('?') !== -1 ? '&' : '?';
            return url + separator + queryString;
        }
    </script>
    
    
    <script type="text/javascript">
        function bindImageToPreviewIVI(srclogo, index, fileType) {
            var viewLogoBtns = document.querySelectorAll('.btn-viewIVI');

            if (index !== -1 && viewLogoBtns[index]) {
                var viewLogoBtn = viewLogoBtns[index];

                // Ensure button visibility is set correctly
                viewLogoBtn.style.display = 'inline-block';

                // Attach event listener only once
                viewLogoBtn.removeEventListener('click', handleClick); // Remove any existing listeners
                viewLogoBtn.addEventListener('click', handleClick);

                function handleClick() {
                    if (fileType === 'application/pdf') {
                        setButtonStyle(viewLogoBtn); // Pass the actual button element
                        window.open(srclogo, '_blank'); // Open the PDF in a new tab

                        // Reload the page with query string
                        var currentUrl = window.location.href;
                        var newUrl = addQueryStringToUrl(currentUrl);
                        window.location.href = newUrl; // Reload the page with updated URL
                    }
                }
            }
        }

        function setButtonStyle(viewLogoBtn) {
            // Apply the style to the passed button element
            viewLogoBtn.style.display = 'inline-block';
        }

        function addQueryStringToUrl(url, queryString) {
            var separator = url.indexOf('?') !== -1 ? '&' : '?';
            return url + separator + queryString;
        }
    </script>


</asp:Content>

