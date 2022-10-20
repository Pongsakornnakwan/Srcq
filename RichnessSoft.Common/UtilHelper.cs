using System;
using System.Reflection;

namespace RichnessSoft.Common
{
    public class UtilHelper
    {
        public static bool gmIsNullOrEmpty(object value) => (value is null || value.ToString().Trim().Length == 0);
        public static string gmNullOrEmpty(object objField, object strDefault)
        {
            string strReturn = strDefault.ToString();
            if (objField is not null && objField.ToString().Trim().Length > 0)
            {
                strReturn = objField.ToString();
            }
            return strReturn.Trim();
        }
        public static string gmNVL(object objField) => gmNVL(objField, "");
        public static string gmNVL(object objField, string strDefault)
        {
            string strReturn = strDefault;
            if (objField is not null)
            {
                strReturn = objField.ToString();
            }
            return strReturn.Trim();
        }
        public static bool gmBoolParse(object val) => gmBoolParse(val, "False");
        public static bool gmBoolParse(object val, object defaultValue)
        {
            bool boolRetVal = false;
            if (bool.TryParse(gmNullOrEmpty(gmNullOrEmpty(val, defaultValue), 0), out bool result))
            {
                boolRetVal = result;
            }
            return boolRetVal;
        }
        public static int gmIntParse(object val) => gmIntParse(val, "0");
        public static int gmIntParse(object val, object defaultValue)
        {
            int intRetVal = 0;
            int result;
            try
            {
                if (int.TryParse(gmNullOrEmpty(gmNullOrEmpty(val, defaultValue), 0), out result))
                {
                    intRetVal = result;
                }
                else
                {
                    intRetVal = pmethConvert<int>(val,defaultValue);
                }
            }
            catch (Exception)
            {
                if (defaultValue is not null && int.TryParse(defaultValue.ToString(), out result))
                {
                    intRetVal = result;
                }
            }
            return intRetVal;
        }
        public static decimal gmDecimalParse(object val) => gmDecimalParse(val, "0M");
        public static decimal gmDecimalParse(object val, object defaultValue)
        {
            decimal decRetVal = 0M;
            decimal result;
            try
            {
                if (decimal.TryParse(gmNullOrEmpty(gmNullOrEmpty(val, defaultValue), 0M), out result))
                {
                    decRetVal = result;
                }
                else
                {
                    decRetVal = pmethConvert<decimal>(val,defaultValue);
                }
            }
            catch (Exception)
            {
                result = 0M;
                if (defaultValue is not null && decimal.TryParse(defaultValue.ToString(), out result))
                {
                    decRetVal = result;
                }
            }
            return decRetVal;
        }
        public static double gmDoubleParse(object val) => gmDoubleParse(val, "0");
        public static double gmDoubleParse(object val, object defaultValue)
        {
            double douRetVal = 0;
            double result;
            try
            {
                if (double.TryParse(gmNullOrEmpty(gmNullOrEmpty(val, defaultValue), 0), out result))
                {
                    douRetVal = result;
                }
                else
                {
                    douRetVal = pmethConvert<double>(val,defaultValue);
                }
            }
            catch (Exception)
            {
                if (defaultValue is not null && double.TryParse(defaultValue.ToString(), out result))
                {
                    douRetVal = result;
                }
            }
            return douRetVal;
        }
        public static DateTime? gmDateTimeParse(object val) => gmDateTimeParse(val, null);
        public static DateTime? gmDateTimeParse(object val, DateTime? defaultValue)
        {
            DateTime? outDateTime = null;
            DateTime dtDateTime;
            try
            {
                if (val is null)
                {
                    outDateTime = defaultValue;
                    return outDateTime;
                }
                if (val.Equals(DBNull.Value) || val.Equals(null) || Convert.ToDateTime(val) == DateTime.MinValue)
                {
                    outDateTime = defaultValue;
                }
                else
                {
                    if (DateTime.TryParse(val.ToString(), out dtDateTime))
                    {
                        outDateTime = dtDateTime;
                    }
                    else
                    {
                        outDateTime = defaultValue;
                    }
                }
            }
            catch (Exception)
            {
                if (defaultValue.HasValue && DateTime.TryParse(defaultValue.Value.ToString(), out dtDateTime))
                {
                    outDateTime = dtDateTime;
                }
            }
            return outDateTime;
        }
        public static double gmRound(double val) => gmRound(val, 2);
        public static double gmRound(double val, int RountAt) => gmRound(val, RountAt, MidpointRounding.AwayFromZero);
        public static double gmRound(double val, int RountAt, MidpointRounding MidpointRounding) => Math.Round(val, RountAt, MidpointRounding);
        public static decimal gmRound(decimal val) => gmRound(val, 2);
        public static decimal gmRound(decimal val, int RountAt) => gmRound(val, RountAt, MidpointRounding.AwayFromZero);
        public static decimal gmRound(decimal val, int RountAt, MidpointRounding MidpointRounding) => decimal.Round(val, RountAt, MidpointRounding);
        public static double gm2Round(double val, int RountAt) => gmRound(gmRound(val, RountAt + 2), RountAt);
        public static double gm2Round(double val, int RountAt, MidpointRounding MidpointRounding) => gmRound(gmRound(val, RountAt + 2, MidpointRounding), RountAt, MidpointRounding);
        public static decimal gm2Round(decimal val, int RountAt) => gmRound(gmRound(val, RountAt + 2), RountAt);
        public static decimal gm2Round(decimal val, int RountAt, MidpointRounding MidpointRounding) => gmRound(gmRound(val, RountAt + 2, MidpointRounding), RountAt, MidpointRounding);
        public static T? gmPropertyValue<T>(object src, string propName = "") => gmPropertyValue<T>(src, new string[] { propName });
        public static T? gmPropertyValue<T>(object src, string[] aPropName )
        {
            object? oResult = null;
            if (gmIsNullOrEmpty(src) == false && aPropName is not null && aPropName.Length>0)
            {
                foreach (string propName in aPropName)
                {
                    if (gmHasProperty(src, propName) == false) { continue; }
                    PropertyInfo? prop = src.GetType().GetProperty(propName, BindingFlags.Public | BindingFlags.Instance| BindingFlags.NonPublic);
                    if (prop is not null)
                    {
                        oResult = prop.GetValue(src) ?? default;
                        break;
                    }
                }
            }
            return oResult is not null ? (T)oResult : default;
        }
        public static bool gmHasProperty(object src, string propName = "") => gmHasProperty(src, new string[] { propName });
        public static bool gmHasProperty(object src, string[] aPropName)
        {
            bool bHasProperty = false;
            foreach (string prop in aPropName)
            {
                bHasProperty = src?.GetType()?.GetProperty(prop, BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic) is not null;
                if (bHasProperty) { break; }
            }
            return bHasProperty;
        }
        public static bool gmHasMethod(object src, string methodName = "") => gmHasMethod(src, new string[] { methodName });
        public static bool gmHasMethod(object src, string[] aMethodName)
        {
            bool bHasMethod = false;
            foreach (string method in aMethodName)
            {
                bHasMethod = src?.GetType()?.GetMethod(method,BindingFlags.Public | BindingFlags.Instance| BindingFlags.NonPublic) is not null;
                if (bHasMethod) { break; }
            }
            return bHasMethod;    
        }
        public static string gmRunDocRefNo(string strDocType= "", string strBookCode="", string strCode ="" )
        {
            return string.Format("{0}{1}/{2}",strDocType,strBookCode,strCode);
        }
        private static T pmethConvert<T>(object val, object defaultValue = default)
        {
            
            try
            {
                return (T)Convert.ChangeType(val,typeof(T));
            }
            catch (Exception)
            {
                return (T)Convert.ChangeType(defaultValue,typeof(T));
            } 
            return (T)default;
        }

