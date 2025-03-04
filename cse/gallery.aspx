<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="department_of_architecture_new_gallery" %>
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
    <link rel="stylesheet" type="text/css" href="https://pmu.edu/gallery/lightbox/lightbox.css" />
    <link rel="shortcut icon" href="../../images/favicon.png" />
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



    <div class="navigationSection  placementBg">
        <div class="swiper-container menuSwiper py-3">
            <div class="placementBorderBottom swiper-wrapper ">
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="default.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block  ">
                        Home
                    </a>
                </div>
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2 ">
                    <a  href="about.aspx" class="blackColor textdecorationNone  sideMenuHover pb-1  d-block  ">
                        About
                    </a>
                </div>
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="courses.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Programs
                    </a>
                </div>

                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="faculty.aspx" class="blackColor textdecorationNone  sideMenuHover pb-1  d-block ">
                        Faculty
                    </a>
                </div>


                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="infrastructure.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Infrastructure
                    </a>
                </div>
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="activities.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Activities
                    </a>
                </div>
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2 ">
                    <a href="events.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block  ">
                        Events
                    </a>
                </div>
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2 activeBorderBottom">
                    <a href="gallery.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Gallery
                    </a>
                </div>
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="placement.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        Placement
                    </a>
                </div>
                <div class="px-3 py-1 placementBorder swiper-slide widthAuto pb-2">
                    <a href="accolades.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
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
                    <a target="_blank" href="https://www.pmu.edu/placement/collabrations.aspx"
                        class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
                        MoU / Collaborations
                    </a>
                </div>
                <div class="px-3 py-1  pb-2 placementBorder swiper-slide widthAuto">
                    <a href="alumni-corner.aspx" class="blackColor textdecorationNone sideMenuHover  pb-1  d-block ">
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

    <div class="container-fluid whiteColor mt-3 z-index">

        <div class="d-flex justify-content-center mb-3 align-items-center">
            <div class="headingAfter mt-1 mr-3"></div>
            <h3 class="upperCase blueColor py-2 m-0  ">Gallery </h3>
            <div class="headingAfter mt-1 ml-3"></div>

        </div>
        <div class="d-flex justify-content-center pt-3">
            <div class="d-flex align-items-center">
                <button class="tablink eventsButton mr-3 activeEvent d-flex" onclick="openTab(event,'photo')">
                    <div class="">
                        <h5 class="OswaldR Oswald upperCase">Photos</h5>
                    </div>
                </button>
                <h3 class="mb-0 blackColor marginT-5">
                    |
                </h3>
                <button class=" tablink eventsButton ml-3" onclick="openTab(event,'video');return false;">
                    <div class="">
                        <h5 class="OswaldR Oswald upperCase">Videos</h5>
                    </div>
                </button>
            </div>
        </div>

    </div>


 
    <div id="photo" class="city faceEffect">
        <div class="container-fluid">
              <div id="dvGallery" runat="server" style="display:block">
            <h2>Coming Soon!</h2>
            </div>
            <div class="pt-3" id="dvGallery1" runat="server" style="display:none">
                <div class="row mx-0">
                    <asp:Repeater ID="rprTopAlbums" runat="server" OnItemDataBound="OnItemDataBound">
                        <ItemTemplate>
                            <asp:HiddenField ID="hdnAlbumId" runat="server" Value='<%#Eval("AlbumId")%>' />
                            <ul class="liststyleNone col-lg-4 col-md-4 col-sm-4 col-xs-12 my-3 lightgallery">
                                 <asp:Repeater ID="rprTopGallery" runat="server">
                        <ItemTemplate>
                    <li data-src="<%# bindImageUrl(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "GalleryImage")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "AlbumName")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "Department")))%>" data-sub-html="<h5> <%#Eval("AlbumName")%></h5>"
                        class="demogallery <%# bindCSS(System.Convert.ToInt32(Container.ItemIndex))%>">
                        <a href="" class="blackColor textdecorationNone ">
                            <div>
                                <div class="galleryBoxShadow">
                                    <div class="p-2">
                                        <img src="<%# bindImageUrl(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "GalleryImage")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "AlbumName")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "Department")))%>"
                                            class="w-100" />
                                        <div class="demo-gallery-poster">
                                            <img
                                                src="https://pmu.edu/gallery/img/zoom.png">
                                        </div>
                                       
                                    </div>
                                </div>
                                <div class="pt-3 f-14 pl-1">
                                    <%#Eval("AlbumName")%>
                                </div>
                            </div>
                        </a>
                    </li>
                     </ItemTemplate>
                     </asp:Repeater>
               
                   </ul>
                        </ItemTemplate>
                    </asp:Repeater>
                
                   

            </div>

               <div class="my-5 container-fluid">
                    <h5 class="text-center mb-0 overFlowHidden">
                        <span class="orangeColor upperCase Oswald OswaldR positionRelative moreAlbums">More Albums</span>
                    </h5>
                </div>
                 <input type="hidden" class="current_page" />
                                    <input type="hidden" class="show_per_page" />
                                    <input type='hidden' id='show_per_page' />
                 <div  id="resultsContentWrapOne">
                <asp:Repeater ID="rprMoreAlbums" runat="server"  OnItemDataBound="OnItemDataBound1">
                    <ItemTemplate>
                       <%--<div class="listData">--%>
                         <asp:HiddenField ID="hdnMoreAlbumId" runat="server" Value='<%#Eval("AlbumId")%>' />
                        <%# bindopndiv1(System.Convert.ToInt32(Container.ItemIndex))%>
                        <%# bindopndiv(System.Convert.ToInt32(Container.ItemIndex))%>
                
                    <ul class="liststyleNone col-lg-3 col-md-3 col-sm-3 col-xs-12 my-3 lightgallery" id="">
                           <asp:Repeater ID="rprMoreGallery" runat="server">
                        <ItemTemplate>
                        <li data-src="<%# bindImageUrl(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "GalleryImage")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "AlbumName")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "Department")))%>" data-sub-html="<h5><%#Eval("AlbumName")%></h5>"
                            class="demogallery <%# bindCSS(System.Convert.ToInt32(Container.ItemIndex))%>">
                            <a href="" class="blackColor textdecorationNone ">
                                <div>
                                    <div class="galleryBoxShadow">
                                        <div class="p-2">
                                            <img src="<%# bindImageUrl(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "GalleryImage")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "AlbumName")),System.Convert.ToString(DataBinder.Eval(Container.DataItem, "Department")))%>"
                                                class="w-100" />
                                            <div class="demo-gallery-poster">
                                                <img
                                                    src="https://pmu.edu/gallery/img/zoom.png">
                                            </div>
                                           
                                        </div>
                                    </div>
                                    <div class="pt-3 f-14 pl-1">
                                         <%#Eval("AlbumName")%>
                                    </div>
                                </div>
                            </a>
                        </li>
                            </ItemTemplate>
                     </asp:Repeater>
                       </ul>
                       
      <%# bindclosediv1(System.Convert.ToInt32(Container.ItemIndex))%>
                <%# bindclosediv(System.Convert.ToInt32(Container.ItemIndex))%>

               <%--</div>--%>
                        </ItemTemplate>
                </asp:Repeater>
                                    </div>
                <nav class="d-flex justify-content-center mt-4 mb-5">
                     <div class="pagination" id="page_navigation"> 
                         </div>
                  </nav>

            </div>
        </div>
    </div>
    <div id="video" class="city faceEffect" style="display: none;">
        <div class="container-fluid"> 
            <input type="hidden" class="current_page1" />
                                    <input type="hidden" class="show_per_page1" />
                                    <input type='hidden' id='show_per_page1' />
                 <div  id="resultsContentWrapOne1">
            <asp:Repeater ID="rprVideo" runat="server">
                    <ItemTemplate>
                           <%# bindvideopndiv1(System.Convert.ToInt32(Container.ItemIndex))%>
                        <%# bindvideoopndiv(System.Convert.ToInt32(Container.ItemIndex))%>
         
                <ul class="col-lg-4 col-md-4 col-sm-4 col-xs-12 my-3 mx-0 liststyleNone lightgallery">
                    <li data-src=" <%#Eval("VideoUrl")%>"
                        class="demogallery ">
                        <a href="" class="blackColor textdecorationNone ">
                            <div>
                                <div class="galleryBoxShadow">
                                    <div class="p-2">
                                        <img src="<%# bindVideoImageUrl(System.Convert.ToString(DataBinder.Eval(Container.DataItem, "VdeoThumbImage")))%>"
                                            class="w-100" />
                                        <div class="galleryPlay">
                                            <img
                                                src="./img/play.png">
                                        </div>
                                    </div>
                                </div>
                                <div class="pt-3 f-14 pl-1">
                                      <%#Eval("VideoTitle")%>
                                </div>
                            </div>
                        </a>
                    </li>
                    
                    </ul>               
      <%# bindvideoclosediv1(System.Convert.ToInt32(Container.ItemIndex))%>
                <%# bindvideoclosediv(System.Convert.ToInt32(Container.ItemIndex))%>
                        </ItemTemplate>
                </asp:Repeater>
                     </div>
            <nav class="d-flex justify-content-center mt-4 mb-5">
                <div class="pagination" id="vpage_navigation"> 
                         </div>
              </nav>
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

