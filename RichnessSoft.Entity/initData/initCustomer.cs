using RichnessSoft.Common;
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
    public static class initCustomer
    {
        public static void InitializeAsync(RicnessDbContext context
           , RichnessLogDbContext contextlog
           , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Customer> listData = new List<Customer>()
            {
                new Customer { companyid = initCompany.companyid ,code = "0000", name1 = "<ลูกค้าทั่วไป>", sname1 = "<ลูกค้าทั่วไป>", name2 = "<General customers>", sname2 ="<General customers>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES,custgroupid = initCustGrp.listData[0].id,custtype = ConstUtil.CUSTTYPE.Individual },
                new Customer { companyid = initCompany.companyid ,code = "0001", name1 = "บริษัท ไอ แอม พลัส จำกัด", sname1 = "ไอ แอม พลัส", name2 = "I am plus co.,ltd.", sname2 ="I am plus co.,ltd.", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES,custgroupid = initCustGrp.listData[0].id ,custtype = ConstUtil.CUSTTYPE.Corporation }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
