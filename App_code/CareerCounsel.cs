using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for CareerCounsel
/// </summary>
public class CareerCounsel
{
    public int Sno { get; set; }
    public string RegID { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string Mobile { get; set; }
    public string WhatsAppNo { get; set; }
    public string School { get; set; }
    public string City { get; set; }
    public string Pursuedegree { get; set; }
    public DateTime RegDate { get; set; }
    public string Guidancetype { get; set; }
    public string Subject { get; set; }
    public string Query { get; set; }
    public DateTime AddedDate { get; set; }
    public string Review { get; set; }
    public string Rating { get; set; }
    public DateTime ReviewAddedDate { get; set; }
    public string QueryID { get; set; }
    public string AssignedTo { get; set; }
    public string ticketstatus { get; set; }
    public DateTime updateddate { get; set; }
    public string updatedby { get; set; }
    public string Remarks { get; set; }

    public CareerCounsel()
    {
        //
        // TODO: Add constructor logic here
        //
    }

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
    public int AddRegCareerCounsel(CareerCounsel career)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddRegCareerCounsel", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RegID", career.RegID));
                command.Parameters.Add(new SqlParameter("@Name", career.Name));
                command.Parameters.Add(new SqlParameter("@EmailId", career.EmailId));
                command.Parameters.Add(new SqlParameter("@Mobile", career.Mobile));
                command.Parameters.Add(new SqlParameter("@WhatsAppNo", career.WhatsAppNo));
                command.Parameters.Add(new SqlParameter("@School", career.School));
                command.Parameters.Add(new SqlParameter("@City", career.City));
                command.Parameters.Add(new SqlParameter("@Pursuedegree", career.Pursuedegree));
                command.Parameters.Add(new SqlParameter("@RegDate", career.RegDate));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewRegCareerByMobileNo(string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegCareerByMobileNo", cnn))
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

    public DataSet ViewRegCareerByEmailId(string stEmail)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegCareerByEmailId", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@EmailId", stEmail));

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
    public DataSet ViewRegCareerByRegID(string stRegID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegCareerByRegID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@RegID", stRegID));

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
    
    public int AddQueriesCareerCounsel(CareerCounsel career)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddQueriesCareerCounsel", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RegID", career.RegID));
                command.Parameters.Add(new SqlParameter("@Guidancetype", career.Guidancetype));
                command.Parameters.Add(new SqlParameter("@Subject", career.Subject));
                command.Parameters.Add(new SqlParameter("@Query", career.Query));
                command.Parameters.Add(new SqlParameter("@AddedDate", career.AddedDate));
                command.Parameters.Add(new SqlParameter("@QueryID", career.QueryID));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    
    public DataSet ViewQueryCareerByQueryID(string stQueryID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewQueryCareerByQueryID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@QueryID", stQueryID));

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

    public DataSet ViewRegCareerByEmailMobile(string stEmailMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegCareerByEmailMobile", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@EmailMobileNo", stEmailMobileNo));

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

    public int UpdateCCFeedBack(CareerCounsel career)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateCCFeedBack", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@QueryID", career.QueryID));
                command.Parameters.Add(new SqlParameter("@Review", career.Review));
                command.Parameters.Add(new SqlParameter("@Rating", career.Rating));
                command.Parameters.Add(new SqlParameter("@ReviewAddedDate", career.ReviewAddedDate));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewAllQueryCareerCounsel()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllQueryCareerCounsel", cnn))
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
    
    public int UpdateCCQueryAssign(CareerCounsel career)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateCCQueryAssign", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Sno", career.Sno));
                command.Parameters.Add(new SqlParameter("@AssignedTo", career.AssignedTo));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeleteCCQuery(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteCCQuery", cnn))
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


    public DataSet ViewQueryByTeamID(string teamID, string stticketstatus, string stguidance)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewQueryByTeamID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@teamId", teamID));
                command.Parameters.Add(
                                      new SqlParameter("@ticketstatus", stticketstatus));
                command.Parameters.Add(
                                      new SqlParameter("@guidance", stguidance));

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

    public DataSet ViewCCQueryById(string Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCCQueryById", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Id", Sno));

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

    public int UpdateCCQueryStatus(CareerCounsel career)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {

            using (SqlCommand command = new SqlCommand("UpdateCCQueryStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                  new SqlParameter("@ticketStatus", career.ticketstatus));
                command.Parameters.Add(
                    new SqlParameter("@Remarks", career.Remarks));
                command.Parameters.Add(
                    new SqlParameter("@updateddate", career.updateddate));
                command.Parameters.Add(
                    new SqlParameter("@updatedby", career.updatedby));
                command.Parameters.Add(
                    new SqlParameter("@Sno", career.Sno));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int ViewTotalCountCareerGriev(string columnval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int count = 0;
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewTotalCountCareerGriev", cnn))
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
    public int ViewLevelCountCareerGriev(string columnval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int count = 0;
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewLevelCountCareerGriev", cnn))
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

	public DataSet ViewAllQueryCareerCounselFilter(string stticketstatus, string stguidance, string strating, string stSearchText)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllQueryCareerCounselFilter", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@ticketstatus", stticketstatus));
                command.Parameters.Add(
                                      new SqlParameter("@guidance", stguidance));
                command.Parameters.Add(
                                     new SqlParameter("@rating", strating));
                command.Parameters.Add(
                                      new SqlParameter("@srchval", stSearchText));

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