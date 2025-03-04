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
public class naaccriteria
{
    public int Id { get; set; }
    public int CriteriaNo { get; set; }
    public string Title { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public naaccriteria()
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
    public int AddCriteria(List<naaccriteria> LstNaaccriteria)
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
                foreach (naaccriteria criteria in LstNaaccriteria)
                {
                    using (SqlCommand command = new SqlCommand("AddCriteria", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                       
                        command.Parameters.Add(
                      new SqlParameter("@CriteriaNo", criteria.CriteriaNo));
                        command.Parameters.Add(
                           new SqlParameter("@Title", criteria.Title));
                        command.Parameters.Add(
                           new SqlParameter("@Active", criteria.Active));
                        command.Parameters.Add(
                       new SqlParameter("@AddedBy", criteria.AddedBy));
                        command.Parameters.Add(
                           new SqlParameter("@AddedDateTime", criteria.AddedDateTime));
                        command.Parameters.Add(
                           new SqlParameter("@UpdatedDateTime", criteria.UpdatedDateTime));
                        command.Parameters.Add(
                          new SqlParameter("@UpdatedBy", criteria.UpdatedBy));
                       
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
    public int UpdateCriteria(string Title, int CriteriaNo, string UpdatedBy,bool Active, DateTime dtUpdateTime,int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;

        //try
        //{

            using (SqlCommand command = new SqlCommand("UpdateCriteria", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                      new SqlParameter("@CriteriaNo", CriteriaNo));
                command.Parameters.Add(
                   new SqlParameter("@Title", Title));
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
  
    public int UpdateCriteriaStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            using (SqlCommand command = new SqlCommand("UpdateCriteriaStatus", cnn))
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
    public int DeleteCriteriaByID(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteCriteria", cnn))
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
    
    public DataSet ViewCriteriaByNo(int CriteriaNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            

                using (SqlCommand command = new SqlCommand("ViewCriteriaByNo", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                                          new SqlParameter("@CriteriaNo", CriteriaNo));
                    
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
    public DataSet ViewCriteriaById(int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            if (ID>0)
            {

                using (SqlCommand command = new SqlCommand("ViewCriteriaById", cnn))
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
   
    public DataSet ViewActiveCriteria()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
          
                using (SqlCommand command = new SqlCommand("ViewActiveCriteria", cnn))
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
    public DataSet ViewActiveCriteria2024()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
          
                using (SqlCommand command = new SqlCommand("ViewActiveCriteria2024", cnn))
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
    public DataSet ViewAllCriteria()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllCriteria", cnn))
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