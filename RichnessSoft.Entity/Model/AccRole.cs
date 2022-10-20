using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class AccRole : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string description { get; set; }
        public string sysvariable { get; set; }
        public int? acchartid { get; set; }
        public string acchart_code { get; set; }
        public virtual Company Company { get; set; }
    }
}
