using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initCustomer
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions, string strCustGrpCode)
        {
            List<customer> listData = new List<customer>()
            {
                new customer(context) { CorpCode = initCompany.gstrDefaultCorpCode ,code = "0000", name = "<ลูกค้าทั่วไป>", sname = "<ลูกค้าทั่วไป>", name2 = "<General customers>", sname2 ="<General customers>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES,custGrpCode = strCustGrpCode },
                new customer(context) { CorpCode = initCompany.gstrDefaultCorpCode ,code = "0001", name = "บริษัท ไอ แอม พลัส จำกัด", sname = "ไอ แอม พลัส", name2 = "I am plus co.,ltd.", sname2 ="I am plus co.,ltd.", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES,custGrpCode = strCustGrpCode ,custType = ConstUtil.CUSTTYPE.Corporation }
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
