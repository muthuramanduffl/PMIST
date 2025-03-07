<%@ Page Language="C#" AutoEventWireup="true" CodeFile="centre-for-energy-and-environmentold.aspx.cs" Inherits="centre_ceeold" %>
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
   </head>
   <body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
           <!-- HEADER -->
           <UCheader:UCheader id="header" runat="server" />
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
                     <h1 class="page-heading btn-line position-relative" >
                        CENTRE FOR ENERGY AND ENVIRONMENT (CEE)
                     </h1>
                     
                     <!-- sub menu list START -->
                     <UCCentreSubmenu:UCCentreSubmenu id="UCCentreSubmenu" runat="server"/>
                     <!-- sub menu list END -->
                  </div>
                  <div class="col-md-9 p-0 ">
                     <div class="centre-content-side">
                        <div class="pe-3 pe-sm-5">
                           <p class="centre-content">
                              The Centre for Energy and Environment (CEE) in PMIST plays a significant role in facilitating innovative research activities in the area of Energy and Environment. It also established ENVIRONMENT INFORMATION CENTRE funded by Department of Environment, Govt. of Tamil Nadu. CEE was the first recipient of the prestigious state award “Karmaveerar Kamarajar Award” in 2009 from the Government of Tamilnadu. The CEE has been recognised through various renewable energy gadgets such as Biomethanation Plant, Solar energy and Biomass Gasifier Unit.
                           </p>
                        </div>
                        <div class="pe-3 pe-sm-5 pb-sm-4 pb-4">
                           <h1 class="centre-heading m-0">
                              Objectives
                           </h1>
                           <ul class="p-0 pt-2 mb-0" >
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">To offer Consultancy services to Industries and/or Organizations</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">To develop a coordination among various agencies and organizations for conducting Training programmes.</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">To develop cost effective energy gadgets</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">To provide training on cutting edge technologies in solar and bio energy</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">To Promote entrepreneurship in energy production</li>
                              </div>
                           </ul>
                        </div>
                        <div class="pe-3 pe-sm-5 pb-sm-4 pb-4">
                           <h1 class="centre-heading m-0">
                              Green Practices
                           </h1>
                           <ul class="p-0 pt-2 mb-0">
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">Practicing International 5R's (Refuse, Reduce, Reuse, Recycle and Recover) concept on Solid Waste Management.</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Installed India's first 500 m3 capacity multifeed Biomethanisation plant which produces 60KWe energy from waste.</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">Implementing rain water harvesting techniques and harvested 80,000m3 per annum within the campus.</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Reduced the CO2 emission with a quantum of 32,340 tonnes per year.</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">Bamboo Cultivation in PMIST over an area of 10 acres under National Bamboo Mission Programme.</li>
                              </div>
                           </ul>
                        </div>
                        <div class="pe-3 pe-sm-5 pb-sm-4 pb-4">
                           <h1 class="centre-heading m-0">
                              Facilities Available
                           </h1>
                           <ul class="p-0 pt-2 mb-0">
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">Supported by Civil Engineering, Mechanical Engineering, Electrical Engineering, Biotechnology and Nanotechnology departments etc</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Designed, fabricated and operating 1 kW, 2 kW and 20 kW Bio mass gasification plants.</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">2 kWe on grid solar systems for solar photovoltaic research</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">4.05 kWe solar power plants for lighting load in hostel dining hall and kitchen</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">15000 lpd solar water heater in hostels and guest house</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Sophisticated equipment for bio energy research such as Thermo Gravimetric Analyzer, Gas Chromatograph, Portable Biomass Gas Analyzer, Portable Exhaust Gas Analyzer, Bomb Calorimeter, etc.</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">Briquetting Machine for conversion of agro residue such as coir pith, saw dust, rice husk etc., into biomass fuel.</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">500 m3 Power based Biomethanation plant</li>
                              </div>
                           </ul>
                        </div>
                        <div class="pe-3 pe-sm-5 pb-sm-4 pb-4">
                           <h1 class="centre-heading m-0">
                              Facilities Available
                           </h1>
                           <ul class="p-0 pt-2 mb-0">
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">Mass Pledge on Open Defecation free</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Green Marathon</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">One Day Workshop on Waste Management in Hospitals</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">One Day Training Programme on Vermicomposting for Transgender</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">Two day workshop on Open Defecation free for the Rural People</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Two day workshop on Capacity Building on Bhuvan Map based Skill Set</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">One day Workshop on Wastewater Management and Solid waste management</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">One day workshop on Terrace Garden</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">All India Seminar on Innovative Approached towards Solid waste Management</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Two day Workshop on Waste to Energy</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">International Conference on Environment and Natural Science</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Jal Divas</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">Rally conducted for creating awareness on Water Management</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Engineers Day and Ozone day</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">Swachhata Hi Sewa Campaign</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Water Conservation Awareness Campaign- Neerinri Amayathu Ulagu</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/blue-tick.svg">
                                 <li class="">International Conference on Combating Climate Change, Saving Lives and Sustainable Development</li>
                              </div>
                              <div class="d-flex align-items-start list-tick mb-3">
                                 <img src="../assets/img/academic/home-page/pink-tick.svg">
                                 <li class="">Online Quiz Competition- World Environment Day</li>
                              </div>
                           </ul>
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
         function prev(){
             document.getElementById('slider-container').scrollLeft -= 270;
         }
         
         function next()
         {
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