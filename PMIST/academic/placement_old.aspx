<%@ Page Language="C#" AutoEventWireup="true" CodeFile="placement_old.aspx.cs" Inherits="academic_placementold" %>
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
 <link href="../assets/css/academic/placement.css" rel="stylesheet">
 <link href="../assets/css/academic/new-sub-menu.css" rel="stylesheet">
 <style>
    /* .sub-menu {
      background: linear-gradient(104deg, #2F4088 0.77%, #181B61 50.61%, #2F4088 101.67%);
    } */
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
    <img src="../assets/img/academic/banner-images/Faculty-banner.jpg" class="img-fluid">
    <div class="custom-container">
      <div class="banner-heading">
        <h4 class="m-0">Department of computer science</h4>
        <h1 class="m-0">Placement</h1>
      </div>
    </div>
  </section>
  <!-- banner section End  -->

  <!-- sub-menu section start  -->
  <UCDepartmentSubmenu:UCDepartmentSubmenu id="UCDepartmentSubmenu" runat="server"/>
  <!-- sub-menu section End  -->

  <section class="">
    <div class="custom-container">
      <h1 class="placement-heading m-0">Placement</h1>
      <p class="placement-content pb-4">Department faculties, Throughout the year, encouraging students in various aspects regarding to get placed in various on-campus companies as well as Off-campus companies. Arranging Industrial visit and In-plant Training program for students to improve their knowledge about the software companies environment and current software trends. Arranging on and off campus recruitments. Compulsory In-Plant Training in Industries for III year respectively assigning due credits.</p>
    </div>
  </section>

  <section class="recruiter-section">
    <div class="custom-container">
      <div class="row justify-content-between align-items-center">
        <div class="col-lg-3 col-12">
          <h1 class="recruiter-heading">Our Top Recruiters </h1>
          <p class="recruiter-para">Prestigious Industry Partners Shaping Our Students' Futures</p>
        </div>

        <div class="col-lg-8 col-12">
          <div id="demo" class="carousel slide" data-bs-ride="carousel">

            <!-- Indicators/dots -->
            <div class="carousel-indicators">
              <button type="button" data-bs-target="#demo" data-bs-slide-to="0" class="active"></button>
              <button type="button" data-bs-target="#demo" data-bs-slide-to="1"></button>
              <button type="button" data-bs-target="#demo" data-bs-slide-to="2"></button>
            </div>
          
            <!-- The slideshow/carousel -->
            <div class="carousel-inner">
              <div class="carousel-item active">
                <div class="row ">
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4 ">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/14.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/19.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/26.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/12.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/11.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/16.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/13.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/18.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/17.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/25.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/2.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/5.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/3.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/6.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/22.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/21.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/4.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/10.png');">
                    </div>
                  </div>
                </div>
              </div>
              <div class="carousel-item">
                <div class="row ">
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4 ">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/14.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/19.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/26.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/12.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/11.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/16.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/13.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/18.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/17.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/25.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/2.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/5.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/3.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/6.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/22.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/21.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/4.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/10.png');">
                    </div>
                  </div>
                </div>
              </div>
              <div class="carousel-item">
                <div class="row ">
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4 ">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/14.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/19.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/26.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/12.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/11.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/16.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/13.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/18.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/17.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/25.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/2.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/5.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/3.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/6.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/22.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/21.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/4.png');">
                    </div>
                  </div>
      
                  <div class="col-lg-2 col-md-3 col-sm-4 col-4 col-sm-4">
                    <div class="swiper-slide recruiterImages"
                                style="background:url('../assets/img/academic/rec/10.png');">
                    </div>
                  </div>
                </div>
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
    
  </script>
  </form>
</body>
</html>