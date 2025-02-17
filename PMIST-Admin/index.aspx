<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Admin Dashboard | PMIST</title>
    <link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet' />
    <link rel="stylesheet" href="assets/css/login.css" />
    <link rel="icon" href="https://demo.pmu.edu/PMIST-admin/assets/img/fav-icon.png" type="image/x-icon" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <div class="login-box">
                <div class="login-header">
                    <span>PMIST-Admin</span>
                </div>
                <div class="input_box">
                    <%--<input type="text" id="user" class="input-field" required>--%>
                    <asp:TextBox ID="txtusername" MaxLength="75" class="input-field" runat="server"></asp:TextBox>


                    <label for="user" class="label">Username</label>
                    <i class="bx bx-user icon"></i>
                    <span class="error-message">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtusername" ValidationGroup="Val" runat="server" ErrorMessage="Enter username"></asp:RequiredFieldValidator>
                    </span>
                </div>
                <div class="input_box">
                    <asp:TextBox ID="txtpassword" MaxLength="75" class="input-field" runat="server"></asp:TextBox>


                    <label for="pass" class="label">Password</label>
                    <i class="bx bx-lock-alt icon" id="togglePassword"></i>
                    <span class="error-message">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtpassword" ValidationGroup="Val" runat="server" ErrorMessage="Enter password"></asp:RequiredFieldValidator>
                    </span>
                </div>

                <div class="input_box">
                    <asp:Button ID="btnsubmit" class="input-submit" runat="server" Text="Go" ValidationGroup="Val" OnClick="btnsubmit_Click" OnClientClick="if (validatePage()) { this.value='Please wait..'; this.style.display='none'; document.getElementById('bWait').style.display = '';return true; } else { return false; }" />
                    <button type="button" style="display: none" id="bWait" class="btn"><i class='fa fa-spinner fa-spin'></i></button>
                </div>
            </div>
        </div>

        <script>
            document.addEventListener("DOMContentLoaded", () => {
                document.getElementById("togglePassword").addEventListener("click", function () {
                    const passwordField = document.getElementById("pass");
                    const type = passwordField.getAttribute("type") === "password" ? "text" : "password";
                    passwordField.setAttribute("type", type);

                    // Toggle icon class
                    this.classList.toggle("bx-hide");
                    this.classList.toggle("bx-show");
                });
            });

            function showError(element, message) {
                const errorSpan = document.createElement("span");
                errorSpan.className = "error-message";
                errorSpan.textContent = message;
                element.parentElement.appendChild(errorSpan);
            }

            function clearErrors() {
                const errors = document.querySelectorAll(".error-message");
                errors.forEach((error) => error.remove());
            }


        </script>


        <script type="text/javascript">
            function validatePage() {
                // alert("hi");
                var flag = Page_ClientValidate('Val')
                //alert(flag);
                return flag;
            }
            //const passwordInput = document.querySelector("[id$='txtpassword']");
            //const togglePassword = document.getElementById("togglePassword");
            //togglePassword.addEventListener("click", function () {
            //    const isPassword = passwordInput.type === "password";
            //    passwordInput.type = isPassword ? "text" : "password";
            //    this.classList.toggle("bi-eye");
            //    this.classList.toggle("bi-eye-slash");
            //});
        </script>
    </form>
</body>
</html>
