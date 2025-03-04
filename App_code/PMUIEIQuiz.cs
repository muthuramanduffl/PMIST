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
public class PMUIEIQuiz
{
    public int Sno { get; set; }
    public string EmailId { get; set; }
    public string Questions { get; set; }
    public string SelAnswers { get; set; }
    public int AttemptedQuestion { get; set; }
    public int UnAttemptedQuestion { get; set; }
    public string Score { get; set; }
    public DateTime QuizTakenDate { get; set; }
    public string QuizTakenTime { get; set; }
    public string Status { get; set; }
    public string Levels { get; set; }
    
    public PMUIEIQuiz()
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
   
    public int AddIEIQuiz(PMUIEIQuiz Quiz)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (Quiz != null)
            {
                using (SqlCommand command = new SqlCommand("spAddIEIQuiz", cnn))
                {

                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@EmailId", Quiz.EmailId));
                    command.Parameters.Add(
                       new SqlParameter("@Questions", Quiz.Questions));
                    command.Parameters.Add(
                       new SqlParameter("@SelAnswers", Quiz.SelAnswers));
                    command.Parameters.Add(
                      new SqlParameter("@AttemptedQuestion", Quiz.AttemptedQuestion));
                    command.Parameters.Add(
                          new SqlParameter("@UnAttemptedQuestion", Quiz.UnAttemptedQuestion));
                    command.Parameters.Add(
                      new SqlParameter("@Score", Quiz.Score));
                    command.Parameters.Add(
                       new SqlParameter("@QuizTakenDate", Quiz.QuizTakenDate));
                    command.Parameters.Add(
                     new SqlParameter("@QuizTakenTime", Quiz.QuizTakenTime));
                    command.Parameters.Add(
                    new SqlParameter("@Status", Quiz.Status));
                    command.Parameters.Add(
                    new SqlParameter("@Levels", Quiz.Levels));
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
    public int AddIEIQuiz1(PMUIEIQuiz Quiz)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
            if (Quiz != null)
            {
                using (SqlCommand command = new SqlCommand("spAddIEIQuiz1", cnn))
                {

                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@EmailId", Quiz.EmailId));
                    command.Parameters.Add(
                       new SqlParameter("@QuizTakenDate", Quiz.QuizTakenDate));
                    command.Parameters.Add(
                       new SqlParameter("@Status", Quiz.Status));
                    command.Parameters.Add(
                      new SqlParameter("@Levels", Quiz.Levels));
                    rowsAffected = command.ExecuteNonQuery();

                }
                cnn.Close();
            }


        //}

        //catch (Exception ex)
        //{
        //}
        return rowsAffected;
    }
    public int UpdateIEIQuiz(PMUIEIQuiz Quiz)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (Quiz != null)
            {
                using (SqlCommand command = new SqlCommand("spUpdateIEIQuiz", cnn))
                {

                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@EmailId", Quiz.EmailId));
                    command.Parameters.Add(
                       new SqlParameter("@Questions", Quiz.Questions));
                    command.Parameters.Add(
                       new SqlParameter("@SelAnswers", Quiz.SelAnswers));
                    command.Parameters.Add(
                      new SqlParameter("@AttemptedQuestion", Quiz.AttemptedQuestion));
                    command.Parameters.Add(
                      new SqlParameter("@UnAttemptedQuestion", Quiz.UnAttemptedQuestion));
                    command.Parameters.Add(
                      new SqlParameter("@Score", Quiz.Score));
                    command.Parameters.Add(
                      new SqlParameter("@QuizTakenTime", Quiz.QuizTakenTime));
                    command.Parameters.Add(
                      new SqlParameter("@Status", Quiz.Status));
                    command.Parameters.Add(
                      new SqlParameter("@Levels", Quiz.Levels));
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
    public DataSet ViewIEIQuiz(string stLevels, string stSubject)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewIEIQuiz", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Levels", stLevels));
                command.Parameters.Add(
                                     new SqlParameter("@Subject", stSubject));
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
    public DataSet ViewIEIQuizByEmailID(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewIEIQuizByEmailID", cnn))
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
    public DataSet ViewIEITestTakenDetails(string stStandard)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewIEITestTakenDetails", cnn))
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
    public DataSet ViewIEITestNotTakenDetails(string stStandard)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewIEITestNotTakenDetails", cnn))
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
    public DataSet ViewAllIEITestDetails(string stStandard)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewAllIEITestDetails", cnn))
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
    public DataSet ViewIEITestInProgressDetails(string stStandard)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spViewIEITestInProgressDetails", cnn))
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