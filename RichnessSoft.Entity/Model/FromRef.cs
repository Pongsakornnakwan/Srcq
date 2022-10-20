using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class FromRef : BaseModel
    {
        public int companyid { get; set; } = default;
        public string reffromtable { get; set; }
        public string reffromcode { get; set; }
        public string formtype { get; set; }
        public string code { get; set; }
        public string name { get; set; }


        public virtual Company Company { get; set; }



    }
}
