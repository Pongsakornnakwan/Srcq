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
    public static class initSize
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrSizeDefaultCode = "00";
        public static List<Size> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<Size>()
            {
                new Size { companyid = initCompany.companyid ,code = initSize.gstrSizeDefaultCode, name1 = "<ไม่ระบุขนาดสินค้า>", name2 = "<Not Define Size>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
