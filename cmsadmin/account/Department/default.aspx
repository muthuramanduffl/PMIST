<%@ Page Title="" Language="C#" MasterPageFile="~/cmsadmin/account/accountMaster.master" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="cmsadmin_account_Default" %>

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





                                <div id="fileUploadContainer">
                                    <div class="file-upload-row" id="fileUploadRow1">
                                        <label class="customFile">Choose file</label>
                                        <asp:FileUpload ID="fileUpload1" class="file-upload-input" accept=".pdf" onchange="handleFileUpload(this)" runat="server" />
                                        <span id="removeBtn1" class="imgremove" style="cursor: pointer; color: red;">x</span>
                                    </div>
                                </div>
                                <p id="addFileUploadBtn" style="cursor: pointer;">+</p>



                                <span class="md-input-bar"></span>
                            </div>





                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3">

                                    <asp:Button ID="btnSave" runat="server"
                                        CssClass="md-btn md-btn-small md-btn-flat md-btn-success" Text=" Save "
                                        OnClick="btnSave_Click" OnClientClick="if (validatePage()) { this.value='Please wait..';this.style.display='none';getElementById('bWait').style.display = '';} else { return false; }"
                                        ValidationGroup="val" />

                                    <input type="button" id="bWait" class="md-btn md-btn-small md-btn-flat md-btn-success" value="Please wait ..." disabled="disabled" style="display: none" />
                                    <asp:Button ID="btnClear" runat="server"
                                        CssClass="md-btn md-btn-small md-btn-flat md-btn-warning" Text=" Clear "
                                        OnClick="btnClear_Click" />
                                    <a class="md-btn md-btn-small md-btn-flat md-btn-warning" href="viewDepartment.aspx">View</a>
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


    <script>
        let uploadCount = 1; // Tracks the number of uploaders
        const maxUploads = 10; // Maximum allowed uploaders

        // Add new uploader logic
        document.getElementById("addFileUploadBtn").addEventListener("click", function () {
            if (uploadCount < maxUploads) {
                uploadCount++;

                // Create a new file upload row dynamically
                const newUploadRow = document.createElement("div");
                newUploadRow.classList.add("file-upload-row");
                newUploadRow.id = `fileUploadRow${uploadCount}`;

                newUploadRow.innerHTML = `
            <label class="customFile">Choose file</label>
            <input type="file" id="fileUpload${uploadCount}" class="file-upload-input" accept=".pdf" onchange="handleFileUpload(this)">
            <span id="removeBtn${uploadCount}" class="imgremove" style="cursor: pointer; color: red;">x</span>
        `;

                // Append the new file upload row
                document.getElementById("fileUploadContainer").appendChild(newUploadRow);

                // Attach remove functionality to the new uploader's remove button
                document.getElementById(`removeBtn${uploadCount}`).addEventListener("click", function () {
                    removeFileUploader(newUploadRow.id);
                });
            } else {
                alert("You can only add up to 10 file uploads.");
            }
        });

        // Handle file upload validation
        function handleFileUpload(fileInput) {
            const allowedFiles = [".pdf"];
            const file = fileInput.files[0];
            const ext = file.name.split('.').pop().toLowerCase();

            // Validate file type
            if (!allowedFiles.includes(`.${ext}`)) {
                alert("Please select PDF files only.");
                resetFileInput(fileInput);
                return;
            }

            // Validate file size
            const size = file.size / 1024 / 1024; // Size in MB
            if (size > 1) {
                alert("File size exceeds 1 MB. Please upload a smaller file.");
                resetFileInput(fileInput);
                return;
            }
        }

        // Reset file input logic
        function resetFileInput(fileInput) {
            fileInput.value = ""; // Clear the input field
        }

        // Remove uploader logic
        function removeFileUploader(rowId) {
            document.getElementById(rowId).remove(); // Remove the entire row
            uploadCount--; // Decrement the upload count
        }


    </script>




</asp:Content>



