using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Data;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
public partial class admin_account_iqac_Add : System.Web.UI.Page
{
    iqacsection section = new iqacsection();
    iqaccontent content = new iqaccontent();
    pmuLogin login = new pmuLogin();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / Iqac / <b>Edit</b>";
            content.Id = Convert.ToInt32(Request.QueryString["ID"]);
            if (!IsPostBack)
            {
                
                BindContent(content.Id);
                RequiredFieldValidator5.Enabled = false;
            }
        }
        else
        {
            if (!IsPostBack)
            {
               
                
            }
            lblDisplayText.Text = "Dashboard / Iqac / <b>Add</b>";
        }

    }
    public bool IsDisplayOrderChangeForUpdate()
    {
        bool Ischanged = false;
        string oldDisplayOrder = hdnDisplayOrder.Value.Trim().ToString();
        string NewDisplayOrder = txtDisplayOrder.Text.Trim();
        if (!string.Equals(oldDisplayOrder, NewDisplayOrder))
            Ischanged = true;
        return Ischanged;
    }
    public void BindContent(int ID)
    {
        try
        {
            
            
            DataSet dsContent = content.ViewIqacContentById(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Section"])))
                {
                    string stSection = Convert.ToString(dsContent.Tables[0].Rows[0]["Section"]);
                    ddlMainSection.Items.FindByText(ddlMainSection.SelectedItem.Text).Selected = false;
                    ddlMainSection.Items.FindByText(stSection).Selected = true;
                    BindSubSection(stSection);
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["SubSectionId"])))
                {
                    int stSubSectionId = Convert.ToInt32(dsContent.Tables[0].Rows[0]["SubSectionId"]);
                    ddlSubSection.Items.FindByValue(ddlSubSection.SelectedValue).Selected = false;
                    ddlSubSection.Items.FindByValue(Convert.ToString(stSubSectionId)).Selected = true;
                    
                }
                
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"])))
                {
                    txtDisplayOrder.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"]);
                    hdnDisplayOrder.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"]);
                }
              
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["PdfName"])))
                {
                    txtTitle.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["PdfName"]);
                   
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["PdfUrl"])))
                {
                    string stSection = Convert.ToString(dsContent.Tables[0].Rows[0]["Section"]);
                    hiddenFile.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["PdfUrl"]);
                    string filePath = System.Configuration.ConfigurationManager.AppSettings["IQACpdf"];
                    string url = txtTitle.Text+ " -  "+ "<a href = '" + filePath + stSection + @"/" + hiddenFile.Value.ToString().Trim() + "' target = '_blank'>View PDF</a>";
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
    public string Getpdfpath(string stSection)
    {
        string stUrl = string.Empty;
        if (string.Equals(stSection, "Meeting", StringComparison.OrdinalIgnoreCase))
            stUrl = "meeting";
        else if (string.Equals(stSection, "Nirf", StringComparison.OrdinalIgnoreCase))
            stUrl = "nirf";
        else if(string.Equals(stSection, "Aqar", StringComparison.OrdinalIgnoreCase))
            stUrl = "aqar";
        else if(string.Equals(stSection, "Pmist Annual Report", StringComparison.OrdinalIgnoreCase))
            stUrl = "report";
        return stUrl;
    }
    public void BindSubSection(string stSection)
    {
        DataSet ds = section.ViewActiveIqacSection(stSection);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            ddlSubSection.Items.Clear();
            ddlSubSection.Items.Add(new ListItem("Select Sub Section", "Select Sub Section"));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string stText = Convert.ToString(ds.Tables[0].Rows[i]["SubSection"]);
                string stValue = Convert.ToString(ds.Tables[0].Rows[i]["Sno"]);
                ddlSubSection.Items.Add(new ListItem(stText, stValue));
            }
            ddlSubSection.DataBind();

        }
        else
        {
            ddlSubSection.Items.Clear();

            ddlSubSection.Items.Add(new ListItem("Select Sub Section", "Select Sub Section"));

        }
    }
   
    protected void btnSave_Click(object sender, EventArgs e)
    {

        string stErrorText = string.Empty;
        if (string.IsNullOrEmpty(txtTitle.Text))
        {
            stErrorText = "Please enter title";
        }
        if (string.Equals(ddlMainSection.SelectedItem.Text,"Select Type"))
        {
            stErrorText = "Please select section";
        }
        if (string.Equals(ddlSubSection.SelectedItem.Text, "Select Sub Section"))
        {
            stErrorText = "Please select sub section";
        }
        if (string.IsNullOrEmpty(txtDisplayOrder.Text))
        {
            stErrorText = "Please enter display order";
        }
        else if (Request.QueryString["ID"] == null && !flFile.HasFile)
        {
            stErrorText = "Please upload file";
        }
       
        if (string.IsNullOrEmpty(stErrorText))
        {

            if (Request.QueryString["ID"] == null)
            {

                InsertContent();
                clear();
            }
            else
            {
                content.Id = Convert.ToInt32(Request.QueryString["ID"]);
                UpdateContent(content.Id);
                BindContent(content.Id);
            }
            dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
            dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

        }

    }
    public int GetMaxDisplayOrder(string stSection,int subSectionId)
    {
        int DisplayOrder = 0;
        DataSet ds = content.ViewMaxIqaccontent(stSection, subSectionId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stDisplayOrder = Convert.ToString(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
            if (!string.IsNullOrEmpty(stDisplayOrder))
                DisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
        }
        return DisplayOrder;
    }
    public int SetDisplayOrder(string stSection, int subSectionId)
    {
        int DisplayOrder = 0;
        DisplayOrder = GetMaxDisplayOrder(stSection, subSectionId) + 1;
        return DisplayOrder;
    }
    public int DisplayOrderForInsert(string stSection, int subSectionId)
    {
        int DisplayOrder = 0;
        int addedDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
        int toDisplayOrder = GetMaxDisplayOrder(stSection, subSectionId);
        if (IsDisplayOrderExists(addedDisplayOrder, stSection, subSectionId))
        {
            DataSet ds = content.GetIqaccontentDisplayOrderForInsert(addedDisplayOrder, toDisplayOrder, stSection, subSectionId);
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
                    content.UpdateIqacContentDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
                DisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
            }

        }
        else
            DisplayOrder = SetDisplayOrder(stSection, subSectionId);
        return DisplayOrder;
    }
    public bool IsDisplayOrderExists(int DisplayOrder, string stSection, int subSectionId)
    {
        bool displayOrderExists = false;
        DataSet ds = content.IsIqaccontentDisplayOrderExists(DisplayOrder, stSection, subSectionId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            displayOrderExists = true;
        return displayOrderExists;


    }
    public int DisplayOrderForUpdate(string stSection, int subSectionId)
    {
        int DisplayOrder = 0;
        int MaxDisplayOrder = GetMaxDisplayOrder(stSection, subSectionId);
        int toDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
        int fromDisplayOrder = Convert.ToInt32(hdnDisplayOrder.Value.ToString());
        if (IsDisplayOrderExists(toDisplayOrder, stSection, subSectionId))
        {
            DisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());

        }
        else
            DisplayOrder = GetMaxDisplayOrder(stSection, subSectionId);

        DataSet ds = new DataSet();
        if (fromDisplayOrder < toDisplayOrder)
        {
            ds = content.GetIqaccontentDisplayOrderWay1(fromDisplayOrder, toDisplayOrder, stSection, subSectionId);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int oldDisplayOrder = 0;
                int NewDisplayOrder = 0;
                int SliderId = 0;
                string updatedBy =  login.GetUserName();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                    SliderId = Convert.ToInt32(ds.Tables[0].Rows[i]["Sno"]);
                    NewDisplayOrder = oldDisplayOrder - 1;
                    content.UpdateIqacContentDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
            }
        }
        else
        {
            ds = content.GetIqaccontentDisplayOrderWay2(fromDisplayOrder, toDisplayOrder, stSection, subSectionId);
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
                    content.UpdateIqacContentDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
            }
        }

        return DisplayOrder;
    }

    public void InsertContent()
    {
        try
        {
            string stfile = string.Empty;

            if (flFile.HasFile)
                stfile = flFile.FileName.Trim();
            bool blStatus = false;
            if (chkStatus.Checked)
                blStatus = true;
            int subSectionId = 0;
            string stSection = string.Empty;
          
            if (!string.Equals(ddlMainSection.SelectedItem.Text, "Select Section"))
            stSection = ddlMainSection.SelectedItem.Text;
            if (!string.Equals(ddlSubSection.SelectedItem.Text, "Select Sub Section"))
                  subSectionId = Convert.ToInt32(ddlSubSection.SelectedValue);
            int itDisplayOrder = DisplayOrderForInsert(stSection, subSectionId);
        List<iqaccontent> lstContent = new List<iqaccontent> {
            new iqaccontent{
                Section=stSection,
                SubSectionId=subSectionId,
                PdfName=(!string.IsNullOrEmpty(txtTitle.Text.Trim()))?txtTitle.Text.Trim():string.Empty,
                PdfUrl=stfile,
                DisplayOrder=Convert.ToInt32(itDisplayOrder),
                Active=blStatus,
                AddedDateTime=Utility.IndianTime,
                AddedBy=login.GetUserName(),
                UpdatedDateTime=Utility.IndianTime,
                UpdatedBy="NONE"

              }
        };
        int save = 0;
        if (!string.IsNullOrEmpty(stfile))
            save = SaveFile(stSection);
        if (save == 1)
        {
            int InsContent = content.AddIqacContent(lstContent);
            if (InsContent == -1)
            {

                dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Added Successfully');</script>");
                if (blStatus)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
            }
        }
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }

    }
    public void UpdateContent(int ID)
    {
        try
        {
            bool blStatus = false;
            if (chkStatus.Checked)
                blStatus = true;
            string stFile = string.Empty;
            int subSectionId = 0;
            string stSection = string.Empty;
            if (!string.Equals(ddlMainSection.SelectedItem.Text, "Select Section"))
                stSection = ddlMainSection.SelectedItem.Text;
            if (!string.Equals(ddlSubSection.SelectedItem.Text, "Select Sub Section"))
                subSectionId = Convert.ToInt32(ddlSubSection.SelectedValue);
            int itDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
            int oldDisplayOrder = Convert.ToInt32(hdnDisplayOrder.Value.ToString().Trim());
            if (!string.Equals(itDisplayOrder, oldDisplayOrder))
                itDisplayOrder = DisplayOrderForUpdate(stSection, subSectionId);
          
            int save = 0;
            if (flFile.HasFile)
            {
                save = SaveFile(stSection);
                stFile = flFile.FileName.Trim();
            }
           else if (flFile.HasFile && !string.IsNullOrEmpty(hiddenFile.Value))
            {
                save =  SaveFile(stSection);
                stFile = flFile.FileName.Trim();
            }
            else if (!flFile.HasFile && !string.IsNullOrEmpty(hiddenFile.Value))
            {

                stFile = hiddenFile.Value.Trim();
                save = 1;
            }
            List<iqaccontent> lstContent = new List<iqaccontent> {
            new iqaccontent{
                Section=stSection,
                SubSectionId=subSectionId,
                PdfName=(!string.IsNullOrEmpty(txtTitle.Text.Trim()))?txtTitle.Text.Trim():string.Empty,
                PdfUrl=stFile,
                DisplayOrder=Convert.ToInt32(itDisplayOrder),
                Active=blStatus,
                UpdatedDateTime=Utility.IndianTime,
                UpdatedBy=login.GetUserName()

              }
        };
            if (save == 1)
            {
                int UpdateContent = content.UpdateIqacContent(lstContent, ID);
                if (UpdateContent == -1)
                {

                    dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Updated Successfully');</script>");
                    if (blStatus)
                        lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                    else
                        lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
                }
            }
            
        }
        catch (Exception ex)
        {
        }
    }
   
   
    protected void ddlSubSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        string stSection = string.Empty;
        int subSectionId = 0;
        if (!string.Equals(ddlSubSection.SelectedItem.Text, "Select Sub Section"))
        {
            stSection = ddlMainSection.SelectedItem.Text.Trim();
            subSectionId = Convert.ToInt32(ddlSubSection.SelectedValue);
            txtDisplayOrder.Text = SetDisplayOrder(stSection, subSectionId).ToString();
            
        }
        else
        {

            txtDisplayOrder.Text = "";
        }
    }
    protected void ddlMainSection_SelectedIndexChanged(object sender, EventArgs e)
    {
        string stSection = string.Empty;
        if (!string.Equals(ddlMainSection.SelectedItem.Text, "Select Section"))
        {
            stSection = Convert.ToString(ddlMainSection.SelectedItem.Text);
            BindSubSection(stSection);
        }
        else
        {
           
            txtDisplayOrder.Text = "";
        }
    }
    public int SaveFile(string stType)
    {
        int savefile = 0;
        try
        {
           
            string filePath = System.Configuration.ConfigurationManager.AppSettings["IQACpdf"];
            string temppath = filePath.Trim() + Getpdfpath(stType) + @"\" + flFile.FileName;
            string savepath = Server.MapPath(temppath);
            flFile.SaveAs(savepath);
            string strPath = flFile.FileName;
            savefile = 1;
        }
        catch (Exception ex)
        {
            savefile = 0;
            Response.Write(ex.ToString());
        }
        return savefile;
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {

        clear();
    }

    public void clear()
    {
        
        txtTitle.Text = "";
        ddlMainSection.SelectedIndex = 0;
        ddlSubSection.SelectedIndex = 0;
        txtDisplayOrder.Text = "";
        lblStatus.Text = "";

    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("view.aspx", true);
    }
   
}