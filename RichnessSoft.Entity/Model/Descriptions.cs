using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Descriptions : BaseModel
    {

        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string desc { get; set; }
        public string desc2 { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }
        public string dtype { get; set; }

        #region Expression Field
        [NotMapped]
        public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? this.desc : this.desc2);

        [NotMapped]
        public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? this.desc2 : this.desc;
        #endregion


        public virtual Company Company { get; set; }



    }
}
