<%@ Page Title="" Language="C#" MasterPageFile="~/PMIST-Admin/Admin.master" AutoEventWireup="true" CodeFile="view-CSAS.aspx.cs" Inherits="PMIST_Admin_view_faqs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="panel-header bg-primary-gradient">
            <div class="page-inner py-5">
                <div class="d-flex pb-2 align-items-left align-items-md-center flex-column flex-md-row justify-content-between">
                    <div class="d-flex">
                        <h2 class="text-white mb-0 fw-bold text-uppercase">View CSAS</h2>
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
                            <div class="form-group p-0">
                                <div class="row mb-4">
                                    <div class="col-md-3 pt-3">
                                        <div class="input-icon input-icon-sm right">
                                            <label>Centre Name </label>
                                            <i class="bi bi-journal-bookmark-fill b5-icon"></i>
                                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList ID="ddldepartment" class="bs-select form-control input-sm" AutoPostBack="true" OnSelectedIndexChanged="ddldepartment_SelectedIndexChanged" runat="server">
                                                        <asp:ListItem Selected="True" Value=""></asp:ListItem>
                                                    </asp:DropDownList>
                                                </ContentTemplate>
                                                <Triggers>
                                                    <asp:AsyncPostBackTrigger ControlID="ddldepartment" EventName="SelectedIndexChanged" />
                                                    <asp:AsyncPostBackTrigger ControlID="btncancel" EventName="Click" />
                                                </Triggers>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>

                                    <div class="col-md-2 pt-3">
                                        <div class="input-icon input-icon-sm right">
                                            <label>Display Status </label>
                                            <i class="bi bi-check2-square b5-icon"></i>
                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList ID="ddlstatus" class="bs-select form-control input-sm" AutoPostBack="true" OnSelectedIndexChanged="ddlstatus_SelectedIndexChanged" runat="server">
                                                        <asp:ListItem Value="">All</asp:ListItem>
                                                        <asp:ListItem Value="1">Active</asp:ListItem>
                                                        <asp:ListItem Value="0">Inactive</asp:ListItem>
                                                    </asp:DropDownList>
                                                </ContentTemplate>
                                                <Triggers>
                                                    <asp:AsyncPostBackTrigger ControlID="ddlstatus" EventName="SelectedIndexChanged" />
                                                    <asp:AsyncPostBackTrigger ControlID="ddldepartment" EventName="SelectedIndexChanged" />
                                                    <asp:AsyncPostBackTrigger ControlID="btncancel" EventName="Click" />
                                                </Triggers>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                    <div class="col-md-2 pt-3 d-flex add-bs-1">
                                        <asp:UpdatePanel ID="UpdatePanel3" UpdateMode="Conditional" runat="server">
                                            <ContentTemplate>
                                                <asp:LinkButton class="b5-icon-reset" data-bs-toggle="tooltip" title="Reset" OnClick="lnkcancel_Click" ID="btncancel" runat="server">                                       
                                            <i class="bi bi-repeat"></i>                                   
                                                </asp:LinkButton>
                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="ddlstatus" EventName="SelectedIndexChanged" />
                                                <asp:AsyncPostBackTrigger ControlID="ddldepartment" EventName="SelectedIndexChanged" />
                                                <asp:AsyncPostBackTrigger ControlID="btncancel" EventName="Click" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                    <ContentTemplate>
                                        <h5 id="h5TotalNoCount" runat="server"><span class="box-b-only p-1">Total no. of Count :
                                    <asp:Label ID="lblcount" runat="server" Text=""></asp:Label></span></h5>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="ddlstatus" EventName="SelectedIndexChanged" />
                                        <asp:AsyncPostBackTrigger ControlID="ddldepartment" EventName="SelectedIndexChanged" />
                                        <asp:AsyncPostBackTrigger ControlID="btncancel" EventName="Click" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </div>
                            <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>
                                    <div class="text-center no-data-found" clientidmode="Static" id="DivNoDataFound" runat="server" style="display: none;">
                                        <h4 class="mb-0 text-secondary pt-5 pb-4">
                                            <img src="https://demo.pmu.edu/PMIST-admin/assets/img/no-data.png" alt="img" class="img-fluid" />
                                            No Data Found</h4>
                                    </div>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlstatus" EventName="SelectedIndexChanged" />
                                    <asp:AsyncPostBackTrigger ControlID="ddldepartment" EventName="SelectedIndexChanged" />
                                    <asp:AsyncPostBackTrigger ControlID="btncancel" EventName="Click" />
                                </Triggers>
                            </asp:UpdatePanel>

                            <div class="table-responsive">
                                <asp:UpdatePanel ID="UpdatePanel5" UpdateMode="Conditional" runat="server">
                                    <ContentTemplate>
                                        <asp:Repeater ID="rpruser" OnItemCommand="Repeater1_ItemCommand" OnItemDataBound="OnItemDataBound" runat="server">
                                            <HeaderTemplate>
                                                <table class="table table-bordered" id="tblUsers" role="grid" aria-describedby="basic-datatables_info">
                                                    <thead>
                                                        <tr>
                                                            <th class="w-sno">#</th>
                                                            <th class="min-w-300">Centre Name</th>
                                                            <th class="min-w-300">Title</th>
                                                            <th style="width:450px; display:none;">Content</th> 
                                                            <th class="min-w-150">Display Status</th>
                                                            <th class="min-w-150">Images </th>
                                                            <th class="min-w-150">Action </th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <asp:HiddenField ID="HiddenField1" Value='<%# Eval("TCCID") %>' runat="server" />

                                                    <th style="color: black !important">
                                                        <asp:Label ID="lblRowNumber" runat="server" />
                                                    </th>

                                                    <td><%# GetCentrename(Convert.ToInt32(Eval("CentreID"))) %>  </td>

                                                    <td>
                                                        <div class="view-paragraphs atag_link"><%# Eval("Title")%></div>
                                                    </td>

                                                    <td style="display:none">
                                                        <div class="view-paragraphs  atag_link"><%# Eval("Content")%></div>
                                                    </td>

                                                    <td>
                                                        <div class="">
                                                            <%# Convert.ToInt32(Eval("DisplayStatus")) == 1 ? 
                                                         "<div class='fw-bold'>Active</div>" :
                                                         "<div '>Inactive </div> " %>
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton class="edit-img me-3" ID="LinkButton1" runat="server" CommandName="view"
                                                            CommandArgument='<%# DataBinder.Eval(Container.DataItem, "TCCID") %>'>
