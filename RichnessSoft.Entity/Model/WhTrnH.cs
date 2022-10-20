using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class WhTrnH : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int bookid { get; set; } = default;
        public int? sectionid { get; set; } = default;
        public int? departmentid { get; set; } = default;
        public int? projectid { get; set; } = default;
        public int? plansld { get; set; } = default;
        public int? gltrnhid { get; set; } = default;
        public int? gltrnhcaid { get; set; } = default;
        public string refdoctype { get; set; } = default;
        public int? refdocid { get; set; } = default;
        public int? customerid { get; set; } = default;
        public int? vendorid { get; set; } = default;

        //public int RefBillLinkID { get; set; } = default;
        //public int RefBillDocType { get; set; } = default;



        public string doctype { get; set; } 
        public string doccode { get; set; } = string.Empty;
        public string docrefnumber { get; set; } = string.Empty;
        public DateTime? docdate { get; set; } = DateTime.UtcNow.Date;
        public string docstatus { get; set; } 
        public string systype { get; set; } 
        public DateTime? dateoffiling { get; set; } = DateTime.Now.Date;
        public string taxdeduction { get; set; } = string.Empty;
        public string whsection { get; set; } = string.Empty;
        public DateTime? monthoffiling { get; set; } = DateTime.Now.Date;
        public string taxseq { get; set; } = string.Empty;
        public decimal totalpayamount { get; set; } = 0M;
        public decimal totaltaxvalue { get; set; } = 0M;
        public decimal totalvalueaftertax { get; set; } = 0M;

        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Book Book { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Customer Contact { get; set; }
        public ICollection<WhTrnD> WhTrnDs { get; set; }

        //#region Expression Field
        //[NotMapped]
        //[Description("Address")]
        //public Address ExpAddress => GetAddress();

        //private Address GetAddress()
        //{
        //    if (Context is null) { return null; }
        //    return Context.Set<Address>().AsNoTrackingWithIdentityResolution().Where(c => c.addressType == Address.enumAddressType.Report_Tax
        //            && c.refType == Address.enumreftype.Withholding_Tax
        //            && c.refID == LinkID).FirstOrDefault<Address>() ?? null;
        //}
        //[NotMapped]
        //[Description("system")]
        //public string ExpSystemName => GetSystemName();
        //private string GetSystemName()
        //{
        //    string strRetValue = "";
        //    ConstUtilBase.cGLRefSystem oResult = ConstUtil.goListSystem?.Where(c => c.code == systype)?.FirstOrDefault() ?? null;
        //    if (oResult is not null)
        //    {
        //        strRetValue = (gbVar.UserLang?.name1 ?? "th-TH") == "en-US" ? oResult.name2 ?? "" : oResult.name1 ?? "";
        //    }
        //    return strRetValue ?? "";
        //}
        //private string GetDebuggerDisplay()
        //{
        //    return ToString();
        //}
        //#endregion



    }
}
