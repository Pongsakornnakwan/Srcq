using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RichnessSoft.Common;

namespace RichnessSoft.Entity.Model
{
    public class CustomerCredit : BaseModel
    {
        public int companyid { get; set; } = default;
        public int customerid { get; set; }

        public string CreditType { get; set; } = ConstUtil.CREDIT_TYPE.INCREASE;
        public decimal amount { get; set; }
        public DateTime? enddate { get; set; }
        public string reftype { get; set; } = ConstUtil.REFTYPE.CUSTOMER;
        public int seq { get; set; }

        public virtual Company Company { get; set; }
    }
}
