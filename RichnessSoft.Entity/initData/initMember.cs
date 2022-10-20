using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;

namespace RichnessSoft.Entity.initData
{
    public static class initMember
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrMemberDefaultCode = "00";
        public static List<MemberGroup> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<MemberGroup> listData = new List<MemberGroup>()
            {
                new MemberGroup { companyid = initCompany.companyid ,code = initMember.gstrMemberDefaultCode, name1 = "<ไม่ระบุสมาชิก>", name2 = "<Not Define Member>", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
