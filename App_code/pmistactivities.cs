using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for pmistactivities
/// </summary>
public class pmistactivities
{
    public int intACTID { get; set; }
    public string strDepartment { get; set; }
    public bool ActivitiyStatus { get; set; }
    public string strTitle { get; set; }
    public string strPdfFilename { get; set; }
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


    public int AddDepartmentActivities(pmistactivities PQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddDepartmentActivities", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Department", PQ.strDepartment));
                command.Parameters.Add(new SqlParameter("@Title", PQ.strTitle));
                command.Parameters.Add(new SqlParameter("@ActivitiyStatus",PQ.ActivitiyStatus));
                command.Parameters.Add(new SqlParameter("@PdfFilename", PQ.strPdfFilename));
                command.Parameters.Add(new SqlParameter("@Addedate", Utility.IndianTime));
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

    public int UpdateDepartmentActivities(pmistactivities PQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateDepartmentActivities", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ACTID", PQ.intACTID));
                command.Parameters.Add(new SqlParameter("@Department", PQ.strDepartment));
                command.Parameters.Add(new SqlParameter("@Title", PQ.strTitle));
                command.Parameters.Add(new SqlParameter("@ActivitiyStatus", PQ.ActivitiyStatus));
                command.Parameters.Add(new SqlParameter("@PdfFilename", PQ.strPdfFilename));
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

    public int DelteActivities(int ActID)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteDepartmentActivities", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ACTID", ActID));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }



    public DataTable ViewAllDepartmentActivities(string Department, string status, string ActID)
    {
        bool? boolValue = null;
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllDepartmentActivities", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Department", Department));
                command.Parameters.Add(new SqlParameter("@ACTID", string.IsNullOrWhiteSpace(ActID) ? (object)DBNull.Value : Convert.ToInt32(ActID)));
                if (!string.IsNullOrWhiteSpace(status))
                {
                    if (status == "1" || status.ToLower() == "true")
                        boolValue = true;
                    else if (status == "0" || status.ToLower() == "false")
                        boolValue = false;
                }
                command.Parameters.Add(new SqlParameter("@ActivitiyStatus", boolValue.HasValue ? (object)boolValue.Value : DBNull.Value));
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