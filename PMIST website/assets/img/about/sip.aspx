<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentsatisfaction.aspx.cs" Inherits="_aqar" %>
<%@ Register Src="~/includes/headernew.ascx" TagPrefix="uc1" TagName="headernew" %>
<%@ Register Src="~/includes/footernew.ascx" TagPrefix="uc2" TagName="footernew" %>
    <%@ Register src="~/includes/UCAdmission.ascx" tagname="admission" tagprefix="uc" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0 user-scalable=0" />
    <title>Internal Quality Assessment Cell | Periyar Maniammai Institute of Science & Technology</title>
    <meta name="description"
        content="Periyar Maniammai Institute of Science & Technology is proud to be a unique institution of higher learning and academic excellence. The University aims to deliver oustanding education to its students" />
    <!-- Style sheets -->
    <link rel="stylesheet" type="text/css" href="../css/style.css" />
    <link rel="stylesheet" type="text/css" href="../css/style-1.css" />
    <link rel="stylesheet" type="text/css" href="../css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="../css/font-awesome.css" />
    <link rel="stylesheet" type="text/css" href="../css/swiper.min.css" />
    <link rel="stylesheet" type="text/css" href="css/custom.css" />
    <link rel="icon" type="image/x-icon" href="..//images/fav-icon.png" />
    <link href="https://use.fontawesome.com/5ecf78f4a4.css" media="all" rel="stylesheet" />
    <script type="text/javascript" src="https://use.fontawesome.com/5ecf78f4a4.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"
        integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"
        crossorigin="anonymous"></script>
    <link rel="stylesheet" type="text/css" href="https://cdn.jsdelivr.net/npm/pushbar.js@1.0.0/src/pushbar.min.css" />
   <!-- Google Tag Manager -->
   <!-- Global site tag (gtag.js) - Google Analytics -->
<script async src="https://www.googletagmanager.com/gtag/js?id=UA-173526007-1"></script>
<script>
  window.dataLayer = window.dataLayer || [];
  function gtag(){dataLayer.push(arguments);}
  gtag('js', new Date());

  gtag('config', 'UA-173526007-1');
</script>
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
    fbq('init', '731880944025301');
    fbq('track', 'PageView');
  </script>
  <noscript><img height="1" width="1" style="display:none"
    src="https://www.facebook.com/tr?id=731880944025301&ev=PageView&noscript=1"
  /></noscript>
  <!-- End Facebook Pixel Code -->
