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
    public static class initBranch
    {
        /// <summary>
        /// สำนักงานใหญ่
        /// </summary>
        public const string gstrBranchCode = "00000";
        public static int branchid;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            Branch branch = new Branch { companyid = initCompany.companyid, code = initBranch.gstrBranchCode, name1 = "สำนักงานใหญ่", name2 = "Head Office", createatutc = DateTime.Now, updateatutc = DateTime.Now };
            context.Add(branch);
            context.SaveChanges();
            branchid = branch.id;
        }
    }
}
