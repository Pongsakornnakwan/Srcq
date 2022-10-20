using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initCategory
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrCategoryDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<category> listData = new List<category>()
            {
                new category { CorpCode = initCompany.gstrDefaultCorpCode , code = initCategory.gstrCategoryDefaultCode, name = "<ไม่ระบุหมวดสินค้า>", name2 = "<Category Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
