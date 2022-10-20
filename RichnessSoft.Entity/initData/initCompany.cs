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
    public static class initCompany
    {
        /// <summary>
        /// ริชเน็ทซอฟท์
        /// </summary>
        public const string gstrDefaultCorpCode = "01";
        public static int companyid;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            Company company = new Company { code = initCompany.gstrDefaultCorpCode, name1 = "ริชเน็ทซอฟท์", name2 = "Richness soft", createatutc = DateTime.Now, updateatutc = DateTime.Now };
            context.Add(company);
            context.SaveChanges();
            companyid = company.id;
        }
    }
}
