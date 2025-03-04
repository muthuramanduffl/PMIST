using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddSSDExtAct
/// </summary>
public class AddSSDExtAct
{
	public int Sno { get; set; }
	public string Year { get; set; }
	public string Eventtype { get; set; }
	public string Title { get; set; }
	public string Participant { get; set; }
	public string Description { get; set; }
	public string EventImage { get; set; }
	public string Location { get; set; }
	public bool Status { get; set; }
	public DateTime Fromdate { get; set; }
	public DateTime Todate { get; set; }





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




	public int AddExtAct(AddSSDExtAct AE)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDAddExtAct", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@EYear", AE.Year));
				command.Parameters.Add(new SqlParameter("@Title", AE.Title));
				command.Parameters.Add(new SqlParameter("@ELocation", AE.Location));
				command.Parameters.Add(new SqlParameter("@Eventtype", AE.Eventtype));
				command.Parameters.Add(new SqlParameter("@Participant", AE.Participant));
				command.Parameters.Add(new SqlParameter("@EDescription", AE.Description));
				command.Parameters.Add(new SqlParameter("@Eventimage", AE.EventImage));
				command.Parameters.Add(new SqlParameter("@FromDate", AE.Fromdate));
				command.Parameters.Add(new SqlParameter("@Todate", AE.Todate));
				command.Parameters.Add(new SqlParameter("@EAstatus", AE.Status));
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


	public int UpdateExtAct(AddSSDExtAct AE)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDUpdateExtAct", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@Sno", AE.Sno));
				command.Parameters.Add(new SqlParameter("@EYear", AE.Year));
				command.Parameters.Add(new SqlParameter("@Title", AE.Title));
				command.Parameters.Add(new SqlParameter("@Eventtype", AE.Eventtype));
				command.Parameters.Add(new SqlParameter("@ELocation", AE.Location));
				command.Parameters.Add(new SqlParameter("@Participant", AE.Participant));
				command.Parameters.Add(new SqlParameter("@EDescription", AE.Description));
				command.Parameters.Add(new SqlParameter("@Eventimage", AE.EventImage));
				command.Parameters.Add(new SqlParameter("@FromDate", AE.Fromdate));
				command.Parameters.Add(new SqlParameter("@Todate", AE.Todate));
				command.Parameters.Add(new SqlParameter("@EAstatus", AE.Status));
				command.Parameters.Add(new SqlParameter("@updatedate", Utility.IndianTime));
				rowsAffected = command.ExecuteNonQuery();
			}
			cnn.Close();
		}
		catch (Exception ex)
		{
		}
		return rowsAffected;
	}	
		
	
	public int UpdatestatusExtAct(int Sno,bool Status)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDEXTACTUpdatestatus", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@Sno", Sno));
				command.Parameters.Add(new SqlParameter("@Status",Status));				
				rowsAffected = command.ExecuteNonQuery();
			}
			cnn.Close();
		}
		catch (Exception ex)
		{
		}
		return rowsAffected;
	}	
	
	
	public int DeleteExtAct(int ID)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDDeleteExtActByID", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@ID", ID));	
				rowsAffected = command.ExecuteNonQuery();
			}
			cnn.Close();
		}
		catch (Exception ex)
		{
		}
		return rowsAffected;
	}


	public DataSet ViewExtAct(int ID)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		DataSet ds = new DataSet();
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDViewExtActByID", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@ID ", ID));
				SqlDataAdapter da = new SqlDataAdapter(command);
				da.Fill(ds);
			}
		}
		catch (Exception ex)
		{
		}

		return ds;
	}
	public DataSet ViewExtAct()
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		DataSet ds = new DataSet();
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDViewExtAct", cnn))
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
	
	public DataTable ViewExtActyear()
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		DataTable ds = new DataTable();
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDExtActviewyear", cnn))
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

	public DataTable ViewExtActViewByyear(string year)
	{

		string connetionString = null;
		SqlConnection cnn;
		connetionString = GetSqlConnection();
		cnn = new SqlConnection(connetionString);
		DataTable ds = new DataTable();
		int rowsAffected = 0;
		try
		{
			using (SqlCommand command = new SqlCommand("SPSSDExtActviewByYear", cnn))
			{
				cnn.Open();
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@Year", year));
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