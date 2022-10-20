using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initUnit
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrUmDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<um> liUnit = new List<um>()
            {
                new um { CorpCode = initCompany.gstrDefaultCorpCode ,code = "00", name = "<ไม่ระบุหน่วยนับ>", name2 = "<Not Define Unit>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new um { CorpCode = initCompany.gstrDefaultCorpCode ,code = "01", name = "ชิ้น", name2 = "Piece", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new um { CorpCode = initCompany.gstrDefaultCorpCode ,code = "02", name = "กล่อง", name2 = "Carton", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new um { CorpCode = initCompany.gstrDefaultCorpCode ,code = "03", name = "ลัง", name2 = "Crate", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new um { CorpCode = initCompany.gstrDefaultCorpCode ,code = "04", name = "ถุง", name2 = "Bag", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new um { CorpCode = initCompany.gstrDefaultCorpCode ,code = "05", name = "ขวด", name2 = "Bottle", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES },
                new um { CorpCode = initCompany.gstrDefaultCorpCode ,code = "06", name = "ครั้ง", name2 = "Time", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            //foreach (um QUm in liUnit)
            //{
            //    context.Add(QUm);
            //}
            //context.SaveChanges();
            context.AddRange(liUnit.ToArray());
            context.SaveChanges();
        }
    }
}
