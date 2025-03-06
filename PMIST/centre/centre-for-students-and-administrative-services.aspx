<%@ Page Language="C#" AutoEventWireup="true" CodeFile="centre-for-students-and-administrative-services.aspx.cs" Inherits="PMIST_website_centre_centre_for_students_and_administrative_services" %>

<%@ Register Src="~/PMIST/assets/includes/UCheader.ascx" TagName="UCheader" TagPrefix="UCheader" %>
<%@ Register Src="~/PMIST/assets/includes/UCCentreSubmenu.ascx" TagName="UCCentreSubmenu" TagPrefix="UCCentreSubmenu" %>

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
 .BindToBackendul li:nth-child(odd)::before, ol li:nth-child(odd)::before {
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
                            <h1 class="page-heading btn-line position-relative">Centre For Students and Administrative Services
                            </h1>
                            <!-- sub menu list START -->
                            <UCCentreSubmenu:UCCentreSubmenu ID="UCCentreSubmenu" runat="server" />
                            <!-- sub menu list END -->
                        </div>
                        <div class="col-md-9 p-0 ">
                            <div class="centre-content-side">
                                <div class="pe-3 pe-sm-5 pb-sm-4 pb-4">
                                    <h1 class="centre-heading m-0">ACTIVITIES OF THE CENTRE
                                    </h1>
                                    <ul class="p-0 pt-2 mb-0">

                                        <asp:Repeater ID="Repeater1" ClientIDMode="Static" runat="server">
                                            <ItemTemplate>
                                                <div class=" BindToBackend align-items-start list-tick mb-3">
                                                    <%# Eval("Content")%>
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>

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
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("Address_one").ToString())%>'><span><%# Eval("Address_one") %></span></h6>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("Mobilenumber_one").ToString())%>'><span>PH:<%#Eval("Mobilenumber_one")%> </span></h6>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("EmailID_one").ToString())%>'><span>EID:<%# Eval("EmailID_one") %></span></h6>

                                                        </div>
                                                        <div class="col-xl-4" runat="server">

                                                            <h3 class="contact-name"><%#!string.IsNullOrEmpty(Eval("Cname_two").ToString())? Eval("Cname_two").ToString() :" " %> </h3>
                                                            <h2 class="Research"><%#!string.IsNullOrEmpty(Eval("Designamtion_two").ToString())? Eval("Designamtion_two").ToString() :" " %>  </h2>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("Address_two").ToString())%>'><span><%# Eval("Address_two") %></span></h6>

                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("Mobilenumber_two").ToString())%>'><span>PH:<%# Eval("Mobilenumber_two")%></span></h6>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("EmailID_two").ToString())%>'><span>EID:<%# Eval("EmailID_two")%> </span></h6>

                                                        </div>
                                                        <div class="col-xl-4" runat="server">
                                                            <h3 class="contact-name"><%#!string.IsNullOrEmpty(Eval("Cname_three").ToString())? Eval("Cname_three").ToString() :" " %></h3>
                                                            <h2 class="Research"><%#!string.IsNullOrEmpty(Eval("Designamtion_three").ToString())? Eval("Designamtion_three").ToString() :" " %> </h2>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("Address_three").ToString())%>'><span><%# Eval("Address_three") %></span></h6>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("Mobilenumber_three").ToString())%>'><span>PH:<%#Eval("Mobilenumber_three")%> </span></h6>
                                                            <h6 class="mbl-number" runat="server" visible='<%#!string.IsNullOrEmpty(Eval("EmailID_three").ToString())%>'><span>EID:<%# Eval("EmailID_three").ToString() %></span></h6>


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




        <script>
            document.addEventListener("DOMContentLoaded", function () {

                document.querySelector(".atag_link a").setAttribute("target", "_blank");
            });
        </script>

    </form>
</body>
</html>
