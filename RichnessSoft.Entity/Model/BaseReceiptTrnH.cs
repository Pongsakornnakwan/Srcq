using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class BaseReceiptTrnH : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int bookid { get; set; } = default;
        public int sectionid { get; set; } = default;
        public int departmentid { get; set; } = default;
        public int projectid { get; set; } = default;
        public int plansld { get; set; } = default;
        public int? customerid { get; set; } = default;
        public int? vendorid { get; set; } = default;
        public int? gltrnhid { get; set; } = default;
        public int? gltrnhcaid { get; set; } = default;
        public int contactid { get; set; } = default;
        public int salemanid { get; set; } = default;
        public int currencyid { get; set; } = default;

        public string doctype { get; set; } 
        public string doccode { get; set; } = string.Empty;
        public string docrefnumber { get; set; } = string.Empty;
        public string docstatus { get; set; } 
        //public string CustSuppCode { get; set; } = string.Empty;
        //public string IsCust { get; set; } 
        public string custsuppbranchcode { get; set; } = string.Empty;
        public string custsupptaxid { get; set; } = string.Empty;
        public int addressofficeid { get; set; }
        public string addressofficedetail { get; set; }
        public string contactname { get; set; } = string.Empty;
        public string contactname2 { get; set; } = string.Empty;
        public string contacttel { get; set; } = string.Empty;
        public DateTime? docdate { get; set; } = DateTime.UtcNow.Date;
        public DateTime? refdocdate { get; set; } = null;
        public string refdoccode { get; set; } = string.Empty;
        public string islocked { get; set; } 
        public string currencycode { get; set; } = string.Empty;
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

        //#region VauleAddedTax Field

        //[Display(name1 = "Address of tax report")]
        //[Description("ที่อยู่รายงานภาษี(เก็บแยกจากเอกสารเชื่อมโยงกันด้วย ID)")]
        //public int taxreportaddrid { get; set; } = 0;

        //[Display(name1 = "TaxPayer code")]
        //[Description("ชื่อลูกค้าที่ออกรายงานภาษี และแสดงในใบกำกับภาษี")]
        //[MaxLength(25)]
        //public string TaxPayerCode { get; set; } = string.Empty;

        //[Display(name1 = "TaxPayer name1")]
        //[Description("ชื่อลูกค้าในรายงานภาษี")]
        //[MaxLength(255)]
        //public string TaxPayerName { get; set; } = string.Empty;

        //[Display(name1 = "TaxPayer name1(2)")]
        //[Description("ชื่อลูกค้าในรายงานภาษี ภาษา 2")]
        //[MaxLength(255)]
        //public string TaxPayername2 { get; set; } = string.Empty;

        //[Display(name1 = "TaxPayer ID")]
        //[Description("เลขประจำตัวผู้เสียภาษี")]
        //[MaxLength(25)]
        //public string taxid { get; set; } = string.Empty;

        //[Display(name1 = "TaxPayer Branch code")]
        //[Description("รัหสสาขา")]
        //[MaxLength(10)]
        //public string taxbranchno { get; set; } = string.Empty;

        //[Display(name1 = "TaxPayer Branch name1")]
        //[Description("ชื่อสาขา")]
        //[MaxLength(255)]
        //public string taxbranchname { get; set; } = string.Empty;

        //[Display(name1 = "TaxPayer Branch name1(2)")]
        //[Description("ชื่อสาขา")]
        //[MaxLength(255)]
        //public string TaxBranchname2 { get; set; } = string.Empty;

        //[Display(name1 = "Filing Tax")]
        //[Description("ยื่นภาษีเดือน/ปี")]
        //public DateTime? FilingTax { get; set; } = null;

        //[MaxLength(1)]
        //[Display(name1 = "Tax refund")]
        //[Description("การคืนเงินภาษี")]
        //[DefaultValue(CONFIRM.YES)]
        //public string taxrefund { get; set; } = CONFIRM.YES;

        //[Display(name1 = "Tax refund(%)")]
        //[Description("% ขอคืนภาษี")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal taxrefundpercen { get; set; } = 0M;

        //[Display(name1 = "Tax refund amount")]
        //[Description("ยอดภาษีที่ขอคืนได้")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal taxrefundamt { get; set; } = 0M;

        //[Display(name1 = "Cancel original invoice To issue new tax invoice")]
        //[Description("ยกเลิกใบกำกับภาษีเดิม เพื่อออกใบกำกับภาษีใหม่")]
        //[DefaultValue(CONFIRM.NO)]
        //[MaxLength(1)]
        //public string IsCanceOldTaxInv { get; set; } = CONFIRM.NO;

        //[Display(name1 = "Reason for cancellation of original tax invoice")]
        //[Description("สาเหตุในการยกเลิกใบกำกับภาษีเดิม")]
        //[MaxLength(25)]
        //public string ReasonCanceOldTaxInv { get; set; } = string.Empty;

        //[Display(name1 = "Other Reason")]
        //[Description("เหตุอื่น ๆ")]
        //[MaxLength(255)]
        //public string OtherReason { get; set; } = string.Empty;

        //[Display(name1 = "Original tax invoice code")]
        //[Description("เลขที่ใบกำกับภาษีเดิม")]
        //[MaxLength(25)]
        //public string OldTaxInvCode { get; set; } = string.Empty;

        //[Display(name1 = "Original tax invoice date")]
        //[Description("วันที่ของใบกำกับภาษีเดิม")]
        //public DateTime? OldTaxInvDate { get; set; }

        //[Display(name1 = "E-TAX TEL.")]
        //[Description("เบอร์โทรส่ง e-tax")]
        //[MaxLength(25)]
        //public string ETaxTel { get; set; } = string.Empty;

        //#endregion

        //[Display(name1 = "Total qty.")]
        //[Description("จำนวนใบแจ้งหนี้")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,0)")]
        //public decimal foottotalqty { get; set; } = 0M;

        //[Display(name1 = "Total amount(Currency)")]
        //[Description("มูลค่า")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footcurramt { get; set; } = 0;

        //[Display(name1 = "Total amount(Standard)")]
        //[Description("มูลค่า")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footstdamt { get; set; } = 0;

        //[Display(name1 = "discount String(Currency)")]
        //[Description("ส่วนลดท้ายบิล")]
        //public string footdiscstr { get; set; } = string.Empty;

        //[Display(name1 = "discount amount(Currency)")]
        //[Description("ส่วนลดท้ายบิล")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footcurrdiscamt { get; set; } = 0M;

        //[Display(name1 = "discount amount(Standard)")]
        //[Description("ส่วนลดท้ายบิล")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footstddiscamt { get; set; } = 0M;

        //[Display(name1 = "After discount amount(Currency)")]
        //[Description("มูลค่าหลัง หัก ส่วนลด")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footcurrafdiscamt { get; set; } = 0M;

        //[Display(name1 = "After discount amount(Standard)")]
        //[Description("มูลค่าหลัง หัก ส่วนลด")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footstdafdiscamt { get; set; } = 0M;

        //[Display(name1 = "Deposit amount(Currency)")]
        //[Description("มูลค่าเงินมัดจำ")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal FootCurrDepositAmt { get; set; } = 0M;

        //[Display(name1 = "Deposit amount(Standard)")]
        //[Description("มูลค่าเงินมัดจำ")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal FootStdDepositAmt { get; set; } = 0M;

        //[Display(name1 = "After Deposit amount(Currency)")]
        //[Description("มูลค่าหลัง หัก เงินมัดจำ")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footcurrafdepositamt { get; set; } = 0M;

        //[Display(name1 = "After Deposit amount(Standard)")]
        //[Description("มูลค่าหลัง หัก เงินมัดจำ")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footstdafdepositamt { get; set; } = 0M;

        //[Display(name1 = "VAT amount(Currency)")]
        //[Description("ภาษีมูลค่าเพิ่ม")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footcurrvatamt { get; set; } = 0M;

        //[Display(name1 = "VAT amount(Standard)")]
        //[Description("ภาษีมูลค่าเพิ่ม")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footstdvatamt { get; set; } = 0M;

        //[Display(name1 = "Withholding Tax(Currency)")]
        //[Description("ภาษีหัก ณ ที่จ่าย")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footcurrwithholdingtaxamt { get; set; } = 0;

        //[Display(name1 = "Withholding Tax(Standard)")]
        //[Description("ภาษีหัก ณ ที่จ่าย")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footstdwithholdingtaxamt { get; set; } = 0;

        //[Display(name1 = "Positive Interest(Currency)")]
        //[Description("ดอกเบี้ยบวก")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal FootCurrPositiveInterestAmt { get; set; } = 0;

        //[Display(name1 = "Positive Interest(Standard)")]
        //[Description("ดอกเบี้ยบวก")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal FootStdPositiveInterestAmt { get; set; } = 0;

        //[Display(name1 = "Net amount(Currency)")]
        //[Description("มูลค่าสุทธิ")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footcurrnetamt { get; set; } = 0M;

        //[Display(name1 = "Net amount(Standard)")]
        //[Description("มูลค่าสุทธิ")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footstdnetamt { get; set; } = 0M;

        //[Display(name1 = "Payment amount(Currency)")]
        //[Description("มูลค่าชำระ")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footcurrpayamt { get; set; } = 0M;

        //[Display(name1 = "Payment amount(Standard)")]
        //[Description("มูลค่าชำระ")]
        //[DefaultValue(0)]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal footstdpayamt { get; set; } = 0M;

        //[Display(name1 = "Cancellation Reason")]
        //[Description("เหตุผลยกเลิกใบวางบิล")]
        //[MaxLength(255)]
        //public string cancellationreason { get; set; } = string.Empty;

        //#region Expression Field
        //[NotMapped]
        //[Description("เลขที่ใบสำคัญ")]
        //public string ExpVoucherNo { get; set; } = string.Empty;

        //[NotMapped]
        //[Description("ชื่อบริษัท")]
        //public string ExpCorpName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpCorp?.name2 ?? "" : ExpCorp?.name1 ?? "";
        //private company ExpCorp => _DB?.Set<company>().AsNoTrackingWithIdentityResolution()?.Where(c => c.code == CorpCode).FirstOrDefault() ?? null;

        //[NotMapped]
        //[Description("ชื่อสาขา")]
        //public string ExpBranchName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpBranch?.name2 ?? "" : ExpBranch?.name1 ?? "";
        //private branch ExpBranch => _DB?.Set<branch>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.code == branchcode).FirstOrDefault() ?? null;

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
        //        case ConstUtil.RECEIPT_STATUS.NEW:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "NEW" : "สร้างใหม่";
        //            break;
        //        case ConstUtil.RECEIPT_STATUS.CANCELED:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "CANCELED" : "ยกเลิก"; ;
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
        //    return _DB?.Set<book>().AsNoTrackingWithIdentityResolution()?.Where(c => c.code == BookCode)?.FirstOrDefault() ?? null;
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
        //#endregion
        //private string GetDebuggerDisplay()
        //{
        //    return ToString();









    }
}
