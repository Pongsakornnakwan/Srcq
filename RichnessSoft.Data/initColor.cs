using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initColor
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrColorDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<color> listData = new List<color>()
            {
                new color { CorpCode = initCompany.gstrDefaultCorpCode ,code = initColor.gstrColorDefaultCode, name = "<ไม่ระบุสีสินค้า>", name2 = "<ColorNot Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
