<%@ Page Title="" Language="C#" MasterPageFile="../accountMaster.master" AutoEventWireup="true" CodeFile="AddDepartment.aspx.cs" Inherits="cmsadmin_account_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Deparment</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PageContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="uk-grid">

        <div class="uk-width-xLarge-1-1  uk-width-large-1-1">
            <div class="md-card">
                <div class="md-card-toolbar">
                    <h3 class="md-card-toolbar-heading-text">
                        <asp:Label ID="lblDisplayText" runat="server"></asp:Label>
                        <b style="padding-left: 420px">
                            <asp:Label ID="lblStatus" runat="server"></asp:Label></b>
                        <b style="padding-left: 120px">
                            <asp:PlaceHolder ID="phLiveUrl" runat="server"></asp:PlaceHolder>
                        </b>

                    </h3>
                </div>
                <div class="md-card-content large-padding">
                    <div class="uk-grid uk-grid-divider uk-grid-medium">
                        <div class="uk-width-large-2-3">

                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3"
                                    <label>Faculty *</label>
                                    <div class="md-input-wrapper" id="dvTitle" runat="server" style="padding-top: 9px">
                                        <asp:DropDownList ID="ddlFaculty" CssClass="md-input" AutoPostBack="true" OnSelectedIndexChanged= "ddlFaculty_SelectedIndexChanged" Style="border-width: 2px 2px 2px;" runat="server">
                                            <asp:ListItem Value="">Select</asp:ListItem>
                                        </asp:DropDownList>


                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" CssClass="mt-2" runat="server" ErrorMessage="Select Faculty"  InitialValue="" ControlToValidate="ddlFaculty" ValidationGroup="val"></asp:RequiredFieldValidator>
                                        <span class="md-input-bar"></span>
                                    </div>
                                </div>
                            </div>
                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3">
                                    <label>Department *</label>
                                    <div class="md-input-wrapper" id="dvDate" runat="server" style="padding-top: 12px">
                                        <asp:TextBox ID="Txtdepartment" ClientIDMode="Static" runat="server" CssClass="md-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>
                                          <asp:RequiredFieldValidator  ID="RequiredFieldValidator2" ForeColor="Red" CssClass="mt-2" runat="server" ErrorMessage="Enter Department"  ControlToValidate="Txtdepartment" ValidationGroup="val"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </div>


                            <div class="uk-grid uk-grid-small " >
                                <div class="uk-width-medium-3-3">
                                    <asp:CheckBox ID="chkStatus" runat="server" Text="Status" data-switchery="false" Checked="true" />
                                    <%--<input type="checkbox" data-switchery="false" id="chkStatus" runat="server" style="display: none;" checked="checked" />--%>

                                    <br />
                                </div>
                            </div>
                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3">

                                    <asp:Button ID="btnSave" runat="server"
                                        CssClass="md-btn md-btn-small md-btn-flat md-btn-success" Text=" Save "
                                        OnClick="btnSave_Click"   OnClientClick="if (validatePage()) { this.value='Please wait..';this.style.display='none';getElementById('bWait').style.display = '';} else { return false; }"   
                                        ValidationGroup="val" />

            <input type="button" id="bWait" class="md-btn md-btn-small md-btn-flat md-btn-success" value="Please wait ..." disabled="disabled" style="display: none" />
                                    <asp:Button ID="btnClear" runat="server"
                                        CssClass="md-btn md-btn-small md-btn-flat md-btn-warning" Text=" Clear "
                                        OnClick="btnClear_Click" />
                                    <a  class="md-btn md-btn-small md-btn-flat md-btn-warning"  href="viewDepartment.aspx"   >View</a>
                                </div>
                            </div>
                            <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
                        </div>


                        <!--Right Side Contents-->
                        <div class="uk-width-large-1-3">
                        </div>

                        <!--End of Right Side-->
                    </div>
                </div>
            </div>


        </div>

    </div>

</asp:Content>




<asp:Content ID="Content4" ContentPlaceHolderID="PageScript" runat="Server">

    <%--<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>--%>

    <script>

        function validatePage() {
           // alert("hi");
            var flag = window.Page_ClientValidate('val');

            //alert(flag);
            return flag;
        }

    </script>


          <script type="text/javascript">

            function showCoverImage(fileInput) {

                  var files = fileInput.files;
            for (var i = 0; i < files.length; i++) {
                      var file = files[i];
            var size = parseFloat(files[i].size / 1024).toFixed(2);
            var r = 1;// (size / 1024).toFixed(2);
                      if (r >= 2) {
                alert("File size is too high , please select image lesser than 2 MB");
            var hdn = $('#hiddenEventImage').val();
            if (hdn == "undefined") {
                document.getElementById("dvEventImage").style.display = "none";
            document.getElementById("spRemove").style.display = "none";
                          }
            else {
                document.getElementById("dvEventImage").style.display = "block";
            document.getElementById("spRemove").style.display = "block";
                          }


                      }
            else {
                document.getElementById("dvEventImage").style.display = "block";
            document.getElementById("spRemove").style.display = "block";
            var imageType = /image.*/;
            if (!file.type.match(imageType)) {
                              continue;
                          }
            var img = document.getElementById("imgEventImage");
            img.file = file;
            var reader = new FileReader();
            reader.onload = (function (aImg) {
                              return function (e) {
                aImg.src = e.target.result;
                              };
                          })(img);
            reader.readAsDataURL(file);
                      }
                  }
              }
            $(".remove").click(function () {
                document.getElementById("dvEventImage").style.display = "none";
            document.getElementById("spRemove").style.display = "none";
            $('#imgEventImage').attr('src', '');
            $('#flEventImage').val("");
              });
          </script>

</asp:Content>



