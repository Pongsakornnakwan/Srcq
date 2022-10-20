using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class PricelistTrnD : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? pricelisttrnhid { get; set; } = default;
        public int? productid { get; set; } = default;
        public int? stdumid { get; set; } = default;
        public int? umid { get; set; } = default;

        public int seq { get; set; } = default;
        public decimal qtystd { get; set; } = 1;
        public decimal qtysale { get; set; } = 1;
        public decimal price { get; set; } = 0M;
        public string discountitem { get; set; } = string.Empty;
        public string exp_prod_name { get; set; } = "";
        public string exp_stdum_per_umratio { get; set; } = "";

        public virtual Company Company { get; set; }
        public virtual PricelistTrnH PricelistTrnH { get; set; }
        public virtual Product Product { get; set; }

        //public virtual UM StdUm { get; set; }
        //public virtual UM UM { get; set; }
        

    }
}
