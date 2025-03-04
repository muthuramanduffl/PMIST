<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="defaultnew" %>
<%@ Register src="~/includes/UCAdmission.ascx" tagname="admission" tagprefix="uc" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0 user-scalable=0">
    <title> Periyar Maniammai Institute of Science & Technology | Think - Innovate - Transform</title>
    <meta name="description"
        content="Pursue your career defining degree from Periyar Maniammai Institute of Science & Technology, a reputed Deemed to be University at Vallam, Thanjavur." />

        <!-- SOCIAL MEDIA META -->
    <meta property="og:description" content="PMIST | Think - Innovate - Transform">
    <meta property="og:title" content="PMIST | Think - Innovate - Transform">
    <meta property="og:type" content="website">
    <meta property="og:url" content="https://pmu.edu">
    <meta property="og:image" content="https://pmu.edu/images/metaimg.png">


            <!-- TWITTER META -->
            <meta name="twitter:card" content="summary">
            <meta property="twitter:url" content="https://pmu.edu" />
            <meta name="twitter:title" content="PMIST | Think - Innovate - Transform">
            <meta name="twitter:description" content="PMIST | Think - Innovate - Transform">
            <meta name="twitter:image" content="https://pmu.edu/images/metaimg.png">

<script async src="https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js?client=ca-pub-5102679633243752"     crossorigin="anonymous"></script>
    <!-- Style sheets -->

    <link rel="preload" href="https://pmu.edu/images/homepage/home-banner-3.png" as="image" />

    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <link rel="stylesheet" type="text/css" href="css/style-1.css" />
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="css/font-awesome.css" />
    <link rel="stylesheet" type="text/css" href="css/swiper.min.css" />
    <link rel="icon" type="image/x-icon" href="/images/fav-icon.png" />
    <link href="https://use.fontawesome.com/5ecf78f4a4.css" media="all" rel="stylesheet">
    <script type="text/javascript" src="https://use.fontawesome.com/5ecf78f4a4.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <link rel="stylesheet" type="text/css" href="https://cdn.jsdelivr.net/npm/pushbar.js@1.0.0/src/pushbar.min.css" />

    <link rel="stylesheet" type="text/css" href="css/text-scroll.css" />

    <link rel="stylesheet" type="text/css" href="css/resp.css" />

    <link rel="stylesheet" type="text/css" href="css/new-tab.css" />

    <link rel="stylesheet" type="text/css" href="css/owl.carousel.min.css" /><link rel="stylesheet" type="text/css" href="css/owl.theme.css" />

    <link rel="stylesheet" type="text/css" href="css/splide.min.css" />

    <link rel="stylesheet" type="text/css" href="home-new/style.css" />

    <link rel="stylesheet" type="text/css" href="https://pmu.edu/css/menuNew.css" />

    <!-- Google Tag Manager -->
    <!-- Global site tag (gtag.js) - Google Analytics -->
    <script async src="https://www.googletagmanager.com/gtag/js?id=UA-173526007-1"></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'UA-173526007-1');
    </script>

<!-- <script>(function(w, d) { w.CollectId = "60d22ff0bd10e41c4c35fe7d"; var h = d.head || d.getElementsByTagName("head")[0]; var s = d.createElement("script"); s.setAttribute("type", "text/javascript"); s.async=true; s.setAttribute("src", "https://collectcdn.com/launcher.js"); h.appendChild(s); })(window, document);</script> -->

<!-- Facebook Pixel Code -->
<script>
    !function(f,b,e,v,n,t,s)
    {if(f.fbq)return;n=f.fbq=function(){n.callMethod?
    n.callMethod.apply(n,arguments):n.queue.push(arguments)};
    if(!f._fbq)f._fbq=n;n.push=n;n.loaded=!0;n.version='2.0';
    n.queue=[];t=b.createElement(e);t.async=!0;
    t.src=v;s=b.getElementsByTagName(e)[0];
    s.parentNode.insertBefore(t,s)}(window, document,'script',
    'https://connect.facebook.net/en_US/fbevents.js');
    fbq('init', '480945943177114');
    fbq('track', 'PageView');
    </script>
    <noscript><img height="1" width="1" style="display:none"
    src="https://www.facebook.com/tr?id=480945943177114&ev=PageView&noscript=1"
    /></noscript>
    <!-- End Facebook Pixel Code -->
 
    <style>
        .bannerImage {
            /* background-size: 100% 100% !important; */
            background-size: cover !important;
            background-position: left !important;
        }
        .affiliation-img img {
            position: relative;
            top: 50%;
        }
        .professional-bodies-tit {
            width: 240px;
            display: block;
        }
        .professional-bodies img {
            width: 63%;
            display: block;
            margin: auto;
        }
        .navbar-expand-lg .navbar-collapse.dNone {
    display: none !important;
  }

  .whatsapp {
    left: 22px;
    right: unset;bottom: 15px;
  }
  .chat-sticky {
    top: 300px;
    position: fixed;
    z-index: 111;
    right: 0;
  }
.chat-sticky .registration__new {
    border-radius: 0px !important;
    min-width: 64px !important;
    font-size: 14px !important;
}
        @media (max-width: 600px) {
            .professional-bodies img {
                width: 44%;
            }
            .bannerImage {
      background-size: cover !important;
      background-position: center !important;
    }
        }
        @media (max-width: 1199px) {
            .professional-bodies-tit {
                width: auto;
                display: block;
            }
        }


       .w-33{width: 33%;} 
    </style>
</head>


<body>
 
    <form id="form1" runat="server">
        <asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>
        <!-- Header  -->
        <nav
            class="navbar m-0 align-items-start navbar-expand-lg p-0 fixed-top shadow container-fluid whiteHeader zindexHigh">
