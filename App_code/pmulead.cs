using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

/// <summary>
/// Summary description for Album
/// </summary>
public class pmulead
{
    public int Id { get; set; }
    public string LeadId { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string MobileNo { get; set; }
    public string WhatsAppNo { get; set; }
    public string Location { get; set; }
    public string District { get; set; }
    public string HSCRegID { get; set; }
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

    public string modeofpayment { get; set; }
    public string BillNo { get; set; }
    public string ApplnFees { get; set; }
    public DateTime PaymentDate { get; set; }
    public string ApplnFeesUpdatedBy { get; set; }
    public string RawLeadId { get; set; }

    public string Specialisation1 { get; set; }
    public string Specialisation2 { get; set; }
    public string Specialisation3 { get; set; }

    public string PMESEReg { get; set; }
    public string PMESEScore { get; set; }
    public string PMESEExamStatus { get; set; }


    public pmulead()
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
    public string NewApplicationNo(string CourseType, string ApplicationFor,int no)
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationNo", con);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        
        int _ApplicationNo = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
        if (_ApplicationNo==1)
        {
            _ApplicationNo = no;
        }
        string _CourseType = "";
        string _ApplicationFor = "";

        if (CourseType.Equals("Regular"))
        {
            _CourseType = "R";
        }
        else
        {
            _CourseType = "PT";
        }
        if (ApplicationFor.Equals("B.E"))
        {
            _ApplicationFor = "BE";
        }
        else if (ApplicationFor.Equals("B.Tech"))
        {
            _ApplicationFor = "BT";
        }
        if (ApplicationFor.Equals("B.Tech Full Time"))
        {
            _ApplicationFor = "BTF";
        }
        else if (ApplicationFor.Equals("B.Tech Lateral Entry"))
        {
            _ApplicationFor = "BTL";
        }
        else if (ApplicationFor.Equals("B.Tech Part Time"))
        {
            _ApplicationFor = "BTP";
        }
        else if (ApplicationFor.Equals("B.C.A"))
        {
            _ApplicationFor = "BCA";
        }
        else if (ApplicationFor.Equals("B.COM"))
        {
            _ApplicationFor = "BCOM";
        }
        else if (ApplicationFor.Equals("B.Sc"))
        {
            _ApplicationFor = "BSC";
        }
        else if (ApplicationFor.Equals("B.Arch"))
        {
            _ApplicationFor = "BAR";
        }

        else if (ApplicationFor.Equals("B.A"))
        {
            _ApplicationFor = "BA";
        }

        else if (ApplicationFor.Equals("BBA"))
        {
            _ApplicationFor = "BBA";
        }

        else if (ApplicationFor.Equals("B.Voc"))
        {
            _ApplicationFor = "BV";
        }

        else if (ApplicationFor.Equals("B.Des"))
        {
            _ApplicationFor = "BDS";
        }

        else if (ApplicationFor.Equals("B.Sc.B.Ed"))
        {
            _ApplicationFor = "BSE";
        }
        else if (ApplicationFor.Equals("M.Tech Full Time"))
        {
            _ApplicationFor = "MTF";
        }
        else if (ApplicationFor.Equals("M.Tech Part Time"))
        {
            _ApplicationFor = "MTP";
        }
        else if (ApplicationFor.Equals("M.Com"))
        {
            _ApplicationFor = "MCO";
        }
        else if (ApplicationFor.Equals("M.Tech(Integerated)"))
        {
            _ApplicationFor = "MTI";
        }
        else if (ApplicationFor.Equals("M.A"))
        {
            _ApplicationFor = "MA";
        }
        else if (ApplicationFor.Equals("M.Arch"))
        {
            _ApplicationFor = "MAR";
        }
        if (ApplicationFor.Equals("M.S.W"))
        {
            _ApplicationFor = "MSW";
        }
        else if (ApplicationFor.Equals("M.B.A"))
        {
            _ApplicationFor = "MBA";
        }
        else if (ApplicationFor.Equals("M.S.C(Integerated)"))
        {
            _ApplicationFor = "MSCI";
        }
        else if (ApplicationFor.Equals("M.S.C"))
        {
            _ApplicationFor = "MSC";
        }
        else if (ApplicationFor.Equals("M.C.A"))
        {
            _ApplicationFor = "MCA";
        }

        else if (ApplicationFor.Equals("M.C.A Lateral Entry"))
        {
            _ApplicationFor = "MCAL";
        }

        return _ApplicationFor + _CourseType + string.Format("{0:D4}", _ApplicationNo);
    }

