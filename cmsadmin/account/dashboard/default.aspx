<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="admin_account_dashboard_default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Dashboard</h1>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" runat="Server">

    <div class="uk-grid uk-grid-width-large-1-1 uk-grid-width-medium-1-1 uk-grid-medium uk-sortable sortable-handler" data-uk-sortable="" data-uk-grid-margin="">
        <div>
            <div class="md-card">
                <div class="md-card-content" style="display: flex; justify-content: space-between;">
                    <p style="margin: 0px;"><b>DATE :</b> <span id='date'></span></p>
                    <p style="margin: 0px;"><b>TIME :</b> <span id='hour'></span></p>
                 </div>
            </div>
        </div>
    </div>

    <div class="uk-grid uk-grid-width-large-1-3 uk-grid-width-medium-1-2 uk-grid-medium uk-sortable sortable-handler" data-uk-sortable="" data-uk-grid-margin="">
        <div>
            <div class="md-card">
                <div class="md-card-content">
                    <div class="uk-float-right uk-margin-top uk-margin-small-right">
                      <span class="fa fa-newspaper-o" style="font-size: 32px;"></span>
                    </div>
                    <span class="uk-text-muted uk-text-small">Events</span>
                    <h2 class="uk-margin-remove"><span class="countUpMe"><asp:Label ID="lblEventsCount" runat="server"></asp:Label> <small>Events</small></span></h2>
                </div>
            </div>
        </div>


        <div>
            <div class="md-card">
                <div class="md-card-content">
                    <div class="uk-float-right uk-margin-top uk-margin-small-right">
                        <span class="fa fa-picture-o" style="font-size: 32px;"></span>
                    </div>
                    <span class="uk-text-muted uk-text-small">Albums</span>
                    <h2 class="uk-margin-remove"><span class="countUpMe"><asp:Label ID="lblAlbumCount" runat="server"></asp:Label> <small>Albums</small></span></h2>
                </div>
            </div>
        </div>

        <div>
            <div class="md-card">
                <div class="md-card-content">
                    <div class="uk-float-right uk-margin-top uk-margin-small-right">
                        <span class="fa fa-play-circle-o" style="font-size: 32px;"></span>
                    </div>
                    <span class="uk-text-muted uk-text-small">Videos</span>
                    <h2 class="uk-margin-remove"><span class="countUpMe"><asp:Label ID="lblVideo" runat="server"></asp:Label> <small>Videos</small></span></h2>
                </div>
            </div>
        </div>
    </div>

    <%--<div class="uk-grid">
        <div class="uk-width-1-1">
            <div class="md-card">
                <div class="md-card-toolbar">
                    <div class="md-card-toolbar-actions">
                        <i class="md-icon material-icons md-card-fullscreen-activate"></i>
                        <i class="md-icon material-icons"></i>
                        <div class="md-card-dropdown" data-uk-dropdown="" aria-haspopup="true" aria-expanded="false">
                            <i class="md-icon material-icons"></i>
                            <div class="uk-dropdown uk-dropdown-flip uk-dropdown-small">
                                <ul class="uk-nav">
                                    <li><a href="#">For Week</a></li>
                                    <li><a href="#">For Month</a></li>
                                    <li><a href="#">For Year</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <h3 class="md-card-toolbar-heading-text">Monthly Update Progress</h3>
                </div>
                <div class="md-card-content">
                    <div class="mGraph-wrapper">
                        <div id="mGraph_sale" class="mGraph">
                        </div>
                    </div>
                    <div class="md-card-fullscreen-content">
                        <div class="uk-overflow-container">
                            <table class="uk-table uk-table-no-border uk-text-nowrap">
                                <thead>
                                    <tr>
                                        <th>Date</th>
                                        <th>Best Seller</th>
                                        <th>Total Sale</th>
                                        <th>Change</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>January 2014</td>
                                        <td>Ea in corrupti.</td>
                                        <td>$3 234 162</td>
                                        <td>0</td>
                                    </tr>
                                    <tr>
                                        <td>February 2014</td>
                                        <td>Nulla odit laboriosam officia.</td>
                                        <td>$3 771 083</td>
                                        <td class="uk-text-success">+2.5%</td>
                                    </tr>
                                    <tr>
                                        <td>March 2014</td>
                                        <td>Omnis pariatur tempora sed.</td>
                                        <td>$2 429 352</td>
                                        <td class="uk-text-danger">-4.6%</td>
                                    </tr>
                                    <tr>
                                        <td>April 2014</td>
                                        <td>Qui incidunt corrupti.</td>
                                        <td>$4 844 169</td>
                                        <td class="uk-text-success">+7%</td>
                                    </tr>
                                    <tr>
                                        <td>May 2014</td>
                                        <td>Odio accusamus nemo.</td>
                                        <td>$5 284 318</td>
                                        <td class="uk-text-success">+3.2%</td>
                                    </tr>
                                    <tr>
                                        <td>June 2014</td>
                                        <td>Molestiae sint sit vel expedita.</td>
                                        <td>$4 688 183</td>
                                        <td class="uk-text-danger">-6%</td>
                                    </tr>
                                    <tr>
                                        <td>July 2014</td>
                                        <td>Porro ea quisquam.</td>
                                        <td>$4 353 427</td>
                                        <td class="uk-text-success">-5.3%</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <p class="uk-margin-large-top uk-margin-small-bottom heading_list uk-text-success">Some Info:</p>
                        <p class="uk-margin-top-remove">Nobis doloribus consequatur illo sunt illum est molestiae vero architecto enim vel ut officia consequatur blanditiis dicta corporis voluptatem quia omnis recusandae eligendi recusandae quidem veniam quisquam aut accusantium vel qui sunt facere ipsum a enim asperiores voluptas ipsam est et placeat illum sed velit ut quam maiores tempore eos ab quae officiis in est ea provident optio recusandae ea natus occaecati cupiditate quia eligendi nostrum rem voluptatibus reiciendis reprehenderit tempora qui repellendus quo voluptates eligendi accusamus iusto corporis repudiandae ab eum deserunt iusto rem dolorem quam corrupti ratione id dolores eaque nobis recusandae voluptatem voluptatem quis corporis quis.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>--%>

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="PageScript" runat="Server">
</asp:Content>

