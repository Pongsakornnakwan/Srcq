using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Bilpay : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? branchid { get; set; } = default;
        public int? gltrnhid { get; set; } = default;
        public int? masterid { get; set; } = default;
        public string doctype { get; set; } = string.Empty;
        public int? paymentid { get; set; } = default;

        public DateTime? date { get; set; } = DateTime.Now.Date;
        //public string CustSuppCode { get; set; } = string.Empty;
        //public string IsCust { get; set; } 
        public string status { get; set; } 
        public decimal amount { get; set; } = 0M;
        public int seq { get; set; } = default;

        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }

        //#region Expression Field

        //[NotMapped]
        //[Display(name1 = "amount")]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal ExpTotalAmt { get; set; } = 0;

        //[NotMapped]
        //[Display(name1 = "Paid Amt")]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal ExpPaidAmt { get; set; } = 0;

        //[NotMapped]
        //[Display(name1 = "Rest Amt")]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal ExpRestAmt { get; set; } = 0;

        //[NotMapped]
        //[Display(name1 = "Pay Amt")]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal ExpPayAmt { get; set; } = 0;

        //[NotMapped]
        //[Display(name1 = "Payment")]
        //public Payment ExpPayment => _context?.Set<Payment>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.LinkID == this.PaymentLinkID)?.FirstOrDefault() ?? null;

        //[NotMapped]
        //[Display(name1 = "Payment systype")]
        //public string ExpPaymentSysType { get; set; } = string.Empty;

        //[NotMapped]
        //[Display(name1 = "Payment paytype")]
        //public string ExpPaymentPayType { get; set; } = string.Empty;

        //[NotMapped]
        //[Display(name1 = "Payment depositwithdraw")]
        //public string ExpPaymentDepositWithdraw { get; set; } = string.Empty;

        //[NotMapped]
        //[Display(name1 = "Payment date")]
        //public DateTime? ExpPaymentDate { get; set; } = null;

        //[NotMapped]
        //[Display(name1 = "Payment code")]
        //public string ExpPaymentCode { get; set; } = string.Empty;

        //[NotMapped]
        //[Display(name1 = "Payment tobankdate")]
        //public DateTime? ExpPaymentToBankDate { get; set; } = null;

        //[NotMapped]
        //[Display(name1 = "Payment duedate")]
        //public DateTime? ExpPaymentDueDate { get; set; } = null;

        //[NotMapped]
        //[Display(name1 = "Payment payrecv")]
        //public string ExpPaymentPayRecv { get; set; } = string.Empty;

        //[NotMapped]
        //[Display(name1 = "Payment paynameincheque")]
        //public string ExpPaymentPayNameInCheque { get; set; } = string.Empty;

        //[NotMapped]
        //[Display(name1 = "Payment bankcode")]
        //public string ExpPaymentBankCode { get; set; } = string.Empty;

        //[NotMapped]
        //[Display(name1 = "Payment BankBranchCode")]
        //public string ExpPaymentBankBranchCode { get; set; } = string.Empty;

        //#endregion











    }
}
