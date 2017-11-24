using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WebConfig
{
    public static Guid DefaultStore
    {
        get
        {
            return Guid.Parse(System.Configuration.ConfigurationManager.AppSettings["DefaultStore"]);
        }
    }

    public static string CompanyName
    {
        get
        {
            return System.Configuration.ConfigurationManager.AppSettings["CompanyName"];
        }
    }

}