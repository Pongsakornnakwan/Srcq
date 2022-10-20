using System;
namespace RichnessSoft.Common
{
    public class cDisplay
    {
        private const string gstrEngLang = "en-US";
        private const string gstrThaiLang = "th-TH";
        /// <summary>
        ///  แสดงสถานะ
        /// </summary>
        /// <param name="active">field active</param>
        /// <returns>String</returns>
        public static string Active(string active = ConstUtil.ACTIVE.YES)
        {
            return Active(active, "th-TH");
        }
        /// <summary>
        /// แสดงสถานะ
        /// </summary>
        /// <param name="active"> field active</param>
        /// <param name="strUserLang">ภาษาที่จะแสดง</param>
        /// <returns>String</returns>
        public static string Active(string active = ConstUtil.ACTIVE.YES, string strUserLang = gstrThaiLang)
        {
            string strRetValue = "";
            switch (active)
            {
                case ConstUtil.ACTIVE.YES:
                    strRetValue = strUserLang == gstrEngLang ? "Active" : "ใช้งาน";
                    break;
                case ConstUtil.ACTIVE.NO:
                    strRetValue = strUserLang == gstrEngLang ? "Inactive" : "ไม่ใช้งาน";
                    break;
                default:
                    break;
            }
            return strRetValue;
        }

    }
}
