<%@ Page Title="" Language="C#" MasterPageFile="~/PMIST-Admin/Admin.master" AutoEventWireup="true" CodeFile="add-resource-for-researchers.aspx.cs" Inherits="PMIST_Admin_resourceforresearchersDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="panel-header bg-primary-gradient">
            <div class="page-inner py-5">
                <div class="d-flex pb-2 align-items-left align-items-md-center flex-column flex-md-row justify-content-between">
                    <div class="d-flex">
                        <h2 class="text-white mb-0 fw-bold text-uppercase">
                            <asp:Label ID="lbldisplayText" runat="server" Text=""></asp:Label>
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
                            <asp:HiddenField ID="hdnID" ClientIDMode="Static" runat="server" />
                            <div class="form-group">
                                <div class="form-border margin-top20">
                                    <div class="form-title">
                                        <h3>Resource for Researchers</h3>
                                    </div>
                                    <div class="row mx-0 margin-top20 mb-4">
                                        <div class="col-md-3 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Resource Type <span class="text-danger">*</span></label>
                                                <i class="bi bi-journal-bookmark-fill b5-icon"></i>
                                                <asp:DropDownList ID="ddlresearch" class="bs-select form-control input-sm" runat="server">
                                                    <asp:ListItem Selected="True" Value=""></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <span class="error">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddlresearch" ValidationGroup="FaqsVal" InitialValue="" runat="server" ErrorMessage="Select resource type"></asp:RequiredFieldValidator>
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
                                                <label>URL Title <span class="text-danger">*</span></label>
                                                <i class="bi bi-body-text b5-icon"></i>
                                                <asp:TextBox class="form-control capitalize-input" ClientIDMode="Static" ID="txttitle" placeholder="" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txttitle" ValidationGroup="FaqsVal" runat="server" ErrorMessage="Enter URL title"></asp:RequiredFieldValidator>
                                            </span>
                                        </div>

                                        <div class="col-md-8 pt-3">
                                            <div class="input-icon input-icon-sm right">
                                                <label>Link <span class="text-danger">*</span></label>
                                                <i class="bi bi-body-text b5-icon"></i>
                                                <asp:TextBox class="form-control capitalize-input" ClientIDMode="Static" ID="txtlink" placeholder="" runat="server"></asp:TextBox>
                                            </div>
                                            <span class="error">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtlink" ValidationGroup="FaqsVal" runat="server" ErrorMessage="Enter link"></asp:RequiredFieldValidator>
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

    <%--  <script>
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
    </script>--%>
    <script src="https://cdn.ckeditor.com/ckeditor5/32.0.0/classic/ckeditor.js"></script>

    <script>
        document.addEventListener("DOMContentLoaded", function () {
            ClassicEditor.create(document.querySelector(".editor"), {
                toolbar: [
                    "bold",
                    "italic",
                    "link",
                    "undo",
                    "redo",
                    "bulletedList",
                    "numberedList",
                    "specialCharacters",
                    "code",
                ],
                language: "en", // Ensure language support
                removePlugins: ["MediaEmbed"],
                link: {
                    decorators: {
                        addTargetBlank: {
                            mode: "automatic",
                            callback: (url) => true,
                            attributes: {
                                target: "_blank",
                                class: "anchor-link txt-sec-clr",
                            },
                        },
                    },
                },
            })
                .then((editor) => {
                    // Set initial value from the TextBox
                    editor.setData(document.getElementById("txtlink").value);

                    // Listen for changes to the document
                    editor.model.document.on("change:data", () => {
                        document.getElementById("txtlink").value = editor.getData();
                    });

                    // Modify links when they are inserted
                    editor.model.document.on("change:data", () => {
                        editor.model.change((writer) => {
                            const root = editor.model.document.getRoot();

                            // Iterate over all child nodes
                            for (const element of root.getChildren()) {
                                if (element.is("element", "paragraph")) {
                                    for (const child of element.getChildren()) {
                                        if (child.is("element", "a") && !child.getChild(0)?.is("element", "image")) {
                                            // Insert image inside the <a> tag
                                            const imageElement = writer.createElement("image", {
                                                src: "../assets/img/icon/link.svg",
                                                alt: "img",
                                                class: "img-fluid pe-2",
                                                width: "26px",
                                            });

                                            writer.insert(imageElement, child, 0);
                                        }
                                    }
                                }
                            }
                        });
                    });
                })
                .catch((error) => console.error(error));
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

