<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCAdmissionCampaign.ascx.cs" Inherits="includes_UCAdmissionCampaign" %>

<div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog"
        aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">

                <div class="modal-body p-0 pb-4">
                    <div class="contactBox px-4">
                       
                        <div class="pt-3">
                            <div class="d-flex justify-content-between align-items-center pb-2 modalBottom">
                                <h4 class="blueColor Oswald OswaldR upperCase semiBoldFont text-uppercase mb-0">Enquire Now</h4>
                                <div data-dismiss="modal" aria-label="Close" class="cusror-pointer">
                                    <img src="https://pmu.edu/admission/images/close-gradient.png" class="closeGrOne">
                                </div>
                            </div>
                            <div class="mt-4">
                                <div>
                                    <div class="regularFont greyColor modalHeading">Name of the Applicant <b style="color: #F00">*</b></div>
                                    <asp:TextBox ID="txtName" CssClass="customInputpopUp w-100" runat="server"></asp:TextBox>                                   
                                    <div class="errorMessage"><asp:RequiredFieldValidator ID="reqv" runat="server" ControlToValidate="txtName" ErrorMessage="Please Enter Your Name" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regv" runat="server" ControlToValidate="txtName" ValidationExpression="^[a-zA-Z'.\s]{3,54}" ErrorMessage="Enter Your Valid Name" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator></div>
                                </div>
                                <div class="mt-3">
                                    <div class="regularFont greyColor modalHeading">Date of Bitrh <b style="color: #F00">*</b></div>
                                     <asp:TextBox ID="txtDateofBirth" ClientIDMode="Static" runat="server" placeholder="dd/mm/yyyy" CssClass="customInputpopUp w-100 datepicker"></asp:TextBox>
                                   
                                    <div class="errorMessage"><asp:RequiredFieldValidator ID="rvDateofbirth" runat="server" ControlToValidate="txtDateofBirth" ErrorMessage="Select Your Date Of Birth"
                                            Display="Dynamic" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revDate2" ErrorMessage="DateFormat should be dd/mm/yyyy" Display="Dynamic" Font-Size="Small" ForeColor="Red"
    ControlToValidate="txtDateofBirth" runat="server" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/]\d{4}" /></div>
                                </div>
                                
                              <%--  <div class="mt-4">
                                    <div class="regularFont greyColor modalHeading">Course Mode <b style="color: #f00">*</b> </div>
                                    <div class="d-flex mt-2 flex-wrap">
                                        <asp:RadioButtonList ID="rbCourseType" runat="server" >
                                            <asp:ListItem Value="0" Text="Regular"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Part Time"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Lateral"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Integrated"></asp:ListItem>
                                            </asp:RadioButtonList>
                                       
                                    </div>
                                    <div class="errorMessage"> <asp:RequiredFieldValidator ID="revcourseType" runat="server" ControlToValidate="rbCourseType" ErrorMessage="Select Course Mode" Display="Dynamic" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator></div>
                                </div>--%>
                              
                               
                                 
                                <div class="mt-3">
                                    <div class="regularFont greyColor modalHeading">Mobile Number <b style="color: #F00">*</b></div>
                                    <asp:TextBox ID="txtMobileNo" CssClass="customInputpopUp w-100" runat="server"></asp:TextBox>
                                      <div class="errorMessage"><asp:RequiredFieldValidator ID="rvCaste" runat="server" ControlToValidate="txtMobileNo"
                                            CssClass="failureNotification" ErrorMessage="Please Enter Your Mobile No"
                                            Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regmobile" runat="server" ControlToValidate="txtMobileNo"
                                            ValidationExpression="[0-9]{10,10}" ErrorMessage="Enter Your Vaild Mobile No" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator></div>
                                </div>
                                <div class="mt-3">
                                    <div class="regularFont greyColor modalHeading">Email ID <b style="color: #F00">*</b></div>
                                    <asp:TextBox ID="txtEmailId" CssClass="customInputpopUp w-100" runat="server"></asp:TextBox>
                                          <div class="errorMessage"><asp:RequiredFieldValidator ID="rvEmailid" runat="server" ControlToValidate="txtEmailId"
                                            CssClass="failureNotification" ErrorMessage="Please Enter Your Email Id"
                                            Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regEmailId" runat="server" ControlToValidate="txtEmailId"
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red" ErrorMessage="Enter Your Vaild Email Id" Display="Dynamic"></asp:RegularExpressionValidator></div>
                                </div>
                               <div class="mt-3">
                                    <div class="regularFont greyColor modalHeading">Location <b style="color: #F00">*</b></div>
                                    <asp:TextBox ID="txtLocation" CssClass="customInputpopUp w-100" runat="server"></asp:TextBox>
                                      <div class="errorMessage"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLocation"
                                            CssClass="failureNotification" ErrorMessage="Please Enter Your Location"
                                            Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
                                       
                                </div>
                               
                                      <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>   --%>
                               
                                
                                              <%-- </ContentTemplate>

                                        </asp:UpdatePanel>--%>
                                <div class="mt-5 d-flex justify-content-center">
                            <asp:Button ID="btnsubmit" Text="Submit" CssClass="submitButton whiteColor semiBoldFont upperCase" runat="server" OnClick="btnsubmit_Click" OnClientClick=" if ( Page_ClientValidate() ) { this.value='Please wait..';this.style.display='none';getElementById('bWait').style.display = ''; }" />
                                     <input type="button" class="submitButton whiteColor semiBoldFont upperCase" id="bWait"  value="Please wait ..." disabled="disabled" style="display:none" />
                                   
                                </div>
                            </div>
                        </div>
                           
                    </div>
                        </div>
                </div>
            </div>
        </div>
        </div>