<a style="display:none" href="https://www.rss.org/hi/%E0%A4%AE%E0%A5%8C%E0%A4%B8%E0%A4%AE/" title="मौसम"  rel="dofollow">मौसम</a>          
  <!-- <div class="logoBg positionRelative">
                <div>
                    <a class="navbar-brand" href="https://pmu.edu/">
			
                        <img src="images/Logo.png" class="logo" />
                    </a>
                </div>
            </div> -->
            <div class="logoBg positionRelative addBg">
                <div class="align-self-center">
                    <a class="navbar-brand" href="https://pmu.edu/">
                        <img src="https://www.pmu.edu/pmistdlp/images/PMIST-reverse-logo.png" class="logo logodef addBg"  />
                        <img src="https://pmu.edu/images/Logo.png" class="logo logoScl" />
                    </a>
                </div>
            </div>
            <div class="admin__btn" style="display: none;">
                <a href="https://pmu.edu/admission/RegistrationNew.aspx">
                    Apply Now 2024 <span></span>
                </a>
            </div>
            <button class="navbar-toggler outlineNone hamburgerIcon" type="button" data-toggle="collapse"
                data-pushbar-target="left" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
                aria-expanded="false" aria-label="Toggle navigation">
                <div class="toggleIcon">
                    <div></div>
                    <div></div>
                    <div></div>
                </div>
            </button>

            <aside data-pushbar-id="left" data-pushbar-direction="left">

                <ul class="liststyleNone mobileMenu  px-2" id="accordionExample">
                    <div class="d-flex justify-content-between align-items-center sideMenuBottomBorder pb-1 mb-1">
                        <div>
                            <a class="navbar-brand" href="https://pmu.edu/">
                                <img src="../images/Logo.png" class="logo">
                            </a>
                        </div>
                        <div data-pushbar-close="" class="close push_left">
                            <img src="https://pmu.edu/admission/images/close-gradient.png" class="closeGr" />
                        </div>
                    </div>
                    <li class="">
                        <a href="https://pmu.edu/"
                            class="upperCase OswaldR Oswald textdecorationNone blueColor">Home</a>
                    </li>
                    <li class="dropdown1">
                        <button onclick="return false;" type="button" data-toggle="collapse" data-target="#collapseOne"
                            aria-expanded="true" aria-controls="collapseOne"
                            class="respButton Oswald OswaldR blueColor upperCase accordionButton">About</button>
                        <div class="panel-accordion collapse" id="collapseOne" aria-labelledby="headingOne"
                            data-parent="#accordionExample">
                            <div>
                                <a href="https://pmu.edu/about/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">About
                                    PMIST</a>
                                <a href="https://pmu.edu/about/history.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">History</a>
                                <a href="https://pmu.edu/about/Chancellor.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Chancellor</a>
                                <a href="https://pmu.edu/about/governance.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Governance </a>
                                
                                <a href="https://pmu.edu/about/management.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Management</a>
                                <a href="https://pmu.edu/about/deans.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Deans</a>
                                
                                <a href="https://pmu.edu/about/directors.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Directors</a>
                                <a href="https://pmu.edu/about/administrative-officers.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Administrative Officers</a>
                                <a href="https://pmu.edu/about/committee.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Committees</a>
                                <a href="https://pmu.edu/about/statutory-bodies.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Statutory Bodies</a>
                                <a href="https://pmu.edu/about/bye-laws.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Bye-laws and
                                    Constitution</a>
                                
                                <a href="https://www.pmu.edu/about/accreditation-and-ranking.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Accreditation and Ranking </a>
        
                                <a href="https://www.pmu.edu/about/e-news-bulletin.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">E-News Bulletin</a>
                                <a href="https://www.pmu.edu/about/year-wise-calendar.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Academic Calender </a>
                                    <a href="https://www.pmu.edu/about/privacy-policy.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Privacy policy </a> 
                                    <a href="https://www.pmu.edu/about/academic-schedule.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR"> Academic schedule  </a>
                                    <a href="https://pmu.edu/about/regulationarchive.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR"> Regulation Archive  </a>
				<a style="display:none" href="https://www.elkjournals.com/eng/hotmail-signup/" target="_blank" rel="dofollow">Hotmail</a>
 			
                            </div>

                        </div>

                    </li>
                    <li class="drop-down">
                        <button onclick="return false;" type="button" data-toggle="collapse"
                            data-target="#collapseProgram" aria-expanded="true" aria-controls="collapseProgram"
                            class="respButton Oswald OswaldR blueColor upperCase accordionButton">Academics</button>

                        <div class="panel-accordion collapse" id="collapseProgram" aria-labelledby="headingOne"
                            data-parent="#accordionExample">
                            <div>
                                <button onclick="return false;"
                                    class="accordion1 respButton blueColor Oswald OswaldR">Faculty of Architecture and Planning</button>
                                <div class="panel">
                                    <a href="https://pmu.edu/about/FacultyOfArchitectureAndPlanning.aspx"
                                        class="textdecorationNone blueColor pb-1 d-block Oswald OswaldR">
                                        <div>Dean's Message</div>
                                    </a>
                                    <a href="https://www.pmu.edu/department-of-architecture/"
                                        class="textdecorationNone blueColor pb-1 d-block Oswald OswaldR">
                                        <div>Department Of Architecture</div>
                                    </a>
                                </div>
                            </div>
                            <div>
                                <button onclick="return false;"
                                    class="accordion1 respButton blueColor Oswald OswaldR">Faculty of Engineering and Technology</button>
                                <div class="panel">
                              
                                    <a href="https://www.pmu.edu/department-of-aerospace/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Aerospace  
                                        </div>
                                    </a> 

                                    <a href="https://www.pmu.edu/department-of-biotechnology/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Biotechnology
                                        </div>
                                    </a>

				 <a style="display:none" href="https://itiltd.in/eng/yahoo-mail-login/" title="yahoo mail"  rel="dofollow">Yahoo Mail</a>

                                    <a href="https://www.pmu.edu/department-of-civil-engineering/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Civil Engineering
                                        </div>
                                    </a>

                                    <a href="https://www.pmu.edu/cse/" class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Computer Science And Engineering
                                        </div>
                                    </a>

                                    <a href="https://www.pmu.edu/department-of-electronics-and-communication/"
                                            class="d-block blueColor Oswald OswaldR pb-1">

                                            <div>
                                                Department of Electronics and Communication Engineering
                                            </div>
                                        </a>



                                    <a href="https://www.pmu.edu/department-of-electrical-and-electronics/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Electrical and Electronics Engineering
                                        </div>
                                    </a>



                                    <a href="https://www.pmu.edu/department-of-mechanical-engineering/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Mechanical Engineering
                                        </div>
                                    </a>
                                    

                                </div>

                                <button onclick="return false;"
                                    class="accordion1 respButton blueColor Oswald OswaldR">Faculty of Computing Science and Applications
                                </button>
                                <div class="panel">
                                    <a href="https://pmu.edu/about/FacultyOfComputingScienceAndApplications.aspx"
                                    class="d-block blueColor Oswald OswaldR pb-1">

                                    <div>Dean's message</div>
                                    </a>

                                    <a href="https://www.pmu.edu/department-of-informatics/"
                                    class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Informatics
                                        </div>
                                    </a>
                                <a href="https://www.pmu.edu/department-of-computer-science/" class="d-block blueColor Oswald OswaldR pb-1">

                                    <div>
                                        Department of Computer Science
                                    </div>
                                </a>


                                <a href="#"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Software Engineering  
                                        </div>
                                    </a>

                                    


                                    <a href="https://www.pmu.edu/department-of-computer-applications/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Computer Applications
                                        </div>
                                    </a>
 
                                </div>

                            </div>
                            <div>
                                <button onclick="return false;"
                                    class="accordion1 respButton blueColor Oswald OswaldR">Faculty of Commerce</button>
                                <div class="panel">

                                    <a href="https://www.pmu.edu/department-of-commerce/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Commerce
                                        </div>
                                    </a>
                                </div>
                            </div>

                            <div>
                                <button onclick="return false;"
                                    class="accordion1 respButton blueColor Oswald OswaldR">Faculty of Management Studies</button>
                                <div class="panel">
                                    <a href='https://pmu.edu/about/FacultyOfManagementStudies.aspx'
                                    class="d-block blueColor Oswald OswaldR pb-1">

                                    <div>
                                        Dean's Message
                                    </div>
                                </a>
                                    <a href="https://www.pmu.edu/department-of-management-studies/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Management Studies
                                        </div>
                                    </a>
                                </div>
                            </div>

                            <div>
                                <button onclick="return false;"
                                    class="accordion1 respButton blueColor Oswald OswaldR">Faculty of Science and Humanities</button>
                                <div class="panel">

                                    <a href="https://pmu.edu/about/FacultyOfScienceAndHumanities.aspx"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Dean's Message
                                        </div>
                                    </a>

                                    <a href="https://www.pmu.edu/department-of-foundation-courses/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Foundation Courses
                                        </div>
                                    </a>
                                    <a href="https://www.pmu.edu/department-of-chemistry/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Chemistry
                                        </div>
                                    </a>
                                    <a href="https://www.pmu.edu/department-of-english/"
                                    class="d-block blueColor Oswald OswaldR pb-1">

                                    <div>
                                        Department of Languages
                                    </div>
                                </a>
                                <a style="display:none" href="https://www.rss.org/eng/rediffmail-login/" title="rediffmail login"  rel="dofollow">rediffmail login</a>

                                    <a href="https://www.pmu.edu/department-of-physics/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Physics
                                        </div>
                                    </a>

                                    <a href="https://www.pmu.edu/department-of-mathematics/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Mathematics
                                        </div>
                                    </a>

                                    <a href="https://www.pmu.edu/department-of-education/"
                                    class="d-block blueColor Oswald OswaldR pb-1">

                                    <div>Department of Education
                                    </div>
                                </a>

                                <a href="https://www.pmu.edu/department-of-political-science/"
                                class="d-block blueColor Oswald OswaldR pb-1">

                                <div>
                                    Department of Political Science
                                </div>
                            </a>
 
 
                                    <a href="https://www.pmu.edu/department-of-social-work/"
                                        class="d-block blueColor Oswald OswaldR pb-1">

                                        <div>
                                            Department of Social Work
                                        </div>
                                    </a>
                                   
                                    <a href="https://pmu.edu/library/index.aspx"
                                    class="d-block blueColor Oswald OswaldR pb-1">

                                    <div>
                                        Department of Library Sciences
                                    </div>
                                </a>
                               
                                <a href="https://www.pmu.edu/campus/physical-education.aspx"
                                    class="d-block blueColor Oswald OswaldR pb-1">

                                    <div>
                                        Department of Physical Education
                                    </div>
                                </a>

                                </div>

                               
                                <a href="https://www.pmu.edu/regulations.aspx" >

                                    <div>
                                       Regulations
                                    </div>
                                </a> 
                                <button onclick="return false;"
                                class="accordion1 respButton blueColor Oswald OswaldR">Programmes Offered</button>
                                <div class="panel">
                                <a href="https://www.pmu.edu/academics.aspx" >
    
                                    <div>
                                       Academic Council
                                    </div>
                                </a>
                            </div>
                            </div>
                             
                        </div>



                    </li>
                    <li class="drop-down">
                        <a href="https://pmu.edu/admission/"
                            class="upperCase OswaldR Oswald textdecorationNone blueColor">Admission</a>
                    </li>
                    <li>
                        <button onclick="return false;" type="button" data-toggle="collapse" data-target="#collapseTwo"
                            aria-expanded="true" aria-controls="collapseTwo"
                            class="respButton Oswald OswaldR blueColor upperCase accordionButton">Facilities</button>
                        <div class="panel-accordion collapse" id="collapseTwo" aria-labelledby="headingOne"
                            data-parent="#accordionExample">

                            <a href="https://www.pmu.edu/campus/" class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>Life at PMIST
                                </div>
                            </a>


                            <a href="https://www.pmu.edu/campus/amenities.aspx"
                                class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Campus Amenities
                                </div>
                            </a>


                            <a href="https://www.pmu.edu/campus/zero-carbon.aspx"
                                class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Zero Carbon Campus
                                </div>
                            </a>


                            <a href="https://pmu.edu/library/index.aspx" class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Arjun Singh Library
                                </div>
                            </a>


                            <a href="https://www.pmu.edu/campus/physical-education.aspx" class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Physical Education
                                </div>
                            </a>


                            <a href="https://www.pmu.edu/campus/ict-facilities.aspx" class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    ICT Facilities
                                </div>
                            </a>




                            <a href="#" class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Computer Facilities
                                </div>
                            </a>


                            <a href="https://www.pmu.edu/campus/hostel.aspx"
                                class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Hostel
                                </div>
                            </a>


                            <a href="https://pmu.edu/campus/student-association.aspx"
                                class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Student Association
                                </div>
                            </a>


                            <a href="https://pmu.edu/centres/centre-for-students-and-administrative-services.aspx" class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Clubs and Socities
                                </div>
                            </a>


                            <a href="https://www.pmu.edu/campus/hospital.aspx"
                                class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Periyar Maniammai Hospital
                                </div>
                            </a>
                            <a href="https://www.pmu.edu/campus/e-governance.aspx"
                                class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    E-Governance
                                </div>
                            </a>

                            <a href="https://www.pmu.edu/campus/barrier-free-environment.aspx"
                                class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Barrier Free Environment
                                </div>
                            </a>
                            <a href="https://www.pmu.edu/campus/cultural-activities.aspx"
                                class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Cultural Activities
                                </div>
                            </a>
                            <a href="https://www.pmu.edu/campus/learning-management-system.aspx"
                                class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    Learning Management System
                                </div>
                            </a>
                            <a href="https://www.pmu.edu/campus/eYantra.aspx"
                                class="d-block pb-1 Oswald OswaldR blueColor">

                                <div>
                                    e Yantra Lab
                                </div>
                            </a>

                        </div>
                    </li>
                    <li>
                        <button onclick="return false;"type="button" data-toggle="collapse" data-target="#collapseCentres" aria-expanded="true" aria-controls="collapseCentres"  class="respButton Oswald OswaldR blueColor upperCase accordionButton">Centres</button>
                        <div class="panel-accordion collapse" id="collapseCentres" aria-labelledby="headingOne" data-parent="#accordionExample">

                            <a href="https://pmu.edu/placement/" class="d-block blueColor Oswald OswaldR pb-1">
        
                                        <div>
                                            Centre for Institute Industry Interaction (CIII)
                                        </div>
                                    </a>
        
        
        
                                    <a href="https://pmu.edu/centres/centre-for-students-and-administrative-services.aspx"
                                        class="d-block blueColor Oswald OswaldR pb-1">
        
                                        <div>
        
                                            Centre For Students And Administrative
                                            Services
                                        </div>
                                    </a>

                                    <a href="https://pmu.edu/centres/Centre-for-Human-Resource-Development.aspx"
                                    class="d-block blueColor Oswald OswaldR pb-1">
    
                                    <div>
    
                                        Centre for Human Resource Development
                                    </div>
                                </a>
        
        
        
                                    <a href="https://pmu.edu/centres/kkcps.aspx" class="d-block blueColor Oswald OswaldR pb-1">
        
                                        <div>
                                            Dr. Kalaignar M.Karunanithi Centre For
                                            Political Science
                                        </div>
                                    </a>
        
        
        
        
                                    <a href="https://pmu.edu/centres/veeramani-mohana-centre-for-quality-life-engineering-research.aspx"
                                        class="d-block blueColor Oswald OswaldR pb-1">
        
                                        <div>
        
                                            Veeramani Mohana Centre For Quality Of
                                            Life Engineering Research (I/C)
                                        </div>
                                    </a>
        
        
        
                                    <a href="https://pmu.edu/centres/centre-for-energy-and-environment.aspx" class="d-block blueColor Oswald OswaldR pb-1">
        
                                        <div>
        
                                            Centre for Energy and Environment
                                        </div>
                                    </a>
        
        
        
        
                                    <a href="https://pmu.edu/centres/centre-for-rural-development.aspx"
                                        class="d-block blueColor Oswald OswaldR pb-1">
        
                                        <div>
        
                                            Periyar Pura Centre For Rural
                                            Development
                                        </div>
                                    </a>
        
        
        
                                    <a href="https://pmu.edu/centres/cetat.aspx" class="d-block blueColor Oswald OswaldR pb-1">
        
                                        <div>
        
                                            Centre Of Excellence For Training And
                                            Research In Automation Technologies
                                        </div>
                                    </a>
        
        
        
        
                                    <a href="https://pmu.edu/centres/centre-of-excellence-for-next-generation-networks.aspx"
                                        class="d-block blueColor Oswald OswaldR pb-1">
        
                                        <div>
                                            Centre
                                            Of Excellence For Next Generation
                                            Networks
                                        </div>
                                    </a>
        
        
        
                                    <a href="https://pmu.edu/centres/centre-of-excellence-for-periyar-thought.aspx"
                                        class="d-block blueColor Oswald OswaldR pb-1">
        
                                        <div>
        
                                            Centre Of Excellence For Periyar Thought
                                        </div>
                                    </a>
                                    <a href="https://pmu.edu/centres/national-cyber-defense-resource-centre.aspx"
                                    class="d-block blueColor Oswald OswaldR pb-1">
    
                                    <div>
    
                                        National Cyber Defense Resource Centre (NCDRC)
                                    </div>
                                </a>
                                <a href="https://pmu.edu/centres/CSSTP.aspx"
                                    class="d-block blueColor Oswald OswaldR pb-1">
    
                                    <div>
    
                                        Centre for Scholarly Scientific Training and Publishing (CSSTP)
                                    </div>
                                </a>
                                <a href="https://pmu.edu/centres/Centre-for-Skill-Development-Center.aspx"
                                class="d-block blueColor Oswald OswaldR pb-1">

                                <div>

                                    Centre For Skill Development Center
                                </div>
                            </a>
    

                        </div>
                    </li>

                    <li class="drop-down">

                        <button onclick="return false;" type="button" data-toggle="collapse" data-target="#collapseFour"
                            aria-expanded="true" aria-controls="collapseFour"
                            class="respButton Oswald OswaldR blueColor upperCase accordionButton">IQAC</button>


                        <div class="panel-accordion collapse" id="collapseFour" aria-labelledby="headingOne"
                            data-parent="#accordionExample">

                            <a href="https://pmu.edu/iqac/default.aspx" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    Home
                                </div>
                            </a>


                            <a href="https://pmu.edu/iqac/about.aspx" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    About
                                </div>
                            </a>


                            <a href="https://pmu.edu/iqac/co-ordinators.aspx"
                                class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    Coordinators
                                </div>
                            </a>


                            <a href="https://pmu.edu/iqac/Members.aspx" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    Members
                                </div>
                            </a>


                            <a href="https://pmu.edu/iqac/meetings.aspx" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    Meeting
                                </div>
                            </a>


                            <a href="https://pmu.edu/iqac/contact.aspx" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    Contact
                                </div>
                            </a>




                            <a href="https://pmu.edu/iqac/reports.aspx" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    Report
                                </div>
                            </a>


                            <a href="https://pmu.edu/iqac/gallery.aspx" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    Gallery
                                </div>
                            </a>




                            <!-- <a href="https://pmu.edu/iqac/nirf.aspx" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    NIRF
                                </div>
                            </a> -->



                            <a href="https://pmu.edu/iqac/naac.aspx" target="_blank" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>NAAC 
                                </div>
                            </a>


                            <a href="https://pmu.edu/iqac/aqar.aspx" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    AQAR
                                </div>
                            </a>
                            <a href="https://pmu.edu/iqac/policies-procedures.aspx"
                                class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    Policies and Procedures
                                </div>
                            </a>
                            <a href="https://pmu.edu/iqac/feedback-on-curricular-aspects.aspx"
                            class="d-block Oswald OswaldR pb-1 blueColor">

                            <div>
                                Feedback on Curricular Aspects
                            </div>
                        </a>
                            <a href="https://pmu.edu/iqac/pmistannualrep.aspx" class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    PMIST Annual Report
                                </div>
                            </a>
                            <a href="https://pmu.edu/iqac/initiatives.aspx"class="d-block Oswald OswaldR pb-1 blueColor">

                                <div>
                                    Initiatives
                                </div>
                            </a>
                           
                          

                            <a href="https://pmu.edu/iqac/staff-appraisal.aspx"
                            class="d-block Oswald OswaldR pb-1 blueColor">

                            <div>
                                Staff Appraisal
                            </div>
                        </a>
                        <a href="https://pmu.edu/iqac/Institutional-Distinctiveness.aspx"
                            class="d-block Oswald OswaldR pb-1 blueColor">

                            <div>
                                Institutional Distinctiveness
                            </div>
                        </a>
                        <a href="https://pmu.edu/iqac/Best-Practices.aspx"
                            class="d-block Oswald OswaldR pb-1 blueColor">

                            <div>
                                Best Practices
                            </div>
                        </a>

                        <a href="https://pmu.edu/iqac/events.aspx"class="d-block Oswald OswaldR pb-1 blueColor">

                            <div>
                                Events
                            </div>
                        </a>


                        </div>
                    </li>
                     <!-- <li class="drop-down">
                  
                            <a href="https://pmu.edu/examination/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Examination</a>
                    </li>  -->
                    <!-- <li class="drop-down">
                        <a href="https://pmu.edu/iqac/nirf.aspx"
                            class="upperCase OswaldR Oswald textdecorationNone blueColor">NIRF</a>
                    </li> -->
                  
                    <li class="dropdown1">
                        <button onclick="return false;" type="button" data-toggle="collapse" data-target="#collapseFive" aria-expanded="true" aria-controls="collapseFive"  class="respButton Oswald OswaldR blueColor upperCase accordionButton">Research</button>
                        <div class="panel-accordion collapse" id="collapseFive" aria-labelledby="headingOne" data-parent="#accordionExample">
                            <div>
                                <a href="https://pmu.edu/research/culture.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Research Culture</a>
                               <a href="https://pmu.edu/research/research-facilities.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Research Facilities</a>
                                <a href="https://pmu.edu/research/funded-projects.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Funded Projects</a>
                                <a href="#."
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Consultancy</a>
                                <a href="https://pmu.edu/research/research-advisory-committee.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Research Advisory Committee (RAC)</a> 
                                <a href="https://pmu.edu/research/research-forms.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Download Research Forms</a>
                               <a href="https://pmu.edu/research/collaborations-and-MoU.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Collaborations &amp; MoU's</a>
                                <a href="https://pmu.edu/research/ipr-cell.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">IPR Cell</a> 
                                <a href="https://pmu.edu/research/code-of-ethics-for-research.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Code of Ethics for Research</a>
                                 <a href="https://pmu.edu/research/regulation.aspx" 
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">M.Phil and Ph.D Regulation</a>
                                <a href="https://pmu.edu/research/institute-innovation-council.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Institute Innovation Council</a> 
                                    <a href="https://pmu.edu/research/funding-agencies.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Funding Agencies</a> 
                                <a href="https://pmu.edu/research/research-outcome-of-PMIST-in-scopus-database.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Research outcome of PMIST in Scopus Database</a> 
                                <a href="https://pmu.edu/research/resource-for-researchers.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Resource for Researchers</a>
                                    <div class="phdAppl__btn" style="display: block;">
                                        <a href="https://pmu.edu/admission/ResearchApplicationRegister.aspx">
                                            Ph.D. Application
                                        </a>
                                    </div>
                            </div>

                        </div>

                    </li>
                    <!-- <li class="drop-down">
                        <a href="https://pmu.edu/research/culture.aspx"
                            class="upperCase OswaldR Oswald textdecorationNone blueColor">research</a>
                    </li> -->
                    <li class="">
                        <a href="https://pmu.edu/chat-with-a-student/"
                            class="upperCase OswaldR Oswald textdecorationNone blueColor">Chat with a student</a>
                    </li>
                     <li>
                        <a href="https://pmu.edu/alumni/" class="upperCase Oswald OswaldR textdecorationNone blueColor">Alumni</a>
                    </li> 

                    <li class="dropdown1">
                        <button onclick="return false;" type="button" data-toggle="collapse" data-target="#collapseSix"
                            aria-expanded="true" aria-controls="collapseSix"
                            class="respButton Oswald OswaldR blueColor upperCase accordionButton">More +</button>
                        <div class="panel-accordion collapse" id="collapseSix" aria-labelledby="headingOne"
                            data-parent="#accordionExample">
                            <div>
                                <a href="https://pmu.edu/examination/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Examination</a>
                                <a href="https://pmu.edu/placement/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Placement</a>
                                <a href="https://pmu.edu/gallery/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Gallery</a>
                                <a href="https://pmu.edu/events/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Events</a>
                                    <a href="http://periyartbi.pmu.edu/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">PTBI</a>
                                <a href="https://pmu.edu/careers/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Careers</a><a href="https://pmu.edu/contact/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Contact</a>
                                 <a href="https://pmu.edu/gallery/mission-green.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Mission Green PMIST</a>
                                <a href="https://pmu.edu/capacity-development-and-skill-enhancement.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Capacity Development and Skill Enhancement Activities</a>
                                    <a href="https://pmu.edu/achievements-corner/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Achievement Corner</a>
                                    <a href="https://pmu.edu/admission/call-letter-login.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Call Letter Download</a>
                                    <a href="https://pmu.edu/students-grievance/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Student Grievance Online</a>

                                    <a href="https://pmu.edu/career-counselling/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Career Guidance</a>

                                    <a href="https://pmu.edu/sustainable-development/"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Sustainable Development</a>
                                    <a href="https://pmu.edu/Counsellors.aspx"
                                    class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Counsellors</a>
                                    
                                        <a href="http://pmiststudentportal.in/"
                                        class="blueColor textdecorationNone pb-1 d-block Oswald OswaldR">Student Portal</a>
                                   
                            </div>

                        </div>

                    </li>
                </ul>
            </aside>

            <div class="collapse ulBg navbar-collapse justify-content-around header overFlow-X "
                id="navbarSupportedContent ">

                <nav class="menu w-100">
                    <ul class="m-0 menuHeight d-flex justify-content-around  w-100">
                        <li class="">
                            <a href="https://pmu.edu/" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16 f-16">Home</span></a>
                        </li>
                        <li class="dropdown1">
                            <a href="#" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16">About
                                </span></a>

                            <div class="mega-menu1 fadeIn animated">
                                <div class="">

                                    <span class="categories-list">
                                        <div class="text-center">
                                            <h4 class=" upperCase OswaldR Oswald headerBottom blackColor pb-3">About
                                            </h4>
                                        </div>
                                        <ul class="w-100 d-flex flex-wrap">
                                            <li class="w-25 liRight">

                                                <span class="pb-2 d-block">
                                                    <a href="https://pmu.edu/about/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            About PMIST
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="d-block pb-2">
                                                    <a href="https://pmu.edu/about/history.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            History
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://pmu.edu/about/Chancellor.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Chancellor
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://pmu.edu/about/governance.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="https://pmu.edu/images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Governance
                                                        </div>
                                                    </a>

                                                </span>
                                            </li>

                                            <li class="w-25 liRight">
                                                <span class="pb-2 d-block">
                                                    <a href="https://pmu.edu/about/management.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Management
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block"><a href="https://pmu.edu/about/deans.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Deans
                                                        </div>
                                                    </a>
                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://pmu.edu/about/directors.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew"><div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Directors
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block"> 
                                                    <a href="https://pmu.edu/about/administrative-officers.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Administrative Officers
                                                        </div>
                                                    </a>
                                                </span>

                                            </li>
                                            <li class="w-25 liRight ">

                                                <span class="pb-2  d-block">
                                                    <a href="https://pmu.edu/about/committee.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Committees
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://pmu.edu/about/statutory-bodies.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew" target="blank">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Statutory Bodies
                                                        </div>
                                                    </a>



                                                </span>
                                                <span class="d-block pb-2">
                                                    <a href="https://pmu.edu/about/bye-laws.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Bye-laws and Constitution
                                                        </div>
                                                    </a>

                                                </span>
                                                
                                                <span class="pb-2 d-block"> 
                                                    <a href="https://www.pmu.edu/about/accreditation-and-ranking.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew" >
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Accreditation and Ranking 
                                                        </div>
                                                    </a>
                                                </span>


                                            </li>
                                            <li class="w-25">
                                                <!-- <h5 class="blackColor pl-2 Oswald OswaldR pb-2">Year Wise Calendar</h5> -->
                                                
                                                <span class="d-block pb-2">
                                                    <a href="https://www.pmu.edu/about/e-news-bulletin.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            E-News Bulletin 
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block"> 
                                                    <a href="https://www.pmu.edu/about/year-wise-calendar.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Academic Calender 
                                                        </div>
                                                    </a>
                                                </span>
                                                
                                                 <span class="pb-2 d-block"><a href="https://www.pmu.edu/about/privacy-policy.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Privacy policy
                                                        </div>
                                                    </a>
                                                </span>
                                                <span class="pb-2 d-block"> 
                                                    <a href="https://www.pmu.edu/about/academic-schedule.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Academic schedule 
                                                        </div>
                                                    </a>
                                                </span>
                                                <span class="pb-2 d-block"> 
                                                    <a href="https://pmu.edu/about/regulationarchive.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Regulation Archive
                                                        </div>
                                                    </a>
                                                </span>

                                            </li>
                                        </ul>
                                    </span>

                                </div>


                            </div>

                        </li>
                        <li class="dropdown2">
                            <a href="#" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16">Academics</span></a>

                            <div class="mega-menu2 fadeIn animated">
                                <div class="">

                                    <span class="categories-list">
                                        <div class="text-center">
                                            <h4 class=" upperCase OswaldR Oswald headerBottom blackColor pb-3">Academics
                                            </h4>
                                        </div>
                                        <ul class="w-100 d-flex flex-wrap">
                                            <li class="w-25 liRight">

                                                <span class="pb-2 d-block">
                                                    <h5 class="blackColor pl-2 Oswald OswaldR  pb-2" style="cursor: pointer;" onclick="window.location.href='https://pmu.edu/about/FacultyOfArchitectureAndPlanning.aspx';" >Faculty of Architecture and Planning</h5>
                                                    <a href="https://www.pmu.edu/department-of-architecture/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Architecture
                                                        </div>
                                                    </a>

                                                </span>

                                                <span class="pb-2 pt-2 d-block">
                                                    <h5 class="blackColor pl-2 Oswald OswaldR  pb-2">Faculty of Engineering and Technology</h5>
                                                    <a href="https://www.pmu.edu/department-of-aerospace/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Aerospace
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2  d-block">
                                                    <a href="https://www.pmu.edu/department-of-biotechnology/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Biotechnology
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2  d-block">
                                                    <a href="https://www.pmu.edu/department-of-civil-engineering/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Civil Engineering
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2  d-block"> 
                                                        <a href="https://www.pmu.edu/cse/"
                                                            class="heightAuto megamenuHover d-flex noSkew">
                                                            <div>
                                                                <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                            </div>
                                                            <div>
                                                                Department of Computer Science and Engineering
                                                            </div>
                                                        </a> 
                                                    </span> 

                                                <span class="pb-2  d-block">
                                                    <a href="https://www.pmu.edu/department-of-electronics-and-communication/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Electronics and Communication Engineering
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2  d-block">
                                                    <a href="https://www.pmu.edu/department-of-electrical-and-electronics/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div><div>
                                                            Department of Electrical and Electronics Engineering
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2  d-block">
                                                    <a href="https://www.pmu.edu/department-of-mechanical-engineering/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Mechanical Engineering
                                                        </div>
                                                    </a>

                                                </span>
 

                                            </li>


                                            <li class="w-25 liRight ">
                                                <h5 class="blackColor pl-2 OswaldR Oswald pb-2"  style="cursor: pointer;" onclick="window.location.href='https://pmu.edu/about/FacultyOfComputingScienceAndApplications.aspx';">Faculty of Computing Science and Applications</h5>
                                                
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-informatics/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Informatics
                                                        </div>
                                                    </a> 
                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-computer-science/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Computer Science 
                                                        </div>
                                                    </a> 
                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="#"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Software Engineering
                                                        </div>
                                                    </a> 
                                                </span>
                                                
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-computer-applications/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Computer Applications
                                                        </div>
                                                    </a> 
                                                </span>
                                                

                                                <h5 class="blackColor pl-2 OswaldR Oswald pb-2 pt-2">Faculty of Commerce</h5>
                                                
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-commerce/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Commerce
                                                        </div>
                                                    </a>

                                                </span>

                                                <h5 class="blackColor pl-2 OswaldR Oswald pb-2" style="cursor: pointer;"  onclick="window.location.href='https://pmu.edu/about/FacultyOfManagementStudies.aspx';">Faculty of Management Studies</h5>
                                                
                                                <span class="pb-2 d-block">
                                                    
                                                    <a href="https://www.pmu.edu/department-of-management-studies/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Management Studies
                                                        </div>
                                                    </a> 
                                                </span>
                                                   
                                            </li>
                                            <li class="w-25 liRight  ">
                                                <h5 class="blackColor pl-2 OswaldR Oswald pb-2" style="cursor: pointer;" onclick="window.location.href='https://pmu.edu/about/FacultyOfScienceAndHumanities.aspx';">Faculty of Science and Humanities</h5>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-foundation-courses/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Foundation Courses
                                                        </div>
                                                    </a> 
                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-chemistry/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Chemistry
                                                        </div>
                                                    </a>

                                                </span> 
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-english/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Languages
                                                        </div>
                                                    </a> 
                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-physics/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Physics
                                                        </div>
                                                    </a> 
                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-mathematics/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Mathematics
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block"> 
                                                    <a href="https://www.pmu.edu/department-of-education/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Education
                                                        </div>
                                                    </a>  
                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-political-science/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Political Science
                                                        </div>
                                                    </a> 
                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-social-work/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Social Work
                                                        </div>
                                                    </a> 
                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://pmu.edu/library/index.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Library Sciences
                                                        </div>
                                                    </a> 
                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/campus/physical-education.aspx"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Physical Education
                                                        </div>
                                                    </a> 
                                                </span>
                                            </li>
                                            <li class="w-25">
                                           
                                                <span class="pb-2 d-block">
                                                     <a href="https://www.pmu.edu/regulations.aspx"
                                                         class="heightAuto megamenuHover d-flex noSkew">
                                                         <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                         </div>
                                                         <div>
                                                             Regulations
                                                         </div>
                                                     </a> 
                                                 </span>
                                                
                                                 <h5 class="blackColor pl-2 OswaldR Oswald pb-2" style="cursor: pointer;" >Programmes Offered</h5>
                                                  <span class="pb-2 d-block">
                                                     <a href="https://www.pmu.edu/academics.aspx"
                                                         class="heightAuto megamenuHover d-flex noSkew">
                                                         <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                         </div>
                                                         <div>
                                                             Academic Council
                                                         </div>
                                                     </a> 
                                                 </span>
                                             </li>
                                            <!-- <li class="w-25">
                                                <h5 class="blackColor pl-2 OswaldR Oswald pb-2">Faculty of Humanities ,
                                                    Science and Management</h5>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-chemistry/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Chemistry
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-commerce/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Commerce
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-english/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Languages
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block">

                                                    <a href="https://www.pmu.edu/department-of-education/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Education
                                                        </div>
                                                    </a>


                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-mathematics/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Mathematics
                                                        </div>
                                                    </a>

                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-management-studies/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Management Studies
                                                        </div>
                                                    </a>



                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-physics/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Physics
                                                        </div>
                                                    </a>



                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-political-science/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Political Science
                                                        </div>
                                                    </a>



                                                </span>
                                                <span class="pb-2 d-block">
                                                    <a href="https://www.pmu.edu/department-of-social-work/"
                                                        class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Department of Social Work
                                                        </div>
                                                    </a>



                                                </span>



                                            </li> -->
                                        </ul>
                                    </span>

                                </div>


                            </div>

                        </li>
                        
                        <li class="downadmission">
                            <a href="https://pmu.edu/admission" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16">admission</span></a>
                         

                        </li>

                        <li class="downfacilities">
                            <a href="#" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16">facilities</span></a>
                            <div class="facilitiesMenu fadeIn animated">
                                <div class="">

                                    <span class="categories-list">
                                        <div class="text-center">
                                            <h4 class=" upperCase OswaldR Oswald headerBottom pb-3">facilities</h4>
                                        </div>
                                        <ul class="w-100 d-flex flex-wrap">
                                            <!-- <li class=" upperCase OswaldR Oswald headerBottom pb-2">IQAC</li> -->
                                            <li class="w-25 text-center liRight">
                                                <a href="https://www.pmu.edu/campus/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Life at PMIST
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://www.pmu.edu/campus/amenities.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Campus Amenities
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://www.pmu.edu/campus/zero-carbon.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew"><div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Zero Carbon Campus
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center">
                                                <a href="https://pmu.edu/library/index.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Arjun Singh Library
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://www.pmu.edu/campus/physical-education.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Physical Education
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://www.pmu.edu/campus/ict-facilities.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        ICT Facilities
                                                    </div>
                                                </a>


                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="#" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Computer Facilities
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center">
                                                <a href="https://www.pmu.edu/campus/hostel.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Hostel
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/campus/student-association.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Student Association
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/centres/centre-for-students-and-administrative-services.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Clubs and Socities
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://www.pmu.edu/campus/hospital.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Periyar Maniammai Hospital
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center">
                                                <a href="https://www.pmu.edu/campus/e-governance.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        E-Governance
                                                    </div>
                                                </a>
                                            </li>

                                            <li class="w-25 text-center liRight">
                                                <a href="https://www.pmu.edu/campus/barrier-free-environment.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div><div>
                                                        Barrier Free Environment
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://www.pmu.edu/campus/cultural-activities.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div><img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Cultural Activities
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://www.pmu.edu/campus/learning-management-system.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Learning Management System
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center ">
                                                <a href="https://www.pmu.edu/campus/eYantra.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        e Yantra Lab
                                                    </div>
                                                </a>
                                            </li>




                                        </ul>
                                    </span>

                                </div>

                            </div>

                        </li>
                        
                       

                    <li class="dropdown3">
                        <a href="#" class="upperCase OswaldR Oswald"><span
                                class="normalSkew textGradient f-16">Research</span></a>

                        <div class="mega-menu3 fadeIn animated">
                            <div class="">

                                <span class="categories-list">
                                    <div class="text-center">
                                        <h4 class=" upperCase OswaldR Oswald headerBottom blackColor pb-3">Research
                                        </h4>
                                    </div>
                                    <ul class="w-100 d-flex flex-wrap">
                                        <li class="w-25 liRight">

                                            <span class="pb-2 d-block">

                                                <a href="https://pmu.edu/research/culture.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Research Culture
                                                    </div>
                                                </a>

                                            </span>
                                           <span class="pb-2  d-block">
                                                <a href="https://pmu.edu/research/research-advisory-committee.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Research Advisory Committee (RAC)
                                                    </div>
                                                </a>

                                            </span> 
                                             <span class="pb-2 d-block">
                                                <a href="https://pmu.edu/research/ipr-cell.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        IPR Cell
                                                    </div>
                                                </a>

                                            </span><span class="pb-2 d-block">
                                                <a href="https://pmu.edu/research/research-outcome-of-PMIST-in-scopus-database.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Research outcome of PMIST in Scopus Database
                                                    </div>
                                                </a>

                                            </span> 
                                        </li>

                                        <li class="w-25 liRight">
                                         <span class="pb-2 d-block">
                                                <a href="https://pmu.edu/research/code-of-ethics-for-research.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Code of Ethics for Research 
                                                    </div>
                                                </a>



                                           <span class="pb-2 pt-2 d-block">
                                                <a href="https://pmu.edu/research/research-facilities.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Research Facilities
                                                    </div>
                                                </a>

                                            </span> 

                                            <span class="pb-2 d-block">

                                                <a href="#" class="heightAuto megamenuHover d-flex noSkew"><div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Consultancy
                                                    </div>
                                                </a>


                                            </span>
                                             <span class="pb-2 d-block">

                                                <a href="https://pmu.edu/research/resource-for-researchers.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Resource for Researchers
                                                    </div>
                                                </a>


                                            </span>
                                            
                                        </li>
                                        <li class="w-25 liRight ">
                                             <span class="pb-2 d-block">
                                                <a href="https://pmu.edu/research/regulation.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        M.Phil. and Ph.D.
                                                        regulation
                                                    </div>
                                                </a>



                                            </span> 
                                                 <span class="pb-2 d-block">
                                                <a href="https://pmu.edu/research/research-forms.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Download Research
                                                        Forms
                                                    </div>
                                                </a>



                                            </span>
                                            <span class="pb-2 d-block">
                                                <a href="https://pmu.edu/research/institute-innovation-council.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Institute Innovation Council
                                                    </div>
                                                </a>

                                            </span> 
                                            <span class="pb-2 d-block">
                                                <div class="phdAppl__btn" style="display: block;">
                                                    <a href="https://pmu.edu/admission/ResearchApplicationRegister.aspx">
                                                        Ph.D. Application
                                                    </a>
                                                </div>

                                            </span>
                                            </li>
                                            <li class="w-25 liRight">

                                                <span class="pb-2 d-block">
                                                    <a href="https://pmu.edu/research/funded-projects.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Funded Projects
                                                        </div>
                                                    </a>
    
                                                </span> 
                                                <span class="pb-2 d-block">
                                                    <a href="https://pmu.edu/research/collaborations-and-MoU.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Collaborations and MoU</div>
                                                    </a>
    
                                                </span> 
                                                <span class="pb-2 d-block">
                                                    <a href="https://pmu.edu/research/funding-agencies.aspx" class="heightAuto megamenuHover d-flex noSkew">
                                                        <div>
                                                            <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                        </div>
                                                        <div>
                                                            Funding Agencies
                                                        </div>
                                                    </a>
    
                                                </span> 
                                                

                                        </li>
                                    </ul>
                                </span>
                            </div>
                        </div>

                    </li>
                        <li class="downiqac">
                            <a href="#" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16">iqac</span></a>
                            <div class="iqacmenu fadeIn animated">
                                <div class="">

                                    <span class="categories-list">
                                        <div class="text-center">
                                            <h4 class=" upperCase OswaldR Oswald headerBottom pb-3">iqac</h4>
                                        </div>
                                        <ul class="w-100 d-flex flex-wrap">
                                            <!-- <li class=" upperCase OswaldR Oswald headerBottom pb-2">IQAC</li> -->
                                            <li class="w-25 text-center liRight"><a href="https://pmu.edu/iqac/default.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Home
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/about.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        About
                                                    </div></a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/co-ordinators.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Coordinators
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center ">
                                                <a href="https://pmu.edu/iqac/Members.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Members
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/meetings.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Meeting
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/contact.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Contact
                                                    </div>
                                                </a>


                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/reports.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Report
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center ">
                                                <a href="https://pmu.edu/iqac/gallery.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Gallery
                                                    </div>
                                                </a>


                                            </li>
                                            <!-- <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/nirf.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        NIRF
                                                    </div>
                                                </a>

                                            </li> -->
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/naac.aspx" target="_blank" class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        NAAC 
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/aqar.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        AQAR
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/policies-procedures.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="./images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Policies and Procedures
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center "><a href="https://pmu.edu/iqac/feedback-on-curricular-aspects.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Feedback on Curricular Aspects
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/pmistannualrep.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        PMIST Annual Report
                                                    </div>
                                                </a>
                                            </li>
                                        <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/initiatives.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Initiatives
                                                    </div>
                                                </a>
                                            </li>
                                         
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/staff-appraisal.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Staff Appraisal 
                                                    </div>
                                                </a>
                                            </li>
                                        <li class="w-25 text-center ">
                                                <a href="https://pmu.edu/iqac/Institutional-Distinctiveness.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Institutional Distinctiveness
                                                    </div>
                                                </a>
                                            </li>

                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/iqac/Best-Practices.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Best Practices
                                                    </div>
                                                </a>
                                            </li>

                                            <li class="w-25 text-center ">
                                                <a href="https://pmu.edu/iqac/events.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Events
                                                    </div>
                                                </a>
                                            </li>



                                        </ul>
                                    </span>

                                </div>

                            </div>

                        </li>
                        <li class="downcentre">
                            <a href="#" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16">Centres</span></a>
                            <div class="centermenu fadeIn animated">
                                <div class="">

                                    <span class="categories-list">
                                        <div class="text-center">
                                            <h4 class=" upperCase OswaldR Oswald headerBottom pb-3">Centres</h4>
                                        </div>
                                        <ul class="w-100 d-flex flex-wrap">

                                            <li class="w-25  liRight">
                                                <a href="https://pmu.edu/placement/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Centre for Institute Industry Interaction (CIII)
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 liRight">

                                                <a href="https://pmu.edu/centres/centre-for-students-and-administrative-services.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div><img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>

                                                        Centre For Students And Administrative
                                                        Services
                                                    </div>
                                                </a>

                                            </li>
                                            <li class="w-25 liRight">

                                                <a href="https://pmu.edu/centres/Centre-for-Human-Resource-Development.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>

                                                        Centre for Human Resource Development
                                                    </div>
                                                </a>

                                            </li>
                                            <li class="w-25">
                                                <a href="https://pmu.edu/centres/kkcps.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Dr. Kalaignar M.Karunanithi Centre For
                                                        Political Science
                                                    </div>
                                                </a>


                                            </li>
                                            <li class="w-25 liRight">
                                                <a href="https://pmu.edu/centres/veeramani-mohana-centre-for-quality-life-engineering-research.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Veeramani Mohana Centre For Quality Of
                                                        Life Engineering Research (I/C)
                                                    </div>
                                                </a>

                                            </li>

                                            <li class="w-25 liRight">
                                                <a href="https://pmu.edu/centres/centre-for-rural-development.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Periyar Pura Centre For Rural
                                                        Development
                                                    </div>
                                                </a>

                                            </li>
                                            <li class="w-25 liRight">
                                                <a href="https://pmu.edu/centres/cetat.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Centre of Excellence For Training And
                                                        Research In Automation Technologies
                                                    </div>
                                                </a>


                                            </li>
                                            <li class="w-25">
                                                <a href="https://pmu.edu/centres/centre-of-excellence-for-next-generation-networks.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div> Centre
                                                        Of Excellence For Next Generation
                                                        Networks
                                                    </div>
                                                </a>

                                            </li>
                                            <li class="w-25 liRight">
                                                <a href="https://pmu.edu/centres/centre-of-excellence-for-periyar-thought.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Centre Of Excellence For Periyar Thought
                                                    </div>
                                                </a>

                                            </li>
                                            <li class="w-25 liRight">
                                                <a href="https://pmu.edu/centres/centre-for-energy-and-environment.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Centre for Energy and Environment (CEE)
                                                    </div>
                                                </a>

                                            </li>
                                            <li class="w-25 liRight">
                                                <a href="https://pmu.edu/centres/national-cyber-defense-resource-centre.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" /></div>
                                                    <div>
                                                        National Cyber Defense Resource Centre (NCDRC)
                                                    </div>
                                                </a>

                                            </li>
                                            <li class="w-25">
                                                <a href="https://pmu.edu/centres/CSSTP.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Centre for Scholarly Scientific Training and Publishing (CSSTP)
                                                    </div>
                                                </a>

                                            </li>
                                            <li class="w-25">
                                                <a href="https://pmu.edu/centres/Centre-for-Skill-Development-Center.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Centre For Skill Development Center
                                                    </div>
                                                </a>

                                            </li>
                                        </ul>
                                    </span>

                                </div>

                            </div>


                        </li>
                        <!-- <li class="drop-down">
                            <a href="https://pmu.edu/examination/" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16">Examination</span></a>


                        </li>  -->
                        <!-- <li class="drop-down">
                            <a href="https://pmu.edu/iqac/nirf.aspx" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16">NIRF</span></a>


                        </li> -->

                        <li class="drop-down">
                            <a href="https://pmu.edu/chat-with-a-student/" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16">Chat with a Student</span></a>


                        </li>

                        <li class="drop-down">
                            <a href="https://pmu.edu/alumni/" class="upperCase OswaldR Oswald"><span
                                    class="normalSkew textGradient f-16">Alumni</span></a>


                        </li>

                        <li class="downMore">
                            <a href="#" class="upperCase OswaldR Oswald"><span class="normalSkew textGradient f-16">More
                                    &#43;</span></a>
                            <div class="moreMenu fadeIn animated">
                                <div class="">

                                    <span class="categories-list">
                                        <div class="text-center">
                                            <h4 class=" upperCase OswaldR Oswald headerBottom pb-3">More</h4>
                                        </div>
                                        <ul class="w-100 d-flex flex-wrap">

                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/examination/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Examination
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/placement/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Placement</div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/gallery/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Gallery
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center">
                                                <a href="https://pmu.edu/events/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Events
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="http://periyartbi.pmu.edu/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        PTBI
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/careers/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Careers
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/contact/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Contact
                                                    </div>
                                                </a>


                                            </li>
                                            <li class="w-25 text-center">
                                                <a href="https://pmu.edu/gallery/mission-green.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Mission Green PMIST
                                                    </div>
                                                </a>


                                            </li>
                                            <li class="w-25 liRight">
                                                <a href="https://www.pmu.edu/capacity-development-and-skill-enhancement.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Capacity Development and Skill Enhancement Activities
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://www.pmu.edu/achievements-corner/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                      Achievement Corner
                                                    </div>
                                                </a>


                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/admission/call-letter-login.aspx"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Call Letter Download
                                                    </div>
                                                </a>


                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="http://pmiststudentportal.in/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Student Portal
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center">
                                                <a href="https://pmu.edu/students-grievance/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Student Grievance Online
                                                    </div>
                                                </a>


                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/career-counselling/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Career Guidance
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/sustainable-development/"
                                                    class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Sustainable Development
                                                    </div>
                                                </a>
                                            </li>
                                            <li class="w-25 text-center liRight">
                                                <a href="https://pmu.edu/Counsellors.aspx"class="heightAuto megamenuHover d-flex noSkew">
                                                    <div>
                                                        <img src="../images/dot-arrow.png" class="arrowIcon" />
                                                    </div>
                                                    <div>
                                                        Counsellors
                                                    </div>
                                                </a>
                                            </li>
                                        </ul>
                                    </span>

                                </div>

                            </div>

                        </li>
                        <!-- <li>
                        <a href="#" class="upperCase OswaldR Oswald">More</a>
                    </li> -->
                    </ul>
                </nav>
            </div>

        </nav>


        <!-- Menu  -->

        <!-- Home Banner Slider  -->
        <div class="homeBanner positionRelative margin-5">
            <div class="swiper-container 
         homeSlider homeMargin">
                <div class="swiper-wrapper">
                
                    <asp:PlaceHolder ID="phslider" runat="server"></asp:PlaceHolder>

                </div>

            </div>
            <div class="swiper-pagination"></div>

            <div>
               
            </div>
        </div>
        <!--  End of Home Banner Slider  -->
        <div class="adm__btn">
             <div class="registration__new-sticky">
                <!-- <a href="http://14.139.171.138/convocation/Login.php" target="_blank" class="registration__new">
                    31<sup style="top: 8px;
                    text-transform: lowercase;">st</sup> Convocation 2023 
                </a> -->
                 <a href="https://pmu.edu/admission/RegistrationNew.aspx" class="registration__new">Apply Now 2024</a>
          </div> 
    
            <!-- <div class="registration__new-sticky" style="top: 300px;">
                <a href="https://www.pmu.edu/chat-with-a-ambassador/" class="registration__new" style="text-transform: uppercase;">Chat with a Student</a>
            </div> -->
        </div>

        <!-- <div class="chat-sticky" style="top: 300px; display: none;">
            <a href="https://www.pmu.edu/chat-with-a-ambassador/" class="registration__new" style="text-transform: uppercase;">Chat with a Student</a>
        </div> -->
 <!-- Text Scroll -->
 <div class="news__upt">
     <div class="arrow-pointer Oswald OswaldR">
         Updates
     </div>
     <div class="position-relative marquee-container">
        <marquee behavior="scroll" direction="left" Scrollamount="5" loop="infinite">
            <!-- <img src="home-new/info-f.png">
            <a href='https://pmu.edu/dare2022/' target="_blank" class='blackColor textdecorationNone'>Dare 2022 - Marathon For A Cause - Register Now</a> &nbsp; &nbsp;  -->
            
            <!-- <img src="home-new/info-f.png">
            <a href="https://forms.gle/ArRbmTuEHby1UdRU6" target="_blank"
                    class="blackColor textdecorationNone">
                            Open House 2022 - Register Now
                </a> &nbsp; &nbsp; 
               
            
            <img src="home-new/info-f.png">
            <a href='https://pmu.edu/admission/RegistrationNew.aspx' target="_blank" class='blackColor textdecorationNone'>
                Admission 2023 - Apply Now
            </a> &nbsp; &nbsp;  -->
            <!-- <img src="home-new/info-f.png">
            <a href='https://pmu.edu/vaagaisoodavaareer/' target="_blank" class='blackColor textdecorationNone'>
                Vaagai Sooda Vareer - Career Guidance Programme
            </a> &nbsp; &nbsp;  -->
            
            <!-- <img src="home-new/info-f.png">
            <a href="http://14.139.171.138/convocation/Login.php" target="_blank"
                    class="blackColor textdecorationNone">
                    31<sup>st</sup> Convocation 2023 - Register Now
                </a>
                &nbsp; &nbsp;  -->
                <img src="home-new/info-f.png">
                <a href="https://pmu.edu/pdf/finefees-tution.pdf" target="_blank"
                        class="blackColor textdecorationNone">
                        Tuition fees for Even semester 2024-25 - Last Date extended with fine
                    </a>
                    &nbsp; &nbsp; 
