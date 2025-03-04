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
        if (!IsPostBack)
        {

            DataTable dt = De.ViewAllFaculty();
            if (dt.Rows.Count > 0)
            {

                ddlFaculty.DataSource = dt;
                ddlFaculty.DataTextField = "FacultyName";
                ddlFaculty.DataValueField = "FacultyID";
                ddlFaculty.DataBind();
                ddlFaculty.Items.Insert(0, new ListItem("Select Faculty", ""));
            }
            if (Request.QueryString["DepartmentID"] != null)
            {
                lblDisplayText.Text = "Edit Department";

                Bind(Convert.ToInt32(Request.QueryString["DepartmentID"]));
            }
            else
            {
                lblDisplayText.Text = "Add Department";
            }
        }
    }


    public void Bind(int id)
    {
        DataTable dt = De.ViewDepartmentByID(id);
        if (dt.Rows.Count > 0)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["FacultyID"])))
            {
                ddlFaculty.SelectedValue = Convert.ToString(dt.Rows[0]["FacultyID"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["DepartmentName"])))
            {
                Txtdepartment.Text = Convert.ToString(dt.Rows[0]["DepartmentName"]);
            }
            if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["Status"])))
            {
                string status = Convert.ToString(dt.Rows[0]["Status"]);
                if (status == "1")
                {
                    chkStatus.Checked = true;
                }
                else
                {
                    chkStatus.Checked = false;
                }
            }
        }
    }

    protected void ddlFaculty_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string labelerror = string.Empty;
        if (string.IsNullOrEmpty(ddlFaculty.SelectedValue) && string.IsNullOrEmpty(Txtdepartment.Text))
        {
            labelerror = "Fill all field";
            ddlFaculty.Focus();
        }
        else if (string.IsNullOrEmpty(ddlFaculty.SelectedValue))
        {
            labelerror = "Select faculty";
            Txtdepartment.Focus();
        }
        if (!AlreadyExist(Convert.ToInt32(ddlFaculty.SelectedValue), Txtdepartment.Text))
        {

            if (string.IsNullOrEmpty(labelerror))
            {
               
                if (Request.QueryString["DepartmentID"] == null)
                {
                    De.Facultyid = Convert.ToInt32(ddlFaculty.SelectedValue);
                    De.Department = Txtdepartment.Text;
                    if (chkStatus.Checked)
                    {
                        De.Status = "1";
                    }
                    else
                    {
                        De.Status = "0";
                    }

                    int ret = 0;
                    ret = De.AddDepartment(De);
                    if (ret == 1)
                    {
                        lblmessage.ForeColor = Color.Green;
                        lblmessage.Text = "Department Added Successfully!";
                        Clear();
                    }
                }
                else
                {

                    De.Departmentid = Convert.ToInt32(Request.QueryString["DepartmentID"]);
                    De.Facultyid = Convert.ToInt32(ddlFaculty.SelectedValue);
                    De.Department = Txtdepartment.Text;
                    if (chkStatus.Checked)
                    {
                        De.Status = "1";
                    }
                    else
                    {
                        De.Status = "0";
                    }
                    int ret = 0;
                    ret = De.UpdateDepartment(De);
                    if (ret == 1)
                    {
                        lblmessage.ForeColor = Color.Green;
                        lblmessage.Text = "Department Updated Successfully!";
                        Clear();
                    }
                }
            }
            else
            {
                lblmessage.ForeColor = Color.Red;
                lblmessage.Text = labelerror;
            }

        }
        else
        {
            lblmessage.ForeColor = Color.Red;
            lblmessage.Text = "Deparment is Already Exist";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //lblDisplayText.Text = "Add Department";
        lblmessage.Text = "";
        Clear();
    }

    public void Clear()
    {
        ddlFaculty.SelectedIndex = 0;
        Txtdepartment.Text = "";
        chkStatus.Checked = true;
    }



    public bool AlreadyExist(int ID, string name)
    {
        bool isAvail = false;
        DataTable dt = De.Viewdepartmentbyfacultyidandname(ID, name);
        if (dt.Rows.Count > 0)
        {
            isAvail = true;
        }

        return isAvail;
    }
    protected void btnView_Click(object sender, EventArgs e)
    {


    }
}