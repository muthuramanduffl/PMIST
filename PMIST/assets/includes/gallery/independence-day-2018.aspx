<%@ Page Language="C#" AutoEventWireup="true" CodeFile="independence-day-2018.aspx.cs" Inherits="gallery_independence_day_2018" %>
<%@ Register Src="~/includes/socialmedia-share-floated.ascx" TagPrefix="uc1" TagName="socialmediasharefloated" %>
<%@ Register Src="~/includes/menu-top.ascx" TagPrefix="uc1" TagName="menutop" %>
<%@ Register Src="~/includes/footer.ascx" TagPrefix="uc1" TagName="footer" %>

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
<link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Titillium+Web:300,400,600,700" />
<script type="text/javascript" src="https://use.fontawesome.com/5ecf78f4a4.js"></script>

<!--Gallery-->
<link rel="stylesheet" type="text/css" href='http://fonts.googleapis.com/css?family=Slabo+27px'>
<link rel="stylesheet" type="text/css" href="css/simplelightbox.css">
<link rel="stylesheet" type="text/css" href="css/simplelightbox.min.css">
<link rel="stylesheet" type="text/css" href="demo.css">
<link rel="icon" type="image/x-icon" href="/site-assets/images/fav-icon.png" />
<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','https://www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-104441290-1', 'auto');
  ga('send', 'pageview');

</script>

<!--/ Gallery-->

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
    <div class="navi">
      <ul class="navi-link">
        <li><a href="/"><i class="fa fa-home" aria-hidden="true"></i><span class="arrow-ic"></span></a></li>
        <li><a href="/gallery/">Gallery</a></li>
        <li><a href="/gallery/independence-day-2018.aspx">Independence Day 2018</a></li>
      </ul>
    </div>
    <div class="content">
      <div class="gallery-1" style="width: 100%">
        <h2 class="fnt">Independence Day 2018</h2>
        <div class="col-3">
          <div class="gallery-box-1 hover01 column gallery-2">
            <div>
              <figure> <a href="images/independence_day_2018/1.jpg" class="big"> <img src="images/independence_day_2018/1.jpg" alt="" /></a> </figure>
            </div>
          </div>
        </div>
        <div class="col-3">
          <div class="gallery-box-1 hover01 column gallery-2">
            <div>
              <figure> <a href="images/independence_day_2018/2.jpg" class="big"> <img src="images/independence_day_2018/2.jpg" alt="" /></a> </figure>
            </div>
          </div>
        </div>
        <div class="col-3">
          <div class="gallery-box-1 hover01 column gallery-2">
            <div>
              <figure> <a href="images/independence_day_2018/3.jpg" class="big"> <img src="images/independence_day_2018/3.jpg" alt="" /></a> </figure>
            </div>
          </div>
        </div>
        <div class="col-3">
          <div class="gallery-box-1 hover01 column gallery-2">
            <div>
              <figure> <a href="images/independence_day_2018/4.jpg" class="big"> <img src="images/independence_day_2018/4.jpg" alt="" /></a> </figure>
            </div>
          </div>
        </div>
        <div class="col-3">
          <div class="gallery-box-1 hover01 column gallery-2">
            <div>
              <figure> <a href="images/independence_day_2018/5.jpg" class="big"> <img src="images/independence_day_2018/5.jpg" alt="" /></a> </figure>
            </div>
          </div>
        </div>
        <div class="col-3">
          <div class="gallery-box-1 hover01 column gallery-2">
            <div>
              <figure> <a href="images/independence_day_2018/6.jpg" class="big"> <img src="images/independence_day_2018/6.jpg" alt="" /></a> </figure>
            </div>
          </div>
        </div>
        <div class="col-3">
          <div class="gallery-box-1 hover01 column gallery-2">
            <div>
              <figure> <a href="images/independence_day_2018/7.jpg" class="big"> <img src="images/independence_day_2018/7.jpg" alt="" /></a> </figure>
            </div>
          </div>
        </div>
        <div class="clear"></div>
      </div>
    </div>
  </div>
</section>
<div class="clear"></div>
<uc1:footer runat="server" ID="footer" />
<script type="text/javascript" src="/site-assets/js/jquery-2.2.0.min.js"></script> 
<script type="text/javascript" src="js/simple-lightbox.js"></script> 
<script type="text/javascript" src="/site-assets/js/comman.js"></script> 
<script>
    $(function () {
        var $gallery = $('.gallery-2 div a, .gallery-3').simpleLightbox();

        $gallery.on('show.simplelightbox', function () {
            console.log('Requested for showing');
        })
            .on('shown.simplelightbox', function () {
                console.log('Shown');
            })
            .on('close.simplelightbox', function () {
                console.log('Requested for closing');
            })
            .on('closed.simplelightbox', function () {
                console.log('Closed');
            })
            .on('change.simplelightbox', function () {
                console.log('Requested for change');
            })
            .on('next.simplelightbox', function () {
                console.log('Requested for next');
            })
            .on('prev.simplelightbox', function () {
                console.log('Requested for prev');
            })
            .on('nextImageLoaded.simplelightbox', function () {
                console.log('Next image loaded');
            })
            .on('prevImageLoaded.simplelightbox', function () {
                console.log('Prev image loaded');
            })
            .on('changed.simplelightbox', function () {
                console.log('Image changed');
            })
            .on('nextDone.simplelightbox', function () {
                console.log('Image changed to next');
            })
            .on('prevDone.simplelightbox', function () {
                console.log('Image changed to prev');
            })
            .on('error.simplelightbox', function (e) {
                console.log('No image found, go to the next/prev');
                console.log(e);
            });
    });
</script> 
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
</body>
</html>
