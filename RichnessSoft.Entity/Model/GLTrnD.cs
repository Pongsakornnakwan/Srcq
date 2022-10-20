using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class GLTrnD : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int accbookid { get; set; } = default;
        public int? sectionid { get; set; } = default;
        public int? departmentid { get; set; } = default;
        public int? projectid { get; set; } = default;
        public int? plansld { get; set; } = default;
        public int acchartid { get; set; } = default;
        public int gltrnhid { get; set; } = default;


        public string doctype { get; set; } 
        public string group { get; set; } = string.Empty;
        public string detail01 { get; set; } = string.Empty;
        public string detail02 { get; set; } = string.Empty;
        public string detail03 { get; set; } = string.Empty;
        public string detail04 { get; set; } = string.Empty;
        public string detail05 { get; set; } = string.Empty;
        public decimal creditamt { get; set; } = 0M;
        public decimal debitamt { get; set; } = 0M;
        public int seq { get; set; } = default;


        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual AccBook AccBook { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
        public virtual GLTrnH GLTrnH { get; set; }


        //#region Expression Field
        //[NotMapped]
        //[Description("Diff")]
        //public decimal Exp_Diff_Amt => decimal.Subtract(creditamt, debitamt);

        //[NotMapped]
        //public string AccRoleCode { get; set; } = "";

        ///// <summary>
        /////  // > 0 = Dr, < 0 CR
        ///// </summary>
        //[NotMapped]
        //public decimal amount { get; set; } = 0;


        //#endregion






    }
}
