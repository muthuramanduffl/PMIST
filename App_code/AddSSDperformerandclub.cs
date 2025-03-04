using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Addperformerandclub
/// </summary>
public class AddSSDperformerandclub
{

    public int Sno { get; set; }
    public string StudentName { get; set; }
    public string Placewon { get; set; }
    public string department { get; set; }
    public string Event { get; set; }
    public bool DisplayStatus { get; set; }
    public string Description { get; set; }
    public string Clubs { get; set; }
    public string Month { get; set; }
    public string Year { get; set; }
    public string UploadImage { get; set; }







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





    public int AddPerformer(AddSSDperformerandclub AP)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPAddperformer", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Studentname", AP.StudentName));
                command.Parameters.Add(new SqlParameter("@PlaceWon", AP.Placewon));
                command.Parameters.Add(new SqlParameter("@Studentimage", AP.UploadImage));
                command.Parameters.Add(new SqlParameter("@Department", AP.department));
                command.Parameters.Add(new SqlParameter("@Clubsandprofessional", AP.Clubs));
                command.Parameters.Add(new SqlParameter("@DisplayStatus", AP.DisplayStatus));
                command.Parameters.Add(new SqlParameter("@Description", AP.Description));
                command.Parameters.Add(new SqlParameter("@Pmonth", AP.Month));
                command.Parameters.Add(new SqlParameter("@Pyear", AP.Year));
                command.Parameters.Add(new SqlParameter("@Addeddate", Utility.IndianTime));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public int AddClub(AddSSDperformerandclub AP)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPAddClubDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ClubName", AP.Clubs));
                command.Parameters.Add(new SqlParameter("@ClubDescription", AP.Description));
                command.Parameters.Add(new SqlParameter("@CMonth", AP.Month));
                command.Parameters.Add(new SqlParameter("@CYear", AP.Year));
                command.Parameters.Add(new SqlParameter("@DisplayStatus", AP.DisplayStatus));
                command.Parameters.Add(new SqlParameter("@Addeddate", Utility.IndianTime));


                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }

    public int UpdatePerformer(AddSSDperformerandclub AP)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPUpdateperformer", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Sno", AP.Sno));
                command.Parameters.Add(new SqlParameter("@Studentname", AP.StudentName));
                command.Parameters.Add(new SqlParameter("@PlaceWon", AP.Placewon));
                command.Parameters.Add(new SqlParameter("@Studentimage", AP.UploadImage));
                command.Parameters.Add(new SqlParameter("@Department", AP.department));
                command.Parameters.Add(new SqlParameter("@Clubsandprofessional", AP.Clubs));
                command.Parameters.Add(new SqlParameter("@DisplayStatus", AP.DisplayStatus));
                command.Parameters.Add(new SqlParameter("@Description", AP.Description));
                command.Parameters.Add(new SqlParameter("@Pmonth", AP.Month));
                command.Parameters.Add(new SqlParameter("@Pyear", AP.Year));
                command.Parameters.Add(new SqlParameter("@Updatedate", Utility.IndianTime));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }


    public int UpdateClub(AddSSDperformerandclub AP)
    {
        int Sno = 0;
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPUpdateClubDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Sno", AP.Sno));
                command.Parameters.Add(new SqlParameter("@ClubName", AP.Clubs));
                command.Parameters.Add(new SqlParameter("@ClubDescription", AP.Description));
                command.Parameters.Add(new SqlParameter("@CMonth", AP.Month));
                command.Parameters.Add(new SqlParameter("@CYear", AP.Year));
                command.Parameters.Add(new SqlParameter("@DisplayStatus", AP.DisplayStatus));


                command.Parameters.Add(new SqlParameter("@UpdatedDate", Utility.IndianTime));

                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }



    public int UpdateStatusPerformer(int Sno, bool Status)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPUpdatestatusPerformer", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Sno", Sno));
                command.Parameters.Add(new SqlParameter("@DisplayStatus", Status));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }
    public int UpdateStatusClub(int Sno, bool Status)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPUpdateStatus", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", Sno));
                command.Parameters.Add(new SqlParameter("@DisplayStatus", Status));
                rowsAffected = command.ExecuteNonQuery();
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rowsAffected;
    }



    public DataSet ViewByid(int Sno)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPViewperformerDetails", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@sno", Sno));



                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public DataSet ViewClubByid(int ID)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPViewClubByid", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", Sno));



                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }
    public void DeleteBYId(int ID)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPDeletePerformer", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Sno", ID));
                command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }

    }


    public void DeleteClubBYId(int ID)
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPDeleteclub", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", ID));
                command.ExecuteNonQuery();

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }

    }


    public DataSet View()
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPViewPerformer", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }






    public DataSet ViewLastmontRecords()
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPGetTopRecordFromLastMonth", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }

    public DataSet ViewClubLastmontRecords()
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPGetTopRecordFromLastMonthInClub", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }


    public DataSet ViewClub()
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("SPSTPViewClub", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(ds);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return ds;
    }







    public DataTable ViewClubByID(int ID)
    {
		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		DataTable dt = new DataTable();
		int rowsAffected = 0;
		try
		{
			

			using (SqlCommand command = new SqlCommand("SPSSDViewNameClubByid", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@Id", ID));
				SqlDataAdapter DA = new SqlDataAdapter(command);
				DA.Fill(dt);

			}
			cnn.Close();
		}
		catch (Exception ex)
		{
		}
		return dt;
	} 
    
    
    public DataTable ViewClubName()
    {

        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataTable dt = new DataTable();
        int rowsAffected = 0;
        try
        {


			using (SqlCommand command = new SqlCommand("SPSSDViewNameClub", cnn))
            {
                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;
			
				SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(dt);

            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dt;
    }


































}