using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMIST_Admin_view_faqs : System.Web.UI.Page
{
    Bindddl Ddl = new Bindddl();
    pmistcentrecsas csas = new pmistcentrecsas();
    CMSDepartment DE = new CMSDepartment();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Ddl.Getcentertypeddl(ddldepartment);
            
            ddldepartment.Items.Insert(0, new ListItem("All", ""));
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
                Repimage.DataBind();
                DivNoDataFound.Style.Add("display", "none");
                h5TotalNoCount.Style.Add("display", "block");
            }
            else
            {
                Session["Projects"] = null;
                rpruser.Visible = false;
                Repimage.Visible = false;
                lblcount.Text = "0";
                DivNoDataFound.Style.Add("display", "block");
                h5TotalNoCount.Style.Add("display", "none");
            }
        }
        catch (Exception ex)
        {
        }
    }

    public string GetCentrename(int ID)
    {
        string strCentrename = string.Empty;
        try
        {
            DataTable dt = csas.viewcentrenamesByID(Convert.ToString(ID));
            if (dt != null && dt.Rows.Count > 0)
            {
                strCentrename = dt.Rows[0]["Centrename"].ToString();
            }
        }
        catch (Exception ex)
        {

        }
        return strCentrename;
    }

    public DataTable Get()
    {
        DataTable dt = new DataTable();
        try
        {
            dt = csas.viewAllcentrecontenttype1(ddldepartment.SelectedValue, ddlstatus.SelectedValue, "");
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
                Response.Redirect("add-csas.aspx?TCCID=" + ID, false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ex)
            {
            }
        }

        if (e.CommandName == "view")
        {
            try
            {
                int ID = Convert.ToInt32(e.CommandArgument);
                Repimage.Visible = true;
                Repimage.DataSource = csas.viewAllcentrecontenttype1("", "1", Convert.ToString(ID));
                Repimage.DataBind();
                fileUploaderModal.Style.Add("display", "block");
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
                ret = csas.Deletecentrecontenttype1ByID(ID);
                if (ret == 1)
                {
                    ScriptManager.RegisterStartupScript(
                    UpdatePanel5,
                    UpdatePanel5.GetType(),
                    "alert",
                    "Swal.fire({" +
                    "  title: 'Centre details has been deleted successfully.', " +
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
                    "  title: 'Centre details has been not deleted due to a server issue.', " +
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

    protected void Repeater1_ItemCommandimage(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "ToggleUpload")
        {
        
            FileUpload fileUpload = (FileUpload)e.Item.FindControl("FileUpload1");
            PlaceHolder imageContainer = (PlaceHolder)e.Item.FindControl("imageContainer");
            HiddenField hdnImagePath = (HiddenField)e.Item.FindControl("hdnImagePath");
            Button btnToggleUpload = (Button)e.Item.FindControl("btnToggleUpload");
            LinkButton btnaddd = (LinkButton)e.Item.FindControl("btnAdd");
            string key = "FileUpload_" + e.Item.ItemIndex; // Unique Key for ViewState
            bool isUploadVisible = ViewState[key] != null ? (bool)ViewState[key] : false;

            if (isUploadVisible)
            {
                fileUpload.Visible = false;
                btnaddd.Visible = false;
                if (!string.IsNullOrEmpty(hdnImagePath.Value))
                {
                    string filepath = System.Configuration.ConfigurationManager.AppSettings["Centreimages"];
                    string[] imagePaths = hdnImagePath.Value.Split(',');
                    imageContainer.Visible = true;
                    foreach (string img in imagePaths)
                    {
                        Image imgControl = new Image
                        {
                            ImageUrl = filepath + img.Trim(),
                            CssClass = "img-thumbnail",
                            Width = 100, // Adjust as needed
                            Height = 100, // Adjust as needed
                        };
                        imageContainer.Controls.Add(imgControl);
                    }
                }
                else
                {
                    imageContainer.Visible = false;
                    btnaddd.Visible = true;
                }
            }
            else
            {

                fileUpload.Visible = true;
                imageContainer.Visible = false;
                btnToggleUpload.Visible =false;
                btnaddd.Visible = true;
            }

            // Store visibility state in ViewState
            ViewState[key] = !isUploadVisible;
        }
        if (e.CommandName == "Update")
        {
            string strfilename = string.Empty;
            int ret = 0;
          
            FileUpload fileUpload = (FileUpload)e.Item.FindControl("FileUpload1" );
            PlaceHolder imageContainer = (PlaceHolder)e.Item.FindControl("imageContainer");
            HiddenField hdnImagePath = (HiddenField)e.Item.FindControl("hdnImagePath");
            Button btnToggleUpload = (Button)e.Item.FindControl("btnToggleUpload");
            LinkButton btnaddd = (LinkButton)e.Item.FindControl("btnAdd");
            if (fileUpload.HasFile)
            {
                //HiddenField hdnsingleimage = (HiddenField)e.Item.FindControl("hdnsingleimage");
                //string imName = Path.GetFileName(hdnsingleimage.Value);
                //string[] imagePaths = hdnImagePath.Value.Split(',');
                //List<string> updatedImagePaths = imagePaths.Where(x => !x.Trim().Equals(imName, StringComparison.OrdinalIgnoreCase)).ToList();
                //hdnImagePath.Value = string.Join(",", updatedImagePaths);

                strfilename = SaveFile(fileUpload, "Centreimages", ddldepartment.SelectedValue);
            }
            else
            {

            }

            string existingImages = hdnImagePath.Value;
            if (!string.IsNullOrEmpty(strfilename)) 
            {
                if (!string.IsNullOrEmpty(existingImages))
                {
                    hdnImagePath.Value = existingImages + "," + strfilename;
                }
                else
                {
                    hdnImagePath.Value = strfilename;
                }
            }
          

            csas.intTCCID = Convert.ToInt32(e.CommandArgument);
            csas.strimages = hdnImagePath.Value;
            ret = csas.UpdateimagesByID(csas);

            if (ret == 1)
            {
                fileUpload.Visible = false;
                imageContainer.Visible = true;
                btnToggleUpload.Visible = true;
                btnaddd.Visible = false;
                if (!string.IsNullOrEmpty(hdnImagePath.Value))
                {
                    string filepath = System.Configuration.ConfigurationManager.AppSettings["Centreimages"];
                    string[] imagePaths = hdnImagePath.Value.Split(',');
                    imageContainer.Visible = true;
                    foreach (string img in imagePaths)
                    {
                        Image imgControl = new Image
                        {
                            ImageUrl = filepath + img.Trim(),
                            CssClass = "img-thumbnail",
                            Width = 100, // Adjust as needed
                            Height = 100, // Adjust as needed
                        };
                        imageContainer.Controls.Add(imgControl);
                    }
                }
                else
                {
                    imageContainer.Visible = false;
                    btnaddd.Visible = true;
                }
            }
        }
    }

    protected void OnItemDataBoundimage(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            HiddenField hdnImagePath = (HiddenField)e.Item.FindControl("hdnImagePath");
            HiddenField hdnsingleimage = (HiddenField)e.Item.FindControl("hdnsingleimage");
            FileUpload fileUpload = (FileUpload)e.Item.FindControl("FileUpload1");
            PlaceHolder imageContainer = (PlaceHolder)e.Item.FindControl("imageContainer"); // Placeholder to hold images dynamically
            LinkButton btnaddd = (LinkButton)e.Item.FindControl("btnAdd");
            if (!string.IsNullOrEmpty(hdnImagePath.Value))
            {
                btnaddd.Visible = false;
                string filepath = System.Configuration.ConfigurationManager.AppSettings["Centreimages"];
                string[] imagePaths = hdnImagePath.Value.Split(',');

                foreach (string img in imagePaths)
                {
                    hdnsingleimage.Value = img.Trim();
                    Image imgControl = new Image
                    {
                        ImageUrl = filepath + img.Trim(),

                        CssClass = "img-thumbnail",
                        Width = 100, // Adjust as needed
                        Height = 100, // Adjust as needed
                    };
                    imageContainer.Controls.Add(imgControl);
                }
            }
        }


        
    }






    public string SaveFile(FileUpload uploadedFile, string appkey, string Projectname)
    {
        int savefile = 0;
        string filename = string.Empty;
        //try
        //{
        if (uploadedFile.HasFile)
        {
            string filepath = System.Configuration.ConfigurationManager.AppSettings[appkey];
            string fileName = Path.GetFileName(uploadedFile.FileName);
            string fileExtension = Path.GetExtension(fileName);
            filename = GenerateFileName(Projectname.Trim(), fileExtension).Trim('-');
            string temppath = filepath.Trim() + @"\" + filename.Trim().Replace(" ", "");
            string savepath = Server.MapPath(temppath);
            uploadedFile.SaveAs(savepath);
            savefile = 1;
        }
        else
        {
            filename = "";
        }
        //}
        //catch (Exception ex)
        //{
        //    // CI.StoreExceptionMessage("add-floor-plan.aspx", "SaveFile", ex.Message, "Not Fixed");
        //}
        return filename.Contains(" ") ? filename.Replace(" ", "") : filename;
    }
    public string GenerateFileName(string Projectname, string fileExtension)
    {
        string randomString = GenerateRandomString(4);
        string newFileName = Projectname + randomString + fileExtension;
        return newFileName;
    }
    private string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var byteArray = new byte[length];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(byteArray);
        }
        var randomString = new char[length];
        for (int i = 0; i < length; i++)
        {
            randomString[i] = chars[byteArray[i] % chars.Length];
        }
        return new string(randomString);
    }

}