<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gallery2.aspx.cs" Inherits="gallery" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!--[if lt IE 7]> <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang="en"> <![endif]-->
<!--[if IE 7]> <html class="no-js lt-ie9 lt-ie8" lang="en"> <![endif]-->
<!--[if IE 8]> <html class="no-js lt-ie9" lang="en"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js" lang="en">
<!--<![endif]-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta charset="UTF-8">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<!--[if IE]><meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1'><![endif]-->
<meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no">
<meta name="keywords" content="Test Message, Test Message, Test Message, Test Message" />
<meta name="description" content="Test Message, Test Message, Test Message, Test Message" />
<!--[if IE]><meta http-equiv="Cache-control" content="public"/><![endif]-->
<!-- html5.js for IE less than 9 -->
<!--[if lt IE 9]>
	<script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
<![endif]-->
<title>Periyar Maniammai University</title>
<link href="css/reset.css" rel="stylesheet">
<link href="css/grid.css" rel="stylesheet">
<link href='http://fonts.googleapis.com/css?family=Roboto+Condensed' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=PT+Sans' rel='stylesheet' type='text/css'>
<link href="css/common.css" rel="stylesheet">
<link rel="stylesheet" href="css/mgmenu.css" type="text/css" media="screen" />
<link href="css/responsive.css" rel="stylesheet">
<link rel="stylesheet" href="css/jquery.fancybox.css" media="screen" />
<link rel="stylesheet" type="text/css" href="css/jquery.fancybox-thumbs.css" />
</head>
<body class="inner">
<form id="form1" runat="server">
  <div id="main-wrapper">
    <noscript>
    <div class="global-site-notice noscript">
      <div class="notice-inner">
        <p> <strong>JavaScript seems to be disabled in your browser.</strong> <br />
          You must have JavaScript enabled in your browser to utilize the functionality of this website.<br />
          <a href="http://support.microsoft.com/gp/howtoscript" target="_blank">Click here</a> to Enable. </p>
      </div>
    </div>
    </noscript>
    
    <!-- Header -->
    <header id="header-main">
      <div class="container-12">
        <div class="grid-2">
          <div class="logo"> <a href="index.aspx" title="Periyar Maniammai University"> <img src="images/icons/inner-logo.png" alt="Periyar Maniammai University" /></a> </div>
        </div>
        <div class="grid-10 right-menu"> <a href="http://pmu.edu/admission2017-18/Registration.aspx" target="_blank" class="apply">Apply Now</a>
          <div id="mgmenu1" class="mgmenu_container">
            <ul class="mgmenu">
              <li class="mgmenu_button">Menu</li>
              <!-- Button (Mobile Devices) -->
              
              <li  ><a href="index.aspx" title="">Home</a></li>
              <li ><a href="#" title="">About Us</a> 
                <!-- Begin Item -->
                <div class="dropdown_container dropdown_2columns"><!-- Begin Item Container -->
                  <div class="col_12">
                    <h5>About PMU</h5>
                    <ul>
                      <li><a href="aboutpmu.aspx">About</a></li>
                      <li><a href="pmuhistory.aspx">History</a></li>
                      <li><a href="management.aspx">Management</a></li>
                      <li><a href="committees.aspx">Committee</a></li>
                      <li><a href="Statutorybodies.aspx">Statutory bodies</a></li>
                      <li><a href="academic.aspx">Academic</a></li>
                      <li><a href="placement/placement_2016/index.html">Placements</a></li>
                      <li><a href="byelawsandconstitution.aspx">Bye-Laws & Constitution</a></li>
                    </ul>
                  </div>
                </div>
                <!-- End Item Container --> 
              </li>
              <!-- End Item -->
              
              <li><a href="#" title="">Programs</a> 
                <!-- Begin Item -->
                <div class="dropdown_container dropdown_9columns"><!-- Begin Item Container -->
                  
                  <div class="col_6">
                    <h5>School of Architecture and Planning (SAP)</h5>
                    <ul>
                      <li><a href="architecturedepartment/about.aspx">Department of Architecture</a></li>
                    </ul>
                    <%--</div>


                <div class="col_6">--%>
                    <h5>School of Engineering and Technology(SET)</h5>
                    <ul>
                      <li><a href="aerospacedepartment/about.aspx">Department of Aerospace Engineering</a></li>
                      <li><a href="biotechnologyDepartment/about.aspx">Department of Bio-Technology</a></li>
                      <li><a href="chemicalengineeringdepartment/about.aspx">Department of Chemical Engineering</a></li>
                      <li><a href="civilengineeringdepartment/about.aspx">Department of Civil Engineering</a></li>
                      <li><a href="electronicsandcommunicationdepartment/about.aspx">Department of Electronics and Communication Engineering</a></li>
                      <li><a href="electricalandelectronicsdepartment/about.aspx">Department of Electrical and Electronics Engineering</a></li>
                      <li><a href="mechanicalengineeringdepartment/about.aspx">Department of Mechanical Engineering</a></li>
                      <li><a href="nanotechnology/about.aspx">Nanotechnology Division</a></li>
                    </ul>
                  </div>
                  <div class="col_6">
                    <h5>School of Computing Sciences and Engineering(SCSE)</h5>
                    <ul>
                      <li><a href="computerscienceandengineeringdepartment/about.aspx">Department of Computer Science and Engineering</a></li>
                      <li><a href="informationtechnologydepartment/about.aspx">Department of Information Technology</a></li>
                      <li>Department of Mathematics and Computer Applications
                        <ul>
                          <li><a href="computersciencedepartment/about.aspx">Computer Applications Division</a></li>
                          <li><a href="softwareengineeringdepartment/about.aspx">Software Engineering Division</a></li>
                          <li><a href="mathematicsdepartment/about.aspx">Mathematics Division</a></li>
                        </ul>
                      </li>
                    </ul>
                  </div>
                  <div class="col_6">
                    <h5>School of  Humanities, Science and Management(SHSM)</h5>
                    <ul>
                      <li><a href="chemistrydepartment/about.aspx">Chemistry</a></li>
                      <li><a href="englishdepartment/about.aspx">English</a></li>
                      <li><a href="mathematicsdepartment/about.aspx">Mathematics</a></li>
                      <li><a href="physicsdepartment/about.aspx">Physics</a></li>
                      <li><a href="managementstudiesdepartment/about.aspx">Management Studies</a></li>
                      <li><a href="educationdepartment/about.aspx">Education</a></li>
                      <li><a href="physicaleducationdepartment/about.aspx">Physical Education</a></li>
                    </ul>
                  </div>
                </div>
                <!-- End Item Container --> 
              </li>
              <li ><a href="admission2017-18.aspx" title="">Admissions</a> 
                <!--<div class="dropdown_container dropdown_2columns">                 
    					<div class="col_12">
                        	<h5>Admissions</h5>
                            <ul>
                            <li><a href="admissionprocedure.aspx">Admission Procedures</a></li>                               
                            <li><a href="coursesoffered.aspx">Courses Offered</a></li>
                    <li><a href="eligibility.aspx">Eligibility</a></li>
                    <li><a href="coursefees.aspx">Course Fee</a></li>
                      <li><a href="course.aspx">Intake For Each Course </a></li>
                      <li><a href="UnigaugeExam-2017.aspx">Unigauge Exam - 2017</a></li>
                    <li><a href="http://www.pmu.edu/admission/entrance_exam_index.html" target="_blank">Entrance Exam</a></li>
                            </ul> 
                    	</div>
                    </div>--> 
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
              <li ><a href="#" title="">Campus</a> 
                <!-- Begin Item -->
                <div class="dropdown_container dropdown_3columns"><!-- Begin Item Container -->
                  <div class="col_12">
                    <h5>Campus</h5>
                    <ul>
                      <li><a href="campus.aspx">Life at PMU</a></li>
                      <li><a href="campusamenities.aspx">Campus Amenities</a></li>
                      <li><a href="zero-carbon.aspx">Zero-Carbon Campus</a></li>
                      <li><a href="hostel.aspx">Hostel</a></li>
                      <li><a href="library.aspx">Library</a></li>
                      <li><a href="studentassociation.aspx">Student Association</a></li>
                      <li><a href="hospital.aspx">Periyar Maniammai Hospital</a></li>
                    </ul>
                  </div>
                </div>
                <!-- End Item Container --> 
                
              </li>
              <li><a href="#" title="">Centres</a> 
                <!-- Begin Item -->
                <div class="dropdown_container dropdown_5columns"><!-- Begin Item Container -->
                  <div class="col_12">
                    <h5>Centres</h5>
                    <ul>
                      <li><a href="cuii.aspx">Centre For University Industry Interaction(CUII)</a></li>
                      <li><a href="cpt.aspx">Centre For Periyar Thought(CPT)</a></li>
                      <li><a href="crd.aspx">Centre for Rural Development(CRD)</a></li>
                      <li><a href="ccc.aspx">Centre for climate change(CCC)</a></li>
                      <li><a href="cetat.aspx">Centre of Excellence for Training and Research in Automation Technologies(CETAT)</a></li>
                      <li><a href="csas.aspx">Centre for Students and Administrative Services(CSAS)</a></li>
                      <li><a href="kkcps.aspx">Dr.Kalaignar M.Karunanithi Centre for Political Science(KKCPS)</a></li>
                      <li><a href="cenn.aspx">Centre of Excellence for Next Generation Networks(CENN)</a></li>
                      <li><a href="veeramanimohancentre.aspx">Veeramani Mohana Centre for Quality Life Engineering Research</a></li>
                      <li><a href="ceerp.aspx">Centre of Excellence for Enterprise Resource Planning(CEERP)</a></li>
                      <li><a href="periyardcentre.aspx">Periyar R & D Centre for Bio and Solar Energies</a></li>
                      <li><a href="ptbi.aspx">Periyar Technology Business Incubator </a></li>
                    </ul>
                  </div>
                </div>
                <!-- End Item Container --> 
              </li>
              <li class="active"><a href="gallery.aspx" title="">Gallery</a></li>
              <li><a href="#" title="">Research</a> 
                <!-- Begin Item -->
                <div class="dropdown_container dropdown_2columns"><!-- Begin Item Container -->
                  <div class="col_12">
                    <h5>Research</h5>
                    <ul>
                      <li><a href="reseachculture.aspx">The Research Culture</a></li>
                      <li><a href="outcomebasedteaching.aspx">Outcome Based Teaching</a></li>
                      <li><a href="researchoutput.aspx">Research Output</a></li>
                      <li><a href="phdapplication.aspx">Application for Ph.D</a></li>
                      <li><a href="researchdownloads.aspx">Downloads</a></li>
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
                      <li><a href="contactus.aspx">Address</a></li>
                      <%-- <li><a href="#">Location Map</a></li>
                                <li><a href="#">Route Map</a></li>--%>
                      <li><a href="informationcenters.aspx">Information Centers</a></li>
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
    </header>
    
    <!-- Banner -->
    <div id="banner-main">
      <div class="container-12">
        <div class="grid-12"> <img src="images/banner/inner-1.jpg" alt="Banner" /> </div>
      </div>
    </div>
    
    <!-- Body -->
    <div id="body-main">
      <div class="apply-wrap">
        <%--	<a href="#" class="apply">Apply Now</a>--%>
      </div>
      <div class="container-12">
        <div class="grid-12">
          <div class="content-section no-padding">
            <div class="breadcrumb">
              <ul>
                <li><a href="index.aspx" title="Home">Home</a></li>
                /
                <li>Gallery</li>
              </ul>
            </div>
            <nav>
              <ul class="media">
                <li class="active"><a href="gallery.aspx"><span class="icon-gallery">Gallery</span></a></li>
                <li><a href="videos.aspx"><span class="icon-video">Videos</span></a></li>
              </ul>
            </nav>
            <div class="clear"></div>
            <div class="media-content">
              <nav>
                <ul class="media-list">
                	<li> <a id="ak" href="javascript:void(0)"> <img src="images/tho.jpg" /></a>
                    <p>Achievement in AK Edusat 2017</p>
                  	</li>
                
                  <li> <a id="pppm" href="javascript:void(0)"> <img src="images/img-06.jpg" /></a>
                    <p>Periyar Pinchu Pazhagu Mugaam 2017 </p>
                  </li>
                  <li> <a id="bokday" href="javascript:void(0)"> <img src="images/img-02.jpg" /></a>
                    <p>World Book Days Photos</p>
                  </li>
                  <li> <a id="vetri" href="javascript:void(0)"> <img src="gallery/Vetrinichayam/4.jpg" /></a>
                    <p>Vetri Nichayam - Thanjavur & Trichy </p>
                  </li>
                  <li> <a id="cetw" href="javascript:void(0)"> <img src="gallery/CETW-2017/1.JPG" alt="" /></a>
                    <p>Civil Engineering Technical Work shop 2017</p>
                  </li>
                  <li> <a id="nylp" href="javascript:void(0)"> <img src="gallery/NYLP/1.JPG" alt="" /></a>
                    <p>National Young Leaders Programme Award</p>
                  </li>
                  <li> <a id="AD-17" href="javascript:void(0)"> <img src="gallery/29th-Annual-Day/1.JPG" alt="" /></a>
                    <p>29th Annual Day - 2017</p>
                  </li>
                  <li> <a id="AMB" href="javascript:void(0)"> <img src="gallery/AMB/1.JPG" alt="" /></a>
                    <p>Annai Maniammaiyar Birthday and International Womens day</p>
                  </li>
                  <li> <a id="IC" href="javascript:void(0)"> <img src="gallery/IC/Thum.JPG" alt="" /></a>
                    <p>International Conference - 2017</p>
                  </li>
                  <li> <a id="P-17" href="javascript:void(0)"> <img src="gallery/P-17/Thum.JPG" alt="" /></a>
                    <p>Peace - 2017 </p>
                  </li>
                  <li> <a id="ASD-17" href="javascript:void(0)"> <img src="gallery/ASD-17/Thum.JPG" alt="" /></a>
                    <p>Annual Sports Day - 2017</p>
                  </li>
                  <li><a id="fancy-manual-24thConvocation" href="javascript:;"> <img src="gallery/24thConvocation/58.JPG" alt="" /></a>
                    <p>24th Convocation 2016</p>
                  </li>
                  <li><a id="fancybox-manual-openhse-2016" href="javascript:;"> <img src="gallery/openhouse2016/1.JPG" alt="" /></a>
                    <p>Open House 2016</p>
                  </li>
                  <li><a id="fancybox-manual-malaysia" href="javascript:;"> <img src="gallery/malaysiaguestvisit/1.jpg" alt="" /></a>
                    <p>Malaysia Guest Visit</p>
                  </li>
                  <li><a id="fancybox-manual-marathon" href="javascript:;"> <img src="gallery/marathon1.jpg" alt="" /></a>
                    <p>Green Marathon - 2016</p>
                  </li>
                  <li><a id="fancybox-manual-sportsday" href="javascript:;"> <img src="gallery/sportsday-thumb.jpg" alt="" /></a>
                    <p>Sports Day-2016</p>
                  </li>
                  <li><a id="fancybox-manual-convocation16" href="javascript:;"> <img src="gallery/convocation16.jpg" alt="" /></a>
                    <p>23rd Convocation 2016 </p>
                  </li>
                  <li><a id="fancybox-manual-Russia" href="javascript:;"> <img src="gallery/Russia.jpg" alt="" /></a>
                    <p>Certificate Awarding Function </p>
                  </li>
                  <li><a id="fancybox-manual-peace" href="javascript:;"> <img src="gallery/peace-thumb.jpg" alt="" /></a>
                    <p>Peace-2016</p>
                  </li>
                  <li><a id="fancybox-manual-ie1" href="javascript:;"> <img src="gallery/ie1-thumb.jpg" alt="" /></a>
                    <p>Inauguration of IEI in Thanjavur </p>
                  </li>
                  <li><a id="fancybox-manual-birthday" href="javascript:;"> <img src="gallery/birthday-thumb.jpg" alt="" /></a>
                    <p>Esteemed Chancellor's Birthday </p>
                  </li>
                  <li><a id="fancybox-manual-meet" href="javascript:;"> <img src="gallery/welcomemeetup-thumb.jpg" alt="" /></a>
                    <p>Freshers Welcome Meet - 2015</p>
                  </li>
                  <li><a id="fancybox-manual-Annualday" href="javascript:;"> <img src="gallery/Annualday-thumb.jpg" alt="" /></a>
                    <p>Annual Day-2015</p>
                  </li>
                  <li><a id="fancybox-manual-FormersProducerMeeting" href="javascript:;"> <img src="gallery/Formers_Producer_Meetingy_thumb.jpg" alt="" /></a>
                    <p>Dr.APJ Abdul Kalam-Farmer's Meet 2015</p>
                  </li>
                  <%--   <li><a id="fancybox-manual-sportsday" href="javascript:;">
                                                        <img src="gallery/sportsday-thumb.jpg" alt="" /></a>
                                                        <p>Sports Day-2015</p></li>--%>
                  <%--        <li><a id="fancybox-manual-peace" href="javascript:;">
                                                            <img src="gallery/peace-thumb.jpg" alt="" /></a>
                                                            <p>Peace-2015</p></li>--%>
                  <%--                                                            <li><a id="fancybox-manual-co" href="javascript:;">
                                                                <img src="gallery/convocation-thumb.jpg" alt="" /></a>
                                                                <p>Convocation-2015</p> </li>--%>
                  <li><a id="fancybox-manual-g" href="javascript:;"> <img src="gallery/innaguration-thumb.jpg" alt="" /></a>
                    <p>Open House 2015 - Inauguration</p>
                  </li>
                  
                  <!-- <li><a id="fancybox-manual-h" href="javascript:;"><img src="gallery/event-thumb.jpg" alt="" /></a>
                        <p>Open House 2015 - The Event</p>
                        </li>-->
                  <li><a id="fancybox-manual-i" href="javascript:;"> <img src="gallery/ValedictoryFunction-thumb.jpg" alt="" /></a>
                    <p>Open House 2015 - Valedictory Function</p>
                  </li>
                  <li><a id="fancybox-manual-a" href="javascript:;"> <img src="gallery/aerofest-thumb.jpg" alt="" /></a>
                    <p>Aero Fest</p>
                  </li>
                  <li><a id="fancybox-manual-b" href="javascript:;"> <img src="gallery/agrofest-thumb.jpg" alt="" /></a>
                    <p>Agro Tech</p>
                  </li>
                  <li><a id="fancybox-manual-c" href="javascript:;"> <img src="gallery/alumnimeet-thumb.jpg" alt="" /></a>
                    <p>Alumni Meet</p>
                  </li>
                  <%--     <li><a id="fancybox-manual-d" href="javascript:;"><img src="gallery/ictfest-thumb.jpg" alt="" /></a>
                        <p>ICT Fest</p>--%>
                  <%-- </li>--%>
                  <li><a id="fancybox-manual-e" href="javascript:;"> <img src="gallery/idms-thumb.jpg" alt="" /></a>
                    <p>IDMS</p>
                  </li>
                  <li><a id="fancybox-manual-f" href="javascript:;"> <img src="gallery/iste-thumb.jpg" alt="" /></a>
                    <p>ISTE Convention</p>
                  </li>
                </ul>
              </nav>
              <div class="clear"></div>
            </div>
          </div>
        </div>
      </div>
    </div>
    
    <!-- Footer -->
    <footer id="footer-main">
      <div class="container-12">
        <div class="grid-3"> &copy; 2016 Periyar Maniammai University </div>
        <div class="grid-3">
          <nav>
            <ul class="list-inline other-links">
              <li><a href="http://www.ugc.ac.in/" target="_blank" title="UGC">UGC</a></li>
              |
              <li><a href="http://www.nba-india.org/" target="_blank" title="NBA">NBA</a></li>
              |
              <li><a href="http://www.periyartbi.org/" target="_blank" title="Periyar TBI">Periyar TBI</a></li>
              |
              <li><a href="http://www.periyarpura.org.in/" target="_blank" title="PURA">PURA</a></li>
              |
              <li><a href="http://www.pmu.edu/gscash.aspx" target="_blank" title="GSCASH">Grievance Committee</a></li>
              |
              <li><a href="PDF/ugc.pdf" target="_blank" title="UGC">UGC - Sexual Harassment of Women</a></li>
              |
              <li><a href="PDF/Sexual Harassment Regulations 2015.pdf" target="_blank">Prevention of Sexual Harassment</a></li>
              |
              <li><a href="http://www.mhrdnats.gov.in/" target="_blank">NATS </a></li>
              |
              <li><a href="PDF/AQAR.pdf" target="_blank">AQAR </a></li>
              |
              <li><a href="../PDF/Commonwealth-scholarship.pdf" target="_blank">UGC Commonwealth Scholarship</a></li>
            </ul>
          </nav>
        </div>
        <div class="grid-3">
          <nav>
            <ul class="list-inline other-links">
              <li><a href="termsandconditions.aspx" title="terms ">Terms & Conditions</a></li>
              |
              <li><a href="termsandconditions.aspx" title="Privacy">Privacy</a></li>
              |
              <li><a href="termsandconditions.aspx" title="Refund">Refund Policy</a></li>
            </ul>
          </nav>
        </div>
        <div class="grid-3"> <a href="http://parampriti.com/" target="_blank">Parampriti</a> </div>
      </div>
    </footer>
  </div>
  <div class="social-right">
    <nav>
      <ul class="list-block">
        <li><a href="http://www.facebook.com/pmuniv" target="_blank"> <img src="images/soc/fb.jpg" alt="" /></a></li>
        <li><a href="http://www.youtube.com/periyarmaniammai" target="_blank"> <img src="images/soc/yt.jpg" alt="" /></a></li>
        <li><a href="https://plus.google.com/u/0/+PmuEducation/videos" target="_blank"> <img src="images/soc/gp.jpg" alt="" /></a></li>
        <li><a href="http://twitter.com/#!/pmuedu" target="_blank"> <img src="images/soc/tw.jpg" alt="" /></a></li>
        <li><a href="https://www.linkedin.com/company/periyar-maniammai-university" target="_blank"><img src="images/soc/li.jpg" alt=""></a></li>
      </ul>
    </nav>
  </div>
  <script src="js/jquery-1.9.0.min.js" type="text/javascript"></script> 
  <script src="js/scripts.js"></script> 
  <script src="js/css3-mediaqueries.js" type="text/javascript"></script> 
  <script src="js/jquery.easing.1.3.min.js" type="text/javascript"></script> 
  <script>
            $(document).ready(function ($) {
                $('#mgmenu1').universalMegaMenu({
                    menu_effect: 'hover_fade',
                    menu_speed_show: 300,
                    menu_speed_hide: 200,
                    menu_speed_delay: 200,
                    menu_click_outside: false,
                    menubar_trigger: false,
                    menubar_hide: false,
                    menu_responsive: true
                });
                megaMenuContactForm();
            });
        </script> 
  <script type="text/javascript" src="js/jquery.fancybox.js"></script> 
  <script type="text/javascript" src="js/jquery.fancybox-thumbs.js"></script> 
  <script type="text/javascript">
            $(document).ready(function () {
                $('.fancybox').fancybox();
				
				$("#ak").click(function () {
                    $.fancybox.open([
                            {
                                href: 'images/tho.jpg',
                                title: ''
                            },
							{
                                href: 'images/theen.jpg',
                                title: ''
                            },
							{
                                href: 'images/shar.jpg',
                                title: ''
                            },
							
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
				
				$("#pppm").click(function () {
                    $.fancybox.open([
                            {
                                href: 'images/img-06.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-07.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-08.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-09.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-10.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-11.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-12.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-13.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-14.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-15.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-16.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-17.jpg',
                                title: ''
                            },
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
				
				$("#bokday").click(function () {
                    $.fancybox.open([
                            {
                                href: 'images/img-02.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-03.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-04.jpg',
                                title: ''
                            },
							{
                                href: 'images/img-05.jpg',
                                title: ''
                            },
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
					
				
					
				$("#vetri").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/Vetrinichayam/1.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/2.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/3.jpg',
                                title: ''
                            },
						{
                                href: 'gallery/Vetrinichayam/4.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/5.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/6.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/7.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/8.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/9.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/10.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/11.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/12.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/13.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/14.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/15.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/16.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/17.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/18.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/19.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/20.png',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/21.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/22.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/23.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/24.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/Vetrinichayam/25.jpg',
                                title: ''
                            },
							
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
				
				$("#cetw").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/CETW-2017/1.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/CETW-2017/2.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/CETW-2017/3.jpg',
                                title: ''
                            },
							
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
				
				$("#nylp").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/NYLP/1.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/NYLP/2.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/NYLP/3.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/NYLP/4.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/NYLP/5.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/NYLP/6.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/NYLP/7.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/NYLP/8.jpg',
                                title: ''
                            },
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
				
				$("#AD-17").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/29th-Annual-Day/1.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/2.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/3.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/4.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/5.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/6.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/7.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/8.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/9.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/10.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/11.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/12.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/13.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/14.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/29th-Annual-Day/15.jpg',
                                title: ''
                            },
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
				
				$("#AMB").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/AMB/1.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/AMB/2.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/AMB/3.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/AMB/4.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/AMB/5.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/AMB/6.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/AMB/7.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/AMB/8.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/AMB/9.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/AMB/10.jpg',
                                title: ''
                            },
							
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
				
				$("#IC").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/IC/Thum.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/IC/2.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/IC/3.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/IC/4.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/IC/5.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/IC/6.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/IC/7.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/IC/8.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/IC/10.jpg',
                                title: ''
                            },
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
					
					$("#P-17").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/P-17/Thum.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/P-17/2.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/P-17/3.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/P-17/4.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/P-17/5.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/P-17/6.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/P-17/7.jpg',
                                title: ''
                            },
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
					
					$("#ASD-17").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/ASD-17/Thum.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/2.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/3.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/4.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/5.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/6.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/7.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/8.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/9.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/10.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/11.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/12.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/13.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/14.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/15.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/16.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/17.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/18.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/19.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/20.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/21.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/22.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/ASD-17/24.jpg',
                                title: ''
                            },
							], 
							{
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    	});
					});
					
					
					
					
					
					
					
					

                      $("#fancy-manual-24thConvocation").click(function () {
                    $.fancybox.open([
                        
                            {
                                href: 'gallery/24thConvocation/1.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/2.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/4.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/5.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/6.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/7.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/8.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/9.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/10.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/11.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/12.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/13.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/14.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/15.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/16.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/17.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/18.jpg',
                                title: ''
                            },
                             {
                                href: 'gallery/24thConvocation/19.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/20.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/21.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/22.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/23.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/24.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/25.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/26.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/27.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/28.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/29.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/30.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/31.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/32.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/33.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/34.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/35.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/36.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/37.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/38.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/39.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/40.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/41.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/42.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/43.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/44.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/45.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/46.jpg',
                                title: ''
                            },
                                    {
                                href: 'gallery/24thConvocation/47.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/48.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/49.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/50.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/51.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/52.jpg',
                                title: ''
                            },
                                           {
                                href: 'gallery/24thConvocation/53.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/54.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/55.jpg',
                                title: ''
                            },
                                           {
                                href: 'gallery/24thConvocation/56.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/57.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/24thConvocation/58.jpg',
                                title: ''
                            }
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });

                $("#fancybox-manual-convocation16").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/Convocation2016/DSC_0002.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Convocation2016/DSC_0023.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Convocation2016/DSC_0025.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0026.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0027.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0028.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0029.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0030.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0031.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0032.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0034.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/Convocation2016/DSC_0035.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0037.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0039.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0042.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation2016/DSC_0044.jpg',
                                title: ''
                            },
                             {
                                 href: 'gallery/Convocation2016/DSC_0045.jpg',
                                 title: ''
                             },
                              {
                                  href: 'gallery/Convocation2016/DSC_0046.jpg',
                                  title: ''
                              },
                               {
                                   href: 'gallery/Convocation2016/DSC_0047.jpg',
                                   title: ''
                               },
                            {
                                href: 'gallery/Convocation2016/DSC_0048.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/Convocation2016/DSC_0049.jpg',
                                title: ''
                            },
                             {
                                 href: 'gallery/Convocation2016/DSC_0050.jpg',
                                 title: ''
                             },


                            {
                                href: 'gallery/Convocation2016/DSC_0051.jpg',
                                title: ''
                            },

                             {
                                 href: 'gallery/Convocation2016/DSC_0052.jpg',
                                 title: ''
                             },
                              {
                                  href: 'gallery/Convocation2016/DSC_0053.jpg',
                                  title: ''
                              },
                              {
                                  href: 'gallery/Convocation2016/DSC_0056.jpg',
                                  title: ''
                              },
                               {
                                   href: 'gallery/Convocation2016/DSC_0057.jpg',
                                   title: ''
                               },
                                {
                                    href: 'gallery/Convocation2016/DSC_0058.jpg',
                                    title: ''
                                },
                                 {
                                     href: 'gallery/Convocation2016/DSC_0059.jpg',
                                     title: ''
                                 },
                                  {
                                      href: 'gallery/Convocation2016/DSC_0061.jpg',
                                      title: ''
                                  },

                                    {
                                        href: 'gallery/Convocation2016/DSC_0064.jpg',
                                        title: ''
                                    },
                                      {
                                          href: 'gallery/Convocation2016/DSC_0066.jpg',
                                          title: ''
                                      },

                                        {
                                            href: 'gallery/Convocation2016/DSC_0068.jpg',
                                            title: ''
                                        },

                                          {
                                              href: 'gallery/Convocation2016/DSC_0069.jpg',
                                              title: ''
                                          },

                                            {
                                                href: 'gallery/Convocation2016/DSC_0070.jpg',
                                                title: ''
                                            },
                                              {
                                                  href: 'gallery/Convocation2016/DSC_0071.jpg',
                                                  title: ''
                                              },
                                               {
                                                   href: 'gallery/Convocation2016/DSC_0072.jpg',
                                                   title: ''
                                               },
                                                {
                                                    href: 'gallery/Convocation2016/DSC_0073.jpg',
                                                    title: ''
                                                },
                                                 {
                                                     href: 'gallery/Convocation2016/DSC_0074.jpg',
                                                     title: ''
                                                 },
                                                  {
                                                      href: 'gallery/Convocation2016/DSC_0077.jpg',
                                                      title: ''
                                                  },
                                                   {
                                                       href: 'gallery/Convocation2016/DSC_0078.jpg',
                                                       title: ''
                                                   },
                                                    {
                                                        href: 'gallery/Convocation2016/DSC_0080.jpg',
                                                        title: ''
                                                    },
                                                     {
                                                         href: 'gallery/Convocation2016/DSC_0081.jpg',
                                                         title: ''
                                                     },
                                                      {
                                                          href: 'gallery/Convocation2016/DSC_0084.jpg',
                                                          title: ''
                                                      },
                                                       {
                                                           href: 'gallery/Convocation2016/DSC_0085.jpg',
                                                           title: ''
                                                       },
                                                        {
                                                            href: 'gallery/Convocation2016/DSC_0086.jpg',
                                                            title: ''
                                                        },
                                                         {
                                                             href: 'gallery/Convocation2016/DSC_0087.jpg',
                                                             title: ''
                                                         },
                                                          {
                                                              href: 'gallery/Convocation2016/DSC_0088.jpg',
                                                              title: ''
                                                          },
                                                           {
                                                               href: 'gallery/Convocation2016/DSC_0089.jpg',
                                                               title: ''
                                                           },
                                                            {
                                                                href: 'gallery/Convocation2016/DSC_0090.jpg',
                                                                title: ''
                                                            },
                                                             {
                                                                 href: 'gallery/Convocation2016/DSC_0091.jpg',
                                                                 title: ''
                                                             },
                                                              {
                                                                  href: 'gallery/Convocation2016/DSC_0092.jpg',
                                                                  title: ''
                                                              },
                                                               {
                                                                   href: 'gallery/Convocation2016/DSC_0093.jpg',
                                                                   title: ''
                                                               },
                                                                {
                                                                    href: 'gallery/Convocation2016/DSC_0094.jpg',
                                                                    title: ''
                                                                },
                                                                 {
                                                                     href: 'gallery/Convocation2016/DSC_0095.jpg',
                                                                     title: ''
                                                                 },
                                                                  {
                                                                      href: 'gallery/Convocation2016/DSC_0096.jpg',
                                                                      title: ''
                                                                  },
                                                                   {
                                                                       href: 'gallery/Convocation2016/DSC_0097.jpg',
                                                                       title: ''
                                                                   },
                                                                   {
                                                                       href: 'gallery/Convocation2016/DSC_0098.jpg',
                                                                       title: ''
                                                                   },
                                                                   {
                                                                       href: 'gallery/Convocation2016/DSC_0099.jpg',
                                                                       title: ''
                                                                   },
                                                                   {
                                                                       href: 'gallery/Convocation2016/DSC_0100.jpg',
                                                                       title: ''
                                                                   },
                                                                     {
                                                                         href: 'gallery/Convocation2016/DSC_0101.jpg',
                                                                         title: ''
                                                                     },
                                                                       {
                                                                           href: 'gallery/Convocation2016/DSC_0102.jpg',
                                                                           title: ''
                                                                       },
                                                                         {
                                                                             href: 'gallery/Convocation2016/DSC_0103.jpg',
                                                                             title: ''
                                                                         },
                                                                           {
                                                                               href: 'gallery/Convocation2016/DSC_0104.jpg',
                                                                               title: ''
                                                                           },
                                                                             {
                                                                                 href: 'gallery/Convocation2016/DSC_0105.jpg',
                                                                                 title: ''
                                                                             },
                                                                               {
                                                                                   href: 'gallery/Convocation2016/DSC_0106.jpg',
                                                                                   title: ''
                                                                               },
                                                                                 {
                                                                                     href: 'gallery/Convocation2016/DSC_0107.jpg',
                                                                                     title: ''
                                                                                 },
                                                                                   {
                                                                                       href: 'gallery/Convocation2016/DSC_0108.jpg',
                                                                                       title: ''
                                                                                   },
                                                                                     {
                                                                                         href: 'gallery/Convocation2016/DSC_0109.jpg',
                                                                                         title: ''
                                                                                     },
                                                                                       {
                                                                                           href: 'gallery/Convocation2016/DSC_0110.jpg',
                                                                                           title: ''
                                                                                       },
                                                                                         {
                                                                                             href: 'gallery/Convocation2016/DSC_0111.jpg',
                                                                                             title: ''
                                                                                         },
                                                                                           {
                                                                                               href: 'gallery/Convocation2016/DSC_0112.jpg',
                                                                                               title: ''
                                                                                           },
                                                                                             {
                                                                                                 href: 'gallery/Convocation2016/DSC_0113.jpg',
                                                                                                 title: ''
                                                                                             },
                                                                                               {
                                                                                                   href: 'gallery/Convocation2016/DSC_0114.jpg',
                                                                                                   title: ''
                                                                                               },
                                                                                                 {
                                                                                                     href: 'gallery/Convocation2016/DSC_0115.jpg',
                                                                                                     title: ''
                                                                                                 },
                                                                                                   {
                                                                                                       href: 'gallery/Convocation2016/DSC_0116.jpg',
                                                                                                       title: ''
                                                                                                   },
                                                                                                     {
                                                                                                         href: 'gallery/Convocation2016/DSC_0117.jpg',
                                                                                                         title: ''
                                                                                                     },
                                                                                                       {
                                                                                                           href: 'gallery/Convocation2016/DSC_0118.jpg',
                                                                                                           title: ''
                                                                                                       },
                                                                                                         {
                                                                                                             href: 'gallery/Convocation2016/DSC_0119.jpg',
                                                                                                             title: ''
                                                                                                         },
                                                                                                           {
                                                                                                               href: 'gallery/Convocation2016/DSC_0121.jpg',
                                                                                                               title: ''
                                                                                                           },
                                                                                                             {
                                                                                                                 href: 'gallery/Convocation2016/DSC_0122.jpg',
                                                                                                                 title: ''
                                                                                                             },
                                                                                                               {
                                                                                                                   href: 'gallery/Convocation2016/DSC_0123.jpg',
                                                                                                                   title: ''
                                                                                                               },
                                                                                                                 {
                                                                                                                     href: 'gallery/Convocation2016/DSC_0124.jpg',
                                                                                                                     title: ''
                                                                                                                 },
                                                                                                                   {
                                                                                                                       href: 'gallery/Convocation2016/DSC_0125.jpg',
                                                                                                                       title: ''
                                                                                                                   },
                                                                                                                     {
                                                                                                                         href: 'gallery/Convocation2016/DSC_0139.jpg',
                                                                                                                         title: ''
                                                                                                                     }   

                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });


                

                $("#fancybox-manual-Russia").click(function () {
                    $.fancybox.open([
                        
                            {
                                href: 'gallery/Russian_course/DSC_0172.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Russian_course/DSC_0174.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Russian_course/DSC_0176.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Russian_course/DSC_0177.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Russian_course/DSC_0178.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Russian_course/DSC_0179.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Russian_course/DSC_0180.jpg',
                                title: ''
                            },
                             {
                                 href: 'gallery/Russian_course/DSC_0181.jpg',
                                 title: ''
                             },
                              {
                                  href: 'gallery/Russian_course/DSC_0182.jpg',
                                  title: ''
                              },
                               {
                                   href: 'gallery/Russian_course/DSC_0183.jpg',
                                   title: ''
                               },
                                {
                                    href: 'gallery/Russian_course/DSC_0184.jpg',
                                    title: ''
                                },
                                 {
                                     href: 'gallery/Russian_course/DSC_0185.jpg',
                                     title: ''
                                 },
                                  {
                                      href: 'gallery/Russian_course/DSC_0186.jpg',
                                      title: ''
                                  }, {
                                      href: 'gallery/Russian_course/DSC_0187.jpg',
                                      title: ''
                                  },
                                  {
                                      href: 'gallery/Russian_course/DSC_0188.jpg',
                                      title: ''
                                  },
                                  {
                                      href: 'gallery/Russian_course/DSC_0189.jpg',
                                      title: ''
                                  },
                                  {
                                      href: 'gallery/Russian_course/DSC_0190.jpg',
                                      title: ''
                                  },
                                  {
                                      href: 'gallery/Russian_course/DSC_0192.jpg',
                                      title: ''
                                  },
                                  {
                                      href: 'gallery/Russian_course/DSC_0197.jpg',
                                      title: ''
                                  },
                                  {
                                      href: 'gallery/Russian_course/DSC_0199.jpg',
                                      title: ''
                                  },
                                  {
                                      href: 'gallery/Russian_course/DSC_0200.jpg',
                                      title: ''
                                  },
                                  {
                                      href: 'gallery/Russian_course/DSC_0201.jpg',
                                      title: ''
                                  },
                                  {
                                      href: 'gallery/Russian_course/DSC_0213.jpg',
                                      title: ''
                                  },
                                  
                            {
                                href: 'gallery/Russian_course/DSC_0188.jpg',
                                title: ''
                            }
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });


                $("#fancybox-manual-peace").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/Peace2016/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Peace2016/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Peace2016/3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/4.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/5.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/6.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/7.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/8.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/9.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/10.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/11.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/Peace2016/12.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/13.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/14.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Peace2016/15.jpg',
                                title: ''
                            }
                           
                           
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });



                $("#fancybox-manual-a").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/Aerofest/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Aerofest/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Aerofest/3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Aerofest/4.jpg',
                                title: ''
                            }
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });

                $("#fancybox-manual-b").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/Agrotech/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Agrotech/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Agrotech/3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Agrotech/4.jpg',
                                title: ''
                            }
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });



                $("#fancybox-manual-ie1").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/final/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/final/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/final/3.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/final/4.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/final/5.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/final/6.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/final/7.jpg',
                                title: ''
                            },


                            {
                                href: 'gallery/final/8.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/final/9.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/final/10.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/final/11.jpg',
                                title: ''
                            },


                            {
                                href: 'gallery/final/12.jpg',
                                title: ''
                            }
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });



                $("#fancybox-manual-birthday").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/ch_birthday/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/ch_birthday/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/ch_birthday/3.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/ch_birthday/4.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/ch_birthday/5.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/ch_birthday/6.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/ch_birthday/7.jpg',
                                title: ''
                            },


                            {
                                href: 'gallery/ch_birthday/8.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/ch_birthday/9.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/ch_birthday/10.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/ch_birthday/11.jpg',
                                title: ''
                            },

                             {
                                 href: 'gallery/ch_birthday/12.jpg',
                                 title: ''
                             },

                              {
                                  href: 'gallery/ch_birthday/13.jpg',
                                  title: ''
                              },

                               {
                                   href: 'gallery/ch_birthday/14.jpg',
                                   title: ''
                               },

                                {
                                    href: 'gallery/ch_birthday/15.jpg',
                                    title: ''
                                },

                                 {
                                     href: 'gallery/ch_birthday/16.jpg',
                                     title: ''
                                 },

                                  {
                                      href: 'gallery/ch_birthday/17.jpg',
                                      title: ''
                                  },


                                   {
                                       href: 'gallery/ch_birthday/18.jpg',
                                       title: ''
                                   },


                                    {
                                        href: 'gallery/ch_birthday/19.jpg',
                                        title: ''
                                    },

                                     {
                                         href: 'gallery/ch_birthday/20.jpg',
                                         title: ''
                                     },

                                    
                            {
                                href: 'gallery/ch_birthday/12.jpg',
                                title: ''
                            }
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });









                $("#fancybox-manual-meet").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/freshersmeet/1.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/2.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/4.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/5.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/6.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/7.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/8.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/9.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/10.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/11.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/freshersmeet/12.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/13.jpg',
                                title: ''

                            },
                            {
                                href: 'gallery/freshersmeet/14.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/15.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/16.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/17.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/18.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/19.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/20.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/21.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/22.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/23.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/24.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/25.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/freshersmeet/26.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/freshersmeet/27.jpg',
                                title: ''

                            },
                            {
                                href: 'gallery/freshersmeet/28.jpg',
                                title: ''
                            }


                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });
                $("#fancybox-manual-Annualday").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/Annualday/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Annualday/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Annualday/3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Annualday/4.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Annualday/5.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Annualday/6.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Annualday/7.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Annualday/8.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Annualday/9.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Annualday/10.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Annualday/11.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/Annualday/12.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Annualday/13.jpg',
                                title: ''

                            },
                            {
                                href: 'gallery/Annualday/14.jpg',
                                title: ''
                            }


                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });


                $("#fancybox-manual-FormersProducerMeeting").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/FormerProducerMeeting/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/FormerProducerMeeting/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/FormerProducerMeeting/3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/FormerProducerMeeting/4.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/FormerProducerMeeting/5.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/FormerProducerMeeting/6.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/FormerProducerMeeting/7.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/FormerProducerMeeting/8.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/FormerProducerMeeting/9.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/FormerProducerMeeting/10.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/FormerProducerMeeting/11.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/FormerProducerMeeting/12.jpg',
                                title: ''
                            }


                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });


