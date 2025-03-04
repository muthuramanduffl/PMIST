<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="viewDepartmentcourses old26 11.aspx.cs" Inherits="admin_account_about_ViewNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.13.2/themes/base/jquery-ui.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>View Department </h1>
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
            padding-left: 10px;
            text-align: center;
            padding-top: 12px;
            padding-bottom: 12px;
            padding-right: 10px;
        }

        table tbody tr td {
            /* padding-left: 11px; */
            text-align: center;
            word-break: break-word;
            padding: 15px 0px;
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
        }
    </style>

    <div class="uk-grid">
        <asp:ScriptManager ID="ScriptManager2" runat="server" />
        <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
            <div class="md-card">
                <div class="md-card-toolbar ">

                    <div>
                        <h3 class="md-card-toolbar-heading-text"><b>View Department
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
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <div class="md-input-wrapper" style="padding-top: 12px;">
                                                    <asp:DropDownList ID="ddlDepartment" CssClass="md-input" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged1" AutoPostBack="true" Style="border-width: 2px;" runat="server">
                                                        <asp:ListItem Value="">Select</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                                <asp:LinkButton Visible="false" class="btn btn-success btn-sm" ID="LinkButton1" OnClick="LinkButton1_Click" runat="server">Add</asp:LinkButton>

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
                                <%--                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" CssClass="mt-2" runat="server" ErrorMessage="Select Faculty" InitialValue="" ControlToValidate="ddlFaculty" ValidationGroup="val"></asp:RequiredFieldValidator>--%>
                                <span class="md-input-bar"></span>
                            </div>

                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3">
                                    <div class="md-input-wrapper md-input-filled" style="">
                                        <asp:Label ID="lblcheck" runat="server"></asp:Label>
                                        <div class="table-responsive">
                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                <ContentTemplate>
                                                    <asp:Repeater ID="rpruser" OnItemCommand="Repeater1_ItemCommand" runat="server">
                                                        <HeaderTemplate>
                                                            <table class="display table table-head-bg-info dataTable no-footer" id="basic-datatables" role="grid" aria-describedby="basic-datatables_info">
                                                                <thead>
                                                                    <tr>
                                                                        <th class="sorting_asc" style="width: 31.0625px;">S.No</th>
                                                                        <th style="min-width: 164px; width: max-content;" class="sorting ">Department</th>
                                                                        <th style="min-width: 164px; width: 164px;" class="sorting ">Introduction</th>
                                                                        <th style="min-width: 164px; width: 164px;" class="sorting ">Section Name</th>
                                                                        <th style="min-width: 122px; width: max-content;" class="sorting ">Content</th>
                                                                        <th style="min-width: 122px; width: max-content;" class="sorting ">Curriculum</th>
                                                                        <th style="min-width: 122px; width: max-content;" class="sorting ">Files</th>
                                                                        <th style="min-width: 122px; width: max-content;" class="sorting ">Added On</th>
                                                                        <th style="min-width: 222px; width: max-content;" class="sorting ">Action</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <tr>
                                                                <asp:HiddenField ID="HiddenField1" Value='<%# Eval("Sno") %>' runat="server" />
                                                                <td class=" d-flex align-items-center justify-content-start" style="width: 70px;">
                                                                    <span style="padding-left: 1px"><%# GetRowNo(Convert.ToString(Container.ItemIndex + 1))%></span>
                                                                </td>
                                                                <td class="text-left"><%#(Binddepartment(Convert.ToInt32(Eval("Department"))))%></td>
                                                                <td class="text-left">
                                                                    <asp:TextBox ID="txtIntroduction" CssClass="w-100 border-0 " Wrap="true" runat="server" Text='<%# string.IsNullOrEmpty(Eval("Introduction").ToString()) ? "-" : Eval("Introduction")%>' ReadOnly="true" Style="background: transparent;" /></td>
                                                                <td class="text-left"><%# Eval("SectionName") %></td>
                                                                <td class="text-left">
                                                                    <asp:TextBox ID="txtContent" CssClass="w-100 border-0 " Wrap="true" runat="server" Text='<%# string.IsNullOrEmpty(Eval("Content").ToString()) ? "-" : Eval("Content")%>' ReadOnly="true" Style="background: transparent;" /></td>
                                                                <td class="text-left">
                                                                    <asp:TextBox ID="txtCurriculum" CssClass="w-100 border-0 " Wrap="true" runat="server" Text=' <%# string.IsNullOrEmpty( Eval("Curriculum").ToString()) ? "-" :  Eval("Curriculum") %>' ReadOnly="true" Style="background: transparent;" />
                                                                </td>
                                                                <td class="text-left">
                                                                    <asp:LinkButton
                                                                        ID="btnview"
                                                                        runat="server"
                                                                        Text='<%# Eval("PDFName") != null && Eval("PDFName").ToString() != "" ? "View PDF" : "" %>'
                                                                        CommandName="ViewPDF"
                                                                        CssClass="md-btn md-btn-small md-btn-flat btn-info text-info"
                                                                        CommandArgument='<%# Eval("Sno") %>'
                                                                        Visible='<%# Eval("PDFName") != null && Eval("PDFName").ToString() != "" %>'>
                                                                    </asp:LinkButton>
                                                                    <asp:HiddenField ID="hdnfile" Value='<%# Eval("PDFName")%>' runat="server" />
                                                                    <asp:FileUpload ID="FileUpload1" Visible="false" runat="server" />

                                                                </td>

                                                                <td class="text-left"><%#Eval("Addeddate","{0:dd-MMM-yyyy}") %>  </td>
                                                                <th class="d-flex ">
                                                                    <asp:HiddenField ID="HiddenField2" Value='<%# Eval("Sno") %>' runat="server" />
                                                                    <asp:LinkButton CssClass="md-btn md-btn-small md-btn-flat md-btn-success" ID="Editbtn" runat="server" CommandName="Edit" Visible="true"
                                                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Sno") %>'>Edit</asp:LinkButton>
                                                                    <asp:LinkButton CssClass="md-btn md-btn-small md-btn-flat md-btn-success" ID="Delete" runat="server" CommandName="Delete" Visible="true"
                                                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Sno") %>'>Delete</asp:LinkButton>
                                                                    <asp:LinkButton class="btn btn-success btn-sm" ID="btnSave" runat="server" CommandName="Save" Visible="false"
                                                                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Sno") %>'>Save</asp:LinkButton>
                                                                </th>
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
        $(function () {
            var today = new Date();

            var maxDate = new Date(today.getFullYear() + 5, 11, 31);

            initializeDatePickers();

            function initializeDatePickers() {
                $("#txtfromdate").datepicker({
                    changeMonth: true,
                    changeYear: true,
                    dateFormat: 'dd/mm/yy',
                    onSelect: function (selectedDate) {
                        $("#txttodate").datepicker("option", "minDate", selectedDate);
                    }
                });

                $("#txttodate").datepicker({
                    changeMonth: true,
                    changeYear: true,
                    dateFormat: 'dd/mm/yy'
                });

                if ($('#txtfromdate').val()) {
                    $("#txtfromdate").datepicker("setDate", $('#txtfromdate').val());
                }

                if ($('#txttodate').val()) {
                    $("#txttodate").datepicker("setDate", $('#txttodate').val());
                }
            }

            function setDateLimits() {
                var status = $('#ddleventstatus').val();

                if (status === '0') {
                    var upcomingMinDate = today;
                    $("#txtfromdate, #txttodate").datepicker("option", {
                        minDate: upcomingMinDate,
                        maxDate: maxDate
                    });

                    validateAndSetDates(upcomingMinDate, maxDate);
                } else if (status === '1') {
                    var yesterday = new Date(today);
                    yesterday.setDate(today.getDate() - 1);

                    $("#txtfromdate, #txttodate").datepicker("option", {
                        minDate: null,
                        maxDate: yesterday
                    });

                    validateAndSetDates(null, yesterday);
                }
            }

            $('#ddleventstatus').on('change', function () {
                setDateLimits();
            });

            setDateLimits();

            function validateAndSetDates(minDate, maxDate) {
                var fromDate = $("#txtfromdate").datepicker("getDate");
                var toDate = $("#txttodate").datepicker("getDate");

                if (fromDate && (minDate && fromDate < minDate || maxDate && fromDate > maxDate)) {
                    $("#txtfromdate").datepicker("setDate", minDate || maxDate);
                }

                if (toDate && (minDate && toDate < minDate || maxDate && toDate > maxDate)) {
                    $("#txttodate").datepicker("setDate", minDate || maxDate);
                }
            }
        });

    </script>



    <!-- Include jQuery -->
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>



    <script src="https://code.jquery.com/ui/1.13.2/jquery-ui.min.js"></script>


    <script>

        $(document).ready(function () {
            $(".close").click(function () {
                $(".popupsuccess").css("display", "none");
            }
      });

    </script>

</asp:Content>

