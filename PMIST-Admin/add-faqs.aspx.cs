using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMIST_Admin_Default : System.Web.UI.Page
{
    Bindddl Ddl = new Bindddl();
    pmistfaq FAQ = new pmistfaq();
    protected void Page_Load(object sender, EventArgs e)
    {
    



        hdnID.Value = null;
        int value = 0;
        if (Request.QueryString["FAQID"] != null)
        {
            if (int.TryParse(Request.QueryString["FAQID"], out value))
            {
                //edit
                btnSave.Text = "Update";
                lbldisplayText.Text = "Edit FAQ's";
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
                            window.location.href = 'view-faqs.aspx';   
                    }}); 
                    </script>");
                ClientScript.RegisterStartupScript(this.GetType(), "alertAndRedirect", script, false);
            }
        }
        else
        {
            lbldisplayText.Text = "Add FAQ's";
            btnSave.Text = "Submit";
            //add
        }

        if (!IsPostBack)
        {
            Ddl.GetDepartmentddl(ddldepartment);
            ddldepartment.Items.Insert(0, new ListItem("", ""));
            if (hdnID.Value!=null && !string.IsNullOrEmpty(hdnID.Value))
            {
                Bind(Convert.ToInt32(hdnID.Value));
            }
        }
    }


    public void Bind(int ID)
    {
        DataTable Dt = FAQ.ViewAllFAQs("", "", Convert.ToString(ID));

        if (Dt.Rows.Count > 0)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Department"])))
            {
                ddldepartment.SelectedValue = Convert.ToString(Dt.Rows[0]["Department"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["QStatus"])))
            {
                toggleActiveInactive.Checked = Convert.ToBoolean(Dt.Rows[0]["QStatus"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Quetion"])))
            {
                txtquetion.InnerText = Convert.ToString(Dt.Rows[0]["Quetion"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(Dt.Rows[0]["Answer"])))
            {
                txtans.Text = Convert.ToString(Dt.Rows[0]["Answer"]);
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["FAQID"] == null)
        {
            Clear();
            Response.Redirect(Request.Url.GetLeftPart(UriPartial.Path));
        }
        else
        {
            Response.Redirect("view-faqs.aspx");
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string lblerror = string.Empty;
        if (string.IsNullOrEmpty(ddldepartment.SelectedValue) && string.IsNullOrEmpty(txtquetion.InnerText) && string.IsNullOrEmpty(txtans.Text))
        {
            lblerror = "Fill all the field";
        }
        else if (string.IsNullOrEmpty(ddldepartment.SelectedValue))
        {
            lblerror = "Select department";
        }
        else if (string.IsNullOrEmpty(txtquetion.InnerText))
        {
            lblerror = "Enter question";
        }
        else if (string.IsNullOrEmpty(txtans.Text))
        {
            lblerror = "Enter answer";
        }

        if (string.IsNullOrEmpty(lblerror))
        {
            if (Request.QueryString["FAQID"] == null)
            {
                int ret = 0;
                ret = AddData();
                if (ret == 1)
                {
                    Clear();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert",
                           "Swal.fire({ " +
                           "  title: 'FAQ\\'s details has been added successfully.', " +
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
                           "  title: 'FAQ\\'s details has been added successfully.', " +
                           "  icon: 'success', " +
                           "  allowOutsideClick: 'true', " +
                           "  customClass: { " +
                           "    icon: 'handle-icon-clr', " +
                           "    confirmButton: 'handle-btn-success' " +
                           "  } " +
                           "}).then((result) => { " +
                           "  window.location.href = '" + "view-faqs.aspx" + "'; " +
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
            FAQ.strDepartment = ddldepartment.SelectedValue;
            FAQ.boolQStatus = toggleActiveInactive.Checked;
            FAQ.strQuetion = txtquetion.InnerText;
            string encodedText = HttpUtility.HtmlEncode(txtans.Text);
            string decodedText = HttpUtility.HtmlDecode(encodedText);
            FAQ.strAnswer = decodedText;
            FAQ.strAddedBy = "admin";
            rowaffected = FAQ.AddFAQ(FAQ);
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
            FAQ.intFAQID = Convert.ToInt32(hdnID.Value);
            FAQ.strDepartment = ddldepartment.SelectedValue;
            FAQ.boolQStatus = toggleActiveInactive.Checked;
            FAQ.strQuetion = txtquetion.InnerText;
            string encodedText = HttpUtility.HtmlEncode(txtans.Text);
            string decodedText = HttpUtility.HtmlDecode(encodedText);
            FAQ.strAnswer = decodedText;
            FAQ.strUpdatedBy = "admin";
            rowaffected = FAQ.UpdateFAQ(FAQ);
        }
        catch (Exception ex)
        {
            //
        }

        return rowaffected;

    }

    public void Clear()
    {
        txtans.Text = "";
        ddldepartment.SelectedIndex = 0;
        txtquetion.InnerText = "";
        toggleActiveInactive.Checked = true;
    }
}