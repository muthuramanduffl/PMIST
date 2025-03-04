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
public class LoadDepartment
{
    public LoadDepartment()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void BindCourse(DropDownList ddlcourse)
    {
        ddlcourse.Items.Add(new ListItem("General", "General"));
        ddlcourse.Items.Add(new ListItem("B.Tech", "B.Tech"));
        ddlcourse.Items.Add(new ListItem("BCA", "BCA"));
        ddlcourse.Items.Add(new ListItem("BBA", "BBA"));
        ddlcourse.Items.Add(new ListItem("B.Com", "B.Com"));
        

        ddlcourse.Items.Add(new ListItem("B.Sc", "B.Sc"));
        ddlcourse.Items.Add(new ListItem("B.Arch", "B.Arch"));
        ddlcourse.Items.Add(new ListItem("B.Ed", "B.Ed"));
        ddlcourse.Items.Add(new ListItem("B.Sc B.Ed", "B.Sc B.Ed"));

        ddlcourse.Items.Add(new ListItem("B.A", "B.A"));
        ddlcourse.Items.Add(new ListItem("M.Arch", "M.Arch"));
        ddlcourse.Items.Add(new ListItem("M.Tech", "M.Tech"));
        ddlcourse.Items.Add(new ListItem("M.A", "M.A"));

        ddlcourse.Items.Add(new ListItem("M.Sc", "M.Sc"));
        ddlcourse.Items.Add(new ListItem("M.Com", "M.Com"));
        ddlcourse.Items.Add(new ListItem("MBA", "MBA"));
        ddlcourse.Items.Add(new ListItem("MSW", "MSW"));
        ddlcourse.Items.Add(new ListItem("MCA", "MCA"));
    }

