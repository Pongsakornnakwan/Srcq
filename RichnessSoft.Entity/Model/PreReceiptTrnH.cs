using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class PreReceiptTrnH : BaseModel
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
        public int? customerid { get; set; } = default;
        public int? vendorid { get; set; } = default;
        public int? contactid { get; set; } = default;
        public int? salemanid { get; set; } = default;
        public int? currencyid { get; set; } = default;

        public string doctype { get; set; }
        public string doccode { get; set; } = string.Empty;
        public string docrefnumber { get; set; } = string.Empty;
        public string docstatus { get; set; }
        public string custsuppbranchcode { get; set; } = string.Empty;
        public string custsupptaxid { get; set; } = string.Empty;
        public int addressofficeid { get; set; }
        public string addressofficedetail { get; set; }
        public string contactname { get; set; } = string.Empty;
        public string contactname2 { get; set; } = string.Empty;
        public string contacttel { get; set; } = string.Empty;
        public DateTime? docdate { get; set; } = DateTime.UtcNow.Date;
        public DateTime? Refdocdate { get; set; } = null;
        public string refdoccode { get; set; } = string.Empty;
        public string islocked { get; set; }
        public string currencycode { get; set; } = string.Empty;
        public decimal currencyrate { get; set; } = 1M;
        public string vattype { get; set; } = string.Empty;
        public decimal vatrate { get; set; } = 0M;
        public string vatisout { get; set; }
        public string remark01 { get; set; } = string.Empty;
        public string remark02 { get; set; } = string.Empty;
        public string remark03 { get; set; } = string.Empty;
        public string remark04 { get; set; } = string.Empty;
        public string remark05 { get; set; } = string.Empty;
        public string remark06 { get; set; } = string.Empty;
        public string remark07 { get; set; } = string.Empty;
        public string remark08 { get; set; } = string.Empty;
        public string remark09 { get; set; } = string.Empty;
        public string remark10 { get; set; } = string.Empty;
        public string attach_file_01 { get; set; } = string.Empty;
        public string attach_file_02 { get; set; } = string.Empty;
        public string attach_file_03 { get; set; } = string.Empty;
        public string attach_file_04 { get; set; } = string.Empty;
        public string attach_file_05 { get; set; } = string.Empty;

        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Book Book { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
        public virtual GLTrnH GLTrnH { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual SaleMan SaleMan { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ICollection<PreReceiptTrnD> PreReceiptTrnDs { get; set; }

    }
}
