using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class GLTrnH : BaseModel
    {

        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int accbookid { get; set; } = default;
        public int sectionid { get; set; } = default;
        public int departmentid { get; set; } = default;
        public int projectid { get; set; } = default;
        public int plansld { get; set; } = default;

        public string freqacct { get; set; } = string.Empty;
        public string doctype { get; set; } 
        public string source { get; set; } 
        public string detail01 { get; set; } = string.Empty;
        public string detail02 { get; set; } = string.Empty;
        public string detail03 { get; set; } = string.Empty;
        public string detail04 { get; set; } = string.Empty;
        public string detail05 { get; set; } = string.Empty;
        public DateTime? docdate { get; set; } = DateTime.Now.Date;
        public string doccode { get; set; } = string.Empty;
        public string approvedby { get; set; } = string.Empty;
        public DateTime? approveddate { get; set; } = null;
        public string status { get; set; } 
        public string islock { get; set; }
        public decimal debitamt { get; set; } = 0M;
        public decimal creditamt { get; set; } = 0M;
        public string bookkeeping { get; set; }

        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual AccBook AccBook { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }

        public virtual ICollection<GLTrnD> GLTrnDs { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<InvTrnH> InvTrnHs { get; set; }

        //#region Expression Field
        //[NotMapped]
        //[Description("Diff")]
        //public decimal Exp_Diff_Amt => decimal.Subtract(creditamt, debitamt);

        //[NotMapped]
        //[Description("Detail")]
        //public string Exp_Detail => string.Format("{0}{1}{2}{3}{4}", this.detail01, this.detail02, this.detail03, this.detail04, this.detail05);


        //[NotMapped]
        //[Description("Company")]
        //public company ExpCorp => GetCorp();
        //private company GetCorp()
        //{
        //    return this._context?.Set<company>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.code == this.CorpCode)?.FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Company Full name1")]
        //public string ExpCorpFullName => this.ExpCorp?.ExpCompanyFullName ?? "";

        //[NotMapped]
        //[Description("Company name1")]
        //public string ExpCorpName => this.ExpCorp?.ExpCompanyName ?? "";

        //[NotMapped]
        //[Description("Branch")]
        //public branch ExpBranch => GetBranch();
        //private branch GetBranch()
        //{
        //    return this._context?.Set<branch>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.CorpCode == this.CorpCode && c.code == this.branchcode)?.FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Branch Full name1")]
        //public string ExpBranchFullName => this.ExpBranch?.ExpFullName ?? "";

        //[NotMapped]
        //[Description("Branch name1")]
        //public string ExpBranchName => this.ExpBranch?.ExpName ?? "";


        //[NotMapped]
        //[Description("doctype")]
        //public docType ExpDocType => GetDocType();
        //private docType GetDocType()
        //{
        //    return this._context?.Set<docType>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.code == this.doctype && c.doc_group == SysDef.DOC_GROUP.GL)?.FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("doctype Full name1")]
        //public string ExpDocTypeFullName => this.ExpDocType?.ExpFullName ?? "";

        //[NotMapped]
        //[Description("doctype name1")]
        //public string ExpDocTypeName => this.ExpDocType?.ExpName ?? "";

        //#endregion






    }
}
