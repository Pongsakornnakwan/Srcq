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
    public class initDepartment
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrDeptDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Department> listData = new List<Department>()
            {
                new Department { companyid = initCompany.companyid ,sectionid = initSection.Section.id, code = initDepartment.gstrDeptDefaultCode, name = "<ไม่ระบุแผนก>", name2 = "<Deprtment Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
