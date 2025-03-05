<%@ Page Language="C#" AutoEventWireup="true" CodeFile="faq.aspx.cs" Inherits="academic_faq" %>

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
    <link href="../assets/css/academic/faq.css" rel="stylesheet">
    <link href="../assets/css/academic/new-sub-menu.css" rel="stylesheet">
    <style>
        /* .sub-menu {
      background: linear-gradient(104deg, #2F4088 0.77%, #181B61 50.61%, #2F4088 101.67%);
    } */
    </style>


    <style>
        /* start */
        .BintTOBackend ul, ol {
            list-style: none;
            padding: 0;
            margin: 0;
        }

        .BintTOBackend li {
            position: relative;
            padding-left: 30px;
            font-size: 16px;
            line-height: 1.5;
        }

        .BintTOBackend ul li::before, ol li::before {
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
        .BintTOBackend ul li:nth-child(odd)::before, ol li:nth-child(odd)::before {
            background-image: url('../assets/img/icon/blue-tick.svg');
        }

        /* Red Tick for Even Items */
        .BintTOBackend ul li:nth-child(even)::before, ol li:nth-child(even)::before {
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
            <img src="../assets/img/academic/banner-images/Faculty-banner.jpg" class="img-fluid">
            <div class="custom-container">
                <div class="banner-heading">
                    <h4 class="m-0">Department of computer science</h4>
                    <h1 class="m-0">Faq</h1>
                </div>
            </div>
        </section>
        <!-- banner section End  -->

        <!-- sub-menu section start  -->
        <UCDepartmentSubmenu:UCDepartmentSubmenu ID="UCDepartmentSubmenu" runat="server" />
        <!-- sub-menu section End  -->


        <div class="custom-container">
            <div class="accordion pb-5" id="accordionExample">
                <asp:Repeater ID="rprfaq" runat="server">
                    <ItemTemplate>
                        <div class="accordion-item">
                            <h2 class="accordion-header">
                                <button class="accordion-button <%# Container.ItemIndex == 0 ? "" : "collapsed" %>"
                                    type="button"
                                    data-bs-toggle="collapse"
                                    data-bs-target='<%# "#collapse" + Container.ItemIndex %>'
                                    aria-expanded='<%# Container.ItemIndex == 0 ? "true" : "false" %>'
                                    aria-controls='<%# "collapse" + Container.ItemIndex %>'>
                                    <%# Eval("Quetion") %>
                                </button>
                            </h2>
                            <div id='<%# "collapse" + Container.ItemIndex %>'
                                class="accordion-collapse BintTOBackend collapse <%# Container.ItemIndex == 0 ? "show" : "" %>"
                                data-bs-parent="#accordionExample">
                                <div class="accordion-body">
                                    <%# Eval("Answer") %>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>

            <div class="contact-details pb-4 pb-sm-4">
                <h1 class="details-head">For More Details</h1>
                <div class="row">
                    <div class="col-xl-12 pb-5">
                        <div class="detailsss  position-relative">
                            <span>Mobile number</span>  : <a href="tel:8925029777">8925029777</a>   /  <a href="tel:+91 97901 11911" class="pe-3">+91 97901 11911</a>
                            <br class="d-none">

                            <span class="line position-relative ps-md-3 ps-0">Email Address </span>: <a href="mailto:admission@pmu.edu">admission@pmu.edu</a>
                        </div>
                    </div>

                </div>
            </div>
        </div>



        <script src="../assets/js/jquery.min.js"></script>
        <script src="../assets/js/bootstrap-bundle.min.js"></script>
        <script src="../assets/js/jquery.fancybox.min.js"></script>
        <script src="../assets/js/aos.js"></script>

        <script src="../assets/js/swiper.min.js"></script>
        <script src="../assets/js/owl.carousel.min.js"></script>
        <script src="../assets/js/main.js"></script>
        <script>

</script>
        <script>
            document.addEventListener("DOMContentLoaded", function () {

                document.querySelector(".atag_link a").setAttribute("target", "_blank");
            });
        </script>
    </form>
</body>
</html>
