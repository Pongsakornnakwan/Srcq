using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RichnessSoft.Entity.Model;
namespace RichnessSoft.Data
{
    public class RicnessDbContext : DbContext

    {
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<Positions> Positions { get; set;}
        public virtual DbSet<docType> docType { get; set; }
        public virtual DbSet<company> company { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<roleMenu> roleMenu { get; set; }
        public virtual DbSet<roleUser> roleUser { get; set; }
        public virtual DbSet<um> um { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<branch> branch { get; set; }
        public virtual DbSet<book> book { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<productUnit> productUnit { get; set; }
        public virtual DbSet<productBarcode> productBarcode { get; set; }
        public virtual DbSet<productShelf> productShelf { get; set; }
        //public virtual DbSet<docType> docType { get; set; }
        public virtual DbSet<productset> productSet { get; set; }
        public virtual DbSet<productsetDetil> productsetDetil { get; set; }
        public virtual DbSet<accBook> accBook { get; set; }
        public virtual DbSet<acchart> acchart { get; set; }
        public virtual DbSet<accRole> accRole { get; set; }
        public virtual DbSet<custGroup> custGroup { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<saleTeam> saleTeam { get; set; }
        public virtual DbSet<sysOption> sysOption { get; set; }
        public virtual DbSet<vendor> vendor { get; set; }
        public virtual DbSet<venderGroup> venderGroup { get; set; }
        public virtual DbSet<warehouse> warehouse { get; set; }
        public virtual DbSet<shelf> shelf { get; set; }
        public virtual DbSet<menu> menu { get; set; }
        public virtual DbSet<section> section { get; set; }
        public virtual DbSet<department> department { get; set; }
        public virtual DbSet<project> project { get; set; }
        public virtual DbSet<plans> plans { get; set; }
        public virtual DbSet<productGroup> productGroup { get; set; }
        public virtual DbSet<color> color { get; set; }
        public virtual DbSet<size> size { get; set; }
        public virtual DbSet<model> model { get; set; }
        public virtual DbSet<brand> brand { get; set; }
        public virtual DbSet<saleMan> saleMan { get; set; }
        public virtual DbSet<saleArea> saleArea { get; set; }
        public virtual DbSet<Segmentation> segmentation { get; set; }
        public virtual DbSet<Address> address { get; set; }
        public virtual DbSet<member> member { get; set; }
        public virtual DbSet<vattype> vattype { get; set; }
        public virtual DbSet<prodtype> prodtype { get; set; }
        public virtual DbSet<productMember> productMember { get; set; }
        public virtual DbSet<storageImage> storageImage { get; set; }
        public virtual DbSet<warehouse_type> warehouse_type { get; set; }
        public virtual DbSet<category> category { get; set; }
        public virtual DbSet<format> format { get; set; }
        public virtual DbSet<design> design { get; set; }
        public virtual DbSet<grade> grade { get; set; }
        public virtual DbSet<weight> weight { get; set; }
        public virtual DbSet<contact> contact { get; set; }
        public virtual DbSet<shipping> shipping { get; set; }
        public virtual DbSet<mop> mop { get; set; }
        public virtual DbSet<bank> bank { get; set; }
        public virtual DbSet<bankBranch> bankBranch { get; set; }
        public virtual DbSet<currency> currency { get; set; }
        public virtual DbSet<customerCredit> customerCredit { get; set; }
        public virtual DbSet<service> service { get; set; }
        public virtual DbSet<serviceUnit> serviceUnit { get; set; }
        public virtual DbSet<serviceMember> serviceMember { get; set; }
        public virtual DbSet<priceList> priceList { get; set; }
        public virtual DbSet<orderTrnH> orderTrnH { get; set; }
        public virtual DbSet<orderTrnD> orderTrnD { get; set; }
        public virtual DbSet<postalCountry> postalCountry { get; set; }
        public virtual DbSet<postalDisrict> postalDisrict { get; set; }
        public virtual DbSet<postalProvince> postalProvince { get; set; }
        public virtual DbSet<postalSubdisrict> postalSubdisrict { get; set; }
        public virtual DbSet<assetgroup> assetgroup { get; set; }
        public virtual DbSet<asset> asset { get; set; }
        public virtual DbSet<pricelistTrnH> pricelistTrnH { get; set; }
        public virtual DbSet<pricelistTrnD> pricelistTrnD { get; set; }
        public virtual DbSet<PurchaseTrnH> purchaseTrnH { get; set; }
        public virtual DbSet<purchaseTrnD> purchaseTrnD { get; set; }
        public virtual DbSet<DocLinks> DocLinks { get; set; }
        public virtual DbSet<accRoleTemplateH> accRoleTemplateH { get; set; }
        public virtual DbSet<accRoleTemplateD> accRoleTemplateD { get; set; }
        public virtual DbSet<bookBank> bookBank { get; set; }
        public virtual DbSet<FromRef> fromRef { get; set; }
        public virtual DbSet<formMaster> formMaster { get; set; }
        public virtual DbSet<GLTrnH> GLTrnH { get; set; }
        public virtual DbSet<GLTrnD> GLTrnD { get; set; }
        public virtual DbSet<GLTrnRef> GLTrnRef { get; set; }
        public virtual DbSet<WhTrnH> WhTrnH { get; set; }
        public virtual DbSet<WhTrnD> WhTrnD { get; set; }
        public virtual DbSet<InvTrnH> InvTrnH { get; set; }
        public virtual DbSet<InvTrnD> InvTrnD { get; set; }
        public virtual DbSet<PayType> PayType { get; set; }
        public virtual DbSet<Descriptions> Description { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Bilpay> Bilpay { get; set; }
        public virtual DbSet<PayInTrnD> PayInTrnD { get; set; }
        public virtual DbSet<StockTrnH> StockTrnH { get; set; }
        public virtual DbSet<StockTrnD> StockTrnD { get; set; }
        public virtual DbSet<Lot> Lot { get; set; }
        public virtual DbSet<Serial> Serial { get; set; }
        public virtual DbSet<SerialTrnH> SerialTrnH { get; set; }
        public virtual DbSet<BillTrnH> BillTrnH { get; set; }
        public virtual DbSet<BillTrnD> BillTrnD { get; set; }
        public virtual DbSet<BillTrnRef> BillTrnRef { get; set; }
        public virtual DbSet<PreReceiptTrnH> PreReceiptTrnH { get; set; }
        public virtual DbSet<PreReceiptTrnD> PreReceiptTrnD { get; set; }
        public virtual DbSet<PreReceiptTrnRef> PreReceiptTrnRef { get; set; }
        public virtual DbSet<ReceiptTrnH> ReceiptTrnH { get; set; }
        public virtual DbSet<ReceiptTrnD> ReceiptTrnD { get; set; }
        public virtual DbSet<ReceiptTrnRef> ReceiptTrnRef { get; set; }
        public RicnessDbContext(DbContextOptions<RicnessDbContext> options)
           : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<company>().HasIndex(p => p.code).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<role>().HasIndex(p => p.code ).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<docType>().HasIndex(p => p.Code).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<roleMenu>().HasIndex(o => new { o.roleCode, o.menuCode }).IsUnique().HasDatabaseName("IDXRoleMenuCode");
            modelBuilder.Entity<roleUser>().HasIndex(o => new { o.roleCode, o.UserCode }).IsUnique().HasDatabaseName("IDXRoleMenuCode");
            modelBuilder.Entity<product>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<productUnit>().HasIndex(p => new { p.CorpCode,p.ProductCode, p.UmCode }).IsUnique().HasDatabaseName("IdxProductUnitCode");
            modelBuilder.Entity<um>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<user>().HasIndex(p => p.userName).IsUnique().HasDatabaseName("IdxUsername");
            modelBuilder.Entity<Positions>().HasIndex(p => new { p.CorpCode, p.Code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<roleMenu>().HasKey(o => new { o.roleCode, o.menuCode });
            modelBuilder.Entity<roleUser>().HasKey(o => new { o.roleCode, o.UserCode });
            modelBuilder.Entity<branch>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<book>().HasIndex(p => new { p.CorpCode,p.branchCode, p.docTypeCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<accBook>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<acchart>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<accRole>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<custGroup>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<customer>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<saleTeam>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<sysOption>().HasIndex(p => p.code).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<vendor>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<venderGroup>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<warehouse>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<shelf>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<section>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<department>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<plans>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<productGroup>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<color>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<size>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<model>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<brand>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<saleArea>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<Segmentation>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<member>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<vattype>().HasIndex(p =>  p.code ).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<prodtype>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<productMember>().HasIndex(p => new { p.CorpCode,p.productCode, p.umCode }).IsUnique().HasDatabaseName("IdxProductMemberCode");
            modelBuilder.Entity<storageImage>().HasIndex(p => new {p.sourceImage, p.RefDocLinkID, p.Source }).IsUnique().HasDatabaseName("IdxLinkImageCode");
            modelBuilder.Entity<warehouse_type>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxWarehouseTypeCode");
            modelBuilder.Entity<category>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCategoryCode");
            modelBuilder.Entity<format>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxFormatCode");
            modelBuilder.Entity<design>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxDesignCode");
            modelBuilder.Entity<grade>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxGradeCode");
            modelBuilder.Entity<weight>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxWeightCode");
            modelBuilder.Entity<contact>().HasIndex(p => new { p.CorpCode,p.contactType, p.refType, p.refID }).IsUnique().HasDatabaseName("IdxRefTypeIDCode");
            modelBuilder.Entity<shipping>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxShippingCode");
            modelBuilder.Entity<mop>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxMopCode");
            modelBuilder.Entity<bank>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxBankCode");
            modelBuilder.Entity<bankBranch>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxbankBranchCode");
            modelBuilder.Entity<currency>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCurrencyCode");
            modelBuilder.Entity<service>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxServiceCode");
            modelBuilder.Entity<serviceUnit>().HasIndex(p => new { p.CorpCode,p.serviceCode, p.UmCode }).IsUnique().HasDatabaseName("IdxServiceUnitCode");
            modelBuilder.Entity<serviceMember>().HasIndex(p => new { p.CorpCode,p.serviceCode, p.umCode }).IsUnique().HasDatabaseName("IdxServiceMemberCode");
            modelBuilder.Entity<priceList>().HasIndex(p => new { p.CorpCode,p.pricelist_type, p.code }).IsUnique().HasDatabaseName("IdxPriceList");
            modelBuilder.Entity<orderTrnH>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.bookCode, p.docType, p.doc_code }).IsUnique().HasDatabaseName("IdxOrdH");
            //modelBuilder.Entity<orderTrnD>().HasIndex(p => new { p.orderTrnHCode, p.type, p.prodTypeCode, p.prodCode, p.umCode, p.price }).IsUnique().HasDatabaseName("IdxOrdD");
            modelBuilder.Entity<postalCountry>().HasIndex(p => p.code).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<postalDisrict>().HasIndex(p => p.code).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<postalProvince>().HasIndex(p => p.code).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<postalSubdisrict>().HasIndex(p => p.code).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<pricelistTrnH>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCode");
            modelBuilder.Entity<PurchaseTrnH>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.BookCode, p.DocType, p.DocCode }).IsUnique().HasDatabaseName("IdxPurchaseH");
            modelBuilder.Entity<accRoleTemplateH>().HasIndex(p => new { p.CorpCode, p.code }).IsUnique().HasDatabaseName("IdxCorpCode");
            modelBuilder.Entity<GLTrnH>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.BookCode, p.DocType, p.Doc_Code }).IsUnique().HasDatabaseName("IdxGLTrnH");
            modelBuilder.Entity<WhTrnH>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.BookCode, p.DocType, p.DocCode }).IsUnique().HasDatabaseName("IdxWhTrnH");
            modelBuilder.Entity<WhTrnD>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.BookCode, p.DocType, p.WhTrnHLinkID, p.IncomeType }).IsUnique().HasDatabaseName("IdxWhTrnD");
            modelBuilder.Entity<InvTrnH>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.BookCode, p.DocType, p.DocCode }).IsUnique().HasDatabaseName("IdxInvTrnHSale");
            modelBuilder.Entity<PayType>().HasIndex(p => new { p.Code }).IsUnique().HasDatabaseName("IdxPayType");
            modelBuilder.Entity<Descriptions>().HasIndex(p => new {p.CorpCode, p.DType,  p.Code }).IsUnique().HasDatabaseName("IdxDescription");
            modelBuilder.Entity<Payment>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.SysType, p.DepositWithdraw, p.PayTypeCode, p.Code }).IsUnique().HasDatabaseName("IdxPayment");
            modelBuilder.Entity<PayInTrnD>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.PayInTrnHLinkID, p.PaymentLinkID}).IsUnique().HasDatabaseName("IdxPayInTrnD");
            modelBuilder.Entity<StockTrnH>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.BookCode, p.DocType, p.DocCode }).IsUnique().HasDatabaseName("IdxStkTrnHSale");
            modelBuilder.Entity<Lot>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.WhCode, p.ProductCode, p.UnitCode }).IsUnique().HasDatabaseName("IdxLot");
            modelBuilder.Entity<Serial>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.WhCode, p.ProductCode, p.Code }).IsUnique().HasDatabaseName("IdxSerial");
            modelBuilder.Entity<SerialTrnH>().HasIndex(p => new { p.CorpCode, p.BranchCode,p.BookCode, p.DocType, p.RefHeadLinkID,p.RefItemLinkID, p.ProductCode, p.WhCode, p.SerialCode,p.ShelfCode }).IsUnique().HasDatabaseName("IdxSerialTrnH");
            modelBuilder.Entity<BillTrnH>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.BookCode, p.DocType, p.DocCode }).IsUnique().HasDatabaseName("IdxBillTrnH");
            modelBuilder.Entity<PreReceiptTrnH>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.BookCode, p.DocType, p.DocCode }).IsUnique().HasDatabaseName("IdxPreReceiptTrnH");
            modelBuilder.Entity<ReceiptTrnH>().HasIndex(p => new { p.CorpCode, p.BranchCode, p.BookCode, p.DocType, p.DocCode }).IsUnique().HasDatabaseName("IdxReceiptTrnH");
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.ConfigureWarnings(w => w.Throw(SqlServerEventId.SavepointsDisabledBecauseOfMARS));
            optionsBuilder.ConfigureWarnings(w => w.Ignore(SqlServerEventId.SavepointsDisabledBecauseOfMARS));
            optionsBuilder.EnableSensitiveDataLogging(false);
            optionsBuilder.EnableDetailedErrors(true);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.EnableServiceProviderCaching(true);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
;