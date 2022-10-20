using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class CustGroup : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? acchartid { get; set; }

        public string code { get; set; }
        public string Name { get; set; }
        public string name2 { get; set; }
        public int levelprice { get; set; }
        public string Active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        #region Expression Field
        [NotMapped]
        public string ExpFullName => string.Format("{0}-{1}", code, ExpName);

        [NotMapped]
        public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : Name;
        #endregion

        public virtual Company Company { get; set; }
        public virtual Acchart Acchart { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
