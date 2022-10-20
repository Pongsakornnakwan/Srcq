using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initCompany
    {
        /// <summary>
        /// ริชเน็ทซอฟท์
        /// </summary>
        public const string gstrDefaultCorpCode = "01";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            company company = new company { code = initCompany.gstrDefaultCorpCode, name = "ริชเน็ทซอฟท์", Name2 = "Richness soft", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now };
            //context.Add(company);
            //context.SaveChanges();
            context.Add(company);
            context.SaveChanges();
            
        }
    }
}
