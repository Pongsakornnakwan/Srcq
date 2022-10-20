using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;


namespace RichnessSoft.Entity.initData
{
    public static class initShhipping
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrShhippingDefaultCode = "000";
        public static List<Shipping> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Shipping> listData = new List<Shipping>()
            {
                new Shipping { companyid = initCompany.companyid ,code = initShhipping.gstrShhippingDefaultCode, name1 = "<ไม่ระบุการขนส่ง>", name2 = "<Not Define Shipping>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new Shipping { companyid = initCompany.companyid ,code = "001", name1 = "รถไฟ", name2 = "Railroads", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new Shipping { companyid = initCompany.companyid ,code = "002", name1 = "รถยนต์", name2 = "Motor Transportation", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new Shipping { companyid = initCompany.companyid ,code = "003", name1 = "รถบรรทุก", name2 = "Truck Transportation", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new Shipping { companyid = initCompany.companyid ,code = "004", name1 = "ทางเรือ", name2 = "Water Transportation", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new Shipping { companyid = initCompany.companyid ,code = "005", name1 = "ทางอากาศ", name2 = "Air Transportation", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new Shipping { companyid = initCompany.companyid ,code = "006", name1 = "ระบบคอนเทนเนอร์", name2 = "Container system", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
