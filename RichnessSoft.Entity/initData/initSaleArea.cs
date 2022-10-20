using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initSaleArea

    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrSaleAreaDefaultCode = "00";
        public static List<SaleArea> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<SaleArea> listData = new List<SaleArea>()
            {
                new SaleArea { companyid = initCompany.companyid ,code = initSaleArea.gstrSaleAreaDefaultCode, name1 = "<ไม่ระบุเขตการขาย>", name2 = "Sale Area Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
