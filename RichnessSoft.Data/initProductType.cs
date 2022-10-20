using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
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
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<prodtype> listData = new List<prodtype>()
            {
                new prodtype() { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductType.gstrFinishedProductCode, name = "สินค้าสำเร็จรูป" , name2 = "Finished Product" , active = ConstUtil.ACTIVE.YES , flag = "P", CreateAtUtc = DateTime.Now , CreateBy ="System"  } ,
                new prodtype() { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductType.gstrMaterialCode, name = "วัตถุดิบ" , name2 = "Material", active = ConstUtil.ACTIVE.YES  , flag = "P" , CreateAtUtc = DateTime.Now , CreateBy ="System" } ,
                new prodtype() { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductType.gstrAssetCode, name = "สินทรัพย์" , name2 = "Asset", active = ConstUtil.ACTIVE.YES  , flag = "P" , CreateAtUtc = DateTime.Now , CreateBy ="System" } ,
                new prodtype() { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductType.gstrConsumablesCode, name = "วัสดุสิ้นเปลือง" , name2 = "Consumables", active = ConstUtil.ACTIVE.YES  , flag = "P" , CreateAtUtc = DateTime.Now , CreateBy ="System"  } ,
                new prodtype() { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductType.gstrOtherIncomeCode, name = "รายได้อื่นๆ" , name2 = "Other Income", active = ConstUtil.ACTIVE.YES , flag = "S" , CreateAtUtc = DateTime.Now , CreateBy ="System"  } ,
                new prodtype() { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductType.gstrOtherExpensesCode, name = "ค่าใช้จ่ายอื่นๆ" , name2 = "Other Expenses", active = ConstUtil.ACTIVE.YES , flag = "S" , CreateAtUtc = DateTime.Now , CreateBy ="System"  },
                new prodtype() { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductType.gstrInsuranceCode, name = "เบี้ยประกันภัย" , name2 = "Insurance", active = ConstUtil.ACTIVE.YES , flag = "S" , CreateAtUtc = DateTime.Now , CreateBy ="System"  }
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
