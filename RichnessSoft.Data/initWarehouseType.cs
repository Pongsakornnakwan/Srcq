using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initWarehouseType
    {
        /// <summary>
        /// คลังซื้อขาย
        /// </summary>
        public const string gstrWarehouseType_Purchase = "01";
        /// <summary>
        /// คลังระหว่างทำ
        /// </summary>
        public const string gstrWarehouseType_During = "02";
        /// <summary>
        /// คลังยืม
        /// </summary>
        public const string gstrWarehouseType_Lend = "03";
        /// <summary>
        /// คลังเบิกไปใช้
        /// </summary>
        public const string gstrWarehouseType_Reveal = "04";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<warehouse_type> listData = new List<warehouse_type>()
            {
                new warehouse_type { CorpCode = initCompany.gstrDefaultCorpCode ,code = initWarehouseType.gstrWarehouseType_Purchase, name = "คลังซื้อขาย", name2 = "Purchase", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new warehouse_type { CorpCode = initCompany.gstrDefaultCorpCode ,code = initWarehouseType.gstrWarehouseType_During, name = "คลังระหว่างทำ", name2 = "During", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new warehouse_type { CorpCode = initCompany.gstrDefaultCorpCode ,code = initWarehouseType.gstrWarehouseType_Lend, name = "คลังยืม", name2 = "Lend", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new warehouse_type { CorpCode = initCompany.gstrDefaultCorpCode ,code = initWarehouseType.gstrWarehouseType_Reveal, name = "คลังเบิกไปใช้", name2 = "Reveal", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