</head>
<body>
   
    <form id="form1" runat="server">        
        <asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>
        <!-- Header  -->
         <uc1:headernew runat="server" ID="headernew" />

        <!-- End of Header  -->

        <!-- Main Section  -->

        <!-- Banner  -->
        <div class="homeBanner positionRelative margin-5">
            <div class="swiper-container homeSlider">
                <div class="swiper-wrapper">
                    <div class="swiper-slide bannerImage d-flex align-items-end"
                        style="background: url('../images/homepage/slider3.jpg');">
                        <div class="centreGradient">
                            <h5 class="m-0 paddingLeft55">IQAC </h5>
                        </div>
                    </div>

                </div>


            </div>
        </div>

        <!-- End of Banner  -->


        <div class="py-5">
            <div class="row  container-fluid">
                <div class="col-lg-9 col-sm-12 col-md-12 col-xs-12 ">
                    <div class="profileSection py-4 libraryBorder container-fluid">
                        <div>
                            <div class="d-flex">
                                <h3 class="blueColor Oswald OswaldR upperCase pr-3">PMIST ANNUAL REPORT</h3>
                                <div class="headingAfter"></div>
                            </div>
                        </div>
                      
                         <div>
                            <div class="mt-4 acc-style">
                                <!-- <a href="#acc1" class="accordion w-100 d-block" data-toggle="collapse">Student Satisfaction Survey</a> -->
                                <!-- <div id="acc1" class="collapse px-3" style="max-height: unset;"> -->
                                    <div class="d-flex pt-2 align-items-center">
                                        <div class="mr-3">
                                            <img src="../images/file.svg">
                                        </div>
                                        <div>
                                           <a href="pdf/studentsatisfactionsurvey.pdf" class="blackColor textdecorationNone" target="_blank">Student Satisfaction Survey</a>
                                        </div>
                                    </div>
                                <!-- </div> -->
                            </div>
    
                            <!-- <div class="mt-4 acc-style">
                                <a href="#acc2" class="accordion w-100 d-block" data-toggle="collapse">Title 2</a>
                                <div id="acc2" class="collapse px-3" style="max-height: unset;">
                                    <div class="d-flex pt-2 align-items-center">
                                        <div class="mr-3">
                                            <img src="../images/file.svg">
                                        </div>
                                        <div>
                                           <a href="#" class="blackColor textdecorationNone" target="_blank">PDF 1</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
    
                            <div class="mt-4 acc-style">
                                <a href="#acc3" class="accordion w-100 d-block" data-toggle="collapse">Title 3</a>
                                <div id="acc3" class="collapse px-3" style="max-height: unset;">
                                    <div class="d-flex pt-2 align-items-center">
                                        <div class="mr-3">
                                            <img src="../images/file.svg">
                                        </div>
                                        <div>
                                           <a href="#" class="blackColor textdecorationNone" target="_blank">PDF 1</a>
                                        </div>
                                    </div>
                                </div>
                            </div> -->
                        </div> 
                    </div>

                </div>
                <div class="col-lg-3 col-sm-12 col-md-12 col-xs-12 stickyMenu">
                    <div>
                        <div class="px-2 py-2 sideMenu">
                            <div class="p-3 sideMenuBottomBorder">
                                <a href="default.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                   Home</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a  href="about.aspx" class="textdecorationNone  sideMenuHover d-flex ">
                                    About</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="co-ordinators.aspx" class="textdecorationNone  sideMenuHover  d-flex ">
                                    Co-ordinators</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="members.aspx" class="textdecorationNone   sideMenuHover  d-flex ">
                                    Members</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="meetings.aspx" class="textdecorationNone  sideMenuHover  d-flex ">
                                    Meetings</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="contact.aspx" class="textdecorationNone  sideMenuHover  d-flex ">
                                    Contact</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="reports.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                    Reports</a>
                            </div>
                            <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2"> 
                                <a  href="events.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block  ">
                                    Events</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="gallery.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                    Gallery</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="nirf.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                    NIRF</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="naac.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                    NAAC </a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="aqar.aspx" class="textdecorationNone  sideMenuHover d-flex ">
                                    AQAR </a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="policies-procedures.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                    Policies & Procedures</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="feedback-on-curricular-aspects.aspx" class="textdecorationNone  sideMenuHover  d-flex ">Feedback on Curricular Aspects</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="pmistannualrep.aspx" class="textdecorationNone activeSideMenu sideMenuHover d-flex ">
                                    PMIST Annual Report</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a  href="audited-statement.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                    Audited Statement</a>
                            </div>
                            
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="initiatives.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                    Initiatives</a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="staff-appraisal.aspx" class="textdecorationNone  sideMenuHover d-flex ">
                                    Staff Appraisal  </a>
                            </div>
                            <div class="p-3 pt-4 sideMenuBottomBorder">
                                <a href="Institutional-Distinctiveness.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                    Institutional Distinctiveness </a>
                            </div>
                            <div class="p-3 pt-4">
                                <a  href="Best-Practices.aspx" class="textdecorationNone sideMenuHover d-flex ">
                                    Best Practices</a>
                            </div>
                        </div>
                    </div>
                </div>



            </div>


        </div>






        <!-- End of Main Section  -->



        <!-- Footer  -->

        <uc2:footernew runat="server" ID="footernew" />

        <!-- End of footer  -->
        <uc:admission runat="server" ID="admission" />

        <div class="enquire" data-toggle="modal" data-target="#exampleModalCenter">
            <a class="cursor-pointer whiteColor">
                <div>Apply Now</div>
            </a>
        </div>
        <div class="whatsappIcon">
            <a href="https://wa.me/919790111911" class="whatsapp whiteColor" target="_blank"> <i
                    class="fa fa-whatsapp whatsapp-icon"></i></a>
        </div>


        <!-- Scripts  -->
        <script type="text/javascript" src="../js/bootstrap.min.js"></script>
        <script type="text/javascript" src="../js/jquery-3.4.1.min.js"></script>
        <script type="text/javascript" src="../js/swiper.min.js"></script>
        <script type="text/javascript" src="https://cdn.jsdelivr.net/npm/pushbar.js@1.0.0/src/pushbar.min.js"></script>

        <!-- Script for header menu  -->
        <script>
            $('#accordion-button-1').click(function(e) {
                e.preventDefault();
                return false;
            });
            const items = document.querySelectorAll(".accordion button");

            function toggleAccordion() {
            const itemToggle = this.getAttribute('aria-expanded');
            
            for (i = 0; i < items.length; i++) {
                items[i].setAttribute('aria-expanded', 'false');
            }
            
            if (itemToggle == 'false') {
                this.setAttribute('aria-expanded', 'true');
            }
            }
            items.forEach(item => item.addEventListener('click', toggleAccordion));

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
                $(".downMore").hover(function () {
                    $('.moreMenu').addClass('display-on');
                });
                $(".downMore").mouseleave(function () {
                    $('.moreMenu').removeClass('display-on');
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
    </form>
</body>
</html>
