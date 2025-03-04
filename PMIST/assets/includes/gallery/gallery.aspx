<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="iqac_gallery" %>
<%@ Register Src="~/includes/menu-top.ascx" TagPrefix="uc1" TagName="menutop" %>
<%@ Register Src="~/iqac/includes/right-navigation.ascx" TagPrefix="uc1" TagName="rightnavigation" %>
<%@ Register Src="~/includes/admission-navigation.ascx" TagPrefix="uc1" TagName="admissionnavigation" %>
<%@ Register Src="~/includes/footer.ascx" TagPrefix="uc1" TagName="footer" %>
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
<link rel="stylesheet" type="text/css" href="/site-assets/css/animate.css" />
<link rel="Stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Titillium+Web:300,400,600,700" />
<script type="text/javascript" src="https://use.fontawesome.com/5ecf78f4a4.js"></script>
</head>
<body>
<uc1:socialmediasharefloated runat="server" ID="socialmediasharefloated" />

<!----------------------------MegaMenu Start------------------------------>
<div class="header adjust">
  <div class="container rsp-4"> 
    
    <!-- Main menu items -->
    <uc1:menutop runat="server" ID="menutop" />
    <!-- End of Main menu --> 
    
  </div>
</div>

<!---------------------------Megamenu End----------------------------------------->
<div class="clear"></div>
<div class="inner-banner">
  <div class="container"></div>
</div>
<section class="content">
  <div class="container">
    <div class="navi">
      <ul class="navi-link">
        <li><a href="/"><i class="fa fa-home" aria-hidden="true"></i><span class="arrow-ic"></span></a></li>
        <li><a href="/about/">Gallery</a></li>
      </ul>
    </div>
    <div class="clear"></div>
    <div class="content-left">
      <h2 class="h2">Gallery</h2>
      <div class="content">
        <div class="gallery-1" style="width: 100%">
          <h2 class="fnt">25<sup style="position:absolute; top:-5px;">th</sup>&nbsp;&nbsp;&nbsp; Convocation 2017</h2>
          <div class="col-3">
            <div class="gallery-box-1 hover01 column gallery-2">
              <div>
                <figure> <a href="images/convocation/01.jpg" class="big"> <img src="images/convocation/01.jpg" alt="" /></a> </figure>
              </div>
            </div>
          </div>
          <div class="col-3">
            <div class="gallery-box-1 hover01 column gallery-2">
              <div>
                <figure> <a href="images/convocation/08.jpg" class="big"> <img src="images/convocation/08.jpg" alt="" /></a> </figure>
              </div>
            </div>
          </div>
          <div class="col-3">
            <div class="gallery-box-1 hover01 column gallery-2">
              <div>
                <figure> <a href="images/convocation/09.jpg" class="big"> <img src="images/convocation/09.jpg" alt="" /></a> </figure>
              </div>
            </div>
          </div>
          <div class="col-3">
            <div class="gallery-box-1 hover01 column gallery-2">
              <div>
                <figure> <a href="images/convocation/10.jpg" class="big"> <img src="images/convocation/10.jpg" alt="" /></a> </figure>
              </div>
            </div>
          </div>
          <div class="col-3">
            <div class="gallery-box-1 hover01 column gallery-2">
              <div>
                <figure> <a href="images/convocation/11.jpg" class="big"> <img src="images/convocation/11.jpg" alt="" /></a> </figure>
              </div>
            </div>
          </div>
          <div class="col-3">
            <div class="gallery-box-1 hover01 column gallery-2">
              <div>
                <figure> <a href="images/convocation/21.jpg" class="big"> <img src="images/convocation/21.jpg" alt="" /></a> </figure>
              </div>
            </div>
          </div>
          <div class="clear"></div>
        </div>
      </div>
    </div>
    <div class="content-right">
      <uc1:rightnavigation runat="server" ID="rightnavigation" MenuIndex="6" />
      <div class="mar-top30"></div>
      <uc1:admissionnavigation runat="server" ID="admissionnavigation" />
      <article class="quick-q"></article>
      <div class="clear"></div>
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
    });
</script>