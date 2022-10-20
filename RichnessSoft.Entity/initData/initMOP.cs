using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initMOP
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrMOPDefaultCode = "00";
        public static List<Mop> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Mop> listData = new List<Mop>()
            {
                new Mop { companyid = initCompany.companyid ,code = initMOP.gstrMOPDefaultCode, name = "<ไม่ระบุ>", name2 = "<Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
