using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Branch : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string addr1 { get; set; }
        public string addr2 { get; set; }
        public string tel { get; set; }
        public string fax { get; set; }
        public string is_headbrn { get; set; }
        public string active { get; set; }
        public Nullable<DateTime> inactivedate { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<DocLink> DocLinks { get; set; }
        public virtual ICollection<GLTrnD> GLTrnDs { get; set; }
        public virtual ICollection<GLTrnH> GLTrnHs { get; set; }
        public virtual ICollection<Bilpay> Bilpays { get; set; }
        public virtual ICollection<InvTrnH> InvTrnHs { get; set; }
        public virtual ICollection<InvTrnD> InvTrnDs { get; set; }
        public virtual ICollection<OrderTrnH> OrderTrnHs { get; set; }
        public virtual ICollection<OrderTrnD> OrderTrnDs { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Serial> Serials { get; set; }
        public virtual ICollection<SerialTrnH> SerialTrnHs { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
        public virtual ICollection<WhTrnH> WhTrnHs { get; set; }
        public virtual ICollection<WhTrnD> WhTrnDs { get; set; }
        public virtual ICollection<BillTrnH> BillTrnHs { get; set; }
        public virtual ICollection<BillTrnD> BillTrnDs { get; set; }
        public virtual ICollection<BillTrnRef> BillTrnRefs { get; set; }
        public virtual ICollection<PayInTrnD> PayInTrnDs { get; set; }
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
