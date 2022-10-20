using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class WhTrnD : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int bookid { get; set; } = default;
        public int? sectionid { get; set; } = default;
        public int? departmentid { get; set; } = default;
        public int? projectid { get; set; } = default;
        public int? plansld { get; set; } = default;
        public int? whtrnhid { get; set; } = default;


        public string doctype { get; set; } = string.Empty;
        public string docstatus { get; set; } 
        public int seq { get; set; } = default;
        public string incometype { get; set; } = string.Empty;
        public decimal payamount { get; set; } = 0M;
        public decimal taxrate { get; set; } = 0M;
        public decimal taxvalue { get; set; } = 0M;
        public decimal valueaftertax { get; set; } = 0M;

        //#region ExpressionField
        //[NotMapped]
        //[Description("Income type")]
        //public vattype ExpIncomeType => GetIncomeType();
        //private vattype GetIncomeType()
        //{
        //    return Context is null
        //        ? null
        //        : Context.Set<vattype>().AsNoTrackingWithIdentityResolution().Where(c => c.code == incometype && c.vat_type == 2).FirstOrDefault<vattype>() ?? null;
        //}
        //[NotMapped]
        //[Description("Income type name1")]
        //public string ExpIncomeTypeName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpIncomeType?.name2 ?? "" : ExpIncomeType?.name1 ?? "";

        //private string GetDebuggerDisplay()
        //{
        //    return ToString();
        //}
        //#endregion


        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Book Book { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
        public virtual WhTrnH WhTrnH { get; set; }

    }
}
