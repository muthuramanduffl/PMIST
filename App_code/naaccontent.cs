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
public class naaccontent
{
    public int Id { get; set; }
    public int CriteriaId { get; set; }
    public int MetricId { get; set; }
    public int SubMetricId { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public int DisplayOrder { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public naaccontent()
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
    public int AddNaac(List<naaccontent> LstNaaccriteria)
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
                foreach (naaccontent naac in LstNaaccriteria)
                {
                    using (SqlCommand command = new SqlCommand("AddNaac", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                       
                        command.Parameters.Add(
                      new SqlParameter("@CriteriaId", naac.CriteriaId));
                        command.Parameters.Add(
                     new SqlParameter("@MetricId", naac.MetricId));
                        command.Parameters.Add(
                     new SqlParameter("@SubMetricId", naac.SubMetricId));
                        command.Parameters.Add(
                           new SqlParameter("@Type", naac.Type));
                        command.Parameters.Add(
                          new SqlParameter("@Title", naac.Title));
                        command.Parameters.Add(
                         new SqlParameter("@Url", naac.Url));
                        command.Parameters.Add(
                         new SqlParameter("@DisplayOrder", naac.DisplayOrder));
                        command.Parameters.Add(
                           new SqlParameter("@Active", naac.Active));
                        command.Parameters.Add(
                       new SqlParameter("@AddedBy", naac.AddedBy));
                        command.Parameters.Add(
                           new SqlParameter("@AddedDateTime", naac.AddedDateTime));
                        command.Parameters.Add(
                           new SqlParameter("@UpdatedDateTime", naac.UpdatedDateTime));
                        command.Parameters.Add(
                          new SqlParameter("@UpdatedBy", naac.UpdatedBy));
                       
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
    public int UpdateNaac(List<naaccontent> LstNaaccriteria,int Id)
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
                foreach (naaccontent naac in LstNaaccriteria)
                {
                    using (SqlCommand command = new SqlCommand("UpdateNaac", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(
                      new SqlParameter("@CriteriaId", naac.CriteriaId));
                        command.Parameters.Add(
                     new SqlParameter("@MetricId", naac.MetricId));
                        command.Parameters.Add(
                     new SqlParameter("@SubMetricId", naac.SubMetricId));
                        command.Parameters.Add(
                           new SqlParameter("@Type", naac.Type));
                        command.Parameters.Add(
                          new SqlParameter("@Title", naac.Title));
                        command.Parameters.Add(
                         new SqlParameter("@Url", naac.Url));
                        command.Parameters.Add(
                         new SqlParameter("@DisplayOrder", naac.DisplayOrder));
                        command.Parameters.Add(
                           new SqlParameter("@Active", naac.Active));
                        command.Parameters.Add(
                           new SqlParameter("@UpdatedDateTime", naac.UpdatedDateTime));
                        command.Parameters.Add(
                          new SqlParameter("@UpdatedBy", naac.UpdatedBy));
                        command.Parameters.Add(
                         new SqlParameter("@Sno", Id));
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
    public int UpdateNaacStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            using (SqlCommand command = new SqlCommand("UpdateNaacStatus", cnn))
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
    public int DeleteNaac(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteNaac", cnn))
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

    public DataSet ViewNaacById(int ID)
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

                using (SqlCommand command = new SqlCommand("ViewNaacById", cnn))
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
    public DataSet ViewAllNaac()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllNaac", cnn))
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
       
    public DataSet ViewNaac(int CriteriaId, int MetricId,int SubMetricId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        //try
        //{
            

                using (SqlCommand command = new SqlCommand("ViewNaac", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                                          new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
            command.Parameters.Add(
                                      new SqlParameter("@SubMetricId", SubMetricId));
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

   
    public DataSet ViewActiveNaac(int CriteriaId, int MetricId, int SubMetricId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewActiveNaac", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
                command.Parameters.Add(
                                     new SqlParameter("@SubMetricId", SubMetricId));
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

    public DataSet ViewActiveNaac2024(int CriteriaId, int MetricId, int SubMetricId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewActiveNaac2024", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
                command.Parameters.Add(
                                     new SqlParameter("@SubMetricId", SubMetricId));
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


    public DataSet ViewMaxNaac(int CriteriaId, int MetricId, int SubMetricId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMaxNaac", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                    new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
                command.Parameters.Add(
                                     new SqlParameter("@SubMetricId", SubMetricId));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet GetNaacDisplayOrderWay1(int fromDisplayOrder, int toDisplayOrder, int CriteriaId, int MetricId, int SubMetricId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetNaacDisplayOrderWay1", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                    new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
                command.Parameters.Add(
                                     new SqlParameter("@SubMetricId", SubMetricId));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet GetNaacDisplayOrderWay2(int fromDisplayOrder, int toDisplayOrder, int CriteriaId, int MetricId, int SubMetricId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetNaacDisplayOrderWay2", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                   new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
                command.Parameters.Add(
                                     new SqlParameter("@SubMetricId", SubMetricId));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public int UpdateNaacDisplayOrder(int Sno, int DisplayOrder, string UpdatedBy)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateNaacDisplayOrder", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                   new SqlParameter("@Sno", Sno));
                command.Parameters.Add(
                   new SqlParameter("@DisplayOrder", DisplayOrder));
                command.Parameters.Add(
               new SqlParameter("@UpdatedBy", UpdatedBy));
                command.Parameters.Add(
                 new SqlParameter("@UpdatedDateTime", DateTime.Now));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet IsNaacDisplayOrderExists(int displayOrder, int CriteriaId, int MetricId, int SubMetricId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("IsNaacDisplayOrderExists", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@DisplayOrder", displayOrder));
                command.Parameters.Add(
                                   new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
                command.Parameters.Add(
                                     new SqlParameter("@SubMetricId", SubMetricId));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet GetNaacDisplayOrderForInsert(int fromDisplayOrder, int toDisplayOrder, int CriteriaId, int MetricId, int SubMetricId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetNaacDisplayOrderForInsert", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                  new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
                command.Parameters.Add(
                                     new SqlParameter("@SubMetricId", SubMetricId));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet GetNaacDisplayOrderForDelete(int fromDisplayOrder, int toDisplayOrder, int CriteriaId, int MetricId, int SubMetricId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetNaacDisplayOrderForDelete", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                  new SqlParameter("@CriteriaId", CriteriaId));
                command.Parameters.Add(
                                      new SqlParameter("@MetricId", MetricId));
                command.Parameters.Add(
                                     new SqlParameter("@SubMetricId", SubMetricId));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return ds;
    }
}