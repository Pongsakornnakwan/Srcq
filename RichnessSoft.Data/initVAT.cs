using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initVAT
    {
        /// <summary>
        /// VAT 7
        /// </summary>
        public const string gstrVAT_1 = "1";
        /// <summary>
        /// VAT 0
        /// </summary>
        public const string gstrVAT_2 = "2";
        /// <summary>
        /// VAT 10
        /// </summary>
        public const string gstrVAT_3 = "3";
        /// <summary>
        /// Tax exempt 
        /// </summary>
        public const string gstrVAT_4 = "4";
        /// <summary>
        /// VAT 5
        /// </summary>
        public const string gstrVAT_5 = "WH01";
        /// <summary>
        /// VAT 1
        /// </summary>
        public const string gstrVAT_6 = "WH02";
        /// <summary>
        /// VAT 2
        /// </summary>
        public const string gstrVAT_7 = "WH03";
        /// <summary>
        /// VAT 1
        /// </summary>
        public const string gstrVAT_8 = "WH04";
        /// <summary>
        /// VAT 1
        /// </summary>
        public const string gstrVAT_9 = "WH05";
        /// <summary>
        /// VAT 5
        /// </summary>
        public const string gstrVAT_10 = "WH06";

        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<vattype> listData = new List<vattype>()
            {
                new vattype() { code = initVAT.gstrVAT_1 , name = "VAT 7" , name2 = "VAT 7", rate = 7, active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , vat_type = ConstUtil.TYPE_VAT.VALUE_ADDED_TAX } ,
                new vattype() { code = initVAT.gstrVAT_2 , name = "VAT 0" , name2 = "VAT 0", rate = 0, active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , vat_type = ConstUtil.TYPE_VAT.VALUE_ADDED_TAX } ,
                new vattype() { code = initVAT.gstrVAT_3 , name = "VAT 10" , name2 = "VAT 10", rate = 10, active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , vat_type = ConstUtil.TYPE_VAT.VALUE_ADDED_TAX } ,
                new vattype() { code = initVAT.gstrVAT_4 , name = "ยกเว้นภาษี" , name2 = "Tax exempt", rate = 0, active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , vat_type = ConstUtil.TYPE_VAT.VALUE_ADDED_TAX } ,
                new vattype() { code = initVAT.gstrVAT_5 , name = "ค่าบริการ" , name2 = "Service", rate = 3, active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , vat_type = ConstUtil.TYPE_VAT.WITHHOLDING_TAX },
                new vattype() { code = initVAT.gstrVAT_6 , name = "ค่าเช่า" , name2 = "Rent", rate = 5, active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , vat_type = ConstUtil.TYPE_VAT.WITHHOLDING_TAX } ,
                new vattype() { code = initVAT.gstrVAT_7 , name = "ค่าขนส่ง" , name2 = "Transportation", rate = 1, active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , vat_type = ConstUtil.TYPE_VAT.WITHHOLDING_TAX },
                new vattype() { code = initVAT.gstrVAT_8 , name = "ค่าโฆษณา" , name2 = "Advertising", rate = 2, active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , vat_type = ConstUtil.TYPE_VAT.WITHHOLDING_TAX },
                new vattype() { code = initVAT.gstrVAT_9 , name = "ดอกเบี้ย" , name2 = "Interest", rate = 1, active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , vat_type = ConstUtil.TYPE_VAT.WITHHOLDING_TAX },
                new vattype() { code = initVAT.gstrVAT_10 , name = "ค่าเบี้ยประกันวินาศภัย" , name2 = "Non-life insurance premiums", rate = 1, active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , vat_type = ConstUtil.TYPE_VAT.WITHHOLDING_TAX },

            };
            //foreach (var item in listData)
            //{
            //    context.Add(item);
            //}
            //context.SaveChanges();
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
