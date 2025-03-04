using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for pmistplacements
/// </summary>
public class pmistplacements
{



    public int intPID { get; set; }
    public string strDepartment { get; set; }
    public bool boolPStatus { get; set; }
    public string strQuetion { get; set; }
    public string strcontent { get; set; }
    public string strAddedBy { get; set; }
    public string strUpdatedBy { get; set; }
    public string strpagename { get; set; }


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


    public int AddPMISTplacements(pmistplacements PQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddPMISTplacements", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Department", PQ.strDepartment));
                command.Parameters.Add(new SqlParameter("@Content", PQ.strcontent));
                command.Parameters.Add(new SqlParameter("@PStatus", PQ.boolPStatus));
                command.Parameters.Add(new SqlParameter("@PageName", PQ.strpagename));

                command.Parameters.Add(new SqlParameter("@AddedDate", Utility.IndianTime));
                command.Parameters.Add(new SqlParameter("@AddedBy", PQ.strAddedBy));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int updatePMISTplacements(pmistplacements PQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdatePMISTplacements", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@PID", PQ.intPID));
                command.Parameters.Add(new SqlParameter("@Department", PQ.strDepartment));
                command.Parameters.Add(new SqlParameter("@Content", PQ.strcontent));
                command.Parameters.Add(new SqlParameter("@PStatus", PQ.boolPStatus));
                command.Parameters.Add(new SqlParameter("@PageName", PQ.strpagename));
                command.Parameters.Add(new SqlParameter("@UpdatedDate", Utility.IndianTime));
                command.Parameters.Add(new SqlParameter("@UpdatedBy", PQ.strUpdatedBy));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }



    public int DeletePMISTPlacementsByID(int FAQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeletePMISTPlacementsByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@PID", FAQ));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }



    public DataTable ViewAllPlacements(string Department, string status, string PID,string strpagename)
    {
        bool? boolValue = null;
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllPlacements", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Department", Department));
                command.Parameters.Add(new SqlParameter("@PID", string.IsNullOrWhiteSpace(PID) ? (object)DBNull.Value : Convert.ToInt32(PID)));
                command.Parameters.Add(new SqlParameter("@PageName", strpagename));
                if (!string.IsNullOrWhiteSpace(status))
                {
                    if (status == "1" || status.ToLower() == "true")
                        boolValue = true;
                    else if (status == "0" || status.ToLower() == "false")
                        boolValue = false;
                }

                command.Parameters.Add(new SqlParameter("@PStatus", boolValue.HasValue ? (object)boolValue.Value : DBNull.Value));
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