using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RichnessSoft.Common.ConstUtil;

namespace RichnessSoft.Entity.Model
{
    public class OrderTrnD : BaseModel
    {
        public int companyid { get; set; } = default;
        public int branchid { get; set; } = default;
        public int bookid { get; set; } = default;
        public int? sectionid { get; set; } = default;
        public int? departmentid { get; set; } = default;
        public int? projectid { get; set; } = default;
        public int? plansld { get; set; } = default;
        public int? ordertrnhid { get; set; } = default;
        public int? customerid { get; set; } = default;
        public int? vendorid { get; set; } = default;
        public int? contactid { get; set; } = default;
        public int? salemanid { get; set; } = default;
        public int? currencyid { get; set; } = default;
        public int productid { get; set; } = default;
        public int warehouseid { get; set; } = default;
        public int umid { get; set; } = default;
        public int umstdid { get; set; } = default;

        //public string DeptName { get; set; } = string.Empty;
        //public string Deptname2 { get; set; } = string.Empty;
        //public string ProjCode { get; set; } = string.Empty;
        //public string ProjName { get; set; } = string.Empty;
        //public string Projname2 { get; set; } = string.Empty;
        //public string PlanCode { get; set; } = string.Empty;
        public string doctype { get; set; } 
        public int seq { get; set; } = default;
        public string type { get; set; } 
        public string prodtype { get; set; } = string.Empty;
        //public string ProdName { get; set; } = string.Empty;
        //public string Prodname2 { get; set; } = string.Empty;
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
        //public string WarehouseCode { get; set; } = string.Empty;
        //public string WarehouseName { get; set; } = string.Empty;
        //public string Warehousename2 { get; set; } = string.Empty;
        public string lot { get; set; } = string.Empty;
        public decimal qty { get; set; } = 0;
        public decimal backqty { get; set; } = 0;
        //public string UmCode { get; set; } = string.Empty;
        //public string UmName { get; set; } = string.Empty;
        //public string Umname2 { get; set; } = string.Empty;
        public decimal stdqty { get; set; } = 0;
        //public string UmStdCode { get; set; } = string.Empty;
        //public string UmStdName { get; set; } = string.Empty;
        //public string UmStdname2 { get; set; } = string.Empty;
        public decimal price { get; set; } = 0;
        public string discstr { get; set; } = string.Empty;
        public decimal discamt { get; set; } = 0;
        public decimal amount { get; set; } = 0;
        public string vattype { get; set; } = string.Empty;
        public decimal vatrate { get; set; } = 0;
        public DateTime? deliverydate { get; set; } = null;
        public string vatisout { get; set; } = VALUE_ADDED_TAX.EXCLUDED;
        public string parent { get; set; } = string.Empty;
        public string child { get; set; } = string.Empty;
        public string status { get; set; }


        public virtual Company Company { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Book Book { get; set; }
        public virtual Section Section { get; set; }
        public virtual Department Department { get; set; }
        public virtual Project Project { get; set; }
        public virtual Plans Plans { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual SaleMan SaleMan { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Product Product { get; set; }
        public virtual OrderTrnH OrderTrnH { get; set; }

        //public virtual UM UM { get; set; }
        //public virtual UM UMStd { get; set; }





    }
}
