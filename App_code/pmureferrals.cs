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
public class pmureferrals
{
    public int Id { get; set; }
    public string RefCode { get; set; }
    public string RefName { get; set; }
    public string RefType { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public pmureferrals()
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
    public int AddReferrals(pmureferrals referrals)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddReferrals", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@RefCode", referrals.RefCode));
                command.Parameters.Add(
             new SqlParameter("@RefName", referrals.RefName));
                command.Parameters.Add(
            new SqlParameter("@RefType", referrals.RefType));
                command.Parameters.Add(
           new SqlParameter("@Status", referrals.Active));
                command.Parameters.Add(
                  new SqlParameter("@AddedBy", referrals.AddedBy));
                command.Parameters.Add(
                 new SqlParameter("@AddedDate", referrals.AddedDateTime));
                command.Parameters.Add(
                 new SqlParameter("@UpdatedBy", referrals.UpdatedBy));
                command.Parameters.Add(
                   new SqlParameter("@UpdatedDate", referrals.UpdatedDateTime));

                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateReferrals(pmureferrals referrals, int Id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateReferrals", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@RefCode", referrals.RefCode));
                command.Parameters.Add(
             new SqlParameter("@RefName", referrals.RefName));
                command.Parameters.Add(
            new SqlParameter("@RefType", referrals.RefType));
                command.Parameters.Add(
           new SqlParameter("@Status", referrals.Active));
                command.Parameters.Add(
                 new SqlParameter("@UpdatedBy", referrals.UpdatedBy));
                command.Parameters.Add(
                   new SqlParameter("@UpdatedDate", referrals.UpdatedDateTime));
                command.Parameters.Add(
                 new SqlParameter("@Sno", Id));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateReferralStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateReferralStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Sno", ID));
                command.Parameters.Add(
                new SqlParameter("@UpdatedBy", updatedBy));
                command.Parameters.Add(
                new SqlParameter("@UpdatedDateTime", dtUpdatedDateTime));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return rowsAffected;

    }
    public int DeleteReferrals(int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsDetail = new DataSet();
        int rowsAffected = 0;
        try
        {
            if (ID > 0)
            {

                cnn.Open();
                using (SqlCommand command = new SqlCommand("DeleteReferrals", cnn))
                {

                    // Add new SqlParameter to the command.

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@Sno", ID));
                    rowsAffected = command.ExecuteNonQuery();


                }
                cnn.Close();

            }
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewReferralByCode(string stCode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewReferralByCode", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", stCode));

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

    public DataSet ViewReferralByType(string stRefType)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewReferralByType", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@RefType", stRefType));

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
    public DataSet ViewReferral()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewReferral", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
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
}