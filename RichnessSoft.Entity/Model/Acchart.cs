using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Acchart : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string tag { get; set; }
        public string tag2 { get; set; }
        public int level { get; set; }
        public int isfixed { get; set; }
        public string group { get; set; }
        public string active { get; set; }
        public Nullable<DateTime> inactivedate { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<AccRoleTemplateD> AccRoleTemplateDs { get; set; }
        public virtual ICollection<Asset> Assets { get;set; }
        public virtual ICollection<AssetGroup> AssetGroups { get; set; }
        public virtual ICollection<BookBank> BookBanks { get; set; }
        public virtual ICollection<CustGroup> CustGroups { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }

        #region Expression Field
        [NotMapped]
        public string ExpFullName => string.Format("{0}-{1}", code, name1);
        [NotMapped]
        public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1;
        #endregion

    }
}
