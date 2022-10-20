using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Shelf : BaseModel
    {
        public int companyid { get; set; } = default;
        public int warehouseid { get; set; }

        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public decimal width { get; set; }
        public decimal length { get; set; }
        public decimal height { get; set; }

        public Company Company { get; set; }
        public Warehouse Warehouse { get; set; }

        #region Expression Field
        [NotMapped]
        //[Description("Shipping Full name1")]
        public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1);
        [NotMapped]
        //[Description("Shipping name1")]
        public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1;
        #endregion




    }
}
