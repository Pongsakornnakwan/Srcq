using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Logs : BaseModel
    {
        public virtual int logid { get; set; }
        public string message { get; set; }
        public string exception { get; set; }
        public DateTime date { get; set; }
        public string thread { get; set; }
        public string level { get; set; }
        public string logger { get; set; }


    }
}
