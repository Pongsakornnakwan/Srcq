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
    public static class initSaleMan
    {
        /// <summary>
        /// <ไม่ระบุพนักงานขาย>
        /// </summary>
        public const string gstrSalemanDefaultCode = "-";
        public static List<SaleMan> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<SaleMan>()
            {
                new SaleMan { companyid = initCompany.companyid ,prefix_th = "000", code = gstrSalemanDefaultCode, name1 = "<ไม่ระบุพนักงานขาย>", name2 = "<Not Define Salesman>", card_no = "-", createatutc = DateTime.Now, updateatutc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
