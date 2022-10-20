using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class ProductGroup : BaseModel
    {
        public int companyid { get; set; } = default;
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }
        public int? accbuycashid { get; set; } = default;
        public int? accbuycreditid { get; set; } = default;
        public int? accsalecashid { get; set; } = default;
        public int? accsalecreditid { get; set; } = default;
        public int? acccostid { get; set; } = default;
        public int? accstockid { get; set; }
        public int? AccWorkInProcessId { get; set; }
        public int? accsuppliedusedid { get; set; }
        public int? accmaterialrequistionid { get; set; }
        public int? budgetgroupid { get; set; } = default;
        public int? acccngoodid { get; set; } = default;
        public int? acccnpriceid { get; set; } = default;
        public int? accincreasedebtreturnincreaseid { get; set; } = default;
        public int? accincreasedebtpriceincreaseid { get; set; } = default;


        public virtual Company Company { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Service> Services { get; set; }

        //#region Expression Field
        //[NotMapped]
        //[Description("Product group name1(Full)")]
        //public string ExpFullName => string.Format("{0}-{1}", this.code, this.ExpName);

        //[NotMapped]
        //[Description("Product group name1")]
        //public string ExpName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? name2 ?? "" : name1 ?? "";
        //#endregion










    }
}
