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
    public static class initProject
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrProjDefaultCode = "00";
        public static List<Project> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<Project>()
            {
                new Project { companyid = initCompany.companyid ,planid = initplans.Plans.id, code = initProject.gstrProjDefaultCode, name1 = "<ไม่ระบุโครการ>", name2 = "<Project Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
