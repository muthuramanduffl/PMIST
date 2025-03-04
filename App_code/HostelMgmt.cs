using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for HostelMgmt
/// </summary>
public class HostelMgmt
{
    public int Sno { get; set; }
    public string RoomType { get; set; }
    public string RoomNo { get; set; }
    public DateTime AddedDate { get; set; }
    public string StudentName { get; set; }
    public string StudentID { get; set; }
    public string Email { get; set; }
    public string MobileNo { get; set; }
    public string ParentEmail { get; set; }
    public string ParentMobileNo { get; set; }
    public string Course { get; set; }
    public string Branch { get; set; }
    public string studyingYear { get; set; }
    public string FeesStatus { get; set; }
    public string SeatStatus { get; set; }
    public string Purpose { get; set; }
    public DateTime? AllotedDate { get; set; }
    public string BalanceAmount { get; set; }
    public string AddedBy { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string Bulkupload { get; set; }
    public string HostelFloor { get; set; }
    public string HostelName { get; set; }
    public string RoomNumber { get; set; }
    public int FloorID { get; set; }
    public int RoomID { get; set; }
    public int RoomCapacity { get; set; }
    public string Gender { get; set; }
    public DateTime? OutDate { get; set; }
    public DateTime? InDate { get; set; }
    public int StudSno { get; set; }
    public string OutTime { get; set; }
    public string InTime { get; set; }
    public HostelMgmt()
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

    public DataSet ViewHostelRoomAlreadyExist(string strRoomNo, string strFloorID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelRoomAlreadyExist", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@RoomNo", strRoomNo));
                command.Parameters.Add(
                    new SqlParameter("@Floor", Convert.ToInt32(strFloorID)));

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

    public int AddHostelRoomDetails(HostelMgmt host)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddHostelRoomDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@RoomType", host.RoomType));
                command.Parameters.Add(
            new SqlParameter("@RoomNo", host.RoomNo));
                command.Parameters.Add(
           new SqlParameter("@Purpose", host.Purpose));
                command.Parameters.Add(
            new SqlParameter("@AddedBy", host.AddedBy));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", host.AddedDate));
                command.Parameters.Add(
            new SqlParameter("@FloorID", host.FloorID));
                command.Parameters.Add(
            new SqlParameter("@RoomCapacity", host.RoomCapacity));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewHostelRoomDetails(string strHostelID,string strFloorlID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelRoomDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@hostelID", strHostelID));
                command.Parameters.Add(
            new SqlParameter("@floorID", strFloorlID));

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

    public DataSet ViewHostelNames()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelNames", cnn))
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

    public DataSet ViewHostelFloor(string strHostelID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelFloor", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@HostelID", strHostelID));
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