//                $("#fancybox-manual-peace").click(function () {
//                    $.fancybox.open([
//                            {
//                                href: 'gallery/peace/1.jpg',
//                                title: ''
//                            }, {
//                                href: 'gallery/peace/2.jpg',
//                                title: ''
//                            }, {
//                                href: 'gallery/peace/3.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/4.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/5.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/6.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/7.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/8.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/9.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/10.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/11.jpg',
//                                title: ''
//                            },

//                            {
//                                href: 'gallery/peace/12.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/13.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/14.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/15.jpg',
//                                title: ''
//                            },
//                            {
//                                href: 'gallery/peace/16.jpg',
//                                title: ''
//                            },

//                            {
//                                href: 'gallery/peace/17.jpg',
//                                title: ''
//                            }


//                    ], {
//                        helpers: {
//                            thumbs: {
//                                width: 75,
//                                height: 50
//                            }
//                        }
//                    });
//                });



                $("#fancybox-manual-sportsday").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/SportsDay2016/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/SportsDay2016/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/SportsDay2016/3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/4.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/5.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/6.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/7.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/8.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/9.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/10.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/11.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/SportsDay2016/12.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/13.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/14.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/15.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/16.jpg',
                                title: ''
                            },
                             {
                                 href: 'gallery/SportsDay2016/17.jpg',
                                 title: ''
                             },
                              {
                                  href: 'gallery/SportsDay2016/18.jpg',
                                  title: ''
                              },
                               {
                                   href: 'gallery/SportsDay2016/19.jpg',
                                   title: ''
                               },
                            {
                                href: 'gallery/SportsDay2016/20.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/SportsDay2016/21.jpg',
                                title: ''
                            },
                             {
                                 href: 'gallery/SportsDay2016/22.jpg',
                                 title: ''
                             },


                            {
                                href: 'gallery/SportsDay2016/23.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/24.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/25.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/26.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/27.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/28.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/SportsDay2016/29.jpg',
                                title: ''
                            },
                            {
                                 href: 'gallery/SportsDay2016/30.jpg',
                                 title: ''
                             },
                             {
                                 href: 'gallery/SportsDay2016/31.jpg',
                                 title: ''
                             },
                                   {
                                 href: 'gallery/SportsDay2016/32.jpg',
                                 title: ''
                             },
                                   {
                                 href: 'gallery/SportsDay2016/33.jpg',
                                 title: ''
                             }
                           


                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });


                $("#fancybox-manual-marathon").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/marathon/marathon1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/marathon/marathon2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/marathon/marathon3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/marathon/marathon4.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/marathon/marathon5.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/marathon/marathon6.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/marathon/marathon7.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/marathon/marathon8.jpg',
                                title: ''
                            }
                            
                           


                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });
				
				$("#fancybox-manual-openhse-2016").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/openhouse2016/1.jpg',
                                title: ''
                            }, 
							{
                                href: 'gallery/openhouse2016/2.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/openhouse2016/3.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/openhouse2016/4.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/openhouse2016/5.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/openhouse2016/6.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/openhouse2016/7.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/openhouse2016/8.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/openhouse2016/9.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/openhouse2016/10.jpg',
                                title: ''
                            },
							{
                                href: 'gallery/openhouse2016/11.jpg',
                                title: ''
                            },
                            
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });

                $("#fancybox-manual-c").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/Alumnimeet/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Alumnimeet/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Alumnimeet/3.jpg',
                                title: ''
                            }

                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });


                $("#fancybox-manual-co").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/Convocation/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Convocation/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/Convocation/3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/4.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/5.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/6.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/7.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/8.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/9.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/10.jpg',
                                title: ''
                            },
                                                        {
                                                            href: 'gallery/Convocation/11.jpg',
                                                            title: ''
                                                        },
                            {
                                href: 'gallery/Convocation/12.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/13.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/14.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/15.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/16.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/17.jpg',
                                title: ''

                            },
                            {
                                href: 'gallery/Convocation/18.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/19.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/20.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/21.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/22.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/23.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/24.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/25.jpg',
                                title: ''

                            },
                            {
                                href: 'gallery/Convocation/26.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/27.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/28.jpg',
                                title: ''
                            },

                            {
                                href: 'gallery/Convocation/29.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/30.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/31.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/32.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/33.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/34.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/35.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/36.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/37.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/38.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/39.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/Convocation/40.jpg',
                                title: ''
                            }

                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });





















                //                $("#fancybox-manual-d").click(function () {
                //                    $.fancybox.open([
                //                            {
                //                                href: 'gallery/ICTfest/1.jpg',
                //                                title: ''
                //                            }, {
                //                                href: 'gallery/ICTfest/2.jpg',
                //                                title: ''
                //                            }, {
                //                                href: 'gallery/ICTfest/3.jpg',
                //                                title: ''
                //                            },
                //                            {
                //                                href: 'gallery/ICTfest/4.jpg',
                //                                title: ''
                //                            }
                //                    ], {
                //                        helpers: {
                //                            thumbs: {
                //                                width: 75,
                //                                height: 50
                //                            }
                //                        }
                //                    });
                //                });

                $("#fancybox-manual-e").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/IDMS/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/IDMS/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/IDMS/3.jpg',
                                title: ''
                            }

                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });

                $("#fancybox-manual-f").click(function () {
                    $.fancybox.open([
                                    {
                                        href: 'gallery/isteconvention/1.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/isteconvention/2.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/isteconvention/3.jpg',
                                        title: ''
                                    },
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });

                $("#fancybox-manual-g").click(function () {
                    $.fancybox.open([
                                    {
                                        href: 'gallery/Innaguration/1.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/2.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/3.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/4.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/5.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/6.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/7.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/8.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/9.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/10.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/11.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/12.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/13.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/14.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/15.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/16.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/17.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/18.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/19.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Innaguration/20.jpg',
                                        title: ''
                                    }
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });


                $("#fancybox-manual-h").click(function () {
                    $.fancybox.open([
                                    {
                                        href: 'gallery/Events/1.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/2.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/3.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/4.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/5.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/6.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/7.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/8.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/9.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/10.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/11.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/12.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/13.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/14.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/Events/15.jpg',
                                        title: ''
                                    }
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });
				
				<!--malaysia-->
				$("#fancybox-manual-malaysia").click(function () {
                    $.fancybox.open([
                            {
                                href: 'gallery/malaysiaguestvisit/1.jpg',
                                title: ''
                            }, {
                                href: 'gallery/malaysiaguestvisit/2.jpg',
                                title: ''
                            }, {
                                href: 'gallery/malaysiaguestvisit/3.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/malaysiaguestvisit/4.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/malaysiaguestvisit/5.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/malaysiaguestvisit/6.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/malaysiaguestvisit/7.jpg',
                                title: ''
                            },
                            {
                                href: 'gallery/malaysiaguestvisit/8.jpg',
                                title: ''
                            }
                            
                           


                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });
				

                $("#fancybox-manual-i").click(function () {
                    $.fancybox.open([
                                    {
                                        href: 'gallery/ValedictoryFunction/1.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/2.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/3.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/4.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/5.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/6.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/7.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/8.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/9.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/10.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/11.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/12.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/13.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/14.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/15.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/16.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/17.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/18.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/19.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/20.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/21.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/22.jpg',
                                        title: ''
                                    }, {
                                        href: 'gallery/ValedictoryFunction/23.jpg',
                                        title: ''
                                    }
                    ], {
                        helpers: {
                            thumbs: {
                                width: 75,
                                height: 50
                            }
                        }
                    });
                });

            });
        </script>
</form>
</body>
</html>
