using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for seatmgmt
/// </summary>
public class transportmgmt
{
    public string Sno { get; set; }
    public int snoo {get; set; }
    public string BusID { get; set; }
    public string BusName { get; set; }
    public string RouteName { get; set; }
    public string BusNo { get; set; }
    public string SeatCapacity { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDate { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string Stoppingname { get; set; }
    public string timing { get; set; }
    public string StudentName { get; set; }
    public string StudentID { get; set; }
    public string Email { get; set; }
    public string MobileNo { get; set; }
    public string Course { get; set; }
    public string Branch { get; set; }
    public string studyingYear { get; set; }
    public string FeesStatus { get; set; }
    public string SeatStatus { get; set; }
    public DateTime? AllotedDate { get; set; }
    public string BusSerialNo { get; set; }
    public string Bulkupload { get; set; }
    public string StopSNo { get; set; }
    public string BalanceAmount { get; set; }
    

    public transportmgmt()
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

    public DataSet ViewBusNo(string strbusno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewBusNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@BusNo", strbusno));
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

    public int AddBusRoute(transportmgmt trans)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddBusRoute", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@BusID", trans.BusID));
                command.Parameters.Add(
            new SqlParameter("@BusName", trans.BusName));
             command.Parameters.Add(
            new SqlParameter("@RouteName", trans.RouteName));
                command.Parameters.Add(
            new SqlParameter("@BusNo", trans.BusNo));
                command.Parameters.Add(
            new SqlParameter("@SeatCapacity", Convert.ToInt32(trans.SeatCapacity)));
                command.Parameters.Add(
            new SqlParameter("@AddedBy", trans.AddedBy));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", trans.AddedDate));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    
    public DataSet ViewBusRoutes()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewBusRoutes", cnn))
            {
                cnn.Open();
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
    
    public DataSet ViewBusRouteSearchCriteria(string stBusName)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewBusRouteSearchCriteria", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@BusName", stBusName));
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

