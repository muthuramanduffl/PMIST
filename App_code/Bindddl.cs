using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for BindDll
/// </summary>
public class Bindddl
{
    CMSDepartment De = new CMSDepartment();
    pmistcentrecsas CSAS = new pmistcentrecsas();

    public void BindDropdown(DropDownList ddl, DataTable dt, string textField, string valueField)
    {
        if (dt != null && dt.Rows.Count > 0)
        {
            ddl.DataSource = dt;
            ddl.DataTextField = textField;
            ddl.DataValueField = valueField;
            ddl.DataBind();
        }

        // Insert a default empty item at the top
        // ddl.Items.Insert(0, new ListItem("", ""));
    }


    public void GetDepartmentddl(DropDownList ddl)
    {
        DataTable facultyDt = De.ViewDepartment();
        BindDropdown(ddl, facultyDt, "DepartmentName", "DepartmentID");
    }

    public void Getcentertypeddl(DropDownList ddl)
    {
        DataTable facultyDt = CSAS.viewAllcentretype();
        BindDropdown(ddl, facultyDt, "Centrename", "centreID");
    }


}