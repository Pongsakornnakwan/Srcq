using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace RichnessSoft.Data
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
            List<productset> listData = new List<productset>()
            {
                new productset(context) { code = "00",name = "ชุด 1", sname = "ชุด 1", name2 = "Set 1",sname2 = "set 2",pdTypeCode = "F",UmCode = "02", vatTypeCode = "1",setPrint = "C", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES, LinkID = StrUtil.GetUniqueKey(25) },
                new productset(context) { code = "01",name = "ชุด 2", sname = "ชุด 2", name2 = "Set 2",sname2 = "set 2",pdTypeCode = "F",UmCode = "02", vatTypeCode = "1",setPrint = "C", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES, LinkID = StrUtil.GetUniqueKey(25) }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
            List<productsetDetil> listPdDetail = new List<productsetDetil>()
            {
                new productsetDetil { CorpCode = initCompany.gstrDefaultCorpCode ,productsetCode  =listData[0].code,ProductCode="P-01001",setType="P", salePrice =100, qty=1,umQty=6,umCode=initUnit.gstrUmDefaultCode , Seq = "0000", LinkID = StrUtil.GetUniqueKey(25)  },
                new productsetDetil { CorpCode = initCompany.gstrDefaultCorpCode ,productsetCode  =listData[0].code,ProductCode="P-01002",setType="P", salePrice =10, qty=2,umQty=1,umCode=initUnit.gstrUmDefaultCode , Seq = "0001", LinkID = StrUtil.GetUniqueKey(25)  },
                new productsetDetil { CorpCode = initCompany.gstrDefaultCorpCode ,productsetCode  =listData[0].code,ProductCode="P-01003",setType="P", salePrice =120, qty=1,umQty=6,umCode=initUnit.gstrUmDefaultCode, Seq = "0002" , LinkID = StrUtil.GetUniqueKey(25)  },
                new productsetDetil { CorpCode = initCompany.gstrDefaultCorpCode ,productsetCode  =listData[1].code,ProductCode="P-01001",setType="P", salePrice =150, qty=1,umQty=6,umCode=initUnit.gstrUmDefaultCode , Seq = "0000", LinkID = StrUtil.GetUniqueKey(25)  },
                new productsetDetil { CorpCode = initCompany.gstrDefaultCorpCode ,productsetCode  =listData[1].code,ProductCode="P-01002",setType="P", salePrice =130, qty=1,umQty=6,umCode=initUnit.gstrUmDefaultCode , Seq = "0001", LinkID = StrUtil.GetUniqueKey(25)  },
                new productsetDetil { CorpCode = initCompany.gstrDefaultCorpCode ,productsetCode  =listData[1].code,ProductCode="M-01001",setType="P", salePrice =15, qty=1,umQty=1,umCode=initUnit.gstrUmDefaultCode , Seq = "0002", LinkID = StrUtil.GetUniqueKey(25)  },
            };
            context.AddRange(listPdDetail.ToArray());
            context.SaveChanges();
        }
    }
}