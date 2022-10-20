using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initWarehouse
    {
        /// <summary>
        /// 01-คลักหลัก
        /// </summary>
        public const string gstrWarehouseMainCode = "01";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions, string warehouse_type)
        {
            List<warehouse> listData = new List<warehouse>()
            {
                new warehouse { CorpCode = initCompany.gstrDefaultCorpCode , BranchCode = initBranch.gstrBranchCode, code = initWarehouse.gstrWarehouseMainCode, name = "คลังหลัก", name2 = "Main Warehouse", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES, w_typeCode = warehouse_type}
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
