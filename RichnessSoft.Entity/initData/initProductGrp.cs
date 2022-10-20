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
        public static ProductGroup productGroup;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<ProductGroup> listData = new List<ProductGroup>()
            {
                new ProductGroup { companyid = initCompany.companyid ,code = initProductGrp.gstrProdGrpDefaultCode, name1 = "<ไม่ระบุกลุ่มสินค้า>", name2 = "<Product group Not Define>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new ProductGroup { companyid = initCompany.companyid ,code = initProductGrp.gstrProdGrpProductCode, name1 = "สินค้า", name2 = "Product", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new ProductGroup { companyid = initCompany.companyid ,code = initProductGrp.gstrProdGrpServiceCode, name1 = "งานบริการ", name2 = "service", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new ProductGroup { companyid = initCompany.companyid ,code = initProductGrp.gstrProdGrpAssetCode, name1 = "สินทรัพย์", name2 = "Asset", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new ProductGroup { companyid = initCompany.companyid ,code = initProductGrp.gstrProdGrpInsuCode, name1 = "เบี้ยประกันภัย", name2 = "Insurance", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
            productGroup = listData[0];
        }
    }
}
