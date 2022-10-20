using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initVendor
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions ,string strVendorGrpCode)
        {
            List<vendor> listData = new List<vendor>()
            {
                new vendor { CorpCode = initCompany.gstrDefaultCorpCode ,code = "0000", name = "<ผู้จำหน่ายทั่วไป>", sname = "<ผู้จำหน่ายทั่วไป>", name2 = "<General supplier>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES, vendorType = ConstUtil.VENDORTYPE.Individual, headOffice = ConstUtil.HEADOFFICE.YES, vattypeCode = "3", vatisout = ConstUtil.VATISOUT.OUT, vatrate = 7 , vendorGrpCode = strVendorGrpCode},
                new vendor { CorpCode = initCompany.gstrDefaultCorpCode ,code = "0001", name = "บริษัท ไอ แอม พลัส จำกัด", sname = "ไอ แอม พลัส", name2 = "I am plus co.,ltd.", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES, vendorType = ConstUtil.VENDORTYPE.Corporation, headOffice = ConstUtil.HEADOFFICE.YES, vattypeCode = "3", vatisout = ConstUtil.VATISOUT.OUT, vatrate = 7 , vendorGrpCode = strVendorGrpCode }
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
