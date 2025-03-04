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
public class pmufaculty
{
    public int Sno { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public string ThumbNailImage { get; set; }
    public string PdfName { get; set; }
    public bool Status { get; set; }
    public bool IsHod { get; set; }
    public DateTime PostedDate { get; set; }
    public int DisplayOrder { get; set; }
    public string PostedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string UpdatedBy { get; set; }   
    public string Department { get; set; }
    public pmufaculty()
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
    public int AddFaculty(List<pmufaculty> LstNews)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
            if (LstNews != null && LstNews.Count > 0)
            {
                foreach (pmufaculty news in LstNews)
                {
                    using (SqlCommand command = new SqlCommand("AddFaculty", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                       new SqlParameter("@Name", news.Name));
                        command.Parameters.Add(
                           new SqlParameter("@Designation", news.Designation));
                        command.Parameters.Add(
                          new SqlParameter("@ThumbNailImage", news.ThumbNailImage));
                        command.Parameters.Add(
                          new SqlParameter("@Active", news.Status));
                        command.Parameters.Add(
                           new SqlParameter("@PdfName", news.PdfName));
                        command.Parameters.Add(
                   new SqlParameter("@IsHod", news.IsHod));
                        command.Parameters.Add(
                          new SqlParameter("@PostedDate", news.PostedDate));
                        command.Parameters.Add(
                         new SqlParameter("@PostedBy", news.PostedBy));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDate", news.UpdatedDate));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", news.UpdatedBy));
                         command.Parameters.Add(
                          new SqlParameter("@DisplayOrder", news.DisplayOrder));
                          command.Parameters.Add(
                         new SqlParameter("@Department", news.Department));                       
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
    public int UpdateEvents(List<pmufaculty> LstNews, int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
            if (LstNews != null && LstNews.Count > 0)
            {
                foreach (pmufaculty news in LstNews)
                {
                    using (SqlCommand command = new SqlCommand("UpdateFaculty", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                       new SqlParameter("@Name", news.Name));
                        command.Parameters.Add(
                           new SqlParameter("@Designation", news.Designation));
                        command.Parameters.Add(
                          new SqlParameter("@ThumbNailImage", news.ThumbNailImage));
                        command.Parameters.Add(
                          new SqlParameter("@Active", news.Status));
                        command.Parameters.Add(
                           new SqlParameter("@PdfName", news.PdfName));
                        command.Parameters.Add(
                   new SqlParameter("@IsHod", news.IsHod));                        
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDate", news.UpdatedDate));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", news.UpdatedBy));
                        command.Parameters.Add(
                       new SqlParameter("@Department", news.Department));
                       command.Parameters.Add(
                          new SqlParameter("@DisplayOrder", news.DisplayOrder));
                        command.Parameters.Add(
                      new SqlParameter("@Sno", ID));
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

    public int DeleteFaculty(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteFaculty", cnn))
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
    public int UpdateFacultyStatus(int ID,string updatedBy,DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateFacultyStatus", cnn))
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
    public DataSet ViewAllFaculty()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllFaculty", cnn))
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
   
    public DataSet ViewFacultyById(int ID)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewFacultyById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Sno", ID));
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
    public DataSet ViewFacultyByDepartment(string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewFacultyByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Department", stDepartment));
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

    public DataSet ViewActiveFacultyByDepartment(string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveFacultyByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("Department", stDepartment));
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

    public DataSet ViewAllFacultyByDepartment(string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllFacultyByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("Department", stDepartment));
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

    public DataSet ViewHODFacultyByDepartment(string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewHODFacultyByDepartment", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("Department", stDepartment));
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

    public DataSet ViewMaxFaculty(string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMaxFaculty", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("Department", stDepartment));
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

    public DataSet GetFacultyDisplayOrderWay1(int fromDisplayOrder, int toDisplayOrder, string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetFacultyDisplayOrderWay1", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;               
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrderSlider", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrderSlider", toDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("Department", stDepartment));
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
    public DataSet GetFacultyDisplayOrderWay2(int fromDisplayOrder, int toDisplayOrder, string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetFacultyDisplayOrderWay2", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
              
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrderSlider", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrderSlider", toDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("Department", stDepartment));
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
    public int UpdateFacultyDisplayOrder(int Sno,int DisplayOrder, string UpdatedBy, string stDepartment)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;

        try
        {      using (SqlCommand command = new SqlCommand("UpdateFacultyDisplayOrder", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        
                        command.Parameters.Add(
                           new SqlParameter("@Sno", Sno));
                        command.Parameters.Add(
                           new SqlParameter("@DisplayOrder", DisplayOrder));
                          command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", UpdatedBy));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedDateTime", DateTime.Now));
                         command.Parameters.Add(
                new SqlParameter("Department", stDepartment));
                         rowsAffected = command.ExecuteNonQuery();
                    }
                    cnn.Close();
              
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet IsDisplayOrderExistsFaculty(int displayOrder, string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("IsDisplayOrderExistsFaculty", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
               
                command.Parameters.Add(
                new SqlParameter("@DisplayOrder", displayOrder));
                command.Parameters.Add(
                new SqlParameter("Department", stDepartment));

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
    public DataSet GetFacultyDisplayOrderForInsert(int fromDisplayOrder,int toDisplayOrder, string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetFacultyDisplayOrderForInsert", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
               
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrderSlider", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrderSlider", toDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("Department", stDepartment));
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
    public DataSet GetFacultyDisplayOrderForDelete(int fromDisplayOrder, int toDisplayOrder, string stDepartment)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("GetFacultyDisplayOrderForDelete", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.Add(
                new SqlParameter("@FromDisplayOrderSlider", fromDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("@ToDisplayOrderSlider", toDisplayOrder));
                command.Parameters.Add(
                new SqlParameter("Department", stDepartment));
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