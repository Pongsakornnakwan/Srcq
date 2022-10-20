using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initDesign
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrDesignDefaultCode = "00";
        public static List<Design> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<Design>()
            {
                new Design { companyid = initCompany.companyid ,code = initDesign.gstrDesignDefaultCode, name = "<ไม่ระบุแบบสินค้า>", name2 = "<Design Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
