using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class PayInTrnD : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public string stat { get; set; } = "";
        public int? payintrnhid { get; set; } = default;
        public int? paymentid { get; set; } = default;
        public int seq { get; set; } = default;

        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Payment Payment { get; set; }

    }
}