    public DataSet ViewHostelRoomTypeByFloor(string stFloorID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelRoomTypeByFloor", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@FloorID", stFloorID));
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

    public DataSet ViewHostelRoomNoByType(string stFloorID, string stRoomType)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelRoomNoByType", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@FloorID", stFloorID));
                command.Parameters.Add(
                    new SqlParameter("@RoomType", stRoomType));
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

    public int AddHostelStudentDetails(HostelMgmt host)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddHostelStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@StudName", host.StudentName));
                command.Parameters.Add(
            new SqlParameter("@StudID", host.StudentID));
                command.Parameters.Add(
            new SqlParameter("@Email", host.Email));
                command.Parameters.Add(
            new SqlParameter("@Mobile", host.MobileNo));
                command.Parameters.Add(
            new SqlParameter("@Gender", host.Gender));
                command.Parameters.Add(
            new SqlParameter("@PEmail", host.ParentEmail));
                command.Parameters.Add(
            new SqlParameter("@PMobile", host.ParentMobileNo));
                command.Parameters.Add(
            new SqlParameter("@Course", host.Course));
                command.Parameters.Add(
            new SqlParameter("@Branch", host.Branch));
                command.Parameters.Add(
            new SqlParameter("@studyingYear", host.studyingYear));
                command.Parameters.Add(
            new SqlParameter("@RoomID", host.RoomID));
                command.Parameters.Add(
            new SqlParameter("@FeesStatus", host.FeesStatus));
                command.Parameters.Add(
            new SqlParameter("@BalanceAmount", host.BalanceAmount));
                command.Parameters.Add(
            new SqlParameter("@SeatStatus", host.SeatStatus));
                command.Parameters.Add(
            new SqlParameter("@AllotedDate", host.AllotedDate));
                command.Parameters.Add(
            new SqlParameter("@AddedBy", host.AddedBy));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", host.AddedDate));
                command.Parameters.Add(
            new SqlParameter("@Bulkupload", host.Bulkupload));
                command.Parameters.Add(
            new SqlParameter("@HostelName", Convert.ToInt32(host.HostelName)));
                command.Parameters.Add(
            new SqlParameter("@HostelFloor", Convert.ToInt32(host.HostelFloor)));
                command.Parameters.Add(
            new SqlParameter("@RoomNumber", Convert.ToInt32(host.RoomNumber)));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    
    public int AddTestEmpDetails(string EmpName,string EmpID,string Age)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddTestEmpDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@EmpName", EmpName));
                command.Parameters.Add(
            new SqlParameter("@EmpID", EmpID));
                command.Parameters.Add(
            new SqlParameter("@Age", Age));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewRoomDetailsByID(int RoomID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewRoomDetailsByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@RoomID", RoomID));
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

    public int ViewHostelStudCountByRoomID(int RoomID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int count = 0;
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewHostelStudCountByRoomID", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RoomID", RoomID));
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return count;
    }

    public DataSet ViewHostStudByID(string stStudID, string strmode, string sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostStudByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@StudID", stStudID));
                command.Parameters.Add(
                  new SqlParameter("@flag", strmode));
                command.Parameters.Add(
                   new SqlParameter("@sno", Convert.ToInt32(sno)));
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

    public DataSet ViewHostStudByEmail(string strStudEmail, string strmode, string sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostStudByEmail", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@StudEmail", strStudEmail));
                command.Parameters.Add(
                   new SqlParameter("@flag", strmode));
                command.Parameters.Add(
                   new SqlParameter("@sno", Convert.ToInt32(sno)));
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

    public DataSet ViewHostelStudentDetails(string srchval, string sthostel, string stfloor, string stroomtype, string stroom, string stcoursename, string stbranch, string stfeestatus, string stseatstatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@srchval", srchval));
                command.Parameters.Add(
                    new SqlParameter("@hostelID", sthostel));
                command.Parameters.Add(
                    new SqlParameter("@floorID", stfloor));
                command.Parameters.Add(
                    new SqlParameter("@roomtype", stroomtype));
                command.Parameters.Add(
                    new SqlParameter("@roomID", stroom));
                command.Parameters.Add(
                    new SqlParameter("@Course", stcoursename));
                command.Parameters.Add(
                    new SqlParameter("@Branch", stbranch));
                command.Parameters.Add(
                    new SqlParameter("@FeesStatus", stfeestatus));
                command.Parameters.Add(
                    new SqlParameter("@SeatStatus", stseatstatus));
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

    public DataSet ViewHostelStudentDetailsByID(string strSno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelStudentDetailsByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Sno", strSno));
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

    public int UpdateHostelStudentDetails(HostelMgmt host)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateHostelStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
            new SqlParameter("@StudSno", host.Sno));
                command.Parameters.Add(
            new SqlParameter("@StudName", host.StudentName));
                command.Parameters.Add(
            new SqlParameter("@StudID", host.StudentID));
                command.Parameters.Add(
            new SqlParameter("@Email", host.Email));
                command.Parameters.Add(
            new SqlParameter("@Mobile", host.MobileNo));
                command.Parameters.Add(
            new SqlParameter("@Gender", host.Gender));
                command.Parameters.Add(
            new SqlParameter("@PEmail", host.ParentEmail));
                command.Parameters.Add(
            new SqlParameter("@PMobile", host.ParentMobileNo));
                command.Parameters.Add(
            new SqlParameter("@Course", host.Course));
                command.Parameters.Add(
            new SqlParameter("@Branch", host.Branch));
                command.Parameters.Add(
            new SqlParameter("@studyingYear", host.studyingYear));
                command.Parameters.Add(
            new SqlParameter("@FeesStatus", host.FeesStatus));
                command.Parameters.Add(
            new SqlParameter("@BalanceAmount", host.BalanceAmount));
                command.Parameters.Add(
            new SqlParameter("@SeatStatus", host.SeatStatus));
                command.Parameters.Add(
            new SqlParameter("@AllotedDate", host.AllotedDate));
                command.Parameters.Add(
            new SqlParameter("@UpdatedBy", host.UpdatedBy));
                command.Parameters.Add(
            new SqlParameter("@UpdatedDate", host.UpdatedDate));
                command.Parameters.Add(
            new SqlParameter("@RoomID", host.RoomID));
                command.Parameters.Add(
            new SqlParameter("@HostelName", Convert.ToInt32(host.HostelName)));
                command.Parameters.Add(
            new SqlParameter("@HostelFloor", Convert.ToInt32(host.HostelFloor)));
                command.Parameters.Add(
            new SqlParameter("@RoomNumber", Convert.ToInt32(host.RoomNumber)));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int DeleteHostelStudentDetails(int Sno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("DeleteHostelStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@Sno", Sno));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewEnquiredHostelStudentDetails(string sthostel, string stfloor, string stroomtype, string stroom, string stcoursename, string stbranch)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewEnquiredHostelStudentDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@hostelID", sthostel));
                command.Parameters.Add(
                    new SqlParameter("@floorID", stfloor));
                command.Parameters.Add(
                    new SqlParameter("@roomtype", stroomtype));
                command.Parameters.Add(
                    new SqlParameter("@roomID", stroom));
                command.Parameters.Add(
                    new SqlParameter("@Course", stcoursename));
                command.Parameters.Add(
                    new SqlParameter("@Branch", stbranch));
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

    public DataSet ViewFloorwiseSeatReport(string sthostel, string stfloor)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewFloorwiseSeatReport", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@hostelID", Convert.ToInt32(sthostel)));
                command.Parameters.Add(
                    new SqlParameter("@floorID", Convert.ToInt32(stfloor)));
               
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

    public DataSet ViewHostelwiseSeatReport(string sthostel)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelwiseSeatReport", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@hostelID", Convert.ToInt32(sthostel)));

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

    public DataSet GetHostelID(string strhostel)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("GetHostelID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@HostelName", strhostel));
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

    public DataSet GetFloorID(string strfloor, string hostelID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("GetFloorID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@FloorName", strfloor));
                command.Parameters.Add(
                    new SqlParameter("@HostelID", hostelID));
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

    public DataSet GetRoomID(string strRoom, string hostelID, string FloorID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("GetRoomID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@RoomNo", strRoom));
                command.Parameters.Add(
                    new SqlParameter("@HostelID", hostelID));
                command.Parameters.Add(
                    new SqlParameter("@FloorID", FloorID));
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
	
    public DataSet ViewEnquiredHostelStudentDetailsByID(string strSno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewEnquiredHostelStudentDetailsByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@Sno", strSno));
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
    public DataSet ViewStudentByRoomNo(string stRoomID, string stRoomno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewStudentByRoomNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@RoomID", Convert.ToInt32(stRoomID)));
                command.Parameters.Add(
                new SqlParameter("@Roomno", Convert.ToInt32(stRoomno)));
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

    public DataSet ViewHostelRoomNo(string stFloorID, string sthostelID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewHostelRoomNo", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                new SqlParameter("@FloorID", Convert.ToInt32(stFloorID)));
                command.Parameters.Add(
                new SqlParameter("@HostelID", Convert.ToInt32(sthostelID)));
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

    public int UpdateParentEmailMobile(string ParentEmail, string ParentMobileNo, string StudSno)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateParentEmailMobile", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
            new SqlParameter("@StudSno", Convert.ToInt32(StudSno)));
                command.Parameters.Add(
            new SqlParameter("@PEmail", ParentEmail));
                command.Parameters.Add(
            new SqlParameter("@PMobile", ParentMobileNo));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int AddGatePassDetails(HostelMgmt host)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddGatePassDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
            new SqlParameter("@OutDate", host.OutDate));
                command.Parameters.Add(
            new SqlParameter("@OutTime", host.OutTime));
                command.Parameters.Add(
            new SqlParameter("@InDate", host.InDate));
                command.Parameters.Add(
            new SqlParameter("@InTime", host.InTime));
                command.Parameters.Add(
            new SqlParameter("@StudSno", host.StudSno));
                command.Parameters.Add(
            new SqlParameter("@Purpose", host.Purpose));
                command.Parameters.Add(
            new SqlParameter("@AddedBy", host.AddedBy));
                command.Parameters.Add(
            new SqlParameter("@AddedDate", host.AddedDate));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public DataSet ViewGatePassDetails(string sthostel, string stfloor, string stroomtype, string stroom, string stcoursename, string stbranch)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewGatePassDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    new SqlParameter("@hostelID", sthostel));
                command.Parameters.Add(
                    new SqlParameter("@floorID", stfloor));
                command.Parameters.Add(
                    new SqlParameter("@roomtype", stroomtype));
                command.Parameters.Add(
                    new SqlParameter("@roomID", stroom));
                command.Parameters.Add(
                    new SqlParameter("@Course", stcoursename));
                command.Parameters.Add(
                    new SqlParameter("@Branch", stbranch));
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