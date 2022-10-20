using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace RichnessSoft.Common
{
    public class CommonUtil
    {
        public static string VarType(object oObj)
        {
            if (oObj == null)
                return "null";
            else
                return oObj.GetType().ToString();
        }

        public static string Type(object oObj)
        {
            return VarType(oObj);
        }

        public static bool xIsNull(object oObj)
        {
            return (oObj == null);
        }
        public static object NVL(object oExp1, object oExp2)
        {
            if (oExp1 != null)
            {
                return oExp1;
            }
            else if ((oExp1 == null) && (oExp2 != null))
            {
                return oExp2;
            }
            else
                return null;
        }

        public static bool xEmpty(int nValue)
        {
            return (nValue == 0);
        }
        public static bool xEmpty(long nValue)
        {
            return (nValue == 0);
        }
        public static bool xEmpty(double nValue)
        {
            return (nValue == 0);
        }
        public static bool xEmpty(decimal nValue)
        {
            return (nValue == 0);
        }
        public static bool xEmpty(string tcString)
        {
            string lcString = tcString.Trim();
            return (lcString.Length == 0);
        }
        public static bool xEmpty(char lcChar)
        {
            return (lcChar == ' ');
        }
        public static bool xEmpty(bool lValue)
        {
            return (lValue == false);
        }
        public static bool xIsBlank(int nValue)
        {
            return xEmpty(nValue);
        }
        public static bool xIsBlank(long nValue)
        {
            return xEmpty(nValue);
        }
        public static bool xIsBlank(double nValue)
        {
            return xEmpty(nValue);
        }
        public static bool xIsBlank(decimal nValue)
        {
            return xEmpty(nValue);
        }
        public static bool xIsBlank(string tcString)
        {
            return (tcString.Length == 0);
        }
        public static bool xIsBlank(char lcChar)
        {
            return xEmpty(lcChar);
        }
        public static bool xIsBlank(bool lValue)
        {
            return xEmpty(lValue);
        }

        public static int CPCurrent()
        {
            return System.Text.Encoding.Default.CodePage;
        }

        public static string CPConvert(int nCurrentCodePage, int nNewCodePage, string cExpression)
        {
            int i = 0;
            int nLength = cExpression.Length;

            byte[] aCurr = new byte[nLength];
            byte[] aNew = new byte[nLength];

            for (i = 0; i < cExpression.Length; i++)
            {
                aCurr[i] = Convert.ToByte(cExpression[i]);
            }

            Encoding CurCP = Encoding.GetEncoding(nCurrentCodePage);
            Encoding NewCP = Encoding.GetEncoding(nNewCodePage);
            aNew = Encoding.Convert(CurCP, NewCP, aCurr);
            StringBuilder sb = new StringBuilder();
            for (i = 0; i < cExpression.Length; i++)
            {
                sb.Append(Convert.ToChar(aNew[i]));
            }
            return sb.ToString();

        }

        public static bool GetPem(object oObject, string cPropertyEventMethodName)
        {
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(oObject);
            foreach (MemberDescriptor md in pdc)
            {
                if (md.Name.ToLower() == cPropertyEventMethodName.ToLower())
                {
                    return true;
                }
            }
            EventDescriptorCollection edc = TypeDescriptor.GetEvents(oObject);
            foreach (EventDescriptor ed in edc)
            {
                if (ed.Name.ToLower() == cPropertyEventMethodName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static System.Drawing.Color RGB(int R, int G, int B)
        {
            return System.Drawing.Color.FromArgb(R, G, B);
        }

        public static bool xBetween(int tnExpression, int tnLowValue, int tnHighValue)
        {
            return ((tnExpression >= tnLowValue) && (tnExpression <= tnHighValue));
        }
        public static bool xBetween(double tnExpression, double tnLowValue, double tnHighValue)
        {
            return ((tnExpression >= tnLowValue) && (tnExpression <= tnHighValue));
        }
        public static bool xBetween(decimal tnExpression, decimal tnLowValue, decimal tnHighValue)
        {
            return ((tnExpression >= tnLowValue) && (tnExpression <= tnHighValue));
        }

        public static bool xBetween(System.DateTime tdDateTime, System.DateTime tdStartDate, System.DateTime tdEndDate)
        {
            return ((tdDateTime >= tdStartDate) && (tdDateTime <= tdEndDate));
        }

        public static bool xBetween(char tcChar, char tcLowChar, char tcHighChar)
        {
            return (((int)tcChar >= (int)tcLowChar) && ((int)tcChar <= (int)tcHighChar));
        }

        public static bool xBetween(string tcExpression, string tcStart, string tcEnd)
        {
            bool llRetVal = true;
            for (int i = 0; i < tcStart.Length; i++)
            {
                if (tcStart[i] > tcExpression[i])
                {
                    llRetVal = false;
                    break;
                }
                if (i == tcExpression.Length)
                    break;
            }
            for (int i = 0; i < tcEnd.Length; i++)
            {
                if (tcEnd[i] < tcExpression[i])
                {
                    llRetVal = false;
                    break;
                }
                if (i == tcExpression.Length)
                    break;
            }
            return llRetVal;
        }

        public static int PCount(System.Reflection.MethodBase mb)
        {
            return mb.GetParameters().Length;
        }

        public static int Parameters(System.Reflection.MethodBase ms)
        {
            return PCount(ms);
        }

        public static bool xInList(object toExpression, params object[] toItems)
        {
            return Array.IndexOf(toItems, toExpression) > -1;
        }

        public static int Occurs(char tcChar, string cExpression)
        {
            int i, nOccured = 0;
            for (i = 0; i < cExpression.Length; i++)
            {
                if (cExpression[i] == tcChar)
                {
                    nOccured++;
                }
            }
            return nOccured;
        }
        public static int Occurs(string cString, string cExpression)
        {
            int nPos = 0;
            int nOccured = 0;
            do
            {
                nPos = cExpression.IndexOf(cString, nPos);
                if (nPos < 0)
                {
                    break;
                }
                else
                {
                    nOccured++;
                    nPos++;
                }
            } while (true);
            return nOccured;
        }

        public static int IntParse(object valueParse)
        {
            return IntParse(valueParse, 0);
        }
        public static int IntParse(object valueParse, int defauleValue)
        {
            int outValue;
            try
            {
                if (valueParse == null) return defauleValue;
                int.TryParse(valueParse.ToString(), out outValue);
                if (outValue.Equals(0)) outValue = defauleValue;
            }
            catch (Exception)
            {
                outValue = defauleValue;
            }
            return outValue;
        }
        public static double DoubleParse(object valueParse)
        {
            return DoubleParse(valueParse, 0);
        }
        public static double DoubleParse(object valueParse, double defauleValue)
        {
            double outValue;
            try
            {
                if (valueParse == null) return defauleValue;
                double.TryParse(valueParse.ToString(), out outValue);
                if (outValue.Equals(0)) outValue = defauleValue;
            }
            catch (Exception)
            {
                outValue = defauleValue;
            }
            return outValue;
        }
        public static decimal DecimalParse(object valueParse)
        {
            return DecimalParse(valueParse, 0);
        }
        public static decimal DecimalParse(object valueParse, decimal defauleValue)
        {
            decimal outValue;
            try
            {
                if (valueParse == null) return defauleValue;
                decimal.TryParse(valueParse.ToString(), out outValue);
                if (outValue.Equals(0)) outValue = defauleValue;
            }
            catch (Exception)
            {
                outValue = defauleValue;
            }
            return outValue;
        }
        public static DateTime DateTimeParse(object valueParse, DateTime defauleValue)
        {
            DateTime outValue;
            try
            {
                if (valueParse == null) return defauleValue;
                DateTime.TryParse(valueParse.ToString(), out outValue);
                if (outValue.Equals(DateTime.MinValue)) outValue = defauleValue;
            }
            catch (Exception)
            {
                outValue = defauleValue;
            }
            return outValue;
        }
        public static string gmNVL(object objField, string strDefault)
        {
            string strReturn = strDefault;
            if (objField != null)
            {
                strReturn = objField.ToString();
            }
            return strReturn;
        }
        public static string gmNullOrEmpty(object objField, string strDefault)
        {
            string strReturn = strDefault;
            if (objField != null && objField.ToString().Trim().Length > 0)
            {
                strReturn = objField.ToString();
            }
            return strReturn;
        }

        public static int gmSeekRow(DataRow[] rows, string[] keyField, string value)
        {
            int min = 0;
            int max = rows.Length - 1;
            int curRow = (max - min) / 2;
            int retRowNo = -1;
            if (rows.Length == 0) { return retRowNo; }
            int cmp;
            cmp = CommonUtil.pmCompareKey(rows[curRow], keyField, value);
            do
            {
                if (cmp < 0)
                {
                    min = curRow;
                    curRow = min + (int)Math.Ceiling(((double)max - (double)min) / 2);
                }
                else
                {
                    max = curRow;
                    curRow = max - (int)Math.Ceiling(((double)max - (double)min) / 2);
                }
                cmp = CommonUtil.pmCompareKey(rows[curRow], keyField, value);
            } while (curRow != min && curRow != max && cmp != 0);
            if (cmp == 0)
            {
                retRowNo = curRow;
            }
            return retRowNo;
        }

        private static int pmCompareKey(DataRow dr, string[] keyField, string value)
        {
            string strKeyVal = "";
            foreach (string field in keyField)
            {
                strKeyVal += dr[field].ToString().PadRight(dr.Table.Columns[field].MaxLength);
            }
            return string.Compare(strKeyVal, value);
        }
    }
}
