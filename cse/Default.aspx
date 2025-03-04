<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="department_of_architecture_new_Default" %>
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
    <link rel="shortcut icon" href="../../images/favicon.png" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"
        integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"
        crossorigin="anonymous"></script>
    <link rel="stylesheet" type="text/css" href="https://cdn.jsdelivr.net/npm/pushbar.js@1.0.0/src/pushbar.min.css" />
     <link href="https://use.fontawesome.com/5ecf78f4a4.css" media="all" rel="stylesheet" />
      <link rel="stylesheet" type="text/css" href="/site-assets/css/modal.css">

      <link rel="stylesheet" type="text/css" href="https://www.pmu.edu/css/department.css">
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
    <div class="navigationSection  placementBg">
        <div class="swiper-container menuSwiper pt-3">
            <div class="placementBorderBottom swiper-wrapper ">
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2 activeBorderBottom">
                    <a class="blackColor textdecorationNone  sideMenuHover pb-1  d-block  ">
                        Home
                    </a>
                </div>
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2 ">
                    <a  href="about.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block  ">
                        About
                    </a>
                </div>
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="courses.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Programs
                    </a>
                </div>

                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="faculty.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Faculty
                    </a>
                </div>


                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="infrastructure.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Infrastructure
                    </a>
                </div>
                <!-- <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="activities.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Activities
                    </a>
                </div> -->
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="events.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Events
                    </a>
                </div>
                <!-- <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="gallery.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Gallery
                    </a>
                </div> -->
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="placement.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Placement
                    </a>
                </div>
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="accolades.aspx"
                        class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                       Accolades
                    </a>
                </div>

                <div class="px-3 py-1  pb-2 placementBorder swiper-slide widthAuto">
                    <a href="research.aspx" 
                        class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Research
                    </a>
                </div>

                <div class="px-3 py-1  pb-2 placementBorder swiper-slide widthAuto">
                    <a target="_blank" href="https://www.pmu.edu/placement/collabrations.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        MoU / Collaborations
                    </a>
                </div>
                <div class="px-3 py-1  pb-2 placementBorder swiper-slide widthAuto">
                    <a href="alumni-corner.aspx" class="blackColor textdecorationNone  sideMenuHover pb-1  d-block ">
                       Alumni Corner
                    </a>
                </div>
                <div class="px-3 py-1  pb-2  swiper-slide widthAuto">
                    <a href="faqs.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                      FAQs
                    </a>
                </div>

            </div>
            <div class="swiper-button-prev"></div>
            <div class="swiper-button-next"></div>
        </div>
    </div>


    <!--============= HIGHLIGHTS SECTION =============-->
    <div class="dep-highlights">
        <div class="dep-highlightList">
            <h4>80%</h4>
            <h6>Placement Assistance</h6>
        </div>
        <div class="dep-highlightList">
            <h4>100+</h4>
            <h6>Industry Tie Ups</h6>
        </div>
        <div class="dep-highlightList">
            <h4>1500+</h4>
            <h6>Offers issued globally</h6>
        </div>
        <div class="dep-highlightList">
            <h4>100%</h4>
            <h6>Green Campus</h6>
        </div>
    </div>
    <!--============= END: HIGHLIGHTS SECTION =============-->


    <!--============= ABOUT SECTION =============-->
    <div class="dept-abtSection">
        <div class="dept-abtBg">
            <div class="abtBg-lft col-lg-4">
                <p>
                    Began in the year 1988 with the approval of AICTE, The Computer Science and Engineering Department imparts high quality education in the field of Computer Science and Engineering and also develops the overall personality of the students. Accredited by National Board of Accreditation in 1998, the Department facilitates the students to enrich technical know-how with the guidance of a team of well qualified and dedicated faculty members. 
                </p>
            </div>
            <div class="abtBg-rgt col-lg-8">
                <h4>
                    <img src="../images/dept-images/student-icon.png">
                    <span>PROGRAMS</span> OFFERED
                </h4>
                <ul>
                    <li>
                        <div class="tit">
                            <img src="../images/dept-images/bullet-icon.png">
                            <h5>Regular (4 years) - Full Time</h5>
                        </div>
                        <p> B.Tech. CSE  </p>
                        <p> B.Tech. CSE (AI & ML)   </p>
                        <p> B.Tech. CSE (Cyber Security)  </p>
                        <!-- <p> (Full Time & Part Time) -  Ph.D. - Computer Science and Engineering </p> -->
                    </li>
                </ul>
                <div class="dept-specf" style="display: none;">
                    <h6>specialization</h6>
                    <ul>
                        <li>
                            <div class="tit">
                                <img src="../images/dept-images/bullet-icon.png">
                            </div>
                            <p> B.Tech. (Hons.) - CSE -  <span>with Specialization in AI and ML</span></p>
                        </li>
                        <li>
                            <div class="tit">
                                <img src="../images/dept-images/bullet-icon.png">
                            </div>
                            <p> B.Tech. (Hons.) - CSE -  <span>with Specialization in Data Science</span></p>
                        </li>
                        <li>
                            <div class="tit">
                                <img src="../images/dept-images/bullet-icon.png">
                            </div>
                            <p> B.Tech. - CSE -  <span>with Specialization in Cyber Security</span></p>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="dept-admission-sec">
            <h4>ADMISSION 2024</h4>
            <a href="https://pmu.edu/admission/RegistrationNew.aspx" class="dept-admission-btn">APPLY NOW</a>
        </div>
    </div>
    <!--============= END: ABOUT SECTION =============-->
   
    <!--============= CONTENT SECTION =============-->
    <div class="dept-contentSection">
        <h4><span>PROGRAMME</span> OVERVIEW</h4>
        <p>
            
            Imparts high quality education in the field of Computer Science and Engineering and also develops the overall personality of the students.
            Facilitates the students to enrich technical know-how with the guidance of a team of well qualified and dedicated faculty members.
            Prepares the studentsto become globally competent by enhancing their skills to work in IT Industries and R & D organizations.
 
        </p>
    </div>
    <div class="dept-contentSection">
        <h4><span>SCOPE OF </span> CSE</h4>
        <ul>
            <li>
                <img src="../images/dept-images/bullet-icon-2.png">
                <p>Computer Engineers</p>
            </li>
            <li>
                <img src="../images/dept-images/bullet-icon-2.png">
                <p>IT Team Leads</p>
            </li>
            <li>
                <img src="../images/dept-images/bullet-icon-2.png">
                <p>Data Scientists</p>
            </li>
            <li>
                <img src="../images/dept-images/bullet-icon-2.png">
                <p>Software Developer</p>
            </li>
        </ul>
    </div>
    <!--============= END: CONTENT SECTION =============-->

    <!--============= HIGHLIGHTS SECTION =============-->
    <div class="dept-highlightBox">
        <div class="tit">
            <div class="highIcon">
                <div class="headerLine"></div>
                <img src="../images/dept-images/highlight-icon.png">
                <div class="headerLine"></div>
            </div>
            <h4><span>HIGH</span>LIGHTS</h4>
        </div>
        <div class="dept-highlightBox__bg row mx-0" style="background-image: url(../images/dept-images/highlights-bg/csc-ban.jpg);">
            <div class="col-lg-6 highlightBox__bg-list">
                <h6>Best Practices</h6>
                <ul>
                    <li>Global Certifications completed by students - AWS, Microsoft, Cyber Security, Microsoft PowerBI </li>
                    <li> Industry Collaborated specialization courses in AI and ML, Data Science and Cyber Security. </li>
                </ul>
            </div>
            <div class="col-lg-6 highlightBox__bg-list">
                <h6>LABORATORIES</h6>
                <ul>
                    <li>7 laboratories with 285 computer systems.</li>
                    <li>Exclusive lab for project work. </li>
                    <li>Exclusive research lab for new innovations.</li>
                    <li>AI and ML, Data Science for Specialization courses.</li>
                </ul>
            </div>
            <div class="col-lg-6 highlightBox__bg-list">
                <h6>PLACEMENT</h6>
                <ul>
                    <li>80% Placement during three consecutive years 2016 and 17, 2018 and 2019, 80% of students got placed and others joined in higher studies. In the current year 2022 85% are placed </li>
                </ul>
            </div>
            <div class="col-lg-6 highlightBox__bg-list">
                <h6>INFRASTRUCTURE</h6>
                <ul>
                    <li>ICT enabled class rooms, lecture halls and tutorial rooms. </li>
                    <li>Well-equipped seminar halls with smart board</li>
                    <li>Exclusive department library with books and journals </li>
                </ul>
            </div>
        </div>
    </div>
    <!--============= END: HIGHLIGHTS SECTION =============-->


    <div class="container-fluid my-5">
        <div class="row">

            <div class="col-lg-9 col-sm-9 col-md-9 col-xs-12 topRecruiterBorder">
                <div class="d-flex">
                    <h4 class="upperCase blueColor oswaldR Oswald positionRelative d-inline-block pr-3 ">
                        <span>Top Recruiters</span>
                    </h4>
                    <div class="headingTextAfterOne">

                    </div>
                </div>
                <div>
                    <div class="swiper-container recruiterSlider mt-4">
                        <div class="swiper-wrapper">
                            <div class="swiper-slide recruiterImages" style="background:url('/images/rec/1.png');">
                            </div>
                            <div class="swiper-slide recruiterImages" style="background:url('/images/rec/2.png');">
                            </div>
                            <div class="swiper-slide recruiterImages" style="background:url('/images/rec/3.png');">
                            </div>
                            <div class="swiper-slide recruiterImages" style="background:url('/images/rec/4.png');">
                            </div>
                            <div class="swiper-slide recruiterImages" style="background:url('/images/rec/5.png');">
                            </div>
                            <div class="swiper-slide recruiterImages" style="background:url('/images/rec/6.png');">
                            </div>
                            <div class="swiper-slide recruiterImages" style="background:url('/images/rec/7.png');">
                            </div>
                            <div class="swiper-slide recruiterImages" style="background:url('/images/rec/8.png');">
                            </div>
                            <div class="swiper-slide recruiterImages" style="background:url('/images/rec/9.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/10.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/11.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/12.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/13.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/14.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/15.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/16.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/17.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/18.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/19.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/20.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/21.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/22.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/23.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/24.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/25.png');">
                            </div>
                            <div class="swiper-slide recruiterImages"
                                style="background:url('/images/rec/26.png');">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-3 col-sm-3 col-md-3 col-xs-12 d-flex justify-content-center">
                <div>

                    <div class="d-flex">
                        <h4 class="upperCase blueColor oswaldR Oswald positionRelative d-inline-block pr-3 ">
                            <span>Affiliation</span>
                        </h4>
                        <div class="headingTextAfterOne">

                        </div>
                    </div>
                    <div class="mt-4">
                        <div class="recruiterImages" style="background: url('/images/a-2.png');"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>




    <!-- objectives  -->
    <!-- <div class="px-4">
        <div>
            <div class="d-flex align-items-center">
                <h3 class="upperCase blueColor py-3 m-0  ">Objectives </h3>
                <div class="headingAfter ml-3 mt-1"></div>
            </div>
            <p class="text-justify lh-2 pt-2">
                To be a unique department in creating eminent Architects with excellent creativity and sound
                technical knowledge, competent enough for adapting to the changing trends and culture of mankind
                and in turn applying them for the societal needs with environmental consciousness.


            </p>

        </div>
    </div> -->


    <!-- Scopr of Work  -->

    <!--<div class="newsSection mb-5 mt-3  container-fluid">
        <div>
            <div>
                <div>
                    <div class="d-flex justify-content-center align-items-center">
                        <div class="headingAfter mt-1 mr-3"></div>
                        <h3 class="upperCase blueColor py-3 m-0  ">Scope </h3>
                        <div class="headingAfter mt-1 ml-3"></div>

                    </div>
                    <div class="d-flex flex-wrap pt-5">
                        <div class="deptScope">
                            <div>
                                <div class="deptScopeText">
                                    Demand in air transportation and newer technologies in space.
                                </div>
                                <div>
                                    <img src="./images/dept1.svg" />
                                </div>

                            </div>

                        </div>
                        <div class="deptScope">
                            <div>
                                <div>
                                    <img src="./images/dept2.svg" />
                                </div>

                                <div class="deptScopeText1">
                                    Demand in air transportation and newer technologies in space.
                                </div>
                            </div>

                        </div>
                        <div class="deptScope">
                            <div>
                                <div class="deptScopeText">
                                    Demand in air transportation and newer technologies in space.
                                </div>
                                <div>
                                    <img src="./images/dept3.svg" />
                                </div>

                            </div>

                        </div>
                        <div class="deptScope">
                            <div>
                                <div>
                                    <img src="./images/dept4.svg" />
                                </div>
                                <div class="deptScopeText1">
                                    Demand in air transportation and newer technologies in space.
                                </div>

                            </div>

                        </div>
                        <div class="deptScope">
                            <div>
                                <div class="deptScopeText">
                                    Demand in air transportation and newer technologies in space.
                                </div>
                                <div>
                                    <img src="./images/dept5.svg" />
                                </div>

                            </div>

                        </div>
                    </div>

                </div>
            </div>

        </div>
    </div>-->



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
        // loop: true,
        // autoplay: {
        //     delay: 4000,
        //     disableOnInteraction: false,
        // },
    });
</script>
<script>
    var swiper = new Swiper('.studentSwiperTwo', {
        slidesPerView: 1,
        // loop: true,
        // autoplay: {
        //     delay: 4000,
        //     disableOnInteraction: false,
        // },
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
        slidesPerView: 4,
        speed: 2000,
        spaceBetween: 40,
        slidesPerGroup: 4,
        loop: true,
        autoplay: {
            delay: 5000,
            disableOnInteraction: false,
        },
        breakpoints: {
            640: {
                slidesPerView: 1,
                spaceBetween: 5,
                centeredSlides: true,
                slidesPerGroup: 1,

            },
            768: {
                slidesPerView: 3,
                spaceBetween: 40,
                slidesPerGroup: 2,
            },
            1024: {
                slidesPerView: 4,
                spaceBetween: 50,
                slidesPerGroup: 3,
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
    var swiper = new Swiper('.menuSwiper', {
        slidesPerView: 'auto',
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },
    });
</script>

</html>