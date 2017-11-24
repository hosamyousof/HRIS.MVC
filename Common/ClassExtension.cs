using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

public static class ClassExtension
{
    private static List<Type> _commonStructType = new List<Type>(
       new Type[] {
            typeof(string),
            typeof(Double),
            typeof(double),
            typeof(decimal),
            typeof(Decimal),
            typeof(float),
            typeof(Int16),
            typeof(Int32),
            typeof(Int64),
            typeof(long),
            typeof(DateTime),
            typeof(bool),
            typeof(Guid),
        });

    public static Func<T> ActionToFunc<T>(this Action a)
    {
        return () => { a(); return default(T); };
    }

    public static string ReferenceDescription<T>(this string value) where T : IReference
    {
        var _ref = Activator.CreateInstance<T>();
        return _ref.GetDescription(value);
    }

    public static IEnumerable<ValueText> AddItem(this IEnumerable<ValueText> data, int index, string text)
    {
        List<ValueText> _data = data.ToList();
        _data.Insert(index, new ValueText("", text));
        return _data;
    }

    public static IEnumerable<ValueText> RemoveItemByValue(this IEnumerable<ValueText> data, string value)
    {
        List<ValueText> _data = data.Where(x => x.Value != value).ToList();
        return _data;
    }

    public static IEnumerable<ValueText> RemoveItemByValue(this IEnumerable<ValueText> data, IEnumerable<string> values)
    {
        List<ValueText> _data = data.Where(x => !values.Contains(x.Value)).ToList();
        return _data;
    }

    public static IEnumerable<T> AddItem<T>(this IEnumerable<T> data, T insert)
    {
        List<T> _data = data.ToList();
        _data.Insert(0, insert);
        return _data;
    }

    public static IEnumerable<T> AddItem<T>(this IEnumerable<T> data, int index, T insert)
    {
        List<T> _data = data.ToList();
        _data.Insert(index, insert);
        return _data;
    }

    public static IEnumerable<ValueText> AddItem(this IEnumerable<ValueText> data, string text)
    {
        List<ValueText> _data = data.ToList();
        _data.Add(new ValueText("", text));
        return _data;
    }

    public static IEnumerable<ValueText> AddItem(this IEnumerable<ValueText> data, string value, string text)
    {
        List<ValueText> _data = data.ToList();
        _data.Add(new ValueText(value, text));
        return _data;
    }

    public static IEnumerable<ValueText> AddItem(this IEnumerable<ValueText> data, int index, string value, string text)
    {
        List<ValueText> _data = data.ToList();
        _data.Insert(0, new ValueText(value, text));
        return _data;
    }

