using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for StudGriev
/// </summary>
public class StudGriev
{
    public int id { get; set; }
    public string RegNo { get; set; }
    public string StudName { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Course { get; set; }
    public string Branch { get; set; }
    public string Year { get; set; }
    public string Gender { get; set; }
    public string Hostelavailed { get; set; }
    public string Busavailed { get; set; }
    public string Bulkupload { get; set; }
    public string AddedBy { get; set; }
    public DateTime AddedDate { get; set; }
    public string Grievance { get; set; }
    public string crossedby { get; set; }
    public string ticketstatus { get; set; }
    public string category{ get; set; }
    public string Othercategory { get; set; }
    public string Remarks { get; set; }
    public DateTime updateddate { get; set; }
    public string updatedby { get; set; }
    public string AssignedTo { get; set; }

    
    public StudGriev()
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

    public int AddStudGriev(StudGriev stud)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddStudGriev", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                  new SqlParameter("@RegNo", stud.RegNo));
                command.Parameters.Add(
                    new SqlParameter("@StudName", stud.StudName));
                command.Parameters.Add(
                    new SqlParameter("@Email", stud.Email));
                command.Parameters.Add(
                    new SqlParameter("@Mobile", stud.Mobile));
                command.Parameters.Add(
                   new SqlParameter("@Course", stud.Course));
                command.Parameters.Add(
                    new SqlParameter("@Branch", stud.Branch));
                command.Parameters.Add(
                    new SqlParameter("@StudyingYr", stud.Year));
                command.Parameters.Add(
                    new SqlParameter("@Gender", stud.Gender));
                    command.Parameters.Add(
                    new SqlParameter("@Hostelavailed", stud.Hostelavailed));
                    command.Parameters.Add(
                    new SqlParameter("@Busavailed", stud.Busavailed));
                command.Parameters.Add(
                    new SqlParameter("@AddedBy", stud.AddedBy));
                command.Parameters.Add(
                    new SqlParameter("@AddedDate", stud.AddedDate));
                command.Parameters.Add(
                     new SqlParameter("@Bulkupload", stud.Bulkupload));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewStudGrievExist(string RegNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStudGrievExist", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@RegNo", RegNo));
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
	
    public DataSet ViewValidStudLoginGriev(string RegNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidStudLoginGriev", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@RegNo", RegNo));
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

    public int AddTicketStudGriev(StudGriev stud,  ref int ticketId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {

            using (SqlCommand command = new SqlCommand("AddTicketStudGriev", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                  new SqlParameter("@RegNo", stud.RegNo));
                  command.Parameters.Add(
                  new SqlParameter("@Category", stud.category));
                command.Parameters.Add(
                  new SqlParameter("@Others", stud.Othercategory));
                command.Parameters.Add(
                    new SqlParameter("@Grievances", stud.Grievance));
                command.Parameters.Add(
                    new SqlParameter("@AddedDate", stud.AddedDate));
                command.Parameters.Add(
                     new SqlParameter("@ticketstatus", stud.ticketstatus));

                command.Parameters.Add("@newId", SqlDbType.VarChar, 300);
                command.Parameters["@newId"].Direction = ParameterDirection.Output;

                rowsAffected = command.ExecuteNonQuery();
                 ticketId = Convert.ToInt16(command.Parameters["@newId"].Value.ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public int UpdateticketNoStudGriev(string ticketNo, int Id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {

            using (SqlCommand command = new SqlCommand("UpdateticketNoStudGriev", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                 new SqlParameter("@ticketNo", ticketNo));
                command.Parameters.Add(
                    new SqlParameter("@Id", Id));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewTicketStudGriev(string RegNo,string stticketstatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTicketStudGriev", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@RegNo", RegNo));
                command.Parameters.Add(
                  new SqlParameter("@ticketstatus", stticketstatus));
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
    public DataSet ViewTicketforFaculty(string stassignedto,string stSearchval, string stcoursename, string stbranch, string stticketstatus, string stCategory)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTicketforFaculty", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                   new SqlParameter("@srchval", stSearchval));
                command.Parameters.Add(
                   new SqlParameter("@course", stcoursename));
                command.Parameters.Add(
                   new SqlParameter("@branch", stbranch));
                command.Parameters.Add(
                   new SqlParameter("@ticketstatus", stticketstatus));
                command.Parameters.Add(
                    new SqlParameter("@assignedto", Convert.ToInt32(stassignedto)));
                command.Parameters.Add(
                   new SqlParameter("@category", stCategory));
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

    public DataSet ViewAllTicketsNew(string stSearchval, string stcoursename, string stbranch, string stticketstatus, string stassignedto, string stCategory)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllTicketsNew", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                   new SqlParameter("@srchval", stSearchval));
                command.Parameters.Add(
                   new SqlParameter("@course", stcoursename));
                command.Parameters.Add(
                   new SqlParameter("@branch", stbranch));
                command.Parameters.Add(
                   new SqlParameter("@ticketstatus", stticketstatus));
                command.Parameters.Add(
                   new SqlParameter("@assignedto", stassignedto));
                   command.Parameters.Add(
                   new SqlParameter("@category", stCategory));

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

    public DataSet ViewTicketStudGrievByID(string id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTicketStudGrievByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@id", Convert.ToInt32(id)));
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

    public int UpdateTicketStatus(StudGriev stud)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {

            using (SqlCommand command = new SqlCommand("UpdateTicketStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                  new SqlParameter("@ticketStatus", stud.ticketstatus));
                command.Parameters.Add(
                    new SqlParameter("@Remarks", stud.Remarks));
                command.Parameters.Add(
                    new SqlParameter("@updateddate", stud.updateddate));
                command.Parameters.Add(
                    new SqlParameter("@updatedby", stud.updatedby));
                command.Parameters.Add(
                    new SqlParameter("@Id", stud.id));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewFacultyStudGriev()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewFacultyStudGriev", cnn))
            {
                cnn.Open();
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

    public int UpdateTicketAssign(StudGriev stud)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {

            using (SqlCommand command = new SqlCommand("UpdateTicketAssign", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                 new SqlParameter("@assignedto",Convert.ToInt32(stud.AssignedTo)));
                command.Parameters.Add(
                    new SqlParameter("@Id", stud.id));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewGrievStudentList(string stSearchval, string stcoursename, string stbranch)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewGrievStudentList", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                   new SqlParameter("@srchval", stSearchval));
                command.Parameters.Add(
                   new SqlParameter("@course", stcoursename));
                command.Parameters.Add(
                   new SqlParameter("@branch", stbranch));
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

    public int ViewTotalCountStudGriev(string columnval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int count = 0;
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewTotalCountStudGriev", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@columnval", columnval));
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return count;
    }
    public DataSet ViewReportStudGriev()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewReportStudGriev", cnn))
            {
                cnn.Open();
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
    public DataSet ViewReportStudGrievCategory()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewReportStudGrievCategory", cnn))
            {
                cnn.Open();
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

    public int ViewLevelCountStudGriev(string columnval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int count = 0;
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewLevelCountStudGriev", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@columnval", columnval));
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return count;
    }
    public int DeleteStudGrievTicket(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteStudGrievTicket", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@ID", Sno));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeleteStudGriev(int Sno,string RegNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteStudGriev", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@Sno", Sno));
                command.Parameters.Add(
                    new SqlParameter("@RegNo", RegNo));

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