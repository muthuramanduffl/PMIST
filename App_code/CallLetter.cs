using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

/// <summary>
/// Summary description for PMUIEIRegistration
/// </summary>
public class CallLetter
{
    public int SNo { get; set; }
    public string StudentName { get; set; }
    public string ApplicationNo { get; set; }
    public string CourseName { get; set; }
    public string DepartmentName { get; set; }
    public string CourseMode { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public string Venue { get; set; }
    public string BulkUpload { get; set; }
    public string PrescribedDate { get; set; }
    public string GraceDate{ get; set; }
    public DateTime AddedDate { get; set; }

    public CallLetter()
    {
        //
        // TODO: Add constructor logic here
        //
    }
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
   


    public DataSet ViewValidCallletterApplicationNo(string stApplicationNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidCallletterApplicationNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@ApplicationNo", stApplicationNo));

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

    public DataSet ViewCallletterApplicationDetails(string ApplicationNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCallletterApplicationDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@ApplicationNo", ApplicationNo));

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

    public int AddCallLetterDetails(CallLetter letter)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddCallLetterDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
            new SqlParameter("@ApplicationNo", letter.ApplicationNo));
                command.Parameters.Add(
            new SqlParameter("@Name", letter.StudentName));
                command.Parameters.Add(
            new SqlParameter("@CourseMode", letter.CourseMode));
                command.Parameters.Add(
            new SqlParameter("@CourseName", letter.CourseName));
                command.Parameters.Add(
            new SqlParameter("@Department", letter.DepartmentName));
                command.Parameters.Add(
            new SqlParameter("@Date", letter.Date));
                command.Parameters.Add(
            new SqlParameter("@Time", letter.Time));
                command.Parameters.Add(
            new SqlParameter("@PrescribedDate", letter.PrescribedDate));
                command.Parameters.Add(
            new SqlParameter("@GraceDate", letter.GraceDate));
                command.Parameters.Add(
            new SqlParameter("@Venue", letter.Venue));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", letter.AddedDate));
                command.Parameters.Add(
            new SqlParameter("@BulkUpload", letter.BulkUpload));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
}