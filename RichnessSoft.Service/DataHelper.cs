using Microsoft.EntityFrameworkCore.Metadata;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service
{
    public interface IDataHelper
    {
        CultureInfo _culture { get; set; }
        ResultModel GenSerial(string sStartCode, string sPrefix, int maxlength, bool isFirst = true);
        Task<ResultModel> GenSerialAsync(string sStartCode, string sPrefix, int maxlength, bool isFirst = true);
        ResultModel GetFieldLen<T>(string dataMember);
        ResultModel GetFieldLen(Type typeOf, string dataMember);
        ResultModel GetTableName<T>();
        ResultModel HaveField<T>(string dataMember);
        ResultModel HaveField(Type typeOf, string dataMember);
        ResultModel RunValue<T>(string sFieldName, int maxlength);
        ResultModel RunValue<T>(string sFieldName, string sStartCode, string sPrefix, int maxlength);
        ResultModel RunValue<T>(string sFieldName, string sStartCode, string sPrefix, int maxlength, string[] aSQLWhere, params object[] aPara);
        Task<ResultModel> RunValueAsync<T>(string sFieldName, string sStartCode, string sPrefix, int maxlength);
        Task<ResultModel> RunValueAsync<T>(string sFieldName, string sStartCode, string sPrefix, int maxlength, string[] aSQLWhere, params object[] aPara);
    }


    public class DataHelper : IDataHelper
    {
        public readonly RicnessDbContext _context;
        public CultureInfo _culture { get; set; } = new CultureInfo("th-US");
        public DataHelper(RicnessDbContext context)
        {
            _context = context;
        }

        public ResultModel GetFieldLen<T>(string dataMember)
        {
            return GetFieldLen(typeof(T), dataMember);
        }
        public ResultModel GetFieldLen(Type typeOf, string dataMember)
        {
            ResultModel oResult = new ResultModel
            {
                Success = true,
                Data = null,
                Message = ""
            };
            if (_context is null) { return oResult; }
            var typeInfo = typeOf.GetTypeInfo();
            IEntityType oEntityType = null;
            IProperty oProperty = null;
            if (typeInfo != null)
            {
                oEntityType = _context.Model.FindEntityType(typeInfo);
            }
            if (oEntityType != null)
            {
                oProperty = oEntityType.FindProperty(dataMember);
            }
            if (oProperty != null)
            {
                oResult.Data = oProperty.GetMaxLength();
                oResult.Success = true;
                oResult.Message = "GetMaxLength Success";
            }
            return oResult;
        }
        public ResultModel HaveField<T>(string dataMember)
        {
            return HaveField(typeof(T), dataMember);
        }
        public ResultModel HaveField(Type typeOf, string dataMember)
        {
            ResultModel oResult = new ResultModel
            {
                Success = true,
                Data = true,
                Message = ""
            };
            var typeInfo = typeOf.GetTypeInfo();
            IEntityType oEntityType = null;
            IProperty oProperty = null;
            if (typeInfo != null)
            {
                oEntityType = _context.Model.FindEntityType(typeInfo);
            }
            if (oEntityType != null)
            {
                oProperty = oEntityType.FindProperty(dataMember);
            }
            oResult.Data = (oProperty != null);
            return oResult;
        }
        public ResultModel RunValue<T>(string sFieldName, int maxlength)
        {
            return RunValue<T>(sFieldName, "", "", maxlength);
        }
        public ResultModel RunValue<T>(string sFieldName, string sStartCode, string sPrefix, int maxlength)
        {
            return RunValueAsync<T>(sFieldName, sStartCode, sPrefix, maxlength, null, null).Result;
        }
        public Task<ResultModel> RunValueAsync<T>(string sFieldName, string sStartCode, string sPrefix, int maxlength)
        {
            return RunValueAsync<T>(sFieldName, sStartCode, sPrefix, maxlength, null, null);
        }
        public ResultModel RunValue<T>(string sFieldName, string sStartCode, string sPrefix, int maxlength, string[] aSQLWhere, params object[] aPara)
        {
            return RunValueAsync<T>(sFieldName, sStartCode, sPrefix, maxlength, aSQLWhere, aPara).Result;
        }
        public Task<ResultModel> RunValueAsync<T>(string sFieldName, string sStartCode, string sPrefix, int maxlength, string[] aSQLWhere, params object[] aPara)
        {
            ResultModel oResult = new ResultModel
            {
                Success = false,
                Data = "",
                Message = ""
            };
            ResultModel oTem = null;
            object SyncRoot = new object();
            decimal maxValue = 0;
            if (maxlength == 0)
            {
                oTem = GetFieldLen<T>(sFieldName);
                if (oTem.Success && oTem.Data != null)
                {
                    Decimal.TryParse((string)oTem.Data, out maxValue);
                }
            }
            string strTableName = "";
            string sSqlStr = "";
            string sSqlCondStr = "";
            oTem = GetTableName<T>();
            if (oTem.Success && oTem.Data != null)
            {
                strTableName = oTem.Data.ToString();
            }

            lock (SyncRoot)
            {
                sSqlStr = string.Format("SELECT MAX({0}) as maxcode FROM  {1} ", sFieldName, strTableName);
                if (aSQLWhere != null && aSQLWhere.Length > 0)
                {
                    sSqlCondStr = "";
                    for (int i = 0; i < aSQLWhere.Length; i++)
                    {
                        sSqlCondStr += (sSqlCondStr == "" ? string.Format("{0} = '{1}'", aSQLWhere[i], aPara[i].ToString()) : string.Format(" AND {0} = '{1}'", aSQLWhere[i], aPara[i].ToString()));
                    }
                }
                if (sPrefix.Trim().Length > 0)
                {
                    if (string.IsNullOrEmpty(sSqlCondStr) == false)
                    {
                        sSqlStr += string.Format(" WHERE {0} AND {1} LIKE '{2}%'", sSqlCondStr, sFieldName, sPrefix.Trim());
                    }
                    else
                    {
                        sSqlStr += string.Format(" WHERE {0} LIKE '{1}%'", sFieldName, sPrefix.Trim());
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(sSqlCondStr) == false)
                    {
                        sSqlStr += string.Format(" WHERE {0} ", sSqlCondStr);
                    }
                }
                //else if (sPrefix.Trim().length > 0)
                //{
                //    sSqlStr += string.Format("WHERE {0} LIKE '{1}%'", sFieldName, sPrefix.Trim());
                //}
                ResultType oRecord = null;
                try
                {
                    oRecord = Task.FromResult(_context.Database.SqlQuery<ResultType>(sSqlStr).FirstOrDefault()).Result;
                }
                catch (Exception) { }
                if (oRecord != null && string.IsNullOrEmpty(oRecord.maxcode) == false)
                {
                    string strTemValue = oRecord.maxcode ?? "";
                    string sTemPrefix = "";
                    string sMaxValue = string.Empty;
                    maxlength = strTemValue.Length;
                    if (sPrefix != "")
                    {
                        sTemPrefix = sPrefix;
                    }
                    else
                    {
                        sTemPrefix = CutString(strTemValue);
                    }
                    sMaxValue = sTemPrefix == "" ? strTemValue : strTemValue.Replace(sTemPrefix, "");
                    if (String.IsNullOrEmpty(sMaxValue) == false)
                    {
                        string tempStr = CutString(sMaxValue);
                        sMaxValue = tempStr == "" ? sMaxValue : sMaxValue.Replace(tempStr, "");
                    }
                    if (sTemPrefix.Length > 0)
                    {
                        if (sMaxValue.Length == 0)
                        {
                            oResult.Success = false;
                            oResult.Data = "";
                            oResult.Message = _culture.Name == "en-US" ? "The right most character is not a numberic" : "เลขที่สุดท้ายประกอบด้วยตัวอักษร ไม่สามารถ RUN ต่อได้ \r\n ถ้าต้องการให้เครื่อง RUN เลขที่ให้อัตโนมัติ โปรดแก้ไขให้มีแต่ตัวเลข";
                        }
                        else
                        {
                            if (IsNumOverflow(sMaxValue, out maxValue))
                            {
                                maxValue = decimal.Add(maxValue, 1);
                                if (string.IsNullOrEmpty(sPrefix) == false)
                                {
                                    oResult.Success = true;
                                    oResult.Data = sPrefix + maxValue.ToString(new string('0', maxlength - sPrefix.Length));
                                    oResult.Message = "";
                                }
                                else if (string.IsNullOrEmpty(sTemPrefix) == false)
                                {
                                    oResult.Success = true;
                                    oResult.Data = sTemPrefix + maxValue.ToString(new string('0', maxlength - sTemPrefix.Length));
                                    oResult.Message = "";
                                }
                                if (oResult.Data.ToString().Length > maxlength)
                                {
                                    oResult.Success = false;
                                    oResult.Data = "";
                                    oResult.Message = string.Format("Running overflow.,Max value is \"{0}\"", strTemValue);
                                }
                            }
                            else
                            {
                                oResult.Success = false;
                                oResult.Data = "";
                                oResult.Message = string.Format("Numberic overflow is \"{0}\"", strTemValue);
                            }
                        }
                    }
                    else
                    {
                        bool llChkDecimalAdded = false;
                        if (String.IsNullOrEmpty(sMaxValue) == false)
                        {
                            sTemPrefix = CutString(sMaxValue);
                            sMaxValue = sTemPrefix == "" ? sMaxValue : sMaxValue.Replace(sTemPrefix, "");
                        }
                        if (sMaxValue.Length > 0)
                        {
                            if (IsNumOverflow(sMaxValue, out maxValue))
                            {
                                maxValue = decimal.Add(maxValue, 1);
                                llChkDecimalAdded = true;
                            }
                            else
                            {
                                oResult.Success = false;
                                oResult.Data = "";
                                oResult.Message = string.Format("Numberic overflow is \"{0}\"", strTemValue);
                            }
                        }
                        if (llChkDecimalAdded == false)
                        {
                            maxValue = decimal.Add(maxValue, 1);
                        }
                        oResult.Success = true;
                        oResult.Data = sPrefix + maxValue.ToString(new string('0', maxlength - sPrefix.Length));
                        oResult.Message = "";
                    }
                }
                else
                {
                    if (IsNumOverflow(sStartCode.Trim() == string.Empty ? 1 : sStartCode, out maxValue))
                    {
                        //maxValue = decimal.Add(maxValue, 1);
                        int nFieldLen = 0;
                        oTem = GetFieldLen<T>(sFieldName);
                        if (oTem.Success && oTem.Data != null)
                        {
                            nFieldLen = Convert.ToInt32(oTem.Data.ToString());
                        }
                        maxlength = Math.Min(maxlength, nFieldLen);

                        oResult.Success = true;
                        oResult.Data = sPrefix + maxValue.ToString(new string('0', maxlength));
                        oResult.Message = "";
                        if (oResult.Data.ToString().Length > maxlength)
                        {
                            oResult.Success = true;
                            oResult.Data = sPrefix + maxValue.ToString(new string('0', maxlength - sPrefix.Length));
                            oResult.Message = "";
                        }
                    }
                    else
                    {
                        oResult.Success = false;
                        oResult.Data = "";
                        oResult.Message = "Numberic overflow"; ;
                    }
                }
            }
            return Task.FromResult(oResult);
        }
        public ResultModel GenSerial(string sStartCode, string sPrefix, int maxlength, bool isFirst = true)
        {
            return GenSerialAsync(sStartCode, sPrefix, maxlength, isFirst).Result;
        }
        public Task<ResultModel> GenSerialAsync(string sStartCode, string sPrefix, int maxlength, bool isFirst = true)
        {
            ResultModel oResult = new ResultModel
            {
                Success = false,
                Data = "",
                Message = ""
            };
            ResultModel oTem = null;
            object SyncRoot = new object();
            decimal maxValue = 0;
            if (maxlength == 0)
            {
                oTem = GetFieldLen<Serial>(nameof(Serial.code));
                if (oTem.Success && oTem.Data != null)
                {
                    Decimal.TryParse((string)oTem.Data, out maxValue);
                }
            }
            string strTableName = "";
            oTem = GetTableName<Serial>();
            if (oTem.Success && oTem.Data != null)
            {
                strTableName = oTem.Data.ToString();
            }
            lock (SyncRoot)
            {
                if (string.IsNullOrEmpty(sStartCode) == false)
                {
                    string strTemValue = sStartCode ?? "";
                    string sTemPrefix = "";
                    string sMaxValue = string.Empty;
                    maxlength = strTemValue.Length;
                    if (sPrefix != "")
                    {
                        sTemPrefix = sPrefix;
                    }
                    else
                    {
                        sTemPrefix = CutString(strTemValue);
                    }
                    sMaxValue = sTemPrefix == "" ? strTemValue : strTemValue.Replace(sTemPrefix, "");
                    if (String.IsNullOrEmpty(sMaxValue) == false)
                    {
                        string tempStr = CutString(sMaxValue);
                        sMaxValue = tempStr == "" ? sMaxValue : sMaxValue.Replace(tempStr, "");
                    }
                    if (sTemPrefix.Length > 0)
                    {
                        if (sMaxValue.Length == 0)
                        {
                            oResult.Success = false;
                            oResult.Data = "";
                            oResult.Message = _culture.Name == "en-US" ? "The right most character is not a numberic" : "เลขที่สุดท้ายประกอบด้วยตัวอักษร ไม่สามารถ RUN ต่อได้ \r\n ถ้าต้องการให้เครื่อง RUN เลขที่ให้อัตโนมัติ โปรดแก้ไขให้มีแต่ตัวเลข";
                        }
                        else
                        {
                            if (IsNumOverflow(sMaxValue, out maxValue))
                            {
                                maxValue = (isFirst ? maxValue : decimal.Add(maxValue, 1));
                                if (string.IsNullOrEmpty(sPrefix) == false)
                                {
                                    oResult.Success = true;
                                    oResult.Data = sPrefix + maxValue.ToString(new string('0', maxlength - sPrefix.Length));
                                    oResult.Message = "";
                                }
                                else if (string.IsNullOrEmpty(sTemPrefix) == false)
                                {
                                    oResult.Success = true;
                                    oResult.Data = sTemPrefix + maxValue.ToString(new string('0', maxlength - sTemPrefix.Length));
                                    oResult.Message = "";
                                }
                                if (oResult.Data.ToString().Length > maxlength)
                                {
                                    oResult.Success = false;
                                    oResult.Data = "";
                                    oResult.Message = string.Format("Running overflow.,Max value is \"{0}\"", strTemValue);
                                }
                            }
                            else
                            {
                                oResult.Success = false;
                                oResult.Data = "";
                                oResult.Message = string.Format("Numberic overflow is \"{0}\"", strTemValue);
                            }
                        }
                    }
                    else
                    {
                        bool llChkDecimalAdded = false;
                        if (String.IsNullOrEmpty(sMaxValue) == false)
                        {
                            sTemPrefix = CutString(sMaxValue);
                            sMaxValue = sTemPrefix == "" ? sMaxValue : sMaxValue.Replace(sTemPrefix, "");
                        }
                        if (sMaxValue.Length > 0)
                        {
                            if (IsNumOverflow(sMaxValue, out maxValue))
                            {
                                maxValue = decimal.Add(maxValue, 1);
                                llChkDecimalAdded = true;
                            }
                            else
                            {
                                oResult.Success = false;
                                oResult.Data = "";
                                oResult.Message = string.Format("Numberic overflow is \"{0}\"", strTemValue);
                            }
                        }
                        if (llChkDecimalAdded == false)
                        {
                            maxValue = decimal.Add(maxValue, 1);
                        }
                        oResult.Success = true;
                        oResult.Data = sPrefix + maxValue.ToString(new string('0', maxlength - sPrefix.Length));
                        oResult.Message = "";
                    }
                }
                else
                {
                    if (IsNumOverflow(sStartCode.Trim() == string.Empty ? 1 : sStartCode, out maxValue))
                    {
                        maxValue = decimal.Add(maxValue, 1);
                        int nFieldLen = 0;
                        oTem = GetFieldLen<Serial>(nameof(Serial.code));
                        if (oTem.Success && oTem.Data != null)
                        {
                            nFieldLen = Convert.ToInt32(oTem.Data.ToString());
                        }
                        maxlength = Math.Min(maxlength, nFieldLen);

                        oResult.Success = true;
                        oResult.Data = sPrefix + maxValue.ToString(new string('0', maxlength));
                        oResult.Message = "";
                        if (oResult.Data.ToString().Length > maxlength)
                        {
                            oResult.Success = true;
                            oResult.Data = sPrefix + maxValue.ToString(new string('0', maxlength - sPrefix.Length));
                            oResult.Message = "";
                        }
                    }
                    else
                    {
                        oResult.Success = false;
                        oResult.Data = "";
                        oResult.Message = "Numberic overflow"; ;
                    }
                }
            }
            return Task.FromResult(oResult);
        }
        public ResultModel GetTableName<T>()
        {
            ResultModel oResult = new ResultModel
            {
                Success = true,
                Data = "",
                Message = ""
            };
            var typeInfo = typeof(T).GetTypeInfo();
            IEntityType oEntityType = null;
            if (typeInfo != null)
            {
                oEntityType = _context.Model.FindEntityType(typeInfo);
            }
            if (oEntityType != null)
            {
                oResult.Data = oEntityType.ClrType.Name;
            }
            return oResult;
        }
        private string CutString(string tcinStrToCut)
        {
            string lstrCut = string.Empty;
            if (String.IsNullOrEmpty(tcinStrToCut))
            {
                return lstrCut;
            }
            for (int i = tcinStrToCut.Length - 1; i >= 0; i--)
            {
                if (Char.IsNumber(tcinStrToCut[i]) == false)
                {
                    lstrCut = tcinStrToCut.Substring(0, i + 1);
                    break;
                }
            }
            return lstrCut;
        }
        private bool IsNumOverflow(object objNum, out decimal number)
        {
            bool llSucc = true;
            number = 0;
            if (objNum == null) { return llSucc; }
            try
            {
                number = Convert.ToDecimal(objNum);
            }
            catch (OverflowException)
            {
                llSucc = false;
            }
            return llSucc;
        }

        public class ResultType
        {
            public string code { get; set; }
            public string name { get; set; }
            public string name2 { get; set; }
            public string maxcode { get; set; }
        }

    }


}
