<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="viewDepartment.aspx.cs" Inherits="admin_account_about_ViewNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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

    <div class="uk-grid">

        <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
            <div class="md-card">
                <div class="md-card-toolbar">
                    <h3 class="md-card-toolbar-heading-text"><b>View Department
                        <asp:Label ID="lblDisplayText" runat="server"></asp:Label></b>
                        <b style="padding-left: 120px">
                            <asp:PlaceHolder ID="phLiveUrl" runat="server"></asp:PlaceHolder>
                        </b>
                    </h3>
                </div>
                <div class="md-card-content large-padding" height="750px">
                    <div class="uk-grid uk-grid-divider uk-grid-medium">
                        <div class="uk-width-large-2-3">
                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3 w-auto">
                                </div>
                            </div>
                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3">
                                    <div class="md-input-wrapper md-input-filled" style="">
                                        <asp:Label ID="lblcheck" runat="server"></asp:Label>
                                        <div class="table-responsive">

                                            <asp:Repeater ID="rpruser" OnItemCommand="Repeater1_ItemCommand" runat="server">
                                                <HeaderTemplate>
                                                    <table class="display table table-head-bg-info dataTable no-footer" id="tblUsers role="grid" aria-describedby="basic-datatables_info">
                                                        <thead>
                                                            <tr>
                                                                <th class="sorting_asc" style="width: 31.0625px;">S.No</th>
                                                                <th style="min-width: 164px; width: max-content;" class="sorting ">Faculty</th>
                                                                <th style="min-width: 164px; width: 164px;" class="sorting ">Department</th>
                                                                <th style="min-width: 164px; width: 164px;" class="sorting ">status</th>


                                                                <th style="min-width: 122px; width: max-content;" class="sorting ">Action</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <asp:HiddenField ID="HiddenField1" Value='<%# Eval("DepartmentID") %>' runat="server" />
                                                        <td class=" d-flex align-items-center justify-content-start" style="width: 70px;">
                                                            <span style="padding-left: 1px"><%# GetRowNo(Convert.ToString(Container.ItemIndex + 1))%></span>
                                                        </td>

                                                        <td class="text-left"><%#(Eval("FacultyName").ToString())%></td>
                                                        <td class="text-left"><%# Eval("DepartmentName") %></td>



                                                        <td>

                                                            <asp:LinkButton ID="lnkStatus" runat="server" 
                                                                CommandArgument='<%# Eval("DepartmentID") %>'
                                                                CommandName="ToggleStatus" >
                                                  
                                                         
     <img src='<%# Convert.ToInt32(Eval("Status")) == 1 ? "/cmsadmin/images/tick.png" : "/cmsadmin/images/untick.png" %>'
                                                          alt='<%# Convert.ToInt32(Eval("Status")) == 1 ? "Active" : "Inactive" %>' 
                                                          style="width:16px; height:16px;" />
                                                            </asp:LinkButton>
                                                        </td>
                                                        <th class="d-flex">

                                                            <asp:LinkButton title="Edit" ID="lkedit" CssClass="md-btn md-btn-small md-btn-flat md-btn-success" runat="server" CommandName="Edit" Text="Edit"
                                                                CommandArgument='<%# DataBinder.Eval(Container.DataItem, "DepartmentID") %>'>
                                                            </asp:LinkButton>


                                                        </th>
                                                    </tr>
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    </tbody>
                    </table>
                   
                                                </FooterTemplate>
                                            </asp:Repeater>


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

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="PageScript" runat="Server">
</asp:Content>

