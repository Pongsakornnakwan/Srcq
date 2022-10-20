using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class OrderTrnH : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int bookid { get; set; } = default;
        public int? sectionid { get; set; } = default;
        public int? departmentid { get; set; } = default;
        public int? projectid { get; set; } = default;
        public int? plansld { get; set; } = default;
        public int? customerid { get; set; } = default;
        public int? vendorid { get; set; } = default;
        public int contactid { get; set; } = default;
        public int? salemanid { get; set; } = default;
        public int? currencyid { get; set; } = default;
        public int? warehouseid { get; set; } = default;

        public string doctype { get; set; } 
        public string approvestatus { get; set; } 
        public DateTime? docdate { get; set; } = DateTime.UtcNow.Date;
        public string doccode { get; set; } = string.Empty;
        public string docrefnumber { get; set; } = string.Empty;
        public string docstatus { get; set; } 
        public string docisclosed { get; set; } 
        public DateTime? doccloseddate { get; set; } = null;
        public string custaddr { get; set; } = string.Empty;
        public string custdeliaddr { get; set; } = string.Empty;
        public string custdeliaddredit { get; set; } = string.Empty;
        public decimal currencyrate { get; set; } = 0.00M;
        public string approveby { get; set; } = string.Empty;
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
        public string sendby { get; set; } = string.Empty;
        public string contactname { get; set; } = string.Empty;
        public Int32 creditterm { get; set; } = 0;
        public DateTime? duedate { get; set; } = null;
        public DateTime? estimatedate { get; set; } = null;
        public DateTime? deliverydate { get; set; } = null;
        public string vattype { get; set; } = string.Empty;
        public decimal vatrate { get; set; } = 0;
        public string vatisout { get; set; } 
        public decimal foottotalqty { get; set; } = 0;
        public decimal footcurramt { get; set; } = 0;
        public decimal footstdamt { get; set; } = 0;
        public string footcurrdiscstr { get; set; } = string.Empty;
        public decimal footcurrdiscamt { get; set; } = 0M;
        public decimal footstddiscamt { get; set; } = 0M;
        public decimal footcurrafdiscamt { get; set; } = 0;
        public decimal footstdafdiscamt { get; set; } = 0;
        public decimal footcurrwithouttaxamt { get; set; } = 0;
        public decimal footstdwithouttaxamt { get; set; } = 0;
        public decimal footcurrwithtaxamt { get; set; } = 0;
        public decimal footstdwithtaxamt { get; set; } = 0;
        public decimal footcurrbfvatamt { get; set; } = 0;
        public decimal footstdbfvatamt { get; set; } = 0;
        public decimal footcurrvatamt { get; set; } = 0;
        public decimal footstdvatamt { get; set; } = 0;
        public decimal footcurrnetamt { get; set; } = 0;
        public decimal footstdnetamt { get; set; } = 0;
        public string refdoctype { get; set; } = string.Empty;
        public string refdoccode { get; set; } = string.Empty;


        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Book Book { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual SaleMan SaleMan { get; set; }
        public virtual Currency Currency { get; set; }

        public virtual ICollection<OrderTrnD> OrderTrnDs {get;set; }

        //#region NotMapped
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
        //[Description("สถานะ")]
        //public string exp_status_name => GetStatusName();
        //private string GetStatusName()
        //{
        //    string strRetValue;
        //    switch (doc_status)
        //    {
        //        case ConstUtil.ORDER_DOC_STATUS.NEW:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "NEW" : "สร้างใหม่";
        //            break;
        //        case ConstUtil.ORDER_DOC_STATUS.ORDER:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "ORDER" : "สั่งขายแล้ว"; ;
        //            break;
        //        case ConstUtil.ORDER_DOC_STATUS.SOME:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "SOME" : "ตัดบางส่วน"; ;
        //            break;
        //        case ConstUtil.ORDER_DOC_STATUS.CANCEL:
        //            strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? "CANCEL" : "ยกเลิก"; ;
        //            break;
        //        default:
        //            strRetValue = "";
        //            break;
        //    }
        //    return strRetValue ?? "";
        //}

        //[NotMapped]
        //[Description("Doc.type(fullname)")]
        //public string ExpDocTypeFullName => this.ExpDocType?.ExpFullName ?? "";

        //[NotMapped]
        //[Description("Doc.type")]
        //public string ExpDocTypeName => this.ExpDocType?.ExpName ?? "";

        //private docType ExpDocType => _DB?.Set<docType>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.code == this.docType)?.FirstOrDefault() ?? null;

        //[NotMapped]
        //[Description("Book name1(Full name1)")]
        //public string ExpBookFullName => this.ExpBook?.ExpFullName ?? "";

        //[NotMapped]
        //[Description("Book name1")]
        //public string ExpBookName => this.ExpBook?.ExpName ?? "";

        //[NotMapped]
        //[Description("Book")]
        //public book ExpBook => _DB?.Set<book>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.CorpCode == this.CorpCode && c.branchCode == this.branchcode && c.docTypeCode == this.docType && c.code == this.bookCode)?.FirstOrDefault() ?? null;

        //[NotMapped]
        //[Description("customer")]
        //public customer ExpCustomer => GetCustomer();
        //private customer GetCustomer()
        //{
        //    if (_DB is null) { return null; }
        //    try
        //    {
        //        return _DB.Set<customer>().AsNoTrackingWithIdentityResolution().Where(c => c.code == custCode).FirstOrDefault() ?? null;
        //    }
        //    catch (exception ex)
        //    {
        //        LogHelper.gmEventLog(LogHelper.logtype.Error, LogHelper.gmGetErrMsg(ex), "orderTrnH", "GetCorpName()");
        //    }
        //    return null;
        //}

        //[NotMapped]
        //[Description("customer name1")]
        //public string exp_cust_name => ExpCustomer is not null ? (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpCustomer.name2 : ExpCustomer.name1 : "";

        //[NotMapped]
        //[Description("customer Branch No.")]
        //public string exp_cust_branch_no => ExpCustomer is not null ? ExpCustomer?.branchCode ?? "" : "";

        //[NotMapped]
        //[Description("customer Tax ID")]
        //public string exp_cust_taxID => ExpCustomer is not null ? ExpCustomer?.taxId ?? "" : "";

        //[NotMapped]
        //[Description("Address Office")]
        //public Address ExpOfficeAddess => GetOfficeAddess();
        //private Address GetOfficeAddess()
        //{
        //    if (_DB is null) { return null; }
        //    else if (ExpCustomer is null) { return null; }
        //    try
        //    {
        //        return _DB.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Office && c.refType == Address.enumreftype.customer && c.refID == ExpCustomer.LinkID).FirstOrDefault() ?? null;
        //    }
        //    catch (exception ex)
        //    {
        //        LogHelper.gmEventLog(LogHelper.logtype.Error, LogHelper.gmGetErrMsg(ex), "orderTrnH", "GetCorpName()");
        //    }
        //    return null;
        //}

        //[NotMapped]
        //[Description("customer Address")]
        //public string exp_cust_addr => ExpOfficeAddess?.Exp_full_address ?? "";

        //[NotMapped]
        //[Description("Address Delivery")]
        //public Address ExpDeliveryAddess => GetDeliveryAddess();
        //private Address GetDeliveryAddess()
        //{
        //    if (_DB is null) { return null; }
        //    else if (ExpCustomer is null) { return null; }
        //    try
        //    {
        //        return _DB.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Billing
        //                            && c.refType == Address.enumreftype.customer
        //                            && c.refID == ExpCustomer.LinkID).FirstOrDefault<Address>() ?? null;
        //    }
        //    catch (exception ex)
        //    {
        //        LogHelper.gmEventLog(LogHelper.logtype.Error, LogHelper.gmGetErrMsg(ex), "orderTrnH", "GetCorpName()");
        //    }
        //    return null;
        //}

        //[NotMapped]
        //[Description("customer Delivery Address")]
        //public string exp_cust_deli_addr => ExpDeliveryAddess?.Exp_full_address ?? "";

        //[NotMapped]
        //[Description("Currency")]
        //public currency ExpCurrency => GetCurrency();
        //private currency GetCurrency()
        //{
        //    if (_DB is null) { return null; }
        //    try
        //    {
        //        return _DB.Set<currency>().AsNoTrackingWithIdentityResolution().Where(c => c.CorpCode == this.CorpCode && c.code == this.currencyCode).FirstOrDefault() ?? null;
        //    }
        //    catch (exception ex)
        //    {
        //        LogHelper.gmEventLog(LogHelper.logtype.Error, LogHelper.gmGetErrMsg(ex), "orderTrnH", "GetCorpName()");
        //    }
        //    return default;
        //}
        //[NotMapped]
        //[Description("Currency Full name1")]
        //public string ExpCurrencyFullName => string.Format("{0}-{1}", this.ExpCurrency?.code ?? "", this.ExpCurrency?.ExpCurrencyName ?? "");

        //[NotMapped]
        //[Description("Currency name1")]
        //public string ExpCurrencyName => this.ExpCurrency?.ExpCurrencyName ?? "";

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
        //[Description("VAT")]
        //public vattype ExpVAT => _DB?.Set<vattype>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.code == vatCode && c.vat_type == 0)?.FirstOrDefault() ?? null;

        //[NotMapped]
        //[Description("Warehouse")]
        //public warehouse ExpWarehouse => _DB?.Set<warehouse>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.CorpCode == this.CorpCode && c.branchcode == this.branchcode && c.code == this.WarehouseCode)?.FirstOrDefault() ?? null;

        //#endregion





    }
}
