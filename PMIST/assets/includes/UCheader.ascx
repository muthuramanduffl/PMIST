
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCheader.ascx.cs" Inherits="includesUCheader" %>
     <nav class="navbar navbar-expand-xl navbar-dark bg-white  align-items-xl-end align-items-center custom-header pb-0">
         <div
            class="d-xl-none d-md-none d-flex align-items-center flex-wrap justify-content-center  header-btngroup  col-12 ">
            <a href="#" class="header-btn-type1 mx-2 my-2">360<sup>0</sup></a>
            <a href="#" class="header-btn-type1 text-uppercase mx-2  my-2">Chat with us</a>
            <a href="#" class="header-btn-type1 text-uppercase mx-2  my-2  yellow-bg">Admission 2025</a>
            <div class="nav-item student-login-btn d-md-none  my-2 ">
               <a class="nav-link pt-0" href="#">
                  <span>
                     Student
                     Login 
                     <div class="arrow-icon"><i class="bi bi-chevron-right"></i></div>
                  </span>
               </a>
            </div>
         </div>
         <div class="container-fluid">
         <a class="navbar-brand" href=""><img src="../assets/img/pmu-logo.png"></a>
         <div class="d-flex align-items-center">
            <div
               class="d-xl-none d-md-flex d-none align-items-center justify-content-end pb-3 pt-2 header-btngroup pe-3 ">
               <a href="#" class="header-btn-type1 mx-2">360<sup>0</sup></a>
               <a href="#" class="header-btn-type1 text-uppercase mx-2">Chat with us</a>
               <a href="#" class="header-btn-type1 text-uppercase mx-2  yellow-bg">Admission 2025</a>
               <div class="nav-item student-login-btn mx-2 me-0 ">
                  <a class="nav-link pt-0 " href="#">
                     <span>
                        Student
                        Login 
                        <div class="arrow-icon"><i class="bi bi-chevron-right"></i></div>
                     </span>
                  </a>
               </div>
            </div>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#main_nav"
               aria-expanded="false" aria-label="Toggle navigation">
            <i class="bi bi-list"></i>
            </button>
         </div>
         <div class="collapse navbar-collapse" id="main_nav">
            <div class="d-xl-flex  d-none align-items-center justify-content-end pb-3 pt-2">
               <a href="#" class="header-btn-type1 mx-2">360<sup>0</sup></a>
               <a href="#" class="header-btn-type1 text-uppercase mx-2">Chat with us</a>
               <a href="#" class="header-btn-type1 text-uppercase mx-2 me-0 yellow-bg">Admission 2025</a>
            </div>
            <hr class="header-line  m-0">
            <ul class="navbar-nav">
               <li class="nav-item active"> <a class="nav-link" href="#">Home</a> </li>
               <li class="nav-item dropdown has-megamenu">
                  <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown"> About </a>
                  <div class="dropdown-menu megamenu" role="menu">
                     <div class="row menutype1">
                        <a href="https://pmu.edu/about/" class="col-lg-3 col-md-4 col-sm-6  col-12">About
                        PMIST</a>
                        <a href="https://pmu.edu/about/history.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">History</a>
                        <a href="https://pmu.edu/about/Chancellor.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Chancellor</a>
                        <a href="https://pmu.edu/about/governance.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Governance </a>
                        <a href="https://pmu.edu/about/management.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Management</a>
                        <a href="https://pmu.edu/about/deans.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Deans</a>
                        <a href="https://pmu.edu/about/directors.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Directors</a>
                        <a href="https://pmu.edu/about/administrative-officers.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Administrative Officers</a>
                        <a href="https://pmu.edu/about/committee.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Committees</a>
                        <a href="https://pmu.edu/about/statutory-bodies.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Statutory Bodies</a>
                        <a href="https://pmu.edu/about/bye-laws.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Bye-laws and
                        Constitution</a>
                        <a href="https://www.pmu.edu/about/accreditation-and-ranking.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Accreditation and Ranking </a>
                        <a href="https://www.pmu.edu/about/e-news-bulletin.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">E-News Bulletin</a>
                        <a href="https://www.pmu.edu/about/year-wise-calendar.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Academic Calender </a>
                        <a href="https://www.pmu.edu/about/privacy-policy.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12">Privacy policy </a>
                        <a href="https://www.pmu.edu/about/academic-schedule.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12"> Academic schedule </a>
                     </div>
                  </div>
               </li>
               <li class="nav-item dropdown has-megamenu">
                  <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown"> Academics </a>
                  <div class="dropdown-menu megamenu" role="menu">
                     <div class="row g-3">
                        <div class="col-xxl-2 col-xl-3 d-xl-block d-none col-12 accordion-side">
                           <ul class="accordion-list">
                              <li data-menu-tab-name="#menutab1">Academics</li>
                              <li class="active" data-menu-tab-name="#menutab2">Faculty </li>
                              <li data-menu-tab-name="#menutab2-1">Centers</li>
                              <li data-menu-tab-name="#menutab3">Student</li>
                              <li data-menu-tab-name="#menutab4">Examination</li>
                              <li data-menu-tab-name="#menutab5">Alumni</li>
                              <li data-menu-tab-name="#menutab6">Faculty</li>
                              <li data-menu-tab-name="#menutab7">Parents</li>
                           </ul>
                        </div>
                        <!-- end col-3 -->
                        <div class="col-xxl-10 col-xl-9 ps-xl-5 col-12"> 
                           <button class="mobile-menuaccord-btn d-xl-none d-block"
                              data-menu-tab-name="#menutab1">
                           Academics
                           </button>
                           <div class="tabmenulist" id="menutab1">
                              <div class="row ">
                                 <div class="col-12">
                                    <div class="col-megamenu">
                                       <!-- <h6 class="title">Faculty of Architecture and Planning</h6> -->
                                       <ul class="list-unstyled">
                                          <li>
                                             <a href="https://pmu.edu/about/deans.aspx">
                                             Deans
                                             </a>
                                          </li>
                                          <li>
                                             <a href="#">
                                             Dean - Academic Courses
                                             </a>
                                          </li>
                                          <li>
                                             <a href="#">
                                             Dean Learning and Development
                                             </a>
                                          </li>
                                          <li>
                                             <a href="#">
                                             Academic Calendar
                                             </a>
                                          </li>
                                          <li>
                                             <a href="#">
                                             Academic schedule
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://www.pmu.edu/regulations.aspx">
                                             Regulations
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://www.pmu.edu/academics.aspx">
                                             Academic Council
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/library/index.aspx">
                                             Library
                                             </a>
                                          </li>
                                          <li>
                                             <a
                                                href="https://pmu.edu/iqac/feedback-on-curricular-aspects.aspx">
                                             Feedback
                                             </a>
                                          </li>
                                       </ul>
                                    </div>
                                 </div>
                              </div>
                           </div>
                           <button class="mobile-menuaccord-btn d-xl-none d-block active"
                              data-menu-tab-name="#menutab2">
                           Faculty 
                           </button> 
                           <div class="tabmenulist" id="menutab2" style="display: block;">
                              <div class="row ">
                                 <div class="col-lg-6 col-12">
                                    <div class="row">
                                       <div class="col-12">
                                          <div class="col-megamenu">
                                             <h6 class="title">Faculty of Architecture and Planning</h6>
                                             <ul class="list-unstyled">
                                                <li><a href="#">Architecture</a></li>
                                             </ul>
                                          </div>
                                       </div>
                                       <div class="col-12">
                                          <div class="col-megamenu">
                                             <h6 class="title">Faculty of Engineering and Technology</h6>
                                             <ul class="list-unstyled">
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-aerospace/"
                                                      class="">
                                                   Aerospace
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-biotechnology/"
                                                      class="">
                                                   Biotechnology
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-civil-engineering/"
                                                      class="">
                                                   Civil Engineering
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-computer-science/"
                                                      class="">
                                                   Computer Science And Engineering
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-electronics-and-communication/"
                                                      class="">
                                                   Electronics And Communication Engineering
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-electrical-and-electronics/"
                                                      class="">
                                                   Electrical And Electronics Engineering
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-mechanical-engineering/"
                                                      class="">
                                                   Mechanical Engineering
                                                   </a>
                                                </li>
                                             </ul>
                                          </div>
                                       </div>
                                       <div class="col-12">
                                          <div class="col-megamenu">
                                             <h6 class="title">Faculty of Computing Science and
                                                Applications
                                             </h6>
                                             <ul class="list-unstyled">
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-informatics/"
                                                      class="">
                                                   Informatics
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-computer-science/"
                                                      class="">
                                                   Computer Science
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="#" class="">
                                                   Software Engineering
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-computer-applications/"
                                                      class="">
                                                   Computer Application
                                                   </a>
                                                </li>
                                             </ul>
                                          </div>
                                       </div>
                                    </div>
                                 </div>
                                 <div class="col-lg-6 col-12">
                                    <div class="row">
                                       <div class="col-12">
                                          <div class="col-megamenu">
                                             <h6 class="title">Faculty of Commerce</h6>
                                             <ul class="list-unstyled">
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-commerce/"
                                                      class="">
                                                   Commerce
                                                   </a>
                                                </li>
                                             </ul>
                                          </div>
                                       </div>
                                       <div class="col-12">
                                          <div class="col-megamenu">
                                             <h6 class="title">Faculty of Management Studies</h6>
                                             <ul class="list-unstyled">
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-management-studies/"
                                                      class="">
                                                   Management Studies
                                                   </a>
                                                </li>
                                             </ul>
                                          </div>
                                       </div>
                                       <div class="col-12">
                                          <div class="col-megamenu">
                                             <h6 class="title">Faculty of Science and Humanities</h6>
                                             <ul class="list-unstyled">
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-foundation-courses/"
                                                      class="">
                                                   Foundation Courses
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-chemistry/"
                                                      class="">
                                                   Chemistry
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-english/"
                                                      class="">
                                                   Languages
                                                   </a>
                                                </li>
                                                <li>
                                                   <a style="display:none"
                                                      href="https://www.rss.org/eng/rediffmail-login/"
                                                      title="rediffmail login"
                                                      rel="dofollow">rediffmail login</a>
                                                   <a href="https://www.pmu.edu/department-of-physics/"
                                                      class="">
                                                   Physics
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-mathematics/"
                                                      class="">
                                                   Mathematics
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-education/"
                                                      class="">
                                                   Education
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-political-science/"
                                                      class="">
                                                   Political Science
                                                   </a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/department-of-social-work/"
                                                      class="">
                                                   Social Work
                                                   </a>
                                                </li>
                                             </ul>
                                          </div>
                                       </div>
                                    </div>
                                 </div> 
                              </div>
                           </div>
                           <button class="mobile-menuaccord-btn d-xl-none d-block"
                              data-menu-tab-name="#menutab2">
                           Centers
                           </button> 
                           <div class="tabmenulist" id="menutab2-1">
                              <div class="row "> 
                                 <div class="col-12">
                                    <div class="col-megamenu"> 
                                       <ul class="list-unstyled">
                                          <li>
                                             <a href="https://pmu.edu/placement/" class="">
                                             Centre for Institute Industry Interaction (CIII)
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/centre-for-students-and-administrative-services.aspx"
                                                class="">
                                             Centre For Students And Administrative Services
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/Centre-for-Human-Resource-Development.aspx"
                                                class="">
                                             Centre for Human Resource Development
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/kkcps.aspx" class="">
                                             Dr. Kalaignar M.Karunanithi Centre For Political Science
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/veeramani-mohana-centre-for-quality-life-engineering-research.aspx"
                                                class="">
                                             Veeramani Mohana Centre For Quality Of Life Engineering
                                             Research (I/C)
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/centre-for-energy-and-environment.aspx"
                                                class="">
                                             Centre for Energy and Environment
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/centre-for-rural-development.aspx"
                                                class="">
                                             Periyar Pura Centre For Rural Development
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/cetat.aspx" class="">
                                             Centre Of Excellence For Training And Research In
                                             Automation Technologies
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/centre-of-excellence-for-next-generation-networks.aspx"
                                                class="">
                                             Centre Of Excellence For Next Generation Networks
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/centre-of-excellence-for-periyar-thought.aspx"
                                                class="">
                                             Centre Of Excellence For Periyar Thought
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/national-cyber-defense-resource-centre.aspx"
                                                class="">
                                             National Cyber Defense Resource Centre (NCDRC)
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/CSSTP.aspx" class="">
                                             Centre for Scholarly Scientific Training and Publishing
                                             (CSSTP)
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/centres/Centre-for-Skill-Development-Center.aspx"
                                                class="">
                                             Centre For Skill Development Center
                                             </a>
                                          </li>
                                       </ul>
                                    </div>
                                 </div>
                              </div>
                           </div>
                           <button class="mobile-menuaccord-btn d-xl-none d-block "
                              data-menu-tab-name="#menutab3">
                           Students
                           </button>
                           <div class="tabmenulist" id="menutab3">
                              <div class="row">
                                 <div class="col-lg-6">
                                    <div class="row">
                                       <div class="col-12">
                                          <div class="col-megamenu">
                                             <ul class="list-unstyled">
                                                <li>
                                                   <a href="#">Online grievance</a>
                                                </li>
                                                <li>
                                                   <a href="#">Student Circular</a>
                                                </li>
                                                <li>
                                                   <a href="#">Online Fee payment</a>
                                                </li>
                                                <li>
                                                   <a
                                                      href="http://14.139.171.138/Student_Leave_Management/Login.php">Leave
                                                   and IPT</a>
                                                </li>
                                                <li>
                                                   <a
                                                      href="https://pmu.edu/about/management.aspx">Management</a>
                                                </li>
                                                <li>
                                                   <a
                                                      href="http://14.139.171.133/LiveStudentPortal/Main_Login.aspx">Open
                                                   Elective</a>
                                                </li>
                                                <li>
                                                   <a href="#">Registration</a>
                                                </li>
                                                <li>
                                                   <a href="https://pmu.edu/events/">Students
                                                   Events</a>
                                                </li>
                                                <li>
                                                   <a href="#">Clubs and Societies</a>
                                                </li>
                                                <li>
                                                   <a href="https://www.pmu.edu/achievements-corner/">Students
                                                   Achievements</a>
                                                </li>
                                                <li>
                                                   <a href="#">Course Registration</a>
                                                </li>
                                                <li>
                                                   <a href="#">Semester Results</a>
                                                </li>
                                                <li>
                                                   <a href="#">Hostel Out pass</a>
                                                </li>
                                                <li>
                                                   <a href="#">Semester Results</a>
                                                </li>
                                             </ul>
                                          </div>
                                       </div>
                                    </div>
                                 </div>
                                 <div class="col-lg-6">
                                    <div class="row">
                                       <div class="col-12">
                                          <div class="col-megamenu">
                                             <h6 class="title">Industrial visit procedure</h6>
                                             <ul class="list-unstyled">
                                                <li>
                                                   <a href="https://pmu.edu/students-grievance/">
                                                   Online grievance
                                                   </a>
                                                </li>
                                             </ul>
                                          </div>
                                       </div>
                                       <div class="col-12">
                                          <div class="col-megamenu">
                                             <h6 class="title">E Content Committees</h6>
                                             <ul class="list-unstyled">
                                                <li>
                                                   <a href="#">Antiragging</a>
                                                </li>
                                                <li>
                                                   <a href="#">Antidrug Committee</a>
                                                </li>
                                                <li>
                                                   <a href="#">Code of Conduct committee</a>
                                                </li>
                                                <li>
                                                   <a href="#">Grievance and Redressal committee</a>
                                                </li>
                                                <li>
                                                   <a href="#">Internal Compliance committee</a>
                                                </li>
                                                <li>
                                                   <a href="#">Student Council</a>
                                                </li>
                                             </ul>
                                          </div>
                                       </div>
                                    </div>
                                 </div>
                              </div>
                           </div>
                           <button class="mobile-menuaccord-btn d-xl-none d-block "
                              data-menu-tab-name="#menutab4">
                           Examination
                           </button>
                           <div class="tabmenulist" id="menutab4">
                              <div class="row">
                                 <div class="col-lg-6">
                                    <div class="col-megamenu">
                                       <h6 class="title">Controller of Examination </h6>
                                       <ul class="list-unstyled">
                                          <li>
                                             <a href="#">Controller of examinations message</a>
                                          </li>
                                          <li>
                                             <a href="#">Staffs</a>
                                          </li>
                                          <li>
                                             <a href="#">PMIST Examinations system</a>
                                          </li>
                                          <li>
                                             <a href="#">CGPA to percentage conversion</a>
                                          </li>
                                       </ul>
                                    </div>
                                 </div>
                                 <div class="col-lg-6">
                                    <div class="col-megamenu">
                                       <div class="col-megamenu">
                                          <h6 class="title">Downloads</h6>
                                          <ul class="list-unstyled">
                                             <li>
                                                <a href="#">Transcript</a>
                                             </li>
                                             <li>
                                                <a href="#">Migration</a>
                                             </li>
                                             <li>
                                                <a href="#">Medium of Instruction</a>
                                             </li>
                                             <li>
                                                <a href="#">Examination</a>
                                             </li>
                                             <li>
                                                <a href="#">Timetable</a>
                                             </li>
                                             <li>
                                                <a href="#">Semester Result</a>
                                             </li>
                                             <li>
                                                <a href="#">Convocation</a>
                                             </li>
                                          </ul>
                                       </div>
                                    </div>
                                 </div>
                              </div>
                           </div>
                           <button class="mobile-menuaccord-btn d-xl-none d-block "
                              data-menu-tab-name="#menutab5">
                           Alumni
                           </button>
                           <div class="tabmenulist" id="menutab5">
                              <div class="row">
                                 <div class="col-lg-4">
                                    <div class="col-megamenu">
                                       <ul class="list-unstyled">
                                          <li>
                                             <a href="https://pmu.edu/alumni/">Home</a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/alumni/about.aspx">About</a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/alumni/pmaa-structure.aspx">PMAA
                                             Structure</a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/alumni/chapters.aspx">Chapters</a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/alumni/events.aspx">Events</a>
                                          </li>
                                          <li>
                                             <a
                                                href="https://pmu.edu/alumni/testimonials.aspx">Testimonial</a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/alumni/gallery.aspx">Gallery</a>
                                          </li>
                                          <li>
                                             <a
                                                href="https://pmu.edu/alumni/job-recruitment.aspx">Jobs</a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/alumni/alumni.aspx">Proud
                                             Alumni</a>
                                          </li>
                                       </ul>
                                    </div>
                                 </div>
                              </div>
                           </div>
                           <button class="mobile-menuaccord-btn d-xl-none d-block "
                              data-menu-tab-name="#menutab6">
                           Faculty
                           </button>
                           <div class="tabmenulist" id="menutab6">
                              <div class="row">
                                 <div class="col-lg-4">
                                    <div class="col-megamenu">
                                       <ul class="list-unstyled">
                                          <li>
                                             <a href="#">
                                             Faculty leave apply
                                             </a>
                                          </li>
                                          <li>
                                             <a href="#">
                                             Faculty welfare measures
                                             </a>
                                          </li>
                                          <li>
                                             <a href="#">
                                             Faculty Circular
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://www.pmu.edu/about/year-wise-calendar.aspx">
                                             Academic Calendar
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/about/bye-laws.aspx">
                                             Bylaws and Constitution
                                             </a>
                                          </li>
                                          <li>
                                             <a href="http://pg.pmu.ind.in/index.aspx">
                                             Cafeteria Portal Recharge system
                                             </a>
                                          </li>
                                       </ul>
                                    </div>
                                 </div>
                              </div>
                           </div>
                           <button class="mobile-menuaccord-btn d-xl-none d-block "
                              data-menu-tab-name="#menutab7">
                           Parents
                           </button>
                           <div class="tabmenulist" id="menutab7">
                              <div class="row">
                                 <div class="col-lg-4">
                                    <div class="col-megamenu">
                                       <ul class="list-unstyled">
                                          <li>
                                             <a href="https://www.pmu.edu/about/year-wise-calendar.aspx">
                                             Academic Calendar
                                             </a>
                                          </li>
                                          <li>
                                             <a href="#">
                                             Student Attendance
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/Counsellors.aspx">
                                             Counselling mentors
                                             </a>
                                          </li>
                                          <li>
                                             <a
                                                href="https://pmu.edu/about/administrative-officers.aspx">
                                             Administrative
                                             </a>
                                          </li>
                                          <li>
                                             <a href="https://pmu.edu/contact/">
                                             Contacts
                                             </a>
                                          </li>
                                       </ul>
                                    </div>
                                 </div>
                              </div>
                           </div>
                        </div>
                        <!-- end col-3 -->
                     </div>
                     <!-- end row -->
                  </div>
                  <!-- dropdown-mega-menu.// -->
               </li>
               <li class="nav-item"><a class="nav-link" href="https://pmu.edu/admission/"> Admission </a></li>
               <li class="nav-item dropdown has-megamenu">
                  <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown"> Research </a>
                  <div class="dropdown-menu megamenu" role="menu">
                     <div class="row menutype1">
                        <a href="https://pmu.edu/research/culture.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Research Culture</a>
                        <a href="https://pmu.edu/research/research-facilities.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Research Facilities</a>
                        <a href="https://pmu.edu/research/funded-projects.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Funded Projects</a>
                        <a href="#." class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Consultancy</a>
                        <a href="https://pmu.edu/research/research-advisory-committee.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Research Advisory Committee (RAC)</a>
                        <a href="https://pmu.edu/research/research-forms.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Download Research Forms</a>
                        <a href="https://pmu.edu/research/collaborations-and-MoU.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Collaborations &amp; MoU's</a>
                        <a href="https://pmu.edu/research/ipr-cell.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">IPR Cell</a>
                        <a href="https://pmu.edu/research/code-of-ethics-for-research.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Code of Ethics for Research</a>
                        <a href="https://pmu.edu/research/regulation.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">M.Phil and Ph.D Regulation</a>
                        <a href="https://pmu.edu/research/institute-innovation-council.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Institute Innovation Council</a>
                        <a href="https://pmu.edu/research/funding-agencies.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Funding Agencies</a>
                        <a href="https://pmu.edu/research/research-outcome-of-PMIST-in-scopus-database.aspx"
                           class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Research outcome of PMIST in Scopus Database</a>
                        <a href="https://pmu.edu/research/resource-for-researchers.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Resource for Researchers</a>
                        <a href="https://pmu.edu/research/ph_d_awards.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">Ph.D. Application</a> 
                        <a href="https://pmu.edu/centres/CSSTP.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                           ">CSSTP</a> 
                     </div>
               </li>
               <li class="nav-item dropdown has-megamenu"><a class="nav-link dropdown-toggle" href="#"
                  data-bs-toggle="dropdown"> iqac </a>
               <div class="dropdown-menu megamenu" role="menu">
               <div class="row menutype1">
               <a href="https://pmu.edu/iqac/default.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">
               Home
               </a>
               <a href="https://pmu.edu/iqac/about.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">
               About
               </a>
               <a href="https://pmu.edu/iqac/co-ordinators.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">
               Coordinators
               </a>
               <a href="https://pmu.edu/iqac/Members.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">
               Members
               </a>
               <a href="https://pmu.edu/iqac/meetings.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">
               Meeting
               </a>
               <a href="https://pmu.edu/iqac/audited-statement.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">
               Audited Statement
               </a>
               <a href="https://pmu.edu/iqac/contact.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">
               Contact
               </a>
               <a href="https://pmu.edu/iqac/reports.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">
               Report
               </a>
               <a href="https://pmu.edu/iqac/gallery.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">
               Gallery
               </a>
               <a href="https://pmu.edu/iqac/naac.aspx" target="_blank"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">
               NAAC
               </a>
               <a href="https://pmu.edu/iqac/aqar.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12">
               AQAR
               </a>
               <a href="https://pmu.edu/iqac/policies-procedures.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">
               Policies and Procedures
               </a>
               <a href="https://pmu.edu/iqac/feedback-on-curricular-aspects.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">
               Feedback on Curricular Aspects
               </a>
               <a href="https://pmu.edu/iqac/pmistannualrep.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">
               PMIST Annual Report
               </a>
               <a href="https://pmu.edu/iqac/initiatives.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">
               Initiatives
               </a>
               <a href="https://pmu.edu/iqac/staff-appraisal.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">
               Staff Appraisal
               </a>
               <a href="https://pmu.edu/iqac/Institutional-Distinctiveness.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">
               Institutional Distinctiveness
               </a>
               <a href="https://pmu.edu/iqac/Best-Practices.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">
               Best Practices
               </a>
               </div>
               </div>
               </li>
               <li class="nav-item  dropdown has-megamenu">
               <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown"> Facilities </a>
               <div class="dropdown-menu megamenu" role="menu">
               <div class="row menutype1">
               <a href="https://www.pmu.edu/campus/" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Life at PMIST
               </a>
               <a href="https://www.pmu.edu/campus/amenities.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Campus Amenities
               </a>
               <a href="https://www.pmu.edu/campus/zero-carbon.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Zero Carbon Campus
               </a>
               <a href="https://pmu.edu/library/index.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Arjun Singh Library
               </a>
               <a href="https://www.pmu.edu/campus/physical-education.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Physical Education
               </a>
               <a href="https://www.pmu.edu/campus/ict-facilities.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               ICT Facilities
               </a>
               <a href="#" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Computer Facilities
               </a>
               <a href="https://www.pmu.edu/campus/hostel.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Hostel
               </a>
               <a href="https://pmu.edu/campus/student-association.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Student Association
               </a>
               <a href="https://pmu.edu/centres/centre-for-students-and-administrative-services.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Clubs and Socities
               </a>
               <a href="https://www.pmu.edu/campus/hospital.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Periyar Maniammai Hospital
               </a>
               <a href="https://www.pmu.edu/campus/e-governance.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               E-Governance
               </a>
               <a href="https://www.pmu.edu/campus/barrier-free-environment.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Barrier Free Environment
               </a>
               <a href="https://www.pmu.edu/campus/cultural-activities.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Cultural Activities
               </a>
               <a href="https://www.pmu.edu/campus/learning-management-system.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               Learning Management System
               </a>
               <a href="https://www.pmu.edu/campus/eYantra.aspx" class="col-lg-3 col-md-4 col-sm-6  col-12
                  ">
               e Yantra Lab
               </a>
               </div>
               </div>
               </li>
               <li class="nav-item"><a class="nav-link" href="https://pmu.edu/chat-with-a-student/"> Chat with a
               student </a></li>
               <li class="nav-item dropdown has-megamenu">
               <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown"> More + </a>
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
               <a href="https://pmu.edu/career-counselling/"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">Career Guidance</a>
               <a href="https://pmu.edu/sustainable-development/"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">Sustainable Development</a>
               <a href="https://pmu.edu/Counsellors.aspx"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">Counsellors</a>
               <a href="http://pmiststudentportal.in/"
                  class="col-lg-3 col-md-4 col-sm-6  col-12">Student Portal</a>
               </div>
               </div>
               </li>
               <li class="nav-item student-login-btn d-xl-block d-none"><a class="nav-link" href="#"><span>Student
               Login <div class="arrow-icon"><i class="bi bi-chevron-right"></i></div></span> </a></li>
            </ul>
            <!-- navbar-collapse.// -->
            </div> <!-- container-fluid.// -->
         </div>
      </nav>
     
   