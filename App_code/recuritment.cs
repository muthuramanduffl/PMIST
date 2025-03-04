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
public class recuritment
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string MobileNo { get; set; }
    public string CompanyContactNo { get; set; }
    public string CompanyName { get; set; }
    public string CompanyEmailId { get; set; }
    public string Designation { get; set; }
    public string JobDetails { get; set; }
    public string JDUrl { get; set; }
    public bool Active { get; set; }
    public string PostedBy { get; set; }
    public DateTime PostedDate { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public recuritment()
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
    public int AddRecuritment(List<recuritment> Lstrecuritment)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (Lstrecuritment != null && Lstrecuritment.Count > 0)
            {
                foreach (recuritment recur in Lstrecuritment)
                {
                    using (SqlCommand command = new SqlCommand("AddRecuritment", cnn))
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
                  new SqlParameter("@Designation", recur.Designation));
                        command.Parameters.Add(
                new SqlParameter("@JobDetails", recur.JobDetails));
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
    public int UpdateRecuritment(List<recuritment> Lstrecuritment, int Id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
            if (Lstrecuritment != null && Lstrecuritment.Count > 0)
            {
                foreach (recuritment recur in Lstrecuritment)
                {
                    using (SqlCommand command = new SqlCommand("UpdateRecuritment", cnn))
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
                  new SqlParameter("@Designation", recur.Designation));
                        command.Parameters.Add(
                new SqlParameter("@JobDetails", recur.JobDetails));
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
    public int UpdateRecuritmentStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            using (SqlCommand command = new SqlCommand("UpdateRecuritmentStatus", cnn))
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
    public int DeleteRecuritment(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteRecuritment", cnn))
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

    public DataSet ViewRecuritmentById(int ID)
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

                using (SqlCommand command = new SqlCommand("ViewRecuritmentById", cnn))
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
   
    public DataSet ViewActiveRecuritment()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewActiveRecuritment", cnn))
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
       
 
    public DataSet ViewAllRecuritment()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllRecuritment", cnn))
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
    public DataSet ViewInactiveRecuritment()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewInactiveRecuritment", cnn))
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
    public DataSet ViewTop2Recuritment()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewTop2Recuritment", cnn))
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