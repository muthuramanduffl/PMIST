<%@ Page Language="C#" AutoEventWireup="true" CodeFile="research.aspx.cs" Inherits="department_of_architecture_new_research" %>
<%@ Register Src="~/includes/UCDepartmentMenuHeader.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/includes/UCDepartmentMenuFooter.ascx" TagPrefix="uc2" TagName="Footer" %>
<%@ Register Src="~/includes/socialmedia-share-floated.ascx" TagPrefix="uc3" TagName="socialmediasharefloated" %>
<%@ Register src="~/includes/UCAdmission.ascx" tagname="admission" tagprefix="uc" %>
<%@ Register src="includes/UCHomeBanner.ascx" tagname="Banner" tagprefix="uc4" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0 user-scalable=0">
   
    

    <!-- Primary Meta Tags -->
    <title>Department of Computer Science & Engineering | PMIST</title>
    <meta name="title" content="Department of Computer Science & Engineering | PMIST">
    <meta name="description" content=""The Department imparts high quality education in the field of Computer Science and Engineering."">
    
    <!-- Open Graph / Facebook -->
    <meta property="og:type" content="website">
    <meta property="og:url" content="https://www.pmu.edu/cse/">
    <meta property="og:title" content="Department of Computer Science & Engineering | PMIST">
    <meta property="og:description" content=""The Department imparts high quality education in the field of Computer Science and Engineering."">
    <meta property="og:image" content="https://pmu.edu/images/BTechComputerScience.png">
    
    <!-- Twitter -->
    <meta property="twitter:card" content="summary_large_image">
    <meta property="twitter:url" content="https://www.pmu.edu/cse/">
    <meta property="twitter:title" content="Department of Computer Science & Engineering | PMIST">
    <meta property="twitter:description" content=""The Department imparts high quality education in the field of Computer Science and Engineering."">
    <meta property="twitter:image" content="https://pmu.edu/images/BTechComputerScience.png">
    
    
    <!-- Global site tag (gtag.js) - Google Analytics -->
    <script async src="https://www.googletagmanager.com/gtag/js?id=UA-173526007-1"></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());
    
        gtag('config', 'UA-173526007-1');
    </script>
    
    
    
    <!-- Facebook Pixel Code -->
    <script>
        !function (f, b, e, v, n, t, s) {
            if (f.fbq) return; n = f.fbq = function () {
                n.callMethod ?
                n.callMethod.apply(n, arguments) : n.queue.push(arguments)
            };
            if (!f._fbq) f._fbq = n; n.push = n; n.loaded = !0; n.version = '2.0';
            n.queue = []; t = b.createElement(e); t.async = !0;
            t.src = v; s = b.getElementsByTagName(e)[0];
            s.parentNode.insertBefore(t, s)
        }(window, document, 'script',
            'https://connect.facebook.net/en_US/fbevents.js');
        fbq('init', '731880944025301');
        fbq('track', 'PageView');
    </script>
    <noscript><img height="1" width="1" style="display:none"
            src="https://www.facebook.com/tr?id=731880944025301&ev=PageView&noscript=1" /></noscript>
    <!-- End Facebook Pixel Code -->


    <!-- Style sheets -->

    <link rel="stylesheet" type="text/css" href="../css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="../css/style.css" />
    <link rel="stylesheet" type="text/css" href="../css/style-1.css" />
    <link rel="stylesheet" type="text/css" href="../css/swiper.min.css" />
    <link rel="shortcut icon" href="../images/favicon.png" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"
        integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"
        crossorigin="anonymous"></script>
    <link rel="stylesheet" type="text/css" href="https://cdn.jsdelivr.net/npm/pushbar.js@1.0.0/src/pushbar.min.css" />
     <link href="https://use.fontawesome.com/5ecf78f4a4.css" media="all" rel="stylesheet" />
      <link rel="stylesheet" type="text/css" href="/site-assets/css/modal.css">
</head>