    public void BindBranch(string strCourseName,DropDownList ddlBranch)
    {
        ddlBranch.Enabled = true;
        ddlBranch.Items.Clear();

        //if (strCourseName.Equals("B.Tech"))
        //{
        //    ddlBranch.Items.Clear();

        //    ddlBranch.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
        //    ddlBranch.Items.Add(new ListItem("Aerospace Engineering with specialization in Unmanned Aerial Vehicle", "Aerospace Engineering with specialization in Unmanned Aerial Vehicle"));
        //    ddlBranch.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
        //    ddlBranch.Items.Add(new ListItem("Biotechnology with specialization in Computer Science and Biology", "Biotechnology with specialization in Computer Science and Biology"));
        //    ddlBranch.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
        //    ddlBranch.Items.Add(new ListItem("Civil Engineering with specialization in GIS and Remote Sensing", "Civil Engineering with specialization in GIS and Remote Sensing"));
        //    ddlBranch.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));
        //    ddlBranch.Items.Add(new ListItem("CSE with specialization in AI and ML", "CSE with specialization in AI and ML"));
        //    ddlBranch.Items.Add(new ListItem("CSE with specialization in Data Science", "CSE with specialization in Data Science"));
        //    ddlBranch.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
        //    ddlBranch.Items.Add(new ListItem("EEE with specialization in Electric Vehicles", "EEE with specialization in Electric Vehicles"));
        //    ddlBranch.Items.Add(new ListItem("EEE with specialization in Energy Engineering", "EEE with specialization in Energy Engineering"));
        //    ddlBranch.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
        //    ddlBranch.Items.Add(new ListItem("ECE with specialization in AI and ML", "ECE with specialization in AI and ML"));
        //    ddlBranch.Items.Add(new ListItem("ECE with specialization in Robotics and Industrial Automation", "ECE with specialization in Robotics and Industrial Automation"));
        //    ddlBranch.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));
        //    ddlBranch.Items.Add(new ListItem("Mechanical Engineering with specialization in Robotics and Industrial Automation", "Mechanical Engineering with specialization in Robotics and Industrial Automation"));
        //    ddlBranch.Items.Add(new ListItem("Mechanical Engineering with specialization in Energy Engineering", "Mechanical Engineering with specialization in Energy Engineering"));

        //    ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        //}

        if (strCourseName.Equals("B.Tech"))
        {
            ddlBranch.Items.Clear();

            ddlBranch.Items.Add(new ListItem("Aerospace Engineering", "Aerospace Engineering"));
            ddlBranch.Items.Add(new ListItem("Bio-Technology", "Bio-Technology"));
            ddlBranch.Items.Add(new ListItem("Civil Engineering", "Civil Engineering"));
            ddlBranch.Items.Add(new ListItem("Computer Science and Engineering", "Computer Science and Engineering"));
            ddlBranch.Items.Add(new ListItem("Electrical and Electronics Engineering", "Electrical and Electronics Engineering"));
            ddlBranch.Items.Add(new ListItem("Electronics and Communication Engineering", "Electronics and Communication Engineering"));
            ddlBranch.Items.Add(new ListItem("Mechanical Engineering", "Mechanical Engineering"));

            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }


else if (strCourseName.Equals("General"))
        {
            ddlBranch.Items.Add(new ListItem("General", "General"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));

        }

        else if (strCourseName.Equals("BCA"))
        {
            ddlBranch.Items.Add(new ListItem("Bachelor of Computer Applications", "Bachelor of Computer Applications"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));

        }

        else if (strCourseName.Equals("B.Com"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("Bachelor of Commerce", "Bachelor of Commerce"));
            ddlBranch.Items.Add(new ListItem("Honours", "Honours"));
            ddlBranch.Items.Add(new ListItem("Computer Applications", "Computer Applications"));
            ddlBranch.Items.Add(new ListItem("Corporate Secretaryship", "Corporate Secretaryship"));

            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("B.Sc"))
        {
            ddlBranch.Items.Clear();

            ddlBranch.Items.Add(new ListItem("Animation and Multimedia", "Animations and Multimedia"));
            ddlBranch.Items.Add(new ListItem("Physics", "Physics"));
            ddlBranch.Items.Add(new ListItem("Chemistry", "Chemistry"));
            ddlBranch.Items.Add(new ListItem("Maths", "Maths"));
            ddlBranch.Items.Add(new ListItem("Computer Science", "Computer Science"));
            ddlBranch.Items.Add(new ListItem("Artificial Intelligence", "Artificial Intelligence"));

            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("BBA"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("Bachelor of Business Administration", "Bachelor of Business Administration"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("B.Arch"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("Architecture", "Architecture"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("B.Ed"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("B.Ed", "B.Ed"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("B.Sc B.Ed"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Insert(0, new ListItem("B.Sc B.Ed", "B.Sc B.Ed"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("B.A"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Insert(0, new ListItem("English", "English"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("M.Tech"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("Environmental Engineering", "Environmental Engineering"));
            ddlBranch.Items.Add(new ListItem("Nano Technology", "Nano Technology"));
            ddlBranch.Items.Add(new ListItem("Renewable Energy", "Renewable Energy"));
            ddlBranch.Items.Add(new ListItem("Wireless Communications", "Wireless Communications"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("M.Tech"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("Power Electronics & Drives", "Power Electronics & Drives"));
            ddlBranch.Items.Add(new ListItem("Renewable Energy", "Renewable Energy"));
            ddlBranch.Items.Add(new ListItem("Wireless Communications", "Wireless Communications"));
            ddlBranch.Items.Add(new ListItem("Environmental Engineering", "Environmental Engineering"));
            ddlBranch.Items.Add(new ListItem("Nano Technology", "Nano Technology"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("M.A"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("English", "English"));
            ddlBranch.Items.Add(new ListItem("History", "History"));
            ddlBranch.Items.Add(new ListItem("Tamil", "Tamil"));
            ddlBranch.Items.Add(new ListItem("Political Science", "Political Science"));
            ddlBranch.Items.Add(new ListItem("Periyar Thought", "Periyar Thought"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("M.Arch"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("Architecture", "Architecture"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));

        }
        else if (strCourseName.Equals("M.Com"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Insert(0, new ListItem("Master of Commerce", "Master of Commerce"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }
        else if (strCourseName.Equals("M.Sc"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("Physics", "Physics"));
            ddlBranch.Items.Add(new ListItem("Chemistry", "Chemistry"));
            ddlBranch.Items.Add(new ListItem("Maths", "Maths"));
            ddlBranch.Items.Add(new ListItem("Computer Science", "Computer Science"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("MSW"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("Master of Social Work", "Master of Social Work"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("MBA"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("Master of Business Administration", "Master of Business Administration"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }

        else if (strCourseName.Equals("MCA"))
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Add(new ListItem("Master of Computer Applications", "Master of Computer Applications"));
            ddlBranch.Items.Insert(0, new ListItem("Select", "0"));
        }
    }
}