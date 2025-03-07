<%@ Page Language="C#" AutoEventWireup="true" CodeFile="resource-for-researchers.aspx.cs" Inherits="resourceforresearchers" %>

<%@ Register Src="~/PMIST/assets/includes/UCheader.ascx" TagName="UCheader" TagPrefix="UCheader" %>
<%@ Register Src="~/PMIST/assets/includes/UCDepartmentSubmenu.ascx" TagName="UCDepartmentSubmenu" TagPrefix="UCDepartmentSubmenu" %>


<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PMIST</title>
    <link rel="icon" type="image/x-icon" href="../assets/img/fav-icon.png">

    <link href="../assets/css/bootstrap5-3-2.min.css" rel="stylesheet">
    <link href="../assets/css/jquery.fancybox.min.css" rel="stylesheet">
    <link href="../assets/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
    <link href="../assets/css/aos.css" rel="stylesheet">
    <link href="../assets/css/swiper.min.css" rel="stylesheet">
    <link href="../assets/css/owl.carousel.min.css" rel="stylesheet">
    <link href="../assets/css/owl.theme.css" rel="stylesheet">
    <link href="../assets/css/style.css" rel="stylesheet">
    <link href="../assets/css/research/style.css" rel="stylesheet">

    <style>
        /* .sub-menu {
      background: linear-gradient(104deg, #2F4088 0.77%, #181B61 50.61%, #2F4088 101.67%);
    } */
    </style>

    <style>
        /* start */
        .BindToBackend ul, ol {
            list-style: none;
            padding: 0;
            margin: 0;
        }

        .BindToBackend li {
            position: relative;
            padding-left: 30px;
            font-size: 16px;
            line-height: 1.5;
        }

        .BindToBackend ul li::before, ol li::before {
            content: "";
            position: absolute;
            left: 0;
            top: 4px;
            width: 20px;
            height: 20px;
            background-size: contain;
            background-repeat: no-repeat;
        }
        /* Blue Tick for Odd Items */
        .BindToBackend ul li:nth-child(odd)::before, ol li:nth-child(odd)::before {
            background-image: url('../assets/img/icon/blue-tick.svg');
        }

        /* Red Tick for Even Items */
        .BindToBackend ul li:nth-child(even)::before, ol li:nth-child(even)::before {
            background-image: url('../assets/img/icon/red-tick.svg');
        }

        /* end */
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <!-- HEADER -->
        <UCheader:UCheader ID="header" runat="server" />
        <!-- END: HEADER -->


        <!-- banner section start  -->
        <section class="faculty banner-section">
            <img src="../assets/img/centre/banner.jpg" class="img-fluid w-100">
            <div class="custom-container">
            </div>
        </section>
        <!-- banner section End  -->

      <%--  <!-- sub-menu section start  -->
        <UCDepartmentSubmenu:UCDepartmentSubmenu ID="UCDepartmentSubmenu" runat="server" />
        <!-- sub-menu section End  -->--%>

        <section class="research">
            <div class="ps-md-5 ps-4">
                <div class="py-5">
                    <div class="row m-0">
                        <div class="col-md-3 pb-md-0 pb-sm-5 pb-4">
                            <h1 class="page-heading btn-line position-relative">Resource for Researchers
                            </h1>
                            <div class="accordion research-sidebar-menu" id="accordionExample">
                                <div class="accordion-item">
                                    <h2 class="accordion-header pe-3">
                                        <button class="accordion-button ps-0 pe-0 collapsed" type="button"
                                            data-bs-toggle="collapse" data-bs-target="#collapseOne"
                                            aria-controls="collapseOne">
                                            More Research
                                        </button>
                                    </h2>
                                    <div id="collapseOne" class="accordion-collapse collapse "
                                        data-bs-parent="#accordionExample">
                                        <h1 class="research-list"><a href="culture.html">Research Culture</a></h1>
                                        <h1 class="research-list"><a href="funded-projects.html">Funded Projects</a></h1>
                                        <h1 class="research-list"><a href="research-facilities.html">Research Facilities</a></h1>
                                        <h1 class="research-list"><a href="research-advisory-committee.html">Research Advisory Committee (RAC)</a></h1>
                                        <h1 class="research-list"><a href="research-forms.html">Download Research Forms</a></h1>
                                        <h1 class="research-list"><a href="collaborations-mou.html">Collaborations & MOU's</a></h1>
                                        <h1 class="research-list"><a href="ipr-cell.html">IRP Cell</a></h1>
                                        <h1 class="research-list"><a href="code-of-ethics-for-research.html">Code of Ethics for Research</a></h1>
                                        <h1 class="research-list"><a href="regulation.html">M.Phil. & Ph.D. Regulation</a></h1>
                                        <h1 class="research-list"><a href="institute-innovation-council.html">Institute Innovation Council</a></h1>
                                        <h1 class="research-list"><a href="funding-agencies.html">Funding Agencies</a></h1>
                                        <h1 class="research-list"><a href="research-outcome.html">Research outcome of PMIST in Scopus Database</a></h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-9 ">
                            <div class="research-content-side">
                                <div class="pe-3 pe-sm-5">
                                    <h1 class="research-heading m-0">List of agencies offering research grants
                                    </h1>
                                    <asp:Repeater ID="rprresource" runat="server">
                                        <ItemTemplate>
                                            <div class="pb-3 pt-3  BindToBackend">

                                                <a href='<%# Eval("URL_AND_Notes")%>' target="_blank"
                                                    class="anchor-link txt-sec-clr">
                                                    <img src="../assets/img/icon/link.svg" alt="img" class="img-fluid pe-2"
                                                        width="26px"><%# Eval("TitleContent")%></a>

                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>










                                    <h1 class="research-heading m-0 mt-4">List of agencies offering research fellowships
                                    </h1>
                                    <asp:Repeater ID="RPRLOA" runat="server">
                                        <ItemTemplate>
                                            <div class="pb-3 pt-3  BindToBackend">
                                                <a href='<%# Eval("URL_AND_Notes")%>' target="_blank"
                                                    class="anchor-link txt-sec-clr">
                                                    <img src="../assets/img/icon/link.svg" alt="img" class="img-fluid pe-2"
                                                        width="26px"><%# Eval("TitleContent")%></a>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>

                                    <h1 class="research-heading m-0 pt-4">List of website announcing seminars / conferences
                                    </h1>
                                    <asp:Repeater ID="rpr4" runat="server">
                                        <ItemTemplate>
                                            <div class="pb-3 pt-3  BindToBackend">
                                                <a href='<%# Eval("URL_AND_Notes")%>' target="_blank"
                                                    class="anchor-link txt-sec-clr">
                                                    <img src="../assets/img/icon/link.svg" alt="img" class="img-fluid pe-2"
                                                        width="26px"><%# Eval("TitleContent")%></a>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>

                                    <h1 class="research-heading m-0 mt-4">List of Intellectual Property Rights (IPR) courses / awareness programs / Patent Agent Examination offered by various agencies
                                    </h1>
                                    <asp:Repeater ID="rpr5" runat="server">
                                        <ItemTemplate>
                                            <div class="pb-3 pt-3  BindToBackend">
                                                <a href='<%# Eval("URL_AND_Notes")%>' target="_blank"
                                                    class="anchor-link txt-sec-clr">
                                                    <img src="../assets/img/icon/link.svg" alt="img" class="img-fluid pe-2"
                                                        width="26px"><%# Eval("TitleContent")%></a>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>

                                    <h1 class="research-heading m-0 mt-4">List of training course offered by various agencies
                                    </h1>
                                    <asp:Repeater ID="rpr6" runat="server">
                                        <ItemTemplate>
                                            <div class="pb-3 pt-3  BindToBackend">
                                                <a href='<%# Eval("URL_AND_Notes")%>' target="_blank"
                                                    class="anchor-link txt-sec-clr">
                                                    <img src="../assets/img/icon/link.svg" alt="img" class="img-fluid pe-2"
                                                        width="26px"><%# Eval("TitleContent")%></a>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>

                                    <h1 class="research-heading m-0 mt-4">List of travel fellowships to attend Seminar / Conferences / Workshops etc
                                    </h1>

                                    <asp:Repeater ID="rpr7" runat="server">
                                        <ItemTemplate>
                                            <div class="pb-3 pt-3  BindToBackend">
                                                <a href='<%# Eval("URL_AND_Notes")%>' target="_blank"
                                                    class="anchor-link txt-sec-clr">
                                                    <img src="../assets/img/icon/link.svg" alt="img" class="img-fluid pe-2"
                                                        width="26px"><%# Eval("TitleContent")%></a>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <script src="../assets/js/jquery.min.js"></script>
        <script src="../assets/js/bootstrap-bundle.min.js"></script>
        <script src="../assets/js/jquery.fancybox.min.js"></script>
        <script src="../assets/js/aos.js"></script>
        <script src="../assets/js/swiper.min.js"></script>
        <script src="../assets/js/owl.carousel.min.js"></script>
        <script src="../assets/js/main.js"></script>









        <script>
            document.addEventListener("DOMContentLoaded", function () {

                document.querySelector(".atag_link a").setAttribute("target", "_blank");
            });
        </script>
    </form>
</body>
</html>
