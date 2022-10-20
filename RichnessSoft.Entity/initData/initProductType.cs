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
    public static class initProductType
    {
        /// <summary>
        /// สินค้าสำเร็จรูป
        /// </summary>
        public const string gstrFinishedProductCode = "F";
        /// <summary>
        /// วัตถุดิบ
        /// </summary>
        public const string gstrMaterialCode = "M";
        /// <summary>
        /// สินทรัพย์
        /// </summary>
        public const string gstrAssetCode = "A";
        /// <summary>
        /// วัสดุสิ้นเปลือง
        /// </summary>
        public const string gstrConsumablesCode = "C";
        /// <summary>
        /// รายได้อื่นๆ
        /// </summary>
        public const string gstrOtherIncomeCode = "R";
        /// <summary>
        /// ค่าใช้จ่ายอื่นๆ
        /// </summary>
        public const string gstrOtherExpensesCode = "E";
        /// <summary>
        /// ค่าใช้จ่ายอื่นๆ
        /// </summary>
        public const string gstrInsuranceCode = "I";

        public  static ProdType prodTypeFinished;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<ProdType> listData = new List<ProdType>()
            {
                new ProdType() { code = initProductType.gstrFinishedProductCode, name1 = "สินค้าสำเร็จรูป" , name2 = "Finished Product" , active = ConstUtil.ACTIVE.YES , flag = "P", createatutc = DateTime.Now , createby ="system"  } ,
                new ProdType() { code = initProductType.gstrMaterialCode, name1 = "วัตถุดิบ" , name2 = "Material", active = ConstUtil.ACTIVE.YES  , flag = "P" , createatutc = DateTime.Now , createby ="system" } ,
                new ProdType() { code = initProductType.gstrAssetCode, name1 = "สินทรัพย์" , name2 = "Asset", active = ConstUtil.ACTIVE.YES  , flag = "P" , createatutc = DateTime.Now , createby ="system" } ,
                new ProdType() { code = initProductType.gstrConsumablesCode, name1 = "วัสดุสิ้นเปลือง" , name2 = "Consumables", active = ConstUtil.ACTIVE.YES  , flag = "P" , createatutc = DateTime.Now , createby ="system"  } ,
                new ProdType() { code = initProductType.gstrOtherIncomeCode, name1 = "รายได้อื่นๆ" , name2 = "Other Income", active = ConstUtil.ACTIVE.YES , flag = "S" , createatutc = DateTime.Now , createby ="system"  } ,
                new ProdType() { code = initProductType.gstrOtherExpensesCode, name1 = "ค่าใช้จ่ายอื่นๆ" , name2 = "Other Expenses", active = ConstUtil.ACTIVE.YES , flag = "S" , createatutc = DateTime.Now , createby ="system"  },
                new ProdType() { code = initProductType.gstrInsuranceCode, name1 = "เบี้ยประกันภัย" , name2 = "Insurance", active = ConstUtil.ACTIVE.YES , flag = "S" , createatutc = DateTime.Now , createby ="system"  }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
            prodTypeFinished = listData[0];
        }
    }
}
