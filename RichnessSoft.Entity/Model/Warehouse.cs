using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Warehouse : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public string warehousetype { get; set; }

        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        public Company Company { get; set; }
        public Branch Branch { get; set; }
        public virtual ICollection<InvTrnD> InvTrnDs { get; set; }
        public virtual ICollection<OrderTrnD> OrderTrnDs { get; set; }
        public virtual ICollection<Serial> Serials { get; set; }
        public virtual ICollection<SerialTrnH> SerialTrnHs { get; set; }
        public virtual ICollection<Shelf> Shelfs { get; set; }

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
