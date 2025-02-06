using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for pmistinfrastruncture
/// </summary>
public class pmistinfrastruncture
{


    public int intInfrID { get; set; }
    public string strDepartment { get; set; }
    public bool boolInfrstatus { get; set; }
    public string strContent { get; set; }
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


    public int Addinfrastruncture(pmistinfrastruncture PQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddInfrastructure", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Department", PQ.strDepartment));
                command.Parameters.Add(new SqlParameter("@Content", PQ.strContent));
                command.Parameters.Add(new SqlParameter("@INFRStatus", PQ.boolInfrstatus));
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
    public int Updateinfrastruncture(pmistinfrastruncture PQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateInfrastructure", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@INFID", PQ.intInfrID));
                command.Parameters.Add(new SqlParameter("@Department", PQ.strDepartment));
                command.Parameters.Add(new SqlParameter("@INFRStatus", PQ.boolInfrstatus));
                command.Parameters.Add(new SqlParameter("@Content", PQ.strContent));
                command.Parameters.Add(new SqlParameter("@UpdatedDate", Utility.IndianTime));
                command.Parameters.Add(new SqlParameter("@Updatedby", PQ.strUpdatedBy));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int DeletePMISTInfrastructureByINFID(int FAQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeletePMISTInfrastructureByINFID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@INFID", FAQ));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataTable ViewAllInfrastructure(string Department, string status, string InfraID)
    {
        bool? boolValue = null;
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllInfrastructure", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Department", Department));
                command.Parameters.Add(new SqlParameter("@INFID", string.IsNullOrWhiteSpace(InfraID) ? (object)DBNull.Value : Convert.ToInt32(InfraID)));
                if (!string.IsNullOrWhiteSpace(status))
                {
                    if (status == "1" || status.ToLower() == "true")
                        boolValue = true;
                    else if (status == "0" || status.ToLower() == "false")
                        boolValue = false;
                }

                command.Parameters.Add(new SqlParameter("@INFRStatus", boolValue.HasValue ? (object)boolValue.Value : DBNull.Value));
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