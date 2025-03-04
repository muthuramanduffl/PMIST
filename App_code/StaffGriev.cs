using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for StaffGriev
/// </summary>
public class StaffGriev
{
    public int id { get; set; }
    public string RegNo { get; set; }
    public string StaffName { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Course { get; set; }
    public string Branch { get; set; }
    public string Year { get; set; }
    public string Gender { get; set; }
    public string Post { get; set; }
    public string Faculty { get; set; }
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

    
    public StaffGriev()
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

    public int AddStaffGriev(StaffGriev stud)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddStaffGriev", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                  new SqlParameter("@RegNo", stud.RegNo));
                command.Parameters.Add(
                    new SqlParameter("@StaffName", stud.StaffName));
                command.Parameters.Add(
                    new SqlParameter("@Email", stud.Email));
                command.Parameters.Add(
                    new SqlParameter("@Mobile", stud.Mobile));
                command.Parameters.Add(
                   new SqlParameter("@Course", stud.Course));
                command.Parameters.Add(
                    new SqlParameter("@Branch", stud.Branch));
                command.Parameters.Add(
                    new SqlParameter("@Gender", stud.Gender));
                    command.Parameters.Add(
                    new SqlParameter("@Post", stud.Post));
                    command.Parameters.Add(
                    new SqlParameter("@Faculty", stud.Faculty));
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

    public DataSet ViewStaffGrievExist(string RegNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStaffGrievExist", cnn))
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
	
    public DataSet ViewValidStaffLoginGriev(string RegNo)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewValidStaffLoginGriev", cnn))
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

    public int AddTicketStaffGriev(StaffGriev stud,  ref int ticketId)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {

            using (SqlCommand command = new SqlCommand("AddTicketStaffGriev", cnn))
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


    public int UpdateticketNoStaffGriev(string ticketNo, int Id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {

            using (SqlCommand command = new SqlCommand("UpdateticketNoStaffGriev", cnn))
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

    public DataSet ViewTicketStaffGriev(string RegNo,string stticketstatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTicketStaffGriev", cnn))
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
    public DataSet ViewTicketforTeam(string stassignedto,string stSearchval, string stcoursename, string stbranch, string stticketstatus, string stCategory)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTicketforTeam", cnn))
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

    public DataSet ViewAllTicketsStaff(string stSearchval, string stcoursename, string stbranch, string stticketstatus, string stassignedto, string stCategory)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewAllTicketsStaff", cnn))
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

    public DataSet ViewTicketStaffGrievByID(string id)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewTicketStaffGrievByID", cnn))
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

    public int UpdateTicketStatusStaff(StaffGriev stud)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {

            using (SqlCommand command = new SqlCommand("UpdateTicketStatusStaff", cnn))
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

    public DataSet ViewFacultyStaffGriev()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewFacultyStaffGriev", cnn))
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

    public int UpdateTicketAssignStaff(StaffGriev stud)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {

            using (SqlCommand command = new SqlCommand("UpdateTicketAssignStaff", cnn))
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

    public DataSet ViewGrievStaffList(string stSearchval, string stcoursename, string stbranch, string stfaculty, string stpost)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewGrievStaffList", cnn))
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
                   new SqlParameter("@Faculty", stfaculty));
                    command.Parameters.Add(
                   new SqlParameter("@Post", stpost));
                   
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

    public int ViewTotalCountStaffGriev(string columnval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int count = 0;
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewTotalCountStaffGriev", cnn))
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
    public DataSet ViewReportStaffGriev()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewReportStaffGriev", cnn))
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
    public DataSet ViewReportStaffGrievCategory()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewReportStaffGrievCategory", cnn))
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

    public int ViewLevelCountStaffGriev(string columnval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int count = 0;
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewLevelCountStaffGriev", cnn))
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
    public int DeleteStaffGrievTicket(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteStaffGrievTicket", cnn))
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
}