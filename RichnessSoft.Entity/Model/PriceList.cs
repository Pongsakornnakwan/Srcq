using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class PriceList : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? productid { get; set; } = default;
        public int? umid { get; set; } = default;
        public int? stdumid { get; set; } = default;

        public string code { get; set; } = string.Empty;
        public string pricelist_type { get; set; } 
        public Int32 qtystd { get; set; } = 1;
        public Int32 qtysale { get; set; } = 1;
        public decimal price { get; set; } = 0M;
        public string discountitem { get; set; } = string.Empty;
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }
        public string datasource { get; set; }
        public string exp_prod_name { get; set; } = "";
        public string exp_stdum_per_umratio { get; set; } = "";

        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
        //public virtual UM UM { get; set; }
        //public virtual UM StdUm { get; set; }

    }
}
