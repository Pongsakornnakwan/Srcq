using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RichnessSoft.Common;

using RichnessSoft.Entity.Model;

namespace RichnessSoft.Entity.initData
{
    public static class initVendorGrp
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrVendorGrpCode = "00";
        public static List<VendorGroup> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<VendorGroup>()
            {
                new VendorGroup { companyid = initCompany.companyid ,code = initVendorGrp.gstrVendorGrpCode, name1 = "<ไม่ระบุกลุ่มผู้จำหน่าย>", name2 = "<Not Define vendor group>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
