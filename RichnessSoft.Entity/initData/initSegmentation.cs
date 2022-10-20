using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initSegmentation
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrSegmentDefaultCode = "00";
        public static List<Segmentation> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Segmentation> listData = new List<Segmentation>()
            {
                new Segmentation { companyid = initCompany.companyid ,code = initSegmentation.gstrSegmentDefaultCode, name1 = "<ไม่ระบุส่วนแบ่งตลาด>", name2 = "<Not Define Segmentation>", createatutc = DateTime.Now, updateatutc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
