using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initCurrency
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrCurrencyDefaultCode = "000";
        public static List<Currency> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<Currency>()
            {
                new Currency() { companyid = initCompany.companyid ,code = initCurrency.gstrCurrencyDefaultCode, name1 = "<ไม่ระบุหน่วยเงิน>" , name2 = "<Currency Not Define>",symbol="-",countrycode = "00", ratio= Convert.ToDecimal(1), createatutc = DateTime.Now, updateatutc = DateTime.Now , active = ConstUtil.ACTIVE.YES } ,
                new Currency() { companyid = initCompany.companyid ,code = "THB", name1 = "บาท" , name2 = "BAHT",symbol="฿",countrycode = "TH", ratio= Convert.ToDecimal(1),createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES  } ,
                new Currency() { companyid = initCompany.companyid ,code = "USD", name1 = "ดอลลาร์สหรัฐ" , name2 = "US Dollar",symbol="$",countrycode = "US", ratio= Convert.ToDecimal(30.35),createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES  },
                new Currency() { companyid = initCompany.companyid ,code = "EUR", name1 = "ยูโร" , name2 = "European Union",symbol="€",countrycode = "00",ratio= Convert.ToDecimal(35.83),createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES  },
                new Currency() { companyid = initCompany.companyid ,code = "JPY", name1 = "เยน ญี่ปุ่น" , name2 = "Japanese Yen",symbol="¥",countrycode = "JA",ratio= Convert.ToDecimal(0.29),createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES  },
                new Currency() { companyid = initCompany.companyid ,code = "CNY", name1 = "หยวน เรนมินบิ จีน" , name2 = "Chinese Yuan Renminbi",symbol="", countrycode = "CH",ratio= Convert.ToDecimal(4.26),createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES  },
                new Currency() { companyid = initCompany.companyid ,code = "SGD", name1 = "ดอลลาร์สิงคโปร์" , name2 = "Singapore Dollar",symbol="",countrycode = "SN",ratio= Convert.ToDecimal(22.62),createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES  }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
