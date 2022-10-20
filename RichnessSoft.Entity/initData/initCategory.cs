using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initCategory
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrCategoryDefaultCode = "00";
        public static List<Category> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<Category>()
            {
                new Category { companyid = initCompany.companyid , code = initCategory.gstrCategoryDefaultCode, name1 = "<ไม่ระบุหมวดสินค้า>", name2 = "<Category Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
