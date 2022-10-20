using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class BaseReceiptTrnRef : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int bookid { get; set; } = default;
        public int SectId { get; set; } = default;
        public int DeptId { get; set; } = default;
        public int ProjId { get; set; } = default;
        public int PlanId { get; set; } = default;
        public string doctype { get; set; } 
        public string doctypeformula { get; set; } 
        public string receipttrnhlinkid { get; set; } = string.Empty;
        public string receipttrndlinkid { get; set; } = string.Empty;
        public string invtrnhlinkid { get; set; } = string.Empty;
        public string invtrndlinkid { get; set; } = string.Empty;
        public string docstatus { get; set; } 
        public string itemreftype { get; set; } 
        public string seq { get; set; } = "0000";
        public decimal rate { get; set; } = 0M;
        public decimal bfcurrvatamount { get; set; } = 0M;
        public decimal bfstdvatamount { get; set; } = 0M;
        public decimal vatcurramount { get; set; } = 0M;
        public decimal vatstdamount { get; set; } = 0M;

        //#region Expression Field
        //[NotMapped]
        //[Description("Invoice Detail")]
        //public InvTrnD ExpInvoiceItem => GetInvoiceItem();
        //private InvTrnD GetInvoiceItem() => _DB?.Set<InvTrnD>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == InvTrnDLinkID)?.FirstOrDefault() ?? null;

        //[NotMapped]
        //[Description("Product/Set")]
        //public string ExpInvoiceItempstype => ExpInvoiceItem?.pstype ?? "";

        //[NotMapped]
        //[Description("Product type")]
        //public string ExpInvoiceItemProductType => ExpInvoiceItem?.ProdTypeCode ?? "";

        //[NotMapped]
        //[Description("Product")]
        //public string ExpInvoiceItemProduct => ExpInvoiceItem?.ExpProductFullName ?? "";

        //[NotMapped]
        //[Description("qty : Unit")]
        //public string ExpInvoiceItemQtyUnit => ExpInvoiceItem.ExpQtyUnit ?? "";

        //[NotMapped]
        //[Description("price")]
        //public decimal ExpInvoiceItemPrice => ExpInvoiceItem?.price ?? 0M;

        //[NotMapped]
        //[Description("pricek")]
        //public decimal ExpInvoiceItemPriceK => ExpInvoiceItem?.pricek ?? 0M;

        //[NotMapped]
        //[Description("discount")]
        //public decimal ExpInvoiceItemDiscount => ExpInvoiceItem?.discamount ?? 0M;

        //[NotMapped]
        //[Description("DiscountK")]
        //public decimal ExpInvoiceItemDiscountK => ExpInvoiceItem?.discamountk ?? 0M;

        //[NotMapped]
        //[Description("bfvatamount")]
        //public decimal ExpInvoiceItemBfVatAmount => ExpInvoiceItem?.bfvatamount ?? 0M;

        //[NotMapped]
        //[Description("bfvatamountk")]
        //public decimal ExpInvoiceItemBfVatAmountK => ExpInvoiceItem?.bfvatamountk ?? 0M;

        //[NotMapped]
        //[Description("vatamount")]
        //public decimal ExpInvoiceItemVatAmount => ExpInvoiceItem?.vatamount ?? 0M;

        //[NotMapped]
        //[Description("vatamountk")]
        //public decimal ExpInvoiceItemVatAmountK => ExpInvoiceItem?.vatamountk ?? 0M;

        //[NotMapped]
        //[Description("amount")]
        //public decimal ExpInvoiceItemAmount => ExpInvoiceItem?.amount ?? 0M;

        //[NotMapped]
        //[Description("amountk")]
        //public decimal ExpInvoiceItemAmountK => ExpInvoiceItem?.amountk ?? 0M;

        //[NotMapped]
        //[Description("type VAT")]
        //public string ExpInvoiceItemTypeVATName => ExpInvoiceItem?.ExpTypeVATName ?? "";

        //[NotMapped]
        //[Description("Net amount(Currency)")]
        //public decimal ExpNetCurrAmount => UtilHelper.gmRound(decimal.Add(this.bfcurrvatamount, this.vatcurramount), gbVar.GnDecimalPlaces, MidpointRounding.AwayFromZero);

        //[NotMapped]
        //[Description("Net amount(Standard)")]
        //public decimal ExpNetStdAmount => UtilHelper.gmRound(decimal.Add(this.bfstdvatamount, this.vatstdamount), gbVar.GnDecimalPlaces, MidpointRounding.AwayFromZero);

        //#endregion
        //private string GetDebuggerDisplay()
        //{
        //    return ToString();











        }
}
