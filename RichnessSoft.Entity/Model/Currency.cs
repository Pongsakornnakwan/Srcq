using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Currency : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public decimal ratio { get; set; }
        public string symbol { get; set; }
        public string countrycode { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        #region Expression Field
        [NotMapped]
        public string ExpCurrencyFullName => string.Format("{0}-{1}", code ?? "", ((gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 ?? "" : name1 ?? ""));
        #endregion

        public virtual Company Company { get; set; }
        public virtual ICollection<OrderTrnH> OrderTrnHs { get; set; }
        public virtual ICollection<InvTrnH> InvTrnHs { get; set; }
        public virtual ICollection<BillTrnH> BillTrnHs { get; set; }
        public virtual ICollection<BillTrnD> BillTrnDs { get; set; }
        public virtual ICollection<OrderTrnD> OrderTrnDs { get; set; }
        public virtual ICollection<PreReceiptTrnD> PreReceiptTrnDs { get; set; }
        public virtual ICollection<PreReceiptTrnH> PreReceiptTrnHs { get; set; }
        public virtual ICollection<PreReceiptTrnRef> PreReceiptTrnRefs { get; set; }
        public virtual ICollection<ReceiptTrnD> ReceiptTrnDs { get; set; }
        public virtual ICollection<ReceiptTrnH> ReceiptTrnHs { get; set; }
        public virtual ICollection<ReceiptTrnRef> ReceiptTrnRefs { get; set; }
    }
}
