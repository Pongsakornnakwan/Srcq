using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class BillTrnH : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int bookid { get; set; } = default;
        public int? sectionid { get; set; } = default;
        public int? departmentid { get; set; } = default;
        public int? projectid { get; set; } = default;
        public int? plansld { get; set; } = default;
        public int? gltrnhid { get; set; } = default;
        public int? gltrnhcaid { get; set; } = default;
        public int? customerid { get; set; } = default;
        public int? vendorid { get; set; } = default;
        public int? contactid { get; set; } = default;
        public int? salemanid { get; set; } = default;
        public int? currencyid { get; set; } = default;

        public string doctype { get; set; } 
        public string doccode { get; set; } = string.Empty;
        public string docrefnumber { get; set; } = string.Empty;
        public string docstatus { get; set; } 
        public string custsuppbranchcode { get; set; } = string.Empty;
        public string custsupptaxid { get; set; } = string.Empty;
        public int addressofficeid { get; set; }
        public string addressofficedetail { get; set; }
        public string contactname { get; set; } = string.Empty;
        public string contactname2 { get; set; } = string.Empty;
        public string contacttel { get; set; } = string.Empty;
        public DateTime? docdate { get; set; } = DateTime.UtcNow.Date;
        public DateTime? paydate { get; set; } = null;
        public decimal creditterm { get; set; } = 0;
        public string islocked { get; set; } 
        public decimal currencyrate { get; set; } = 1M;
        public string vattype { get; set; } = string.Empty;
        public decimal vatrate { get; set; } = 0M;
        public string vatisout { get; set; } 
        public string remark01 { get; set; } = string.Empty;
        public string remark02 { get; set; } = string.Empty;
        public string remark03 { get; set; } = string.Empty;
        public string remark04 { get; set; } = string.Empty;
        public string remark05 { get; set; } = string.Empty;
        public string remark06 { get; set; } = string.Empty;
        public string remark07 { get; set; } = string.Empty;
        public string remark08 { get; set; } = string.Empty;
        public string remark09 { get; set; } = string.Empty;
        public string remark10 { get; set; } = string.Empty;
        public string attach_file_01 { get; set; } = string.Empty;
        public string attach_file_02 { get; set; } = string.Empty;
        public string attach_file_03 { get; set; } = string.Empty;
        public string attach_file_04 { get; set; } = string.Empty;
        public string attach_file_05 { get; set; } = string.Empty;
        public decimal foottotalqty { get; set; } = 0M;
        public decimal footcurramt { get; set; } = 0;
        public decimal footstdamt { get; set; } = 0;
        public decimal footcurrwithholdingtaxamt { get; set; } = 0;
        public decimal footstdwithholdingtaxamt { get; set; } = 0;
        public string footdiscstr { get; set; } = string.Empty;
        public decimal footcurrdiscamt { get; set; } = 0M;
        public decimal footstddiscamt { get; set; } = 0M;
        public decimal footcurrnetamt { get; set; } = 0M;
        public decimal footstdnetamt { get; set; } = 0M;
        public decimal footcurrpayamt { get; set; } = 0M;
        public decimal footstdpayamt { get; set; } = 0M;
        public string cancellationreason { get; set; } = string.Empty;


        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Book Book { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
        public virtual GLTrnH GLTrnH { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual SaleMan SaleMan { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ICollection<BillTrnD> BillTrnDs { get; set; }



        //#region Expression Field
        //[NotMapped]
        //[Description("ชื่อบริษัท")]
        //public string ExpCorpName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpCorp?.name2 ?? "" : ExpCorp?.name1 ?? "";
        //private company ExpCorp => _DB?.Set<company>().AsNoTrackingWithIdentityResolution()?.Where(c => c.code == CorpCode).FirstOrDefault() ?? null;

        //[NotMapped]
        //[Description("ชื่อสาขา")]
        //public string ExpBranchName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpBranch?.name2 ?? "" : ExpBranch?.name1 ?? "";
        //private branch ExpBranch => _DB?.Set<branch>().AsNoTrackingWithIdentityResolution()?.Where(c => c.code == branchcode).FirstOrDefault() ?? null;

        //[NotMapped]
        //[Description("login")]
        //public string ExpLoginName => GetLoginName();
        //private string GetLoginName()
        //{
        //    string strRetValue = "";
        //    if (_DB is null) { return strRetValue; }
        //    user oResult = _DB.Set<user>().AsNoTrackingWithIdentityResolution().Where(c => c.userName == createby).FirstOrDefault() ?? null;
        //    if (oResult is not null)
        //    {
        //        strRetValue = string.Format("{0} {1}", oResult.firstName, oResult.lastName);
        //    }
        //    return strRetValue ?? "";
        //}
        //[NotMapped]
        //[Description("สถานะ")]
        //public string ExpStatusName => GetStatusName();
        //private string GetStatusName()
        //{
        //    string strRetValue;
        //    switch (docstatus)
        //    {
        //        case ConstUtil.BILL_STATUS.NEW:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "NEW" : "สร้างใหม่";
        //            break;
        //        case ConstUtil.BILL_STATUS.PART:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "PART" : "บางส่วน"; ;
        //            break;
        //        case ConstUtil.BILL_STATUS.CANCELED:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "CANCELED" : "ยกเลิก"; ;
        //            break;
        //        case ConstUtil.BILL_STATUS.CLOSED:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "CLOSED" : "CLOSED"; ;
        //            break;
        //        case ConstUtil.BILL_STATUS.PAID:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "PAID" : "จ่ายเต็มแล้ว"; ;
        //            break;
        //        default:
        //            strRetValue = "";
        //            break;
        //    }
        //    return strRetValue ?? "";
        //}

        //[NotMapped]
        //[Description("Doc.type")]
        //public string ExpDocTypeName => GetDocTypeName();
        //private string GetDocTypeName()
        //{
        //    string strRetValue = "";
        //    if (_DB is null) { return strRetValue; }
        //    docType oResult = _DB.Set<docType>().AsNoTrackingWithIdentityResolution().Where(c => c.code == doctype).FirstOrDefault() ?? null;
        //    if (oResult is not null)
        //    {
        //        strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? oResult.name2 : oResult.name1;
        //    }
        //    return strRetValue ?? "";
        //}

        //[NotMapped]
        //[Description("Book name1")]
        //public string ExpBookName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpBook?.name2 ?? "" : ExpBook?.name1 ?? "";

        //[NotMapped]
        //[Description("Book")]
        //public book ExpBook => GetBook();
        //private book GetBook()
        //{
        //    return _DB?.Set<book>()?.AsNoTrackingWithIdentityResolution().Where(c => c.code == BookCode)?.FirstOrDefault() ?? null;
        //}

        //[NotMapped]
        //[Description("customer")]
        //public customer ExpCustomer => GetCustomer();
        //private customer GetCustomer()
        //{
        //    if (_DB is null) { return null; }
        //    else if (IsCust == CONFIRM.NO) { return null; }
        //    return _DB.Set<customer>().AsNoTrackingWithIdentityResolution().Where(c => c.code == CustSuppCode).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("vendor")]
        //public vendor ExpVendor => GetVendor();
        //private vendor GetVendor()
        //{
        //    if (_DB is null) { return null; }
        //    else if (IsCust == CONFIRM.YES) { return null; }
        //    return _DB.Set<vendor>().AsNoTrackingWithIdentityResolution().Where(c => c.code == CustSuppCode).FirstOrDefault() ?? null;
        //}

        //[NotMapped]
        //[Description("customer/vendor name1")]
        //public string ExpCustomerName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? IsCust == CONFIRM.YES ? ExpCustomer?.name2 ?? "" : ExpVendor?.name2 ?? "" : IsCust == CONFIRM.YES ? ExpCustomer?.name1 ?? "" : ExpVendor?.name1 ?? "";

        //[NotMapped]
        //[Description("customer/vendor Branch No.")]
        //public string ExpCustomerBranchNo => IsCust == CONFIRM.YES ? ExpCustomer?.branchCode ?? "" : ExpVendor?.branchCode ?? "";

        //[NotMapped]
        //[Description("customer/vendor Tax ID")]
        //public string ExpCustomerTaxID => IsCust == CONFIRM.YES ? ExpCustomer?.taxId ?? "" : ExpVendor?.taxId ?? "";

        //[NotMapped]
        //[Description("customer/vendor Address Office")]
        //public Address ExpOfficeAddess => GetOfficeAddess();
        //private Address GetOfficeAddess()
        //{
        //    if (_DB is null) { return null; }
        //    if (IsCust == CONFIRM.YES && ExpCustomer is not null)
        //    {
        //        return _DB.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Office && c.refType == Address.enumreftype.customer && c.refID == ExpCustomer.LinkID).FirstOrDefault() ?? null;
        //    }
        //    else if (IsCust == CONFIRM.NO && ExpVendor is not null)
        //    {
        //        return _DB.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Office && c.refType == Address.enumreftype.Supplier && c.refID == ExpVendor.LinkID).FirstOrDefault() ?? null;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //[NotMapped]
        //[Description("customer/vendor Address")]
        //public string ExpCustomerAddress => ExpOfficeAddess?.Exp_full_address ?? "";

        //[NotMapped]
        //[Description("customer/vendor Address Delivery")]
        //public Address ExpCustomerDeliveryAddess => GetCustomerDeliveryAddess();
        //private Address GetCustomerDeliveryAddess()
        //{
        //    if (_DB is null) { return null; }
        //    else if (IsCust == CONFIRM.YES && ExpCustomer is not null)
        //    {
        //        return _DB.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Billing
        //            && c.refType == Address.enumreftype.customer
        //            && c.refID == ExpCustomer.LinkID).FirstOrDefault<Address>() ?? null;
        //    }
        //    else if (IsCust == CONFIRM.NO && ExpVendor is not null)
        //    {
        //        return _DB.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Billing
        //            && c.refType == Address.enumreftype.Supplier
        //            && c.refID == ExpCustomer.LinkID).FirstOrDefault<Address>() ?? null;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //[NotMapped]
        //[Description("customer Delivery Address")]
        //public string ExpCustomerDeliveryAddr => ExpCustomerDeliveryAddess?.Exp_full_address ?? "";

        //[NotMapped]
        //[Description("Currency")]
        //public currency ExpCurrency => GetCurrency();
        //private currency GetCurrency()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB.Set<currency>().AsNoTrackingWithIdentityResolution().Where(c => c.code == currencycode).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Currency Full name1")]
        //public string ExpCurrencyFullName => string.Format("{0}-{1}", this.ExpCurrency?.code ?? "", this.ExpCurrency?.ExpCurrencyName ?? "");

        //[NotMapped]
        //[Description("Currency name1")]
        //public string ExpCurrencyName => this.ExpCurrency?.ExpCurrencyName ?? "";

        //[NotMapped]
        //[Description("VAT")]
        //public vattype ExpVAT => GetVAT();
        //private vattype GetVAT()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB.Set<vattype>().AsNoTrackingWithIdentityResolution().Where(c => c.code == VatCode && c.vat_type == 0).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Section")]
        //public section ExpSection => GetSection();
        //private section GetSection()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB.Set<section>().AsNoTrackingWithIdentityResolution().Where(c => c.code == SectCode).FirstOrDefault() ?? null;
        //}

        ///// <summary>
        ///// มูลค่าค้างชำระ
        ///// </summary>
        //[NotMapped]
        //[Description("Outstanding Balance")]
        //public decimal ExpOutstandingBalance { get; set; } = 0M;

        ///// <summary>
        ///// จำนวนครั้งที่ทำ ใบเสร็จ,ใบเสร็จก่อนการรับเงิน แล้ว
        ///// </summary>
        //[NotMapped]
        //[Description("Number of billing times")]
        //public int ExpQtyOfBill { get; set; } = 0;
        ///// <summary>
        ///// Invoice DocGroup ตามรายการของ Bill
        ///// </summary>
        //[NotMapped]
        //[Description("Ref(Invoice DocGroup)")]
        //public string ExpRefInvoiceDocGroup => this.pmethGetInvoiceDocGroup();

        //private string pmethGetInvoiceDocGroup()
        //{
        //    return _DB?.Set<BillTrnD>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.HeadLinkID == this.LinkID && c.refinvoicedocgroup == SysDef.DOC_GROUP.SS)?.FirstOrDefault()?.refinvoicedocgroup ?? SysDef.DOC_GROUP.ST;
        //}
        //#endregion
        //private string GetDebuggerDisplay()
        //{
        //    return ToString();






    }
}
