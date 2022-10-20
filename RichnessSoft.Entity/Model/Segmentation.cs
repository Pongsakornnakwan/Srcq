using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RichnessSoft.Common;

namespace RichnessSoft.Entity.Model
{
    public class Segmentation : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string active { get; set; } = ConstUtil.ACTIVE.YES;
        public Nullable<DateTime> inactivedate { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        //#region Expression Field
        //[NotMapped]
        //[Description("Segmentataion Full name1")]
        //public string ExpFullName => string.Format("{0}-{1}", code, ExpName);

        //[NotMapped]
        //[Description("Segmentataion name1")]
        //public string ExpName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? name2 : name1;
        //#endregion

    }
}
