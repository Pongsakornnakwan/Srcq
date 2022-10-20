using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class UM : BaseModel
    {
        public UM()
        {
            //InvTrnDs = new HashSet<InvTrnD>();
        }
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        public Company Company { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
        //public virtual ICollection<OrderTrnD> OrderTrnDs { get; set; }
        //public virtual ICollection<InvTrnD> InvTrnDs { get; set; }
        //public virtual ICollection<InvTrnD> InvTrnDUmStds { get; set; }
        //public virtual ICollection<PriceList> PriceLists { get; set; }
        //public virtual ICollection<PricelistTrnD> PricelistTrnDUms { get; set; }
        //public virtual ICollection<PricelistTrnD> PricelistTrnDStdUms { get; set; }
        //public virtual ICollection<ProductSet> ProductSets { get; set; }
        //public virtual ICollection<ProductSetDetail> ProductSetDetails { get; set; }
        //public virtual ICollection<ProductUnit> ProductUnits { get; set; }
        //public virtual ICollection<ServiceMember> ServiceMembers { get; set; }
        //public virtual ICollection<ServiceUnit> ServiceUnits { get; set; }

        #region Expression Field
        [NotMapped]
        //[Description("Shipping Full name1")]
        public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1);
        [NotMapped]
        //[Description("Shipping name1")]
        public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1;
        #endregion









    }
}
