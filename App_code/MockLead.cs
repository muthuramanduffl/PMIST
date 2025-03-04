using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for MockLead
/// </summary>
public class MockLead
{
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string MobileNo { get; set; }
    public string Location { get; set; }
    public string State { get; set; }
    public string SchoolName { get; set; }
    public string class_study { get; set; }
    public string SourceEntered { get; set; }
    public DateTime LeadGeneratedDate { get; set; }
    public string BulkUpload { get; set; }

    public MockLead()
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
    public DataSet RawLeadEmailExist(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("RawLeadEmailExist", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@EmailId", stEmailId));

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
    public DataSet RawLeadMobileNoExist(string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("RawLeadMobileNoExist", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@MobileNo", stMobileNo));

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
    public int AddMocktest_RawLead(MockLead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddMocktest_RawLead", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
            new SqlParameter("@Name", lead.Name));
                command.Parameters.Add(
            new SqlParameter("@EmailId", lead.EmailId));
                command.Parameters.Add(
            new SqlParameter("@PhoneNo", lead.MobileNo));
                command.Parameters.Add(
            new SqlParameter("@State", lead.State));
                command.Parameters.Add(
            new SqlParameter("@City", lead.Location));
                command.Parameters.Add(
            new SqlParameter("@Class_study", lead.class_study));
                command.Parameters.Add(
            new SqlParameter("@School_CollegeName", lead.SchoolName));
                command.Parameters.Add(
            new SqlParameter("@Source", lead.SourceEntered));
                command.Parameters.Add(
            new SqlParameter("@generateddate", lead.LeadGeneratedDate));
                command.Parameters.Add(
            new SqlParameter("@BulkUpload", lead.BulkUpload));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public DataSet ViewCityBYStateID(string stateID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCityBYStateID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@StateID", stateID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }
}