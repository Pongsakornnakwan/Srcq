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
    public class initUnit
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrUmDefaultCode = "00";
        public static UM Um;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<UM> liUnit = new List<UM>()
            {
                new UM { companyid = initCompany.companyid ,code = "00", name1 = "<ไม่ระบุหน่วยนับ>", name2 = "<Not Define Unit>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new UM { companyid = initCompany.companyid ,code = "01", name1 = "ชิ้น", name2 = "Piece", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new UM { companyid = initCompany.companyid ,code = "02", name1 = "กล่อง", name2 = "Carton", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new UM { companyid = initCompany.companyid ,code = "03", name1 = "ลัง", name2 = "Crate", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new UM { companyid = initCompany.companyid ,code = "04", name1 = "ถุง", name2 = "Bag", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new UM { companyid = initCompany.companyid ,code = "05", name1 = "ขวด", name2 = "Bottle", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new UM { companyid = initCompany.companyid ,code = "06", name1 = "ครั้ง", name2 = "Time", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(liUnit.ToArray());
            context.SaveChanges();
            Um = liUnit[0];
        }
    }
}