<img src="home-new/info-f.png">
                <a href="https://pmu.edu/pdf/Ph.D.Admission-25.pdf" target="_blank"
                        class="blackColor textdecorationNone">
                        Ph.D. Admission 2024-25 Slot II
                    </a>
                    &nbsp; &nbsp; 

                <img src="home-new/info-f.png">
                <a href="https://www.pmu.edu/department-of-foundation-courses/about.aspx" target="_blank"
                        class="blackColor textdecorationNone">
                        Dual B. Tech. Degree Programme
                    </a> &nbsp; &nbsp; 
 <img src="home-new/info-f.png">
            <a href="https://pmu.edu/examination/RevisedTimeTable-Nov-Dec2024.jpg" target="_blank"
                    class="blackColor textdecorationNone">
                    Revised Time Table - Nov/Dec 2024
                </a> &nbsp; &nbsp; 
 <!-- <img src="home-new/info-f.png">
            <a href="https://pmu.edu/examination/27-28-Nov-ExamPostponed.jpg" target="_blank"
                    class="blackColor textdecorationNone">
                    Exam Postponement Notice - Nov 27 & 28, 2024
                </a> &nbsp; &nbsp;  -->
            <img src="home-new/info-f.png">
            <a href="https://pmu.edu/examination/" target="_blank"
                    class="blackColor textdecorationNone">
                    End Semester Examinations Schedule - Nov./Dec. 2024
                </a> &nbsp; &nbsp; 
                <img src="home-new/info-f.png">
                <a href="https://pmu.edu/admission/ResearchApplicationRegister.aspx" target="_blank"
                class="blackColor textdecorationNone">
                Ph.D. Application


                </a>
                &nbsp; &nbsp; 

                <img src="home-new/info-f.png">
            <a href="https://pmu.edu/admission/scholarship.aspx" target="_blank"
                    class="blackColor textdecorationNone">
                    Scholarships - Know More
                </a>
                &nbsp; &nbsp; 
               

              
        </marquee>
    </div>
 </div>
        
        <div class="certificate-section row col-lg-12 my-sm-5 my-4">
            <div class="col-lg-2 col-sm-2 col-4"> 
                <img src="home-new/certificates/7.png">
            </div>
            <div class="col-lg-2 col-sm-2 col-4"> 
                <img src="home-new/certificates/1.png">
            </div>
            <div class="col-lg-2 col-sm-2 col-4"> 
                <img src="home-new/certificates/2.png">
            </div>
            <div class="col-lg-2 col-sm-2 col-4"> 
                <img src="home-new/certificates/3.png">
            </div>
            <div class="col-lg-2 col-sm-2 col-4"> 
                <img src="home-new/certificates/4.png">
            </div>
            <div class="col-lg-2 col-sm-2 col-4"> 
                <img src="home-new/certificates/5.png">
            </div>
            <!-- <div class="col-lg"> 
                <img src="home-new/certificates/6.png">
            </div> -->
            
        </div>
        
        <div class="newsSection mt-sm-5  container-fluid">
            <div class="row pb-2">
                <div class="col-lg-11 mx-auto pb-0">
                    <div>
                        <h5 class="upperCase blueColor py-3 m-0 Oswald OswaldR text-center"> THINK . INNOVATE . Transform. </h5>
                        <p class="text-center line-ht-28">Pursue your career defining degree from PMIST (Periyar Maniammai Institute of Science & Technology), a reputed Deemed to be University with finest professional and supportive environment. With over 100 plus industry tie-ups, 100% placement assistance and value added certificate programs, be rest assured for a promising future.
                            <span class="d-none d-md-inline">PMIST imparts quality education, value added certification courses for better employment opportunities, ICT enabled classrooms, well-equipped library that shelves over 90,000 books & research journals, well-equipped laboratories and a fleet of highly qualified faculty members to provide an excellent academic environment that enables its students to Think, Innovate and Transform.</span>
                        </p>
                    </div>
                </div>
                <!-- <div
                    class="col-lg-2 col-md-2 col-sm-2 col-xs-12 d-flex justify-content-center align-items-center newLogoAfter positionRelative">
                    <img src="images/new-logo1-1.png" class="" />
                </div>
                <div class="col-lg-5 col-md-5 col-sm-5 col-xs-12">
                    <div>
                        <h5 class="upperCase blueColor py-3 m-0 Oswald OswaldR"> News Update </h5>
                        <div class="swiper-container newsSlider mt-4">
                            <div class="swiper-wrapper">
                                <asp:PlaceHolder ID="phNewsSlider" runat="server"></asp:PlaceHolder>
                            </div></div>

                    </div>
                </div> -->
            </div>
            <div class="col-12 text-center">
                <a href="https://pmu.edu/virtualtour/index.htm" class="btn btn-dark" target="_blank">360<sup>o</sup> View</a>
            </div>
        </div>
      
        <div class="school-section col-lg-11 row mx-auto mt-sm-5 mt-3">
            <div class="col-lg-6 col-sm-6">
                <div class="school-section-list">
                    <div class="box">
                        <img src="home-new/schools/1.jpg">
                        <div class="box-content">
                            <h5>FACULTY OF ARCHITECTURE &amp; PLANNING</h5>
                            <ul>
                                <li>
                                    <a href="https://www.pmu.edu/department-of-architecture/"
                                                class="whiteColor textdecorationNone">Department of Architecture</a>
                                </li>
                            </ul>
                        </div>
                        <div class="school-overlay">
                            <div class="vert__center">
                                <h5>FACULTY OF ARCHITECTURE &amp; PLANNING</h5>
                                <div class="d-flex justify-content-center" data-aos="fade-up" data-aos-duration="2000" data-aos-once="true">
                                    <div class="header-line"></div>
                                    <div class="header-circle"></div>
                                    <div class="header-line"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-6 col-sm-6">
                <div class="school-section-list">
                    <div class="box">
                        <img src="home-new/schools/2.jpg">
                        <div class="box-content">
                            <h5>FACULTY OF COMPUTING SCIENCE AND APPLICATIONS</h5>
                            <ul>
                                <li>
                                    <a href="https://www.pmu.edu/department-of-informatics/" class="whiteColor textdecorationNone">
                                        Department of Informatics
                                    </a>
                                </li>
                                <li>
                                    <a href="https://pmu.edu/cse/" class="whiteColor textdecorationNone">
                                        Department of Computer Science </a>
                                </li>
                                <li>
                                    <a href="https://pmu.edu/department-of-software-engineering/" class="whiteColor textdecorationNone">
                                        Department of Software Engineering </a>
                                </li>
                                <li>
                                    <a href="https://pmu.edu/department-of-computer-science-applications/" class="whiteColor textdecorationNone">
                                        Department of Computer Applications </a>
                                </li>
                               

                            </ul>
                        </div>
                        <div class="school-overlay">
                            <div class="vert__center">
                                <h5>FACULTY OF COMPUTING SCIENCE AND APPLICATIONS</h5>
                                <div class="d-flex justify-content-center" data-aos="fade-up" data-aos-duration="2000" data-aos-once="true">
                                    <div class="header-line"></div>
                                    <div class="header-circle"></div>
                                    <div class="header-line"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="vert__section my-3">
            <div class="d-flex justify-content-center cnt-circle" data-aos="fade-up" data-aos-duration="2000" data-aos-once="true">
                <div class="header-line"></div>
                <div class="header-circle"></div>
                <div class="header-line"></div>
            </div>
        </div>
        
        <div class="school-section col-lg-11 row mx-auto mb-4 ">
            <div class="col-lg-6 col-sm-6">
                <div class="school-section-list">
                    <div class="box">
                        <img src="home-new/schools/3.jpg" class="h-m-img">
                        <div class="box-content">
                            <h5>FACULTY OF ENGINEERING AND TECHNOLOGY</h5>
                            <ul>
                                <li>
                                    <a href="https://pmu.edu/department-of-aerospace/" class="whiteColor textdecorationNone">
                                        Department of Aerospace
                                     </a>
                                </li>
                                <li>
                                    <a href="https://pmu.edu/department-of-biotechnology/" class="whiteColor textdecorationNone">
                                        Department of Biotechnology
                                    </a>
                                </li>
                               
                                <li>
                                    <a href="https://pmu.edu/department-of-civil-engineering/" class="whiteColor textdecorationNone">
                                        Department of Civil Engineering
                                     </a>
                                </li>
                                <li>
                                    <a href="https://www.pmu.edu/cse/" class="whiteColor textdecorationNone">
                                        Department of Computer Science and Engineering
                                    </a>
                                </li>
                                <li>
                                    <a href="https://pmu.edu/department-of-electronics-and-communication/" class="whiteColor textdecorationNone">
                                        Department of Electronics and Communication Engineering </a>
                                   
                                </li>
                                <li>
                                    <a href="https://pmu.edu/department-of-electrical-and-electronics/" class="whiteColor textdecorationNone">
                                        Department of Electrical and Electronics Engineering</a>
                                    
                                </li>
                                <li>
                                    <a href="https://pmu.edu/department-of-mechanical-engineering/" class="whiteColor textdecorationNone">
                                        Department of Mechanical Engineering
                                    </a>
                                  
                                </li>
                               
                            </ul>
                        </div>
                        <div class="school-overlay">
                            <div class="vert__center">
                                <h5>FACULTY OF ENGINEERING AND TECHNOLOGY</h5>
                                <div class="d-flex justify-content-center" data-aos="fade-up" data-aos-duration="2000" data-aos-once="true">
                                    <div class="header-line"></div>
                                    <div class="header-circle"></div>
                                    <div class="header-line"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-6 col-sm-6">
                <div class="school-section-list">
                    <div class="box">
                        <img src="home-new/schools/Faculty-of-Commerce.jpg">
                        <div class="box-content">
                            <h5>FACULTY OF COMMERCE</h5>
                            <ul>
                                <li>
                                    <a href="https://www.pmu.edu/department-of-commerce/" class="whiteColor textdecorationNone">
                                      
                                        Department of Commerce
                                                        
                                    </a>
                                </li>
                               

                            </ul>
                        </div>
                        <div class="school-overlay">
                            <div class="vert__center">
                                <h5>FACULTY OF COMMERCE</h5>
                                <div class="d-flex justify-content-center" data-aos="fade-up" data-aos-duration="2000" data-aos-once="true">
                                    <div class="header-line"></div>
                                    <div class="header-circle"></div>
                                    <div class="header-line"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="vert__section my-3">
            <div class="d-flex justify-content-center cnt-circle" data-aos="fade-up" data-aos-duration="2000" data-aos-once="true">
                <div class="header-line"></div>
                <div class="header-circle"></div>
                <div class="header-line"></div>
            </div>
        </div>

        <div class="school-section col-lg-11 row mx-auto pb-4">
            <div class="col-lg-6 col-sm-6">
                <div class="school-section-list">
                    <div class="box">
                        <img src="home-new/schools/Faculty-of-Management-Studies.jpg">
                        <div class="box-content">
                            <h5>FACULTY OF MANAGEMENT STUDIES</h5>
                            <ul>
                                <li>
                                    <a href="https://www.pmu.edu/department-of-management-studies/"
                                                class="whiteColor textdecorationNone">
                                                Department of Management Studies
                                            </a>
                                </li>
                            </ul>
                        </div>
                        <div class="school-overlay">
                            <div class="vert__center">
                                <h5>FACULTY OF MANAGEMENT STUDIES</h5>
                                <div class="d-flex justify-content-center" data-aos="fade-up" data-aos-duration="2000" data-aos-once="true">
                                    <div class="header-line"></div>
                                    <div class="header-circle"></div>
                                    <div class="header-line"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-6 col-sm-6">
               
                <div class="school-section-list">
                    <div class="box">
                        <img src="home-new/schools/4.jpg" class="h-m-img">
                        <div class="box-content row mx-0 px-0 col-lg-12">
                            <h5>
                                FACULTY OF SCIENCE AND HUMANITIES
                            </h5>
                            <ul class="col-lg-6 pl-sm-5 mb-0">
                                <li>
                                    <a href="https://www.pmu.edu/department-of-foundation-courses/" class="whiteColor textdecorationNone">
                                        Department of Foundation Courses
                                    </a>
                                </li>
                                <li>
                                    <a href="https://pmu.edu/department-of-chemistry/" class="whiteColor textdecorationNone">Department of Chemistry</a>
                                </li>
                              
                                <li>
                                    <a href="https://pmu.edu/department-of-english/"class="whiteColor textdecorationNone">Department of Languages
                                            </a>
                                </li>
                                <li>
                                    <a href="https://pmu.edu/department-of-physics/" 
                                    class="whiteColor textdecorationNone">Department of Physics
                                </a>
                                </li>
                                <li>
                                    <a href="https://pmu.edu/department-of-mathematics/"
                                    class="whiteColor textdecorationNone">Department of Mathematics </a>
                                </li>
                                
                                
                                
                                </ul>
                                <ul class="col-lg-6 pl-sm-5 mb-0">
                                    <li>
                                        <a href="https://pmu.edu/department-of-education/"
                                        class="whiteColor textdecorationNone">Department of Education</a>
                                    </li>
                                    <li>
                                        <a href="https://pmu.edu/department-of-political-science/"
                                                    class="whiteColor textdecorationNone">Department of Political Science </a>
                                    </li>
                                    <li>
                                        <a href="https://pmu.edu/department-of-social-work/"
                                                    class="whiteColor textdecorationNone">Department of Social Work </a>
                                    </li>
                                    <li>
                                    <a href="https://pmu.edu/library/"
                                                class="whiteColor textdecorationNone">Department of Library Sciences </a>
                                </li>
                                    <li>
                                        <a href="https://www.pmu.edu/campus/physical-education.aspx"
                                        class="whiteColor textdecorationNone">Department of Physical Education </a>
                                    </li>
                              
                                

                            </ul>
                        </div>
                        <div class="school-overlay">
                            <div class="vert__center">
                                <h5>FACULTY OF SCIENCE AND HUMANITIES</h5>
                                <div class="d-flex justify-content-center" data-aos="fade-up" data-aos-duration="2000" data-aos-once="true">
                                    <div class="header-line"></div>
                                    <div class="header-circle"></div>
                                    <div class="header-line"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <div class="col-lg-11 mx-auto mb-5 p-0">
            <div class="whatsnew-section-border">
                <div class="whatsnew-section shadow py-4 px-4">
                    <h6>What's New</h6>
                    <h5 class="upperCase pb-3 m-0 mb-3 Oswald OswaldR text-center">Industry-Ready Programs </h5>
                    <div class="tab_section col-lg-12 mx-auto px-0 wrapper" data-aos="fade-up" data-aos-duration="2000" data-aos-once="true">
                        <div class="tab-head-sec col-xl-8 col-lg-10 row mx-auto px-0">
                            <input type="radio" name="slider" checked id="spec">
                            <input type="radio" name="slider" id="newcourses">
                        <nav>
                            <label for="spec" class="home"><i class="fa fa-dot-circle-o pr-0" style="font-size: 14px;" aria-hidden="true"></i> B.Tech Specialization Courses</label>
                            <label for="newcourses" class="blog"><i class="fa fa-dot-circle-o pr-0" style="font-size: 14px;" aria-hidden="true"></i> New Courses</label>
                            <div class="slider"></div>
                        </nav>
                        </div>
                        <section>
                          <div class="content content-1">
                              <div class="row col-lg-12 px-sm-3 px-0">
                                <ul class="col-lg-6 px-sm-3 px-0 mb-0">
                                    <li>
                                        <img src="home-new/check-mark.png">
                                        B.Tech. (Hons.) - Aerospace Engineering with
                                        specialization in Unmanned Aerial Vehicle
                                        </li>
                                        <li><img src="home-new/check-mark.png">
                                            B.Tech. (Hons.) - Biotechnology with specialization in
                                                                    Computer Science and Biology
                                        </li>
                                        <li><img src="home-new/check-mark.png">
                                            B.Tech. (Hons.) - Civil Engineering with specialization in
                                                                    GIS and Remote Sensing
                                        </li>
                                        <li><img src="home-new/check-mark.png"> B.Tech. (Hons.) - ECE with specialization in AI and ML</li>
                                        <li><img src="home-new/check-mark.png"> B.Tech. (Hons.) - ECE with specialization in
                                            Robotics and Industrial Automation</li>
                                        <li><img src="home-new/check-mark.png"> B.Tech. (Hons.) - EEE with specialization in Electric Vehicles</li>
                                        
                                </ul>
                                <ul class="col-lg-6 px-sm-3 px-0 mb-0">
                                    <li><img src="home-new/check-mark.png"> B.Tech. (Hons.) - EEE with specialization in 
                                        Energy Engineering</li>
                                    <li><img src="home-new/check-mark.png"> B.Tech. (Hons.) - Mechanical Engineering with 
                                        specialization in Robotics and Industrial Automation</li>
                                    <li><img src="home-new/check-mark.png"> B.Tech. (Hons.) - Mechanical Engineering with  
                                        specialization in Energy Engineering</li>
                                    <li><img src="home-new/check-mark.png"> B.Tech. (Hons.) - CSE with specialization in AI and ML</li>
                                    <li><img src="home-new/check-mark.png"> B.Tech. (Hons.) - CSE with specialization in Data Science</li>
                                    <li><img src="home-new/check-mark.png"> B.Tech. (Hons.) - CSE with specialization in Cyber Security</li>
                                </ul>
                              </div>
                            
                          </div>
                          <div class="content content-2" style="display: none;">
                            <div class="row col-lg-12 px-sm-3 px-0">
                                <ul class="col-lg-6 px-sm-3 px-0 mb-0">
                                    <li>
                                        <img src="home-new/check-mark.png">
                                        B.B.A. Hospitality Management
                                    </li>
                                    <li><img src="home-new/check-mark.png"> B.Sc Mathematics and Data Analytics </li>
                                    <li><img src="home-new/check-mark.png">B.Sc. Artificial Intelligence </li>
                                    <li><img src="home-new/check-mark.png">B.Sc. Healthcare Analytics </li>
                                </ul>
                                <ul class="col-lg-6 px-sm-3 px-0 mb-0">
                                    <li><img src="home-new/check-mark.png"> B.Tech Artificial Intelligence & Data Science</li>
                                    <li><img src="home-new/check-mark.png"> B.Sc. Data Science </li>
                                    <li><img src="home-new/check-mark.png"> B.A. Journalism and Mass Communication</li>
                                    <li><img src="home-new/check-mark.png"> B.Sc. Biotechnology</li>
                                </ul>
                                <div class="col-lg-12 cnt-title-course">
                                    <div class="header-line"></div>
                                    <h5>After noon batch</h5>
                                    <div class="header-line"></div>
                                </div>
                                <ul class="col-lg-6 px-sm-3 px-0 mb-0">
                                    <li><img src="home-new/check-mark.png"> B.C.A. </li> 
                                    <li><img src="home-new/check-mark.png"> B.Com. CA </li>
                                </ul>
                                <ul class="col-lg-6 px-sm-3 px-0 mb-0">
                                    <li><img src="home-new/check-mark.png"> B.Sc. Computer Science </li>
                                    <li><img src="home-new/check-mark.png"> B.B.A.  </li>
                                </ul>
                            </div>
                            
                          </div>
                          <div class="ad-btn">
                            <a href="https://pmu.edu/admission/RegistrationNew.aspx">
                                Apply Now 2024 
                            </a>
                          </div>
                        </section>
                    </div>
                </div>
                
            </div>
            
        </div>

        <div class="container-fluid my-5 pb-5 pt-4">
            <div class="row">
                <div class="recruiters-tab mx-auto">
                    <div class="wrapper d-flex">
                        <nav class="recruiterstabs">
                            <div class="selector"></div>
                            <a href="#top-recruiters" class="active top-recruiters-tab"> Top Recruiters</a>
                            <a href="#affiliation" class="affiliation-tab">Professional Affiliations</a>
                        </nav>
                    </div>
                </div>
                <div class="recruiters-rows col-xl-12" id="top-recruiters">
                    <div class="swiper-container recruiterSlider mt-4">
                        <div class="swiper-wrapper">
                            <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/26.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/12.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/11.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/16.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/20.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages" style="background:url('./images/rec/8.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/13.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/18.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/17.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/25.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages" style="background:url('./images/rec/2.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages" style="background:url('./images/rec/5.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages" style="background:url('./images/rec/3.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages" style="background:url('./images/rec/6.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/22.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/21.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages" style="background:url('./images/rec/4.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/10.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages" style="background:url('./images/rec/7.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/15.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/23.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/24.png');">
                                    </div>


                                   
                                   
                                    
                                    
                                   
                                    
                                    
                                    <div class="swiper-slide recruiterImages" style="background:url('./images/rec/9.png');">
                                    </div>
                                    <div class="swiper-slide recruiterImages" style="background:url('./images/rec/1.png');">
                                    </div>
                                    
                                   
                                    
                                    
                                    <div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/14.png');">
                                    </div><div class="swiper-slide recruiterImages"
                                        style="background:url('./images/rec/19.png');">
                                    </div>
                        </div>
                    </div>
                </div>
                <div class="recruiters-rows col-xl-12 mt-4" id="affiliation" style="display: none;">
                    
                    <div id="owl-demo2" class="owl-carousel"> 
                        <div class="item"><img src="professional-bodies/1.png" alt="Owl Image"></div>
                        <div class="item"><img src="professional-bodies/2.png" alt="Owl Image"></div>
                        <div class="item"><img src="professional-bodies/3.png" alt="Owl Image"></div>
                        <div class="item"><img src="professional-bodies/4.png" alt="Owl Image"></div>
                        <div class="item"><img src="professional-bodies/5.png" alt="Owl Image"></div>
                        <div class="item"><img src="professional-bodies/6.png" alt="Owl Image"></div>
                        <div class="item"><img src="professional-bodies/7.png" alt="Owl Image"></div>
                        <div class="item"><img src="professional-bodies/8.png" alt="Owl Image"></div>
                        <div class="item"><img src="professional-bodies/9.png" alt="Owl Image"></div>
                        <div class="item"><img src="professional-bodies/10.png" alt="Owl Image"></div>
                        <div class="item"><img src="professional-bodies/11.png" alt="Owl Image"></div>
                        <div class="item"><img src="images/a-2.png" alt="Owl Image"></div>
                        <div class="item"><img src="images/ncsass.png" alt="Owl Image"></div>
                    </div>
                </div>
            </div>
        </div>

        <!-- End of Courses Section  -->
     
        

 <!-- Modal -->
 <div class="modal fade px-0" id="myModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-xl" role="document">
        <div class="modal-content" style="background-color: transparent;">
            <div class="modal-body pt-0">
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true" style="font-size: 25px; color: #fff;">&times;</span>
            </button>        
            <!-- 16:9 aspect ratio -->
                <div class="embed-responsive embed-responsive-16by9">
                    <iframe class="embed-responsive-item" src="" id="video"  allowscriptaccess="always" allow="autoplay"></iframe>
                </div>
            </div>
        </div>
    </div>
</div> 
        <!-- Campus Highlights  -->
        <div class="campusSection footerBg my-5">
            <div class=" ">
                <div class="row">
                    <div class="col-lg-3 col-sm-6 mx-auto col-xs-12 offset-lg-1 campus-highlights col-11 pl-0">
                        <div class="tablinkOne-img video-btn" style="cursor: pointer;" data-toggle="modal" data-src="https://www.youtube.com/embed/jtS-Dl7QRyo" data-target="#myModal">
                            <img src="home-new/h-vid-thum.jpg">
                            <div class="play-icon">
                                <img src="home-new/play-icon.png">
                            </div>
                        </div>
                        <div class="tablinkOne1-img" style="display: none;">
                            <img src="home-new/camp-1.png" >
                            <h4>Campus Life </h4>
                        </div>
                        <div class="tablinkOne5-img" style="display: none;">
                            <img src="home-new/camp-2.png">
                            <h4>Library</h4>
                        </div>
                        <div class="tablinkOne2-img" style="display: none;">
                            <img src="home-new/camp-3.png">
                            <h4>Hostel</h4>
                        </div>
                        <div class="tablinkOne3-img" style="display: none;">
                            <img src="home-new/camp-4.png">
                            <h4>Sports</h4>
                        </div>
                        <div class="tablinkOne4-img" style="display: none;">
                            <img src="home-new/camp-5.png">
                            <h4>Green Campus</h4>
                        </div>
                        
                        <!-- <div class="another-btn text-right mr-3">
                            <button type="button" class="tablinkOne tablinkOne1 whiteColor campusButton activeEventOne"
                                onclick="openCityOne(event,'campusOne'); return false;">
                            </button>
                            <button type="button" class="tablinkOne tablinkOne5
                            whiteColor campusButton"
                               onclick="openCityOne(event,'campusFive') ; return false;">
                           </button>
                            <button type="button" class="tablinkOne tablinkOne2 whiteColor campusButton"
                                onclick="openCityOne(event,'campusTwo'); return false;">
                            </button>
                            <button type="button" class="tablinkOne tablinkOne3 whiteColor campusButton"
                                onclick="openCityOne(event,'campusThree') ; return false;">
                            </button>
                            <button type="button" class="tablinkOne tablinkOne4 whiteColor campusButton"
                                onclick="openCityOne(event,'campusFour') ; return false;">
                            </button>
                           
                        </div> -->
                    </div>
                    <div class="col-lg-8 col-sm-12 col-md-12 col-xs-12 campus-highlights-rgt">
                        <div>
                            <div class="col-xl-11 col-lg-12 px-sm-3 px-0">
                                <div class="campus d-flex justify-content-between flex-wrap">
                                    <button type="button" class="tablinkOne tablinkOne1 whiteColor campusButton activeEventOne"
                                        onclick="openCityOne(event,'campusOne'); return false;">
                                        <h6> Campus Life </h6>
                                    </button>
                                    <button type="button" class="tablinkOne tablinkOne5 whiteColor campusButton"
                                        onclick="openCityOne(event,'campusFive') ; return false;">
                                        <h6> Library </h6>
                                    </button>
                                    <button type="button" class="tablinkOne tablinkOne2 whiteColor campusButton"
                                        onclick="openCityOne(event,'campusTwo'); return false;">
                                        <h6> Hostel </h6>
                                    </button>
                                    <button type="button" class="tablinkOne tablinkOne3 whiteColor campusButton"
                                        onclick="openCityOne(event,'campusThree') ; return false;">
                                        <h6> Sports </h6>
                                    </button>
                                    <button type="button" class="tablinkOne tablinkOne4 whiteColor campusButton"
                                        onclick="openCityOne(event,'campusFour') ; return false;">
                                        <h6> Green Campus </h6>
                                    </button>
                                    

                                </div>

                                <!-- <div class="campus-highlights-cnt mt-4"><p>
                                        PMIST is an Eco friendly, Energy efficient, Green & Clean, Ragging free Conducive environment for student's life. The University is located on a land area of 114.85 acres, which once were barren and dry with scarce population in rural area. It is an energy efficient, pollution-free, zero waste and well-laid campus with an ambience for learning. 
                                    </p>
                                </div> -->

                                <div id="campusOne" class="cityOne whiteColor faceEffect activeEventOne">
                                    <div class="pt-4 row col-lg-12">
                                        <p>
                                            PMIST is an Eco friendly, Energy efficient, Green & Clean, Ragging free Conducive environment for student's life. The University is located on a land area of 114.85 acres, which once were barren and dry with scarce population in rural area. It is an energy efficient, pollution-free, zero waste and well-laid campus with an ambience for learning. 
                                        </p>
                                        <div class="col-lg-12 px-0">
                                            <div class="campusList row col-lg-12 mx-lg-0 mt-sm-4 px-0 mx-0">
                                                <div class="col-lg-4 col-sm-4 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">Anti-ragging </h4>
                                                        <p>Campus</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-4 col-sm-4 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">24 Hours</h4>
                                                        <p>Hospital</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-4 col-sm-4">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">WI-FI </h4>
                                                        <p>Connectivity</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- <div class="ad-btn mt-sm-5 mt-3 mb-lg-3 mb-5 mx-auto" style="position: unset;">
                                            <a target="_blank" class="text-uppercase f-16 rounded-0" href="https://www.pmu.edu/chat-with-a-ambassador/">
                                                chat with a student
                                            </a>
                                          </div> -->
                                    </div>
                                </div>
                                <div id="campusTwo" class="cityOne whiteColor faceEffect" style="display:none">
                                    <div class="pt-4 row col-lg-12">
                                       <p>To cater to the needs of residential students, PMIST has established three Women’s hostels and one Men’s Hostel. </p>
                                        <div class="col-lg-12 px-0">
                                            <div class="campusList row col-lg-12 mx-lg-0 mt-sm-4 px-0 mx-0">
                                                <div class="col-lg-3 col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">Separate Hostels </h4>
                                                        <p>for Boys and Girls</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-3 col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">Hygienic & Nutrient</h4>
                                                        <p>steam cooking Facilities</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-3 col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">Audio & Video</h4>
                                                        <p> Facilities in Dining Halls</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-3 col-sm-3 col-6">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">24 hours hospital</h4>
                                                        <p>support within campus</p>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                                <div id="campusThree" class="cityOne whiteColor faceEffect" style="display:none">
                                    <div class="pt-4 row col-lg-12">
                                        <p>
                                            Periyar Maniammai Institute of Science & Technology emphasizes on total personality development of all students so that they can serve for the advancement of the Nation. 
                                        </p>
                                        <div class="col-lg-12 px-0">
                                            <div class="campusList row col-lg-12 mx-lg-0 mt-sm-4 px-0 mx-0">
                                                <div class="col-lg-3 col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">Professional </h4>
                                                        <p>Play Ground</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-3 col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">Separate courts</h4>
                                                        <p>for different sports</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-3 col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">Dedicated tutor</h4>
                                                        <p>for sports</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-3 col-sm-3 col-6">
                                                    <div class="count-list"><h4 class="whiteColor">Encouragement </h4>
                                                        <p>to participate</p>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                                <div id="campusFour" class="cityOne whiteColor faceEffect" style="display:none">
                                    <div class="pt-4 row col-lg-12">
                                        <p>PMU campus has around 4,500 shrubs and plant varieties, 26,000 native trees and endangered trees. Such thick foliage of vegetation releases oxygen of 8.4 tonnes per day and CO2 absorption is around 1.6 tonnes per day. </p>

                                        <div class="col-lg-12 px-0">
                                            <div class="campusList row col-lg-12 mx-lg-0 mt-sm-4 px-0 mx-0">
                                                <div class="col-lg-3 col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">Eco-green</h4>
                                                        <p>campus</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-3 col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">4,500</h4>
                                                        <p>shrubs</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-3 col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">26,000</h4>
                                                        <p>native trees</p>
                                                    </div>
                                                </div>
                                                <div class="col-lg-3 col-sm-3 col-6">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">R World</h4>
                                                        <p>Institutional Ranking</p>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="campusList row col-lg-12 mx-0">
                                                
                                            </div>

                                        </div>
                                    </div>
                                </div>
                                 <div id="campusFive" class="cityOne whiteColor faceEffect" style="display:none">
                                    <div class="pt-4 row">
                                        <div class="col-lg-12">
                                            <p>
                                                The library has an extensive collection of Books, Thesis, Dissertations, Journals, Newspapers, E-books and more catalogued and arranged for the easy access of our students. 
                                            </p>
                                            <div class="campusList row col-lg-12 mx-lg-0 mt-sm-4 px-0 mx-0">
                                                <div class="col-lg col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">93,097 </h4>
                                                        <p>Books </p>
                                                    </div>
                                                </div>
                                                <div class="col-lg col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">308 </h4>
                                                        <p>Journals </p>
                                                    </div>
                                                </div>
                                                <div class="col-lg col-sm-3 col-6 brd-r">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">2,263 </h4>
                                                        <p>Digital Library </p>
                                                    </div>
                                                </div>
                                                <div class="col-lg col-sm-3 col-6">
                                                    <div class="count-list">
                                                        <h4 class="whiteColor">2,780 </h4>
                                                        <p>Dissertations </p>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div> 


                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <!-- End of Campus Highlights  -->


        <!-- Events  -->

        <div class="eventsSection container-fluid pt-2 pb-5">
            <h4 class="upperCase blueColor oswaldR Oswald text-center">
                <span>Events</span>
            </h4>
            <div>
                <div class=" ">

                    <div class="w3-bar w3-black">


                    </div>
                </div>

                <!-- <hr /> -->

                <div id="ongoing" class="city faceEffect">
                    <div class="swiper-container eventsSlider">
                        <div class="swiper-wrapper"><asp:Repeater ID="rprEvents" runat="server">
                                <ItemTemplate>
                                    <div class="swiper-slide ml-1 mt-2 eventsHover"
                                        style="height: 100%;">
                                        <a href='<%# bindMore(System.Convert.ToInt32(DataBinder.Eval(Container.DataItem, "EventId")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "Title")))%>'
                                            target="_blank" class="textdecorationNone blueColor">
                                            <div class=" ">
                                                <div class="d-flex align-items-center p-3">
                                                    <div class="blueColor pr-3 eventsBorder oswaldR Oswald text-center">
                                                        <div class="upperCase lt-2">
                                                            <h5 class="OswaldL">
                                                                <%# bindEventMonth(System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "EventStartDate")))%>
                                                            </h5>
                                                        </div>
                                                        <div class="">
                                                            <h5 style="font-size:20px !important">
                                                                <%# bindEventDate(System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "EventStartDate")),System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "EventEndDate")))%>
                                                            </h5>
                                                        </div>
                                                        <div class="lt-2">
                                                            <h5 class="OswaldL">
                                                                <%# bindEventYear(System.Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "EventStartDate")))%>
                                                            </h5>
                                                        </div>
                                                    </div>
                                                    <div class="pl-3">
                                                        <div class="pt-2  blackColor">
                                                            <%#Eval("Title")%>
                                                        </div>
                                                        <div>
                                                            <p class="blueColor pt-2 m-0">
                                                                <%#Eval("Department")%>
                                                            </p>
                                                        </div>
                                                        <div class="pt-2 d-flex justify-content-end pr-2">
                                                            <a href='<%# bindMore(System.Convert.ToInt32(DataBinder.Eval(Container.DataItem, "EventId")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "Title")))%>'
                                                                target="_blank"
                                                                class="orangeColor f-14 textdecorationNone">More</a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                        <hr class="mb-5 mt-0 w-85 mx-auto" style="border-style: dashed;">
                        <div class="swiper-pagination"></div>
                        <!-- <div class="swiper-button-next"></div>
                    <div class="swiper-button-prev"></div> -->
                    </div>
                </div>


            </div>
        </div>

        <!-- End of Events  -->

        
        <!-- Quick Links  -->

        <div class="quickLinks container-fluid mb-3 mt-3">
            <div class="pb-4">
                <h4 class="upperCase blueColor oswaldR Oswald text-center">
                    <span>Quick Links</span>
                </h4>
            </div>
            <div>
                <div class="d-flex flex-wrap justify-content-center">
                    
                    <a href="https://pmu.edu/pdf/ARIIA-2020-21.pdf" class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                                ARIIA 2020-21
                            </div>
                        </div>
                    </a>
                    <a href="https://pmu.edu/students-grievance/" class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                                Grievance online
                            </div>
                        </div>
                    </a>
                    <!-- <a href="https://pmu.edu/pdf/MOOCS-Courses-for-July-Nov-2019.pdf"
                        class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           <div class="upperCase f-14">
                                ugc mooc 2019-20
                            </div>
                        </div>
                    </a> -->
                    <a href="https://pmu.edu/pdf/Feedback2018-2019.pdf" class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                                Feedback analysis 2018-19
                            </div>
                        </div>
                    </a>
                   <a href="https://samadhaan.ugc.ac.in/"
                        class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                                UGC Online Grievance and Redressal System
                            </div>
                        </div>
                    </a>   
                    <a href="https://pmu.edu/pdf/AICTE2024-25.PDF"
                        class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                                Aicte approval 2024-2025
                            </div>
                        </div>
                    </a>
                    <a href="https://pmu.edu/chat-with-a-student/" class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                               Chat with a Student
                            </div>
                        </div>
                    </a>
                    <a href="https://pmu.edu/AICTE/AICTEMandatoryFiles.aspx" class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                                Aicte Mandatory disclosure
                            </div>
                        </div>
                    </a>
                    <a href="https://ariia.gov.in/Grievance" class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                                AIIRA - Grievance
                            </div>
                        </div>
                    </a>
                    <a href="https://www.aicte-india.org/feedback/index.php" class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                                AICTE Feedback
                            </div>
                        </div>
                    </a>
                    <a href="https://www.youth4work.com/onlinetalenttest" class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                                AICTE Online Talent Test
                            </div>
                        </div>
                    </a>
                    <a href="https://ncte.gov.in/website/index.aspx" class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                           
                            <div class="upperCase f-14">
                                NCTE
                            </div>
                        </div>
                    </a>
                    <a href="https://pmu.edu/careers/"
                        class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                        
                            <div class="upperCase f-14">
                                Careers @ PMIST
                            </div>
                        </div>
                    </a>
                    <a href="https://pmu.edu/alumni/"
                        class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                        
                            <div class="upperCase f-14">
                                Alumni
                            </div>
                        </div>
                    </a>
                    <a href="https://www.pmu.edu/about/accreditation-and-ranking.aspx"
                        class="blackColor textdecorationNone">
                        <div class="d-flex align-items-center quickLinksSection px-3 mb-3">
                        
                            <div class="upperCase f-14">
                                Accreditation and Ranking
                            </div>
                        </div>
                    </a>
                </div>

            </div>
        </div>

        <!-- End of Quick Links  -->

        <!-- <div class="whatsappIcon">
            <a href="https://wa.me/919790111911" class="whatsapp whiteColor" target="_blank"> <i
                    class="fa fa-whatsapp whatsapp-icon"></i></a>
        </div> -->
        <!-- Footer  -->

        <footer class="footerBg" style="background:url('./images/AFV_2183.png') ;">
            <div class="container-fluid">
                <div class="pt-5 whiteColor text-center">
                    <h3 class="m-0 pb-4">PERIYAR MANIAMMAI INSTITUTE OF SCIENCE & TECHNOLOGY (PMIST)</h3>
                </div>
                <div class="addressSection pb-2 d-flex justify-content-center align-items-center">
                    <div class="d-flex flexColumn">
                        <div class="d-flex">
                            
                            <div class="whiteColor f-14 ml-2 pr-3 borderrightNone footerBorderRight mb-3">
                                Periyar Nagar, Vallam, Thanjavur - 613403, Tamil Nadu, India
                            </div>
                        </div>
                        <div class="d-flex margin0Responsive  ml-3">
                           
                            <div class=" f-14 ml-2 pr-3 borderrightNone footerBorderRight mb-3 w-m-100">
                                <a href="tel:+91 4362 264600" class="whiteColor textdecorationNone">+91 4362 264600</a>
                            </div>
                        </div>
                        <div class="d-flex  margin0Responsive ml-3 ">
                    
                            <div class=" f-14 ml-2 pr-3 borderrightNone footerBorderRight mb-3 w-m-100">
                                <a href="mailto:registrar@pmu.edu"
                                    class="whiteColor textdecorationNone">registrar@pmu.edu</a> 
                            </div>
                        </div>
                        <!-- <div class="d-flex  margin0Responsive ml-3 ">
                    
                            <div class=" f-14 ml-2  pr-3 pb-3 w-m-100">
                                <a target="_blank" href="https://www.pmu.edu/chat-with-a-ambassador/"
                                    class="whiteColor textdecorationNone text-uppercase">Chat with a Student</a> 
                            </div>
                        </div> -->
                    </div>
                </div>
            </div>
            <div class="my-1">
                <div class="d-flex justify-content-center  positionRelative footerLogo">
                    <div class="line"></div>
                    <div class="d-flex justify-content-center">
                        
                        <a href="https://twitter.com/PMIST2"  class="" target="_blank">
                            <img src="./images/twitter-f.svg">
                        </a>
                        <a href="https://www.linkedin.com/in/pmistofficial"  class="ml-4" target="_blank">
                            <img src="./images/linkedin-f.svg">
                        </a>
                        <a href="https://www.instagram.com/pmist_official" class="ml-4"  target="_blank">
                            <img src="./images/instagram-f.svg"  />
                        </a>
                        <a href="https://www.threads.net/@pmist_official" class="ml-4"  target="_blank">
                            <img src="./images/thread-f.svg" />
                        </a>
                        <a href="https://www.facebook.com/pmuniv" class="ml-4 "  target="_blank">
                            <img src="./images/facebook.svg" />
                        </a>
                       
                        <a href="https://youtube.com/@pmistdeemedtobeuniversity" class="ml-4"  target="_blank">
                            <img src="./images/youtube.svg" />
                        </a>
                    </div>
                    <div class="line"></div>
                </div>
            </div>
            <div class="d-flex justify-content-center mt-4 container">
		<a style="display:none" href="https://itiltd.in/en/fb-login/" title="facebook login"  rel="dofollow">facebook login</a>
                <div class="d-flex justify-content-center flex-wrap">
                    <a href="http://www.ugc.ac.in/"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        ugc
                    </a>
                    <a href="https://pmu.edu/"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        nba
                    </a>
                    <!-- <a href="https://www.pmu.edu/09/ugc-new/default.html"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        MHRD/UGC Compliance
                    </a> -->
                    <a href="https://nad.gov.in/"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        NAD
                    </a>
                    <a href="http://periyartbi.pmu.edu/"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        Periyar TBI
                    </a>
                    <a href="https://pmu.edu/about/anti-discriminationcell.aspx"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        ANTI-DISCRIMINATION CELL
                    </a>
                    <a href="https://pmu.edu/about/antiragging.aspx"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        Antiragging
                    </a>
                    <a href="https://pmu.edu/chat-with-a-student/"
                    class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                   CHAT WITH A STUDENT
                </a>
                    <a href="https://pmu.edu/about/code-of-conduct-committee.aspx"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        CODE OF CONDUCT COMMITTEE
                    </a>
                    <a href="https://pmu.edu/about/grievances-and-redressal-committee.aspx"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        GRIEVANCES REDRESSAL COMMITTEE
                    </a>
                    <a href="https://pmu.edu/about/internal-complaints-committee.aspx"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        INTERNAL COMPLAINTS COMMITTEE
                    </a>
                    
                    <a href="http://www.mhrdnats.gov.in/"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        NATS
                    </a>
                    <a href="https://pmu.edu/AdmissionEnquiry/Login.aspx"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        Admin Login
                    </a>
                    <a href="https://pmu.edu/about/terms-and-conditions.aspx"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12 footerBorderRight">
                        Refund Policy
                    </a>
                    <a href="https://pmu.edu/"
                        class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12">
                        LMS
                    </a>
                    <a href="https://samadhaan.ugc.ac.in/"
                    class="whiteColor pl-2 mb-2 textdecorationNone pr-2 upperCase f-12">
                    UGC Online Grievance and Redressal System
                </a>

                </div>
            </div>
            <div class="mt-3 container text-center f-12 d-flex justify-content-between flex-wrap">
                <div class="py-3 whiteColor f-13"> 
                    <!-- Copyright Clare.AI -->
                    &#169; 
                    <script type="text/javascript">
                    var today = new Date()
                    var year = today.getFullYear()
                    document.write(year)
                    </script> Periyar Maniammai Institute of Science &amp; Technology
                </div>
                <div class="py-3">
                    <a href="https://duffldigital.com/" class="f-13 whiteColor textdecorationNone letterSpacing"
                        target="blank">Duffl Digital</a>
                </div>
            </div>
        </footer>

        <div class="whatsappIconNew">
            <a href="https://wa.me/919790111911" class="whatsapp whiteColor" target="_blank"> <img alt="image" src="https://pmu.edu/images/whatsapp.svg"></a>
        </div>
       
        <!--<div id="ac-wrapper" style='display:none'>
            <div id="popup">
                <div>
                    <a href="https://pmu.edu/admission/RegistrationNew.aspx" target="_blank">
                        <img src="./images/admission_poster.jpg" class="w-100" />
                    </a>
                </div>
                <div class="bannerClose" onClick="PopUp('hide')">
                    <img src="./images/cancel-banner.png" />
                </div>
            </div>
        </div>-->
        <script>
//            function PopUp(hideOrshow) {
//                if (hideOrshow == 'hide') {
//                    document.getElementById('ac-wrapper').style.display = "none";
//
//                    sessionStorage.setItem('popState', 'shown');
//                }
//                else {
//                    document.getElementById('ac-wrapper').removeAttribute('style');
//                }
//            }
//window.onload = function () {
//
//                setTimeout(function () {
//                    if (sessionStorage.getItem('popState') != 'shown') {
//                        PopUp('show');
//                    }
//                }, 1000);
//            }
//
//            $(function () {
//                if (localStorage.getItem('popState') != 'shown') {
//                    $("#ac-wrapper").fadeIn();
//                }
//
//                $('#popup-close').click(function (e) {
//                    $('#ac-wrapper').fadeOut();
//
//                });
//            });
        </script>
        <!-- End of Footer  -->
         <div class="enquire" data-toggle="modal" data-target="#exampleModalCenter">
            <a class="cursor-pointer whiteColor">
                <div>APPLY NOW</div>
            </a>
        </div> 
        <uc:admission id="admission" runat="server" />
    </form>

    <!-- Script  -->
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="js/swiper.min.js"></script>
    <script type="text/javascript" src="js/popper.js"></script>
    <script type="text/javascript" src="https://cdn.jsdelivr.net/npm/pushbar.js@1.0.0/src/pushbar.min.js"></script>

    
    <script type="text/javascript" src="js/owl.carousel.min.js"></script>

    <script type="text/javascript" src="js/splide.min.js"></script>


    <!-- <script src="https://code.jquery.com/jquery-3.1.1.slim.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script> -->
        <script src="https://cdn.rawgit.com/JacobLett/bootstrap4-latest/master/bootstrap-4-latest.min.js"></script>
    
    <script>
$(document).scroll(function () {
    var y = $(this).scrollTop();
    if (y > 400) {
        $('#chat-bot-launcher-container').fadeIn();
    } else {
        $('#chat-bot-launcher-container').fadeOut();
    }

});

// $( document ).ready(function() {
//         $('.swiper-wrapper .bannerImage:nth-child(2)').addClass("bannerload");
//         $('.swiper-wrapper .bannerImage:nth-child(7)').addClass("bannerload");
//     });

// $(document).ready( function() {

// var c = new Image();

// c.onload = function(){
//     $(".bannerload").css("background-image", "url(https://pmu.edu/images/homepage/home-banner-3.png)");  
// }

// c.src = "https://pmu.edu/images/homepage/home-banner-3.png";

// });




// $(document).scroll(function () {
//     var y = $(this).scrollTop();
//     if (y > 400) {
//         $('.navbar-toggler').addClass('dBlockClass');
//         $('.navbar-collapse').addClass('dNone');
//         $('.logoBg .logo').addClass('logoScroll');
//         $('.navbar-expand-lg').addClass('bg-white');
//         $('.logoBg').addClass('logoBgScroll');
//         $('.admin__btn').css('display', 'block');
//     } else {
//         $('.navbar-toggler').removeClass('dBlockClass');
//         $('.navbar-collapse').removeClass('dNone');
//         $('.logoBg .logo').removeClass('logoScroll');
//         $('.navbar-expand-lg').removeClass('bg-white');
//         $('.logoBg').removeClass('logoBgScroll');
//         $('.admin__btn').css('display', 'none');
//     }

// });


$(document).scroll(function () {
    var y = $(this).scrollTop();
    if (y > 100) {
        $('.navbar-toggler').addClass('dBlockClass');
        $('.navbar-collapse').addClass('dNone');
        $('.logoBg .logoScl').addClass('logoScroll');
        $('.navbar-expand-lg').addClass('bg-white');
        $('.logoBg').addClass('logoBgScroll');
        $('.admin__btn').css('display', 'block');
        $('.registration__new-sticky').hide();
        $('.logoBg .logoScl').show();
        $('.logoBg .logodef').hide();
        $('.logoBg').removeClass('addBg');
        $('.chat-sticky').show();
    } else {
        $('.navbar-toggler').removeClass('dBlockClass');
        $('.navbar-collapse').removeClass('dNone');
        $('.logoBg .logo').removeClass('logoScroll');
        $('.navbar-expand-lg').removeClass('bg-white');
        $('.logoBg').removeClass('logoBgScroll');
        $('.admin__btn').css('display', 'none');
        $('.registration__new-sticky').show();
        $('.logoBg .logoScl').hide();
        $('.logoBg .logodef').show();
        $('.logoBg').addClass('addBg');
        $('.chat-sticky').hide();
    }

});

    $(document).ready(function () {
        $("#spec").click(function () {
            $(".content-1").css("display", "block");
            $(".content-2").css("display", "none");
        });
        $("#newcourses").click(function () {
            $(".content-2").css("display", "block");
            $(".content-1").css("display", "none");
        });
    });
    </script>

<script>
    $(document).ready(function() {

        // Gets the video src from the data-src on each button

        var $videoSrc;  
        $('.video-btn').click(function() {
            $videoSrc = $(this).data( "src" );
        });
        console.log($videoSrc);

        
        
        // when the modal is opened autoplay it  
        $('#myModal').on('shown.bs.modal', function (e) {
            
        // set the video src to autoplay and not to show related video. Youtube related video is like a box of chocolates... you never know what you're gonna get
        $("#video").attr('src',$videoSrc + "?autoplay=1&amp;modestbranding=1&amp;showinfo=0" ); 
        })
        


        // stop playing the youtube video when I close the modal
        $('#myModal').on('hide.bs.modal', function (e) {
            // a poor man's stop video
            $("#video").attr('src',$videoSrc); 
        }) 
    
    // document ready  
    });
</script>
    <script>
        var tabs = $('.recruiterstabs');
            var selector = $('.recruiterstabs').find('a').length;
            //var selector = $(".tabs").find(".selector");
            var activeItem = tabs.find('.active');
            var activeWidth = activeItem.innerWidth();
            $(".selector").css({
            "left": activeItem.position.left + "px", 
            "width": activeWidth + "px"
            });

            $(".recruiterstabs").on("click","a",function(e){
            e.preventDefault();
            $('.recruiterstabs a').removeClass("active");
            $(this).addClass('active');
            var activeWidth = $(this).innerWidth();
            var itemPos = $(this).position();
            $(".selector").css({
                "left":itemPos.left + "px", 
                "width": activeWidth + "px"
            });
        });

        $(document).ready(function() {
            $('.top-recruiters-tab').click(function() {
                $('.top-recruiters-tab').addClass('active');
                $('.affiliation-tab').removeClass('active');
                $('#top-recruiters').fadeIn(1000);
                $('#affiliation').fadeOut(0);
            });
            $('.affiliation-tab').click(function() {
                $('.affiliation-tab').addClass('active');
                $('.top-recruiters-tab').removeClass('active');
                $('#top-recruiters').fadeOut(0);
                $('#affiliation').fadeIn(1000);
            });

            
            
            $("#owl-demo2").owlCarousel({
            
                autoPlay: 3000,
                pagination : false,
                items : 6,
                slideByitems: 6,
                slideBy: 6,
                autoplayTimeout: 5000,
                smartSpeed: 600,
                loop: true,
                navigation: false,
                itemsDesktop : [1199,3],
                itemsDesktopSmall : [979,3]
            
            });
        });
    </script>
    <script>
        var swiper = new Swiper('.homeSlider', {
            slidesPerView: 1,
            // effect: 'coverflow',
            autoplay: {
                delay: 8000,
                disableOnInteraction: false,
            },
            observeParents: true,
            observer: true,
            pagination: {
                el: '.swiper-pagination',
                clickable: true,
            },
            speed: 1000,
            loop: true,
        });
    </script>
    <script>
        var swiper = new Swiper('.newsSlider', {
            // slidesPerView:1,
            // spaceBetween: 15,
            // fadeEffect: {
            //     crossFade: true
            // },
            // centeredSlides: true,
            // observeParents: true,
            //     autoplay: {
            //             delay: 4000,
            //             disableOnInteraction: false,
            //         },
            slidesPerView: 1,
            fadeEffect: {
                crossFade: true
            },
            effect: 'fade',
            loop: true,
            autoplay: {
                delay: 5000,
                disableOnInteraction: false,
            },

        });
    </script>
    <script>
        var swiper = new Swiper('.eventsSlider', {
            slidesPerView: 3,
            spaceBetween: 25,
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
            slidesPerGroup: 3,
            // autoplay: {
            //     delay: 4000,
            //     disableOnInteraction: false,
            // },
            pagination: {
                el: '.swiper-pagination',
                clickable: true,
                renderBullet: function (index, className) {
                    return '<span class="' + className + '">' + (index + 1) + '</span>';
                },
            },
            breakpoints: {
                640: {
                    slidesPerView: 1,
                    spaceBetween: 5,
                    centeredSlides: true,
                    slidesPerGroup: 1,
                    observer: true,
                    observeParents: true,
                },
                768: {
                    slidesPerView: 2,
                    spaceBetween: 40,
                    slidesPerGroup: 2,
                    observer: true,
                    observeParents: true,
                },
                1024: {
                    slidesPerView: 2,
                    spaceBetween: 50,
                    slidesPerGroup: 2,
                },
                1400: {
                    slidesPerView: 3,
                    spaceBetween: 50,
                    slidesPerGroup: 3,
                },
            },
        }); 
    </script>
    <script>
        var swiper = new Swiper('.professional-bodiesSlider', {
            slidesPerView: 6,
            speed: 2000,
            spaceBetween: 40,
            slidesPerGroup: 6,
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
        var swiper = new Swiper('.recruiterSlider', {
            slidesPerView: 6,
            speed: 2000,
            spaceBetween: 40,
            slidesPerGroup: 6,
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
        var acc = document.getElementsByClassName("accordion1");
        var i;

        for (i = 0; i < acc.length; i++) {
            acc[i].addEventListener("click", function () {
                this.classList.toggle("active");
                var panel = this.nextElementSibling;
                if (panel.style.maxHeight) {
                    panel.style.maxHeight = null;
                } else {
                    panel.style.maxHeight = "inherit";
                }
            });
        }
    </script>
    <script>
        var acc = document.getElementsByClassName("accordion5");
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

        $('.tablinkOne1').on("click",function(){
            $('.tablinkOne1').addClass('activeEventOne'); 
            $('.tablinkOne2').removeClass('activeEventOne'); 
            $('.tablinkOne3').removeClass('activeEventOne'); 
            $('.tablinkOne4').removeClass('activeEventOne'); 
            $('.tablinkOne5').removeClass('activeEventOne'); 
            
            $('.tablinkOne1-img').css('display', 'block');
            $('.tablinkOne2-img').css('display', 'none');
            $('.tablinkOne3-img').css('display', 'none');
            $('.tablinkOne4-img').css('display', 'none');
            $('.tablinkOne5-img').css('display', 'none');
            $('.tablinkOne-img').css('display', 'none');
        });
        $('.tablinkOne2').on("click",function(){
            $('.tablinkOne2').addClass('activeEventOne'); 
            $('.tablinkOne3').removeClass('activeEventOne'); 
            $('.tablinkOne4').removeClass('activeEventOne'); 
            $('.tablinkOne5').removeClass('activeEventOne'); 
            $('.tablinkOne1').removeClass('activeEventOne'); 

            $('.tablinkOne2-img').css('display', 'block');
            $('.tablinkOne1-img').css('display', 'none');
            $('.tablinkOne3-img').css('display', 'none');
            $('.tablinkOne4-img').css('display', 'none');
            $('.tablinkOne5-img').css('display', 'none');
            $('.tablinkOne-img').css('display', 'none');
        });
        $('.tablinkOne3').on("click",function(){
            $('.tablinkOne3').addClass('activeEventOne'); 
            $('.tablinkOne2').removeClass('activeEventOne'); 
            $('.tablinkOne4').removeClass('activeEventOne'); 
            $('.tablinkOne5').removeClass('activeEventOne'); 
            $('.tablinkOne1').removeClass('activeEventOne'); 

            $('.tablinkOne3-img').css('display', 'block');
            $('.tablinkOne2-img').css('display', 'none');
            $('.tablinkOne1-img').css('display', 'none');
            $('.tablinkOne4-img').css('display', 'none');
            $('.tablinkOne5-img').css('display', 'none');
            $('.tablinkOne-img').css('display', 'none');
        });
        $('.tablinkOne4').on("click",function(){
            $('.tablinkOne4').addClass('activeEventOne'); 
            $('.tablinkOne1').removeClass('activeEventOne'); 
            $('.tablinkOne2').removeClass('activeEventOne'); 
            $('.tablinkOne3').removeClass('activeEventOne'); 
            $('.tablinkOne5').removeClass('activeEventOne'); 

            $('.tablinkOne4-img').css('display', 'block');
            $('.tablinkOne2-img').css('display', 'none');
            $('.tablinkOne3-img').css('display', 'none');
            $('.tablinkOne1-img').css('display', 'none');
            $('.tablinkOne5-img').css('display', 'none');
            $('.tablinkOne-img').css('display', 'none');
        });
        $('.tablinkOne5').on("click",function(){
            $('.tablinkOne5').addClass('activeEventOne'); 
            $('.tablinkOne1').removeClass('activeEventOne'); 
            $('.tablinkOne2').removeClass('activeEventOne'); 
            $('.tablinkOne3').removeClass('activeEventOne'); 
            $('.tablinkOne4').removeClass('activeEventOne'); 

            $('.tablinkOne5-img').css('display', 'block');
            $('.tablinkOne2-img').css('display', 'none');
            $('.tablinkOne3-img').css('display', 'none');
            $('.tablinkOne4-img').css('display', 'none');
            $('.tablinkOne1-img').css('display', 'none');
            $('.tablinkOne-img').css('display', 'none');
        });
        $('.tablinkOne').on("click",function(){
            $('.campus-highlights-cnt').css('display', 'none'); 
        });
        
        
    </script>

    <script>

        $(document).ready(function () {

            $("#menutoggle").hover(function () {
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
            });$(".downadmission").hover(function () {
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
            $(".downMore").hover(function () {
                $('.moreMenu').addClass('display-on');
            });
            $(".downMore").mouseleave(function () {
                $('.moreMenu').removeClass('display-on');
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

        var animSpeed = 50;
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
        $('a.multiLink').click(function (e) {
            e.preventDefault();
            window.open('https://pmu.edu/images/CISTA_2K20.jpg');
            window.open('https://pmu.edu/images/Invitation_ CISTA_2K20.jpg');
        });
    </script>
</body>

</html>