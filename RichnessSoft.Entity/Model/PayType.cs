using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class PayType : BaseModel
    {
        public string code { get; set; } = string.Empty;
        public string name1 { get; set; } = string.Empty;
        public string name2 { get; set; } = string.Empty;
        public string isdeposit { get; set; } 
        public string iswithdraw { get; set; } 
        public string group { get; set; } = string.Empty;
        public string inout { get; set; } 
        public string active { get; set; } 
        public DateTime? inactivedate { get; set; } = null;

        //#region Expression Field
        //[NotMapped]
        //[Description("ชื่อประเภทการจ่าย")]
        //public string ExpFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? name2 : name1);
        //#endregion




    }
}