<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>
        <uc3:socialmediasharefloated runat="server" ID="socialmediasharefloated" />
        <!-- Header  -->
        <uc1:Header runat="server" ID="Header" />

        <!-- Home Banner Slider  -->
        <uc4:Banner runat="server" ID="Banner" />

        <!--  End of Home Banner Slider  -->

        <div class="navigationSection  placementBg menuMobileBlock">
            <div class="swiper-container menuSwiper py-3">
                <div class="placementBorderBottom swiper-wrapper ">
                    <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2 ">
                        <a href="default.aspx" class="blackColor textdecorationNone   pb-1  d-block  ">
                            Home
                        </a>
                    </div>
                    <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2 ">
                        <a href="about.aspx" class="blackColor textdecorationNone   pb-1  d-block  ">
                            About
                        </a>
                    </div>
                    <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                        <a href="courses.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            Programs
                        </a>
                    </div>

                    <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                        <a href="faculty.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            Faculty
                        </a>
                    </div>


                    <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                        <a href="infrastructure.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            Infrastructure
                        </a>
                    </div>
                    <!-- <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                        <a href="activities.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            Activities
                        </a>
                    </div> -->
                    <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                        <a href="events.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            Events
                        </a>
                    </div>
                    <!-- <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                        <a href="gallery.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            Gallery
                        </a>
                    </div> -->
                    <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                        <a href="placement.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            Placement
                        </a>
                    </div>
                    <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                        <a href="accolades.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            Accolades
                        </a>
                    </div>

                    <div class="px-3 py-1  pb-2 placementBorder swiper-slide widthAuto activeBorderBottom">
                        <a href="research.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            Research
                        </a>
                    </div>

                    <div class="px-3 py-1  pb-2 placementBorder swiper-slide widthAuto">
                        <a target="_blank" href="https://www.pmu.edu/placement/collabrations.aspx"
                            class="blackColor textdecorationNone   pb-1  d-block ">
                            MoU / Collaborations
                        </a>
                    </div>
                    <div class="px-3 py-1  pb-2 placementBorder swiper-slide widthAuto">
                        <a href="alumni-corner.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            Alumni Corner
                        </a>
                    </div>
                    <div class="px-3 py-1  pb-2  swiper-slide widthAuto">
                        <a href="faqs.aspx" class="blackColor textdecorationNone   pb-1  d-block ">
                            FAQs
                        </a>
                    </div>

                </div>
                <div class="swiper-button-prev"></div>
                <div class="swiper-button-next"></div>
            </div>
        </div>



        <div>
            <div class="py-5">
                <div class="row  container-fluid">
                    <div class="col-lg-9 col-sm-12 col-md-12 col-xs-12 ">
                        <div class="profileSection pt-4 libraryBorder">
                            <div class="container-fluid  py-2">
                                <div class="d-flex">
                                    <h3 class="blueColor   upperCase pr-3 mb-0 "> Research</h3>
                                    <div class="headingAfter"></div>
                                </div>
                            </div>
                            <div class="container-fluid">
                                <div class="pt-3 fontBold">
                                    Thrust Areas : 

                                </div>
                                <div>
                                    <ul class="customli pt-4">
                                        <li class="lh-1-8">
                                            Text Mining

                                        </li>
                                        <li class="pt-2 lh-1-8">
                                            Mobile Adhoc Networks

                                        </li>
                                        <li class="pt-2 lh-1-8">
                                            Data Analytics, Information Security

                                        </li>
                                        <li class="pt-2 lh-1-8">
                                            Data mining

                                        </li>
                                        <li class="pt-2 lh-1-8">
                                            Image Processing

                                        </li>
                                        <li class="pt-2 lh-1-8">
                                            Wireless sensor networks 

                                        </li>
                                        <li class="pt-2 lh-1-8">
                                            Social Network Analytics

                                        </li>
                                        <li class="pt-2 lh-1-8">
                                            Software Engineering 

                                        </li>
                                        <li class="pt-2 lh-1-8">
                                            Big Data Analytics and IoT

                                        </li>
                                    </ul>
                                </div>
                                <div class="pt-3 fontBold" style="display: none;">
                                    Student Funded Projects

                                </div>
                                <div class="pt-3" style="display: none;">
                                    <table class="table  table-bordered tableResponsive  table-striped  text-center">
                                        <thead class="tableBlueBg">
                                            <tr>
                                                <td scope="col">Sl.No</td>
                                                <td scope="col">Name </td>
                                                <td scope="col">Title </td>
                                                <td scope="col">
                                                    Amount
                                                    (Rs.)
                                                </td>
                                                <td scope="col">Funding Agency</td>
                                                <td scope="col">Date</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td scope="row">1</td>
                                                <td>
                                                    Amudhini.V.P <br> Santhini.T  <br> Pavitra Kailash <br>Nivetha.D 
                                                </td>
                                                <td>Prediction of cardiovascular disease using machine learning algorithm)</td>
                                                <td>
                                                    7500
                                                </td>
                                                <td>
                                                    Tamil Nadu State Council for Technical Education (Student Project Scheme 2018 -19)
                                                </td>
                                                <td>
                                                    Feb 2019
                                                </td>
                                            </tr>
                                            <tr>
                                                <td scope="row">2</td>
                                                <td>
                                                    M.Yuvana Roja <br>R.Pragadeeswar

                                                </td>
                                                <td>Industrial Waste monitoring system using SPLUNK (IWMS)</td>
                                                <td>
                                                    7500
                                                </td>
                                                <td>
                                                    Tamil Nadu State Council for Technical Education (Student Project Scheme 2016 -17)
                                                </td>
                                                <td>
                                                    July 2017
                                                </td>
                                            </tr>
                                            
                                            
                                        </tbody>
                                    </table>
                                </div>

                                <div class="pt-3 fontBold">
                                    DEPARTMENT OF COMPUTER SCIENCE AND ENGINEERING
                                    Sponsored Research

                                </div>
                                <div class="pt-3">
                                    <table class="table  table-bordered tableResponsive  table-striped  text-center">
                                        <thead class="tableBlueBg">
                                            <tr>
                                                <td scope="col">Academic
                                                    Year</td>
                                                <td scope="col">Title of the Project </td>
                                                <td scope="col">Name of the
                                                    Principal
                                                    Investigator </td>
                                                <td scope="col">
                                                    Sponsoring
                                                    Agency
                                                </td>
                                                <td scope="col">Amount in
                                                   ( Rs )</td>
                                                
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td scope="row">2022-23</td>
                                                <td>
                                                    Automatic Music
                                                    Recommendation based
                                                    on face expression using
                                                    Machine Learning
                                                </td>
                                                <td>Ms.K.Sathiyalakshmi</td>
                                                <td>Tamil Nadu State
                                                        Council for
                                                        Science and
                                                        Technology
                                                        (TNSCST)</td>
                                                <td>
                                                    7500.00
                                                </td>
                                               
                                            </tr>
                                            <tr>
                                                <td scope="row">2021-22</td>
                                                <td>
                                                    Prevention of Fake Food
                                                    and Adulteration using
                                                    Electronic Product Code
                                                    (EC) and Machine
                                                    Learning based Bock
                                                    Chain Technology

                                                </td>
                                                <td>Dr.A.E.Narayanan</td>
                                                <td>
                                                    Tamil Nadu State
                                                    Council for
                                                    Science and
                                                    Technology
                                                    (TNSCST)
                                                </td>
                                                <td>
                                                    7500.00
                                                </td>
                                               
                                            </tr>

                                            <tr>
                                                <td scope="row">2019-20</td>
                                                <td>Detection and Prevention
                                                    of Mycotoxin in Stored
                                                    Food Grains using
                                                    Internet of Things IoT with
                                                    Machine Learning</td>
                                                <td>Dr.A.E.Narayanan</td>
                                                <td>
                                                    Tamil Nadu State
                                                    Council for
                                                    Science and
                                                    Technology
                                                    (TNSCST)
                                                </td>
                                                <td>7500.00</td>
                                            </tr>
                                            <tr>
                                                <td scope="row">2018-19</td>
                                                <td>Prediction of
                                                    cardiovascular disease
                                                    using machine learning
                                                    algorithm</td>
                                                <td>
                                                    Dr.R.Poonguzhali
                                                </td>
                                                <td>
                                                    Tamil Nadu State
                                                    Council for
                                                    Science and
                                                    Technology
                                                    (TNSCST)
                                                </td>
                                                <td>
                                                    7500.00
                                                </td>
                                            </tr>
                                          
                                            
                                            
                                        </tbody>
                                    </table>
                                </div>
                            </div>





                        </div>
                    </div>


                    <div class="col-lg-3 stickyMenu disNoneRespMenu">
                        <div>
                            <div class="px-2 py-2 sideMenuDept sideMenu sideMenuArch">
                                <div class="p-3 sideMenuBottomBorder">
                                    <a href="default.aspx" class="textdecorationNone sideMenuHover  d-flex ">
                                        Home</a>
                                </div>
                                <div class="p-3 sideMenuBottomBorder">
                                    <a href="about.aspx" class="textdecorationNone sideMenuHover  d-flex ">
                                        About</a>
                                </div>
                                <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a href="courses.aspx" class="textdecorationNone  sideMenuHover d-flex ">
                                        Programs</a>
                                </div>
                                <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a href="faculty.aspx" class="textdecorationNone  sideMenuHover d-flex ">
                                        Faculty</a>
                                </div>
                                <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a href="infrastructure.aspx" class="textdecorationNone  sideMenuHover d-flex ">
                                        Infrastructure</a>
                                </div>
                                <!-- <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a href="activities.aspx" class="textdecorationNone  sideMenuHover d-flex ">
                                        Activities</a>
                                </div> -->
                                <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a href="events.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                        Events</a>
                                </div>
                                <!-- <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a href="gallery.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                        Gallery</a>
                                </div> -->
                                <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a href="placement.aspx" class="textdecorationNone sideMenuHover  d-flex ">
                                        Placements</a>
                                </div>
                                <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a href="accolades.aspx" class="textdecorationNone   sideMenuHover d-flex ">
                                        Accolades
                                    </a>
                                </div>
                                <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a class="textdecorationNone activeSideMenu sideMenuHover d-flex ">

                                        Research</a>
                                </div>
                                <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a target="_blank" href="https://www.pmu.edu/placement/collabrations.aspx"
                                        class="textdecorationNone sideMenuHover d-flex ">
                                        MoU / Collaborations</a>
                                </div>
                                <div class="p-3 pt-4 sideMenuBottomBorder">
                                    <a href="alumni-corner.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                        Alumni Corner</a>
                                </div>
                                <div class="p-3 pt-4">
                                    <a href="faqs.aspx" class="textdecorationNone  sideMenuHover d-flex ">
                                        FAQs</a>
                                </div>

                            </div>
                        </div>
                    </div>


                </div>


            </div>
        </div>


        <!-- Footer  -->


        <uc:admission runat="server" ID="admission" />
        <uc2:Footer runat="server" ID="Footer" />
        
         <div class="enquire" data-toggle="modal" data-target="#exampleModalCenter">
        <a class="cursor-pointer whiteColor">
            <div>Apply Now</div>
        </a>
    </div>
          <div class="whatsappIcon">
            <a href="https://wa.me/919790111911" class="whatsapp whiteColor" target="_blank"> <i
                    class="fa fa-whatsapp whatsapp-icon"></i></a>
        </div>
        <!-- End of Footer  -->
    </form>
