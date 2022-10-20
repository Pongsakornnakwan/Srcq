using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class PricelistTrnH : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public int? customerid { get; set; }
        public string pricelisttype { get; set; }
        public string active { get; set; }
        public DateTime? inactive { get; set; }

        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<PricelistTrnD> PricelistTrnDs { get; set; }
    }
}
