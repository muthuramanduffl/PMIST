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
public class ConvocationList
{

    #region
    public string Name { get; set; }
    public string AddressDetails { get; set; }
    public string Gender { get; set; }
    public string MobileNo { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Degree { get; set; }
    public string Batch { get; set; }
    public string Branch { get; set; }
    public string Rank { get; set; }
    public string Specilalization { get; set; }
    public string ModeOfReceiving { get; set; }
    public string RegistrationNo { get; set; }
    public string EmailId { get; set; }
    public string YearOfPassing { get; set; }
    public DateTime PostedDate { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }

    #endregion

    public ConvocationList()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int Create()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spConvocationListCreate", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        CultureInfo provider = CultureInfo.InvariantCulture;
        System.Globalization.DateTimeStyles style = DateTimeStyles.None;


        cmd.Parameters.AddWithValue("@RegistrationNo", this.RegistrationNo);
        cmd.Parameters.AddWithValue("@Name", this.Name);
        cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
        cmd.Parameters.AddWithValue("@MobileNo", this.MobileNo);
        cmd.Parameters.AddWithValue("@EmailId", this.EmailId);
        cmd.Parameters.AddWithValue("@Gender", this.Gender);
        cmd.Parameters.AddWithValue("@ModeOfReceiving", this.ModeOfReceiving);
        cmd.Parameters.AddWithValue("@Degree", this.Degree);
        cmd.Parameters.AddWithValue("@Rank", this.Rank);
        cmd.Parameters.AddWithValue("@Branch", this.Branch);
        cmd.Parameters.AddWithValue("@Batch", this.Batch);
        cmd.Parameters.AddWithValue("@YearOfPassing", this.YearOfPassing);
        cmd.Parameters.AddWithValue("@Specialization", this.Specilalization);
        cmd.Parameters.AddWithValue("@AddressDetails", this.AddressDetails);
        cmd.Parameters.AddWithValue("@PostedDate", this.PostedDate);      
        
        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
         
        return rows;
    }

    public bool IsApplicationAlreadyRegistered(string RegistrationNo)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spConvocationListAlreadyExist", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        cmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);

        int rows = Convert.ToInt32(cmd.ExecuteScalar());

        return rows > 0 ? true : false;

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

        return dtAdmissionList;

    }

    public int AddConvocationList2019(ConvocationList conv)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PMU"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("spInserttblConvocationList2019", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@RegistrationNo", conv.RegistrationNo);
        cmd.Parameters.AddWithValue("@Name", conv.Name);
        cmd.Parameters.AddWithValue("@Degree", conv.Degree);
        cmd.Parameters.AddWithValue("@Branch", conv.Branch);
        cmd.Parameters.AddWithValue("@PostedDate", conv.PostedDate);

        int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
        con.Close();
        return rows;
    }
    
}