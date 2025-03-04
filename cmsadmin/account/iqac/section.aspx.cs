using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
public partial class admin_account_iqac_section : System.Web.UI.Page
{
    iqacsection section = new iqacsection();
    pmuLogin login = new pmuLogin();
   
    protected void Page_Load(object sender, EventArgs e)
    {

        lblDisplayText.Text = "Dashboard / IQAC Section / <b>Add / Edit </b>";


        if (!IsPostBack)
        {
            BindSection();
          
        }

    }
    protected void ddlFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindSection();
    }
    protected void btnPublish_Click(object sender, EventArgs e)
    {
        string stErrorText = string.Empty;
        if (string.IsNullOrEmpty(txtTitle.Text))
        {
            stErrorText = "Please enter title";
        }
       
        if (string.Equals(ddlMainSection.SelectedItem.Text, "Select Criteria"))
        {
            stErrorText = "Please select section";
        }
        if (string.IsNullOrEmpty(stErrorText))
        {
            InsertSection();
            txtTitle.Text = "";
            ddlMainSection.SelectedIndex = 0;
            txtDisplayOrder.Text = "";

        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
    }

    public void BindSection()
    {
        try
        {
            DataSet ds = new DataSet();
        string stFlter = ddlFilter.SelectedItem.Text.Trim();
        string stSection = string.Empty;
        if (!string.Equals(stFlter, "All"))
        {
            stSection = Convert.ToString(ddlFilter.SelectedItem.Text.Trim());
            ds = section.ViewIqacSectionBySection(stSection);
        }
        else
            ds = section.ViewAllIqacSection();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            lblcheck.Text = "";
            grvSection.Visible = true;
            grvSection.DataSource = ds;
            grvSection.DataBind();
        }
        else
        {
            lblcheck.Visible = true;
            grvSection.Visible = false;
            lblcheck.Text = "No Records Found";
        }
        }

        catch (Exception ex)
        {
        }
    }
    protected void Button_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton btnDelete = sender as LinkButton;
            GridViewRow row = (GridViewRow)btnDelete.NamingContainer;
            string[] args = btnDelete.CommandArgument.Split(',');
            int Id = Convert.ToInt16(args[0]);
            int DisplayOrder = Convert.ToInt32(args[1]);
            string stSection = Convert.ToString(args[2]);
            section.DeleteIqacSection(Id);
            UpdateDisplayOrder(DisplayOrder, stSection);
            BindSection();
        }
        catch (Exception ex)
        {
        }
    }
    public void UpdateDisplayOrder(int displayOrder, string stSection)
    {
        int toDisplayOrder = GetMaxDisplayOrder(stSection);
        DataSet ds = section.GetIqacSectionDisplayOrderForDelete(displayOrder, toDisplayOrder, stSection);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            int oldDisplayOrder = 0;
            int NewDisplayOrder = 0;
            int SliderId = 0;
            string updatedBy = login.GetUserName();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                SliderId = Convert.ToInt32(ds.Tables[0].Rows[i]["Sno"]);
                NewDisplayOrder = oldDisplayOrder - 1;
                section.UpdateIqacSectionDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

            }

        }
    }
    
    public int GetMaxDisplayOrder(string stSection)
    {
        int DisplayOrder = 0;
        DataSet ds = section.ViewMaxIqacSection(stSection);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stDisplayOrder = Convert.ToString(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
            if (!string.IsNullOrEmpty(stDisplayOrder))
                DisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
        }
        return DisplayOrder;
    }
    public int SetDisplayOrder(string stSection)
    {
        int DisplayOrder = 0;
        DisplayOrder = GetMaxDisplayOrder(stSection) + 1;
        return DisplayOrder;
    }
    public int DisplayOrderForInsert(string stSection)
    {
        int DisplayOrder = 0;
        int addedDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
        int toDisplayOrder = GetMaxDisplayOrder(stSection);
        if (IsDisplayOrderExists(addedDisplayOrder, stSection))
        {
            DataSet ds = section.GetIqacSectionDisplayOrderForInsert(addedDisplayOrder, toDisplayOrder, stSection);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int oldDisplayOrder = 0;
                int NewDisplayOrder = 0;
                int SliderId = 0;
                string updatedBy = login.GetUserName();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                    SliderId = Convert.ToInt32(ds.Tables[0].Rows[i]["Sno"]);
                    NewDisplayOrder = oldDisplayOrder + 1;
                    section.UpdateIqacSectionDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
                DisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
            }

        }
        else
            DisplayOrder = SetDisplayOrder(stSection);
        return DisplayOrder;
    }
    public bool IsDisplayOrderExists(int DisplayOrder, string stSection)
    {
        bool displayOrderExists = false;
        DataSet ds = section.IsIqacSectionDisplayOrderExists(DisplayOrder, stSection);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            displayOrderExists = true;
        return displayOrderExists;


    }
    public int DisplayOrderForUpdate(string stSection,int TodisplayOrder,int FromdisplayOrder)
    {
        int DisplayOrder = 0;
        int MaxDisplayOrder = GetMaxDisplayOrder(stSection);
        int toDisplayOrder = TodisplayOrder;// Convert.ToInt32(txtDisplayOrder.Text.Trim());
        int fromDisplayOrder = FromdisplayOrder;// Convert.ToInt32(hdnDisplayOrder.Value.ToString());
        if (IsDisplayOrderExists(toDisplayOrder, stSection))
        {
            DisplayOrder = toDisplayOrder;

        }
        else
            DisplayOrder = GetMaxDisplayOrder(stSection);

        DataSet ds = new DataSet();
        if (fromDisplayOrder < toDisplayOrder)
        {
            ds = section.GetIqacSectionDisplayOrderWay1(fromDisplayOrder, toDisplayOrder, stSection);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int oldDisplayOrder = 0;
                int NewDisplayOrder = 0;
                int SliderId = 0;
                string updatedBy = login.GetUserName();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                    SliderId = Convert.ToInt32(ds.Tables[0].Rows[i]["Sno"]);
                    NewDisplayOrder = oldDisplayOrder - 1;
                    section.UpdateIqacSectionDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
            }
        }
        else
        {
            ds = section.GetIqacSectionDisplayOrderWay2(fromDisplayOrder, toDisplayOrder, stSection);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int oldDisplayOrder = 0;
                int NewDisplayOrder = 0;
                int SliderId = 0;
                string updatedBy = login.GetUserName();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                    SliderId = Convert.ToInt32(ds.Tables[0].Rows[i]["Sno"]);
                    NewDisplayOrder = oldDisplayOrder + 1;
                    section.UpdateIqacSectionDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
            }
        }

        return DisplayOrder;
    }
    public void InsertSection()
    {
        try
        {

            bool blStatus = false;
            if (chkStatus.Checked)
                blStatus = true;

            string stSection = string.Empty;
            if (!string.Equals(ddlMainSection.SelectedItem.Text, "Select Section"))
                stSection = Convert.ToString(ddlMainSection.SelectedItem.Text);
           
            if (!IsTitleExistsForCreate(stSection, txtTitle.Text.Trim()))
            {
                int itDisplayOrder = DisplayOrderForInsert(stSection);
                List<iqacsection> lstContent = new List<iqacsection> {
            new iqacsection{
                Section=stSection,
                SubSection=(!string.IsNullOrEmpty(txtTitle.Text.Trim()))?txtTitle.Text.Trim():string.Empty,
                DisplayOrder=Convert.ToInt32(itDisplayOrder),
                Active=blStatus,
                AddedDateTime=Utility.IndianTime,
                AddedBy=login.GetUserName(),
                UpdatedDateTime=Utility.IndianTime,
                UpdatedBy="NONE"

              }
        };
                int InsContent = section.AddAddIqacSection(lstContent);
                if (InsContent == -1)
                {

                    dvMainSection.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Added Successfully');</script>");
                   
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Title alreday Exists');</script>");
            }
            BindSection();
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }

    }

    public bool IsTitleExistsForCreate(string Section,string stTitle)
    {
        bool IsExist = false;
        DataSet ds = section.ViewIqacSectionByTitle(Section, stTitle);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            IsExist = true;
        return IsExist;

    }

   
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtTitle.Text = "";
        ddlMainSection.SelectedIndex = 0;
        txtDisplayOrder.Text = "";
    }
    
    
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindSection();
        grvSection.PageIndex = e.NewPageIndex;
        grvSection.DataBind();

    }
    protected void Statusimg_click(object sender, EventArgs e)
    {
        try
        {
            ImageButton imgRead = sender as ImageButton;
            GridViewRow row = (GridViewRow)imgRead.NamingContainer;
            int Sno = int.Parse(imgRead.CommandArgument);
            string stUpdatedBy = "admin";
            DateTime dtUpdatedTime = Utility.IndianTime;
            section.UpdateIqacSectionStatus(Sno, stUpdatedBy, dtUpdatedTime);
            BindSection();
        }
        catch (Exception ex)
        {
        }
    }
    protected void grvSection_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvSection.EditIndex = e.NewEditIndex;
        BindSection();
    }
    protected void grvSection_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //try
        //{
            int Sno = Convert.ToInt32(grvSection.DataKeys[e.RowIndex].Value.ToString());
            TextBox txtTitle = (TextBox)grvSection.Rows[e.RowIndex].FindControl("txtEditTitle");
            HiddenField hiddenTitle = (HiddenField)grvSection.Rows[e.RowIndex].FindControl("hiddenTitle");

            TextBox txtDisplayOrder = (TextBox)grvSection.Rows[e.RowIndex].FindControl("txtEditDisplayOrder");
            HiddenField hiddenDisplayOrder = (HiddenField)grvSection.Rows[e.RowIndex].FindControl("hiddenDisplayOrder");

            HiddenField hiddenStatus = (HiddenField)grvSection.Rows[e.RowIndex].FindControl("hiddenStatus");
           Label lblSection = (Label)grvSection.Rows[e.RowIndex].FindControl("lblEditSection");
        //DropDownList ddSection = (DropDownList)grvSection.Rows[e.RowIndex].FindControl("ddlUpdateSection");
        if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtDisplayOrder.Text))
            {

                string stUpdatedBy = login.GetUserName();
                bool blnStatus = Convert.ToBoolean(hiddenStatus.Value);
                string stSection = lblSection.Text;
                int itDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
                int oldDisplayOrder = Convert.ToInt32(hiddenDisplayOrder.Value);
               
                if (!IsTitleExistForUpdate(stSection, txtTitle.Text, Sno))
                {
                    if (!string.Equals(itDisplayOrder, oldDisplayOrder))
                        itDisplayOrder = DisplayOrderForUpdate(stSection, itDisplayOrder, oldDisplayOrder);
                    List<iqacsection> lstContent = new List<iqacsection> {
            new iqacsection{
                Section=stSection,
                SubSection=(!string.IsNullOrEmpty(txtTitle.Text.Trim()))?txtTitle.Text.Trim():string.Empty,
                DisplayOrder=Convert.ToInt32(itDisplayOrder),
                Active=blnStatus,
                UpdatedDateTime=Utility.IndianTime,
                UpdatedBy=stUpdatedBy

              }
        };
                    section.UpdateSection(lstContent, Sno);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
                }

                else
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Title alreday Exists');</script>");
                grvSection.EditIndex = -1;
                BindSection();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Mandatory fields should not be empty');</script>");

            }
       // }
        //catch (Exception ex)
        //{
        //}
    }
    public bool IsTitleExistForUpdate(string stSection, string stTitle, int Sno)
    {
        bool IsExist = false;
        DataSet ds = section.ViewIqacSectionByTitle(stSection, stTitle);
        if(ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
        {
            int ISno = Convert.ToInt32(ds.Tables[0].Rows[0]["Sno"]);
            if (Sno != ISno)
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
                DropDownList ddList = (DropDownList)e.Row.FindControl("ddlUpdateSection");
                //bind dropdown-list
               
                DataRowView dr = e.Row.DataItem as DataRowView;
                //ddList.SelectedItem.Text = dr["category_name"].ToString();
                ddList.SelectedValue = dr["Section"].ToString();
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
    protected void grvSection_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvSection.EditIndex = -1;
        BindSection();
    }
    protected void ddlMainSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.Equals(ddlMainSection.SelectedItem.Text, "Select Section"))
        {
            string stSection = ddlMainSection.SelectedItem.Text;
            txtDisplayOrder.Text = SetDisplayOrder(stSection).ToString();
        }
        else
        {
            txtDisplayOrder.Text = "";
        }
    }

  public string bindDate(DateTime dt)
    {

        return dt.ToShortDateString();
    }
    

}