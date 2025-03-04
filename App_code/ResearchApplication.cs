using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ResearchApplication
/// </summary>
public class ResearchApplication
{
    #region

    public string NameOfTheApplicant { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ModeOfStudy { get; set; }
    public string MobileNo { get; set; }
    public string EmailId { get; set; }
    public string ApplicationFor { get; set; }
    public string Branch { get; set; }
    public string BoardAreaOfResearch { get; set; }
    public string ApplicationNo { get; set; }
    public string Gender { get; set; }
    public string PlaceOfBirth { get; set; }
    public string BloodGroup { get; set; }
    public string Village { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public string ModeOfPayment { get; set; }
    public string TelephoneNo { get; set; }
    public string Caste { get; set; }
    public string Religion { get; set; }
    public string Community { get; set; }
    public string Nationality { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string MaritalStatus { get; set; }
    public string CountryInWhichQualified { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Pincode { get; set; }
    public string PDistrict { get; set; }
    public string PPincode { get; set; }
    public string CommunicationAddress { get; set; }
    public string PermanentAddress { get; set; }
    public string PState { get; set; }
    public string PCountry { get; set; }
    public string MotherTounge { get; set; }
    public string PersonWithDisability { get; set; }
    public string StateThePercentageOfDisability { get; set; }
    public string FatherMobileNo { get; set; }
    public string HostelRequired { get; set; }
    public string SponsoredCandidate { get; set; }
    public string ValidScore { get; set; }
    public string TypeOfEmployee { get; set; }
    public string NameOfTheEmployer { get; set; }
    public string NatureOfWork { get; set; }
    public string AadhaarCardNo { get; set; }
    public string Others { get; set; }
    public string TotalExperience { get; set; }
    public string AverageMonthlyIncome { get; set; }
    public string PaperPublished { get; set; }
    public string QualifiyingDegree { get; set; }
    public string Specialization { get; set; }
    public string NameOfTheCollege { get; set; }
    public string AffiliatingUniversity { get; set; }
    public string MonthAndYearOfPassing { get; set; }
    public string AverageMarks { get; set; }
    public string PaymentMode { get; set; }
    public string NameOfTheOrganization { get; set; }
    public string Designation { get; set; }
    public string University { get; set; }
    public string PeriodFrom { get; set; }
    public string PeriodTo { get; set; }
    public string AveragePercentageOfMarks { get; set; }
    public string Fees { get; set; }
    public string BillNo { get; set; }
    public DateTime BillDate { get; set; }
    public string NameOftheApplicant { get; set; }
    public DateTime PostedDate { get; set; }


    public List<ProfessionalDetails> ProfessionalDetails { get; set; }

    public List<ResearchDetails> ResearchDetails { get; set; }


    #endregion

    public ResearchApplication()
    {
        this.ProfessionalDetails = new List<ProfessionalDetails>();
        this.ResearchDetails = new List<ResearchDetails>();
    }

    public string NewApplicationNo(string CourseType, string ApplicationFor, string Branch)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spNewApplicationNo", con);
        cmd.Parameters.AddWithValue("@Discipline", Branch);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        int _ApplicationNo = int.Parse(cmd.ExecuteScalar().ToString()) + 1;

        string _CourseType = "";
        string _ApplicationFor = "";
        string _Branch = "";

        if (Branch.Equals("Bio-Chemistry"))
        {
            _Branch = "BC";
        }
        else if (Branch.Equals("Bio-Technology"))
        {
            _Branch = "BT";
        }
        else if (Branch.Equals("Commerce"))
        {
            _Branch = "COM";
        }
        else if (Branch.Equals("Chemistry"))
        {
            _Branch = "C";
        }
        else if (Branch.Equals("Computer Science"))
        {
            _Branch = "CS";
        }
        else if (Branch.Equals("Economics"))
        {
            _Branch = "EC";

        }
        else if (Branch.Equals("Education"))
        {
            _Branch = "ED";
        }
        else if (Branch.Equals("English"))
        {
            _Branch = "ENG";
        }
        else if (Branch.Equals("Environmental Science"))
        {
            _Branch = "EVS";
        }
        else if (Branch.Equals("Management studies"))
        {
            _Branch = "MS";
        }
        else if (Branch.Equals("Mathematics"))
        {
            _Branch = "M";
        }
        else if (Branch.Equals("Periyar Thought"))
        {
            _Branch = "PT";

        }
        else if (Branch.Equals("Physics"))
        {
            _Branch = "PH";

        }
        else if (Branch.Equals("Nano-Technology"))
        {
            _Branch = "NT";

        }
        else if (Branch.Equals("Political Science"))
        {
            _Branch = "PS";

        }
        else if (Branch.Equals("Social Work"))
        {
            _Branch = "SW";

        }
        else if (Branch.Equals("Architecture"))
        {
            _Branch = "AR";

        }
        else if (Branch.Equals("Civil Engineering"))
        {
            _Branch = "CV";

        }
        else if (Branch.Equals("Computer Applications"))
        {
            _Branch = "CA";

        }
        else if (Branch.Equals("Computer Science and Engineering"))
        {
            _Branch = "CSE";

        }
        else if (Branch.Equals("Chemical Engineering"))
        {
            _Branch = "CE";

        }
        else if (Branch.Equals("Electrical and Electronics Engineering"))
        {
            _Branch = "EEE";

        }
        else if (Branch.Equals("Electronics and Communication Engineering"))
        {
            _Branch = "ECE";

        }
        else if (Branch.Equals("Information Technology"))
        {
            _Branch = "IT";

        }
        else if (Branch.Equals("Mechanical Engineering"))
        {
            _Branch = "MC";

        }
        else if (Branch.Equals("Dr.Kalaignar M.Karunanidhi Centre for Political Science"))
        {
            _Branch = "KPS";
        }
        else if (Branch.Equals("CSA"))
        {
            _Branch = "CSA";
        }

        if (CourseType.Equals("Full Time"))
        {
            _CourseType = "F";
        }
        else if (CourseType.Equals("External Part Time"))
        {
            _CourseType = "E";
        }
        else if (CourseType.Equals("Part Time"))
        {
            _CourseType = "P";
        }
        else
        {
            _CourseType = "S";
        }

        if (ApplicationFor.Equals("M.Phil"))
        {
            _ApplicationFor = "MP";
        }
        else
        {
            _ApplicationFor = "PhD";
        }


        return _ApplicationFor + _CourseType + _Branch + string.Format("{0:D4}", _ApplicationNo);
    }


    public bool IsApplicationAlreadyRegistered(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchApplicationIsRegistered", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }

    public bool IsBillNoAlreadyRegistered(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spBillNoIsRegistered", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }

    public int ApplicationRegister()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchApplicationCreate", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@NameOfTheApplicant", this.NameOfTheApplicant);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@ModeOfStudy", this.ModeOfStudy);
        cmd.Parameters.AddWithValue("@MobileNo", this.MobileNo);
        cmd.Parameters.AddWithValue("@EmailID", this.EmailId);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@Branch", this.Branch);
        cmd.Parameters.AddWithValue("@BoardAreaOfResearch", this.BoardAreaOfResearch);
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

        int createForm = int.Parse(cmd.ExecuteNonQuery().ToString());

        return createForm;
    }

    public int ApplicationForm()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchApplicationFormCreate", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@NameOfTheApplicant", this.NameOfTheApplicant);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailId);
        cmd.Parameters.AddWithValue("@CandidateMobileNo", this.MobileNo);
        cmd.Parameters.AddWithValue("@Gender", this.Gender);
        cmd.Parameters.AddWithValue("@PlaceOfBirth", this.PlaceOfBirth);
        cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
        cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
        cmd.Parameters.AddWithValue("@CountryInWhichQualified", this.CountryInWhichQualified);
        cmd.Parameters.AddWithValue("@Religion", this.Religion);
        cmd.Parameters.AddWithValue("@MotherTounge", this.MotherTounge);
        cmd.Parameters.AddWithValue("@Community", this.Community);
        cmd.Parameters.AddWithValue("@Caste", this.Caste);
        cmd.Parameters.AddWithValue("@PersonWithDisablity", this.PersonWithDisability);
        cmd.Parameters.AddWithValue("@StateThePercentageOfDisablity", this.StateThePercentageOfDisability);
        cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
        cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
        cmd.Parameters.AddWithValue("@MaritalStatus", this.MaritalStatus);
        cmd.Parameters.AddWithValue("@CommunicationAddress", this.CommunicationAddress);
        cmd.Parameters.AddWithValue("@District", this.District);
        cmd.Parameters.AddWithValue("@Pincode", this.Pincode);
        cmd.Parameters.AddWithValue("@State", this.State);
        cmd.Parameters.AddWithValue("@Country", this.Country);
        cmd.Parameters.AddWithValue("@PermanentAddress", this.PermanentAddress);
        cmd.Parameters.AddWithValue("@PDistrict", this.PDistrict);
        cmd.Parameters.AddWithValue("@PPincode", this.PPincode);
        cmd.Parameters.AddWithValue("@Pstate", this.PState);
        cmd.Parameters.AddWithValue("@Pcountry", this.PCountry);
        cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);
        cmd.Parameters.AddWithValue("@FatherMobileNo", this.FatherMobileNo);
        cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
        cmd.Parameters.AddWithValue("@SponsoredCandidate", this.SponsoredCandidate);
        cmd.Parameters.AddWithValue("@ValidScore", this.ValidScore);
        cmd.Parameters.AddWithValue("@Others", this.Others);
        cmd.Parameters.AddWithValue("@TypeOfEmployee", this.TypeOfEmployee);
        cmd.Parameters.AddWithValue("@NameOfEmployer", this.NameOfTheEmployer);
        cmd.Parameters.AddWithValue("@NatureOfWork", this.NatureOfWork);
        cmd.Parameters.AddWithValue("@TotalExperience", this.TotalExperience);
        cmd.Parameters.AddWithValue("@AverageMonthlyIncome", this.AverageMonthlyIncome);
        cmd.Parameters.AddWithValue("@PaperPublished", this.PaperPublished);
        cmd.Parameters.AddWithValue("@PaymentMode", this.PaymentMode);
        cmd.Parameters.AddWithValue("@Fees", this.Fees);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@Branch", this.Branch);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
        cmd.Parameters.AddWithValue("@AadhaarCardNo", this.AadhaarCardNo);

        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());

        cmd = new SqlCommand("spProfessionalExpCreate", con);
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (ProfessionalDetails _mark in this.ProfessionalDetails)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            cmd.Parameters.AddWithValue("@NameOfOrganization", _mark.NameOfTheOrganization);
            cmd.Parameters.AddWithValue("@Designation", _mark.Designation);
            cmd.Parameters.AddWithValue("@University", _mark.University);
            cmd.Parameters.AddWithValue("@PeriodFrom", _mark.PeriodFrom);
            cmd.Parameters.AddWithValue("@PeriodTo", _mark.PeriodTo);

            cmd.ExecuteNonQuery();
        }


        cmd = new SqlCommand("spResearchDetailsCreate", con);
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (ResearchDetails _research in this.ResearchDetails)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ApplicationNo", _research.ApplicationNo);
            cmd.Parameters.AddWithValue("@QualifiyingDegree", _research.QualifiyingDegree);
            cmd.Parameters.AddWithValue("@Specialization", _research.Specialization);
            cmd.Parameters.AddWithValue("@NameOfTheCollege", _research.NameOfTheCollege);
            cmd.Parameters.AddWithValue("@AffiliatingUniversity", _research.AffiliatingUniversity);
            cmd.Parameters.AddWithValue("@MonthAndYearOfPassing", _research.MonthAndYearOfPassing);
            cmd.Parameters.AddWithValue("@AveragePercentageOfMarks", _research.AveragePercentageOfMarks);

            cmd.ExecuteNonQuery();
        }

        return rows;
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
        cmd.Parameters.AddWithValue("@PaymentMode", this.PaymentMode);
        cmd.Parameters.AddWithValue("@BillNo", this.BillNo);
        cmd.Parameters.AddWithValue("@BillDate", this.BillDate);

        int InsertBillNo = int.Parse(cmd.ExecuteNonQuery().ToString());



        return InsertBillNo;

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
        cmd.Parameters.AddWithValue("@PaymentMode", this.PaymentMode);
        cmd.Parameters.AddWithValue("@BillNo", this.BillNo);
        cmd.Parameters.AddWithValue("@BillDate", this.BillDate);

        int UpdateBillNo = int.Parse(cmd.ExecuteNonQuery().ToString());

        return UpdateBillNo;

    }

    public ResearchApplication GetDetails(string ApplicationNo)
    {
        ResearchApplication _form = new ResearchApplication();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spGetResearchDetailsByApplicationNo", con);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _form.NameOfTheApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.DateOfBirth = dr.IsDBNull(2) ? new DateTime() : dr.GetDateTime(2);
            _form.ModeOfStudy = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.MobileNo = dr.IsDBNull(4) ? "" : dr.GetString(4);
            _form.EmailId = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.ApplicationFor = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.Branch = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.BoardAreaOfResearch = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.ApplicationNo = dr.IsDBNull(9) ? "" : dr.GetString(9);

        }
        return _form;

    }

    public ResearchApplication GetList(string ApplicationNo)
    {
        ResearchApplication _form = new ResearchApplication();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchApplicationFormView", con);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _form.ApplicationNo = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.NameOfTheApplicant = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _form.DateOfBirth = dr.IsDBNull(3) ? new DateTime() : dr.GetDateTime(3);
            _form.EmailId = dr.IsDBNull(4) ? "" : dr.GetString(4);
            _form.MobileNo = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.Gender = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.PlaceOfBirth = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.BloodGroup = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.Nationality = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.CountryInWhichQualified = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.Religion = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _form.MotherTounge = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _form.Community = dr.IsDBNull(13) ? "" : dr.GetString(13);
            _form.Caste = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _form.PersonWithDisability = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _form.StateThePercentageOfDisability = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _form.MotherName = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _form.FatherName = dr.IsDBNull(18) ? "" : dr.GetString(18);
            _form.MaritalStatus = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _form.CommunicationAddress = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _form.District = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _form.Pincode = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _form.State = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _form.Country = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _form.PermanentAddress = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _form.PDistrict = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _form.PPincode = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _form.PState = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _form.PCountry = dr.IsDBNull(29) ? "" : dr.GetString(29);
            _form.TelephoneNo = dr.IsDBNull(30) ? "" : dr.GetString(30);
            _form.FatherMobileNo = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _form.HostelRequired = dr.IsDBNull(32) ? "" : dr.GetString(32);
            _form.SponsoredCandidate = dr.IsDBNull(33) ? "" : dr.GetString(33);
            _form.ValidScore = dr.IsDBNull(34) ? "" : dr.GetString(34);
            _form.Others = dr.IsDBNull(35) ? "" : dr.GetString(35);
            _form.TypeOfEmployee = dr.IsDBNull(36) ? "" : dr.GetString(36);
            _form.NameOfTheEmployer = dr.IsDBNull(37) ? "" : dr.GetString(37);
            _form.NatureOfWork = dr.IsDBNull(38) ? "" : dr.GetString(37);
            _form.TotalExperience = dr.IsDBNull(39) ? "" : dr.GetString(39);
            _form.AverageMonthlyIncome = dr.IsDBNull(40) ? "" : dr.GetString(40);
            _form.PaperPublished = dr.IsDBNull(41) ? "" : dr.GetString(41);
            _form.PaymentMode = dr.IsDBNull(42) ? "" : dr.GetString(42);
            _form.Fees = dr.IsDBNull(43) ? "" : dr.GetString(43);
            _form.ApplicationFor = dr.IsDBNull(44) ? "" : dr.GetString(44);
            _form.Branch = dr.IsDBNull(45) ? "" : dr.GetString(45);
            _form.PostedDate = dr.IsDBNull(46) ? new DateTime() : dr.GetDateTime(46);
            _form.AadhaarCardNo = dr.IsDBNull(47) ? "" : dr.GetString(47);
        }
        return _form;

    }

    //public ResearchApplication GetResearchDetails(string ApplicationNo)
    //{
    //    ResearchApplication _form = new ResearchApplication();

    //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand("spResearchApplicationFormView", con);

    //    cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

    //    cmd.CommandType = System.Data.CommandType.StoredProcedure;

    //    SqlDataReader dr = cmd.ExecuteReader();

    //    if (dr.Read())
    //    {
    //        _form.ApplicationNo = dr.IsDBNull(1) ? "" : dr.GetString(1);
    //        _form.NameOfTheApplicant = dr.IsDBNull(2) ? "" : dr.GetString(2);
    //        _form.DateOfBirth = dr.IsDBNull(3) ? new DateTime() : dr.GetDateTime(3);
    //        _form.EmailId = dr.IsDBNull(4) ? "" : dr.GetString(4);
    //        _form.MobileNo = dr.IsDBNull(5) ? "" : dr.GetString(5);
    //        _form.Gender = dr.IsDBNull(6) ? "" : dr.GetString(6);
    //        _form.PlaceOfBirth = dr.IsDBNull(7) ? "" : dr.GetString(7);
    //        _form.BloodGroup = dr.IsDBNull(8) ? "" : dr.GetString(8);
    //        _form.Nationality = dr.IsDBNull(9) ? "" : dr.GetString(9);
    //        _form.CountryInWhichQualified = dr.IsDBNull(10) ? "" : dr.GetString(10);
    //        _form.Religion = dr.IsDBNull(11) ? "" : dr.GetString(11);
    //        _form.MotherTounge = dr.IsDBNull(12) ? "" : dr.GetString(12);
    //        _form.Community = dr.IsDBNull(13) ? "" : dr.GetString(13);
    //        _form.Caste = dr.IsDBNull(14) ? "" : dr.GetString(14);
    //        _form.PersonWithDisability = dr.IsDBNull(15) ? "" : dr.GetString(15);
    //        _form.StateThePercentageOfDisability = dr.IsDBNull(16) ? "" : dr.GetString(16);
    //        _form.MotherName = dr.IsDBNull(17) ? "" : dr.GetString(17);
    //        _form.FatherName = dr.IsDBNull(18) ? "" : dr.GetString(18);
    //        _form.MaritalStatus = dr.IsDBNull(19) ? "" : dr.GetString(19);
    //        _form.CommunicationAddress = dr.IsDBNull(20) ? "" : dr.GetString(20);
    //        _form.District = dr.IsDBNull(21) ? "" : dr.GetString(21);
    //        _form.Pincode = dr.IsDBNull(22) ? "" : dr.GetString(22);
    //        _form.State = dr.IsDBNull(23) ? "" : dr.GetString(23);
    //        _form.Country = dr.IsDBNull(24) ? "" : dr.GetString(24);
    //        _form.PermanentAddress = dr.IsDBNull(25) ? "" : dr.GetString(25);
    //        _form.PDistrict = dr.IsDBNull(26) ? "" : dr.GetString(26);
    //        _form.PPincode = dr.IsDBNull(27) ? "" : dr.GetString(27);
    //        _form.PState = dr.IsDBNull(28) ? "" : dr.GetString(28);
    //        _form.PCountry = dr.IsDBNull(29) ? "" : dr.GetString(29);
    //        _form.TelephoneNo = dr.IsDBNull(30) ? "" : dr.GetString(30);
    //        _form.FatherMobileNo = dr.IsDBNull(31) ? "" : dr.GetString(31);
    //        _form.HostelRequired = dr.IsDBNull(32) ? "" : dr.GetString(32);
    //        _form.SponsoredCandidate = dr.IsDBNull(33) ? "" : dr.GetString(33);
    //        _form.ValidScore = dr.IsDBNull(34) ? "" : dr.GetString(34);
    //        _form.Others = dr.IsDBNull(35) ? "" : dr.GetString(35);
    //        _form.TypeOfEmployee = dr.IsDBNull(36) ? "" : dr.GetString(36);
    //        _form.NameOfTheEmployer = dr.IsDBNull(37) ? "" : dr.GetString(37);
    //        _form.NatureOfWork = dr.IsDBNull(38) ? "" : dr.GetString(37);
    //        _form.TotalExperience = dr.IsDBNull(39) ? "" : dr.GetString(39);
    //        _form.AverageMonthlyIncome = dr.IsDBNull(40) ? "" : dr.GetString(40);
    //        _form.PaperPublished = dr.IsDBNull(41) ? "" : dr.GetString(41);
    //        _form.PaymentMode = dr.IsDBNull(42) ? "" : dr.GetString(42);
    //        _form.Fees = dr.IsDBNull(43) ? "" : dr.GetString(43);
    //        _form.ApplicationFor = dr.IsDBNull(44) ? "" : dr.GetString(44);
    //        _form.Branch = dr.IsDBNull(45) ? "" : dr.GetString(45);
    //        _form.PostedDate = dr.IsDBNull(46) ? new DateTime() : dr.GetDateTime(46);
    //        _form.AadhaarCardNo = dr.IsDBNull(47) ? "" : dr.GetString(47);
    //    }
    //    return _form;

    //}

    public ResearchApplication GetBillDetails(string ApplicationNo)
    {
        ResearchApplication _form = new ResearchApplication();

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
            _form.PaymentMode = dr.IsDBNull(4) ? "" : dr.GetString(4);
            _form.BillNo = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.BillDate = dr.IsDBNull(6) ? new DateTime() : dr.GetDateTime(6);


        }
        return _form;

    }

    public ResearchApplication PrintResearchApplication(string ApplicationNo)
    {
        ResearchApplication _form = new ResearchApplication();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchApplicationFormView", con);
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _form.ApplicationNo = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.NameOfTheApplicant = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _form.DateOfBirth = dr.IsDBNull(3) ? new DateTime() : dr.GetDateTime(3);
            _form.EmailId = dr.IsDBNull(4) ? "" : dr.GetString(4);
            _form.MobileNo = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.Gender = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.PlaceOfBirth = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.BloodGroup = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.Nationality = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.CountryInWhichQualified = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.Religion = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _form.MotherTounge = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _form.Community = dr.IsDBNull(13) ? "" : dr.GetString(13);
            _form.Caste = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _form.PersonWithDisability = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _form.StateThePercentageOfDisability = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _form.MotherName = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _form.FatherName = dr.IsDBNull(18) ? "" : dr.GetString(18);
            _form.MaritalStatus = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _form.CommunicationAddress = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _form.District = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _form.Pincode = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _form.State = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _form.Country = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _form.PermanentAddress = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _form.PDistrict = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _form.PPincode = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _form.PState = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _form.PCountry = dr.IsDBNull(29) ? "" : dr.GetString(29);
            _form.TelephoneNo = dr.IsDBNull(30) ? "" : dr.GetString(30);
            _form.FatherMobileNo = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _form.HostelRequired = dr.IsDBNull(32) ? "" : dr.GetString(32);
            _form.SponsoredCandidate = dr.IsDBNull(33) ? "" : dr.GetString(33);
            _form.ValidScore = dr.IsDBNull(34) ? "" : dr.GetString(34);
            _form.Others = dr.IsDBNull(35) ? "" : dr.GetString(35);
            _form.TypeOfEmployee = dr.IsDBNull(36) ? "" : dr.GetString(36);
            _form.NameOfTheEmployer = dr.IsDBNull(37) ? "" : dr.GetString(37);
            _form.NatureOfWork = dr.IsDBNull(38) ? "" : dr.GetString(37);
            _form.TotalExperience = dr.IsDBNull(39) ? "" : dr.GetString(39);
            _form.AverageMonthlyIncome = dr.IsDBNull(40) ? "" : dr.GetString(40);
            _form.PaperPublished = dr.IsDBNull(41) ? "" : dr.GetString(41);
            _form.PaymentMode = dr.IsDBNull(42) ? "" : dr.GetString(42);
            _form.Fees = dr.IsDBNull(43) ? "" : dr.GetString(43);
            _form.ApplicationFor = dr.IsDBNull(44) ? "" : dr.GetString(44);
            _form.Branch = dr.IsDBNull(45) ? "" : dr.GetString(45);
            _form.PostedDate = dr.IsDBNull(46) ? new DateTime() : dr.GetDateTime(46);
            _form.AadhaarCardNo = dr.IsDBNull(47) ? "" : dr.GetString(47);

        }
        return _form;

    }

    public ResearchApplication ResearchPrint(string ApplicationNo)
    {
        ResearchApplication _form = new ResearchApplication();

        ProfessionalDetails _Professional = new ProfessionalDetails();
        ResearchDetails Research = new global::ResearchDetails();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchPrint", con);
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {

            _form.ApplicationNo = dr.IsDBNull(0) ? "" : dr.GetString(0);
            _form.NameOfTheApplicant = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _form.DateOfBirth = dr.IsDBNull(2) ? new DateTime() : dr.GetDateTime(2);
            _form.EmailId = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _form.MobileNo = dr.IsDBNull(4) ? "" : dr.GetString(4);
            _form.Gender = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _form.PlaceOfBirth = dr.IsDBNull(6) ? "" : dr.GetString(6);
            _form.BloodGroup = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _form.Nationality = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _form.CountryInWhichQualified = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _form.Religion = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _form.MotherTounge = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _form.Community = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _form.Caste = dr.IsDBNull(13) ? "" : dr.GetString(13);
            _form.PersonWithDisability = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _form.StateThePercentageOfDisability = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _form.MotherName = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _form.FatherName = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _form.AadhaarCardNo = dr.IsDBNull(18) ? "" : dr.GetString(18);
            _form.MaritalStatus = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _form.CommunicationAddress = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _form.District = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _form.Pincode = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _form.State = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _form.Country = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _form.PermanentAddress = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _form.PDistrict = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _form.PPincode = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _form.PState = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _form.PCountry = dr.IsDBNull(29) ? "" : dr.GetString(29);
            _form.TelephoneNo = dr.IsDBNull(30) ? "" : dr.GetString(30);
            _form.FatherMobileNo = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _form.HostelRequired = dr.IsDBNull(32) ? "" : dr.GetString(32);
            _form.SponsoredCandidate = dr.IsDBNull(33) ? "" : dr.GetString(33);
            _form.ValidScore = dr.IsDBNull(34) ? "" : dr.GetString(34);
            _form.Others = dr.IsDBNull(35) ? "" : dr.GetString(35);
            _form.TypeOfEmployee = dr.IsDBNull(36) ? "" : dr.GetString(36);
            _form.NameOfTheEmployer = dr.IsDBNull(37) ? "" : dr.GetString(37);
            _form.NatureOfWork = dr.IsDBNull(38) ? "" : dr.GetString(38);
            _form.TotalExperience = dr.IsDBNull(39) ? "" : dr.GetString(39);
            _form.AverageMonthlyIncome = dr.IsDBNull(40) ? "" : dr.GetString(40);
            _form.PaperPublished = dr.IsDBNull(41) ? "" : dr.GetString(41);
            _form.ApplicationFor = dr.IsDBNull(42) ? "" : dr.GetString(42);
            _form.Branch = dr.IsDBNull(43) ? "" : dr.GetString(43);
            _form.BoardAreaOfResearch = dr.IsDBNull(44) ? "" : dr.GetString(44);

            _form.Designation = dr.IsDBNull(45) ? "" : dr.GetString(45);
            _form.NameOfTheOrganization = dr.IsDBNull(46) ? "" : dr.GetString(46);
            _form.University = dr.IsDBNull(47) ? "" : dr.GetString(47);
            _form.PeriodFrom = dr.IsDBNull(48) ? "" : dr.GetString(48);
            _form.PeriodTo = dr.IsDBNull(49) ? "" : dr.GetString(49);

            _form.NameOfTheCollege = dr.IsDBNull(50) ? "" : dr.GetString(50);
            _form.QualifiyingDegree = dr.IsDBNull(51) ? "" : dr.GetString(51);
            _form.Specialization = dr.IsDBNull(52) ? "" : dr.GetString(52);
            _form.AffiliatingUniversity = dr.IsDBNull(53) ? "" : dr.GetString(53);
            _form.MonthAndYearOfPassing = dr.IsDBNull(54) ? "" : dr.GetString(54);
            _form.AveragePercentageOfMarks = dr.IsDBNull(55) ? "" : dr.GetString(55);

            _form.PaymentMode = dr.IsDBNull(56) ? "" : dr.GetString(56);
            _form.Fees = dr.IsDBNull(57) ? "" : dr.GetString(57);
            _form.PostedDate = dr.IsDBNull(58) ? new DateTime() : dr.GetDateTime(58);

            _form.BillNo = dr.IsDBNull(59) ? "" : dr.GetString(59);
            _form.BillDate = dr.IsDBNull(60) ? new DateTime() : dr.GetDateTime(60);



        }
        return _form;

    }

    public bool Validate()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spUserValidateForResearch", con);

        cmd.Parameters.AddWithValue("@UserName", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@Password", this.MobileNo);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        int rows = int.Parse(cmd.ExecuteScalar().ToString());
        return rows > 0 ? true : false;
    }

    public DataTable Printdetails()
    {
        ResearchApplication _form = new ResearchApplication();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchPrintApplication", con);

        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;


    }

    public DataTable PrintExcel(string ApplicationNo)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchPrintApplications", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;


    }

    public DataTable AdmissionList()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchList201718", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);

        return dtAdmissionList;
    }

    public bool ISResearchStudentExist(string EmailId)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchStudentExists", con);

        cmd.Parameters.AddWithValue("@EmailID", EmailId);

        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        int rows = int.Parse(cmd.ExecuteScalar().ToString());
        return rows > 0 ? true : false;
    }

    public bool IsBillNoAlreadyRegister(string ApplicaitonNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spBillNoIsRegistered", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicaitonNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

    }

    public DataTable ListByDate(DateTime FromDate, DateTime ToDate)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spGetResearchByDate", con);
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

        SqlCommand cmd = new SqlCommand("spResearchAdmissionList", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        dpt.Fill(dt);
        return dt;
    }

    
    public DataTable ListbyCourse(string Course)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchAdminListByCourse", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@Branch", Course);

        dpt.Fill(dt);

        return dt;

    }

    public DataTable ExportByCourse(string Course)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spExportResearchByCourse", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@Branch", Course);

        dpt.Fill(dt);

        return dt;

    }


    public DataTable ListbyPayment(string payment)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchAdminListByPayment", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@PaymentMode", payment);

        dpt.Fill(dt);

        return dt;

    }


    public DataTable ExportByPayment(string payment)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spExportResearchByPayment", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@PaymentMode", payment);

        dpt.Fill(dt);

        return dt;

    }

    public DataTable ExportByDate(DateTime FromDate, DateTime ToDate)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spExportResearchByDate", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        dpt.Fill(dt);
        return dt;
    }

    public DataTable ListbyApplicationNo(string ApplicationNo)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchListByApplicationNo", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        dpt.Fill(dt);

        return dt;

    }

    public DataTable ExportbyApplicationNo(string ApplicationNo)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchListByApplicationNo", con);
        cmd.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);

        dpt.Fill(dt);

        return dt;

    }
    public int ApplicationRegisterModify()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchApplicationCreateModify", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@NameOfTheApplicant", this.NameOfTheApplicant);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@ModeOfStudy", this.ModeOfStudy);
        cmd.Parameters.AddWithValue("@MobileNo", this.MobileNo);
        cmd.Parameters.AddWithValue("@EmailID", this.EmailId);
        cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
        cmd.Parameters.AddWithValue("@Branch", this.Branch);
        cmd.Parameters.AddWithValue("@BoardAreaOfResearch", this.BoardAreaOfResearch);
        cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
        cmd.Parameters.AddWithValue("@RegistrationDate", this.PostedDate);

        int createForm = int.Parse(cmd.ExecuteNonQuery().ToString());

        return createForm;
    }
}