using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
using System.Net;
using System.Data;


public partial class infrastructure : System.Web.UI.Page
{
    pmistinfrastruncture PMIF = new pmistinfrastruncture();
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
                rprinfrastructure.Visible = true;
                rprinfrastructure.DataSource = dt;
                rprinfrastructure.DataBind();
            }
            else
            {
                rprinfrastructure.Visible = false;
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
            dt = PMIF.ViewAllInfrastructure("5", "1", ""); // department ID is Computer science.
        }
        catch (Exception ex)
        {
        }
        return dt;
    }


}