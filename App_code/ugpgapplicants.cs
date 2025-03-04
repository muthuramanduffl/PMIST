using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for ugpgadmission
/// </summary>
[WebService(Namespace = "http://pmu.edu/api/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class ugpgapplicants : System.Web.Services.WebService
{
    string _ConnectionString = "";

    public ugpgapplicants()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 

        _ConnectionString = ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;
    }


    [WebMethod]
    public PagedResult<UGPGApplicant> ListAll()
    {
        SqlConnection con = new SqlConnection(_ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdmissionList201718ForAPI", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        DataTable dtApplicantList = new DataTable();
        dpt.Fill(dtApplicantList);

        // Select the customers based on paging parameters
        IEnumerable<UGPGApplicant> list = (from _applicant in dtApplicantList.AsEnumerable()
                                           select new UGPGApplicant()
                                           {
                                               ApplicationNo = _applicant["ApplicationNo"].ToString(),
                                               ApplicantName = _applicant["NameOfApplicant"].ToString(),
                                               AppliedFor = _applicant["ApplicationFor"].ToString(),
                                               MobileNo = _applicant["MobileNo"].ToString(),
                                               EmailId = _applicant["EmailId"].ToString(),
                                               Gender = _applicant["Gender"].ToString(),
                                               DateOfBirth = _applicant["DateOfBirth"].ToString(),
                                               MotherTongue = _applicant["MotherTongue"].ToString(),
                                               Nationality = _applicant["Nationality"].ToString(),
                                               BloodGroup = _applicant["BloodGroup"].ToString(),
                                               Community = _applicant["Community"].ToString(),
                                               Religion = _applicant["Religion"].ToString(),
                                               MotherName = _applicant["MotherName"].ToString(),
                                               FatherName = _applicant["FatherName"].ToString(),
                                               CommunicationAddress = _applicant["CommunicationAddress"].ToString(),
                                               PermanentAddress = _applicant["PermanentAddress"].ToString(),
                                               ParentOccupation = _applicant["ParentsOccupation"].ToString(),
                                               PatentAnnualIncome = _applicant["AnnualIncome"].ToString(),
                                               CutOffMarks = _applicant["CutOffMarks"].ToString(),
                                               EligibilityMarks = _applicant["Eligibility"].ToString(),
                                               NATAScore = _applicant["NataScore"].ToString(),
                                               UNIGAUGEScore = _applicant["UniGaugeScore"].ToString(),
                                               HostelRequirement = _applicant["HostelRequired"].ToString(),
                                               AchievementInSport = _applicant["AchivementInSports"].ToString(),
                                               AchievementSportName = _applicant["AchievementSportName"].ToString(),
                                               AchievementSportLevel = _applicant["AchievementSportLevel"].ToString(),
                                               AchievementSportMedalist = _applicant["AchievementSportMedal"].ToString(),
                                               PaymentMode = _applicant["ModeOfPayment"].ToString(),
                                               Fee = _applicant["Fees"].ToString(),
                                               CashPaymentBillNo = _applicant["BillNo"].ToString(),
                                               CashPaymentBillDate = _applicant["BillDate"].ToString(),

                                               SSLCBoard = _applicant["SslcBoardOfExamination"].ToString(),
                                               SSLCSchoolName = _applicant["SslcSchoolName"].ToString(),
                                               SSLCMediumOfInstruction = _applicant["SslcMediumOfInstruction"].ToString(),
                                               SSLCRegistrationNo = _applicant["SslcRegistrationNo"].ToString(),
                                               SSLCNoOfAttempts = _applicant["SslcNoOfAttempt"].ToString(),
                                               SSLCMonthAndYearOfPassing = _applicant["SslcYearOfPassing"].ToString(),
                                               SSLCPercentageOfMarks = _applicant["SslcPercentage"].ToString(),

                                               HSCBoard = _applicant["HscBoardOfExamination"].ToString(),
                                               HSCSchoolName = _applicant["HscSchoolName"].ToString(),
                                               HSCMediumOfInstruction = _applicant["HscMediumOfInstruction"].ToString(),
                                               HSCRegistrationNo = _applicant["HscRegistrationNo"].ToString(),
                                               HSCNoOfAttempts = _applicant["HscNoOfAttempt"].ToString(),
                                               HSCMonthAndYearOfPassing = _applicant["HscYearOfPassing"].ToString(),
                                               HSCPercentageOfMarks = _applicant["HscPercentage"].ToString(),
                                               //HSCSubjectMarks = _applicant["SubjectMarks"].ToString(),
                                               AppliedDate = _applicant["AppliedOn"].ToString()


                                           }).ToList();

        con.Close();
        con.Open();
        cmd = new SqlCommand("spHscMarkListForAPI", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        dpt = new SqlDataAdapter(cmd);
        DataTable dtHscMarks = new DataTable();
        dpt.Fill(dtHscMarks);

        foreach (UGPGApplicant _UgPGApplicant in list)
        {
            try
            {
                DataTable dtTemp = dtHscMarks.AsEnumerable().Where(row => row.Field<string>("ApplicationNo").Equals(_UgPGApplicant.ApplicationNo)).CopyToDataTable();
                List<string> _HscMark = new List<string>();

                _UgPGApplicant.HSCSubjectMarks = new HSCMark[dtTemp.Rows.Count];
                for (int i = 0; i < dtTemp.Rows.Count; i++)
                {
                    _UgPGApplicant.HSCSubjectMarks[i] = new HSCMark();
                    _UgPGApplicant.HSCSubjectMarks[i].SubjectName = dtTemp.Rows[i].ItemArray[1].ToString();
                    _UgPGApplicant.HSCSubjectMarks[i].SubjectMark = dtTemp.Rows[i].ItemArray[2].ToString();
                }
            }
            catch (Exception)
            {
            }
        }
        con.Close();
        return (new PagedResult<UGPGApplicant>(list, 1, list.Count(), list.Count()));
    }

    [WebMethod]
    public PagedResult<UGPGApplicant> ListByPage(int PageNo, int RecordsPerPage)
    {
        SqlConnection con = new SqlConnection(_ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spAdmissionList201718ForAPI", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        DataTable dtApplicantList = new DataTable();
        dpt.Fill(dtApplicantList);

        // Determine the number of records to skip
        int _RecordsToBeSkip = (PageNo - 1) * RecordsPerPage;

        // Get total number of records
        int _TotalRecords = dtApplicantList.Rows.Count;

        // Select the customers based on paging parameters
        IEnumerable<UGPGApplicant>
            list = (from _applicant in dtApplicantList.AsEnumerable()
                    select new UGPGApplicant()
                    {
                        ApplicationNo = _applicant["ApplicationNo"].ToString(),
                        ApplicantName = _applicant["NameOfApplicant"].ToString(),
                        AppliedFor = _applicant["ApplicationFor"].ToString(),
                        MobileNo = _applicant["MobileNo"].ToString(),
                        EmailId = _applicant["EmailId"].ToString(),
                        Gender = _applicant["Gender"].ToString(),
                        DateOfBirth = _applicant["DateOfBirth"].ToString(),
                        MotherTongue = _applicant["MotherTongue"].ToString(),
                        Nationality = _applicant["Nationality"].ToString(),
                        BloodGroup = _applicant["BloodGroup"].ToString(),
                        Community = _applicant["Community"].ToString(),
                        Religion = _applicant["Religion"].ToString(),
                        MotherName = _applicant["MotherName"].ToString(),
                        FatherName = _applicant["FatherName"].ToString(),
                        CommunicationAddress = _applicant["CommunicationAddress"].ToString(),
                        PermanentAddress = _applicant["PermanentAddress"].ToString(),
                        ParentOccupation = _applicant["ParentsOccupation"].ToString(),
                        PatentAnnualIncome = _applicant["AnnualIncome"].ToString(),
                        CutOffMarks = _applicant["CutOffMarks"].ToString(),
                        EligibilityMarks = _applicant["Eligibility"].ToString(),
                        NATAScore = _applicant["NataScore"].ToString(),
                        UNIGAUGEScore = _applicant["UniGaugeScore"].ToString(),
                        HostelRequirement = _applicant["HostelRequired"].ToString(),
                        AchievementInSport = _applicant["AchivementInSports"].ToString(),
                        AchievementSportName = _applicant["AchievementSportName"].ToString(),
                        AchievementSportLevel = _applicant["AchievementSportLevel"].ToString(),
                        AchievementSportMedalist = _applicant["AchievementSportMedal"].ToString(),
                        PaymentMode = _applicant["ModeOfPayment"].ToString(),
                        Fee = _applicant["Fees"].ToString(),
                        CashPaymentBillNo = _applicant["BillNo"].ToString(),
                        CashPaymentBillDate = _applicant["BillDate"].ToString(),

                        SSLCBoard = _applicant["SslcBoardOfExamination"].ToString(),
                        SSLCSchoolName = _applicant["SslcSchoolName"].ToString(),
                        SSLCMediumOfInstruction = _applicant["SslcMediumOfInstruction"].ToString(),
                        SSLCRegistrationNo = _applicant["SslcRegistrationNo"].ToString(),
                        SSLCNoOfAttempts = _applicant["SslcNoOfAttempt"].ToString(),
                        SSLCMonthAndYearOfPassing = _applicant["SslcYearOfPassing"].ToString(),
                        SSLCPercentageOfMarks = _applicant["SslcPercentage"].ToString(),

                        HSCBoard = _applicant["HscBoardOfExamination"].ToString(),
                        HSCSchoolName = _applicant["HscSchoolName"].ToString(),
                        HSCMediumOfInstruction = _applicant["HscMediumOfInstruction"].ToString(),
                        HSCRegistrationNo = _applicant["HscRegistrationNo"].ToString(),
                        HSCNoOfAttempts = _applicant["HscNoOfAttempt"].ToString(),
                        HSCMonthAndYearOfPassing = _applicant["HscYearOfPassing"].ToString(),
                        HSCPercentageOfMarks = _applicant["HscPercentage"].ToString(),
                        //HSCSubjectMarks = _applicant["SubjectMarks"].ToString(),
                        AppliedDate = _applicant["AppliedOn"].ToString()


                    }).Skip(_RecordsToBeSkip).Take(RecordsPerPage).ToList();

        con.Close();
        con.Open();
        cmd = new SqlCommand("spHscMarkListForAPI", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        dpt = new SqlDataAdapter(cmd);
        DataTable dtHscMarks = new DataTable();
        dpt.Fill(dtHscMarks);

        foreach (UGPGApplicant _UgPGApplicant in list)
        {
            try
            {
                DataTable dtTemp = dtHscMarks.AsEnumerable().Where(row => row.Field<string>("ApplicationNo").Equals(_UgPGApplicant.ApplicationNo)).CopyToDataTable();
                List<string> _HscMark = new List<string>();

                _UgPGApplicant.HSCSubjectMarks = new HSCMark[dtTemp.Rows.Count];
                for (int i = 0; i < dtTemp.Rows.Count; i++)
                {
                    _UgPGApplicant.HSCSubjectMarks[i] = new HSCMark();
                    _UgPGApplicant.HSCSubjectMarks[i].SubjectName = dtTemp.Rows[i].ItemArray[1].ToString();
                    _UgPGApplicant.HSCSubjectMarks[i].SubjectMark = dtTemp.Rows[i].ItemArray[2].ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        con.Close();
        return (new PagedResult<UGPGApplicant>(list, PageNo, RecordsPerPage, _TotalRecords));
    }

    [WebMethod]
    public PagedResult<UGPGApplicant> ListByCourse(string CourseName)
    {
        SqlConnection con = new SqlConnection(_ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spUGPGApplicationListByCourse", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@CourseName", CourseName);
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        DataTable dtApplicantList = new DataTable();
        dpt.Fill(dtApplicantList);

        // Select the customers based on paging parameters
        IEnumerable<UGPGApplicant> list = (from _applicant in dtApplicantList.AsEnumerable()
                                           select new UGPGApplicant()
                                           {
                                               ApplicationNo = _applicant["ApplicationNo"].ToString(),
                                               ApplicantName = _applicant["NameOfApplicant"].ToString(),
                                               AppliedFor = _applicant["ApplicationFor"].ToString(),
                                               MobileNo = _applicant["MobileNo"].ToString(),
                                               EmailId = _applicant["EmailId"].ToString(),
                                               Gender = _applicant["Gender"].ToString(),
                                               DateOfBirth = _applicant["DateOfBirth"].ToString(),
                                               MotherTongue = _applicant["MotherTongue"].ToString(),
                                               Nationality = _applicant["Nationality"].ToString(),
                                               BloodGroup = _applicant["BloodGroup"].ToString(),
                                               Community = _applicant["Community"].ToString(),
                                               Religion = _applicant["Religion"].ToString(),
                                               MotherName = _applicant["MotherName"].ToString(),
                                               FatherName = _applicant["FatherName"].ToString(),
                                               CommunicationAddress = _applicant["CommunicationAddress"].ToString(),
                                               PermanentAddress = _applicant["PermanentAddress"].ToString(),
                                               ParentOccupation = _applicant["ParentsOccupation"].ToString(),
                                               PatentAnnualIncome = _applicant["AnnualIncome"].ToString(),
                                               CutOffMarks = _applicant["CutOffMarks"].ToString(),
                                               EligibilityMarks = _applicant["Eligibility"].ToString(),
                                               NATAScore = _applicant["NataScore"].ToString(),
                                               UNIGAUGEScore = _applicant["UniGaugeScore"].ToString(),
                                               HostelRequirement = _applicant["HostelRequired"].ToString(),
                                               AchievementInSport = _applicant["AchivementInSports"].ToString(),
                                               AchievementSportName = _applicant["AchievementSportName"].ToString(),
                                               AchievementSportLevel = _applicant["AchievementSportLevel"].ToString(),
                                               AchievementSportMedalist = _applicant["AchievementSportMedal"].ToString(),
                                               PaymentMode = _applicant["ModeOfPayment"].ToString(),
                                               Fee = _applicant["Fees"].ToString(),
                                               CashPaymentBillNo = _applicant["BillNo"].ToString(),
                                               CashPaymentBillDate = _applicant["BillDate"].ToString(),

                                               SSLCBoard = _applicant["SslcBoardOfExamination"].ToString(),
                                               SSLCSchoolName = _applicant["SslcSchoolName"].ToString(),
                                               SSLCMediumOfInstruction = _applicant["SslcMediumOfInstruction"].ToString(),
                                               SSLCRegistrationNo = _applicant["SslcRegistrationNo"].ToString(),
                                               SSLCNoOfAttempts = _applicant["SslcNoOfAttempt"].ToString(),
                                               SSLCMonthAndYearOfPassing = _applicant["SslcYearOfPassing"].ToString(),
                                               SSLCPercentageOfMarks = _applicant["SslcPercentage"].ToString(),

                                               HSCBoard = _applicant["HscBoardOfExamination"].ToString(),
                                               HSCSchoolName = _applicant["HscSchoolName"].ToString(),
                                               HSCMediumOfInstruction = _applicant["HscMediumOfInstruction"].ToString(),
                                               HSCRegistrationNo = _applicant["HscRegistrationNo"].ToString(),
                                               HSCNoOfAttempts = _applicant["HscNoOfAttempt"].ToString(),
                                               HSCMonthAndYearOfPassing = _applicant["HscYearOfPassing"].ToString(),
                                               HSCPercentageOfMarks = _applicant["HscPercentage"].ToString(),
                                               //HSCSubjectMarks = _applicant["SubjectMarks"].ToString(),
                                               AppliedDate = _applicant["AppliedOn"].ToString()


                                           }).ToList();


        con.Close();
        con.Open();
        cmd = new SqlCommand("spHscMarkListForAPI", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        dpt = new SqlDataAdapter(cmd);
        DataTable dtHscMarks = new DataTable();
        dpt.Fill(dtHscMarks);

        foreach (UGPGApplicant _UgPGApplicant in list)
        {
            try
            {
                DataTable dtTemp = dtHscMarks.AsEnumerable().Where(row => row.Field<string>("ApplicationNo").Equals(_UgPGApplicant.ApplicationNo)).CopyToDataTable();
                List<string> _HscMark = new List<string>();

                _UgPGApplicant.HSCSubjectMarks = new HSCMark[dtTemp.Rows.Count];
                for (int i = 0; i < dtTemp.Rows.Count; i++)
                {
                    _UgPGApplicant.HSCSubjectMarks[i] = new HSCMark();
                    _UgPGApplicant.HSCSubjectMarks[i].SubjectName = dtTemp.Rows[i].ItemArray[1].ToString();
                    _UgPGApplicant.HSCSubjectMarks[i].SubjectMark = dtTemp.Rows[i].ItemArray[2].ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        con.Close();
        return (new PagedResult<UGPGApplicant>(list, 1, list.Count(), list.Count()));
    }

    [WebMethod]
    public UGPGApplicant ApplicantDetails(string ApplicationNo)
    {
        UGPGApplicant _Applicant = new UGPGApplicant();

        SqlConnection con = new SqlConnection(_ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spUGPGApplicantListSingle", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _Applicant.ApplicationNo = dr.IsDBNull(0) ? "" : dr.GetString(0);
            _Applicant.ApplicantName = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _Applicant.AppliedFor = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _Applicant.MobileNo = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _Applicant.EmailId = dr.IsDBNull(4) ? "" : dr.GetString(4);
            _Applicant.Gender = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _Applicant.DateOfBirth = dr.IsDBNull(6) ? "" : dr.GetDateTime(6).ToString();
            _Applicant.MotherTongue = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _Applicant.Nationality = dr.IsDBNull(8) ? "" : dr.GetString(8);
            _Applicant.BloodGroup = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _Applicant.Community = dr.IsDBNull(10) ? "" : dr.GetString(10);
            _Applicant.Religion = dr.IsDBNull(11) ? "" : dr.GetString(11);
            _Applicant.MotherName = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _Applicant.FatherName = dr.IsDBNull(13) ? "" : dr.GetString(13);
            _Applicant.CommunicationAddress = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _Applicant.PermanentAddress = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _Applicant.ParentOccupation = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _Applicant.PatentAnnualIncome = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _Applicant.CutOffMarks = dr.IsDBNull(18) ? "" : dr.GetString(18);
            _Applicant.EligibilityMarks = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _Applicant.NATAScore = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _Applicant.UNIGAUGEScore = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _Applicant.HostelRequirement = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _Applicant.AchievementInSport = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _Applicant.AchievementSportName = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _Applicant.AchievementSportLevel = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _Applicant.AchievementSportMedalist = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _Applicant.PaymentMode = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _Applicant.Fee = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _Applicant.CashPaymentBillDate = dr.IsDBNull(29) ? "" : dr.GetDateTime(29).ToString();
            _Applicant.CashPaymentBillNo = dr.IsDBNull(30) ? "" : dr.GetString(30);

            _Applicant.SSLCBoard = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _Applicant.SSLCSchoolName = dr.IsDBNull(32) ? "" : dr.GetString(33);
            _Applicant.SSLCMediumOfInstruction = dr.IsDBNull(33) ? "" : dr.GetString(34);
            _Applicant.SSLCRegistrationNo = dr.IsDBNull(34) ? "" : dr.GetString(35);
            _Applicant.SSLCNoOfAttempts = dr.IsDBNull(35) ? "" : dr.GetString(36);
            _Applicant.SSLCMonthAndYearOfPassing = dr.IsDBNull(36) ? "" : dr.GetString(37);
            _Applicant.SSLCPercentageOfMarks = dr.IsDBNull(37) ? "" : dr.GetString(38);

            _Applicant.HSCBoard = dr.IsDBNull(38) ? "" : dr.GetString(39);
            _Applicant.HSCSchoolName = dr.IsDBNull(39) ? "" : dr.GetString(40);
            _Applicant.HSCMediumOfInstruction = dr.IsDBNull(40) ? "" : dr.GetString(41);
            _Applicant.HSCRegistrationNo = dr.IsDBNull(41) ? "" : dr.GetString(42);
            _Applicant.HSCNoOfAttempts = dr.IsDBNull(42) ? "" : dr.GetString(43);
            _Applicant.HSCMonthAndYearOfPassing = dr.IsDBNull(43) ? "" : dr.GetString(43);
            _Applicant.HSCPercentageOfMarks = dr.IsDBNull(44) ? "" : dr.GetString(44);
            //_Applicant.HSCSubjectMarks = dr.IsDBNull(45) ? "" : dr.GetString(45);
            _Applicant.AppliedDate = dr.IsDBNull(46) ? "" : dr.GetDateTime(46).ToString();
        }

        con.Close();
        con.Open();
        cmd = new SqlCommand("spHscMarkListForAPI", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        DataTable dtHscMarks = new DataTable();
        dpt.Fill(dtHscMarks);

        try
        {
            DataTable dtTemp = dtHscMarks.AsEnumerable().Where(row => row.Field<string>("ApplicationNo").Equals(_Applicant.ApplicationNo)).CopyToDataTable();
            List<string> _HscMark = new List<string>();

            _Applicant.HSCSubjectMarks = new HSCMark[dtTemp.Rows.Count];
            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                _Applicant.HSCSubjectMarks[i] = new HSCMark();
                _Applicant.HSCSubjectMarks[i].SubjectName = dtTemp.Rows[i].ItemArray[1].ToString();
                _Applicant.HSCSubjectMarks[i].SubjectMark = dtTemp.Rows[i].ItemArray[2].ToString();
            }
        }
        catch (Exception)
        {
        }

        con.Close();

        con.Close();
        return _Applicant;
    }


    [WebMethod]
    public PagedResult<UGPGCourse> UGPGCourseList()
    {
        SqlConnection con = new SqlConnection(_ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spUGPGCourseListAll", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        DataTable dtCourseList = new DataTable();
        dpt.Fill(dtCourseList);

        // Select the customers based on paging parameters
        IEnumerable<UGPGCourse> _CourseList = (from _applicant in dtCourseList.AsEnumerable()
                                               select new UGPGCourse()
                                               {
                                                   CourseCode = Convert.ToInt32(_applicant["CourseCode"].ToString()),
                                                   CourseName = _applicant["CourseName"].ToString(),
                                                   Department = _applicant["Department"].ToString(),

                                               }).ToList();

        return (new PagedResult<UGPGCourse>(_CourseList, 1, _CourseList.Count(), _CourseList.Count()));
    }

}
