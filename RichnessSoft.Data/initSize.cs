using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initSize
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrSizeDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<size> listData = new List<size>()
            {
                new size { CorpCode = initCompany.gstrDefaultCorpCode ,code = initSize.gstrSizeDefaultCode, name = "<ไม่ระบุขนาดสินค้า>", name2 = "<Not Define Size>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
