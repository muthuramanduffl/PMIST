using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
public partial class admin_account_naac_criteria : System.Web.UI.Page
{
    
    naacmetriciqac metric = new naacmetriciqac();
    pmuLogin login = new pmuLogin();
    //bvmLogin login = new bvmLogin();
    protected void Page_Load(object sender, EventArgs e)
    {

        lblDisplayText.Text = "Dashboard / Metric / <b>Add / Edit </b>";


        if (!IsPostBack)
        {
            BindMetric();
          
        }

    }
    protected void ddlFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindMetric();
    }
    protected void btnPublish_Click(object sender, EventArgs e)
    {
        string stErrorText = string.Empty;
        if (string.IsNullOrEmpty(txtMetricNo.Text))
        {
            stErrorText = "Please enter metric no";
        }
        if (string.IsNullOrEmpty(txtTitle.Text))
        {
            stErrorText = "Please enter title";
        }
        if (string.Equals(ddlCriteria.SelectedItem.Text, "Select Criteria"))
        {
            stErrorText = "Please select criteria";
        }
        if (string.IsNullOrEmpty(stErrorText))
        {
            InsertCriteria();
           
        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
    }

    public void BindMetric()
    {
        //try
        //{
        DataSet ds = new DataSet();
        string stFlter = ddlFilter.SelectedItem.Text.Trim();
        int CriteriaNo = 0;
        if (!string.Equals(stFlter, "All"))
        {
            CriteriaNo = Convert.ToInt32(ddlFilter.SelectedItem.Text.Trim());
            ds = metric.ViewMetricByCriteria(CriteriaNo);
        }
        else
            ds = metric.ViewAllMetric();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            lblcheck.Text = "";
            grvCriteria.Visible = true;
            grvCriteria.DataSource = ds;
            grvCriteria.DataBind();
        }
        else
        {
            lblcheck.Visible = true;
            grvCriteria.Visible = false;
            lblcheck.Text = "No Records Found";
        }
        //}

        //catch (Exception ex)
        //{
        //}
    }
    protected void Button_Click(object sender, EventArgs e)
    {
        //try
        //{
            LinkButton btnDelete = sender as LinkButton;
            GridViewRow row = (GridViewRow)btnDelete.NamingContainer;
            string[] args = btnDelete.CommandArgument.Split(',');
            int Id = Convert.ToInt16(args[0]);
            metric.DeleteMetricByID(Id);
        BindMetric();
        //}
        //catch (Exception ex)
        //{
        //}
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string stErrorText = string.Empty;
        if (string.IsNullOrEmpty(txtMetricNo.Text))
        {
            stErrorText = "Please enter metric no";
        }
        if (string.IsNullOrEmpty(txtTitle.Text))
        {
            stErrorText = "Please enter title";
        }
        if (string.Equals(ddlCriteria.SelectedItem.Text, "Select Criteria"))
        {
            stErrorText = "Please select criteria";
        }
        if (string.IsNullOrEmpty(stErrorText))
        {
            InsertCriteria();

        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
    }


    public void InsertCriteria()
    {
        try
        {
            
            bool blnStatus = false;
            if (chkStatus.Checked)
                blnStatus = true;
            int Criteria = 0;
            if (!string.Equals(ddlCriteria.SelectedItem.Text, "Select Criteria"))
                Criteria = Convert.ToInt32(ddlCriteria.SelectedItem.Text.Trim());

            List<naacmetriciqac> lstContent = new List<naacmetriciqac> {
            new naacmetriciqac{
                MetricName=(!string.IsNullOrEmpty(txtTitle.Text.Trim()))?txtTitle.Text.Trim():string.Empty,
                MetricNo=(!string.IsNullOrEmpty(txtMetricNo.Text.Trim()))?txtMetricNo.Text.Trim():string.Empty,
                Active=blnStatus,
                CriteriaNo=Criteria,
                AddedDateTime=Utility.IndianTime,
                AddedBy=login.GetUserName(),
                UpdatedDateTime=Utility.IndianTime,
                UpdatedBy=login.GetUserName()

              }
        };
           
            if (!IsMetricExistsForCrearte(Criteria,txtMetricNo.Text))
            {
                dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvMetricNo.Attributes["class"] = "md-input-wrapper md-input-filled";
                int Ins = metric.AddMetric(lstContent);
                if (Ins == -1)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Added Successfully');</script>");
                    txtTitle.Text = "";
                    txtMetricNo.Text = "";
                    ddlCriteria.SelectedIndex = 0;
                }
                

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('metric no alreday Exists');</script>");
            }

            BindMetric();

        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }
    }

    public bool IsMetricExistsForCrearte(int CriteriaNo,string stMetricNo)
    {
        bool IsExist = false;
        DataSet ds = metric.ViewMetricByMetricNo(CriteriaNo, stMetricNo);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            IsExist = true;
        return IsExist;

    }

   
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtTitle.Text = "";
        ddlCriteria.SelectedIndex = 0;
        txtMetricNo.Text = "";


    }
    
    
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindMetric();
        grvCriteria.PageIndex = e.NewPageIndex;
        grvCriteria.DataBind();

    }
    protected void Statusimg_click(object sender, EventArgs e)
    {
        //try
        //{
            ImageButton imgRead = sender as ImageButton;
            GridViewRow row = (GridViewRow)imgRead.NamingContainer;
            int Sno = int.Parse(imgRead.CommandArgument);
            string stUpdatedBy = "admin";
            DateTime dtUpdatedTime = Utility.IndianTime;
            metric.UpdateMetricStatus(Sno, stUpdatedBy, dtUpdatedTime);
        BindMetric();
        //}
        //catch (Exception ex)
        //{
        //}
    }
    protected void grvCriteria_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvCriteria.EditIndex = e.NewEditIndex;
        BindMetric();
    }
    protected void grvCriteria_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //try
        //{
            int Sno = Convert.ToInt32(grvCriteria.DataKeys[e.RowIndex].Value.ToString());
            TextBox txtMetricNo = (TextBox)grvCriteria.Rows[e.RowIndex].FindControl("txtEditMetricNo");
            HiddenField hiddenMetricNo = (HiddenField)grvCriteria.Rows[e.RowIndex].FindControl("hiddenMetricNo");
        TextBox txtTitle = (TextBox)grvCriteria.Rows[e.RowIndex].FindControl("txtEditTitle");
        HiddenField hiddenTitle = (HiddenField)grvCriteria.Rows[e.RowIndex].FindControl("hiddenTitle");
        HiddenField hiddenStatus = (HiddenField)grvCriteria.Rows[e.RowIndex].FindControl("hiddenStatus");
            DropDownList ddcriteria = (DropDownList)grvCriteria.Rows[e.RowIndex].FindControl("ddlUpdateCriteria");
        if (!string.IsNullOrEmpty(txtTitle.Text) &&!string.IsNullOrEmpty(txtMetricNo.Text))
        {

            string stUpdatedBy = login.GetUserName();
            bool blnStatus = Convert.ToBoolean(hiddenStatus.Value);
            int intcriteria = Convert.ToInt32(ddcriteria.SelectedItem.Text.Trim());
            if (!IsMetricExistForUpdate(intcriteria, txtMetricNo.Text, Sno))
            {

                metric.UpdateCriteria(txtTitle.Text.Trim(), txtMetricNo.Text.Trim(),intcriteria, stUpdatedBy, blnStatus, Utility.IndianTime, Sno);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
            }

            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('metric no alreday Exists');</script>");
            grvCriteria.EditIndex = -1;
            BindMetric();
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Mandatory fields should not be empty');</script>");

        }
        //}
        //catch (Exception ex)
        //{
        //}
    }
    public bool IsMetricExistForUpdate(int CriteriaNo, string stMetricNo, int Sno)
    {
        bool IsExist = false;
        DataSet ds = metric.ViewMetricByMetricNo(CriteriaNo, stMetricNo);
        if(ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
        {
            int CriteriaId = Convert.ToInt32(ds.Tables[0].Rows[0]["Sno"]);
            if (Sno != CriteriaId)
                IsExist = true;
        }
        return IsExist;

    }
   
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if ((e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                DropDownList ddList = (DropDownList)e.Row.FindControl("ddlUpdateCriteria");
                //bind dropdown-list
               
                DataRowView dr = e.Row.DataItem as DataRowView;
                //ddList.SelectedItem.Text = dr["category_name"].ToString();
                ddList.SelectedValue = dr["CriteriaId"].ToString();
            }
        }
    }

   
    public string bindImage(int imgId)
    {

        if (imgId == 1)
        {
            return "/cmsadmin/images/tick.png";
        }
        else
        {

            return "/cmsadmin/images/untick.png";
        }
    }
    protected void grvCriteria_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvCriteria.EditIndex = -1;
        BindMetric();
    }
   
    
    public string bindDate(DateTime dt)
    {

        return dt.ToShortDateString();
    }
    

}