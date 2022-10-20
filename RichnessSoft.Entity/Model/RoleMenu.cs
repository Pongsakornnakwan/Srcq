using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class RoleMenu : BaseModel
    {
        public string rolecode { get; set; }
        public string menucode { get; set; }
        public bool canopen { get; set; }
        public bool canadd { get; set; }
        public bool canedit { get; set; }
        public bool candelete { get; set; }
        public bool canprint { get; set; }


    }
}
