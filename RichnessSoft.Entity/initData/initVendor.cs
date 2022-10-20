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
    public static class initVendor
    {
        public static void InitializeAsync(RicnessDbContext context
           , RichnessLogDbContext contextlog
           , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Vendor> listData = new List<Vendor>()
            {
                new Vendor { companyid = initCompany.companyid ,code = "0000", name1 = "<ผู้จำหน่ายทั่วไป>", sname1 = "<ผู้จำหน่ายทั่วไป>", name2 = "<General supplier>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES, vendortype = ConstUtil.VENDORTYPE.Individual, headoffice = ConstUtil.HEADOFFICE.YES, vattype = "3", vatisout = ConstUtil.VATISOUT.OUT, vatrate = 7 , vendorgroupid = initVendorGrp.listData[0].id},
                new Vendor { companyid = initCompany.companyid ,code = "0001", name1 = "บริษัท ไอ แอม พลัส จำกัด", sname1 = "ไอ แอม พลัส", name2 = "I am plus co.,ltd.", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES, vendortype = ConstUtil.VENDORTYPE.Corporation, headoffice = ConstUtil.HEADOFFICE.YES, vattype = "3", vatisout = ConstUtil.VATISOUT.OUT, vatrate = 7 , vendorgroupid = initVendorGrp.listData[0].id}
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