</body>

<!-- Script  -->
<script type="text/javascript" src="../js/bootstrap.min.js"></script>
<script type="text/javascript" src="../js/jquery-3.4.1.min.js"></script>
<script type="text/javascript" src="../js/swiper.min.js"></script>
<script type="text/javascript" src="https://cdn.jsdelivr.net/npm/pushbar.js@1.0.0/src/pushbar.min.js"></script>

<script>
    var swiper = new Swiper('.placementSlider', {
        slidesPerView: 1,
        // effect: 'coverflow',
        // autoplay: {
        //     delay: 4000,
        //     disableOnInteraction: false,
        // },
        // loop: true,
    });
</script>
<script>
    var swiper = new Swiper('.newsSlider', {
        slidesPerView: 2,
        direction: 'vertical',
        autoplay: {
            delay: 4000,
            disableOnInteraction: false,
        },
    });
</script>
<script>
    var swiper = new Swiper('.studentSwiperOne', {
        slidesPerView: 1,
        loop: true,
        autoplay: {
            delay: 4000,
            disableOnInteraction: false,
        },
    });
</script>
<script>
    var swiper = new Swiper('.studentSwiperTwo', {
        slidesPerView: 1,
        loop: true,
        autoplay: {
            delay: 4000,
            disableOnInteraction: false,
        },
    });
