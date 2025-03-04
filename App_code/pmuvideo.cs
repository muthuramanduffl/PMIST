using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
/// <summary>
/// Summary description for News
/// </summary>
public class pmuvideo
{
    public int VideoId { get; set; }
    public string VideoTitle { get; set; }
    public string VideoUrl { get; set; }
    public string VideoThumbImage { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string UpdatedBy { get; set; }
    public string Department { get; set; }
    public pmuvideo()
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
    public int AddVideo(List<pmuvideo> LstNews)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
            if (LstNews != null && LstNews.Count > 0)
            {
                foreach (pmuvideo video in LstNews)
                {
                    using (SqlCommand command = new SqlCommand("AddVideo", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                       new SqlParameter("@VideoTitle", video.VideoTitle));
                        command.Parameters.Add(
                           new SqlParameter("@VideoUrl", video.VideoUrl));
                        command.Parameters.Add(
                          new SqlParameter("@VdeoThumbImage", video.VideoThumbImage));
                        command.Parameters.Add(
                          new SqlParameter("@Status", video.Status));
                        command.Parameters.Add(
                           new SqlParameter("@CreatedBy", video.CreatedBy));
                        command.Parameters.Add(
                   new SqlParameter("@CreatedDate", video.CreatedDate));
                        command.Parameters.Add(
                          new SqlParameter("@UpdatedBy", video.UpdatedBy));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDate", video.UpdatedDate));
                        command.Parameters.Add(
                        new SqlParameter("@Department", video.Department));
                        rowsAffected = command.ExecuteNonQuery();
                         

                    }
                    cnn.Close();
                }


            }
        //}
        //catch (Exception ex)
        //{
        //}
        return rowsAffected;
    }
    public int UpdateVideo(List<pmuvideo> LstNews, int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstNews != null && LstNews.Count > 0)
            {
                foreach (pmuvideo video in LstNews)
                {
                    using (SqlCommand command = new SqlCommand("UpdateVideo", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                       new SqlParameter("@VideoTitle", video.VideoTitle));
                        command.Parameters.Add(
                           new SqlParameter("@VideoUrl", video.VideoUrl));
                        command.Parameters.Add(
                          new SqlParameter("@VdeoThumbImage", video.VideoThumbImage));
                        command.Parameters.Add(
                          new SqlParameter("@Status", video.Status));                       
                        command.Parameters.Add(
                          new SqlParameter("@UpdatedBy", video.UpdatedBy));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDate", video.UpdatedDate));
                        command.Parameters.Add(
                         new SqlParameter("@VideoId", ID));
                        command.Parameters.Add(
                        new SqlParameter("@Department", video.Department));
                        rowsAffected = command.ExecuteNonQuery();


                    }
                    cnn.Close();
                }


            }
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeleteVideo(int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsDetail = new DataSet();
        int rowsAffected = 0;
        try
        {
            if (ID > 0)
            {

                cnn.Open();
                using (SqlCommand command = new SqlCommand("DeleteVideo", cnn))
                {

                    // Add new SqlParameter to the command.

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@VideoId", ID));
                    rowsAffected = command.ExecuteNonQuery();


                }
                cnn.Close();

            }
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateVideoStatus(int ID,string updatedBy,DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateVideoStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@VideoId", ID));
                command.Parameters.Add(
                new SqlParameter("@UpdatedBy", updatedBy));
                command.Parameters.Add(
                new SqlParameter("@UpdatedDateTime", dtUpdatedDateTime));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return rowsAffected;

    }
    public DataSet ViewAllVideo()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllVideo", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;                
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet ViewActiveVideo()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveVideo", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;                
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet ViewVideoById(int ID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewVideoById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@VideoId", ID));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet ViewVideoByDepartment(string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewVideoByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Department", stDepartment));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet ViewActiveVideoByDepartment(string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveVideoByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Department", stDepartment));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
}