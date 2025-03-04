using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for nata2023
/// </summary>
public class nata2023
{
    public int Sno { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string MobileNo { get; set; }
    public string City { get; set; }
    public string TestTaken{ get; set; }
    public string Studying{ get; set; }
    public string PageSource{ get; set; }

    public DateTime AddedDate { get; set; }
    public nata2023()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string GetSqlConnection()
    {
        string connectionString = null;
        try
        {

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connectionString;
    }
    public int AddNata2023Registrations(nata2023 nata)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddNata2023Registrations", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Name", nata.Name));
                command.Parameters.Add(new SqlParameter("@EmailId", nata.EmailId));
                command.Parameters.Add(new SqlParameter("@MobileNo", nata.MobileNo));
                
                command.Parameters.Add(new SqlParameter("@City", nata.City));
                command.Parameters.Add(new SqlParameter("@PageSource", nata.PageSource));
                command.Parameters.Add(new SqlParameter("@TestTaken", nata.TestTaken));
                command.Parameters.Add(new SqlParameter("@AddedDate", nata.AddedDate));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewAllNata2023Enquiries()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllNata2023Enquiries", cnn))
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