</script>
<script>
    var swiper = new Swiper('.eventsSlider', {
        slidesPerView: 4,
        spaceBetween: 5,
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },
        autoplay: {
            delay: 4000,
            disableOnInteraction: false,
        },
        breakpoints: {
            640: {
                slidesPerView: 1,
                spaceBetween: 5,
                centeredSlides: true,

            },
            768: {
                slidesPerView: 2,
                spaceBetween: 40,
            },
            1024: {
                slidesPerView: 2,
                spaceBetween: 50,
            },
            1400: {
                slidesPerView: 3,
                spaceBetween: 50,
            },
        },
    }); 
</script>
<script>
    var swiper = new Swiper('.recruiterSlider', {
        slidesPerView: 5,
        slidesPerColumn: 2,
        spaceBetween: 20,
        slidesPerGroup: 3,
        autoplay: {
            delay: 2000,
            disableOnInteraction: false,
        },
        breakpoints: {
            640: {
                slidesPerView: 1,
                spaceBetween: 5,
                centeredSlides: true,

            },
            768: {
                slidesPerView: 5,
                spaceBetween: 40,
            },
            1024: {
                slidesPerView: 5,
                spaceBetween: 50,
            },
        },
    }); 
</script>
<script>
    var swiper = new Swiper('.eventsSliderOne', {
        slidesPerView: 3,
        spaceBetween: 10,
        observer: true,
        observeParents: true,
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },
        autoplay: {
            delay: 4000,
            disableOnInteraction: false,
        },
        breakpoints: {
            640: {
                slidesPerView: 1,
                spaceBetween: 5,
                centeredSlides: true,

            },
            768: {
                slidesPerView: 5,
                spaceBetween: 40,
            },
            1024: {
                slidesPerView: 5,
                spaceBetween: 50,
            },

        },
    }); 
