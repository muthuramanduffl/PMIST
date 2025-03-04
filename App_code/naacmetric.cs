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
public class naacmetric
{
    public int Id { get; set; }
    public int CriteriaNo { get; set; }
    public string MetricNo { get; set; }
    public string MetricName { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public naacmetric()
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
    public int AddMetric(List<naacmetric> LstNaaccriteria)
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
                foreach (naacmetric metric in LstNaaccriteria)
                {
                    using (SqlCommand command = new SqlCommand("AddMetric", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                       
                        command.Parameters.Add(
                      new SqlParameter("@CriteriaId", metric.CriteriaNo));
                        command.Parameters.Add(
                     new SqlParameter("@MetricNo", metric.MetricNo));
                        command.Parameters.Add(
                           new SqlParameter("@MetricName", metric.MetricName));
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
    public int UpdateCriteria(string Title, string stMetricNo, int CriteriaNo, string UpdatedBy,bool Active, DateTime dtUpdateTime,int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;

        //try
        //{

            using (SqlCommand command = new SqlCommand("UpdateMetric", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                      new SqlParameter("@CriteriaId", CriteriaNo));
            command.Parameters.Add(
                     new SqlParameter("@MetricNo", stMetricNo));
            command.Parameters.Add(
                   new SqlParameter("@MetricName", Title));
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
  
    public int UpdateMetricStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            using (SqlCommand command = new SqlCommand("UpdateMetricStatus", cnn))
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
                using (SqlCommand command = new SqlCommand("DeleteMetric", cnn))
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

    public DataSet ViewMetricById(int ID)
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

                using (SqlCommand command = new SqlCommand("ViewMetricById", cnn))
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
    public DataSet ViewAllMetric()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllMetric", cnn))
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
    public DataSet ViewMetricByCriteria(int CriteriaNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            

                using (SqlCommand command = new SqlCommand("ViewMetricByCriteria", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                                          new SqlParameter("@CriteriaId", CriteriaNo));
                    
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

    public DataSet ViewMetricByMetricNo(int CriteriaNo,string stMetricNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {


            using (SqlCommand command = new SqlCommand("ViewMetricByMetricNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CriteriaId", CriteriaNo));
                command.Parameters.Add(
                                     new SqlParameter("@MetricNo", stMetricNo));
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
    public DataSet ViewActiveMetric(int CriteriaId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        //try
        //{
          
                using (SqlCommand command = new SqlCommand("ViewActiveMetric", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                     new SqlParameter("@CriteriaId", CriteriaId));
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

    public DataSet ViewActiveMetric2024(int CriteriaId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        //try
        //{
          
                using (SqlCommand command = new SqlCommand("ViewActiveMetric2024", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                     new SqlParameter("@CriteriaId", CriteriaId));
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
   
   
   
}