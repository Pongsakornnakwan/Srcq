using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class Menu : BaseModel
    {
        public string code { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string desc1 { get; set; }
        public string desc2 { get; set; }
        public string parrentmenu { get; set; }
        public string path { get; set; }
        public string module { get; set; }
        public string menutype { get; set; }
        public string icon { get; set; }
        public string command { get; set; }
        public string color { get; set; }

    }
}
