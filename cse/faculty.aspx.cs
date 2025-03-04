using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class department_of_architecture_new_faculty : System.Web.UI.Page
{
    pmufaculty faculty = new pmufaculty();
    protected void Page_Load(object sender, EventArgs e)
    {
        BindHeadofDepartment();
        BindFaculty();
    }
    public void BindHeadofDepartment()
    {
        DataSet ds = faculty.ViewHODFacultyByDepartment("Department of Computer Science and Engineering");
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            dvfaculty1.Attributes.Add("style", "display:block");
            dvfaculty.Attributes.Add("style", "display:none");
            lblName.Text = Convert.ToString(ds.Tables[0].Rows[0]["Name"]);
            lblDesignation.Text = Convert.ToString(ds.Tables[0].Rows[0]["Designation"]);
            if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["ThumbNailImage"])))
            {
                string imgfile = Convert.ToString(ds.Tables[0].Rows[0]["ThumbNailImage"]);
                string CoverImagefilePath = System.Configuration.ConfigurationManager.AppSettings["FacultyImages"];
                string stpath = CoverImagefilePath + "/" + imgfile.Trim();
                phImage.Controls.Add(new LiteralControl(" <img src='" + stpath + "' class='staffProfileImage'>"));

            }
            if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["PdfName"])))
            {
                string PdfName = Convert.ToString(ds.Tables[0].Rows[0]["PdfName"]);
                string FacultypdffilePath = System.Configuration.ConfigurationManager.AppSettings["Facultypdf"];
                string stpath = FacultypdffilePath + "/" + PdfName.Trim();
                phMore.Controls.Add(new LiteralControl("<a href='" + stpath + "' target='_blank' class='deptPlus'>+</a>"));

            }
            else
            {
                phMore.Controls.Add(new LiteralControl("<a class='deptPlus'>+</a>"));
            }
        }
        else
        {
            dvfaculty.Attributes.Add("style", "display:block");
            dvfaculty1.Attributes.Add("style", "display:none");

        }
    }

    public void BindFaculty()
    {
        DataSet ds = faculty.ViewActiveFacultyByDepartment("Department of Computer Science and Engineering");
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            dvfaculty1.Attributes.Add("style", "display:block");
            dvfaculty.Attributes.Add("style", "display:none");
            rprfaculty.Visible = true;
            rprfaculty.DataSource = ds.Tables[0];
            rprfaculty.DataBind();
        }
        else
        {
            dvfaculty1.Attributes.Add("style", "display:none");
            dvfaculty.Attributes.Add("style", "display:block");
            rprfaculty.Visible = false;

        }
    }
    public string bindImageUrl(string stThumbNailImage)
    {
        string CoverImagefilePath = System.Configuration.ConfigurationManager.AppSettings["FacultyImages"];
        string stpath = CoverImagefilePath + "/" + stThumbNailImage.Trim();
        return stpath;
    }
    public string bindMore(string stpdfname)
    {
        if (!string.IsNullOrEmpty(stpdfname))
        {
            string CoverImagefilePath = System.Configuration.ConfigurationManager.AppSettings["Facultypdf"];
            string stpath = CoverImagefilePath + "/" + stpdfname.Trim();
            return "<a href='" + stpath + "' target='_blank' class='deptPlus'>+</a>";
        }
        else
        {
            return "<a class='deptPlus'>+</a>";
        }
    }
}