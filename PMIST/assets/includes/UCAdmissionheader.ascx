<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCAdmissionheader.ascx.cs" Inherits="includesUCAdmissionheader" %>
<nav class="navbar navbar-expand-xl navbar-dark bg-white  align-items-xl-end align-items-center custom-header pb-0">
   <div
      class="d-xl-none d-md-none d-flex align-items-center flex-wrap justify-content-center  header-btngroup  col-12 ">
      <a href="https://pmu.edu/virtualtour/index.htm" class="header-btn-type1 mx-2 my-2" target="_blank" >360&deg;</a>
      <a href="#" class="header-btn-type1 text-uppercase mx-2  my-2">Chat with us</a>
      <a href="https://pmu.edu/admission/RegistrationNew.aspx" class="header-btn-type1 text-uppercase mx-2  my-2  yellow-bg">Admission 2025</a>
      <a href="https://pmu.edu/admission/ResearchApplicationRegister.aspx" class="header-btn-type1 text-uppercase mx-2 me-0 yellow-bg">P<span style="text-transform: lowercase;">h</span>.D. Application</a>
   </div>
   <div class="container-fluid">
   <a class="navbar-brand" href=""><img src="../assets/img/pmu-logo.png"></a>
   <div class="d-flex align-items-center">
      <div
         class="d-xl-none d-md-flex d-none align-items-center justify-content-end pb-3 pt-2 header-btngroup pe-3 ">
         <a href="https://pmu.edu/virtualtour/index.htm" class="header-btn-type1 mx-2" target="_blank" >360&deg;</a>
         <a href="#" class="header-btn-type1 text-uppercase mx-2">Chat with us</a>
      </div>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#main_nav"
         aria-expanded="false" aria-label="Toggle navigation">
      <i class="bi bi-list"></i>
      </button>
   </div>
   <div class="collapse navbar-collapse" id="main_nav">
      <div class="d-xl-flex  d-none align-items-center justify-content-end pb-3 pt-2">
         <a href="https://pmu.edu/virtualtour/index.htm" class="header-btn-type1 mx-2" target="_blank">360&deg;</a>
         <a href="#" class="header-btn-type1 text-uppercase mx-2">Chat with us</a>
         <a href="https://pmu.edu/admission/RegistrationNew.aspx" class="header-btn-type1 text-uppercase mx-2 me-0 yellow-bg">Admission 2025</a>
         <a href="https://pmu.edu/admission/ResearchApplicationRegister.aspx" class="header-btn-type1 text-uppercase mx-2 me-0 yellow-bg">P<span style="text-transform: lowercase;">h</span>.D. Application</a>
      </div>
      <hr class="header-line  m-0">
      <ul class="navbar-nav">
         <li class="nav-item admission-active position-relative"> <a class="nav-link" href="index.aspx">Home</a> </li>
         <li class="nav-item dropdown has-megamenu">
            <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown"> Programmes offered </a>
            <div class="dropdown-menu megamenu" role="menu">
               <div class="row menutype1">
                  <a href="architecture.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">Architecture</a>
                  <a href="engineering.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">Engineering</a>
                  <a href="arts_seience.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">Arts & Science</a>
                  <a href="shift-2-courses.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">Shift 2</a>
                  <a href="management.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">Management Studies</a>
                  <a href="mphil_phd.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">M.Phil & Ph.D</a>
                  <a href="education.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">Education (Integrated Programme)</a>
                  
                  
               </div>
            </div>
         </li>
         <li class="nav-item dropdown has-megamenu">
            <a class="nav-link" href="programmefees.aspx" >Programme Fees</a>
         </li>
         <li class="nav-item"><a class="nav-link" href="scholarship.aspx"> Scholarship</a></li>
         <!-- <li class="nav-item dropdown has-megamenu">
            <a class="nav-link " href="https://pmu.edu/admission/counselling.aspx" > Counselling </a>
         </li> -->
         <li class="nav-item dropdown has-megamenu">
            <a class="nav-link " href="download.aspx"> Downloads </a>
         </li>
         <li class="nav-item  dropdown has-megamenu">
            <a class="nav-link " href="contact.aspx"> contact </a>
            
         </li>
         
         <li class="nav-item dropdown has-megamenu">
         <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown" > More + </a>
         <div class="dropdown-menu megamenu" role="menu">
         <div class="row menutype1">
         <a href="https://pmu.edu/examination/"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Examination</a>
         <a href="https://pmu.edu/placement/"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Placement</a>
         <a href="https://pmu.edu/gallery/"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Gallery</a>
         <a href="https://pmu.edu/events/" class="col-lg-3 col-md-4 col-sm-6  col-12">Events</a>
         <a href="http://periyartbi.pmu.edu/" class="col-lg-3 col-md-4 col-sm-6  col-12">PTBI</a>
         <a href="https://pmu.edu/careers/"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Careers</a>
         <a href="https://pmu.edu/contact/"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Contact</a>
         <a href="https://pmu.edu/gallery/mission-green.aspx"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Mission Green PMIST</a>
         <a href="https://pmu.edu/capacity-development-and-skill-enhancement.aspx"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Capacity Development and Skill
         Enhancement Activities</a>
         <a href="https://pmu.edu/achievements-corner/"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Achievement Corner</a>
         <a href="https://pmu.edu/admission/call-letter-login.aspx"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Call Letter Download</a>
         <a href="https://pmu.edu/students-grievance/"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Student Grievance Online</a>
         <a href="https://pmu.edu/admission/ResearchApplicationRegister.aspx"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Ph.D.Application</a>
         <a href="https://pmu.edu/career-counselling/"
            class="col-lg-3 col-md-4 col-sm-6  col-12">Career Guidance</a>
         
         </div>
         </div>
         </li>

      </ul>
      </div> 

   </div>
   
</nav>