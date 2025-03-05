
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
using System.Net;
using System.Data;


public partial class academic_faq : System.Web.UI.Page
{

    pmistfaq FAQ = new pmistfaq();
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
                rprfaq.Visible = true;
                rprfaq.DataSource = dt;
                rprfaq.DataBind();
            }
            else
            {
                rprfaq.Visible = false;
            }
        }
        catch (Exception ex)
        {
        }
    }


    public DataTable Get()
    {
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        try
        {
             dt = FAQ.ViewAllFAQs("5", "1", "");
            if (dt != null && dt.Rows.Count > 0)
            {
                dv = dt.DefaultView;
                dv.Sort = "addeddate ASC";  // Sort by added date
                dt = dv.ToTable();
            }
        }
        catch (Exception ex)
        {
        }
        return dt;
    }

}