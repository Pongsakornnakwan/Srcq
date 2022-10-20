using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RichnessSoft.Common.ConstUtil;

namespace RichnessSoft.Entity.Model
{
    public class InvTrnH : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int bookid { get; set; } = default;
        public int sectionid { get; set; } = default;
        public int departmentid { get; set; } = default;
        public int projectid { get; set; } = default;
        public int plansld { get; set; } = default;
        public int? gltrnhid { get; set; } = default;
        public int? gltrnhcaid { get; set; } = default;
        public int? customerid { get; set; } = default;
        public int? vendorid { get; set; } = default;
        public int? contactid { get; set; } = default;
        public int? salemanid { get; set; } = default;
        public int? currencyid { get; set; } = default;
        public int warehouseid { get; set; } = default;


        public string doctype { get; set; }
        public string doccode { get; set; } = string.Empty;
        public string docrefnumber { get; set; } = string.Empty;
        public string docstatus { get; set; }
        public string custsuppbranchcode { get; set; } = string.Empty;
        public string custsupptax { get; set; } = string.Empty;
        public int addressofficeid { get; set; }
        public string addressofficedetail { get; set; }
        public int addressdeliveryid { get; set; }
        public string addressdeliverydetail { get; set; }
        //public string contactname { get; set; } = string.Empty;
        public string contacttel { get; set; } = string.Empty;
        public string shippingby { get; set; } = string.Empty;
        public DateTime? purchasedate { get; set; }
        public string purchasecode { get; set; }
        public string IsRetProduct { get; set; } = string.Empty;
        public string RetProductReason { get; set; } = string.Empty;
        public DateTime? docdate { get; set; } = DateTime.UtcNow.Date;
        public DateTime? docdelidate { get; set; } = null;
        public string deliverycode { get; set; }
        public DateTime? docduedate { get; set; } = null;
        public DateTime? docvatdate { get; set; } = null;
        public string vattype { get; set; } = string.Empty;
        public decimal vatrate { get; set; } = 0M;
        public string vatisout { get; set; } = VALUE_ADDED_TAX.EXCLUDED;
        public decimal CreditTerm { get; set; } = 0;
        public string taxrefund { get; set; }
        public string vatdue { get; set; }
        public string islocked { get; set; }
        public decimal currencyrate { get; set; } = 0M;
        public int taxreportaddrid { get; set; } = 0;
        public string approvedby { get; set; } = string.Empty;
        public DateTime? approveddate { get; set; } = null;
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
        public decimal footcurrdisamtitem { get; set; } = 0M;
        public decimal footstddisamtitem { get; set; } = 0M;
        public decimal footcurrpayamount { get; set; } = 0M;
        public decimal footstdpayamount { get; set; } = 0M;
        public decimal foottotalqty { get; set; } = 0M;
        public decimal footcurramt { get; set; } = 0;
        public decimal footstdamt { get; set; } = 0;
        public string footcurrdiscstr { get; set; } = string.Empty;
        public decimal footcurrdiscamt { get; set; } = 0M;
        public decimal footstddiscamt { get; set; } = 0M;
        public decimal footcurrafdiscamt { get; set; } = 0;
        public decimal footstdafdiscamt { get; set; } = 0;
        public decimal footdepositamt { get; set; } = 0;
        public decimal footcurrafdepositamt { get; set; } = 0;
        public decimal footstdafdepositamt { get; set; } = 0;
        public decimal footcurrwithouttaxamt { get; set; } = 0;
        public decimal footstdwithouttaxamt { get; set; } = 0;
        public decimal footcurrwithtaxamt { get; set; } = 0;
        public decimal footstdwithtaxamt { get; set; } = 0;
        public decimal footcurrbfvatamt { get; set; } = 0;
        public decimal footstdbfvatamt { get; set; } = 0;
        public decimal footcurrvatamt { get; set; } = 0;
        public decimal footstdvatamt { get; set; } = 0;
        public decimal footwithholdingtaxamt { get; set; } = 0;
        public decimal footcurrnetamt { get; set; } = 0;
        public decimal footstdnetamt { get; set; } = 0;

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
        public virtual ICollection<InvTrnD> InvTrnDs { get; set; }

        //#region VauleAddedTax Field


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

        //[Display(name1 = "Cancellation Reason")]
        //[Description("เหตุผลยกเลิกใบแจ้งหนี้")]
        //[MaxLength(255)]
        //public string cancellationreason { get; set; } = string.Empty;

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

        //#region Delivery Address Field
        //[Display(name1 = "Address of delivery ")]
        //[Description("ที่อยู่ส่งของ(เก็บแยกจากเอกสารเชื่อมโยงกันด้วย ID)")]
        //public int DeliAddrId { get; set; } = 0;

        //[Display(name1 = "Staff name1 of delivery")]
        //[Description("ชื่อพนักงานที่ใช้จัดส่ง")]
        //[MaxLength(255)]
        //public string DeliStaff { get; set; } = string.Empty;

        //[Display(name1 = "Staff name1(2) of delivery")]
        //[Description("ชื่อพนักงานที่ใช้จัดส่ง(ภาษา 2)")]
        //[MaxLength(255)]
        //public string DeliStaff2 { get; set; } = string.Empty;

