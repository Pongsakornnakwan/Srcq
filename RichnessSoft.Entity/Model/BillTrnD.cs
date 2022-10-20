using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class BillTrnD : BaseModel
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
        public int? billtrnhid { get; set; } = default;

        public string doctype { get; set; }
        public string receipttrnhid { get; set; } = string.Empty;
        public DateTime? docdate { get; set; } = DateTime.UtcNow.Date;
        public string docstatus { get; set; }
        //public string CustSuppCode { get; set; } = string.Empty;
        //public string IsCust { get; set; } 
        public int seq { get; set; } = default;
        //public string RefDocHeadLinkID { get; set; } = string.Empty;
        //public string refdocheaddoctype { get; set; } = string.Empty;
        //public string RefDocItemLinkID { get; set; } = string.Empty;
        public string refinvoicelinkid { get; set; } = string.Empty;
        public string refinvoicedoctype { get; set; } = string.Empty;
        public string refinvoicedocgroup { get; set; } = string.Empty;
        public enum enumPartialType { HEAD = 1, ITEM = 2 };
        public enumPartialType partialtype { get; set; } = enumPartialType.HEAD;
        public decimal amount { get; set; } = 0M;
        public decimal payamt { get; set; } = 0M;
        public decimal depositamt { get; set; } = 0M;
        public decimal whtamt { get; set; } = 0M;

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
        public virtual BillTrnH BillTrnH{ get; set; }

        //#region Expression Field
        //[NotMapped]
        //[Description("Invoice")]
        //public InvTrnH ExpInvoice => GetInvoice();
        //private InvTrnH GetInvoice() => _DB?.Set<InvTrnH>().AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == refinvoicelinkid && c.doctype == refinvoicedoctype)?.FirstOrDefault() ?? null;
        //[NotMapped]
        //[Description("Invoice date")]
        //public DateTime? ExpInvoiceDate => ExpInvoice?.docdate ?? null;

        //[NotMapped]
        //[Description("Invoice code")]
        //public string ExpInvoiceCode => ExpInvoice?.doccode ?? "";

        //[NotMapped]
        //[Description("Invoice Ref.No")]
        //public string ExpInvoiceRefNo => ExpInvoice?.docrefnumber ?? "";

        //[NotMapped]
        //[Description("Invoice Due date")]
        //public DateTime? ExpInvoiceDueDate => ExpInvoice?.docduedate ?? null;

        //[NotMapped]
        //[Description("Invoice amount(Currency)")]
        //public decimal ExpInvoiceCurrNetAmount => ExpInvoice?.footcurrnetamt ?? 0M;

        //[NotMapped]
        //[Description("Invoice amount(Standard)")]
        //public decimal ExpInvoiceStdNetAmount => ExpInvoice?.footstdnetamt ?? 0M;

        //[NotMapped]
        //[Description("Invoice Deposit amount")]
        //public decimal ExpInvoiceDepositAmount => ExpInvoice?.footdepositamt ?? 0M;
        ///// <summary>
        ///// มูลค่าค้างชำระ
        ///// </summary>
        //[NotMapped]
        //[Display(name1 = "Unpaid amount")]
        //[Column(TypeName = "decimal(18,2)")]
        //[DefaultValue(0)]
        //public decimal ExpUnpaidAmt { get; set; } = 0M;
        //#endregion
        //private string GetDebuggerDisplay()
        //{
        //    return ToString();




    }
}
