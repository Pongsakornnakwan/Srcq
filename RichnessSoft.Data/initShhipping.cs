using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initShhipping
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrShhippingDefaultCode = "000";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<shipping> listData = new List<shipping>()
            {
                new shipping { CorpCode = initCompany.gstrDefaultCorpCode ,code = initShhipping.gstrShhippingDefaultCode, name = "<ไม่ระบุการขนส่ง>", name2 = "<Not Define Shipping>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new shipping { CorpCode = initCompany.gstrDefaultCorpCode ,code = "001", name = "รถไฟ", name2 = "Railroads", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new shipping { CorpCode = initCompany.gstrDefaultCorpCode ,code = "002", name = "รถยนต์", name2 = "Motor Transportation", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new shipping { CorpCode = initCompany.gstrDefaultCorpCode ,code = "003", name = "รถบรรทุก", name2 = "Truck Transportation", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new shipping { CorpCode = initCompany.gstrDefaultCorpCode ,code = "004", name = "ทางเรือ", name2 = "Water Transportation", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new shipping { CorpCode = initCompany.gstrDefaultCorpCode ,code = "005", name = "ทางอากาศ", name2 = "Air Transportation", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new shipping { CorpCode = initCompany.gstrDefaultCorpCode ,code = "006", name = "ระบบคอนเทนเนอร์", name2 = "Container System", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
