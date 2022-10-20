using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class ProductSetDetail : BaseModel
    {
        public int companyid { get; set; } = default;
        public int productsetid { get; set; }
        public int productid { get; set; }
        public int umid { get; set; }

        public string settype { get; set; }
        public Int32 qty { get; set; }
        public Int32 umqty { get; set; }
        public decimal saleprice { get; set; }
        public int  seq { get; set; } = default;

        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductSet ProductSet { get; set; }
        //public virtual UM UM { get; set; }
    }
}
