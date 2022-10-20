using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initMember
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrMemberDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<member> listData = new List<member>()
            {
                new member { CorpCode = initCompany.gstrDefaultCorpCode ,code = initMember.gstrMemberDefaultCode, name = "<ไม่ระบุสมาชิก>", name2 = "<Not Define Member>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
