using System;
using System.Collections.Generic;
using System.Text;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System.Linq;
using RichnessSoft.Common;
using System.Threading.Tasks;

namespace RichnessSoft.Data
{
    public static class initService
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<service> listData = new List<service>()
            {
                new service { CorpCode = initCompany.gstrDefaultCorpCode ,code = "R-01001", name = "รายได้จากการบริการ", sName = "รายได้จากการบริการ", name2 = "Revenue <example>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, UmCode = "06", pdTypeCode = "R", pdGroupCode = "02", active = ConstUtil.ACTIVE.YES },
                new service { CorpCode = initCompany.gstrDefaultCorpCode ,code = "E-01001", name = "ค่าใช้จ่ายทั่วไป", sName = "ค่าใช้จ่ายทั่วไป", name2 = "Expenses <example>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, UmCode = "06", pdTypeCode = "E", pdGroupCode = "02", active = ConstUtil.ACTIVE.YES }
            };
            //foreach (var item in listData)
            //{
            //    context.Add(item);
            //}
            //context.SaveChanges();
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
