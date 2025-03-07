﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PMIST-Admin/Admin.master" AutoEventWireup="true" CodeFile="add-faqs.aspx.cs" Inherits="PMIST_Admin_Default" %>

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
                                        <h3>FAQ's Details</h3>
                                    </div>
                                    <div class="row mx-0 margin-top20 mb-4">
                                        <div class="col-md-3 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Department <span class="text-danger">*</span></label>
                                                <i class="bi bi-journal-bookmark-fill b5-icon"></i>
                                                <asp:DropDownList ID="ddldepartment" class="bs-select form-control input-sm" runat="server">
                                                    <asp:ListItem Selected="True" Value=""></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <span class="error">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddldepartment" ValidationGroup="FaqsVal" InitialValue="" runat="server" ErrorMessage="Select department"></asp:RequiredFieldValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-6 pt-3">
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
                                        <div class="col-md-4 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Question <span class="text-danger">*</span></label>
                                                <i class="bi bi-person-raised-hand b5-icon"></i>
                                                <textarea class="form-control capitalize-input" rows="4" cols="50" id="txtquetion" placeholder="" runat="server"></textarea>
                                                <!-- <span class="handle-file-request">(maximum 200 characters)</span> -->
                                            </div>
                                            <span class="error">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtquetion" ValidationGroup="FaqsVal" runat="server" ErrorMessage="Enter question"></asp:RequiredFieldValidator>
                                            </span>
                                        </div>
                                        <div class="col-md-8 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Answer <span class="text-danger">*</span></label>
                                                <i class="bi bi-body-text b5-icon"></i>
                                                <asp:TextBox class="form-control capitalize-input editor" ClientIDMode="Static" ValidateRequestMode="Disabled" Rows="4" ID="txtans" cols="50" placeholder="" TextMode="MultiLine" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtans" ValidationGroup="FaqsVal" runat="server" ErrorMessage="Enter answer"></asp:RequiredFieldValidator>
                                            </span>
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
                                <asp:Button ID="btnCancel" runat="server" Text="Cancel Project" OnClick="btnCancel_Click" Style="display: none;" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        document.getElementById('<%= txtquetion.ClientID %>').addEventListener('keydown', function (e) {
            var key = e.key;
            var validPattern = /^[A-Za-z0-9\s@#.,?()-]+$/;
            if (!validPattern.test(key) && e.keyCode !== 8) {
                e.preventDefault();
            }
        });
        document.getElementById('<%= txtans.ClientID %>').addEventListener('keydown', function (e) {
            var key = e.key;
            var validPattern = /^[A-Za-z0-9\s@#.,?()\-!]+$/;

            if (!validPattern.test(key) && e.keyCode !== 8) {
                e.preventDefault();
            }
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
                            { model: 'heading2', view: 'h2', title: 'Heading 2', class: 'ck-heading_heading2' },
                            { model: 'heading3', view: 'h3', title: 'Heading 3', class: 'ck-heading_heading3' },
                            { model: 'heading4', view: 'h4', title: 'Heading 4', class: 'ck-heading_heading4' },
                            { model: 'heading5', view: 'h5', title: 'Heading 5', class: 'ck-heading_heading5' },
                            { model: 'heading6', view: 'h6', title: 'Heading 6', class: 'ck-heading_heading6' }
                        ]
                    },
                    language: 'en',
                    removePlugins: ['MediaEmbed']
                })
                .then(editor => {
                    editor.model.document.on('change:data', () => {
                        document.getElementById('<%= txtans.ClientID %>').value = editor.getData();
                   });
               })
               .catch(error => console.error(error));
       });
    </script>


    <script type="text/javascript">
        function validatePage() {
            var flag = Page_ClientValidate('FaqsVal')
            return flag;
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
                        // Trigger the ASP.NET Button click to handle postback
                        document.getElementById('<%= btnCancel.ClientID %>').click();
                    } else if (result.dismiss === Swal.DismissReason.cancel) {
                        // User clicked 'No' 
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

</asp:Content>