</script>

<script>
    function openCity(evt, cityName) {
        var i, x, tablinks;
        x = document.getElementsByClassName("city");
        for (i = 0; i < x.length; i++) {
            x[i].style.display = "none";
        }
        tablinks = document.getElementsByClassName("tablink");
        for (i = 0; i < x.length; i++) {
            tablinks[i].className = tablinks[i].className.replace("activeEvent", "");
        }
        document.getElementById(cityName).style.display = "block";
        evt.currentTarget.className += " activeEvent";
    }
</script>
<script>
    function openCityOne(evt, cityName) {
        var i, x, tablinks;
        x = document.getElementsByClassName("cityOne");
        for (i = 0; i < x.length; i++) {
            x[i].style.display = "none";
        }
        tablinks = document.getElementsByClassName("tablinkOne");
        for (i = 0; i < x.length; i++) {
            tablinks[i].className = tablinks[i].className.replace("activeEventOne", "");
        }
        document.getElementById(cityName).style.display = "block";
        evt.currentTarget.className += " activeEventOne";
    }
</script>

<script>

    $(document).ready(function () {

        $("#menutoggle").click(function () {
            $('.xs-menu').toggleClass('displaynone');

        });

        $(".dropdown1").hover(function () {
            $('.mega-menu1').addClass('display-on');
        });
        $(".dropdown1").mouseleave(function () {
            $('.mega-menu1').removeClass('display-on');
        });
        $(".downiqac").hover(function () {
            $('.iqacmenu').addClass('display-on');
        });
        $(".downiqac").mouseleave(function () {
            $('.iqacmenu').removeClass('display-on');
        });
        $(".downcentre").hover(function () {
            $('.centermenu').addClass('display-on');
        });
        $(".downcentre").mouseleave(function () {
            $('.centermenu').removeClass('display-on');
        });
        $(".downExam").hover(function () {
            $('.examMenu').addClass('display-on');
        });
        $(".downExam").mouseleave(function () {
            $('.examMenu').removeClass('display-on');
        });

    });

