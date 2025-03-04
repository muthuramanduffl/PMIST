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
public class pmucareer
{
    public int Sno { get; set; }
    public int ApplicantId { get; set; }
    public string JobId { get; set; }
    public string ApplyingFor { get; set; }
    public string Department { get; set; }
    public string School { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string PhoneNo { get; set; }
    public string WhatsappNo { get; set; }
    public string Gender { get; set; }
    public string DOB { get; set; }
    public int Age { get; set; }
    public string Religion { get; set; }
    public string Nationality { get; set; }
    public string Community { get; set; }
    public string AddrLine1 { get; set; }
    public string AddrLine2 { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string Pincode { get; set; }
    public string Languages { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string DifferentlyAbled { get; set; }
    public string MartialStatus { get; set; }
    public DateTime AppliedDate { get; set; }
    public string Degree { get; set; }
    public string PhD { get; set; }
    public string Specialisation { get; set; }
    public string Institution { get; set; }
    public string University { get; set; }
    public string ModeStudy { get; set; }
    public string Marks { get; set; }
    public string YearofPassing { get; set; }
    public string CourseMode { get; set; }
    public string Fresher { get; set; }
    public string CurrentDesignation { get; set; }
    public string CurrentOrganisation { get; set; }
    public string OverallExperience { get; set; }
    public string CurrentlyEmployed { get; set; }
    public string PresentPayDrawn { get; set; }
    public string Resume { get; set; }
    public string Mode { get; set; }
    public string ModeValue { get; set; }
    public string Status { get; set; }
    public string ScrutinisedStatus { get; set; }
    public string RefSource { get; set; }
    public string DisabilityNature { get; set; }
    public string NoScholarsGuided { get; set; }
    public string Caste { get; set; }
    public string COAregNo { get; set; }
    public string COAregmon { get; set; }
    public string COAregyr { get; set; }
    public string FinalDepartment { get; set; }
    public string FinalSchool { get; set; }
    public string FinalPosition { get; set; }

    public pmucareer()
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
    public int AddCareerPersonalDetails(pmucareer career, ref int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddCareerPersonalDetailsnew", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@JobId", career.JobId));
                command.Parameters.Add(
                    new SqlParameter("@ApplyingFor", career.ApplyingFor));
                command.Parameters.Add(
                    new SqlParameter("@Department", career.Department));
                command.Parameters.Add(
                    new SqlParameter("@School", career.School));
                command.Parameters.Add(
                    new SqlParameter("@Name", career.Name));
                command.Parameters.Add(
                    new SqlParameter("@EmailId", career.EmailId));
                command.Parameters.Add(
                    new SqlParameter("@PhoneNo", career.PhoneNo));
                command.Parameters.Add(
                    new SqlParameter("@WhatsappNo", career.WhatsappNo));
                command.Parameters.Add(
                    new SqlParameter("@Gender", career.Gender));
                command.Parameters.Add(
                new SqlParameter("@DOB", career.DOB));
                command.Parameters.Add(
                new SqlParameter("@Age", career.Age));
                command.Parameters.Add(
                new SqlParameter("@Religion", career.Religion));
                command.Parameters.Add(
                new SqlParameter("@Nationality", career.Nationality));
                command.Parameters.Add(
                new SqlParameter("@Community", career.Community));
                command.Parameters.Add(
                new SqlParameter("@AddrLine1", career.AddrLine1));
                command.Parameters.Add(
                new SqlParameter("@AddrLine2", career.AddrLine2));
                command.Parameters.Add(
                new SqlParameter("@State", career.State));
                command.Parameters.Add(
                new SqlParameter("@City", career.City));
                command.Parameters.Add(
                new SqlParameter("@Pincode", career.Pincode));
                command.Parameters.Add(
                new SqlParameter("@Languages", career.Languages));
                command.Parameters.Add(
                new SqlParameter("@FatherName", career.FatherName));
                command.Parameters.Add(
                new SqlParameter("@MotherName", career.MotherName));
                command.Parameters.Add(
                new SqlParameter("@DifferentlyAbled", career.DifferentlyAbled));
                command.Parameters.Add(
                new SqlParameter("@MartialStatus", career.MartialStatus));
                command.Parameters.Add(
                new SqlParameter("@AppliedDate", career.AppliedDate));
                command.Parameters.Add(
                    new SqlParameter("@Status", career.Status));
                command.Parameters.Add(
                    new SqlParameter("@ScrutinisedStatus", career.ScrutinisedStatus));
                command.Parameters.Add(
                    new SqlParameter("@PhD", career.PhD));
                command.Parameters.Add(
                    new SqlParameter("@RefSource", career.RefSource));
                command.Parameters.Add(
                    new SqlParameter("@DisabilityNature", career.DisabilityNature));
                command.Parameters.Add(
                    new SqlParameter("@Caste", career.Caste));
                command.Parameters.Add(
                   new SqlParameter("@FinalDepartment", career.FinalDepartment));
                command.Parameters.Add(
                    new SqlParameter("@FinalSchool", career.FinalSchool));
                command.Parameters.Add(
                    new SqlParameter("@FinalPosition", career.FinalPosition));


                command.Parameters.Add("@newId", SqlDbType.VarChar, 15000);
                command.Parameters["@newId"].Direction = ParameterDirection.Output;
                rowsAffected = command.ExecuteNonQuery();
                ID = Convert.ToInt16(command.Parameters["@newId"].Value.ToString());

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddCareerPersonalDetails2024(pmucareer career, ref int ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddCareerPersonalDetails2024", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@JobId", career.JobId));
                command.Parameters.Add(
                    new SqlParameter("@ApplyingFor", career.ApplyingFor));
                command.Parameters.Add(
                    new SqlParameter("@Department", career.Department));
                command.Parameters.Add(
                    new SqlParameter("@School", career.School));
                command.Parameters.Add(
                    new SqlParameter("@Name", career.Name));
                command.Parameters.Add(
                    new SqlParameter("@EmailId", career.EmailId));
                command.Parameters.Add(
                    new SqlParameter("@PhoneNo", career.PhoneNo));
                command.Parameters.Add(
                    new SqlParameter("@Gender", career.Gender));
                command.Parameters.Add(
                new SqlParameter("@DOB", career.DOB));
                command.Parameters.Add(
                new SqlParameter("@Age", career.Age));
                command.Parameters.Add(
                new SqlParameter("@Religion", career.Religion));
                command.Parameters.Add(
                new SqlParameter("@Nationality", career.Nationality));
                command.Parameters.Add(
                new SqlParameter("@Community", career.Community));
                command.Parameters.Add(
                new SqlParameter("@AddrLine1", career.AddrLine1));
                command.Parameters.Add(
                new SqlParameter("@AddrLine2", career.AddrLine2));
                command.Parameters.Add(
                new SqlParameter("@State", career.State));
                command.Parameters.Add(
                new SqlParameter("@City", career.City));
                command.Parameters.Add(
                new SqlParameter("@Pincode", career.Pincode));
                command.Parameters.Add(
                new SqlParameter("@Languages", career.Languages));
                command.Parameters.Add(
                new SqlParameter("@FatherName", career.FatherName));
                command.Parameters.Add(
                new SqlParameter("@MotherName", career.MotherName));
                command.Parameters.Add(
                new SqlParameter("@DifferentlyAbled", career.DifferentlyAbled));
                command.Parameters.Add(
                new SqlParameter("@MartialStatus", career.MartialStatus));
                command.Parameters.Add(
                new SqlParameter("@AppliedDate", career.AppliedDate));
                command.Parameters.Add(
                    new SqlParameter("@Status", career.Status));
                command.Parameters.Add(
                    new SqlParameter("@ScrutinisedStatus", career.ScrutinisedStatus));
                command.Parameters.Add(
                    new SqlParameter("@PhD", career.PhD));
                command.Parameters.Add(
                    new SqlParameter("@RefSource", career.RefSource));
                command.Parameters.Add(
                    new SqlParameter("@DisabilityNature", career.DisabilityNature));
                command.Parameters.Add(
                    new SqlParameter("@Caste", career.Caste));
                command.Parameters.Add(
                   new SqlParameter("@FinalDepartment", career.FinalDepartment));
                command.Parameters.Add(
                    new SqlParameter("@FinalSchool", career.FinalSchool));
                command.Parameters.Add(
                    new SqlParameter("@FinalPosition", career.FinalPosition));


                command.Parameters.Add("@newId", SqlDbType.VarChar, 15000);
                command.Parameters["@newId"].Direction = ParameterDirection.Output;
                rowsAffected = command.ExecuteNonQuery();
                ID = Convert.ToInt16(command.Parameters["@newId"].Value.ToString());

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddCareerEducationDetails(pmucareer career)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddCareerEducationDetails", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@ApplicantId", career.ApplicantId));
                command.Parameters.Add(
                   new SqlParameter("@Degree", career.Degree));
                command.Parameters.Add(
                  new SqlParameter("@Specialisation", career.Specialisation));
                command.Parameters.Add(
                  new SqlParameter("@Institution", career.Institution));
                command.Parameters.Add(
                   new SqlParameter("@University", career.University));
                command.Parameters.Add(
           new SqlParameter("@ModeStudy", career.ModeStudy));
                command.Parameters.Add(
                  new SqlParameter("@Marks", career.Marks));
                command.Parameters.Add(
                 new SqlParameter("@YearofPassing", career.YearofPassing));
                command.Parameters.Add(
                new SqlParameter("@CourseMode", career.CourseMode));
                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public int AddCareerEducationCOADetails(pmucareer career)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddCareerEducationCOADetails", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@ApplicantId", career.ApplicantId));
                command.Parameters.Add(
                   new SqlParameter("@COAregNo", career.COAregNo));
                command.Parameters.Add(
                  new SqlParameter("@COAregmon", career.COAregmon));
                command.Parameters.Add(
                  new SqlParameter("@COAregyr", career.COAregyr));
                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddCareerExperienceDetails(pmucareer career)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddCareerExperienceDetails", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@ApplicantId", career.ApplicantId));
                command.Parameters.Add(
                   new SqlParameter("@Fresher", career.Fresher));
                command.Parameters.Add(
                  new SqlParameter("@CurrentDesignation", career.CurrentDesignation));
                command.Parameters.Add(
                  new SqlParameter("@CurrentOrganisation", career.CurrentOrganisation));
                command.Parameters.Add(
                   new SqlParameter("@OverallExperience", career.OverallExperience));
                command.Parameters.Add(
           new SqlParameter("@CurrentlyEmployed", career.CurrentlyEmployed));
                command.Parameters.Add(
                  new SqlParameter("@PresentPayDrawn", career.PresentPayDrawn));
                command.Parameters.Add(
                 new SqlParameter("@Resume", career.Resume));
                command.Parameters.Add(
                 new SqlParameter("@NoScholarsGuided", career.NoScholarsGuided));
                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int AddCareerOtherDetails(pmucareer career)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddCareerOtherDetails", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@ApplicantId", career.ApplicantId));
                command.Parameters.Add(
                   new SqlParameter("@Mode", career.Mode));
                command.Parameters.Add(
                  new SqlParameter("@ModeValue", career.ModeValue));

                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public DataSet ViewCareerBySearchDateAdminNew(string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCareerBySearchDateAdminNew", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));
                command.Parameters.Add(
                new SqlParameter("@Status", Status));
                command.Parameters.Add(
                new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
                new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
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
    public DataSet ViewShortListBySearchDateAdminFilter(string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewShortListBySearchDateAdminFilter", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));
                command.Parameters.Add(
                new SqlParameter("@Status", Status));
                command.Parameters.Add(
                new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
                new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
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
    public DataSet ViewOnholdBySearchDateAdminFilter(string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewOnholdBySearchDateAdminFilter", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));
                command.Parameters.Add(
                new SqlParameter("@Status", Status));
                command.Parameters.Add(
                new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
                new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
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
    public DataSet ViewWaitlistedBySearchDateAdminFilter(string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewWaitlistedBySearchDateAdminFilter", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));
                command.Parameters.Add(
                new SqlParameter("@Status", Status));
                command.Parameters.Add(
                new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
                new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
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
    public DataSet ViewRejectedBySearchDateAdminFilter(string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewRejectedBySearchDateAdminFilter", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));
                command.Parameters.Add(
                new SqlParameter("@Status", Status));
                command.Parameters.Add(
                new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
                new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
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
    public DataSet ViewRecruitedBySearchDateAdminFilter(string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewRecruitedBySearchDateAdminFilter", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));
                command.Parameters.Add(
                new SqlParameter("@Status", Status));
                command.Parameters.Add(
                new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
                new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
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
    public DataSet ViewJoinedBySearchDateAdminFilter(string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewJoinedBySearchDateAdminFilter", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));
                command.Parameters.Add(
                new SqlParameter("@Status", Status));
                command.Parameters.Add(
                new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
                new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
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
    public DataSet ViewNotyetJoinedBySearchDateAdminFilter(string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewNotyetJoinedBySearchDateAdminFilter", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                new SqlParameter("@Department", Department));
                command.Parameters.Add(
                new SqlParameter("@School", School));
                command.Parameters.Add(
                new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                new SqlParameter("@ApplyingFor", ApplyingFor));
                command.Parameters.Add(
                new SqlParameter("@Status", Status));
                command.Parameters.Add(
                new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
                new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
                new SqlParameter("@State", stState));
                command.Parameters.Add(
                new SqlParameter("@City", stCity));
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
    public DataSet ViewCareerBySearchDateAdmin(string Department, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCareerBySearchDateAdmin", cnn))
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
             new SqlParameter("@State", stState));
                command.Parameters.Add(
             new SqlParameter("@City", stCity));
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
    public int UpdateCareerStatus(int ApplicantId, string Status)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateCareerStatus", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@ApplicantId", ApplicantId));
                command.Parameters.Add(
                   new SqlParameter("@Status", Status));

                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int UpdateCareerCandByAdmin(string status, int sno, string scrutinisedby, string reason, string ScrutinisedStatus, string stfinalschool,
        string stfinaldept, string stfinalpos)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateCareerCandByAdmin", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@ApplicantId", sno));
                command.Parameters.Add(
                    new SqlParameter("@Status", status));
                command.Parameters.Add(
                    new SqlParameter("@Reason", reason));
                command.Parameters.Add(
                    new SqlParameter("@Scrutinisedby", scrutinisedby));
                command.Parameters.Add(
                    new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                    new SqlParameter("@Finalschool", stfinalschool));
                command.Parameters.Add(
                    new SqlParameter("@Finaldept", stfinaldept));
                command.Parameters.Add(
                    new SqlParameter("@Finalpos", stfinalpos));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public int UpdateCareerCandidateByAdmin(string Transfer, DateTime Transferdate, string status, int sno, string scrutinisedby, string reason, string ScrutinisedStatus, string stfinalschool,
        string stfinaldept, string stfinalpos)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateCareerCandidateByAdmin", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                   new SqlParameter("@Transfer", Transfer));
                command.Parameters.Add(
                   new SqlParameter("@Transferdate", Transferdate));
                command.Parameters.Add(
                    new SqlParameter("@ApplicantId", sno));
                command.Parameters.Add(
                    new SqlParameter("@Status", status));
                command.Parameters.Add(
                    new SqlParameter("@Reason", reason));
                command.Parameters.Add(
                    new SqlParameter("@Scrutinisedby", scrutinisedby));
                command.Parameters.Add(
                    new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                    new SqlParameter("@Finalschool", stfinalschool));
                command.Parameters.Add(
                    new SqlParameter("@Finaldept", stfinaldept));
                command.Parameters.Add(
                    new SqlParameter("@Finalpos", stfinalpos));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateCareerCanScrutinisedStatus(string status, int sno, string scrutinisedby, string reason, string ScrutinisedStatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateCareerCanScrutinisedStatus", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
               new SqlParameter("@ApplicantId", sno));
                command.Parameters.Add(
                   new SqlParameter("@Status", status));
                command.Parameters.Add(
                     new SqlParameter("@Scrutinisedby", scrutinisedby));
                command.Parameters.Add(
                   new SqlParameter("@Reason", reason));
                command.Parameters.Add(
                   new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                rowsAffected = command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeleteCareer(int ApplicantId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        //try
        //{
        using (SqlCommand command = new SqlCommand("DeleteCareer", cnn))
        {

            cnn.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
           new SqlParameter("@ApplicantId", ApplicantId));

            rowsAffected = command.ExecuteNonQuery();

        }
        cnn.Close();
        //}
        //catch (Exception ex)
        //{
        //}
        return rowsAffected;
    }

    public DataSet ViewTopJobSpec(int ApplicantId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewTopJobSpec", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ApplicantId", ApplicantId));
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

    public DataSet ViewTopJobSpecByCourseMode(int ApplicantId, string stCourseMode)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewTopJobSpecByCourseMode", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ApplicantId", ApplicantId));
                command.Parameters.Add(
               new SqlParameter("@CourseMode", stCourseMode));
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
    public DataSet ViewCareerPersonalById(int ApplicantId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCareerPersonalById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ApplicantId", ApplicantId));
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


    public DataSet ViewCareerEducationById(int ApplicantId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCareerEducationById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ApplicantId", ApplicantId));
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
    public DataSet ViewCareerExpById(int ApplicantId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCareerExpById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ApplicantId", ApplicantId));
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

    public DataSet ViewCOARegDetails(int ApplicantId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCOARegDetails", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ApplicantId", ApplicantId));
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

    public DataSet ViewCareerOtherById(int ApplicantId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCareerOtherById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ApplicantId", ApplicantId));
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

    public DataSet ViewCareerCOAById(int ApplicantId)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCareerCOAById", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@ApplicantId", ApplicantId));
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
    public DataSet ViewShortListBySearchDateAdmin(string Department, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewShortListBySearchDateAdmin", cnn))
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
            new SqlParameter("@State", stState));
                command.Parameters.Add(
             new SqlParameter("@City", stCity));
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
    public DataSet ViewWaitlistedBySearchDateAdmin(string Department, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewWaitlistedBySearchDateAdmin", cnn))
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
            new SqlParameter("@State", stState));
                command.Parameters.Add(
             new SqlParameter("@City", stCity));
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
    public DataSet ViewRejectedBySearchDateAdmin(string Department, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewRejectedBySearchDateAdmin", cnn))
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
             new SqlParameter("@State", stState));
                command.Parameters.Add(
             new SqlParameter("@City", stCity));
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

    public DataSet ViewOnholdBySearchDateAdmin(string Department, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewOnholdBySearchDateAdmin", cnn))
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
             new SqlParameter("@State", stState));
                command.Parameters.Add(
             new SqlParameter("@City", stCity));
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

    public DataSet ViewRecruitedBySearchDateAdmin(string Department, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewRecruitedBySearchDateAdmin", cnn))
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
             new SqlParameter("@State", stState));
                command.Parameters.Add(
             new SqlParameter("@City", stCity));
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

    public DataSet ViewJoinedBySearchDateAdmin(string Department, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewJoinedBySearchDateAdmin", cnn))
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
             new SqlParameter("@State", stState));
                command.Parameters.Add(
             new SqlParameter("@City", stCity));
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

    public DataSet ViewNotJoinedBySearchDateAdmin(string Department, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewNotJoinedBySearchDateAdmin", cnn))
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
             new SqlParameter("@State", stState));
                command.Parameters.Add(
             new SqlParameter("@City", stCity));
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
    public DataSet ViewAllCareerPersonalDetails()
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewAllCareerPersonalDetails", cnn))
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

    public DataSet ViewCareerBySearchDateAdminFilter(string Searchval, string admindept, string Department, string School, string PhD, string Scrutinisedby, string ScrutinisedStatus, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewCareerBySearchDateAdminFilter", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Searchval", Searchval));
                command.Parameters.Add(
                    new SqlParameter("@admindept", admindept));
                command.Parameters.Add(
                    new SqlParameter("@Department", Department));
                command.Parameters.Add(
                    new SqlParameter("@School", School));
                command.Parameters.Add(
                    new SqlParameter("@PhD", PhD));
                command.Parameters.Add(
                    new SqlParameter("@Scrutinisedby", Scrutinisedby));
                command.Parameters.Add(
                    new SqlParameter("@ScrutinisedStatus", ScrutinisedStatus));
                command.Parameters.Add(
                    new SqlParameter("@ApplyingFor", ApplyingFor));
                command.Parameters.Add(
                    new SqlParameter("@Status", Status));
                command.Parameters.Add(
                    new SqlParameter("@FromDate", FromDate));
                command.Parameters.Add(
                    new SqlParameter("@ToDate", ToDate));
                command.Parameters.Add(
                    new SqlParameter("@State", stState));
                command.Parameters.Add(
                    new SqlParameter("@City", stCity));
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

    //public DataSet ViewJoinedCandidateSearchCriteria(string admindept,string SearchCriteria)
    //{
    //    DataSet ds = new DataSet();
    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);

    //    try
    //    {
    //        cnn.Open();
    //        using (SqlCommand command = new SqlCommand("ViewJoinedCandidateSearchCriteria", cnn))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(
    //            new SqlParameter("@admindept", admindept));
    //            command.Parameters.Add(
    //            new SqlParameter("@SearchCriteria", SearchCriteria));
    //            SqlDataAdapter da = new SqlDataAdapter(command);

    //            da.Fill(ds);
    //        }
    //        cnn.Close();

    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //    return ds;
    //}

    //public DataSet ViewNotyetJoinedCandidateSearchCriteria(string SearchCriteria)
    //{
    //    DataSet ds = new DataSet();
    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);

    //    try
    //    {
    //        cnn.Open();
    //        using (SqlCommand command = new SqlCommand("ViewNotyetJoinedCandidateSearchCriteria", cnn))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(
    //            new SqlParameter("@SearchCriteria", SearchCriteria));
    //            SqlDataAdapter da = new SqlDataAdapter(command);

    //            da.Fill(ds);


    //        }
    //        cnn.Close();

    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //    return ds;
    //}

    //public DataSet ViewWaitlistedCandidateSearchCriteria(string SearchCriteria)
    //{
    //    DataSet ds = new DataSet();
    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);

    //    try
    //    {
    //        cnn.Open();
    //        using (SqlCommand command = new SqlCommand("ViewWaitlistedCandidateSearchCriteria", cnn))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(
    //            new SqlParameter("@SearchCriteria", SearchCriteria));
    //            SqlDataAdapter da = new SqlDataAdapter(command);

    //            da.Fill(ds);


    //        }
    //        cnn.Close();

    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //    return ds;
    //}

    //public DataSet ViewOnholdCandidateSearchCriteria(string SearchCriteria)
    //{
    //    DataSet ds = new DataSet();
    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);

    //    try
    //    {
    //        cnn.Open();
    //        using (SqlCommand command = new SqlCommand("ViewOnholdCandidateSearchCriteria", cnn))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(
    //            new SqlParameter("@SearchCriteria", SearchCriteria));
    //            SqlDataAdapter da = new SqlDataAdapter(command);

    //            da.Fill(ds);


    //        }
    //        cnn.Close();

    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //    return ds;
    //}

    // public DataSet ViewRecrutiedCandidateSearchCriteria(string SearchCriteria)
    //{
    //    DataSet ds = new DataSet();
    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);

    //    try
    //    {
    //        cnn.Open();
    //        using (SqlCommand command = new SqlCommand("ViewRecruitedCandidateSearchCriteria", cnn))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(
    //            new SqlParameter("@SearchCriteria", SearchCriteria));
    //            SqlDataAdapter da = new SqlDataAdapter(command);

    //            da.Fill(ds);


    //        }
    //        cnn.Close();

    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //    return ds;
    //}
    //public DataSet ViewRejectedCandidateSearchCriteria(string SearchCriteria)
    //{
    //    DataSet ds = new DataSet();
    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);

    //    try
    //    {
    //        cnn.Open();
    //        using (SqlCommand command = new SqlCommand("ViewRejectedCandidateSearchCriteria", cnn))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(
    //            new SqlParameter("@SearchCriteria", SearchCriteria));
    //            SqlDataAdapter da = new SqlDataAdapter(command);

    //            da.Fill(ds);


    //        }
    //        cnn.Close();

    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //    return ds;
    //}
    //public DataSet ViewShortlistedCandidateSearchCriteria(string SearchCriteria)
    //{
    //    DataSet ds = new DataSet();
    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);

    //    try
    //    {
    //        cnn.Open();
    //        using (SqlCommand command = new SqlCommand("ViewShortlistedCandidateSearchCriteria", cnn))
    //        {
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(
    //            new SqlParameter("@SearchCriteria", SearchCriteria));
    //            SqlDataAdapter da = new SqlDataAdapter(command);

    //            da.Fill(ds);


    //        }
    //        cnn.Close();

    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //    return ds;
    //}

    public DataSet ViewTransferredListBySearchDateAdmin(string Department, string ApplyingFor, string Status, string FromDate, string ToDate, string stState, string stCity, string stCategory)
    {
        DataSet ds = new DataSet();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewTransferredListBySearchDateAdmin", cnn))
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
            new SqlParameter("@State", stState));
                command.Parameters.Add(
             new SqlParameter("@City", stCity));
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
}