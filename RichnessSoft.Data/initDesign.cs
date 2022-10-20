using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initDesign
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrDesignDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<design> listData = new List<design>()
            {
                new design { CorpCode = initCompany.gstrDefaultCorpCode ,code = initDesign.gstrDesignDefaultCode, name = "<ไม่ระบุแบบสินค้า>", name2 = "<Design Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
