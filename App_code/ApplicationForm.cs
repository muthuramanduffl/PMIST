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
public class ApplicationForm
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
    public string FacultySchool { get; set; }
    public string provisionaladmissionfees { get; set; }
    public string Scholarship { get; set; }
    public string paymentdate { get; set; }
    public string TransportRequired { get; set; }
    public string TextApplicationFor { get; set; }
    public string ApplnForID { get; set; }
    public DateTime CBillDate { get; set; }
    public string CBillNo { get; set; }

    public string MotherMobileNo { get; set; }
    public string CommunitycentralQuota { get; set; }
    public string SslcSchoolDistrict { get; set; }
    public string HSCSchoolDistrict { get; set; }
    public string SslcSchoolCategory { get; set; }
    public string HSCSchoolCategory { get; set; }
    
    #endregion

    public ApplicationForm()
    {
        //
        // TODO: Add constructor logic here
        //
        this.HscMarks = new List<HSCMarks>();
    }
    public string GetSqlConnection()
    {
        string connectionString = null;
        try
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;
        }
        catch (Exception ex)
        {
        }
        return connectionString;
    }

    public string NewApplicationNo(string CourseType, string ApplicationFor)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationNo", con);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        int _ApplicationNo = int.Parse(cmd.ExecuteScalar().ToString()) + 1;

        string _CourseType = "";
        string _ApplicationFor = "";

        if (CourseType.Equals("Regular"))
        {
            _CourseType = "R";
        }
        else if (CourseType.Equals("Part Time"))
        {
            _CourseType = "PT";
        }
        else
        {
            _CourseType = "LAT";
        }

        if (ApplicationFor.Equals("B.Tech"))
        {
            if (CourseType.Equals("Regular"))
            {
                _ApplicationFor = "BTF";
            }
            else if (CourseType.Equals("Part Time"))
            {
                _ApplicationFor = "BTP";
            }
            else if (CourseType.Equals("Lateral"))
            {
                _ApplicationFor = "BTL";
            }
        }
       
        else if (ApplicationFor.Equals("BCA"))
        {
            _ApplicationFor = "BCA";
        }
        if (ApplicationFor.Equals("B.Com"))
        {
            _ApplicationFor = "BCOM";
        }
        if (ApplicationFor.Equals("B.Sc"))
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

        if (ApplicationFor.Equals("BBA") || ApplicationFor.Equals("B.B.A"))
        {
            _ApplicationFor = "BBA";
        }

       

        else if (ApplicationFor.Equals("B.Sc B.Ed"))
        {
            _ApplicationFor = "BSE";
        }
        else if (ApplicationFor.Equals("B.Ed"))
        {
            _ApplicationFor = "BED";
        }
        else if (ApplicationFor.Equals("M.Tech"))
        {
            if (CourseType.Equals("Regular"))
            {
                _ApplicationFor = "MTF";
            }
            else if (CourseType.Equals("Part Time"))
            {
                _ApplicationFor = "MTP";
            }
           
            
        }
        
        else if (ApplicationFor.Equals("M.A"))
        {
            _ApplicationFor = "MA";
        }
        else if (ApplicationFor.Equals("M.Arch"))
        {
            _ApplicationFor = "MAR";
        }
        if (ApplicationFor.Equals("MSW"))
        {
            _ApplicationFor = "MSW";
        }
        else if (ApplicationFor.Equals("MBA"))
        {
            _ApplicationFor = "MBA";
        }
       
        else if (ApplicationFor.Equals("M.Sc"))
        {
            _ApplicationFor = "MSC";
        }
        else if (ApplicationFor.Equals("MCA"))
        {
            _ApplicationFor = "MCA";
        }

        else if (ApplicationFor.Equals("M.Com"))
        {
            _ApplicationFor = "MCOM";
        }

        // return _ApplicationFor + _CourseType + string.Format("{0:D5}", _ApplicationNo);
        //return _ApplicationFor + _CourseType + string.Format("{0:D5}", _ApplicationNo) + Util.GetDateFormat(Utility.IndianTime) + Util.GenerateOTP();

        return _ApplicationFor + _CourseType + string.Format("{0:D5}", _ApplicationNo);

    }

    public string NewApplicationNo23(string CourseType, string ApplicationFor)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationNo23", con);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        int _ApplicationNo = int.Parse(cmd.ExecuteScalar().ToString()) + 1;

        string _CourseType = "";
        string _ApplicationFor = "";

        if (CourseType.Equals("Regular"))
        {
            _CourseType = "R";
        }
        else if (CourseType.Equals("Part Time"))
        {
            _CourseType = "PT";
        }
        else
        {
            _CourseType = "LAT";
        }

        if (ApplicationFor.Equals("B.Tech"))
        {
            if (CourseType.Equals("Regular"))
            {
                _ApplicationFor = "BTF";
            }
            else if (CourseType.Equals("Part Time"))
            {
                _ApplicationFor = "BTP";
            }
            else if (CourseType.Equals("Lateral"))
            {
                _ApplicationFor = "BTL";
            }
        }
       
        else if (ApplicationFor.Equals("BCA"))
        {
            _ApplicationFor = "BCA";
        }
        if (ApplicationFor.Equals("B.Com"))
        {
            _ApplicationFor = "BCOM";
        }
        if (ApplicationFor.Equals("B.Sc"))
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

        if (ApplicationFor.Equals("BBA") || ApplicationFor.Equals("B.B.A"))
        {
            _ApplicationFor = "BBA";
        }

       

        else if (ApplicationFor.Equals("B.Sc B.Ed"))
        {
            _ApplicationFor = "BSE";
        }
        else if (ApplicationFor.Equals("B.Ed"))
        {
            _ApplicationFor = "BED";
        }
        else if (ApplicationFor.Equals("M.Tech"))
        {
            if (CourseType.Equals("Regular"))
            {
                _ApplicationFor = "MTF";
            }
            else if (CourseType.Equals("Part Time"))
            {
                _ApplicationFor = "MTP";
            }
           
            
        }
        
        else if (ApplicationFor.Equals("M.A"))
        {
            _ApplicationFor = "MA";
        }
        else if (ApplicationFor.Equals("M.Arch"))
        {
            _ApplicationFor = "MAR";
        }
        if (ApplicationFor.Equals("MSW"))
        {
            _ApplicationFor = "MSW";
        }
        else if (ApplicationFor.Equals("MBA"))
        {
            _ApplicationFor = "MBA";
        }
       
        else if (ApplicationFor.Equals("M.Sc"))
        {
            _ApplicationFor = "MSC";
        }
        else if (ApplicationFor.Equals("MCA"))
        {
            _ApplicationFor = "MCA";
        }

        else if (ApplicationFor.Equals("M.Com"))
        {
            _ApplicationFor = "MCOM";
        }

        // return _ApplicationFor + _CourseType + string.Format("{0:D5}", _ApplicationNo);
        //return _ApplicationFor + _CourseType + string.Format("{0:D5}", _ApplicationNo) + Util.GetDateFormat(Utility.IndianTime) + Util.GenerateOTP();

        return _ApplicationFor + _CourseType + string.Format("{0:D5}", _ApplicationNo);

    }

    public string NewApplicationNoForCampaign(string AppliedFrom)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationNoForCampaign", con);
        cmd.Parameters.AddWithValue("@AppliedFrom", AppliedFrom);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        int _ApplicationNo = int.Parse(cmd.ExecuteScalar().ToString()) + 1;

        string _CourseType = "";
        string _ApplicationFor = "";

        if (AppliedFrom.Equals("aerospacecampaign"))
        {
            _CourseType = "AR";
        }
        else
        {
            _CourseType = "ED";
        }

        return _ApplicationFor + _CourseType + string.Format("{0:D4}", _ApplicationNo);
    }
    public bool IsApplicationAlreadyRegistered(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationIsRegistered", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }
    public bool IsApplicationAlreadyRegistered23(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationIsRegistered23", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }


    public bool IsBillNoAlreadyRegister(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spBillNoIsRegister", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }

    public bool IsBillNoAlreadyRegister2023(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spBillNoIsRegister2023", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }

    public bool IsBillNoNotRegister(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spBillNoNotRegister", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }

    //public bool IsApplicationNotRegister(string ApplicaitonNo)
    //{
    //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand("spBillNoNotRegisters", con);
    //    cmd.CommandType = System.Data.CommandType.StoredProcedure;

    //    cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

    //    int rows = Convert.ToInt32(cmd.ExecuteScalar());

    //    return rows > 0 ? true : false;

    //}

    public bool IsApplicationMasterListIsRegistered(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterListIsRegistered", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }
    public bool IsApplicationMasterRegistered(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterRegistered", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }
    public bool IsApplicationMasterRegistered23(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterRegistered23", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }

    public bool IsApplicationIsRegistered(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationRegistered", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }
    public bool IsApplicationIsRegistered23(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationRegistered23", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }
    public bool IsInsertBillNoAlreadyRegister(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spInsertBillNoIsRegistered", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }



    public int Create()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterListCreate1", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@NameOfApplicant", this.NameOfApplicant);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
        cmd.Parameters.AddWithValue("@CandidateMobileNo", this.CandidateMobileNo);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@Gender", this.Gender);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@AddressForCommunication", this.AddressForCommunication);
        cmd.Parameters.AddWithValue("@Village", this.Village);
        cmd.Parameters.AddWithValue("@District", this.District);
        cmd.Parameters.AddWithValue("@City", this.City);
        cmd.Parameters.AddWithValue("@DifferentAblePerson", this.DifferentAblePerson);
        cmd.Parameters.AddWithValue("@PercentageOfDisability", this.PercentageOfDisability);
        cmd.Parameters.AddWithValue("@Country", this.Country);
        cmd.Parameters.AddWithValue("@state", this.State);
        cmd.Parameters.AddWithValue("@Pincode", this.Pincode);
        cmd.Parameters.AddWithValue("@ParentMobileNo", this.ParentMobileNo);
        cmd.Parameters.AddWithValue("@ParentTelephoneNo", this.ParentTelephoneNo);
        cmd.Parameters.AddWithValue("@PermanentAddress", this.PermanentAddress);
        cmd.Parameters.AddWithValue("@SslcSchoolName", this.SslcSchoolName);
        cmd.Parameters.AddWithValue("@SslcMediumOfInstruction", this.SslcMediumOfInstruction);
        cmd.Parameters.AddWithValue("@SslcYearOfPassing", this.SslcYearOfPassing);
        cmd.Parameters.AddWithValue("@SslcNoOFAttempt", this.SslcNoOFAttempt);
        cmd.Parameters.AddWithValue("@SslcRegistrationNo", this.SslcRegistrationNo);
        cmd.Parameters.AddWithValue("@SslcPercentage", this.SslcPercentage);
        cmd.Parameters.AddWithValue("@SslcBoardOfExamination", this.SslcBoardOFExamination);
        cmd.Parameters.AddWithValue("@HscSchoolName", this.HscSchoolName);
        cmd.Parameters.AddWithValue("@HscMediumOfInstruction", this.HscMediumOfInstruction);
        cmd.Parameters.AddWithValue("@HscNoOfAttempt", this.HscNoOfAttempt);
        cmd.Parameters.AddWithValue("@HscRegistrationNo", this.HscRegistrationNo);
        cmd.Parameters.AddWithValue("@HscYearOfPassing", this.HscYearOfPassing);
        cmd.Parameters.AddWithValue("@HscPercentage", this.HscPercentage);
        cmd.Parameters.AddWithValue("@HscBoardOfExamination", this.HscBoardOFExamination);
        cmd.Parameters.AddWithValue("@CollegeName", this.CollageName);
        cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);
        cmd.Parameters.AddWithValue("@Degree", this.Degree);
        cmd.Parameters.AddWithValue("@Percentage", this.Percentage);
        cmd.Parameters.AddWithValue("@BoardOfExamination", this.University);
        cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
        cmd.Parameters.AddWithValue("@CutOffMarks", this.CutOffMarks);
        cmd.Parameters.AddWithValue("@Eligibility", this.Eligibility);
        cmd.Parameters.AddWithValue("@ModeOfPayment", this.ModeOfPayment);
        cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);
        cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
        cmd.Parameters.AddWithValue("@Caste", this.Caste);
        cmd.Parameters.AddWithValue("@Religion", this.Religion);
        cmd.Parameters.AddWithValue("@Community", this.Community);
        cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
        cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
        cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
        cmd.Parameters.AddWithValue("@ParentsOccupation", string.Empty);
        cmd.Parameters.AddWithValue("@AnnualIncome", this.AnnualIncome);
        cmd.Parameters.AddWithValue("@MotherTongue", this.MotherTongue);
        cmd.Parameters.AddWithValue("@MaritalStatus", this.MaritalStatus);
        cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
        cmd.Parameters.AddWithValue("@AchivementInSports", this.AchivementInSports);
        cmd.Parameters.AddWithValue("@Level", this.Level);
        cmd.Parameters.AddWithValue("@Game", this.Game);
        cmd.Parameters.AddWithValue("Medal", this.Medal);
        cmd.Parameters.AddWithValue("NATAScore", this.NATAScore);
        cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        cmd.Parameters.AddWithValue("@Fees", this.Fees);
        cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);
        cmd.Parameters.AddWithValue("@FatherOccupation", this.FatherOccupation);
        cmd.Parameters.AddWithValue("@MotherOccupation", this.MotherOccupation);
        cmd.Parameters.AddWithValue("@AadharNumber", this.AadharNumber);
        cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);


        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());

        cmd = new SqlCommand("spHSCMarksCreate", con);
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (HSCMarks _mark in this.HscMarks)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            cmd.Parameters.AddWithValue("@Board", _mark.Board);
            cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

            cmd.ExecuteNonQuery();
        }

        return rows;
    }
    
    public int CreateTest23()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterListCreateTest23", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@NameOfApplicant", this.NameOfApplicant);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
        cmd.Parameters.AddWithValue("@CandidateMobileNo", this.CandidateMobileNo);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@Gender", this.Gender);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@AddressForCommunication", this.AddressForCommunication);
        cmd.Parameters.AddWithValue("@Village", this.Village);
        cmd.Parameters.AddWithValue("@District", this.District);
        cmd.Parameters.AddWithValue("@City", this.City);
        cmd.Parameters.AddWithValue("@DifferentAblePerson", this.DifferentAblePerson);
        cmd.Parameters.AddWithValue("@PercentageOfDisability", this.PercentageOfDisability);
        cmd.Parameters.AddWithValue("@Country", this.Country);
        cmd.Parameters.AddWithValue("@state", this.State);
        cmd.Parameters.AddWithValue("@Pincode", this.Pincode);
        cmd.Parameters.AddWithValue("@ParentMobileNo", this.ParentMobileNo);
        cmd.Parameters.AddWithValue("@ParentTelephoneNo", this.ParentTelephoneNo);
        cmd.Parameters.AddWithValue("@PermanentAddress", this.PermanentAddress);
        cmd.Parameters.AddWithValue("@SslcSchoolName", this.SslcSchoolName);
        cmd.Parameters.AddWithValue("@SslcMediumOfInstruction", this.SslcMediumOfInstruction);
        cmd.Parameters.AddWithValue("@SslcYearOfPassing", this.SslcYearOfPassing);
        cmd.Parameters.AddWithValue("@SslcNoOFAttempt", this.SslcNoOFAttempt);
        cmd.Parameters.AddWithValue("@SslcRegistrationNo", this.SslcRegistrationNo);
        cmd.Parameters.AddWithValue("@SslcPercentage", this.SslcPercentage);
        cmd.Parameters.AddWithValue("@SslcBoardOfExamination", this.SslcBoardOFExamination);
        cmd.Parameters.AddWithValue("@HscSchoolName", this.HscSchoolName);
        cmd.Parameters.AddWithValue("@HscMediumOfInstruction", this.HscMediumOfInstruction);
        cmd.Parameters.AddWithValue("@HscNoOfAttempt", this.HscNoOfAttempt);
        cmd.Parameters.AddWithValue("@HscRegistrationNo", this.HscRegistrationNo);
        cmd.Parameters.AddWithValue("@HscYearOfPassing", this.HscYearOfPassing);
        cmd.Parameters.AddWithValue("@HscPercentage", this.HscPercentage);
        cmd.Parameters.AddWithValue("@HscBoardOfExamination", this.HscBoardOFExamination);
        cmd.Parameters.AddWithValue("@CollegeName", this.CollageName);
        cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);
        cmd.Parameters.AddWithValue("@Degree", this.Degree);
        cmd.Parameters.AddWithValue("@Percentage", this.Percentage);
        cmd.Parameters.AddWithValue("@BoardOfExamination", this.University);
        cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
        cmd.Parameters.AddWithValue("@CutOffMarks", this.CutOffMarks);
        cmd.Parameters.AddWithValue("@Eligibility", this.Eligibility);
        cmd.Parameters.AddWithValue("@ModeOfPayment", this.ModeOfPayment);
        cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);
        cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
        cmd.Parameters.AddWithValue("@Caste", this.Caste);
        cmd.Parameters.AddWithValue("@Religion", this.Religion);
        cmd.Parameters.AddWithValue("@Community", this.Community);
        cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
        cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
        cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
        cmd.Parameters.AddWithValue("@ParentsOccupation", string.Empty);
        cmd.Parameters.AddWithValue("@AnnualIncome", this.AnnualIncome);
        cmd.Parameters.AddWithValue("@MotherTongue", this.MotherTongue);
        cmd.Parameters.AddWithValue("@MaritalStatus", this.MaritalStatus);
        cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
        cmd.Parameters.AddWithValue("@AchivementInSports", this.AchivementInSports);
        cmd.Parameters.AddWithValue("@Level", this.Level);
        cmd.Parameters.AddWithValue("@Game", this.Game);
        cmd.Parameters.AddWithValue("Medal", this.Medal);
        cmd.Parameters.AddWithValue("NATAScore", this.NATAScore);
        cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        cmd.Parameters.AddWithValue("@Fees", this.Fees);
        cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);
        cmd.Parameters.AddWithValue("@FatherOccupation", this.FatherOccupation);
        cmd.Parameters.AddWithValue("@MotherOccupation", this.MotherOccupation);
        cmd.Parameters.AddWithValue("@AadharNumber", this.AadharNumber);
        cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);
        cmd.Parameters.AddWithValue("@TransportRequired", this.TransportRequired);


        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
        cmd = new SqlCommand("spHscMarkDetailsDelete23", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

        cmd.ExecuteNonQuery();
        cmd = new SqlCommand("spHSCMarksCreateTest23", con);
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (HSCMarks _mark in this.HscMarks)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            cmd.Parameters.AddWithValue("@Board", _mark.Board);
            cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

            cmd.ExecuteNonQuery();
        }

        return rows;
    }
    public int AddLeadApplnMasterList23()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMULead"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterListCreateTest23", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@NameOfApplicant", this.NameOfApplicant);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
        cmd.Parameters.AddWithValue("@CandidateMobileNo", this.CandidateMobileNo);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@Gender", this.Gender);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@AddressForCommunication", this.AddressForCommunication);
        cmd.Parameters.AddWithValue("@Village", this.Village);
        cmd.Parameters.AddWithValue("@District", this.District);
        cmd.Parameters.AddWithValue("@City", this.City);
        cmd.Parameters.AddWithValue("@DifferentAblePerson", this.DifferentAblePerson);
        cmd.Parameters.AddWithValue("@PercentageOfDisability", this.PercentageOfDisability);
        cmd.Parameters.AddWithValue("@Country", this.Country);
        cmd.Parameters.AddWithValue("@state", this.State);
        cmd.Parameters.AddWithValue("@Pincode", this.Pincode);
        cmd.Parameters.AddWithValue("@ParentMobileNo", this.ParentMobileNo);
        cmd.Parameters.AddWithValue("@ParentTelephoneNo", this.ParentTelephoneNo);
        cmd.Parameters.AddWithValue("@PermanentAddress", this.PermanentAddress);
        cmd.Parameters.AddWithValue("@SslcSchoolName", this.SslcSchoolName);
        cmd.Parameters.AddWithValue("@SslcMediumOfInstruction", this.SslcMediumOfInstruction);
        cmd.Parameters.AddWithValue("@SslcYearOfPassing", this.SslcYearOfPassing);
        cmd.Parameters.AddWithValue("@SslcNoOFAttempt", this.SslcNoOFAttempt);
        cmd.Parameters.AddWithValue("@SslcRegistrationNo", this.SslcRegistrationNo);
        cmd.Parameters.AddWithValue("@SslcPercentage", this.SslcPercentage);
        cmd.Parameters.AddWithValue("@SslcBoardOfExamination", this.SslcBoardOFExamination);
        cmd.Parameters.AddWithValue("@HscSchoolName", this.HscSchoolName);
        cmd.Parameters.AddWithValue("@HscMediumOfInstruction", this.HscMediumOfInstruction);
        cmd.Parameters.AddWithValue("@HscNoOfAttempt", this.HscNoOfAttempt);
        cmd.Parameters.AddWithValue("@HscRegistrationNo", this.HscRegistrationNo);
        cmd.Parameters.AddWithValue("@HscYearOfPassing", this.HscYearOfPassing);
        cmd.Parameters.AddWithValue("@HscPercentage", this.HscPercentage);
        cmd.Parameters.AddWithValue("@HscBoardOfExamination", this.HscBoardOFExamination);
        cmd.Parameters.AddWithValue("@CollegeName", this.CollageName);
        cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);
        cmd.Parameters.AddWithValue("@Degree", this.Degree);
        cmd.Parameters.AddWithValue("@Percentage", this.Percentage);
        cmd.Parameters.AddWithValue("@BoardOfExamination", this.University);
        cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
        cmd.Parameters.AddWithValue("@CutOffMarks", this.CutOffMarks);
        cmd.Parameters.AddWithValue("@Eligibility", this.Eligibility);
        cmd.Parameters.AddWithValue("@ModeOfPayment", this.ModeOfPayment);
        cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);
        cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
        cmd.Parameters.AddWithValue("@Caste", this.Caste);
        cmd.Parameters.AddWithValue("@Religion", this.Religion);
        cmd.Parameters.AddWithValue("@Community", this.Community);
        cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
        cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
        cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
        cmd.Parameters.AddWithValue("@ParentsOccupation", string.Empty);
        cmd.Parameters.AddWithValue("@AnnualIncome", this.AnnualIncome);
        cmd.Parameters.AddWithValue("@MotherTongue", this.MotherTongue);
        cmd.Parameters.AddWithValue("@MaritalStatus", this.MaritalStatus);
        cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
        cmd.Parameters.AddWithValue("@AchivementInSports", this.AchivementInSports);
        cmd.Parameters.AddWithValue("@Level", this.Level);
        cmd.Parameters.AddWithValue("@Game", this.Game);
        cmd.Parameters.AddWithValue("Medal", this.Medal);
        cmd.Parameters.AddWithValue("NATAScore", this.NATAScore);
        cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        cmd.Parameters.AddWithValue("@Fees", this.Fees);
        cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);
        cmd.Parameters.AddWithValue("@FatherOccupation", this.FatherOccupation);
        cmd.Parameters.AddWithValue("@MotherOccupation", this.MotherOccupation);
        cmd.Parameters.AddWithValue("@AadharNumber", this.AadharNumber);
        cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);
        cmd.Parameters.AddWithValue("@TransportRequired", this.TransportRequired);


        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
        cmd = new SqlCommand("spHscMarkDetailsDelete23", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

        cmd.ExecuteNonQuery();
        cmd = new SqlCommand("spHSCMarksCreateTest23", con);
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (HSCMarks _mark in this.HscMarks)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            cmd.Parameters.AddWithValue("@Board", _mark.Board);
            cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

            cmd.ExecuteNonQuery();
        }

        return rows;
    }
    public int CreateTest()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterListCreateTest", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@NameOfApplicant", this.NameOfApplicant);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
        cmd.Parameters.AddWithValue("@CandidateMobileNo", this.CandidateMobileNo);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@Gender", this.Gender);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@AddressForCommunication", this.AddressForCommunication);
        cmd.Parameters.AddWithValue("@Village", this.Village);
        cmd.Parameters.AddWithValue("@District", this.District);
        cmd.Parameters.AddWithValue("@City", this.City);
        cmd.Parameters.AddWithValue("@DifferentAblePerson", this.DifferentAblePerson);
        cmd.Parameters.AddWithValue("@PercentageOfDisability", this.PercentageOfDisability);
        cmd.Parameters.AddWithValue("@Country", this.Country);
        cmd.Parameters.AddWithValue("@state", this.State);
        cmd.Parameters.AddWithValue("@Pincode", this.Pincode);
        cmd.Parameters.AddWithValue("@ParentMobileNo", this.ParentMobileNo);
        cmd.Parameters.AddWithValue("@ParentTelephoneNo", this.ParentTelephoneNo);
        cmd.Parameters.AddWithValue("@PermanentAddress", this.PermanentAddress);
        cmd.Parameters.AddWithValue("@SslcSchoolName", this.SslcSchoolName);
        cmd.Parameters.AddWithValue("@SslcMediumOfInstruction", this.SslcMediumOfInstruction);
        cmd.Parameters.AddWithValue("@SslcYearOfPassing", this.SslcYearOfPassing);
        cmd.Parameters.AddWithValue("@SslcNoOFAttempt", this.SslcNoOFAttempt);
        cmd.Parameters.AddWithValue("@SslcRegistrationNo", this.SslcRegistrationNo);
        cmd.Parameters.AddWithValue("@SslcPercentage", this.SslcPercentage);
        cmd.Parameters.AddWithValue("@SslcBoardOfExamination", this.SslcBoardOFExamination);
        cmd.Parameters.AddWithValue("@HscSchoolName", this.HscSchoolName);
        cmd.Parameters.AddWithValue("@HscMediumOfInstruction", this.HscMediumOfInstruction);
        cmd.Parameters.AddWithValue("@HscNoOfAttempt", this.HscNoOfAttempt);
        cmd.Parameters.AddWithValue("@HscRegistrationNo", this.HscRegistrationNo);
        cmd.Parameters.AddWithValue("@HscYearOfPassing", this.HscYearOfPassing);
        cmd.Parameters.AddWithValue("@HscPercentage", this.HscPercentage);
        cmd.Parameters.AddWithValue("@HscBoardOfExamination", this.HscBoardOFExamination);
        cmd.Parameters.AddWithValue("@CollegeName", this.CollageName);
        cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);
        cmd.Parameters.AddWithValue("@Degree", this.Degree);
        cmd.Parameters.AddWithValue("@Percentage", this.Percentage);
        cmd.Parameters.AddWithValue("@BoardOfExamination", this.University);
        cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
        cmd.Parameters.AddWithValue("@CutOffMarks", this.CutOffMarks);
        cmd.Parameters.AddWithValue("@Eligibility", this.Eligibility);
        cmd.Parameters.AddWithValue("@ModeOfPayment", this.ModeOfPayment);
        cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);
        cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
        cmd.Parameters.AddWithValue("@Caste", this.Caste);
        cmd.Parameters.AddWithValue("@Religion", this.Religion);
        cmd.Parameters.AddWithValue("@Community", this.Community);
        cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
        cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
        cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
        cmd.Parameters.AddWithValue("@ParentsOccupation", string.Empty);
        cmd.Parameters.AddWithValue("@AnnualIncome", this.AnnualIncome);
        cmd.Parameters.AddWithValue("@MotherTongue", this.MotherTongue);
        cmd.Parameters.AddWithValue("@MaritalStatus", this.MaritalStatus);
        cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
        cmd.Parameters.AddWithValue("@AchivementInSports", this.AchivementInSports);
        cmd.Parameters.AddWithValue("@Level", this.Level);
        cmd.Parameters.AddWithValue("@Game", this.Game);
        cmd.Parameters.AddWithValue("Medal", this.Medal);
        cmd.Parameters.AddWithValue("NATAScore", this.NATAScore);
        cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        cmd.Parameters.AddWithValue("@Fees", this.Fees);
        cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);
        cmd.Parameters.AddWithValue("@FatherOccupation", this.FatherOccupation);
        cmd.Parameters.AddWithValue("@MotherOccupation", this.MotherOccupation);
        cmd.Parameters.AddWithValue("@AadharNumber", this.AadharNumber);
        cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);


        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
        cmd = new SqlCommand("spHscMarkDetailsDelete", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

        cmd.ExecuteNonQuery();
        cmd = new SqlCommand("spHSCMarksCreateTest", con);
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (HSCMarks _mark in this.HscMarks)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            cmd.Parameters.AddWithValue("@Board", _mark.Board);
            cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

            cmd.ExecuteNonQuery();
        }

        return rows;
    }
    public int Update()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterListUpdate1", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@NameOfApplicant", this.NameOfApplicant);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
        cmd.Parameters.AddWithValue("@CandidateMobileNo", this.CandidateMobileNo);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@Gender", this.Gender);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@AddressForCommunication", this.AddressForCommunication);
        cmd.Parameters.AddWithValue("@Village", this.Village);
        cmd.Parameters.AddWithValue("@District", this.District);
        cmd.Parameters.AddWithValue("@City", this.City);
        cmd.Parameters.AddWithValue("@DifferentAblePerson", this.DifferentAblePerson);
        cmd.Parameters.AddWithValue("@PercentageOfDisability", this.PercentageOfDisability);
        cmd.Parameters.AddWithValue("@Country", this.Country);
        cmd.Parameters.AddWithValue("@state", this.State);
        cmd.Parameters.AddWithValue("@Pincode", this.Pincode);
        cmd.Parameters.AddWithValue("@ParentMobileNo", this.ParentMobileNo);
        cmd.Parameters.AddWithValue("@ParentTelephoneNo", this.ParentTelephoneNo);
        cmd.Parameters.AddWithValue("@PermanentAddress", this.PermanentAddress);
        cmd.Parameters.AddWithValue("@SslcSchoolName", this.SslcSchoolName);
        cmd.Parameters.AddWithValue("@SslcMediumOfInstruction", this.SslcMediumOfInstruction);
        cmd.Parameters.AddWithValue("@SslcYearOfPassing", this.SslcYearOfPassing);
        cmd.Parameters.AddWithValue("@SslcNoOFAttempt", this.SslcNoOFAttempt);
        cmd.Parameters.AddWithValue("@SslcRegistrationNo", this.SslcRegistrationNo);
        cmd.Parameters.AddWithValue("@SslcPercentage", this.SslcPercentage);
        cmd.Parameters.AddWithValue("@SslcBoardOfExamination", this.SslcBoardOFExamination);
        cmd.Parameters.AddWithValue("@HscSchoolName", this.HscSchoolName);
        cmd.Parameters.AddWithValue("@HscMediumOfInstruction", this.HscMediumOfInstruction);
        cmd.Parameters.AddWithValue("@HscNoOfAttempt", this.HscNoOfAttempt);
        cmd.Parameters.AddWithValue("@HscRegistrationNo", this.HscRegistrationNo);
        cmd.Parameters.AddWithValue("@HscYearOfPassing", this.HscYearOfPassing);
        cmd.Parameters.AddWithValue("@HscPercentage", this.HscPercentage);
        cmd.Parameters.AddWithValue("@HscBoardOfExamination", this.HscBoardOFExamination);
        cmd.Parameters.AddWithValue("@CollegeName", this.CollageName);
        cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);
        cmd.Parameters.AddWithValue("@Degree", this.Degree);
        cmd.Parameters.AddWithValue("@Percentage", this.Percentage);
        cmd.Parameters.AddWithValue("@BoardOfExamination", this.University);
        cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
        cmd.Parameters.AddWithValue("@CutOffMarks", this.CutOffMarks);
        cmd.Parameters.AddWithValue("@Eligibility", this.Eligibility);
        cmd.Parameters.AddWithValue("@ModeOfPayment", this.ModeOfPayment);
        cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);
        cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
        cmd.Parameters.AddWithValue("@Caste", this.Caste);
        cmd.Parameters.AddWithValue("@Religion", this.Religion);
        cmd.Parameters.AddWithValue("@Community", this.Community);
        cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
        cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
        cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
        cmd.Parameters.AddWithValue("@ParentsOccupation", string.Empty);
        cmd.Parameters.AddWithValue("@AnnualIncome", this.AnnualIncome);
        cmd.Parameters.AddWithValue("@MotherTongue", this.MotherTongue);
        cmd.Parameters.AddWithValue("@MaritalStatus", this.MaritalStatus);
        cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
        cmd.Parameters.AddWithValue("@AchivementInSports", this.AchivementInSports);
        cmd.Parameters.AddWithValue("@Level", this.Level);
        cmd.Parameters.AddWithValue("@Game", this.Game);
        cmd.Parameters.AddWithValue("Medal", this.Medal);
        cmd.Parameters.AddWithValue("NATAScore", this.NATAScore);
        cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        cmd.Parameters.AddWithValue("@Fees", this.Fees);
        cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);
        cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);
        cmd.Parameters.AddWithValue("@FatherOccupation", this.FatherOccupation);
        cmd.Parameters.AddWithValue("@MotherOccupation", this.MotherOccupation);
        cmd.Parameters.AddWithValue("@AadharNumber", this.AadharNumber);
        cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);


        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());

        cmd = new SqlCommand("spHscMarkDetailsDelete", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

        cmd.ExecuteNonQuery();

        cmd = new SqlCommand("spHSCMarksCreate", con);
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (HSCMarks _mark in this.HscMarks)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            cmd.Parameters.AddWithValue("@Board", _mark.Board);
            cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

            cmd.ExecuteNonQuery();
        }


        return rows;
    }

    public int UpdateNew()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterListUpdatenEW", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;	
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);        
        cmd.Parameters.AddWithValue("@Gender", this.Gender);       
        cmd.Parameters.AddWithValue("@AddressForCommunication", this.AddressForCommunication);
        cmd.Parameters.AddWithValue("@Village", this.Village);
        cmd.Parameters.AddWithValue("@District", this.District);
        cmd.Parameters.AddWithValue("@City", this.City);
        cmd.Parameters.AddWithValue("@DifferentAblePerson", this.DifferentAblePerson);
        cmd.Parameters.AddWithValue("@PercentageOfDisability", this.PercentageOfDisability);
        cmd.Parameters.AddWithValue("@Country", this.Country);
        cmd.Parameters.AddWithValue("@state", this.State);
        cmd.Parameters.AddWithValue("@Pincode", this.Pincode);
        cmd.Parameters.AddWithValue("@ParentMobileNo", this.ParentMobileNo);
        cmd.Parameters.AddWithValue("@ParentTelephoneNo", this.ParentTelephoneNo);
        cmd.Parameters.AddWithValue("@PermanentAddress", this.PermanentAddress);
        cmd.Parameters.AddWithValue("@SslcSchoolName", this.SslcSchoolName);
        cmd.Parameters.AddWithValue("@SslcMediumOfInstruction", this.SslcMediumOfInstruction);
        cmd.Parameters.AddWithValue("@SslcYearOfPassing", this.SslcYearOfPassing);
        cmd.Parameters.AddWithValue("@SslcNoOFAttempt", this.SslcNoOFAttempt);
        cmd.Parameters.AddWithValue("@SslcRegistrationNo", this.SslcRegistrationNo);
        cmd.Parameters.AddWithValue("@SslcPercentage", this.SslcPercentage);
        cmd.Parameters.AddWithValue("@SslcBoardOfExamination", this.SslcBoardOFExamination);
        cmd.Parameters.AddWithValue("@HscSchoolName", this.HscSchoolName);
        cmd.Parameters.AddWithValue("@HscMediumOfInstruction", this.HscMediumOfInstruction);
        cmd.Parameters.AddWithValue("@HscNoOfAttempt", this.HscNoOfAttempt);
        cmd.Parameters.AddWithValue("@HscRegistrationNo", this.HscRegistrationNo);
        cmd.Parameters.AddWithValue("@HscYearOfPassing", this.HscYearOfPassing);
        cmd.Parameters.AddWithValue("@HscPercentage", this.HscPercentage);
        cmd.Parameters.AddWithValue("@HscBoardOfExamination", this.HscBoardOFExamination);
        cmd.Parameters.AddWithValue("@CollegeName", this.CollageName);
        cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);
        cmd.Parameters.AddWithValue("@Degree", this.Degree);
        cmd.Parameters.AddWithValue("@Percentage", this.Percentage);
        cmd.Parameters.AddWithValue("@BoardOfExamination", this.University);
        cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
        cmd.Parameters.AddWithValue("@CutOffMarks", this.CutOffMarks);
        cmd.Parameters.AddWithValue("@Eligibility", this.Eligibility);       
        cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);
        cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
        cmd.Parameters.AddWithValue("@Caste", this.Caste);
        cmd.Parameters.AddWithValue("@Religion", this.Religion);
        cmd.Parameters.AddWithValue("@Community", this.Community);
        cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
        cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
        cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
        cmd.Parameters.AddWithValue("@ParentsOccupation", string.Empty);
        cmd.Parameters.AddWithValue("@AnnualIncome", this.AnnualIncome);
        cmd.Parameters.AddWithValue("@MotherTongue", this.MotherTongue);
        cmd.Parameters.AddWithValue("@MaritalStatus", this.MaritalStatus);
        cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
        cmd.Parameters.AddWithValue("@AchivementInSports", this.AchivementInSports);
        cmd.Parameters.AddWithValue("@Level", this.Level);
        cmd.Parameters.AddWithValue("@Game", this.Game);
        cmd.Parameters.AddWithValue("Medal", this.Medal);
        cmd.Parameters.AddWithValue("NATAScore", this.NATAScore);
        cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);       
        cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);             
        cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);


        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());

        cmd = new SqlCommand("spHscMarkDetailsDelete", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

        cmd.ExecuteNonQuery();

        cmd = new SqlCommand("spHSCMarksCreate", con);
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (HSCMarks _mark in this.HscMarks)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            cmd.Parameters.AddWithValue("@Board", _mark.Board);
            cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

            cmd.ExecuteNonQuery();
        }


        return rows;
    }

    public int UpdateNew23()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterListUpdatenEW23", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;	
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);        
        cmd.Parameters.AddWithValue("@Gender", this.Gender);       
        cmd.Parameters.AddWithValue("@AddressForCommunication", this.AddressForCommunication);
        cmd.Parameters.AddWithValue("@Village", this.Village);
        cmd.Parameters.AddWithValue("@District", this.District);
        cmd.Parameters.AddWithValue("@City", this.City);
        cmd.Parameters.AddWithValue("@DifferentAblePerson", this.DifferentAblePerson);
        cmd.Parameters.AddWithValue("@PercentageOfDisability", this.PercentageOfDisability);
        cmd.Parameters.AddWithValue("@Country", this.Country);
        cmd.Parameters.AddWithValue("@state", this.State);
        cmd.Parameters.AddWithValue("@Pincode", this.Pincode);
        cmd.Parameters.AddWithValue("@ParentMobileNo", this.ParentMobileNo);
        cmd.Parameters.AddWithValue("@ParentTelephoneNo", this.ParentTelephoneNo);
        cmd.Parameters.AddWithValue("@PermanentAddress", this.PermanentAddress);
        cmd.Parameters.AddWithValue("@SslcSchoolName", this.SslcSchoolName);
        cmd.Parameters.AddWithValue("@SslcMediumOfInstruction", this.SslcMediumOfInstruction);
        cmd.Parameters.AddWithValue("@SslcYearOfPassing", this.SslcYearOfPassing);
        cmd.Parameters.AddWithValue("@SslcNoOFAttempt", this.SslcNoOFAttempt);
        cmd.Parameters.AddWithValue("@SslcRegistrationNo", this.SslcRegistrationNo);
        cmd.Parameters.AddWithValue("@SslcPercentage", this.SslcPercentage);
        cmd.Parameters.AddWithValue("@SslcBoardOfExamination", this.SslcBoardOFExamination);
        cmd.Parameters.AddWithValue("@HscSchoolName", this.HscSchoolName);
        cmd.Parameters.AddWithValue("@HscMediumOfInstruction", this.HscMediumOfInstruction);
        cmd.Parameters.AddWithValue("@HscNoOfAttempt", this.HscNoOfAttempt);
        cmd.Parameters.AddWithValue("@HscRegistrationNo", this.HscRegistrationNo);
        cmd.Parameters.AddWithValue("@HscYearOfPassing", this.HscYearOfPassing);
        cmd.Parameters.AddWithValue("@HscPercentage", this.HscPercentage);
        cmd.Parameters.AddWithValue("@HscBoardOfExamination", this.HscBoardOFExamination);
        cmd.Parameters.AddWithValue("@CollegeName", this.CollageName);
        cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);
        cmd.Parameters.AddWithValue("@Degree", this.Degree);
        cmd.Parameters.AddWithValue("@Percentage", this.Percentage);
        cmd.Parameters.AddWithValue("@BoardOfExamination", this.University);
        cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
        cmd.Parameters.AddWithValue("@CutOffMarks", this.CutOffMarks);
        cmd.Parameters.AddWithValue("@Eligibility", this.Eligibility);       
        cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);
        cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
        cmd.Parameters.AddWithValue("@Caste", this.Caste);
        cmd.Parameters.AddWithValue("@Religion", this.Religion);
        cmd.Parameters.AddWithValue("@Community", this.Community);
        cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
        cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
        cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
        cmd.Parameters.AddWithValue("@ParentsOccupation", string.Empty);
        cmd.Parameters.AddWithValue("@AnnualIncome", this.AnnualIncome);
        cmd.Parameters.AddWithValue("@MotherTongue", this.MotherTongue);
        cmd.Parameters.AddWithValue("@MaritalStatus", this.MaritalStatus);
        cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
        cmd.Parameters.AddWithValue("@AchivementInSports", this.AchivementInSports);
        cmd.Parameters.AddWithValue("@Level", this.Level);
        cmd.Parameters.AddWithValue("@Game", this.Game);
        cmd.Parameters.AddWithValue("Medal", this.Medal);
        cmd.Parameters.AddWithValue("NATAScore", this.NATAScore);
        cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);       
        cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);             
        cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);
        cmd.Parameters.AddWithValue("@TransportRequired", this.TransportRequired);

        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());

        cmd = new SqlCommand("spHscMarkDetailsDelete23", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

        cmd.ExecuteNonQuery();

        cmd = new SqlCommand("spHSCMarksCreate23", con);
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (HSCMarks _mark in this.HscMarks)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            cmd.Parameters.AddWithValue("@Board", _mark.Board);
            cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

            cmd.ExecuteNonQuery();
        }


        return rows;
    }
    public int InsertError(string method,string message,DateTime dt,string stApplicationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("AddError", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ErrorMessage", message);
        cmd.Parameters.AddWithValue("@Method", method);
        cmd.Parameters.AddWithValue("@ErrorDate", dt);
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
        return rows;
    }
    public int HscCreate()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spHSCMarksCreate", con);
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (HSCMarks _mark in this.HscMarks)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            cmd.Parameters.AddWithValue("@Board", _mark.Board);
            cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);


        }

        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
        return rows;
    }

    public int CreateForm()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterCreate", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        CultureInfo provider = CultureInfo.InvariantCulture;
        System.Globalization.DateTimeStyles style = DateTimeStyles.None;


        cmd.Parameters.AddWithValue("@Name", this.NameOfApplicant);
        cmd.Parameters.AddWithValue("@MobileNo", this.CandidateMobileNo);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
        cmd.Parameters.AddWithValue("@Course", this.Course);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@Choice", this.Choice);
        cmd.Parameters.AddWithValue("@ChoiceTwo", this.ChoiceTwo);
        cmd.Parameters.AddWithValue("@ChoiceThree", this.ChoiceThree);
        cmd.Parameters.AddWithValue("@CourseType", this.CourseType);
        cmd.Parameters.AddWithValue("@AppliedFrom", this.AppliedFrom);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        int createForm = int.Parse(cmd.ExecuteNonQuery().ToString());



        return createForm;
    }


    public string CreateForm23()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterCreate23", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        CultureInfo provider = CultureInfo.InvariantCulture;
        System.Globalization.DateTimeStyles style = DateTimeStyles.None;


        cmd.Parameters.AddWithValue("@Name", this.NameOfApplicant);
        cmd.Parameters.AddWithValue("@MobileNo", this.CandidateMobileNo);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
        cmd.Parameters.AddWithValue("@Course", this.Course);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        //cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@Choice", this.Choice);
        cmd.Parameters.AddWithValue("@ChoiceTwo", this.ChoiceTwo);
        cmd.Parameters.AddWithValue("@ChoiceThree", this.ChoiceThree);
        cmd.Parameters.AddWithValue("@CourseType", this.CourseType);
        cmd.Parameters.AddWithValue("@AppliedFrom", this.AppliedFrom);
        cmd.Parameters.AddWithValue("@Scholarship", this.Scholarship);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        cmd.Parameters.AddWithValue("@FacultySchool", this.FacultySchool);
       

        cmd.Parameters.Add("@ID", SqlDbType.Int);
        cmd.Parameters["@ID"].Direction = ParameterDirection.Output;
        int createForm = int.Parse(cmd.ExecuteNonQuery().ToString());

        int ID = Convert.ToInt32(cmd.Parameters["@ID"].Value);

        string ApplnNo = GenerateApplicationNo(this.CourseType, this.TextApplicationFor, ID);
        UpdateApplicationNo23(ApplnNo, ID);

        return ApplnNo;
    }

    public string CreateForm24()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterCreate24", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        CultureInfo provider = CultureInfo.InvariantCulture;
        System.Globalization.DateTimeStyles style = DateTimeStyles.None;


        cmd.Parameters.AddWithValue("@Name", this.NameOfApplicant);
        cmd.Parameters.AddWithValue("@MobileNo", this.CandidateMobileNo);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
        cmd.Parameters.AddWithValue("@Course", this.Course);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        //cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@Choice", this.Choice);
        cmd.Parameters.AddWithValue("@HSCRegNo", this.HscRegistrationNo);
        cmd.Parameters.AddWithValue("@ChoiceTwo", this.ChoiceTwo);
        cmd.Parameters.AddWithValue("@ChoiceThree", this.ChoiceThree);
        cmd.Parameters.AddWithValue("@CourseType", this.CourseType);
        cmd.Parameters.AddWithValue("@AppliedFrom", this.AppliedFrom);
        cmd.Parameters.AddWithValue("@Scholarship", this.Scholarship);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        cmd.Parameters.AddWithValue("@FacultySchool", this.FacultySchool);
       

        cmd.Parameters.Add("@ID", SqlDbType.Int);
        cmd.Parameters["@ID"].Direction = ParameterDirection.Output;
        int createForm = int.Parse(cmd.ExecuteNonQuery().ToString());

        int ID = Convert.ToInt32(cmd.Parameters["@ID"].Value);

        string ApplnNo = GenerateApplicationNo(this.CourseType, this.TextApplicationFor, ID);
        UpdateApplicationNo23(ApplnNo, ID);

        return ApplnNo;
    }

    public int CreateForm_Admission()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spApplicationMasterCreate_Admission", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        CultureInfo provider = CultureInfo.InvariantCulture;
        System.Globalization.DateTimeStyles style = DateTimeStyles.None;


        cmd.Parameters.AddWithValue("@Name", this.NameOfApplicant);
        cmd.Parameters.AddWithValue("@MobileNo", this.CandidateMobileNo);
        cmd.Parameters.AddWithValue("@WhatsAppNo", this.CandidateWhatsAppNo);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
        cmd.Parameters.AddWithValue("@Course", this.Course);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@Choice", this.Choice);
        cmd.Parameters.AddWithValue("@ChoiceTwo", this.ChoiceTwo);
        cmd.Parameters.AddWithValue("@ChoiceThree", this.ChoiceThree);
        cmd.Parameters.AddWithValue("@CourseType", this.CourseType);
        cmd.Parameters.AddWithValue("@AppliedFrom", this.AppliedFrom);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        int createForm = int.Parse(cmd.ExecuteNonQuery().ToString());



        return createForm;
    }
    public int CreateCampaignForm(string stLocation)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("AddApplicationMasterCampaign", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        CultureInfo provider = CultureInfo.InvariantCulture;
        System.Globalization.DateTimeStyles style = DateTimeStyles.None;


        cmd.Parameters.AddWithValue("@Name", this.NameOfApplicant);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@MobileNo", this.CandidateMobileNo);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
        cmd.Parameters.AddWithValue("@Course", this.Course);
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@Choice", this.Choice);        
        cmd.Parameters.AddWithValue("@CourseType", this.CourseType);
        cmd.Parameters.AddWithValue("@AppliedFrom", this.AppliedFrom);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        cmd.Parameters.AddWithValue("@Location", stLocation);
        int createForm = int.Parse(cmd.ExecuteNonQuery().ToString());



        return createForm;
    }

    public int InsertMarks()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spGetSubjectDetails", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        CultureInfo provider = CultureInfo.InvariantCulture;
        System.Globalization.DateTimeStyles style = DateTimeStyles.None;


        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@SubjectName", this.SubjectName);
        cmd.Parameters.AddWithValue("@SubjectMark", this.SubjectMark);
        cmd.Parameters.AddWithValue("@Board", this.Board);
        cmd.Parameters.AddWithValue("RegistrationNo", this.RegistrationNo);


        int createForm = int.Parse(cmd.ExecuteNonQuery().ToString());

        return createForm;
    }

    public int InsertBillNo()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spInsertBillNo", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@NameOftheApplicant", this.NameOftheApplicant);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@PaymentMode", this.ModeOfPayment);
        cmd.Parameters.AddWithValue("@BillNo", this.BillNo);
        cmd.Parameters.AddWithValue("@BillDate", this.BillDate);

        int InsertBillNo = int.Parse(cmd.ExecuteNonQuery().ToString());



        return InsertBillNo;

    }
    public int InsertBillNo2023()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spInsertBillNo2023", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@Fees", this.Fees);
        cmd.Parameters.AddWithValue("@TransactionStatus", "Success");
     
        cmd.Parameters.AddWithValue("@PaymentMode", this.ModeOfPayment);
        cmd.Parameters.AddWithValue("@BillNo", this.BillNo);
        cmd.Parameters.AddWithValue("@BillDate", this.BillDate);

        int InsertBillNo2023 = int.Parse(cmd.ExecuteNonQuery().ToString());



        return InsertBillNo2023;

    }

    public int UpdateBillNo()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spUpdateBillNo", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@NameOftheApplicant", this.NameOftheApplicant);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@PaymentMode", this.ModeOfPayment);
        cmd.Parameters.AddWithValue("@BillNo", this.BillNo);
        cmd.Parameters.AddWithValue("@BillDate", this.BillDate);

        int UpdateBillNo = int.Parse(cmd.ExecuteNonQuery().ToString());

        return UpdateBillNo;

    }

    public int UpdateBillNo2023()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spUpdateBillNo2023", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@Fees", this.Fees);
        cmd.Parameters.AddWithValue("@TransactionStatus", "Success");
        cmd.Parameters.AddWithValue("@PaymentMode", "Cash");
        cmd.Parameters.AddWithValue("@BillNo", this.BillNo);
        cmd.Parameters.AddWithValue("@BillDate", this.BillDate);

        int UpdateBillNo2023 = int.Parse(cmd.ExecuteNonQuery().ToString());

        return UpdateBillNo2023;

    }


    public ApplicationForm GetBillDetails(string ApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spBillDetailView", con);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {

            _form.ApplicationNo = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.NameOftheApplicant = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _form.ApplicationFor = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.ModeOfPayment = dr.IsDBNull(4) ? "" : dr.GetString(4);
            _form.BillNo = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.BillDate = dr.IsDBNull(6) ? new DateTime() : dr.GetDateTime(6);


        }
        return _form;

    }

    public ApplicationForm GetDetails(string ApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spGetDetailsByApplicationNo", con);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {

            _form.NameOfApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.DateOfBirth = dr.IsDBNull(2) ? new DateTime() : dr.GetDateTime(2);
            _form.CandidateMobileNo = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.EmailID = dr.IsDBNull(4) ? "" : dr.GetString(4);
            _form.Course = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.ApplicationNo = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.ApplicationFor = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.Choice = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.ChoiceTwo = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.ChoiceThree = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.CourseType = dr.IsDBNull(11) ? "" : dr.GetString(11);

        }
        return _form;

    }

    public ApplicationForm GetDetails23(string ApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spGetDetailsByApplicationNo23", con);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {

            _form.NameOfApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.DateOfBirth = dr.IsDBNull(2) ? new DateTime() : dr.GetDateTime(2);
            _form.CandidateMobileNo = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.EmailID = dr.IsDBNull(4) ? "" : dr.GetString(4);
            _form.Course = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.ApplicationNo = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.ApplicationFor = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.Choice = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.ChoiceTwo = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.ChoiceThree = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.CourseType = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _form.ApplnForID = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _form.Scholarship = dr.IsDBNull(13) ? "" : dr.GetString(13);

        }
        return _form;

    }

    public ApplicationForm GetList(string ApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintDetails", con);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _form.ApplicationNo = dr.IsDBNull(0) ? "" : dr.GetString(0);
            _form.NameOfApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.CandidateMobileNo = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _form.EmailID = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.DateOfBirth = dr.IsDBNull(4) ? new DateTime() : dr.GetDateTime(4);
            _form.Gender = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.ApplicationFor = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.AddressForCommunication = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.Village = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.District = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.City = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.DifferentAblePerson = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _form.PercentageOfDisability = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _form.State = dr.IsDBNull(13) ? "" : dr.GetString(13);
            _form.Country = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _form.Pincode = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _form.ParentMobileNo = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _form.ParentTelephoneNo = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _form.PermanentAddress = dr.IsDBNull(18) ? "" : dr.GetString(18);
            _form.SslcSchoolName = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _form.SslcMediumOfInstruction = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _form.SslcYearOfPassing = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _form.SslcNoOFAttempt = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _form.SslcRegistrationNo = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _form.SslcPercentage = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _form.SslcBoardOFExamination = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _form.HscSchoolName = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _form.HscMediumOfInstruction = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _form.HscNoOfAttempt = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _form.HscRegistrationNo = dr.IsDBNull(29) ? "" : dr.GetString(29);
            _form.HscYearOfPassing = dr.IsDBNull(30) ? "" : dr.GetString(30);
            _form.HscPercentage = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _form.HscBoardOFExamination = dr.IsDBNull(32) ? "" : dr.GetString(32);
            _form.CollageName = dr.IsDBNull(33) ? "" : dr.GetString(33);
            _form.YearOfPassing = dr.IsDBNull(34) ? "" : dr.GetString(34);
            _form.Degree = dr.IsDBNull(35) ? "" : dr.GetString(35);
            _form.Percentage = dr.IsDBNull(36) ? "" : dr.GetString(36);
            _form.University = dr.IsDBNull(37) ? "" : dr.GetString(37);
            _form.RegistrationNo = dr.IsDBNull(38) ? "" : dr.GetString(38);
            _form.CutOffMarks = dr.IsDBNull(39) ? "" : dr.GetString(39);
            _form.Eligibility = dr.IsDBNull(40) ? "" : dr.GetString(40);
            _form.ModeOfPayment = dr.IsDBNull(41) ? "" : dr.GetString(41);
            _form.TelephoneNo = dr.IsDBNull(42) ? "" : dr.GetString(42);
            _form.BloodGroup = dr.IsDBNull(43) ? "" : dr.GetString(43);
            _form.Caste = dr.IsDBNull(44) ? "" : dr.GetString(44);
            _form.Religion = dr.IsDBNull(45) ? "" : dr.GetString(45);
            _form.Community = dr.IsDBNull(46) ? "" : dr.GetString(46);
            _form.Nationality = dr.IsDBNull(47) ? "" : dr.GetString(47);
            _form.FatherName = dr.IsDBNull(48) ? "" : dr.GetString(48);
            _form.MotherName = dr.IsDBNull(49) ? "" : dr.GetString(49);
            _form.ParentsOccupation = dr.IsDBNull(50) ? "" : dr.GetString(50);
            _form.AnnualIncome = dr.IsDBNull(51) ? "" : dr.GetString(51);
            _form.MotherTongue = dr.IsDBNull(52) ? "" : dr.GetString(52);
            _form.MaritalStatus = dr.IsDBNull(53) ? "" : dr.GetString(53);
            _form.HostelRequired = dr.IsDBNull(54) ? "" : dr.GetString(54);
            _form.AchivementInSports = dr.IsDBNull(55) ? "" : dr.GetString(55);
            _form.Level = dr.IsDBNull(56) ? "" : dr.GetString(56);
            _form.Game = dr.IsDBNull(57) ? "" : dr.GetString(57);
            _form.Medal = dr.IsDBNull(58) ? "" : dr.GetString(58);
            _form.NATAScore = dr.IsDBNull(59) ? "" : dr.GetString(59);
            _form.UniGaugeScore = dr.IsDBNull(60) ? "" : dr.GetString(60);
            _form.PostedDate = dr.IsDBNull(61) ? new DateTime() : dr.GetDateTime(61);
            _form.Fees = dr.IsDBNull(62) ? "" : dr.GetString(62);
            _form.Choice = dr.IsDBNull(63) ? "" : dr.GetString(63);
            _form.ChoiceTwo = dr.IsDBNull(64) ? "" : dr.GetString(64);
            _form.ChoiceThree = dr.IsDBNull(65) ? "" : dr.GetString(65);

            _form.BillNo = dr.IsDBNull(66) ? "" : dr.GetString(66);
            _form.BillDate = dr.IsDBNull(67) ? new DateTime() : dr.GetDateTime(67);

        }
        return _form;

    }

    public ApplicationForm PrintDetails(string ApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintDetails", con);
        cmd.CommandType =CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
      
      
        SqlDataReader dr = cmd.ExecuteReader();
        

        if (dr.Read())
        {
            _form.ApplicationNo = dr.IsDBNull(0) ? "" : dr.GetString(0);
            _form.NameOfApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.CandidateMobileNo = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _form.EmailID = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.DateOfBirth = dr.IsDBNull(4) ? new DateTime() : dr.GetDateTime(4);
            _form.Gender = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.ApplicationFor = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.AddressForCommunication = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.Village = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.District = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.City = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.DifferentAblePerson = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _form.PercentageOfDisability = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _form.State = dr.IsDBNull(13) ? "" : dr.GetString(13);
            _form.Country = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _form.Pincode = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _form.ParentMobileNo = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _form.ParentTelephoneNo = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _form.PermanentAddress = dr.IsDBNull(18) ? "" : dr.GetString(18);
            _form.SslcSchoolName = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _form.SslcMediumOfInstruction = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _form.SslcYearOfPassing = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _form.SslcNoOFAttempt = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _form.SslcRegistrationNo = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _form.SslcPercentage = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _form.SslcBoardOFExamination = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _form.HscSchoolName = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _form.HscMediumOfInstruction = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _form.HscNoOfAttempt = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _form.HscRegistrationNo = dr.IsDBNull(29) ? "" : dr.GetString(29);
            _form.HscYearOfPassing = dr.IsDBNull(30) ? "" : dr.GetString(30);
            _form.HscPercentage = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _form.HscBoardOFExamination = dr.IsDBNull(32) ? "" : dr.GetString(32);
            _form.CollageName = dr.IsDBNull(33) ? "" : dr.GetString(33);
            _form.YearOfPassing = dr.IsDBNull(34) ? "" : dr.GetString(34);
            _form.Degree = dr.IsDBNull(35) ? "" : dr.GetString(35);
            _form.Percentage = dr.IsDBNull(36) ? "" : dr.GetString(36);
            _form.University = dr.IsDBNull(37) ? "" : dr.GetString(37);
            _form.RegistrationNo = dr.IsDBNull(38) ? "" : dr.GetString(38);
            _form.CutOffMarks = dr.IsDBNull(39) ? "" : dr.GetString(39);
            _form.Eligibility = dr.IsDBNull(40) ? "" : dr.GetString(40);
            _form.ModeOfPayment = dr.IsDBNull(41) ? "" : dr.GetString(41);
            _form.TelephoneNo = dr.IsDBNull(42) ? "" : dr.GetString(42);
            _form.BloodGroup = dr.IsDBNull(43) ? "" : dr.GetString(43);
            _form.Caste = dr.IsDBNull(44) ? "" : dr.GetString(44);
            _form.Religion = dr.IsDBNull(45) ? "" : dr.GetString(45);
            _form.Community = dr.IsDBNull(46) ? "" : dr.GetString(46);
            _form.Nationality = dr.IsDBNull(47) ? "" : dr.GetString(47);
            _form.FatherName = dr.IsDBNull(48) ? "" : dr.GetString(48);
            _form.MotherName = dr.IsDBNull(49) ? "" : dr.GetString(49);
            _form.ParentsOccupation = dr.IsDBNull(50) ? "" : dr.GetString(50);
            _form.AnnualIncome = dr.IsDBNull(51) ? "" : dr.GetString(51);
            _form.MotherTongue = dr.IsDBNull(52) ? "" : dr.GetString(52);
            _form.MaritalStatus = dr.IsDBNull(53) ? "" : dr.GetString(53);
            _form.HostelRequired = dr.IsDBNull(54) ? "" : dr.GetString(54);
            _form.AchivementInSports = dr.IsDBNull(55) ? "" : dr.GetString(55);
            _form.Level = dr.IsDBNull(56) ? "" : dr.GetString(56);
            _form.Game = dr.IsDBNull(57) ? "" : dr.GetString(57);
            _form.Medal = dr.IsDBNull(58) ? "" : dr.GetString(58);
            _form.NATAScore = dr.IsDBNull(59) ? "" : dr.GetString(59);
            _form.UniGaugeScore = dr.IsDBNull(60) ? "" : dr.GetString(60);
            _form.PostedDate = dr.IsDBNull(61) ? new DateTime() : dr.GetDateTime(61);
            _form.Fees = dr.IsDBNull(62) ? "" : dr.GetString(62);
            _form.Choice = dr.IsDBNull(63) ? "" : dr.GetString(63);
            _form.ChoiceTwo = dr.IsDBNull(64) ? "" : dr.GetString(64);
            _form.ChoiceThree = dr.IsDBNull(65) ? "" : dr.GetString(65);

            _form.BillNo = dr.IsDBNull(66) ? "" : dr.GetString(66);
            _form.BillDate = dr.IsDBNull(67) ? new DateTime() : dr.GetDateTime(67);


        }
        return _form;

    }
    public ApplicationForm PrintDetails2020(string ApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintDetails2020", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _form.ApplicationNo = dr.IsDBNull(0) ? "" : dr.GetString(0);
            _form.NameOfApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.CandidateMobileNo = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _form.EmailID = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.DateOfBirth = dr.IsDBNull(4) ? new DateTime() : dr.GetDateTime(4);
            _form.Gender = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.ApplicationFor = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.AddressForCommunication = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.Village = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.District = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.City = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.DifferentAblePerson = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _form.PercentageOfDisability = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _form.State = dr.IsDBNull(13) ? "" : dr.GetString(13);
            _form.Country = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _form.Pincode = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _form.ParentMobileNo = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _form.ParentTelephoneNo = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _form.PermanentAddress = dr.IsDBNull(18) ? "" : dr.GetString(18);
            _form.SslcSchoolName = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _form.SslcMediumOfInstruction = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _form.SslcYearOfPassing = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _form.SslcNoOFAttempt = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _form.SslcRegistrationNo = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _form.SslcPercentage = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _form.SslcBoardOFExamination = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _form.HscSchoolName = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _form.HscMediumOfInstruction = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _form.HscNoOfAttempt = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _form.HscRegistrationNo = dr.IsDBNull(29) ? "" : dr.GetString(29);
            _form.HscYearOfPassing = dr.IsDBNull(30) ? "" : dr.GetString(30);
            _form.HscPercentage = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _form.HscBoardOFExamination = dr.IsDBNull(32) ? "" : dr.GetString(32);
            _form.CollageName = dr.IsDBNull(33) ? "" : dr.GetString(33);
            _form.YearOfPassing = dr.IsDBNull(34) ? "" : dr.GetString(34);
            _form.Degree = dr.IsDBNull(35) ? "" : dr.GetString(35);
            _form.Percentage = dr.IsDBNull(36) ? "" : dr.GetString(36);
            _form.University = dr.IsDBNull(37) ? "" : dr.GetString(37);
            _form.RegistrationNo = dr.IsDBNull(38) ? "" : dr.GetString(38);
            _form.CutOffMarks = dr.IsDBNull(39) ? "" : dr.GetString(39);
            _form.Eligibility = dr.IsDBNull(40) ? "" : dr.GetString(40);
            _form.ModeOfPayment = dr.IsDBNull(41) ? "" : dr.GetString(41);
            _form.TelephoneNo = dr.IsDBNull(42) ? "" : dr.GetString(42);
            _form.BloodGroup = dr.IsDBNull(43) ? "" : dr.GetString(43);
            _form.Caste = dr.IsDBNull(44) ? "" : dr.GetString(44);
            _form.Religion = dr.IsDBNull(45) ? "" : dr.GetString(45);
            _form.Community = dr.IsDBNull(46) ? "" : dr.GetString(46);
            _form.Nationality = dr.IsDBNull(47) ? "" : dr.GetString(47);
            _form.FatherName = dr.IsDBNull(48) ? "" : dr.GetString(48);
            _form.MotherName = dr.IsDBNull(49) ? "" : dr.GetString(49);
            _form.ParentsOccupation = dr.IsDBNull(50) ? "" : dr.GetString(50);
            _form.AnnualIncome = dr.IsDBNull(51) ? "" : dr.GetString(51);
            _form.MotherTongue = dr.IsDBNull(52) ? "" : dr.GetString(52);
            _form.MaritalStatus = dr.IsDBNull(53) ? "" : dr.GetString(53);
            _form.HostelRequired = dr.IsDBNull(54) ? "" : dr.GetString(54);
            _form.AchivementInSports = dr.IsDBNull(55) ? "" : dr.GetString(55);
            _form.Level = dr.IsDBNull(56) ? "" : dr.GetString(56);
            _form.Game = dr.IsDBNull(57) ? "" : dr.GetString(57);
            _form.Medal = dr.IsDBNull(58) ? "" : dr.GetString(58);
            _form.NATAScore = dr.IsDBNull(59) ? "" : dr.GetString(59);
            _form.UniGaugeScore = dr.IsDBNull(60) ? "" : dr.GetString(60);
            _form.PostedDate = dr.IsDBNull(61) ? new DateTime() : dr.GetDateTime(61);
            _form.Fees = dr.IsDBNull(62) ? "" : dr.GetString(62);
            _form.Choice = dr.IsDBNull(63) ? "" : dr.GetString(63);
            _form.ChoiceTwo = dr.IsDBNull(64) ? "" : dr.GetString(64);
            _form.ChoiceThree = dr.IsDBNull(65) ? "" : dr.GetString(65);

            _form.BillNo = dr.IsDBNull(66) ? "" : dr.GetString(66);
            _form.BillDate = dr.IsDBNull(67) ? new DateTime() : dr.GetDateTime(67);


        }
        return _form;

    }
    public bool Validate()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spUserValidate", con);

        cmd.Parameters.AddWithValue("@UserName", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@Password", this.CandidateMobileNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        int rows = int.Parse(cmd.ExecuteScalar().ToString());
        return rows > 0 ? true : false;
    }

    public bool Validate23()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spUserValidate23", con);

        cmd.Parameters.AddWithValue("@UserName", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@Password", this.CandidateMobileNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        int rows = int.Parse(cmd.ExecuteScalar().ToString());
        return rows > 0 ? true : false;
    }

    public bool ISStudentExist(string EmailId)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spStudentExists", con);

        cmd.Parameters.AddWithValue("@EmailID", EmailID);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        int rows = int.Parse(cmd.ExecuteScalar().ToString());
        return rows > 0 ? true : false;
    }

    public ApplicationForm PrintPage(string ApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintDetails", con);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _form.ApplicationNo = dr.IsDBNull(0) ? "" : dr.GetString(0);
            _form.NameOfApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.CandidateMobileNo = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _form.EmailID = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.DateOfBirth = dr.IsDBNull(4) ? new DateTime() : dr.GetDateTime(4);
            _form.Gender = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.ApplicationFor = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.AddressForCommunication = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.Village = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.District = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.City = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.DifferentAblePerson = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _form.PercentageOfDisability = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _form.State = dr.IsDBNull(13) ? "" : dr.GetString(13);
            _form.Country = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _form.Pincode = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _form.ParentMobileNo = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _form.ParentTelephoneNo = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _form.PermanentAddress = dr.IsDBNull(18) ? "" : dr.GetString(18);
            _form.SslcSchoolName = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _form.SslcMediumOfInstruction = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _form.SslcYearOfPassing = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _form.SslcNoOFAttempt = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _form.SslcRegistrationNo = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _form.SslcPercentage = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _form.SslcBoardOFExamination = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _form.HscSchoolName = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _form.HscMediumOfInstruction = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _form.HscNoOfAttempt = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _form.HscRegistrationNo = dr.IsDBNull(29) ? "" : dr.GetString(29);
            _form.HscYearOfPassing = dr.IsDBNull(30) ? "" : dr.GetString(30);
            _form.HscPercentage = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _form.HscBoardOFExamination = dr.IsDBNull(32) ? "" : dr.GetString(32);
            _form.CollageName = dr.IsDBNull(33) ? "" : dr.GetString(33);
            _form.YearOfPassing = dr.IsDBNull(34) ? "" : dr.GetString(34);
            _form.Degree = dr.IsDBNull(35) ? "" : dr.GetString(35);
            _form.Percentage = dr.IsDBNull(36) ? "" : dr.GetString(36);
            _form.University = dr.IsDBNull(37) ? "" : dr.GetString(37);
            _form.RegistrationNo = dr.IsDBNull(38) ? "" : dr.GetString(38);
            _form.CutOffMarks = dr.IsDBNull(39) ? "" : dr.GetString(39);
            _form.Eligibility = dr.IsDBNull(40) ? "" : dr.GetString(40);
            _form.ModeOfPayment = dr.IsDBNull(41) ? "" : dr.GetString(41);
            _form.TelephoneNo = dr.IsDBNull(42) ? "" : dr.GetString(42);
            _form.BloodGroup = dr.IsDBNull(43) ? "" : dr.GetString(43);
            _form.Caste = dr.IsDBNull(44) ? "" : dr.GetString(44);
            _form.Religion = dr.IsDBNull(45) ? "" : dr.GetString(45);
            _form.Community = dr.IsDBNull(46) ? "" : dr.GetString(46);
            _form.Nationality = dr.IsDBNull(47) ? "" : dr.GetString(47);
            _form.FatherName = dr.IsDBNull(48) ? "" : dr.GetString(48);
            _form.MotherName = dr.IsDBNull(49) ? "" : dr.GetString(49);
            _form.ParentsOccupation = dr.IsDBNull(50) ? "" : dr.GetString(50);
            _form.AnnualIncome = dr.IsDBNull(51) ? "" : dr.GetString(51);
            _form.MotherTongue = dr.IsDBNull(52) ? "" : dr.GetString(52);
            _form.MaritalStatus = dr.IsDBNull(53) ? "" : dr.GetString(53);
            _form.HostelRequired = dr.IsDBNull(54) ? "" : dr.GetString(54);
            _form.AchivementInSports = dr.IsDBNull(55) ? "" : dr.GetString(55);
            _form.Level = dr.IsDBNull(56) ? "" : dr.GetString(56);
            _form.Game = dr.IsDBNull(57) ? "" : dr.GetString(57);
            _form.Medal = dr.IsDBNull(58) ? "" : dr.GetString(58);
            _form.NATAScore = dr.IsDBNull(59) ? "" : dr.GetString(59);
            _form.UniGaugeScore = dr.IsDBNull(60) ? "" : dr.GetString(60);
            _form.PostedDate = dr.IsDBNull(61) ? new DateTime() : dr.GetDateTime(61);
            _form.Fees = dr.IsDBNull(62) ? "" : dr.GetString(62);
            _form.Choice = dr.IsDBNull(63) ? "" : dr.GetString(63);
            _form.ChoiceTwo = dr.IsDBNull(64) ? "" : dr.GetString(64);
            _form.ChoiceThree = dr.IsDBNull(65) ? "" : dr.GetString(65);

            _form.BillNo = dr.IsDBNull(66) ? "" : dr.GetString(66);
            _form.BillDate = dr.IsDBNull(67) ? new DateTime() : dr.GetDateTime(67);
            _form.HscTotalMarks = dr.IsDBNull(68) ? "" : dr.GetString(68);
            _form.Course = dr.IsDBNull(69) ? "" : dr.GetString(69);
            _form.CourseType = dr.IsDBNull(70) ? "" : dr.GetString(70);
            _form.DegreeMedium = dr.IsDBNull(71) ? "" : dr.GetString(71);

        }
        return _form;

    }

    public DataTable AdmissionList()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdmissionList201718", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;
    }

    public DataTable AdmissionList2019()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdmissionList2019", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;
    }
    public DataTable AdmissionList2020()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdmissionList2020", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;
    }
    public DataTable AdmissionList2021()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdmissionList2021", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;
    }
    public DataTable AdmissionList2022()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdmissionList2022", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;
    }
    public DataTable ExportByMaster()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spExportApplicationMaster", con);
        cmd.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);


        dpt.Fill(dt);
        return dt;
    }

    public DataTable Printdetails()
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintApplication", con);
        cmd.CommandType = CommandType.StoredProcedure;


        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;


    }
    public DataTable Printdetails2020()
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintApplication2020", con);
        cmd.CommandType = CommandType.StoredProcedure;


        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;


    }
    public DataTable Printdetails2021()
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintApplication2021", con);
        cmd.CommandType = CommandType.StoredProcedure;


        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;


    }
    public DataTable Printdetails2022()
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintApplication2022", con);
        cmd.CommandType = CommandType.StoredProcedure;


        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;


    }
    public DataTable Printdetails2017()
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintApplication2017", con);
        cmd.CommandType = CommandType.StoredProcedure;


        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;


    }
    public DataTable Printdetails2018()
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintApplication2018", con);
        cmd.CommandType = CommandType.StoredProcedure;


        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;


    }

    public DataTable PrintExcel(string ApplicaitionNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintApplications", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitionNo);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;

    }

    public DataTable ListByDate(DateTime FromDate, DateTime ToDate)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spGetByDate", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        dpt.Fill(dt);
        return dt;
    }

    public DataTable ExportByDate(DateTime FromDate, DateTime ToDate)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spExportByDate", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        dpt.Fill(dt);
        return dt;
    }

    public DataTable ListAll(string ApplicationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spAdmissionList", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        dpt.Fill(dt);
        return dt;
    }

    public DataTable ListApplication2017()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spAdmissionList2017", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);      

        dpt.Fill(dt);
        return dt;
    }
    public DataTable ListApplication2020()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spAdmissionList2020", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataTable ListApplication2021()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spAdmissionList2021", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataTable ListApplication2022()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spAdmissionList2022", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataTable ListApplication2018()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spAdmissionList2018", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataTable ListGrievance()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spViewGrievance", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataSet ViewApplicationRegistrationList()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spViewApplicationRegistrationList", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataSet ViewAllRegistrationListByCampagin()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spAllViewRegistrationListByCampagin", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataSet spViewRegistrationListByCampagin(string stAppliedFrom)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spViewRegistrationListByCampagin", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@AppliedFrom", stAppliedFrom);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataSet GetApplicationDetails(string stApplicationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spGetApplicationDetailsByApplicationNo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
       
        dpt.Fill(dt);
        return dt;
    }
    public DataSet ViewFacultyname(string stChoice1)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spGetFacultyName", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Choice1", stChoice1);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
       
        dpt.Fill(dt);
        return dt;
    }

    public DataSet GetApplicationDetails23(string stApplicationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spGetApplicationDetailsByApplicationNo23", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
       
        dpt.Fill(dt);
        return dt;
    }
    public DataSet GetCashPaymentDetails23(string stApplicationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spGetCashPaymentDetails23", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
       
        dpt.Fill(dt);
        return dt;
    }
    public DataSet GetApplicationDetailsProvisional(string stApplicationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spGetApplicationDetailsProvisional", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataSet GetApplicationDetailsProvisional23(string stApplicationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spGetApplicationDetailsProvisional23", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataSet GetHSCMarks(string stApplicationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spHscMarkView", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }
    public DataSet GetHSCMarks23(string stApplicationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spHscMarkView23", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }

    public DataSet ViewBillDetails(string stApplicationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("ViewBillByApplicationNo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        DataSet dt = new DataSet();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);
        return dt;
    }

    public DataTable SelectedView(DateTime FromDate, DateTime ToDate)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminSearchByDate", con);
        cmd.Parameters.AddWithValue("@ModeOfPayment", ModeOfPayment);
        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }

    public DataTable ExportByPaymentDate(string payment, DateTime FromDate, DateTime ToDate)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spExportSearchByPaymentDate", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ModeOfPayment", payment);
        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }

    public DataTable ListCourseByDate(string ApplicationFor, DateTime FromDate, DateTime ToDate)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminSearchCourseByDate", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Courses", ApplicationFor);
        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }

    public DataTable ExportCourseByDate(string ApplicationFor, DateTime FromDate, DateTime ToDate)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spExportSearchCourseByDate", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Courses", ApplicationFor);
        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }

    public DataTable ListByPaymentDate(string payment, DateTime FromDate, DateTime ToDate)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminSearchByPaymentDate", con);
        cmd.CommandType = CommandType.StoredProcedure;      

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ModeOfPayment", payment);
        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }
    public DataTable ListByPaymentAndCourse(string payment, string course)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminSearchByPaymentAndCourse", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ModeOfPayment", payment);
        cmd.Parameters.AddWithValue("@Course", course);      

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }
    public DataTable ListByPaymentAndCourse2021(string payment, string course)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminSearchByPaymentAndCourse2021", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ModeOfPayment", payment);
        cmd.Parameters.AddWithValue("@Course", course);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }
    public DataTable ListByPaymentAndCourse2022(string payment, string course)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminSearchByPaymentAndCourse2022", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ModeOfPayment", payment);
        cmd.Parameters.AddWithValue("@Course", course);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }
    public DataTable ListByPayment(string payment,string Year)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminListByPayment", con);
        cmd.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();

        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ModeofPayment", payment);
        cmd.Parameters.AddWithValue("@Year", Year);
        dpt.Fill(dt);
        return dt;

    }

    public DataTable ExportByPayment(string payment,int Year)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spExportByPayment", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ModeofPayment", payment);
        cmd.Parameters.AddWithValue("@Year", Year);

        dpt.Fill(dt);
        return dt;

    }

    public DataTable ListByApplicationFor(string ApplicationFor)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminListByCourses", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable ListByApplicationFor2021(string ApplicationFor)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminListByCoursesBy2021", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable ListByApplicationFor2022(string ApplicationFor)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminListByCoursesBy2022", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable ListByApplicationFor2020(string ApplicationFor)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminListByCoursesBy2020", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable ListByApplicationFor2019(string ApplicationFor)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminListByCoursesBy2019", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable ListByApplicationFor2018(string ApplicationFor)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminListByCoursesBy2018", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable ListByApplicationFor2017(string ApplicationFor)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminListByCoursesBy2017", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable ExportByApplicationFor(string ApplicationFor,int Year)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spExportByCourses", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);
        cmd.Parameters.AddWithValue("@Year", Year);
        dpt.Fill(dt);
        return dt;

    }

    public DataTable ListBySports(string Year)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminListBySports", con);
        cmd.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@Year", Year);
        dpt.Fill(dt);

        return dt;

    }

    public DataTable ExportBySports(int Year)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spExportBySports", con);
        cmd.Parameters.AddWithValue("@Year", Year);
        cmd.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dt);

        return dt;

    }

    public DataTable ListByApplicationNo(string ApplicationNo)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spGetByApplicationNo", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable ListByApplicationNo_includeProvisional(string ApplicationNo)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spGetByApplicationNo_includeProvisional", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        dpt.Fill(dt);
        return dt;

    }
    
    public DataTable ListByTopDetails(string ApplicationNo)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("ViewTopPaymentDetails", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable ExportByApplicationNo(string ApplicationNo)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spExportByApplicationNo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
        dpt.Fill(dt);

        return dt;

    }

    public DataTable listSportByDate(DateTime FromDate, DateTime ToDate)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdminBySportsDate", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;

    }

    public DataTable ExportSportByDate(DateTime FromDate, DateTime ToDate)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spExportBySportsDate", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }

    public DataTable spPaymentIsSuccess(string stApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPaymentIsSuccess", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);      

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }
    public DataTable spPaymentIsSuccess23(string stApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPaymentIsSuccess23", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);      

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }
    public DataTable ViewPaymentMode(string stApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spViewPaymentMode", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }

    public DataTable ViewPaymentMode23(string stApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spViewPaymentMode23", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }
    public DataSet ViewRegByEmailId(string stEmailId)
    {
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegByEmailId", con))
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
    public DataSet ViewRegByMobileNo(string stMobileNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegByMobileNo", con))
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
    public DataSet ViewLeadByEmailId(string stEmailId)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMULead"].ConnectionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadByEmailId", con))
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
    public DataSet ViewLeadByMobileNo(string stMobileNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMULead"].ConnectionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewLeadByMobileNo", con))
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
    public DataTable ViewAdminApplicantsSearch(string stYear,string stModeOfPayment,string stCourse,string stBranch,string stFromDate,string stToDate)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("ViewAdminApplicantsSearch", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@Year", stYear);
        cmd.Parameters.AddWithValue("@ModeOfPayment", stModeOfPayment);
        cmd.Parameters.AddWithValue("@Course", stCourse);
        cmd.Parameters.AddWithValue("@Branch", stBranch);
        cmd.Parameters.AddWithValue("@FromDate", stFromDate);
        cmd.Parameters.AddWithValue("@ToDate", stToDate);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable ViewAdminApplicantsSearch_includeProvisional(string stYear, string stModeOfPayment, string stCourse, string stBranch, string stFromDate, string stToDate)
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("ViewAdminApplicantsSearch_includeProvisional", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@Year", stYear);
        cmd.Parameters.AddWithValue("@ModeOfPayment", stModeOfPayment);
        cmd.Parameters.AddWithValue("@Course", stCourse);
        cmd.Parameters.AddWithValue("@Branch", stBranch);

        dpt.Fill(dt);
        return dt;

    }
    public DataTable GetChoicesByApplicationNo(string stApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spGetChoicesByApplicationNo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;


    }

    public int Updateprovisionaladmissionfor(string stApplicationNo, string provisionaladmissionfor, string proviadmissionfees)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spUpdateprovisionaladmissionfor", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
        cmd.Parameters.AddWithValue("@provisionaladmissionfor",provisionaladmissionfor);
        cmd.Parameters.AddWithValue("@proviadmissionfees", proviadmissionfees);
        int provisional = int.Parse(cmd.ExecuteNonQuery().ToString());

        return provisional;

    }

    public DataTable spPaymentByCash(string stApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPaymentByCash", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;
    }

    public ApplicationForm PrintProvisionalPage(string ApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintProvisionalPageDetails", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _form.ApplicationNo = dr.IsDBNull(0) ? "" : dr.GetString(0);
            _form.NameOfApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.CandidateMobileNo = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _form.EmailID = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.DateOfBirth = dr.IsDBNull(4) ? new DateTime() : dr.GetDateTime(4);
            _form.Gender = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.provisionaladmissionfor = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.provisionaladmissionfees = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.paymentdate = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.Course = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.CourseType = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.ApplicationFor = dr.IsDBNull(11) ? "" : dr.GetString(11);
        }
        return _form;
    }

    public DataTable ChkProvisional_amtPaid(string stApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spProvisionalAmt", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);

        DataTable dtSelectedView = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtSelectedView);

        return dtSelectedView;
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

    public int InsertPayment2023(string BillNo, string ApplicationNo, string Fees, string paymentmode, string transStatus, string clnttxnref, string tpslbankcd, string tpsltxnid, string transerrmsg)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("spInsertPaymentDetails2023", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@BillNo", BillNo));
                command.Parameters.Add(new SqlParameter("@ApplicationNo", ApplicationNo));
                command.Parameters.Add(new SqlParameter("@Fees", Fees));
                command.Parameters.Add(new SqlParameter("@PaymentMode", paymentmode));
                command.Parameters.Add(new SqlParameter("@PaymentDateTime", DateTime.Now.ToString()));
                command.Parameters.Add(new SqlParameter("@TransactionStatus", transStatus));
                command.Parameters.Add(new SqlParameter("@ClientTxnRef", clnttxnref));
                command.Parameters.Add(new SqlParameter("@TpslBankCd", tpslbankcd));
                command.Parameters.Add(new SqlParameter("@TpsltxnId", tpsltxnid));
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


    public ApplicationForm PrintPage2023(string ApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintDetails2023", con);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _form.ApplicationNo = dr.IsDBNull(0) ? "" : dr.GetString(0);
            _form.NameOfApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.CandidateMobileNo = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _form.EmailID = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.DateOfBirth = dr.IsDBNull(4) ? new DateTime() : dr.GetDateTime(4);
            _form.Gender = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.ApplicationFor = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.AddressForCommunication = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.Village = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.District = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.City = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.DifferentAblePerson = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _form.PercentageOfDisability = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _form.State = dr.IsDBNull(13) ? "" : dr.GetString(13);
            _form.Country = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _form.Pincode = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _form.ParentMobileNo = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _form.ParentTelephoneNo = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _form.PermanentAddress = dr.IsDBNull(18) ? "" : dr.GetString(18);
            _form.SslcSchoolName = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _form.SslcMediumOfInstruction = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _form.SslcYearOfPassing = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _form.SslcNoOFAttempt = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _form.SslcRegistrationNo = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _form.SslcPercentage = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _form.SslcBoardOFExamination = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _form.HscSchoolName = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _form.HscMediumOfInstruction = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _form.HscNoOfAttempt = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _form.HscRegistrationNo = dr.IsDBNull(29) ? "" : dr.GetString(29);
            _form.HscYearOfPassing = dr.IsDBNull(30) ? "" : dr.GetString(30);
            _form.HscPercentage = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _form.HscBoardOFExamination = dr.IsDBNull(32) ? "" : dr.GetString(32);
            _form.CollageName = dr.IsDBNull(33) ? "" : dr.GetString(33);
            _form.YearOfPassing = dr.IsDBNull(34) ? "" : dr.GetString(34);
            _form.Degree = dr.IsDBNull(35) ? "" : dr.GetString(35);
            _form.Percentage = dr.IsDBNull(36) ? "" : dr.GetString(36);
            _form.University = dr.IsDBNull(37) ? "" : dr.GetString(37);
            _form.RegistrationNo = dr.IsDBNull(38) ? "" : dr.GetString(38);
            _form.CutOffMarks = dr.IsDBNull(39) ? "" : dr.GetString(39);
            _form.Eligibility = dr.IsDBNull(40) ? "" : dr.GetString(40);
            _form.ModeOfPayment = dr.IsDBNull(41) ? "" : dr.GetString(41);
            _form.TelephoneNo = dr.IsDBNull(42) ? "" : dr.GetString(42);
            _form.BloodGroup = dr.IsDBNull(43) ? "" : dr.GetString(43);
            _form.Caste = dr.IsDBNull(44) ? "" : dr.GetString(44);
            _form.Religion = dr.IsDBNull(45) ? "" : dr.GetString(45);
            _form.Community = dr.IsDBNull(46) ? "" : dr.GetString(46);
            _form.Nationality = dr.IsDBNull(47) ? "" : dr.GetString(47);
            _form.FatherName = dr.IsDBNull(48) ? "" : dr.GetString(48);
            _form.MotherName = dr.IsDBNull(49) ? "" : dr.GetString(49);
            _form.ParentsOccupation = dr.IsDBNull(50) ? "" : dr.GetString(50);
            _form.AnnualIncome = dr.IsDBNull(51) ? "" : dr.GetString(51);
            _form.MotherTongue = dr.IsDBNull(52) ? "" : dr.GetString(52);
            _form.MaritalStatus = dr.IsDBNull(53) ? "" : dr.GetString(53);
            _form.HostelRequired = dr.IsDBNull(54) ? "" : dr.GetString(54);
            _form.AchivementInSports = dr.IsDBNull(55) ? "" : dr.GetString(55);
            _form.Level = dr.IsDBNull(56) ? "" : dr.GetString(56);
            _form.Game = dr.IsDBNull(57) ? "" : dr.GetString(57);
            _form.Medal = dr.IsDBNull(58) ? "" : dr.GetString(58);
            _form.NATAScore = dr.IsDBNull(59) ? "" : dr.GetString(59);
            _form.UniGaugeScore = dr.IsDBNull(60) ? "" : dr.GetString(60);
            _form.PostedDate = dr.IsDBNull(61) ? new DateTime() : dr.GetDateTime(61);
            _form.Fees = dr.IsDBNull(62) ? "" : dr.GetString(62);
            _form.Choice = dr.IsDBNull(63) ? "" : dr.GetString(63);
            _form.ChoiceTwo = dr.IsDBNull(64) ? "" : dr.GetString(64);
            _form.ChoiceThree = dr.IsDBNull(65) ? "" : dr.GetString(65);

            _form.BillNo = dr.IsDBNull(66) ? "" : dr.GetString(66);
            _form.BillDate = dr.IsDBNull(67) ? new DateTime() : dr.GetDateTime(67);
            _form.HscTotalMarks = dr.IsDBNull(68) ? "" : dr.GetString(68);
            _form.Course = dr.IsDBNull(69) ? "" : dr.GetString(69);
            _form.CourseType = dr.IsDBNull(70) ? "" : dr.GetString(70);
            _form.DegreeMedium = dr.IsDBNull(71) ? "" : dr.GetString(71);
            _form.TransportRequired = dr.IsDBNull(72) ? "" : dr.GetString(72);
            _form.Scholarship = dr.IsDBNull(73) ? "" : dr.GetString(73);

        }
        return _form;

    }

    public string GenerateApplicationNo(string CourseType, string ApplicationFor, int ID)
    {
        string _CourseType = "";
        string _ApplicationFor = "";

        if (CourseType.Equals("Regular"))
        {
            _CourseType = "R";
        }
        else if (CourseType.Equals("Part Time"))
        {
            _CourseType = "PT";
        }
        else
        {
            _CourseType = "LAT";
        }

        if (ApplicationFor.Equals("B.Tech"))
        {
            if (CourseType.Equals("Regular"))
            {
                _ApplicationFor = "BTF";
            }
            else if (CourseType.Equals("Part Time"))
            {
                _ApplicationFor = "BTP";
            }
            else if (CourseType.Equals("Lateral"))
            {
                _ApplicationFor = "BTL";
            }
        }

        else if (ApplicationFor.Equals("BCA"))
        {
            _ApplicationFor = "BCA";
        }
        if (ApplicationFor.Equals("B.Com"))
        {
            _ApplicationFor = "BCOM";
        }
        if (ApplicationFor.Equals("B.Sc"))
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

        if (ApplicationFor.Equals("BBA") || ApplicationFor.Equals("B.B.A"))
        {
            _ApplicationFor = "BBA";
        }



        else if (ApplicationFor.Equals("B.Sc B.Ed"))
        {
            _ApplicationFor = "BSE";
        }
        else if (ApplicationFor.Equals("B.Ed"))
        {
            _ApplicationFor = "BED";
        }
        else if (ApplicationFor.Equals("M.Tech"))
        {
            if (CourseType.Equals("Regular"))
            {
                _ApplicationFor = "MTF";
            }
            else if (CourseType.Equals("Part Time"))
            {
                _ApplicationFor = "MTP";
            }


        }

        else if (ApplicationFor.Equals("M.A"))
        {
            _ApplicationFor = "MA";
        }
        else if (ApplicationFor.Equals("M.Arch"))
        {
            _ApplicationFor = "MAR";
        }
        if (ApplicationFor.Equals("MSW"))
        {
            _ApplicationFor = "MSW";
        }
        else if (ApplicationFor.Equals("MBA"))
        {
            _ApplicationFor = "MBA";
        }

        else if (ApplicationFor.Equals("M.Sc"))
        {
            _ApplicationFor = "MSC";
        }
        else if (ApplicationFor.Equals("MCA"))
        {
            _ApplicationFor = "MCA";
        }

        else if (ApplicationFor.Equals("M.Com"))
        {
            _ApplicationFor = "MCOM";
        }

        return _ApplicationFor + _CourseType + string.Format("{0:D5}", ID);

    }

    public int UpdateApplicationNo23(string ApplnNo,int ID)
    {
        int rowsAffected = 0;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spUpdateApplicationNo23", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ApplNo", ApplnNo);
        cmd.Parameters.AddWithValue("@Id", ID);
        rowsAffected = int.Parse(cmd.ExecuteNonQuery().ToString());

        return rowsAffected;
    }
    

    public DataSet ViewApplicationRegistrationList23(string Course, string CourseMode, string CourseType, string Branch, string FromDate, string ToDate, string Scholarship,string srchval)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        DataSet dsNews = new DataSet();

        try
        {
            using (SqlCommand command = new SqlCommand("ViewApplicationRegistrationList23", con))
            {
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Course", Course));
                command.Parameters.Add(new SqlParameter("@CourseMode", CourseMode));
                command.Parameters.Add(new SqlParameter("@CourseType", CourseType));
                command.Parameters.Add(new SqlParameter("@Branch", Branch));
                command.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(new SqlParameter("@Scholarship", Scholarship));
                command.Parameters.Add(new SqlParameter("@srchval", srchval));
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

    public DataSet ViewPaidApplicationList23(string Course, string CourseMode, string CourseType, string Branch, string FromDate, string ToDate, string State, string City, string Scholarship, string srchval)
    {
        string connetionString = null;
        SqlConnection con;
        connetionString = GetSqlConnection();
        con = new SqlConnection(connetionString); DataSet dsNews = new DataSet();

        try
        {
            using (SqlCommand command = new SqlCommand("ViewPaidApplicationList23", con))
            {
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Course", Course));
                command.Parameters.Add(new SqlParameter("@CourseMode", CourseMode));
                command.Parameters.Add(new SqlParameter("@CourseType", CourseType));
                command.Parameters.Add(new SqlParameter("@Branch", Branch));
                command.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(new SqlParameter("@State", State));
                command.Parameters.Add(new SqlParameter("@City", City));
                command.Parameters.Add(new SqlParameter("@Scholarship", Scholarship));
                command.Parameters.Add(new SqlParameter("@srchval", srchval));
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

    public DataSet ViewCashPaidApplicationList23(string Course, string CourseMode, string CourseType, string Branch, string FromDate, string ToDate, string State, string City, string Scholarship, string srchval)
    {
        string connetionString = null;
        SqlConnection con;
        connetionString = GetSqlConnection();
        con = new SqlConnection(connetionString); DataSet dsNews = new DataSet();

        try
        {
            using (SqlCommand command = new SqlCommand("ViewCashPaidApplicationList23", con))
            {
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Course", Course));
                command.Parameters.Add(new SqlParameter("@CourseMode", CourseMode));
                command.Parameters.Add(new SqlParameter("@CourseType", CourseType));
                command.Parameters.Add(new SqlParameter("@Branch", Branch));
                command.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(new SqlParameter("@State", State));
                command.Parameters.Add(new SqlParameter("@City", City));
                command.Parameters.Add(new SqlParameter("@Scholarship", Scholarship));
                command.Parameters.Add(new SqlParameter("@srchval", srchval));
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

    public DataSet ViewUnPaidApplicationList23(string Course, string CourseMode, string CourseType, string Branch, string FromDate, string ToDate, string State, string City, string Scholarship, string srchval)
    {
        string connetionString = null;
        SqlConnection con;
        connetionString = GetSqlConnection();
        con = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewUnPaidApplicationList23", con))
            {
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Course", Course));
                command.Parameters.Add(new SqlParameter("@CourseMode", CourseMode));
                command.Parameters.Add(new SqlParameter("@CourseType", CourseType));
                command.Parameters.Add(new SqlParameter("@Branch", Branch));
                command.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(new SqlParameter("@State", State));
                command.Parameters.Add(new SqlParameter("@City", City));
                command.Parameters.Add(new SqlParameter("@Scholarship", Scholarship));
                command.Parameters.Add(new SqlParameter("@srchval", srchval));
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

    public DataSet ViewCashUnPaidApplicationList23(string Course, string CourseMode, string CourseType, string Branch, string FromDate, string ToDate, string State, string City, string Scholarship, string srchval)
    {
        string connetionString = null;
        SqlConnection con;
        connetionString = GetSqlConnection();
        con = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCashUnPaidApplicationList23", con))
            {
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Course", Course));
                command.Parameters.Add(new SqlParameter("@CourseMode", CourseMode));
                command.Parameters.Add(new SqlParameter("@CourseType", CourseType));
                command.Parameters.Add(new SqlParameter("@Branch", Branch));
                command.Parameters.Add(new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(new SqlParameter("@State", State));
                command.Parameters.Add(new SqlParameter("@City", City));
                command.Parameters.Add(new SqlParameter("@Scholarship", Scholarship));
                command.Parameters.Add(new SqlParameter("@srchval", srchval));
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

    public ApplicationForm PrintPage2023Modify(string ApplicationNo)
    {
        ApplicationForm _form = new ApplicationForm();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spPrintDetails2023Modify", con);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _form.ApplicationNo = dr.IsDBNull(0) ? "" : dr.GetString(0);
            _form.NameOfApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.CandidateMobileNo = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _form.EmailID = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.DateOfBirth = dr.IsDBNull(4) ? new DateTime() : dr.GetDateTime(4);
            _form.Gender = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.ApplicationFor = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.AddressForCommunication = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.Village = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.District = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.City = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.DifferentAblePerson = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _form.PercentageOfDisability = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _form.State = dr.IsDBNull(13) ? "" : dr.GetString(13);
            _form.Country = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _form.Pincode = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _form.ParentMobileNo = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _form.ParentTelephoneNo = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _form.PermanentAddress = dr.IsDBNull(18) ? "" : dr.GetString(18);
            _form.SslcSchoolName = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _form.SslcMediumOfInstruction = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _form.SslcYearOfPassing = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _form.SslcNoOFAttempt = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _form.SslcRegistrationNo = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _form.SslcPercentage = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _form.SslcBoardOFExamination = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _form.HscSchoolName = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _form.HscMediumOfInstruction = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _form.HscNoOfAttempt = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _form.HscRegistrationNo = dr.IsDBNull(29) ? "" : dr.GetString(29);
            _form.HscYearOfPassing = dr.IsDBNull(30) ? "" : dr.GetString(30);
            _form.HscPercentage = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _form.HscBoardOFExamination = dr.IsDBNull(32) ? "" : dr.GetString(32);
            _form.CollageName = dr.IsDBNull(33) ? "" : dr.GetString(33);
            _form.YearOfPassing = dr.IsDBNull(34) ? "" : dr.GetString(34);
            _form.Degree = dr.IsDBNull(35) ? "" : dr.GetString(35);
            _form.Percentage = dr.IsDBNull(36) ? "" : dr.GetString(36);
            _form.University = dr.IsDBNull(37) ? "" : dr.GetString(37);
            _form.RegistrationNo = dr.IsDBNull(38) ? "" : dr.GetString(38);
            _form.CutOffMarks = dr.IsDBNull(39) ? "" : dr.GetString(39);
            _form.Eligibility = dr.IsDBNull(40) ? "" : dr.GetString(40);
            _form.ModeOfPayment = dr.IsDBNull(41) ? "" : dr.GetString(41);
            _form.TelephoneNo = dr.IsDBNull(42) ? "" : dr.GetString(42);
            _form.BloodGroup = dr.IsDBNull(43) ? "" : dr.GetString(43);
            _form.Caste = dr.IsDBNull(44) ? "" : dr.GetString(44);
            _form.Religion = dr.IsDBNull(45) ? "" : dr.GetString(45);
            _form.Community = dr.IsDBNull(46) ? "" : dr.GetString(46);
            _form.Nationality = dr.IsDBNull(47) ? "" : dr.GetString(47);
            _form.FatherName = dr.IsDBNull(48) ? "" : dr.GetString(48);
            _form.MotherName = dr.IsDBNull(49) ? "" : dr.GetString(49);
            _form.ParentsOccupation = dr.IsDBNull(50) ? "" : dr.GetString(50);
            _form.AnnualIncome = dr.IsDBNull(51) ? "" : dr.GetString(51);
            _form.MotherTongue = dr.IsDBNull(52) ? "" : dr.GetString(52);
            _form.MaritalStatus = dr.IsDBNull(53) ? "" : dr.GetString(53);
            _form.HostelRequired = dr.IsDBNull(54) ? "" : dr.GetString(54);
            _form.AchivementInSports = dr.IsDBNull(55) ? "" : dr.GetString(55);
            _form.Level = dr.IsDBNull(56) ? "" : dr.GetString(56);
            _form.Game = dr.IsDBNull(57) ? "" : dr.GetString(57);
            _form.Medal = dr.IsDBNull(58) ? "" : dr.GetString(58);
            _form.NATAScore = dr.IsDBNull(59) ? "" : dr.GetString(59);
            _form.UniGaugeScore = dr.IsDBNull(60) ? "" : dr.GetString(60);
            _form.PostedDate = dr.IsDBNull(61) ? new DateTime() : dr.GetDateTime(61);
            _form.Fees = dr.IsDBNull(62) ? "" : dr.GetString(62);
            _form.Choice = dr.IsDBNull(63) ? "" : dr.GetString(63);
            _form.ChoiceTwo = dr.IsDBNull(64) ? "" : dr.GetString(64);
            _form.ChoiceThree = dr.IsDBNull(65) ? "" : dr.GetString(65);

            _form.BillNo = dr.IsDBNull(66) ? "" : dr.GetString(66);
            _form.BillDate = dr.IsDBNull(67) ? new DateTime() : dr.GetDateTime(67);
            _form.HscTotalMarks = dr.IsDBNull(68) ? "" : dr.GetString(68);
            _form.Course = dr.IsDBNull(69) ? "" : dr.GetString(69);
            _form.CourseType = dr.IsDBNull(70) ? "" : dr.GetString(70);
            _form.DegreeMedium = dr.IsDBNull(71) ? "" : dr.GetString(71);
            _form.TransportRequired = dr.IsDBNull(72) ? "" : dr.GetString(72);
            _form.Scholarship = dr.IsDBNull(73) ? "" : dr.GetString(73);
            _form.CBillNo = dr.IsDBNull(74) ? "" : dr.GetString(74);
            _form.CBillDate = dr.IsDBNull(75) ? new DateTime() : dr.GetDateTime(75);

        }
        return _form;

    }
    public DataSet ViewRegByCourseEmailMobileNo(string stEmail, string stMobileNo, string coursemode, string coursetype, string Applnfor)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegByCourseEmailMobileNo", con))
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

    public int AddApplicationMasterList()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
                SqlCommand cmd = new SqlCommand("AddApplicationMasterList", cnn);
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
                cmd.Parameters.AddWithValue("@NameOfApplicant", this.NameOfApplicant);
                cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
                cmd.Parameters.AddWithValue("@CandidateMobileNo", this.CandidateMobileNo);
                cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", this.Gender);
                cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
                cmd.Parameters.AddWithValue("@AddressForCommunication", this.AddressForCommunication);
                cmd.Parameters.AddWithValue("@Village", this.Village);
                cmd.Parameters.AddWithValue("@District", this.District);
                cmd.Parameters.AddWithValue("@City", this.City);
                cmd.Parameters.AddWithValue("@DifferentAblePerson", this.DifferentAblePerson);
                cmd.Parameters.AddWithValue("@PercentageOfDisability", this.PercentageOfDisability);
                cmd.Parameters.AddWithValue("@Country", this.Country);
                cmd.Parameters.AddWithValue("@state", this.State);
                cmd.Parameters.AddWithValue("@Pincode", this.Pincode);
                cmd.Parameters.AddWithValue("@ParentMobileNo", this.ParentMobileNo);
                cmd.Parameters.AddWithValue("@ParentTelephoneNo", this.ParentTelephoneNo);
                cmd.Parameters.AddWithValue("@PermanentAddress", this.PermanentAddress);
                cmd.Parameters.AddWithValue("@SslcSchoolName", this.SslcSchoolName);
                cmd.Parameters.AddWithValue("@SslcMediumOfInstruction", this.SslcMediumOfInstruction);
                cmd.Parameters.AddWithValue("@SslcYearOfPassing", this.SslcYearOfPassing);
                cmd.Parameters.AddWithValue("@SslcNoOFAttempt", this.SslcNoOFAttempt);
                cmd.Parameters.AddWithValue("@SslcRegistrationNo", this.SslcRegistrationNo);
                cmd.Parameters.AddWithValue("@SslcPercentage", this.SslcPercentage);
                cmd.Parameters.AddWithValue("@SslcBoardOfExamination", this.SslcBoardOFExamination);
                cmd.Parameters.AddWithValue("@HscSchoolName", this.HscSchoolName);
                cmd.Parameters.AddWithValue("@HscMediumOfInstruction", this.HscMediumOfInstruction);
                cmd.Parameters.AddWithValue("@HscNoOfAttempt", this.HscNoOfAttempt);
                cmd.Parameters.AddWithValue("@HscRegistrationNo", this.HscRegistrationNo);
                cmd.Parameters.AddWithValue("@HscYearOfPassing", this.HscYearOfPassing);
                cmd.Parameters.AddWithValue("@HscPercentage", this.HscPercentage);
                cmd.Parameters.AddWithValue("@HscBoardOfExamination", this.HscBoardOFExamination);
                cmd.Parameters.AddWithValue("@CollegeName", this.CollageName);
                cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);
                cmd.Parameters.AddWithValue("@Degree", this.Degree);
                cmd.Parameters.AddWithValue("@Percentage", this.Percentage);
                cmd.Parameters.AddWithValue("@BoardOfExamination", this.University);
                cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
                cmd.Parameters.AddWithValue("@CutOffMarks", this.CutOffMarks);
                cmd.Parameters.AddWithValue("@Eligibility", this.Eligibility);
                cmd.Parameters.AddWithValue("@ModeOfPayment", this.ModeOfPayment);
                cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);
                cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
                cmd.Parameters.AddWithValue("@Caste", this.Caste);
                cmd.Parameters.AddWithValue("@Religion", this.Religion);
                cmd.Parameters.AddWithValue("@Community", this.Community);
                cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
                cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
                cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
                cmd.Parameters.AddWithValue("@ParentsOccupation", string.Empty);
                cmd.Parameters.AddWithValue("@AnnualIncome", this.AnnualIncome);
                cmd.Parameters.AddWithValue("@MotherTongue", this.MotherTongue);
                cmd.Parameters.AddWithValue("@MaritalStatus", this.MaritalStatus);
                cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
                cmd.Parameters.AddWithValue("@AchivementInSports", this.AchivementInSports);
                cmd.Parameters.AddWithValue("@Level", this.Level);
                cmd.Parameters.AddWithValue("@Game", this.Game);
                cmd.Parameters.AddWithValue("Medal", this.Medal);
                cmd.Parameters.AddWithValue("NATAScore", this.NATAScore);
                cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);
                cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
                cmd.Parameters.AddWithValue("@Fees", this.Fees);
                cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);
                cmd.Parameters.AddWithValue("@FatherOccupation", this.FatherOccupation);
                cmd.Parameters.AddWithValue("@MotherOccupation", this.MotherOccupation);
                cmd.Parameters.AddWithValue("@AadharNumber", this.AadharNumber);
                cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);
                cmd.Parameters.AddWithValue("@TransportRequired", this.TransportRequired);

                cmd.Parameters.AddWithValue("@CommunitycentralQuota", this.CommunitycentralQuota);
                cmd.Parameters.AddWithValue("@SslcSchoolCategory", this.SslcSchoolCategory);
                cmd.Parameters.AddWithValue("@SslcSchoolDistrict", this.SslcSchoolDistrict);
                cmd.Parameters.AddWithValue("@HSCSchoolCategory", this.HSCSchoolCategory);
                cmd.Parameters.AddWithValue("@HSCSchoolDistrict", this.HSCSchoolDistrict);


                rowsAffected = int.Parse(cmd.ExecuteNonQuery().ToString());
                cmd = new SqlCommand("spHscMarkDetailsDelete23", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("spHSCMarksCreateTest23", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (HSCMarks _mark in this.HscMarks)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
                    cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
                    cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
                    cmd.Parameters.AddWithValue("@Board", _mark.Board);
                    cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

                    cmd.ExecuteNonQuery();
                }
            
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
  
}
