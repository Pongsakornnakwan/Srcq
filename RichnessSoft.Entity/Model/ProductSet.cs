using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class ProductSet : BaseModel
    {
        public int companyid { get; set; } = default;
        public int umid { get; set; }

        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string sname1 { get; set; }
        public string sname2 { get; set; }
        public string prodtype { get; set; }
        public string setprint { get; set; }
        public string vattype { get; set; }
        public string remark { get; set; }
        public string remark2 { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        public virtual Company Company { get; set; }
        //public virtual UM Um { get; set; }
        public virtual ICollection<ProductSetDetail> ProductSetDetails { get; set; }

        //#region Expression Field
        //[NotMapped]
        //[Description("Full name1")]
        //public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? name2 : name1);

        //[NotMapped]
        //[Description("name1")]
        //public string ExpName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? name2 : name1;

        //[NotMapped]
        //[Description("Product type")]
        //public prodtype ExpProductType => GetProductType();

        //private prodtype GetProductType()
        //{
        //    return _DB?.Set<prodtype>()?.AsNoTrackingWithIdentityResolution().Where(c => c.code == pdTypeCode)?.FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("Product type Full name1")]
        //public string ExpProductTypeFullName => string.Format("{0}-{1}", pdTypeCode, (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpProductType?.name2 ?? "" : ExpProductType?.name1 ?? "");
        //[NotMapped]
        //[Description("Product type name1")]
        //public string ExpProductTypeName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? ExpProductType?.name2 ?? "" : ExpProductType?.name1 ?? "";
        //#endregion







    }
}
