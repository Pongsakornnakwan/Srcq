using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Colour : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }


        #region Expression Field
        public string ExpFullName => string.Format("{0}-{1}", code, name1);
        #endregion

        public virtual Company Company { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
