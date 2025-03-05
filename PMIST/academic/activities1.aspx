<%@ Page Language="C#" AutoEventWireup="true" CodeFile="activities1.aspx.cs" Inherits="PMIST_website_academic_Activities1" %>

<%@ Register Src="~/PMIST/assets/includes/UCheader.ascx" TagName="UCheader" TagPrefix="UCheader" %>
<%@ Register Src="~/PMIST/assets/includes/UCDepartmentSubmenu.ascx" TagName="UCDepartmentSubmenu" TagPrefix="UCDepartmentSubmenu" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>PMIST</title>
    <link rel="icon" type="image/x-icon" href="../assets/img/fav-icon.png" />
    <link href="../assets/css/bootstrap5-3-2.min.css" rel="stylesheet" />
    <link href="../assets/css/jquery.fancybox.min.css" rel="stylesheet" />
    <link href="../assets/bootstrap-icons/bootstrap-icons.css" rel="stylesheet" />
    <link href="../assets/css/aos.css" rel="stylesheet" />
    <link href="../assets/css/swiper.min.css" rel="stylesheet" />
    <link href="../assets/css/owl.carousel.min.css" rel="stylesheet" />
    <link href="../assets/css/owl.theme.css" rel="stylesheet" />

    <link href="../assets/css/academic/activities.css" rel="stylesheet" />
    <link href="../assets/css/academic/new-sub-menu.css" rel="stylesheet" />









    <link href="../assets/css/style.css" rel="stylesheet" />
    <link href="../assets/css/centre/centre-common.css" rel="stylesheet" />
    <link href="../assets/css/centre/centre-for-students-and-administrative-services.css" rel="stylesheet" />


    <style>
        /* start */
        .BindToBackend ul, ol {
            list-style: none;
            padding: 0;
            margin: 0;
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
            <img src="../assets/img/academic/banner-images/Faculty-banner.jpg" class="img-fluid">
            <div class="custom-container">
                <div class="banner-heading">
                    <h4 class="m-0">Department of computer science</h4>
                    <h1 class="m-0">Activities</h1>
                </div>
            </div>
        </section>
        <!-- banner section End  -->

        <!-- sub-menu section start  -->
        <UCDepartmentSubmenu:UCDepartmentSubmenu ID="UCDepartmentSubmenu" runat="server" />
        <!-- sub-menu section End  -->

        <section class="Activities  py-md-5  ">
            <div class="custom-container">
                <div class="full-page position-relative">

                    <h1 class="activities-heading">Activities</h1>

                    <div class="pt-3">
                        <div class="d-flex align-items-start list-tick mb-2">
                            <img src="../assets/img/academic/home-page/blue-tick.svg">
                            <h1 class="activities-sub-heading">B.Sc. - Animation and Multimedia</h1>
                        </div>
                        <p class="activities-content">The department of Aerospace arranged Industrial visit from 23.02.2019 to 25.02.2019 (3 days).Among all our visits to other industries in this period, the visit to VSSC (Vikram Sarabhai Space Center) Trivandrum, Kerala holds a greater importance as it provided a good exposure to the current trends in aerospace industry. We were a crew consisting of 26 boys and 12 girls with two faculty members. We arrived there approximately by 10:00 AM and after undergoing all the security procedures, we finally went into their premises by 11:00 AM.</p>
                    </div>

                    <div class="pt-3">
                        <div class="d-flex align-items-start list-tick mb-2">
                            <img src="../assets/img/academic/home-page/pink-tick.svg">
                            <h1 class="activities-sub-heading">Activities</h1>
                        </div>
                        <div class="pb-3 ">
                            <a href="" class="anchor-PDF">
                                <img src="../assets/img/academic/activities/pdf-icon.svg" alt="img" class="img-fluid pe-2">FDP on Python</a>
                        </div>

                        <div class="pb-3 ">
                            <a href="" class="anchor-PDF">
                                <img src="../assets/img/academic/activities/pdf-icon.svg" alt="img" class="img-fluid pe-2">IOT - 3D Modelling</a>
                        </div>

                        <div class="pb-3 ">
                            <a href="" class="anchor-PDF">
                                <img src="../assets/img/academic/activities/pdf-icon.svg" alt="img" class="img-fluid pe-2">MATLAB</a>
                        </div>

                        <div class="pb-3 ">
                            <a href="" class="anchor-PDF">
                                <img src="../assets/img/academic/activities/pdf-icon.svg" alt="img" class="img-fluid pe-2">SWARD</a>
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
    </form>
</body>
</html>
