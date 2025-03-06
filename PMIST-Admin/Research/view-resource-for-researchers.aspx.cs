using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMIST_Admin_view_placements : System.Web.UI.Page
{ 
    Bindddl Ddl = new Bindddl();
    pmistresourceofresources PMROR = new pmistresourceofresources();
    CMSDepartment DE = new CMSDepartment();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Ddl.GetResourceResearchType(ddlresearch);
            ddlresearch.Items.Insert(0, new ListItem("All", ""));
            Bind();
        }
    } 

    public void Bind()
    {
        try
        {
            DataTable dt = Get();
            if (dt != null && dt.Rows.Count > 0)
            {
                rpruser.Visible = true;
                rpruser.DataSource = dt;
                lblcount.Text = Convert.ToString(dt.Rows.Count);
                rpruser.DataBind();
                DivNoDataFound.Style.Add("display", "none");
                h5TotalNoCount.Style.Add("display", "block");
            }
            else
            {
                Session["Projects"] = null;
                rpruser.Visible = false;
                lblcount.Text = "0";
                DivNoDataFound.Style.Add("display", "block");
                h5TotalNoCount.Style.Add("display", "none");
            }
        }
        catch (Exception ex)
        {
        }
    } 

    public string ResourcetypeName(int ID)
    {
        string Departmentname = string.Empty;
        try
        {
            DataTable dt = PMROR.viewAllResourceResearchTypeNameByID(ID);
            if (dt != null && dt.Rows.Count > 0)
            {
                Departmentname = dt.Rows[0]["ResearchTypeName"].ToString();
            }
        }
        catch (Exception ex)
        {

        } 
        return Departmentname;
    }
 
    public DataTable Get()
    {
        DataTable dt = new DataTable();
        try
        {
            dt = PMROR.ViewAllResearchRFRFilter(ddlresearch.SelectedValue, ddlstatus.SelectedValue, "");
        }
        catch (Exception ex)
        {
        }
        return dt;
    } 

    protected void OnItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            (e.Item.FindControl("lblRowNumber") as Label).Text = (e.Item.ItemIndex + 1).ToString();
        }
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            try
            {
                int ID = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("add-resource-for-researchers.aspx?RFID=" + ID, false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ex)
            {
            }
        }
        else if (e.CommandName == "Delete")
        {
            int ret = 0;
            try
            { 
                int ID = Convert.ToInt32(e.CommandArgument);
                ret = PMROR.DeleteResearchRFR(ID);
                if (ret == 1)
                {
                    ScriptManager.RegisterStartupScript(
                    UpdatePanel5,
                    UpdatePanel5.GetType(),
                    "alert",
                    "Swal.fire({" +
                    "  title: 'Resource for researchers details has been deleted', " +
                    "  confirmButtonText: 'OK', " + // Add the missing comma here
                    "  customClass: {" +
                    "    confirmButton: 'handle-btn-success'" +
                    "  }" +
                    "}).then((result) => { " +
                    "   window.location.href = '" + Request.Url.AbsolutePath + "'; " +
                    "});",
                    true);

                }
                else
                {
                    ScriptManager.RegisterStartupScript(UpdatePanel5, UpdatePanel5.GetType(),
                    "alert",
                    "Swal.fire({" +
                    "  title: 'Resource for researchers details has been not deleted. please try again', " +
                    "  confirmButtonText: 'OK', " + // Add the missing comma here
                    "  customClass: {" +
                    "    confirmButton: 'handle-btn-success'" +
                    "  }" +
                    "}).then((result) => { " +
                    "   window.location.href = '" + Request.Url.AbsolutePath + "'; " +
                    "});",
                    true);

                }
            }
            catch (Exception ex)
            {
            }
            UpdatePanel5.Update();
        }
    }

    protected void lnkcancel_Click(object sender, EventArgs e)
    {
        ddlresearch.SelectedIndex = 0;
        ddlstatus.SelectedIndex = 0;
        Bind();
        UpdatePanel3.Update();
    }


    protected void ddlstatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        Bind();
    }

    protected void ddldepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        Bind();
    }
}