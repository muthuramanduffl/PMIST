using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

public partial class courses1 : System.Web.UI.Page
{
    CMSDepartment D = new CMSDepartment();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = D.SpViewCMSDeptCoursesByDeptandSectionName(11, "ProgrammeOffered");

        if (dt.Rows.Count > 0)
        {
            rprProgramsOffered.Visible = true;
            rprProgramsOffered.DataSource = dt;
            rprProgramsOffered.DataBind();

        }
        else
        {
            rprProgramsOffered.Visible = false;
        }



        DataTable dtPo = D.SpViewCMSDeptCoursesByDeptandSectionName(11, "PO");
        if (dtPo.Rows.Count > 0)
        {
            rprPO.Visible = true;
            lblpoIntro.Text = dtPo.Rows[0]["Introduction"].ToString();
            rprPO.DataSource = dtPo;
            rprPO.DataBind();


        }
        else
        {
            rprPO.Visible = false;
        }


        DataTable dtPSO = D.SpViewCMSDeptCoursesByDeptandSectionName(11, "PSO");
        if (dtPSO.Rows.Count > 0)
        {
            lblPSOIntro.Text = dtPSO.Rows[0]["Introduction"].ToString();
            rprPSO.Visible = true;
            rprPSO.DataSource = dtPSO;
            rprPSO.DataBind();

        }
        else
        {
            rprPSO.Visible = false;
        }


        DataTable dtPEO = D.SpViewCMSDeptCoursesByDeptandSectionName(11, "PEO");
        if (dtPEO.Rows.Count > 0)
        {

            lblPEoIntro.Text = dtPEO.Rows[0]["Introduction"].ToString();
            rprPEO.Visible = true;
            rprPEO.DataSource = dtPEO;
            rprPEO.DataBind();

        }
        else
        {
            rprPEO.Visible = false;
        }


        DataTable dtCurriculum = D.SpViewCMSDeptCoursesByDeptandSectionName(11, "curriculum");
        if (dtCurriculum.Rows.Count > 0)
        {
            rprCurriculum.Visible = true;
            rprCurriculum.DataSource = dtCurriculum;
            rprCurriculum.DataBind();

            rprPDF.Visible = true;
            rprPDF.DataSource = dtCurriculum;
            rprPDF.DataBind();

        }
        else
        {
            rprCurriculum.Visible = false;
            rprPDF.Visible = false;
        }



    }

    protected void rprPDF_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "ViewPDF")
        {
            try
            {
                int ID = Convert.ToInt32(e.CommandArgument);
                DataTable dt = D.ViewDepartmentCoursesByID(ID);
                if (dt.Rows.Count > 0)
                {
                    DateTime today = DateTime.Today;
                    string filepath = System.Configuration.ConfigurationManager.AppSettings["CSMDepartmentPDF"];
                    string fullFilePath = Path.Combine(filepath.Trim(), dt.Rows[0]["PDFName"].ToString());
                    string fileUrl = "https://pmu.edu/" + fullFilePath.TrimStart('/');
                    ScriptManager.RegisterStartupScript(this, GetType(), "redirect", "window.open('" + fileUrl + "', '_blank');", true);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(
                           this.GetType(),
                           "Alert",
                           "<script type='text/javascript'>alert('Pdf file does not exist.');</script>"
                       );
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}