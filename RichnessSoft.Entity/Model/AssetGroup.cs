using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class AssetGroup : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? acchartid { get; set; }
        public int? Depreciateacchartid { get; set; }
        public int? DepreciateSumacchartid { get; set; }

        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }


        public virtual Company Company { get; set; }
        public virtual Acchart Acchart { get; set; }
        public virtual ICollection<Asset> Assets { get; set;}
    }
}
