using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for research_scholars
/// </summary>
[WebService(Namespace = "http://pmu.edu/api/research-scholars.asmx")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class research_scholars : System.Web.Services.WebService
{
    string _ConnectionString = "";

    public research_scholars()
    {
        _ConnectionString = ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    [WebMethod]
    public PagedResult<ResearchCourse> ResearchCourseList()
    {
        List<ResearchCourse> _CourseList = new List<ResearchCourse>();

        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Bio-Chemistry" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Bio-Technology" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Chemistry" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Commerce" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Computer Science" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Economics" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Education" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "English" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Environmental Science" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Management Studies" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Mathematics" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Periyar Thought" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Physics" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Political Science" });
        _CourseList.Add(new ResearchCourse() { CourseName = "M.Phil", Department = "Social Work" });


        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Architecture" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Bio-Technology" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Civil Engineering" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Computer Applications" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Computer Science and Engineering" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Chemistry" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Chemical Engineering" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Electrical and Electronics Engineering" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Electronics and Communication Engineering" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "English" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Education" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Information Technology" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Management Studies" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Mathematics" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Mechanical Engineering" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Physics" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Social Work" });
        _CourseList.Add(new ResearchCourse() { CourseName = "Ph.D", Department = "Dr.Kalaignar M.Karunanidhi Centre for Political Science" });

        return new PagedResult<ResearchCourse>(_CourseList, 1, _CourseList.Count, _CourseList.Count);
    }


    [WebMethod]
    public PagedResult<ResearchApplicant> ListAll()
    {
        SqlConnection con = new SqlConnection(_ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchScholarList201718", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        DataTable dtApplicantList = new DataTable();
        dpt.Fill(dtApplicantList);

        // Select the customers based on paging parameters
        IEnumerable<ResearchApplicant>
            _ApplicantsList = (from _applicant in dtApplicantList.AsEnumerable()
                               select new ResearchApplicant()
                               {
                                   ApplicationNo = _applicant["ApplicationNo"].ToString(),
                                   AppliedFor = _applicant["ApplicationFor"].ToString(),
                                   Branch = _applicant["Branch"].ToString(),
                                   ResearchArea = _applicant["AreaOfReserch"].ToString(),
                                   ModeOfStudy = _applicant["ModeOfStudy"].ToString(),

                                   ApplicantName = _applicant["NameOfTheApplicant"].ToString(),
                                   Gender = _applicant["Gender"].ToString(),
                                   DateOfBirth = _applicant["DateOfBirth"].ToString(),
                                   PlaceOfBirth = _applicant["PlaceOfBirth"].ToString(),
                                   PresentAddress = _applicant["CommunicationAddress"].ToString(),
                                   PermanentAddress = _applicant["PermanentAddress"].ToString(),

                                   District = _applicant["District"].ToString(),
                                   State = _applicant["State"].ToString(),
                                   Country = _applicant["Country"].ToString(),
                                   PostalCode = _applicant["Pincode"].ToString(),
                                   MobileNo = _applicant["MobileNo"].ToString(),
                                   EmailId = _applicant["EmailId"].ToString(),
                                   TelephoneNo = _applicant["TelephoneNo"].ToString(),

                                   Nationality = _applicant["Nationality"].ToString(),
                                   Caste = _applicant["Caste"].ToString(),
                                   Community = _applicant["Community"].ToString(),
                                   Religion = _applicant["Religion"].ToString(),
                                   MotherTongue = _applicant["MotherTounge"].ToString(),
                                   BloodGroup = _applicant["BloodGroup"].ToString(),
                                   MaitalStatus = _applicant["MaritalStatus"].ToString(),
                                   DifferentlyAbledPerson = _applicant["PersonWithDisability"].ToString(),
                                   MotherName = _applicant["MotherName"].ToString(),
                                   FatherName = _applicant["FatherName"].ToString(),
                                   CountryInWhichQualified = _applicant["CountryInWhichQualified"].ToString(),
                                   PresentAnnualIncome = _applicant["AverageMonthlyIncome"].ToString(),

                                   HostelRequired = _applicant["HostelRequired"].ToString(),
                                   SponsorCandidate = _applicant["SponsoredCandidate"].ToString(),

                                   TypeOfEmployment = _applicant["TypeOfEmployee"].ToString(),
                                   NatureOfWork = _applicant["NatureOfWork"].ToString(),
                                   NameOfTheEmployer = _applicant["NameOfTheEmployer"].ToString(),
                                   TotalExperience = _applicant["TotalExperience"].ToString(),
                                   AverageIncome = _applicant["AverageMonthlyIncome"].ToString(),
                                   PaperPublished = _applicant["PaperPublished"].ToString(),
                                   AadhaarNo = _applicant["AadhaarCardNo"].ToString(),

                                   PaymentMode = _applicant["PaymentMode"].ToString(),
                                   Fee = _applicant["Fees"].ToString(),
                                   CashPaymentBillNo = _applicant["BillNo"].ToString(),
                                   CashPaymentBillDate = _applicant["BillDate"].ToString(),
                                   AppliedDate = _applicant["AppliedDate"].ToString()

                               }).ToList();


        con.Close();
        return (new PagedResult<ResearchApplicant>(_ApplicantsList, 1, _ApplicantsList.Count(), _ApplicantsList.Count()));
    }

    [WebMethod]
    public PagedResult<ResearchApplicant> ListByPage(int PageNo, int RecordsPerPage)
    {
        SqlConnection con = new SqlConnection(_ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchScholarList201718", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        DataTable dtApplicantList = new DataTable();
        dpt.Fill(dtApplicantList);


        // Determine the number of records to skip
        int _RecordsToBeSkip = (PageNo - 1) * RecordsPerPage;

        // Get total number of records
        int _TotalRecords = dtApplicantList.Rows.Count;

        // Select the customers based on paging parameters
        IEnumerable<ResearchApplicant>
            _ApplicantsList = (from _applicant in dtApplicantList.AsEnumerable()
                               select new ResearchApplicant()
                               {
                                   ApplicationNo = _applicant["ApplicationNo"].ToString(),
                                   AppliedFor = _applicant["ApplicationFor"].ToString(),
                                   Branch = _applicant["Branch"].ToString(),
                                   ResearchArea = _applicant["AreaOfReserch"].ToString(),
                                   ModeOfStudy = _applicant["ModeOfStudy"].ToString(),

                                   ApplicantName = _applicant["NameOfTheApplicant"].ToString(),
                                   Gender = _applicant["Gender"].ToString(),
                                   DateOfBirth = _applicant["DateOfBirth"].ToString(),
                                   PlaceOfBirth = _applicant["PlaceOfBirth"].ToString(),
                                   PresentAddress = _applicant["CommunicationAddress"].ToString(),
                                   PermanentAddress = _applicant["PermanentAddress"].ToString(),

                                   District = _applicant["District"].ToString(),
                                   State = _applicant["State"].ToString(),
                                   Country = _applicant["Country"].ToString(),
                                   PostalCode = _applicant["Pincode"].ToString(),
                                   MobileNo = _applicant["MobileNo"].ToString(),
                                   EmailId = _applicant["EmailId"].ToString(),
                                   TelephoneNo = _applicant["TelephoneNo"].ToString(),

                                   Nationality = _applicant["Nationality"].ToString(),
                                   Caste = _applicant["Caste"].ToString(),
                                   Community = _applicant["Community"].ToString(),
                                   Religion = _applicant["Religion"].ToString(),
                                   MotherTongue = _applicant["MotherTounge"].ToString(),
                                   BloodGroup = _applicant["BloodGroup"].ToString(),
                                   MaitalStatus = _applicant["MaritalStatus"].ToString(),
                                   DifferentlyAbledPerson = _applicant["PersonWithDisability"].ToString(),
                                   MotherName = _applicant["MotherName"].ToString(),
                                   FatherName = _applicant["FatherName"].ToString(),
                                   CountryInWhichQualified = _applicant["CountryInWhichQualified"].ToString(),
                                   PresentAnnualIncome = _applicant["AverageMonthlyIncome"].ToString(),

                                   HostelRequired = _applicant["HostelRequired"].ToString(),
                                   SponsorCandidate = _applicant["SponsoredCandidate"].ToString(),

                                   TypeOfEmployment = _applicant["TypeOfEmployee"].ToString(),
                                   NatureOfWork = _applicant["NatureOfWork"].ToString(),
                                   NameOfTheEmployer = _applicant["NameOfTheEmployer"].ToString(),
                                   TotalExperience = _applicant["TotalExperience"].ToString(),
                                   AverageIncome = _applicant["AverageMonthlyIncome"].ToString(),
                                   PaperPublished = _applicant["PaperPublished"].ToString(),
                                   AadhaarNo = _applicant["AadhaarCardNo"].ToString(),

                                   PaymentMode = _applicant["PaymentMode"].ToString(),
                                   Fee = _applicant["Fees"].ToString(),
                                   CashPaymentBillNo = _applicant["BillNo"].ToString(),
                                   CashPaymentBillDate = _applicant["BillDate"].ToString(),
                                   AppliedDate = _applicant["AppliedDate"].ToString()

                               }).Skip(_RecordsToBeSkip).Take(RecordsPerPage).ToList();


        con.Close();
        return (new PagedResult<ResearchApplicant>(_ApplicantsList, PageNo, RecordsPerPage, _TotalRecords));
    }

    [WebMethod]
    public PagedResult<ResearchApplicant> ListByCourse(string CourseName)
    {
        SqlConnection con = new SqlConnection(_ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchScholarList201718ByCourse", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@CourseName", CourseName);
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        DataTable dtApplicantList = new DataTable();
        dpt.Fill(dtApplicantList);

        // Select the customers based on paging parameters
        IEnumerable<ResearchApplicant>
            _ApplicantsList = (from _applicant in dtApplicantList.AsEnumerable()
                               select new ResearchApplicant()
                               {
                                   ApplicationNo = _applicant["ApplicationNo"].ToString(),
                                   AppliedFor = _applicant["ApplicationFor"].ToString(),
                                   Branch = _applicant["Branch"].ToString(),
                                   ResearchArea = _applicant["AreaOfReserch"].ToString(),
                                   ModeOfStudy = _applicant["ModeOfStudy"].ToString(),

                                   ApplicantName = _applicant["NameOfTheApplicant"].ToString(),
                                   Gender = _applicant["Gender"].ToString(),
                                   DateOfBirth = _applicant["DateOfBirth"].ToString(),
                                   PlaceOfBirth = _applicant["PlaceOfBirth"].ToString(),
                                   PresentAddress = _applicant["CommunicationAddress"].ToString(),
                                   PermanentAddress = _applicant["PermanentAddress"].ToString(),

                                   District = _applicant["District"].ToString(),
                                   State = _applicant["State"].ToString(),
                                   Country = _applicant["Country"].ToString(),
                                   PostalCode = _applicant["Pincode"].ToString(),
                                   MobileNo = _applicant["MobileNo"].ToString(),
                                   EmailId = _applicant["EmailId"].ToString(),
                                   TelephoneNo = _applicant["TelephoneNo"].ToString(),

                                   Nationality = _applicant["Nationality"].ToString(),
                                   Caste = _applicant["Caste"].ToString(),
                                   Community = _applicant["Community"].ToString(),
                                   Religion = _applicant["Religion"].ToString(),
                                   MotherTongue = _applicant["MotherTounge"].ToString(),
                                   BloodGroup = _applicant["BloodGroup"].ToString(),
                                   MaitalStatus = _applicant["MaritalStatus"].ToString(),
                                   DifferentlyAbledPerson = _applicant["PersonWithDisability"].ToString(),
                                   MotherName = _applicant["MotherName"].ToString(),
                                   FatherName = _applicant["FatherName"].ToString(),
                                   CountryInWhichQualified = _applicant["CountryInWhichQualified"].ToString(),
                                   PresentAnnualIncome = _applicant["AverageMonthlyIncome"].ToString(),

                                   HostelRequired = _applicant["HostelRequired"].ToString(),
                                   SponsorCandidate = _applicant["SponsoredCandidate"].ToString(),

                                   TypeOfEmployment = _applicant["TypeOfEmployee"].ToString(),
                                   NatureOfWork = _applicant["NatureOfWork"].ToString(),
                                   NameOfTheEmployer = _applicant["NameOfTheEmployer"].ToString(),
                                   TotalExperience = _applicant["TotalExperience"].ToString(),
                                   AverageIncome = _applicant["AverageMonthlyIncome"].ToString(),
                                   PaperPublished = _applicant["PaperPublished"].ToString(),
                                   AadhaarNo = _applicant["AadhaarCardNo"].ToString(),

                                   PaymentMode = _applicant["PaymentMode"].ToString(),
                                   Fee = _applicant["Fees"].ToString(),
                                   CashPaymentBillNo = _applicant["BillNo"].ToString(),
                                   CashPaymentBillDate = _applicant["BillDate"].ToString(),
                                   AppliedDate = _applicant["AppliedDate"].ToString()

                               }).ToList();


        con.Close();
        return (new PagedResult<ResearchApplicant>(_ApplicantsList, 1, _ApplicantsList.Count(), _ApplicantsList.Count()));
    }

    [WebMethod]
    public ResearchApplicant ResearchApplicantDetails(string ApplicationNo)
    {
        ResearchApplicant _Applicant = new global::ResearchApplicant();

        SqlConnection con = new SqlConnection(_ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spResearchScholarListSingle201718", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            _Applicant.ApplicationNo = dr.IsDBNull(0) ? "" : dr.GetString(0);
            _Applicant.AppliedFor = dr.IsDBNull(1) ? "" : dr.GetString(1);
            _Applicant.Branch = dr.IsDBNull(2) ? "" : dr.GetString(2);
            _Applicant.ResearchArea = dr.IsDBNull(3) ? "" : dr.GetString(3);
            _Applicant.ModeOfStudy = dr.IsDBNull(4) ? "" : dr.GetString(4);

            _Applicant.ApplicantName = dr.IsDBNull(5) ? "" : dr.GetString(5);
            _Applicant.DateOfBirth = dr.IsDBNull(6) ? "" : dr.GetDateTime(6).ToString();

            _Applicant.MobileNo = dr.IsDBNull(7) ? "" : dr.GetString(7);
            _Applicant.EmailId = dr.IsDBNull(8) ? "" : dr.GetString(8);

            _Applicant.Gender = dr.IsDBNull(9) ? "" : dr.GetString(9);
            _Applicant.PlaceOfBirth = dr.IsDBNull(11) ? "" : dr.GetString(11);

            _Applicant.PresentAddress = dr.IsDBNull(12) ? "" : dr.GetString(12);
            _Applicant.PermanentAddress = dr.IsDBNull(13) ? "" : dr.GetString(13);

            _Applicant.District = dr.IsDBNull(14) ? "" : dr.GetString(14);
            _Applicant.State = dr.IsDBNull(15) ? "" : dr.GetString(15);
            _Applicant.Country = dr.IsDBNull(16) ? "" : dr.GetString(16);
            _Applicant.PostalCode = dr.IsDBNull(17) ? "" : dr.GetString(17);
            _Applicant.TelephoneNo = dr.IsDBNull(18) ? "" : dr.GetString(18);

            _Applicant.Nationality = dr.IsDBNull(19) ? "" : dr.GetString(19);
            _Applicant.Caste = dr.IsDBNull(20) ? "" : dr.GetString(20);
            _Applicant.Community = dr.IsDBNull(21) ? "" : dr.GetString(21);
            _Applicant.Religion = dr.IsDBNull(22) ? "" : dr.GetString(22);
            _Applicant.MotherTongue = dr.IsDBNull(23) ? "" : dr.GetString(23);
            _Applicant.BloodGroup = dr.IsDBNull(24) ? "" : dr.GetString(24);
            _Applicant.MaitalStatus = dr.IsDBNull(25) ? "" : dr.GetString(25);
            _Applicant.DifferentlyAbledPerson = dr.IsDBNull(26) ? "" : dr.GetString(26);
            _Applicant.MotherName = dr.IsDBNull(27) ? "" : dr.GetString(27);
            _Applicant.FatherName = dr.IsDBNull(28) ? "" : dr.GetString(28);
            _Applicant.CountryInWhichQualified = dr.IsDBNull(29) ? "" : dr.GetString(29);
            _Applicant.PresentAnnualIncome = dr.IsDBNull(30) ? "" : dr.GetString(30);

            _Applicant.HostelRequired = dr.IsDBNull(31) ? "" : dr.GetString(31);
            _Applicant.SponsorCandidate = dr.IsDBNull(32) ? "" : dr.GetString(32);

            _Applicant.TypeOfEmployment = dr.IsDBNull(33) ? "" : dr.GetString(33);
            _Applicant.NatureOfWork = dr.IsDBNull(34) ? "" : dr.GetString(34);
            _Applicant.NameOfTheEmployer = dr.IsDBNull(35) ? "" : dr.GetString(35);
            _Applicant.TotalExperience = dr.IsDBNull(36) ? "" : dr.GetString(36);
            _Applicant.AverageIncome = dr.IsDBNull(30) ? "" : dr.GetString(30);
            _Applicant.PaperPublished = dr.IsDBNull(37) ? "" : dr.GetString(37);
            _Applicant.AadhaarNo = dr.IsDBNull(38) ? "" : dr.GetString(38);

            _Applicant.PaymentMode = dr.IsDBNull(39) ? "" : dr.GetString(39);
            _Applicant.Fee = dr.IsDBNull(40) ? "" : dr.GetString(40);
            _Applicant.CashPaymentBillNo = dr.IsDBNull(41) ? "" : dr.GetString(41);
            _Applicant.CashPaymentBillDate = dr.IsDBNull(42) ? "" : dr.GetString(42);
            _Applicant.AppliedDate = dr.IsDBNull(43) ? "" : dr.GetDateTime(43).ToString();
        }

        con.Close();
        con.Open();
        cmd = new SqlCommand("spProfessionalDetailsView", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
        DataTable dtExperiences = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        dpt.Fill(dtExperiences);

        _Applicant.ProfessionalExperiences = new ProfessionalExperience[dtExperiences.Rows.Count];
        for (int i = 0; i < dtExperiences.Rows.Count; i++)
        {
            _Applicant.ProfessionalExperiences[i] = new ProfessionalExperience();
            _Applicant.ProfessionalExperiences[i].NameOfTheOrganization = dtExperiences.Rows[i].ItemArray[2].ToString();
            _Applicant.ProfessionalExperiences[i].Designation = dtExperiences.Rows[i].ItemArray[3].ToString();
            _Applicant.ProfessionalExperiences[i].NameOfTheCollege = dtExperiences.Rows[i].ItemArray[4].ToString();
            _Applicant.ProfessionalExperiences[i].PeriodFrom = dtExperiences.Rows[i].ItemArray[5].ToString();
            _Applicant.ProfessionalExperiences[i].PeriodTill = dtExperiences.Rows[i].ItemArray[6].ToString();
        }



        con.Close();
        con.Open();
        cmd = new SqlCommand("spResearchDetailsView", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
        DataTable dtEducations = new DataTable();
        dpt = new SqlDataAdapter(cmd);
        dpt.Fill(dtEducations);

        _Applicant.EducationDetails = new Education[dtEducations.Rows.Count];
        for (int i = 0; i < dtEducations.Rows.Count; i++)
        {
            _Applicant.EducationDetails[i] = new Education();
            _Applicant.EducationDetails[i].QualifyingDegree = dtEducations.Rows[i].ItemArray[2].ToString();
            _Applicant.EducationDetails[i].Specialization = dtEducations.Rows[i].ItemArray[3].ToString();
            _Applicant.EducationDetails[i].NameOfTheCollege = dtEducations.Rows[i].ItemArray[4].ToString();
            _Applicant.EducationDetails[i].AffiliatingUniversity = dtEducations.Rows[i].ItemArray[5].ToString();
            _Applicant.EducationDetails[i].MonthAndYearOfPassing = dtEducations.Rows[i].ItemArray[6].ToString();
            _Applicant.EducationDetails[i].PercentageOfMarks = dtEducations.Rows[i].ItemArray[7].ToString();
        }

        con.Close();
        return _Applicant;
    }

}
