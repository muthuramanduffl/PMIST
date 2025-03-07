

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using iTextSharp.text.pdf.codec;


public partial class centre_cengn : System.Web.UI.Page
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
            if (dt.Rows.Count > 0)
            {
                Repeater1.Visible = true;
                DataView dv = dt.DefaultView;
                dv.Sort = "AddedBy ASC, TCCID ASC";
                Repeater1.DataSource = dv.ToTable();
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.Visible = false;
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
            dt = csas.viewAllcentrecontenttype1("9", "", "");//centre type based bind ex: centre id 3 only shows
        }
        catch (Exception ex)
        {
        }
        return dt;
    }

}