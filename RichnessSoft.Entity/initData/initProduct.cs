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
    public static class initProduct
    {
        public static List<Product> listProduct;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listProduct = new List<Product>()
            {
                new Product { companyid=initCompany.companyid ,code = "P-01001", name1 = "สินค้า A", sname1 = "สินค้า A", name2 = "Product A", createatutc = DateTime.Now, updateatutc = DateTime.Now, umid = initUnit.Um.id, prodtype = initProductType.gstrFinishedProductCode, productgroupid = initProductGrp.productGroup.id, active = ConstUtil.ACTIVE.YES , stockcounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new Product { companyid=initCompany.companyid ,code = "P-01002", name1 = "สินค้า B", sname1 = "สินค้า B", name2 = "Product B", createatutc = DateTime.Now, updateatutc = DateTime.Now, umid = initUnit.Um.id, prodtype = initProductType.gstrFinishedProductCode, productgroupid = initProductGrp.productGroup.id, active = ConstUtil.ACTIVE.YES , stockcounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new Product { companyid=initCompany.companyid ,code = "P-01003", name1 = "สินค้า C", sname1 = "สินค้า C", name2 = "Product C", createatutc = DateTime.Now, updateatutc = DateTime.Now, umid = initUnit.Um.id, prodtype = initProductType.gstrFinishedProductCode, productgroupid = initProductGrp.productGroup.id, active = ConstUtil.ACTIVE.YES , stockcounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new Product { companyid=initCompany.companyid ,code = "P-01004", name1 = "สินค้า D", sname1 = "สินค้า D", name2 = "Product D", createatutc = DateTime.Now, updateatutc = DateTime.Now, umid = initUnit.Um.id, prodtype = initProductType.gstrFinishedProductCode, productgroupid = initProductGrp.productGroup.id, active = ConstUtil.ACTIVE.YES , stockcounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new Product { companyid=initCompany.companyid ,code = "P-01005", name1 = "สินค้า E", sname1 = "สินค้า E", name2 = "Product E", createatutc = DateTime.Now, updateatutc = DateTime.Now, umid = initUnit.Um.id, prodtype = initProductType.gstrFinishedProductCode, productgroupid = initProductGrp.productGroup.id, active = ConstUtil.ACTIVE.YES , stockcounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new Product { companyid=initCompany.companyid ,code = "M-01001", name1 = "วัตถุดิบ <ตัวอย่าง>", sname1 = "วัตถุดิบ <ตัวอย่าง>", name2 = "Material <example> ", createatutc = DateTime.Now, updateatutc = DateTime.Now, umid = initUnit.Um.id, prodtype = initProductType.gstrMaterialCode, productgroupid = initProductGrp.productGroup.id, active = ConstUtil.ACTIVE.YES, stockcounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new Product { companyid=initCompany.companyid ,code = "A-01001", name1 = "สินทรัพย์ <ตัวอย่าง>", sname1 = "สินทรัพย์ <ตัวอย่าง>", name2 = "Asset <example> ", createatutc = DateTime.Now, updateatutc = DateTime.Now, umid = initUnit.Um.id, prodtype = initProductType.gstrAssetCode, productgroupid =initProductGrp.productGroup.id, active = ConstUtil.ACTIVE.YES , stockcounting = ConstUtil.STOCK_COUNTING.NO_COUNT_STOCK},
                new Product { companyid=initCompany.companyid ,code = "C-01001", name1 = "วัสดุสิ้นเปลือง <ตัวอย่าง>", sname1 = "วัสดุสิ้นเปลือง <ตัวอย่าง>", name2 = "Consumables <example>", createatutc = DateTime.Now, updateatutc = DateTime.Now, umid = initUnit.Um.id, prodtype = initProductType.gstrConsumablesCode, productgroupid = initProductGrp.productGroup.id, active = ConstUtil.ACTIVE.YES, stockcounting = ConstUtil.STOCK_COUNTING.COMPANY }
            };
            context.AddRange(listProduct.ToArray());
            context.SaveChanges();
        }
    }
}
