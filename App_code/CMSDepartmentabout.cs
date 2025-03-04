using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

public class CMSDepartmentabout
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
    public int AddDepartmenntAbout(List<CMSDepartmentabout> D)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            foreach (var Vission in D)
            {

                using (SqlCommand command = new SqlCommand("AddDepartmentabout", cnn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@Department", Vission.Departmentid));
                    command.Parameters.Add(
                new SqlParameter("@SectionName", Vission.SectionName));
                    command.Parameters.Add(
                new SqlParameter("@Content", Vission.Content));
                    command.Parameters.Add(
                new SqlParameter("@AddedDate", Utility.IndianTime));
                    command.Parameters.Add(
                    new SqlParameter("@AddedBy", "Admin"));
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


    public int UpdateDepartmenntAbout(CMSDepartmentabout DA)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();


            using (SqlCommand command = new SqlCommand("UpdateDepartmenntAbout", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@AID", DA.DSno));
                command.Parameters.Add(
            new SqlParameter("@SectionName", DA.SectionName));
                command.Parameters.Add(
            new SqlParameter("@Content", DA.Content));
                command.Parameters.Add(
            new SqlParameter("@UpdatedDate", Utility.IndianTime));
                command.Parameters.Add(
                new SqlParameter("@UpdatedBy", "Admin"));
                rowaffected = command.ExecuteNonQuery();
            }


            cnn.Close();
        }
        catch (Exception ex)
        {

        }
        return rowaffected;

    }




    public int AddDepartmenntAboutSingle(CMSDepartmentabout D)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();


            using (SqlCommand command = new SqlCommand("AddDepartmentabout", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@Department", D.Departmentid));
                command.Parameters.Add(
            new SqlParameter("@SectionName", D.SectionName));
                command.Parameters.Add(
            new SqlParameter("@Content", D.Content));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", Utility.IndianTime));
                command.Parameters.Add(
                new SqlParameter("@AddedBy", "Admin"));
                rowaffected = command.ExecuteNonQuery();
            }
            cnn.Close();



        }
        catch (Exception ex)
        {

        }
        return rowaffected;

    }
    public DataTable viewAlltblDepartmentabout(int ID)
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
            using (SqlCommand command = new SqlCommand("SpviewAlltblDepartmentabout", cnn))
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


    public DataTable ViewCMSDeptAboutByID(int ID)
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
            using (SqlCommand command = new SqlCommand("SpViewCMSDeptAboutByID", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(
           new SqlParameter("@ID", ID));


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
    public DataTable ViewAllDepartmentAbout()
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
            using (SqlCommand command = new SqlCommand("ViewAllDepartmentAbout", cnn))
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



    //



    public int DeleteDepartmentAbout(int ID)
    {
        int rowaffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("DeleteDepartmentAbout", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@AID", ID));
                rowaffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowaffected;
    }


}