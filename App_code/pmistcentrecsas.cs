using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for pmistcentrecsas
/// </summary>
public class pmistcentrecsas
{

    public int intTCCID { get; set; }
    public string strcentreID { get; set; }
    public string strtitle { get; set; }
    public string strcontent { get; set; }
    public bool booldisplaystatus { get; set; }
    public string strCnameOne { get; set; }
    public string strDesignationOne { get; set; }
    public string strMobilenumberOne { get; set; }
    public string strEmailiDOne { get; set; }
    public string strAddressOne { get; set; }

    public string strCnametwo { get; set; }
    public string strDesignationtwo { get; set; }
    public string strMobilenumbertwo { get; set; }
    public string strEmailiDtwo { get; set; }
    public string strAddresstwo { get; set; }

    public string strCnamethree { get; set; }
    public string strDesignationthree { get; set; }
    public string strMobilenumberthree { get; set; }
    public string strEmailiDthree { get; set; }
    public string strAddressthree { get; set; }


    public string strimages { get; set; }
    public string strPageType { get; set; }
    public string straddedBy { get; set; }






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


    public int addcentrecontenttype1(pmistcentrecsas csas)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("addcentrecontenttype1", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CentreID", csas.strcentreID));
                command.Parameters.Add(new SqlParameter("@Title", csas.strtitle));
                command.Parameters.Add(new SqlParameter("@Content", csas.strcontent));
                command.Parameters.Add(new SqlParameter("@DisplayStatus", csas.booldisplaystatus));
                command.Parameters.Add(new SqlParameter("@Designamtion_one", csas.strDesignationOne));
                command.Parameters.Add(new SqlParameter("@Cname_one", csas.strCnameOne));
                command.Parameters.Add(new SqlParameter("@Mobilenumber_one", csas.strMobilenumberOne));
                command.Parameters.Add(new SqlParameter("@EmailID_one", csas.strEmailiDOne));
                command.Parameters.Add(new SqlParameter("@Address_one", csas.strAddressOne));

                command.Parameters.Add(new SqlParameter("@Cname_two", csas.strCnametwo));
                command.Parameters.Add(new SqlParameter("@Designamtion_two", csas.strDesignationtwo));
                command.Parameters.Add(new SqlParameter("@Mobilenumber_two", csas.strMobilenumbertwo));
                command.Parameters.Add(new SqlParameter("@EmailID_two", csas.strEmailiDtwo));
                command.Parameters.Add(new SqlParameter("@Address_two", csas.strAddresstwo));

                command.Parameters.Add(new SqlParameter("@Cname_three", csas.strCnamethree));
                command.Parameters.Add(new SqlParameter("@Designamtion_three", csas.strDesignationthree));
                command.Parameters.Add(new SqlParameter("@Mobilenumber_three", csas.strMobilenumberthree));
                command.Parameters.Add(new SqlParameter("@EmailID_three", csas.strEmailiDthree));
                command.Parameters.Add(new SqlParameter("@Address_three", csas.strAddressthree));
              
                command.Parameters.Add(new SqlParameter("@Imges", csas.strimages));
                command.Parameters.Add(new SqlParameter("@PageType", csas.strPageType));
                command.Parameters.Add(new SqlParameter("@AddedBy", csas.straddedBy));
                command.Parameters.Add(new SqlParameter("@AddedDate", Utility.IndianTime));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int Updatecentrecontenttype1(pmistcentrecsas csas)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("Updatecentrecontenttype1", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TCCID", csas.intTCCID));
                command.Parameters.Add(new SqlParameter("@CentreID", csas.strcentreID));
                command.Parameters.Add(new SqlParameter("@Title", csas.strtitle));
                command.Parameters.Add(new SqlParameter("@Content", csas.strcontent));
                command.Parameters.Add(new SqlParameter("@DisplayStatus", csas.booldisplaystatus));
                command.Parameters.Add(new SqlParameter("@Designamtion_one", csas.strDesignationOne));
                command.Parameters.Add(new SqlParameter("@Cname_one", csas.strCnameOne));
                command.Parameters.Add(new SqlParameter("@Mobilenumber_one", csas.strMobilenumberOne));
                command.Parameters.Add(new SqlParameter("@EmailID_one", csas.strEmailiDOne));
                command.Parameters.Add(new SqlParameter("@Address_one", csas.strAddressOne));
                command.Parameters.Add(new SqlParameter("@Cname_two", csas.strCnametwo));
                command.Parameters.Add(new SqlParameter("@Designamtion_two", csas.strDesignationtwo));
                command.Parameters.Add(new SqlParameter("@Mobilenumber_two", csas.strMobilenumbertwo));
                command.Parameters.Add(new SqlParameter("@EmailID_two", csas.strEmailiDtwo));
                command.Parameters.Add(new SqlParameter("@Address_two", csas.strAddresstwo));
                command.Parameters.Add(new SqlParameter("@Cname_three", csas.strCnamethree));
                command.Parameters.Add(new SqlParameter("@Designamtion_three", csas.strDesignationthree));
                command.Parameters.Add(new SqlParameter("@Mobilenumber_three", csas.strMobilenumberthree));
                command.Parameters.Add(new SqlParameter("@EmailID_three", csas.strEmailiDthree));
                command.Parameters.Add(new SqlParameter("@Address_three", csas.strAddressthree));
                command.Parameters.Add(new SqlParameter("@Imges", csas.strimages));
                command.Parameters.Add(new SqlParameter("@PageType", csas.strPageType));
                command.Parameters.Add(new SqlParameter("@UpdatedBy", csas.straddedBy));
                command.Parameters.Add(new SqlParameter("@updatedDate", Utility.IndianTime));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateimagesByID(pmistcentrecsas csas)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("UpdateimagesByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TCCID", csas.intTCCID));               
                command.Parameters.Add(new SqlParameter("@Imges", csas.strimages));              
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }




    public int Deletecentrecontenttype1ByID(int ID)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("Deletecentrecontenttype1ByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TCCID", ID));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }




    public DataTable viewAllcentrecontenttype1(string CenterID, string status, string TCCID)
    {
        bool? boolValue = null;
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("viewAllcentrecontenttype1", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CentreID", CenterID));
                command.Parameters.Add(new SqlParameter("@TCCID", string.IsNullOrWhiteSpace(TCCID) ? (object)DBNull.Value : Convert.ToInt32(TCCID)));
                if (!string.IsNullOrWhiteSpace(status))
                {
                    if (status == "1" || status.ToLower() == "true")
                        boolValue = true;
                    else if (status == "0" || status.ToLower() == "false")
                        boolValue = false;
                }

                command.Parameters.Add(new SqlParameter("@DisplayStatus", boolValue.HasValue ? (object)boolValue.Value : DBNull.Value));
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(dt);
            }
        }
        catch (Exception ex)
        {

        }
        return dt;
    }
    public DataTable viewAllcentretype()
    {
        bool? boolValue = null;
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("viewAlltblcentrenames", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(dt);
            }
        }
        catch (Exception ex)
        {

        }
        return dt;
    }

    public DataTable viewcentrenamesByID(string CID)
    {
        bool? boolValue = null;
        DataTable dt = new DataTable();
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        try
        {
            using (SqlCommand command = new SqlCommand("viewcentrenamesByID", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", CID));
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(dt);
            }
        }
        catch (Exception ex)
        {

        }
        return dt;
    }





}