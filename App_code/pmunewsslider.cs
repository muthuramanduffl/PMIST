using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
/// <summary>
/// Summary description for News
/// </summary>
public class pmunewsslider
{
    public int SliderId { get; set; }
    public string Title { get; set; }
    public string LinkUrl { get; set; }   
    public bool Status { get; set; }
    public DateTime PostedDate { get; set; }
    public string PostedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string UpdatedBy { get; set; }
   
    public pmunewsslider()
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
    public int AddNewsSlider(List<pmunewsslider> LstNews)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstNews != null && LstNews.Count > 0)
            {
                foreach (pmunewsslider slider in LstNews)
                {
                    using (SqlCommand command = new SqlCommand("AddNewsSlider", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                       new SqlParameter("@Title", slider.Title));
                        command.Parameters.Add(
                           new SqlParameter("@LinkUrl", slider.LinkUrl));
                        command.Parameters.Add(
                          new SqlParameter("@Status", slider.Status));
                        command.Parameters.Add(
                          new SqlParameter("@PostedBy", slider.PostedBy));
                        command.Parameters.Add(
                           new SqlParameter("@PostedDate", slider.PostedDate));
                        command.Parameters.Add(
                   new SqlParameter("@UpdatedBy", slider.UpdatedBy));
                        command.Parameters.Add(
                          new SqlParameter("@UpdatedDate", slider.UpdatedDate));
                       
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
    public int UpdateNewsSlider(List<pmunewsslider> LstNews, int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstNews != null && LstNews.Count > 0)
            {
                foreach (pmunewsslider slider in LstNews)
                {
                    using (SqlCommand command = new SqlCommand("UpdateNewsSlider", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                        new SqlParameter("@Title", slider.Title));
                        command.Parameters.Add(
                           new SqlParameter("@LinkUrl", slider.LinkUrl));
                        command.Parameters.Add(
                          new SqlParameter("@Status", slider.Status));                       
                        command.Parameters.Add(
                   new SqlParameter("@UpdatedBy", slider.UpdatedBy));
                        command.Parameters.Add(
                          new SqlParameter("@UpdatedDate", slider.UpdatedDate));
                        command.Parameters.Add(
                          new SqlParameter("@NewsId", ID));
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

    public int DeleteNewsSlider(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteNewsSlider", cnn))
                {

                    // Add new SqlParameter to the command.

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@NewsId", ID));
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
    public int UpdateNewsSliderStatus(int ID,string updatedBy,DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateNewsSliderStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@NewsId", ID));
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
    public DataSet ViewAllNewsSlier()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllNewsSlier", cnn))
            {
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
    public DataSet ViewActiveNewsSlier()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveNewsSlier", cnn))
            {
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
    public DataSet ViewNewsSliderById(int ID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewNewsSliderById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@NewsId", ID));
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