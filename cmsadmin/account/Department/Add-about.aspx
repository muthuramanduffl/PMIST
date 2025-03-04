<%@ Page Title="" Language="C#" MasterPageFile="~/cmsadmin/account/accountMaster.master" AutoEventWireup="true" CodeFile="Add-about.aspx.cs" Inherits="cmsadmin_account_about" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        hr {
            border: 0;
            height: 1px;
            background-color: #000;
            margin: 20px 0;
        }



        .d-flex {
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .flex-grow-1 {
            flex-grow: 1;
        }



        .d-flex {
            display: flex;
            justify-content: space-between;
            align-items: center;
        }



        .px-4 {
            padding-left: 16px;
            padding-right: 16px;
        }

        .resize {
            width: 48%;
        }

        .resize-width {
            width: 100% !important;
        }

        .full-width {
            width: 100%;
        }

        @media (max-width:768px) {
            .first-box {
                width: 100%;
            }

            .two-box {
                width: 97%;
            }
        }

        .plus {
            color: #ffffff;
            font: bold;
            border: 1px solid;
            margin-left: 10px;
            width: 25px;
            height: 25px;
            display: flex;
            min-width: 25px;
            align-items: center;
            justify-content: center;
            border-radius: 50%;
            background: seagreen;
            cursor: pointer;
            margin-bottom: 0;
        }

        .minus {
            color: #ffffff;
            font: bold;
            margin-top: 44px;
            width: 25px;
            height: 25px;
            display: flex;
            align-items: center;
            justify-content: center;
            border-radius: 50%;
            background: red;
            margin-left: 10px;
            cursor: pointer;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="Server">
    <h1>Add Deparment About</h1>
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
                            <asp:Label ID="lblStatus" runat="server"></asp:Label>
                        </b>
                        <b style="padding-left: 120px">
                            <asp:PlaceHolder ID="phLiveUrl" runat="server"></asp:PlaceHolder>
                        </b>

                    </h3>
                </div>
                <div class="md-card-content large-padding">
                    <div class="uk-grid uk-grid-divider uk-grid-medium">
                        <div class="uk-width-large-2-3 resize-width">
                            <div class="d-flex " style="flex-wrap: wrap; justify-content: start; column-gap: 26px;">
                                <div class="uk-grid uk-grid-small resize first-box">
                                    <div class="uk-width-large-3-3">
                                        <label>Department *</label>
                                        <div class="md-input-wrapper" id="dvDepartment" runat="server" style="padding-top: 9px">
                                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                <ContentTemplate>

                                                    <asp:DropDownList ID="ddlDepartment" AutoPostBack="true" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged" CssClass="md-input form-input" Style="border-width: 2px 2px 2px;" runat="server">
                                                        <asp:ListItem Value="">Select</asp:ListItem>
                                                    </asp:DropDownList>
                                                </ContentTemplate>
                                                <Triggers>
                                                    <asp:AsyncPostBackTrigger ControlID="ddlDepartment" EventName="SelectedIndexChanged" />
                                                </Triggers>
                                            </asp:UpdatePanel>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Select Department" InitialValue="" ControlToValidate="ddlDepartment" ValidationGroup="val"></asp:RequiredFieldValidator>

                                            <span class="md-input-bar"></span>
                                        </div>
                                    </div>
                                </div>

                                <div class="d-flex resize two-box">
                                    <div class="  uk-grid uk-grid-small " style="position: relative; width: 100%; height:max-content;" id="doctoraterow">
                                        <div class="uk-width-large-3-3 d-flex align-items-center">
                                            <div class="flex-grow-1 col-8" style="margin-bottom: 4px;">
                                                <label for="txtIntroContent">Intro Content *</label>
                                                <div class="md-input-wrapper" id="dvPO" runat="server" style="padding-top: 12px">
                                                    <asp:TextBox ID="txtIntroContent" ClientIDMode="Static"   ValidateRequestMode="Disabled" Rows="8"  cols="50" placeholder="" TextMode="MultiLine" runat="server" CssClass="md-input form-input editor" ></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Enter Intro Content" ControlToValidate="txtIntroContent" ValidationGroup="val"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>

                                         
                                        </div>

                                    </div>
                                    
                                </div>




                                <!-- Container to append new cloned rows -->

                            </div>
                            <div id="dgadd" style="margin-top: 20px;"></div>
                            <hr />
                            <div class=" d-flex flex-column" style="flex-direction: column;">

                                <div class="full-width">


                                    <div class="d-flex full-width">
                                        <div class="uk-grid uk-grid-small full-width  doctorateduplicatepo" id="doctoraterowPO">
                                            <div class="uk-width-large-3-3 d-flex align-items-center">
                                                <div class="flex-grow-1 col-4">
                                                    <label for="txtSO">Vision *</label>
                                                    <div class="md-input-wrapper" id="Div2" runat="server" style="padding-top: 12px">
                                                        <asp:TextBox ID="txtpo" ClientIDMode="Static" runat="server" CssClass="md-input form-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Enter vision" ControlToValidate="txtpo" ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>


                                                <div class="d-flex align-items-center">
                                                    <div class="remove-more-btn-doctoratepo" style="display: none;">
                                                        <p class="minus btn-removepo">x</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div runat="server" id="Divpo">
                                            <p class="plus btn-addpo" id="doctoratebuttonpo">+</p>
                                        </div>
                                    </div>
                                </div>


                                <div id="dgadd1" style="width: 100%; margin-top: 20px;"></div>
                                <hr />
                                <div class="full-width">
                                  



                                    <div class="d-flex full-width">
                                        <div class="uk-grid uk-grid-small full-width doctorateduplicatePEO" id="doctoraterowPEO">
                                            <div class="uk-width-large-3-3 d-flex align-items-center">
                                                <div class="flex-grow-1 col-4">
                                                    <label for="txtPEO">Mission *</label>
                                                    <div class="md-input-wrapper" id="Div3" runat="server" style="padding-top: 12px">
                                                        <asp:TextBox ID="TXTPEO" ClientIDMode="Static" runat="server" CssClass="md-input form-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Enter mission" ControlToValidate="TXTPEO" ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>

                                                <div class="d-flex align-items-center">
                                                    <div class="remove-more-btn-doctoratePEO" style="display: none;">
                                                        <p class="btn-removePEO minus">x</p>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                        <div runat="server" id="divpeo">
                                            <p class="plus btn-addPEO" id="doctoratebuttonPEO">+</p>
                                        </div>
                                    </div>
                                </div>


                                <div id="dgadd2" style="width: 100%; margin-top: 20px;"></div>
                                <hr />

                                <div class="full-width">
                                    
                                    <div class="d-flex full-width ">
                                        <div class="uk-grid uk-grid-small full-width doctorateduplicatePSO" id="doctoraterowPSO">
                                            <div class="uk-width-large-3-3 d-flex align-items-center">
                                                <div class="flex-grow-1 col-4">
                                                    <label for="txtPSO">Objective *</label>
                                                    <div class="md-input-wrapper" id="Div4" runat="server" style="padding-top: 12px">
                                                        <asp:TextBox ID="TXTPSO" ClientIDMode="Static" runat="server" CssClass="md-input form-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>

                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Enter Objective" ControlToValidate="TXTPSO" ValidationGroup="val"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>

                                                <div class="d-flex align-items-center">
                                                    <div class="remove-more-btn-doctoratePSO" style="display: none;">
                                                        <p class="btn-removePSO minus">x</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div runat="server" id="divpso">
                                            <p class="plus btn-addPSO" id="doctoratebuttonPSO">+</p>
                                        </div>
                                    </div>
                                </div>

                                <div id="dgadd3" style="width: 100%; margin-top: 20px;" ></div>
                                <!-- Container to append new cloned rows -->
                            </div>                          
                            <div>                             
                            <span class="md-input-bar"></span>
                            <div class="uk-grid uk-grid-small" style="padding-top: 30px;">
                                <div class="uk-width-large-3-3">
                                    <asp:Button ID="btnSave" runat="server"
                                        CssClass="md-btn md-btn-small md-btn-flat md-btn-success btnSave" Text=" Save "
                                        OnClick="btnSave_Click" OnClientClick="if (validatePage()) { this.value='Please wait..';this.style.display='none';getElementById('bWait').style.display = '';} else { return false; }"
                                        ValidationGroup="val" />
                                    <input type="button" id="bWait" class="md-btn md-btn-small md-btn-flat md-btn-success" value="Please wait ..." disabled="disabled" style="display: none" />
                                    <asp:Button ID="btnClear" runat="server"
                                        CssClass="md-btn md-btn-small md-btn-flat md-btn-warning" Text=" Clear "
                                        OnClick="btnClear_Click" />
                                    <a class="md-btn md-btn-small md-btn-flat md-btn-warning " href="viewabout.aspx">View</a>
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




     <script src="https://cdn.ckeditor.com/ckeditor5/32.0.0/classic/ckeditor.js"></script>

<script>
    document.addEventListener('DOMContentLoaded', function () {
        ClassicEditor
            .create(document.querySelector('.editor'), {
                toolbar: [
                    'bold', 'italic', 'link', 'undo', 'redo',
                    'bulletedList', 'numberedList',
                    'specialCharacters', 'code'
                ],
                language: 'en', // Ensure language support
                removePlugins: ['MediaEmbed'] // If media embedding causes issues
            })
            .then(editor => {
                editor.model.document.on('change:data', () => {
                    document.getElementById('<%= txtIntroContent.ClientID %>').value = editor.getData();
                });
            })
            .catch(error => console.error(error));
    });
</script>

<%--  <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>--%>

    <script>

        function validatePage() {
            // alert("hi");
            var flag = window.Page_ClientValidate('val');

            //alert(flag);
            return flag;
        }

    </script>






    <script>
        $(document).ready(function () {
            var i = $(".doctorateduplicatepo").length;
            var maxClones = 10;

            function addNewClone() {
                if (i < maxClones) {
                    var clone = $("#doctoraterowPO").first().clone();
                    i++;

                    clone.attr("id", "doctoraterowPO" + i);

                    clone.find("input[type='text']").each(function () {
                        var newId = "txtpo" + i;
                        $(this).attr("id", newId);
                        $(this).attr("name", newId);
                        $(this).addClass("form-input");
                        $(this).val("");
                    });

                    clone.find(".remove-more-btn-doctoratepo").show();
                    clone.find(".required-validator").remove();

                    clone.find("label").text("Vision");
                    $("#dgadd1").append(clone);

                    if (i >= maxClones) {
                        alert("You can only add up to " + maxClones + " items.");
                        $(".btn-addpo").prop('disabled', true);
                    }
                }
            }
            $(document).on("click", "#doctoratebuttonpo", function () {
                addNewClone();
            });


            $(document).on("click", ".remove-more-btn-doctoratepo", function () {
                $(this).closest(".doctorateduplicatepo").remove();
                i--;

                if (i < maxClones) {
                    $(".btn-addpo").prop('disabled', false);
                }
            });

            if (i >= maxClones) {
                $(".btn-addpo").prop('disabled', true);
            }
        });
    </script>


    <script>
        $(document).ready(function () {
            var i = $(".doctorateduplicatePEO").length;
            var maxClones = 10;

            function addNewClone() {
                if (i < maxClones) {
                    var clone = $("#doctoraterowPEO").first().clone();
                    i++;
                    clone.attr("id", "doctoraterowPEO" + i);
                    clone.find(".required-validator").remove();
                    clone.find("input[type='text']").each(function () {
                        var newId = "TXTPEO" + i;
                        $(this).attr("id", newId);
                        $(this).attr("name", newId);
                        $(this).addClass("form-input");
                        $(this).val("");
                    });

                    clone.find(".remove-more-btn-doctoratePEO").show();
                    clone.find("label").text("Mission");
                    $("#dgadd2").append(clone);

                    if (i >= maxClones) {
                        alert("You can only add up to " + maxClones + " items.");
                        $(".btn-addPEO").prop('disabled', true);
                    }
                }
            }


            $(document).on("click", "#doctoratebuttonPEO", function () {
                addNewClone();
            });


            $(document).on("click", ".remove-more-btn-doctoratePEO", function () {
                $(this).closest(".doctorateduplicatePEO").remove();
                i--;

                if (i < maxClones) {
                    $(".btn-addPEO").prop('disabled', false);
                }
            });

            if (i >= maxClones) {
                $(".btn-addPEO").prop('disabled', true);
            }
        });
    </script>

    <script>
        $(document).ready(function () {
            var i = $(".doctorateduplicatePSO").length;
            var maxClones = 10;

            function addNewClone() {
                if (i < maxClones) {
                    var clone = $("#doctoraterowPSO").first().clone();
                    i++;

                    clone.attr("id", "doctoraterowPSO" + i);
                    clone.find(".required-validator").remove();
                    clone.find("input[type='text']").each(function () {
                        var newId = "TXTPSO" + i;
                        $(this).attr("id", newId);
                        $(this).attr("name", newId);
                        $(this).addClass("form-input");
                        $(this).val("");
                    });

                    clone.find(".remove-more-btn-doctoratePSO").show();


                    clone.find("label").text("Objective");

                    $("#dgadd3").append(clone);


                    if (i >= maxClones) {
                        alert("You can only add up to " + maxClones + " items.");
                        $(".btn-addPSO").prop('disabled', true);
                    }
                }
            }


            $(document).on("click", "#doctoratebuttonPSO", function () {
                addNewClone();
            });


            $(document).on("click", ".remove-more-btn-doctoratePSO", function () {
                $(this).closest(".doctorateduplicatePSO").remove();
                i--;

                if (i < maxClones) {
                    $(".btn-addPSO").prop('disabled', false);
                }
            });

            if (i >= maxClones) {
                $(".btn-addPSO").prop('disabled', true);
            }
        });
    </script>


















    <script>
        $(document).ready(function () {
            $(document).on("keydown", ".form-input", function (e) {
                if (e.key === "Enter") {
                    e.preventDefault();

                    var inputs = $(".form-input");
                    var currentIndex = inputs.index(this);

                    if (currentIndex < inputs.length - 1) {
                        inputs.eq(currentIndex + 1).focus();
                    } else {
                        $(".btnSave").focus().click();
                    }
                }
            });
        });
    </script>




</asp:Content>



