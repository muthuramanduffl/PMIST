<%@ Page Language="C#" AutoEventWireup="true" CodeFile="centre-for-students-and-administrative-services.aspx.cs" Inherits="PMIST_website_centre_centre_for_students_and_administrative_services" %>

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
    <link href="../assets/css/style.css" rel="stylesheet" />
    <link href="../assets/css/centre/centre-common.css" rel="stylesheet" />
    <link href="../assets/css/centre/centre-for-students-and-administrative-services.css" rel="stylesheet" />



    <style>
        /* start */
        ul, ol {
            list-style: none;
            padding: 0;
            margin: 0;
        }

        li {
            position: relative;
            padding-left: 30px;
            font-size: 16px;
            line-height: 1.5;
        }

        ul li::before, ol li::before {
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
        ul li:nth-child(odd)::before, ol li:nth-child(odd)::before {
            background-image: url('../assets/img/icon/blue-tick.svg');
        }

        /* Red Tick for Even Items */
        ul li:nth-child(even)::before, ol li:nth-child(even)::before {
            background-image: url('../assets/img/icon/red-tick.svg');
        }

        /* end */
    </style>

</head>

<body>
    <form id="form1" runat="server">
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
                            <h1 class="page-heading btn-line position-relative">Centre For Students and Administrative Services
                            </h1>
                            <div class="accordion" id="accordionExample">
                                <div class="accordion-item">
                                    <h2 class="accordion-header pe-4">
                                        <button class="accordion-button ps-0 pe-0 collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-controls="collapseOne">
                                            More Centres
                                        </button>
                                    </h2>
                                    <div id="collapseOne" class="accordion-collapse collapse " data-bs-parent="#accordionExample">
                                        <div class="accordion-body ps-0">
                                            <h1 class="centres-list"><a href="">Centre for Institute Industry Interaction (CIII)</a></h1>
                                            <h1 class="centres-list"><a href="centre-for-skill-development-center.html">Centre for Skill Development Centre</a></h1>
                                            <h1 class="centres-list"><a href="">Dr.Kalaignar M.Karunanithi Centre For Political Science (KKCPS)</a></h1>
                                            <h1 class="centres-list"><a href="veeramani-mohana-centre-for-quality-of-life-engineering-research.html">Veeramani Mohana Centre For Quality Life Engineering Research</a></h1>
                                            <h1 class="centres-list"><a href="">Centre for Human Resource Development</a></h1>
                                            <h1 class="centres-list"><a href="centre-for-energy-and-environment-cee.html">Centre for Energy and Environment (CEE)</a></h1>
                                            <h1 class="centres-list"><a href="">Centre Of Excellence For Training And Research In Automation Technologies</a></h1>
                                            <h1 class="centres-list"><a href="centre-of-excellence-for-next-generation-networks.html">Centre Of Excellence For Next Generation Networks</a></h1>
                                            <h1 class="centres-list"><a href="">Centre Of Excellence For Periyar Thought</a></h1>
                                            <h1 class="centres-list"><a href="">Centre for Scholarly Scientific Training and Publishing (CSSTP)</a></h1>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-9 p-0 ">
                            <div class="centre-content-side">
                                <div class="pe-3 pe-sm-5 pb-sm-4 pb-4">
                                    <h1 class="centre-heading m-0">ACTIVITIES OF THE CENTRE
                                    </h1>
                                    <ul class="p-0 pt-2 mb-0">

                                        <asp:Repeater ID="Repeater1" ClientIDMode="Static" runat="server">
                                            <ItemTemplate>
                                                <div class="d-flex align-items-start list-tick mb-3">
                                                    <%# Eval("Content")%>
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <%--  <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/blue-tick.svg">
                                            <li class="">Conduct students' activities for the development of personality, organizing skills and leadership skills through clubs and societies.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/pink-tick.svg">
                                            <li class="">Organize competitions, workshops, lectures and other programmes through clubs and societies.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/blue-tick.svg">
                                            <li class="">Address the students' grievances through the Grievances and Redressal Committee.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/pink-tick.svg">
                                            <li class="">Form committees to ensure discrimination and ragging free campus.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/blue-tick.svg">
                                            <li class="">Conduct of students' council election in a democratic way each year.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/pink-tick.svg">
                                            <li class="">Assist students in obtaining passports.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/blue-tick.svg">
                                            <li class="">Prepare bi-monthly news bulletin and monthly e-news bulletin.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/pink-tick.svg">
                                            <li class="">Collaborate with various professional bodies like ISTE, NSSW, INTACH, IEEE, SESI, AeSI, BES, INS, and CSI in conducting activities for the benefit of students and faculty.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/blue-tick.svg">
                                            <li class="">Provide identification cards to students and employees of the institution.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/pink-tick.svg">
                                            <li class="">Conduct institute level annual cultural festivals.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/blue-tick.svg">
                                            <li class="">Work in tandem with student counsellor.</li>
                                        </div>
                                        <div class="d-flex align-items-start list-tick mb-3">
                                            <img src="../assets/img/academic/home-page/pink-tick.svg">
                                            <li class="">Form Student Discipline Committee and conduct enquiry whenever a student breaches the institute code of conduct.</li>
                                        </div>--%>
                                    </ul>
                                </div>
                                <div class="pe-3 pe-sm-5 pb-sm-4 pb-4">
                                    <div class="table-responsive ">
                                        <table class="table table-bordered table-custom">
                                            <thead>
                                                <tr>
                                                    <th style="width: 40%;">Clubs</th>
                                                    <th style="width: 60%;">Societies</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>1. Energy Club</td>
                                                    <td>1. Dance and Music Society </td>
                                                </tr>
                                                <tr>
                                                    <td>2. Environment Club</td>
                                                    <td>2. Debating Society</td>
                                                </tr>
                                                <tr>
                                                    <td>3. Humanist Club</td>
                                                    <td>3. Foreign Language and Culture Society (German, Chinese, etc.,)</td>
                                                </tr>
                                                <tr>
                                                    <td>4. Photography & Media Club</td>
                                                    <td>4. Tamil Mandram</td>
                                                </tr>
                                                <tr>
                                                    <td>5. Painters Club</td>
                                                    <td>1. Dance and Music Society</td>
                                                </tr>
                                                <tr>
                                                    <td>6. Public Affairs Club</td>
                                                    <td>1. Dance and Music Society</td>
                                                </tr>
                                                <tr>
                                                    <td>7. Rationalist Club</td>
                                                    <td>1. Dance and Music Society</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="pe-3 pe-sm-5">
                                    <div class="contact pb-4 position-relative btn-line ">
                                        <div class=" contact-details">
                                            <h1 class="contact-heading">Contact</h1>
                                            <div class="row pt-3 align-items-center contact-part-line position-relative justify-content-between contact-set">

                                                <asp:Repeater ID="repContact" ClientIDMode="Static" runat="server">
                                                    <ItemTemplate>
                                                        <div class="col-xl-4" runat="server">

                                                            <h3 class="contact-name"><%#!string.IsNullOrEmpty(Eval("Cname_one").ToString())? Eval("Cname_one").ToString() :" " %></h3>
                                                            <h2 class="Research"><%#!string.IsNullOrEmpty(Eval("Designamtion_one").ToString())? Eval("Designamtion_one").ToString() :" " %></h2>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("Mobilenumber_one").ToString())%>'>Mobile Number: <span><%#Eval("Mobilenumber_one")%> </span></h6>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("EmailID_one").ToString())%>'>Email Address: <span><%# Eval("EmailID_one") %></span></h6>
                                                        </div>
                                                        <div class="col-xl-4" runat="server">

                                                            <h3 class="contact-name"><%#!string.IsNullOrEmpty(Eval("Cname_two").ToString())? Eval("Cname_two").ToString() :" " %> </h3>
                                                            <h2 class="Research"><%#!string.IsNullOrEmpty(Eval("Designamtion_two").ToString())? Eval("Designamtion_two").ToString() :" " %>  </h2>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("Mobilenumber_two").ToString())%>'>Mobile Number: <span><%# Eval("Mobilenumber_two")%></span></h6>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("EmailID_two").ToString())%>'>Email Address: <span><%# Eval("EmailID_two")%> </span></h6>
                                                        </div>
                                                        <div class="col-xl-4" runat="server">
                                                            <h3 class="contact-name"><%#!string.IsNullOrEmpty(Eval("Cname_three").ToString())? Eval("Cname_three").ToString() :" " %></h3>
                                                            <h2 class="Research"><%#!string.IsNullOrEmpty(Eval("Designamtion_three").ToString())? Eval("Designamtion_three").ToString() :" " %> </h2>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("Mobilenumber_three").ToString())%>'>Mobile Number: <span><%#Eval("Mobilenumber_three")%> </span></h6>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("EmailID_three").ToString())%>'>Email Address: <span><%# Eval("EmailID_three").ToString() %></span></h6>
                                                        </div>
                                                    </ItemTemplate>
                                                </asp:Repeater>



                                                <%-- <div class="col-xl-4">
                                                    <h3 class="contact-name">Dr.C.V.Subramanian</h3>
                                                    <h2 class="Research">Director - CSAS</h2>
                                                    <h6 class="mbl-number">Mobile Number: <span>+91 9790001588</span></h6>
                                                    <h6 class="mbl-number">Email Address: <span>dircsas@pmu.edu</span></h6>
                                                </div>
                                                <div class="col-xl-4">
                                                    <h3 class="contact-name">Dr. N. Muruganantham</h3>
                                                    <h2 class="Research">Deputy Director</h2>
                                                    <h6 class="mbl-number">Mobile Number: <span>+91 7904392171</span></h6>
                                                </div>
                                                <div class="col-xl-4">
                                                    <h3 class="contact-name">Dr.S.Gomathi</h3>
                                                    <h2 class="Research">Deputy Director</h2>
                                                    <h6 class="mbl-number">Mobile Number: <span>+91 8248503532</span></h6>
                                                </div>--%>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="slider-section position-relative py-sm--5 py-5">

                                    <div id="slider-container" class="slider">
                                        <asp:Repeater ID="Repimage" runat="server">
                                            <ItemTemplate>
                                                <div class="image-container slide">
                                                    <asp:Image ID="imgDisplay" runat="server" ImageUrl='<%# Eval("Images") %>' />
                                                    <asp:HiddenField ID="hdnsingleimage" Value='<%# Eval("Images") %>' runat="server" />
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>



                                        <%--<a class="slide" data-fancybox="hostel-slider" href="../assets/img/centre/slider01.jpg">
                                            <img src="../assets/img/centre/slider01.jpg" alt="">
                                        </a>
                                        <a class="slide" data-fancybox="hostel-slider" href="../assets/img/centre/slider02.jpg">
                                            <img src="../assets/img/centre/slider02.jpg" alt="">
                                        </a>
                                        <a class="slide" data-fancybox="hostel-slider" href="../assets/img/centre/slider03.jpg">
                                            <img src="../assets/img/centre/slider03.jpg" alt="">
                                        </a>
                                        <a class="slide" data-fancybox="hostel-slider" href="../assets/img/centre/slider01.jpg">
                                            <img src="../assets/img/centre/slider01.jpg" alt="">
                                        </a>
                                        <a class="slide" data-fancybox="hostel-slider" href="../assets/img/centre/slider02.jpg">
                                            <img src="../assets/img/centre/slider02.jpg" alt="">
                                        </a>
                                        <a class="slide" data-fancybox="hostel-slider" href="../assets/img/centre/slider03.jpg">
                                            <img src="../assets/img/centre/slider03.jpg" alt="">
                                        </a>
                                        <a class="slide" data-fancybox="hostel-slider" href="../assets/img/centre/slider01.jpg">
                                            <img src="../assets/img/centre/slider01.jpg" alt="">
                                        </a>
                                        <a class="slide" data-fancybox="hostel-slider" href="../assets/img/centre/slider02.jpg">
                                            <img src="../assets/img/centre/slider02.jpg" alt="">
                                        </a>--%>
                                        <div onclick="prev()" class="control-prev-btn">
                                            <img src="../assets/img/centre/left-arrow.svg">
                                        </div>
                                        <div onclick="next()" class="control-next-btn">
                                            <img src="../assets/img/centre/right-arrow.svg">
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
        </script>


        <script>
            document.addEventListener("DOMContentLoaded", function () {

                document.querySelector(".atag_link a").setAttribute("target", "_blank");
            });
        </script>

    </form>
</body>
</html>
