using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;


namespace RichnessSoft.Entity.initData
{
    public static class initGrade
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrGradeDefaultCode = "00";
        public static List<Grade> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<Grade>()
            {
                new Grade { companyid = initCompany.companyid ,code = initGrade.gstrGradeDefaultCode, name = "<ไม่ระบุคุณภาพสินค้า>", name2 = "<Grade Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
