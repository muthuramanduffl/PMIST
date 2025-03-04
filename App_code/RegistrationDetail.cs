using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for RegistrationDetail
/// </summary>
public class RegistrationDetail
{
    #region

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
    public DateTime AddedDateTime { get; set; }

    public string MotherMobileNo { get; set; }
    public string CommunitycentralQuota { get; set; }
    public string SslcSchoolDistrict { get; set; }
    public string HSCSchoolDistrict { get; set; }
    public string SslcSchoolCategory { get; set; }
    public string HSCSchoolCategory { get; set; }
    public string CivicStatusNative { get; set; }
    public string CivicStatusSSLC { get; set; }
    public string CivicStatusHSC { get; set; }
    public string Qualification { get; set; }

    public string Specialisation1 { get; set; }
    public string Specialisation2 { get; set; }
    public string Specialisation3 { get; set; }

    public string PMESEReg { get; set; }
    public string PMESEScore { get; set; }
    public string PMESEExamStatus { get; set; }

    public string DegreeMaxmarks { get; set; }
    public string SslcTotalmarks { get; set; }

    public string Photo { get; set; }
    public string EntranceExam { get; set; }
    public string Admissionlevel { get; set; }

    public string NoOfAttempts { get; set; }
    public string MaxMarks { get; set; }

