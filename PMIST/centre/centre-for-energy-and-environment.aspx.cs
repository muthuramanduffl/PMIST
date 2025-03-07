
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using iTextSharp.text.pdf.codec;


public partial class centre_cee : System.Web.UI.Page
{
    pmistcentrecsas csas = new pmistcentrecsas();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
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
                rprenvironment.Visible = true;
                DataView dv = dt.DefaultView;
                dv.Sort = "AddedDate ASC, TCCID ASC";
                rprenvironment.DataSource = dv.ToTable();
                rprenvironment.DataBind();
            }
            else
            {
                rprenvironment.Visible = false;
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
            dt = csas.viewAllcentrecontenttype1("7", "", "");//centre type based bind ex: centre id 3 only shows
        }
        catch (Exception ex)
        {
        }
        return dt;
    }

}