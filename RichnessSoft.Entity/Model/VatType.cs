using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class VatType : BaseModel
    {
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public decimal rate { get; set; }
        public Int32 vat_type { get; set; }
        public string active { get; set; } 
        public Nullable<DateTime> inactivedate { get; set; }

        //#region Expression Field
        //[NotMapped]
        //[Description("VAT Full name1")]
        //public string ExpFullName => string.Format("{0}-{1}", code, ExpName);

        //[NotMapped]
        //[Description("VAT name1")]
        //public string ExpName => (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? name2 : name1;
        //#endregion










    }
}