    public int AddAppLead(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddAppLead", cnn))
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
                 new SqlParameter("@School_CollegeName", string.Empty));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddAppLead_Admission(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddAppLead_Admission", cnn))
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
                    new SqlParameter("@WhatsAppNo", lead.WhatsAppNo));
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
                 new SqlParameter("@School_CollegeName", string.Empty));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddDashboardLead(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddDashboardLead", cnn))
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
                 new SqlParameter("@AssignedTo", lead.AssignedTo));
                command.Parameters.Add(
                 new SqlParameter("@AssignedRole", lead.AssignedRole));
                command.Parameters.Add(
                 new SqlParameter("@CurrentCallStatus", lead.CurrentCallStatus));
                command.Parameters.Add(
                new SqlParameter("@ResponseStatus", lead.ResponseStatus));
                command.Parameters.Add(
               new SqlParameter("@LastActionTaken", lead.LastActionTaken));
                command.Parameters.Add(
                  new SqlParameter("@AdmissionLevel", lead.AdmissionLevel));
                command.Parameters.Add(
                new SqlParameter("@Remarks", lead.Remarks));
                command.Parameters.Add(
               new SqlParameter("@NextFollowupDate", lead.NextFollowupDate));
                command.Parameters.Add(
                new SqlParameter("@LeadStatus", lead.LeadStatus));
                command.Parameters.Add(
               new SqlParameter("@Department", lead.Department));
                command.Parameters.Add(
              new SqlParameter("@ClosureReason", lead.ClosureReason));
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
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateAppLead(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
            using (SqlCommand command = new SqlCommand("UpdateAppLead", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@LeadId", lead.LeadId));
                command.Parameters.Add(
              new SqlParameter("@CurrentCallStatus", lead.CurrentCallStatus));
                command.Parameters.Add(
            new SqlParameter("@ResponseStatus", lead.ResponseStatus));
                command.Parameters.Add(
            new SqlParameter("@LastActionTaken", lead.LastActionTaken));
                command.Parameters.Add(
            new SqlParameter("@AdmissionLevel", lead.AdmissionLevel));
                command.Parameters.Add(
           new SqlParameter("@Remarks", lead.Remarks));
                command.Parameters.Add(
         new SqlParameter("@LeadStatus", lead.LeadStatus));
                command.Parameters.Add(
         new SqlParameter("@ClosureReason", lead.ClosureReason));
                command.Parameters.Add(
        new SqlParameter("@Department", lead.Department));
                command.Parameters.Add(
       new SqlParameter("@LastUpdatedBy", lead.LastUpdatedBy));
                command.Parameters.Add(
      new SqlParameter("@LastUpdatedDate", lead.LastUpdatedDate));
            command.Parameters.Add(
     new SqlParameter("@RefCode", lead.RefCode));
            command.Parameters.Add(
    new SqlParameter("@LastHistoryUpdateDate", lead.LastHistoryUpdateDate));
            command.Parameters.Add(
  new SqlParameter("@NextFollowUpDate", lead.NextFollowupDate));
            command.Parameters.Add(
 new SqlParameter("@LastFollowupDate", lead.LastFollowupDate));
            command.Parameters.Add(
new SqlParameter("@Referral", lead.Referral));
            rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        //}
        //catch (Exception ex)
        //{
        //}
        return rowsAffected;
    }
    public int UpdateAdmissionLevelStatus(string stAdmissionLevel, string stApplNo,string stSchoolName)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateAdmissionLevelStatus", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;               
                command.Parameters.Add(
              new SqlParameter("@AdmissionLevel", stAdmissionLevel));
                command.Parameters.Add(
            new SqlParameter("@ApplicationNo", stApplNo));
                command.Parameters.Add(
           new SqlParameter("@SchoolCollegeName", stSchoolName));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int UpdateAdmissionLevelStatus_AddGC(string stAdmissionLevel, string stApplNo, string stSchoolName,string stCommunity, string stGender)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateAdmissionLevelStatus_AddGC", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
              new SqlParameter("@AdmissionLevel", stAdmissionLevel));
                command.Parameters.Add(
            new SqlParameter("@ApplicationNo", stApplNo));
                command.Parameters.Add(
           new SqlParameter("@SchoolCollegeName", stSchoolName));
                command.Parameters.Add(
                  new SqlParameter("@Gender", stGender));
                command.Parameters.Add(
           new SqlParameter("@Community", stCommunity));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateAppLeadAdmin(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
        using (SqlCommand command = new SqlCommand("UpdateAppLeadAdmin", cnn))
        {

            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(
          new SqlParameter("@LeadId", lead.LeadId));
            command.Parameters.Add(
          new SqlParameter("@CurrentCallStatus", lead.CurrentCallStatus));
            command.Parameters.Add(
        new SqlParameter("@ResponseStatus", lead.ResponseStatus));
            command.Parameters.Add(
        new SqlParameter("@LastActionTaken", lead.LastActionTaken));
            command.Parameters.Add(
        new SqlParameter("@AdmissionLevel", lead.AdmissionLevel));
            command.Parameters.Add(
       new SqlParameter("@Remarks", lead.Remarks));
            command.Parameters.Add(
     new SqlParameter("@LeadStatus", lead.LeadStatus));
            command.Parameters.Add(
     new SqlParameter("@ClosureReason", lead.ClosureReason));
            command.Parameters.Add(
    new SqlParameter("@Department", lead.Department));
            command.Parameters.Add(
   new SqlParameter("@LastUpdatedBy", lead.LastUpdatedBy));
            command.Parameters.Add(
  new SqlParameter("@LastUpdatedDate", lead.LastUpdatedDate));
            command.Parameters.Add(
     new SqlParameter("@RefCode", lead.RefCode));
            command.Parameters.Add(
    new SqlParameter("@LastHistoryUpdateDate", lead.LastHistoryUpdateDate));
            command.Parameters.Add(
  new SqlParameter("@NextFollowUpDate", lead.NextFollowupDate));
            command.Parameters.Add(
 new SqlParameter("@LastFollowupDate", lead.LastFollowupDate));
            command.Parameters.Add(
new SqlParameter("@Referral", lead.Referral));
            command.Parameters.Add(
new SqlParameter("@AssignedTo", lead.AssignedTo));
            command.Parameters.Add(
new SqlParameter("@Exam", lead.EntranceExam));
            rowsAffected = command.ExecuteNonQuery();
            

        }
        cnn.Close();
        //}
        //catch (Exception ex)
        //{
        //}
        return rowsAffected;
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
    public DataSet ViewLeadByTeleCounsellor(int assignedTo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadByTeleCounsellor", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));

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

    public int UpdateLeadStatus(string stLeadStatus,string stAdmissionLevel,string stLeadid)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateLeadStatus", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@LeadId", stLeadid));
                command.Parameters.Add(
             new SqlParameter("@LeadStatus", stLeadStatus));
                command.Parameters.Add(
            new SqlParameter("@AdmissionLevel", stAdmissionLevel));
                command.Parameters.Add(
           new SqlParameter("@LastHistoryUpdateDate", Utility.IndianTime));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateLeadFollowupdate(string dtLastFollowupdate, string stLeadid)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateLeadFollowupdate", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@LeadId", stLeadid));
               
                command.Parameters.Add(
            new SqlParameter("@LastFollowupDate", dtLastFollowupdate));
                
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewLeadByLeadId(string stLeadId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadByLeadId", cnn))
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
    public DataSet ViewTodayLeads(string stCurrentDate, string assignedTo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTodayLeads", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
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
    public DataSet ViewTodayFollowupLeads(string stCurrentDate, string assignedTo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTodayFollowupLeads", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
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
    public DataSet ViewMissedLeads(string stCurrentDate, string assignedTo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMissedLeads", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
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
    public DataSet ViewLeadsBySearch(string Source,string AdmissionLevel,string Status,string Course,string RefCode,string Location, string stCurrentDate, string assignedTo, string StBranch, string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadsBySearch", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
                command.Parameters.Add(
                                     new SqlParameter("@Branch", StBranch));
                command.Parameters.Add(
                                    new SqlParameter("@State", StState));
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
    public DataSet ViewFollowupLeadsBySearch(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stCurrentDate, string assignedTo, string StBranch, string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewFollowupLeadsBySearch", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
                command.Parameters.Add(
                                     new SqlParameter("@Branch", StBranch));
                command.Parameters.Add(
                                    new SqlParameter("@State", StState));
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
    public DataSet ViewMissedLeadsBySearch(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stCurrentDate, string assignedTo, string StBranch, string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMissedLeadsBySearch", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
                command.Parameters.Add(
                                    new SqlParameter("@Branch", StBranch));
                command.Parameters.Add(
                                    new SqlParameter("@State", StState));
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
    public DataSet ViewAllLeadsBySearch(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stCurrentDate, string assignedTo, string StBranch, string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllLeadsBySearch", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
                command.Parameters.Add(
                                    new SqlParameter("@Branch", StBranch));
                command.Parameters.Add(
                                    new SqlParameter("@State", StState));
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
    public DataSet ViewLeadsBySearchDate(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stFromDate,string stToDate,string assignedTo, string StBranch, string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        //try
        //{
            using (SqlCommand command = new SqlCommand("ViewLeadsBySearchDate", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@FromDate", stFromDate));
                command.Parameters.Add(
                                      new SqlParameter("@ToDate", stToDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
            command.Parameters.Add(
                                    new SqlParameter("@Branch", StBranch));
            command.Parameters.Add(
                                new SqlParameter("@State", StState));
            SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dsNews);

            }

            cnn.Close();
        //}
        //catch (Exception ex)
        //{
        //}
        return dsNews;
    }
    public DataSet ViewLeadBySearchCriteria(string SearchCriteria, string assignedTo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadBySearchCriteria", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@SearchCriteria", SearchCriteria));
                command.Parameters.Add(
                                     new SqlParameter("@AssignedTo", assignedTo));
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
    public DataSet ViewLeadIdByAssigned(string stLeadId,string assignedTo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadIdByAssigned", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                     new SqlParameter("@LeadId", stLeadId));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));

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
    public DataSet ViewLeadByEmailId(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadByEmailId", cnn))
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
    public DataSet ViewLeadByMobileNo(string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadByMobileNo", cnn))
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
    public DataSet ViewReportBySearchForTeleCounsellor(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stState, string assignedTo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        //try
        //{
            using (SqlCommand command = new SqlCommand("ViewReportBySearchForTeleCounsellor", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@State", stState));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dsNews);

            }

            cnn.Close();
        //}
        //catch (Exception ex)
        //{
        //}
        return dsNews;
    }
    public DataSet ViewReportLeadsBySearchDate(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stState, string stFromDate, string stToDate, string assignedTo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewReportLeadsBySearchDate", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
                                  new SqlParameter("@Source", Source));
            command.Parameters.Add(
                                  new SqlParameter("@AdmissionLevel", AdmissionLevel));
            command.Parameters.Add(
                                  new SqlParameter("@Status", Status));
            command.Parameters.Add(
                                  new SqlParameter("@Course", Course));
            command.Parameters.Add(
                                  new SqlParameter("@RefCode", RefCode));
            command.Parameters.Add(
                                  new SqlParameter("@Location", Location));
            command.Parameters.Add(
                                  new SqlParameter("@State", stState));
            command.Parameters.Add(
                                  new SqlParameter("@FromDate", stFromDate));
            command.Parameters.Add(
                                  new SqlParameter("@ToDate", stToDate));
            command.Parameters.Add(
                                  new SqlParameter("@AssignedTo", assignedTo));
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
    public DataSet ViewReportBySearch(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        //try
        //{
        using (SqlCommand command = new SqlCommand("ViewReportBySearch", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
                                  new SqlParameter("@Source", Source));
            command.Parameters.Add(
                                  new SqlParameter("@AdmissionLevel", AdmissionLevel));
            command.Parameters.Add(
                                  new SqlParameter("@Status", Status));
            command.Parameters.Add(
                                  new SqlParameter("@Course", Course));
            command.Parameters.Add(
                                  new SqlParameter("@RefCode", RefCode));
            command.Parameters.Add(
                                  new SqlParameter("@Location", Location));
            command.Parameters.Add(
                                  new SqlParameter("@State", stState));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dsNews);

        }

        cnn.Close();
        //}
        //catch (Exception ex)
        //{
        //}
        return dsNews;
    }
    public DataSet ViewReportLeadsBySearchDateAdmin(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stState, string stFromDate, string stToDate)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewReportLeadsBySearchDateAdmin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@State", stState));
                command.Parameters.Add(
                                      new SqlParameter("@FromDate", stFromDate));
                command.Parameters.Add(
                                      new SqlParameter("@ToDate", stToDate));
               
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
    public DataSet ViewLeadFollowupCount(string assignedTo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadFollowupCount", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));

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
    public DataSet ViewTodayLeadsAdmin(string stCurrentDate)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTodayLeadsAdmin", cnn))
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
    public DataSet ViewTodayFollowupLeadsAdmin(string stCurrentDate)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTodayFollowupLeadsAdmin", cnn))
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
    public DataSet ViewMissedLeadsAdmin(string stCurrentDate)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMissedLeadsAdmin", cnn))
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
    public DataSet ViewAllLeadAdmin()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllLeadAdmin", cnn))
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
    public DataSet ViewLeadAssignedAdmin()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadAssignedAdmin", cnn))
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
    public DataSet ViewTopCourse()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTopCourse", cnn))
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
    public int UpdateLeadAssign(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateLeadAssign", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@LeadId", lead.LeadId));
                command.Parameters.Add(
               new SqlParameter("@AssignedTo", lead.AssignedTo));
                command.Parameters.Add(
               new SqlParameter("@AssignedRole", lead.AssignedRole));
                command.Parameters.Add(
               new SqlParameter("@LastUpdatedBy", lead.LastUpdatedBy));
                command.Parameters.Add(
              new SqlParameter("@LastUpdatedDate", lead.LastUpdatedDate));
                command.Parameters.Add(
              new SqlParameter("@LastUpdatedRole", lead.LastUpdatedRole));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewActiveLeadsAdmin()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewActiveLeadsAdmin", cnn))
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
    public DataSet ViewAdmittedLeadsAdmin()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAdmittedLeadsAdmin", cnn))
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
       
    public DataSet ViewDroppedLeadsAdmin()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewDroppedLeadsAdmin", cnn))
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
    public DataSet ViewTotalLeadsAdmin()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTotalLeadsAdmin", cnn))
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


    public DataSet ViewLeadsBySearchAdmin(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stCurrentDate, string assignedTo,string StBranch,string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadsBySearchAdmin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
                command.Parameters.Add(
                                     new SqlParameter("@Branch", StBranch));
                command.Parameters.Add(
                                    new SqlParameter("@State", StState));
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
    public DataSet ViewFollowupLeadsBySearchAdmin(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stCurrentDate, string assignedTo, string StBranch, string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewFollowupLeadsBySearchAdmin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
                command.Parameters.Add(
                                     new SqlParameter("@Branch", StBranch));
                command.Parameters.Add(
                                   new SqlParameter("@State", StState));
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
    public DataSet ViewMissedLeadsBySearchAdmin(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stCurrentDate, string assignedTo, string StBranch, string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMissedLeadsBySearchAdmin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
                command.Parameters.Add(
                                     new SqlParameter("@Branch", StBranch));
                command.Parameters.Add(
                                   new SqlParameter("@State", StState));
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
    public DataSet ViewAllLeadsBySearchAdmin(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stCurrentDate, string assignedTo, string StBranch,string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllLeadsBySearchAdmin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Source", Source));
                command.Parameters.Add(
                                      new SqlParameter("@AdmissionLevel", AdmissionLevel));
                command.Parameters.Add(
                                      new SqlParameter("@Status", Status));
                command.Parameters.Add(
                                      new SqlParameter("@Course", Course));
                command.Parameters.Add(
                                      new SqlParameter("@RefCode", RefCode));
                command.Parameters.Add(
                                      new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                      new SqlParameter("@CurrentDate", stCurrentDate));
                command.Parameters.Add(
                                      new SqlParameter("@AssignedTo", assignedTo));
                command.Parameters.Add(
                                     new SqlParameter("@Branch", StBranch));
                command.Parameters.Add(
                                  new SqlParameter("@State", StState));
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
    public DataSet ViewLeadsBySearchDateAdmin(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stFromDate, string stToDate, string assignedTo,string StBranch,string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        //try
        //{
        using (SqlCommand command = new SqlCommand("ViewLeadsBySearchDateAdmin", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
                                  new SqlParameter("@Source", Source));
            command.Parameters.Add(
                                  new SqlParameter("@AdmissionLevel", AdmissionLevel));
            command.Parameters.Add(
                                  new SqlParameter("@Status", Status));
            command.Parameters.Add(
                                  new SqlParameter("@Course", Course));
            command.Parameters.Add(
                                  new SqlParameter("@RefCode", RefCode));
            command.Parameters.Add(
                                  new SqlParameter("@Location", Location));
            command.Parameters.Add(
                                  new SqlParameter("@FromDate", stFromDate));
            command.Parameters.Add(
                                  new SqlParameter("@ToDate", stToDate));
            command.Parameters.Add(
                                  new SqlParameter("@AssignedTo", assignedTo));
            command.Parameters.Add(
                                    new SqlParameter("@Branch", StBranch));
            command.Parameters.Add(
                                  new SqlParameter("@State", StState));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dsNews);

        }

        cnn.Close();
        //}
        //catch (Exception ex)
        //{
        //}
        return dsNews;
    }
    public DataSet ViewLeadBySearchCriteriaAdmin(string SearchCriteria)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadBySearchCriteriaAdmin", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@SearchCriteria", SearchCriteria));
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
    public DataSet ViewUnAssignedLeadsBySearch(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location,string StBranch, string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewUnAssignedLeadsBySearch", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
                                  new SqlParameter("@Source", Source));
            command.Parameters.Add(
                                  new SqlParameter("@AdmissionLevel", AdmissionLevel));
            command.Parameters.Add(
                                  new SqlParameter("@Status", Status));
            command.Parameters.Add(
                                  new SqlParameter("@Course", Course));
            command.Parameters.Add(
                                  new SqlParameter("@RefCode", RefCode));
            command.Parameters.Add(
                                  new SqlParameter("@Location", Location));
                command.Parameters.Add(
                                         new SqlParameter("@Branch", StBranch));
                command.Parameters.Add(
                                        new SqlParameter("@State", StState));
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
    public DataSet ViewUnAssignedLeadsBySearchDateAdmin(string Source, string AdmissionLevel, string Status, string Course, string RefCode, string Location, string stFromDate, string stToDate,string StState)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        //try
        //{
        using (SqlCommand command = new SqlCommand("ViewUnAssignedLeadsBySearchDateAdmin", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
                                  new SqlParameter("@Source", Source));
            command.Parameters.Add(
                                  new SqlParameter("@AdmissionLevel", AdmissionLevel));
            command.Parameters.Add(
                                  new SqlParameter("@Status", Status));
            command.Parameters.Add(
                                  new SqlParameter("@Course", Course));
            command.Parameters.Add(
                                  new SqlParameter("@RefCode", RefCode));
            command.Parameters.Add(
                                  new SqlParameter("@Location", Location));
            command.Parameters.Add(
                                  new SqlParameter("@FromDate", stFromDate));
            command.Parameters.Add(
                                  new SqlParameter("@ToDate", stToDate));
            command.Parameters.Add(
                                  new SqlParameter("@State", stToDate));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dsNews);

        }

        cnn.Close();
        //}
        //catch (Exception ex)
        //{
        //}
        return dsNews;
    }
    public DataSet ViewApplicationByEmailId(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewApplicationByEmailId", cnn))
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
    public DataSet ViewApplicationByMobileNo(string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewApplicationByMobileNo", cnn))
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
    public DataSet GetApplicationDetails(string stApplicationNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        SqlCommand cmd = new SqlCommand("spGetApplicationDetailsByApplicationNo", cnn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        dpt.Fill(dt);
        return dt;
    }
    public DataSet ViewLeadByApplicationNo(string stApplicationNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        SqlCommand cmd = new SqlCommand("ViewLeadByApplicationNo", cnn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        dpt.Fill(dt);
        return dt;
    }
    public int UpdateApplicationNo(string stApplicationNo, string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateApplicationNo", cnn))
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

    public int UpdateprovisionaladmissionforInLeads(string stApplicationNo, string provisionaladmissionfor, string proviadmissionfees)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        cnn.Open();
        SqlCommand cmd = new SqlCommand("spUpdateprovisionaladmissionforInLeads", cnn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        cmd.Parameters.AddWithValue("@provisionaladmissionfor", provisionaladmissionfor);
        cmd.Parameters.AddWithValue("@proviadmissionfees", proviadmissionfees);
        int provisional = int.Parse(cmd.ExecuteNonQuery().ToString());

        return provisional;

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
    public DataSet ViewCourseByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCourseByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@courseID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewBranchCoursesByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewBranchCoursesByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@BranchID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewSource()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewSource", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewSourceonlyforAdmission()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewSourceonlyforAdmission", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewSourceByID(string sourceID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewSourceByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@sourceID", sourceID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }
    public DataSet ViewState()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewState", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCityBYStateID(string stateID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCityBYStateID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@StateID", stateID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }


    public DataSet ViewDistrictBYStateID(string stateID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewDistrictBYStateID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@StateID", stateID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }
    public DataSet ViewCityByDistrictID(string DistrictID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCityByDistrictID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@DistrictID", DistrictID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
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

    public int UpdateApplicationNo23ByEmailId(string stApplicationNo, string stEmailID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateApplicationNo23ByEmailId", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@ApplicationNo", stApplicationNo));
                command.Parameters.Add(
               new SqlParameter("@EmailID", stEmailID));
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

    public int AddAppLead23(pmulead lead)
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
                    new SqlParameter("@District", lead.District));
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

    public DataSet ViewSpecialByBranchname(string branchname)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewSpecialByBranchname", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@branchname", branchname));

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

    public DataSet ViewBranchByCNameModeTypeCamp(string course, string coursetype, string coursemode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewBranchByCNameModeTypeCamp", cnn))
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
    public int UpdateAdmissionLevelApplnFeesPaid(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateAdmissionLevelApplnFeesPaid", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@AdmissionLevel", lead.AdmissionLevel));
                command.Parameters.Add(new SqlParameter("@ApplicationNo", lead.ApplicaionNo));
                command.Parameters.Add(new SqlParameter("@modeofpayment", lead.modeofpayment));

                command.Parameters.Add(new SqlParameter("@BillNo", lead.BillNo));
                command.Parameters.Add(new SqlParameter("@ApplnFees", lead.ApplnFees));
                command.Parameters.Add(new SqlParameter("@PaymentDate", lead.PaymentDate));
                command.Parameters.Add(new SqlParameter("@ApplnFeesUpdatedBy", lead.ApplnFeesUpdatedBy));

                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int UpdateprovisionalPaymentDetailsInLeads(string ApplicationNo, string transerrmsg)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateprovisionalPaymentDetailsInLeads", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ApplicationNo", ApplicationNo));
                command.Parameters.Add(new SqlParameter("@PaymentDateTime", Utility.IndianTime));
                command.Parameters.Add(new SqlParameter("@TransErrorMessage", transerrmsg));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public void BindScholarship(DropDownList ddl)
    {
        pmulead lead = new pmulead();
        DataSet ds = lead.ViewScholarshipdrp();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["Scholarship"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["SID"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }
    public DataSet ViewScholarshipdrp()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewScholarshipdrp", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }
        cnn.Close();
        return ds;
    }

    public int UpdateAddGC(string stApplNo, string stSchoolName, string stCommunity, string stGender)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateAddGC", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@ApplicationNo", stApplNo));
                command.Parameters.Add(
           new SqlParameter("@SchoolCollegeName", stSchoolName));
                command.Parameters.Add(
                  new SqlParameter("@Gender", stGender));
                command.Parameters.Add(
           new SqlParameter("@Community", stCommunity));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet RawLeadEmailExist(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("RawLeadEmailExist", cnn))
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
    public DataSet RawLeadMobileNoExist(string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("RawLeadMobileNoExist", cnn))
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

    public int UpdateRawLeadStatus(string EmailIDMobileNo, string Flag)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateRawLeadStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@EmailIDMobileNo", EmailIDMobileNo));
                command.Parameters.Add(
                    new SqlParameter("@Flag", Flag));
                command.Parameters.Add(
                   new SqlParameter("@leadstatus", "Active"));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewRawDetailsByEmailMobile(string stEmailId, string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRawDetailsByEmailMobile", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@EmailId", stEmailId));
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

    public int UpdateRawLeadStatusByRawID(string RawID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateRawLeadStatusByRawID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@RawID", RawID));
                command.Parameters.Add(
                   new SqlParameter("@leadstatus", "Active"));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int AddAppLead23Modify(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddAppLead23Modify", cnn))
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
                command.Parameters.Add(
              new SqlParameter("@RawLeadId", lead.RawLeadId));
                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int AddAppLead24New(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddAppLead24", cnn))
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
                    new SqlParameter("@District", string.Empty));
                command.Parameters.Add(
                    new SqlParameter("@HSCRegID", lead.HSCRegID));
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
                command.Parameters.Add(
              new SqlParameter("@RawLeadId", string.Empty));
               
                command.Parameters.Add(
             new SqlParameter("@PMESE_Reg", string.Empty));
                command.Parameters.Add(
             new SqlParameter("@PMESE_Score", string.Empty));
                command.Parameters.Add(
             new SqlParameter("@PMESE_ExamStatus", string.Empty));

                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddAppLead2024(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddAppLead2024", cnn))
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
                    new SqlParameter("@District", lead.District));
                command.Parameters.Add(
                    new SqlParameter("@HSCRegID", lead.HSCRegID));
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
                command.Parameters.Add(
              new SqlParameter("@RawLeadId", lead.RawLeadId));

              command.Parameters.AddWithValue("@Special1", lead.Specialisation1);
                command.Parameters.AddWithValue("@Special2", lead.Specialisation2);
                command.Parameters.AddWithValue("@Special3", lead.Specialisation3);
               
                command.Parameters.Add(
             new SqlParameter("@PMESE_Reg", lead.PMESEReg));
                command.Parameters.Add(
             new SqlParameter("@PMESE_Score", lead.PMESEScore));
                command.Parameters.Add(
             new SqlParameter("@PMESE_ExamStatus", lead.PMESEExamStatus));

                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int AddAppLead24(pmulead lead)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddAppLead24", cnn))
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
                    new SqlParameter("@District", lead.District));
                command.Parameters.Add(
                    new SqlParameter("@HSCRegID", lead.HSCRegID));
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
                command.Parameters.Add(
              new SqlParameter("@RawLeadId", lead.RawLeadId));
               
                command.Parameters.Add(
             new SqlParameter("@PMESE_Reg", lead.PMESEReg));
                command.Parameters.Add(
             new SqlParameter("@PMESE_Score", lead.PMESEScore));
                command.Parameters.Add(
             new SqlParameter("@PMESE_ExamStatus", lead.PMESEExamStatus));

                rowsAffected = command.ExecuteNonQuery();


            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewTotalAS()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTotalAS", cnn))
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
    public DataSet ViewTotalPA()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTotalPA", cnn))
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
    public int AddLeadApplnMasterList23(ApplicationForm form)
    {
        int rows = 0;
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMULead"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("spApplicationMasterListCreateTest23", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@ApplicationNo", form.ApplicationNo);
            cmd.Parameters.AddWithValue("@NameOfApplicant", form.NameOfApplicant);
            cmd.Parameters.AddWithValue("@EmailId", form.EmailID);
            cmd.Parameters.AddWithValue("@CandidateMobileNo", form.CandidateMobileNo);
            cmd.Parameters.AddWithValue("@DateOfBirth", form.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", form.Gender);
            cmd.Parameters.AddWithValue("@ApplicationFor", form.ApplicationFor);
            cmd.Parameters.AddWithValue("@AddressForCommunication", form.AddressForCommunication);
            cmd.Parameters.AddWithValue("@Village", form.Village);
            cmd.Parameters.AddWithValue("@District", form.District);
            cmd.Parameters.AddWithValue("@City", form.City);
            cmd.Parameters.AddWithValue("@DifferentAblePerson", form.DifferentAblePerson);
            cmd.Parameters.AddWithValue("@PercentageOfDisability", form.PercentageOfDisability);
            cmd.Parameters.AddWithValue("@Country", form.Country);
            cmd.Parameters.AddWithValue("@state", form.State);
            cmd.Parameters.AddWithValue("@Pincode", form.Pincode);
            cmd.Parameters.AddWithValue("@ParentMobileNo", form.ParentMobileNo);
            cmd.Parameters.AddWithValue("@ParentTelephoneNo", form.ParentTelephoneNo);
            cmd.Parameters.AddWithValue("@PermanentAddress", form.PermanentAddress);
            cmd.Parameters.AddWithValue("@SslcSchoolName", form.SslcSchoolName);
            cmd.Parameters.AddWithValue("@SslcMediumOfInstruction", form.SslcMediumOfInstruction);
            cmd.Parameters.AddWithValue("@SslcYearOfPassing", form.SslcYearOfPassing);
            cmd.Parameters.AddWithValue("@SslcNoOFAttempt", form.SslcNoOFAttempt);
            cmd.Parameters.AddWithValue("@SslcRegistrationNo", form.SslcRegistrationNo);
            cmd.Parameters.AddWithValue("@SslcPercentage", form.SslcPercentage);
            cmd.Parameters.AddWithValue("@SslcBoardOfExamination", form.SslcBoardOFExamination);
            cmd.Parameters.AddWithValue("@HscSchoolName", form.HscSchoolName);
            cmd.Parameters.AddWithValue("@HscMediumOfInstruction", form.HscMediumOfInstruction);
            cmd.Parameters.AddWithValue("@HscNoOfAttempt", form.HscNoOfAttempt);
            cmd.Parameters.AddWithValue("@HscRegistrationNo", form.HscRegistrationNo);
            cmd.Parameters.AddWithValue("@HscYearOfPassing", form.HscYearOfPassing);
            cmd.Parameters.AddWithValue("@HscPercentage", form.HscPercentage);
            cmd.Parameters.AddWithValue("@HscBoardOfExamination", form.HscBoardOFExamination);
            cmd.Parameters.AddWithValue("@CollegeName", form.CollageName);
            cmd.Parameters.AddWithValue("@YearOfPassing", form.YearOfPassing);
            cmd.Parameters.AddWithValue("@Degree", form.Degree);
            cmd.Parameters.AddWithValue("@Percentage", form.Percentage);
            cmd.Parameters.AddWithValue("@BoardOfExamination", form.University);
            cmd.Parameters.AddWithValue("@RegistrationNo", form.RegistrationNo);
            cmd.Parameters.AddWithValue("@CutOffMarks", form.CutOffMarks);
            cmd.Parameters.AddWithValue("@Eligibility", form.Eligibility);
            cmd.Parameters.AddWithValue("@ModeOfPayment", form.ModeOfPayment);
            cmd.Parameters.AddWithValue("@TelephoneNo", form.TelephoneNo);
            cmd.Parameters.AddWithValue("@BloodGroup", form.BloodGroup);
            cmd.Parameters.AddWithValue("@Caste", form.Caste);
            cmd.Parameters.AddWithValue("@Religion", form.Religion);
            cmd.Parameters.AddWithValue("@Community", form.Community);
            cmd.Parameters.AddWithValue("@Nationality", form.Nationality);
            cmd.Parameters.AddWithValue("@FatherName", form.FatherName);
            cmd.Parameters.AddWithValue("@MotherName", form.MotherName);
            cmd.Parameters.AddWithValue("@ParentsOccupation", string.Empty);
            cmd.Parameters.AddWithValue("@AnnualIncome", form.AnnualIncome);
            cmd.Parameters.AddWithValue("@MotherTongue", form.MotherTongue);
            cmd.Parameters.AddWithValue("@MaritalStatus", form.MaritalStatus);
            cmd.Parameters.AddWithValue("@HostelRequired", form.HostelRequired);
            cmd.Parameters.AddWithValue("@AchivementInSports", form.AchivementInSports);
            cmd.Parameters.AddWithValue("@Level", form.Level);
            cmd.Parameters.AddWithValue("@Game", form.Game);
            cmd.Parameters.AddWithValue("Medal", form.Medal);
            cmd.Parameters.AddWithValue("NATAScore", form.NATAScore);
            cmd.Parameters.AddWithValue("@UniGaugeScore", form.UniGaugeScore);
            cmd.Parameters.AddWithValue("@PostedDate", form.PostedDate);
            cmd.Parameters.AddWithValue("@Fees", form.Fees);
            cmd.Parameters.AddWithValue("@HscTotalMarks", form.HscTotalMarks);
            cmd.Parameters.AddWithValue("@FatherOccupation", form.FatherOccupation);
            cmd.Parameters.AddWithValue("@MotherOccupation", form.MotherOccupation);
            cmd.Parameters.AddWithValue("@AadharNumber", form.AadharNumber);
            cmd.Parameters.AddWithValue("@Medium", form.DegreeMedium);
            cmd.Parameters.AddWithValue("@TransportRequired", form.TransportRequired);


            rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd = new SqlCommand("spHscMarkDetailsDelete23", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ApplicationNo", form.ApplicationNo);

            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("spHSCMarksCreateTest23", con);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (HSCMarks _mark in form.HscMarks)
            {
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
                cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
                cmd.Parameters.AddWithValue("@Board", _mark.Board);
                cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

                cmd.ExecuteNonQuery();
            }
        }
        catch(Exception e)
        {

        }

        return rows;
    }

    public DataSet ViewLeadByCourseEmailMobileNo(string stEmail, string stMobileNo, string coursemode, string coursetype, string Applnfor)
    {
        string connetionString = null;
        SqlConnection con;
        connetionString = GetSqlConnection();
        con = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadByCourseEmailMobileNo", con))
            {
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Email", stEmail));
                command.Parameters.Add(new SqlParameter("@MobileNo", stMobileNo));
                command.Parameters.Add(new SqlParameter("@coursemode", coursemode));
                command.Parameters.Add(new SqlParameter("@coursetype", coursetype));
                command.Parameters.Add(new SqlParameter("@Applnfor", Applnfor));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dsNews);

            }

            con.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public int UpdateLeadApplicationNoByCourseEmailMobileNo(string stApplicationNo, string stEmail, string stMobileNo, string coursemode,
        string coursetype, string Applnfor,string PMESEReg,string PMESEScore,string PMESEExamStatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateLeadApplicationNoByCourseEmailMobileNo", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ApplicationNo", stApplicationNo));
                command.Parameters.Add(new SqlParameter("@Email", stEmail));
                command.Parameters.Add(new SqlParameter("@MobileNo", stMobileNo));
                command.Parameters.Add(new SqlParameter("@coursemode", coursemode));
                command.Parameters.Add(new SqlParameter("@coursetype", coursetype));
                command.Parameters.Add(new SqlParameter("@Applnfor", Applnfor));
                command.Parameters.Add(new SqlParameter("@PMESE_Reg", PMESEReg));
                command.Parameters.Add(new SqlParameter("@PMESE_Score", PMESEScore));
                command.Parameters.Add(new SqlParameter("@PMESE_ExamStatus",PMESEExamStatus));

                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewScholarshipByID(string ScholarshipID)
    {
        string connetionString = null;
        SqlConnection con;
        connetionString = GetSqlConnection();
        con = new SqlConnection(connetionString); DataSet dsNews = new DataSet();

        try
        {
            using (SqlCommand command = new SqlCommand("ViewScholarshipByID", con))
            {
                con.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@SID", ScholarshipID));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dsNews);

            }

            con.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public DataSet ViewLeadByEmailMobileNo(string Email, string Mobileno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();

        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewLeadByEmailMobileNo", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Email", Email));
                cmd.Parameters.Add(new SqlParameter("@Mobileno", Mobileno));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsNews);

            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public int UpdateLeadByEmailMobile(string stApplicationNo, string stEmail, string stMobileNo, string PMESEReg, string PMESEScore, string PMESEExamStatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateLeadByEmailMobile", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ApplicationNo", stApplicationNo));
                command.Parameters.Add(new SqlParameter("@Email", stEmail));
                command.Parameters.Add(new SqlParameter("@MobileNo", stMobileNo));
                command.Parameters.Add(new SqlParameter("@PMESE_Reg", PMESEReg));
                command.Parameters.Add(new SqlParameter("@PMESE_Score", PMESEScore));
                command.Parameters.Add(new SqlParameter("@PMESE_ExamStatus", PMESEExamStatus));

                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int UpdateLeadByMobile(string stApplicationNo, string stMobileNo, string PMESEReg, string PMESEScore, string PMESEExamStatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateLeadByMobile", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ApplicationNo", stApplicationNo));
                command.Parameters.Add(new SqlParameter("@MobileNo", stMobileNo));
                command.Parameters.Add(new SqlParameter("@PMESE_Reg", PMESEReg));
                command.Parameters.Add(new SqlParameter("@PMESE_Score", PMESEScore));
                command.Parameters.Add(new SqlParameter("@PMESE_ExamStatus", PMESEExamStatus));

                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int UpdateLeadByEmailId(string stApplicationNo, string stEmail, string PMESEReg, string PMESEScore, string PMESEExamStatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateLeadByEmailId", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ApplicationNo", stApplicationNo));
                command.Parameters.Add(new SqlParameter("@Email", stEmail));
                command.Parameters.Add(new SqlParameter("@PMESE_Reg", PMESEReg));
                command.Parameters.Add(new SqlParameter("@PMESE_Score", PMESEScore));
                command.Parameters.Add(new SqlParameter("@PMESE_ExamStatus", PMESEExamStatus));

                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
}
