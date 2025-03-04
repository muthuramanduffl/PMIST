using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class cmsadmin_account_Default : System.Web.UI.Page
{

    CMSDepartment De = new CMSDepartment();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


  
    protected void btnSave_Click(object sender, EventArgs e)
    {
       
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        ////lblDisplayText.Text = "Add Department";
        //lblmessage.Text = "";
        //Clear();
    }

    public void Clear()
    {
        //ddlFaculty.SelectedIndex = 0;
        //Txtdepartment.Text = "";
        //chkStatus.Checked = true;
    }



   
    protected void btnView_Click(object sender, EventArgs e)
    {


    }
}