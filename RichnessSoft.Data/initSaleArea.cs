using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initSaleArea
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrSaleAreaDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<saleArea> listData = new List<saleArea>()
            {
                new saleArea { CorpCode = initCompany.gstrDefaultCorpCode ,code = initSaleArea.gstrSaleAreaDefaultCode, name = "<ไม่ระบุเขตการขาย>", name2 = "Sale Area Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
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
