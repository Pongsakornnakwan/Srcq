using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Asset : BaseModel
    {
        public int? companyid { get; set; } = default;
        public int? branchid { get; set; }
        public int? projectid { get; set; }
        public int? acchartid { get; set; }
        public int? assetgroupid { get; set; }
        public int? departmentid { get; set; }
        public int? depreciateacchartid { get; set; }
        public int? depreciatesumacchartid { get; set; }

        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string identity { get; set; }
        public string generate { get; set; }
        public decimal buyprice { get; set; }
        public decimal transportexpense { get; set; }
        public decimal setupexpense { get; set; }
        public decimal miscellaneousexpense { get; set; }
        public decimal totalprice { get; set; }
        public decimal amount { get; set; }
        public decimal amountdepreciat { get; set; }
        public DateTime buydate { get; set; }
        public string buyinv { get; set; }
        public string buyvoucher { get; set; }
        public DateTime startdate { get; set; }
        public string method { get; set; }
        public string voucherrecord { get; set; }
        public decimal rate { get; set; }
        public string rateper { get; set; }
        public decimal rate2 { get; set; }
        public decimal salvage { get; set; }
        public string deduct { get; set; }
        public DateTime stopdate { get; set; }
        public DateTime saledate { get; set; }
        public string saleinv { get; set; }
        public string salevoucher { get; set; }
        public string customer { get; set; }
        public string vendor { get; set; }
        public string brand { get; set; }
        public string series { get; set; }
        public string serial { get; set; }
        public string usefullife { get; set; }
        public string warrantyno { get; set; }
        public string insurancecomp { get; set; }
        public string insuranceno { get; set; }
        public string remark { get; set; }

        public virtual Company Company { get; set; }
        public virtual AssetGroup AssetGroup    { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Acchart Acchart { get; set; }


    }
}
