<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCAdmission.ascx.cs" Inherits="includes_UCAdmission" %>

<div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog"
        aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">

                <div class="modal-body p-0 pb-4">
                    <div class="contactBox px-4">
                       <asp:UpdatePanel ID="updatePanel2" runat="server">
                        <ContentTemplate>
                        <div class="pt-3">
                            <div class="d-flex justify-content-between align-items-center pb-2 modalBottom">
                                <h4 class="blueColor Oswald OswaldR upperCase semiBoldFont text-uppercase mb-0">Admission 2021 - Apply Now</h4>
                                <div data-dismiss="modal" aria-label="Close" class="cusror-pointer">
                                    <img src="https://pmu.edu/admission/images/close-gradient.png" class="closeGrOne">
                                </div>
                            </div>
                            <div class="mt-4">
                                <div>
                                    <div class="regularFont modalHeading">Name of the Applicant <b style="color: #F00">*</b></div>
                                    <asp:TextBox ID="txtName" CssClass="customInputpopUp w-100" runat="server"></asp:TextBox>                                   
                                    <div class="errorMessage"><asp:RequiredFieldValidator ID="reqv" runat="server" ControlToValidate="txtName" ErrorMessage="Please Enter Your Name" Font-Size="Small" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regv" runat="server" ControlToValidate="txtName" ValidationExpression="^[a-zA-Z'.\s]{3,54}" ErrorMessage="Enter Your Valid Name" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator></div>
                                </div>
                                <div class="mt-2">
                                    <div class="regularFont modalHeading">Date of Birth <b style="color: #F00">*</b></div>
                                     <asp:TextBox ID="txtDateofBirth" ClientIDMode="Static" runat="server" placeholder="dd/mm/yyyy" CssClass="customInputpopUp w-100 datepicker"></asp:TextBox>
                                   
                                    <div class="errorMessage"><asp:RequiredFieldValidator ID="rvDateofbirth" runat="server" ControlToValidate="txtDateofBirth" ErrorMessage="Select Your Date Of Birth"
                                            Display="Dynamic" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revDate2" ErrorMessage="DateFormat should be dd/mm/yyyy" Display="Dynamic" Font-Size="Small" ForeColor="Red"
    ControlToValidate="txtDateofBirth" runat="server" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/]\d{4}" /></div>
                                </div>
                                <asp:UpdatePanel ID="updatePanel" runat="server">
                                    <ContentTemplate>
                                <div class="mt-2">
                                    <div class="regularFont modalHeading">Course Mode <b style="color: #f00">*</b> </div>
                                    <div class="d-flex mt-2 flex-wrap">
                                        <asp:RadioButtonList ID="rbCourseType" runat="server" AutoPostBack="true"
 RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="rbCourseType_SelectedIndexChanged">
                                            <asp:ListItem Value="0" Text="Regular"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Part Time"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Lateral"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Integrated"></asp:ListItem>
                                            </asp:RadioButtonList>
                                       
                                    </div>
                                    <div class="errorMessage"> <asp:RequiredFieldValidator ID="revcourseType" runat="server" ControlToValidate="rbCourseType" ErrorMessage="Select Course Mode" Display="Dynamic" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator></div>
                                </div>
                              
                                <div class="mt-2">
                                    <div class="regularFont  modalHeading">Course Type <b style="color: #F00">*</b></div>
                                    <div class="d-flex mt-2">
                                          <asp:RadioButtonList runat="server" ID="rbCourse"  AutoPostBack="true" OnSelectedIndexChanged="rbCourse_SelectedIndexChanged" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                                    <asp:ListItem Value="UG">UG</asp:ListItem>
                                                    <asp:ListItem Value="PG">PG</asp:ListItem>
                                                </asp:RadioButtonList>
                                       
                                    </div>
                                    <div class="errorMessage"><asp:RequiredFieldValidator ID="rvCourse" runat="server" ControlToValidate="rbCourse" ErrorMessage="Select Course Type" Display="Dynamic" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator></div>
                                </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>

                                <div class="mt-2">
                                    <div class="regularFont  modalHeading">Mobile Number <b style="color: #F00">*</b></div>
                                    <asp:TextBox ID="txtMobileNo" CssClass="customInputpopUp w-100" runat="server"></asp:TextBox>
                                      <div class="errorMessage"><asp:RequiredFieldValidator ID="rvCaste" runat="server" ControlToValidate="txtMobileNo"
                                            CssClass="failureNotification" ErrorMessage="Please Enter Your Mobile No"
                                            Display="Dynamic" SetFocusOnError="true" ForeColor="Red" Font-Size="Small"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regmobile" runat="server" ControlToValidate="txtMobileNo"
                                            ValidationExpression="[0-9]{10,10}" ErrorMessage="Enter Your Vaild Mobile No" Display="Dynamic" ForeColor="Red" Font-Size="Small"></asp:RegularExpressionValidator></div>
                                </div>
                                <div class="">
                                     <div class="form-check pl-0">
                                        <label class="form-check-label mt-1" for="checkWhatsapp" style="font-size: 14px;padding-top: 8px;background-image: none;">Is this your Whatsapp Number?</label>
                                        <input type="checkbox" class="form-check-input mt-3 ml-3" id="checkWhatsapp">
                                    </div>
                                </div>
                                <div class="mt-2">
                                    <div class="regularFont  modalHeading">Whatsapp Number</div>
                                    <input name="admission$txtMobileNo" type="text" id="admission_txtMobileNo" class="customInputpopUp w-100">
                                      <div class="errorMessage"><span id="admission_rvCaste" class="failureNotification" style="color:Red;display:none;">Please Enter Your Whatsapp No</span>
                                        <span id="admission_regmobile" style="color:Red;display:none;">Enter Your Vaild Mobile No</span></div>
                                </div>
                                <div class="mt-2">
                                    <div class="regularFont  modalHeading">Email ID <b style="color: #F00">*</b></div>
                                    <asp:TextBox ID="txtEmailId" CssClass="customInputpopUp w-100" runat="server"></asp:TextBox>
                                          <div class="errorMessage"><asp:RequiredFieldValidator ID="rvEmailid" runat="server" ControlToValidate="txtEmailId"
                                            CssClass="failureNotification" ErrorMessage="Please Enter Your Email Id"
                                            Display="Dynamic" SetFocusOnError="true" ForeColor="Red" Font-Size="Small"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regEmailId" runat="server" ControlToValidate="txtEmailId"
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red" Font-Size="Small" ErrorMessage="Enter Your Vaild Email Id" Display="Dynamic"></asp:RegularExpressionValidator></div>
                                </div>
                               <div class="mt-2">
                                    <div class="regularFont  modalHeading">City <b style="color: #F00">*</b></div>
                                    <input name="" type="text" id="" class="customInputpopUp w-100">
                                          <div class="errorMessage"><span id="" class="failureNotification" style="color:Red;display:none;">Please Enter Your City</span>
                                    </div>
                                </div>
                                <div class="mt-2">
                                    <div class="regularFont modalHeading">State <b style="color: #F00">*</b></div>
                                    <select name="admission$ddlApplicationFor" class="customInputpopUp w-100">
                                        <option selected="selected" value="0">Select</option>
                                            <option value="Andhra Pradesh">Andhra Pradesh</option>
                                            <option value="Arunachal Pradesh">Arunachal Pradesh</option>
                                            <option value="Assam">Assam</option>
                                            <option value="Bihar">Bihar</option>
                                            <option value="Chattisgarh">Chattisgarh</option>
                                            <option value="Delhi">Delhi</option>
                                            <option value="Goa">Goa</option>
                                            <option value="Gujarat">Gujarat</option>
                                            <option value="Haryana">Haryana</option>
                                            <option value="Himachal Pradesh">Himachal Pradesh</option>
                                            <option value="Jammu and Kashmir">Jammu and Kashmir</option>
                                            <option value="Jharkhand">Jharkhand</option>
                                            <option value="Karnataka">Karnataka</option>
                                            <option value="Kerala">Kerala</option>
                                            <option value="Madhya Pradesh">Madhya Pradesh</option>
                                            <option value="Maharashtra">Maharashtra</option>
                                            <option value="Karnataka">Karnataka</option>
                                            <option value="Kerala">Kerala</option>
                                            <option value="Madhya Pradesh">Madhya Pradesh</option>
                                            <option value="Manipur">Manipur</option>
                                            <option value="Meghalaya">Meghalaya</option>
                                            <option value="Mizoram">Mizoram</option>
                                            <option value="Nagaland">Nagaland</option>
                                            <option value="Orissa">Orissa</option>
                                            <option value="Punjab">Punjab</option>
                                            <option value="Rajasthan">Rajasthan</option>
                                            <option value="Sikkim">Sikkim</option>
                                            <option value="Tamil Nadu">Tamil Nadu</option>
                                            <option value="Tripura">Tripura</option>
                                            <option value="Uttar Pradesh">Uttar Pradesh</option>
                                            <option value="Uttaranchal">Uttaranchal</option>
                                            <option value="West Bengal">West Bengal</option>
                                            <option value="Andaman and nicobar islands (UT)">Andaman and nicobar islands (UT)</option>
                                            <option value="Chandigarh (UT)">Chandigarh (UT)</option>
                                            <option value="Dadra and Nagar Haveli (UT)">Dadra and Nagar Haveli (UT)</option>
                                            <option value="Daman and Diu (UT)">Daman and Diu (UT)</option>
                                            <option value="Lakshadweep (UT)-44">Lakshadweep (UT)</option>
                                            <option value="Puducherry (UT)">Puducherry (UT)</option>
                                            <option value="Other countries">Other countries</option>

                                    </select>
                                    
                                    <div class="errorMessage"><span id="" style="color:Red;font-size:Small;display:none;">Select State</span></div>
                                </div>
                                <div class="mt-2">
                                    <div class="regularFont modalHeading">You came to know us through <b style="color: #F00">*</b></div>
                                    <select name="" class="customInputpopUp w-100">
                                        <option selected="selected" value="0">Select</option>
                                        <option>Facebook</option>
                                        <option>Instagram</option>
                                        <option>Google</option>
                                        <option>Other Websites</option>
                                        <option>Print</option>
                                        <option>Expo</option>
                                        <option>Current Student</option>
                                    </select>
                                </div>
                                <div class="mt-2">
                                    <div class="regularFont modalHeading">Entrance Exam Taken<b style="color: #F00">*</b></div>
                                    <select name=" " class="customInputpopUp w-100">
                                        <option selected="selected" value="0">Select</option>
                                        <option value="PMUCET">PMUCET</option>
                                        <option>JEE</option>
                                    </select>
                                </div>
                                
                                <div class="mt-2">
                                    <div class="regularFont modalHeading">Applying For <b style="color: #F00">*</b></div>
                                    <asp:DropDownList ID="ddlApplicationFor" runat="server" AutoPostBack="true"
                                                    OnSelectedIndexChanged="ddlApplicationFor_SelectedIndexChanged" CausesValidation="true" CssClass="customInputpopUp w-100">
                                                    <asp:ListItem Value="0">Select</asp:ListItem>
                                                    <asp:ListItem Value="B. Tech Full Time" Text="B. Tech Full Time"></asp:ListItem>
                                                    <asp:ListItem Value="B. Tech Lateral Entry" Text="B. Tech Lateral Entry"></asp:ListItem>
                                                    <asp:ListItem Value="B. Tech Part Time" Text="B. Tech Part Time"></asp:ListItem>
                                                   <%-- <asp:ListItem Value="B.C.A" Text="B.C.A"></asp:ListItem>--%>
                                                   <%-- <asp:ListItem Value="B.COM" Text="B.COM"></asp:ListItem>--%>
                                                    <asp:ListItem Value="B.Sc" Text="B.Sc"></asp:ListItem>                                                  
                                                    <asp:ListItem Value="B.A" Text="B.A"></asp:ListItem>                                                  
                                                    <%--<asp:ListItem Value="BBA" Text="BBA"></asp:ListItem>--%>
                                                    <asp:ListItem Value="B.Arch" Text="B.Arch"></asp:ListItem>
                                                    <asp:ListItem Value="B.Sc.B.Ed" Text="B.Sc.B.Ed"></asp:ListItem>
                                                    <asp:ListItem Value="M. Tech  Part Time" Text="M. Tech  Part Time"></asp:ListItem>
                                                    <asp:ListItem Value="M. Tech Full Time" Text="M. Tech Full Time"></asp:ListItem>
                                                    <asp:ListItem Value="M.S.C" Text="M.S.C"></asp:ListItem>
                                                    <asp:ListItem Value="M.A" Text="M.A"></asp:ListItem>
                                                    <%--<asp:ListItem Value="M.Arch" Text="M.Arch"></asp:ListItem>--%>
                                                    <asp:ListItem Value="M.C.A" Text="M.C.A"></asp:ListItem>
                                                    <asp:ListItem Value="M.S.W" Text="M.S.W"></asp:ListItem>
                                                    <asp:ListItem Value="M.Com" Text="M.Com"></asp:ListItem>
                                                </asp:DropDownList>
                                    
                                    <div class="errorMessage"><asp:RequiredFieldValidator ID="rvApplicationfor" runat="server" InitialValue="0" ControlToValidate="ddlApplicationFor"
                                                    ErrorMessage="Select Application For" Display="Dynamic" SetFocusOnError="true" ForeColor="Red" Font-Size="Small"></asp:RequiredFieldValidator></div>
                                </div>
                                      <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>   --%>
                               
                                <div class="mt-2">
                                    <div class="regularFont modalHeading">Choice of Branch Code </div>
                                    <div class="mt-2">
                                        <asp:DropDownList ID="ddlChoice1" CssClass="customInputpopUp w-100" runat="server"
                                                        AutoPostBack="true">                                                       
                                                    </asp:DropDownList>                                        
                                        <div class="errorMessage"> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="Select" ControlToValidate="ddlChoice1"
                                                    ErrorMessage="Select choice 1" Display="Dynamic" ForeColor="Red" Font-Size="Small"></asp:RequiredFieldValidator></div>
                                        
                                    </div>
                                    <div class="mt-2">
                                         <asp:DropDownList ID="ddlChoice2" CssClass="customInputpopUp w-100" runat="server"
                                                        AutoPostBack="true">                                                         
                                                    </asp:DropDownList>
                                       
                                        <div class="errorMessage"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" InitialValue="Select" ControlToValidate="ddlChoice2"
                                                    ErrorMessage="Select choice 2" Display="Dynamic"  ForeColor="Red" Font-Size="Small"></asp:RequiredFieldValidator></div>
                                    </div>
                                    <div class="mt-2">
                                         <asp:DropDownList ID="ddlChoice3" CssClass="customInputpopUp w-100" runat="server">                                                     
                                                    </asp:DropDownList>                                       
                                        <div class="errorMessage"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" InitialValue="Select" ControlToValidate="ddlChoice3"
                                                    ErrorMessage="Select choice 3" Display="Dynamic"  ForeColor="Red" Font-Size="Small"></asp:RequiredFieldValidator></div>
                                    </div>
                                </div>
                                              <%-- </ContentTemplate>

                                        </asp:UpdatePanel>--%>
                                <div class="form-group">
                                    <div class="col-lg-12 px-0 captcha d-flex">
                                        <h6 id="mainCaptcha" clientidmode="static" class="pt-3 pr-2"></h6>
                                        <button onclick="Captcha();return false;" class="bg-transparent border-0"><img
                                                src="/images/refreshicon.png"></button><b style="color: #F00">*</b>
                                    </div>
                                    <div class="col-lg-12 px-0">
                                        <input type="text" class="customInputpopUp w-100" placeholder="">
                                        <!-- <span class="error">Enter your verification code</span> -->
                                    </div>
                                </div>
                                     
                                <div class="mt-5 d-flex justify-content-center">
                            <asp:Button ID="btnsubmit" Text="Submit" CssClass="submitButton whiteColor semiBoldFont upperCase" runat="server" OnClick="btnsubmit_Click" OnClientClick=" if ( Page_ClientValidate() ) { this.value='Please wait..';this.style.display='none';getElementById('bWait').style.display = ''; }" />
                                     <input type="button" class="submitButton whiteColor semiBoldFont upperCase" id="bWait"  value="Please wait ..." disabled="disabled" style="display:none" />
                                   
                                </div>
                            </div>
                        </div>
                            </ContentTemplate>
                           </asp:UpdatePanel>

                    </div>

                </div>
            </div>
        </div>
        </div>
        <script>
		$(document).ready(function () {

			Captcha();
			$("#pupclse").click(function () {
				$("#thnkovr").css("display", "none");
			});
		});
		function valid() {

			if (!Page_ClientValidate()) {

			}
			else {
				if (!ValidCaptcha()) {
					document.getElementById("lblErrMesg").style.display = "block";
					return false;
				}
				else {

					document.getElementById("lblErrMesg").style.display = "none";
					$("#btnSend").val("Please wait..");
					if (Page_ClientValidate()) {
						this.value = 'Please wait..'; this.style.display = 'none'; getElementById('bWait').style.display = '';
						return true;
					}
					else {
						return false;

					}
				}
			}
		}

		function Captcha() {
			var alpha = new Array('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
				'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'm', 'n', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
				'1', '2', '3', '4', '5', '6', '7', '8', '9');
			var i;
			for (i = 0; i < 6; i++) {
				var a = alpha[Math.floor(Math.random() * alpha.length)];
				var b = alpha[Math.floor(Math.random() * alpha.length)];
				var c = alpha[Math.floor(Math.random() * alpha.length)];
				var d = alpha[Math.floor(Math.random() * alpha.length)];
				var e = alpha[Math.floor(Math.random() * alpha.length)];
				var f = alpha[Math.floor(Math.random() * alpha.length)];
				var g = alpha[Math.floor(Math.random() * alpha.length)];
			}
			var code = a + ' ' + b + ' ' + ' ' + c + ' ' + d + ' ' + e + ' ' + f + ' ' + g;
			document.getElementById("mainCaptcha").innerHTML = code
			document.getElementById("mainCaptcha").value = code
		}
		function removeSpaces(string) {
			return string.split(' ').join('');
		}
		function ValidCaptcha() {
			var string1 = removeSpaces(document.getElementById('mainCaptcha').value);
			var string2 = removeSpaces(document.getElementById('Txtverify').value);

			if (string1 == string2) {
				return true;
			} else {
				return false;
			}
		}
	</script>