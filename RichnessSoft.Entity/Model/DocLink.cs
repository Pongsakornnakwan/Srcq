using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class DocLink : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int? bookid { get; set; } = default;
        public int? sectionid { get; set; } = default;
        public int? departmentid { get; set; } = default;
        public int? projectid { get; set; } = default;
        public int? plansld { get; set; } = default;
        public int? MasterType { get; set; } = default;
        public int? MasterLinkId { get; set; } = default;
        public int? MasterItemLinkId { get; set; } = default;
        public int childtype { get; set; } = default;
        public int childlinkid { get; set; } = default;
        public int childitemlinkid { get; set; } = default;
        public string seq { get; set; } = "0000";
        public decimal qty { get; set; } = 0;
        public decimal amount { get; set; } = 0;


        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Book Book { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
    }
}
