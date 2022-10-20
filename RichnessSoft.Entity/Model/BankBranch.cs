using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
        public class BankBranch : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? bankid { get; set; }

        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        public virtual Company Company { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual ICollection<BookBank> BookBanks { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }

        #region Expression Field
        [NotMapped]
        public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1);
        #endregion
    }
}
