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
public class pmuevents
{
    public int EventId { get; set; }
    public string Title { get; set; }
    public string Department { get; set; }
    public string ShortAbstract { get; set; }
    public string NewsImage { get; set; }
    public string NewsContent { get; set; }
    public DateTime EventStartDate { get; set; }
    public DateTime EventEndDate { get; set; }
    public bool Status { get; set; }
    public DateTime PostedDate { get; set; }
    public string PostedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string UpdatedBy { get; set; }
    public string pdf1 { get; set; }
    public string pdf2 { get; set; }
    public string pdf3 { get; set; }
    public bool ShowHomePage { get; set; }
    public pmuevents()
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
    public int AddEvents(List<pmuevents> LstNews)
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
                foreach (pmuevents news in LstNews)
                {
                    using (SqlCommand command = new SqlCommand("AddEvent", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                       new SqlParameter("@Title", news.Title.Trim()));
                        command.Parameters.Add(
                           new SqlParameter("@Department", news.Department));
                        command.Parameters.Add(
                          new SqlParameter("@ShortAbstract", news.ShortAbstract));
                        command.Parameters.Add(
                          new SqlParameter("@NewsImage", news.NewsImage));
                        command.Parameters.Add(
                           new SqlParameter("@NewsContent", news.NewsContent));
                        command.Parameters.Add(
                   new SqlParameter("@EventStartDate", news.EventStartDate));
                        command.Parameters.Add(
                          new SqlParameter("@EventEndDate", news.EventEndDate));
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
                       new SqlParameter("@pdf1", news.pdf1));
                        command.Parameters.Add(
                       new SqlParameter("@pdf2", news.pdf2));
                        command.Parameters.Add(
                       new SqlParameter("@pdf3", news.pdf3));
                        command.Parameters.Add(
                       new SqlParameter("@ShowHomePage", news.ShowHomePage));
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
    public int UpdateEvents(List<pmuevents> LstNews, int ID)
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
                foreach (pmuevents news in LstNews)
                {
                    using (SqlCommand command = new SqlCommand("UpdateEvent", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                       new SqlParameter("@Title", news.Title.Trim()));
                        command.Parameters.Add(
                           new SqlParameter("@Department", news.Department));
                        command.Parameters.Add(
                          new SqlParameter("@ShortAbstract", news.ShortAbstract));
                        command.Parameters.Add(
                          new SqlParameter("@NewsImage", news.NewsImage));
                        command.Parameters.Add(
                           new SqlParameter("@NewsContent", news.NewsContent));
                        command.Parameters.Add(
                   new SqlParameter("@EventStartDate", news.EventStartDate));
                        command.Parameters.Add(
                          new SqlParameter("@EventEndDate", news.EventEndDate));                        
                        command.Parameters.Add(
                         new SqlParameter("@Active", news.Status));
                        command.Parameters.Add(
                       new SqlParameter("@UpdatedDate", news.UpdatedDate));
                        command.Parameters.Add(
                        new SqlParameter("@UpdatedBy", news.UpdatedBy));
                        command.Parameters.Add(
                        new SqlParameter("@EventId", ID));
                        command.Parameters.Add(
                      new SqlParameter("@pdf1", news.pdf1));
                        command.Parameters.Add(
                       new SqlParameter("@pdf2", news.pdf2));
                        command.Parameters.Add(
                       new SqlParameter("@pdf3", news.pdf3));
                        command.Parameters.Add(
                       new SqlParameter("@ShowHomePage", news.ShowHomePage));
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

    public int DeleteEvents(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteEvent", cnn))
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
    public int UpdateEventStatus(int ID,string updatedBy,DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateEventStatus", cnn))
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
    public DataSet ViewEvents()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewEvents", cnn))
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
    public DataSet ViewActiveEvents()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveEvents", cnn))
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
    public DataSet ViewTopActiveEvents()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewTopActiveEvents", cnn))
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
    public DataSet ViewEventsByDate()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewEventsByDate", cnn))
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
    public DataSet ViewEventsById(int ID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewEventsById", cnn))
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
    public DataSet ViewEventsByDepartment(string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewEventsByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Department", stDepartment));
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

    public DataSet ViewAllEventsByDepartment(string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllEventsByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("Department", stDepartment));
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

    public void GetPreviousAndNextArticles(DateTime dt, out int PreviousID, out int NextID, out string strPreviousTitle, out string strNextTitle)
    {
        DataTable dTable = new DataTable();
        DataSet ds = new DataSet();
        PreviousID = 0;
        NextID = 0;
        strPreviousTitle = string.Empty;
        strNextTitle = string.Empty;
        SqlConnection cnn;
        string connetionString = null;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("spNextAndPreviousRecord", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                         new SqlParameter("@PostedDate", dt));

                command.Parameters.Add("@PrevRecord", SqlDbType.Int, 4);
                command.Parameters.Add("@NextRecord", SqlDbType.Int, 4);
                command.Parameters.Add("@PreviousTitle", SqlDbType.NVarChar, 500);
                command.Parameters.Add("@NextTitle", SqlDbType.NVarChar, 500);
                command.Parameters["@PrevRecord"].Direction = ParameterDirection.Output;
                command.Parameters["@NextRecord"].Direction = ParameterDirection.Output;
                command.Parameters["@PreviousTitle"].Direction = ParameterDirection.Output;
                command.Parameters["@NextTitle"].Direction = ParameterDirection.Output;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);
                // totalCount = int.Parse(db.GetParameterValue(dbcmd, "totalCount").ToString());
                PreviousID = Convert.ToInt32(command.Parameters["@PrevRecord"].Value);
                NextID = Convert.ToInt32(command.Parameters["@NextRecord"].Value);
                strPreviousTitle = Convert.ToString(command.Parameters["@PreviousTitle"].Value);
                strNextTitle = Convert.ToString(command.Parameters["@NextTitle"].Value);
            }
            cnn.Close();

        }
        catch (Exception ex)
        {

        }

    }
    public void GetPreviousAndNextArticlesByDepartment(DateTime dt, out int PreviousID, out int NextID, out string strPreviousTitle, out string strNextTitle,string stDepartment)
    {
        DataTable dTable = new DataTable();
        DataSet ds = new DataSet();
        PreviousID = 0;
        NextID = 0;
        strPreviousTitle = string.Empty;
        strNextTitle = string.Empty;
        SqlConnection cnn;
        string connetionString = null;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("spNextAndPreviousRecordByDepartment", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                         new SqlParameter("@PostedDate", dt));
                command.Parameters.Add(
                                         new SqlParameter("@Department", stDepartment));

                command.Parameters.Add("@PrevRecord", SqlDbType.Int, 4);
                command.Parameters.Add("@NextRecord", SqlDbType.Int, 4);
                command.Parameters.Add("@PreviousTitle", SqlDbType.NVarChar, 500);
                command.Parameters.Add("@NextTitle", SqlDbType.NVarChar, 500);

                command.Parameters["@PrevRecord"].Direction = ParameterDirection.Output;
                command.Parameters["@NextRecord"].Direction = ParameterDirection.Output;
                command.Parameters["@PreviousTitle"].Direction = ParameterDirection.Output;
                command.Parameters["@NextTitle"].Direction = ParameterDirection.Output;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);
                // totalCount = int.Parse(db.GetParameterValue(dbcmd, "totalCount").ToString());
                PreviousID = Convert.ToInt32(command.Parameters["@PrevRecord"].Value);
                NextID = Convert.ToInt32(command.Parameters["@NextRecord"].Value);
                strPreviousTitle = Convert.ToString(command.Parameters["@PreviousTitle"].Value);
                strNextTitle = Convert.ToString(command.Parameters["@NextTitle"].Value);
            }
            cnn.Close();

        }
        catch (Exception ex)
        {

        }

    }

}