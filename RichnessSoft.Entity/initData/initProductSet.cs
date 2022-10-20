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
    public static class initProductSet
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<ProductSet> listData = new List<ProductSet>()
            {
                new ProductSet { companyid=initCompany.companyid,code = "00",name1 = "ชุด 1", sname1 = "ชุด 1", name2 = "Set 1",sname2 = "set 2",prodtype = "F",umid = initUnit.Um.id, vattype = "1",setprint = "C", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES},
                new ProductSet { companyid=initCompany.companyid,code = "01",name1 = "ชุด 2", sname1 = "ชุด 2", name2 = "Set 2",sname2 = "set 2",prodtype = "F",umid = initUnit.Um.id, vattype = "1",setprint = "C", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
            List<ProductSetDetail> listPdDetail = new List<ProductSetDetail>()
            {
                new ProductSetDetail { companyid=initCompany.companyid ,productsetid  =listData[0].id,productid=initProduct.listProduct.Where(x=>x.code=="P-01001").FirstOrDefault().id ,settype="P", saleprice =100, qty=1,umqty=6,umid=initUnit.Um.id , seq = 0},
                new ProductSetDetail { companyid=initCompany.companyid ,productsetid  =listData[0].id,productid=initProduct.listProduct.Where(x=>x.code=="P-01002").FirstOrDefault().id ,settype="P", saleprice =10 , qty=2,umqty=1,umid=initUnit.Um.id , seq = 1},
                new ProductSetDetail { companyid=initCompany.companyid ,productsetid  =listData[0].id,productid=initProduct.listProduct.Where(x=>x.code=="P-01003").FirstOrDefault().id ,settype="P", saleprice =120, qty=1,umqty=6,umid=initUnit.Um.id , seq = 2},
                new ProductSetDetail { companyid=initCompany.companyid ,productsetid  =listData[1].id,productid=initProduct.listProduct.Where(x=>x.code=="P-01001").FirstOrDefault().id ,settype="P", saleprice =150, qty=1,umqty=6,umid=initUnit.Um.id , seq = 0},
                new ProductSetDetail { companyid=initCompany.companyid ,productsetid  =listData[1].id,productid=initProduct.listProduct.Where(x=>x.code=="P-01002").FirstOrDefault().id ,settype="P", saleprice =130, qty=1,umqty=6,umid=initUnit.Um.id , seq = 1},
                new ProductSetDetail { companyid=initCompany.companyid ,productsetid  =listData[1].id,productid=initProduct.listProduct.Where(x=>x.code=="M-01001").FirstOrDefault().id ,settype="P", saleprice =15 , qty=1,umqty=1,umid=initUnit.Um.id , seq = 2},
            };
            context.AddRange(listPdDetail.ToArray());
            context.SaveChanges();
        }
    }
}
