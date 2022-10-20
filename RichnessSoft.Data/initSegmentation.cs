using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initSegmentation
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrSegmentDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Segmentation> listData = new List<Segmentation>()
            {
                new Segmentation { CorpCode = initCompany.gstrDefaultCorpCode ,code = initSegmentation.gstrSegmentDefaultCode, name = "<ไม่ระบุส่วนแบ่งตลาด>", name2 = "<Not Define Segmentation>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
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
