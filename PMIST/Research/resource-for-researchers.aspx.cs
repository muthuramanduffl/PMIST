

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using System.Text.RegularExpressions;
using System.Security.Permissions;


public partial class resourceforresearchers : System.Web.UI.Page
{

    pmistresourceofresources PMROR = new pmistresourceofresources();
    protected void Page_Load(object sender, EventArgs e)
    {


        Bind(rprresource, "1");
        Bind(RPRLOA, "3");
        Bind(rpr4, "4");
        Bind(rpr5, "5");
        Bind(rpr6, "6");
        Bind(rpr7, "6");
    }


    public void Bind(Repeater repeater, string ID)
    {
        try
        {
            DataTable dt = Get(ID);
            if (dt != null && dt.Rows.Count > 0)
            {
                repeater.Visible = true;
                repeater.DataSource = dt;
                repeater.DataBind();


            }
            else
            {
                repeater.Visible = false;

            }
        }
        catch (Exception ex)
        {
        }
    }


    public DataTable Get(string ID)
    {
        DataTable dt = new DataTable();
        try
        {
            dt = PMROR.ViewAllResearchRFRFilter(ID, "1", "");//computer science id 5 only shows
        }
        catch (Exception ex)
        {
        }
        return dt;
    }




}