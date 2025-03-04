using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ConvocationList
/// </summary>
public class ConvocationAcceptanceList
{

    #region
    public string Name { get; set; }
    public string MobileNo { get; set; }
    public string DegreeBranch { get; set; }
    public string RegistrationNo { get; set; }
    public string EmailId { get; set; }
    public string PplComing { get; set; }
    public string OTPCode { get; set; }
    public bool OTPVerified { get; set; }

    public DateTime PostedDate { get; set; }
   
    #endregion

    public ConvocationAcceptanceList()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int InsertConvocationList(ConvocationAcceptanceList conv)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spInsertConvocationAcceptanceList2019", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@RegistrationNo", conv.RegistrationNo);
        cmd.Parameters.AddWithValue("@Name", conv.Name);
        cmd.Parameters.AddWithValue("@DegreeBranch", conv.DegreeBranch);
        cmd.Parameters.AddWithValue("@EnailId", conv.EmailId);
        cmd.Parameters.AddWithValue("@PplComing", conv.PplComing);
        cmd.Parameters.AddWithValue("@MobileNo", conv.MobileNo);
        cmd.Parameters.AddWithValue("@OTPVerified", conv.OTPVerified);
        cmd.Parameters.AddWithValue("@OTPNo", conv.OTPCode);
        cmd.Parameters.AddWithValue("@PostedDate", conv.PostedDate);  
        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
         con.Close();
        return rows;
    }
    public bool IsApplicationAlreadyRegistered(string RegistrationNo)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spConvocationListAlreadyExist2019", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
        int rows = Convert.ToInt32(cmd.ExecuteScalar());
		con.Close();
        return rows > 0 ? true : false;

    }
    public bool IsApplicationAlreadyRegisteredMobile(string MobileNo)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spConvocationListAlreadyExist2019bymobile", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MobileNo", MobileNo);
        int rows = Convert.ToInt32(cmd.ExecuteScalar());
		con.Close();
        return rows > 0 ? true : false;

    }
    public DataSet GetRegistrationDetails(string RegistrationNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("spConvocationListByRegNo", con))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
            new SqlParameter("@RegistrationNo", RegistrationNo));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }
        con.Close();
        return ds;


    }
    public DataSet GetMobileDetails(string MobileNo)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("spConvocationListByMobileNo", con))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
            new SqlParameter("@MobileNo", MobileNo));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }
        con.Close();
        return ds;


    }
    public DataSet GetRegistrationDetailsByDate(string FromDate, string ToDate)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("spConvocationAcceptanceListByDate", con))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
            new SqlParameter("@FromDate", FromDate));
            command.Parameters.Add(
          new SqlParameter("@ToDate", ToDate));
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }
        con.Close();
        return ds;


    }

    public DataSet GetAllRegistration()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        DataSet ds = new DataSet();
        using (SqlCommand command = new SqlCommand("spConvocationAcceptanceListAll", con))
        {
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
        }
        con.Close();
        return ds;


    }

    public DataTable Printdetails()
    {
        ConvocationList _form = new ConvocationList();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spConvocationListExport", con);
        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);
        con.Close();
        return dtAdmissionList;


    }

    public DataTable ListAll()
    {
        ConvocationList _form = new ConvocationList();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spConvocationListAll", con);
        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);
        con.Close();
        return dtAdmissionList;


    }

    public DataTable ListByDate(DateTime FromDate, DateTime ToDate)
    {
        ConvocationList _form = new ConvocationList();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spConvocationAdminSearch", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);
        
        dpt.Fill(dtAdmissionList);
        con.Close();
        return dtAdmissionList;

    }

    public DataTable ExportByDate(DateTime FromDate, DateTime ToDate)
    {
        ConvocationList _form = new ConvocationList();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spConvocationListExportBySearch", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@FromDate", FromDate);
        cmd.Parameters.AddWithValue("@ToDate", ToDate);

        DataTable dtAdmissionList = new DataTable();
        SqlDataAdapter dpt = new SqlDataAdapter(cmd);

        dpt.Fill(dtAdmissionList);
        con.Close();
        return dtAdmissionList;

    }
}