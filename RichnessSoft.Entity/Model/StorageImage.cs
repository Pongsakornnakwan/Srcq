using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class StorageImage : BaseModel
    {
        public string sourceimage { get; set; }
        public string refdocid { get; set; }
        public string source { get; set; }
        public string alt { get; set; }
        public string caption { get; set; }
        public string header { get; set; }
        public string seq { get; set; }



    }
}
