using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initModel
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrModelDefaultCode = "00";
        public static List<Models> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Models> listData = new List<Models>()
            {
                new Models { companyid = initCompany.companyid ,code = initModel.gstrModelDefaultCode, name1 = "<ไม่ระบุรุ่นสินค้า>", name2 = "<Model Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
