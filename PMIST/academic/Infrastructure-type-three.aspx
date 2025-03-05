<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Infrastructure-type-three.aspx.cs" Inherits="academic_infrastructure3" %>
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

  <section class="Infrastructure pb-5">
    <div class="custom-container">
      <div class="">
        <h1 class="infrastructure-heading m-0">Classrooms</h1>
        <p class="infrastructure-content pb-4">Spacious classrooms that can accommodate between 30 and 60 students.</p>
      </div>

      <div class="">
        <h1 class="infrastructure-heading m-0">Seminar hall</h1>
        <p class="infrastructure-content pb-4">Accommodate approximately 80 - 120 students, air conditioned and equipped with projector, sound system and internet connection suitable for conducting any seminars and workshops.</p>
      </div>

      <div class="">
        <h1 class="infrastructure-heading m-0">Laboratories</h1>
        <div class="">
          <h2 class="sub-heading">Green screen studio</h2>
          <p class="infrastructure-content pb-2">Studio with green/blue matte equipped with latest digital hd camera, studio lights and accessories. The studio has an adjoining post production laboratory.</p>
        </div>

        <div class="">
          <h2 class="sub-heading">Claymation and creative art studio</h2>
          <p class="infrastructure-content pb-2">Art studios with drawing tables, light boxes, with facilities for live modelling and abundance of natural light essential for the art environment.</p>
        </div>

        <div class="">
          <h2 class="sub-heading">Animation and multimedia lab</h2>
          <p class="infrastructure-content pb-2">Systems with latest configuration along with the software required for 2d & 3d animation, modelling, audio & video editing.</p>
        </div>

        <div class="">
          <h2 class="sub-heading">computer science lab</h2>
          <p class="infrastructure-content pb-2">Systems with latest configuration along with the proprietary as well as open source software.</p>
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
  </form>
</body>
</html>