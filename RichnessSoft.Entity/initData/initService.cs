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
    public static class initService
    {
        public static void InitializeAsync(RicnessDbContext context
          , RichnessLogDbContext contextlog
          , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Service> listData = new List<Service>()
            {
                new Service { companyid = initCompany.companyid ,code = "R-01001", name1 = "รายได้จากการบริการ", sname = "รายได้จากการบริการ", name2 = "Revenue <example>", createatutc = DateTime.Now, updateatutc = DateTime.Now, umid = initUnit.Um.id, prodtype = "R", productgroupid = initProductGrp.productGroup.id, active = ConstUtil.ACTIVE.YES },
                new Service { companyid = initCompany.companyid ,code = "E-01001", name1 = "ค่าใช้จ่ายทั่วไป", sname = "ค่าใช้จ่ายทั่วไป", name2 = "Expenses <example>", createatutc = DateTime.Now, updateatutc = DateTime.Now, umid = initUnit.Um.id, prodtype = "E", productgroupid = initProductGrp.productGroup.id, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
