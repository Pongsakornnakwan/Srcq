using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RichnessSoft.Common.ConstUtil;

namespace RichnessSoft.Entity.Model
{
    public class BaseInvDModel : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int bookid { get; set; } = default;
        public int sectionid { get; set; } = default;
        public int departmentid { get; set; } = default;
        public int projectid { get; set; } = default;
        public int plansld { get; set; } = default;
        public int gltrnhid { get; set; } = default;
        public int invtrnhid { get; set; } = default;
        public int? customerid { get; set; } = default;
        public int? vendorid { get; set; } = default;
        public int warehouseid { get; set; } = default;
        public int productid { get; set; } = default;
        public int umid { get; set; } = default;
        public int umstdid { get; set; } = default;

        public string doctype { get; set; } = string.Empty;
        public string docstatus { get; set; }
        public DateTime? docdate { get; set; } = DateTime.UtcNow.Date;
        public DateTime? docdeliverydate { get; set; } = DateTime.UtcNow.Date;
        public string pstype { get; set; } = string.Empty;
        public string refund { get; set; } 
        public string prodtype { get; set; } = string.Empty;
        public string inouttype { get; set; } 
        public string rootseq { get; set; } = string.Empty;
        public string setparent { get; set; } = string.Empty;
        //public string ProdName { get; set; } = string.Empty;
        //public string Prodname2 { get; set; } = string.Empty;
        //public string UnitName { get; set; } = string.Empty;
        //public string Unitname2 { get; set; } = string.Empty;
        //public string UnitStdName { get; set; } = string.Empty;
        //public string UnitStdname2 { get; set; } = string.Empty;
        public decimal qty { get; set; } = 0;
        public decimal backqty { get; set; } = 0;
        public decimal qtystd { get; set; } = 0;
        public decimal price { get; set; } = 0;
        public decimal pricek { get; set; } = 0;
        public string discstr { get; set; } = string.Empty;
        public decimal discamount { get; set; } = 0;
        public decimal discamountk { get; set; } = 0;
        public decimal xrate { get; set; } = 0;
        public decimal bfvatamount { get; set; } = 0;
        public decimal bfvatamountk { get; set; } = 0;
        public decimal amount { get; set; } = 0;
        public decimal amountk { get; set; } = 0;
        public string vattype { get; set; }
        public string vatisout { get; set; } = VALUE_ADDED_TAX.EXCLUDED;
        public decimal vatrate { get; set; } = 0;
        public decimal vatamount { get; set; } = 0;
        public decimal vatamountk { get; set; } = 0;
        public string lot { get; set; } = string.Empty;
        public DateTime? mfgdate { get; set; }
        public DateTime? expdate { get; set; }
        //public string WhName { get; set; } = string.Empty;
        //public string Whname2 { get; set; } = string.Empty;
        public int seq { get; set; } = default;
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
        public decimal costamount { get; set; } = 0;
        public decimal costadj { get; set; } = 0;
        public decimal costavg { get; set; } = 0;
        public decimal costfifo { get; set; } = 0;
        public decimal costlot { get; set; } = 0;
        public decimal coststd { get; set; } = 0;
        public int calflag { get; set; } 
        public int refdochid { get; set; } = default;
        public string refdoctype { get; set; } = string.Empty;
        public int refdocdid { get; set; } = default;
        public decimal refdocqtyofcut { get; set; } = 0;
        public decimal paycurramt { get; set; } = 0;
        public decimal paystdamt { get; set; } = 0;

        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Book Book { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
        public virtual GLTrnH GLTrnH { get; set; }
        public virtual InvTrnH InvTrnH { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        //public virtual UM UM { get; set; }
        //public virtual UM UmStd { get; set; }


        //#region Expression Field
        //[NotMapped]
        //[Description("ชื่อบริษัท")]
        //public string ExpCorpName => GetCorpName();

        //private string GetCorpName()
        //{
        //    string strRetValue = "";
        //    if (_DB is null) { return strRetValue; }
        //    company oResult = _DB.Set<company>().AsNoTrackingWithIdentityResolution().Where(c => c.code == CorpCode).FirstOrDefault() ?? null;
        //    if (oResult is not null)
        //    {
        //        strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? oResult.name2 : oResult.name1;
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
        //        case ConstUtilBase.cStatus.NEW:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "NEW" : "NEW";
        //            break;
        //        case ConstUtilBase.cStatus.ORDER:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "ORDER" : "ORDER"; ;
        //            break;
        //        case ConstUtilBase.cStatus.SOME:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "SOME" : "SOME"; ;
        //            break;
        //        case ConstUtilBase.cStatus.CANCEL:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "CANCEL" : "CANCEL"; ;
        //            break;
        //        case ConstUtilBase.cStatus.INV:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "INV" : "INV"; ;
        //            break;
        //        case ConstUtilBase.cStatus.PAID:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "PAID" : "PAID"; ;
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
        //public string ExpBookName => GetBookName();
        //private string GetBookName()
        //{
        //    string strRetValue = "";
        //    if (_DB is null) { return strRetValue; }
        //    book oResult = _DB.Set<book>().AsNoTrackingWithIdentityResolution().Where(c => c.code == BookCode).FirstOrDefault() ?? null;
        //    if (oResult is not null)
        //    {
        //        strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? oResult.name2 : oResult.name1;
        //    }
        //    return strRetValue ?? "";
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
        //[Description("Product name1(Full)")]
        //public string ExpProductFullName => string.Format("{0}-{1}", this.ProdCode, gbVar.UserLang.name1 == "en-US" ? this.Prodname2 : this.ProdName);

        //[NotMapped]
        //[Description("Product name1")]
        //public string ExpProductName => gbVar.UserLang.name1 == "en-US" ? this.Prodname2 : this.ProdName;

        //[NotMapped]
        //[Description("Warehouse name1(Full)")]
        //public string ExpWarehouseFullName => string.Format("{0}-{1}", this.WhCode, gbVar.UserLang.name1 == "en-US" ? this.Whname2 : this.WhName);

        //[NotMapped]
        //[Description("Warehouse name1")]
        //public string ExpWarehouseName => gbVar.UserLang.name1 == "en-US" ? this.Whname2 : this.WhName;

        //[NotMapped]
        //[Description("Unit name1(Full)")]
        //public string ExpUnitFullName => string.Format("{0}-{1}", this.UnitCode, gbVar.UserLang.name1 == "en-US" ? this.Unitname2 : this.UnitName);

        //[NotMapped]
        //[Description("Unit name1")]
        //public string ExpUnitName => gbVar.UserLang.name1 == "en-US" ? this.Unitname2 : this.UnitName;

        //[NotMapped]
        //[Description("Unit.Std name1(Full)")]
        //public string ExpUnitStdFullName => string.Format("{0}-{1}", this.UnitStdCode, gbVar.UserLang.name1 == "en-US" ? this.UnitStdname2 : this.UnitStdName);

        //[NotMapped]
        //[Description("Unit.Std name1")]
        //public string ExpUnitStdName => gbVar.UserLang.name1 == "en-US" ? this.UnitStdname2 : this.UnitStdName;

        //[NotMapped]
        //[Description("Department name1(Full)")]
        //public string ExpDeptFullName => string.Format("{0}-{1}", this.DeptCode, gbVar.UserLang.name1 == "en-US" ? this.Deptname2 : this.DeptName);

        //[NotMapped]
        //[Description("Department")]
        //public department ExpDept => GetDept();

        //private department GetDept()
        //{
        //    return _DB?.Set<department>()?.AsNoTrackingWithIdentityResolution().Where(c => c.code == this.DeptCode)?.FirstOrDefault() ?? null;
        //}

        //[NotMapped]
        //[Description("Department name1")]
        //public string ExpDeptName => gbVar.UserLang.name1 == "en-US" ? this.Deptname2 : this.DeptName;

        //[NotMapped]
        //[Description("Project")]
        //public project ExpProj => GetProj();

        //private project GetProj()
        //{
        //    return _DB?.Set<project>()?.AsNoTrackingWithIdentityResolution().Where(c => c.code == this.ProjCode)?.FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Project name1(Full)")]
        //public string ExpProjFullName => string.Format("{0}-{1}", this.ProjCode, gbVar.UserLang.name1 == "en-US" ? this.Projname2 : this.ProjName);

        //[NotMapped]
        //[Description("Project name1")]
        //public string ExpProjName => gbVar.UserLang.name1 == "en-US" ? this.Projname2 : this.ProjName;

        //[NotMapped]
        //[Description("qty : Unit Sell")]
        //public string ExpQtyUnit => string.Format("{0} : {1}", qty.ToString("N0"), gbVar.UserLang.name1 == "en-US" ? this.Unitname2 ?? "?" : this.UnitName ?? "?");
        //[NotMapped]
        //[Description("qty : Standard Unit")]
        //public string ExpQtyStdUnit => string.Format("{0} : {1}", qtystd.ToString("N0"), gbVar.UserLang.name1 == "en-US" ? this.UnitStdname2 ?? "?" : this.UnitStdName ?? "?");

        //[NotMapped]
        //[Display(name1 = "ประเภทภาษี")]
        //public ConstUtilBase.cTypeVAT ExpTypeVAT => ConstUtil.goListTypeVAT?.Where(c => c.code == this.TypeVat)?.FirstOrDefault() ?? null;

        //[NotMapped]
        //[Display(name1 = "ประเภทภาษี")]
        //public string ExpTypeVATName => gbVar.UserLang.name1 == "en-US" ? ExpTypeVAT?.name2 ?? "" : ExpTypeVAT?.name1 ?? "";

        //[NotMapped]
        //[Display(name1 = "เอกสารอ้างอิง(Head)")]
        //public object ExpRefDocHead => this.GetRefDocHead();

        //[NotMapped]
        //[Display(name1 = "เอกสารอ้างอิง(Invoice code)")]
        //public string ExpRefInvoiceHeadCode => (ExpRefDocHead as InvTrnH)?.doccode ?? "";

        //[NotMapped]
        //[Display(name1 = "เอกสารอ้างอิง(Order code)")]
        //public string ExpRefOrderHeadCode => (ExpRefDocHead as orderTrnH)?.doc_code ?? "";

        //[NotMapped]
        //[Display(name1 = "เอกสารอ้างอิง(Stock code)")]
        //public string ExpRefStockHeadCode => (ExpRefDocHead as StockTrnH)?.doccode ?? "";

        //private object GetRefDocHead()
        //{
        //    if (UtilHelper.gmIsNullOrEmpty(this.RefDocHeadLinkID)) { return default; }
        //    else if (UtilHelper.gmIsNullOrEmpty(this.refdoctype)) { return default; }
        //    switch (this.refdoctype)
        //    {
        //        case GbDocRefType.SALE.QUOTATION:
        //        case GbDocRefType.SALE.SALE_ORDER:
        //            return _DB?.Set<orderTrnH>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == this.RefDocHeadLinkID)?.FirstOrDefault()?.doc_code ?? string.Empty;
        //            break;
        //        case GbDocRefType.SALE.CREDIT_SALE_INVOICE_TAX_NOT_DUE:
        //        case GbDocRefType.SALE.INVOICE_CREDIT_NOTE_TAX_NOT_DUE:
        //        case GbDocRefType.SALE.INVOICE_DEBIT_NOTE_TAX_NOT_DUE:
        //        case GbDocRefType.SALE.TAX_INVOICE_CREDIT_NOTE_CASH_SALE:
        //        case GbDocRefType.SALE.TAX_INVOICE_CREDIT_NOTE_CREDIT_SELL:
        //        case GbDocRefType.SALE.TAX_INVOICE_DEBIT_NOTE_CASH_SALE:
        //        case GbDocRefType.SALE.TAX_INVOICE_DEBIT_NOTE_CREDIT_SELL:
        //        case GbDocRefType.SALE.TAX_INVOICE_INVOICE_CREDIT_SELL:
        //        case GbDocRefType.SALE.TAX_INVOICE_RECEIPT_CASH_SALE:
        //            return _DB?.Set<InvTrnH>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == this.RefDocHeadLinkID)?.FirstOrDefault()?.doccode ?? string.Empty;
        //            break;
        //        case GbDocRefType.INVENTORY.DELIVERY_ORDER:
        //        case GbDocRefType.INVENTORY.GOODS_RECEIVED:
        //        case GbDocRefType.INVENTORY.ADJUST_INVENTORY:
        //            return _DB?.Set<StockTrnH>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == this.RefDocHeadLinkID)?.FirstOrDefault()?.doccode ?? string.Empty;
        //            break;
        //        case GbDocRefType.PURCHASE.PURCHASE_REQUEST:
        //        case GbDocRefType.PURCHASE.PURCHASE_ORDER:
        //        case GbDocRefType.PURCHASE.PURCHASE_TAX_INVOICE:
        //        case GbDocRefType.PURCHASE.PURCHASE_CREDIT_NOTE:
        //        case GbDocRefType.PURCHASE.PURCHASE_DEBIT_NOTE:
        //        case GbDocRefType.PURCHASE.SERVICE_CREDIT_NOTE_BUY:
        //        case GbDocRefType.PURCHASE.SERVICE_DEBIT_NOTE_BUY:
        //        case GbDocRefType.PURCHASE.SERVICE_INVOICE_BUY:
        //        case GbDocRefType.PURCHASE.TAX_INVOICE_CREDIT_NOTE_CASH_BUY:
        //        case GbDocRefType.PURCHASE.TAX_INVOICE_DEBIT_NOTE_CASH_BUY:
        //        case GbDocRefType.PURCHASE.TAX_INVOICE_RECEIPT_CASH_BUY:
        //            return _DB?.Set<PurchaseTrnH>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == this.RefDocHeadLinkID)?.FirstOrDefault()?.doccode ?? string.Empty;
        //            break;
        //    }
        //    return default;
        //}


        //private string GetRefDocHeadCode()
        //{
        //    string strRefDocHeadCode = "";
        //    if (UtilHelper.gmIsNullOrEmpty(this.RefDocHeadLinkID)) { return strRefDocHeadCode; }
        //    else if (UtilHelper.gmIsNullOrEmpty(this.refdoctype)) { return strRefDocHeadCode; }
        //    switch (this.refdoctype)
        //    {
        //        case GbDocRefType.SALE.QUOTATION:
        //        case GbDocRefType.SALE.SALE_ORDER:
        //            strRefDocHeadCode = _DB?.Set<orderTrnH>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == this.RefDocHeadLinkID)?.FirstOrDefault()?.doc_code ?? string.Empty;
        //            break;
        //        case GbDocRefType.SALE.CREDIT_SALE_INVOICE_TAX_NOT_DUE:
        //        case GbDocRefType.SALE.INVOICE_CREDIT_NOTE_TAX_NOT_DUE:
        //        case GbDocRefType.SALE.INVOICE_DEBIT_NOTE_TAX_NOT_DUE:
        //        case GbDocRefType.SALE.TAX_INVOICE_CREDIT_NOTE_CASH_SALE:
        //        case GbDocRefType.SALE.TAX_INVOICE_CREDIT_NOTE_CREDIT_SELL:
        //        case GbDocRefType.SALE.TAX_INVOICE_DEBIT_NOTE_CASH_SALE:
        //        case GbDocRefType.SALE.TAX_INVOICE_DEBIT_NOTE_CREDIT_SELL:
        //        case GbDocRefType.SALE.TAX_INVOICE_INVOICE_CREDIT_SELL:
        //        case GbDocRefType.SALE.TAX_INVOICE_RECEIPT_CASH_SALE:
        //            strRefDocHeadCode = _DB?.Set<InvTrnH>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == this.RefDocHeadLinkID)?.FirstOrDefault()?.doccode ?? string.Empty;
        //            break;
        //        case GbDocRefType.INVENTORY.DELIVERY_ORDER:
        //        case GbDocRefType.INVENTORY.GOODS_RECEIVED:
        //        case GbDocRefType.INVENTORY.ADJUST_INVENTORY:
        //            strRefDocHeadCode = _DB?.Set<StockTrnH>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == this.RefDocHeadLinkID)?.FirstOrDefault()?.doccode ?? string.Empty;
        //            break;
        //        case GbDocRefType.PURCHASE.PURCHASE_REQUEST:
        //        case GbDocRefType.PURCHASE.PURCHASE_ORDER:
        //        case GbDocRefType.PURCHASE.PURCHASE_TAX_INVOICE:
        //        case GbDocRefType.PURCHASE.PURCHASE_CREDIT_NOTE:
        //        case GbDocRefType.PURCHASE.PURCHASE_DEBIT_NOTE:
        //        case GbDocRefType.PURCHASE.SERVICE_CREDIT_NOTE_BUY:
        //        case GbDocRefType.PURCHASE.SERVICE_DEBIT_NOTE_BUY:
        //        case GbDocRefType.PURCHASE.SERVICE_INVOICE_BUY:
        //        case GbDocRefType.PURCHASE.TAX_INVOICE_CREDIT_NOTE_CASH_BUY:
        //        case GbDocRefType.PURCHASE.TAX_INVOICE_DEBIT_NOTE_CASH_BUY:
        //        case GbDocRefType.PURCHASE.TAX_INVOICE_RECEIPT_CASH_BUY:
        //            strRefDocHeadCode = _DB?.Set<PurchaseTrnH>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == this.RefDocHeadLinkID)?.FirstOrDefault()?.doccode ?? string.Empty;
        //            break;
        //    }
        //    return strRefDocHeadCode;
        //}

        //#endregion






    }



}
