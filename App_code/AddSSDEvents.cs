
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddEvents
/// </summary>
public class AddSSDEvents
{
    public string professionalBodies { get; set; }
    public string Eventtitle { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public bool EventStatus { get; set; }
    public string DStatus { get; set; }
    public string EStatus { get; set; }
    public bool DisplayStatus { get; set; }
    public string PDFfilename { get; set; }
    public string Imagename { get; set; }
    public string Thmnailimage { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public string EVENTDAYSTYPE { get; set; }
    public string Eventid { get; set; }
    public string Searchval { get; set; }
    public string FromTime { get; set; }
    public string ToTime { get; set; }





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






    public int AddeventDetails(AddSSDEvents AE)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDADDEVENTS", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Title", AE.Eventtitle));
                command.Parameters.Add(new SqlParameter("@EventDate", AE.FromDate));
                command.Parameters.Add(new SqlParameter("@ShortDescription", AE.ShortDescription));
                command.Parameters.Add(new SqlParameter("@EventStatus", AE.EventStatus));
                command.Parameters.Add(new SqlParameter("@DisplayStatus", AE.DisplayStatus));
                command.Parameters.Add(new SqlParameter("@LongDescription", AE.LongDescription));
                command.Parameters.Add(new SqlParameter("@PDFUpload", AE.PDFfilename));
                command.Parameters.Add(new SqlParameter("@EventImage", AE.Imagename));
                command.Parameters.Add(new SqlParameter("@Thumnailimage", AE.Thmnailimage));
                command.Parameters.Add(new SqlParameter("@EVENTDAYTYPE", AE.EVENTDAYSTYPE));
                
                    command.Parameters.Add(new SqlParameter("@EVENTENDDATE", AE.ToDate));
                command.Parameters.Add(new SqlParameter("@Fromtime", AE.FromTime));
                command.Parameters.Add(new SqlParameter("@ToTime", AE.ToTime));

                command.Parameters.Add(new SqlParameter("@professionalBodies", AE.professionalBodies));
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

    public int updateeventDetails(AddSSDEvents AE)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDUPDATEEVENTS", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@EventID", AE.Eventid));
                command.Parameters.Add(new SqlParameter("@Title", AE.Eventtitle));
                command.Parameters.Add(new SqlParameter("@EventDate", AE.FromDate));
                command.Parameters.Add(new SqlParameter("@ShortDescription", AE.ShortDescription));
                command.Parameters.Add(new SqlParameter("@EventStatus", AE.EventStatus));
                command.Parameters.Add(new SqlParameter("@DisplayStatus", AE.DisplayStatus));
                command.Parameters.Add(new SqlParameter("@LongDescription", AE.LongDescription));
                command.Parameters.Add(new SqlParameter("@PDFUpload", AE.PDFfilename));
                command.Parameters.Add(new SqlParameter("@EventImage", AE.Imagename));
                command.Parameters.Add(new SqlParameter("@Thumnailimage", AE.Thmnailimage));
                command.Parameters.Add(new SqlParameter("@EVENTDAYTYPE", AE.EVENTDAYSTYPE));
                command.Parameters.Add(new SqlParameter("@EVENTENDDATE", AE.ToDate));
                command.Parameters.Add(new SqlParameter("@professionalBodies", AE.professionalBodies));
                command.Parameters.Add(new SqlParameter("@Fromtime", AE.FromTime));
                command.Parameters.Add(new SqlParameter("@ToTime", AE.ToTime));
                command.Parameters.Add(new SqlParameter("@UpdatedDate", Utility.IndianTime));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }




    public DataSet Vieweventdetailsbyid(int studentid)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDPEVENTDETAILS", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@EVENTID", studentid));
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
    public void Deleteeventdetailsbyid(int EVENTID)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDEVENTDETAILSDELETEBYID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@EVENTID", EVENTID));
                command.ExecuteReader();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
       
    } 
    
   
    
   
    public DataSet Vieweventdetails(AddSSDEvents AE)
     {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDPVIEWEVENT", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Searchval", AE.Searchval));
                if (AE.FromDate== Convert.ToDateTime("01-01-1753"))
                    command.Parameters.Add(new SqlParameter("@FromDate", ""));
                else
                    command.Parameters.Add(new SqlParameter("@FromDate", AE.FromDate));


                if(AE.ToDate == Convert.ToDateTime("01-01-1753"))
                    command.Parameters.Add(new SqlParameter("@Todate", ""));
                else
                    command.Parameters.Add(new SqlParameter("@Todate", AE.ToDate));


                if(AE.DStatus!= "Choose one")
                    command.Parameters.Add(new SqlParameter("@displaystatus", AE.DisplayStatus));
                else
                    command.Parameters.Add(new SqlParameter("@displaystatus",""));

                if(AE.EStatus!= "Choose one")
                    command.Parameters.Add(new SqlParameter("@Eventstatus", AE.EventStatus));
                else
                    command.Parameters.Add(new SqlParameter("@Eventstatus", ""));





                command.Parameters.Add(new SqlParameter("@professionalBodies", AE.professionalBodies));
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

     public DataSet view()
     {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDEventAll", cnn))
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




    public void UpdateStatusByID(int ID,bool Newstatus)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDUPDATESTATUSBYID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", ID));
                command.Parameters.Add(new SqlParameter("@STATUS", Newstatus));

                command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
       
    }


















}