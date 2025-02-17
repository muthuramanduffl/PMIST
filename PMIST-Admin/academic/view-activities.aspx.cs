using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMIST_Admin_view_infrastructure : System.Web.UI.Page
{ 
    Bindddl Ddl = new Bindddl();
      pmistactivities PMA=new pmistactivities();
    CMSDepartment DE = new CMSDepartment();
    protected void Page_Load(object sender, EventArgs e)
    { 
        if (!IsPostBack)
        {
            Ddl.GetDepartmentddl(ddldepartment);
            ddldepartment.Items.Insert(0, new ListItem("All", ""));
            Bind();
        }
    }
 
    public void Bind()
    {
        try
        {
            //if (pageIndex == 0)
            //    pageIndex = 1; // Keep PageIndex correctly updated
            DataTable dt = Get(); // Fetch DataTable
            if (dt != null && dt.Rows.Count > 0)
            {
                //int totalRecords = dt.Rows.Count;
                //int pageSize = 10;
                //int startRow = (pageIndex - 1) * pageSize;

                rpruser.Visible = true;
                rpruser.DataSource = dt;
                lblcount.Text = Convert.ToString(dt.Rows.Count);
                rpruser.DataBind();

                //  PopulatePager(totalRecords, pageIndex, pageSize); // Pass correct pageIndex
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
 
    public string DepartmentName(int ID)
    {
        string Departmentname = string.Empty;
        try
        {
            DataTable dt = DE.ViewDepartmentByID(ID);
            if (dt != null && dt.Rows.Count > 0)
            {
                Departmentname = dt.Rows[0]["DepartmentName"].ToString();
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
            dt = PMA.ViewAllDepartmentActivities(ddldepartment.SelectedValue,"1","");
        }
        catch (Exception ex)
        {
        }
        return dt;
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            try
            {
                int ID = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("add-activities.aspx?ACTID=" + ID, false);
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
                ret = PMA.DelteActivities(ID);
                if (ret == 1)
                {
                    ScriptManager.RegisterStartupScript(
                    UpdatePanel5,
                    UpdatePanel5.GetType(),
                    "alert",
                    "Swal.fire({" +
                    "  title: 'Activity has been deleted', " +
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
                    "  title: 'Activity has been not deleted. please try again', " +
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
    protected void OnItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            (e.Item.FindControl("lblRowNumber") as Label).Text = (e.Item.ItemIndex + 1).ToString();
        }
    }

    protected void lnkcancel_Click(object sender, EventArgs e)
    {
        ddldepartment.SelectedIndex = 0;
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