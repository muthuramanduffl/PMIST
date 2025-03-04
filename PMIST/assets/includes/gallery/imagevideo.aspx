<%@ Page Language="C#" AutoEventWireup="true" CodeFile="imagevideo.aspx.cs" Inherits="imagevideo" %>

<%@ Register Src="~/includes/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/includes/socialmedia-share-floated.ascx" TagPrefix="uc1" TagName="socialmediasharefloated" %>
<%@ Register Src="~/includes/menu-top.ascx" TagPrefix="uc1" TagName="menutop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, user-scalable=no" />
<title>Periyar Maniammai Institute of Science & Technology | Think - Innovate - Transform</title>
<link rel="stylesheet" type="text/css" href="/site-assets/css/style.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/menu.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/responsive.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/animate.css" />
<link rel="stylesheet" type="text/css" href="/site-assets/css/hover.css" />
<link rel="icon" type="image/x-icon" href="/site-assets/images/fav-icon.png" />
<script>
    (function (i, s, o, g, r, a, m) {
        i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
            (i[r].q = i[r].q || []).push(arguments)
        }, i[r].l = 1 * new Date(); a = s.createElement(o),
  m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
    })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

    ga('create', 'UA-104441290-1', 'auto');
    ga('send', 'pageview');

</script>

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
<div class="inner-banner">
  <div class="container"></div>
</div>
<section class="content">
  <div class="container">
    <div class="navi glry">
      <ul class="navi-link">
        <li><a href="/"><i class="fa fa-home" aria-hidden="true"></i><span class="arrow-ic"></span></a></li>
        <li><a href="/gallery/">Images</a></li>
      </ul>
    </div>
    <div class="clear"></div>
    <div class="content">
    
     <div class="col-4">
        <div >
          <div>
            <li><a href="/gallery/default.aspx">Images</a></li>
            <li><a href="/gallery/videos.aspx">Videos</a></li>
          </div>
        </div>
      
      </div>


      
      <!-------------------------------------------------------------------------------------------------->
      
    </div>
  </div>
</section>
<div class="clear"></div>
<uc1:footer runat="server" ID="footer" />
</body>
</html>
<script type="text/javascript" src="/site-assets/js/jquery-2.2.0.min.js"></script>
<script type="text/javascript" src="/site-assets/js/comman.js"></script>
<script type="text/javascript">

    $(document).ready(function () {

        $(".share-link").click(function () {
            $(".share-link1").slideToggle(500);
            $(".share-link1 li").click(function () {
                $(".share-link1").slideToggle();
            });
        });

        $(".responsive-menu").click(function () {
            $(".menu-content-1").slideToggle(500);
            $(".menu-content-1 li a").click(function () {
                $(".menu-content-1").slideUp();
            });
        });

    });
</script>