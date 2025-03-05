<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Infrastructure.aspx.cs" Inherits="infrastructure" %>

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
    <link href="../assets/css/academic/infrastructure.css" rel="stylesheet">
    <link href="../assets/css/academic/new-sub-menu.css" rel="stylesheet">




    <style>
        /* Start */
        .BindToBackend ul, .BindToBackend ol {
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

        /* Apply background image for list items */
        .BindToBackend ul li::before, .BindToBackend ol li::before {
            content: "";
            position: absolute;
            left: 0;
            top: 4px;
            width: 20px;
            height: 20px;
            background-size: contain;
            background-repeat: no-repeat;
            display: inline-block; /* Ensures the image is visible */
        }

        /* Blue Tick for Odd Items */
        .BindToBackend ul li:nth-child(odd)::before,
        .BindToBackend ol li:nth-child(odd)::before {
            background-image: url('../assets/img/icon/blue-tick.svg');
        }

        /* Red Tick for Even Items */
        .BindToBackend ul li:nth-child(even)::before,
        .BindToBackend ol li:nth-child(even)::before {
            background-image: url('../assets/img/icon/red-tick.svg');
        }
        /* End */
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
            <img src="../assets/img/academic/banner-images/home-banner.jpg" class="img-fluid w-100">
            <div class="custom-container">
                <div class="banner-heading">
                    <h4 class="m-0">Department of computer science</h4>
                    <h1 class="m-0">Infrastructure</h1>
                </div>
            </div>
        </section>
        <!-- banner section End  -->

        <!-- sub-menu section start  -->
        <UCDepartmentSubmenu:UCDepartmentSubmenu ID="UCDepartmentSubmenu" runat="server" />
        <!-- sub-menu section End  -->

        <section class="Infrastructure">
            <div class="custom-container">
                <asp:Repeater ID="rprinfrastructure" runat="server">
                    <ItemTemplate>
                        <div class="BindToBackend">
                            <%# Eval("Content") %>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </section>

        <section class="gallery section pb-5">
            <div class="gallery-container ">
                <!-- Slider main container -->
                <div class="swiper gallery-swiper">
                    <!-- Additional required wrapper -->
                    <div class="swiper-wrapper">
                        <!-- Slides -->
                        <div class="swiper-slide position relative">
                            <div class="galleryImg-overlay"></div>
                            <a href="../assets/img/academic/infrastructure/img-1.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-1.jpg">

                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>
                        <div class="swiper-slide position relative">
                            <a href="../assets/img/academic/infrastructure/img-2.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-2.jpg">
                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>
                        <div class="swiper-slide position relative">
                            <a href="../assets/img/academic/infrastructure/img-3.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-3.jpg">
                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>
                        <div class="swiper-slide position relative">
                            <a href="../assets/img/academic/infrastructure/img-4.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-4.jpg">
                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>
                        <div class="swiper-slide position relative">
                            <a href="../assets/img/academic/infrastructure/img-5.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-5.jpg">
                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>
                        <div class="swiper-slide position relative">
                            <a href="../assets/img/academic/infrastructure/img-1.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-1.jpg">
                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>
                        <div class="swiper-slide position relative">
                            <a href="../assets/img/academic/infrastructure/img-2.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-2.jpg">
                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>
                        <div class="swiper-slide position relative">
                            <a href="../assets/img/academic/infrastructure/img-3.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-3.jpg">
                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>
                        <div class="swiper-slide position relative">
                            <a href="../assets/img/academic/infrastructure/img-4.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-4.jpg">
                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>
                        <div class="swiper-slide position relative">
                            <a href="../assets/img/academic/infrastructure/img-5.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-5.jpg">
                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>
                        <div class="swiper-slide position relative">
                            <a href="../assets/img/academic/infrastructure/img-1.jpg" data-fancybox="gallery-slide">
                                <img src="../assets/img/academic/infrastructure/img-1.jpg">
                                <div class="galleryImg-overlay"></div>
                            </a>
                        </div>

                    </div>
                    <!-- If we need pagination -->
                    <div class="swiper-pagination"></div>

                    <!-- If we need navigation buttons -->
                    <div class="swiper-button-prev"></div>
                    <div class="swiper-button-next"></div>


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
        <script>
            const swiper2 = new Swiper('.gallery-swiper', {
                // Optional parameters
                slidesPerView: 5,
                spaceBetween: 20,
                slidesPerGroup: 5, // Number of slides to move per click
                loop: true,

                // If we need pagination
                pagination: {
                    el: '.swiper-pagination',
                    clickable: true,
                },

                // Navigation arrows
                navigation: {
                    nextEl: '.swiper-button-next',
                    prevEl: '.swiper-button-prev',
                },
                breakpoints: {
                    // When the window is <= 480px
                    480: {
                        slidesPerView: 2,
                        slidesPerGroup: 2,
                    },
                    // When the window is <= 768px
                    768: {
                        slidesPerView: 2,
                        slidesPerGroup: 2,
                    },
                    // When the window is <= 1024px
                    1024: {
                        slidesPerView: 3,
                        slidesPerGroup: 2,
                    },
                },

            });
        </script>
    </form>
</body>
</html>