        public static void CopyProperties(object source, object destination)
        {
            // If any this null throw an exception
            if (source == null || destination == null)
                throw new Exception("Source or/and Destination Objects are null");
            // Getting the Types of the objects
            Type typeDest = destination.GetType();
            Type typeSrc = source.GetType();

            // Iterate the Properties of the source instance and  
            // populate them from their desination counterparts  
            PropertyInfo[] srcProps = typeSrc.GetProperties();
            foreach (PropertyInfo srcProp in srcProps)
            {
                if (!srcProp.CanRead)
                {
                    continue;
                }
                PropertyInfo targetProperty = typeDest.GetProperty(srcProp.Name);
                if (targetProperty == null)
                {
                    continue;
                }
                if (!targetProperty.CanWrite)
                {
                    continue;
                }
                if (targetProperty.GetSetMethod(true) != null && targetProperty.GetSetMethod(true).IsPrivate)
                {
                    continue;
                }
                if ((targetProperty.GetSetMethod().Attributes & MethodAttributes.Static) != 0)
                {
                    continue;
                }
                if (!targetProperty.PropertyType.IsAssignableFrom(srcProp.PropertyType))
                {
                    continue;
                }
                // Passed all tests, lets set the value
                targetProperty.SetValue(destination, srcProp.GetValue(source, null), null);
            }
        }
    }
}
