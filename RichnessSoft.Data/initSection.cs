using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initSection
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrSectDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<section> listData = new List<section>()
            {
                new section { CorpCode = initCompany.gstrDefaultCorpCode ,code = initSection.gstrSectDefaultCode, name = "<ไม่ระบุฝ่าย>", name2 = "<Not Define Section>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
