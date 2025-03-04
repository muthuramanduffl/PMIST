using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for Adduser
/// </summary>
public class AddSSDuser
{
    public int Sno { get; set; }
    public string Club { get; set; }
    public string name { get; set; }
    public string Role { get; set; }
    public string Designation { get; set; }
    public string PhoneNumber { get; set; }
    public string Emailid { get; set; }
    public string Username { get; set; }
    public string password { get; set; }
    public bool status { get; set; }



    #region GetSqlConnectionstring
    public string GetSqlConnection()
    {
        string connectionString = null;
        try
        {

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMUSSD"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connectionString;
    }
    #endregion



    //public int Adduserdetails(Adduser AU)
    //{

    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);
    //    int rowsAffected = 0;
    //    try
    //    {
    //        using (SqlCommand command = new SqlCommand("SPSTPAddUserDetails", cnn))
    //        {
    //            cnn.Open();
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(new SqlParameter("@Clubsprofessional", AU.Club));
    //            command.Parameters.Add(new SqlParameter("@Name", AU.name));
    //            command.Parameters.Add(new SqlParameter("@Role",AU.Role));
    //            command.Parameters.Add(new SqlParameter("@Designation",AU.Designation ));
    //            command.Parameters.Add(new SqlParameter("@Phonenumber", AU.PhoneNumber));
    //            command.Parameters.Add(new SqlParameter("@Emailid",AU.Emailid));
    //            command.Parameters.Add(new SqlParameter("@Username", AU.Username));
    //            command.Parameters.Add(new SqlParameter("@Password", AU.password));
    //            command.Parameters.Add(new SqlParameter("@Status", AU.status));
    //            command.Parameters.Add(new SqlParameter("@Addeddate", Utility.IndianTime));             
    //            rowsAffected = command.ExecuteNonQuery();
    //        }
    //        cnn.Close();
    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //    return rowsAffected;
    //}
    //public int updateuserdetails(Adduser AU)
    //{

    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);
    //    int rowsAffected = 0;
    //    try
    //    {
    //        using (SqlCommand command = new SqlCommand("SPSTPUpdateLoginuser", cnn))
    //        {
    //            cnn.Open();
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(new SqlParameter("@ID", AU.Sno));
    //            command.Parameters.Add(new SqlParameter("@Clubsprofessional", AU.Club));
    //            command.Parameters.Add(new SqlParameter("@Name", AU.name));
    //            command.Parameters.Add(new SqlParameter("@Role",AU.Role));
    //            command.Parameters.Add(new SqlParameter("@Designation",AU.Designation ));
    //            command.Parameters.Add(new SqlParameter("@Phonenumber", AU.PhoneNumber));
    //            command.Parameters.Add(new SqlParameter("@Emailid",AU.Emailid));
    //            command.Parameters.Add(new SqlParameter("@Username", AU.Username));
    //            command.Parameters.Add(new SqlParameter("@Password", AU.password));
    //            command.Parameters.Add(new SqlParameter("@Status", AU.status));
    //            command.Parameters.Add(new SqlParameter("@updatetime", Utility.IndianTime));             
    //            rowsAffected = command.ExecuteNonQuery();
    //        }
    //        cnn.Close();
    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //    return rowsAffected;
    //}



    public DataSet ViewLogin(string username, string password)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSSDLOGIN", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@USERNAME", username));
                command.Parameters.Add(new SqlParameter("@PASSWORD", password));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);
            }
        }
        catch (Exception ex)
        {
        }

        return ds;
    } 
    
    
    //public DataSet Viewuser()
    //{

    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);
    //    DataSet ds = new DataSet();
    //    int rowsAffected = 0;
    //    try
    //    {
    //        using (SqlCommand command = new SqlCommand("SPSTPviewuser", cnn))
    //        {
    //            cnn.Open();
    //            command.CommandType = CommandType.StoredProcedure;
                
    //            SqlDataAdapter da = new SqlDataAdapter(command);
    //            da.Fill(ds);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //    }

    //    return ds;
    //}
    
    //public DataSet Viewuserbyid(int ID)
    //{

    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);
    //    DataSet ds = new DataSet();
    //    int rowsAffected = 0;
    //    try
    //    {
    //        using (SqlCommand command = new SqlCommand("SPSTPviewuserbyid", cnn))
    //        {
    //            cnn.Open();
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(new SqlParameter("@ID", ID));
    //            SqlDataAdapter da = new SqlDataAdapter(command);
    //            da.Fill(ds);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //    }

    //    return ds;
    //}


    //public DataTable Viewuserbynumber(string number)
    //{

    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);
    //    DataTable dt = new DataTable();
    //    int rowsAffected = 0;
    //    try
    //    {
    //        using (SqlCommand command = new SqlCommand("SPSTPviewuserBYNubmer", cnn))
    //        {
    //            cnn.Open();
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(new SqlParameter("@number", number));
    //            SqlDataAdapter da = new SqlDataAdapter(command);
    //            da.Fill(dt);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //    }

    //    return dt;
    //}
    
    
    //public DataSet Deleteuserbyid(int ID)
    //{

    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);
    //    DataSet ds = new DataSet();
    //    int rowsAffected = 0;
    //    try
    //    {
    //        using (SqlCommand command = new SqlCommand("SPSTPDeleteuserbyid", cnn))
    //        {
    //            cnn.Open();
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(new SqlParameter("@ID", ID));
    //            command.ExecuteNonQuery();  
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //    }

    //    return ds;
    //}
    //public DataSet updatestatusbyid(int ID,bool status)
    //{

    //    string connetionString = null;
    //    SqlConnection cnn;
    //    connetionString = GetSqlConnection();
    //    cnn = new SqlConnection(connetionString);
    //    DataSet ds = new DataSet();
    //    int rowsAffected = 0;
    //    try
    //    {
    //        using (SqlCommand command = new SqlCommand("SPSTPUpdateuserstatus", cnn))
    //        {
    //            cnn.Open();
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.Add(new SqlParameter("@ID", ID));
    //            command.Parameters.Add(new SqlParameter("@Status", status));
    //            command.ExecuteNonQuery();  
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //    }

    //    return ds;
    //}


}