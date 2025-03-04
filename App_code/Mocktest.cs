using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

/// <summary>
/// Summary description for Mocktest
/// </summary>
public class Mocktest
{

    public Mocktest()
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

    public DateTime indiandatetime(DateTime d)
    {
        DateTime dateTime = d; // I am getting date time here
        DateTime utcTime = dateTime.ToUniversalTime(); // From current datetime I am retriving UTC time
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"); // Now I am Getting `IST` time From `UTC`
        DateTime yourISTTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, istZone); // Finally converting it 
        //var hourIST = yourISTTime.Hour; // More granular extraction.
        //var hourISTmin = yourISTTime.Minute;

        //var todaydate = yourISTTime.ToString("dd-MM-yyyy");
        //var todaytime = yourISTTime.ToString("HH:mm");

        return yourISTTime;
    }
	
    public void SendMocktestMail(string ToMail, string Subject, string body)
    {
        try
        {
            using (System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("PMIST +2 Mock Test<updates@pmu.edu>", ToMail))
            {

                mm.Subject = Subject;
                mm.Body = body;
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "relay-hosting.secureserver.net";
                NetworkCredential NetworkCred = new NetworkCredential("updates@pmu.edu", "periyar2020");
                smtp.Credentials = NetworkCred;
                smtp.Port = 25;
                smtp.UseDefaultCredentials = true;
                smtp.EnableSsl = false;
                smtp.Send(mm);

            }
        }
        catch (Exception ex)
        {

        }

    }
}