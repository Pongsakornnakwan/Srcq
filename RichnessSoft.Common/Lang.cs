namespace RichnessSoft.Common
{
    public class Lang
    {
        private static readonly string langDefault = gbVar.UserLang?.Name ?? "th-TH";
        public static string SysCode(string Str1, string Str2)
        {
            return SysCode(Str1, Str2, langDefault);
        }
        public static string SysCode(string Str1, string Str2, string CultureInfoName = "th-TH")
        {
            string strRetValue = (CultureInfoName.ToUpper()) switch
            {
                "TH" or "TH-TH" => Str1,
                "EN" or "US" or "EN-US" => Str2,
                _ => Str1,
            };
            return strRetValue;
        }
    }
}
