using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.IdentityModel.Protocols.WSTrust;

/// <summary>
/// Summary description for Addalbum
/// </summary>
public class AddSSDalbum
{

    public string Title { get; set; }
    public string ClubsandProfessional { get; set; }
    public string videolink { get; set; }
    public string image { get; set; }

    public bool status { get; set; }
    public bool imagestatus { get; set; }
    public string Albuminagename { get; set; }
    public bool Albumstatus { get; set; }
    public int Sno { get; set; }







    #region GetSqlConnectionstring
    public string GetSqlConnection()
    {
        string connectionString = null;
        try
        {

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMUSSD"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connectionString;
    }
    #endregion



    public int Addalbumimagedetails(AddSSDalbum AD)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDADDALBUMDETAILS", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Title", AD.Title));
                command.Parameters.Add(new SqlParameter("@ClupsandProfessionals", AD.ClubsandProfessional));
               
                command.Parameters.Add(new SqlParameter("@AddedDate", Utility.IndianTime));
                command.Parameters.Add(new SqlParameter("@Status", AD.status));
                SqlParameter outputParam = new SqlParameter("@Sno", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputParam);
                rowsAffected = command.ExecuteNonQuery();
                Sno = (int)command.Parameters["@Sno"].Value;
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return Sno;
    }
    public int Addalbumimage(AddSSDalbum AD)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDADDALBUMIMAGES", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Titile", AD.Sno));
                command.Parameters.Add(new SqlParameter("@Albuminagename", AD.Albuminagename));
                command.Parameters.Add(new SqlParameter("@Status", AD.status));
                command.Parameters.Add(new SqlParameter("@Albumstatus", AD.Albumstatus));
                command.Parameters.Add(new SqlParameter("@AddedDate", Utility.IndianTime));

                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int Updatealbumimage(AddSSDalbum AD)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDUPDATEALBUM", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@SNO", AD.Sno));
                command.Parameters.Add(new SqlParameter("@TITLE", AD.Title));
                command.Parameters.Add(new SqlParameter("@ClupsandProfessionals", AD.ClubsandProfessional));             
                command.Parameters.Add(new SqlParameter("@status", AD.status));
                command.Parameters.Add(new SqlParameter("@Updatedate", Utility.IndianTime));

                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public DataSet Viewalbumdetailsbyid(int albumid)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDVIEWALBUMDETAILSBYID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                if (albumid != 0)
                    command.Parameters.Add(new SqlParameter("@ID", albumid));
                else
                    command.Parameters.Add(new SqlParameter("@ID", DBNull.Value));


                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    } public DataSet Viewalbumcount(int albumid)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDVIEWALBUMIMAGEcountBYID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                
                    command.Parameters.Add(new SqlParameter("@ID", albumid));
             


                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet Viewalbumimagesbyid(int albumid)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDVIEWALBUMIMAGES", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                if (albumid != 0)
                    command.Parameters.Add(new SqlParameter("@SNO", albumid));
                else
                    command.Parameters.Add(new SqlParameter("@SNO", DBNull.Value));


                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }public DataSet View(int albumid)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDVIEWALBUMDETAILS", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
              
                    command.Parameters.Add(new SqlParameter("@SNO", albumid));
            


                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }


    public DataSet Viewimagesbyid(int albumid)
     {


        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDVIEWALBUMIMAGEBYID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
              
                    command.Parameters.Add(new SqlParameter("@ID", albumid));
               


                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    } public DataSet Viewimages()
     {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDVIEWGALLERY", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {

        }
        return ds;
    }
    public DataSet Updatealbumdetailsbyid(int albumid, bool Status)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDUPDATEALBUMDetailsSTATUSBYID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", albumid));
                command.Parameters.Add(new SqlParameter("@status", Status));
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet UpdatealbumIMAGESbyid(int albumid, bool Status)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDUPDATEALBUMIMAGESTATUS", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", albumid));
                command.Parameters.Add(new SqlParameter("@STATUS", Status));
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }public void Updatebyid(int albumid, bool Status,bool Albumimages)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDUPDATEALBUMIMAGEALBUMSTATUS", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", albumid));
                command.Parameters.Add(new SqlParameter("@Albumimagestatus", Albumimages));
                command.Parameters.Add(new SqlParameter("@STATUS", Status));
                command.ExecuteNonQuery();
              

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
     
    }


    public void DeleteAlbumdetailsbyid(int Sno)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDDELETEALBUMDETAILSBYID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", Sno));
                command.ExecuteReader();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }

    }
     public void DeleteImagesbyid(int Sno)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDDELETEBYID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", Sno));
                command.ExecuteReader();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }

    }



}