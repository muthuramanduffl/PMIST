﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMIST_website_academic_Activities : System.Web.UI.Page
{
    pmistactivities PMA = new pmistactivities();
    protected void Page_Load(object sender, EventArgs e)
    {
        Bind();
    }


    public void Bind()
    {
        try
        {
            DataTable dt = Get();
            if (dt != null && dt.Rows.Count > 0)
            {
                Repeater1.Visible = true;
                Repeater1.DataSource = dt;
                Repeater1.DataBind();

                rprcontentpdf.Visible = true;
                rprcontentpdf.DataSource = dt;
                rprcontentpdf.DataBind();
            }
            else
            {
                Repeater1.Visible = false;
                rprcontentpdf.Visible = false;
            }
        }
        catch (Exception ex)
        {
        }
    }


    public DataTable Get()
    {
        DataTable dt = new DataTable();
        try
        {
            dt = PMA.ViewAllDepartmentActivities("2", "", "");//centre type based bind ex: centre id 3 only shows
        }
        catch (Exception ex)
        {
        }
        return dt;
    }



    public string bindMore(string stpdfname)
    {
        if (!string.IsNullOrEmpty(stpdfname))
        {
            string CoverImagefilePath = System.Configuration.ConfigurationManager.AppSettings["ActivitiesDoc"];
            string stpath = CoverImagefilePath + "/" + stpdfname.Trim();
            return "<a href='" + stpath + "' target='_blank' class='deptPlus'>"+ stpdfname.Trim() + "</a>"; //<img src="../assets/img/academic/activities/pdf-icon.svg" alt="img" class="img-fluid pe-2">
        }
        else
        {
            return "<a class='deptPlus'>"+ stpdfname.Trim() + "</a>";
        }
    }
}
