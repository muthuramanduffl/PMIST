using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Collections;

/// <summary>
/// Summary description for LoadDropdown
/// </summary>
public class LoadDropdown
{
    public LoadDropdown()
    {
        //
        // TODO: Add constructor logic here
        //
    }
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

    public void BindCaste(DropDownList ddl)
    {
        DataSet ds = ViewCaste();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["Caste"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }
   
    public DataSet ViewCaste()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCaste", cnn))
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

    public void BindReligion(DropDownList ddl)
    {
        DataSet ds = ViewReligion();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["Religion"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewReligion()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewReligion", cnn))
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

    public void BindCommunity(DropDownList ddl)
    {
        DataSet ds = ViewCommunity();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["Community"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewCommunity()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCommunity", cnn))
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

    public void BindNationality(DropDownList ddl)
    {
        DataSet ds = ViewNationality();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["Nationality"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewNationality()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewNationality", cnn))
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





    public void BindCommunityCentralQuota(DropDownList ddl)
    {
        DataSet ds = ViewCommunityCentralQuota();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["Community"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewCommunityCentralQuota()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCommunityCentralQuota", cnn))
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


    public void BindOccupation(DropDownList ddl)
    {
        DataSet ds = ViewOccupation();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["occupation"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewOccupation()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewOccupation", cnn))
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

    public void BindSchoolBoard(DropDownList ddl)
    {
        DataSet ds = ViewSchoolBoard();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["SchoolBoard"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewSchoolBoard()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewSchoolBoard", cnn))
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

    public void BindSchoolName(DropDownList ddl)
    {
        DataSet ds = ViewSchoolName();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["SchoolName"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["SchoolID"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewSchoolName()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewSchoolName", cnn))
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

    public void BindSchoolCategory(DropDownList ddl)
    {
        DataSet ds = ViewSchoolCategory();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["SchoolCategory"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewSchoolCategory()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewSchoolCategory", cnn))
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

    public void BindBloodGroup(DropDownList ddl)
    {
        DataSet ds = ViewBloodGroup();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["Bloodgrp"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewBloodGroup()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewBloodGroup", cnn))
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

    public void BindMotherTongue(DropDownList ddl)
    {
        DataSet ds = ViewMotherTongue();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["MotherTongue"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewMotherTongue()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewMotherTongue", cnn))
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
 
    public void BindSubjectList(DropDownList ddl)
    {
        DataSet ds = ViewSubjectList();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["Subjectname"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewSubjectList()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewSubjectList", cnn))
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

    public void BindCivicstatusSchool(DropDownList ddl)
    {
        DataSet ds = ViewCivicStatusSchool();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["CivicStatusSchool"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewCivicStatusSchool()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewCivicStatusSchool", cnn))
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

    public void BindQualification(DropDownList ddl)
    {
        DataSet ds = ViewQualification();
        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            string stText = string.Empty;
            string stValue = string.Empty;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stText = Convert.ToString(ds.Tables[0].Rows[i]["Qualification"]);
                stValue = Convert.ToString(ds.Tables[0].Rows[i]["Id"]);
                ddl.Items.Add(new ListItem(stText, stValue));
            }
            ddl.DataBind();
        }
    }

    public DataSet ViewQualification()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet ds = new DataSet();
        try
        {
            using (SqlCommand command = new SqlCommand("ViewQualification", cnn))
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

}