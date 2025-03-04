using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for adminPgm
/// </summary>
public class adminPgm
{
    public string Department { get; set; }
    public string InsName { get; set; }
    public string InsDesignation { get; set; }
    public string InsImage { get; set; }
    public string Institution { get; set; }

    public string Department2 { get; set; }
    public string InsName2 { get; set; }
    public string InsDesignation2 { get; set; }
    public string InsImage2 { get; set; }
    public string Institution2 { get; set; }

    public string Title { get; set; }
    public string ThumbnailImage { get; set; }
    public string AboutProgram { get; set; }
    public string Rolefor { get; set; }
    public DateTime AddedDate { get; set; }
    public string AddedBy { get; set; }
    public string Chapter { get; set; }
    public string activestatus { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string UpdatedBy { get; set; }
    public string Lecture { get; set; }
    public string duration { get; set; }
    public string Contentformat { get; set; }
    public string contentvideofilename { get; set; }
    public string contentPdffilename { get; set; }

    public string Duration { get; set; }
    public string Credits { get; set; }
    public string Domain { get; set; }
    public string Practical { get; set; }
    public string Tutorial { get; set; }
    public string Totalhrs { get; set; }

    public adminPgm()
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

            connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;

        }
        catch (Exception ex)
        {
        }
        return connetionString;
    }

    public int AddDLPProgram(adminPgm pgm)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("AddDLPProgram", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Department", pgm.Department));
                cmd.Parameters.Add(new SqlParameter("@InsName", pgm.InsName));
                cmd.Parameters.Add(new SqlParameter("@InsDesignation", pgm.InsDesignation));
                cmd.Parameters.Add(new SqlParameter("@Institution", pgm.Institution));
                cmd.Parameters.Add(new SqlParameter("@Department2", pgm.Department2));
                cmd.Parameters.Add(new SqlParameter("@InsName2", pgm.InsName2));
                cmd.Parameters.Add(new SqlParameter("@InsDesignation2", pgm.InsDesignation2));
                cmd.Parameters.Add(new SqlParameter("@Institution2", pgm.Institution2));
                cmd.Parameters.Add(new SqlParameter("@InsImage", pgm.InsImage));
                cmd.Parameters.Add(new SqlParameter("@Title", pgm.Title));
                cmd.Parameters.Add(new SqlParameter("@ThumbnailImage", pgm.ThumbnailImage));
                cmd.Parameters.Add(new SqlParameter("@AboutProgram", pgm.AboutProgram));
                cmd.Parameters.Add(new SqlParameter("@Rolefor", pgm.Rolefor));
                cmd.Parameters.Add(new SqlParameter("@AddedDate", pgm.AddedDate));
                cmd.Parameters.Add(new SqlParameter("@AddedBy", pgm.AddedBy));

                cmd.Parameters.Add(new SqlParameter("@Duration", pgm.Duration));
                cmd.Parameters.Add(new SqlParameter("@Credits", pgm.Credits));
                cmd.Parameters.Add(new SqlParameter("@Domain", pgm.Domain));
                cmd.Parameters.Add(new SqlParameter("@Lecture", pgm.Lecture));
                cmd.Parameters.Add(new SqlParameter("@Practical", pgm.Practical));
                cmd.Parameters.Add(new SqlParameter("@Tutorial", pgm.Tutorial));
                cmd.Parameters.Add(new SqlParameter("@Totalhrs", pgm.Totalhrs));

                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }
    public DataSet ViewDLPProgramByTitle(string stTitle, string stDept)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPProgramByTitle", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Title", stTitle));
                cmd.Parameters.Add(new SqlParameter("@Dept", stDept));
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public DataSet ViewDLPPgmTitle(string stmode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPPgmTitle", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@column", stmode));
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public DataSet ViewDLPPgmwithFilter(string stpgm, string stDept, string stInsname, string stInsDesign, string stSearchval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPPgmwithFilter", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Pgm", stpgm));
                cmd.Parameters.Add(new SqlParameter("@Dept", stDept));
                cmd.Parameters.Add(new SqlParameter("@Insname", stInsname));
                cmd.Parameters.Add(new SqlParameter("@InsDesign", stInsDesign));
                cmd.Parameters.Add(new SqlParameter("@srchval", stSearchval));
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public int DeleteDLPPgm(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("DeleteDLPPgm", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }

    public DataSet ViewDLPPgm()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPPgm", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public int UpdateDLPProgram(adminPgm pgm, string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("UpdateDLPProgram", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));

                cmd.Parameters.Add(new SqlParameter("@Department", pgm.Department));
                cmd.Parameters.Add(new SqlParameter("@InsName", pgm.InsName));
                cmd.Parameters.Add(new SqlParameter("@InsDesignation", pgm.InsDesignation));
                cmd.Parameters.Add(new SqlParameter("@InsImage", pgm.InsImage));
                cmd.Parameters.Add(new SqlParameter("@Institution", pgm.Institution));
                cmd.Parameters.Add(new SqlParameter("@Department2", pgm.Department2));
                cmd.Parameters.Add(new SqlParameter("@InsName2", pgm.InsName2));
                cmd.Parameters.Add(new SqlParameter("@InsDesignation2", pgm.InsDesignation2));
                cmd.Parameters.Add(new SqlParameter("@Institution2", pgm.Institution2));

                cmd.Parameters.Add(new SqlParameter("@Title", pgm.Title));
                cmd.Parameters.Add(new SqlParameter("@ThumbnailImage", pgm.ThumbnailImage));
                cmd.Parameters.Add(new SqlParameter("@AboutProgram", pgm.AboutProgram));
                cmd.Parameters.Add(new SqlParameter("@Rolefor", pgm.Rolefor));
                cmd.Parameters.Add(new SqlParameter("@UpdatedDate", pgm.UpdatedDate));
                cmd.Parameters.Add(new SqlParameter("@UpdatedBy", pgm.UpdatedBy));

                cmd.Parameters.Add(new SqlParameter("@Duration", pgm.Duration));
                cmd.Parameters.Add(new SqlParameter("@Credits", pgm.Credits));
                cmd.Parameters.Add(new SqlParameter("@Domain", pgm.Domain));
                cmd.Parameters.Add(new SqlParameter("@Lecture", pgm.Lecture));
                cmd.Parameters.Add(new SqlParameter("@Practical", pgm.Practical));
                cmd.Parameters.Add(new SqlParameter("@Tutorial", pgm.Tutorial));
                cmd.Parameters.Add(new SqlParameter("@Totalhrs", pgm.Totalhrs));
                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }
    public int AddDLPProgramChapter(adminPgm pgm)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("AddDLPProgramChapter", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Program", pgm.Title));
                cmd.Parameters.Add(new SqlParameter("@Chapter", pgm.Chapter));
                cmd.Parameters.Add(new SqlParameter("@Activestatus", pgm.activestatus));
                cmd.Parameters.Add(new SqlParameter("@AddedDate", pgm.AddedDate));
                cmd.Parameters.Add(new SqlParameter("@AddedBy", pgm.AddedBy));

                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }

    public DataSet ViewChapterExist(string chapter,string program,string ID,string stmode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewChapterExist", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@chapter", chapter));
                cmd.Parameters.Add(new SqlParameter("@program", program));
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@stmode", stmode));
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public DataSet ViewDLPPgmChapter()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPPgmChapter", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public DataSet ViewDLPPgmChapterwithFilter(string stpgm, string stchapter, string stSearchval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPPgmChapterwithFilter", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Pgm", stpgm));
                cmd.Parameters.Add(new SqlParameter("@Chapter", stchapter));
                cmd.Parameters.Add(new SqlParameter("@srchval", stSearchval));
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public DataSet ViewDLPPgmByID(string PgmID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPPgmByID", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@PgmID", PgmID));

                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public int DeleteDLPPgmChapters(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("DeleteDLPPgmChapters", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }

    public int UpdateActiveStatusPgmChapters(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("UpdateActiveStatusPgmChapters", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }

    public DataSet ViewDLPPgmChapterByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPPgmChapterByID", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@ID", ID));

                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public int UpdateDLPProgramChapter(adminPgm pgm,string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("UpdateDLPProgramChapter", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@Program", pgm.Title));
                cmd.Parameters.Add(new SqlParameter("@Chapter", pgm.Chapter));
                cmd.Parameters.Add(new SqlParameter("@UpdatedDate", pgm.UpdatedDate));
                cmd.Parameters.Add(new SqlParameter("@UpdatedBy", pgm.UpdatedBy));
                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }

    public DataSet ViewPgmChapterByPgmID(string PgmID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewPgmChapterByPgmID", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Program", PgmID));

                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public DataSet ViewDLPLectureswithFilter(string stpgm, string stchapter, string stSearchval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPLectureswithFilter", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Pgm", stpgm));
                cmd.Parameters.Add(new SqlParameter("@Chapter", stchapter));
                cmd.Parameters.Add(new SqlParameter("@srchval", stSearchval));
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public int AddDLPLecture(adminPgm pgm)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("AddDLPLecture", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Program", pgm.Title));
                cmd.Parameters.Add(new SqlParameter("@Chapter", pgm.Chapter));

                cmd.Parameters.Add(new SqlParameter("@Lecture", pgm.Lecture));
                cmd.Parameters.Add(new SqlParameter("@Duration", pgm.duration));
                cmd.Parameters.Add(new SqlParameter("@contentvideofilename", pgm.contentvideofilename));
                cmd.Parameters.Add(new SqlParameter("@contentPdffilename", pgm.contentPdffilename));

                cmd.Parameters.Add(new SqlParameter("@Activestatus", pgm.activestatus));
                cmd.Parameters.Add(new SqlParameter("@AddedDate", pgm.AddedDate));
                cmd.Parameters.Add(new SqlParameter("@AddedBy", pgm.AddedBy));

                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }

    public int UpdateActiveLectures(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("UpdateActiveLectures", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }

    public int DeleteLectures(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("DeleteLectures", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }
    public DataSet ViewDLPLectureByID(string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPLectureByID", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@ID", ID));

                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public int UpdateDLPLecture(adminPgm pgm, string ID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int rows = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("UpdateDLPLecture", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@Program", pgm.Title));
                cmd.Parameters.Add(new SqlParameter("@Chapter", pgm.Chapter));

                cmd.Parameters.Add(new SqlParameter("@Lecture", pgm.Lecture));
                cmd.Parameters.Add(new SqlParameter("@Duration", pgm.duration));
                cmd.Parameters.Add(new SqlParameter("@contentvideofilename", pgm.contentvideofilename));
                cmd.Parameters.Add(new SqlParameter("@contentpdffilename", pgm.contentPdffilename));
                cmd.Parameters.Add(new SqlParameter("@UpdatedDate", pgm.UpdatedDate));
                cmd.Parameters.Add(new SqlParameter("@UpdatedBy", pgm.UpdatedBy));
                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return rows;
    }

    public DataSet ViewDLPLectureByChapterID(string ChapterID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPLectureByChapterID", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@ChapterID", ChapterID));

                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }

    public DataSet ViewDLPCoursewithFilter(string stpgm, string stDept, string stInsname, string stInstitution, string stSearchval)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPCoursewithFilter", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Pgm", stpgm));
                cmd.Parameters.Add(new SqlParameter("@Dept", stDept));
                cmd.Parameters.Add(new SqlParameter("@Insname", stInsname));
                cmd.Parameters.Add(new SqlParameter("@Institution", stInstitution));
                cmd.Parameters.Add(new SqlParameter("@srchval", stSearchval));
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public int ViewDLPDashboard(string leadStatus)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);

        int count = 0;
        try
        {
            cnn.Open();
            using (SqlCommand command = new SqlCommand("ViewDLPDashboard", cnn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@leadStatus", leadStatus));
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            cnn.Close();

        }
        catch (Exception ex)
        {
        }
        return count;
    }

    public DataSet ViewPgmChapterLectureByPgmID(string PgmID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewPgmChapterLectureByPgmID", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@Program", PgmID));

                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
    public int ViewVideoCountByPgmID(string PgmID)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        int count = 0;
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewVideoCountByPgmID", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@PgmID", PgmID));
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return count;
    }
    
    public DataSet ViewDLPUniquePgmColumns(string stmode)
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = GetSqlConnection();
        cnn = new SqlConnection(connetionString);
        DataSet dsNews = new DataSet();
        try
        {
            using (SqlCommand cmd = new SqlCommand("ViewDLPUniquePgmColumns", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add(new SqlParameter("@column", stmode));
                da.Fill(dsNews);
            }

            cnn.Close();
        }
        catch (Exception ex)
        {
        }
        return dsNews;
    }
}