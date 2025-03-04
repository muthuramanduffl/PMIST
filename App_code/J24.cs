using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for J24
/// </summary>
public class J24
{


    public int ID { get; set; }
    public DateTime date { get; set; }
    public string Venue { get; set; }
    public string time { get; set; }
    public string Host { get; set; }
    public string Location { get; set; }




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

    public int J24UpdateCareerCandByAdmin(string status, int sno, string scrutinisedby, string reason, string ScrutinisedStatus, string stfinalschool,
       string stfinaldept, string stfinalpos, string Remarks, DateTime date, string sttime, string stvenue, string sthost, string stlocation)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("J24UpdateCareerCandByAdmin", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@ApplicantId", sno));
                command.Parameters.Add(
                    new SqlParameter("@Status", status));
                command.Parameters.Add(
                    new SqlParameter("@Reason", reason));
                command.Parameters.Add(
                    new SqlParameter("@Scrutinisedby", scrutinisedby));
                command.Parameters.Add(
                    new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                    new SqlParameter("@Finalschool", stfinalschool));
                command.Parameters.Add(
                    new SqlParameter("@Finaldept", stfinaldept));
                command.Parameters.Add(
                    new SqlParameter("@Finalpos", stfinalpos));
                command.Parameters.Add(
                    new SqlParameter("@Remarks", Remarks));
                command.Parameters.Add(
                    new SqlParameter("@Applieddatewithperiod", date));
                command.Parameters.Add(
                    new SqlParameter("@Time", sttime));
                command.Parameters.Add(
                    new SqlParameter("@Venue", stvenue));
                command.Parameters.Add(
                    new SqlParameter("@Host", sthost));
                command.Parameters.Add(
                    new SqlParameter("@Location", stlocation));
                command.Parameters.Add(
                    new SqlParameter("@updateddate", Utility.IndianTime));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }












    public DataSet ViewDateAdminFilterDateAdminFilter(string status, string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("J24ViewstausbySearchDateAdminFilter", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                new SqlParameter("@Status", status));
                command.Parameters.Add(
                new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));

                command.Parameters.Add(
                new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
                new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
                command.Parameters.Add(
                new SqlParameter("@Category", stCategory));
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

    public int j24UPDATECANDIDATEDETAILSBYID(J24 j)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        int Rowaffected = 0;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SPJ24UPDATECANDIDATEDETAILS", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ID", j.ID));
                command.Parameters.Add(
                new SqlParameter("@TIME", j.time));
                command.Parameters.Add(
                new SqlParameter("@VENUE", j.Venue));

               // //if (string.IsNullOrEmpty(date))
               // //{
               //     command.Parameters.Add(
               //new SqlParameter("@APPLIEDDATEWITHPERIOD", DBNull.Value));
               // }
               // else
               // {
                    command.Parameters.Add(
                new SqlParameter("@APPLIEDDATEWITHPERIOD", date));

                //}
                command.Parameters.Add(
                   new SqlParameter("@location", j.Location));
                command.Parameters.Add(
                   new SqlParameter("@Updateddate", Utility.IndianTime));
                Rowaffected = command.ExecuteNonQuery();
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return Rowaffected;
    }



    public DataTable ViewCareerPersonalById(string ApplicantId)
    {
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCareerPersonalById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ApplicantId", ApplicantId));
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

    public DataTable ViewcandidatedetailsBycurrentdate()
    {
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SPJ24VIEWCURRENTUPLOADDATABYDATE", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@date", Utility.IndianTime));
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

    public DataTable Viewcurrentmonthlist()
    {
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SPJ24VIEWCURRENTMONTHLIST", cnn))
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

    public DataTable ViewPreviousmonthlist()
    {
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SPJ24VIEWPREVIOUSMONTHLIST", cnn))
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
    public DataTable Viewcurrentlyearlist()
    {
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SPJ24VIEWCURRENTYEARLIST", cnn))
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
    
    public DataTable VIEWInterviewdateCURRENTMONTHLIST()
    {
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SPJ24VIEWInterviewdateCURRENTMONTHLIST", cnn))
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

     public DataTable VIEWInterviewdatepreviousMONTHLIST()
    {
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SPJ24VIEWInterviewdatepreviousMONTHLIST", cnn))
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
     public DataTable VIEWInterviewdatePreviousYEARLIST()
    {
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SPJ24VIEWInterviewdateCurrentYEARLIST", cnn))
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


    public DataSet ViewShortListBySearchDateAdminFilter(string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string stState, string stCity, string stCategory, string stdate)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SP_VIEWCAONDIDATELISTBYDATE", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@DATE", stdate));
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                new SqlParameter("@Status", Status));
                command.Parameters.Add(
                new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));


                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
                command.Parameters.Add(
                new SqlParameter("@Category", stCategory));

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }public DataSet ViewcallofnterviewapplicantsShortListBySearchDateAdminFilter(string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string stState, string stCity, string stCategory, string stdate)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("SP_VIEWCALLFORINTERVIEWCANDIDATELISTBYDATE", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@DATE", stdate));
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                new SqlParameter("@Status", Status));
                command.Parameters.Add(
                new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));


                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
                command.Parameters.Add(
                new SqlParameter("@Category", stCategory));

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