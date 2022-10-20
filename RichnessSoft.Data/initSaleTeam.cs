using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initSaleTeam
    {
        /// <summary>
        /// <ไม่ระบุทีมขาย>
        /// </summary>
        public const string gstrSaleTeamDefaultCode = "000";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<saleTeam> listData = new List<saleTeam>()
            {
                new saleTeam { CorpCode = initCompany.gstrDefaultCorpCode ,code = gstrSaleTeamDefaultCode, name = "<ไม่ระบุทีมขาย>", name2 = "<Not Define Sale Team>", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();    
        }
    }
}
