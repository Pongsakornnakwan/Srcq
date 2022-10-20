using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RichnessSoft.Data
{
    public static class initDepartment
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrDeptDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions
            , string strSectionCode)
        {
            List<department> listData = new List<department>()
            {
                new department { CorpCode = initCompany.gstrDefaultCorpCode ,sectionCode = strSectionCode, code = initDepartment.gstrDeptDefaultCode, name = "<ไม่ระบุแผนก>", name2 = "<Deprtment Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
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
