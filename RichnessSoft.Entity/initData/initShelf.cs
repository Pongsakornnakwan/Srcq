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
    public static class initShelf
    {
        public static void InitializeAsync(RicnessDbContext context
           , RichnessLogDbContext contextlog
           , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<Shelf> listData = new List<Shelf>()
            {
                new Shelf { companyid = initCompany.companyid ,code = "00", name1 = "<ไม่ระบุชั้นวาง>", name2 = "<Not Define Shelf>", warehouseid = initWarehouse.listData[0].id, createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
