using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Model
{
    
    public class Company : BaseModel
    {
        public string code { get; set; }
        public string taxid { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string houseno { get; set; }
        public string moo { get; set; }
        public string floor { get; set; }
        public string room { get; set; }
        public string village { get; set; } = string.Empty;
        public string village2 { get; set; } = string.Empty;
        public string building { get; set; }
        public string building2 { get; set; }
        public string lane { get; set; }
        public string lane2 { get; set; }
        public string yaek { get; set; } = string.Empty;
        public string road { get; set; }
        public string road2 { get; set; }
        public int subdisrictid { get; set; }
        public int disrictid { get; set; }
        public int provinceid { get; set; }
        public int countryid { get; set; }
        public int postalid { get; set; }
        public string tel2 { get; set; }
        public string tel { get; set; }
        public string fax { get; set; }
        public string website { get; set; }
        public string onwername { get; set; }
        public string registerno { get; set; }
        #region Expression Field
        [NotMapped]
        public string ExpCompanyFullName => string.Format("{0}-{1}", code, (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1);
        [NotMapped]
        public string ExpCompanyName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name1;
        #endregion

        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<AccBook> Accbooks { get; set; }
        public virtual ICollection<Acchart> Accharts { get; set; }
        public virtual ICollection<AccRole> AccRoles { get; set; }
        public virtual ICollection<AccRoleTemplateH> AccRoleTemplateHs { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<AssetGroup> AssetGroups { get; set; }
        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<BankBranch> BankBranchs { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<BookBank> BookBanks { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<Category> Categorys { get; set; }
        public virtual ICollection<Colour> Colors { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Descriptions> Descriptions { get; set; }
        public virtual ICollection<Currency> Currencys { get; set; }
        public virtual ICollection<Design> Designs { get; set; }
        public virtual ICollection<CustGroup> CustGroups { get; set; }
        public virtual ICollection<CustomerCredit> CustomeCredits { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<DocLink> DocLinks { get; set; }
        public virtual ICollection<GLTrnD> GLTrnDs { get; set; }
        public virtual ICollection<GLTrnH> GLTrnHs { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Bilpay> Bilpays { get; set; }
        public virtual ICollection<InvTrnH> InvTrnHs { get; set; }
        public virtual ICollection<InvTrnD> InvTrnDs { get; set; }
        public virtual ICollection<MemberGroup> MemberGroups { get; set; }
        public virtual ICollection<Models> Modelss { get; set; }
        public virtual ICollection<Mop> Mops { get; set; }
        public virtual ICollection<OrderTrnH> OrderTrnHs { get; set; }
        public virtual ICollection<OrderTrnD> OrderTrnDs { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Plans> Plans { get; set; }
        public virtual ICollection<Positions> Positions { get; set; }
        public virtual ICollection<PriceList> PriceLists { get; set; }
        public virtual ICollection<PricelistTrnH> PricelistTrnHs { get; set; }
        public virtual ICollection<PricelistTrnD> PricelistTrnDs { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<ProductMember> ProductMembers { get; set; }
        public virtual ICollection<ProductSet> ProductSets { get; set; }
        public virtual ICollection<ProductSetDetail> ProductSetDetails { get; set; }
        public virtual ICollection<ProductUnit> ProductUnits { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<SaleArea> SaleAreas { get; set; }
        public virtual ICollection<SaleMan> SaleMans { get; set; }
        public virtual ICollection<SaleTeam> SaleTeams { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<Segmentation> Segmentations { get; set; }
        public virtual ICollection<Serial> Serials { get; set; }
        public virtual ICollection<SerialTrnH> SerialTrnHs { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<ServiceMember> ServiceMembers { get; set; }
        public virtual ICollection<ServiceUnit> ServiceUnits { get; set; }
        public virtual ICollection<Shipping> Shippings { get; set; }
        public virtual ICollection<Size> Sizes { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
        public virtual ICollection<UM> UMs { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
        public virtual ICollection<Weight> Weights { get; set; }
        public virtual ICollection<WhTrnH> WhTrnHs { get; set; }
        public virtual ICollection<WhTrnD> WhTrnDs { get; set; }
        public virtual ICollection<Format> Formats { get; set; }
        public virtual ICollection<FormMaster> FormMasters { get; set; }
        public virtual ICollection<FromRef> FromRefs { get; set; }
        public virtual ICollection<Shelf> Shelfs { get; set; }
        public virtual ICollection<VendorGroup> VendorGroups { get; set; }
        public virtual ICollection<BillTrnH> BillTrnHs { get; set; }
        public virtual ICollection<BillTrnD> BillTrnDs { get; set; }
        public virtual ICollection<BillTrnRef> BillTrnRefs { get; set; }
        public virtual ICollection<PayInTrnD> PayInTrnDs { get; set; }
        public virtual ICollection<PreReceiptTrnD> PreReceiptTrnDs { get; set; }
        public virtual ICollection<PreReceiptTrnH> PreReceiptTrnHs { get; set; }
        public virtual ICollection<PreReceiptTrnRef> PreReceiptTrnRefs { get; set; }
        public virtual ICollection<ReceiptTrnD> ReceiptTrnDs { get; set; }
        public virtual ICollection<ReceiptTrnH> ReceiptTrnHs { get; set; }
        public virtual ICollection<ReceiptTrnRef> ReceiptTrnRefs { get; set; }
        public virtual ICollection<ProductBarcode> ProductBarcodes { get; set; }
    }
}
