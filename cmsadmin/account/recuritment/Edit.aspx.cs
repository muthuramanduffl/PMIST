using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Data;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
public partial class admin_account_Slider_AddSlider : System.Web.UI.Page
{
    recuritment recurit = new recuritment();
    pmuLogin login = new pmuLogin();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / Recuritment / <b>Edit</b>";
            recurit.Id = Convert.ToInt32(Request.QueryString["ID"]);
            if (!IsPostBack)
            {

                BindContent(recurit.Id);

            }
        }
        else
        {
            Response.Redirect("view.aspx");
        }

    }

    public void BindContent(int ID)
    {
        try
        {


            DataSet dsContent = recurit.ViewRecuritmentById(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                dvName.Attributes["class"] = "md-input-wrapper md-input-filled";
                dVEmailId.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvMobile.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvCompanyMobile.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvCompanyEmailId.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvCompanyName.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDesignation.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvJobDetails.Attributes["class"] = "md-input-wrapper md-input-filled";

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Name"])))
                {
                    txtName.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Name"]);

                }

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["EmailId"])))
                    txtEmailId.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["EmailId"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["MobileNo"])))
                    txtMobileNo.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["MobileNo"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["CompanyContactNo"])))
                    txtCompanyContactNo.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["CompanyContactNo"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["CompanyName"])))
                    txtCompanyName.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["CompanyName"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["CompanyEmailId"])))
                    txtCompanyEmailId.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["CompanyEmailId"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Designation"])))
                    txtDesignation.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Designation"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["JobDetails"])))
                    txtJobDetails.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["JobDetails"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["JDUrl"])))
                {
                    hiddenFile.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["JDUrl"]);
                    string filePath = System.Configuration.ConfigurationManager.AppSettings["Recurit"];
                    string url = "<a href = '" + filePath + @"/" + hiddenFile.Value.ToString().Trim() + "' target = '_blank'>View - " + hiddenFile.Value.ToString().Trim() + "</a>";
                    phType.Controls.Add(new LiteralControl(url));
                    dvoldImage.Style.Add("display", "block");
                }

                bool Publish = Convert.ToBoolean(dsContent.Tables[0].Rows[0]["Active"]);
                chkStatus.Checked = Publish;
                hdnStatus.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["Active"]);
                if (Publish)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
            }

        }

        catch (Exception ex)
        {
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] != null)
        {
            recurit.Id = Convert.ToInt32(Request.QueryString["ID"]);
            UpdateContent(recurit.Id);
            BindContent(recurit.Id);
            
        }
    }

    
  
   
    public void UpdateContent(int ID)
    {
        //try
        //{
            List<recuritment> lstContent = new List<recuritment> {
            new recuritment{
                Name=(!string.IsNullOrEmpty(txtName.Text.Trim()))?txtName.Text.Trim():string.Empty,
                EmailId=(!string.IsNullOrEmpty(txtEmailId.Text.Trim()))?txtEmailId.Text.Trim():string.Empty,
                MobileNo=(!string.IsNullOrEmpty(txtMobileNo.Text.Trim()))?txtMobileNo.Text.Trim():string.Empty,
                CompanyContactNo=(!string.IsNullOrEmpty(txtCompanyContactNo.Text.Trim()))?txtCompanyContactNo.Text.Trim():string.Empty,
                CompanyName=(!string.IsNullOrEmpty(txtCompanyName.Text.Trim()))?txtCompanyName.Text.Trim():string.Empty,
                CompanyEmailId=(!string.IsNullOrEmpty(txtCompanyEmailId.Text.Trim()))?txtCompanyEmailId.Text.Trim():string.Empty,
                Designation=(!string.IsNullOrEmpty(txtDesignation.Text.Trim()))?txtDesignation.Text.Trim():string.Empty,
                JobDetails=(!string.IsNullOrEmpty(txtJobDetails.Text.Trim()))?txtJobDetails.Text.Trim():string.Empty,
                JDUrl=hiddenFile.Value,
                Active=chkStatus.Checked,
                UpdatedDate=Utility.IndianTime,
                UpdatedBy="admin"

              }
        };
         int UpdateContent = recurit.UpdateRecuritment(lstContent,ID);
            if (UpdateContent == -1)
            {

                dvName.Attributes["class"] = "md-input-wrapper md-input-filled";
                dVEmailId.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvMobile.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvCompanyMobile.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvCompanyEmailId.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvCompanyName.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDesignation.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvJobDetails.Attributes["class"] = "md-input-wrapper md-input-filled";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Updated Successfully');</script>");
                if (chkStatus.Checked)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
            }
        //}
        //catch (Exception ex)
        //{
        //}
    }
   
   
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("view.aspx", true);
    }
   
}