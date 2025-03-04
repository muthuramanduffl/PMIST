<%@ Page Language="C#" AutoEventWireup="true" CodeFile="researchold.aspx.cs" Inherits="academic_researchold" %>

<%@ Register Src="~/PMIST/assets/includes/UCheader.ascx" TagName="UCheader" TagPrefix="UCheader" %>
<%@ Register Src="~/PMIST/assets/includes/UCDepartmentSubmenu.ascx" TagName="UCDepartmentSubmenu" TagPrefix="UCDepartmentSubmenu" %>


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
    <link href="../assets/css/academic/placement.css" rel="stylesheet">
    <link href="../assets/css/academic/new-sub-menu.css" rel="stylesheet">
    <style>
        /* .sub-menu {
      background: linear-gradient(104deg, #2F4088 0.77%, #181B61 50.61%, #2F4088 101.67%);
    } */
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <!-- HEADER -->
        <UCheader:UCheader id="header" runat="server" />
        <!-- END: HEADER -->


        <!-- banner section start  -->
        <section class="faculty banner-section">
            <img src="../assets/img/academic/banner-images/Faculty-banner.jpg" class="img-fluid">
            <div class="custom-container">
                <div class="banner-heading">
                    <h4 class="m-0">Department of computer science</h4>
                    <h1 class="m-0">Research</h1>
                </div>
            </div>
        </section>
        <!-- banner section End  -->

        <!-- sub-menu section start  -->
        <UCDepartmentSubmenu:UCDepartmentSubmenu id="UCDepartmentSubmenu" runat="server" />
        <!-- sub-menu section End  -->

        <section class="">



            <div class="custom-container">
                

                 <h1 class="placement-heading m-0">THRUST AREA: MOBILE AD HOC NETWORK</h1>
      <p class="placement-content pb-4">Wireless communications is a rapidly developing technology that enables people to access networks and services without cables. Even though several wireless technologies have been introduced, forming Mobile Ad hoc Network without interference is still not possible. Especially, construction of inference free enhanced MANET is a challenging issue in the rural and disaster scenarios. Moreover, formation of MANET cannot be confined to a particular wireless technology, because each technology has its own highlights and limitations. So, it is essential to design and develop a protocol which facilitates to structure MANET and transfer data through any form of wireless technology either it may use radio waves or light waves without any inference issues.</p>
    
      <h1 class="placement-heading m-0">THRUST AREA: STREAMING DATA ANALYTICS</h1>
      <p class="placement-content pb-4">Predictive analytics is used to forecast the upcoming outcome by learning the existing dataset. Building a predictive model for streamlining data is a more challenging one, as the distribution of data varies over time. The built old predictive model will not be suitable for the newly incoming data and hence the model has to be adaptable with the data distribution whenever needed.</p>

      <h1 class="placement-heading m-0">THRUST AREA: Video Analytics</h1>
      <p class="placement-content pb-4">Governments and law enforcement authorities have used video surveillance in various circumstances ranging from the investigation of crimes, the protection of urban environments and government buildings, traffic control, the monitoring of demonstrators and in the context of criminal investigations. The proposed system helps to find the abnormal behaviours/activities of human beings in heterogeneous environment.</p>

      <h1 class="placement-heading m-0">THRUST AREA: Visual Analytics</h1>
      <p class="placement-content pb-4">Data representation and similarity measurement are two basic aspects of similarity detection in time series data mining. This proposed visual analytics system performs similarity detection efficiently and effectively with the help of a new time series representation model and a corresponding similarity measure.</p>
    
                
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

</script>
    </form>
</body>
</html>
