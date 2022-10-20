using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initVendorGrp
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrVendorGrpCode = "00";
        public static void  InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<venderGroup> listData = new List<venderGroup>()
            {
                new venderGroup { CorpCode = initCompany.gstrDefaultCorpCode ,code = initVendorGrp.gstrVendorGrpCode, name = "<ไม่ระบุกลุ่มผู้จำหน่าย>", name2 = "<Not Define Vendor group>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
