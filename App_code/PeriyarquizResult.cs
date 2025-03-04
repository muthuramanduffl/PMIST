using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for periyarquiz
/// </summary>
public class PeriyarquizResult
{
    public string Name { get; set; }
    public string CentreName { get; set; }
    public string CentreCode { get; set; }
    public string Barcode{ get; set; }
    public string DistrictCode { get; set; }
    public string DistrictName { get; set; }
    public string MobileNo { get; set; }
    public string BulkUpload { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDate { get; set; }
    public string Marks { get; set; }


    
    public PeriyarquizResult()
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

            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["Periyar1000English"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connetionString;
    }
    

    public int AddOfflineQuizResultDetails(PeriyarquizResult reg)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddOfflineQuizResultDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@Name", reg.Name));
                command.Parameters.Add(
            new SqlParameter("@Barcode", reg.Barcode));
            command.Parameters.Add(
            new SqlParameter("@CentreCode", reg.CentreCode));
                command.Parameters.Add(
            new SqlParameter("@CentreName", reg.CentreName));
                command.Parameters.Add(
            new SqlParameter("@DistrictName", reg.DistrictName));
                command.Parameters.Add(
            new SqlParameter("@DistrictCode", reg.DistrictCode));
                command.Parameters.Add(
            new SqlParameter("@Marks", reg.Marks));
                command.Parameters.Add(
            new SqlParameter("@MobileNo", reg.MobileNo));
                command.Parameters.Add(
            new SqlParameter("@AddedBy", reg.AddedBy));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", reg.AddedDate));
                command.Parameters.Add(
           new SqlParameter("@BulkUpload", reg.BulkUpload));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public DataSet ViewQuizStudentResultAlreadyExists(string stbarcode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewQuizStudentResultAlreadyExists", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Barcode", stbarcode));


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

    public DataSet ViewValidStudLogin(string stbarcode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidStudLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Barcode", stbarcode));


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

    public DataSet ViewOfflineQuizResultByBarcode(string stbarcode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewOfflineQuizResultByBarcode", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Barcode", stbarcode));


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