using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddSSDGI
/// </summary>
public class AddSSDGI
{
	public int Sno { get; set; }
	public string Title { get; set; }
	public bool Status  { get; set; }
	public string Image  { get; set; }
	public string Description  { get; set; }
	public string Content  { get; set; }




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





	public int AddGIDetails(AddSSDGI ASSD)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDAddGI", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@Title", ASSD.Title));
				command.Parameters.Add(new SqlParameter("@EventImage", ASSD.Image));
				command.Parameters.Add(new SqlParameter("@Content",ASSD.Content));
				command.Parameters.Add(new SqlParameter("@EStatus", Status));
				command.Parameters.Add(new SqlParameter("@EDescription",Description));
				command.Parameters.Add(new SqlParameter("@Addeddate",Utility.IndianTime));
				rowsAffected = command.ExecuteNonQuery();
			}
			cnn.Close();
		}
		catch (Exception ex)
		{

		}
		return rowsAffected;
	}
	public int UpdateGIDetails(AddSSDGI ASSD)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDUpdateGI", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@Sno", ASSD.Sno));
				command.Parameters.Add(new SqlParameter("@Title", ASSD.Title));
				command.Parameters.Add(new SqlParameter("@EventImage", ASSD.Image));
				command.Parameters.Add(new SqlParameter("@Content",ASSD.Content));
				command.Parameters.Add(new SqlParameter("@EStatus", Status));
				command.Parameters.Add(new SqlParameter("@EDescription",Description));
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
	
	public int UpdateStatus(int ID,bool status)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPIpdatestatus", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@Sno", ID));
				command.Parameters.Add(new SqlParameter("@Status", status));
				rowsAffected = command.ExecuteNonQuery();
			}
			cnn.Close();
		}
		catch (Exception ex)
		{

		}
		return rowsAffected;
	}
	
	public int deleteGIByID(int ID)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDDeleteGIByID", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@Sno", ID));
				rowsAffected = command.ExecuteNonQuery();
			}
			cnn.Close();
		}
		catch (Exception ex)
		{

		}
		return rowsAffected;
	}





	public DataSet ViewGIBYID(int ID)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		DataSet ds = new DataSet();
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPViewGIByID", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@Sno", ID));			
				SqlDataAdapter da = new SqlDataAdapter(command);
				da.Fill(ds);
			}
		}
		catch (Exception ex)
		{
		}

		return ds;
	}
	public DataSet ViewGI()
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		DataSet ds = new DataSet();
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPViewGI", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;		
				SqlDataAdapter da = new SqlDataAdapter(command);
				da.Fill(ds);
			}
		}
		catch (Exception ex)
		{
		}

		return ds;
	}



}