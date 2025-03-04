<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="department_of_computer_science_engineering_default" %>
<%@ Register Src="~/includes/socialmedia-share-floated.ascx" TagPrefix="uc1" TagName="socialmediasharefloated" %>
<%@ Register Src="~/includes/menu-top.ascx" TagPrefix="uc1" TagName="menutop" %>
<%@ Register Src="~/cse/include/banner-menu.ascx" TagPrefix="uc1" TagName="bannermenu" %>
<%@ Register Src="~/includes/admission-navigation.ascx" TagPrefix="uc1" TagName="admissionnavigation" %>
<%@ Register Src="~/cse/include/features-menu.ascx" TagPrefix="uc1" TagName="featuresmenu" %>
<%@ Register Src="~/includes/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register src="~/includes/UCAdmission.ascx" tagname="admission" tagprefix="uc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, user-scalable=no" />
<title>Department of Computer Science & Engineering | PMIST</title>
    <meta name="title" content="Department of Computer Science & Engineering">
<meta name="description" content="The Department imparts high quality education in the field of Computer Science and Engineering.">

    <!-- Open Graph / Facebook -->
<meta property="og:type" content="website">
<meta property="og:url" content="http://www.pmu.edu/cse/">
<meta property="og:title" content="Department of Computer Science & Engineering | PMIST">
<meta property="og:description" content="The Department imparts high quality education in the field of Computer Science and Engineering.">
<meta property="og:image" content="http://pmu.edu/images/BTechComputerScience.png">

<!-- Twitter -->
<meta property="twitter:card" content="summary_large_image">
<meta property="twitter:url" content="http://www.pmu.edu/cse/">
<meta property="twitter:title" content="Department of Computer Science & Engineering | PMIST">
<meta property="twitter:description" content="The Department imparts high quality education in the field of Computer Science and Engineering.">
<meta property="twitter:image" content="http://pmu.edu/images/BTechComputerScience.png">


<link rel="stylesheet" type="text/css" href="/site-assets/css/style.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/responsive.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/hover.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/animate.css">
<link rel="stylesheet" type="text/css" href="/site-assets/css/menu.css" />
<link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Titillium+Web:300,400,600,700" />
<link rel="icon" type="image/x-icon" href="/site-assets/images/fav-icon.png" />
    <link rel="stylesheet" type="text/css" href="/site-assets/css/modal.css">
 
<script type="text/javascript" src="https://use.fontawesome.com/5ecf78f4a4.js"></script>
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
</head>
<body>
     
     <form id="form1" runat="server">
        <asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>
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
      </ul>
    </div>
     <div class="content-left">
      <h2 class="h2">Department of Computer Science and Engineering</h2>
      <article class="content-1">
        <h3>About</h3>
         <p>Began in the year 1988 with the approval of AICTE, The Computer Science and Engineering Department imparts high quality education in the field of Computer Science and Engineering and also develops the overall personality of the students.</p>
        <p>The Department has well qualified faculty members and well equipped laboratories to develop the technical skills of the students.</p>
        <ul class="content-list">
          <li>30 years past since it is inception. </li>
          <li>Accredited by National Board of Accreditation in 1998 and since then till date.</li>
          <li>Facilitates the students to enrich technical know-how with the guidance of a team of well qualified and dedicated faculty members. </li>
        </ul>


         <h3>Vision</h3>
        <p>To Produce professionals who can  relate theory and practice, familiar with common themes and apply concepts of Computer Science and Engineering for Research and Societal development.</p>
        <h3>Mission</h3>
        <ul class="content-list">
          <li>To offer UG, PG, Ph.D. programme  with state of art facilities in the field of Computer Science and Engineering.</li>
          <li>To prepare the students become globally competent by enhancing their skills to work in IT Industries and R & D organizations.</li>
          <li>To prepare the students with good ethical attitude and an ability to relate engineering issues to broader social context. </li>
          <li>To promote significant research in cutting edge Information and Communication technologies with environmental consciousness. </li>
          <%--<li>To nurture the students as resourceful and responsible citizens to fulfill the expectations of society following ethical values. </li>--%>
        </ul>


       
      </article>
    </div>
    
    <div class="content-right">
      <uc1:admissionnavigation runat="server" ID="admissionnavigation" />
      <article class="quick-q"></article>
      <div class="clear"></div>
      <uc1:featuresmenu runat="server" ID="featuresmenu" />
    </div>
  </div>
</section>
<div class="clear"></div>
<uc1:footer runat="server" ID="footer" />
           <div class="enquire" data-toggle="modal" data-target="#exampleModalCenter">
        <a class="cursor-pointer whiteColor">
            <div>Apply Now</div>
        </a>
    </div>
    <uc:admission id="admission" runat="server" />
         </form>
</body>
</html>
<script type="text/javascript" src="/site-assets/js/jquery-2.2.0.min.js"></script>
<script type="text/javascript" src="/site-assets/js/comman.js"></script>
<script type="text/javascript" src="/js/bootstrap.min.js"></script>
<script type="text/javascript">
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