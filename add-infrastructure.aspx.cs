using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMIST_Admin_addinfrastructure : System.Web.UI.Page
{
    Bindddl Ddl = new Bindddl();

    pmistinfrastruncture PINF = new pmistinfrastruncture();
    protected void Page_Load(object sender, EventArgs e)
    {
        hdnID.Value = null;
        int value = 0;
        if (Request.QueryString["INFID"] != null)
        {
            if (int.TryParse(Request.QueryString["INFID"], out value))
            {
                //edit
                btnSave.Text = "Update";
                lbldisplayText.Text = "Edit Infrastructure";
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
                            window.location.href = 'view-infrastructure.aspx';   
                    }}); 
                    </script>");
                ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);
            }
        }
        else
        {
            lbldisplayText.Text = "Add Infrastructure";
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
        DataTable Dt = PINF.ViewAllInfrastructure("", "", Convert.ToString(ID));

        if (Dt.Rows.Count > 0)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Department"])))
            {
                ddldepartment.SelectedValue = Convert.ToString(Dt.Rows[0]["Department"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["INFRStatus"])))
            {
                toggleActiveInactive.Checked = Convert.ToBoolean(Dt.Rows[0]["INFRStatus"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Content"])))
            {
                txtcontent.Text = Convert.ToString(Dt.Rows[0]["Content"]);
            }

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["INFID"] == null)
        {
            Clear();
            Response.Redirect(Request.Url.GetLeftPart(UriPartial.Path));
        }
        else
        {
            Response.Redirect("view-infrastructure.aspx");
        }
    }
    
    public void Clear()
    {
        ddldepartment.SelectedIndex = 0;
        txtcontent.Text = "";
        toggleActiveInactive.Checked = true;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string strlabelerror = string.Empty;

        if (string.IsNullOrEmpty(ddldepartment.SelectedValue) && string.IsNullOrEmpty(txtcontent.Text))
        {
            strlabelerror = "Fill all the field";
        }
        else if (string.IsNullOrEmpty(ddldepartment.SelectedValue))
        {
            strlabelerror = "Select department";
        }
        else if (string.IsNullOrEmpty(txtcontent.Text))
        {
            strlabelerror = "Enter content";
        }

        if (string.IsNullOrEmpty(strlabelerror))
        {
            if (Request.QueryString["INFID"] == null)
            {
                int ret = 0;
                ret = AddData();
                if (ret == 1)
                {
                    Clear();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'Infrastructure details has been added successfully', " +
                           "  icon: 'success', " +
                           "  allowOutsideClick: 'true', " +
                           "  customClass: { " +
                           "    icon: 'handle-icon-clr', " +
                           "    confirmButton: 'handle-btn-success' " +
                           "  } " +
                           "}).then((result) => { " + 
                           "});", true);
                }
            }
            else
            {
                int ret = 0;
                ret = UpdateData();
                if (ret == 1)
                {
                    Clear();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'Infrastructure details has been updated successfully', " +
                           "  icon: 'success', " +
                           "  allowOutsideClick: 'true', " +
                           "  customClass: { " +
                           "    icon: 'handle-icon-clr', " +
                           "    confirmButton: 'handle-btn-success' " +
                           "  } " +
                           "}).then((result) => { " +
                           "  window.location.href = '" + "view-infrastructure.aspx" + "'; " +
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
            PINF.strDepartment = ddldepartment.SelectedValue;
            PINF.strContent = txtcontent.Text;
            PINF.boolInfrstatus = toggleActiveInactive.Checked;
            PINF.strAddedBy = "Admin";
            rowaffected = PINF.Addinfrastruncture(PINF);
        }
        catch (Exception ex)
        { 
        }
        return rowaffected;
    }

    public int UpdateData()
    {
        int rowaffected = 0;
        try
        {
            PINF.intInfrID =Convert.ToInt32(hdnID.Value);  
            PINF.strDepartment = ddldepartment.SelectedValue;
            PINF.strContent = txtcontent.Text;
            PINF.boolInfrstatus = toggleActiveInactive.Checked;
            PINF.strUpdatedBy = "Admin";
            rowaffected = PINF.Updateinfrastruncture(PINF);
        }
        catch (Exception ex)
        {

        }
        return rowaffected;
    }
}