using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class ProductBarcode : BaseModel
    {
        public int companyid { get; set; } = default;
        public int productid { get; set; } = default;
        public int Productumid { get; set; } = default;
        public int umid { get; set; } = default;

        public string barcode { get; set; }
        public decimal stdprice { get; set; }
        public decimal memberprice1 { get; set; }
        public decimal memberprice2 { get; set; }
        public decimal memberprice3 { get; set; }
        public decimal memberprice4 { get; set; }
        public decimal memberprice5 { get; set; }
        public decimal memberprice6 { get; set; }
        public decimal memberprice7 { get; set; }
        public decimal memberprice8 { get; set; }
        public int seq { get; set; } = default;

        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
        //public virtual UM UM { get; set; }
        //public virtual UM ProductUM { get; set; }

        //#region Expression Field

        //[NotMapped]
        //public string flag { get; set; }

        //[NotMapped]
        //public decimal ExpQty { get; set; } = 0M;

        //[NotMapped]
        //public string ExpStdUm { get; set; } = string.Empty;

        //[NotMapped]
        //public decimal ExpStdPrice { get; set; } = 0M;
        //#endregion









    }
}
