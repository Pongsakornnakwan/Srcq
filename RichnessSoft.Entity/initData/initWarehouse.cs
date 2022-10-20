using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using System;
using System.Collections.Generic;
using RichnessSoft.Entity.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RichnessSoft.Common;

namespace RichnessSoft.Entity.initData
{
    public static class initWarehouse
    {
        /// <summary>
        /// 01-คลักหลัก
        /// </summary>
        public const string gstrWarehouseMainCode = "01";
        public static List<Warehouse> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions, string warehouse_type)
        {
            listData = new List<Warehouse>()
            {
                new Warehouse { companyid = initCompany.companyid , branchid = initBranch.branchid , code = initWarehouse.gstrWarehouseMainCode, name1 = "คลังหลัก", name2 = "Main Warehouse", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES, warehousetype = warehouse_type}
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