    #endregion
    public RegistrationDetail()
    {
        //
        // TODO: Add constructor logic here
        //
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

    public string GetBrainSqlConnection()
    {
        string connectionString1 = null;
        try
        {
            connectionString1 = System.Configuration.ConfigurationManager.ConnectionStrings["BRAIN"].ConnectionString;
        }
        catch (Exception ex)
        {
        }
        return connectionString1;
    }


    public string AddQuickForm2024()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        string ApplnNo = string.Empty;
        try
        {
            using (SqlCommand cmd = new SqlCommand("AddQuickForm2024New", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", this.NameOfApplicant);
                cmd.Parameters.AddWithValue("@MobileNo", this.CandidateMobileNo);
                cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
                cmd.Parameters.AddWithValue("@Course", this.Course);
                cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
                cmd.Parameters.AddWithValue("@ApplicationFor", this.ApplicationFor);
                cmd.Parameters.AddWithValue("@Choice", this.Choice);
                cmd.Parameters.AddWithValue("@ChoiceTwo", this.ChoiceTwo);
                cmd.Parameters.AddWithValue("@ChoiceThree", this.ChoiceThree);
                cmd.Parameters.AddWithValue("@CourseType", this.CourseType);
                cmd.Parameters.AddWithValue("@AppliedFrom", this.AppliedFrom);
                cmd.Parameters.AddWithValue("@Scholarship", this.Scholarship);
                cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
                cmd.Parameters.AddWithValue("@FacultySchool", this.FacultySchool);
                cmd.Parameters.AddWithValue("@City", this.City);
                cmd.Parameters.AddWithValue("@District", this.District);
                cmd.Parameters.AddWithValue("@State", this.State);
                cmd.Parameters.AddWithValue("@HSCRegID", this.HscRegistrationNo);

                cmd.Parameters.AddWithValue("@Special1", this.Specialisation1);
                cmd.Parameters.AddWithValue("@Special2", this.Specialisation2);
                cmd.Parameters.AddWithValue("@Special3", this.Specialisation3);

                cmd.Parameters.AddWithValue("@PMESE_Reg", this.PMESEReg);
                cmd.Parameters.AddWithValue("@PMESE_Score", this.PMESEScore);
                cmd.Parameters.AddWithValue("@PMESE_ExamStatus", this.PMESEExamStatus);

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Direction = ParameterDirection.Output;
                int createForm = int.Parse(cmd.ExecuteNonQuery().ToString());

                int ID = Convert.ToInt32(cmd.Parameters["@ID"].Value);

                ApplnNo = GenerateApplicationNo(this.CourseType, this.TextApplicationFor, ID);
                UpdateApplicationNo23(ApplnNo, ID);
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ApplnNo;
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

    public int UpdateApplicationNo23(string ApplnNo, int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("spUpdateApplicationNo23", cnn))
            {
                cnn.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ApplNo", ApplnNo);
                cmd.Parameters.AddWithValue("@Id", ID);
                rowsAffected = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewFacultyname(string stChoice1)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dt = new DataSet();

        try
        {
            using (SqlCommand cmd = new SqlCommand("spGetFacultyName", cnn))
            {
                cnn.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

               
                cmd.Parameters.AddWithValue("@Choice1", stChoice1);
                SqlDataAdapter dpt = new SqlDataAdapter(cmd);
                dpt.Fill(dt);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dt;
    }

    public DataSet ViewRegByEmailId23(string stEmailId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegByEmailId23", cnn))
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

    public DataSet ViewRegByMobileNo23(string stMobileNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegByMobileNo23", cnn))
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

    public DataSet ViewRegByCourseEmailMobileNo(string stEmail, string stMobileNo, string coursemode, string coursetype, string Applnfor)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegByCourseEmailMobileNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Email", stEmail));
                command.Parameters.Add(new SqlParameter("@MobileNo", stMobileNo));
                command.Parameters.Add(new SqlParameter("@coursemode", coursemode));
                command.Parameters.Add(new SqlParameter("@coursetype", coursetype));
                command.Parameters.Add(new SqlParameter("@Applnfor", Applnfor));
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
            cmd.Parameters.AddWithValue("@MotherMobileNo", this.MotherMobileNo);
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
            cmd.Parameters.AddWithValue("@Medal", this.Medal);

            cmd.Parameters.AddWithValue("@NATAScore", this.NATAScore);
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
            cmd.Parameters.AddWithValue("@CivicStatusNative", this.CivicStatusNative);
            cmd.Parameters.AddWithValue("@CivicStatusSSLC", this.CivicStatusSSLC);
            cmd.Parameters.AddWithValue("@CivicStatusHSC", this.CivicStatusHSC);
            cmd.Parameters.AddWithValue("@Qualification", this.Qualification);
            cmd.Parameters.AddWithValue("@DegreeMaxmarks", this.DegreeMaxmarks);

            cmd.Parameters.AddWithValue("@SslcTotalmarks", this.SslcTotalmarks);
            cmd.Parameters.AddWithValue("@Photo", this.Photo);


            rowsAffected = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd = new SqlCommand("spHscMarkDetailsDelete23", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("AddHSCMarksDetails", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (HSCMarks _mark in this.HscMarks)
            {
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
                cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
                cmd.Parameters.AddWithValue("@Board", _mark.Board);
                cmd.Parameters.AddWithValue("@YrOfPassing", _mark.YrOfPassing);
                cmd.Parameters.AddWithValue("@NoOfAttempts", _mark.NoOfAttempts);
                cmd.Parameters.AddWithValue("@MaxMarks", _mark.MaxMarks);
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

    public int InsertError(string method, string message, DateTime dt, string stApplicationNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("AddError", cnn))
            {
                
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
            
                cmd.Parameters.AddWithValue("@ErrorMessage", message);
                cmd.Parameters.AddWithValue("@Method", method);
                cmd.Parameters.AddWithValue("@ErrorDate", dt);
                cmd.Parameters.AddWithValue("@ApplicationNo", stApplicationNo);
                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }

    public RegistrationDetail GetDetails23(string ApplicationNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        RegistrationDetail _form = new RegistrationDetail();

        try
        {
            using (SqlCommand cmd = new SqlCommand("spGetDetailsByApplicationNo23", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
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
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return _form;

    }
    

    public DataSet ViewSchoolsByDistrictID(string stDistrictID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewSchoolsByDistrictID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@DistrictID", stDistrictID));
               
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

    public int UpdateApplicationMasterList()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            SqlCommand cmd = new SqlCommand("UpdateApplicationMasterList", cnn);
            cnn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

           
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
            cmd.Parameters.AddWithValue("@MotherMobileNo", this.MotherMobileNo);
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
            cmd.Parameters.AddWithValue("@Medal", this.Medal);
            cmd.Parameters.AddWithValue("@NATAScore", this.NATAScore);
            cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);
            cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);
            cmd.Parameters.AddWithValue("@FatherOccupation", this.FatherOccupation);
            cmd.Parameters.AddWithValue("@MotherOccupation", this.MotherOccupation);
            cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);
            cmd.Parameters.AddWithValue("@TransportRequired", this.TransportRequired);

            cmd.Parameters.AddWithValue("@CommunitycentralQuota", this.CommunitycentralQuota);
            cmd.Parameters.AddWithValue("@SslcSchoolCategory", this.SslcSchoolCategory);
            cmd.Parameters.AddWithValue("@SslcSchoolDistrict", this.SslcSchoolDistrict);
            cmd.Parameters.AddWithValue("@HSCSchoolCategory", this.HSCSchoolCategory);
            cmd.Parameters.AddWithValue("@HSCSchoolDistrict", this.HSCSchoolDistrict);

            cmd.Parameters.AddWithValue("@CivicStatusNative", this.CivicStatusNative);
            cmd.Parameters.AddWithValue("@CivicStatusSSLC", this.CivicStatusSSLC);
            cmd.Parameters.AddWithValue("@CivicStatusHSC", this.CivicStatusHSC);
            cmd.Parameters.AddWithValue("@Qualification", this.Qualification);
            cmd.Parameters.AddWithValue("@DegreeMaxmarks", this.DegreeMaxmarks);
            cmd.Parameters.AddWithValue("@SslcTotalmarks", this.SslcTotalmarks);

            rowsAffected = int.Parse(cmd.ExecuteNonQuery().ToString());

            // cmd = new SqlCommand("spHscMarkDetailsDelete23", cnn);
            // cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

            cmd.ExecuteNonQuery();

            // cmd = new SqlCommand("AddHSCMarksDetails", cnn);
            // cmd.CommandType = CommandType.StoredProcedure;

            // foreach (HSCMarks _mark in this.HscMarks)
            // {
            //     cmd.Parameters.Clear();

            //     cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            //     cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            //     cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            //     cmd.Parameters.AddWithValue("@Board", _mark.Board);
            //     cmd.Parameters.AddWithValue("@YrOfPassing", _mark.YrOfPassing);
            //     cmd.Parameters.AddWithValue("@NoOfAttempts", _mark.NoOfAttempts);
            //     cmd.Parameters.AddWithValue("@MaxMarks", _mark.MaxMarks);
            //     cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

            //     cmd.ExecuteNonQuery();
            // }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewPMESEDetailsByEmailMobile(string Email,string Mobileno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();

        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewPMESEDetailsByEmailMobile", cnn))
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

    public DataSet ViewRegByEmailMobileNo(string Email, string Mobileno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();

        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewRegByEmailMobileNo", cnn))
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

    public int AddApplicationMasterListBRAIN2024()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetBrainSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            SqlCommand cmd = new SqlCommand("AddApplicationMasterListBRAIN2024", cnn);
            cnn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
            cmd.Parameters.AddWithValue("@NameOfApplicant", this.NameOfApplicant);
            cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
            cmd.Parameters.AddWithValue("@CandidateMobileNo", this.CandidateMobileNo);
            cmd.Parameters.AddWithValue("@WhatsAppNo", this.CandidateWhatsAppNo);

            cmd.Parameters.AddWithValue("@CourseMode", this.CourseType);
            cmd.Parameters.AddWithValue("@CourseType", this.Course);
            cmd.Parameters.AddWithValue("@Choice", this.Choice);
            cmd.Parameters.AddWithValue("@ChoiceTwo", this.ChoiceTwo);
            cmd.Parameters.AddWithValue("@ChoiceThree", this.ChoiceThree);

            cmd.Parameters.AddWithValue("@Scholarship", this.Scholarship);
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
            cmd.Parameters.AddWithValue("@ParentTelephoneNo", this.ParentTelephoneNo);
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
            cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);
            cmd.Parameters.AddWithValue("@HSCSchoolCategory", this.HSCSchoolCategory);

            cmd.Parameters.AddWithValue("@HSCSchoolDistrict", this.HSCSchoolDistrict);
            cmd.Parameters.AddWithValue("@CivicStatusHSC", this.CivicStatusHSC);
            cmd.Parameters.AddWithValue("@Qualification", this.Qualification);
            cmd.Parameters.AddWithValue("@CollegeName", this.CollageName);
            cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);

            cmd.Parameters.AddWithValue("@Degree", this.Degree);
            cmd.Parameters.AddWithValue("@Percentage", this.Percentage);
            cmd.Parameters.AddWithValue("@BoardOfExamination", this.University);
            cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
            cmd.Parameters.AddWithValue("@DegreeMaxmarks", this.DegreeMaxmarks);

            cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);
            cmd.Parameters.AddWithValue("@CutOffMarks", this.CutOffMarks);
            cmd.Parameters.AddWithValue("@Eligibility", this.Eligibility);
            cmd.Parameters.AddWithValue("@ModeOfPayment", this.ModeOfPayment);
            cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);

            cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
            cmd.Parameters.AddWithValue("@Caste", this.Caste);
            cmd.Parameters.AddWithValue("@Religion", this.Religion);
            cmd.Parameters.AddWithValue("@Community", this.Community);
            cmd.Parameters.AddWithValue("@Nationality", this.Nationality);

            cmd.Parameters.AddWithValue("@CommunitycentralQuota", this.CommunitycentralQuota);
            cmd.Parameters.AddWithValue("@CivicStatusNative", this.CivicStatusNative);
            cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
            cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
            cmd.Parameters.AddWithValue("@FatherOccupation", this.FatherOccupation);

            cmd.Parameters.AddWithValue("@MotherOccupation", this.MotherOccupation);
            cmd.Parameters.AddWithValue("@MotherMobileNo", this.MotherMobileNo);
            cmd.Parameters.AddWithValue("@FatherMobileNo", this.ParentMobileNo);
            cmd.Parameters.AddWithValue("@AnnualIncome", this.AnnualIncome);
            cmd.Parameters.AddWithValue("@MotherTongue", this.MotherTongue);

            cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
            cmd.Parameters.AddWithValue("@TransportRequired", this.TransportRequired);
            cmd.Parameters.AddWithValue("@AchivementInSports", this.AchivementInSports);
            cmd.Parameters.AddWithValue("@Level", this.Level);
            cmd.Parameters.AddWithValue("@Game", this.Game);

            cmd.Parameters.AddWithValue("@Medal", this.Medal);
            cmd.Parameters.AddWithValue("@NATAScore", this.NATAScore);
            cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);
            cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
            cmd.Parameters.AddWithValue("@Fees", this.Fees);

            cmd.Parameters.AddWithValue("@Photo", this.Photo);
            cmd.Parameters.AddWithValue("@SslcTotalmarks", this.SslcTotalmarks);

            cmd.Parameters.AddWithValue("@EntranceExam", this.EntranceExam);
            cmd.Parameters.AddWithValue("@ApplicationPayMode", this.ModeOfPayment);
            cmd.Parameters.AddWithValue("@ApplicationFeeDate", this.BillDate);
            cmd.Parameters.AddWithValue("@ApplicationBillNo", this.BillNo);
            cmd.Parameters.AddWithValue("@AdmissionLevel", this.Admissionlevel);
            cmd.Parameters.AddWithValue("@AddedDateTime", this.AddedDateTime);

            cmd.Parameters.AddWithValue("@Special1", this.Specialisation1);
            cmd.Parameters.AddWithValue("@Special2", this.Specialisation2);
            cmd.Parameters.AddWithValue("@Special3", this.Specialisation3);



            cmd.ExecuteNonQuery();
            rowsAffected = int.Parse(cmd.ExecuteNonQuery().ToString());

           // DegreeObtainedMarks

            // rowsAffected = int.Parse(cmd.ExecuteNonQuery().ToString());
            // cmd = new SqlCommand("spHscMarkDetailsDeleteBRAIN", cnn);
            // cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

            // cmd.ExecuteNonQuery();
            // cmd = new SqlCommand("AddHSCMarksDetailBRAIN", cnn);
            // cmd.CommandType = CommandType.StoredProcedure;

            // foreach (HSCMarks _mark in this.HscMarks)
            // {
            //     cmd.Parameters.Clear();

            //     cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            //     cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            //     cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            //     cmd.Parameters.AddWithValue("@Board", _mark.Board);
            //     cmd.Parameters.AddWithValue("@YrOfPassing", _mark.YrOfPassing);
            //     cmd.Parameters.AddWithValue("@NoOfAttempts", _mark.NoOfAttempts);
            //     cmd.Parameters.AddWithValue("@MaxMarks", _mark.MaxMarks);
            //     cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

            //     cmd.ExecuteNonQuery();
            // }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddApplicationMasterListBRAIN()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetBrainSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            SqlCommand cmd = new SqlCommand("AddApplicationMasterListBRAIN", cnn);
            cnn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
            cmd.Parameters.AddWithValue("@NameOfApplicant", this.NameOfApplicant);
            cmd.Parameters.AddWithValue("@EmailId", this.EmailID);
            cmd.Parameters.AddWithValue("@CandidateMobileNo", this.CandidateMobileNo);
            cmd.Parameters.AddWithValue("@WhatsAppNo", this.CandidateWhatsAppNo);

            cmd.Parameters.AddWithValue("@CourseMode", this.CourseType);
            cmd.Parameters.AddWithValue("@CourseType", this.Course);
            cmd.Parameters.AddWithValue("@Choice", this.Choice);
            cmd.Parameters.AddWithValue("@ChoiceTwo", this.ChoiceTwo);
            cmd.Parameters.AddWithValue("@ChoiceThree", this.ChoiceThree);

            cmd.Parameters.AddWithValue("@Scholarship", this.Scholarship);
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
            cmd.Parameters.AddWithValue("@ParentTelephoneNo", this.ParentTelephoneNo);
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
            cmd.Parameters.AddWithValue("@HscTotalMarks", this.HscTotalMarks);
            cmd.Parameters.AddWithValue("@HSCSchoolCategory", this.HSCSchoolCategory);

            cmd.Parameters.AddWithValue("@HSCSchoolDistrict", this.HSCSchoolDistrict);
            cmd.Parameters.AddWithValue("@CivicStatusHSC", this.CivicStatusHSC);
            cmd.Parameters.AddWithValue("@Qualification", this.Qualification);
            cmd.Parameters.AddWithValue("@CollegeName", this.CollageName);
            cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);

            cmd.Parameters.AddWithValue("@Degree", this.Degree);
            cmd.Parameters.AddWithValue("@Percentage", this.Percentage);
            cmd.Parameters.AddWithValue("@BoardOfExamination", this.University);
            cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
            cmd.Parameters.AddWithValue("@DegreeMaxmarks", this.DegreeMaxmarks);

            cmd.Parameters.AddWithValue("@Medium", this.DegreeMedium);
            cmd.Parameters.AddWithValue("@CutOffMarks", this.CutOffMarks);
            cmd.Parameters.AddWithValue("@Eligibility", this.Eligibility);
            cmd.Parameters.AddWithValue("@ModeOfPayment", this.ModeOfPayment);
            cmd.Parameters.AddWithValue("@TelephoneNo", this.TelephoneNo);

            cmd.Parameters.AddWithValue("@BloodGroup", this.BloodGroup);
            cmd.Parameters.AddWithValue("@Caste", this.Caste);
            cmd.Parameters.AddWithValue("@Religion", this.Religion);
            cmd.Parameters.AddWithValue("@Community", this.Community);
            cmd.Parameters.AddWithValue("@Nationality", this.Nationality);

            cmd.Parameters.AddWithValue("@CommunitycentralQuota", this.CommunitycentralQuota);
            cmd.Parameters.AddWithValue("@CivicStatusNative", this.CivicStatusNative);
            cmd.Parameters.AddWithValue("@FatherName", this.FatherName);
            cmd.Parameters.AddWithValue("@MotherName", this.MotherName);
            cmd.Parameters.AddWithValue("@FatherOccupation", this.FatherOccupation);

            cmd.Parameters.AddWithValue("@MotherOccupation", this.MotherOccupation);
            cmd.Parameters.AddWithValue("@MotherMobileNo", this.MotherMobileNo);
            cmd.Parameters.AddWithValue("@FatherMobileNo", this.ParentMobileNo);
            cmd.Parameters.AddWithValue("@AnnualIncome", this.AnnualIncome);
            cmd.Parameters.AddWithValue("@MotherTongue", this.MotherTongue);

            cmd.Parameters.AddWithValue("@HostelRequired", this.HostelRequired);
            cmd.Parameters.AddWithValue("@TransportRequired", this.TransportRequired);
            cmd.Parameters.AddWithValue("@AchivementInSports", this.AchivementInSports);
            cmd.Parameters.AddWithValue("@Level", this.Level);
            cmd.Parameters.AddWithValue("@Game", this.Game);

            cmd.Parameters.AddWithValue("@Medal", this.Medal);
            cmd.Parameters.AddWithValue("@NATAScore", this.NATAScore);
            cmd.Parameters.AddWithValue("@UniGaugeScore", this.UniGaugeScore);
            cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);
            cmd.Parameters.AddWithValue("@Fees", this.Fees);

            cmd.Parameters.AddWithValue("@Photo", this.Photo);
            cmd.Parameters.AddWithValue("@SslcTotalmarks", this.SslcTotalmarks);

            cmd.Parameters.AddWithValue("@EntranceExam", this.EntranceExam);
            cmd.Parameters.AddWithValue("@ApplicationPayMode", this.ModeOfPayment);
            cmd.Parameters.AddWithValue("@ApplicationFeeDate", this.BillDate);
            cmd.Parameters.AddWithValue("@ApplicationBillNo", this.BillNo);
            cmd.Parameters.AddWithValue("@AdmissionLevel", this.Admissionlevel);
            cmd.Parameters.AddWithValue("@AddedDateTime", this.AddedDateTime);

            cmd.ExecuteNonQuery();
            rowsAffected = int.Parse(cmd.ExecuteNonQuery().ToString());

           // DegreeObtainedMarks

            // rowsAffected = int.Parse(cmd.ExecuteNonQuery().ToString());
            // cmd = new SqlCommand("spHscMarkDetailsDeleteBRAIN", cnn);
            // cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);

            // cmd.ExecuteNonQuery();
            // cmd = new SqlCommand("AddHSCMarksDetailBRAIN", cnn);
            // cmd.CommandType = CommandType.StoredProcedure;

            // foreach (HSCMarks _mark in this.HscMarks)
            // {
            //     cmd.Parameters.Clear();

            //     cmd.Parameters.AddWithValue("@ApplicationNo", _mark.ApplicationNo);
            //     cmd.Parameters.AddWithValue("@SubjectName", _mark.SubjectName);
            //     cmd.Parameters.AddWithValue("@SubjectMark", _mark.SubjectMark);
            //     cmd.Parameters.AddWithValue("@Board", _mark.Board);
            //     cmd.Parameters.AddWithValue("@YrOfPassing", _mark.YrOfPassing);
            //     cmd.Parameters.AddWithValue("@NoOfAttempts", _mark.NoOfAttempts);
            //     cmd.Parameters.AddWithValue("@MaxMarks", _mark.MaxMarks);
            //     cmd.Parameters.AddWithValue("@RegistrationNo", _mark.RegistrationNo);

            //     cmd.ExecuteNonQuery();
            // }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
     public DataSet DeleteHSCMarksDetailsBrain(string stApplNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetBrainSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spHscMarkDetailsDeleteBRAIN", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ApplicationNo", stApplNo));
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

    public DataSet ViewApplnPaymentIsSuccess23(string stApplNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spPaymentIsSuccess23", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ApplicationNo", stApplNo));
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

    public DataSet GetCompleteApplicationDetails23(string stApplicationNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spGetCompleteApplicationDetails23", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ApplicationNo", stApplicationNo));
               
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
    public DataSet GetCompleteApplicationDetails23Cash(string stApplicationNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spGetCompleteApplicationDetails23Cash", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ApplicationNo", stApplicationNo));
               
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
    public DataSet GetCompleteHSCMarkDetails23(string stApplicationNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("spGetCompleteHSCMarkDetails23", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ApplicationNo", stApplicationNo));
               
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

    public int AddHSCMarksDetailBRAIN()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetBrainSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            SqlCommand cmd = new SqlCommand("AddHSCMarksDetailBRAIN", cnn);
            cnn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ApplicationNo", this.ApplicationNo);
            cmd.Parameters.AddWithValue("@SubjectName", this.SubjectName);
            cmd.Parameters.AddWithValue("@SubjectMark", this.SubjectMark);
            cmd.Parameters.AddWithValue("@Board", this.Board);
            cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
            cmd.Parameters.AddWithValue("@YrOfPassing", this.YearOfPassing);
            cmd.Parameters.AddWithValue("@NoOfAttempts", this.NoOfAttempts);
            cmd.Parameters.AddWithValue("@MaxMarks", this.MaxMarks);

            cmd.ExecuteNonQuery();
            rowsAffected = int.Parse(cmd.ExecuteNonQuery().ToString());


            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewMotherTongueByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewMotherTongueByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewReligionByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewReligionByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewSchoolBoardByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewSchoolBoardByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewSchoolNameByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewSchoolNameByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewSchoolCatByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewSchoolCatByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewSubjectNameByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewSubjectNameByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewBloodgrpByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewBloodgrpByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCommunityByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCommunityByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewOccupationByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewOccupationByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCommunityCQByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCommunityCQByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewNationalityByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewNationalityByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewQualificationByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewQualificationByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewDistrictByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewDistrictByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewCasteByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCasteByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }



    public DataSet ViewCivicStatusByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("ViewCivicStatusByID", cnn))
        {
            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@SID", ID));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }

        cnn.Close();
        return ds;
    }

    public DataSet ViewRegByHscRegNo(string stHscregno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRegByHscRegno24", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                                      new SqlParameter("@Hscregno", stHscregno));

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