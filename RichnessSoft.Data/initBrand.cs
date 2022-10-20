using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initBrand
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrBrandDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<brand> listData = new List<brand>()
            {
                new brand { CorpCode = initCompany.gstrDefaultCorpCode, code = initBrand.gstrBrandDefaultCode, name = "<ไม่ระบุยี่ห้อ>", name2 = "<Brand Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
