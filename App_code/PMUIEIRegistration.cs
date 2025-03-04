using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

/// <summary>
/// Summary description for PMUIEIRegistration
/// </summary>
public class PMUIEIRegistration
{
    public int RegId { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string MobileNo { get; set; }
    public string DOB { get; set; }
    public string City { get; set; }
    public string Studying { get; set; }
    public string SchoolName { get; set; }
    public string Levels { get; set; }
    public string Password { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string Gender { get; set; }
    public PMUIEIRegistration()
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
   
    public int AddRegistration(PMUIEIRegistration reg)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (reg != null)
            {
                using (SqlCommand command = new SqlCommand("spAddIEIRegistration", cnn))
                {

                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Name", reg.Name));
                    command.Parameters.Add(
                       new SqlParameter("@EmailId", reg.EmailId));
                    command.Parameters.Add(
                       new SqlParameter("@MobileNo", reg.MobileNo));
                    command.Parameters.Add(
                      new SqlParameter("@DOB", reg.DOB));
                    command.Parameters.Add(
                          new SqlParameter("@City", reg.City));
                    command.Parameters.Add(
                      new SqlParameter("@Studying", reg.Studying));
                    command.Parameters.Add(
                       new SqlParameter("@SchoolName", reg.SchoolName));
                    command.Parameters.Add(
                     new SqlParameter("@Levels", reg.Levels));
                    command.Parameters.Add(
                    new SqlParameter("@Password", reg.Password));
                    command.Parameters.Add(
                    new SqlParameter("@RegistrationDate", reg.RegistrationDate));
                    command.Parameters.Add(
                   new SqlParameter("@Gender", reg.Gender));
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
    public DataSet ViewValidRegistration(string stEmailId, string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewValidRegistration", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@EmailID", stEmailId));
                command.Parameters.Add(
                                     new SqlParameter("@Password", stPassword));
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
    public DataSet ViewRegistrationByEmailID(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewIEIRegistrationByEmailID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@EmailID", stEmailId));
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
    public DataSet ViewRegistration()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewIEIRegistration", cnn))
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
    public DataSet ViewIEIRegistartionByDate(string stFromDate, string stToDate)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewIEIRegistartionByDate", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@RegDate", stFromDate));
                command.Parameters.Add(
                                      new SqlParameter("@RegToDate", stToDate));
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
    public DataSet ViewIEIRegistartionByStandard(string stStandard)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewIEIRegistartionByStandard", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Standard", stStandard));
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