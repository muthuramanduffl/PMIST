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
public class pmuconsultant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PromoCode { get; set; }
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDateTime { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public pmuconsultant()
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

            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMULead"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connetionString;
    }
    public int AddConsultant(pmuconsultant consultant)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddConsutant", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@Name", consultant.Name));
                command.Parameters.Add(
             new SqlParameter("@PromoCode", consultant.PromoCode));
                command.Parameters.Add(
           new SqlParameter("@Status", consultant.Active));
                command.Parameters.Add(
                  new SqlParameter("@AddedBy", consultant.AddedBy));
                command.Parameters.Add(
                 new SqlParameter("@AddedDate", consultant.AddedDateTime));
                command.Parameters.Add(
                 new SqlParameter("@UpdatedBy", consultant.UpdatedBy));
                command.Parameters.Add(
                   new SqlParameter("@UpdatedDate", consultant.UpdatedDateTime));

                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
   
    public DataSet ViewConsultantByCode(string stCode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewConsultantByCode", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@PromoCode", stCode));

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

   
    public DataSet ViewConsultant()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewConsultant", cnn))
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