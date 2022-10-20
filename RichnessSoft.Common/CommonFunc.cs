using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RichnessSoft.Common
{
    public static class CommonFunc
    {
        public static string EncryptData(string strToHash)
        {
            string Result = "";
            System.Security.Cryptography.SHA1CryptoServiceProvider OSha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();

            //Step 1
            byte[] bytesToHash = System.Text.Encoding.ASCII.GetBytes(strToHash);

            //Step 2
            bytesToHash = OSha1.ComputeHash(bytesToHash);

            //Step 3
            foreach (byte item in bytesToHash)
            {
                Result += item.ToString("x2");
            }
            return Result;
        }

        public static string toThaiMonth(DateTime DMonth)
        {
            CultureInfo _enCulture = new CultureInfo("en-US");
            CultureInfo _thCulture = new CultureInfo("th-TH");
            return DMonth.ToString("MMMM", _thCulture);
        }

        public static string toThaiYear(DateTime DYear)
        {
            CultureInfo _enCulture = new CultureInfo("en-US");
            CultureInfo _thCulture = new CultureInfo("th-TH");
            return DYear.ToString("yyyy", _thCulture);
        }

        public static DateTime toDatetime(string str)
        {
            DateTime dt = new DateTime();
            try
            {
                dt = Convert.ToDateTime(str);
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
            return dt;
        }

        public static bool IsNumberOnly(string myString)
        {
            bool bSucc = true;
            for (int i = 0; i < myString.Length; i++)
            {
                if (i < 1 || IsDigit(myString[i].ToString()))
                { }
                else
                {
                    bSucc = false;
                    break;
                }
            }
            return bSucc;
        }

        public static bool IsDigit(string tcString)
        {
            //get the first character in the string
            char c = tcString[0];
            return Char.IsDigit(c);
        }
        public static Array GmArrayRemoveAt(Array tainSource, int tninIndex)
        {
            if (tainSource is null) { return tainSource; }
            if (0 > tninIndex || tninIndex >= tainSource.Length) { return tainSource; }
            Array laDest = Array.CreateInstance(tainSource.GetType().GetElementType(), tainSource.Length - 1);
            Array.Copy(tainSource, 0, laDest, 0, tninIndex);
            Array.Copy(tainSource, tninIndex + 1, laDest, tninIndex, tainSource.Length - tninIndex - 1);
            return laDest;
        }
        


    }
}
