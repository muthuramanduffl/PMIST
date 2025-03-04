<%@ Page Language="C#" AutoEventWireup="true" CodeFile="courses.aspx.cs" Inherits="department_of_computer_science_engineering_courses" %>
<%@ Register Src="~/includes/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/department-of-computer-science-engineering/include/features-menu.ascx" TagPrefix="uc1" TagName="featuresmenu" %>
<%@ Register Src="~/includes/admission-navigation.ascx" TagPrefix="uc1" TagName="admissionnavigation" %>
<%@ Register Src="~/department-of-computer-science-engineering/include/banner-menu.ascx" TagPrefix="uc1" TagName="bannermenu" %>
<%@ Register Src="~/includes/menu-top.ascx" TagPrefix="uc1" TagName="menutop" %>
<%@ Register Src="~/includes/socialmedia-share-floated.ascx" TagPrefix="uc1" TagName="socialmediasharefloated" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, user-scalable=no" />
<title>Periyar Maniammai Institute of Science & Technology | Think - Innovate - Transform</title>
<link rel="stylesheet" type="text/css" href="/site-assets/css/style.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/responsive.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/hover.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/menu.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/animate.css">
<link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Titillium+Web:300,400,600,700" />
<link rel="icon" type="image/x-icon" href="/site-assets/images/fav-icon.png" />
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
<script type="text/javascript" src="https://use.fontawesome.com/5ecf78f4a4.js"></script>
</head>
<body>
    
<uc1:socialmediasharefloated runat="server" ID="socialmediasharefloated" />

<!----------------------------MegaMenu Start------------------------------>
<div class="header adjust">
  <div class="container rsp-4">
    <uc1:menutop runat="server" ID="menutop" />
  </div>
</div>
<!---------------------------Megamenu End----------------------------------------->
<div class="clear"></div>
<div class="inner-banner cse">
  <div class="container"> 
    <!--<div class="header-left">
		<div class="inner-logo"><a href="index.html"> <img src="images/inner-logo.png"></a> </div>
    </div>-->
    <div class="header-right">
      <uc1:bannermenu runat="server" ID="bannermenu" />
    </div>
  </div>
</div>
<section class="content">

  <div class="container">
    <div class="navi">
      <ul class="navi-link">
        <li><a href="/"><i class="fa fa-home" aria-hidden="true"></i><span class="arrow-ic"></span></a></li>
        <li><a href="/cse/">Department of Computer Science and Engineering</a></li>
        <li><a href="javascript:void(0)">Program</a></li>
      </ul>
    </div>

    <div class="content-left">
      <h2 class="h2">Department of Computer Science and Engineering</h2>

      <article class="content-1">
        <h3>Program</h3>
        <ul class="content-list">
        <li>B.Tech – Computer Science and Engineering</li>
                       
        </ul>
      </article>
       <article class="content-1">
        <h3></h3>
        
      </article>

      <article class="content-1">
        <h3></h3>
        <ul class="content-list">
        
        <div class="content-acc">
          <div class="acc-head open2">
            <h4>PEO's,PO's & PSO's</h4>
            <span class="arrow-picker"><i class="fa fa-plus" aria-hidden="true"></i></span> </div>
          <div class="acc-content open2">
           
       
            <ul >
             <P><font size="3" color="red">B.Tech- Computer Science and Engineering</font></P>
             <P><font size="3" color="blue">PROGRAMME EDUCATIONAL OBJECTIVES</font></P>
              
              <li><strong>PEO1</strong>Graduates will attain the expertise of analyzing and specifying the requirements for any computing system as well as capable of modeling, designing,implementing and verifying a computing system to meet specified requirements using contemporary tools.</li>
              <li><strong>PEO2</strong>Graduates will possess diversified professional skills for successful career.</li>
              <li><strong>PEO3</strong>Graduates of the programme will have the competencies for communicating, planning, coordinating, organizing, decision making and leading a team.</li>
              <li><strong>PEO4</strong>Graduates of the programme will have knowledge of professional, interpersonal and ethical responsibility and will contribute to society through active research</li>
             <%-- <li><strong>PEO5</strong> Stimulate adaptability in the Nation development through imparting knowledge and skill.</li>--%>
            </ul>
          
         
            
            <ul class="content-list">
            <P><font size="3" color="blue"> PROGRAM OUTCOMES </font></P>
              <li><strong>PO1</strong> Ability to apply knowledge of computing and mathematics appropriate to the discipline.</li>
              <li><strong>PO2</strong>Ability to analyze a problem, interpret data, and define the computing system requirements which would be appropriate to the solution.</li>
              <li><strong>PO3</strong>Ability to design, implement, and evaluate a computer-based system, process, component, or program to meet desired needs.</li>

              <li><strong>PO4</strong>Ability to apply creativity in the design of systems which would help to investigate the complex problem and provide software solution.</li>
              <li><strong>PO5</strong>Ability to use the  computing techniques,  skills, and  modern  system  tools necessary for practice as a CSE professional.</li>
              <li><strong>PO6</strong> Ability to analyze the local and global impact of computing on individuals, organizations, and society.</li>
              <li><strong>PO7</strong> Ability to develop and use the software systems within realistic constraints environmental,   health   and   safety,   manufacturability,   and   sustainability considerations.</li>
              <li><strong>PO8</strong>Ability in understanding of professional, ethical, legal, security and social issues and responsibilities.</li>
              <li><strong>PO9</strong>Ability to function effectively on teams and individually to accomplish a common goal.</li>
              <li><strong>PO10</strong>Ability to communicate effectively with a range of audiences by written and oral.</li>
              <li><strong>PO11</strong>Ability to plan, organize and follow best practices and standards so that the project is completed as successfully by meeting performance, quality at CMM level, budget and time.</li>
              <li><strong>PO12</strong>Ability to engage in Lifelong learning and continuing professional development.</li>
              
            </ul>

             <ul class="content-list">
             <P><font size="3" color="blue">PROGRAM SPECIFIC OUTCOME </font></P>
              
              <li><strong>PSO1</strong>Ability to employ latest computer languages, environments and platforms for solving problems in the areas of emerging communication technologies.</li>
              <li><strong>PSO2</strong>Ability to use knowledge in data analytics and mining for industrial problems.</li>
              
            </ul>
          
            </div>
        </div>
         
          <div class="content-acc">
          <div class="acc-head open2">
            <%--<h4>M.Tech - Wireless Communication Systems (Full time & Part time) </h4>--%>
            <h4>Curriculam</h4>
            <span class="arrow-picker"><i class="fa fa-plus" aria-hidden="true"></i></span> </div>
          <div class="acc-content open2">
           
          
            <ul class="content-list2"> 
            <P><font size="3" color="red">B.Tech - Computer Science and Engineering</font></P>    
             <%--<p> Curriculam</p>--%>
            <li><a href="/department-of-computer-science-engineering/pdf/Regulation_2015_rev2 - III Year, IV year (2015-2019, 2016-2020).pdf" target="_blank">Curriculam 2015</a></li>
             <li><a href="/department-of-computer-science-engineering/pdf/Regulation_2017 -II Year (2017-2021).pdf" target="_blank">Curriculam 2017</a></li>
             <li><a href="/department-of-computer-science-engineering/pdf/Regulation 2018 -I year (2018-2022).pdf" target="_blank">Curriculam 2018</a></li>
            </ul>
           
            
            </div>
        </div>

        <div class="content-acc">
          <div class="acc-head open2">
            <%--<h4>M.Tech – Nano Technology (Full time & Part time) </h4>--%>
            <h4>Workload</h4>
             
            <span class="arrow-picker"><i class="fa fa-plus" aria-hidden="true"></i></span> </div>
          <div class="acc-content open2">
            
            <ul class="content-list2">     
