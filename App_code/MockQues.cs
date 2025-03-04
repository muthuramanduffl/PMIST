using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for MockQues
/// </summary>
public class MockQues
{
    public string Question { get; set; }
    public string OptionA { get; set; }
    public string OptionB { get; set; }
    public string OptionC { get; set; }
    public string OptionD { get; set; }
    public string Answer { get; set; }
    public string Subject { get; set; }
    public string Medium { get; set; }
    public string QueImageBased { get; set; }
    public string AnsImageBased { get; set; }
    public DateTime PostedDateTime { get; set; }
    public string EmailId { get; set; }
    public DateTime ExamDate { get; set; }
    public string Status { get; set; }
    public string ExamName { get; set; }
    public string RegId { get; set; }
   // public string ExamName { get; set; }

    public string ExamTakenTime { get; set; }
    public string SelAnswers { get; set; }
    public int AttemptedQuestion { get; set; }
    public int UnAttemptedQuestion { get; set; }
    public string Score { get; set; }
    public string Questions { get; set; }
    public MockQues()
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
  
    public DataSet ViewMocktestSubjByGroup(string subjgroup)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMocktestSubjByGroup", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                   new SqlParameter("@group", subjgroup));
        
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
    public DataSet ViewMocktestExamByRegId(DateTime ExamDate, string RegId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMocktestExamByRegId", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                          new SqlParameter("@RegId", RegId));
          
                command.Parameters.Add(
                                     new SqlParameter("@ExamDate", ExamDate));
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
    public DataSet ViewMocktestRegByRegID(string RegId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMocktestRegByRegID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                          new SqlParameter("@RegId", RegId));
                
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


    public DataSet ViewMocktestQuestions(string stExam, string stMedium)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMocktestQuestions", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Subject", stExam));
                command.Parameters.Add(new SqlParameter("@Medium", stMedium));
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

    public int AddMockTestExamStatusRegID(MockQues Que)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (Que != null)
            {
                using (SqlCommand command = new SqlCommand("AddMockTestExamStatusRegID", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RegId", Que.RegId));
                    command.Parameters.Add(
                        new SqlParameter("@ExamDate", Que.ExamDate));
                        command.Parameters.Add(
                        new SqlParameter("@ExamName", Que.ExamName));
                    command.Parameters.Add(
                        new SqlParameter("@Status", Que.Status));
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

    public int UpdateMockTestExamRegID(MockQues Que)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (Que != null)
            {
                using (SqlCommand command = new SqlCommand("UpdateMockTestExamRegID", cnn))
                {

                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RegId", Que.RegId));
            
                    command.Parameters.Add(
                       new SqlParameter("@ExamDate", Que.ExamDate));
                    command.Parameters.Add(
                        new SqlParameter("@ExamTakenTime", Que.ExamTakenTime));
                    command.Parameters.Add(
                        new SqlParameter("@Status", Que.Status));
                    command.Parameters.Add(
                       new SqlParameter("@SelAnswers", Que.SelAnswers));
                    command.Parameters.Add(
                     new SqlParameter("@AttemptedQuestion", Que.AttemptedQuestion));
                    command.Parameters.Add(
                     new SqlParameter("@UnAttemptedQuestion", Que.UnAttemptedQuestion));
                    command.Parameters.Add(
                     new SqlParameter("@Score", Que.Score));
                    command.Parameters.Add(
                    new SqlParameter("@Questions", Que.Questions));
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

    public int UpdateMockTestResultRegID(string originalscore, string ExamDate, string RegId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateMockTestResultRegID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@originalscore", originalscore));
     
                command.Parameters.Add(new SqlParameter("@ExamDate", Convert.ToDateTime(ExamDate)));
                command.Parameters.Add(new SqlParameter("@RegId", RegId));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }

        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewMockTestQuestionByQuestionNo(string QuestionNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMockTestQuestionByQuestionNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add(new SqlParameter("@Medium", stMedium));
                command.Parameters.Add(new SqlParameter("@QuestionNo", QuestionNo));
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

    public int AddMocktestQuestions(MockQues Que)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (Que != null)
            {
                using (SqlCommand command = new SqlCommand("AddMocktestQuestions", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                         new SqlParameter("@Questions", Que.Question));
                    command.Parameters.Add(
                       new SqlParameter("@OptionsA", Que.OptionA));
                    command.Parameters.Add(
                       new SqlParameter("@OptionsB", Que.OptionB));
                    command.Parameters.Add(
                      new SqlParameter("@OptionsC", Que.OptionC));
                    command.Parameters.Add(
                          new SqlParameter("@OptionsD", Que.OptionD));
                    command.Parameters.Add(
                      new SqlParameter("@Answer", Que.Answer));
                    command.Parameters.Add(
                      new SqlParameter("@Subject", Que.Subject));
                    command.Parameters.Add(
                      new SqlParameter("@Medium", Que.Medium));
                    command.Parameters.Add(
                    new SqlParameter("@QueImageBased", Que.QueImageBased));
                    command.Parameters.Add(
                    new SqlParameter("@AnsImageBased", Que.AnsImageBased));
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

    public int AddMocktestAnswerkey(string upload_type, string subj,string filename)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("sp_MocktestAddQuestionpaper", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@upload_doc", upload_type));
                command.Parameters.Add(new SqlParameter("@subject", subj));
                command.Parameters.Add(new SqlParameter("@filename", filename));
                command.Parameters.Add(new SqlParameter("@uploaded_date", Utility.IndianTime));
                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int UpdateMocktestAnswerkey(string upload_type, string subj, string filename)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("sp_MocktestUpdateQuestionpaper", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@upload_doc", upload_type));
                command.Parameters.Add(new SqlParameter("@subject", subj));
                command.Parameters.Add(new SqlParameter("@filename", filename));
                command.Parameters.Add(new SqlParameter("@uploaded_date", Utility.IndianTime));
                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewAnswerkeyExist(string upload_type, string subj)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAnswerkeyExist", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Subject", subj));
                command.Parameters.Add(new SqlParameter("@Uploadtype", upload_type));
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

    public DataSet ViewAnswerkeyByGroup(string subjGroup)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAnswerkeyByGroup", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@subjGroup", subjGroup));
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
    public DataSet ViewMockExamResult()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMockExamResult", cnn))
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