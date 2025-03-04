<%@ Page Language="C#" AutoEventWireup="true" CodeFile="research.aspx.cs" Inherits="department_of_computer_science_engineering_research" %>
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
<link rel="stylesheet" type="text/css" href="/site-assets/css/animate.css">
<link rel="stylesheet" type="text/css" href="/site-assets/css/menu.css" />
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
        <li><a href="/cse/research.aspx">Research</a></li>
      </ul>
    </div>
    <div class="content-left">
      <h2 class="h2">Department of Computer Science and Engineering</h2>
      <article class="content-1">
        <h3>Research</h3>
        <p> Our Objective of teaching is to provide an excellent academic knowledge with a bias towards research. The school has a good number of research scholars with focus on emerging areas such as:<br />
          Cloud Computing, Computer Networks, Mobile Computing, Natural Language Processing, Intelligent Systems, Distributed Computing, Network Security, Software Engineering, Real Time Systems, Image Processing, Pattern Recognition, Soft-computing and Wireless sensor networks Etc..Our faculty members are very active in publications of books and technical journals. </p>
        <p>Following are some Strong Research Areas.</p>
        <ul class="content-list">
          <p><b>Cloud Computing</b></p>
          <li>Efficient way of Intrusion Detection Systems by Supporting Vector Machine and Genetic algorithm.</li>
          <li>Data security and Privacy in cloud servers.</li>
          <p><b>Natural Language Processing</b></p>
          <li>Automatic Question answering system.</li>
          <li>Tamil speech recognition system.</li>
          <li>Efficient Video retrieval techniques.</li>
          <p><b>Software Engineering</b></p>
          <li>Optimized way of software metric analysis.</li>
          <p><b>Big-Data Analytics</b></p>
          <li>Efficient way of Content/Data insertion and retrieval.</li>
          <p><b>Wireless Sensor Networks</b></p>
          <li>Energy Efficient security protocol for WSN.</li>
          <p><b>Mobile Computing</b></p>
          <li>Single carrier frequency division multiple access technique.</li>
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