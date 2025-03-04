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
public class naacsubmetric
{
    public int Id { get; set; }
    public int CriteriaNo { get; set; }
    public int MetricId { get; set; }
    public string SubMetricNo { get; set; }
    public string SubMetricName { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public naacsubmetric()
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

            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connetionString;
    }
    public int AddSubMetric(List<naacsubmetric> LstNaaccriteria)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstNaaccriteria != null && LstNaaccriteria.Count > 0)
            {
                foreach (naacsubmetric metric in LstNaaccriteria)
                {
                    using (SqlCommand command = new SqlCommand("AddSubMetric", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                       
                        command.Parameters.Add(
                      new SqlParameter("@CriteriaId", metric.CriteriaNo));
                        command.Parameters.Add(
                     new SqlParameter("@MetricId", metric.MetricId));
                        command.Parameters.Add(
                     new SqlParameter("@SubMetricNo", metric.SubMetricNo));
                        command.Parameters.Add(
                           new SqlParameter("@SubMetricName", metric.SubMetricName));
                        command.Parameters.Add(
                           new SqlParameter("@Active", metric.Active));
                        command.Parameters.Add(
                       new SqlParameter("@AddedBy", metric.AddedBy));
                        command.Parameters.Add(
                           new SqlParameter("@AddedDateTime", metric.AddedDateTime));
                        command.Parameters.Add(
                           new SqlParameter("@UpdatedDateTime", metric.UpdatedDateTime));
                        command.Parameters.Add(
                          new SqlParameter("@UpdatedBy", metric.UpdatedBy));
                       
                        rowsAffected = command.ExecuteNonQuery();


                    }
                    cnn.Close();
                }


            }
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateSubMetric(string Title, string stMetricNo, int CriteriaNo, int MetricId, string UpdatedBy,bool Active, DateTime dtUpdateTime,int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;

        //try
        //{

            using (SqlCommand command = new SqlCommand("UpdateSubMetric", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                      new SqlParameter("@CriteriaId", CriteriaNo));
            command.Parameters.Add(
                      new SqlParameter("@MetricId", MetricId));
            command.Parameters.Add(
                     new SqlParameter("@SubMetricNo", stMetricNo));
            command.Parameters.Add(
                   new SqlParameter("@SubMetricName", Title));
                command.Parameters.Add(
                   new SqlParameter("@Active", Active));
                command.Parameters.Add(
                   new SqlParameter("@UpdatedDateTime", dtUpdateTime));
                command.Parameters.Add(
                  new SqlParameter("@UpdatedBy", UpdatedBy));
            command.Parameters.Add(
                 new SqlParameter("@Sno", Sno));
            rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        //}


        //catch (Exception ex)
        //{
        //}
        return rowsAffected;
    }
  
    public int UpdateSubMetricStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            using (SqlCommand command = new SqlCommand("UpdateSubMetricStatus", cnn))
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

        //}
        //catch (Exception ex)
        //{
        //}
        return rowsAffected;

    }
    public int DeleteMetricByID(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteSubMetric", cnn))
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

    public DataSet ViewSubMetricById(int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            if (ID > 0)
            {

                using (SqlCommand command = new SqlCommand("ViewSubMetricById", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                                          new SqlParameter("@Sno", ID));

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dsNews);

                }

                cnn.Close();

            }
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public DataSet ViewAllSubMetric()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllSubMetric", cnn))
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
    public DataSet ViewSubMetricBySubMetricNo(int CriteriaNo, int MetricId, string stSubMetricNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        //try
        //{


            using (SqlCommand command = new SqlCommand("ViewSubMetricBySubMetricNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CriteriaId", CriteriaNo));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
                command.Parameters.Add(
                                     new SqlParameter("@SubMetricNo", stSubMetricNo));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dsNews);

            }

            cnn.Close();

        //}
        //catch (Exception ex)
        //{
        //}
        return dsNews;
    }
    public DataSet ViewSubMetricByMetric(int CriteriaId, int MetricId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        //try
        //{
            

                using (SqlCommand command = new SqlCommand("ViewSubMetricByMetric", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                                          new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
                SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dsNews);

                }

                cnn.Close();

        //}
        //catch (Exception ex)
        //{
        //}
        return dsNews;
    }

   
    public DataSet ViewActiveSubMetric(int CriteriaId, int MetricId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewSubMetricByMetric", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
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

    public DataSet ViewActiveSubMetric2024(int CriteriaId, int MetricId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewSubMetricByMetric2024", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
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