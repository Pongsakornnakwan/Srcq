using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initCurrency
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrCurrencyDefaultCode = "000";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<currency> listData = new List<currency>()
            {
                new currency() { CorpCode = initCompany.gstrDefaultCorpCode ,code = initCurrency.gstrCurrencyDefaultCode, name = "<ไม่ระบุหน่วยเงิน>" , name2 = "<Currency Not Define>",symbol="-",countryCode = "00", ratio= Convert.ToDecimal(1), CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now , active = ConstUtil.ACTIVE.YES } ,
                new currency() { CorpCode = initCompany.gstrDefaultCorpCode ,code = "THB", name = "บาท" , name2 = "BAHT",symbol="฿",countryCode = "TH", ratio= Convert.ToDecimal(1),CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES  } ,
                new currency() { CorpCode = initCompany.gstrDefaultCorpCode ,code = "USD", name = "ดอลลาร์สหรัฐ" , name2 = "US Dollar",symbol="$",countryCode = "US", ratio= Convert.ToDecimal(30.35),CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES  },
                new currency() { CorpCode = initCompany.gstrDefaultCorpCode ,code = "EUR", name = "ยูโร" , name2 = "European Union",symbol="€",countryCode = "00",ratio= Convert.ToDecimal(35.83),CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES  },
                new currency() { CorpCode = initCompany.gstrDefaultCorpCode ,code = "JPY", name = "เยน ญี่ปุ่น" , name2 = "Japanese Yen",symbol="¥",countryCode = "JA",ratio= Convert.ToDecimal(0.29),CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES  },
                new currency() { CorpCode = initCompany.gstrDefaultCorpCode ,code = "CNY", name = "หยวน เรนมินบิ จีน" , name2 = "Chinese Yuan Renminbi",symbol="", countryCode = "CH",ratio= Convert.ToDecimal(4.26),CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES  },
                new currency() { CorpCode = initCompany.gstrDefaultCorpCode ,code = "SGD", name = "ดอลลาร์สิงคโปร์" , name2 = "Singapore Dollar",symbol="",countryCode = "SN",ratio= Convert.ToDecimal(22.62),CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES  }
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
