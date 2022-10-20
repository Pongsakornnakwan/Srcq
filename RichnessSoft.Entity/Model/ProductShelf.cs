using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    public class ProductShelf : BaseModel
    {

        public int companyid { get; set; } 
        public int productid { get; set; }
        public int warehouseid { get; set; }
        public int shelfid { get; set; }
        public int seq { get; set; }

        public decimal width { get; set; } = 0;
        public decimal length { get; set; } = 0;
        public decimal height { get; set; } = 0;

        //public virtual Company Company { get; set; }
        //public virtual Product Product { get; set; }
        //public virtual Warehouse Warehouse { get; set; }
        //public virtual Shelf Shelf { get; set; }


        //#region Expression Field
        //[NotMapped]
        //public string flag => this.ExpDimension;

        //[NotMapped]
        //[Description("กว้าง x ยาว x สูง")]
        //public string ExpDimension => string.Format("{0} x {1} x {2}", width.ToString("N0"), length.ToString("N0"), height.ToString("N0"));

        //[NotMapped]
        //[Description("คลังสินค้า")]
        //public warehouse ExpWarehouse => _context?.Set<warehouse>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.CorpCode == this.CorpCode && c.code == this.whCode)?.FirstOrDefault() ?? null;

        //[NotMapped]
        //[Description("ชั้นวางสินค้า")]
        //public shelf ExpShelf => _context?.Set<shelf>()?.AsNoTrackingWithIdentityResolution()?.Where(c => c.CorpCode == this.CorpCode && c.code == this.shelfCode)?.FirstOrDefault() ?? null;
        //#endregion
    }
}
