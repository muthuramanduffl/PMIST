using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DbConnection
/// </summary>
public class DbConnection
{
    public DbConnection()
    {
    }
       public static string ConnectionString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["PMU"].ConnectionString;
        }
    }
}
  