</script>
<script>
    function myFunction() {
        var x = document.getElementById("myDIV");
        if (x.style.display === "none") {
            x.style.display = "block";
        } else {
            x.style.display = "none";
        }
    }
</script>

<script>

    var animSpeed = 700;
    $('.category').click(function () {
        var target = $(this).data('target');
        if (!target) {
            return;
        }
        var self = this;
        $('.category').not($(this)[0]).hide(animSpeed, function () {
            $(target).fadeIn(animSpeed);
        });
        //$('.category').each(function(){ if(this != self) { $(this).hide(1000); } });
        //$(target).show(1000);
    });

    $('.category-close').click(function () {
        $(this).parent().fadeOut(animSpeed, function () {
            $('.target').hide(function () {
                $('.category').fadeIn(animSpeed);
            });
        });
    });
</script>
<script type="text/javascript">
    const pushbar = new Pushbar({
        blur: true,
        overlay: true,
    });
</script>
<script>
    var acc = document.getElementsByClassName("accordion1");
    var i;

    for (i = 0; i < acc.length; i++) {
        acc[i].addEventListener("click", function () {
            this.classList.toggle("active");
            var panel = this.nextElementSibling;
            if (panel.style.maxHeight) {
                panel.style.maxHeight = null;
            } else {
                panel.style.maxHeight = panel.scrollHeight + "px";
            }
        });
    }
</script>
<script>

    $(document).ready(function () {

        $("#menutoggle").click(function () {
            $('.xs-menu').toggleClass('displaynone');

        });

        $(".dropdown1").hover(function () {
            $('.mega-menu1').addClass('display-on');
        });
        $(".dropdown1").mouseleave(function () {
            $('.mega-menu1').removeClass('display-on');
        });
        $(".dropdown3").hover(function () {
            $('.mega-menu3').addClass('display-on');
        });
        $(".dropdown3").mouseleave(function () {
            $('.mega-menu3').removeClass('display-on');
        });
        $(".dropdown2").hover(function () {
            $('.mega-menu2').addClass('display-on');
        });
        $(".dropdown2").mouseleave(function () {
            $('.mega-menu2').removeClass('display-on');
        });
        $(".downiqac").hover(function () {
            $('.iqacmenu').addClass('display-on');
        });
        $(".downiqac").mouseleave(function () {
            $('.iqacmenu').removeClass('display-on');
        });
        $(".downadmission").hover(function () {
            $('.admissionMenu').addClass('display-on');
        });
        $(".downadmission").mouseleave(function () {
            $('.admissionMenu').removeClass('display-on');
        });
        $(".downfacilities").hover(function () {
            $('.facilitiesMenu').addClass('display-on');
        });
        $(".downfacilities").mouseleave(function () {
            $('.facilitiesMenu').removeClass('display-on');
        });
        $(".downcentre").hover(function () {
            $('.centermenu').addClass('display-on');
        });
        $(".downcentre").mouseleave(function () {
            $('.centermenu').removeClass('display-on');
        });
        $(".downExam").hover(function () {
            $('.examMenu').addClass('display-on');
        });
        $(".downExam").mouseleave(function () {
            $('.examMenu').removeClass('display-on');
        });

    });

</script>
<script>
    var acc = document.getElementsByClassName("accordion");
    var i;

    for (i = 0; i < acc.length; i++) {
        acc[i].addEventListener("click", function () {
            this.classList.toggle("active");
            var panel = this.nextElementSibling;
            if (panel.style.maxHeight) {
                panel.style.maxHeight = null;
            } else {
                panel.style.maxHeight = panel.scrollHeight + "px";
            }
        });
    }
</script>
<script>
    var swiper = new Swiper('.menuSwiper', {
        slidesPerView: 'auto',
        initialSlide: 8,
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },
    });
</script>

</html>