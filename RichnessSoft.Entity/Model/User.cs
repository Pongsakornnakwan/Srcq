using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class User : BaseModel
    {
        public string username { get; set; } = "";
        public string password { get; set; } = "";
        public string firstname { get; set; } = "";
        public string lastname { get; set; } = "";
        public string email { get; set; }
        public string token { get; set; }
        public string confirmpassword { get; set; }
        public string usertype { get; set; }

        //#region Expression Field
        //[NotMapped]
        //public string ExpFullName => string.Format("{0} {1}", firstName ?? "", lastName ?? "");
        //#endregion







    }
}
