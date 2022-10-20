using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RichnessSoft.Entity.Model;
using RichnessSoft.Common;

namespace RichnessSoft.Entity.initData
{
    public static class initCustGrp
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrCustGrpCode = "00";
        public static List<CustGroup> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<CustGroup>()
            {
                new CustGroup { companyid = initCompany.companyid , code = initCustGrp.gstrCustGrpCode, Name = "<ไม่ระบุกลุ่มลูกค้า>", name2 = "<Custmer group Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now, Active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
