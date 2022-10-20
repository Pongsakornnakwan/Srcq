using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initplans
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrplansDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<plans> listData = new List<plans>()
            {
                new plans { CorpCode = initCompany.gstrDefaultCorpCode ,code = initplans.gstrplansDefaultCode, name = "<ไม่ระบุแผนงาน>", name2 = "<plans Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now ,active = ConstUtil.ACTIVE.YES }
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
