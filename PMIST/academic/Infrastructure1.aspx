<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Infrastructure1.aspx.cs" Inherits="academic_infrastructure1" %>
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
      <div class="">
        <h1 class="infrastructure-heading m-0">Cutting-edge laboratories & facilities</h1>
        <p class="infrastructure-content pb-4">The department has spacious laboratories with the state-of-the-art machiner and equipments including Computerized 100T UTM, Automized Compression Testing Machine, Non Destructive Testing Equipments, Pipe Testing Equipment, Advanced Soil Test Equipments, Total Survey Station.</p>
      </div>

      <div class="">
        <h1 class="infrastructure-heading m-0">Strength of Materials Laboratory</h1>
        <p class="infrastructure-content pb-4">Strength of materials laboratory is well equipped with destructive testing machineries. This lab course is offered for Civil and Mechanical Engineering. The laboratory may enable them to apply the theoretical concepts of strength of Materials course. Various tests are being performed in this laboratory to know the mechanical properties of a material such as young’s modulus, shear modulus, hardness, toughness, deflection, fatigue strength etc. A Unique feature of this lab is with “Universal Testing Machine (UTM)” having capacity of 100 T and 40 T to test the steel material.</p>
      </div>

      <div class="">
        <h1 class="infrastructure-heading m-0">Environmental Engineering Laboratory</h1>
        <p class="infrastructure-content pb-4">This laboratory offers the experiments related to Physico-chemical and Biological parameters testing for Water and Wastewater, solid waste and air pollution. It also provides testing facilities for research and analysis for the Researchers and Post graduates of environmental Engineering discipline.</p>
      </div>

      <div class="">
        <h1 class="infrastructure-heading m-0">Geotechnical Laboratory</h1>
        <p class="infrastructure-content pb-4">This laboratory furnishes with all necessary equipment for Civil Engineering course. Research, consultancy and Laboratory soil testing works are being conducted in this laboratory. Different soil properties are determined by both field and laboratory test methods which are essential for the design of foundation and earth structures.</p>
      </div>

      <div class="">
        <h1 class="infrastructure-heading m-0">Concrete Laboratory</h1>
        <p class="infrastructure-content pb-4">The laboratory serves an extensive range of activities covering those related to teaching, research and consultancy. Experimental studies related to different types of materials which are employed in concrete and testing of concrete specimens in various exposure conditions are being handled.</p>
      </div>

      <div class="">
        <h1 class="infrastructure-heading m-0">Transportation Engineering Laboratory</h1>
        <p class="infrastructure-content pb-4">The laboratory includes every measure that impacts practical knowledge and carries out all the tests required for complete understanding of the subject.</p>
      </div>

      <div class="">
        <h1 class="infrastructure-heading m-0">Surveying Laboratory</h1>
        <p class="infrastructure-content pb-4">The laboratory provides the experience in fundamental land surveying measurement methods for surveying courses, including methods to perform horizontal measurements, digital theodolites to perform angular measurements and Total Stations which enable to provide various measurements in single equipment.</p>
      </div>

      <div class="">
        <h1 class="infrastructure-heading m-0">Computational Laboratory</h1>
        <p class="infrastructure-content pb-4">The Laboratory makes available various computing facilities to the graduate students, research scholars and faculty members. A high-speed Local Area Network connection through the Institute's central facilities, ensure that all students and faculty have the most modern computing facilities, including continuous internet and e-mail connection, to meet their academic and research needs. Besides that, the laboratory also has different software’s and packages for various disciplines in order to practice and gain knowledge.</p>
      </div>

      <div class="">
        <h1 class="infrastructure-heading m-0">Hydraulics and Fluid Machinery Lab</h1>
        <p class="infrastructure-content pb-4">The Laboratory makes available various computing facilities to the graduate students, research scholars and faculty members. A high-speed Local Area Network connection through the Institute's central facilities, ensure that all students and faculty have the most modern computing facilities, including continuous internet and e-mail connection, to meet their academic and research needs. Besides that, the laboratory also has different software’s and packages for various disciplines in order to practice and gain knowledge.</p>
      </div>

      
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
      <a href="../assets/img/academic/infrastructure/img-1.jpg"  data-fancybox="gallery-slide">
      <img src="../assets/img/academic/infrastructure/img-1.jpg">

      <div class="galleryImg-overlay"></div>
    </a>
    </div>
    <div class="swiper-slide position relative">  
      <a href="../assets/img/academic/infrastructure/img-2.jpg"  data-fancybox="gallery-slide">
        <img src="../assets/img/academic/infrastructure/img-2.jpg">
        <div class="galleryImg-overlay"></div>
      </a>
      </div>
    <div class="swiper-slide position relative"> 
      <a href="../assets/img/academic/infrastructure/img-3.jpg"  data-fancybox="gallery-slide">
        <img src="../assets/img/academic/infrastructure/img-3.jpg">
        <div class="galleryImg-overlay"></div>
      </a>
    </div>
    <div class="swiper-slide position relative">    
      <a href="../assets/img/academic/infrastructure/img-4.jpg"  data-fancybox="gallery-slide">
        <img src="../assets/img/academic/infrastructure/img-4.jpg">
        <div class="galleryImg-overlay"></div>
      </a>
    </div>
    <div class="swiper-slide position relative">    
      <a href="../assets/img/academic/infrastructure/img-5.jpg"  data-fancybox="gallery-slide">
        <img src="../assets/img/academic/infrastructure/img-5.jpg">
        <div class="galleryImg-overlay"></div>
      </a>
    </div>
    <div class="swiper-slide position relative">    
      <a href="../assets/img/academic/infrastructure/img-1.jpg"  data-fancybox="gallery-slide">
        <img src="../assets/img/academic/infrastructure/img-1.jpg">
        <div class="galleryImg-overlay"></div>
      </a>
    </div>
    <div class="swiper-slide position relative">    
      <a href="../assets/img/academic/infrastructure/img-2.jpg"  data-fancybox="gallery-slide">
        <img src="../assets/img/academic/infrastructure/img-2.jpg">
        <div class="galleryImg-overlay"></div>
      </a>
    </div>
    <div class="swiper-slide position relative">    
      <a href="../assets/img/academic/infrastructure/img-3.jpg"  data-fancybox="gallery-slide">
        <img src="../assets/img/academic/infrastructure/img-3.jpg">
        <div class="galleryImg-overlay"></div>
      </a>
    </div>
    <div class="swiper-slide position relative">    
      <a href="../assets/img/academic/infrastructure/img-4.jpg"  data-fancybox="gallery-slide">
        <img src="../assets/img/academic/infrastructure/img-4.jpg">
        <div class="galleryImg-overlay"></div>
      </a>
    </div>
    <div class="swiper-slide position relative">    
      <a href="../assets/img/academic/infrastructure/img-5.jpg"  data-fancybox="gallery-slide">
        <img src="../assets/img/academic/infrastructure/img-5.jpg">
        <div class="galleryImg-overlay"></div>
      </a>
    </div>
    <div class="swiper-slide position relative">    
      <a href="../assets/img/academic/infrastructure/img-1.jpg"  data-fancybox="gallery-slide">
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