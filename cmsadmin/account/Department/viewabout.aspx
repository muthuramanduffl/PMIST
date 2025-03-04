<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="viewabout.aspx.cs" Inherits="admin_account_departmentabout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.13.2/themes/base/jquery-ui.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>View Department About</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" runat="Server">
    <script type="text/javascript">
        function confirmDelete() {
            return confirm('Are you sure you wish to delete this entry?');

        }
        function newPopup(url) {
            popupWindow = window.open(
                url, 'popUpWindow', 'height=700,width=800,left=10,top=10,resizable=yes,scrollbars=no,toolbar=no,menubar=no,location=no,directories=no,status=yes')
            return false;
        }
    </script>
    <!-- Add Bootstrap JavaScript -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.2/dist/js/bootstrap.bundle.min.js"></script>








    <style>
        /* table tbody tr th {
     padding-left: 11px;
     text-align:center;
}
 table tbody tr td {
     padding-left: 11px;
     text-align:center;
} */
        table tbody tr th {
            padding-left: 5px;
            text-align: center;
            padding-top: 6px;
            padding-bottom: 6px;
            padding-right: 5px;
        }

        table tbody tr td {
            /* padding-left: 11px; */
            text-align: center;
            word-break: break-word;
            padding: 5px 0px;
        }

        table {
            border-collapse: separate !important;
            border-spacing: 2px 0;
            width: 100%;
        }

            table table {
                width: auto;
                margin-top: 2%;
                margin-bottom: 3%;
            }

        .table-responsive {
            display: block;
            width: 100%;
            overflow-x: auto;
            /* height: 90vh; */
            /* overflow-y: hidden; */
        }

        .uk-width-large-3-3, .uk-width-large-2-3 {
            width: 100%;
        }

        tr table tr:last-child td {
            padding: 0px !important;
            margin: auto 2px;
        }

            tr table tr:last-child td a {
                color: #000;
                padding: .5rem .75rem;
                border: 1px solid #e2e5e9;
                border-radius: 100px;
            }

            tr table tr:last-child td span {
                background: #004A8F;
                color: #fff;
                padding: .5rem .75rem;
                border: 1px solid #004A8F;
                border-radius: 100px;
            }

        .w-auto {
            width: auto !important;
        }
    </style>

    <style>
        input:read-only {
            border: none;
        }

        input:not(:read-only) {
            border: 1px solid !important;
            padding: 10px !important;
            border: 1px solid #bcbbbb !important;
        }

        .table tbody tr td {
            border: 1px solid #cacaca !important;
        }

        thead tr th {
            padding: 10px;
            font-weight: 500;
        }



        .repeater-item {
            /* Enables flexbox */
            flex-direction: column; /* Aligns items in a column */
            justify-content: center; /* Centers content vertically */
            align-items: center; /* Centers content horizontally */
            min-height: 100px; /* Ensure there's enough space for centering */
            padding: 10px 20px; /* Dynamic top and bottom spacing */
            border: none; /* Optional: for better visibility */
            /* margin-bottom: 10px; */
            box-sizing: border-box; /* Include padding in height/width calculations */
        }

        .md-card .md-card-toolbar:after, .md-card .md-card-toolbar:before {
            content: " ";
            display: none;
        }


        .dynamic-textbox {
            resize: none;
            overflow: hidden;
            min-height: 50px;
            max-height: 200px;
            width: 100%;
            font-family: Arial, sans-serif;
            font-size: 14px;
            padding: 8px;
            border: none;
            border-radius: 4px;
            box-sizing: border-box;
        }

        .classic {
            position: relative;
        }

            .classic:after {
                content: "";
                position: absolute;
                width: 0px;
                height: 0px;
                top: 50%;
                right: 10px;
                z-index: 9999;
                border-left: 5px solid transparent;
                border-right: 5px solid transparent;
                border-top: 10px solid #000;
            }
    </style>

    <div class="uk-grid">
        <asp:ScriptManager ID="ScriptManager2" runat="server" />
        <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
            <div class="md-card">
                <div class="md-card-toolbar " style="display: flex; justify-content: space-between; height: auto; flex-wrap: wrap;">

                    <div>
                        <h3 class="md-card-toolbar-heading-text"><b>View Department About
                        <asp:Label ID="lblDisplayText" runat="server"></asp:Label></b>
                            <b style="padding-left: 120px">
                                <asp:PlaceHolder ID="phLiveUrl" runat="server"></asp:PlaceHolder>
                            </b>
                        </h3>
                    </div>
                    <div class="md-card-toolbar-heading-text align-self-end">
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>
                                <p>
                                    Total:<asp:Label ID="Lblcount" runat="server"></asp:Label>
                                    <p>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="ddlDepartment" EventName="SelectedIndexChanged" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </div>
                    <div class="md-card-toolbar-heading-text align-self-end">
                        <a class="btn btn-success btn-sm" href="add-about.aspx">Add Department About</a>

                    </div>


                </div>
                <div class="md-card-content large-padding" height="750px">
                    <div class="uk-grid uk-grid-divider uk-grid-medium">
                        <div class="uk-width-large-2-3">
                            <div class="uk-grid uk-grid-small">
                            </div>


                            <div class="md-input-wrapper" id="dvTitle" runat="server" style="padding-top: 9px">
                                <div class="d-flex">
                                    <!-- Department Dropdown -->
                                    <div class="uk-width-large-3-6">
                                        <label>Department *</label>
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="" style="display: flex; align-items: center; gap: 20px;">
                                                    <div class="md-input-wrapper classic" style="padding-top: 12px;">
                                                        <asp:DropDownList ID="ddlDepartment" CssClass="md-input " OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged1" AutoPostBack="true" Style="border-width: 2px;" runat="server">
                                                            <asp:ListItem Value="">Select</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </div>
                                                    <asp:LinkButton Visible="false" class="md-btn md-btn-small md-btn-flat md-btn-success" ID="LinkButton1" OnClick="LinkButton1_Click" runat="server">Add</asp:LinkButton>
                                                </div>

                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="ddlDepartment" EventName="SelectedIndexChanged" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </div>

                                    <!-- Placeholder for Additional UI -->
                                    <div class="uk-width-large-2-6 " style="display: none">
                                        <asp:LinkButton class="btn btn-success btn-sm" ID="BTNGo" OnClick="BTNGo_Click" runat="server">GO</asp:LinkButton>
                                    </div>
                                    <div class="uk-width-large-3-3 " style="display: none">
                                        <label>From date *</label>
                                        <div class="md-input-wrapper" id="dvFromDate" runat="server" style="padding-top: 12px">
                                            <asp:TextBox ID="TxtFromdate" type="date" placeholder="DD-MM-YYYY" ClientIDMode="Static" runat="server" CssClass="md-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="uk-width-large-3-6" style="display: none">
                                        <label>To date *</label>
                                        <div class="md-input-wrapper" id="dvtodate" runat="server" style="padding-top: 12px">
                                            <asp:TextBox ID="txttodate" type="Date" placeholder="DD-MM-YYYY" ClientIDMode="Static" runat="server" CssClass="md-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" CssClass="mt-2" runat="server" ErrorMessage="Select Faculty" InitialValue="" ControlToValidate="ddlFaculty" ValidationGroup="val"></asp:RequiredFieldValidator>--%>
                                <span class="md-input-bar"></span>
                            </div>

                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3">
                                    <div class="md-input-wrapper md-input-filled" style="">
                                        <asp:Label ID="lblcheck" runat="server"></asp:Label>
                                        <div class="table-responsive">
                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                <ContentTemplate>
                                                    <asp:Repeater ID="rpruser" OnItemCommand="Repeater1_ItemCommand" OnItemDataBound="rpruser_ItemDataBound" runat="server">
                                                        <HeaderTemplate>
                                                            <table class="display table table-head-bg-info dataTable no-footer" id="tblUsers" role="grid" aria-describedby="basic-datatables_info" style="border-collapse: collapse !important;">
                                                                <thead>
                                                                    <tr style="background: #16accd !important; color: #fff !important;">
                                                                        <th class="sorting_asc" style="width: 31.0625px;">S.No</th>
                                                                        <th style="min-width: 164px; width: max-content;" class="sorting ">Department</th>
                                                                        <%-- <th style="min-width: 240px; width: 164px;" class="sorting ">Introduction</th>--%>
                                                                        <th style="min-width: 204px; width: 164px;" class="sorting ">Section Name</th>
                                                                        <th style="min-width: 240px; width: max-content;" class="sorting ">Content</th>
                                                                        <%--<th style="min-width: 222px; width: max-content;" class="sorting ">Curriculum</th>--%>

                                                                        <th style="min-width: 122px; width: max-content;" class="sorting ">Added On</th>
                                                                        <th style="min-width: 222px; width: max-content; align-content: center" class="sorting ">Action</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <tr>
                                                                <asp:HiddenField ID="HiddenField1" Value='<%# Eval("AID") %>' runat="server" />
                                                                <td class=" d-flex align-items-center justify-content-start" style="width: 70px;">
                                                                    <span style="padding-left: 1px"><%# GetRowNo(Convert.ToString(Container.ItemIndex + 1))%></span>
                                                                </td>
                                                                <td class="text-left"><%#(Binddepartment(Convert.ToInt32(Eval("Department"))))%></td>

                                                                <td class="text-left"><%# Eval("SectionName") %></td>
                                                                <td class="text-left">
                                                                    <asp:HiddenField ID="HiddenField3" Value='<%# Eval("SectionName") %>' runat="server" />
                                                                    <asp:Label ID="lblcontent" runat="server" Text='<%# Eval("Content") %>'></asp:Label>
                                                                    <asp:TextBox
                                                                        ID="txtContent"
                                                                        TextMode="MultiLine" Visible="false"
                                                                        CssClass="w-100 border-0 input-cus dynamic-textbox atag_link readonly-textbox"
                                                                        Wrap="true"
                                                                        runat="server"
                                                                        Text='<%# string.IsNullOrEmpty(Eval("Content").ToString()) ? "-" : Eval("Content") %>'
                                                                        ReadOnly="true"
                                                                        Style="background: transparent; text-align: center;" />

                                                                </td>

                                                                <td class="text-left"><%#Eval("Addeddate","{0:dd-MMM-yyyy}") %>  </td>
                                                                <td class="d-flex repeater-item" style="align-items: center; justify-content: center; gap: 14px; flex-direction: row;">
                                                                    <asp:HiddenField ID="HiddenField2" Value='<%# Eval("AID") %>' runat="server" />
                                                                    <asp:LinkButton CssClass="md-btn md-btn-small md-btn-flat md-btn-success" ID="Editbtn" runat="server" CommandName="Edit" Visible="true"
                                                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "AID") %>'>Edit</asp:LinkButton>
                                                                    <asp:LinkButton CssClass="md-btn md-btn-small md-btn-flat md-btn-danger" ID="Delete" runat="server" OnClientClick='javascript:return confirm("Are you sure you want to delete?")' CommandName="Delete" Visible="true"
                                                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "AID") %>'>Delete</asp:LinkButton>
                                                                    <asp:LinkButton class="btn btn-success btn-sm" ID="btnSave" runat="server" CommandName="Save" Visible="false"
                                                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "AID") %>'>Save</asp:LinkButton>
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

                                                    <asp:AsyncPostBackTrigger ControlID="ddlDepartment" EventName="SelectedIndexChanged" />
                                                </Triggers>
                                            </asp:UpdatePanel>
                                        </div>
                                        <div style="padding-top: 25px"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Modal HTML -->
    <div class="modal popupsuccess" runat="server" id="success" tabindex="-1" style="display: none" role="dialog">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Success</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p id="popupMessage">Updated Sccessfully!.</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="PageScript" runat="Server">

    <script>
        document.addEventListener("DOMContentLoaded", function () {
            document.querySelectorAll(".atag_link a").forEach(aTag => {
                aTag.setAttribute("target", "_blank");
                aTag.style.color = "blue";
            });
        });
    </script>

    <script src="https://cdn.ckeditor.com/ckeditor5/32.0.0/classic/ckeditor.js"></script>

    <script>

        document.addEventListener('DOMContentLoaded', function () {
            initEditors(); // Initialize CKEditor on page load
        });

        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
            initEditors(); // Ensure CKEditor loads after an AJAX request (if using UpdatePanel)
        });

        function initEditors() {
            document.querySelectorAll('.editor').forEach(textarea => {
                ClassicEditor
                    .create(textarea, {
                        toolbar: [
                            'bold', 'italic', 'link', 'undo', 'redo',
                            'bulletedList', 'numberedList',
                            'specialCharacters', 'code'
                        ],
                        language: 'en',
                        removePlugins: ['MediaEmbed']
                    })
                    .then(editor => {
                        if (textarea.hasAttribute("data-readonly")) {
                            editor.enableReadOnlyMode("readonly-mode"); // Enable read-only mode
                        }

                        editor.model.document.on('change:data', () => {
                            textarea.value = editor.getData(); // Sync the content
                        });
                    })
                    .catch(error => console.error(error));
            });
        }


    </script>




    <script>
        function adjustHeight(textBox) {
            textBox.style.height = "auto";

            const scrollHeight = textBox.scrollHeight;
            const maxHeight = 200;

            textBox.style.height = Math.min(scrollHeight, maxHeight) + "px";
        }

        function bindDynamicTextbox() {
            document.querySelectorAll('.dynamic-textbox').forEach(function (textBox) {
                textBox.removeEventListener('input', handleInput); // Remove existing event to avoid duplication
                textBox.addEventListener('input', handleInput);

                adjustHeight(textBox);
            });
        }

        function handleInput(event) {
            adjustHeight(event.target);
        }

        // Bind the event on page load
        document.addEventListener('DOMContentLoaded', bindDynamicTextbox);

        // Re-bind the event after an UpdatePanel partial postback
        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
            bindDynamicTextbox();
        });
    </script>


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

        $(document).ready(function () {
            $(".close").click(function () {
                $(".popupsuccess").css("display", "none");
            });
        });

    </script>

</asp:Content>

