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
public class iqacsection
{
    public int Id { get; set; }
    public string Section { get; set; }
    public string SubSection { get; set; }
    public int DisplayOrder { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public iqacsection()
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
    public int AddAddIqacSection(List<iqacsection> LstNaaccriteria)
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
                foreach (iqacsection iqac in LstNaaccriteria)
                {
                    using (SqlCommand command = new SqlCommand("AddIqacSection", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                       
                        command.Parameters.Add(
                      new SqlParameter("@Section", iqac.Section));
                        command.Parameters.Add(
                     new SqlParameter("@SubSection", iqac.SubSection));
                        command.Parameters.Add(
                     new SqlParameter("@DisplayOrder", iqac.DisplayOrder));
                        command.Parameters.Add(
                           new SqlParameter("@Active", iqac.Active));
                        command.Parameters.Add(
                          new SqlParameter("@AddedBy", iqac.AddedBy));
                        command.Parameters.Add(
                         new SqlParameter("@AddedDateTime", iqac.AddedDateTime));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", iqac.UpdatedBy));
                        command.Parameters.Add(
                           new SqlParameter("@UpdatedDateTime", iqac.UpdatedDateTime));
                       
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
    public int UpdateSection(List<iqacsection> LstNaaccriteria,int Id)
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
                foreach (iqacsection iqac in LstNaaccriteria)
                {
                    using (SqlCommand command = new SqlCommand("UpdateIqacSection", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(
                      new SqlParameter("@Section", iqac.Section));
                        command.Parameters.Add(
                     new SqlParameter("@SubSection", iqac.SubSection));
                        command.Parameters.Add(
                     new SqlParameter("@DisplayOrder", iqac.DisplayOrder));
                        command.Parameters.Add(
                           new SqlParameter("@Active", iqac.Active));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", iqac.UpdatedBy));
                        command.Parameters.Add(
                           new SqlParameter("@UpdatedDateTime", iqac.UpdatedDateTime));
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
    public int UpdateIqacSectionStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            using (SqlCommand command = new SqlCommand("UpdateIqacSectionStatus", cnn))
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
    public int DeleteIqacSection(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteIqacSection", cnn))
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

    public DataSet ViewIqacSectionById(int ID)
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

                using (SqlCommand command = new SqlCommand("ViewIqacSectionById", cnn))
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
    public DataSet ViewIqacSectionByTitle(string section,string stTitle)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewIqacSectionByTitle", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@SubSection", stTitle));
                command.Parameters.Add(
                                         new SqlParameter("@Section", section));
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
    public DataSet ViewAllIqacSection()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllIqacSection", cnn))
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
       
 
    public DataSet ViewActiveIqacSection(string stSection)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewActiveIqacSection", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                          new SqlParameter("@Section", stSection));
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
    public DataSet ViewIqacSectionBySection(string stSection)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewIqacSectionBySection", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                          new SqlParameter("@Section", stSection));
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
    public DataSet ViewMaxIqacSection(string stSection)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMaxIqacSection", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                         new SqlParameter("@Section", stSection));
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
    public DataSet GetIqacSectionDisplayOrderWay1(int fromDisplayOrder, int toDisplayOrder, string stSection)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetIqacSectionDisplayOrderWay1", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                    new SqlParameter("@Section", stSection));
               
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
    public DataSet GetIqacSectionDisplayOrderWay2(int fromDisplayOrder, int toDisplayOrder, string stSection)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetIqacSectionDisplayOrderWay2", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                    new SqlParameter("@Section", stSection));
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
    public int UpdateIqacSectionDisplayOrder(int Sno, int DisplayOrder, string UpdatedBy)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateIqacSectionDisplayOrder", cnn))
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
    public DataSet IsIqacSectionDisplayOrderExists(int displayOrder, string stSection)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("IsIqacSectionDisplayOrderExists", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@DisplayOrder", displayOrder));
                command.Parameters.Add(
                                     new SqlParameter("@Section", stSection));
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
    public DataSet GetIqacSectionDisplayOrderForInsert(int fromDisplayOrder, int toDisplayOrder, string stSection)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetIqacSectionDisplayOrderForInsert", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                     new SqlParameter("@Section", stSection));
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
    public DataSet GetIqacSectionDisplayOrderForDelete(int fromDisplayOrder, int toDisplayOrder,string stSection)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetIqacSectionDisplayOrderForDelete", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                     new SqlParameter("@Section", stSection));
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