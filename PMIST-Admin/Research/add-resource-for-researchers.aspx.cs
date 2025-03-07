using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMIST_Admin_resourceforresearchersDefault : System.Web.UI.Page
{
    Bindddl Ddl = new Bindddl();
    pmistresourceofresources PMROR = new pmistresourceofresources();
    protected void Page_Load(object sender, EventArgs e)
    {
        hdnID.Value = null;
        int value = 0;
        if (Request.QueryString["RFID"] != null)
        {
            if (int.TryParse(Request.QueryString["RFID"], out value))
            {
                //edit
                btnSave.Text = "Update";
                lbldisplayText.Text = "Edit Resource for Researchers";
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
                            window.location.href = 'view-resource-for-researchers.aspx';   
                    }}); 
                    </script>");
                ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);
            }
        }
        else
        {
            lbldisplayText.Text = "Add Resource for Researchers";
            btnSave.Text = "Submit";
            //add
        }

        if (!IsPostBack)
        {
            Ddl.GetResourceResearchType(ddlresearch);
            ddlresearch.Items.Insert(0, new ListItem("", ""));
            if (hdnID.Value != null && !string.IsNullOrEmpty(hdnID.Value))
            {
                Bind(Convert.ToInt32(hdnID.Value));
            }
        }
    }


    public void Bind(int ID)
    {
        DataTable Dt = PMROR.ViewAllResearchRFRFilter("", "", Convert.ToString(ID));

        if (Dt.Rows.Count > 0)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["ResearchType"])))
            {
                ddlresearch.SelectedValue = Convert.ToString(Dt.Rows[0]["ResearchType"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["URL_AND_Notes"])))
            {
                txtlink.Text = Convert.ToString(Dt.Rows[0]["URL_AND_Notes"]);
            } 
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["TitleContent"])))
            {
                txttitle.Text = Convert.ToString(Dt.Rows[0]["TitleContent"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["CStatus"])))
            {
                toggleActiveInactive.Checked = Convert.ToBoolean(Dt.Rows[0]["CStatus"]);
            }

        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["RFID"] == null)
        {
            Clear();
            Response.Redirect(Request.Url.GetLeftPart(UriPartial.Path));
        }
        else
        {
            Response.Redirect("");
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string lblerror = string.Empty;
        if (string.IsNullOrEmpty(ddlresearch.SelectedValue) && string.IsNullOrEmpty(txtlink.Text))
        {
            lblerror = "Fill all the field";
        }
        else if (string.IsNullOrEmpty(ddlresearch.SelectedValue))
        {
            lblerror = "Select research type";
        }

        else if (string.IsNullOrEmpty(txtlink.Text))
        {
            lblerror = "Enter link";
        } 
        else if (string.IsNullOrEmpty(txttitle.Text))
        {
            lblerror = "Enter URL title";
        }

        if (string.IsNullOrEmpty(lblerror))
        {
            if (Request.QueryString["RFID"] == null)
            {
                int ret = 0;
                ret = AddData();
                if (ret == 1)
                {
                    Clear();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'Resource for researchers detatails added successfully.', " +
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
                           "  title: 'Resource for researchers detatails updated successfully.', " +
                           "  icon: 'success', " +
                           "  allowOutsideClick: 'true', " +
                           "  customClass: { " +
                           "    icon: 'handle-icon-clr', " +
                           "    confirmButton: 'handle-btn-success' " +
                           "  } " +
                           "}).then((result) => { " +
                           "  window.location.href = '" + "view-resource-for-researchers.aspx" + "'; " +
                           "});", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                                              "Swal.fire({ " +
                                              "  title: 'Resource for researchers detatails updated successfully., " +
                                              "  icon: 'success', " +
                                              "  allowOutsideClick: 'true', " +
                                              "  customClass: { " +
                                              "    icon: 'handle-icon-clr', " +
                                              "    confirmButton: 'handle-btn-success' " +
                                              "  } " +
                                              "}).then((result) => { " +
                                              "  window.location.href = '" + "view-resource-for-researchers.aspx" + "'; " +
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
            PMROR.strResearchType = ddlresearch.SelectedValue;
            PMROR.strURL_AND_Notes = txtlink.Text;
            PMROR.strTitleContent = txttitle.Text;
            PMROR.status = toggleActiveInactive.Checked;
            PMROR.strAddedBy = "Admin";
            rowaffected = PMROR.AddResearchForResearches(PMROR);
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
            PMROR.intRFID = Convert.ToInt32(hdnID.Value);
            PMROR.strResearchType = ddlresearch.SelectedValue;
            PMROR.strURL_AND_Notes = txtlink.Text;
            PMROR.strTitleContent = txttitle.Text;
            PMROR.status = toggleActiveInactive.Checked;
            PMROR.strUpdatedBy = "Admin";
            rowaffected = PMROR.UpdateResearchForResearches(PMROR);
        }
        catch (Exception ex)
        {
            //
        }

        return rowaffected;

    }

    public void Clear()
    {
        ddlresearch.SelectedIndex = 0;
        txtlink.Text = "";
        toggleActiveInactive.Checked = true;
    }
}