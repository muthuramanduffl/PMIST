using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addresearch : System.Web.UI.Page
{
    Bindddl Ddl = new Bindddl();
    pmistplacements PMP = new pmistplacements();
    protected void Page_Load(object sender, EventArgs e)
    {
        hdnID.Value = null;
        int value = 0;
        if (Request.QueryString["PID"] != null)
        {
            if (int.TryParse(Request.QueryString["PID"], out value))
            {
                //edit
                btnSave.Text = "Update";
                lbldisplayText.Text = "Edit Research";
                hdnID.Value = Convert.ToString(value);
            }
            else
            {
                string script = string.Format(@" 
                    <script> 
                    Swal.fire({{ 
                        title: ' URL is incorrect. please try again', 
                        confirmButtonText: 'OK', 
                        customClass: {{ 
                            confirmButton: 'handle-btn-success'  
                        }} 
                    }}).then((result) => {{  
                            window.location.href = 'view-research.aspx';   
                    }}); 
                    </script>");
                ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);
            }
        }
        else
        {
            lbldisplayText.Text = "Add Research";
            btnSave.Text = "Submit";
            //add
        }

        if (!IsPostBack)
        {
            Ddl.GetDepartmentddl(ddldepartment);
            ddldepartment.Items.Insert(0, new ListItem("", ""));
            if (hdnID.Value != null && !string.IsNullOrEmpty(hdnID.Value))
            {
                Bind(Convert.ToInt32(hdnID.Value));
            }
        }
    }


    public void Bind(int ID)
    {
        DataTable Dt = PMP.ViewAllPlacements("", "", Convert.ToString(ID), "Research");

        if (Dt.Rows.Count > 0)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Department"])))
            {
                ddldepartment.SelectedValue = Convert.ToString(Dt.Rows[0]["Department"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["PStatus"])))
            {
                toggleActiveInactive.Checked = Convert.ToBoolean(Dt.Rows[0]["PStatus"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Content"])))
            {
                txtcontent.Text = Convert.ToString(Dt.Rows[0]["Content"]);
            }

        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["PID"] == null)
        {
            Clear();
            Response.Redirect(Request.Url.GetLeftPart(UriPartial.Path));
        }
        else
        {
            Response.Redirect("view-research.aspx");
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string lblerror = string.Empty;
        if (string.IsNullOrEmpty(ddldepartment.SelectedValue) && string.IsNullOrEmpty(txtcontent.Text))
        {
            lblerror = "Fill all the field";
        }
        else if (string.IsNullOrEmpty(ddldepartment.SelectedValue))
        {
            lblerror = "Select department";
        }
        else if (string.IsNullOrEmpty(txtcontent.Text))
        {
            lblerror = "Enter Content";
        }

        if (string.IsNullOrEmpty(lblerror))
        {
            if (Request.QueryString["PID"] == null)
            {
                int ret = 0;
                ret = AddData();
                if (ret == 1)
                {
                    Clear();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'Research detail has been added successfully.', " +
                           "  icon: 'success', " +
                           "  allowOutsideClick: 'true', " +
                           "  customClass: { " +
                           "    icon: 'handle-icon-clr', " +
                           "    confirmButton: 'handle-btn-success' " +
                           "  } " +
                           "}).then((result) => { " +
                           "  window.location.href = '" + Request.Url.AbsolutePath + "'; " +
                           "});", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
       "Swal.fire({ " +
       "  title: 'Research detail has not been added due to a server issue.', " +  // Corrected the title string
       "  icon: 'success', " +
       "  allowOutsideClick: true, " +  // No need for quotes around true
       "  customClass: { " +
       "    icon: 'handle-icon-clr', " +
       "    confirmButton: 'handle-btn-success' " +
       "  } " +
       "});", true);

                }
            }
            else
            {
                int ret = 0;
                ret = Updatedata();
                if (ret == 1)
                {
                    Clear();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'Research detail has been update successfully.', " +
                           "  icon: 'success', " +
                           "  allowOutsideClick: 'true', " +
                           "  customClass: { " +
                           "    icon: 'handle-icon-clr', " +
                           "    confirmButton: 'handle-btn-success' " +
                           "  } " +
                           "}).then((result) => { " +
                           "  window.location.href = '" + "view-research.aspx" + "'; " +
                           "});", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                                               "Swal.fire({ " +
                                               "  title: 'Research detail has not been updated due to a server issue., " +
                                               "  icon: 'success', " +
                                               "  allowOutsideClick: 'true', " +
                                               "  customClass: { " +
                                               "    icon: 'handle-icon-clr', " +
                                               "    confirmButton: 'handle-btn-success' " +
                                               "  } " +
                                               "}).then((result) => { " +
                                               "  window.location.href = '" + "view-research.aspx" + "'; " +
                                               "});", true);
                }
            }
        }
    }

    public int AddData()
    {
        int rowaffected = 0;
        try
        {
            PMP.strDepartment = ddldepartment.SelectedValue;
            PMP.boolPStatus = toggleActiveInactive.Checked;

            string encodedText = HttpUtility.HtmlEncode(txtcontent.Text);
            string decodedText = HttpUtility.HtmlDecode(encodedText);
            PMP.strcontent = decodedText;
            PMP.strpagename = "Research";
            PMP.strAddedBy = "admin";
            rowaffected = PMP.AddPMISTplacements(PMP);
        }
        catch (Exception ex)
        {
            //
        }

        return rowaffected;

    }



    public int Updatedata()
    {
        int rowaffected = 0;
        try
        {
            PMP.intPID = Convert.ToInt32(hdnID.Value);
            PMP.strDepartment = ddldepartment.SelectedValue;
            PMP.boolPStatus = toggleActiveInactive.Checked;
            string encodedText = HttpUtility.HtmlEncode(txtcontent.Text);
            string decodedText = HttpUtility.HtmlDecode(encodedText);
            PMP.strcontent = decodedText;
            PMP.strpagename = "Research";
            PMP.strUpdatedBy = "admin";
            rowaffected = PMP.updatePMISTplacements(PMP);
        }
        catch (Exception ex)
        {
            //
        }

        return rowaffected;

    }

    public void Clear()
    {

        ddldepartment.SelectedIndex = 0;
        txtcontent.Text = "";
        toggleActiveInactive.Checked = true;
    }
}