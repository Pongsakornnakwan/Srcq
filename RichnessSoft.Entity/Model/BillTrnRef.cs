using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class BillTrnRef : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int? bookid { get; set; } = default;
        public int? sectionid { get; set; } = default;
        public int? departmentid { get; set; } = default;
        public int? projectid { get; set; } = default;
        public int? plansld { get; set; } = default;
        public int? DocType { get; set; }= default;
        public int? ReceiptTrnHId { get; set; } = default;
        public int? ReceiptTrnDId { get; set; } = default;
        public int? invtrnhid { get; set; } = default;
        public int? InvTrnDId { get; set; } = default;

        public string docstatus { get; set; }
        public string itemreftype { get; set; }
        public int seq { get; set; } = default;
        public decimal rate { get; set; } = 0M;
        public decimal bfcurrvatamount { get; set; } = 0M;
        public decimal bfstdvatamount { get; set; } = 0M;
        public decimal vatcurramount { get; set; } = 0M;
        public decimal vatstdamount { get; set; } = 0M;

        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Book Book { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
    }
}
