using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Payment : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int? gltrnhid { get; set; } = default;
        public int? bankid { get; set; } = default;
        public int? bankbranchid { get; set; } = default;
        public int? customerid { get; set; } = default;
        public int? vendorid { get; set; } = default;
        public int? custvendorid { get; set; } = default;
        public string systype { get; set; } 
        public string depositwithdraw { get; set; } 
        public string paytype { get; set; } 
        public string paygroup { get; set; } 
        public DateTime? date { get; set; } = DateTime.Now.Date;
        public DateTime? tobankdate { get; set; } = DateTime.Now.Date;
        public DateTime? duedate { get; set; } = DateTime.Now.Date;
        public string code { get; set; } = string.Empty;
        public string payrecv { get; set; } = string.Empty;
        public string payrecv2 { get; set; } = string.Empty;
        public string paynameincheque { get; set; } = string.Empty;
        public string paynameincheque2 { get; set; } = string.Empty;
        /// <summary>
        /// มูลค่าในเช็ค
        /// </summary>
        public decimal amount { get; set; } = 0M;
        /// <summary>
        /// ชำระสำหรับเอกสารนี้
        /// </summary>
        public decimal payamount { get; set; } = 0M;
        public string acpayee { get; set; } 
        public string orderbearer { get; set; } 
        public string stat { get; set; } 
        public string step { get; set; } 
        public string inout { get; set; } 
        public decimal returnattime { get; set; } = 0M;
        public DateTime? paydate { get; set; } = null;
        public DateTime? passdate { get; set; } = null;
        public DateTime? returndate { get; set; } = null;
        public string chequereturncode { get; set; } = string.Empty;
        public string remark01 { get; set; } = string.Empty;
        public int seq { get; set; } = 0;

        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual GLTrnH GLTrnH { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual BankBranch BankBranch { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<PayInTrnD> PayInTrnDs { get; set; }

        //#region Expression Field

        //[NotMapped]
        //[Display(name1 = "CuttPayAnotherBillAmt")]
        //[Description("ตัดชำระใบเสร็จอื่นแล้ว")]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal CuttPayAnotherBillAmt { get; set; } = 0M;

        //[NotMapped]
        //[Display(name1 = "BalanceAmt")]
        //[Description("คงเหลือ")]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal BalanceAmt { get; set; } = 0M;

        //[NotMapped]
        //[Description("systype name1")]
        //public string ExpSysTypeName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpSysType?.name2 ?? "" : ExpSysType?.name1 ?? "";

        //[NotMapped]
        //[Description("systype")]
        //public ConstUtilBase.cGLRefSystem ExpSysType => GetSysType();
        //private ConstUtilBase.cGLRefSystem GetSysType()
        //{
        //    return ConstUtil.goListSystem?.Where(c => c.code == systype)?.FirstOrDefault() ?? null;
        //}

        //[NotMapped]
        //[Description("depositwithdraw name1")]
        //public string ExpDepositWithdrawName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpDepositWithdraw?.name2 ?? "" : ExpDepositWithdraw?.name1 ?? "";

        //[NotMapped]
        //[Description("depositwithdraw")]
        //public ConstUtilBase.cDepositWithdraw ExpDepositWithdraw => GetDepositWithdrawe();
        //private ConstUtilBase.cDepositWithdraw GetDepositWithdrawe()
        //{
        //    return ConstUtil.goListDepositWithdraw?.Where(c => c.code == depositwithdraw)?.FirstOrDefault() ?? null;
        //}

        //[NotMapped]
        //[Description("paytype name1")]
        //public string ExpPayTypeName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpPayType?.name2 ?? "" : ExpPayType?.name1 ?? "";

        //[NotMapped]
        //[Description("paytype")]
        //public paytype ExpPayType => GetPayType();
        //private paytype GetPayType()
        //{
        //    return dbContext is null
        //        ? null
        //        : dbContext.Set<paytype>().AsNoTrackingWithIdentityResolution().Where(c => c.code == PayTypeCode).FirstOrDefault() ?? null;
        //}

        //[NotMapped]
        //[Description("customer")]
        //public customer ExpCustomer => GetCustomer();
        //private customer GetCustomer()
        //{
        //    if (systype == ConstUtil.SYSTEM.SALE)
        //    {
        //        return dbContext is null
        //        ? null
        //        : dbContext.Set<customer>().AsNoTrackingWithIdentityResolution().Where(c => c.code == CustVendorCode).FirstOrDefault() ?? null;
        //    }
        //    return null;
        //}

        //[NotMapped]
        //[Description("vendor")]
        //public vendor ExpVendor => GetVendor();
        //private vendor GetVendor()
        //{
        //    if (systype == ConstUtil.SYSTEM.PURCHASE)
        //    {
        //        return dbContext is null
        //        ? null
        //        : dbContext.Set<vendor>().AsNoTrackingWithIdentityResolution().Where(c => c.code == CustVendorCode).FirstOrDefault() ?? null;
        //    }
        //    return null;
        //}

        //[NotMapped]
        //[Description("payrecv")]
        //public string ExpPayRecv => GetPayRecv("th-TH");

        //[NotMapped]
        //[Description("payrecv2")]
        //public string ExpPayRecv2 => GetPayRecv("en-US");

        //private string GetPayRecv(string strLang = "en-US")
        //{
        //    if (systype == ConstUtil.SYSTEM.SALE)
        //    {
        //        return strLang == "en-US" ? ExpCustomer?.name2 ?? "" : ExpCustomer?.name1 ?? "";
        //    }
        //    else if (systype == ConstUtil.SYSTEM.PURCHASE)
        //    {
        //        return strLang == "en-US" ? ExpVendor?.name2 ?? "" : ExpVendor?.name1 ?? "";
        //    }
        //    return string.Empty;
        //}

        //[NotMapped]
        //[Description("Bank name1")]
        //public string ExpBankName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpBank?.name2 ?? "" : ExpBank?.name1 ?? "";

        //[NotMapped]
        //[Description("Bank")]
        //public bank ExpBank => GetBank();

        //private bank GetBank()
        //{
        //    return dbContext is null
        //        ? null
        //        : dbContext.Set<bank>().AsNoTrackingWithIdentityResolution().Where(c => c.code == bankcode).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Bank Branch name1")]
        //public string ExpBankBranchName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpBankBranch?.name2 ?? "" : ExpBankBranch?.name1 ?? "";

        //[NotMapped]
        //[Description("Bank Branch")]
        //public bankBranch ExpBankBranch => GetBankBranch();

        //private bankBranch GetBankBranch()
        //{
        //    return dbContext is null
        //        ? null
        //        : dbContext.Set<bankBranch>().AsNoTrackingWithIdentityResolution().Where(c => c.code == BankBranchCode).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Book Bank name1")]
        //public string ExpBookBankName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpBookBank?.name2 ?? "" : ExpBookBank?.name1 ?? "";

        //[NotMapped]
        //[Description("Bank Branch")]
        //public bookBank ExpBookBank => GetExpBookBank();

        //private bookBank GetExpBookBank()
        //{
        //    return dbContext is null
        //        ? null
        //        : dbContext.Set<bookBank>().AsNoTrackingWithIdentityResolution().Where(c => c.code == BookBankCode).FirstOrDefault() ?? null;
        //}

        //[NotMapped]
        //[Description("paynameincheque")]
        //public string ExpPayNameInCheque => (gbVar.UserLang?.name1 ?? "en-US") == "en-US" ? this.paynameincheque2 : this.paynameincheque;


        //[NotMapped]
        //[Description("payrecv")]
        //public string ExpPayRecvFull => (gbVar.UserLang?.name1 ?? "en-US") == "en-US" ? this.payrecv2 : this.payrecv;
        //#endregion








    }
}