<i class="bi bi-pencil-square b5-icon-et-dlt" data-bs-toggle="tooltip" aria-label="Edit" data-bs-original-title="Edit"></i>
                                                        </asp:LinkButton>

                                                    </td>
                                                    <td>
                                                        <asp:LinkButton class="edit-img me-3" ID="lkedit" runat="server" CommandName="Edit"
                                                            CommandArgument='<%# DataBinder.Eval(Container.DataItem, "TCCID") %>'>
                                                       <i class="bi bi-pencil-square b5-icon-et-dlt" data-bs-toggle="tooltip" aria-label="Edit" data-bs-original-title="Edit"></i>
                                                        </asp:LinkButton>
                                                        <a class="swtAltCancel">
                                                            <i class="bi bi-trash b5-icon-et-dlt" data-bs-toggle="tooltip" aria-label="Delete" data-bs-original-title="Delete"></i>
                                                        </a>
                                                        <asp:LinkButton ID="LinkButton2" CausesValidation="false" runat="server" class="dlt-img hidden" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("TCCID") %>' Style="display: none">
                                                        </asp:LinkButton>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                            <FooterTemplate>
                                                </tbody>
                                                </table>               
                                            </FooterTemplate>
                                        </asp:Repeater>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="ddlstatus" EventName="SelectedIndexChanged" />
                                        <asp:AsyncPostBackTrigger ControlID="ddldepartment" EventName="SelectedIndexChanged" />
                                        <asp:AsyncPostBackTrigger ControlID="btncancel" EventName="Click" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </div>


                            <div id="fileUploaderModal" runat="server" clientidmode="Static" class="modal" style="display: none;">
                                <div class="modal-dialog modal-dialog-centered">
                                    <div class="modal-content px-5 py-4">
                                        <div class="modal-header border-0 justify-content-center">
                                            <h3 class="fw-bold m-0 p-0 text-black" id="modalLabel">Upload File</h3>
                                            <div class="btn-close-icon" onclick="closeModal()" aria-label="Close" style="cursor: pointer; position: absolute; top: 16px; right: 14px;">
                                                <p style="margin-left: 9px; margin-top: 1px">X</p>
                                            </div>
                                        </div>
                                        <asp:Repeater ID="Repimage" OnItemCommand="Repeater1_ItemCommandimage"
                                            OnItemDataBound="OnItemDataBoundimage" runat="server">
                                            <ItemTemplate>
                                                <div class="modal-body border-0 p-0">
                                                    <asp:HiddenField ID="hdnProgressID" ClientIDMode="Static" runat="server" />
                                                    <asp:HiddenField ID="hdnImagePath" ClientIDMode="Static" runat="server" Value='<%# Eval("Imges") %>' />

                                                    <asp:FileUpload ID="FileUpload1" ClientIDMode="Static" accept=".jpeg, .jpg, .png" onchange="return fileValidation()"
                                                        runat="server" class="form-control input-sm file-upload" Visible="false" />
                                                    <asp:HiddenField ID="hfFileCount" ClientIDMode="Static" Value="0" runat="server" />
                                                    <div class="image-container">
                                                        <asp:PlaceHolder ID="imageContainer" runat="server"></asp:PlaceHolder>
                                                        <asp:HiddenField ID="hdnsingleimage" ClientIDMode="Static" runat="server" />
                                                    </div>
                                                        <asp:HiddenField ClientIDMode="Static" ID="hdnaddremiderimages" Value="0" runat="server" />
                                                    <asp:Label ID="lblErrorMessage" CssClass="lblErrorMessage" runat="server" Text="" ForeColor="#D41111"></asp:Label>
                                                    <span class="handle-file-request">(max file size of 500 KB)</span>
                                                    <span class="error-label" style="color: #D41111"></span>
                                                    <span class="error">
                                                        <asp:RequiredFieldValidator
                                                            ID="RequiredFieldValidator5"
                                                            runat="server"
                                                            ControlToValidate="FileUpload1"
                                                            ErrorMessage="Upload image"
                                                            ValidationGroup='<%# "val" + Container.ItemIndex %>' />
                                                    </span>
                                                </div>

                                                <div class="modal-footer m-0 p-0 justify-content-center border-0">
                                                    <asp:LinkButton ID="btnAdd" ClientIDMode="AutoID" ValidationGroup="val"
                                                        OnClientClick="if (validatePage1()) { 
                        this.value='Please wait..'; this.style.display='none'; 
                        document.getElementById('bWait1').style.display = ''; 
                    } else { return false; }"
                                                        CommandName="Update"
                                                        CommandArgument='<%# Eval("TCCID") %>'
                                                        runat="server" class="btn btn-sm me-1 handle-btn-success add-btn">
                Submit
                                                    </asp:LinkButton>

                                                    <asp:Button ID="btnToggleUpload" ClientIDMode="Static" runat="server" Text="Edit"
                                                        CommandName="ToggleUpload" CommandArgument='<%# Eval("TCCID") %>'
                                                        CssClass="btn btn-sm btn-primary" />

                                                    <button type="button" style="display: none" id="bWait1"
                                                        class="btn btn-secondary btn-sm me-1">
                                                        <i class='fa fa-spinner fa-spin'></i>Please Wait
                                                    </button>
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                </div>
                            </div>


                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="https://demo.pmu.edu/PMIST-admin/assets/js/core/jquery.3.2.1.min.js"></script>
    <script src="https://cdn.datatables.net/1.11.5/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript">
        var $jq = jQuery.noConflict();
        $jq(document).ready(function () {
            function initDataTable() {
                var table = $jq('#tblUsers').DataTable({
                    "pageLength": 10,
                    "bSort": false,
                    "paging": true
                });

                $jq('#tblUsers_info').hide();
                var rowCount = table.rows().count();
                if (rowCount <= 10) {
                    table.page.len(rowCount).draw();
                    $jq('.dataTables_paginate').hide();
                } else {
                    $jq('.dataTables_paginate').show();
                }
            }
            initDataTable();
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_endRequest(function (sender, args) {
                // Re-initialize the DataTable after UpdatePanel update
                setTimeout(function () {
                    initDataTable();
                }, 100);
            });
        });
    </script>



    <script>
        //$(document).ready(function () {
        //    // Initialize the label message
        //    updateImageLabel();
        //});

        function fileValidation() {
            var fileInput = document.getElementById('FileUpload1');
            var files = fileInput.files;
            var hfFileCount = document.getElementById('hfFileCount').value;  // Get the value of hfFileCount
            var hdnaddremiderimages = document.getElementById('hdnaddremiderimages').value;  // Get the value of already uploaded images
            var lblErrorMessage = document.querySelector('.lblErrorMessage');  // Use querySelector to select the first element with this class
            //document.getElementById("dvoldImage").style.display = "none";
            //document.getElementById("imgTherapyImage").src = '';

            var allowedImageTypes = ['image/jpeg', 'image/jpg', 'image/png'];
            var allowedExtensions = ['jpg', 'jpeg', 'png'];
            var maxFileSize = 500 * 1024; // 500 KB
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
                    lblErrorMessage.textContent = 'File size is too high, please select a file smaller than 500 KB.';
                    fileInput.value = '';
                    updateImageLabel();
                    return false;
                }
            }

            updateImageLabel();
            return true;
        }


        function updateImageLabel() {
            var fileInput = document.getElementById('FileUpload1');
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



    <script>
        document.addEventListener("DOMContentLoaded", function () {
            document.querySelectorAll(".atag_link a").forEach(aTag => {
                aTag.setAttribute("target", "_blank");
                aTag.style.color = "blue";
            });
        });
    </script>
    <script>
        function initializeDeleteEvents() {
            const cancelButtons = document.querySelectorAll('.swtAltCancel');

            cancelButtons.forEach((cancelButton) => {
                cancelButton.addEventListener('click', function () {
                    const linkButton = this.closest('tr')?.querySelector('.dlt-img.hidden');
                    Swal.fire({
                        title: 'Are you sure you want to delete?',
                        showCancelButton: true,
                        confirmButtonText: 'Yes',
                        cancelButtonText: 'No',
                        customClass: {
                            title: 'handle-info-pt',
                            confirmButton: 'handle-btn-danger',
                            cancelButton: 'handle-btn-success',
                        }
                    }).then((result) => {
                        if (result.isConfirmed && linkButton) {
                            linkButton.click();
                        } else if (result.dismiss === Swal.DismissReason.cancel) {
                            //Your project has not been deleted.
                        }
                    });
                });
            });
        }
        // Attach events on page load
        document.addEventListener('DOMContentLoaded', function () {
            initializeDeleteEvents();
        });

        // Attach events after UpdatePanel updates
        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
            initializeDeleteEvents();
        });
    </script>



    <script>

        function openModal() {
            document.getElementById('fileUploaderModal').style.display = 'block';
        }


        function closeModal() {
            document.getElementById('fileUploaderModal').style.display = 'none';
        }
    </script>



</asp:Content>
