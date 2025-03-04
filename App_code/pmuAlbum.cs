using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

/// <summary>
/// Summary description for Album
/// </summary>
public class pmuAlbum
{
    public string AlbumName { get; set; }
    public int AlbumID { get; set; }    
    public bool Status { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public string Department { get; set; }
    public pmuAlbum()
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
    public int AddAlbum(List<pmuAlbum> LstAlbum)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstAlbum != null && LstAlbum.Count > 0)
            {
                foreach (pmuAlbum album in LstAlbum)
                {
                    using (SqlCommand command = new SqlCommand("AddAlbum", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                       
                        command.Parameters.Add(
                      new SqlParameter("@AlbumName", album.AlbumName.Trim()));
                        command.Parameters.Add(
                           new SqlParameter("@Status", album.Status));
                        command.Parameters.Add(
                       new SqlParameter("@CreatedDate", album.CreatedDateTime));
                        command.Parameters.Add(
                           new SqlParameter("@CreatedBy", album.CreatedBy));
                        command.Parameters.Add(
                           new SqlParameter("@UpdatedDate", album.UpdatedDateTime));
                        command.Parameters.Add(
                          new SqlParameter("@UpdatedBy", album.UpdatedBy));
                        command.Parameters.Add(
                          new SqlParameter("@Department", album.Department));
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
    public int UpdateAlbum(string strAlbum, int AlbumID, string UpdatedBy,bool Status,DateTime dtUpdateTime,string stDepartment)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;

        try
        {

            using (SqlCommand command = new SqlCommand("UpdateAlbum", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
               new SqlParameter("@AlbumName", strAlbum.Trim()));
                command.Parameters.Add(
                                  new SqlParameter("@AlbumId", AlbumID));
                  command.Parameters.Add(
                  new SqlParameter("@UpdatedBy", UpdatedBy.Trim()));
                command.Parameters.Add(
                  new SqlParameter("@UpdatedDate", dtUpdateTime));               
                command.Parameters.Add(
                                 new SqlParameter("@Status", Status));
                command.Parameters.Add(
                          new SqlParameter("@Department", stDepartment));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }


        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewTop3AlbumByDepartment(string stDepartment)
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewTop3AlbumByDepartment", cnn))
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
    public DataSet ViewMoreAlbumByDepartment(string stDepartment)
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMoreAlbumByDepartment", cnn))
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
    public DataSet ViewAlbumByOnlyDepartment(string stDepartment)
    {
        DataSet dsGallery = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAlbumByOnlyDepartment", cnn))
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
    public int UpdateAlbumSatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateAlbumStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@AlbumId", ID));
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
    public int DeleteAlbumByID(int AlbumID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsDetail = new DataSet();
        int rowsAffected = 0;
        try
        {
            if (AlbumID > 0)
            {

                cnn.Open();
                using (SqlCommand command = new SqlCommand("DeleteAlbum", cnn))
                {

                    // Add new SqlParameter to the command.

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@AlbumId", AlbumID));
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
    
    public DataSet ViewAlbumByName(string strAlbumName)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            if (!string.IsNullOrEmpty(strAlbumName))
            {

                using (SqlCommand command = new SqlCommand("ViewAlbumByName", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                                          new SqlParameter("@AlbumName", strAlbumName.Trim()));
                    
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dsNews);

                }

                cnn.Close();

            }
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public DataSet ViewAlbumByID(int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            if (ID>0)
            {

                using (SqlCommand command = new SqlCommand("ViewAlbumById", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                                          new SqlParameter("@AlbumId", ID));

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dsNews);

                }

                cnn.Close();

            }
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
   
    public DataSet ViewActiveAlbum()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
          
                using (SqlCommand command = new SqlCommand("ViewActiveAlbum", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
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
    public DataSet ViewAllAlbum()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllAlbum", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
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
    public DataSet VieTop3Album()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewTop3Album", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
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

    public DataSet ViewMoreAlbum()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewMoreAlbum", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
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