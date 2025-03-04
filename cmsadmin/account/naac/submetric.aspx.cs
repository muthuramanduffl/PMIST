using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
public partial class admin_account_naac_submetric : System.Web.UI.Page
{
    naacsubmetric submetric = new naacsubmetric();
    naacmetric metric1 = new naacmetric();
    pmuLogin login = new pmuLogin();
    //bvmLogin login = new bvmLogin();
    protected void Page_Load(object sender, EventArgs e)
    {

        lblDisplayText.Text = "Dashboard / Sub Metric / <b>Add / Edit </b>";


        if (!IsPostBack)
        {
            BindSubMetric();
          
        }

    }
    public void ddlCriteria_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Critera = 0;
        if(!string.Equals(ddlCriteria.SelectedItem.Text, "Select Criteria"))
        {
            Critera = Convert.ToInt32(ddlCriteria.SelectedItem.Text);
            BindMetric(Critera);
        }
       
    }
    public void BindMetric(int CriteriaId)
    {
        DataSet ds = metric1.ViewActiveMetric(CriteriaId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            ddlMetricNo.Items.Clear();
            ddlMetricNo.Items.Add(new ListItem("Select Metric", "Select Metric"));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string stText = Convert.ToString(ds.Tables[0].Rows[i]["MetricNo"]);
                string stValue = Convert.ToString(ds.Tables[0].Rows[i]["Sno"]);
                ddlMetricNo.Items.Add(new ListItem(stText, stValue));
            }
            ddlMetricNo.DataBind();
            
        }
        else
        {
            ddlMetricNo.Items.Clear();
           
            ddlMetricNo.Items.Add(new ListItem("Select Metric", "Select Metric"));
          
        }
    }
    public void BindilterMetric(int CriteriaId)
    {
        DataSet ds = metric1.ViewActiveMetric(CriteriaId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
           
            ddlFilterMetric.Items.Clear();
            ddlFilterMetric.Items.Add(new ListItem("All", "All"));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string stText = Convert.ToString(ds.Tables[0].Rows[i]["MetricNo"]);
                string stValue = Convert.ToString(ds.Tables[0].Rows[i]["Sno"]);
                ddlFilterMetric.Items.Add(new ListItem(stText, stValue));
            }
            ddlFilterMetric.DataBind();
        }
        else
        {
           
            ddlFilterMetric.Items.Clear();
          
            ddlFilterMetric.Items.Add(new ListItem("All", "All"));
        }
    }
    protected void ddlFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        int Criteria = 0;
        if(!string.Equals(ddlFilter.SelectedItem.Text, "All"))
        {
            Criteria = Convert.ToInt32(ddlFilter.SelectedItem.Text);
            BindilterMetric(Criteria);
            
        }
        BindSubMetric();

    }
    protected void ddlMetric_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindSubMetric();
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
        if (string.Equals(ddlMetricNo.SelectedItem.Text, "Select Mertic"))
        {
            stErrorText = "Please select metric no";
        }
        if (string.IsNullOrEmpty(stErrorText))
        {
            InsertCriteria();
           
        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
    }

    public void BindSubMetric()
    {
        //try
        //{
        DataSet ds = new DataSet();
        string stFlter = ddlFilter.SelectedItem.Text.Trim();
       
        int CriteriaNo = 0;
        int MetricId = 0;
        if (!string.Equals(stFlter, "All"))
        {
            CriteriaNo = Convert.ToInt32(ddlFilter.SelectedItem.Text.Trim());
            string stMetricFlter = ddlFilterMetric.SelectedItem.Text.Trim();
            if (!string.Equals(stMetricFlter, "All"))
                MetricId = Convert.ToInt32(ddlFilterMetric.SelectedValue);
            ds = submetric.ViewSubMetricByMetric(CriteriaNo, MetricId);
        }
        else
            ds = submetric.ViewAllSubMetric();
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
        submetric.DeleteMetricByID(Id);
        BindSubMetric();
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
        if (string.Equals(ddlMetricNo.SelectedItem.Text, "Select Mertic"))
        {
            stErrorText = "Please select metric no";
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
            int IMetricId = 0;
            if (!string.Equals(ddlMetricNo.SelectedItem.Text, "Select Metric"))
                IMetricId = Convert.ToInt32(ddlMetricNo.SelectedValue);
            List<naacsubmetric> lstContent = new List<naacsubmetric> {
            new naacsubmetric{
                MetricId=IMetricId,
                SubMetricName=(!string.IsNullOrEmpty(txtTitle.Text.Trim()))?txtTitle.Text.Trim():string.Empty,
                SubMetricNo=(!string.IsNullOrEmpty(txtMetricNo.Text.Trim()))?txtMetricNo.Text.Trim():string.Empty,
                Active=blnStatus,
                CriteriaNo=Criteria,
                AddedDateTime=Utility.IndianTime,
                AddedBy=login.GetUserName(),
                UpdatedDateTime=Utility.IndianTime,
                UpdatedBy=login.GetUserName()

              }
        };
           
            if (!IsSubMetricExistsForCrearte(Criteria, IMetricId,txtMetricNo.Text))
            {
                dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvMetricNo.Attributes["class"] = "md-input-wrapper md-input-filled";
                int Ins = submetric.AddSubMetric(lstContent);
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

            BindSubMetric();

        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }
    }

    public bool IsSubMetricExistsForCrearte(int CriteriaNo,int MetricId, string stMetricNo)
    {
        bool IsExist = false;
        DataSet ds = submetric.ViewSubMetricBySubMetricNo(CriteriaNo, MetricId, stMetricNo);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            IsExist = true;
        return IsExist;

    }

   
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtTitle.Text = "";
        ddlCriteria.SelectedIndex = 0;
        ddlMetricNo.SelectedIndex = 0;
        txtMetricNo.Text = "";


    }
    
    
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindSubMetric();
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
            submetric.UpdateSubMetricStatus(Sno, stUpdatedBy, dtUpdatedTime);
        BindSubMetric();
        //}
        //catch (Exception ex)
        //{
        //}
    }
    protected void grvCriteria_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvCriteria.EditIndex = e.NewEditIndex;
        BindSubMetric();
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
        DropDownList ddMetricNo = (DropDownList)grvCriteria.Rows[e.RowIndex].FindControl("ddlUpdateMetricNo");
        if (!string.IsNullOrEmpty(txtTitle.Text) &&!string.IsNullOrEmpty(txtMetricNo.Text))
        {

            string stUpdatedBy = login.GetUserName();
            bool blnStatus = Convert.ToBoolean(hiddenStatus.Value);
            int intcriteria = Convert.ToInt32(ddcriteria.SelectedItem.Text.Trim());
            int intmetricno = Convert.ToInt32(ddMetricNo.SelectedValue);
            if (!IsSubMetricExistForUpdate(intcriteria, intmetricno, txtMetricNo.Text, Sno))
            {

                submetric.UpdateSubMetric(txtTitle.Text.Trim(), txtMetricNo.Text.Trim(),intcriteria, intmetricno,stUpdatedBy, blnStatus, Utility.IndianTime, Sno);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
            }

            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('metric no alreday Exists');</script>");
            grvCriteria.EditIndex = -1;
            BindSubMetric();
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
    public bool IsSubMetricExistForUpdate(int CriteriaNo, int MetricId, string stMetricNo, int Sno)
    {
        bool IsExist = false;
        DataSet ds = submetric.ViewSubMetricBySubMetricNo(CriteriaNo, MetricId, stMetricNo);
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
                DropDownList ddMetricNo = (DropDownList)e.Row.FindControl("ddlUpdateMetricNo");
                DataRowView dr = e.Row.DataItem as DataRowView;
                int intcriteria = Convert.ToInt32(dr["CriteriaId"].ToString());
                //bind dropdown-list
                DataSet ds = metric1.ViewActiveMetric(intcriteria);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string stText = Convert.ToString(ds.Tables[0].Rows[i]["MetricNo"]);
                        string stValue = Convert.ToString(ds.Tables[0].Rows[i]["Sno"]);
                        ddMetricNo.Items.Add(new ListItem(stText, stValue));
                    }
                    ddMetricNo.DataBind();
                }
                
                //ddList.SelectedItem.Text = dr["category_name"].ToString();
                ddList.SelectedValue = dr["CriteriaId"].ToString();
                ddMetricNo.SelectedValue = dr["MetricId"].ToString();
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
        BindSubMetric();
    }
   
    
    public string bindDate(DateTime dt)
    {

        return dt.ToShortDateString();
    }
    

}