using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class BookBank : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? bankid { get; set; }
        public int? bankbranchid { get; set; }
        public int? acchartid { get; set; }
        public int? recivecqacchartid { get; set; }
        public int? paymentcqacchartid { get; set; }
        public int? depositbookid { get; set; }
        public int? revertcqacchartid { get; set; }
        public int? trandferacchartid { get; set; }

        public string code { get; set; }
        public string bookno { get; set; } = "";
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string sname1 { get; set; }
        public string sname2 { get; set; }

        public string bookbanktype { get; set; }
        public Nullable<DateTime> opendate { get; set; }
        public decimal balanceamount { get; set; } = 0;
        public Nullable<DateTime> blancedate { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        public virtual Company Company { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual BankBranch BankBranch { get; set; }
        public virtual Acchart Acchart { get; set; }




        #region Expression Field
        [NotMapped]
        public string ExpBookBankTypeName => GetBookBankType();
        private string GetBookBankType()
        {
            string strRetValue = "";
            if (string.IsNullOrEmpty(bookbanktype)) { return strRetValue; }
            switch (bookbanktype)
            {
                case SysDef.BookBank_Type.gc_BANKACCT_TYPE_CURRENT:
                    strRetValue = (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? SysDef.BookBank_Type.gc_BANKACCT_TYPE_NAME_CURRENT2 : SysDef.BookBank_Type.gc_BANKACCT_TYPE_NAME_CURRENT;
                    break;
                case SysDef.BookBank_Type.gc_BANKACCT_TYPE_FIX:
                    strRetValue = (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? SysDef.BookBank_Type.gc_BANKACCT_TYPE_NAME_FIX2 : SysDef.BookBank_Type.gc_BANKACCT_TYPE_NAME_FIX;
                    break;
                case SysDef.BookBank_Type.gc_BANKACCT_TYPE_GUARANTEE:
                    strRetValue = (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? SysDef.BookBank_Type.gc_BANKACCT_TYPE_NAME_GUARANTEE2 : SysDef.BookBank_Type.gc_BANKACCT_TYPE_NAME_GUARANTEE;
                    break;
                case SysDef.BookBank_Type.gc_BANKACCT_TYPE_SAVING:
                    strRetValue = (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? SysDef.BookBank_Type.gc_BANKACCT_TYPE_NAME_SAVING2 : SysDef.BookBank_Type.gc_BANKACCT_TYPE_NAME_SAVING;
                    break;
                default:
                    strRetValue = "";
                    break;
            }
            return strRetValue;
        }

        [NotMapped]
        public string ExpBookBankFullName => string.Format("{0} {1} {2}", code ?? "", ExpBookBankTypeName ?? "", name1 ?? "");
        #endregion



    }
}
