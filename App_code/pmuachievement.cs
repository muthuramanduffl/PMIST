using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

/// <summary>
/// Summary description for Album
/// </summary>
public class pmuachievement
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string mainContent { get; set; }
    public string BigImage { get; set; }
    public string AddlImage { get; set; }  
    public bool Active { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDate { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public pmuachievement()
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
    public int AddAchievement(List<pmuachievement> LstAchievement)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstAchievement != null && LstAchievement.Count > 0)
            {
                foreach (pmuachievement achievement in LstAchievement)
                {
                    using (SqlCommand command = new SqlCommand("AddAchievement", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                     new SqlParameter("@Title", achievement.Title));
                        command.Parameters.Add(
                      new SqlParameter("@mainContent", achievement.mainContent));
                        command.Parameters.Add(
                     new SqlParameter("@BigImage", achievement.BigImage));
                        command.Parameters.Add(
                     new SqlParameter("@AddlImage", achievement.AddlImage));                        
                        command.Parameters.Add(
                           new SqlParameter("@Active", achievement.Active));
                        command.Parameters.Add(
                          new SqlParameter("@AddedBy", achievement.AddedBy));
                        command.Parameters.Add(
                         new SqlParameter("@AddedDate", achievement.AddedDate));
                        
                        rowsAffected = command.ExecuteNonQuery();
                       
                    }
                    cnn.Close();
                }


            }
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateAchievement(List<pmuachievement> LstAchievement, int Id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
            if (LstAchievement != null && LstAchievement.Count > 0)
            {
                foreach (pmuachievement achievement in LstAchievement)
                {
                    using (SqlCommand command = new SqlCommand("UpdateAchievement", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                     new SqlParameter("@Title", achievement.Title));
                        command.Parameters.Add(
                      new SqlParameter("@mainContent", achievement.mainContent));
                        command.Parameters.Add(
                     new SqlParameter("@BigImage", achievement.BigImage));
                        command.Parameters.Add(
                     new SqlParameter("@AddlImage", achievement.AddlImage));
                        command.Parameters.Add(
                           new SqlParameter("@Active", achievement.Active));
                        command.Parameters.Add(
                          new SqlParameter("@UpdatedBy", achievement.UpdatedBy));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDate", achievement.UpdatedDate));
                    command.Parameters.Add(
                        new SqlParameter("@Sno", Id));
                    rowsAffected = command.ExecuteNonQuery();

                    }
                    cnn.Close();
                }


            }
        //}
        //catch (Exception ex)
        //{
        //}
        return rowsAffected;
    }
    public int UpdateAchievementStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateAchievementStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Sno", ID));
                command.Parameters.Add(
                new SqlParameter("@UpdatedBy", updatedBy));
                command.Parameters.Add(
                new SqlParameter("@UpdatedDateTime", dtUpdatedDateTime));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return rowsAffected;

    }
   
    public int DeleteAchievement(int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsDetail = new DataSet();
        int rowsAffected = 0;
        try
        {
            if (ID > 0)
            {

                cnn.Open();
                using (SqlCommand command = new SqlCommand("DeleteAchievement", cnn))
                {

                    // Add new SqlParameter to the command.

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@Sno", ID));
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

    public DataSet ViewAchievementById(int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            if (ID > 0)
            {

                using (SqlCommand command = new SqlCommand("ViewAchievementById", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                                          new SqlParameter("@Sno", ID));

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dsNews);

                }

                cnn.Close();

            }
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

   
    public DataSet ViewActiveAchievement()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewActiveAchievement", cnn))
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
       
 
    public DataSet ViewAllAchievement()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllAchievement", cnn))
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