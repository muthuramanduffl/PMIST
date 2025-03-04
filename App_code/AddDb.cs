using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for AddDb
/// </summary>
public class AddDb
{
    public int Id { get; set; }
    public string faculty { get; set; }
    public string CourseMode { get; set; }
    public string CourseType { get; set; }

    public string CourseName { get; set; }
    public string Branchname1 { get; set; }
    public DateTime AddedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public AddDb()
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

            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMULead"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connetionString;
    }
    public int AddFacultySchool(string facultySchool)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        using (SqlCommand command = new SqlCommand("AddFacultySchool", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(
                new SqlParameter("@facultySchool", facultySchool));
            command.Parameters.Add(
               new SqlParameter("@addeddate", Utility.IndianTime));

            rowsAffected = command.ExecuteNonQuery();
        }
        cnn.Close();
        return rowsAffected;
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
    public int UpdateFacultySchool(string facultySchool,int FID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        using (SqlCommand command = new SqlCommand("UpdateFacultySchool", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(
                new SqlParameter("@facultySchool", facultySchool));
            command.Parameters.Add(
               new SqlParameter("@FID", FID));

            rowsAffected = command.ExecuteNonQuery();
        }
        cnn.Close();
        return rowsAffected;
    }

    public int AddCourse(AddDb add)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        using (SqlCommand command = new SqlCommand("AddCourse", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@CourseName", add.CourseName));
            command.Parameters.Add(new SqlParameter("@CourseType", add.CourseType));
            command.Parameters.Add(new SqlParameter("@AddedDate", add.AddedDate));

            rowsAffected = command.ExecuteNonQuery();
        }
        cnn.Close();
        return rowsAffected;
    }

    public int UpdateDBCourse(AddDb add)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        using (SqlCommand command = new SqlCommand("UpdateDBCourse", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@CourseName", add.CourseName));
            command.Parameters.Add(new SqlParameter("@CourseType", add.CourseType));
            command.Parameters.Add(new SqlParameter("@CourseID", add.Id));
            command.Parameters.Add(new SqlParameter("@UpdatedDate", add.UpdatedDate));

            rowsAffected = command.ExecuteNonQuery();
        }
        cnn.Close();
        return rowsAffected;
    }

    public DataSet ViewCourseByName(string course,string flag, string ID)
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

    public int AddBranchCourses(AddDb add)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        using (SqlCommand command = new SqlCommand("AddBranchCourses", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@faculty", add.faculty));
            command.Parameters.Add(new SqlParameter("@Coursemode", add.CourseMode));
            command.Parameters.Add(new SqlParameter("@Coursetype", add.CourseType));
            command.Parameters.Add(new SqlParameter("@CourseName", add.CourseName));
            command.Parameters.Add(new SqlParameter("@branchname1", add.Branchname1));
            command.Parameters.Add(new SqlParameter("@AddedDate", add.AddedDate));

            rowsAffected = command.ExecuteNonQuery();
        }
        cnn.Close();
        return rowsAffected;
    }

    public int UpdateBranchCourses(AddDb add)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        using (SqlCommand command = new SqlCommand("UpdateBranchCourses", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@faculty", add.faculty));
            command.Parameters.Add(new SqlParameter("@Coursemode", add.CourseMode));
            command.Parameters.Add(new SqlParameter("@Coursetype", add.CourseType));
            command.Parameters.Add(new SqlParameter("@CourseName", add.CourseName));
            command.Parameters.Add(new SqlParameter("@branchname1", add.Branchname1));
            command.Parameters.Add(new SqlParameter("@BranchID", add.Id));
            command.Parameters.Add(new SqlParameter("@UpdatedDate", add.UpdatedDate));

            rowsAffected = command.ExecuteNonQuery();
        }
        cnn.Close();
        return rowsAffected;
    }
    
    public DataSet ViewBranchCourses()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewBranchCourses", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
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

    public DataSet ViewBranchWithCoursename(string course,string coursemode)
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

    public int AddState(string  state)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        using (SqlCommand command = new SqlCommand("AddState", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@State", state));
            command.Parameters.Add(new SqlParameter("@AddedDate", Utility.IndianTime));

            rowsAffected = command.ExecuteNonQuery();
        }
        cnn.Close();
        return rowsAffected;
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

    public int AddCity(string StateID,string City)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        using (SqlCommand command = new SqlCommand("AddCity", cnn))
        {
            cnn.Open();

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@StateID", Convert.ToInt32(StateID)));
            command.Parameters.Add(new SqlParameter("@City", City));
            command.Parameters.Add(new SqlParameter("@AddedDate", Utility.IndianTime));

            rowsAffected = command.ExecuteNonQuery();
        }
        cnn.Close();
        return rowsAffected;
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
    public DataSet ViewCourseNameByModeType(string coursetype, string coursemode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCourseNameByModeType", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@coursetype", coursetype));
                command.Parameters.Add(new SqlParameter("@coursemode", coursemode));

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dsNews);

            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    
}