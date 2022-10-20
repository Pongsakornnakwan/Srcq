using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class SerialTrnH : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int bookid { get; set; } = default;
        public int? sectionid { get; set; } = default;
        public int? departmentid { get; set; } = default;
        public int? projectid { get; set; } = default;
        public int? plansld { get; set; } = default;
        public string doctype { get; set; } = default;
        public int? refheadid { get; set; } = default;
        public int? refitemid { get; set; } = default;
        public int? productid { get; set; } = default;
        public int? warehouseid { get; set; } = default;

        public string docstatus { get; set; } 
        /// <summary>
        /// รับเข้า/ตัดออก >
        /// IN  =  1, OUT = -1   
        /// </summary>
        public enum CalcFlag { IN = 1, OUT = -1 };
        public CalcFlag calcflag { get; set; } = CalcFlag.OUT;

        public string serialcode { get; set; } = string.Empty;
        public string shelfcode { get; set; } = string.Empty;
        public string seq { get; set; } = "0000";

        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Book Book { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }


        //#region ExpressionField
        ////[NotMapped]
        ////[Description("List Serials")]
        ////public IList<serial> ListSerials { get; set; }
        //#endregion


    }
}
