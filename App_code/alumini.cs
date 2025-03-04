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
public class alumini
{
    public int Id { get; set; }
    public string RegistrationNo { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string MobileNo { get; set; }
    public string Batch { get; set; }
    public string Department { get; set; }
    public string CurrentStatus { get; set; }
    public string CompanyName { get; set; }
    public string Designation { get; set; }
    public string Place { get; set; }
    public string IDCardUrl { get; set; }
    public string Degree { get; set; }
    public string StudyCourse { get; set; }
    public string InstituteName { get; set; }
    public string PhotoUrl { get; set; }
    public string TestimonialContent { get; set; }
    public string Password { get; set; }
    public bool Active { get; set; }
    public string PostedBy { get; set; }
    public DateTime PostedDate { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public alumini()
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
    public int AddAlumini(List<alumini> Lstalumini)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            if (Lstalumini != null && Lstalumini.Count > 0)
            {
                foreach (alumini alumini in Lstalumini)
                {
                    using (SqlCommand command = new SqlCommand("AddAlumini", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                     new SqlParameter("@RegistrationNo", alumini.RegistrationNo));
                        command.Parameters.Add(
                      new SqlParameter("@Name", alumini.Name));
                        command.Parameters.Add(
                     new SqlParameter("@EmailId", alumini.EmailId));
                        command.Parameters.Add(
                     new SqlParameter("@MobileNo", alumini.MobileNo));
                        command.Parameters.Add(
                    new SqlParameter("@Batch", alumini.Batch));
                        command.Parameters.Add(
                   new SqlParameter("@Department", alumini.Department));
                        command.Parameters.Add(
                  new SqlParameter("@CurrentStatus", alumini.CurrentStatus));
                        command.Parameters.Add(
                  new SqlParameter("@CompanyName", alumini.CompanyName));
                        command.Parameters.Add(
                new SqlParameter("@Designation", alumini.Designation));
                        command.Parameters.Add(
                new SqlParameter("@Place", alumini.Place));
                        command.Parameters.Add(
              new SqlParameter("@IDCardUrl", alumini.IDCardUrl));
                        command.Parameters.Add(
              new SqlParameter("@Degree", alumini.Degree));
                        command.Parameters.Add(
              new SqlParameter("@StudyCourse", alumini.StudyCourse));
                        command.Parameters.Add(
             new SqlParameter("@InstituteName", alumini.InstituteName));
                        command.Parameters.Add(
            new SqlParameter("@PhotoUrl", alumini.PhotoUrl));
                        command.Parameters.Add(
          new SqlParameter("@TestimonialContent", alumini.TestimonialContent));
                        command.Parameters.Add(
        new SqlParameter("@Password", alumini.Password));
                        command.Parameters.Add(
                           new SqlParameter("@Active", alumini.Active));
                        command.Parameters.Add(
                          new SqlParameter("@PostedBy", alumini.PostedBy));
                        command.Parameters.Add(
                         new SqlParameter("@PostedDate", alumini.PostedDate));
                        
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
    public int UpdateAlumini(List<alumini> Lstalumini, int Id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
            if (Lstalumini != null && Lstalumini.Count > 0)
            {
                foreach (alumini alumini in Lstalumini)
                {
                    using (SqlCommand command = new SqlCommand("UpdateAlumini", cnn))
                    {

                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                     new SqlParameter("@RegistrationNo", alumini.RegistrationNo));
                        command.Parameters.Add(
                      new SqlParameter("@Name", alumini.Name));
                    command.Parameters.Add(
                 new SqlParameter("@EmailId", alumini.EmailId));
                    command.Parameters.Add(
                 new SqlParameter("@MobileNo", alumini.MobileNo));
                    command.Parameters.Add(
                new SqlParameter("@Batch", alumini.Batch));
                    command.Parameters.Add(
               new SqlParameter("@Department", alumini.Department));
                    command.Parameters.Add(
              new SqlParameter("@CurrentStatus", alumini.CurrentStatus));
                    command.Parameters.Add(
              new SqlParameter("@CompanyName", alumini.CompanyName));
                    command.Parameters.Add(
            new SqlParameter("@Designation", alumini.Designation));
                    command.Parameters.Add(
            new SqlParameter("@Place", alumini.Place));
                    command.Parameters.Add(
          new SqlParameter("@IDCardUrl", alumini.IDCardUrl));
                    command.Parameters.Add(
          new SqlParameter("@Degree", alumini.Degree));
                    command.Parameters.Add(
          new SqlParameter("@StudyCourse", alumini.StudyCourse));
                    command.Parameters.Add(
         new SqlParameter("@InstituteName", alumini.InstituteName));
                    command.Parameters.Add(
        new SqlParameter("@PhotoUrl", alumini.PhotoUrl));
                    command.Parameters.Add(
      new SqlParameter("@TestimonialContent", alumini.TestimonialContent));
                  
                    command.Parameters.Add(
                       new SqlParameter("@Active", alumini.Active));
                    command.Parameters.Add(
                     new SqlParameter("@UpdatedBy", alumini.UpdatedBy));
                    command.Parameters.Add(
                       new SqlParameter("@UpdatedDate", alumini.UpdatedDate));
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
    public int UpdateAluminiStatus(int ID, string updatedBy, DateTime dtUpdatedDateTime)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            using (SqlCommand command = new SqlCommand("UpdateAluminiStatus", cnn))
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
    public int UpdateAluminiUser(List<alumini> Lstalumini, int Id)
    {
        int rowsAffected = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        //try
        //{
            if (Lstalumini != null && Lstalumini.Count > 0)
            {
                foreach (alumini alumini in Lstalumini)
                {
                    using (SqlCommand command = new SqlCommand("UpdateAluminiUser", cnn))
                    {
                        cnn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                 new SqlParameter("@RegistrationNo", alumini.RegistrationNo));
                    command.Parameters.Add(
                     new SqlParameter("@EmailId", alumini.EmailId));
                        command.Parameters.Add(
                     new SqlParameter("@MobileNo", alumini.MobileNo));
                        command.Parameters.Add(
                    new SqlParameter("@Batch", alumini.Batch));
                        command.Parameters.Add(
                   new SqlParameter("@Department", alumini.Department));
                        command.Parameters.Add(
                  new SqlParameter("@CurrentStatus", alumini.CurrentStatus));
                        command.Parameters.Add(
                  new SqlParameter("@CompanyName", alumini.CompanyName));
                        command.Parameters.Add(
                new SqlParameter("@Designation", alumini.Designation));
                        command.Parameters.Add(
                new SqlParameter("@Place", alumini.Place));
                        command.Parameters.Add(
              new SqlParameter("@IDCardUrl", alumini.IDCardUrl));
                        command.Parameters.Add(
              new SqlParameter("@Degree", alumini.Degree));
                        command.Parameters.Add(
              new SqlParameter("@StudyCourse", alumini.StudyCourse));
                        command.Parameters.Add(
             new SqlParameter("@InstituteName", alumini.InstituteName));
                        command.Parameters.Add(
            new SqlParameter("@PhotoUrl", alumini.PhotoUrl));
                        command.Parameters.Add(
          new SqlParameter("@TestimonialContent", alumini.TestimonialContent));
                        command.Parameters.Add(
                         new SqlParameter("@UpdatedBy", alumini.UpdatedBy));
                        command.Parameters.Add(
                           new SqlParameter("@UpdatedDate", alumini.UpdatedDate));
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
    public int DeleteAlumini(int ID)
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
                using (SqlCommand command = new SqlCommand("DeleteAlumini", cnn))
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

    public DataSet ViewAluminiById(int ID)
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

                using (SqlCommand command = new SqlCommand("ViewAluminiById", cnn))
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

    public DataSet ViewAluminiByMobileNo(string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            

                using (SqlCommand command = new SqlCommand("ViewAluminiByMobileNo", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                                          new SqlParameter("@MobileNo", stMobileNo));

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
    public DataSet ViewActiveAlumini()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewActiveAlumini", cnn))
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
       
 
    public DataSet ViewAllAlumini()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewAllAlumini", cnn))
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
    public DataSet ViewInActiveAlumini()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {

            using (SqlCommand command = new SqlCommand("ViewInActiveAlumini", cnn))
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
    public DataSet ViewAluminiByEmailId(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
           
                using (SqlCommand command = new SqlCommand("ViewAluminiByEmailId", cnn))
                {
                    cnn.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                                          new SqlParameter("@EmailId", stEmailId));

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
    public DataSet ViewMaxAlumni()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMaxAlumni", cnn))
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

    public DataSet ViewActiveAlumniLogin(string stMobileNo,string stPassword)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {


            using (SqlCommand command = new SqlCommand("ViewActiveAlumniLogin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Mobile", stMobileNo));
                command.Parameters.Add(
                                      new SqlParameter("@Password", stPassword));
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