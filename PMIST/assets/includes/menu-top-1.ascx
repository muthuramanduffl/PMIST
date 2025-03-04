<%@ Control Language="C#" AutoEventWireup="true" CodeFile="menu-top.ascx.cs" Inherits="includes_menu_top" %>

<div class="menu">
  <div class="h-left bx-1 rsp-1">
    <div class="logo"> <span><a href="/"> <img src="/site-assets/images/new-logo1.jpg" /></a></span> </div>
  </div>
  <div class="h-right bx-2 rsp-2">
    <div class="digimeg-nav-wrap">
      <div class="rs-menu">☰ Menu</div>
      <ul class="digimeg-group digimeg-main-nav rsp-5">
        <li class="nnes"><a href="/"><span class="home-icon"><i class="fa fa-home" aria-hidden="true"></i></span></a></li>
        <li class="nne"><a href="/">Home</a></li>
        <li class="desk"><a href="javascript:void(0);" data-subnav="define-subnav" class="digimeg-nav-item">About <span class="digimeg-active-mark"></span></a></li>
        <li class="mbl-menu-res"> <a href="javascript:void(0);">About <i class="nav-arrow fa fa-angle-down pull-right"></i></a>
          <ul class="mbl-menu-list">
            <li><a href="/about/">About PMIST</a></li>
            <li><a href="/about/history.aspx">History</a></li>
            <li><a href="/about/management.aspx">Management</a></li>
            <li><a href="/about/committee.aspx">Committee</a></li>
            <li><a href="/about/statutory-bodies.aspx">Statutory bodies</a></li>
            <%--<li><a href="/about/academic.aspx">Academic</a></li>--%>
            <li><a href="/about/placements.aspx">Placements</a></li>
            <li><a href="/about/bye-laws.aspx">Bye-Laws & Constitution</a></li>
          </ul>
        </li>
        <li class="desk"><a href="#" data-subnav="voucher-subnav" class="digimeg-nav-item">Academic <span class="digimeg-active-mark"></span></a></li>
        <li class="mbl-menu-res"> <a href="javascript:void(0);">Academic<i class="nav-arrow fa fa-angle-down pull-right"></i></a>
          <ul class="mbl-menu-list">
            <li> <a href="javascript:void(0);"><i class="fa fa-angle-right" aria-hidden="true"></i>FACULTY OF ARCHITECTURE AND PLANNING (FAP)</a>
              <ul class="sub-menu-list">
                <li><a href="/department-of-architecture/">Department of Architecture</a></li>
              </ul>
            </li>
            <li> <a href="javascript:void(0);"><i class="fa fa-angle-right" aria-hidden="true"></i>FACULTY OF COMPUTING SCIENCE AND ENGINEERING(FCSE)</a>
              <ul class="sub-menu-list">
                <li><a href="/cse/">Department of Computer Science and Engineering</a></li>
                <!--<li><a href="/department-of-information-technology/">Department of Information Technology</a></li>-->
                <li><a href="/department-of-computer-science-applications/"><i class="fa fa-angle-right" aria-hidden="true"></i>Department of Computer Science & Application</a></li>
                <li><a href="/department-of-software-engineering/"><i class="fa fa-angle-right" aria-hidden="true"></i>Department of Software Engineering</a></li>
              </ul>
            </li>
            <li> <a href="javascript:void(0);"><i class="fa fa-angle-right" aria-hidden="true"></i>FACULTY OF HUMANITIES, SCIENCE AND MANAGEMENT(FHSM)</a>
              <ul class="sub-menu-list">
                <li><a href="/department-of-chemistry/">Chemistry</a></li>
                <li><a href="/department-of-english/">English</a></li>
                <li><a href="/department-of-mathematics/">Mathematics</a></li>
                <li><a href="/department-of-physics/">Physics</a></li>
                <li><a href="/department-of-management-studies/">Management Studies</a></li>
                <li><a href="/department-of-education/">Education</a></li>
                <li><a href="/department-of-physical-education/faculty.aspx">Physical Education</a></li>
                <li><a href="/department-of-commerce/">Commerce</a></li>
				<li><a href="/department-of-political-science/">Political Science</a></li>
				<li><a href="/department-of-social-work/">Social Work</a></li>
              </ul>
            </li>
            <li> <a href="javascript:void(0);"><i class="fa fa-angle-right" aria-hidden="true"></i>FACULTY OF ENGINEERING AND TECHNOLOGY(FET)</a>
              <ul class="sub-menu-list">
                <li><a href="/department-of-aerospace/">Department of Aerospace Engineering</a></li>
                <li><a href="/department-of-biotechnology/">Department of Bio-Technology</a></li>
                <li><a href="/department-of-chemical-engineering/">Department of Chemical Engineering</a></li>
                <li><a href="/department-of-civil-engineering/">Department of Civil Engineering</a></li>
                <li><a href="/department-of-electronics-and-communication/">Department of Electronics and Communication Engineering</a></li>
                <li><a href="/department-of-electrical-and-electronics/">Department of Electrical and Electronics Engineering</a></li>
                <li><a href="/department-of-mechanical-engineering/">Department of Mechanical Engineering</a></li>
                <%--<li><a href="/department-of-nano-technology/">Division of  Nanotechnology</a></li>--%>
              </ul>
            </li>
          </ul>
        </li>
        <li><a href="/admissions/admission-2019-20.aspx">Admission</a></li>
        <li class="desk"><a href="#" data-subnav="final-subnav" class="digimeg-nav-item">campus <span class="digimeg-active-mark"></span></a></li>
        <li class="mbl-menu-res"><a href="javascript:void(0)l">campus <i class="nav-arrow fa fa-angle-down pull-right"></i></a>
          <ul class="mbl-menu-list">
            <li><a href="/campus/">Life at PMIST</a></li>
            <li><a href="/campus/amenities.aspx">Campus Amenities</a></li>
            <li><a href="/campus/zero-carbon.aspx">Zero-Carbon Campus</a></li>
            <li><a href="/campus/hostel.aspx">Hostel</a></li>
            <li><a href="/campus/library.aspx">Library</a></li>
            <li><a href="/campus/student-association.aspx">Student Association</a></li>
            <li><a href="/campus/hospital.aspx">Periyar Maniammai Hospital</a></li>
          </ul>
        </li>
        <li class="desk"><a href="#" data-subnav="reports-subnav" class="digimeg-nav-item">Centres <span class="digimeg-active-mark"></span></a></li>
        <li class="mbl-menu-res"> <a href="javascript:void(0)l">Centres <i class="nav-arrow fa fa-angle-down pull-right"></i></a>
          <ul class="mbl-menu-list">
            <li><a href="/centres/centre-for-university-industry-interaction.aspx">Centre For University Industry Interaction(CUII)</a></li>
            <li><a href="/centres/centre-of-excellence-for-periyar-thought.aspx">Centre For Periyar Thought(CPT)</a></li>
            <li><a href="/centres/centre-for-rural-development.aspx">Centre for Rural Development(CRD)</a></li>
            <li><a href="/centres/centre-for-climate-change.aspx">Centre for Climate Change(CCC)</a></li>
            <li><a href="/centres/cetat.aspx">Centre of Excellence for Training and Research in Automation Technologies(CETAT)</a></li>
            <li><a href="/centres/centre-for-students-and-administrative-services.aspx">Centre for Students and Administrative Services(CSAS)</a></li>
            <li><a href="/centres/kkcps.aspx">Dr.Kalaignar M.Karunanithi Centre for Political Science(KKCPS)</a></li>
            <li><a href="/centres/centre-of-excellence-for-next-generation-networks.aspx">Centre of Excellence for Next Generation Networks(CNGN)</a></li>
            <li><a href="/centres/veeramani-mohana-centre-for-quality-life-engineering-research.aspx">Veeramani Mohana Centre for Quality Life Engineering Research</a></li>
            <li><a href="/centres/centre-of-excellence-for-erp.aspx">Centre of Excellence for Enterprise Resource Planning(CEERP)</a></li>
            <li><a href="/centres/periyar-technology-business-incubator.aspx">Periyar R & D Centre for Bio and Solar Energies</a></li>
            <li><a href="/centres/periyar-technology-business-incubator.aspx">Periyar Technology Business Incubator</a></li>
          </ul>
        </li>
        <li class="desk"><a href="#" data-subnav="gallery-subnav" class="digimeg-nav-item">Gallery<span class="digimeg-active-mark"></span> </a></li>
        <li class="mbl-menu-res"> <a href="javascript:void(0)">Gallery <i class="nav-arrow fa fa-angle-down pull-right"></i></a>
          <ul class="mbl-menu-list">
            <li><a href="/gallery/default.aspx">Images </a></li>
            <li><a href="/gallery/videos.aspx">Videos</a></li>
          </ul>
        </li>
        <li class="desk"><a href="#" data-subnav="iqac-subnav" class="digimeg-nav-item">IQAC <span class="digimeg-active-mark"></span></a></li>
        <li class="mbl-menu-res"><a href="javascript:void(0)l">IQAC <i class="nav-arrow fa fa-angle-down pull-right"></i></a>
          <ul class="mbl-menu-list">
            <li><a href="/iqac/default.aspx">Home </a></li>
            <li><a href="/iqac/about.aspx">About</a></li>
            <li><a href="/iqac/co-ordinators.aspx">Co-ordinators</a></li>
            <li><a href="/iqac/meetings.aspx">Meetings</a></li>
            <li><a href="/iqac/reports.aspx">Reports</a></li>
            <li><a href="/iqac/gallery.aspx">Gallery</a></li>
            <li><a href="/iqac/contact.aspx">Contact</a></li>
            <li><a href="/iqac/aqar.aspx">AQAR</a></li>
            <li><a href="/iqac/policiesandprocedures.aspx">Policies and Procedures</a></li>
          </ul>
        </li>
        <li class="desk"><a href="#" data-subnav="research-subnav" class="digimeg-nav-item">Research <span class="digimeg-active-mark"></span></a></li>
        <li class="mbl-menu-res"> <a href="javascript:void(0)">Research <i class="nav-arrow fa fa-angle-down pull-right"></i></a>
          <ul class="mbl-menu-list">
            <li><a href="/research/culture.aspx">The Research Culture</a></li>
            <li><a href="/research/outcome-based-teaching.aspx">Outcome Based Teaching</a></li>
            <li><a href="/research/research-output.aspx">Research Output</a></li>
            <li><a href="/admission/admission-2018-19.aspx">Application for Ph.D</a></li>
            <li><a href="/research/downloads.aspx">Downloads</a></li>
          </ul>
        </li>
        <li class="desk"><a href="/contact/"  >Contact </a></li>
        <li class="mbl-menu-res"><a href="/contact/">Contact </a>
        <%--  <ul class="mbl-menu-list">
            <li><a href="/contact/">Address</a></li>
            <li><a href="/contact/information-centers.aspx">Information Centers</a></li>
          </ul>--%>
        </li>
      </ul>
      <ul class="digimeg-nav-down-content digimeg-sub-nav">
        <li id="define-subnav">
          <div class="digimeg-nav-item-content digimeg-group">
            <div class="col-3">
              <div class="menu-img"> <img src="/site-assets/images/about-01.jpg" width="250" height="150" /> </div>
            </div>
            <div class="col-9">
              <div class="digimeg-nav-chunk">
                <h5>About</h5>
                <div class="menu-box">
                  <ul class="mega col-6">
                    <li><a href="/about/">About PMIST</a></li>
                    <li><a href="/about/history.aspx">History</a></li>
                    <li><a href="/about/management.aspx">Management</a></li>
                    <li><a href="/about/committee.aspx">Committee</a></li>
                  </ul>
                  <ul class="mega col-6">
                    <li><a href="/about/statutory-bodies.aspx">Statutory bodies</a></li>
                    <%--<li><a href="/about/academic.aspx">Academic</a></li>--%>
                    <li><a href="/about/placements.aspx">Placements</a></li>
                    <li><a href="/about/bye-laws.aspx">Bye-Laws & Constitution</a></li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </li>
        <!-- /#define-subnav -->
        <li id="voucher-subnav">
          <div class="digimeg-nav-item-content digimeg-group">
            <div class="col-12">
              <div class="digimeg-nav-chunk">
                <h5>FACULTY OF ARCHITECTURE AND PLANNING (FAP)</h5>
                <div class="menu-box">
                  <ul class="mega">
                    <li><a href="/department-of-architecture/">Department of Architecture</a></li>
                  </ul>
                </div>
                <h5>FACULTY OF COMPUTING SCIENCE AND ENGINEERING(FCSE)</h5>
                <div class="menu-box">
                  <ul class="mega">
                    <li><a href="/cse/">Department of Computer Science and Engineering</a></li>
                    <!--<li><a href="/department-of-information-technology/">Department of Information Technology</a></li>-->
                    <li><a href="/department-of-computer-science-applications/"><!--<span> <img src="/site-assets/images/sub-menu-i.png" /></span>-->Department of Computer Science & Application</a></li>
                    <li><a href="/department-of-software-engineering/"><!--<span> <img src="/site-assets/images/sub-menu-i.png" /></span> -->Department of Software Engineering </a></li>
                    <!--<li><a href="/department-of-mathematics/"><span> <img src="/site-assets/images/sub-menu-i.png" /></span> Mathematics Division</a></li>-->
                    
                  </ul>
                </div>
                <h5>FACULTY OF HUMANITIES, SCIENCE AND MANAGEMENT(FHSM)</h5>
                <div class="menu-box">
                  <ul class="mega">
                    <li><a href="/department-of-chemistry/">Chemistry</a></li>
                    <li><a href="/department-of-english/">English</a></li>
                    <li><a href="/department-of-mathematics/">Mathematics</a></li>
                    <li><a href="/department-of-physics/">Physics</a></li>
                    <li><a href="/department-of-management-studies/">Management Studies</a></li>
                    <li><a href="/department-of-education/">Education</a></li>
                    <li><a href="/department-of-physical-education/faculty.aspx">Physical Education</a></li>
                    <li><a href="/department-of-commerce/">Commerce</a></li>
					<li><a href="/department-of-political-science/">Political Science</a></li>
					<li><a href="/department-of-social-work/">Social Work</a></li>
                  </ul>
                </div>
              </div>
              <div class="digimeg-nav-chunk">
                <h5>FACULTY OF ENGINEERING AND TECHNOLOGY(FET)</h5>
                <div class="menu-box">
                  <ul class="mega">
                    <li><a href="/department-of-aerospace/">Department of Aerospace Engineering</a></li>
                    <li><a href="/department-of-biotechnology/">Department of Bio-Technology</a></li>
                    <li><a href="/department-of-chemical-engineering/">Department of Chemical Engineering</a></li>
                    <li><a href="/department-of-civil-engineering/">Department of Civil Engineering</a></li>
                    <li><a href="/department-of-electronics-and-communication/">Department of Electronics and Communication Engineering</a></li>
                    <li><a href="/department-of-electrical-and-electronics/">Department of Electrical and Electronics Engineering</a></li>
                    <li><a href="/department-of-mechanical-engineering/">Department of Mechanical Engineering</a></li>
                    <%--<li><a href="/department-of-nano-technology/">Division of  Nanotechnology</a></li>--%>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </li>
        <li id="final-subnav">
          <div class="digimeg-nav-item-content digimeg-group">
            <div class="col-3">
              <div class="menu-img">
                <div class="menu-img"> <img src="/site-assets/images/banner.jpg" width="250" height="150" /> </div>
              </div>
            </div>
            <div class="col-9">
              <div class="digimeg-nav-chunk col-8">
                <h5>CAMPUS</h5>
                <div class="menu-box">
                  <ul class="mega col-6">
                    <li><a href="/campus/">Life at PMIST</a></li>
                    <li><a href="/campus/amenities.aspx">Campus Amenities</a></li>
                    <li><a href="/campus/zero-carbon.aspx">Zero-Carbon Campus</a></li>
                    <li><a href="/campus/hostel.aspx">Hostel</a></li>
                  </ul>
                  <ul class="mega col-6">
                    <li><a href="/campus/library.aspx">Library</a></li>
                    <li><a href="/campus/student-association.aspx">Student Association</a></li>
                    <li><a href="/campus/hospital.aspx">Periyar Maniammai Hospital</a></li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </li>
        <li id="reports-subnav">
          <div class="digimeg-nav-item-content digimeg-group">
            <div class="col-3">
              <div class="menu-img">
                <div class="menu-img"> <img src="/site-assets/images/centres-02.jpg" width="250" height="150" /> </div>
              </div>
            </div>
            <div class="col-9">
              <div class="digimeg-nav-chunk col-12">
                <h5>Centres</h5>
                <div class="menu-box">
                  <ul class="mega col-6">
                    <li><a href="/centres/centre-for-university-industry-interaction.aspx">Centre For University Industry Interaction(CUII)</a></li>
                    <li><a href="/centres/centre-of-excellence-for-periyar-thought.aspx">Centre For Periyar Thought(CPT)</a></li>
                    <li><a href="/centres/centre-for-rural-development.aspx">Centre for Rural Development(CRD)</a></li>
                    <li><a href="/centres/centre-for-climate-change.aspx">Centre for Climate Change(CCC)</a></li>
                    <li><a href="/centres/cetat.aspx">Centre of Excellence for Training and Research in Automation Technologies(CETAT)</a></li>
                    <li><a href="/centres/centre-for-students-and-administrative-services.aspx">Centre for Students and Administrative Services(CSAS)</a></li>
                  </ul>
                  <ul class="mega col-6">
                    <li><a href="/centres/kkcps.aspx">Dr.Kalaignar M.Karunanithi Centre for Political Science(KKCPS)</a></li>
                    <li><a href="/centres/centre-of-excellence-for-next-generation-networks.aspx">Centre of Excellence for Next Generation Networks(CNGN)</a></li>
                    <li><a href="/centres/veeramani-mohana-centre-for-quality-life-engineering-research.aspx">Veeramani Mohana Centre for Quality Life Engineering Research</a></li>
                    <li><a href="/centres/centre-of-excellence-for-erp.aspx">Centre of Excellence for Enterprise Resource Planning(CEERP)</a></li>
                    <li><a href="/centres/periyar-r-and-d-centre-for-bio-and-solar-energies.aspx">Periyar R & D Centre for Bio and Solar Energies</a></li>
                    <li><a href="/centres/periyar-technology-business-incubator.aspx">Periyar Technology Business Incubator</a></li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </li>
        <li id="gallery-subnav">
          <div class="digimeg-nav-item-content digimeg-group">
            <div class="col-3">
              <div class="menu-img">
                <div class="menu-img"> <img src="/site-assets/images/gallery-01.jpg" width="250" height="150" /> </div>
              </div>
            </div>
            <div class="col-9">
              <div class="digimeg-nav-chunk">
                <h5>Gallery</h5>
                <div class="menu-box">
                  <ul class="mega">
                    <li><a href="/gallery/default.aspx">Images</a></li>
                    <li><a href="/gallery/videos.aspx">Videos</a></li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </li>
        <li id="iqac-subnav">
          <div class="digimeg-nav-item-content digimeg-group">
            <div class="col-3">
              <div class="menu-img">
                <div class="menu-img"> <img src="/site-assets/images/iqac-01.jpg" width="250" height="150" /> </div>
              </div>
            </div>
            <div class="col-9">
              <div class="digimeg-nav-chunk">
                <h5>IQAC</h5>
                <div class="menu-box">
                  <ul class="mega col-6">
                    <li><a href="/iqac/default.aspx">Home </a></li>
                    <li><a href="/iqac/about.aspx">About</a></li>
                    <li><a href="/iqac/co-ordinators.aspx">Co-ordinators</a></li>
                    <li><a href="/iqac/Members.aspx">Members</a></li>
                     <li><a href="/iqac/pdf/Undertaking Standard Compliance - PMIST.pdf">NAAC Undertaking</a></li>
                  </ul>
                  <ul class="mega col-6">
                   <li><a href="/iqac/contact.aspx">Contact</a></li>
                    <li><a href="/iqac/meetings.aspx">Meetings</a></li>
                    <li><a href="/iqac/reports.aspx">Reports</a></li>
                    <li><a href="/iqac/gallery.aspx">Gallery</a></li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </li>
        <li id="research-subnav">
          <div class="digimeg-nav-item-content digimeg-group">
            <div class="col-3">
              <div class="menu-img">
                <div class="menu-img"> <img src="/site-assets/images/banner.jpg" width="250" height="150" /> </div>
              </div>
            </div>
            <div class="col-9">
              <div class="digimeg-nav-chunk">
                <h5>Research</h5>
                <div class="menu-box">
                  <ul class="mega">
                    <li><a href="/research/culture.aspx">The Research Culture</a></li>
                    <li><a href="/research/outcome-based-teaching.aspx">Outcome Based Teaching</a></li>
                    <li><a href="/research/research-output.aspx">Research Output</a></li>
                    <li><a href="#">Application for Ph.D</a></li>
                    <li><a href="/research/research-forms.aspx">Downloads</a></li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </li>
       <%-- <li id="contact-subnav">--%>
          <%--<div class="digimeg-nav-item-content digimeg-group">
            <div class="col-3">
              <div class="menu-img">
                <div class="menu-img"> <img src="/site-assets/images/contact-01.jpg" width="250" height="150" /> </div>
              </div>
            </div>
            <div class="col-9">
              <div class="digimeg-nav-chunk">
                <h5>Contact</h5>
                <div class="menu-box">
                  <ul class="mega">
                    <li><a href="/contact/">Address</a></li>
                    <li><a href="/contact/information-centers.aspx">Information Centers</a></li>
                  </ul>
                </div>
              </div>
            </div>
          </div>--%>
       <%-- </li>--%>
      </ul>
    </div>
  </div>
  <%--<div class="fb-icon bx-3 rsp-3"> <span class="img-fb"><a class="hvr-grow" target="_blank" href="https://www.facebook.com/pmuniv"> <img src="/site-assets/images/fb-01.png" /> </a></span> </div>--%>
  <div class="fb-icon bx-3 rsp-3"> <span class="img-fb"><a class="hvr-grow" target="_blank" href="http://14.139.171.133/egov/Taxcalc/login.aspx"> <img src="/site-assets/images/brain_weblogo1.png" /> </a></span> </div>
</div>
