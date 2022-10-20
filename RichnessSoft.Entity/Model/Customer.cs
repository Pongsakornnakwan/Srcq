using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Customer : BaseModel
    {
        public int companyid { get; set; }
        public int? custgroupid { get; set; }
        public int? membergroupid { get; set; }
        public int? salemanid { get; set; }
        public int? saleteamid { get; set; }
        public int? saleareaid { get; set; }
        public int? segmentationid { get; set; }
        public int? bankid { get; set; }
        public int? receivableacchartid { get; set; }
        public int? memberpriceid { get; set; }
        public string mopid { get; set; }


        public string code { get; set; }
        public string custtype { get; set; }
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
        public string bookbankno { get; set; }
        public string bookbankname { get; set; }
        public string bankbranch { get; set; }
        public string billingcond { get; set; }
        public decimal creditdaysbilling { get; set; } = 0;
        public string receivingdatecond { get; set; }
        public string discountendbill { get; set; }
        public string discountitem { get; set; }
        public string currencyid { get; set; }
        public string promotioncode { get; set; }
        public string vattype { get; set; }
        public string vatisout { get; set; }
        public decimal vatrate { get; set; }
        public string remark1 { get; set; }
        public string Remark2 { get; set; }
        public string remark3 { get; set; }
        public string Remark4 { get; set; }
        public string remark5 { get; set; }
        public string remark6 { get; set; }
        public string remark7 { get; set; }
        public string remark8 { get; set; }
        public string remark9 { get; set; }
        public string remark10 { get; set; }

        public virtual Company Company { get; set; }
        public virtual CustGroup CustGroup { get; set; }
        public virtual MemberGroup MemberGroup { get; set; }
        public virtual Acchart Acchart { get; set; }
        public virtual SaleMan SaleMan { get; set; }
        public virtual SaleTeam SaleTeam { get; set; }
        public virtual SaleArea SaleArea { get; set; }
        public Segmentation Segmentation { get; set; }
        public Bank Bank { get; set; }
        public virtual ICollection<InvTrnH> InvTrnHs { get; set; }
        public virtual ICollection<InvTrnD> InvTrnDs { get; set; }
        public virtual ICollection<OrderTrnH> OrderTrnHs { get; set; }
        public virtual ICollection<OrderTrnD> OrderTrnDs { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<PricelistTrnH> PricelistTrnHs { get; set; }
        public virtual ICollection<ProductMember> ProductMembers { get; set; }
        public virtual ICollection<ServiceMember> ServiceMembers { get; set; }
        public virtual ICollection<WhTrnH> WhTrnHs { get; set; }
        public virtual ICollection<BillTrnH> BillTrnHs { get; set; }
        public virtual ICollection<BillTrnD> BillTrnDs { get; set; }
        public virtual ICollection<PreReceiptTrnD> PreReceiptTrnDs { get; set; }
        public virtual ICollection<PreReceiptTrnH> PreReceiptTrnHs { get; set; }
        public virtual ICollection<PreReceiptTrnRef> PreReceiptTrnRefs { get; set; }
        public virtual ICollection<ReceiptTrnD> ReceiptTrnDs { get; set; }
        public virtual ICollection<ReceiptTrnH> ReceiptTrnHs { get; set; }
        public virtual ICollection<ReceiptTrnRef> ReceiptTrnRefs { get; set; }

        //#region Expression Field
        //[Description("Full name1")]
        //[NotMapped]
        //public string fullName
        //{
        //    get
        //    {
        //        return string.Format("{0,-2}|{1}", code, (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? name2 : name1);
        //    }
        //}
        //[NotMapped]
        //[Description("ชื่อลูกค้า(User Lang)")]
        //public string ExpName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? name2 : name1;

        //[NotMapped]
        //[Description("ชื่อเต็มลูกค้า(User Lang)")]
        //public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? name2 : name1);

        //[NotMapped]
        //[Description("ชื่อเต็มลูกค้า(Lang 1)")]
        //public string ExpFullNameLang01 => string.Format("{0}-{1}", code, name1);

        //[NotMapped]
        //[Description("ชื่อเต็มลูกค้า(Lang 2)")]
        //public string ExpFullNameLang02 => string.Format("{0}-{1}", code, name2);

        //[NotMapped]
        //[Description("Address(Tax)")]
        //public Address ExpAddressTax => GetTaxAddress();
        //private Address GetTaxAddress()
        //{
        //    if (Context is null) { return null; }
        //    return Context.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Report_Tax
        //            && c.refType == Address.enumreftype.customer
        //            && c.refID == LinkID).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Address(Contact)")]
        //public Address ExpAddressContact => GetContactAddress();
        //private Address GetContactAddress()
        //{
        //    if (Context is null) { return null; }
        //    return Context.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Contact
        //            && c.refType == Address.enumreftype.customer
        //            && c.refID == LinkID).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Address(Delivery)")]
        //public Address ExpAddressDelivery => GetDeliveryAddress();
        //private Address GetDeliveryAddress()
        //{
        //    if (Context is null) { return null; }
        //    return Context.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Billing
        //            && c.refType == Address.enumreftype.customer
        //            && c.refID == LinkID).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Address(Office)")]
        //public Address ExpAddressOffice => GetOfficeAddress();
        //private Address GetOfficeAddress()
        //{
        //    if (Context is null) { return null; }
        //    return Context.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Office
        //            && c.refType == Address.enumreftype.customer
        //            && c.refID == LinkID).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Currency")]
        //public currency ExpCurrency => GetCurrency();
        //private currency GetCurrency()
        //{
        //    if (Context is null) { return null; }
        //    return Context?.Set<currency>()?.AsNoTrackingWithIdentityResolution().Where(c => c.code == currencyCode)?.FirstOrDefault() ?? null;
        //}
        //#endregion




    }
}
