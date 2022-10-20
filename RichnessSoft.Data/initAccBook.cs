using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initAccBook
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<accBook> listData = new List<accBook>()
            {
                new accBook { CorpCode = initCompany.gstrDefaultCorpCode, code = "JV", name = "สมุดรายวันทั่วไป", name2="General journal" , CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new accBook { CorpCode = initCompany.gstrDefaultCorpCode, code = "AP", name = "สมุดซื้อเชื่อ", name2="Buy journal", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new accBook { CorpCode = initCompany.gstrDefaultCorpCode, code = "PV", name = "สมุดรายวันจ่าย", name2="Pay journal", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new accBook { CorpCode = initCompany.gstrDefaultCorpCode, code = "AR", name = "สมุดขายเชื่อ", name2="Sales journal", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new accBook { CorpCode = initCompany.gstrDefaultCorpCode, code = "SV", name = "สมุดเรายวันรับ", name2="Receipt journal", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now }
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
