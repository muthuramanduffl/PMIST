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
public class PeriyarquizRegistration
{
    public int RegValue { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string ContactNo { get; set; }
    public string DOB { get; set; }
    public string AreYou { get; set; }
    public string AddrLine1 { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public DateTime PostedDate { get; set; }

    public PeriyarquizRegistration()
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
   


    public int AddRegistration(PeriyarquizRegistration reg)
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
                using (SqlCommand command = new SqlCommand("spAddRegistration", cnn))
                {

                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                     new SqlParameter("@RegValue", RegValue));
                command.Parameters.Add(
                   new SqlParameter("@FirstName", FirstName));
                command.Parameters.Add(
                   new SqlParameter("@LastName", LastName));
                command.Parameters.Add(
                   new SqlParameter("@EmailAddress", EmailAddress));
                command.Parameters.Add(
                  new SqlParameter("@ContactNo", ContactNo));
                command.Parameters.Add(
                  new SqlParameter("@DOB", DOB));
                command.Parameters.Add(
                  new SqlParameter("@AreYou", AreYou));
                command.Parameters.Add(
                  new SqlParameter("@AddrLine1", AddrLine1));
                command.Parameters.Add(
                new SqlParameter("@Country", Country));
                command.Parameters.Add(
                 new SqlParameter("@City", City));
                command.Parameters.Add(
                 new SqlParameter("@State", State));
                command.Parameters.Add(
                 new SqlParameter("@ZipCode", ZipCode));
                command.Parameters.Add(
                new SqlParameter("@PhotoImage", string.Empty));
                command.Parameters.Add(
                new SqlParameter("@PostedDate", DateTime.Now));
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


    public DataSet ViewRegistration()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewRegistration", cnn))
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

    public DataSet ViewQuizTakenStudents(string filter)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            string sql = "SELECT R.RegID,FirstName,LastName,EmailAddress,ContactNo,Q.Language,Score,TakenDate FROM " +
                "(tblRegistration R JOIN tblScore S ON R.RegID = S.RegID) JOIN tblQuizLevels Q ON Q.Quizno = S.Quizno" + filter;
            //using (SqlCommand command = new SqlCommand("spViewQuizTakenStudents", cnn))
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                cnn.Open();
                command.ExecuteNonQuery();
                // command.CommandType = CommandType.StoredProcedure;
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