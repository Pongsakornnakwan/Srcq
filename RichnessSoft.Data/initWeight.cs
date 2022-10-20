using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initWeight
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrWeightDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<weight> listData = new List<weight>()
            {
                new weight { CorpCode = initCompany.gstrDefaultCorpCode ,code = initWeight.gstrWeightDefaultCode, name = "<ไม่ระบุน้ำหนักสินค้า>", name2 = "<Not Define Weight>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
