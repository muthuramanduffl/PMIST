using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Data;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
public partial class admin_account_Slider_AddSlider : System.Web.UI.Page
{
    naaccontent content = new naaccontent();
    naacmetric metric = new naacmetric();
    naacsubmetric submetric = new naacsubmetric();
    pmuLogin login = new pmuLogin();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / Naac / <b>Edit</b>";
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
            lblDisplayText.Text = "Dashboard / Naac / <b>Add</b>";
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
            
            
            DataSet dsContent = content.ViewNaacById(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvSubMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvType.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["CriteriaId"])))
                {
                    string stCriteria = Convert.ToString(dsContent.Tables[0].Rows[0]["CriteriaId"]);
                    ddlCriteria.Items.FindByText(ddlCriteria.SelectedItem.Text).Selected = false;
                    ddlCriteria.Items.FindByText(stCriteria).Selected = true;
                    BindMetric(Convert.ToInt32(stCriteria));
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["MetricId"])))
                {
                    string stmetricId = Convert.ToString(dsContent.Tables[0].Rows[0]["MetricId"]);
                    int ICriteria = Convert.ToInt32(dsContent.Tables[0].Rows[0]["CriteriaId"]);
                    ddlMetricNo.Items.FindByValue(ddlMetricNo.SelectedValue).Selected = false;
                    ddlMetricNo.Items.FindByValue(stmetricId).Selected = true;
                    BindSubMetric(Convert.ToInt32(ICriteria),Convert.ToInt32(stmetricId));
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["SubMetricId"])))
                {
                    string stSubmetricId = Convert.ToString(dsContent.Tables[0].Rows[0]["SubMetricId"]);
                    ddlSubMetric.Items.FindByValue(ddlSubMetric.SelectedValue).Selected = false;
                    ddlSubMetric.Items.FindByValue(stSubmetricId).Selected = true;
                    
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"])))
                {
                    txtDisplayOrder.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"]);
                    hdnDisplayOrder.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"]);
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Type"])))
                {
                    string stType = Convert.ToString(dsContent.Tables[0].Rows[0]["Type"]);
                    ddlType.Items.FindByText(ddlType.SelectedItem.Text).Selected = false;
                    ddlType.Items.FindByText(stType).Selected = true;

                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Title"])))
                {
                    txtTitle.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Title"]);
                   
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Url"])))
                {
                    hiddenFile.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["Url"]);
                    string stType = Convert.ToString(dsContent.Tables[0].Rows[0]["Type"]);
                    if (string.Equals(stType, "Image"))
                    {
                        string filePath = System.Configuration.ConfigurationManager.AppSettings["NaacImage"];
                        imgSliderImage.Src = filePath + @"/" + hiddenFile.Value.ToString().Trim();
                        
                    }
                    else if (string.Equals(stType, "Video"))
                    {
                        string filePath = System.Configuration.ConfigurationManager.AppSettings["NaacVideo"];
                        string url = "<a href = '" + filePath + @"/" + hiddenFile.Value.ToString().Trim() + "' target = '_blank'>View Video</a>";
                        phType.Controls.Add(new LiteralControl(url));
                       
                    }
                    else if (string.Equals(stType, "PDF"))
                    {
                        string filePath = System.Configuration.ConfigurationManager.AppSettings["Naacpdf"];
                        string url = "<a href = '" + filePath + @"/" + hiddenFile.Value.ToString().Trim() + "' target = '_blank'>View PDF</a>";
                        phType.Controls.Add(new LiteralControl(url));
                    }
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
    public void BindMetric(int CriteriaId)
    {
        DataSet ds = metric.ViewActiveMetric(CriteriaId);
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
            BindSubMetric(0, 0);
        }
    }
    public void BindSubMetric(int CriteriaId,int metricId)
    {
        DataSet ds = submetric.ViewActiveSubMetric(CriteriaId, metricId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            ddlSubMetric.Items.Clear();
            ddlSubMetric.Items.Add(new ListItem("Select Sub Metric", "Select Sub Metric"));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string stText = Convert.ToString(ds.Tables[0].Rows[i]["SubMetricNo"]);
                string stValue = Convert.ToString(ds.Tables[0].Rows[i]["Sno"]);
                ddlSubMetric.Items.Add(new ListItem(stText, stValue));
            }
            ddlSubMetric.DataBind();

        }
        else
        {
            ddlSubMetric.Items.Clear();

            ddlSubMetric.Items.Add(new ListItem("Select Sub Metric", "Select Sub Metric"));

        }
    }
    public bool IsSubMetricAvailable(int CriteriaId, int metricId)
    {
        bool IsAvailable = false;
        DataSet ds = submetric.ViewActiveSubMetric(CriteriaId, metricId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            IsAvailable = true;
        return IsAvailable;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {

        string stErrorText = string.Empty;
        if (string.IsNullOrEmpty(txtTitle.Text))
        {
            stErrorText = "Please enter title";
        }
        if (string.Equals(ddlType.SelectedItem.Text,"Select Type"))
        {
            stErrorText = "Please select type";
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
            dvSubMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvType.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
            dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvSubMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvType.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

        }

    }
    public int GetMaxDisplayOrder(int CriteriaId,int metricId, int SubmetricId)
    {
        int DisplayOrder = 0;
        DataSet ds = content.ViewMaxNaac(CriteriaId, metricId, SubmetricId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stDisplayOrder = Convert.ToString(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
            if (!string.IsNullOrEmpty(stDisplayOrder))
                DisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
        }
        return DisplayOrder;
    }
    public int SetDisplayOrder(int CriteriaId, int metricId, int SubmetricId)
    {
        int DisplayOrder = 0;
        DisplayOrder = GetMaxDisplayOrder(CriteriaId, metricId, SubmetricId) + 1;
        return DisplayOrder;
    }
    public int DisplayOrderForInsert(int CriteriaId, int metricId, int SubmetricId)
    {
        int DisplayOrder = 0;
        int addedDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
        int toDisplayOrder = GetMaxDisplayOrder(CriteriaId, metricId, SubmetricId);
        if (IsDisplayOrderExists(addedDisplayOrder, CriteriaId, metricId, SubmetricId))
        {
            DataSet ds = content.GetNaacDisplayOrderForInsert(addedDisplayOrder, toDisplayOrder, CriteriaId, metricId, SubmetricId);
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
                    NewDisplayOrder = oldDisplayOrder + 1;
                    content.UpdateNaacDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
                DisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
            }

        }
        else
            DisplayOrder = SetDisplayOrder(CriteriaId, metricId, SubmetricId);
        return DisplayOrder;
    }
    public bool IsDisplayOrderExists(int DisplayOrder, int CriteriaId, int metricId, int SubmetricId)
    {
        bool displayOrderExists = false;
        DataSet ds = content.IsNaacDisplayOrderExists(DisplayOrder, CriteriaId, metricId, SubmetricId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            displayOrderExists = true;
        return displayOrderExists;


    }
    public int DisplayOrderForUpdate(int CriteriaId, int metricId, int SubmetricId)
    {
        int DisplayOrder = 0;
        int MaxDisplayOrder = GetMaxDisplayOrder(CriteriaId, metricId, SubmetricId);
        int toDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
        int fromDisplayOrder = Convert.ToInt32(hdnDisplayOrder.Value.ToString());
        if (IsDisplayOrderExists(toDisplayOrder, CriteriaId, metricId, SubmetricId))
        {
            DisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());

        }
        else
            DisplayOrder = GetMaxDisplayOrder(CriteriaId, metricId, SubmetricId);

        DataSet ds = new DataSet();
        if (fromDisplayOrder < toDisplayOrder)
        {
            ds = content.GetNaacDisplayOrderWay1(fromDisplayOrder, toDisplayOrder, CriteriaId, metricId, SubmetricId);
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
                    content.UpdateNaacDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
            }
        }
        else
        {
            ds = content.GetNaacDisplayOrderWay2(fromDisplayOrder, toDisplayOrder, CriteriaId, metricId, SubmetricId);
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
                    content.UpdateNaacDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
            }
        }

        return DisplayOrder;
    }

    public void InsertContent()
    {
        //try
        //{
            string stfile = string.Empty;

            if (flFile.HasFile)
                stfile = flFile.FileName.Trim();
            bool blStatus = false;
            if (chkStatus.Checked)
                blStatus = true;
            int Criteria = 0;
            int metricid = 0;
            int submetricId = 0;
            string stType = string.Empty;
            string stFileError = string.Empty;
            if (!string.Equals(ddlCriteria.SelectedItem.Text, "Select Criteria"))
                Criteria = Convert.ToInt32(ddlCriteria.SelectedItem.Text);
            if (!string.Equals(ddlMetricNo.SelectedItem.Text, "Select Metric"))
                metricid = Convert.ToInt32(ddlMetricNo.SelectedValue);
            if (!string.Equals(ddlSubMetric.SelectedItem.Text, "Select Sub Metric"))
                submetricId = Convert.ToInt32(ddlSubMetric.SelectedValue);
            int itDisplayOrder = DisplayOrderForInsert(Criteria, metricid, submetricId);
            if (!string.Equals(ddlType.SelectedItem.Text, "Select Type"))
            {
                stType = ddlType.SelectedItem.Text;
                string extension = System.IO.Path.GetExtension(stfile);
                if (string.Equals(stType, "Image"))
                {
                    if (!extension.Equals(".png", StringComparison.OrdinalIgnoreCase) && !extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase)
                        && !extension.Equals(".gif", StringComparison.OrdinalIgnoreCase) && !extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase))
                    {
                        stFileError = "Images must be of type jpeg or gif or png!";
                    }
                }
                else if (string.Equals(stType, "PDF"))
                {
                    if (!extension.Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                    {
                        stFileError = "File must be of type pdf";
                    }
                }
                else if (string.Equals(stType, "Video"))
                {
                    if (!extension.Equals(".mp4", StringComparison.OrdinalIgnoreCase))
                    {
                        stFileError = "Video file must be of type mp4";
                    }
                }
            }
            if (string.IsNullOrEmpty(stFileError))
            {
                List<naaccontent> lstContent = new List<naaccontent> {
            new naaccontent{
                CriteriaId=Criteria,
                MetricId=metricid,
                SubMetricId=submetricId,
                Title=(!string.IsNullOrEmpty(txtTitle.Text.Trim()))?txtTitle.Text.Trim():string.Empty,
                Url=stfile,
                Type=stType,
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
                    save = SaveFile(stType);
                if (save == 1)
                {
                    int InsContent = content.AddNaac(lstContent);
                    if (InsContent == -1)
                    {

                        //dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
                        //dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
                        //dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                        //dvSubMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                        //dvType.Attributes["class"] = "md-input-wrapper md-input-filled";
                        //dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                        //dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Added Successfully');</script>");
                        if (blStatus)
                            lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                        else
                            lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
                    }
                }
            }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('"+ stFileError + "');</script>");
            dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvSubMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvType.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";
        }
        //}
        //catch (Exception ex)
        //{
        //    Response.Write(ex.ToString());
        //}
    
    }
    public void UpdateContent(int ID)
    {
        try
        {
            bool blStatus = false;
            if (chkStatus.Checked)
                blStatus = true;
            string stFile = string.Empty;
            int Criteria = 0;
            int metricid = 0;
            int submetricId = 0;
            if (!string.Equals(ddlCriteria.SelectedItem.Text, "Select Criteria"))
                Criteria = Convert.ToInt32(ddlCriteria.SelectedItem.Text);
            if (!string.Equals(ddlMetricNo.SelectedItem.Text, "Select Metric"))
                metricid = Convert.ToInt32(ddlMetricNo.SelectedValue);
            if (!string.Equals(ddlSubMetric.SelectedItem.Text, "Select Sub Metric"))
                submetricId = Convert.ToInt32(ddlSubMetric.SelectedValue);
            int itDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
            int oldDisplayOrder = Convert.ToInt32(hdnDisplayOrder.Value.ToString().Trim());
            if (!string.Equals(itDisplayOrder, oldDisplayOrder))
                itDisplayOrder = DisplayOrderForUpdate(Criteria, metricid, submetricId);
            string stType = string.Empty;
            string stFileError = string.Empty;
            if (!string.Equals(ddlType.SelectedItem.Text, "Select Type"))
            {
                stType = ddlType.SelectedItem.Text;

                if (string.Equals(stType, "Image") && flFile.HasFile)
                {
                    string extension = System.IO.Path.GetExtension(flFile.FileName);
                    if (!extension.Equals(".png", StringComparison.OrdinalIgnoreCase) && !extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase)
                         && !extension.Equals(".gif", StringComparison.OrdinalIgnoreCase) && !extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase))
                    {
                        stFileError = "Images must be of type jpeg or gif or png!";
                    }
                }
                else if (string.Equals(stType, "PDF") && flFile.HasFile)
                {
                    string extension = System.IO.Path.GetExtension(flFile.FileName);
                    if (!extension.Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                    {
                        stFileError = "File must be of type pdf";
                    }
                }
                else if (string.Equals(stType, "Video") && flFile.HasFile)
                {
                    string extension = System.IO.Path.GetExtension(flFile.FileName);
                    if (!extension.Equals(".mp4", StringComparison.OrdinalIgnoreCase))
                    {
                        stFileError = "Video file must be of type mp4";
                    }
                }
            }
            int save = 0;
            if (flFile.HasFile)
            {
                save = SaveFile(stType);
                stFile = flFile.FileName.Trim();
            }
           else if (flFile.HasFile && !string.IsNullOrEmpty(hiddenFile.Value))
            {
                save =  SaveFile(stType);
                stFile = flFile.FileName.Trim();
            }
            else if (!flFile.HasFile && !string.IsNullOrEmpty(hiddenFile.Value))
            {

                stFile = hiddenFile.Value.Trim();
                save = 1;
            }
            List<naaccontent> lstContent = new List<naaccontent> {
            new naaccontent{
                CriteriaId=Criteria,
                MetricId=metricid,
                SubMetricId=submetricId,
                Title=(!string.IsNullOrEmpty(txtTitle.Text.Trim()))?txtTitle.Text.Trim():string.Empty,
                Url=stFile,
                Type=stType,
                DisplayOrder=Convert.ToInt32(itDisplayOrder),
                Active=blStatus,
                UpdatedDateTime=Utility.IndianTime,
                UpdatedBy="admin"

              }
        };
            if (save == 1)
            {
                int UpdateContent = content.UpdateNaac(lstContent, ID);
                if (UpdateContent == -1)
                {

                    dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvSubMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvType.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                    dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Updated Successfully');</script>");
                    if (blStatus)
                        lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                    else
                        lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stFileError + "');</script>");
                dvCriteria.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvUplodFile.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvSubMetric.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvType.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";
            }
        }
        catch (Exception ex)
        {
        }
    }
   
    protected void ddlSubMetric_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Critera = 0;
        int metricId = 0;
        int submetricId = 0;
        if (!string.Equals(ddlCriteria.SelectedItem.Text, "Select Criteria"))
        {
            Critera = Convert.ToInt32(ddlCriteria.SelectedItem.Text);
            if (!string.Equals(ddlMetricNo.SelectedItem.Text, "Select Metric"))
            {
                metricId = Convert.ToInt32(ddlMetricNo.SelectedValue);

                if (!string.Equals(ddlSubMetric.SelectedItem.Text, "Select Sub Metric"))
                {
                    submetricId = Convert.ToInt32(ddlSubMetric.SelectedValue);
                    txtDisplayOrder.Text = SetDisplayOrder(Critera, metricId, submetricId).ToString();
                }
                else
                {
                    txtDisplayOrder.Text = "";
                }
            }

        }
        else
        {
            txtDisplayOrder.Text = "";
        }
        
    }
    protected void ddlMetricNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Critera = 0;
        int metricId = 0;
        if (!string.Equals(ddlCriteria.SelectedItem.Text, "Select Criteria"))
        {
            Critera = Convert.ToInt32(ddlCriteria.SelectedItem.Text);
            if (!string.Equals(ddlMetricNo.SelectedItem.Text, "Select Metric"))
            {
                metricId = Convert.ToInt32(ddlMetricNo.SelectedValue);
                if (!IsSubMetricAvailable(Critera, metricId))
                {
                    txtDisplayOrder.Text = SetDisplayOrder(Critera, metricId, 0).ToString();
                }
                else
                {
                    txtDisplayOrder.Text = "";
                    BindSubMetric(Critera, metricId);
                }
            }
            else
            {
                BindSubMetric(0, 0);
                txtDisplayOrder.Text = "";
            }
        }
        
    }
    protected void ddlCriteria_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Critera = 0;
        if (!string.Equals(ddlCriteria.SelectedItem.Text, "Select Criteria"))
        {
            Critera = Convert.ToInt32(ddlCriteria.SelectedItem.Text);
            BindMetric(Critera);
        }
        else
        {
            BindMetric(0);
            txtDisplayOrder.Text = "";
        }
    }
    public int SaveFile(string stType)
    {
        int savefile = 0;
        try
        {
            string filePath = string.Empty;
            if (string.Equals(stType, "Image"))
                filePath = System.Configuration.ConfigurationManager.AppSettings["NaacImage"];
            else if (string.Equals(stType, "PDF"))
                filePath = System.Configuration.ConfigurationManager.AppSettings["Naacpdf"];
            else if (string.Equals(stType, "Video"))
                filePath = System.Configuration.ConfigurationManager.AppSettings["NaacVideo"];
            string temppath = filePath.Trim() + @"\" + flFile.FileName;
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
        ddlCriteria.SelectedIndex = 0;
        ddlMetricNo.SelectedIndex = 0;
        ddlSubMetric.SelectedIndex = 0;
        txtDisplayOrder.Text = "";
        ddlType.SelectedIndex = 0;
        lblStatus.Text = "";

    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("view.aspx", true);
    }
   
}