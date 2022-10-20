using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.initData
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
            List<WarehouseType> listData = new List<WarehouseType>()
            {
                new WarehouseType {code = initWarehouseType.gstrWarehouseType_Purchase, name1 = "คลังซื้อขาย", name2 = "Purchase", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new WarehouseType {code = initWarehouseType.gstrWarehouseType_During, name1 = "คลังระหว่างทำ", name2 = "During", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new WarehouseType {code = initWarehouseType.gstrWarehouseType_Lend, name1 = "คลังยืม", name2 = "Lend", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new WarehouseType {code = initWarehouseType.gstrWarehouseType_Reveal, name1 = "คลังเบิกไปใช้", name2 = "Reveal", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
