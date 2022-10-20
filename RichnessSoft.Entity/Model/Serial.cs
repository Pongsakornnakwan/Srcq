using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RichnessSoft.Common.SysDef;

namespace RichnessSoft.Entity.Model
{
    public class Serial : BaseModel
    {
        
        public int companyid { get; set; }
        public int branchid { get; set; } = default;
        public int productid { get; set; } = default;
        public int warehouseid { get; set; } = default;

        public string code { get; set; } = string.Empty;
        public string lot { get; set; } = string.Empty;
        public P_Step pstep { get; set; } = P_Step.ORDER;
        public S_Step sstep { get; set; } = S_Step.ORDER;
        public decimal qty { get; set; } = 0;
        public decimal umqty { get; set; } = 1;
        public string seq { get; set; } = "0000";

        public Company Company { get; set; }
        public Branch Branch { get; set; }
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
