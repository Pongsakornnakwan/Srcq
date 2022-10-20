using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class MemberGroup : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        public virtual Company Company { get; set; }

        //#region Expression Field
        //[NotMapped]
        //[Description("ชื่อสมาชิก(ชื่อเต็ม)")]
        //public string ExpFullName => string.Format("{0}-{1}", code, ExpName);

        //[NotMapped]
        //[Description("ชื่อสมาชิก")]
        //public string ExpName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? name2 : name1;
        //#endregion

        public virtual ICollection<Customer> Customers { get; set; }





    }
}
