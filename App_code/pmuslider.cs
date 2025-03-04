using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for PageContent
/// </summary>
public class pmuslider
{
    public int ID { get; set; }
    public string SliderImage { get; set; }
    public string SliderText1 { get; set; }
    public string SliderText2 { get; set; }
    public string LinkUrl { get; set; }
    public int DisplayOrder { get; set; }
    public bool Status { get; set; }
    public DateTime AddedDateTime { get; set; }
    public string AddedBy { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public string UpdatedBy { get; set; }
   
    public pmuslider()
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
    public int AddSlider(List<pmuslider> LstPageContent)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (LstPageContent != null && LstPageContent.Count > 0)
            {
                foreach (pmuslider slider in LstPageContent)
                {
                    using (SqlCommand command = new SqlCommand("AddSlider", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                       new SqlParameter("@SliderImage", slider.SliderImage));
                        command.Parameters.Add(
                           new SqlParameter("@SliderText1", slider.SliderText1));
                        command.Parameters.Add(
                           new SqlParameter("@SliderText2", slider.SliderText2));
                        command.Parameters.Add(
                           new SqlParameter("@LinkUrl", slider.LinkUrl));
                          command.Parameters.Add(
                          new SqlParameter("@Status", slider.Status));
                        command.Parameters.Add(
                          new SqlParameter("@AddedBy", slider.AddedBy));
                        command.Parameters.Add(
                          new SqlParameter("@AddedDateTime", slider.AddedDateTime));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", slider.UpdatedBy));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDateTime", slider.UpdatedDateTime));                       
                        command.Parameters.Add(
                          new SqlParameter("@DisplayOrder", slider.DisplayOrder));                        
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
    public int UpdateSlider(List<pmuslider> LstPageContent, int Id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;

        try
        {
            if (LstPageContent != null && LstPageContent.Count > 0)
            {
                foreach (pmuslider slider in LstPageContent)
                {
                    using (SqlCommand command = new SqlCommand("UpdateSlider", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                        new SqlParameter("@SliderImage", slider.SliderImage));
                        command.Parameters.Add(
                           new SqlParameter("@SliderText1", slider.SliderText1));
                        command.Parameters.Add(
                           new SqlParameter("@SliderText2", slider.SliderText2));
                        command.Parameters.Add(
                           new SqlParameter("@LinkUrl", slider.LinkUrl));
                        command.Parameters.Add(
                        new SqlParameter("@Status", slider.Status));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", slider.UpdatedBy));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDateTime", slider.UpdatedDateTime));                       
                        command.Parameters.Add(
                          new SqlParameter("@DisplayOrder", slider.DisplayOrder));
                        command.Parameters.Add(
                        new SqlParameter("@SliderId", Id));                       
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

    public int DeleteSlider(int Id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsDetail = new DataSet();
        int rowsAffected = 0;
        try
        {
            if (Id > 0)
            {

                cnn.Open();
                using (SqlCommand command = new SqlCommand("DeleteSlider", cnn))
                {

                    // Add new SqlParameter to the command.

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                new SqlParameter("@SliderId", Id));
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
    public DataSet ViewSlider()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllSlider", cnn))
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
    public DataSet ViewSliderByID(int ID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewSliderById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@SliderId", ID));
              
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
    public DataSet ViewActiveSlider()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveSlider", cnn))
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
    public int UpdateStatus(int Id,string UpdatedBy)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateSliderStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@SliderId", Id));               
                command.Parameters.Add(
                new SqlParameter("@UpdatedBy", UpdatedBy));
                command.Parameters.Add(
                new SqlParameter("@UpdatedDateTime", DateTime.Now));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return rowsAffected;

    }
    public DataSet ViewMaxSlider()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMaxSlider", cnn))
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
    public DataSet GetSliderDisplayOrderWay1(int fromDisplayOrder, int toDisplayOrder)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetSliderDisplayOrderWay1", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;               
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrderSlider", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrderSlider", toDisplayOrder));
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
    public DataSet GetSliderDisplayOrderWay2(int fromDisplayOrder, int toDisplayOrder)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetSliderDisplayOrderWay2", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
              
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrderSlider", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrderSlider", toDisplayOrder));
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
    public int UpdateSliderDisplayOrder(int SliderId,int DisplayOrder, string UpdatedBy)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;

        try
        {      using (SqlCommand command = new SqlCommand("UpdateSliderDisplayOrder", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        
                        command.Parameters.Add(
                           new SqlParameter("@SliderId", SliderId));
                        command.Parameters.Add(
                           new SqlParameter("@DisplayOrder", DisplayOrder));
                          command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", UpdatedBy));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDateTime", DateTime.Now));
                         rowsAffected = command.ExecuteNonQuery();
                    }
                    cnn.Close();
              
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet IsDisplayOrderExists(int displayOrder)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("IsDisplayOrderExists", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
               
                command.Parameters.Add(
                new SqlParameter("@DisplayOrder", displayOrder));

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
    public DataSet GetSliderDisplayOrderForInsert(int fromDisplayOrder,int toDisplayOrder)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetSliderDisplayOrderForInsert", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
               
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrderSlider", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrderSlider", toDisplayOrder));
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
    public DataSet GetSliderDisplayOrderForDelete(int fromDisplayOrder, int toDisplayOrder)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetSliderDisplayOrderForDelete", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrderSlider", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrderSlider", toDisplayOrder));
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