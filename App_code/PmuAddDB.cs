using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for PmuAddDB
/// </summary>
public class PmuAddDB
{
    public int Id { get; set; }
    public string faculty { get; set; }
    public string CourseMode { get; set; }
    public string CourseType { get; set; }

    public string CourseName { get; set; }
    public string Branchname1 { get; set; }
    public PmuAddDB()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string GetSqlConnection()
    {
        string connetionString = null;
        try
        {

            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connetionString;
    }

    public DataSet ViewFacultySchoolByName(string facname)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewFacultySchoolByName", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@facname", facname));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewFacultySchool()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewFacultySchool", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }
    public DataSet ViewFacultySchoolByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewFacultySchoolByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@fID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCourseByName(string course, string flag, string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCourseByName", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@CourseName", course));
            command.Parameters.Add(new SqlParameter("@flag", flag));
            command.Parameters.Add(new SqlParameter("@ID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCourse()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCourse", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }
    public DataSet ViewCourseByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCourseByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@courseID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCourseByType(string coursetype)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCourseByType", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@coursetype", coursetype));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewBranchExist(string faculty, string Coursemode, string Coursetype, string CourseName, string branchname1, string flag, string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewBranchExist", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@faculty", faculty));
            command.Parameters.Add(new SqlParameter("@Coursemode", Coursemode));
            command.Parameters.Add(new SqlParameter("@Coursetype", Coursetype));
            command.Parameters.Add(new SqlParameter("@CourseName", CourseName));
            command.Parameters.Add(new SqlParameter("@branchname1", branchname1));
            command.Parameters.Add(new SqlParameter("@flag", flag));
            command.Parameters.Add(new SqlParameter("@ID", ID));

            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewBranchCoursesByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewBranchCoursesByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@BranchID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewBranchWithCoursename(string course, string coursemode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewBranchWithCoursename", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@coursename", course));
            command.Parameters.Add(new SqlParameter("@coursemode", coursemode));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCourseByMode(string coursemode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCourseByMode", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@CourseMode", coursemode));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }


    public DataSet ViewStateByName(string state)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewStateByName", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@State", state));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCityByName(string city, string stateID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCityByName", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@StateID", Convert.ToInt32(stateID)));
            command.Parameters.Add(new SqlParameter("@City", city));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCity()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCity", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewState()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewState", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewStateByID(string stateID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewStateByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@StateID", stateID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCityBYStateID(string stateID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCityBYStateID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@StateID", stateID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewBranchBycourseId(string courseID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewBranchBycourseId", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@courseID", courseID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCityByID(string CityID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCityByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@CityID", CityID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }
    public void BindCourse(DropDownList ddlCourse)
    {
        try
        {
            ddlCourse.Items.Clear();
            ddlCourse.Items.Insert(0, new ListItem("All", "All"));
            string stCourseID = string.Empty;
            string stCourse = string.Empty;

            DataSet dsContent = ViewCourse();
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsContent.Tables[0].Rows.Count; i++)
                {
                    stCourseID = Convert.ToString(dsContent.Tables[0].Rows[i]["CourseID"]);
                    stCourse = Convert.ToString(dsContent.Tables[0].Rows[i]["CourseName"]);
                    ddlCourse.Items.Add(new ListItem(stCourse, stCourseID));
                }

                ddlCourse.DataBind();
            }
        }
        catch (Exception ex)
        {
        }
    }

    public void BindBranch(string course, DropDownList ddlBranch)
    {
        try
        {
            ddlBranch.Items.Clear();
            ddlBranch.Items.Insert(0, new ListItem("All", "All"));
            string stBranchID = string.Empty;
            string stBranch = string.Empty;
            string stCourse = string.Empty;
            string stCourseBranch = string.Empty;
            string stcoursmode = string.Empty;

            DataSet dsContent = ViewBranchBycourseId(course);
            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsContent.Tables[0].Rows.Count; i++)
                {
                    stBranchID = Convert.ToString(dsContent.Tables[0].Rows[i]["BranchID"]);
                    stBranch = Convert.ToString(dsContent.Tables[0].Rows[i]["BranchName1"]);
                    stCourse = Convert.ToString(dsContent.Tables[0].Rows[i]["Degree"]);
                    stcoursmode = Convert.ToString(dsContent.Tables[0].Rows[i]["CourseMode"]);
                    stCourseBranch = stcoursmode + " " + stCourse + " " + stBranch;
                    ddlBranch.Items.Add(new ListItem(stCourseBranch, stBranchID));
                }

                ddlBranch.DataBind();
            }
        }
        catch (Exception ex)
        {
        }
    }
    public void BindScholarshipdrp(DropDownList ddl)
    {
        DataSet ds = ViewScholarshipdrp();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["Scholarship"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["SID"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }
    public DataSet ViewScholarshipdrp()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewScholarshipdrp", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }
        cnn.Close();
        return ds;
    }
    
    public DataSet ViewScholarshipByID(string SID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewScholarshipByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", SID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }
}