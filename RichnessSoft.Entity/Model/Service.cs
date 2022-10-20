using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Service : BaseModel
    {
        public int companyid { get; set; } = default;
        public int? productgroupid { get; set; } = default;
        public int? categoryid { get; set; }
        public int? brandid { get; set; }
        public int? formatid { get; set; }
        public int? designid { get; set; }
        public int? gradeid { get; set; }
        public int? modelid { get; set; }
        public int? sizeid { get; set; }
        public int? colorid { get; set; }
        public int? weightid { get; set; }
        public int? umid { get; set; }
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

        public string code { get; set; }
        public string status { get; set; }
        public string active { get; set; }
        public Nullable<DateTime> inactivedate { get; set; }
        public string name1 { get; set; }
        public string sname { get; set; }
        public string name2 { get; set; }
        public string sname2 { get; set; }
        public string prodtype { get; set; }
        
        public string taxrate { get; set; }
        public string inputtax { get; set; }
        public string salestax { get; set; }
        public string stockcounting { get; set; }
        public string showinventories { get; set; }
        public string purchaseprice { get; set; }
        public string saleprice { get; set; }
        public decimal stdcost { get; set; }
        public Decimal stdprice { get; set; }
        public Decimal minprice { get; set; }
        public string remark1 { get; set; }
        public string remark2 { get; set; }
        public string remark3 { get; set; }
        public string remark4 { get; set; }
        public string remark5 { get; set; }
        public string remark6 { get; set; }
        public string remark7 { get; set; }
        public string remark8 { get; set; }
        public string remark9 { get; set; }
        public string remark10 { get; set; }
        public string vattype { get; set; }
        public string commision { get; set; }
        public string cardfee { get; set; }

        public virtual Company Company { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Format Format { get; set; }
        public virtual Design Design { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual Models Model { get; set; }
        public virtual Size Size { get; set; }
        public virtual Colour Color { get; set; }
        public virtual Weight Weight { get; set; }
        public virtual ICollection<ServiceMember> ServiceMembers { get; set; }
        public virtual ICollection<ServiceUnit> ServiceUnits { get; set; }

        //public string fullname
        //{
        //    get
        //    {
        //        return string.Format("{0,-2}-{1}", code, name1);
        //    }
        //}
    }
}

       



