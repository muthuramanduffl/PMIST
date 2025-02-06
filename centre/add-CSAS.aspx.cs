
using System;
using System.Data;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Linq;

public partial class PMIST_Admin_Mcentre_CSAS : System.Web.UI.Page
{
    Bindddl Ddl = new Bindddl();
    //pmistCSAS CSAS = new pmistCSAS();
    protected void Page_Load(object sender, EventArgs e)
    {
        hdnID.Value = null;
        int value = 0;
        if (Request.QueryString["CSASID"] != null)
        {
            if (int.TryParse(Request.QueryString["CSASID"], out value))
            {
                //edit
                btnSave.Text = "Update";
                lbldisplayText.Text = "Edit Centre For Students and Administrative Services";
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
                            window.location.href = 'view-CSAS.aspx';   
                    }}); 
                    </script>");
                ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);
            }
        }
        else
        {
            lbldisplayText.Text = "Add Centre For Students and Administrative Services";
            btnSave.Text = "Submit";
            //add
        }

         
    }

    public void Bind(int ID)
    {
        DataTable Dt = new DataTable();

        if (Dt.Rows.Count > 0)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtTitle.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                toggleActiveInactive.Checked = Convert.ToBoolean(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtContent.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC1Name.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC1Designation.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC1MobileNo.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC1Emailid.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC2Name.Text = Convert.ToString(Dt.Rows[0][""]);
            } 
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC2Designation.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC2MobileNo.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC2Emailid.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC3Name.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC3Designation.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC3MobileNo.Text = Convert.ToString(Dt.Rows[0][""]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0][""])))
            {
                txtC3Emailid.Text = Convert.ToString(Dt.Rows[0][""]);
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["CSASID"] == null)
        {
            Clear();
            Response.Redirect(Request.Url.GetLeftPart(UriPartial.Path));
        }
        else
        {
            Response.Redirect("view-CSAS.aspx");
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string lblerror = string.Empty;
        if (string.IsNullOrEmpty(txtTitle.Text) && string.IsNullOrEmpty(txtContent.Text))
        {
            lblerror = "Fill all the field";
        }
        else if (string.IsNullOrEmpty(txtTitle.Text))
        {
            lblerror = "Select title";
        } 
        else if (string.IsNullOrEmpty(txtContent.Text))
        {
            lblerror = "Enter content";
        }

        if (string.IsNullOrEmpty(lblerror))
        {
            if (Request.QueryString["CSASID"] == null)
            {
                int ret = 0;
                ret = AddData();
                if (ret == 1)
                {
                    Clear();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'CSAS details has been added successfully', " +
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
                ret = Updatedata();
                if (ret == 1)
                {
                    Clear();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'CSAS details has been updated successfully', " +
                           "  icon: 'success', " +
                           "  allowOutsideClick: 'true', " +
                           "  customClass: { " +
                           "    icon: 'handle-icon-clr', " +
                           "    confirmButton: 'handle-btn-success' " +
                           "  } " +
                           "}).then((result) => { " +
                           "  window.location.href = '" + "view-CSAS.aspx" + "'; " +
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
        }
        catch (Exception ex)
        {
            //
        }

        return rowaffected;
    }

    public void Clear()
    {
        Response.Redirect(Request.Url.AbsolutePath);
    }
}