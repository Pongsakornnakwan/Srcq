using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initBranch
    {
        /// <summary>
        /// สำนักงานใหญ่
        /// </summary>
        public const string gstrBranchCode = "00000";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            branch branch = new branch { CorpCode= initCompany.gstrDefaultCorpCode,code = initBranch.gstrBranchCode, name = "สำนักงานใหญ่", name2 = "Head Office", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now };
            //context.Add(branch);
            //context.SaveChanges();
            context.Add(branch);
            context.SaveChanges();
        }
    }
}
