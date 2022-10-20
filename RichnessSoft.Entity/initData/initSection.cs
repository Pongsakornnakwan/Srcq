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
    public class initSection
    {
        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrSectDefaultCode = "00";
        public static Section Section;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Section> listData = new List<Section>()
            {
                new Section { companyid = initCompany.companyid ,code = initSection.gstrSectDefaultCode, name1 = "<ไม่ระบุฝ่าย>", name2 = "<Not Define Section>", createatutc = DateTime.Now, updateatutc = DateTime.Now , active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
            Section = listData[0];
        }
    }
}
