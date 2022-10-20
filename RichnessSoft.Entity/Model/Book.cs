using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Book : BaseModel
    {
        public int? companyid { get; set; } = default;
        public int? branchid { get; set; }
        public int? accbookid { get; set; }
        public int? accroletemplatehid { get; set; }

        public string doctype { get; set; }
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string prefixrunno { get; set; }
        public string yearrunno { get; set; }
        public string docformatrunno { get; set; }
        public int doclenrunno { get; set; }
        public int docstartrunno { get; set; }
        public Nullable<DateTime> lockdate { get; set; }
        public string accremarkdetail { get; set; }
        public int warehouseid { get; set; }
        public int sectionid { get; set; }
        public string vattype { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        public  virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual AccBook AccBook { get; set; }
        public virtual AccRoleTemplateH AccRoleTemplateH { get; set; }
        public virtual ICollection<InvTrnH> InvTrnHs { get; set; }
        public virtual ICollection<InvTrnD> InvTrnDs { get; set; }
        public virtual ICollection<DocLink> DocLinks { get; set; }
        public virtual ICollection<OrderTrnH> OrderTrnHs { get; set; }
        public virtual ICollection<OrderTrnD> OrderTrnDs { get; set; }
        public virtual ICollection<SerialTrnH> SerialTrnHs { get; set; }
        public virtual ICollection<WhTrnH> WhTrnHs { get; set; }
        public virtual ICollection<WhTrnD> WhTrnDs { get; set; }
        public virtual ICollection<BillTrnH> BillTrnHs { get; set; }
        public virtual ICollection<BillTrnD> BillTrnDs { get; set; }
        public virtual ICollection<BillTrnRef> BillTrnRefs { get; set; }
        public virtual ICollection<PreReceiptTrnD> PreReceiptTrnDs { get; set; }
        public virtual ICollection<PreReceiptTrnH> PreReceiptTrnHs { get; set; }
        public virtual ICollection<PreReceiptTrnRef> PreReceiptTrnRefs { get; set; }
        public virtual ICollection<ReceiptTrnD> ReceiptTrnDs { get; set; }
        public virtual ICollection<ReceiptTrnH> ReceiptTrnHs { get; set; }
        public virtual ICollection<ReceiptTrnRef> ReceiptTrnRefs { get; set; }
        #region Expression Field

        [NotMapped]
        public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1);

        #endregion






    }
}
