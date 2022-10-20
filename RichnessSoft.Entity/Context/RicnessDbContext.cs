using System;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RichnessSoft.Common;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Entity.Context
{
    public class RicnessDbContext : DbContext
    {
        #region System
        public virtual DbSet<DocType> DocType { get; set; }
        public virtual DbSet<PayType> PayType { get; set; }
        public virtual DbSet<VatType> VatType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleUser> RoleUser { get; set; }
        public virtual DbSet<RoleMenu> RoleMenu { get; set; }

        #endregion

        #region Master
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }

        public virtual DbSet<AccBook> AccBook { get; set; }
        public virtual DbSet<Acchart> Acchart { get; set; }
        public virtual DbSet<AccRole> AccRole { get; set; }
        public virtual DbSet<AccRoleTemplateH> AccRoleTemplateH { get; set; }
        public virtual DbSet<AccRoleTemplateD> AccRoleTemplateD { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetGroup> AssetGroup { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankBranch> BankBranch { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookBank> BookBank { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Colour> Color { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CustGroup> CustGroup { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerCredit> CustomerCredit { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Descriptions> Description { get; set; }
        public virtual DbSet<Design> Design { get; set; }
        public virtual DbSet<Erp_Log> Erp_Log { get; set; }
        public virtual DbSet<Format> Format { get; set; }
        public virtual DbSet<FormMaster> FormMaster { get; set; }
        public virtual DbSet<FromRef> FromRef { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<MemberGroup> MemberGroup { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Models> Models { get; set; }
        public virtual DbSet<Mop> Mop { get; set; }
        public virtual DbSet<Plans> Plans { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<PostalCountry> PostalCountry { get; set; }
        public virtual DbSet<PostalDisrict> PostalDisrict { get; set; }
        public virtual DbSet<PostalProvince> PostalProvince { get; set; }
        public virtual DbSet<PostalSubdisrict> PostalSubdisrict { get; set; }
        public virtual DbSet<PriceList> PriceList { get; set; }
        public virtual DbSet<PricelistTrnD> PricelistTrnD { get; set; }
        public virtual DbSet<PricelistTrnH> PricelistTrnH { get; set; }
        public virtual DbSet<ProdType> ProdType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductShelf> ProductShelf { get; set; }
        public virtual DbSet<ProductBarcode> ProductBarcode { get; set; }
        public virtual DbSet<ProductGroup> ProductGroup { get; set; }
        public virtual DbSet<ProductMember> ProductMember { get; set; }
        public virtual DbSet<ProductSet> ProductSet { get; set; }
        public virtual DbSet<ProductSetDetail> ProductSetDetail { get; set; }
        public virtual DbSet<ProductUnit> ProductUnit { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<SaleArea> SaleArea { get; set; }
        public virtual DbSet<SaleMan> SaleMan { get; set; }
        public virtual DbSet<SaleTeam> SaleTeam { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Segmentation> Segmentation { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceMember> ServiceMember { get; set; }
        public virtual DbSet<ServiceUnit> ServiceUnit { get; set; }
        public virtual DbSet<Shelf> Shelf { get; set; }
        public virtual DbSet<Shipping> Shipping { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<StorageImage> StorageImage { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<SysOption> SysOption { get; set; }
        public virtual DbSet<UM> UM { get; set; }
        public virtual DbSet<VendorGroup> VendorGroup { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WarehouseType> WarehouseType { get; set; }
        public virtual DbSet<Weight> Weight { get; set; }
        #endregion

        #region Transaction
        public virtual DbSet<BillTrnH> BillTrnH { get; set; }
        public virtual DbSet<BillTrnD> BillTrnD { get; set; }
        public virtual DbSet<BillTrnRef> BillTrnRef { get; set; }
        public virtual DbSet<Bilpay> Bilpay { get; set; }
        public virtual DbSet<DocLink> DocLink { get; set; }
        public virtual DbSet<GLTrnH> GLTrnH { get; set; }
        public virtual DbSet<GLTrnD> GLTrnD { get; set; }
        //public virtual DbSet<GLTrnRef> GLTrnRef { get; set; }
        public virtual DbSet<InvTrnH> InvTrnH { get; set; }
        public virtual DbSet<InvTrnD> InvTrnD { get; set; }
        public virtual DbSet<OrderTrnH> OrderTrnH { get; set; }
        public virtual DbSet<OrderTrnD> OrderTrnD { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PreReceiptTrnH> PreReceiptTrnH { get; set; }
        public virtual DbSet<PreReceiptTrnD> PreReceiptTrnD { get; set; }
        public virtual DbSet<PreReceiptTrnRef> PreReceiptTrnRef { get; set; }
        public virtual DbSet<ReceiptTrnH> ReceiptTrnH { get; set; }
        public virtual DbSet<ReceiptTrnD> ReceiptTrnD { get; set; }
        public virtual DbSet<ReceiptTrnRef> ReceiptTrnRef { get; set; }
        public virtual DbSet<Serial> Serial { get; set; }
        public virtual DbSet<SerialTrnH> SerialTrnH { get; set; }
        public virtual DbSet<WhTrnH> WhTrnH { get; set; }
        public virtual DbSet<WhTrnD> WhTrnD { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(gbVar.MainConstr)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public RicnessDbContext() { }
        public RicnessDbContext(DbContextOptions<RicnessDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
