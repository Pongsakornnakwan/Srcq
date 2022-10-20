using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace RichnessSoft.Common
{

    public static partial class gbVar
    {
         public static string MainConstr = "";
        public static string LogConstr = "";
        public static string branchCode = "";
        public static string bookCode = "";
        public static string sectCode = "";
        public static string deptCode = "";
        public static string projCode = "";
        public static string planCode = "";
        public static string docTypeCode = "";
        public static string vatTypeCode = "1";

        public static string ModeInsert = "I";
        public static string ModeEdit = "E";
        public static string ModeDelete = "D";

        public static string gbTypeMenuHeader1 = "H1";
        public static string gbTypeMenuHeader2 = "H2";
        public static string gbTypeMenuSubMenu = "S";

        /// <summary>
        /// ภาษา(ตามผู้ใช้งาน)
        /// </summary>
        //public static CultureInfo UserLang { get; set; } = new("en-US");
        public static CultureInfo UserLang { get; set; } = new("th-TH");
        /// <summary>
        /// จำนวนตำแหน่งทศนิยม (System Config)
        /// </summary>
        public static int GnDecimalPlaces { get; set; } = 2;
        /// <summary>
        /// ตัวเลขยอมรับจุดและเครื่องหมาย(,)
        /// </summary>
        public static NumberStyles GnNumberStyles { get; set; } = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign;

        public static string WebRootPath { get; set; } = "";

        public static object goCurrCorp = null;
    }

    public static class gbOptionVar
    {
        /// <summary>
        /// เปืด Option แผนก
        /// </summary>
        public static bool gbOpenOptionDept { get; set; } = true;
        /// <summary>
        /// เปืด Option ฝ่าย
        /// </summary>
        public static bool gbOpenOptionSect { get; set; } = true;
        /// <summary>
        /// เปืด Option โครงการ
        /// </summary>
        public static bool gbOpenOptionProj { get; set; } = true;
        /// <summary>
        /// เปืด Option หน่วยเงิน
        /// </summary>
        public static bool gbOpenOptionCurrency { get; set; } = true;
        /// <summary>
        /// เปืด Option อัตราแลกเปลี่ยน
        /// </summary>
        public static bool gbOpenOptionExchangeRate { get; set; } = true;
        /// <summary>
        /// เปืด Option หน่วยเงินมาตรฐาน
        /// </summary>
        public static bool gbOpenOptionStdCurrency { get; set; } = true;
        /// <summary>
        /// เปืด Option ประเภทภาษีมูลค่าเพิ่ม ระดับรายการสินค้า
        /// </summary>
        public static bool gbOpenOptionVATItem { get; set; } = false;
    }

    public static class GbConstVar
    {
        /// <summary>
        ///  นำเข้า / ส่งออก
        /// </summary>
        public static class IOTYPE
        {
            /// <summary>
            /// IN = นำเข้า
            /// </summary>
            public const string IN = "I";
            /// <summary>
            /// IN = ส่งออก
            /// </summary>
            public const string OUT = "O";
        }
    }


}
