using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initModel
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrModelDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<model> listData = new List<model>()
            {
                new model { CorpCode = initCompany.gstrDefaultCorpCode ,code = initModel.gstrModelDefaultCode, name = "<ไม่ระบุรุ่นสินค้า>", name2 = "<Model Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
