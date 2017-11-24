using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

public static class Util
{
    private static Random random = new Random((int)DateTime.Now.Ticks);


    public static string RandomString(int size)
    {
        StringBuilder builder = new StringBuilder();
        char ch;
        for (int i = 0; i < size; i++)
        {
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
            builder.Append(ch);
        }

        return builder.ToString();
    }

    public static object ConvertValue(object value, Type type)
    {
        try
        {
            string val = value.ToString();
            if (type == typeof(DateTime) || type == typeof(DateTime?))
                return DateTime.Parse(val);
            else if (type == typeof(int) || type == typeof(int?))
                return int.Parse(val);
            else if (type == typeof(Int16) || type == typeof(Int16?))
                return Int16.Parse(val);
            else if (type == typeof(Int32) || type == typeof(Int32?))
                return Int32.Parse(val);
            else if (type == typeof(Int64) || type == typeof(Int64?))
                return Int64.Parse(val);
            else if (type == typeof(long) || type == typeof(long?))
                return long.Parse(val);
            else if (type == typeof(bool) || type == typeof(bool?))
                return bool.Parse(val);
            else if (type == typeof(double) || type == typeof(double?))
                return double.Parse(val);
            else if (type == typeof(decimal) || type == typeof(decimal?))
                return decimal.Parse(val);
            else if (type == typeof(Guid) || type == typeof(Guid?))
                return Guid.Parse(val);
            else if (type == typeof(string))
                return val.Trim();
            else
                return null;
        }
        catch { return null; }
    }

    public static IEnumerable<string> GetWebRouteList()
    {
        var routes = RouteTable.Routes;
        foreach (var route in routes)
        {
            if (route is Route)
            {
                yield return ((Route)route).Url;
            }
        }
    }

    public static T ConvertValue<T>(object value)
    {
        return (T)ConvertValue(value, typeof(T));
    }

    public static IEnumerable<Type> GetClassListWithAttribute<T>(string referenceName) where T : Attribute
    {
        var types = (from lAssembly in AppDomain.CurrentDomain.GetAssemblies().Where(x => x.GetName().Name == referenceName)
                     from lType in lAssembly.GetTypes()
                     where lType.GetInterfaces().Where(i => i.GetCustomAttributes<T>().Any()).Any()
                     select lType);

        return types;
    }

    public static bool ExtensionFileIsImage(string extension)
    {
        var validFiles = new string[] { ".jpg", ".png", ".jpeg" };
        return validFiles.Contains(extension);
    }

    public static IEnumerable<Type> GetClassWithInherited<T>(string referenceName)
    {
        var types = (from lAssembly in AppDomain.CurrentDomain.GetAssemblies().Where(x => x.GetName().Name == referenceName)
                     from lType in lAssembly.GetTypes()
                     where lType.BaseType == typeof(T)
                     select lType);
        return types;
    }

    public static void CreateInstanceIfNull<TModel>(TModel model) where TModel : class
    {
        if (model == null)
        {
            model = Activator.CreateInstance<TModel>();
        }
    }
}
