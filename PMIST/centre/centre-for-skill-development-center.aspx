<%@ Page Language="C#" AutoEventWireup="true" CodeFile="centre-for-skill-development-center.aspx.cs" Inherits="centre_skill_development" %>

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
    <link href="../assets/css/centre/centre-for-skill-development-center.css" rel="stylesheet">


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



        <!-- banner section start  -->
        <section class="faculty banner-section">
            <img src="../assets/img/centre/banner.jpg" class="img-fluid w-100">
            <div class="custom-container">
            </div>
        </section>
        <!-- banner section End  -->
        <section class="centre">
            <div class="ps-md-5 ps-4">
                <div class="py-5">
                    <div class="row m-0">
                        <div class="col-md-3 p-0 pb-md-0 pb-sm-5 pb-4">
                            <h1 class="page-heading btn-line position-relative">Centre for Skill Development Center
                            </h1>
                            <!-- sub menu list START -->
                            <UCCentreSubmenu:UCCentreSubmenu ID="UCCentreSubmenu" runat="server" />
                            <!-- sub menu list END -->
                        </div>

                        <div class="col-md-9 p-0 ">
                            <div class="centre-content-side">
                                <div class="pe-3 pe-sm-5 pb-sm-4 pb-4">
                                    <asp:Repeater ID="rprenvironment" runat="server">
                                        <ItemTemplate>
                                            <h1 class="centre-heading m-0">
                                                <%# Eval("Title")%>
                                            </h1>
                                            <div class=" BindToBackend align-items-start list-tick mb-3 mt-3">
                                                <%# Eval("Content")%>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>



                                <div class="teaching-staff px-4 px-sm-5 pb-sm-5 pb-4">
                                    <h1>Programmes Organized by CHRD for Teaching Staff</h1>
                                    <p class="m-0">Our Institution was approved by the PMKVY- Skill Hub Program Centre for implementing the Skill India Digital courses. So in this regard we identified our students from the department of Aero Space Engineering, Mechanical Engineering, Electrical and Electronic Engineering, Electrical and Electronic Engineering, Electronics and Communication Engineering and Computer Science and Engineering for enrolled in the following courses. 1. Drone Manufacturing and Assembly -150 candidates & 2. IoT Hardware Analyst – 90 candidates. Total Sanctioned in take strength are 240 nos. The training payout to project implementing agency would be as per PMKVY 4.0 scheme.</p>
                                </div>
                                <div class="pe-3 pe-sm-5">
                                    <div class="contact py-5 position-relative">
                                        <div class="row align-items-center">
                                            <div class="col-sm-3 ">
                                                <div class="contact-profile">
                                                    <img src="../assets/img/centre/contact-profile-img.jpg" class="img-fluid w-100">
                                                </div>
                                            </div>
                                            <div class="col-sm-9 p-0 ps-4 contact-details">
                                                <h1 class="contact-heading">Contact</h1>
                                                <h3 class="contact-name">Dr. L. Aruna, M.Sc., M.Phil., Ph.D., MBA, M.Phil., M.Tech. (CSE)</h3>
                                                <p class="role">Director - Skill Development & Entrepreneurship,</p>
                                                <p class="role">PMIST.</p>
                                                <h6 class="mbl-number">Mobile Number: <span>7010368543</span></h6>
                                                <h6 class="mbl-number">Email Address: <span>dircsd@pmu.edu.</span></h6>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="slider-section position-relative py-sm--5 py-5">
                                    <asp:Panel ID="Panel1" runat="server">
                                        <div class="slider-section position-relative py-sm--5 py-5">
                                            <div id="slideridcontainer" class="slider">
                                                <asp:Repeater ID="Repimage" runat="server">
                                                    <ItemTemplate>
                                                        <div class="image-container slide">
                                                            <img src='<%# Eval("Images") %>' class="slider-image" />
                                                        </div>
                                                    </ItemTemplate>
                                                </asp:Repeater>

                                                <div onclick="prev()" class="control-prev-btn">
                                                    <img src="../assets/img/centre/left-arrow.svg">
                                                </div>
                                                <div onclick="next()" class="control-next-btn">
                                                    <img src="../assets/img/centre/right-arrow.svg">
                                                </div>
                                            </div>
                                        </div>
                                    </asp:Panel>
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


        </script>
    </form>
</body>
</html>
