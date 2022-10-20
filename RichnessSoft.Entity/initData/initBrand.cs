using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initBrand
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrBrandDefaultCode = "00";
        public static List<Brand> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Brand> listData = new List<Brand>()
            {
                new Brand { companyid = initCompany.companyid , code = initBrand.gstrBrandDefaultCode, name1 = "<ไม่ระบุยี่ห้อ>", name2 = "<brand Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
