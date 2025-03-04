<%@ Page Title="" Language="C#" MasterPageFile="~/cmsadmin/account/accountMaster.master" AutoEventWireup="true" CodeFile="Add-Departmentcourses old.aspx.cs" Inherits="cmsadmin_account_Default" %>

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
    </style>





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
                            <asp:Label ID="lblStatus" runat="server"></asp:Label>
                        </b>
                        <b style="padding-left: 120px">
                            <asp:PlaceHolder ID="phLiveUrl" runat="server"></asp:PlaceHolder>
                        </b>

                    </h3>
                </div>
                <div class="md-card-content large-padding">
                    <div class="uk-grid uk-grid-divider uk-grid-medium">
                        <div class="uk-width-large-2-3">
                            <div class="">
                                <div class="uk-grid uk-grid-small">
                                    <div class="uk-width-large-3-3">
                                        <label>Department *</label>
                                        <div class="md-input-wrapper" id="dvDepartment" runat="server" style="padding-top: 9px">
                                            <asp:DropDownList ID="ddlDepartment" CssClass="md-input form-input" Style="border-width: 2px 2px 2px;" runat="server">
                                                <asp:ListItem Value="">Select</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Select Department" InitialValue="" ControlToValidate="ddlDepartment" ValidationGroup="val"></asp:RequiredFieldValidator>

                                            <span class="md-input-bar"></span>
                                        </div>
                                    </div>
                                </div>
                                <p class="px-4 btn-add" id="doctoratebutton" style="color: green; font: bold;">+</p>

                                <div class="uk-grid uk-grid-small doctorateduplicate" id="doctoraterow">
                                    <div class="uk-width-large-3-3 d-flex align-items-center">
                                        <div class="flex-grow-1 col-4">
                                            <label for="txtProgrammeOffered">Programme Offered *</label>
                                            <div class="md-input-wrapper" id="dvPO" runat="server" style="padding-top: 12px">
                                                <asp:TextBox ID="txtProgrammeOffered" ClientIDMode="Static" runat="server" CssClass="md-input form-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Enter Programme Offered" ControlToValidate="txtProgrammeOffered" ValidationGroup="val"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>

                                        <div class="d-flex align-items-center">
                                            <div class="remove-more-btn-doctorate" style="display: none;">
                                                <p class="px-4 btn-remove" style="color: red; font: bold;">x</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>



                                <!-- Container to append new cloned rows -->

                            </div>
                            <div id="dgadd"></div>
                            <hr />
                            <div class=" flex-column">
                                <div class="uk-grid uk-grid-small">
                                    <div class="uk-width-large-3-3">
                                        <label>Introduction</label>
                                        <div class="md-input-wrapper" id="Div1" runat="server" style="padding-top: 9px">
                                            <asp:TextBox ID="txtindroduction" Style="border-width: 2px 2px 2px;" CssClass="md-input form-input" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Enter introduction" ControlToValidate="txtindroduction" ValidationGroup="val"></asp:RequiredFieldValidator>

                                            <span class="md-input-bar"></span>
                                        </div>
                                    </div>
                                </div>

                                <p class="px-4 btn-addpo" id="doctoratebuttonpo" style="color: green; font: bold;">+</p>

                                <div class="uk-grid uk-grid-small doctorateduplicatepo" id="doctoraterowPO">
                                    <div class="uk-width-large-3-3 d-flex align-items-center">
                                        <div class="flex-grow-1 col-4">
                                            <label for="txtSO">PO *</label>
                                            <div class="md-input-wrapper" id="Div2" runat="server" style="padding-top: 12px">
                                                <asp:TextBox ID="txtpo" ClientIDMode="Static" runat="server" CssClass="md-input form-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Enter introduction" ControlToValidate="txtindroduction" ValidationGroup="val"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>


                                        <div class="d-flex align-items-center">
                                            <div class="remove-more-btn-doctoratepo" style="display: none;">
                                                <p class="px-4 btn-removepo" style="color: red; font: bold;">x</p>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div id="dgadd1"></div>




                                <p class="px-4 btn-addPEO" style="color: green; font: bold" runat="server" id="doctoratebuttonPEO">+</p>
                                <div class="uk-grid uk-grid-small doctorateduplicatePEO" id="doctoraterowPEO">
                                    <div class="uk-width-large-3-3 d-flex align-items-center">
                                        <div class="flex-grow-1 col-4">
                                            <label for="txtPEO">PEO *</label>
                                            <div class="md-input-wrapper" id="Div3" runat="server" style="padding-top: 12px">
                                                <asp:TextBox ID="TXTPEO" ClientIDMode="Static" runat="server" CssClass="md-input form-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Enter PEO" ControlToValidate="TXTPEO" ValidationGroup="val"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>

                                        <div class="d-flex align-items-center">
                                            <div class="remove-more-btn-doctoratePEO" style="display: none;">
                                                <p class="px-4 btn-removePEO " style="color: red; font: bold;">x</p>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div id="dgadd2"></div>

                                <p class="px-4 btn-addPSO" style="color: green; font: bold" runat="server" id="doctoratebuttonPSO">+</p>
                                <div class="uk-grid uk-grid-small doctorateduplicatePSO" id="doctoraterowPSO">
                                    <div class="uk-width-large-3-3 d-flex align-items-center">
                                        <div class="flex-grow-1 col-4">
                                            <label for="txtPSO">PSO *</label>
                                            <div class="md-input-wrapper" id="Div4" runat="server" style="padding-top: 12px">
                                                <asp:TextBox ID="TXTPSO" ClientIDMode="Static" runat="server" CssClass="md-input form-input" Style="border-width: 2px 2px 2px;"></asp:TextBox>

                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Enter PSO" ControlToValidate="TXTPSO" ValidationGroup="val"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>

                                        <div class="d-flex align-items-center">
                                            <div class="remove-more-btn-doctoratePSO" style="display: none;">
                                                <p class="px-4 btn-removePSO  " style="color: red; font: bold;">x</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div id="dgadd3"></div>
                                <!-- Container to append new cloned rows -->

                            </div>

                            <hr />


                            <div>
                                <label>Curriculum: </label>
                            </div>


                            <p id="addFileUploadBtn" style="cursor: pointer; color: green;">+</p>

                            <div id="fileUploadContainer">
                                <!-- Default original file upload row -->
                                <div class="file-upload-row" id="fileUploadRow1" style="display: flex; justify-content: space-between; margin-bottom: 10px;">
                                    <label for="textBox1">Title </label>
                                    <div class="md-input-wrapper" style="flex: 1;">

                                        <asp:TextBox ID="textBox" Style="border-width: 2px;" class="md-input pb-5 form-input" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="md-input-wrapper ml-5" style="flex: 1;">
                                        <label for="fileUpload" class="MT-5">Choose file (PDF only, max 1 MB)</label>
                                        <asp:FileUpload type="file" ClientIDMode="Static" ID="fileUpload" class="md-input form-input" accept=".pdf" onchange="handleFileUpload(this)" runat="server"></asp:FileUpload>
                                    </div>
                                    <p type="button" class="remove-btn" style="color: red; display: none;">x</p>
                                </div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Enter curriculum" ControlToValidate="textBox" ValidationGroup="val"></asp:RequiredFieldValidator>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ForeColor="Red" CssClass="mt-2 required-validator" runat="server" ErrorMessage="Upload File" ControlToValidate="fileUpload" ValidationGroup="val"></asp:RequiredFieldValidator>
                            </div>




                            <span class="md-input-bar"></span>
                            <div class="uk-grid uk-grid-small">
                                <div class="uk-width-large-3-3">

                                    <asp:Button ID="btnSave" runat="server"
                                        CssClass="md-btn md-btn-small md-btn-flat md-btn-success btnSave" Text=" Save "
                                        OnClick="btnSave_Click" OnClientClick="if (validatePage()) { this.value='Please wait..';this.style.display='none';getElementById('bWait').style.display = '';} else { return false; }"
                                        ValidationGroup="val" />

                                    <input type="button" id="bWait" class="md-btn md-btn-small md-btn-flat md-btn-success" value="Please wait ..." disabled="disabled" style="display: none" />
                                    <asp:Button ID="btnClear" runat="server"
                                        CssClass="md-btn md-btn-small md-btn-flat md-btn-warning" Text=" Clear "
                                        OnClick="btnClear_Click" />
                                    <a class="md-btn md-btn-small md-btn-flat md-btn-warning " style="display:none" href="viewDepartment.aspx">View</a>
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

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

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
            var i = $(".doctorateduplicate").length;
            var maxClones = 10;

            function addNewClone() {
                if (i < maxClones) {
                    var clone = $("#doctoraterow").first().clone(); 
                    i++; 

                    clone.attr("id", "doctoraterow" + i);
                    clone.find("input[type='text']").each(function () {
                        var newId = "txtProgrammeOffered" + i;
                        $(this).attr("id", newId); 
                        $(this).attr("name", newId);
                        $(this).addClass("form-input");
                        $(this).val(""); 
                    });
                    clone.find(".required-validator").remove();
                    clone.find("label").text("Programme Offered");

                    clone.find(".remove-more-btn-doctorate").show();

                    $("#dgadd").append(clone);

                    if (i >= maxClones) {
                        alert("You can only add up to " + maxClones + " items.");
                        $(".btn-add").prop('disabled', true);
                    }
                }
            }

            $("#doctoratebutton").on("click", function () {
                addNewClone(); 
            });

            $(document).on("click", ".remove-more-btn-doctorate", function () {
                $(this).closest(".doctorateduplicate").remove();
                i--; 

                if (i < maxClones) {
                    $(".btn-add").prop('disabled', false);
                }
            });

            if (i >= maxClones) {
                $(".btn-add").prop('disabled', true);
            }
        });
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

                    clone.find("label").text("PO");
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
                    clone.find("label").text("PEO");
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


                    clone.find("label").text("PSO");
                
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
            let rowCounter = 1;
            const maxRows = 10; 
            function addNewFileUploadRow() {
                if (rowCounter < maxRows) {
                    rowCounter++; 

                    const clone = $("#fileUploadRow1").clone();

                    clone.attr("id", "fileUploadRow" + rowCounter);

                    clone.find("input[type='text']").each(function () {
                        const newId = "textBox" + rowCounter;
                        $(this).attr("id", newId);
                        $(this).attr("name", newId);
                        $(this).val(""); 
                    });

                    clone.find("input[type='file']").each(function () {
                        const newId = "fileUpload" + rowCounter;
                        $(this).attr("id", newId);
                        $(this).attr("name", newId);
                        $(this).addClass("form-input");
                        $(this).val(""); 
                        $(this).off("change").on("change", function () {
                            handleFileUpload(this); 
                        });
                    });

                    clone.find(".remove-btn").show();
                    clone.find(".remove-btn").attr("data-row", "fileUploadRow" + rowCounter);

                    $("#fileUploadContainer").append(clone);
                } else {
                    alert("You can only add up to " + maxRows + " rows.");
                }
            }


            $(document).on("click", ".remove-btn", function () {
                const rowId = $(this).data("row");
                $("#" + rowId).remove(); 
                rowCounter--; 
            });


            function handleFileUpload(fileInput) {
                const allowedFiles = [".pdf"];
                const file = fileInput.files[0];
                const ext = file.name.split(".").pop().toLowerCase();

                if (!allowedFiles.includes("." + ext)) {
                    alert("Please select PDF files only.");
                    resetFileInput(fileInput);
                    return;
                }

                const size = file.size / 1024 / 1024;
                if (size > 1) {
                    alert("File size exceeds 1 MB. Please upload a smaller file.");
                    resetFileInput(fileInput);
                    return;
                }
            }
            function resetFileInput(fileInput) {
                fileInput.value = ""; 
            }

            $("#addFileUploadBtn").on("click", function () {
                addNewFileUploadRow();
            });

            $("#fileUploadRow1 .remove-btn").hide();
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



