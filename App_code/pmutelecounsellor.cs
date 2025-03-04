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
public class pmutelecounsellor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string MobileNo { get; set; }
    public int CounsellorId { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public pmutelecounsellor()
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
    public int AddTeleCounsellor(pmutelecounsellor telecounsellor)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddTeleCounsellor", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@Name", telecounsellor.Name));
                command.Parameters.Add(
             new SqlParameter("@EmailId", telecounsellor.EmailId));
                command.Parameters.Add(
            new SqlParameter("@MobileNo", telecounsellor.MobileNo));
                command.Parameters.Add(
           new SqlParameter("@CounsellorId", telecounsellor.CounsellorId));
                command.Parameters.Add(
                   new SqlParameter("@Active", telecounsellor.Active));
                command.Parameters.Add(
                  new SqlParameter("@AddedBy", telecounsellor.AddedBy));
                command.Parameters.Add(
                 new SqlParameter("@AddedDateTime", telecounsellor.AddedDateTime));
                command.Parameters.Add(
                 new SqlParameter("@UpdatedBy", telecounsellor.UpdatedBy));
                command.Parameters.Add(
                   new SqlParameter("@UpdatedDateTime", telecounsellor.UpdatedDateTime));

                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewTelecounsellorByUniqueId(int CounsellorId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTelecounsellorByUniqueId", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CounsellorId", CounsellorId));

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
    public DataSet ViewActiveTelecounsellor()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewActiveTelecounsellor", cnn))
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
    public int ActiveTeleCallerCount()
    {
        int count = 0;
        DataSet ds = ViewActiveTelecounsellor();
        if(ds.Tables.Count>0 && ds.Tables[0].Rows.Count > 0)
        {
            count = ds.Tables[0].Rows.Count;
        }
        return count;
    }
    public bool IsTeleCounsellorActive(int CounsellorId)
    {
        bool IsExists = false;
        DataSet ds = ViewTelecounsellorByUniqueId(CounsellorId);
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            IsExists = true;
        return IsExists;
    }

    public DataSet ViewActiveLeads(int CounsellorId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewActiveLeads", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", CounsellorId.ToString()));

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
    public DataSet ViewAdmittedLeads(int CounsellorId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAdmittedLeads", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", CounsellorId.ToString()));
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
    public DataSet ViewDroppedLeads(int CounsellorId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewDroppedLeads", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", CounsellorId.ToString()));
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
    public DataSet ViewTotalLeads(int CounsellorId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTotalLeads", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", CounsellorId.ToString()));
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