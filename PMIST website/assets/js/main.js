// <!-- AOS --> 
AOS.init({
  duration: 1200,
  once: true
})
// <!-- //AOS --> 
 
// sub menu 


document.addEventListener('DOMContentLoaded', function () {
  // Check if the element with the class .menuSwiper exists
  if (document.querySelector('.menuSwiper')) {
      var swiper = new Swiper('.menuSwiper', {
          slidesPerView: 'auto',
          navigation: {
              nextEl: '.swiper-button-next',
              prevEl: '.swiper-button-prev',
          },
      });
  }
});

 
  // Append the footer directly to the body
  (function () {
    // Ensure the DOM is fully loaded
    document.addEventListener('DOMContentLoaded', function () {
        // Append the footer directly to the body
        document.body.insertAdjacentHTML('beforeend', `
        <footer class="footer-section">
            <div class="footer-firstbg"></div>
            <div class="footer-secondbg"></div>
            <div class="newfooter">
                <div class="container-fluid new-footer-top-sec py-5">
                    <div class="row pt-2">
                        <div class="col-xl-6 footer-left pb-xl-0 pb-4">
                            <h3 class="">PERIYAR MANIAMMAI INSTITUTE OF SCIENCE & TECHNOLOGY (PMIST)</h3>
                            <div class="addressSection pb-2 d-flex justify-content-center align-items-center">
                                <div class="d-flex flex-md-row flex-column align-items-center justify-content-center flex-wrap">
                                    <div class="d-flex">
                                        <div class="whiteColor ms-2 pe-3 borderrightNone footerBorderRight mb-3">
                                            Periyar Nagar, Vallam, Thanjavur - 613403, Tamil Nadu, India
                                        </div>
                                    </div>
                                    <div class="d-flex margin0Responsive ms-3">
                                        <div class="pe-3 borderrightNone footerBorderRight mb-3 w-m-100">
                                            <a href="tel:+914362264600" class="whiteColor textdecorationNone">+91 4362 264600</a>
                                        </div>
                                    </div>
                                    <div class="d-flex margin0Responsive ms-3">
                                        <div class="pe-3 border-right-0 mb-3 w-m-100">
                                            <a href="mailto:registrar@pmu.edu" class="whiteColor textdecorationNone">registrar@pmu.edu</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="social-links">
                                <div class="d-flex align-items-center social-links-group">
                                    <a href="https://twitter.com/PMIST2" target="_blank"><img src="../assets/img/footer/twitter.png"></a>
                                    <a href="https://www.instagram.com/pmist_official" target="_blank"><img src="../assets/img/footer/instagram.png"></a>
                                    <a href="https://www.threads.net/@pmist_official" target="_blank"><img src="../assets/img/footer/icon-3.png"></a>
                                    <a href="https://youtube.com/@pmistdeemedtobeuniversity" target="_blank"><img src="../assets/img/footer/youtube.png"></a>
                                    <a href="https://www.linkedin.com/in/pmistofficial" target="_blank"><img src="../assets/img/footer/linkedin.png"></a>
                                    <a href="https://www.facebook.com/pmuniv" target="_blank"><img src="../assets/img/footer/facebook.png" class="facebook-img"></a>
                                </div>
                            </div>
                        </div>
                        <div class="col-xl-6 footer-right align-self-center">
                            <div class="d-flex justify-content-center flex-wrap footer-quick-links-sec">
                                <a href="http://www.ugc.ac.in/" target="_blank" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">UGC</a>
                                <a href="https://pmu.edu/" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">NBA</a>
                                <a href="https://nad.gov.in/" target="_blank" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">NAD</a>
                                <a href="http://periyartbi.pmu.edu/" target="_blank" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">Periyar TBI</a>
                                <a href="https://pmu.edu/about/anti-discriminationcell.aspx" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">ANTI-DISCRIMINATION CELL</a>
                                <a href="https://pmu.edu/about/antiragging.aspx" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">Antiragging</a>
                                <a href="https://pmu.edu/chat-with-a-student/" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">CHAT WITH A STUDENT</a>
                                <a href="https://pmu.edu/about/code-of-conduct-committee.aspx" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">CODE OF CONDUCT COMMITTEE</a>
                                <a href="https://pmu.edu/about/grievances-and-redressal-committee.aspx" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">GRIEVANCES REDRESSAL COMMITTEE</a>
                                <a href="https://pmu.edu/about/internal-complaints-committee.aspx" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">INTERNAL COMPLAINTS COMMITTEE</a>
                                <a href="http://www.mhrdnats.gov.in/" target="_blank" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">NATS</a>
                                <a href="https://pmu.edu/AdmissionEnquiry/Login.aspx" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">Admin Login</a>
                                <a href="https://pmu.edu/about/terms-and-conditions.aspx" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">Refund Policy</a>
                                <a href="https://pmu.edu/" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase footerBorderRight">LMS</a>
                                <a href="https://samadhaan.ugc.ac.in/" target="_blank" class="whiteColor ps-2 mb-2 textdecorationNone pe-2 upperCase">UGC Online Grievance and Redressal System</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="px-4">
                    <div class="footer-btm container-fluid">
                        <div class="row">
                            <div class="col-md-6 py-2 text-md-start text-center px-2 ps-3">&#169;
                                <span id="currentYear"></span> Periyar Maniammai Institute of Science & Technology
                            </div>
                            <div class="col-md-6 text-md-end text-center py-2">
                                <a href="https://duffldigital.com/" class="textdecorationNone text-uppercase letterSpacing px-2" target="blank">Duffl Digital</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        `);
        // Set the current year
        var currentYear = new Date().getFullYear();
        document.getElementById('currentYear').textContent = currentYear;
    });
})();


// sub menu  
document.addEventListener('DOMContentLoaded', function () {
var swiper = new Swiper('.CIII-module-menu .menuSwiper', {
    slidesPerView: 'auto',
    navigation: {
      nextEl: '.swiper-button-next',
      prevEl: '.swiper-button-prev',
    },
  });

  var swiper = new Swiper('.About-module-menu .menuSwiper', {
    slidesPerView: 'auto',
    navigation: {
      nextEl: '.swiper-button-next',
      prevEl: '.swiper-button-prev',
    },
  });
});

