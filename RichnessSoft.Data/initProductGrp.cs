using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initProductGrp
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrProdGrpDefaultCode = "00";
        /// <summary>
        /// สินค้า
        /// </summary>
        public const string gstrProdGrpProductCode = "01";
        /// <summary>
        /// งานบริการ
        /// </summary>
        public const string gstrProdGrpServiceCode = "02";
        /// <summary>
        /// สินทรัพย์
        /// </summary>
        public const string gstrProdGrpAssetCode = "03";
        /// <summary>
        /// เบี้ยประกันภัย
        /// </summary>
        public const string gstrProdGrpInsuCode = "04";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<productGroup> listData = new List<productGroup>()
            {
                new productGroup { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductGrp.gstrProdGrpDefaultCode, name = "<ไม่ระบุกลุ่มสินค้า>", name2 = "<Product group Not Define>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new productGroup { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductGrp.gstrProdGrpProductCode, name = "สินค้า", name2 = "Product", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new productGroup { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductGrp.gstrProdGrpServiceCode, name = "งานบริการ", name2 = "Service", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new productGroup { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductGrp.gstrProdGrpAssetCode, name = "สินทรัพย์", name2 = "Asset", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new productGroup { CorpCode = initCompany.gstrDefaultCorpCode ,code = initProductGrp.gstrProdGrpInsuCode, name = "เบี้ยประกันภัย", name2 = "Insurance", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
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
