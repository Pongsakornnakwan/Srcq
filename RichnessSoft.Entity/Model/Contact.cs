using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Contact : BaseModel
    {
        public int companyid { get; set; } = default;
        public enumcontacttype contacttype { get; set; }
        public enumreftype reftype { get; set; }
        public string refid { get; set; }
        public string contactname { get; set; }
        public string positionname { get; set; }
        public string remark { get; set; }
        public string mobile { get; set; }
        public string tel { get; set; }
        public string companyname { get; set; }
        public int seq { get; set; }
        public enum enumcontacttype { Contact = 1 };
        public enum enumreftype { Vendor = 1, Customer = 2 };

        #region Expression Field
        /// <summary>
        /// ชื่อผู้ติดต่อ+เบอร์โทร
        /// </summary>
        [NotMapped]
        public string ExpFullNameMobile => string.Format("{0} , {1}", this.contactname ?? "", this.mobile ?? "");
        #endregion

        public virtual Company Company { get; set; }
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
    }
}
