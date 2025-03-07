
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;


public partial class centre_skill_development : System.Web.UI.Page
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


                int count = 0;
                if (dt.Rows.Count > 0)
                {

                    string filepath = System.Configuration.ConfigurationManager.AppSettings["Centreimages"];
                    string[] imagePaths = dt.Rows[0]["Imges"].ToString().Split(',');

                    DataTable dtImages = new DataTable();
                    dtImages.Columns.Add("Images");

                    foreach (string img in imagePaths)
                    {
                        if (!string.IsNullOrEmpty(img))
                        {
                            dtImages.Rows.Add(filepath + img);

                            count++;
                        }
                        // Append path to image name
                    }

                    Repimage.Visible = true;
                    Repimage.DataSource = dtImages;
                    Repimage.DataBind();
                }
                else
                {
                    Repimage.Visible = false;
                }



                if (count == 0)
                {
                    Repimage.Visible = false;
                    Panel1.Visible = false;


                }
                else
                {
                    Panel1.Visible = true;
                }





            }
            else
            {
                rprenvironment.Visible = false;
                Repimage.Visible = false;
                Panel1.Visible = false;
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
            dt = csas.viewAllcentrecontenttype1("4", "", "");//centre type based bind ex: centre id 3 only shows
        }
        catch (Exception ex)
        {
        }
        return dt;
    }
}