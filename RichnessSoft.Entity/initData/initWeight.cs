using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initWeight
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrWeightDefaultCode = "00";
        public static List<Weight> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<Weight>()
            {
                new Weight { companyid = initCompany.companyid ,code = initWeight.gstrWeightDefaultCode, name1 = "<ไม่ระบุน้ำหนักสินค้า>", name2 = "<Not Define Weight>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
