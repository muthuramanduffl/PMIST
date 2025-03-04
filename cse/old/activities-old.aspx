<%@ Page Language="C#" AutoEventWireup="true" CodeFile="activities.aspx.cs" Inherits="department_of_computer_science_engineering_activities" %>
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
<script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
})(window,document,'script','dataLayer','GTM-5H893BR');</script>
<!-- End Google Tag Manager -->
<script type="text/javascript" src="https://use.fontawesome.com/5ecf78f4a4.js"></script>
</head>
<body>
     <!-- Google Tag Manager (noscript) -->
<noscript><iframe src="https://www.googletagmanager.com/ns.html?id=GTM-5H893BR"
height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
<!-- End Google Tag Manager (noscript) -->
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
        <li><a href="/cse/activities.aspx">Activities</a></li>
      </ul>
    </div>
    <div class="content-left">
      <h2 class="h2">Department of Computer Science and Engineering</h2>
      <article class="content-1">
        <h3>Activities</h3>
        <ul class="content-list">
          <li>Organizes Technical showcase, Symposium, Seminars and Conferences periodically to bring out the talents of students and to improve their leadership qualities. </li>
          <li>Motivates the students to take part in National, State level competitive examinations, project exhibitions, paper presentations etc. </li>
          <li>Facilitates the students with  skill development programmes like SAP R/3, Oracle 10g, Java, .Net etc </li>
          <li>The students are motivated to undergo inplant training  in various companies</li>
          <li>Lectures given by Industry experts from the field of computer science and information  technology. </li>
          <li>Seminars  and workshops are organized on emerging trends in the field of information technology.</li>
          <li>Every year the students can exhibit their innovative ideas in Open House Exhibition.</li>
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