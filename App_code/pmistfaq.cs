using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for pmistfaq
/// </summary>
public class pmistfaq
{



    public int intFAQID { get; set; }
    public string strDepartment { get; set; }
    public bool boolQStatus { get; set; }
    public string strQution { get; set; }
    public string strAnswer { get; set; }
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


    public int AddFAQ(pmistfaq PQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddFAQ", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Department", PQ.strDepartment));
                command.Parameters.Add(new SqlParameter("@QStatus", PQ.boolQStatus));
                command.Parameters.Add(new SqlParameter("@Qution", PQ.strQution));
                command.Parameters.Add(new SqlParameter("@Answer", PQ.strAnswer));
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

    public int UpdateFAQ(pmistfaq PQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateFAQ", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@FAQID", PQ.intFAQID));
                command.Parameters.Add(new SqlParameter("@Department", PQ.strDepartment));
                command.Parameters.Add(new SqlParameter("@QStatus", PQ.boolQStatus));
                command.Parameters.Add(new SqlParameter("@Qution", PQ.strQution));
                command.Parameters.Add(new SqlParameter("@Answer", PQ.strAnswer));
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

    public int DelteFAQ(int FAQ)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteFAQID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@FAQID", FAQ));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }



    public DataTable ViewAllFAQs(string Department, string status, string FAQID)
    {
        bool? boolValue = null;
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllFAQs", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Department", Department));
                command.Parameters.Add(new SqlParameter("@FAQID", string.IsNullOrWhiteSpace(FAQID) ? (object)DBNull.Value : Convert.ToInt32(FAQID)));
                if (!string.IsNullOrWhiteSpace(status))
                {
                    if (status == "1" || status.ToLower() == "true")
                        boolValue = true;
                    else if (status == "0" || status.ToLower() == "false")
                        boolValue = false;
                }

                command.Parameters.Add(new SqlParameter("@QStatus", boolValue.HasValue ? (object)boolValue.Value : DBNull.Value));
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