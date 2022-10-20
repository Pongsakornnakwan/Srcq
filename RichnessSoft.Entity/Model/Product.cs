using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RichnessSoft.Common;

namespace RichnessSoft.Entity.Model
{
    public class Product : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? productgroupid { get; set; } = default;
        public int umid { get; set; } = default;
        public int? categoryid { get; set; } = default;
        public int? brandid { get; set; } = default;
        public int? formatid { get; set; } = default;
        public int? designid { get; set; } = default;
        public int? gradeid { get; set; } = default;
        public int? modelid { get; set; } = default;
        public int? sizeid { get; set; } = default;
        public int? colorid { get; set; } = default;
        public int? weightid { get; set; } = default;
        public int? accbuycashid { get; set; } = default;
        public int? accbuycreditid { get; set; } = default;
        public int? accsalecashid { get; set; } = default;
        public int? accsalecreditid { get; set; } = default;
        public int? acccostid { get; set; } = default;
        public int? accstockid { get; set; } = default;
        public int? AccWorkInProcessId { get; set; } = default;
        public int? accsuppliedusedid { get; set; } = default;
        public int? accmaterialrequistionid { get; set; } = default;
        public int? budgetgroupid { get; set; } = default;
        public int? acccngoodid { get; set; } = default;
        public int? acccnpriceid { get; set; } = default;
        public int? accincreasedebtreturnincreaseid { get; set; } = default;
        public int? accincreasedebtpriceincreaseid { get; set; } = default;

        public string code { get; set; } = string.Empty;
        public string status { get; set; } = "A";
        public string active { get; set; } 
        public DateTime? inactivedate { get; set; } = null;
        public string name1 { get; set; } = string.Empty;
        public string sname1 { get; set; } = string.Empty;
        public string name2 { get; set; } = string.Empty;
        public string sname2 { get; set; } = string.Empty;
        public string prodtype { get; set; } = string.Empty;
        public string taxrate { get; set; } = string.Empty;
        public string inputtax { get; set; } = string.Empty;
        public string salestax { get; set; } = string.Empty;
        public string stockcounting { get; set; } 
        public string showinventories { get; set; } = "Y";
        public string purchaseprice { get; set; } 
        public string saleprice { get; set; } 
        public decimal stdcost { get; set; } = 0M;
        public Decimal stdprice { get; set; } = 0M;
        public Decimal minprice { get; set; } = 0M;
        public string remark1 { get; set; } = string.Empty;
        public string remark2 { get; set; } = string.Empty;
        public string remark3 { get; set; } = string.Empty;
        public string remark4 { get; set; } = string.Empty;
        public string remark5 { get; set; } = string.Empty;
        public string remark6 { get; set; } = string.Empty;
        public string remark7 { get; set; } = string.Empty;
        public string remark8 { get; set; } = string.Empty;
        public string remark9 { get; set; } = string.Empty;
        public string remark10 { get; set; } = string.Empty;
        public string vattype { get; set; } 
        public string commision { get; set; } = "N";
        public string cardfee { get; set; } = "N";

        public virtual Company Company { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Format Format { get; set; }
        public virtual Design Design { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual Models Models { get; set; }
        public virtual Size Size { get; set; }
        public virtual Colour Color { get; set; }
        public virtual Weight Weight { get; set; }

        public virtual ICollection<InvTrnD> InvTrnDs { get; set; }
        public virtual ICollection<OrderTrnD> OrderTrnDs { get; set; }
        public virtual ICollection<PriceList> PriceLists { get; set; }
        public virtual ICollection<PricelistTrnD> PricelistTrnDs { get; set; }
        public virtual ICollection<ProductMember> ProductMembers { get; set; }
        public virtual ICollection<ProductSetDetail> ProductSetDetails { get; set; }
        public virtual ICollection<ProductUnit> ProductUnits { get; set; }
        public virtual ICollection<Serial> Serials { get; set; }
        public virtual ICollection<SerialTrnH> SerialTrnHs { get; set; }
        public virtual ICollection<ProductBarcode> ProductBarcodes { get; set; }

        #region Expression Field
        [NotMapped]
        //[Description("ชื่อรุ่นสินค้า(ชื่อเต็ม)")]
        public string ExpFullName => string.Format("{0}-{1}", code, ExpName);
        [NotMapped]
        //[Description("ชื่อรุ่นสินค้า")]
        public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1;
        #endregion

    }
}
