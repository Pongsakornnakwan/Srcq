using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initProject
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrProjDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions
            , string strPlanCode)
        {
            List<project> listData = new List<project>()
            {
                new project { CorpCode = initCompany.gstrDefaultCorpCode ,planCode = strPlanCode, code = initProject.gstrProjDefaultCode, name = "<ไม่ระบุโครการ>", name2 = "<Project Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
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
