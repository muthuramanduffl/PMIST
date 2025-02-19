using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMIST_Infrastructure_type_two : System.Web.UI.Page
{
    Bindddl Ddl = new Bindddl();
    pmistfaq FAQ = new pmistfaq();
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
            dt = FAQ.ViewAllFAQs("9", "1", "");
        }
        catch (Exception ex)
        {
        }
        return dt;
    }


   



}