        //[Display(name1 = "Delivery Payer code")]
        //[Description("ชื่อลูกค้าที่อยู่ที่ส่งของ")]
        //[MaxLength(25)]
        //public string DeliPayerCode { get; set; } = string.Empty;

        //[Display(name1 = "Delivery Payer name1")]
        //[Description("ชื่อลูกค้าที่อยู่่ส่งของ")]
        //[MaxLength(255)]
        //public string DeliPayerName { get; set; } = string.Empty;

        //[Display(name1 = "Delivery Payer name1(2)")]
        //[Description("ชื่อลูกค้าที่อยู่่ส่งของ ภาษา 2")]
        //[MaxLength(255)]
        //public string DeliPayername2 { get; set; } = string.Empty;

        //[Display(name1 = "Delivery Payer ID")]
        //[Description("เลขประจำตัวผู้เสียภาษี")]
        //[MaxLength(25)]
        //public string DeliID { get; set; } = string.Empty;

        //[Display(name1 = "Delivery Payer Branch code")]
        //[Description("รัหสสาขา")]
        //[MaxLength(10)]
        //public string DeliBranchNo { get; set; } = string.Empty;

        //[Display(name1 = "Delivery Payer Branch name1")]
        //[Description("ชื่อสาขา")]
        //[MaxLength(255)]
        //public string DeliBranchName { get; set; } = string.Empty;

        //[Display(name1 = "Delivery Payer Branch name1(2)")]
        //[Description("ชื่อสาขา")]
        //[MaxLength(255)]
        //public string DeliBranchname2 { get; set; } = string.Empty;

        //[Display(name1 = "Delivery tel.")]
        //[Description("เบอรโทร")]
        //[MaxLength(50)]
        //public string DeliTel { get; set; } = string.Empty;

        //#endregion
        //#region Expression Field
        //[NotMapped]
        //[Description("Company")]
        //public company ExpCorp => GetCorp();
        //private company GetCorp()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB?.Set<company>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.code == this.CorpCode)?.FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Company Full name1")]
        //public string ExpCorpFullName => this.ExpCorp?.ExpCompanyFullName ?? "";

        //[NotMapped]
        //[Description("Company name1")]
        //public string ExpCorpName => this.ExpCorp?.ExpCompanyName ?? "";

        //[NotMapped]
        //[Description("login")]
        //public string ExpLoginName => GetLoginName();
        //private string GetLoginName()
        //{
        //    string strRetValue = "";
        //    if (_DB is null) { return strRetValue; }
        //    user oResult = _DB.Set<user>().AsNoTrackingWithIdentityResolution().Where(c => c.userName == approvedby).FirstOrDefault() ?? null;
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
        //        case ConstUtil.INV_STATUS.NEW:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "NEW" : "สร้างใหม่";
        //            break;
        //        case ConstUtil.INV_STATUS.BILL:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "BILL" : "วางบิล"; ;
        //            break;
        //        case ConstUtil.INV_STATUS.CANCELED:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "CANCELED" : "ยกเลิก"; ;
        //            break;
        //        case ConstUtil.INV_STATUS.DELIVERY:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "DELIVERY" : "ส่งของ"; ;
        //            break;
        //        case ConstUtil.INV_STATUS.PART:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "PART" : "ชำระบางส่วน"; ;
        //            break;
        //        case ConstUtil.INV_STATUS.PAID:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "PAID" : "ชำระเต็มแล้ว"; ;
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
        //[Description("Warehouse")]
        //public warehouse ExpWarehouse => GetWarehouse();
        //private warehouse GetWarehouse()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB.Set<warehouse>().AsNoTrackingWithIdentityResolution().Where(c => c.code == WhCode).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Section")]
        //public section ExpSection => GetSection();
        //private section GetSection()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB.Set<section>().AsNoTrackingWithIdentityResolution().Where(c => c.code == SectCode).FirstOrDefault() ?? null;
        //}

        //[NotMapped]
        //[Description("Branch")]
        //public branch ExpBranch => GetBranch();
        //private branch GetBranch()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB?.Set<branch>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.CorpCode == this.CorpCode && c.code == this.branchcode)?.FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Branch Full name1")]
        //public string ExpBranchFullName => this.ExpBranch?.ExpFullName ?? "";

        //[NotMapped]
        //[Description("Branch name1")]
        //public string ExpBranchName => this.ExpBranch?.ExpName ?? "";

        //[NotMapped]
        //[Description("Department")]
        //public department ExpDepartment => GetDepartment();
        //private department GetDepartment()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB?.Set<department>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.CorpCode == this.CorpCode && c.code == this.DeptCode)?.FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Department Full name1")]
        //public string ExpDepartmentFullName => this.ExpDepartment?.ExpFullName ?? "";

        //[NotMapped]
        //[Description("Department name1")]
        //public string ExpDepartmentName => this.ExpDepartment?.ExpName ?? "";

        //[NotMapped]
        //[Description("Project")]
        //public project ExpProject => GetProject();
        //private project GetProject()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB?.Set<project>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.CorpCode == this.CorpCode && c.code == this.ProjCode)?.FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Project Full name1")]
        //public string ExpProjectFullName => this.ExpProject?.ExpFullName ?? "";

        //[NotMapped]
        //[Description("Project name1")]
        //public string ExpProjectName => this.ExpProject?.ExpName ?? "";
        //#endregion
    }
}
