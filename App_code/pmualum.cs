using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
/// <summary>
/// Summary description for News
/// </summary>
public class pmualum
{
    public int EventId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Venue { get; set; }
    public DateTime EventStartDate { get; set; }

    public bool Status { get; set; }
    public DateTime PostedDate { get; set; }
    public string PostedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string UpdatedBy { get; set; }
    public string Album { get; set; }

    public pmualum()
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
    public int AddAlumniMeet(List<pmualum> LstNews)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstNews != null && LstNews.Count > 0)
            {
                foreach (pmualum news in LstNews)
                {
                    using (SqlCommand command = new SqlCommand("AddAlumniMeet", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(
                            new SqlParameter("@Title", news.Title.Trim()));
                        command.Parameters.Add(
                            new SqlParameter("@Description", news.Description));
                        command.Parameters.Add(
                            new SqlParameter("@Venue", news.Venue));
                        command.Parameters.Add(
                            new SqlParameter("@EventStartDate", news.EventStartDate));
                        command.Parameters.Add(
                            new SqlParameter("@PostedDate", news.PostedDate));
                        command.Parameters.Add(
                            new SqlParameter("@PostedBy", news.PostedBy));
                        command.Parameters.Add(
                            new SqlParameter("@Active", news.Status));
                        command.Parameters.Add(
                            new SqlParameter("@UpdatedDate", news.UpdatedDate));
                        command.Parameters.Add(
                            new SqlParameter("@UpdatedBy", news.UpdatedBy));
                        command.Parameters.Add(
                            new SqlParameter("@Album", news.Album));

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
    public int UpdateAlumniMeet(List<pmualum> LstNews, int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstNews != null && LstNews.Count > 0)
            {
                foreach (pmualum news in LstNews)
                {
                    using (SqlCommand command = new SqlCommand("UpdateAlumniMeet", cnn))
                    {
                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(
                            new SqlParameter("@EventId", ID));
                        command.Parameters.Add(
                            new SqlParameter("@Title", news.Title.Trim()));
                        command.Parameters.Add(
                            new SqlParameter("@Description", news.Description));
                        command.Parameters.Add(
                            new SqlParameter("@Venue", news.Venue));
                        command.Parameters.Add(
                            new SqlParameter("@EventStartDate", news.EventStartDate));
                        command.Parameters.Add(
                            new SqlParameter("@Active", news.Status));
                        command.Parameters.Add(
                            new SqlParameter("@UpdatedDate", news.UpdatedDate));
                        command.Parameters.Add(
                            new SqlParameter("@UpdatedBy", news.UpdatedBy));
                        command.Parameters.Add(
                            new SqlParameter("@Album", news.Album));
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

    public int DeleteAlumniMeet(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteAlumniMeet", cnn))
                {

                    // Add new SqlParameter to the command.

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@EventId", ID));
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
    public int UpdateAlumniMeetStatus(int ID,string updatedBy,DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateAlumniMeetStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@EventId", ID));
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
    public DataSet ViewAlumniMeet()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAlumniMeet", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;                
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
    public DataSet ViewActiveAlumniMeet()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveAlumniMeet", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
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

    public DataSet ViewAlumniMeetByDate()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAlumniMeetByDate", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;                
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
    public DataSet ViewAlumniMeetById(int ID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAlumniMeetById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@EventId", ID));
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
    
    public DataSet ViewActiveAlumniMeetById(int ID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveAlumniMeetById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@EventId", ID));
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