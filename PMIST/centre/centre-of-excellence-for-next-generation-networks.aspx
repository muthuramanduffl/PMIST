<%@ Page Language="C#" AutoEventWireup="true" CodeFile="centre-of-excellence-for-next-generation-networks.aspx.cs" Inherits="centre_cengn" %>

<%@ Register Src="~/PMIST/assets/includes/UCheader.ascx" TagName="UCheader" TagPrefix="UCheader" %>
<%@ Register Src="~/PMIST/assets/includes/UCCentreSubmenu.ascx" TagName="UCCentreSubmenu" TagPrefix="UCCentreSubmenu" %>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PMIST</title>
    <link rel="icon" type="image/x-icon" href="../assets/img/fav-icon.png">
    <link href="../assets/css/bootstrap5-3-2.min.css" rel="stylesheet">
    <link href="../assets/css/jquery.fancybox.min.css" rel="stylesheet">
    <link href="../assets/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
    <link href="../assets/css/aos.css" rel="stylesheet">
    <link href="../assets/css/swiper.min.css" rel="stylesheet">
    <link href="../assets/css/owl.carousel.min.css" rel="stylesheet">
    <link href="../assets/css/owl.theme.css" rel="stylesheet">
    <link href="../assets/css/style.css" rel="stylesheet">
    <link href="../assets/css/centre/centre-common.css" rel="stylesheet">
    <link href="../assets/css/centre/centre-of-excellence-for-next-generation-networks.css" rel="stylesheet">

        <style>
        /* start */
        .BindToBackend ul, ol {
            list-style: none;
       
           
        }


        .BindToBackend li {
            position: relative;
            padding-left: 30px;
            font-size: 16px;
            line-height: 1.5;
        }

        .BindToBackend ul li::before, ol li::before {
            content: "";
            position: absolute;
            left: 0;
            top: 4px;
            width: 20px;
            height: 20px;
            background-size: contain;
            background-repeat: no-repeat;
        }

        /* Blue Tick for Odd Items */
        .BindToBackend ul li:nth-child(odd)::before, ol li:nth-child(odd)::before {
            background-image: url('../assets/img/icon/blue-tick.svg');
        }

        /* Red Tick for Even Items */
        .BindToBackend ul li:nth-child(even)::before, ol li:nth-child(even)::before {
            background-image: url('../assets/img/icon/red-tick.svg');
        }

        /* end */
    </style>

</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <!-- HEADER -->
        <UCheader:UCheader ID="header" runat="server" />
        <!-- END: HEADER -->






        <!-- banner section start  -->
        <section class="faculty banner-section">
            <img src="../assets/img/centre/banner.jpg" class="img-fluid w-100">
            <div class="custom-container">
            </div>
        </section>
        <!-- banner section End  -->
        <section class="centre">
            <div class="ps-md-5 ps-4">
                <div class="pt-5">
                    <div class="row m-0">
                        <div class="col-md-3 p-0 pb-md-0 pb-sm-5 pb-4">
                            <h1 class="page-heading btn-line position-relative">Centre Of Excellence For Next Generation Networks
                            </h1>
                            <!-- sub menu list START -->
                            <UCCentreSubmenu:UCCentreSubmenu ID="UCCentreSubmenu" runat="server" />
                            <!-- sub menu list END -->
                        </div>
                        <div class="col-md-9 p-0 ">
                            <div class="centre-content-side">


                                <asp:Repeater ID="Repeater1" ClientIDMode="Static" runat="server">
                                    <ItemTemplate>
                                        <div class=" BindToBackend pe-3 pe-sm-5">
                                            <%# Eval("Content")%>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>

                             

                                <div class="pe-3 pe-sm-5  vision-mission-full position-relative">
                                    <div class="row m-0 vision-mission-gap">
                                        <div class="col-lg-6 col-12 pe-lg-2 pe-0 ps-lg-2 ps-0">
                                            <div class="vision-mission">
                                                <div class="vision-mission-heading">
                                                    <div class="d-flex align-items-center">
                                                        <div class="heading-icon d-flex align-items-center justify-content-center">
                                                            <img src="../assets/img/centre/vision-mission-icon.svg">
                                                        </div>
                                                        <h1 class="vision-mission-title m-0">Vision</h1>
                                                    </div>
                                                    <p class="vision-mission-content">To be a world class training institute in telecommunication networks, recognized as employment generator through true commitment for quality training and corporate social responsibility.</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-6 col-12 pe-lg-2 pe-0 ps-lg-2 ps-0">
                                            <div class="vision-mission">
                                                <div class="d-flex align-items-center">
                                                    <div class="heading-icon d-flex align-items-center justify-content-center">
                                                        <img src="../assets/img/centre/vision-mission-icon.svg">
                                                    </div>
                                                    <h1 class="vision-mission-title m-0">Mission</h1>
                                                </div>
                                                <ul class="p-0 vision-mission-listing  mb-0">
                                                    <div class="d-flex align-items-start list-circle mb-3">
                                                        <img src="../assets/img/centre/vision-mission-list.svg">
                                                        <li class="text-white">To make students industry ready by bridging the gap between what a traditional educational institute teaches and what the industry requires.</li>
                                                    </div>
                                                    <div class="d-flex align-items-start list-circle  mb-3">
                                                        <img src="../assets/img/centre/vision-mission-list.svg">
                                                        <li class="text-white">To provide ecosystem for skill development and quality assurance of personnel in the Telecom sector.</li>
                                                    </div>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="pe-3 pe-sm-5">
                                    <div class="contact py-5 position-relative">
                                        <div class=" contact-details">
                                            <h1 class="contact-heading">Contact</h1>
                                            <h3 class="contact-name">Director (i/c)</h3>
                                            <p class="role">Centre Of Excellence For Next Generation Networks<br>
                                                Periyar Maniammai Institute of Science and Technology,<br>
                                                Thanjavur</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <script src="../assets/js/jquery.min.js"></script>
        <script src="../assets/js/bootstrap-bundle.min.js"></script>
        <script src="../assets/js/jquery.fancybox.min.js"></script>
        <script src="../assets/js/aos.js"></script>
        <script src="../assets/js/swiper.min.js"></script>
        <script src="../assets/js/owl.carousel.min.js"></script>
        <script src="../assets/js/main.js"></script>
        <script>
            function prev() {
                document.getElementById('slider-container').scrollLeft -= 270;
            }

            function next() {
                document.getElementById('slider-container').scrollLeft += 270;
            }


            // $(".slide img").on("click" , function(){
            //   $(this).toggleClass('zoomed');
            //   $(".overlay").toggleClass('active');
            // })
        </script>
    </form>
</body>
</html>
