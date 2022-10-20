using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace RichnessSoft.Common
{
    public class StrUtil
    {
        public static string AllTrim(string cExpression)
        {
            return cExpression.Trim();
        }

        public static int Asc(char cCharacter)
        {
            return (int)cCharacter;
        }
        private static int At(string cSearchFor, string cSearchIn, int nOccurence)
        {
            return __at(cSearchFor, cSearchIn, nOccurence, 1);
        }

        private static int __at(string cSearchFor, string cSearchIn, int nOccurence, int nMode)
        {

            int i = 0;
            int nOccured = 0;
            int nPos = 0;
            if (nMode == 1) { nPos = 0; }
            else { nPos = cSearchIn.Length; }
            for (i = 1; i <= nOccurence; i++)
            {
                if (nMode == 1) { nPos = cSearchIn.IndexOf(cSearchFor, nPos); }
                else { nPos = cSearchIn.LastIndexOf(cSearchFor, nPos); }

                if (nPos < 0)
                {
                    break;
                }
                else
                {
                    nOccured++;
                    if (nOccured == nOccurence)
                    {
                        return nPos + 1;
                    }
                    else
                    {
                        if (nMode == 1) { nPos++; }
                        else { nPos--; }
                    }
                }
            }
            return 0;
        }

        public static int xAt(string cSearchExpression, string cExpressionSearched)
        { return xAt(cSearchExpression, cExpressionSearched, 1); }

        public static int xAt(string cSearchExpression, string cExpressionSearched, int nOccurrence)
        {
            int num3 = -1;
            int num2 = 0;
            char[] chArray1 = cExpressionSearched.ToCharArray();
            if (cSearchExpression.IndexOfAny(chArray1) == 0)
            {
                int num5 = cExpressionSearched.Length - 1;
                for (int num1 = 0; num1 <= num5; num1++)
                {
                    if (StringType.StrCmp(cSearchExpression, StringType.FromChar(chArray1[num1]), false) == 0)
                    {
                        num2++;
                        num3 = num1;
                        if (num2 == nOccurrence)
                        {
                            break;
                        }
                    }
                }
            }
            return num3;
        }

        public static int AtC(string cSearchFor, string cSearchIn)
        {
            return cSearchIn.ToLower().IndexOf(cSearchFor.ToLower()) + 1;
        }

        public static int AtC(string cSearchFor, string cSearchIn, int nOccurence)
        {
            return __at(cSearchFor.ToLower(), cSearchIn.ToLower(), nOccurence, 1);
        }

        public static char Chr(int nAnsiCode)
        {
            return (char)nAnsiCode;
        }
        public static string xChrt(object tcinValue)
        {
            return xChrTran(tcinValue.ToString(), @"abcdefghijklmnopqrstuwxyz1234567890ฤฺฉฏฎโฌ็ณ๋ษศ?์ฯญ๐ฑฆธ๊" + Chr(34) + ")ํ(+๑๒๓๔ู฿๕๖๗ฟิแกำดเ้ร่าสทืนยๆพหะีไปัผๅ/-ภถุึคตจจ", "ABCDEFGHIJKLMNOPQRSTUWXYZ1234567890ABCDEFGHIJKLMNOPQRSTUWXYZ1234567890ABCDEFGHIJKLMNOPQRSTUWXYZ1234567890");
        }


        public static string xChrTran(string cSearchedExpression, string cSearchExpression, string cReplacementExpression)
        {
            char[] chArray2 = cSearchExpression.ToCharArray();
            char[] chArray1 = cReplacementExpression.ToCharArray();
            char[] chArray3 = cSearchedExpression.ToCharArray();
            int num4 = chArray3.Length - 1;
            for (int num1 = 0; num1 <= num4; num1++)
            {
                if (chArray3[num1].ToString().IndexOfAny(chArray2) == 0)
                {
                    int num3 = chArray2.Length - 1;
                    for (int num2 = 0; num2 <= num3; num2++)
                    {
                        if (chArray3[num1] == chArray2[num2])
                        {
                            if (num2 > (chArray1.Length - 1))
                            {
                                chArray3[num1] = '\0';
                            }
                            else
                            {
                                chArray3[num1] = chArray1[num2];
                            }
                            break;
                        }
                    }
                }
            }
            string[] textArray1 = new string[1] { new string(chArray3) };
            return string.Concat(textArray1);
        }

        public static string CreateBinary(string cExpression)
        {
            return cExpression;
        }

        public static string FileToStr(string cFileName)
        {
            StreamReader oReader = System.IO.File.OpenText(cFileName);

            string lcString = oReader.ReadToEnd();

            oReader.Close();
            return lcString;
        }

        public static long GetWordCount(string cString)
        {
            int i = 0;
            long nLength = cString.Length;
            long nWordCount = 0;

            if (!Char.IsWhiteSpace(cString[0]))
            {
                nWordCount++;
            }

            for (i = 0; i < nLength; i++)
            {
                if (Char.IsWhiteSpace(cString[i]))
                {
                    do
                    {
                        i++;
                        if (i >= nLength) { break; }
                        if (!Char.IsWhiteSpace(cString[i]))
                        {
                            nWordCount++;
                            break;
                        }
                    } while (true);

                }

            }
            return nWordCount;
        }


        public static bool IsAlpha(string cExpression)
        {
            return Char.IsLetter(cExpression[0]);
        }
        public static bool IsLower(string cExpression)
        {
            try
            {
                string lcString = cExpression.Substring(0, 1);
                return lcString == lcString.ToLower();
            }
            catch
            {
                return false;
            }
        }

        public static bool IsUpper(string cExpression)
        {
            try
            {
                string lcString = cExpression.Substring(0, 1);
                return lcString == lcString.ToUpper();
            }
            catch
            {
                return false;
            }
        }

        public static string Left(string cExpression, int nDigits)
        {
            if (string.IsNullOrEmpty(cExpression))
                return "";
            else
                return Microsoft.VisualBasic.Strings.Left(cExpression, nDigits);
        }

        public static int Len(string cExpression)
        {
            return cExpression.Length;
        }

        public static string Lower(string cExpression)
        {
            return cExpression.ToLower();
        }

        public static string LTrim(string cExpression)
        {
            return cExpression.TrimStart(null);
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

        public static string PadC(string cExpression, int nResultSize)
        {
            int nPaddTotal = nResultSize - cExpression.Length;
            int lnHalfLength = (int)(nPaddTotal / 2);

            string lcString = xPadLeft(cExpression, cExpression.Length + lnHalfLength);
            return lcString.PadRight(nResultSize);
        }

        public static string PadC(string cExpression, int nResultSize, char cPaddingChar)
        {
            int nPaddTotal = nResultSize - cExpression.Length;
            int lnHalfLength = (int)(nPaddTotal / 2);

            string lcString = xPadLeft(cExpression, cExpression.Length + lnHalfLength, cPaddingChar);
            return lcString.PadRight(nResultSize, cPaddingChar);
        }

        public static string xPadLeft(string cExpression, int nResultSize)
        {
            return StrUtil.mPadString(cExpression, nResultSize, 1, ' ');
        }
        public static string xPadLeft(string cExpression, int nResultSize, char cPadCharacter)
        {
            return StrUtil.mPadString(cExpression, nResultSize, 1, cPadCharacter);
        }

        public static string xPadRight(string cExpression, int nResultSize)
        {
            return StrUtil.mPadString(cExpression, nResultSize, 2, ' ');
        }

        public static string xPadRight(string cExpression, int nResultSize, char cPadCharacter)
        {
            return StrUtil.mPadString(cExpression, nResultSize, 2, cPadCharacter);
        }

        public static string Proper(string cString)
        {
            StringBuilder sb = new StringBuilder(cString);
            int i, j = 0;
            int nLength = cString.Length;

            for (i = 0; i < nLength; i++)
            {
                if ((i == 0) || (char.IsWhiteSpace(cString[i])))
                {
                    if (i == 0) { j = i; }
                    else { j = i + 1; }
                    sb.Remove(j, 1);
                    sb.Insert(j, Char.ToUpper(cString[j]));
                }
            }
            return sb.ToString();
        }

        public static int RAt(string cSearchFor, string cSearchIn)
        {
            return cSearchIn.LastIndexOf(cSearchFor) + 1;
        }

        public static int RAt(string cSearchFor, string cSearchIn, int nOccurence)
        {
            return __at(cSearchFor, cSearchIn, nOccurence, 0);
        }

        public static string Replicate(string cExpression, int nTimes)
        {
            if (nTimes != 0)
            {
                StringBuilder builder1 = new StringBuilder();
                builder1.Insert(0, cExpression, nTimes);
                return builder1.ToString();
            }
            else
                return "";
        }


        public static string Right(string cExpression, int nDigits)
        {
            return cExpression.Substring(cExpression.Length - nDigits);
        }

        public static string RTrim(string cExpression)
        {
            return cExpression.TrimEnd(null);
        }

        public static string Space(int nSpaces)
        {
            char val = ' ';
            return new string(val, nSpaces);
        }

        public static string Str(int nNumber)
        {
            return nNumber.ToString();
        }

        public static string Str(double nNumber)
        {
            return nNumber.ToString();
        }

        public static string Str(decimal nNumber)
        {
            return nNumber.ToString();
        }

        public static string StrExtract(string cSearchExpression, string cBeginDelim, string cEndDelim, int nBeginOccurence, int nFlags)
        {
            string cstring = cSearchExpression;
            string cb = cBeginDelim;
            string ce = cEndDelim;
            string lcRetVal = "";

            if (cstring != string.Empty)
            {
                if (nFlags == 1)
                {
                    cstring = cstring.ToLower();
                    cb = cb.ToLower();
                    ce = ce.ToLower();
                }
                int nbpos = At(cb, cstring, nBeginOccurence) + cb.Length - 1;
                int nepos = cstring.IndexOf(ce, nbpos + 1);
                if (nepos > nbpos)
                {
                    lcRetVal = cSearchExpression.Substring(nbpos, nepos - nbpos);
                }
            }

            return lcRetVal;
        }

        public static string StrExtract(string cSearchExpression, string cBeginDelim)
        {
            int nbpos = xAt(cBeginDelim, cSearchExpression);
            return cSearchExpression.Substring(nbpos + cBeginDelim.Length - 1);
        }

        public static string StrExtract(string cSearchExpression, string cBeginDelim, string cEndDelim)
        {
            return StrExtract(cSearchExpression, cBeginDelim, cEndDelim, 1, 0);
        }

        public static string StrExtract(string cSearchExpression, string cBeginDelim, string cEndDelim, int nBeginOccurence)
        {
            return StrExtract(cSearchExpression, cBeginDelim, cEndDelim, nBeginOccurence, 0);
        }
        public static void StrToFile(string cExpression, string cFileName)
        {
            if (System.IO.File.Exists(cFileName) == true)
            {
                System.IO.File.Delete(cFileName);
            }
            FileStream oFs = new FileStream(cFileName, FileMode.CreateNew, FileAccess.ReadWrite);
            StreamWriter oWriter = new StreamWriter(oFs);
            oWriter.Write(cExpression);
            oWriter.Flush();
            oWriter.Close();

            oFs.Close();
        }
        public static void StrToFile(string cExpression, string cFileName, bool lAdditive)
        {
            FileStream oFs = new FileStream(cFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter oWriter = new StreamWriter(oFs);
            oWriter.BaseStream.Seek(0, SeekOrigin.End);
            oWriter.Write(cExpression);
            oWriter.Flush();
            oWriter.Close();
            oFs.Close();
        }

        public static string StrTran(string cSearchIn, string cSearchFor, string cReplaceWith, int nStartoccurence, int nCount)
        {
            StringBuilder builder1 = new StringBuilder(cSearchIn);
            builder1.Replace(cSearchFor, cReplaceWith);
            return builder1.Replace(cSearchFor, cReplaceWith, nStartoccurence, nCount).ToString();
        }
        public static string StrTran(string cSearchIn, string cSearchFor, string cReplaceWith)
        {
            StringBuilder builder1 = new StringBuilder(cSearchIn);
            builder1.Replace(cSearchFor, cReplaceWith);
            return builder1.Replace(cSearchFor, cReplaceWith).ToString();
        }
        public static string StrTran(string cSearchIn, string cSearchFor)
        {
            StringBuilder builder1 = new StringBuilder(cSearchIn);
            return builder1.Replace(cSearchFor, "").ToString();
        }

        public static string xStuff(string cExpression, int nStartReplacement, int nCharactersReplaced, string cReplacement)
        {
            nStartReplacement = IntegerType.FromObject(Interaction.IIf(nStartReplacement <= 0, 1, nStartReplacement));
            nCharactersReplaced = IntegerType.FromObject(Interaction.IIf(nCharactersReplaced < 0, 0, nCharactersReplaced));
            string text1 = cExpression.Remove(nStartReplacement - 1, cExpression.Length - (nStartReplacement - 1));
            string text2 = cExpression.Substring((nStartReplacement + nCharactersReplaced) - 1);
            return (text1 + cReplacement + text2);
        }

        public static string SubStr(string cExpression, int nStartPosition)
        {
            return cExpression.Substring(nStartPosition - 1);
        }

        public static string SubStr(string cExpression, int nStartPosition, int nLength)
        {
            nStartPosition--;
            if ((nLength + nStartPosition) > cExpression.Length)
                return cExpression.Substring(nStartPosition);
            else
                return cExpression.Substring(nStartPosition, nLength);
        }

        public static string Trim(string cExpression)
        {
            return cExpression.Trim();
        }

        public static string Upper(string cExpression)
        {
            return cExpression.ToUpper();
        }


        public static int Val(string cExpression)
        {

            return Int32.Parse(cExpression, NumberStyles.Any);
        }


        public static int RAtLine(string tcSearchExpression, string tcExpressionSearched)
        {
            string lcString;
            int nPosition;
            int nCount = 0;

            try
            {
                nPosition = StrUtil.RAt(tcSearchExpression, tcExpressionSearched);
                if (nPosition > 0)
                {
                    lcString = StrUtil.SubStr(tcExpressionSearched, 1, nPosition - 1);
                    nCount = StrUtil.Occurs(@"\r", lcString) + 1;
                }
            }
            catch
            {
                nCount = 0;
            }

            return nCount;
        }


        public static bool IsDigit(string tcString)
        {
            char c = tcString[0];
            return Char.IsDigit(c);
        }


        public static string MLine(string tcString, int tnLineNo)
        {
            string[] aLines = tcString.Split('\r');
            string lcRetVal = "";
            try
            {
                lcRetVal = aLines[tnLineNo - 1];
            }
            catch
            {
            }
            return lcRetVal;
        }

        public static bool Between(char tcChar, char tcLowChar, char tcHighChar)
        {
            return ((tcChar >= tcLowChar) & (tcChar <= tcHighChar));
        }


        public static bool Between(DateTime tdDateTime, DateTime tdStartDate, DateTime tdEndDate)
        {
            return ((DateTime.Compare(tdDateTime, tdStartDate) >= 0) & (DateTime.Compare(tdDateTime, tdEndDate) <= 0));
        }

        public static bool Between(decimal tnExpression, decimal tnLowValue, decimal tnHighValue)
        {
            return ((decimal.Compare(tnExpression, tnLowValue) >= 0) & (decimal.Compare(tnExpression, tnHighValue) <= 0));
        }

        public static bool Between(double tnExpression, double tnLowValue, double tnHighValue)
        {
            return ((tnExpression >= tnLowValue) & (tnExpression <= tnHighValue));
        }

        public static bool Between(int tnExpression, int tnLowValue, int tnHighValue)
        {
            return ((tnExpression >= tnLowValue) & (tnExpression <= tnHighValue));
        }

        public static bool Between(string tcExpression, string tcStart, string tcEnd)
        {

            bool flag2 = true;
            int num1 = 1;
            int num4 = num1 + 1;
            int num5 = tcStart.Length - 1;
            num1 = 0;
            while (((num4 >> 0x1f) ^ num1) <= ((num4 >> 0x1f) ^ num5))
            {
                if (tcStart[num1] < tcExpression[num1])
                {
                    flag2 = false;
                    break;
                }
                if (num1 == tcExpression.Length)
                {
                    break;
                }
                num1 += num4;
            }
            int num2 = num1 + 1;
            int num3 = tcEnd.Length - 1;
            for (num1 = 0; ((num2 >> 0x1f) ^ num1) <= ((num2 >> 0x1f) ^ num3); num1 += num2)
            {
                if (tcEnd[num1] > tcExpression[num1])
                {
                    flag2 = false;
                    break;
                }
                if (num1 == tcExpression.Length)
                {
                    break;
                }
            }
            return flag2;
        }
        public static bool InList(object toExpression, params object[] toItems)
        {
            return (Array.IndexOf(toItems, RuntimeHelpers.GetObjectValue(toExpression)) > -1);
        }

        private static string mPadString(string cExpression, int nResultSize, int nDirection, [Optional] char cPadCharacter /* = ' ' */)
        {
            string text2 = "";
            if (nResultSize > (cExpression.Length - 1))
            {
                switch (nDirection)
                {
                    case 0:
                        {
                            goto Label_0054;
                        }
                    case 1:
                        {
                            text2 = cExpression.PadLeft(nResultSize, cPadCharacter);
                            goto Label_0054;
                        }
                    case 2:
                        {
                            return cExpression.PadRight(nResultSize, cPadCharacter);
                        }
                }
                goto Label_0054;
            }
            text2 = cExpression.Remove(nResultSize, cExpression.Length - nResultSize);
        Label_0054:
            return text2;
        }

        private static int pnRunning = new Random().Next(1, 100000);

        public static string GenerateId()
        {
            return GenerateId(pnRunning++);
        }
        public static string GenerateId(int nRunning)
        {
            return GenerateId(nRunning, "");
        }
        public static string GenerateId(int nRunning, string tcinPrefix)
        {
            string lcRetValue = string.Empty;
            string lcTemValue = string.Empty;
            long i = 1;
            long j = 1;
            if (string.IsNullOrEmpty(tcinPrefix) == false)
            {
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                lcTemValue = string.Format("{0:X}", i - DateTime.Now.Ticks) + StrUtil.Base220(nRunning, 3); // บวก running ป้องกันการซ้ำ
            }
            else
            {
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                char[] UniqueKey = GetUniqueKey(4).ToCharArray();
                foreach (char c in UniqueKey)
                {
                    byte b = Convert.ToByte(c);
                    j *= ((int)b + 1);
                }
                lcTemValue = string.Format("{0:X}", i - DateTime.Now.Ticks) + StrUtil.Base220(nRunning, 3);// +string.Format("{0:X}", j - DateTime.Now.Ticks).Substring(0, 4); // บวก running ป้องกันการซ้ำ
                lcTemValue = lcTemValue + Right(string.Format("{0:X}", j - DateTime.Now.Ticks), 24 - lcTemValue.Length);
            }
            if (UtilHelper.gmIsNullOrEmpty(tcinPrefix) == false)
            {
                lcRetValue = string.Format("{0}{1}", tcinPrefix.Length <= 4 ? tcinPrefix : tcinPrefix.Substring(0, 4), lcTemValue);
            }
            else
            {
                lcRetValue = lcTemValue;
            }
            return lcRetValue;
        }


        public static string GetUniqueKey(int nMaxSize)
        {

            if (nMaxSize == 0) { nMaxSize = 1; };
            string sCharKey = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            char[] cACharKey = new char[sCharKey.Length];
            cACharKey = sCharKey.ToCharArray();
            byte[] aData = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(aData);
            aData = new byte[nMaxSize];
            crypto.GetNonZeroBytes(aData);
            StringBuilder result = new StringBuilder(nMaxSize);
            foreach (byte b in aData)
            {
                result.Append(cACharKey[b % (cACharKey.Length - 1)]);
            }
            ///Guid obj = Guid.NewGuid();
            return result.ToString();
        }

        public static char FChr(string tsinName)
        {
            if (string.Compare(tsinName, "", false) == 0)
            {
                return '\0';
            }
            char[] chArray1 = tsinName.ToCharArray();
            char[] chArray2 = new char[5] { '\u0e40', '\u0e41', '\u0e42', '\u0e44', '\u0e43' };
            if ((tsinName.IndexOfAny(chArray2) == 0) & (tsinName.Length > 0))
            {
                return chArray1[1];
            }
            return chArray1[0];
        }
        public const int gnSeqRunningLen = 4;
        public static string Base220(int inBase10, int inLen = gnSeqRunningLen)
        {
            int lnLng = inLen;
            string strBase220 = "";
            int intBase10 = inBase10;
            int intModulus10;
            for (int lnRun = 1; lnRun <= lnLng; lnRun++)
            {
                intModulus10 = (intBase10 % 62);
                intBase10 = (intBase10 - intModulus10) / 62;
                if (intModulus10 <= 9)		// 0-9
                    intModulus10 = intModulus10 + 48;
                else if (intModulus10 <= 35)		// A-Z ( 10 - 35 ) โดย  A = 10 +55
                    intModulus10 = intModulus10 + 55;
                else
                {
                    //a-z ( 36 - 61 ) โดย a = 36 +61
                    intModulus10 = intModulus10 + 61;
                }
                strBase220 = Strings.Chr(intModulus10) + strBase220;
            }
            return strBase220;
        }



        public static int Base10(string inBase220)
        {
            int lnLenght, lnBase10, lnNum;
            string lcBase220, lcChr;
            lnLenght = inBase220.Length;
            lcBase220 = inBase220.Replace(" ", "0");
            lnBase10 = 0;
            for (int lnLoop = 0; lnLoop <= lnLenght - 1; lnLoop++)
            {
                lcChr = SubStr(lcBase220, lnLoop, 1);

                if (string.Compare(lcChr, "0", true) < 0)	//lcChr < "0"
                    lcChr = "0";
                else if (CommonUtil.xBetween(lcChr, Strings.Chr(58).ToString(), Strings.Chr(64).ToString()))
                    lcChr = "A";
                else if (CommonUtil.xBetween(lcChr, Strings.Chr(91).ToString(), Strings.Chr(96).ToString()))
                    lcChr = "a";
                else if (string.Compare(lcChr, "z", true) > 0)
                    lcChr = "z";

                if (string.Compare(lcChr, "9", true) <= 0) //lcChr <= "9"
                    lnNum = Strings.Asc(lcChr) - 48;
                else if (string.Compare(lcChr, "Z", true) <= 0)	//lcChr <= "Z"
                    lnNum = Strings.Asc(lcChr) - 55;
                else
                    lnNum = Strings.Asc(lcChr) - 61; //case lcChr <= 'z'

                lnBase10 = lnBase10 * 62 + lnNum;
            }
            return lnBase10;
        }

        public static string Inc220(string inBase220)
        {
            string kBase220 = inBase220.Trim() + Replicate("0", inBase220.Length - inBase220.Trim().Length);
            int kAt = kBase220.Length;
            string kChr = "";
            while (kAt > 0)
            {
                kChr = SubStr(kBase220, kAt, 1);
                if (string.Compare(kChr, "z", true) < 0) // kChr < 'z	&& OK
                {
                    kChr = Strings.Chr(Strings.Asc(kChr) + 1).ToString();
                    if (string.Compare(kChr, "0", true) < 0)
                        kBase220 = xStuff(kBase220, kAt, 1, "0");
                    else if (CommonUtil.xBetween(kChr, Strings.Chr(58).ToString(), Strings.Chr(6).ToString()))
                        kBase220 = xStuff(kBase220, kAt, 1, "A");
                    else if (CommonUtil.xBetween(kChr, Strings.Chr(91).ToString(), Strings.Chr(96).ToString()))
                        kBase220 = xStuff(kBase220, kAt, 1, "a");
                    else
                        kBase220 = xStuff(kBase220, kAt, 1, kChr);
                    break;
                }
                else
                {
                    if (kAt == 1) // เหลือตัวสุดท้ายแล้ว และยังเป็น 'z' อีก จึงเพิ่มไม่ได้
                        throw new Exception("OVERFLOW in Inc220!!! Call programer");
                    else
                        kBase220 = xStuff(kBase220, kAt, 1, "0"); //  ยังปัดไปหลักถัดไปได้
                }
                kAt = kAt - 1;
            }
            return kBase220;
        }


        public static string CutStr(ref string outStr)
        {
            return CutStr(ref outStr, "", false);
        }
        public static string CutStr(ref string outStr, string inDeliStr)
        {
            return CutStr(ref outStr, inDeliStr, false);
        }
        public static string CutStr(ref string outStr, string inDeliStr, bool inNoTrim)
        {
            string text2 = "";
            int num1 = outStr.IndexOf(inDeliStr);
            if (!inNoTrim)
            {
                outStr = outStr.Trim();
            }
            if (num1 > -1)
            {
                text2 = Strings.Left(outStr, num1);
                if (((Strings.Len(text2) + Strings.Len(inDeliStr)) + 1) <= Strings.Len(outStr))
                {
                    outStr = outStr.Substring(Strings.Len(text2) + Strings.Len(inDeliStr));
                }
                else
                {
                    outStr = "";
                }
            }
            else
            {
                text2 = outStr;
                outStr = "";
            }
            return text2;
        }

        public static string CutStr2(string lstrCut, string ParaToCut, int lArrayIndex)
        {
            string text1;
            object obj1 = "";
            try
            {
                obj1 = Strings.Split(lstrCut, ParaToCut, -1, CompareMethod.Text);
                object[] objArray1 = new object[1] { lArrayIndex - 1 };
                text1 = StringType.FromObject(LateBinding.LateIndexGet(obj1, objArray1, null));
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                text1 = string.Empty;
                ProjectData.ClearProjectError();
                return text1;
            }
            return text1;
        }

        public static string HexToDec(string hex)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i <= hex.Length - 2; i += 2)
            {
                sb.Append(Microsoft.VisualBasic.Strings.Chr(Int32.Parse(hex.Substring(i, 2), System.Globalization.NumberStyles.HexNumber)));
            }
            return sb.ToString();
        }

        public static string DecToHex(string dec)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i <= dec.Length - 1; i += 1)
            {
                sb.Append(string.Format("{0:X}", Microsoft.VisualBasic.Strings.Asc(dec.Substring(i, 1))));
            }
            return sb.ToString();
        }

        public static string HashText(string text)
        {
            return HashText(text, "", new MD5CryptoServiceProvider());
        }
        public static string HashText(string text, HashAlgorithm hasher)
        {
            return HashText(text, "", hasher);
        }
        public static string HashText(string text, string salt)
        {
            return HashText(text, salt, new MD5CryptoServiceProvider());
        }

        public static string HashText(string text, string salt, HashAlgorithm hasher)
        {
            byte[] textWithSaltBytes = Encoding.UTF8.GetBytes(string.Concat(text, salt));
            byte[] hashedBytes = hasher.ComputeHash(textWithSaltBytes);
            hasher.Clear();
            return Convert.ToBase64String(hashedBytes);
        }

        public static double IIF(bool TlinVar, double Case1, double Case2)
        {
            return IIF<double>(TlinVar, Case1, Case2);
        }
        public static decimal IIF(bool TlinVar, decimal Case1, decimal Case2)
        {
            return IIF<decimal>(TlinVar, Case1, Case2);
        }
        public static int IIF(bool TlinVar, int Case1, int Case2)
        {
            return IIF<int>(TlinVar, Case1, Case2);
        }
        
        public static string IIF(bool TlinVar, string Case1, string Case2)
        {
            return IIF<string>(TlinVar, Case1, Case2);
        }
        public static char IIF(bool TlinVar, char Case1, char Case2)
        {
            return IIF<char>(TlinVar, Case1, Case2);
        }
        public static byte[] IIF(bool TlinVar, byte[] Case1, byte[] Case2)
        {
            return IIF<byte[]>(TlinVar, Case1, Case2);
        }
        public static object IIF(bool TlinVar, object Case1, object Case2)
        {
            return IIF<object>(TlinVar, Case1, Case2);
        }
        private static T IIF<T>(bool TlinVar, object Case1, object Case2)
        {
            return TlinVar ? (T)Convert.ChangeType(Case1, typeof(T)) : (T)Convert.ChangeType(Case2, typeof(T));
        }

        public static System.Collections.ArrayList SubString(string tcinString, int FieldLen)
        {
            char cPad = ' ';
            string temp_string = tcinString;
            string temp_string2 = "";
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            if (string.IsNullOrEmpty(tcinString) || FieldLen == 0) { return null; }
            if (tcinString.Length <= FieldLen)
            {
                list.Add(tcinString);
            }
            else
            {
                int lnFoundPadIndex = FieldLen;
                while (temp_string.Length != 0)
                {
                    temp_string2 = "";
                    lnFoundPadIndex = FieldLen;

                    string tempStr = temp_string.Substring(0, FieldLen);
                    char[] char_arrays = tempStr.ToCharArray();
                    for (int i = char_arrays.Length - 1; i < 0; i--)
                    {
                        if (char_arrays[i].CompareTo(cPad) == 0)
                        {
                            lnFoundPadIndex = i;
                            break;
                        }
                    }
                    if (lnFoundPadIndex != FieldLen)
                    {
                        temp_string2 = tempStr.Substring(0, lnFoundPadIndex);
                    }
                    else
                    {
                        temp_string2 = tempStr.Substring(0, FieldLen);
                    }
                    list.Add(temp_string2);
                    temp_string = temp_string.Replace(temp_string2, "");
                }
            }
            return list;
        }
        public static System.Collections.ArrayList SubString(string tcinString, string tcinPadStr, int FieldLen)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            if (string.IsNullOrEmpty(tcinString) || FieldLen == 0) { return null; }
            return list;
        }


    }
}
