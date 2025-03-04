using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

public partial class admin_account_faculty_addfaculty : System.Web.UI.Page
{
    pmufaculty faculty = new pmufaculty();
    pmuLogin login = new pmuLogin();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request.QueryString["ID"] != null)
        {
            lblDisplayText.Text = "Dashboard / Faculty / <b>Edit</b>";
            faculty.Sno = Convert.ToInt32(Request.QueryString["ID"]);
            if (!IsPostBack)
            {
                RequiredFieldValidator6.Enabled = false;
                BindFaculty(faculty.Sno);


            }
        }
        else
        {
            if (!IsPostBack)
            {
               
                txtDisplayOrder.Text = SetDisplayOrder().ToString();
            }

            lblDisplayText.Text = "Dashboard / Faculty / <b>Add</b>";
            
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

    public void BindFaculty(int ID)
    {
        try
        {
            DataSet dsContent = faculty.ViewFacultyById(ID);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvHeaderTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
               dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";
               
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Name"])))
                    txtName.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Name"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Designation"])))
                    txtDesignation.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["Designation"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["Department"])))
                {
                    string stDepartment= Convert.ToString(dsContent.Tables[0].Rows[0]["Department"]);
                    ddlDepartment.Items.FindByText(ddlDepartment.SelectedItem.Text).Selected = false;
                    ddlDepartment.Items.FindByText(stDepartment).Selected = true;
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"])))
                {
                    txtDisplayOrder.Text = Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"]);
                    hdnDisplayOrder.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["DisplayOrder"]);
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["ThumbNailImage"])))
                {
                    string CoverImagefilePath = System.Configuration.ConfigurationManager.AppSettings["FacultyImages"];
                    hiddenEventImage.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["ThumbNailImage"]);
                    imgoldImage.Src = CoverImagefilePath + @"\" + hiddenEventImage.Value.ToString().Trim();
                    dvoldImage.Style.Add("display", "block");
                }
               
                
                bool Status = Convert.ToBoolean(dsContent.Tables[0].Rows[0]["Status"]);
                chkStatus.Checked = Status;
                bool IShod = Convert.ToBoolean(dsContent.Tables[0].Rows[0]["IsHod"]);
                chkIshod.Checked = IShod;


                if (!string.IsNullOrEmpty(Convert.ToString(dsContent.Tables[0].Rows[0]["PdfName"])))
                {
                    hlPDF1.Value = Convert.ToString(dsContent.Tables[0].Rows[0]["PdfName"]);
                    string path = System.Configuration.ConfigurationManager.AppSettings["Facultypdf"];
                    string pdf1path = path +  hlPDF1.Value;
                    phpdf1.Controls.Add(new LiteralControl("PDF : <a href='" + pdf1path + "' target='_balnk'>View PDF</a>"));
                }
               

                //BindLiveUrl(ID);
                if (Status)
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

        if (string.IsNullOrEmpty(txtName.Text))
        {
            stErrorText = "Please enter name";
        }
        else if (string.IsNullOrEmpty(txtDisplayOrder.Text))
        {
            stErrorText = "Please enter display order";
        }
        else if (string.IsNullOrEmpty(txtDesignation.Text))
        {
            stErrorText = "Please enter designation";
        }
        
        if (string.IsNullOrEmpty(stErrorText))
        {
            if (Request.QueryString["ID"] == null)
            {

                InsertContent();
                Clear();
            }
            else
            {
                faculty.Sno = Convert.ToInt32(Request.QueryString["ID"]);
                UpdateContent(faculty.Sno);
            }

        }
        else
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('" + stErrorText + "');</script>");
            dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";
        btnSave.Text = "Save";
    }

    public int GetMaxDisplayOrder()
    {
        int DisplayOrder = 0;
        string stDepartment = ddlDepartment.SelectedItem.Text.Trim();
        DataSet ds = faculty.ViewMaxFaculty(stDepartment);
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
        string stDepartment = ddlDepartment.SelectedItem.Text.Trim();
        if (IsDisplayOrderExistsFaculty(addedDisplayOrder, stDepartment))
        {
            DataSet ds = faculty.GetFacultyDisplayOrderForInsert(addedDisplayOrder, toDisplayOrder, stDepartment);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int oldDisplayOrder = 0;
                int NewDisplayOrder = 0;
                int Sno = 0;
                string updatedBy = "admin";// login.GetUserName();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                    Sno = Convert.ToInt32(ds.Tables[0].Rows[i]["Sno"]);
                    NewDisplayOrder = oldDisplayOrder + 1;
                    faculty.UpdateFacultyDisplayOrder(Sno, NewDisplayOrder, updatedBy, stDepartment);

                }
                DisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
            }

        }
        else
            DisplayOrder = SetDisplayOrder();
        return DisplayOrder;
    }
    public bool IsDisplayOrderExistsFaculty(int DisplayOrder, string stDepartment)
    {
        bool displayOrderExists = false;
        DataSet ds = faculty.IsDisplayOrderExistsFaculty(DisplayOrder, stDepartment);
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
        string stDepartment = ddlDepartment.SelectedItem.Text.Trim();
        if (IsDisplayOrderExistsFaculty(toDisplayOrder, stDepartment))
        {
            DisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());

        }
        else
            DisplayOrder = GetMaxDisplayOrder();

        DataSet ds = new DataSet();
        if (fromDisplayOrder < toDisplayOrder)
        {
            ds = faculty.GetFacultyDisplayOrderWay1(fromDisplayOrder, toDisplayOrder, stDepartment);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int oldDisplayOrder = 0;
                int NewDisplayOrder = 0;
                int Sno = 0;
                string updatedBy = "admin";// login.GetUserName();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                    Sno = Convert.ToInt32(ds.Tables[0].Rows[i]["Sno"]);
                    NewDisplayOrder = oldDisplayOrder - 1;
                    faculty.UpdateFacultyDisplayOrder(Sno, NewDisplayOrder, updatedBy, stDepartment);

                }
            }
        }
        else
        {
            ds = faculty.GetFacultyDisplayOrderWay2(fromDisplayOrder, toDisplayOrder, stDepartment);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int oldDisplayOrder = 0;
                int NewDisplayOrder = 0;
                int Sno = 0;
                string updatedBy = "admin"; //login.GetUserName();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    oldDisplayOrder = Convert.ToInt32(ds.Tables[0].Rows[i]["DisplayOrder"]);
                    Sno = Convert.ToInt32(ds.Tables[0].Rows[i]["Sno"]);
                    NewDisplayOrder = oldDisplayOrder + 1;
                    faculty.UpdateFacultyDisplayOrder(Sno, NewDisplayOrder, updatedBy, stDepartment);

                }
            }
        }

        return DisplayOrder;
    }


    public void InsertContent()
    {
        //try
        //{
            bool status = false;
            if (chkStatus.Checked)
                status = true;

            bool IsHOD = false;
            if (chkIshod.Checked)
                IsHOD = true;

            string steventImage = string.Empty;
            string stpdf1 = string.Empty;
            int itDisplayOrder = DisplayOrderForInsert();
           
            string stdepartment = string.Empty;
            if (!string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
                stdepartment = ddlDepartment.SelectedItem.Text.Trim();
            if (flEventImage.HasFile)
                steventImage = flEventImage.FileName.Trim();
            if (flPDF1.HasFile)
                stpdf1 = flPDF1.FileName.Trim();
           
            List<pmufaculty> lstContent = new List<pmufaculty> {
            new pmufaculty{
                Name=(!string.IsNullOrEmpty(txtName.Text))?txtName.Text.Trim():string.Empty,
                Designation=(!string.IsNullOrEmpty(txtDesignation.Text))?txtDesignation.Text.Trim():string.Empty,
                Department=stdepartment,
                ThumbNailImage=steventImage, 
                DisplayOrder=Convert.ToInt32(itDisplayOrder),              
                Status=status,
                PostedDate=Utility.IndianTime,
                PostedBy=login.GetUserName(),
                UpdatedDate=Utility.IndianTime,
                UpdatedBy=login.GetUserName(),
                PdfName=stpdf1,
                IsHod=IsHOD
              }
        };
            if (!string.IsNullOrEmpty(steventImage))
                SaveImageFile();
            if (!string.IsNullOrEmpty(stpdf1))
                Savepdf1File();
           
            int InsContent = faculty.AddFaculty(lstContent);
            if (InsContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvHeaderTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Inserted');</script>");
                if (status)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
                // string stUrl = "<a href='/news-details.aspx?ID=" + ID + "' target='_blank'>Live Url :News</a>";
                //phLiveUrl.Controls.Add(new LiteralControl(stUrl.Trim()));
               

            }
        //}
        //catch (Exception ex)
        //{
        //    Response.Write(ex.ToString());
        //}
    }
    
    public void UpdateContent(int ID)
    {
        //try
        //{
            bool status = false;
            if (chkStatus.Checked)
                status = true;
            bool IsHOD = false;
            if (chkIshod.Checked)
                IsHOD = true;

            int itDisplayOrder = Convert.ToInt32(txtDisplayOrder.Text.Trim());
            int oldDisplayOrder = Convert.ToInt32(hdnDisplayOrder.Value.ToString().Trim());
            if (!string.Equals(itDisplayOrder, oldDisplayOrder))
                itDisplayOrder = DisplayOrderForUpdate();

            string steventImage = string.Empty;
            if (flEventImage.HasFile)
            {
                SaveImageFile();
                steventImage = flEventImage.FileName.Trim();
            }
            if (flEventImage.HasFile && !string.IsNullOrEmpty(hiddenEventImage.Value))
            {
                SaveImageFile();
                steventImage = flEventImage.FileName.Trim();
            }
            else if (!flEventImage.HasFile && !string.IsNullOrEmpty(hiddenEventImage.Value))
            {

                steventImage = hiddenEventImage.Value.Trim();
            }
            string stpdf1 = string.Empty;
            if (flPDF1.HasFile)
            {
                Savepdf1File();
                stpdf1 = flPDF1.FileName.Trim();
            }
            if (flPDF1.HasFile && !string.IsNullOrEmpty(hlPDF1.Value))
            {
                Savepdf1File();
                stpdf1 = flPDF1.FileName.Trim();
            }
            else if (!flPDF1.HasFile && !string.IsNullOrEmpty(hlPDF1.Value))
            {

                stpdf1 = hlPDF1.Value.Trim();
            }
            
            string stdepartment = string.Empty;
            if (!string.Equals(ddlDepartment.SelectedItem.Text, "Select Department"))
                stdepartment = ddlDepartment.SelectedItem.Text.Trim();
            List<pmufaculty> lstContent = new List<pmufaculty> {
            new pmufaculty{
                Name=(!string.IsNullOrEmpty(txtName.Text))?txtName.Text.Trim():string.Empty,
                Designation=(!string.IsNullOrEmpty(txtDesignation.Text))?txtDesignation.Text.Trim():string.Empty,
                Department=stdepartment,
                DisplayOrder=Convert.ToInt32(itDisplayOrder),
                ThumbNailImage=steventImage,
                Status=status,                
                UpdatedDate=Utility.IndianTime,
                UpdatedBy=login.GetUserName(),
                PdfName=stpdf1,
                IsHod=IsHOD
              }
        };

            int UpdateContent = faculty.UpdateEvents(lstContent, ID);
            if (UpdateContent == -1)
            {

                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvHeaderTitle.Attributes["class"] = "md-input-wrapper md-input-filled";
                dvDisplayOrder.Attributes["class"] = "md-input-wrapper md-input-filled";
               
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script>alert('Successfully Updated');</script>");
                if (status)
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-success'>Active</span>";
                else
                    lblStatus.Text = "Status: <span class='uk-badge uk-badge-warning'>In Active</span>";
                // string stUrl = "<a href='/news-details.aspx?ID=" + ID + "' target='_blank'>Live Url :News</a>";
                //phLiveUrl.Controls.Add(new LiteralControl(stUrl.Trim()));
                BindFaculty(ID);
            }
        //}
        //catch (Exception ex)
        //{
        //}
    }
    public int SaveImageFile()
    {
        int savefile = 0;
        try
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["FacultyImages"];
            string temppath = filePath.Trim() + @"\" + flEventImage.FileName;
            string savepath = Server.MapPath(temppath);
            flEventImage.SaveAs(savepath);
            string strPath = flEventImage.FileName;
            savefile = 1;
        }
        catch (Exception ex)
        {
            savefile = 0;
            Response.Write(ex.ToString());
        }
        return savefile;
    }
    public int Savepdf1File()
    {
        int savefile = 0;
        try
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["Facultypdf"];
            string temppath = filePath.Trim() + @"\" + flPDF1.FileName;
            string savepath = Server.MapPath(temppath);
            flPDF1.SaveAs(savepath);
            string strPath = flPDF1.FileName;
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
        Clear();
    }
    public void Clear()
    {
        txtName.Text = "";
        txtDesignation.Text = "";
        ddlDepartment.SelectedIndex = 0;
        txtDisplayOrder.Text = SetDisplayOrder().ToString();
        flEventImage.Dispose();
        flPDF1.Dispose();
        chkIshod.Checked = false;
        chkStatus.Checked = true;
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewfaculty.aspx", true);
    }

    
}