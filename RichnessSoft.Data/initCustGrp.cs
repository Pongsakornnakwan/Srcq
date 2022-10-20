using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initCustGrp
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrCustGrpCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<custGroup> listData = new List<custGroup>()
            {
                new custGroup { CorpCode = initCompany.gstrDefaultCorpCode , code = initCustGrp.gstrCustGrpCode, name = "<ไม่ระบุกลุ่มลูกค้า>", name2 = "<Custmer group Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
