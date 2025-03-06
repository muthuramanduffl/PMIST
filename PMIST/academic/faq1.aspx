<%@ Page Language="C#" AutoEventWireup="true" CodeFile="faq1.aspx.cs" Inherits="academic_faq1" %>
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
 <link href="../assets/css/academic/faq.css" rel="stylesheet">
 <link href="../assets/css/academic/new-sub-menu.css" rel="stylesheet">
 <style>
    /* .sub-menu {
      background: linear-gradient(104deg, #2F4088 0.77%, #181B61 50.61%, #2F4088 101.67%);
    } */
 </style>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
           <!-- HEADER -->
           <UCheader:UCheader id="header" runat="server" />
           <!-- END: HEADER -->

  <!-- banner section start  -->
  <section class="faculty banner-section">
    <img src="../assets/img/academic/banner-images/Faculty-banner.jpg" class="img-fluid">
    <div class="custom-container">
      <div class="banner-heading">
        <h4 class="m-0">Department of computer science</h4>
        <h1 class="m-0">Faq</h1>
      </div>
    </div>
  </section>
  <!-- banner section End  -->

  <!-- sub-menu section start  -->
  <UCDepartmentSubmenu:UCDepartmentSubmenu id="UCDepartmentSubmenu" runat="server"/>
  <!-- sub-menu section End  -->


  <div class="custom-container">
    <div class="accordion pb-5" id="accordionExample">
      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
            1. What is M.Sc. (computer science) Programme?
          </button>
        </h2>
        <div id="collapseOne" class="accordion-collapse collapse show" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            M.Sc. (computer science) is a five year integrated programme associated with development of software product using well-defined scientific principles, methods and procedures. The outcome of software engineering is an efficient and reliable software product which involves Requirements, System Analysis, System Design, Coding, Testing, Deployment and Maintenance.
          </div>
        </div>
      </div>

      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
            2. What is B.Sc. (Animation and Multimedia) programme?
          </button>
        </h2>
        <div id="collapseTwo" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            CB.Sc. Animation and Multimedia is a three year undergraduate programme. The Program helps to produce full-fledged animation professionals with the skills & confidence to build a rewarding career in the field.
          </div>
        </div>
      </div>

      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
            3. What is B.Sc. (Computer Science) programme?
          </button>
        </h2>
        <div id="collapseThree" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            B.Sc. Computer Science is a three year undergraduate programme which deals with courses and topics related to computer application and services.Technological implementation of computer systems is the main agenda of the program.
          </div>
        </div>
      </div>

      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseFour" aria-expanded="false" aria-controls="collapseFour">
            4. What will I learn in the M.Sc. (computer science)programme?
          </button>
        </h2>
        <div id="collapseFour" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            computer science requires a comprehensive technical skill set and knowledge base that ranges from understanding software requirements to computer science management.
            <ul class="p-0 pt-3 pt-sm-4">
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/blue-tick.svg">
              <li class="Program-overview-content">Software Requirements</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/pink-tick.svg">
              <li class="Program-overview-content">computer science Tools</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/blue-tick.svg">
              <li class="Program-overview-content">Software Development Process</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/pink-tick.svg">
              <li class="Program-overview-content">Software Testing</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
                  <img src="../assets/img/academic/home-page/blue-tick.svg">
                  <li class="Program-overview-content">Software Design</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
                  <img src="../assets/img/academic/home-page/pink-tick.svg">
                  <li class="Program-overview-content">Software Maintenance</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/blue-tick.svg">
                <li class="Program-overview-content">Software Quality</li>
                </div>
                <div class="d-flex align-items-start list-tick mb-3">
                    
                    <img src="../assets/img/academic/home-page/pink-tick.svg">
                    <li class="Program-overview-content">Software Development</li>
                </div>
                <div class="d-flex align-items-start list-tick mb-3">
                  <img src="../assets/img/academic/home-page/blue-tick.svg">
                    <li class="Program-overview-content">Software Configuration Management</li>
                </div>
                <div class="d-flex align-items-start list-tick mb-3">
                  <img src="../assets/img/academic/home-page/pink-tick.svg">
                  <li class="Program-overview-content">computer science Management</li>
              </div>
          </ul>
          </div>
        </div>
      </div>

      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseFive" aria-expanded="false" aria-controls="collapseFive">
            5. What will I learn in the B.Sc. (Animation and Multimedia) programme?
          </button>
        </h2>
        <div id="collapseFive" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            The course imparts knowledge and the right skills in multimedia and animation disciplines that leads to a successful career in the designing and animation field. There is no Movie, TV serial or advertisement without VFX/Animation.The students will get the skill set and knowledge base that ranges from Free Hand Drawing to 3D Modelling.
            <ul class="p-0 pt-3 pt-sm-4">
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/blue-tick.svg">
              <li class="Program-overview-content">Free Hand Drawing</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/pink-tick.svg">
              <li class="Program-overview-content">Digital Arts</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/blue-tick.svg">
              <li class="Program-overview-content">Visual Design</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/pink-tick.svg">
              <li class="Program-overview-content">Claymation</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
                  <img src="../assets/img/academic/home-page/blue-tick.svg">
                  <li class="Program-overview-content">Cinematography</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
                  <img src="../assets/img/academic/home-page/pink-tick.svg">
                  <li class="Program-overview-content">Television Production</li>
              </div>

              <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/blue-tick.svg">
                <li class="Program-overview-content">Story Board Writing</li>
                </div>
                <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/pink-tick.svg">
                <li class="Program-overview-content">2D Animation</li>
                </div>
                <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/blue-tick.svg">
                <li class="Program-overview-content">3D Modelling</li>
                </div>
                <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/pink-tick.svg">
                <li class="Program-overview-content">3D Animation</li>
                </div>
                <div class="d-flex align-items-start list-tick mb-3">
                    <img src="../assets/img/academic/home-page/blue-tick.svg">
                    <li class="Program-overview-content">Film Making</li>
                </div>
                <div class="d-flex align-items-start list-tick mb-3">
                    <img src="../assets/img/academic/home-page/pink-tick.svg">
                    <li class="Program-overview-content">Game Design</li>
                </div>
          </ul>
          </div>
        </div>
      </div>

      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseSix" aria-expanded="false" aria-controls="collapseSix">
            6. What will I learn in the B.Sc. (Computer Science)programme?
          </button>
        </h2>
        <div id="collapseSix" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            B.Sc. Computer Science is the study of principles and fundamentals of computers, where latest technologies and trends are the most important topics. The course empowers students to deal with the technical issues with authorized knowledge of Software, databases and analytical skills.
          </div>
        </div>
      </div>

      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseShaven" aria-expanded="false" aria-controls="collapseShaven">
            7. What are the scope of M.Sc. (computer science) in India and Abroad?
          </button>
        </h2>
        <div id="collapseShaven" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <ul class="p-0 pt-3 pt-sm-4">
            <div class="d-flex align-items-start list-tick mb-3">
            <img src="../assets/img/academic/home-page/blue-tick.svg">
            <li class="Program-overview-content">computer science is one of the top recruiters in India and Abroad.</li>
            </div>
            <div class="d-flex align-items-start list-tick mb-3">
            <img src="../assets/img/academic/home-page/pink-tick.svg">
            <li class="Program-overview-content">There are huge scope for computer science students due to the fast growing of IT industries. Ample career options are available in the field of computer science.</li>
            </div>
            <div class="d-flex align-items-start list-tick mb-3">
            <img src="../assets/img/academic/home-page/blue-tick.svg">
            <li class="Program-overview-content">Plenty of jobs are available in software companies for software engineers. There is also a need for software engineers in the public sector.</li>
            </div>
            <div class="d-flex align-items-start list-tick mb-3">
            <img src="../assets/img/academic/home-page/pink-tick.svg">
            <li class="Program-overview-content">After gaining good experience one can start their own software firm.</li>
            </div>
            <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/blue-tick.svg">
                <li class="Program-overview-content">Software engineers can also choose their profession in teaching.</li>
            </div>
            <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/pink-tick.svg">
                <li class="Program-overview-content">Software Engineers can also work in Public & private sector banks, schools and colleges & financial institutions.</li>
            </div>

            <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/blue-tick.svg">
              <li class="Program-overview-content">As a Software Engineer, one can also run consultancy to develop & repair software as per the requirements of the clients.</li>
              </div>
              
              
        </ul>
        </div>
      </div>

      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseEight" aria-expanded="false" aria-controls="collapseEight">
            8. What are the scope of B.Sc (Animation And Multimedia) in India and Abroad?
          </button>
        </h2>
        <div id="collapseEight" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            Animation itself is an industry, which is rapidly growing. There is a great scope in the field of animation.
            <ul class="p-0 pt-3 pt-sm-4">
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/blue-tick.svg">
              <li class="Program-overview-content">Big international studios and companies like Sony Pictures, Turner Entertainment and Walt Disney are off shoring the development of animation content to India, and, already, Indian animation studies and production houses are jam packed with work, be it outsourced from abroad or in-house projects.</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/pink-tick.svg">
              <li class="Program-overview-content">Therefore, there is a talent crunch in this industry and people are required to fill up these vacancies.</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
              <img src="../assets/img/academic/home-page/blue-tick.svg">
              <li class="Program-overview-content">Opportunities exist both with the government as well as private sector enterprises.</li>
              </div>
              
                
                
          </ul>
          </div>
        </div>
      </div>

      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseNine" aria-expanded="false" aria-controls="collapseNine">
            9. What are the scope of B.Sc (Computer Science)in India and Abroad ?
          </button>
        </h2>
        <div id="collapseNine" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            Animation itself is an industry, which is rapidly growing. There is a great scope in the field of animation.
            <ul class="p-0 pt-3 pt-sm-4">
              <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/blue-tick.svg">
                <li class="Program-overview-content">Computers are going to replace / augment stock brokers, traders, doctors by automating mundane jobs and give humans a better time to think and achieve activities of higher calling - things. B.Sc in computer science would help land on a job for these huge software giants.</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/pink-tick.svg">
                <li class="Program-overview-content">Computer Science graduates have scope in Companies and Government sectors.</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/blue-tick.svg">
                <li class="Program-overview-content">After the graduation one can attend competitive exams right from UPSC , SSC , IBPS exams.</li>
              </div>
              <div class="d-flex align-items-start list-tick mb-3">
                <img src="../assets/img/academic/home-page/pink-tick.svg">
                <li class="Program-overview-content">They can also pursue MSC or MCA after completing BSC.</li>
              </div>
                
                
          </ul>
          </div>
        </div>
      </div>


      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTen" aria-expanded="false" aria-controls="collapseTen">
            10. What are the job opportunities for M.Sc(computer science)?
          </button>
        </h2>
        <div id="collapseTen" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            Reputed companies that recruits software engineers are: <br>
