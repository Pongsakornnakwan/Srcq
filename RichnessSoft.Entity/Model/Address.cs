using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Address : BaseModel
    {
        public enumaddresstype addresstype { get; set; }

        public enumreftype reftype { get; set; }
        public string refid { get; set; }
        public string taxpayer { get; set; } = string.Empty;
        public string taxrepprefix { get; set; } = string.Empty;
        public string taxrepfirstname { get; set; }
        public string taxrepmidname { get; set; }
        public string taxreplastname { get; set; }
        public string taxrepfirstname2 { get; set; }
        public string taxrepmidname2 { get; set; }
        public string taxreplastname2 { get; set; }
        public string taxrepname { get; set; } = string.Empty;
        public string taxrepname2 { get; set; } = string.Empty;
        public string taxrepsname { get; set; } = string.Empty;
        public string taxtepsname2 { get; set; } = string.Empty;
        public string taxreptaxid { get; set; } = string.Empty;
        public string taxrepbranchno { get; set; } = string.Empty;
        public string taxrepbranchname { get; set; } = string.Empty;
        public string no { get; set; } = string.Empty;
        public string moo { get; set; } = string.Empty;
        public string floor { get; set; } = string.Empty;
        public string room { get; set; } = string.Empty;
        public string village { get; set; } = string.Empty;
        public string village2 { get; set; } = string.Empty;
        public string building { get; set; } = string.Empty;
        public string building2 { get; set; } = string.Empty;
        public string soi { get; set; } = string.Empty;
        public string soi2 { get; set; } = string.Empty;
        public string yaek { get; set; } = string.Empty;
        public string road { get; set; } = string.Empty;
        public string road2 { get; set; } = string.Empty;
        public string tambolcode { get; set; } = string.Empty;
        public string tambolname { get; set; } = string.Empty;
        public string tambolname2 { get; set; } = string.Empty;
        public string amplurcode { get; set; } = string.Empty;
        public string amplurname { get; set; } = string.Empty;
        public string amplurname2 { get; set; } = string.Empty;
        public string provincecode { get; set; } = string.Empty;
        public string provincename { get; set; } = string.Empty;
        public string provincename2 { get; set; } = string.Empty;
        public string countrycode { get; set; } = string.Empty;
        public string countryname { get; set; } = string.Empty;
        public string countryname2 { get; set; } = string.Empty;
        public string cipcode { get; set; } = string.Empty;
        public string zipcode { get; set; } = string.Empty;

        #region Expression Field
        [NotMapped]
        public string Exp_full_address => gbVar.UserLang.Name switch
        {
            "th-TH" => string.Format("เลขที่ : {0} หมู่ที่ : {1} ชั้น : {2} ห้อง : {3} อาคาร/หมู่บ้าน : {4} ซอย : {5} ถนน : {6} แขวง/ตำบล : {7} เขต/อำเภอ : {8} จังหวัด : {9} ประเทศ : {10} รหัสไปรษณีย์ : {11}", (no ?? "-"), (moo ?? "-"), (floor ?? "-"), (room ?? "-"), (village ?? "-"), (soi ?? "-"), (road ?? "-"), (tambolname ?? "-"), (amplurname ?? "-"), (provincename ?? "-"), (countryname ?? "-"), (zipcode ?? "-")),
            "en-US" => string.Format("{0}/{1} floor : {2} room : {3} village : {4} Soi : {5} road : {6} Sub-district : {7} District : {8} Province : {9} Country : {10} Zipcode : {11}", (no ?? "-"), (moo ?? "-"), (floor ?? "-"), (room ?? "-"), (village ?? "-"), (soi ?? "-"), (road ?? "-"), (tambolname ?? "-"), (amplurname ?? "-"), (provincename ?? "-"), (countryname ?? "-"), (zipcode ?? "-")),
            _ => "",
        };

        [NotMapped]
        public bool IsEmptyAddress => gbVar.UserLang.Name switch
        {
            "th-TH" => ((no ?? "") + (moo ?? "") + (floor ?? "") + (room ?? "") + (village ?? "") + (soi ?? "") + (road ?? "") + (tambolname ?? "") + (amplurname ?? "") + (provincename ?? "") + (countryname ?? "") + (zipcode ?? ""))?.Trim()?.Length == 0,
            "en-US" => ((no ?? "") + (moo ?? "") + (floor ?? "") + (room ?? "") + (village ?? "") + (soi ?? "") + (road ?? "") + (tambolname ?? "") + (amplurname ?? "") + (provincename ?? "") + (countryname ?? "") + (zipcode ?? ""))?.Trim()?.Length == 0,
            _ => true,
        };
        #endregion

        public enum enumaddresstype { Home = 1, Office = 2, Billing = 3, IDCard = 4, Other = 5, Contact = 6, Report_Tax = 7 };
        public enum enumreftype { Saleman = 1, Customer = 2, Supplier = 3, Purchase = 4, Sales = 5, Billing = 6, Other = 7, Company = 8, Withholding_Tax = 9, Invoice = 10, Pre_Receipt = 11, Receipt = 12 };
    }


}
