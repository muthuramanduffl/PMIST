using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for ApplicationForm
/// </summary>
public class ApplicationForm23
{

    #region

    public string UserName { get; set; }
    public string Password { get; set; }
    public string ApplicationNo { get; set; }
    public string NameOfApplicant { get; set; }
    public string CandidateMobileNo { get; set; }
    public string CandidateWhatsAppNo { get; set; }
    public string EmailID { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Course { get; set; }
    public string Gender { get; set; }
    public string ApplicationFor { get; set; }
    public string CourseType { get; set; }
    public string Choice { get; set; }
    public string ChoiceTwo { get; set; }
    public string ChoiceThree { get; set; }
    public string AddressForCommunication { get; set; }
    public string Village { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public string DifferentAblePerson { get; set; }
    public string PercentageOfDisability { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Pincode { get; set; }
    public string Scholarship { get; set; }
    public string ParentMobileNo { get; set; }
    public string ParentTelephoneNo { get; set; }
    public string PermanentAddress { get; set; }
    public string SslcSchoolName { get; set; }
    public string SslcYearOfPassing { get; set; }
    public string MediumOfInstruction { get; set; }
    public string SslcNoOFAttempt { get; set; }
    public string SslcPercentage { get; set; }
    public string SslcRegistrationNo { get; set; }
    public string SslcBoardOFExamination { get; set; }
    public string SslcMediumOfInstruction { get; set; }
    public string HscSchoolName { get; set; }
    public string HscYearOfPassing { get; set; }
    public string HscPercentage { get; set; }
    public string HscRegistrationNo { get; set; }
    public string HscMediumOfInstruction { get; set; }
    public string HscNoOfAttempt { get; set; }
    public string HscBoardOFExamination { get; set; }
    public string SubjectName { get; set; }
    public string SubjectMark { get; set; }
    public string Board { get; set; }
    public string RegistrationNo1 { get; set; }
    public string ScoredMarks { get; set; }
    public string MaximumMarks { get; set; }
    public string TotalMarks { get; set; }
    public string CollageName { get; set; }
    public string YearOfPassing { get; set; }
    public string Degree { get; set; }
    public string RegistrationNo { get; set; }
    public string University { get; set; }
    public string DegreeYearOfPassing { get; set; }
    public string Percentage { get; set; }
    public string CutOffMarks { get; set; }
    public string Eligibility { get; set; }
    public string ModeOfPayment { get; set; }
    public string TelephoneNo { get; set; }
    public string BloodGroup { get; set; }
    public string Caste { get; set; }
    public string Religion { get; set; }
    public string Community { get; set; }
    public string Nationality { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string MaritalStatus { get; set; }
    public string Level { get; set; }
    public string Game { get; set; }
    public string Medal { get; set; }
    public string ParentsOccupation { get; set; }
    public string AnnualIncome { get; set; }
    public string MotherTongue { get; set; }
    public string HostelRequired { get; set; }
    public string AchivementInSports { get; set; }
    public string UniGaugeScore { get; set; }
    public string NATAScore { get; set; }
    public DateTime PostedDate { get; set; }
    public string Fees { get; set; }
    public string FromDate { get; set; }
    public DateTime BillDate { get; set; }
    public string BillNo { get; set; }
    public string ToDate { get; set; }
    public string NameOftheApplicant { get; set; }
    public string HscTotalMarks { get; set; }
    public string FatherOccupation { get; set; }
    public string MotherOccupation { get; set; }
    public string DegreeMedium { get; set; }
    public string AadharNumber { get; set; }
    public string AppliedFrom { get; set; }
    public List<HSCMarks> HscMarks { get; set; }
    public string provisionaladmissionfor { get; set; }

    public string provisionaladmissionfees { get; set; }

    public string paymentdate { get; set; }

    #endregion

    public ApplicationForm23()
    {
        //
        // TODO: Add constructor logic here
        //
        this.HscMarks = new List<HSCMarks>();
    }
    public DataSet ViewRegByEmailId23(string stEmailId)
    {
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegByEmailId23", con))
            {
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@EmailId", stEmailId));

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
    public DataSet ViewRegByMobileNo23(string stMobileNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegByMobileNo23", con))
            {
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@MobileNo", stMobileNo));
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
}
    