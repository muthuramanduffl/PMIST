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
public class pmulead23
{
    public int Id { get; set; }
    public string LeadId { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string MobileNo { get; set; }
    public string WhatsAppNo { get; set; }
    public string Location { get; set; }
    public string State { get; set; }
    public string ApplicationFor { get; set; }
    public string CourseMode { get; set; }
    public string CourseType { get; set; }
    public string BranchChoice1 { get; set; }
    public string BranchChoice2 { get; set; }
    public string BranchChoice3 { get; set; }
    public string EntranceExam { get; set; }
    public string RefCode { get; set; }
    public string ApplicaionNo { get; set; }
    public string SourceEntered { get; set; }
    public string SourceCaptured { get; set; }
    public string AssignedTo { get; set; }
    public string AssignedRole { get; set; }
    public string CurrentCallStatus { get; set; }
    public string ResponseStatus { get; set; }
    public string LeadStatus { get; set; }
    public string AdmissionLevel { get; set; }
    public DateTime? NextFollowupDate { get; set; }
    public DateTime? LastFollowupDate { get; set; }
    public DateTime LastHistoryUpdateDate { get; set; }
    public string LeadGeneratedFrom { get; set; }
    public DateTime LeadGeneratedDate { get; set; }
    public string LastActionTaken { get; set; }
    public string LeadGeneratedBy { get; set; }
    public DateTime LastUpdatedDate { get; set; }
    public string LastUpdatedBy { get; set; }
    public string LastUpdatedRole { get; set; }
    public string ClosureReason { get; set; }
    public string Remarks { get; set; }
    public string BulkUpload { get; set; }
    public string ConsultantName_Code { get; set; }
    public string Referral { get; set; }
    public string Department { get; set; }
    public string FacultySchool { get; set; }
    public string Scholarship { get; set; }
    public pmulead23()
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

            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMULead"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connetionString;
    }
   
    public int UpdateApplicationNo23(string stApplicationNo, string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateApplicationNo23", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@ApplicationNo", stApplicationNo));
                command.Parameters.Add(
               new SqlParameter("@MobileNo", stMobileNo));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewLeadByEmailId23(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadByEmailId23", cnn))
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
    public DataSet ViewLeadByMobileNo23(string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadByMobileNo23", cnn))
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

    public int AddAppLead23(pmulead23 lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddAppLead23", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@LeadId", lead.LeadId));
                command.Parameters.Add(
                    new SqlParameter("@Name", lead.Name));
                command.Parameters.Add(
                    new SqlParameter("@EmailId", lead.EmailId));
                command.Parameters.Add(
                    new SqlParameter("@MobileNo", lead.MobileNo));
                command.Parameters.Add(
                    new SqlParameter("@Location", lead.Location));
                command.Parameters.Add(
                   new SqlParameter("@State", lead.State));
                command.Parameters.Add(
                  new SqlParameter("@ApplicationFor", lead.ApplicationFor));
                command.Parameters.Add(
                 new SqlParameter("@CourseMode", lead.CourseMode));
                command.Parameters.Add(
                 new SqlParameter("@CourseType", lead.CourseType));
                command.Parameters.Add(
                   new SqlParameter("@BranchChoice1", lead.BranchChoice1));
                command.Parameters.Add(
                   new SqlParameter("@BranchChoice2", lead.BranchChoice2));
                command.Parameters.Add(
                   new SqlParameter("@BranchChoice3", lead.BranchChoice3));
                command.Parameters.Add(
                   new SqlParameter("@EntranceExam", lead.EntranceExam));
                command.Parameters.Add(
                   new SqlParameter("@RefCode", lead.RefCode));
                command.Parameters.Add(
                   new SqlParameter("@ApplicaionNo", lead.ApplicaionNo));
                command.Parameters.Add(
                  new SqlParameter("@SourceEntered", lead.SourceEntered));
                command.Parameters.Add(
                  new SqlParameter("@SourceCaptured", lead.SourceCaptured));
                command.Parameters.Add(
                 new SqlParameter("@AssignedTo", lead.AssignedTo));
                command.Parameters.Add(
                 new SqlParameter("@AssignedRole", lead.AssignedRole));
                command.Parameters.Add(
                new SqlParameter("@LeadStatus", lead.LeadStatus));
                command.Parameters.Add(
                new SqlParameter("@AdmissionLevel", lead.AdmissionLevel));
                command.Parameters.Add(
                new SqlParameter("@LeadGeneratedFrom", lead.LeadGeneratedFrom));
                command.Parameters.Add(
               new SqlParameter("@LeadGeneratedDate", lead.LeadGeneratedDate));
                command.Parameters.Add(
               new SqlParameter("@LeadGeneratedBy", lead.LeadGeneratedBy));
                command.Parameters.Add(
              new SqlParameter("@BulkUpload", lead.BulkUpload));
                command.Parameters.Add(
             new SqlParameter("@Referral", lead.Referral));
                command.Parameters.Add(
            new SqlParameter("@GroupName", string.Empty));
            command.Parameters.Add(
            new SqlParameter("@Scholarship", lead.Scholarship));
                command.Parameters.Add(
                 new SqlParameter("@School_CollegeName", string.Empty));
                  command.Parameters.Add(
                 new SqlParameter("@FacultySchool", lead.FacultySchool));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewLeadByLeadId23(string stLeadId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadByLeadId23", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@LeadId", stLeadId));

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

    public DataSet ViewLeadGeneratedByDate(string stCurrentDate)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadGeneratedByDate", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));

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

    public DataSet ViewCourseNameByModeType(string coursetype, string coursemode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCourseNameByModeType", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@coursetype", coursetype));
                command.Parameters.Add(new SqlParameter("@coursemode", coursemode));

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

    public DataSet ViewBranchByCNameModeType(string course, string coursetype, string coursemode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewBranchByCNameModeType", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@coursename", course));
                command.Parameters.Add(new SqlParameter("@coursetype", coursetype));
                command.Parameters.Add(new SqlParameter("@coursemode", coursemode));

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


    public int UpdateCampaignCount(string stCampaignName, int Count)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateCampaignCount", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@CampaignName", stCampaignName));
                command.Parameters.Add(
                    new SqlParameter("@Count", Count));
                command.Parameters.Add(
                    new SqlParameter("@LastUpdateDate", Utility.IndianTime));

                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewCampaignCount(string stCampaignName)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCampaignCount", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CampaignName", stCampaignName));

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
