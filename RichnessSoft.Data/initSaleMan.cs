using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initSaleMan
    {
        /// <summary>
        /// <ไม่ระบุพนักงานขาย>
        /// </summary>
        public const string gstrSalemanDefaultCode = "-";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<saleMan> listData = new List<saleMan>()
            {
                new saleMan { CorpCode = initCompany.gstrDefaultCorpCode ,prefix_th = "000", code = gstrSalemanDefaultCode, name = "<ไม่ระบุพนักงานขาย>", name2 = "<Not Define Salesman>", card_no = "-", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
