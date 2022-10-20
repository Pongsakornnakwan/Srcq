using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class AccBook : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<GLTrnD> GLTrnDs { get; set; }
        public virtual ICollection<GLTrnH> GLTrnHs { get; set; }

        #region Expression Field
        [NotMapped]
        public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1);
        #endregion

    }
}
