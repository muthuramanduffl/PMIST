

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
using System.Net;
using System.Data;


public partial class academic_researchold : System.Web.UI.Page
{

    pmistplacements PMP = new pmistplacements();
    protected void Page_Load(object sender, EventArgs e)
    {


      //  Bind();
    }


    //public void Bind()
    //{
    //    try
    //    {
    //        DataTable dt = Get();
    //        if (dt != null && dt.Rows.Count > 0)
    //        {
    //            rprresearch.Visible = true;
    //            rprresearch.DataSource = dt;
    //            rprresearch.DataBind();

            
    //        }
    //        else
    //        {
    //            rprresearch.Visible = false;
    
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //}


    public DataTable Get()
    {
        DataTable dt = new DataTable();
        try
        {
            dt = PMP.ViewAllPlacements("5", "", "", "Research");//centre type based bind ex: centre id 3 only shows
        }
        catch (Exception ex)
        {
        }
        return dt;
    }


}