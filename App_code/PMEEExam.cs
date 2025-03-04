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
public class PMEEExam
{
    public int Sno { get; set; }
    public string RegId { get; set; }
    public string ExamName { get; set; }
    public string EmailId { get; set; }
    public DateTime ExamDate { get; set; }
    public string ExamTakenTime { get; set; }
    public string SelAnswers { get; set; }
    public int AttemptedQuestion { get; set; }
    public int UnAttemptedQuestion { get; set; }
    public string Score { get; set; }
    public string Status { get; set; }
    public string Questions { get; set; }
   
    public PMEEExam()
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
   
    public int AddExam(PMEEExam reg)
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
                using (SqlCommand command = new SqlCommand("AddPMEEExam", cnn))
                {

                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RegId", reg.RegId));
                    command.Parameters.Add(new SqlParameter("@ExamName", reg.ExamName));
                    command.Parameters.Add(
                       new SqlParameter("@EmailId", reg.EmailId));
                    command.Parameters.Add(
                       new SqlParameter("@Status", reg.Status));
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
    
   
}