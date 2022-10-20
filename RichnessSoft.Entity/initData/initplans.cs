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
    public class initplans
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrplansDefaultCode = "00";
        public static Plans Plans;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Plans> listData = new List<Plans>()
            {
                new Plans { companyid = initCompany.companyid ,code = initplans.gstrplansDefaultCode, name1 = "<ไม่ระบุแผนงาน>", name2 = "<plans Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now ,active = ConstUtil.ACTIVE.YES }
            };
            //foreach (var item in listData)
            //{
            //    context.Add(item);
            //}
            //context.SaveChanges();
            context.AddRange(listData.ToArray());
            context.SaveChanges();
            Plans = listData[0];
        }
    }
}
