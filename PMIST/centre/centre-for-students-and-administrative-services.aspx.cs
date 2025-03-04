using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMIST_website_centre_centre_for_students_and_administrative_services : System.Web.UI.Page
{
   
   pmistcentrecsas csas=new pmistcentrecsas();
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
                repContact.Visible = true;
                repContact.DataSource = dt;
                repContact.DataBind();

                if (dt.Rows.Count > 0)
                {
                    string filepath = System.Configuration.ConfigurationManager.AppSettings["Centreimages"];
                    string[] imagePaths =  dt.Rows[0]["Imges"].ToString().Split(',');

                    DataTable dtImages = new DataTable();
                    dtImages.Columns.Add("Images");

                    foreach (string img in imagePaths)
                    {
                        dtImages.Rows.Add(filepath + img); // Append path to image name
                    }
                    Repimage.Visible = true;
                    Repimage.DataSource = dtImages;
                    Repimage.DataBind();
                }




                

                Repeater1.Visible = true;
                Repeater1.DataSource = dt;
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
            dt = csas.viewAllcentrecontenttype1("3","","");//centre type based bind ex: centre id 3 only shows
        }
        catch (Exception ex)
        {
        }
        return dt;
    }
}