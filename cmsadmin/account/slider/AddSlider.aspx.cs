using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Data;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
public partial class admin_account_Slider_AddSlider : System.Web.UI.Page
{
    pmuslider content = new pmuslider();
    

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / Slider / <b>Edit</b>";
            content.ID = Convert.ToInt32(Request.QueryString["ID"]);
            if (!IsPostBack)
            {
                
                BindContent(content.ID);
                RequiredFieldValidator5.Enabled = false;
            }
        }
        else
        {
            if (!IsPostBack)
            {
               
                txtDisplayOrder.Text = SetDisplayOrder().ToString();
            }
            lblDisplayText.Text = "Dashboard / Slider / <b>Add</b>";
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
            string filePath = System.Configuration.ConfigurationManager.AppSettings["SliderImages"];
            string temppath = filePath.Trim() + @"\" + flSliderImage.FileName;
            DataSet dsContent = content.ViewSliderByID(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                //dvSliderImage.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvProjectLink.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["SliderText1"])))
                {
                    string stContent = Convert.ToString(dsContent.Tables[0].Rows[0]["SliderText1"]);
                    txtSliderText1.Text = stContent.Trim();
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["SliderText2"])))
                {
                    string stContent = Convert.ToString(dsContent.Tables[0].Rows[0]["SliderText2"]);
                    txtSliderText2.Text = stContent.Trim();
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"])))
                {
                    txtDisplayOrder.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"]);
                    hdnDisplayOrder.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"]);
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["SliderImage"])))
                {
                    hiddenSliderImage.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["SliderImage"]);
                    imgSliderImage.Src = filePath + @"/" + hiddenSliderImage.Value.ToString().Trim();
                    dvoldImage.Style.Add("display", "block");
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["LinkUrl"])))
                {
                    txtLinkUrl.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["LinkUrl"]);
                    

                }
                bool Publish = Convert.ToBoolean(dsContent.Tables[0].Rows[0]["Status"]);
                chkStatus.Checked = Publish;
                hdnStatus.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["Status"]);
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

        string stErrorText = string.Empty;
        if (string.IsNullOrEmpty(txtDisplayOrder.Text))
        {
            stErrorText = "Please enter display order";
        }
        else if (Request.QueryString["ID"] == null && !flSliderImage.HasFile)
        {
            stErrorText = "Please upload slider image";
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
                content.ID = Convert.ToInt32(Request.QueryString["ID"]);
                UpdateContent(content.ID);
                BindContent(content.ID);
            }

        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
            dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvEventImage.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvProjectLink.Attributes["class"] = "md-input-wrapper md-input-filled";
            dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

        }

    }
    public int GetMaxDisplayOrder()
    {
        int DisplayOrder = 0;
        DataSet ds = content.ViewMaxSlider();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stDisplayOrder = Convert.ToString(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
            if (!string.IsNullOrEmpty(stDisplayOrder))
                DisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[0]["MaxDisplayOrder"]);
        }
        return DisplayOrder;
    }
    public int SetDisplayOrder()
    {
        int DisplayOrder = 0;
        DisplayOrder = GetMaxDisplayOrder() + 1;
        return DisplayOrder;
    }
    public int DisplayOrderForInsert()
    {
        int DisplayOrder = 0;
        int addedDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
        int toDisplayOrder = GetMaxDisplayOrder();
        if (IsDisplayOrderExists(addedDisplayOrder))
        {
            DataSet ds = content.GetSliderDisplayOrderForInsert(addedDisplayOrder, toDisplayOrder);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int oldDisplayOrder = 0;
                int NewDisplayOrder = 0;
                int SliderId = 0;
                string updatedBy = "admin";// login.GetUserName();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                    SliderId = Convert.ToInt32(ds.Tables[0].Rows[i]["SliderId"]);
                    NewDisplayOrder = oldDisplayOrder + 1;
                    content.UpdateSliderDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
                DisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
            }

        }
        else
            DisplayOrder = SetDisplayOrder();
        return DisplayOrder;
    }
    public bool IsDisplayOrderExists(int DisplayOrder)
    {
        bool displayOrderExists = false;
        DataSet ds = content.IsDisplayOrderExists(DisplayOrder);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            displayOrderExists = true;
        return displayOrderExists;


    }
    public int DisplayOrderForUpdate()
    {
        int DisplayOrder = 0;
        int MaxDisplayOrder = GetMaxDisplayOrder();
        int toDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
        int fromDisplayOrder = Convert.ToInt32(hdnDisplayOrder.Value.ToString());
        if (IsDisplayOrderExists(toDisplayOrder))
        {
            DisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());

        }
        else
            DisplayOrder = GetMaxDisplayOrder();

        DataSet ds = new DataSet();
        if (fromDisplayOrder < toDisplayOrder)
        {
            ds = content.GetSliderDisplayOrderWay1(fromDisplayOrder, toDisplayOrder);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int oldDisplayOrder = 0;
                int NewDisplayOrder = 0;
                int SliderId = 0;
                string updatedBy = "admin";// login.GetUserName();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                    SliderId = Convert.ToInt32(ds.Tables[0].Rows[i]["SliderId"]);
                    NewDisplayOrder = oldDisplayOrder - 1;
                    content.UpdateSliderDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
            }
        }
        else
        {
            ds = content.GetSliderDisplayOrderWay2(fromDisplayOrder, toDisplayOrder);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int oldDisplayOrder = 0;
                int NewDisplayOrder = 0;
                int SliderId = 0;
                string updatedBy = "admin"; //login.GetUserName();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                    SliderId = Convert.ToInt32(ds.Tables[0].Rows[i]["SliderId"]);
                    NewDisplayOrder = oldDisplayOrder + 1;
                    content.UpdateSliderDisplayOrder(SliderId, NewDisplayOrder, updatedBy);

                }
            }
        }

        return DisplayOrder;
    }
    public string bindProjectUrl(string projectLink)
    {

        return projectLink;
    }
    public void InsertContent()
    {
        try
        {
            string stSliderImage = string.Empty;
            string stSliderText = string.Empty;
            if (flSliderImage.HasFile)
                stSliderImage = flSliderImage.FileName.Trim();
            bool blStatus = false;
            if (chkStatus.Checked)
                blStatus = true;
            int itDisplayOrder = DisplayOrderForInsert();
           
           
            List<pmuslider> lstContent = new List<pmuslider> {
            new pmuslider{
                SliderText1=(!string.IsNullOrEmpty(txtSliderText1.Text.Trim()))?txtSliderText1.Text.Trim():string.Empty,
                SliderText2=(!string.IsNullOrEmpty(txtSliderText2.Text.Trim()))?txtSliderText2.Text.Trim():string.Empty,
                DisplayOrder=Convert.ToInt32(itDisplayOrder),
                SliderImage=stSliderImage.Trim(),
                LinkUrl=(!string.IsNullOrEmpty(txtLinkUrl.Text.Trim()))?txtLinkUrl.Text.Trim():string.Empty,
                Status=blStatus,
                AddedDateTime=Utility.IndianTime,
                AddedBy="admin",//login.GetUserName(),
                UpdatedDateTime=Utility.IndianTime,
                UpdatedBy="NONE"
               
              }
        };
            if (!string.IsNullOrEmpty(stSliderImage))
                SaveSliderImageFile();

            int InsContent = content.AddSlider(lstContent);
            if (InsContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvEventImage.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvProjectLink.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Added');</script>");
                if (blStatus)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
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
            string stSliderImage = string.Empty;
            int itDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
            int oldDisplayOrder = Convert.ToInt32(hdnDisplayOrder.Value.ToString().Trim());
            if (!string.Equals(itDisplayOrder, oldDisplayOrder))
                itDisplayOrder = DisplayOrderForUpdate();
            if (flSliderImage.HasFile)
            {
                SaveSliderImageFile();
                stSliderImage = flSliderImage.FileName.Trim();
            }
            if (flSliderImage.HasFile && !string.IsNullOrEmpty(hiddenSliderImage.Value))
            {
                SaveSliderImageFile();
                stSliderImage = flSliderImage.FileName.Trim();
            }
            else if (!flSliderImage.HasFile && !string.IsNullOrEmpty(hiddenSliderImage.Value))
            {

                stSliderImage = hiddenSliderImage.Value.Trim();
            }

            List<pmuslider> lstContent = new List<pmuslider> {
            new pmuslider{
                SliderText1=(!string.IsNullOrEmpty(txtSliderText1.Text.Trim()))?txtSliderText1.Text.Trim():string.Empty,
                SliderText2=(!string.IsNullOrEmpty(txtSliderText2.Text.Trim()))?txtSliderText2.Text.Trim():string.Empty,
                DisplayOrder=Convert.ToInt32(itDisplayOrder),
                LinkUrl=(!string.IsNullOrEmpty(txtLinkUrl.Text.Trim()))?txtLinkUrl.Text.Trim():string.Empty,
                SliderImage=stSliderImage.Trim(),
                Status=blStatus,
                AddedDateTime=Utility.IndianTime,
                AddedBy= "admin",// login.GetUserName(),
                UpdatedDateTime=Utility.IndianTime,
                UpdatedBy="admin"
                
            }
        };

            int UpdateContent = content.UpdateSlider(lstContent, ID);
            if (UpdateContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvEventImage.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvProjectLink.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
                if (blStatus)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
            }
        }
        catch (Exception ex)
        {
        }
    }
    public int SaveSliderImageFile()
    {
        int savefile = 0;
        try
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["SliderImages"];
            string temppath = filePath.Trim() + @"\" + flSliderImage.FileName;
            string savepath = Server.MapPath(temppath);
            flSliderImage.SaveAs(savepath);
            string strPath = flSliderImage.FileName;
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
        txtDisplayOrder.Text = SetDisplayOrder().ToString();
        txtLinkUrl.Text = "";
        txtSliderText1.Text = "";
        txtSliderText2.Text = "";
        lblStatus.Text = "";

    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewSlider.aspx", true);
    }
   
}