Infosys , Accenture, TCS, Persistent, Cognizant, IBM, Symantec,Microsoft, Fiserv,Google,Oracle, Wipro Ltd,HCLInfosystemsLtd,TataInfotech Ltd, DELL.
           
          </div>
        </div>
      </div>

      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseEleven" aria-expanded="false" aria-controls="collapseEleven">
            11. What are the job opportunities for B.Sc (Animation and Multimedia)?
          </button>
        </h2>
        <div id="collapseEleven" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            B.Sc.(Animation and Multimedia) course is an art form and a very demanding career which has plenty of opportunities for the creatively talented people. It is a course through which students can find job opportunities in TV Channels like VIJAY TV, SUN TV, Polimer TV, Advertising Agencies, Media Agencies, Video Gaming Industries etc. They can find job profiles like Animator, Editor, Game Developer, Sound Engineer and Graphic Designer, etc.
          </div>
        </div>
      </div>

      <div class="accordion-item">
        <h2 class="accordion-header">
          <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseLast" aria-expanded="false" aria-controls="collapseLast">
            12. What are the job opportunities for B.Sc( Computer Science)?
          </button>
        </h2>
        <div id="collapseLast" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
          <div class="accordion-body">
            Students will usually go immediately for higher education after B.Sc, but jobs do exist. They can take on positions as Software Professionals, Applications Developer, Data analyst, Database Administrator, Information Systems manager, System Administrator and Network Administrator, etc. by taking additional training in the specific domain.
           
          </div>
        </div>
      </div>



    </div>

    <div class="contact-details pb-4 pb-sm-4">
      <h1 class="details-head">For More Details</h1>
      <div class="row">
        <div class="col-xl-12 pb-5">
          <div class="detailsss  position-relative">
            <span>Mobile number</span>  : <a href="tel:8925029777">8925029777</a>   /  <a href="tel:+91 97901 11911" class="pe-3">+91 97901 11911</a> <br class="d-none">

            <span class="line position-relative ps-md-3 ps-0">Email Address </span>  : <a href="mailto:admission@pmu.edu">admission@pmu.edu</a> 
          </div>
        </div>
        
      </div>
    </div>
  </div>
 


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