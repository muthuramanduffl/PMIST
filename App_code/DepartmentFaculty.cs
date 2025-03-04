using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

/// <summary>
/// Summary description for LoadDepartment
/// </summary>
public class DepartmentFaculty
{
    public DepartmentFaculty()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void BindDepartment(DropDownList ddlBranch)
    {
        ddlBranch.Items.Add(new ListItem("General", "General"));
        ddlBranch.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
        ddlBranch.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
        ddlBranch.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
        ddlBranch.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));
        ddlBranch.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
        ddlBranch.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
        ddlBranch.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));

        ddlBranch.Items.Add(new ListItem("Bachelor of Computer Applications", "Bachelor of Computer Applications"));

        ddlBranch.Items.Add(new ListItem("Bachelor of Commerce", "Bachelor of Commerce"));
        ddlBranch.Items.Add(new ListItem("Honours", "Honours"));
        ddlBranch.Items.Add(new ListItem("Computer Applications", "Computer Applications"));
        ddlBranch.Items.Add(new ListItem("Corporate Secretaryship", "Corporate Secretaryship"));

        ddlBranch.Items.Add(new ListItem("Animation and Multimedia", "Animations and Multimedia"));
        ddlBranch.Items.Add(new ListItem("Artificial Intelligence", "Artificial Intelligence"));

        ddlBranch.Items.Add(new ListItem("Bachelor of Business Administration", "Bachelor of Business Administration"));

        ddlBranch.Items.Add(new ListItem("Architecture", "Architecture"));
        ddlBranch.Items.Add(new ListItem("B.Ed", "B.Ed"));

        ddlBranch.Items.Add(new ListItem("Environmental Engineering", "Environmental Engineering"));
        ddlBranch.Items.Add(new ListItem("Nano Technology", "Nano Technology"));
        ddlBranch.Items.Add(new ListItem("Renewable Energy", "Renewable Energy"));
        ddlBranch.Items.Add(new ListItem("Wireless Communications", "Wireless Communications"));
        ddlBranch.Items.Add(new ListItem("Power Electronics & Drives", "Power Electronics & Drives"));
        ddlBranch.Items.Add(new ListItem("English", "English"));
        ddlBranch.Items.Add(new ListItem("History", "History"));
        ddlBranch.Items.Add(new ListItem("Tamil", "Tamil"));
        ddlBranch.Items.Add(new ListItem("Political Science", "Political Science"));
        ddlBranch.Items.Add(new ListItem("Periyar Thought", "Periyar Thought"));

        ddlBranch.Items.Add(new ListItem("Master of Commerce", "Master of Commerce"));
        ddlBranch.Items.Add(new ListItem("Physics", "Physics"));
        ddlBranch.Items.Add(new ListItem("Chemistry", "Chemistry"));
        ddlBranch.Items.Add(new ListItem("Maths", "Maths"));
        ddlBranch.Items.Add(new ListItem("Computer Science", "Computer Science"));

        ddlBranch.Items.Add(new ListItem("Master of Social Work", "Master of Social Work"));

        ddlBranch.Items.Add(new ListItem("Master of Business Administration", "Master of Business Administration"));
        ddlBranch.Items.Add(new ListItem("Master of Computer Applications", "Master of Computer Applications"));
        ddlBranch.Items.Insert(0, new ListItem("Select", ""));
    }
}