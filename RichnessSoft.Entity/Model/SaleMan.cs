using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class SaleMan : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string card_no { get; set; }
        public string prefix_th { get; set; }
        public string prefix_en { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string tel { get; set; }
        public string mobile { get; set; }
        public string line { get; set; }
        public string email { get; set; }
        public string position { get; set; }
        public string login { get; set; }
        public string sale_team { get; set; }
        public string sale_area { get; set; }
        public decimal commission { get; set; }
        public string signature { get; set; }
        public enumstatus status { get; set; }
        public enum enumstatus { Working = 1, Resign = 2, Stay_Off_Work = 3 };
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        public Company Company { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<InvTrnH> InvTrnHs { get; set; }
        public virtual ICollection<InvTrnD> InvTrnDs { get; set; }
        public virtual ICollection<OrderTrnH> OrderTrnHs { get; set; }
        public virtual ICollection<OrderTrnD> OrderTrnDs { get; set; }
        public virtual ICollection<BillTrnH> BillTrnHs { get; set; }
        public virtual ICollection<BillTrnD> BillTrnDs { get; set; }
        public virtual ICollection<PreReceiptTrnD> PreReceiptTrnDs { get; set; }
        public virtual ICollection<PreReceiptTrnH> PreReceiptTrnHs { get; set; }
        public virtual ICollection<PreReceiptTrnRef> PreReceiptTrnRefs { get; set; }
        public virtual ICollection<ReceiptTrnD> ReceiptTrnDs { get; set; }
        public virtual ICollection<ReceiptTrnH> ReceiptTrnHs { get; set; }
        public virtual ICollection<ReceiptTrnRef> ReceiptTrnRefs { get; set; }

        #region Expression Field
        [NotMapped]
        //[Description("ชื่อรุ่นสินค้า(ชื่อเต็ม)")]
        public string ExpFullName => string.Format("{0}-{1}", code, ExpName);
        [NotMapped]
        //[Description("ชื่อรุ่นสินค้า")]
        public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1;
        #endregion

    }
}