<P><font size="3" color="red">B.Tech - Computer Science and Engineering</font></P>
            <li><a href="/department-of-computer-science-engineering/pdf/workload-CSE-converted.pdf" target="_blank">Workload</a></li>
             
            </ul>
      
               
          </div>
        </div>
        
        <div class="content-acc">
          <div class="acc-head open2">
            <%--<h4>M.Tech – Nano Technology(Integrated) Full Time </h4>--%>
            <h4>TimeTable</h4>
            
            <span class="arrow-picker"><i class="fa fa-plus" aria-hidden="true"></i></span> </div>
          <div class="acc-content open2">
           
            <ul class="content-list2">     
            <P><font size="3" color="red">B.Tech - Computer Science and Engineering</font></P> 
            <li><a href="/department-of-computer-science-engineering/pdf/Time Table Even 2018-CSE-converted.pdf" target="_blank">Time Table</a></li>
             
            </ul>
      
               
            </div>
        </div>

         
        </ul>
      </article>
    </div>




   <%-- <div class="content-left">
      <h2 class="h2">Department of Aerospace Engineering</h2>
      <article class="content-1">
        <h3>Courses</h3>
        <ul class="content-list">
          <li>B.Tech – Aerospace Engineering</li>
        </ul>
      </article>
    </div>--%>
    <div class="content-right">
      <uc1:admissionnavigation runat="server" ID="admissionnavigation" />
      <article class="quick-q"></article>
      <div class="clear"></div>
      <uc1:featuresmenu runat="server" ID="featuresmenu" />
    </div>
  </div>


 <%-- <div class="container">
    <div class="navi">
      <ul class="navi-link">
        <li><a href="/"><i class="fa fa-home" aria-hidden="true"></i><span class="arrow-ic"></span></a></li>
        <li><a href="/department-of-computer-science-engineering/">Department of Computer Science and Engineering</a></li>
        <li><a href="/department-of-computer-science-engineering/courses.aspx">Courses</a></li>
      </ul>
    </div>
    <div class="content-left">
      <h2 class="h2">Department of Computer Science and Engineering</h2>
      <article class="content-1">
        <h3>Courses</h3>
        <ul class="content-list">
          <li>B.Tech. Computer Science and Engineering </li>
          <li>M.Tech. Computer Science and Engineering (Full Time and Part Time) </li>
          <li>Ph.D. programmes (Full Time and Part Time)</li>
        </ul>
      </article>
    </div>
    <div class="content-right">
      <uc1:admissionnavigation runat="server" ID="admissionnavigation" />
      <article class="quick-q"></article>
      <div class="clear"></div>
      <uc1:featuresmenu runat="server" ID="featuresmenu" />
    </div>
  </div>--%>
</section>
<div class="clear"></div>
<uc1:footer runat="server" ID="footer" />
</body>
</html>
<script type="text/javascript" src="/site-assets/js/jquery-2.2.0.min.js"></script>
<script type="text/javascript" src="/site-assets/js/comman.js"></script>
<script>
    $(document).ready(function () {
        $(".share-link").click(function () {
            $(".share-link1").slideToggle(500);
            $(".share-link1 li").click(function () {
                $(".share-link1").slideToggle();
            });
        });
    });

    $(document).ready(function () {
        $(".responsive-menu").click(function () {
            $(".menu-content-1").slideToggle(500);
            $(".menu-content-1 li a").click(function () {
                $(".menu-content-1").slideUp();
            });
        });
    });

    $('.windowjs').windowJS({
        backgroundColor: 'rgba(0,0,0,.9)'
    });
</script>