using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initFormat
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrFormatDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<format> listData = new List<format>()
            {
                new format { CorpCode = initCompany.gstrDefaultCorpCode ,code = initFormat.gstrFormatDefaultCode, name = "<ไม่ระบุรูปแบบสินค้า>", name2 = "<Format Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
