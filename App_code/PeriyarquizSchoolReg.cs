using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for periyarquiz
/// </summary>
public class PeriyarquizSchoolReg
{
    public string SchoolName { get; set; }
    public string Location { get; set; }
    public string Board { get; set; }
    public string TotalStud { get; set; }
    public string ExamDate { get; set; }
    public string Headmaster { get; set; }
    public string Coordinator { get; set; }
    public string StudDataFname { get; set; }
    public DateTime PostedDate { get; set; }
    public string StudID { get; set; }
    public string StudName { get; set; }
    public string Gender { get; set; }
    public DateTime DOB { get; set; }
    public string Class { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public string FName { get; set; }
    public string FMobile { get; set; }
    public string Pincode { get; set; }
    public string Address { get; set; }
    public string ReceiptNo { get; set; }
    
    public PeriyarquizSchoolReg()
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
    

    public int AddQuizSchoolReg(PeriyarquizSchoolReg reg)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddQuizSchoolReg", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@SchoolName", reg.SchoolName));
                command.Parameters.Add(
            new SqlParameter("@Location", reg.Location));
                command.Parameters.Add(
            new SqlParameter("@Board", reg.Board));
                command.Parameters.Add(
            new SqlParameter("@TotalStud", reg.TotalStud));
                command.Parameters.Add(
            new SqlParameter("@ExamDate", reg.ExamDate));
                command.Parameters.Add(
            new SqlParameter("@Headmaster", reg.Headmaster));
                command.Parameters.Add(
            new SqlParameter("@Coordinator", reg.Coordinator));
                command.Parameters.Add(
            new SqlParameter("@StudDataFname", reg.StudDataFname));
                command.Parameters.Add(
            new SqlParameter("@PostedDate", reg.PostedDate));
                command.Parameters.Add(
           new SqlParameter("@ReceiptNo", reg.ReceiptNo));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int AddQuizStudentDetails(PeriyarquizSchoolReg reg)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddQuizStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                //StudID generated in the stored procedure itself
                //    command.Parameters.Add(
                //new SqlParameter("@StudID", reg.StudID));
                command.Parameters.Add(
            new SqlParameter("@StudName", reg.StudName));
                command.Parameters.Add(
            new SqlParameter("@Gender", reg.Gender));
                command.Parameters.Add(
            new SqlParameter("@DOB", reg.DOB));
                command.Parameters.Add(
            new SqlParameter("@Class", reg.Class));
                command.Parameters.Add(
            new SqlParameter("@SchoolName", reg.SchoolName));
                command.Parameters.Add(
            new SqlParameter("@City", reg.City));
                command.Parameters.Add(
            new SqlParameter("@District", reg.District));
                command.Parameters.Add(
            new SqlParameter("@FathersName", reg.FName));
                command.Parameters.Add(
            new SqlParameter("@FMobileNo", reg.FMobile));
                command.Parameters.Add(
            new SqlParameter("@Pincode", reg.Pincode));
                command.Parameters.Add(
            new SqlParameter("@Address", reg.Address));
                command.Parameters.Add(
            new SqlParameter("@PostedDate", reg.PostedDate));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewQuizStudUniqIDExists(string stID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewQuizStudUniqIDExists", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@StudUniqID", stID));

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

    public DataSet ViewQuizStudentAlreadyExists(string ststudname, string stclass, string stfmobile)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewQuizStudentAlreadyExists", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Studname", ststudname));
                command.Parameters.Add(new SqlParameter("@class", stclass));
                command.Parameters.Add(new SqlParameter("@Fmobile", stfmobile));

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
    
    public DataSet ViewAllSchoolRegistrations()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllSchoolRegistrations", cnn))
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

    public DataSet ViewStudRegistrations()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStudRegistrations", cnn))
            {
                cnn.Open();
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

    
}