    public DataSet ViewBusByID(string stSno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewBusByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Sno", stSno));
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

    public int AddStopping(transportmgmt trans)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddStopping", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@BusSerialNo", trans.Sno));
                command.Parameters.Add(
           new SqlParameter("@Stoppingname", trans.Stoppingname));
                command.Parameters.Add(
           new SqlParameter("@timing", trans.timing));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", Utility.IndianTime));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewStoppingExist(string ststopname, string stSno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStoppingExist", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@stopname", ststopname));
                command.Parameters.Add(
               new SqlParameter("@BusSerialNo", stSno));
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

    public DataSet ViewStoppingBySerialNo(string stSno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStoppingBySerialNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@BusSerialNo", stSno));
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
    public DataSet ViewBusName(string stSno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewBusName", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@SNo", stSno));
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
    
    public DataSet ViewRouteById(string stSno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRouteById", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@SNo", stSno));
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
    
    public int UpdateRouteById(transportmgmt trans)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        
         int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateRouteById", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(
                    new SqlParameter("@BusName", trans.BusName));
                command.Parameters.Add(
                    new SqlParameter("@BusNo", trans.BusNo));
                command.Parameters.Add(
                    new SqlParameter("@SeatCapacity", trans.SeatCapacity));
                command.Parameters.Add(
                    new SqlParameter("@RouteName", trans.RouteName));
                command.Parameters.Add(
                new SqlParameter("@SNo", trans.snoo));
               rowsAffected = command.ExecuteNonQuery();
           
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public int DeleteStopping(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteStopping", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@Sno", Sno));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int UpdateStopping(string stoppingname, string timing,string sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateStopping", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(
                    new SqlParameter("@StoppingName", stoppingname));
                command.Parameters.Add(
                    new SqlParameter("@timing", timing));
                command.Parameters.Add(
                    new SqlParameter("@Sno", sno));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int AddTransStudentDetailsnew(transportmgmt trans)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddTransStudentDetailsnew", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@StudentName", trans.StudentName));
                command.Parameters.Add(
            new SqlParameter("@StudentID", trans.StudentID));
                command.Parameters.Add(
            new SqlParameter("@Email", trans.Email));
                command.Parameters.Add(
            new SqlParameter("@MobileNo", trans.MobileNo));
                command.Parameters.Add(
            new SqlParameter("@Course", trans.Course));
                command.Parameters.Add(
            new SqlParameter("@Branch", trans.Branch));
                command.Parameters.Add(
            new SqlParameter("@studyingYear", trans.studyingYear));
                command.Parameters.Add(
            new SqlParameter("@FeesStatus", trans.FeesStatus));
                command.Parameters.Add(
            new SqlParameter("@BusSerialNo", trans.BusSerialNo));
                command.Parameters.Add(
            new SqlParameter("@SeatStatus", trans.SeatStatus));
                command.Parameters.Add(
            new SqlParameter("@AllotedDate", trans.AllotedDate));
                command.Parameters.Add(
            new SqlParameter("@AddedBy", trans.AddedBy));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", trans.AddedDate));
                command.Parameters.Add(
           new SqlParameter("@Bulkupload", trans.Bulkupload));
                command.Parameters.Add(
           new SqlParameter("@StopSNo", trans.StopSNo));
        //        command.Parameters.Add(
        //    new SqlParameter("@BalanceAmount", trans.BalanceAmount));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddTransStudentDetails(transportmgmt trans)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddTransStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@StudentName", trans.StudentName));
                command.Parameters.Add(
            new SqlParameter("@StudentID", trans.StudentID));
                command.Parameters.Add(
            new SqlParameter("@Email", trans.Email));
                command.Parameters.Add(
            new SqlParameter("@MobileNo", trans.MobileNo));
                command.Parameters.Add(
            new SqlParameter("@Course", trans.Course));
                command.Parameters.Add(
            new SqlParameter("@Branch", trans.Branch));
                command.Parameters.Add(
            new SqlParameter("@studyingYear", trans.studyingYear));
                command.Parameters.Add(
            new SqlParameter("@FeesStatus", trans.FeesStatus));
                command.Parameters.Add(
            new SqlParameter("@BusSerialNo", trans.BusSerialNo));
                command.Parameters.Add(
            new SqlParameter("@SeatStatus", trans.SeatStatus));
                command.Parameters.Add(
            new SqlParameter("@AllotedDate", trans.AllotedDate));
                command.Parameters.Add(
            new SqlParameter("@AddedBy", trans.AddedBy));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", trans.AddedDate));
                command.Parameters.Add(
           new SqlParameter("@Bulkupload", trans.Bulkupload));
                command.Parameters.Add(
           new SqlParameter("@StopSNo", trans.StopSNo));
               command.Parameters.Add(
           new SqlParameter("@BalanceAmount", trans.BalanceAmount));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewByStudID(string stStudID,string strmode, string sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewByStudID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@StudID", stStudID));
                command.Parameters.Add(
                  new SqlParameter("@flag", strmode));
                command.Parameters.Add(
                   new SqlParameter("@sno", Convert.ToInt32(sno)));
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
    
    public int UpdateBusSeatVacancy(int vacancy,string sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateBusSeatVacancy", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(
                    new SqlParameter("@vacancy", vacancy));
                command.Parameters.Add(
                    new SqlParameter("@Sno", Convert.ToInt32(sno)));
                command.Parameters.Add(
                    new SqlParameter("@vacancyUpdateddate", Utility.IndianTime));
                
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewTransStudentDetails(string stbusno, string stbusname, string stcoursename, string stbranch, string stfeestatus, string stseatstatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        { 
            using (SqlCommand command = new SqlCommand("ViewTransStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@BusNo", stbusno));
                command.Parameters.Add(
                    new SqlParameter("@BusName", stbusname));
                command.Parameters.Add(
                    new SqlParameter("@Course", stcoursename));
                command.Parameters.Add(
                    new SqlParameter("@Branch", stbranch));
                command.Parameters.Add(
                    new SqlParameter("@FeesStatus", stfeestatus));
                command.Parameters.Add(
                    new SqlParameter("@SeatStatus", stseatstatus));
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
    public DataSet ViewEnquiredTransStudentDetails(string stbusno, string stbusname, string stcoursename, string stbranch, string stfeestatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        { 
            using (SqlCommand command = new SqlCommand("ViewEnquiredTransStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@BusNo", stbusno));
                command.Parameters.Add(
                    new SqlParameter("@BusName", stbusname));
                command.Parameters.Add(
                    new SqlParameter("@Course", stcoursename));
                command.Parameters.Add(
                    new SqlParameter("@Branch", stbranch));
                command.Parameters.Add(
                    new SqlParameter("@FeesStatus", stfeestatus));
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

    public DataSet ViewBuswiseSeatReport(string stbusSerialno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewBuswiseSeatReport", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@BusSerialno", stbusSerialno));
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

    public int ViewTotalCountTransMgmt(string columnval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int count = 0;
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewTotalCountTransMgmt", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@columnval", columnval));
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return count;
    }

    public DataSet ViewTransStudentDetailsByID(string strSno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTransStudentDetailsByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Sno", strSno));
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

    public int UpdateTransStudentDetails(transportmgmt trans)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateTransStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
            new SqlParameter("@StudSno", trans.snoo));
                command.Parameters.Add(
            new SqlParameter("@StudentName", trans.StudentName));
                command.Parameters.Add(
            new SqlParameter("@StudentID", trans.StudentID));
                command.Parameters.Add(
            new SqlParameter("@Email", trans.Email));
                command.Parameters.Add(
            new SqlParameter("@MobileNo", trans.MobileNo));
                command.Parameters.Add(
            new SqlParameter("@Course", trans.Course));
                command.Parameters.Add(
            new SqlParameter("@Branch", trans.Branch));
                command.Parameters.Add(
            new SqlParameter("@studyingYear", trans.studyingYear));
                command.Parameters.Add(
            new SqlParameter("@FeesStatus", trans.FeesStatus));
                command.Parameters.Add(
            new SqlParameter("@BusSerialNo", trans.BusSerialNo));
                command.Parameters.Add(
            new SqlParameter("@SeatStatus", trans.SeatStatus));
                command.Parameters.Add(
            new SqlParameter("@AllotedDate", trans.AllotedDate));
                command.Parameters.Add(
            new SqlParameter("@UpdatedBy", trans.UpdatedBy));
                command.Parameters.Add(
            new SqlParameter("@UpdatedDate", trans.UpdatedDate));
                command.Parameters.Add(
            new SqlParameter("@StopSNo", trans.StopSNo));
                command.Parameters.Add(
           new SqlParameter("@BalanceAmount", trans.BalanceAmount));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewByStudEmail(string strStudEmail, string strmode, string sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewByStudEmail", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@StudEmail", strStudEmail));
                command.Parameters.Add(
                   new SqlParameter("@flag", strmode));
                command.Parameters.Add(
                   new SqlParameter("@sno", Convert.ToInt32(sno)));
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
    public DataSet ViewByNameEmailMobile(string strstudname, string strEmail, string strMobile)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewByNameEmailMobile", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@StudName", strstudname));
                command.Parameters.Add(
                   new SqlParameter("@StudEmail", strEmail));
                command.Parameters.Add(
                   new SqlParameter("@StudMobile", strMobile));
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

    public DataSet GetBusSerialNo(string strbusno, string strbusname)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("GetBusSerialNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@BusNo", strbusno));
                command.Parameters.Add(
                    new SqlParameter("@BusName", strbusname));
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

    public DataSet GetStopSerialNo(string strbusSNO, string strstopname)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("GetStopSerialNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@BusSerialNo", strbusSNO));
                command.Parameters.Add(
                    new SqlParameter("@StopName", strstopname));
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
    public int UpdateTransStudentDetailsBulk(transportmgmt trans)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateTransStudentDetailsBulk", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
            new SqlParameter("@StudentName", trans.StudentName));
                command.Parameters.Add(
            new SqlParameter("@StudentID", trans.StudentID));
                command.Parameters.Add(
            new SqlParameter("@Email", trans.Email));
                command.Parameters.Add(
            new SqlParameter("@MobileNo", trans.MobileNo));
                command.Parameters.Add(
            new SqlParameter("@Course", trans.Course));
                command.Parameters.Add(
            new SqlParameter("@Branch", trans.Branch));
                command.Parameters.Add(
            new SqlParameter("@studyingYear", trans.studyingYear));
                command.Parameters.Add(
            new SqlParameter("@FeesStatus", trans.FeesStatus));
                command.Parameters.Add(
            new SqlParameter("@BusSerialNo", trans.BusSerialNo));
                command.Parameters.Add(
            new SqlParameter("@SeatStatus", trans.SeatStatus));
                command.Parameters.Add(
            new SqlParameter("@AllotedDate", trans.AllotedDate));
                command.Parameters.Add(
            new SqlParameter("@UpdatedBy", trans.UpdatedBy));
                command.Parameters.Add(
            new SqlParameter("@UpdatedDate", trans.UpdatedDate));
                command.Parameters.Add(
            new SqlParameter("@Bulkupload", trans.Bulkupload));
                command.Parameters.Add(
          new SqlParameter("@StopSNo", trans.StopSNo));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewStoppingByBusSNo(string strSno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStoppingByBusSNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Sno", strSno));
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

    public DataSet GetStudentSeatStatus(string strstudname, string strEmail, string strMobile)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("GetStudentSeatStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@StudName", strstudname));
                command.Parameters.Add(
                   new SqlParameter("@StudEmail", strEmail));
                command.Parameters.Add(
                   new SqlParameter("@StudMobile", strMobile));
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

    public int ViewStudCountByRouteID(string RouteID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int count = 0;
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewStudCountByRouteID", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@BusSerialNo", RouteID));
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return count;
    }

    public int DeleteStudentDetails(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@Sno", Sno));

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