    public static IDictionary<string, object> AsDictionary(this object source, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
    {
        return source.GetType().GetProperties(bindingAttr).ToDictionary
        (
            propInfo => propInfo.Name,
            propInfo => propInfo.GetValue(source, null)
        );
    }

    public static T Clone<T>(this T source)
    {
        if (!typeof(T).IsSerializable)
        {
            throw new ArgumentException("The type must be serializable.", "source");
        }

        // Don't serialize a null object, simply return the default for that object
        if (Object.ReferenceEquals(source, null))
        {
            return default(T);
        }

        IFormatter formatter = new BinaryFormatter();
        Stream stream = new MemoryStream();
        using (stream)
        {
            formatter.Serialize(stream, source);
            stream.Seek(0, SeekOrigin.Begin);
            return (T)formatter.Deserialize(stream);
        }
    }

    public static T ConvertTo<T>(this object obj) where T : struct
    {
        if (obj == null)
        {
            return default(T);
        }
        var strucType = obj.GetType();

        if (_commonStructType.Contains(strucType))
        {
            if (typeof(T).GetType() == typeof(string))
            {
                return (T)obj;
            }
            else
            {
                object newObj = Activator.CreateInstance<T>();
                var type = typeof(T);

                MethodInfo methodInfo = type.GetMethod("TryParse",
                    BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Static,
                    null,
                    new Type[] { typeof(string), type.MakeByRefType() },
                    null);
                try
                {
                    object result = null;
                    ParameterInfo[] parameters = methodInfo.GetParameters();
                    object classInstance = Activator.CreateInstance(type, null);
                    object[] parametersArray = new object[] { obj.ToString(), newObj };
                    result = methodInfo.Invoke(methodInfo, parametersArray);

                    return (T)parametersArray[1];
                }
                catch
                {
                    return default(T);
                }
            }
        }
        else
        {
            throw new Exception("Standard Type Only.");
        }
    }

    public static object ConvertTo(this object obj, Type type)
    {
        if (obj == null) return null;
        return ConvertValue(obj.ToString(), type);
    }

    public static object ConvertValue(string val, Type type)
    {
        try
        {
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
        catch
        {
            if (type.IsNullable())
                return null;
            else
                throw;
        }
    }

    public static string GenerateCode(this string value, int length)
    {
        string code = value ?? "";

        code = code.RemoveSpecialCharacters();

        if (value.Trim().Length > length)
        {
            var str_s = value.ToUpper().Trim().Split(' ').ToList();

            code = string.Join("", str_s.Select(x => x.Substring(0, 1)));

            if (code.Trim().Length < length)
            {
                code += str_s.Last().Substring(1);
            }
            if (code.Trim().Length > length)
            {
                code = code.Substring(0, length);
            }
        }
        else
        {
            code = code.ToUpper();
        }

        return code;
    }

    public static TData GetData<TData>(this object data, string field)
    {
        var type = data.GetType();
        return (TData)type.GetProperty(field).GetValue(data);
    }

    public static PropertyInfo GetPropertyInfo<TSource, TProperty>(this Expression<Func<TSource, TProperty>> propertyLambda)
    {
        Type type = typeof(TSource);

        MemberExpression member = propertyLambda.Body as MemberExpression;
        if (member == null)
            throw new ArgumentException(string.Format(
                "Expression '{0}' refers to a method, not a property.",
                propertyLambda.ToString()));

        PropertyInfo propInfo = member.Member as PropertyInfo;
        if (propInfo == null)
            throw new ArgumentException(string.Format(
                "Expression '{0}' refers to a field, not a property.",
                propertyLambda.ToString()));

        if (type != propInfo.ReflectedType &&
            !type.IsSubclassOf(propInfo.ReflectedType))
            throw new ArgumentException(string.Format(
                "Expresion '{0}' refers to a property that is not from type {1}.",
                propertyLambda.ToString(),
                type));

        return propInfo;
    }

    public static DateTime GetTimeOnly(this DateTime date)
    {
        return default(DateTime).AddHours(date.Hour).AddMinutes(date.Minute).AddSeconds(date.Second);
    }

    public static Type GetTypeFromMemberExpression(this MemberExpression memberExpression)
    {
        if (memberExpression == null) return null;

        var dataType = GetTypeFromMemberInfo(memberExpression.Member, (PropertyInfo p) => p.PropertyType);
        if (dataType == null) dataType = GetTypeFromMemberInfo(memberExpression.Member, (MethodInfo m) => m.ReturnType);
        if (dataType == null) dataType = GetTypeFromMemberInfo(memberExpression.Member, (FieldInfo f) => f.FieldType);

        return dataType;
    }

    public static string IncludeNumberInLast(this string value, string originalValue, IEnumerable<string> _compare)
    {
        IEnumerable<int> numberList = _compare.Select(x =>
        {
            try
            {
                return int.Parse(x.Substring(originalValue.Length));
            }
            catch { }
            return 0;
        });
        var last = numberList.Where(x => x != 0).OrderByDescending(x => x).FirstOrDefault();
        return last != 0 ? (originalValue + (last + 1)) : (originalValue + "1");
    }

    public static bool IsNull(this string str)
    {
        return string.IsNullOrEmpty(str);
    }

    public static bool IsNullable(this Type type)
    {
        try
        {
            if (type == typeof(DateTime?)
                || type == typeof(int?)
                || type == typeof(Int16?)
                || type == typeof(Int32?)
                || type == typeof(Int64?)
                || type == typeof(long?)
                || type == typeof(bool?)
                || type == typeof(double?)
                || type == typeof(decimal?)
                || type == typeof(Guid?)
                )
                return true;
            else
                return false;
        }
        catch { return false; }
    }

    public static bool IsOdd(this int value)
    {
        return value % 2 != 0;
    }

    public static T MapToModel<T>(this object data) where T : class
    {
        if (data == null) return null;
        var prop = data.GetType().GetProperties();
        var propModel = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var newData = Activator.CreateInstance<T>();
        foreach (var p in propModel)
        {
            try
            {
                p.SetValue(newData, prop.FirstOrDefault(x => x.Name == p.Name).GetValue(data));
            }
            catch { }
        }
        return newData;
    }

    public static T MapToModel<T>(this object data, IEnumerable<string> excludeFields) where T : class
    {
        if (data == null) return null;
        var prop = data.GetType().GetProperties();
        var propModel = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var newData = Activator.CreateInstance<T>();
        foreach (var p in propModel)
        {
            try
            {
                if (excludeFields.Contains(p.Name)) continue;

                p.SetValue(newData, prop.FirstOrDefault(x => x.Name == p.Name).GetValue(data));
            }
            catch { }
        }
        return newData;
    }

    public static TSource UpdateFieldValues<TSource, TProperty>(this TSource toData, object fromData, params Expression<Func<TSource, TProperty>>[] args) where TSource : class
    {
        IEnumerable<string> fields = args.Select(x => x.GetPropertyInfo().Name);
        if (fromData == null) return null;
        var prop = fromData.GetType().GetProperties();
        var propModel = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var p in propModel)
        {
            try
            {
                if (fields.Contains(p.Name)) continue;

                p.SetValue(toData, prop.FirstOrDefault(x => x.Name == p.Name).GetValue(fromData));
            }
            catch { }
        }
        return toData;
    }

    public static T NextOf<T>(this IList<T> list, T item)
    {
        return list[(list.IndexOf(item) + 1) == list.Count ? 0 : (list.IndexOf(item) + 1)];
    }

    public static T PreviousOf<T>(this IList<T> list, T item)
    {
        return list[(list.IndexOf(item) - 1) == list.Count ? 0 : (list.IndexOf(item) - 1)];
    }

    public static string RemoveSpecialCharacters(this string input)
    {
        return Regex.Replace(input, "[^0-9a-zA-Z ]+", "");
    }

    public static string ReplaceSpecialCharactersToDash(this string input)
    {
        string regExp = @"[^\w\d]";
        return Regex.Replace(input, regExp, "-");
    }

    public static Expression RemoveUnary(this Expression body)
    {
        var unary = body as UnaryExpression;
        if (unary != null)
        {
            return unary.Operand;
        }
        return body;
    }

    public static DataTable ToDataTable<T>(this IEnumerable<T> source)
    {
        var dt = new DataTable();

        var propCol = typeof(T).GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
        foreach (var p in propCol)
        {
            dt.Columns.Add(p.Name);
        }

        foreach (var item in source)
        {
            var prop = item.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            DataRow dr = dt.NewRow();
            foreach (var p in prop)
            {
                try
                {
                    string value = p.GetValue(item, null).ToString();
                    dr[p.Name] = value;
                }
                catch { }
            }
            dt.Rows.Add(dr);
        }

        return dt;
    }

    public static Dictionary<string, object> ToDictionary(this object data)
    {
        if (data == null) return null;

        BindingFlags publicAttributes = BindingFlags.Public | BindingFlags.Instance;
        Dictionary<string, object> dictionary = new Dictionary<string, object>();

        foreach (PropertyInfo property in data.GetType().GetProperties(publicAttributes))
        {
            if (property.CanRead)
            {
                try
                {
                    object value = property.GetValue(data, null);
                    if (value == null)
                    {
                        value = "";
                    }
                    else
                    {
                        value = ConvertValue(value.ToString(), property.PropertyType);
                    }

                    try
                    {
                        dictionary.Add(property.Name, value.ToString());
                    }
                    catch
                    {
                        dictionary.Add(property.Name, "");
                    }
                }
                catch (Exception)
                {
                    dictionary.Add(property.Name, "");
                }
            }
        }
        return dictionary;
    }

    public static ExpandoObject ToExpando(this IDictionary<string, object> dictionary)
    {
        var eo = new ExpandoObject();
        var eoColl = (ICollection<KeyValuePair<string, object>>)eo;

        foreach (var kvp in dictionary)
        {
            eoColl.Add(kvp);
        }

        dynamic eoDynamic = eo;
        return eoDynamic;

        //var expando = new ExpandoObject();
        //var expandoDic = (IDictionary<string, object>)expando;

        //// go through the items in the dictionary and copy over the key value pairs)
        //foreach (var kvp in dictionary)
        //{
        //    // if the value can also be turned into an ExpandoObject, then do it!
        //    if (kvp.Value is IDictionary<string, object>)
        //    {
        //        var expandoValue = ((IDictionary<string, object>)kvp.Value).ToExpando();
        //        expandoDic.Add(kvp.Key, expandoValue);
        //    }
        //    else if (kvp.Value is ICollection)
        //    {
        //        // iterate through the collection and convert any strin-object dictionaries
        //        // along the way into expando objects
        //        var itemList = new List<object>();
        //        foreach (var item in (ICollection)kvp.Value)
        //        {
        //            if (item is IDictionary<string, object>)
        //            {
        //                var expandoItem = ((IDictionary<string, object>)item).ToExpando();
        //                itemList.Add(expandoItem);
        //            }
        //            else
        //            {
        //                itemList.Add(item);
        //            }
        //        }

        //        expandoDic.Add(kvp.Key, itemList);
        //    }
        //    else
        //    {
        //        expandoDic.Add(kvp);
        //    }
        //}

        //return expando;
    }

    public static string ToLineString(this IEnumerable<string> lst, string separtor)
    {
        string attr = "";

        foreach (string str in lst)
        {
            attr += str + separtor;
        }

        if (!separtor.IsNull())
        {
            if (attr.EndsWith(separtor))
            {
                attr = attr.Substring(0, attr.Length - separtor.Length);
            }
        }
        return attr;
    }

    private static object GetPropertyValue<T>(T instance, MemberExpression me)
    {
        object target;

        if (me.Expression.NodeType == ExpressionType.Parameter)
        {
            // If the current MemberExpression is at the root object, set that as the target.
            target = instance;
        }
        else
        {
            target = GetPropertyValue<T>(instance, me.Expression as MemberExpression);
        }

        // Return the value from current MemberExpression against the current target
        return target.GetType().GetProperty(me.Member.Name).GetValue(target, null);
    }

    private static Type GetTypeFromMemberInfo<TMember>(MemberInfo member, Func<TMember, Type> func) where TMember : MemberInfo
    {
        if (member is TMember)
        {
            return func((TMember)member);
        }
        return null;
    }
}