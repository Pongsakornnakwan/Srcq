using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class GLTrnRef : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int Accbookid { get; set; } = default;
        public int sectionid { get; set; } = default;
        public int departmentid { get; set; } = default;
        public int projectid { get; set; } = default;
        public int plansld { get; set; } = default;
        public string gltrnhid { get; set; }


        public string doctype { get; set; } = string.Empty;
        public string systype { get; set; } = string.Empty;
        public DateTime? docdate { get; set; }
        public int docrefid { get; set; }
        public string docrefcode { get; set; } = string.Empty;
        public string docrefno { get; set; } = string.Empty;
        public string docrefcustcode { get; set; } = string.Empty;
        public string docrefvalueaddedtax { get; set; } 
        public string docrefvatcode { get; set; } = string.Empty;
        public decimal docrefvatrate { get; set; } = 0M;
        public decimal docrefbfvatamt { get; set; } = 0M;
        public decimal docrefvatamt { get; set; } = 0M;
        public decimal docrefnetamt { get; set; } = 0M;
        public string seq { get; set; } = "0000";
        public string taxseq { get; set; } = string.Empty;
        public DateTime? taxincrease { get; set; }
        public string taxnameonreport { get; set; } = string.Empty;
        public string taxid { get; set; } = string.Empty;
        public string taxbranchno { get; set; } = string.Empty;
        public string taxbranchname { get; set; } = string.Empty;
        public string taxrefund { get; set; } = "Y";
        public decimal taxrefundpercen { get; set; } = 0M;
        public decimal taxrefundamt { get; set; } = 0M;
        public string taxdue { get; set; } = "Y";

        public virtual Company Company { get; set; }

        //#region Expression Field
        //[NotMapped]
        //[Description("customer")]
        //public customer ExpCustomer => GetCustomer();
        //private customer GetCustomer()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB.Set<customer>().AsNoTrackingWithIdentityResolution().Where(c => c.code == docrefcustcode).FirstOrDefault() ?? null;
        //}
        //[NotMapped]
        //[Description("vendor")]
        //public vendor ExpVendor => GetVendor();
        //private vendor GetVendor()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB.Set<vendor>().AsNoTrackingWithIdentityResolution().Where(c => c.code == docrefcustcode).FirstOrDefault() ?? null;
        //}

        //[NotMapped]
        //[Description("Book")]
        //public book ExpBook => GetBook();
        //private book GetBook()
        //{
        //    return _DB?.Set<book>()?.AsNoTrackingWithIdentityResolution().Where(c => c.code == BookCode)?.FirstOrDefault() ?? null;
        //}

        //[NotMapped]
        //[Description("VAT")]
        //public vattype ExpVAT => GetVAT();
        //private vattype GetVAT()
        //{
        //    if (_DB is null) { return null; }
        //    return _DB.Set<vattype>().AsNoTrackingWithIdentityResolution().Where(c => c.code == docrefvatcode && c.vat_type == 0).FirstOrDefault() ?? null;
        //}
        //#endregion



    }
}
