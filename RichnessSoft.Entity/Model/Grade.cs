using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using RichnessSoft.Common;

namespace RichnessSoft.Entity.Model
{
    public class Grade : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name { get; set; }
        public string name2 { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        public virtual Company Company { get; set; }

        #region Expression Field
        [NotMapped]
        [Description("ชื่อเกรดสินค้า(ชื่อเต็ม)")]
        public string ExpFullName => string.Format("{0}-{1}", code, ExpName);
        [NotMapped]
        [Description("ชื่อเกรดสินค้า")]
        public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name;
        #endregion


        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Service> Services { get; set; }


    }
}
