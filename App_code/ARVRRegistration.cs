using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for MarathonRegistration
/// </summary>
public class ARVRRegistration
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Youare { get; set; }
    public string PreferredLocation { get; set; }
    public string Phoneno { get; set; }
    public string Emailid { get; set; }

    public DateTime regDate { get; set; }
    public string Source { get; set; }

    public ARVRRegistration()
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

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMULead"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connectionString;
    }

    
    public int AddARVRRegistration(ARVRRegistration reg)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        int RegID = 0;
        try
        {
            if (reg != null)
            {
                using (SqlCommand command = new SqlCommand("AddARVRRegistration", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(
                        new SqlParameter("@Name", reg.Name));
                    command.Parameters.Add(
                        new SqlParameter("@Location", reg.Location));
                    command.Parameters.Add(
                        new SqlParameter("@Phoneno", reg.Phoneno));
                    command.Parameters.Add(
                        new SqlParameter("@Youare", reg.Youare));
                    command.Parameters.Add(
                        new SqlParameter("@PreferredLocation", reg.PreferredLocation));
                    command.Parameters.Add(
                        new SqlParameter("@Source", reg.Source));
                    command.Parameters.Add(
                        new SqlParameter("@Emailid", reg.Emailid));
                    command.Parameters.Add(
                        new SqlParameter("@AddedDate", reg.regDate));

                    rowsAffected = command.ExecuteNonQuery();

                }
                cnn.Close();
            }
        }

        catch (Exception ex)
        {
        }
        return RegID;
    }
}