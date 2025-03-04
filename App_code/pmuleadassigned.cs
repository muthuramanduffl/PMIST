using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

/// <summary>
/// Summary description for Album
/// </summary>
public class leadassigned
{
    public int Sno { get; set; }
    public string LeadId { get; set; }
    public string AssignedTo { get; set; }
    public string AssignedRole { get; set; }
    public string AssignedBy { get; set; }
    public string AssignById { get; set; }
    public DateTime AssignedDate { get; set; }
    
    public leadassigned()
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
    public int Addleadassigned(leadassigned lassigned)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rowsAffected = 0;
        try
        {
            using (SqlCommand command = new SqlCommand("AddLeadAssigned", cnn))
            {

                cnn.Open();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
              new SqlParameter("@LeadId", lassigned.LeadId));
                command.Parameters.Add(
             new SqlParameter("@AssignedTo", lassigned.AssignedTo));
                command.Parameters.Add(
            new SqlParameter("@AssignedRole", lassigned.AssignedRole));
                command.Parameters.Add(
           new SqlParameter("@AssignedBy", lassigned.AssignedBy));
                command.Parameters.Add(
             new SqlParameter("@AssignById", lassigned.AssignById));
                command.Parameters.Add(
                   new SqlParameter("@AssignedDate", lassigned.AssignedDate));
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