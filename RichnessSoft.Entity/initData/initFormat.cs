using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initFormat
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrFormatDefaultCode = "00";
        public static List<Format> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<Format>()
            {
                new Format { companyid = initCompany.companyid ,code = initFormat.gstrFormatDefaultCode, name1 = "<ไม่ระบุรูปแบบสินค้า>", name2 = "<Format Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
