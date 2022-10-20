using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class DocType : BaseModel
    {
        public string system { get; set; }
        public string menu { get; set; }
        public string type { get; set; }
        public string doc_group { get; set; }
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string vat { get; set; }
        public string cash { get; set; }
        public string service { get; set; }
        public string tax_refund { get; set; }

        #region Expression Field
        [NotMapped]
        [Description("Full name1")]
        public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1);
        [NotMapped]
        [Description("name1")]
        public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1;
        #endregion









    }
}
