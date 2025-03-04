<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCTopMenu.ascx.cs" Inherits="Includes_UCTopMenu" %>
<div class="container-12">
    <div class="grid-2">
    	<div class="logo">
    		<a href="/index.aspx" title="Periyar Maniammai University"><img src="../images/icons/inner-logo.png" alt="Periyar Maniammai University" /></a>
        </div>
    </div>
    <div class="grid-10 right-menu">
    <!--<a href="https://pmu.edu/UG_PG_Application.aspx" target="_blank" class="apply">Apply Now</a>-->
    <div id="mgmenu1" class="mgmenu_container">

		<ul class="mgmenu">

        	<li class="mgmenu_button">Menu</li><!-- Button (Mobile Devices) -->

        	<li  <%=BindUrlClass("index") %>><a href="/index.aspx" title="">Home</a></li>

            <li  <%=BindUrlClass("About") %>><a href="#" title="">About Us</a>
                <!-- Begin Item -->
                    <div class="dropdown_container dropdown_2columns"><!-- Begin Item Container -->
    					<div class="col_12">
                        	<h5>About PMU</h5>
                            <ul>
                            <li><a href="/aboutpmu.aspx">About</a></li>
                            <li><a href="/pmuhistory.aspx">History</a></li>
                            <li><a href="/management.aspx">Management</a></li>
                            <li><a href="/committees.aspx">Committee</a></li>
                            <li><a href="/Statutorybodies.aspx">Statutory bodies</a></li>
                            <li><a href="/academic.aspx">Academic</a></li>
                              <li><a href="https://pmu.edu/placement/placement_2016/index.html">Placements</a></li>
                            </ul>
                    	</div>
                    </div>
                <!-- End Item Container -->
            </li><!-- End Item -->

            <li><a href="#" title="">Programs</a>
                <!-- Begin Item -->
                    <div class="dropdown_container dropdown_9columns"><!-- Begin Item Container -->

                        <div class="col_6">


                  <h5>School of Architecture and Planning (SAP)</h5>
                  <ul>
                    <li><a href="/architecturedepartment/about.aspx">Department of Architecture</a></li>
                                     </ul>
                <%--</div>


                <div class="col_6">--%>
                  <h5>School of Engineering and Technology(SET)</h5>
                  <ul>
                    <li><a href="/aerospacedepartment/about.aspx">Department of Aerospace Engineering</a></li>
                    <li><a href="/biotechnologyDepartment/about.aspx">Department of Bio-Technology</a></li>
                    <li><a href="/chemicalengineeringdepartment/about.aspx">Department of Chemical Engineering</a></li>
                    <li><a href="/civilengineeringdepartment/about.aspx">Department of Civil Engineering</a></li>
                    <li><a href="/electronicsandcommunicationdepartment/about.aspx">Department of Electronics and Communication Engineering</a></li>
                    <li><a href="/electricalandelectronicsdepartment/about.aspx">Department of Electrical and Electronics Engineering</a></li>
                    <li><a href="/mechanicalengineeringdepartment/about.aspx">Department of Mechanical Engineering</a></li>
                    <%--<li><a href="/nanotechnology/about.aspx">Nanotechnology Division</a></li>--%>
                  </ul>
                </div>

                     <div class="col_6">
              <h5>School of Computing Sciences and Engineering(SCSE)</h5>
              <ul>
                <li><a href="/computerscienceandengineeringdepartment/about.aspx">Department of Computer Science and Engineering</a></li>
                <li><a href="/informationtechnologydepartment/about.aspx">Department of Information Technology</a></li>
                <!--<li>Department of Mathematics and Computer Applications</li>-->
         
                  <li><a href="/computersciencedepartment/about.aspx">Department of Computer Science & Application </a></li>
                  <li><a href="/softwareengineeringdepartment/about.aspx">Department of Software Engineering</a></li>
                
              </ul>
            </div>
                        <div class="col_6">
              <h5>School of  Humanities, Science and Management(SHSM)</h5>
              <ul>
                <li><a href="/chemistrydepartment/about.aspx">Chemistry</a></li>
                <li><a href="/englishdepartment/about.aspx">English</a></li>
                <!--<li><a href="/mathematicsdepartment/about.aspx">Mathematics</a></li>-->
                <li><a href="/mathematicsdepartment/about.aspx">Department of Mathematics</a></li>
                <li><a href="/physicsdepartment/about.aspx">Physics</a></li>
                <li><a href="/managementstudiesdepartment/about.aspx">Management Studies</a></li>
                <li><a href="/educationdepartment/about.aspx">Education</a></li>
                <li><a href="/physicaleducationdepartment/faculty.aspx">Physical Education</a></li>
                <li><a href="javascript:void(0);">Commerce</a></li>
              </ul>
            </div>
                    </div>
                <!-- End Item Container -->
            </li>

            <li <%=BindUrlClass("Admissions") %>><a href="/admission2017-18.aspx" title="">Admissions</a>
                <!-- Begin Item -->
                   <%-- <div class="dropdown_container dropdown_2columns"><!-- Begin Item Container -->
    					<div class="col_12">
                        	<h5>Admissions</h5>
                            <ul>
                            <li><a href="/admissionprocedure.aspx">Admission Procedures</a></li>                               
                            <li><a href="/coursesoffered.aspx">Courses Offered</a></li>
                            <li><a href="/eligibility.aspx">Eligibility</a></li>
                            <li><a href="/coursefees.aspx">Course Fee</a></li>
                            <li><a href="/course.aspx">Intake For Each Course </a></li>
                            <li><a href="/UnigaugeExam-2017.aspx">Unigauge Exam - 2017</a></li>
                    <!--<li><a href="https://www.pmu.edu/admission/entrance_exam_index.html" target="_blank">Entrance Exam</a></li>-->
                            </ul>
                    	</div>
                    </div>--%>
                <!-- End Item Container -->
            </li>

           <%-- <li><a href="#" title="">Faculty</a>
                <!-- Begin Item -->
                    <div class="dropdown_container dropdown_2columns"><!-- Begin Item Container -->
    					<div class="col_12">
                        	<h5>Faculty</h5>
                            <ul>

                                <li><a href="#">About</a></li>
                                <li><a href="#">List of Faculties</a></li>
                            </ul>
                    	</div>
                    </div>
                <!-- End Item Container -->
            </li>--%>

            <li <%=BindUrlClass("Campus") %>><a href="#" title="">Campus</a>
                <!-- Begin Item -->
                    <div class="dropdown_container dropdown_3columns"><!-- Begin Item Container -->
    					<div class="col_12">
                        	<h5>Campus</h5>
                            <ul>

                                 <li><a href="/campus.aspx">Life at PMU</a></li>
                                <li><a href="/campusamenities.aspx">Campus Amenities</a></li>
                                <li><a href="/zero-carbon.aspx">Zero-Carbon Campus</a></li>
                                <li><a href="/hostel.aspx">Hostel</a></li>
                                <li><a href="/library.aspx">Library</a></li>
                                <li><a href="/studentassociation.aspx">Student Association</a></li>
                                <li><a href="/hospital.aspx">Periyar Maniammai Hospital</a></li>
                            </ul>
                    	</div>
                    </div>
                <!-- End Item Container -->

            </li>

            <li <%=BindUrlClass("Centres") %>><a href="#" title="">Centres</a>
                <!-- Begin Item -->
                    <div class="dropdown_container dropdown_5columns"><!-- Begin Item Container -->
    					<div class="col_12">
                        	<h5>Centres</h5>
                            <ul>

                                 <li><a href="/cuii.aspx">Centre For University Industry Interaction(CUII)</a></li>
                                <li><a href="/cpt.aspx">Centre For Periyar Thought(CPT)</a></li>
                                <li><a href="/crd.aspx">Centre for Rural Development(CRD)</a></li>
                                <li><a href="/ccc.aspx">Centre for climate change(CCC)</a></li>
                                 <li><a href="/cetat.aspx">Centre of Excellence for Training and Research in Automation Technologies(CETAT)</a></li>
                                <li><a href="/csas.aspx">Centre for Students and Administrative Services(CSAS)</a></li>
                                <li><a href="/kkcps.aspx">Dr.Kalaignar M.Karunanithi Centre for Political Science(KKCPS)</a></li>
                                <li><a href="/cenn.aspx">Centre of Excellence for Next Generation Networks(CNGN)</a></li>
                                <li><a href="/veeramanimohancentre.aspx">Veeramani Mohana Centre for Quality Life Engineering Research</a></li>
                                <li><a href="/ceerp.aspx">Centre of Excellence for Enterprise Resource Planning(CEERP)</a></li>
                                <li><a href="/periyardcentre.aspx">Periyar R & D Centre for Bio and Solar Energies</a></li>
                                <li><a href="/ptbi.aspx">Periyar Technology Business Incubator </a></li>
                            </ul>
                    	</div>
                    </div>
                <!-- End Item Container -->
            </li>
             <li><a href="gallery.aspx" title="">Gallery</a></li>

            <li <%=BindUrlClass("Research") %>><a href="#" title="">Research</a>
                <!-- Begin Item -->
                    <div class="dropdown_container dropdown_2columns"><!-- Begin Item Container -->
    					<div class="col_12">
                        	<h5>Research</h5>
                            <ul>
                            <li><a href="/reseachculture.aspx">The Research Culture</a></li>
                            <%--<li><a href="outcomebasedteaching.aspx">Outcome Based Teaching</a></li>--%>
                            <li><a href="/researchoutput.aspx">Research Output</a></li>
                            <%--<li><a href="phdapplication.aspx">Application for Ph.D</a></li>--%>
                            <li><a href="/researchdownloads.aspx">Downloads</a></li>
                            </ul>
                    	</div>
                    </div>
                <!-- End Item Container -->
            </li>

           <%-- <li><a href="#" title="">Alumni</a>
                <!-- Begin Item -->
                    <div class="dropdown_container dropdown_2columns"><!-- Begin Item Container -->
    					<div class="col_12">
                        	<h5>Alumni</h5>
                            <ul>
                                <li><a href="#">Activities</a></li>
                                <li><a href="#">Alumnus Speak</a></li>
                            </ul>
                    	</div>
                    </div>
                <!-- End Item Container -->

            </li>--%>

            <li><a href="#" title="">Contact</a>
                <!-- Begin Item -->
                    <div class="dropdown_container dropdown_13columns"><!-- Begin Item Container -->
    					<div class="col_12">
                        	<h5>Contact</h5>
                            <ul>
                                <li><a href="/contactus.aspx">Address</a></li>
                               <%-- <li><a href="#">Location Map</a></li>
                                <li><a href="#">Route Map</a></li>--%>
                                <li><a href="/informationcenters.aspx">Information Centers</a></li>
                            </ul>
                    	</div>
                    </div>
                <!-- End Item Container -->
            </li>
<!--<li><a href="finishingSchool.aspx" title="">Finishing School</a>
              <!-- Begin Item -->
              <!--<div class="dropdown_container dropdown_13columns">
                <div class="col_12">
                  <h5>Results</h5>
                  <ul>
                    <li><a href="finishingSchool.aspx"> Finishing School</a></li>
                  </ul>
                </div>
              </div>-->
              <!-- End Item Container
            </li>-->
        </ul>

    </div>
  </div>
  </div>
