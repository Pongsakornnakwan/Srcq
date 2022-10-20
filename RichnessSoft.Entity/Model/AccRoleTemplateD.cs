using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class AccRoleTemplateD : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? acchartid { get; set; } = default;
        public int? accroletemplatehid { get; set; } = default;

        public string accrolecode { get; set; } = default;
        public string accroledesc { get; set; } = default;
        public string accroledesc2 { get; set; } = default;

        public virtual Acchart Acchart { get; set; }
        public virtual AccRoleTemplateH AccRoleTemplateH { get; set; }
    }
}
