using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class ReceiptTrnD : BaseModel
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
        public int receipttrnhid { get; set; } = default;

        public string doctype { get; set; }
        public DateTime? docdate { get; set; } = DateTime.UtcNow.Date;
        public string docstatus { get; set; }
        public string seq { get; set; } = "0000";
        public int RefDocHeadId { get; set; } = default;
        public string refdocheaddoctype { get; set; } = string.Empty;
        public string refdocitemid { get; set; } = string.Empty;
        public int refinvoiceid { get; set; } = default;
        public string refinvoicedoctype { get; set; } = string.Empty;
        public string refinvoicedocgroup { get; set; } = string.Empty;
        public enum enumpartialtype { HEAD = 1, ITEM = 2 };
        public enumpartialtype partialtype { get; set; } = enumpartialtype.HEAD;
        public decimal amount { get; set; } = 0M;
        public decimal payamt { get; set; } = 0M;
        public decimal depositamt { get; set; } = 0M;
        public decimal whtamt { get; set; } = 0M;

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
        public virtual ReceiptTrnH ReceiptTrnH { get; set; }

    }
}
