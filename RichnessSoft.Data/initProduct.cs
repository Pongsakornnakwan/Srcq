using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initProduct
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<product> listData = new List<product>()
            {
                new product(context) { CorpCode = initCompany.gstrDefaultCorpCode ,code = "P-01001", name = "สินค้า A", sName = "สินค้า A", name2 = "Product A", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, UmCode = "01", pdTypeCode = initProductType.gstrFinishedProductCode, pdGroupCode = initProductGrp.gstrProdGrpProductCode, active = ConstUtil.ACTIVE.YES , stockCounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new product(context) { CorpCode = initCompany.gstrDefaultCorpCode ,code = "P-01002", name = "สินค้า B", sName = "สินค้า B", name2 = "Product B", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, UmCode = "01", pdTypeCode = initProductType.gstrFinishedProductCode, pdGroupCode = initProductGrp.gstrProdGrpProductCode, active = ConstUtil.ACTIVE.YES , stockCounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new product(context) { CorpCode = initCompany.gstrDefaultCorpCode ,code = "P-01003", name = "สินค้า C", sName = "สินค้า C", name2 = "Product C", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, UmCode = "01", pdTypeCode = initProductType.gstrFinishedProductCode, pdGroupCode = initProductGrp.gstrProdGrpProductCode, active = ConstUtil.ACTIVE.YES , stockCounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new product(context) { CorpCode = initCompany.gstrDefaultCorpCode ,code = "P-01004", name = "สินค้า D", sName = "สินค้า D", name2 = "Product D", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, UmCode = "01", pdTypeCode = initProductType.gstrFinishedProductCode, pdGroupCode = initProductGrp.gstrProdGrpProductCode, active = ConstUtil.ACTIVE.YES , stockCounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new product(context) { CorpCode = initCompany.gstrDefaultCorpCode ,code = "P-01005", name = "สินค้า E", sName = "สินค้า E", name2 = "Product E", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, UmCode = "01", pdTypeCode = initProductType.gstrFinishedProductCode, pdGroupCode = initProductGrp.gstrProdGrpProductCode, active = ConstUtil.ACTIVE.YES , stockCounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new product(context) { CorpCode = initCompany.gstrDefaultCorpCode ,code = "M-01001", name = "วัตถุดิบ <ตัวอย่าง>", sName = "วัตถุดิบ <ตัวอย่าง>", name2 = "Material <example> ", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, UmCode = "01", pdTypeCode = initProductType.gstrMaterialCode, pdGroupCode = initProductGrp.gstrProdGrpProductCode, active = ConstUtil.ACTIVE.YES, stockCounting = ConstUtil.STOCK_COUNTING.COMPANY },
                new product(context) { CorpCode = initCompany.gstrDefaultCorpCode ,code = "A-01001", name = "สินทรัพย์ <ตัวอย่าง>", sName = "สินทรัพย์ <ตัวอย่าง>", name2 = "Asset <example> ", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, UmCode = "01", pdTypeCode = initProductType.gstrAssetCode, pdGroupCode =initProductGrp.gstrProdGrpAssetCode, active = ConstUtil.ACTIVE.YES , stockCounting = ConstUtil.STOCK_COUNTING.NO_COUNT_STOCK},
                new product(context) { CorpCode = initCompany.gstrDefaultCorpCode ,code = "C-01001", name = "วัสดุสิ้นเปลือง <ตัวอย่าง>", sName = "วัสดุสิ้นเปลือง <ตัวอย่าง>", name2 = "Consumables <example>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, UmCode = "01", pdTypeCode = initProductType.gstrConsumablesCode, pdGroupCode = initProductGrp.gstrProdGrpProductCode, active = ConstUtil.ACTIVE.YES, stockCounting = ConstUtil.STOCK_COUNTING.COMPANY }
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
