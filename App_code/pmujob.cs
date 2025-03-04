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
public class pmujob
{
    public int Sno { get; set; }   
    public string JobId { get; set; }
    public string Department { get; set; }
    public string ApplyingFor { get; set; }
    public DateTime LastAppliedDate { get; set; }
    public string Experience { get; set; }
    public string JobDescription { get; set; }
    public DateTime AppliedDate { get; set; }
    public string Source { get; set; }   
    public string SourceText { get; set; }
    public bool Active { get; set; }
    public string CategoryType { get; set; }
    public string Category { get; set; }
    public string School { get; set; }
    public DateTime UpdatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public string Intake { get; set; }

    public pmujob()
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


    public int AddJobDetails(pmujob job)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddJobDetails", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@JobId", job.JobId));
                command.Parameters.Add(
                   new SqlParameter("@Department", job.Department));
                command.Parameters.Add(
                   new SqlParameter("@ApplyingFor", job.ApplyingFor));
                command.Parameters.Add(
                  new SqlParameter("@LastAppliedDate", job.LastAppliedDate));
                command.Parameters.Add(
                 new SqlParameter("@Experience", job.Experience));
                command.Parameters.Add(
                new SqlParameter("@JobDescription", job.JobDescription));
                command.Parameters.Add(
              new SqlParameter("@AppliedDate", job.AppliedDate));
                command.Parameters.Add(
              new SqlParameter("@Active", job.Active));
                command.Parameters.Add(
             new SqlParameter("@CategoryType", job.CategoryType));
                rowsAffected = command.ExecuteNonQuery();
               

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int AddDepartmentIntakeDetails(pmujob job)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddDepartmentDetail", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
              command.Parameters.Add(
               new SqlParameter("@School", job.School));
                command.Parameters.Add(
                   new SqlParameter("@Department", job.Department));
             command.Parameters.Add(
               new SqlParameter("@Category", job.Category));
                command.Parameters.Add(
                   new SqlParameter("@ApplyingFor", job.ApplyingFor));
                command.Parameters.Add(
                  new SqlParameter("@Intake", job.Intake));
                command.Parameters.Add(
                 new SqlParameter("@UpdatedOn", job.UpdatedOn));
                command.Parameters.Add(
                new SqlParameter("@UpdatedBy", job.UpdatedBy));
                rowsAffected = command.ExecuteNonQuery();
               

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int AddJobDetailsmodify(pmujob job)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddJobDetailsmodify", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@JobId", job.JobId));
                command.Parameters.Add(
                   new SqlParameter("@School", job.School));
                command.Parameters.Add(
                   new SqlParameter("@Department", job.Department));
                command.Parameters.Add(
                   new SqlParameter("@ApplyingFor", job.ApplyingFor));
                command.Parameters.Add(
                  new SqlParameter("@LastAppliedDate", job.LastAppliedDate));
                command.Parameters.Add(
                 new SqlParameter("@Experience", job.Experience));
                command.Parameters.Add(
                new SqlParameter("@JobDescription", job.JobDescription));
                command.Parameters.Add(
              new SqlParameter("@AppliedDate", job.AppliedDate));
                command.Parameters.Add(
              new SqlParameter("@Active", job.Active));
                command.Parameters.Add(
             new SqlParameter("@CategoryType", job.CategoryType));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateJobDetails(pmujob job)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateJobDetails", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@JobId", job.JobId));
                command.Parameters.Add(
                   new SqlParameter("@Department", job.Department));
                command.Parameters.Add(
                   new SqlParameter("@ApplyingFor", job.ApplyingFor));
                command.Parameters.Add(
                  new SqlParameter("@LastAppliedDate", job.LastAppliedDate));
                command.Parameters.Add(
                 new SqlParameter("@Experience", job.Experience));
                command.Parameters.Add(
                new SqlParameter("@JobDescription", job.JobDescription));
                command.Parameters.Add(
             new SqlParameter("@CategoryType", job.CategoryType));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public int UpdateJobDetailsModify(pmujob job)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateJobDetailsModify", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@JobId", job.JobId));
                command.Parameters.Add(
                  new SqlParameter("@School", job.School));
                command.Parameters.Add(
                   new SqlParameter("@Department", job.Department));
                command.Parameters.Add(
                   new SqlParameter("@ApplyingFor", job.ApplyingFor));
                command.Parameters.Add(
                  new SqlParameter("@LastAppliedDate", job.LastAppliedDate));
                command.Parameters.Add(
                 new SqlParameter("@Experience", job.Experience));
                command.Parameters.Add(
                new SqlParameter("@JobDescription", job.JobDescription));
                command.Parameters.Add(
             new SqlParameter("@CategoryType", job.CategoryType));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public int UpdateJobStatus(int sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateJobStatus", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@Sno", sno));
               
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int DeleteJobSpecifications(string jobId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteJobSpecifications", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@JobId", jobId));                
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeleteJobById(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteJobById", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@Sno", Sno));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddJobSpecifications(pmujob job)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddJobSpecifications", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@JobId", job.JobId));
                command.Parameters.Add(
                   new SqlParameter("@Source", job.Source));
                command.Parameters.Add(
                  new SqlParameter("@SourceText", job.SourceText));                         
                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewJobById(string stJobId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewJobById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@JobId", stJobId));
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
    public DataSet ViewJobSpecificationsById(string stJobId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewJobSpecificationsById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@JobId", stJobId));
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
    public DataSet ViewMaxJobId()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewMaxJobId", cnn))
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
    public DataSet ViewActiveJobDetails(string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewActiveJobDetails", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@Category", stCategory));
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
    public DataSet ViewJobBySearchDateAdmin(string Department, string ApplyingFor, string Status, string FromDate, string ToDate,string stCategorytype)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewJobBySearchDateAdmin", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
               new SqlParameter("@ApplyingFor", ApplyingFor));
                command.Parameters.Add(
              new SqlParameter("@Status", Status));
                command.Parameters.Add(
              new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
              new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
             new SqlParameter("@CategoryType", stCategorytype));
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
    public DataSet ViewAllApplyingFor()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllApplyingFor", cnn))
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
    public DataSet ViewDepartmentIntake()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewDepartmentIntake", cnn))
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
	public DataSet ViewBySchoolDeptCatApply(string stschool, string stdepartment, string stCategory, string stApplyingFor)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewBySchoolDeptCatApply", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@School", stschool));
                command.Parameters.Add(
                                      new SqlParameter("@Dept", stdepartment));
                command.Parameters.Add(
                                    new SqlParameter("@Category", stCategory));
                command.Parameters.Add(
                                    new SqlParameter("@ApplyingFor", stApplyingFor));
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

    public DataSet ViewDeptVacancyById(string Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewDeptVacancyById", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@Sno", Sno));
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

    public int UpdateDepartmentIntakeDetails(pmujob job)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateDepartmentIntakeDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@Sno", job.JobId));
                command.Parameters.Add(
                    new SqlParameter("@School", job.School));
                command.Parameters.Add(
                    new SqlParameter("@Department", job.Department));
                command.Parameters.Add(
                    new SqlParameter("@Category", job.Category));
                command.Parameters.Add(
                    new SqlParameter("@ApplyingFor", job.ApplyingFor));
                command.Parameters.Add(
                    new SqlParameter("@Intake", job.Intake));
                command.Parameters.Add(
                    new SqlParameter("@UpdatedOn", job.UpdatedOn));
                command.Parameters.Add(
                    new SqlParameter("@UpdatedBy", job.UpdatedBy));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewCareerJobVacancyReport(string stSchool, string stDepartment, string stApplyingFor, string stFromDate, string stToDate)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCareerJobVacancyReport", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                   new SqlParameter("@School", stSchool));
                command.Parameters.Add(
                  new SqlParameter("@Department", stDepartment));
                command.Parameters.Add(
                  new SqlParameter("@ApplyingFor", stApplyingFor));
                command.Parameters.Add(
                  new SqlParameter("@FromDate", stFromDate));
                command.Parameters.Add(
                  new SqlParameter("@ToDate", stToDate));
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