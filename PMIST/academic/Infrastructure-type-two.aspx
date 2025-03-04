<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Infrastructure-type-two.aspx.cs" Inherits="PMIST_Infrastructure_type_two" %>
<%@ Register Src="/PMIST/assets/includes/UCheader.ascx" TagName="UCheader" TagPrefix="UCheader" %>
<%@ Register Src="/PMIST/assets/includes/UCDepartmentSubmenu.ascx" TagName="UCDepartmentSubmenu" TagPrefix="UCDepartmentSubmenu" %>
 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>PMIST</title>
    <link rel="icon" type="image/x-icon" href="../assets/img/fav-icon.png" />
    <link href="../assets/css/bootstrap5-3-2.min.css" rel="stylesheet" />
    <link href="../assets/css/jquery.fancybox.min.css" rel="stylesheet" />
    <link href="../assets/bootstrap-icons/bootstrap-icons.css" rel="stylesheet" />
    <link href="../assets/css/aos.css" rel="stylesheet" />
    <link href="../assets/css/swiper.min.css" rel="stylesheet" />
    <link href="../assets/css/owl.carousel.min.css" rel="stylesheet" />
    <link href="../assets/css/owl.theme.css" rel="stylesheet" />
    <link href="../assets/css/style.css" rel="stylesheet" />
    <link href="../assets/css/academic/infrastructure.css" rel="stylesheet" />
    <link href="../assets/css/academic/new-sub-menu.css" rel="stylesheet">
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
        <asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
       <!-- HEADER -->
       <UCheader:UCheader id="header" runat="server" />
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
        <UCDepartmentSubmenu:UCDepartmentSubmenu id="UCDepartmentSubmenu" runat="server"/>
        <!-- sub-menu section End  -->
        <section class="Infrastructure">
            <div class="custom-container">
                <div class="atag_link">
                    <asp:Repeater ID="Repeater1" ClientIDMode="Static" runat="server">
                        <ItemTemplate>
                            <p class="infrastructure-content  p-0"><%# Eval("Quetion")%></p>
                            <div class="BindToBackend">
                                <%# Eval("Answer")%>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div>
                    <h1 class="infrastructure-heading m-0 p-0 pt-4 pb-4 border-0">COMPUTER SCIENCE AND ENGINEERING INFRASTRUCTURE</h1>
                    <div class="table-responsive">
                        <table id="table1">
                            <thead>
                                <tr>
                                    <th style="min-width: 79px;">S.No</th>
                                    <th style="min-width: 150px;">Laboratory Name</th>
                                    <th style="min-width: 246px;">Configuration</th>
                                    <th style="min-width: 127px;">System count</th>
                                    <th style="min-width: 208px;">Software</th>
                                    <th style="min-width: 220px;">Laboratory Incharge</th>
                                    <th style="min-width: 230px;">Technical Staff</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>1</td>
                                    <td>CSE 1 Lab</td>
                                    <td>LENOVOi5 Processor 12th gen, 500 HDD,8GB RAM, NVME SSD,21.5” Monitor,USB Keyboard & Mouse</td>
                                    <td>30</td>
                                    <td>Microsoft Windows 11 Professional Turbo C, C++ JDK 11.0 Oracle 11g Visual Studio Professional Python 3.12.5</td>
                                    <td>Dr. S. MANJULA, B.E, M.E Ph.D., Assistant Professor</td>
                                    <td>Mr.A.BALASUBRAMAN AN, B.E, Technical Assistant</td>
                                </tr>
                                <tr>
                                    <td>2</td>
                                    <td>CSE 2 Lab</td>
                                    <td>LENOVO i5 Processor 12th gen, 500 HDD, 8GB RAM, NVME SSD, 21.5” Monitor, USB Keyboard & Mouse</td>
                                    <td>30</td>
                                    <td>Microsoft Windows 11 Professional Turbo C, C++ JDK 11.0 Argo UML 0.35 Python 3.12.5</td>
                                    <td>Ms. V. PRIYA, B.Tech., M.E,Assistant Professor</td>
                                    <td>Mr.E.NAVANEETHA KRISHNAN, DCT, B. Tech,Technical Assistant</td>
                                </tr>
                                <tr>
                                    <td>3</td>
                                    <td>CSE 3 Lab</td>
                                    <td>HP Elite Desk 600 G1 & 800 G1 SFF, Desktop PC Intel core i3 Processor, 4th gen, 8GB DDR3 RAM, 1TB SATA HDD,18.5” LED Monitor, USB Keyboard & Mouse </td>
                                    <td>30 </td>
                                    <td>Microsoft Windows 10 Professional Turbo C, C++ JDK 11.0 Anaconda 23.5.2 Python 3.12.5 Ubuntu 22.0</td>
                                    <td>Ms. S.P. RAMYA, B.Tech., M. Tech, (Ph.D.),Assistant Professor (SS)</td>
                                    <td>Ms. K. JAYANTHI, BCA, MCA,Technical Assistant</td>
                                </tr>
                                <tr>
                                    <td>4</td>
                                    <td>CSE 4 Lab</td>
                                    <td>HP Elite Desk 600 G1 & 800 G1-SFF, Desktop PC Intel core i3 Processor, 4th gen, 8GB DDR3 RAM, 1TB SATA HDD, 18.5” LED Monitor,USB Keyboard & Mouse</td>
                                    <td>30</td>
                                    <td>Microsoft Windows 10 Professional Turbo C, C++, JDK 11.0, Anaconda 23.5.2, Python 3.12.5, Ubuntu 22.0</td>
                                    <td>Ms. I. EPISTLE, B. Tech, M. Tech,Assistant Professor</td>
                                    <td>Mr. C. SARGUNAN, B.E.,Technical Assistant</td>
                                </tr>

                                <tr>
                                    <td>5</td>
                                    <td>CSE 5 Lab</td>
                                    <td>HP 3090 Intel® CORE 2 DUO E7500 Processor 2GB DDR3 RAM, 320GB SATA HDD, 18.5” LCD Monitor, USB Keyboard & Mouse</td>
                                    <td>30</td>
                                    <td>Microsoft Windows 10 Professional Turbo C, C++,JDK 11.0, Python 3.12.5, Scilab, R studio</td>
                                    <td>Ms. U. ELAMATHI, B. Tech, M.Tech.,Assistant Professor</td>
                                    <td>Ms. T. NISHA, B.E.,Technical Assistant</td>
                                </tr>

                                <tr>
                                    <td>6</td>
                                    <td>CSE 6 Lab</td>
                                    <td>HP 3090 Intel® CORE 2 DUO E7500 Processor , 2GB DDR3 RAM, 320GB SATA HDD, 18.5” LCD Monitor, USB Keyboard & Mouse</td>
                                    <td>30</td>
                                    <td>Microsoft Windows 10 Professional Turbo C, C++,JDK 11.0,Python 3.12.5,Scilab,R studio</td>
                                    <td>Ms.K.SATHIYALAKSHMI, B.E, M.Tech,Assistant Professor</td>
                                    <td>Mr. S.KODEESWARAN, B.E.,Technical Assistant</td>
                                </tr>

                                <tr>
                                    <td>7</td>
                                    <td>Project Lab</td>
                                    <td>HP Elite Desk 600 G1 & 800 G1-SFF Desktop PC Intel core i5 Processor, 4th gen, 8GB DDR3 RAM, 1TB SATA HDD, 18.5” LED Monitor, USB Keyboard & Mouse</td>
                                    <td>30</td>
                                    <td>Microsoft Windows 10 Professional Turbo C, C++,JDK 11.0, Python 3.12.5,Weka Tool 3.8.2., Android 12, Visual studio Code,Arduino IDE, My SQL,MonogoDB, Anaconda 23.5.2, Ubuntu 22.0, Wamp server</td>
                                    <td>Ms. A.V.M.B. ARUNA, B. E, M.Tech, Assistant Professor</td>
                                    <td>Ms. S. SATHYA, DCT,B.E.,Technical Assistant</td>
                                </tr>

                                <tr>
                                    <td>8</td>
                                    <td>Research Lab</td>
                                    <td>HP Elite Desk 600 G1 & 800 G1-SFF Desktop PC Intel core i5 Processor,4th gen, 8GB DDR3 RAM, 1TB SATA HDD, 18.5” LED Monitor, USB Keyboard & Mouse</td>
                                    <td>30</td>
                                    <td>Microsoft Windows 10 Professional Adobe Photoshop 2023, Oracle 11g, MATlaboratory2022, SPSS 25.0, Visual Studio Professional 2022, Kali Linux 2023, Nessus 10.6.1, Nmap/Zen map 7.94, crypt tool 2.1, wire shark 3.2.2,Urkund Plagiarism, Python 3.12.5, Ubuntu 22.0</td>
                                    <td>Dr.T. KAVITHA, B.E, M.E, Ph.D., Associate ProfessorDr.T. KAVITHA, B.E, M.E, Ph.D., Associate ProfessorDr.T. KAVITHA, B.E, M.E, Ph.D., Associate Professor</td>
                                    <td>Ms. C. SHALINI, DECE, B.E.,Technical Assistant</td>
                                </tr>

                                <tr>
                                    <td>9</td>
                                    <td>Next Generation Networks Lab</td>
                                    <td>LENOVO i5, i5 processor 12th gen, 500 HDD, 8GB RAM Mini SSD, 2GB NVIDIA Graphics Card, 21.5” Monitor, USB Keyboard & Mouse</td>
                                    <td>30</td>
                                    <td>Microsoft Windows 11 Professional</td>
                                    <td>Mr. P. SUNIL KUMAR, B. Tech,M.E, (Ph.D.). Assistant Professor</td>
                                    <td>Mr. K. RAVISHANKAR NARAYANAN, B.E., M.Tech.,Technical Assistant</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </section>
        <section class="gallery section pb-5 pt-5">
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
