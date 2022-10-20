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
    public static class initAccBook
    {
        public static List<AccBook> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<AccBook>()
            {
                new AccBook { companyid = initCompany.companyid, code = "JV", name1 = "สมุดรายวันทั่วไป", name2="General journal" , createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new AccBook { companyid = initCompany.companyid, code = "AP", name1 = "สมุดซื้อเชื่อ", name2="Buy journal", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new AccBook { companyid = initCompany.companyid, code = "PV", name1 = "สมุดรายวันจ่าย", name2="Pay journal", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new AccBook { companyid = initCompany.companyid, code = "AR", name1 = "สมุดขายเชื่อ", name2="Sales journal", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new AccBook { companyid = initCompany.companyid, code = "SV", name1 = "สมุดเรายวันรับ", name2="Receipt journal", createatutc = DateTime.Now, updateatutc = DateTime.Now }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
