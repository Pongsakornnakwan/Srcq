using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    [Table("erp_log")]
    public class Erp_Log : BaseModel
    {
       
        public int companyid { get; set; }
        public int value_id { get; set; }
        public DateTime logdatetime { get; set; }
        public string logtype { get; set; }
        public string doc_no { get; set; }
        public string old_doc_no { get; set; }
        public DateTime doc_date { get; set; }
        public DateTime old_doc_date { get; set; }
        public string user_code { get; set; }
        public string data_new { get; set; }
        public string data_old { get; set; }


    }
}
