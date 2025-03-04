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
public class PMEERegistration
{
    public int Sno { get; set; }
    public string RegId { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string PhoneNo { get; set; }
    public string WhatsAppNo { get; set; }
    public string DOB { get; set; }
    public string Gender { get; set; }
    public string SchoolName { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string ExamApplying { get; set; }
    public string Choice { get; set; }
    public string Medium { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string Password { get; set; }
    public PMEERegistration()
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
   
    public int AddRegistration(PMEERegistration reg)
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
                using (SqlCommand command = new SqlCommand("AddPMEERegistration", cnn))
                {

                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RegId", reg.RegId));
                    command.Parameters.Add(new SqlParameter("@Name", reg.Name));
                    command.Parameters.Add(
                       new SqlParameter("@EmailId", reg.EmailId));
                    command.Parameters.Add(
                       new SqlParameter("@MobileNo", reg.PhoneNo));
                    command.Parameters.Add(
                      new SqlParameter("@WhatsAppNo", reg.WhatsAppNo));
                    command.Parameters.Add(
                          new SqlParameter("@DOB", reg.DOB));
                    command.Parameters.Add(
                      new SqlParameter("@Gender", reg.Gender));
                    command.Parameters.Add(
                       new SqlParameter("@SchoolName", reg.SchoolName));
                    command.Parameters.Add(
                     new SqlParameter("@State", reg.State));
                    command.Parameters.Add(
                    new SqlParameter("@City", reg.City));
                    command.Parameters.Add(
                    new SqlParameter("@ExamApplying", reg.ExamApplying));
                    command.Parameters.Add(
                   new SqlParameter("@Choice", reg.Choice));
                    command.Parameters.Add(
                  new SqlParameter("@Medium", reg.Medium));
                    command.Parameters.Add(
                  new SqlParameter("@RegistrationDate", reg.RegistrationDate));
                    command.Parameters.Add(
                  new SqlParameter("@Password", reg.Password));
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
    
    public DataSet ViewPMEERegistrationByEmailID(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewPMEERegistrationByEmailID", cnn))
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
    public DataSet ViewMaxPMEERegistration()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMaxPMEERegistration", cnn))
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
    public DataSet ViewPMEEDetailsByRegId(string stRegId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewPMEEDetailsByRegId", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@RegId", stRegId));
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