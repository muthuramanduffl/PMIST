using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

public class CMSDepartment
{


    public int DSno { get; set; }
    public int Departmentid { get; set; }
    public int Facultyid { get; set; }
    public string Department { get; set; }
    public string Status { get; set; }
    public string SectionName { get; set; }
    public string Content { get; set; }
    public string Introduction { get; set; }
    public string curriculum { get; set; }
    public string PDFFilename { get; set; }




    #region GetSqlConnectionstring
    public string GetSqlConnection()
    {
        string connectionString = null;
        try
        {

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connectionString;
    }
    #endregion



    public int AddDepartment(CMSDepartment D)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("AddCMSDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@FacultyID", D.Facultyid));
                command.Parameters.Add(
            new SqlParameter("@DepartmentName", D.Department));
                command.Parameters.Add(
            new SqlParameter("@Status", D.Status));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", Utility.IndianTime));
                rowaffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return rowaffected;
    }
    public int UpdateDepartment(CMSDepartment D)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("UpdateCMSDepartment", cnn))
            {



                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@DepartmentID", D.Facultyid));
                command.Parameters.Add(
            new SqlParameter("@FacultyID", D.Facultyid));
                command.Parameters.Add(
            new SqlParameter("@DepartmentName", D.Department));
                command.Parameters.Add(
            new SqlParameter("@Status", D.Status));
                command.Parameters.Add(
            new SqlParameter("@UpdatedDAte", Utility.IndianTime));
                rowaffected = command.ExecuteNonQuery();




            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return rowaffected;
    }




    public int UpdateCMSDepartmentCourses(CMSDepartment D)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("UpdateCMSDEpartmentCourses", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@Sno", D.DSno));
                command.Parameters.Add(
            new SqlParameter("@Introduction", D.Introduction));
                command.Parameters.Add(
            new SqlParameter("@Content", D.Content));
                command.Parameters.Add(

            new SqlParameter("@Updateddate", Utility.IndianTime));
                rowaffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return rowaffected;
    }


    public int UpdateCMSDepartmentCoursesWithcurriculum(CMSDepartment D)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("UpdateCMSDEpartmentCoursesWithcurriculum", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@Sno", D.DSno));
                command.Parameters.Add(
            new SqlParameter("@PDFName", D.PDFFilename));
                command.Parameters.Add(
            new SqlParameter("@Content", D.Content));
                command.Parameters.Add(

            new SqlParameter("@Updateddate", Utility.IndianTime));
                rowaffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return rowaffected;
    }

    public void UpdateDepartmentStatus(int ID, string status)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("UpdateStatusCMSDepartment", cnn))
            {



                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@DepartmentID", ID));
                command.Parameters.Add(
            new SqlParameter("@Status", status));

                rowaffected = command.ExecuteNonQuery();




            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }


    }


    public void DeleteDepartmentCoursesbyID(int ID)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("DeleteCMSDepartmentCoursesBySno", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@Sno", ID));
                rowaffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }


    }
    public int AddProgrammedoffered(List<CMSDepartment> D)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            foreach (var programme in D)
            {
                using (SqlCommand command = new SqlCommand("AddCMSCoursesProgrammedoffered", cnn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@DeptID", programme.Departmentid));
                    command.Parameters.Add(
                new SqlParameter("@Sectionname", programme.SectionName));
                    command.Parameters.Add(
                new SqlParameter("@Content", programme.Content));
                    command.Parameters.Add(
                new SqlParameter("@Addeddate", Utility.IndianTime));

                    rowaffected += command.ExecuteNonQuery();


                }

            }

            if (rowaffected == Convert.ToInt32(D.Count))
            {
                rowaffected = 1;
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return rowaffected;
    }


    public int AddPO(List<CMSDepartment> D)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            foreach (var PO in D)
            {
                using (SqlCommand command = new SqlCommand("AddCMSCoursesPo", cnn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@DeptID", PO.Departmentid));
                    command.Parameters.Add(
                new SqlParameter("@Sectionname", PO.SectionName));
                    command.Parameters.Add(
                new SqlParameter("@Content", PO.Content));
                    command.Parameters.Add(
                new SqlParameter("@Introduction", PO.Introduction));
                    command.Parameters.Add(
                new SqlParameter("@Addeddate", Utility.IndianTime));
                    rowaffected += command.ExecuteNonQuery();


                }

            }
            if (rowaffected == Convert.ToInt32(D.Count))
            {
                rowaffected = 1;
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }
        return rowaffected;

    }


    public int Addcurriculum(List<CMSDepartment> D)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            foreach (var PO in D)
            {
                using (SqlCommand command = new SqlCommand("AddCMSCoursesPDF", cnn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@DeptID", PO.Departmentid));
                    command.Parameters.Add(
                new SqlParameter("@Sectionname", PO.SectionName));
                    command.Parameters.Add(
                new SqlParameter("@Content", PO.Content));
                    command.Parameters.Add(
                new SqlParameter("@PDFName", PO.PDFFilename));
                    command.Parameters.Add(
                new SqlParameter("@Addeddate", Utility.IndianTime));

                    rowaffected += command.ExecuteNonQuery();


                }

            }

            if (rowaffected == Convert.ToInt32(D.Count))
            {
                rowaffected = 1;
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }
        return rowaffected;
    }


    public DataTable ViewDepartmentByID(int ID)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataTable dt = new DataTable();
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCMSDepartmentByID", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@DepartmentID", ID));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return dt;
    }



    public DataTable ViewDepartmentCoursesByID(int ID)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataTable dt = new DataTable();
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SpViewCMSDeptCoursesByID", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("ID", ID));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return dt;
    }
    public DataTable ViewDepartment()
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataTable dt = new DataTable();
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllCMSDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return dt;
    }



    public DataTable ViewDepartmentCourses(int ID)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataTable dt = new DataTable();
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SpviewAllCMSDeptCourses", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                if (ID == 0)
                {
                    command.Parameters.Add(
               new SqlParameter("@Department", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(
               new SqlParameter("@Department", ID));
                }

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return dt;
    }


    public DataTable SpViewCMSDeptCoursesByDeptandSectionName(int Dept, string SectionName)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataTable dt = new DataTable();
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SpViewCMSDeptCoursesByDeptandSectionName", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
           new SqlParameter("@Dept", Dept));
                command.Parameters.Add(
               new SqlParameter("@SectionName", SectionName));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return dt;
    }




    public DataTable Viewdepartmentbyfacultyidandname(int ID, string name)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataTable dt = new DataTable();
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("CMSAlreadyExistDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@FacultyID", ID));
                command.Parameters.Add(
                new SqlParameter("@DepartmentName", name));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return dt;
    }

    public DataTable ViewAllFaculty()
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataTable dt = new DataTable();
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllCMSFaculty", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }

        return dt;
    }

}