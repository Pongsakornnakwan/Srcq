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
    public class initColor
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrColorDefaultCode = "00";
        public static List<Colour> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
           listData = new List<Colour>()
            {
                new Colour { companyid = initCompany.companyid ,code = initColor.gstrColorDefaultCode, name1 = "<ไม่ระบุสีสินค้า>", name2 = "<ColorNot Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
