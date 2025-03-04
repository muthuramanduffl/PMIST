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
public class pmuleadhistory
{
    public int Sno { get; set; }
    public string LeadId { get; set; }
    public string Field { get; set; }
    public string FieldValue { get; set; }
    public DateTime Historyupdatedate { get; set; }
    public string UpdatedBy { get; set; }
    public string Role { get; set; }

    public string RawId { get; set; }
    public pmuleadhistory()
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
    public int AddleadHistory(pmuleadhistory leadhistory)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddLeadHistory", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@LeadId", leadhistory.LeadId));
                command.Parameters.Add(
             new SqlParameter("@Field", leadhistory.Field));
                command.Parameters.Add(
            new SqlParameter("@FieldValue", leadhistory.FieldValue));
                command.Parameters.Add(
           new SqlParameter("@Historyupdatedate", leadhistory.Historyupdatedate));
                command.Parameters.Add(
             new SqlParameter("@UpdatedBy", leadhistory.UpdatedBy));
                command.Parameters.Add(
                   new SqlParameter("@Role", leadhistory.Role));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewGroupLeadHistoryByDate(string stLeadId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewGroupLeadHistoryByDate", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@LeadId", stLeadId));

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
    public DataSet ViewLeadHistoryByDate(string stLeadId, string stHistoryDate)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadHistoryByDate", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@LeadId", stLeadId));
                command.Parameters.Add(
                                     new SqlParameter("@HistoryDate", stHistoryDate));
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

    public int AddRawleadHistory(pmuleadhistory leadhistory)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddRawLeadHistory", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@RawId", leadhistory.RawId));
                command.Parameters.Add(
                    new SqlParameter("@Field", leadhistory.Field));
                command.Parameters.Add(
                    new SqlParameter("@FieldValue", leadhistory.FieldValue));
                command.Parameters.Add(
                    new SqlParameter("@Historyupdatedate", leadhistory.Historyupdatedate));
                command.Parameters.Add(
                    new SqlParameter("@UpdatedBy", leadhistory.UpdatedBy));
                command.Parameters.Add(
                    new SqlParameter("@Role", leadhistory.Role));
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