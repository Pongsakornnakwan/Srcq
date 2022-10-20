using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.initData
{
    public static class initSaleTeam
    {
        /// <summary>
        /// <ไม่ระบุทีมขาย>
        /// </summary>
        public const string gstrSaleTeamDefaultCode = "000";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<SaleTeam> listData = new List<SaleTeam>()
            {
                new SaleTeam { companyid = initCompany.companyid ,code = gstrSaleTeamDefaultCode, name1 = "<ไม่ระบุทีมขาย>", name2 = "<Not Define Sale Team>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }

    }
}
