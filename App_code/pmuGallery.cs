using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;


/// <summary>
/// Summary description for Gallery
/// </summary>
public class pmuGallery
{
    public int GalleryID { get; set; }
    public string ImageUrl { get; set; }
    public int AlbumID { get; set; }
    public bool Status { get; set; }
    
    public pmuGallery()
	{
		
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

    public int AddGallery(List<pmuGallery> LstGallery)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstGallery != null && LstGallery.Count > 0)
            {
                foreach (pmuGallery gallery in LstGallery)
                {
                    using (SqlCommand command = new SqlCommand("AddGallery", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                      new SqlParameter("@AlbumId", gallery.AlbumID));
                        command.Parameters.Add(
                    new SqlParameter("@Status", gallery.Status));
                        command.Parameters.Add(
                      new SqlParameter("@GalleryImage", gallery.ImageUrl));                        
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
   
    public int UpdateGallerySatus(int ID)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateGalleryStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@GalleryId", ID));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return rowsAffected;

    }
    public DataSet ViewAllGalleryByDepartment(string stDepartment)
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllGalleryByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(
                                      new SqlParameter("@Department", stDepartment));
                da.Fill(dsGallery);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return dsGallery;
    }
    public DataSet ViewAllGalleryByDepartmentIQAC(string stDepartment)
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllGalleryByDepartmentIQAC", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(
                                      new SqlParameter("@Department", stDepartment));
                da.Fill(dsGallery);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return dsGallery;
    }
    public DataSet ViewGalleryByAlbumID(int AlbumID)
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewGalleryByAlbum", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(
                                      new SqlParameter("@AlbumID", AlbumID));                
                da.Fill(dsGallery);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return dsGallery;
    }
    public DataSet ViewTopGalleryByAlbum(int AlbumID)
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewTopGalleryByAlbum", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(
                                      new SqlParameter("@AlbumID", AlbumID));
                da.Fill(dsGallery);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return dsGallery;
    }
    
    public DataSet ViewAllGallery()
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllGallery", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);                
                da.Fill(dsGallery);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return dsGallery;
    }
    public DataSet ViewActiveGalleryByAlbumID(int AlbumID)
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveGalleryAlbum", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(
                                      new SqlParameter("@AlbumId", AlbumID));
                da.Fill(dsGallery);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return dsGallery;
    }
    public DataSet ViewAlbumByDepartment(string stDepartment,string stAlbumName)
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAlbumByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(
                                      new SqlParameter("@Department", stDepartment));
                command.Parameters.Add(
                                      new SqlParameter("@AlbumName", stAlbumName));
                da.Fill(dsGallery);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return dsGallery;
    }
    public DataSet ViewActiveAlbumByDepartment(string stDepartment)
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveAlbumByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.Parameters.Add(
                                      new SqlParameter("@Department", stDepartment));
              
                da.Fill(dsGallery);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return dsGallery;
    }
    public int DeleteGalleryByID(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteGallery", cnn))
                {

                    // Add new SqlParameter to the command.

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@GalleryId", ID));
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

    
    
}