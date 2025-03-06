<%@ Page Title="" Language="C#" MasterPageFile="~/PMIST-Admin/Admin.master" AutoEventWireup="true" CodeFile="add-research.aspx.cs" Inherits="addresearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .custom-width {
            width: 500px; /* Adjust as needed */
            max-width: 100%; /* Ensures it is responsive */
        }
    </style>
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
                                        <h3>Research Details</h3>
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

                                        <div class="col-md-8 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Content <span class="text-danger">*</span></label>
                                                <i class="bi bi-body-text b5-icon"></i>
                                                <asp:TextBox class="form-control capitalize-input editor custom-width " ClientIDMode="Static" ValidateRequestMode="Disabled" Rows="8" ID="txtcontent" placeholder="" TextMode="MultiLine" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtcontent" ValidationGroup="FaqsVal" runat="server" ErrorMessage="Enter content"></asp:RequiredFieldValidator>
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
                            { model: 'paragraph', view: 'p', title: 'Paragraph' },
                            { model: 'heading1', view: { name: 'h1', classes: 'placement-heading m-0' }, title: 'Heading 1' },
                            
                        ]
                    },
                    language: 'en',
                    removePlugins: ['MediaEmbed']
                })
                .then(editor => {
                    const conversion = editor.conversion;

                    // 🔥 Downcast: Add class to <p> elements
                    conversion.for('downcast').add(dispatcher => {
                        dispatcher.on('insert:paragraph', (evt, data, conversionApi) => {
                            const viewWriter = conversionApi.writer;
                            const viewElement = conversionApi.mapper.toViewElement(data.item);

                            if (viewElement) {
                                viewWriter.addClass('placement-content pb-4', viewElement);
                            }
                        });
                    });

                    // 🔥 Upcast: Ensure class is recognized in the editor
                    conversion.for('upcast').elementToElement({
                        view: {
                            name: 'p',
                            classes: 'placement-content pb-4'
                        },
                        model: 'paragraph'
                    });

                    // 🔥 Ensure data is updated
                    editor.model.document.on('change:data', () => {
                        document.getElementById('<%= txtcontent.ClientID %>').value = editor.getData();
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

