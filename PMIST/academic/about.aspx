<%@ Page Language="C#" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="academic_about" %>
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
 <link href="../assets/css/academic/about.css" rel="stylesheet">
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
    <img src="../assets/img/academic/banner-images/Faculty-banner.jpg" class="img-fluid w-100">
    <div class="custom-container">
      <div class="banner-heading">
        <h4 class="m-0">Department of computer science</h4>
        <h1 class="m-0">About</h1>
      </div>
    </div>
  </section>
  <!-- banner section End  -->

  <!-- sub-menu section start  -->
  <UCDepartmentSubmenu:UCDepartmentSubmenu id="UCDepartmentSubmenu" runat="server"/>
  <!-- sub-menu section End  -->

  <section class="about-content">
    <div class="custom-container">
        <p class="m-0">The Department of computer science started in the year 2001 is a five year integrated direct PG course after 10+2 ,which helps the student to get the in-depth understanding of the role of computer science within IT dependent enterprises. Students develop capabilities in analysis, design, implementation, project management, software metrics and software testing.</p>
    </div>
  </section>

  <section class="vision-box-section">
    <div class="row ps-lg-4 m-0">
        <div class="col-lg-4 p-0 vision-align">
            <div class="vision d-flex h-100">
                <div class="heading-vision-section d-flex">
                    <h1 class="m-0">Vision</h1>
                    <img src="../assets/img/academic/about/vision.svg">
                </div>
                <p class="vision-content">
                    To be a leading department in the field of software development and digital design that offers the software education with the State-of-the-art skills. The Graduates will be recognized as globally competent by their dynamic work and produce valuable digital solutions for the society.
                </p>
            </div>
        </div>

        <div class="col-lg-4 p-0 ">
            <div class="mission d-flex ">
                <div class="heading-vision-section d-flex">
                    <h1 class="m-0">Mission</h1>
                    <img src="../assets/img/academic/about/mission-icon.svg">
                </div>
                <ul class="p-0">
                    <div class="d-flex align-items-start list-tick">
                      <img src="../assets/img/academic/home-page/tick.svg">
                      <li class="mission-list">To construct the software related technical skills among the students.</li>
                    </div>
                    <div class="d-flex align-items-start list-tick">
                      <img src="../assets/img/academic/home-page/tick.svg">
                      <li class="mission-list">To practice the cutting-edge technologies in the various areas of digital design and software development.</li>
                    </div>
                    <div class="d-flex align-items-start list-tick">
                      <img src="../assets/img/academic/home-page/tick.svg">
                      <li class="mission-list">To contribute towards the betterment of the society by producing enhanced software solutions through research.</li>
                    </div>
                    <div class="d-flex align-items-start list-tick">
                        <img src="../assets/img/academic/home-page/tick.svg">
                        <li class="mission-list">To generate the spirit of inquiry, team work, novelty and professionalism among the students.</li>
                    </div>
                    
      
                      
      
                        
                  </ul>
            </div>
        </div>

        <div class="col-lg-4 p-0">
            <div class="mission d-flex position-relative Objectives">
                <div class="heading-vision-section d-flex">
                    <h1 class="m-0">Objectives</h1>
                    <img src="../assets/img/academic/about/objectives-icon.svg">
                </div>
                <ul class="p-0">
                    <div class="d-flex align-items-start list-tick">
                      <img src="../assets/img/academic/home-page/tick.svg">
                      <li class="mission-list">To motivate all the staff members to qualify NET / SET exam and to pursue Research.</li>
                    </div>
                    <div class="d-flex align-items-start list-tick">
                      <img src="../assets/img/academic/home-page/tick.svg">
                      <li class="mission-list">To publish minimum of two papers per year by each staff member.</li>
                    </div>
                    <div class="d-flex align-items-start list-tick">
                      <img src="../assets/img/academic/home-page/tick.svg">
                      <li class="mission-list">To send one project proposal to funding agencies by each staff member per academic year.</li>
                    </div>
                    <div class="d-flex align-items-start list-tick">
                        <img src="../assets/img/academic/home-page/tick.svg">
                        <li class="mission-list">To motivate the staff members to attend various Faculty Development Programme to enrich their knowledge.</li>
                    </div>
                    <div class="d-flex align-items-start list-tick">
                        <img src="../assets/img/academic/home-page/tick.svg">
                        <li class="mission-list">To Achieve 100 % Placement in the academic year 2019 -2020</li>
                      </div>
                      <div class="d-flex align-items-start list-tick">
                          <img src="../assets/img/academic/home-page/tick.svg">
                          <li class="mission-list">To conduct Workshop, Seminar, Symposium, and Guest Lecture for the welfare of the students.</li>
                      </div>
      
                      
      
                        
                  </ul>
            </div>
        </div>
    </div>
  </section>
    

  <section class="academic-index Programs-offered mt-3 py-5 position-relative ">
    <div class="center-design"></div>
    <h1 class="text-center small-BA-line">
      <span class="">PROGRAMS OFFERED
        <div class="cap-img">
          <img src="../assets/img/academic/about/cap-image.svg">
        </div>
      </span> </h1>

      <div class="custom-container">
        <div class="row m-0 pt-5 justify-content-between">
          <div class="col-lg-3">
            <h1 class="offered-heading mb-3">Regular</h1>
            <ul class="p-0">
              <div class="d-flex align-items-start list-tick">
                <img src="../assets/img/academic/home-page/blue-tick.svg">
                <li class="offers">(3 years) - Full Time - B.Sc. Animation and Multimedia</li>
              </div>
              <div class="d-flex align-items-start list-tick">
                <img src="../assets/img/academic/home-page/pink-tick.svg">
                <li class="offers">(3 years) - Full Time - B.Sc. - Computer Science</li>
              </div>
              <div class="d-flex align-items-start list-tick">
                <img src="../assets/img/academic/home-page/blue-tick.svg">
                <li class="offers">(3 years) - Full Time - B.Sc. - Computer Science</li>
              </div>
              

                

                  
            </ul>
          </div>

          <div class="col-lg-4 ps-lg-5">
            <h1 class="offered-heading mb-3">Batch I [9.15 AM - 1.45PM] - Co-Education</h1>
            <ul class="p-0 center-list">
              <div class="d-flex align-items-start list-tick">
                <img src="../assets/img/academic/home-page/blue-tick.svg">
                <li class="offers">B.Sc. Animation and Multimedia</li>
              </div>
              
                <div class="d-flex align-items-start list-tick">
                    <img src="../assets/img/academic/home-page/pink-tick.svg">
                  <li class="offers">B.Sc. Computer Science</li>
                </div>
                
                  <div class="d-flex align-items-start list-tick">
                    <img src="../assets/img/academic/home-page/blue-tick.svg">
                    <li class="offers">B.Sc. Artificial Intelligence</li>
                  </div>
                  
                    <div class="d-flex align-items-start list-tick">
                        <img src="../assets/img/academic/home-page/pink-tick.svg">
                      <li class="offers">B.Sc. Computer Science (Cyber Security)</li>
                    </div>
                    
                      <div class="d-flex align-items-start list-tick">
                        <img src="../assets/img/academic/home-page/blue-tick.svg">
                        <li class="offers"> M.Sc. Computer Science (AR & VR)*</li>
                      </div>
                     
            </ul>
          </div>

          <div class="col-lg-3">
            <h1 class="offered-heading mb-3">Batch II [11.45 AM - 4.45 PM]</h1>
            <ul class="p-0">
              <div class="d-flex align-items-start list-tick">
                <img src="../assets/img/academic/home-page/blue-tick.svg">
                <li class="offers">B.Sc. Computer Science</li>
              </div>
              
            </ul>
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