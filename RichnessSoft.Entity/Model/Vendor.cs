using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Vendor : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? vendorgroupid { get; set; }
        public int? accreceivableid { get; set; }

        public string code { get; set; }
        public string vendortype { get; set; }
        public string status { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }
        public string prename { get; set; }
        public string firstname { get; set; }
        public string midname { get; set; }
        public string lastname { get; set; }
        public string firstname2 { get; set; }
        public string midname2 { get; set; }
        public string lastname2 { get; set; }
        public string name1 { get; set; }
        public string sname1 { get; set; }
        public string name2 { get; set; }
        public string sname2 { get; set; }
        public string taxid { get; set; }
        public string cid { get; set; }
        public string headoffice { get; set; }
        public string branchcode { get; set; }
        public string branchname { get; set; }
        public string teletax { get; set; }
        public string tel { get; set; }
        public string fax { get; set; }
        public string website { get; set; }
        public string singlelineaddress { get; set; }
        public string singlelineaddress2 { get; set; }
        public string shippingby { get; set; }
        public string bussinesstype { get; set; }
        public decimal creditdays { get; set; } = 0;
        public decimal creditamt { get; set; } = 0;
        public string methodofpaymentcode { get; set; }
        public string bookbankno { get; set; }
        public string bookbankname { get; set; }
        public string bankcode { get; set; }
        public string bankbranch { get; set; }
        public string billingcond { get; set; }
        public decimal creditdays_billing { get; set; } = 0;
        public string receivingdatecond { get; set; }
        public string discountendbill { get; set; }
        public string discountitem { get; set; }
        public string currencycode { get; set; }
        public string promotioncode { get; set; }
        
        public string vattype { get; set; }
        public string vatisout { get; set; }
        public decimal vatrate { get; set; }
        public string remark1 { get; set; }
        public string remark2 { get; set; }
        public string remark3 { get; set; }
        public string remark4 { get; set; }
        public string remark5 { get; set; }
        public string remark6 { get; set; }
        public string remark7 { get; set; }
        public string remark8 { get; set; }
        public string remark9 { get; set; }
        public string remark10 { get; set; }
        public string fullname
        {
            get
            {
                return string.Format("{0,-2}|{1}", code, name1);
            }
        }

        public Company Company { get; set; }
        public VendorGroup VendorGroup { get; set; }
        public Acchart Acchart { get; set; }
        public virtual ICollection<InvTrnH> InvTrnHs { get; set; }
        public virtual ICollection<InvTrnD> InvTrnDs { get; set; }
        public virtual ICollection<OrderTrnH> OrderTrnHs { get; set; }
        public virtual ICollection<OrderTrnD> OrderTrnDs { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<WhTrnH> WhTrnHs { get; set; }
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
        //[Description("Shipping Full name1")]
        public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1);
        [NotMapped]
        //[Description("Shipping name1")]
        public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1;
        #endregion
    }
}
