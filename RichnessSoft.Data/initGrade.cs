using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RichnessSoft.Data
{
    public static class initGrade
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrGradeDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<grade> listData = new List<grade>()
            {
                new grade { CorpCode = initCompany.gstrDefaultCorpCode ,code = initGrade.gstrGradeDefaultCode, name = "<ไม่ระบุคุณภาพสินค้า>", name2 = "<Grade Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
