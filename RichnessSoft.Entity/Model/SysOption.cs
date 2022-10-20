using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class SysOption : BaseModel
    {
        public int companyid { get; set; }
        public int? branchid { get; set; }
        public string code { get; set; }
        public DateTime startaccountdate { get; set; } = DateTime.Now.Date;
        public DateTime endaccountdate { get; set; } = DateTime.Now.Date;
        public DateTime carryingamountdate { get; set; } = DateTime.Now.Date;
        public DateTime startsystemdate { get; set; } = DateTime.Now.Date;
        public string postaccount { get; set; } = "A";
        public string vattype { get; set; } = "1";
        public string vatisout { get; set; } = "O";
        public string taxapproveno { get; set; }
        public DateTime? taxapprovedate { get; set; }
        public string taxpayname { get; set; }
        public string taxpayposition { get; set; }
        public int inputitemqty { get; set; }
        public int inputitemqtydecimal { get; set; }
        public int inputprice { get; set; }
        public int inputpricedecimal { get; set; }
        public int inputitemamt { get; set; }
        public int inputitemamtdecimal { get; set; }
        public int inputvat { get; set; }
        public int inputvatdecimal { get; set; }
        public int reportitemqty { get; set; }
        public int reportitemqtydecimal { get; set; }
        public int reportprice { get; set; }
        public int reportpricedecimal { get; set; }
        public int reportitemamt { get; set; }
        public int reportitemamtdecimal { get; set; }
        public int reportvat { get; set; }
        public int reportvatdecimal { get; set; }
        public int sectionid { get; set; }
        public int projectid { get; set; }
        public int buywarehouseid { get; set; }
        public int salewarehouseid { get; set; }
        public int revalueaccountbookid { get; set; }
        public int assetaccountbookid { get; set; }
        public int insuranaccountbookid { get; set; }
        public string stockcounting { get; set; }
        public string controllot { get; set; }
        public string controlserial { get; set; }
        public string fgcost { get; set; }
        public string rmcost { get; set; }
        public string cscost { get; set; }
        public string fgglpost { get; set; }
        public string rmglpost { get; set; }
        public string csglpost { get; set; }
        public string selectbuyprice { get; set; }
        public string selectsaleprice { get; set; }
        public string costcnbuy { get; set; }
        public string costcnsale { get; set; }
        public string costproductzero { get; set; }
        public string costcountstockdoc { get; set; }
        public string costreturnwithdraw { get; set; }
        public string glyearmode { get; set; }
        public string glformatdoc { get; set; }
        public int glrundoclen { get; set; }
        public string glheadmessage { get; set; }
        public string docyearmode { get; set; }
        public string docformatdoc { get; set; }
        public int docrundoclen { get; set; }
    }
}
