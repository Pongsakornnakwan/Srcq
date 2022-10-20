using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;
using System.Text.Json.Serialization;
using RichnessSoft.Common;

namespace RichnessSoft.Entity.Model
{
    public class BaseModel
    {
        public BaseModel()
        {
            if (UtilHelper.gmIsNullOrEmpty(this.createapp))
            {
                this.createapp = SysDef.CreateApp.gc_APP_MASTER;
            }
            if (UtilHelper.gmIsNullOrEmpty(this.createatutc))
            {
                this.createatutc = DateTime.UtcNow;
            }
        }
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //audit trail
        [ScaffoldColumn(false)]
        public string createby { get; set; }
        [ScaffoldColumn(false)]
        public DateTime? createatutc { get; set; }
        [ScaffoldColumn(false)]
        public string updateby { get; set; }
        [ScaffoldColumn(false)]
        public DateTime? updateatutc { get; set; }

        //[ScaffoldColumn(false)]
        //[MaxLength(25)]
        //public string LinkID { get; set; }
        [ScaffoldColumn(false)]
        [MaxLength(25)]
        public string createapp { get; set; }

        #region NotMapped
        //[NotMapped]
        //[Description("ภาษา")]
        //[JsonIgnore]
        //public CultureInfo goCultureInfo { get; set; } = new CultureInfo(gbVar.UserLang?.name1 ?? "th-TH");
        #endregion
    }
}
