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
public class internships
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string MobileNo { get; set; }
    public string CompanyContactNo { get; set; }
    public string CompanyName { get; set; }
    public string CompanyEmailId { get; set; }
    public string Duration { get; set; }
    public string Deliverables { get; set; }
    public string JDUrl { get; set; }
    public bool Active { get; set; }
    public string PostedBy { get; set; }
    public DateTime PostedDate { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public internships()
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
    public int AddInternships(List<internships> Lstinternships)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (Lstinternships != null && Lstinternships.Count > 0)
            {
                foreach (internships recur in Lstinternships)
                {
                    using (SqlCommand command = new SqlCommand("AddInternships", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                       
                        command.Parameters.Add(
                      new SqlParameter("@Name", recur.Name));
                        command.Parameters.Add(
                     new SqlParameter("@EmailId", recur.EmailId));
                        command.Parameters.Add(
                     new SqlParameter("@MobileNo", recur.MobileNo));
                        command.Parameters.Add(
                    new SqlParameter("@CompanyContactNo", recur.CompanyContactNo));
                        command.Parameters.Add(
                   new SqlParameter("@CompanyName", recur.CompanyName));
                        command.Parameters.Add(
                  new SqlParameter("@CompanyEmailId", recur.CompanyEmailId));
                        command.Parameters.Add(
                  new SqlParameter("@Duration", recur.Duration));
                        command.Parameters.Add(
                new SqlParameter("@Deliverables", recur.Deliverables));
                        command.Parameters.Add(
                new SqlParameter("@JDUrl", recur.JDUrl));
                        command.Parameters.Add(
                           new SqlParameter("@Active", recur.Active));
                        command.Parameters.Add(
                          new SqlParameter("@PostedBy", recur.PostedBy));
                        command.Parameters.Add(
                         new SqlParameter("@PostedDate", recur.PostedDate));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", recur.UpdatedBy));
                        command.Parameters.Add(
                           new SqlParameter("@UpdatedDate", recur.UpdatedDate));
                       
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
    public int UpdateInternships(List<internships> Lstinternships, int Id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
            if (Lstinternships != null && Lstinternships.Count > 0)
            {
                foreach (internships recur in Lstinternships)
                {
                    using (SqlCommand command = new SqlCommand("UpdateInternships", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(
                       new SqlParameter("@Name", recur.Name));
                        command.Parameters.Add(
                     new SqlParameter("@EmailId", recur.EmailId));
                        command.Parameters.Add(
                     new SqlParameter("@MobileNo", recur.MobileNo));
                        command.Parameters.Add(
                    new SqlParameter("@CompanyContactNo", recur.CompanyContactNo));
                        command.Parameters.Add(
                   new SqlParameter("@CompanyName", recur.CompanyName));
                        command.Parameters.Add(
                  new SqlParameter("@CompanyEmailId", recur.CompanyEmailId));
                        command.Parameters.Add(
                  new SqlParameter("@Duration", recur.Duration));
                        command.Parameters.Add(
                new SqlParameter("@Deliverables", recur.Deliverables));
                        command.Parameters.Add(
                new SqlParameter("@JDUrl", recur.JDUrl));
                        command.Parameters.Add(
                           new SqlParameter("@Active", recur.Active));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", recur.UpdatedBy));
                        command.Parameters.Add(
                           new SqlParameter("@UpdatedDate", recur.UpdatedDate));
                        command.Parameters.Add(
                         new SqlParameter("@Sno", Id));
                        rowsAffected = command.ExecuteNonQuery();


                    }
                    cnn.Close();
                }


            }
        //}
        //catch (Exception ex)
        //{
        //}
        return rowsAffected;
    }
    public int UpdateInternshipStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            using (SqlCommand command = new SqlCommand("UpdateInternshipStatus", cnn))
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
    public int DeleteInternships(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteInternships", cnn))
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

    public DataSet ViewInternshipById(int ID)
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

                using (SqlCommand command = new SqlCommand("ViewInternshipById", cnn))
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
   
    public DataSet ViewActiveInternships()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewActiveInternships", cnn))
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
       
 
    public DataSet ViewAllInternships()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllInternships", cnn))
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
    public DataSet ViewInactiveInternships()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewInactiveInternships", cnn))
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
    public DataSet ViewTop2Internship()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewTop2Internship", cnn))
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