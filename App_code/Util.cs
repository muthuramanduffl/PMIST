using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for Util
/// </summary>
public static class Util
{
    private static string _numbers = "0123456789";
   
    public static string GetApplicationFor(string stApplicationFor, string CourseType)
    {
        string stName = string.Empty;
        if (!string.IsNullOrEmpty(stApplicationFor))
        {
            if (stApplicationFor.Equals("B.Tech"))
            {
                if (CourseType.Equals("Regular"))
                {
                    stName = "BTF";
                }
                else if (CourseType.Equals("Part Time"))
                {
                    stName = "BTP";
                }
                else if (CourseType.Equals("Lateral"))
                {
                    stName = "BTL";
                }
                
            }
            
            else if (stApplicationFor.Equals("BCA"))
            {
                stName = "BCA";
            }
            if (stApplicationFor.Equals("B.Com"))
            {
                stName = "BCOM";
            }
            if (stApplicationFor.Equals("B.Sc"))
            {
                stName = "BSC";
            }
            else if (stApplicationFor.Equals("B.Arch"))
            {
                stName = "BAR";
            }

            else if (stApplicationFor.Equals("B.A"))
            {
                stName = "BA";
            }

            if (stApplicationFor.Equals("BBA"))
            {
                stName = "BBA";
            }

            else if (stApplicationFor.Equals("B.Sc B.Ed"))
            {
                stName = "BSE";
            }
            else if (stApplicationFor.Equals("B.Ed"))
            {
                stName = "BSE";
            }
            else if (stApplicationFor.Equals("M.Tech"))
            {
                if (CourseType.Equals("Regular"))
                {
                    stName = "MTF";
                }
                else if (CourseType.Equals("Part Time"))
                {
                    stName = "MTP";
                }
            }            
            else if (stApplicationFor.Equals("M.A"))
            {
                stName = "MA";
            }
            else if (stApplicationFor.Equals("M.Com"))
            {
                stName = "MCO";
            }
            else if (stApplicationFor.Equals("M.Arch"))
            {
                stName = "MAR";
            }
            if (stApplicationFor.Equals("MSW"))
            {
                stName = "MSW";
            }
            else if (stApplicationFor.Equals("MBA"))
            {
                stName = "MBA";
            }
            else if (stApplicationFor.Equals("M.Sc"))
            {
                stName = "MSC";
            }
            
            else if (stApplicationFor.Equals("MCA"))
            {
                stName = "MCA";
            }

           
        }
        return stName;
    }
    public static string GetDateFormat(DateTime dtTime)
    {
        string stDate = string.Empty;
        if (dtTime != null)
            stDate = dtTime.ToString("ddMMyyyy");
        return stDate;
    }

    public static string GetDatewithoutYearFormat(DateTime dtTime)
    {
        string stDate = string.Empty;
        if (dtTime != null)
            stDate = dtTime.ToString("ddMM");
        return stDate;
    }
    public static string GenerateOTP()
    {
        Random random = new Random();
        StringBuilder builder = new StringBuilder(6);
        string OTPCode = "";
        for (int i = 0; i < 4; i++)
        {
            builder.Append(_numbers[random.Next(0, _numbers.Length)]);
        }
        OTPCode = builder.ToString();
        return OTPCode;
    }
}