<script type="text/javascript" src="https://pmu.edu/gallery/lightbox/lightgallery.js"></script>
<script type="text/javascript" src="https://pmu.edu/gallery/lightbox/mousewheel.js"></script>
<script type="text/javascript" src="https://pmu.edu/gallery/lightbox/picmain.js"></script>

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
    $(document).ready(function () {
         $('.lightgallery').lightGallery({
            pager: true,
            fullscreen:false,
            zoom:false,
        });
        $('#lightgallery').lightGallery({
            pager: true,
            fullscreen:false,
            zoom:false,
        });
        $('#lightgallery1').lightGallery({
            pager: true,
            fullscreen:false,
            zoom:false,
        });
        $('#lightgallery2').lightGallery({
            pager: true,
        });
        $('#lightgallery1').lightGallery({
            pager: true,
        });
        $('#lightgallery5').lightGallery({
            pager: true,
        });
        $('#lightgallery6').lightGallery({
            pager: true,
        });
        $('#lightgallery7').lightGallery({
            pager: true,
        });
        $('#lightgallery8').lightGallery({
            pager: true,
        });
        $('#lightgallery9').lightGallery({
            pager: true,
        });
        $('#lightgallery10').lightGallery({
            pager: true,
        });
        $('#lightgallery11').lightGallery({
            pager: true,
        });
        $('#lightgallery12').lightGallery({
            pager: true,
        });
        $('#lightgallery13').lightGallery({
            pager: true,
        });
        $('#lightgallery14').lightGallery({
            pager: true,
        });
        $('#lightgallery15').lightGallery({
            pager: true,
            fullscreen:false,
            zoom:false,
            
        });
    });</script>




<script>
function openTab(evt, cityName) {
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
    var swiper = new Swiper('.menuSwiper', {
        slidesPerView: 'auto',
        initialSlide:5,
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },
    });
</script>
      <script type="text/javascript" src="../js/GalleryPagination.js"></script>  
   <script type="text/javascript" src="../js/VideoPagination.js"></script>
    <script>

        $(document).ready(function () {
            paginateit('#resultsContentWrapOne');
            paginateit('#resultsContentWrapOne1');
         });
</script>
</html>
