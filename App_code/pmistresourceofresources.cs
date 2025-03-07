using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for pmistresourceofresources
/// </summary>
public class pmistresourceofresources
{



    public int intRFID { get;set; }
    public string strTitleContent { get; set; }
    public string strResearchType { get; set; }
    public string strURL_AND_Notes { get; set; }
    public string strContent { get; set; }
    public string AddedBy { get; set; }
    public bool status { get; set; }
    public string strAddedBy { get; set; }
    public string strUpdatedBy { get; set; }


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


    public int AddResearchForResearches(pmistresourceofresources PQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddResearchForResearches", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.Add(new SqlParameter("@ResearchType", PQ.strResearchType));
                command.Parameters.Add(new SqlParameter("@TitleContent", PQ.strTitleContent));
                command.Parameters.Add(new SqlParameter("@URL_AND_Notes", PQ.strURL_AND_Notes));
                command.Parameters.Add(new SqlParameter("@CStatus", PQ.status));             
                command.Parameters.Add(new SqlParameter("@AddedBy", PQ.strAddedBy));
                command.Parameters.Add(new SqlParameter("@Addedate", Utility.IndianTime));
         
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    
    public int UpdateResearchForResearches(pmistresourceofresources PQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateResearchForResearches", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RFID", PQ.intRFID));
                command.Parameters.Add(new SqlParameter("@ResearchType", PQ.strResearchType));
                command.Parameters.Add(new SqlParameter("@TitleContent", PQ.strTitleContent));
                command.Parameters.Add(new SqlParameter("@URL_AND_Notes", PQ.strURL_AND_Notes));
                command.Parameters.Add(new SqlParameter("@CStatus", PQ.status));              
                command.Parameters.Add(new SqlParameter("@UpdatedBy", PQ.strUpdatedBy));
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



    public int DeleteResearchRFR(int RFID)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteResearchRFR", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RFID", RFID));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }



    public DataTable ViewAllResearchRFRFilter(string resource, string status, string RFID)
    {
        bool? boolValue = null;
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllResearchRFRFilter", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ResearchType", resource));
                command.Parameters.Add(new SqlParameter("@RFID", string.IsNullOrWhiteSpace(RFID) ? (object)DBNull.Value : Convert.ToInt32(RFID)));
                if (!string.IsNullOrWhiteSpace(status))
                {
                    if (status == "1" || status.ToLower() == "true")
                        boolValue = true;
                    else if (status == "0" || status.ToLower() == "false")
                        boolValue = false;
                }
                command.Parameters.Add(new SqlParameter("@Status", boolValue.HasValue ? (object)boolValue.Value : DBNull.Value));
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(dt);
            }
        }
        catch (Exception ex)
        {

        }
        return dt;
    }


    public DataTable viewAllResourceResearchTypeName()
    {
      
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("viewAllResourceResearchTypeName", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(dt);
            }
        }
        catch (Exception ex)
        {

        }
        return dt;
    }


    public DataTable viewAllResourceResearchTypeNameByID(int RFID)
    {
      
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("viewAllResourceResearchTypeNameByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RRID", RFID));
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(dt);
            }
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

}