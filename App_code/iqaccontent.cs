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
public class iqaccontent
{
    public int Id { get; set; }
    public string Section { get; set; }
    public int SubSectionId { get; set; }
    public string PdfName { get; set; }
    public string PdfUrl { get; set; }
    public int DisplayOrder { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public iqaccontent()
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
    public int AddIqacContent(List<iqaccontent> LstNaaccriteria)
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
                foreach (iqaccontent iqac in LstNaaccriteria)
                {
                    using (SqlCommand command = new SqlCommand("AddIqacContent", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                       
                        command.Parameters.Add(
                      new SqlParameter("@Section", iqac.Section));
                        command.Parameters.Add(
                     new SqlParameter("@SubSectionId", iqac.SubSectionId));
                        command.Parameters.Add(
                    new SqlParameter("@PdfName", iqac.PdfName));
                        command.Parameters.Add(
                   new SqlParameter("@PdfUrl", iqac.PdfUrl));
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
    public int UpdateIqacContent(List<iqaccontent> LstNaaccriteria,int Id)
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
                foreach (iqaccontent iqac in LstNaaccriteria)
                {
                    using (SqlCommand command = new SqlCommand("UpdateIqacContent", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(
                       new SqlParameter("@Section", iqac.Section));
                        command.Parameters.Add(
                     new SqlParameter("@SubSectionId", iqac.SubSectionId));
                        command.Parameters.Add(
                    new SqlParameter("@PdfName", iqac.PdfName));
                        command.Parameters.Add(
                   new SqlParameter("@PdfUrl", iqac.PdfUrl));
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
    public int UpdateIqacContentStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            using (SqlCommand command = new SqlCommand("UpdateIqacContentStatus", cnn))
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
    public int DeleteIqacContent(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteIqacContent", cnn))
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

    public DataSet ViewIqacContentById(int ID)
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

                using (SqlCommand command = new SqlCommand("ViewIqacContentById", cnn))
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
   
    public DataSet ViewAllIqacContent()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllIqacContent", cnn))
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
       
 
    public DataSet ViewActiveIqacContent(string stSection,int subSectionId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewActiveIqacContent", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                          new SqlParameter("@Section", stSection));
                command.Parameters.Add(
                                          new SqlParameter("@SubSectionId", subSectionId));
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
    public DataSet ViewIqacContent(string stSection, int subSectionId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewIqacContent", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                          new SqlParameter("@Section", stSection));
                command.Parameters.Add(
                                          new SqlParameter("@SubSectionId", subSectionId));
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
    public DataSet ViewMaxIqaccontent(string stSection, int subSectionId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMaxIqaccontent", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                         new SqlParameter("@Section", stSection));
                command.Parameters.Add(
                                        new SqlParameter("@SubSectionId", subSectionId));
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds);


            }
            cnn.Close();

        //}
        //catch (Exception ex)
        //{
        //}
        return ds;
    }
    public DataSet GetIqaccontentDisplayOrderWay1(int fromDisplayOrder, int toDisplayOrder, string stSection, int subSectionId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetIqaccontentDisplayOrderWay1", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                        new SqlParameter("@Section", stSection));
                command.Parameters.Add(
                                        new SqlParameter("@SubSectionId", subSectionId));

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
    public DataSet GetIqaccontentDisplayOrderWay2(int fromDisplayOrder, int toDisplayOrder, string stSection, int subSectionId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetIqaccontentDisplayOrderWay2", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                       new SqlParameter("@Section", stSection));
                command.Parameters.Add(
                                        new SqlParameter("@SubSectionId", subSectionId));
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
    public int UpdateIqacContentDisplayOrder(int Sno, int DisplayOrder, string UpdatedBy)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateIqacContentDisplayOrder", cnn))
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
    public DataSet IsIqaccontentDisplayOrderExists(int displayOrder, string stSection, int subSectionId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("IsIqaccontentDisplayOrderExists", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@DisplayOrder", displayOrder));
                command.Parameters.Add(
                                     new SqlParameter("@Section", stSection));

                command.Parameters.Add(
                                       new SqlParameter("@SubSectionId", subSectionId));
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
    public DataSet GetIqaccontentDisplayOrderForInsert(int fromDisplayOrder, int toDisplayOrder, string stSection, int subSectionId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetIqaccontentDisplayOrderForInsert", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                     new SqlParameter("@Section", stSection));
                command.Parameters.Add(
                                      new SqlParameter("@SubSectionId", subSectionId));
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
    public DataSet GetIqaccontentDisplayOrderForDelete(int fromDisplayOrder, int toDisplayOrder,string stSection, int subSectionId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetIqaccontentDisplayOrderForDelete", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrder", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrder", toDisplayOrder));
                command.Parameters.Add(
                                     new SqlParameter("@Section", stSection));
                command.Parameters.Add(
                                     new SqlParameter("@SubSectionId", subSectionId));
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