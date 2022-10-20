using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using RichnessSoft.Common;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using RichnessSoft.Service.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service
{
    public class QueryData
    {
        private readonly RicnessDbContext? _Db;
        private readonly RichnessLogDbContext _logContract;
        private readonly ProfileStore _store;
        private readonly IDistributedCache _cache;

        private const int gnTaskDelay = 100;
        public enum enumPriceType { SELLING = 1, STD };
        public enum enumGetMode { INSERT = 1, EDIT = 2, DELETE = 3 };
        public enum EnumPaymentPayType { ALL = 0, DEPOSIT = 1, WITHDRAW = 2 };
        public QueryData(RicnessDbContext db, RichnessLogDbContext logDbContext, ProfileStore store, IDistributedCache cache)
        {
            _Db = db;
            _logContract = logDbContext;
            _store = store;
            _cache = cache;
        }
        public IEnumerable<AccBook> LoadAccBookListData(int companyid) => GetAccBookListData(companyid);
        private List<AccBook> GetAccBookListData(int companyid)
        {
            return _Db?.AccBook.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid.Equals(companyid))?.OrderBy(c => c.code)?.ToList() ?? new List<AccBook>();
        }
        public IEnumerable<Acchart> LoadAcchartListData() => LoadAcchartListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<Acchart> LoadAcchartListData(string active = ConstUtil.ACTIVE.YES) => LoadAcchartListData(active, "DETAIL");
        public IEnumerable<Acchart> LoadAcchartListData(string active = ConstUtil.ACTIVE.YES, string strTagDetail = "DETAIL") => GetAcchartListData(active, strTagDetail);
        private List<Acchart> GetAcchartListData(string active = ConstUtil.ACTIVE.YES, string tagDetail2 = "DETAIL")
        {
            return _Db?.Acchart.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(active) || c.inactivedate >= DateTime.Now.Date) && c.tag2 == tagDetail2)?.OrderBy(c => c.code)?.ToList() ?? new List<Acchart>();
        }
        public IEnumerable<PostalDisrict> LoadPostalDistrictListData(string strPostalCountryCode = "", string strPostalProvinceCode = "") => GetPostalDistrictListData(strPostalCountryCode, strPostalProvinceCode);
        private IList<PostalDisrict> GetPostalDistrictListData(string strPostalCountryCode = "", string strPostalProvinceCode = "")
        {
            string strUserLang = gbVar.UserLang?.Name ?? "th-TH";
            List<PostalDisrict> disricts = new List<PostalDisrict>();
            if (strUserLang == "en-US")
            {
                disricts = _cache.GetObject<List<PostalDisrict>>(string.Format("{0}:{1}_{2}_{3}", nameof(PostalDisrict), strUserLang, strPostalCountryCode, strPostalProvinceCode));
                if (disricts is null)
                {
                    disricts = _Db?.PostalDisrict?.AsNoTrackingWithIdentityResolution()?.Where(c => c.countrycode == strPostalCountryCode && c.provincecode == strPostalProvinceCode)?.OrderBy(c => c.name2)?.ToList() ?? new List<PostalDisrict>();
                    _cache.SetObject<List<PostalDisrict>>(string.Format("{0}:{1}_{2}_{3}", nameof(PostalDisrict), strUserLang, strPostalCountryCode, strPostalProvinceCode), disricts);

                }
            }
            else
            {
                disricts = _cache.GetObject<List<PostalDisrict>>(string.Format("{0}:{1}_{2}_{3}", nameof(PostalDisrict), strUserLang, strPostalCountryCode, strPostalProvinceCode));
                if (disricts is null)
                {
                    disricts = _Db?.PostalDisrict?.AsNoTrackingWithIdentityResolution()?.Where(c => c.countrycode == strPostalCountryCode && c.provincecode == strPostalProvinceCode)?.OrderBy(c => c.name1)?.ToList() ?? new List<PostalDisrict>();
                    _cache.SetObject<List<PostalDisrict>>(string.Format("{0}:{1}_{2}_{3}", nameof(PostalDisrict), strUserLang, strPostalCountryCode, strPostalProvinceCode), disricts);
                }
            }
            return disricts;
        }
        public IEnumerable<User> LoadApprovalListData() => GetApprovalListData();
        private List<User> GetApprovalListData()
        {
            return _Db?.User.AsNoTrackingWithIdentityResolution()?.OrderBy(c => c.username)?.ToList() ?? new List<User>();
        }
        public IEnumerable<Bank> LoadBankListData() => LoadBankListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<Bank> LoadBankListData(string strActive = ConstUtil.ACTIVE.YES) => GetBankListData(strActive);
        private List<Bank> GetBankListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Bank.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Bank>();
        }
        public IEnumerable<BankBranch> LoadBankBranchListData() => LoadBankBranchListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<BankBranch> LoadBankBranchListData(string strActive = ConstUtil.ACTIVE.YES) => LoadBankBranchListData(strActive, 0);
        public IEnumerable<BankBranch> LoadBankBranchListData(string strActive = ConstUtil.ACTIVE.YES, int bankid = 0) => GetBankBranchListData(strActive, bankid);
        private List<BankBranch> GetBankBranchListData(string strActive = ConstUtil.ACTIVE.YES, int bankid = 0)
        {
            if (bankid > 0)
            {
                return _Db?.BankBranch.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date) && c.bankid == bankid)?.OrderBy(c => c.code)?.ToList() ?? new List<BankBranch>();
            }
            else
            {
                return _Db?.BankBranch.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<BankBranch>();
            }
        }
        public IEnumerable<Book> LoadBookListData(int CorpId, int branchid, string doctypeCode) => GetBookListData(CorpId, branchid, doctypeCode);
        private List<Book> GetBookListData(int corpId, int branchid, string doctypeCode)
        {
            return _Db?.Book.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == corpId && c.branchid.Equals(branchid) && c.doctype.Equals(doctypeCode))?.OrderBy(c => c.code)?.ToList() ?? new List<Book>();

        }
        public IEnumerable<BookBank> LoadBookBankListData() => LoadBookBankListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<BookBank> LoadBookBankListData(string strActive = ConstUtil.ACTIVE.YES) => LoadBookBankListData(strActive, 0);
        public IEnumerable<BookBank> LoadBookBankListData(string strActive = ConstUtil.ACTIVE.YES, int bankid = 0) => LoadBookBankListData(strActive, bankid, 0);
        public IEnumerable<BookBank> LoadBookBankListData(string strActive = ConstUtil.ACTIVE.YES, int bankid = 0, int bankbranchid = 0) => GetBookBankListData(strActive, bankid, bankbranchid);
        private List<BookBank> GetBookBankListData(string strActive = ConstUtil.ACTIVE.YES, int bankid = 0, int bankbranchid = 0)
        {
            if (bankid > 0 && bankbranchid > 0)
            {
                return _Db?.BookBank.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date) && c.bankid == bankid && c.bankbranchid == bankbranchid)?.OrderBy(c => c.code)?.ToList() ?? new List<BookBank>();
            }
            else if (bankid > 0)
            {
                return _Db?.BookBank.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date) && c.bankid == bankid)?.OrderBy(c => c.code)?.ToList() ?? new List<BookBank>();
            }
            else
            {
                return _Db?.BookBank.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<BookBank>();
            }
        }
        public IEnumerable<Branch> LoadBranchListData() => LoadBranchListData(_store?.CurrentUser?.id ?? 0);
        public IEnumerable<Branch> LoadBranchListData(int companyid = 0) => GetBranchListData(companyid);
        public List<Branch> GetBranchListData(int companyid = 0)
        {
            return _Db?.Branch?.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == companyid)?.OrderBy(c => c.code)?.ToList() ?? new List<Branch>();
        }
        public IEnumerable<Brand> LoadBrandListData(string strActive = ConstUtil.ACTIVE.YES) => GetBrandListData(strActive);
        private IList<Brand> GetBrandListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Brand?.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Brand>();
        }
        public IEnumerable<Category> LoadCategoryListData(string strActive = ConstUtil.ACTIVE.YES) => GetCategoryListData(strActive);
        private IList<Category> GetCategoryListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Category?.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Category>();
        }
        public IEnumerable<Colour> LoadColorListData(string strActive = ConstUtil.ACTIVE.YES) => GetColorListData(strActive);
        private IList<Colour> GetColorListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Color?.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Colour>();
        }
        public IEnumerable<Company> LoadCompanyListData() => GetCompanyListData();
        private List<Company> GetCompanyListData()
        {
            return _Db?.Company.AsNoTrackingWithIdentityResolution()?.OrderBy(c => c.code)?.ToList() ?? new List<Company>();
        }
        public IEnumerable<PostalCountry> LoadPostalCountryListData() => GetPostalCountryListData();
        private IList<PostalCountry> GetPostalCountryListData()
        {
            string strUserLang = gbVar.UserLang?.Name ?? "th-TH";
            List<PostalCountry> countries = new List<PostalCountry>();
            if (strUserLang == "en-US")
            {
                countries = _cache.GetObject<List<PostalCountry>>(string.Format("{0}:AllOrderByname2", nameof(PostalCountry)));
                if (countries is null)
                {
                    countries = _Db?.PostalCountry?.AsNoTrackingWithIdentityResolution()?.OrderBy(c => c.name2)?.ToList() ?? new List<PostalCountry>();
                    _cache.SetObject<List<PostalCountry>>(string.Format("{0}:AllOrderByname2", nameof(PostalCountry)), countries);
                }
            }
            else
            {
                countries = _cache.GetObject<List<PostalCountry>>(string.Format("{0}:AllOrderByName", nameof(PostalCountry)));
                if (countries is null)
                {
                    countries = _Db?.PostalCountry?.AsNoTrackingWithIdentityResolution()?.OrderBy(c => c.name1)?.ToList() ?? new List<PostalCountry>();
                    _cache.SetObject<List<PostalCountry>>(string.Format("{0}:AllOrderByName", nameof(PostalCountry)), countries);
                }
            }
            return countries;
        }
        public IEnumerable<Currency> LoadCurrencyListData() => GetCurrencyListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<Currency> LoadCurrencyListData(string active = ConstUtil.ACTIVE.YES) => GetCurrencyListData(active);
        private List<Currency> GetCurrencyListData(string active = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Currency.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active == active || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Currency>();
        }
        public IEnumerable<Customer> LoadCustomerListData() => GetCustomerListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<Customer> LoadCustomerListData(string active = ConstUtil.ACTIVE.YES) => GetCustomerListData(active);
        private List<Customer> GetCustomerListData(string active = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Customer.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && c.active.Equals(active) || c.inactivedate >= DateTime.Now.Date)?.OrderBy(c => c.code)?.ToList() ?? new List<Customer>();
        }
        public IEnumerable<Department> LoadDeptListData() => GetDeptListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<Department> LoadDeptListData(string active = ConstUtil.ACTIVE.YES) => GetDeptListData(active);
        private List<Department> GetDeptListData(string active = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Department.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active == active || c.inactivedate >= DateTime.Now.Date)).OrderBy(c => c.code)?.ToList() ?? new List<Department>();
        }
        public IEnumerable<Descriptions> LoadDescriptionListData() => LoadDescriptionListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<Descriptions> LoadDescriptionListData(string strActive = ConstUtil.ACTIVE.YES) => LoadDescriptionListData(strActive, "");
        public IEnumerable<Descriptions> LoadDescriptionListData(string strActive = ConstUtil.ACTIVE.YES, string strType = "") => GetDescriptionListData(strActive, strType);
        private List<Descriptions> GetDescriptionListData(string strActive = ConstUtil.ACTIVE.YES, string strDescriptionType = "")
        {
            if (UtilHelper.gmIsNullOrEmpty(strDescriptionType) == false)
            {
                return _Db?.Description.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date) && c.dtype == strDescriptionType)?.OrderBy(c => c.code)?.ToList() ?? new List<Descriptions>();
            }
            else
            {
                return _Db?.Description.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Descriptions>();
            }
        }
        public IEnumerable<Design> LoadDesignListData(string strActive = ConstUtil.ACTIVE.YES) => GetDesignListData(strActive);
        private IList<Design> GetDesignListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Design?.AsNoTrackingWithIdentityResolution().Where(c => (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Design>();
        }
        public IEnumerable<DocType> LoadDocTypeListData() => LoadDocTypeListData(null);
        public IEnumerable<DocType> LoadDocTypeListData(string[] aSystemType) => LoadDocTypeListData(aSystemType, null);
        public IEnumerable<DocType> LoadDocTypeListData(string[] aSystemType, string[] aDocGroup) => GetDocTypeListData(aSystemType, aDocGroup);
        public IEnumerable<DocType> LoadDocTypeListData2(string[] aSystemType, string[] aDocGroup, string[] aDocCode) => GetDocTypeListData2(aSystemType, aDocGroup, aDocCode);
        private List<DocType> GetDocTypeListData(string[] aSystemType, string[] aDocGroup)
        {
            if (UtilHelper.gmIsNullOrEmpty(aSystemType) == false && aSystemType.Length > 0 && UtilHelper.gmIsNullOrEmpty(aDocGroup) == false && aDocGroup.Length > 0)
            {
                return _Db?.DocType?.AsNoTrackingWithIdentityResolution().Where(c => aSystemType.Contains(c.system) && aDocGroup.Contains(c.doc_group))?.OrderBy(c => c.code)?.ToList() ?? new List<DocType>();
            }
            else if (UtilHelper.gmIsNullOrEmpty(aSystemType) == false && aSystemType.Length > 0)
            {
                return _Db?.DocType?.AsNoTrackingWithIdentityResolution().Where(c => aSystemType.Contains(c.system))?.OrderBy(c => c.code)?.ToList() ?? new List<DocType>();
            }
            else if (UtilHelper.gmIsNullOrEmpty(aDocGroup) == false && aDocGroup.Length > 0)
            {
                return _Db?.DocType?.AsNoTrackingWithIdentityResolution().Where(c => aDocGroup.Contains(c.doc_group))?.OrderBy(c => c.code)?.ToList() ?? new List<DocType>();
            }
            else
            {
                return _Db?.DocType?.AsNoTrackingWithIdentityResolution().OrderBy(c => c.code)?.ToList() ?? new List<DocType>();
            }
        }
        private List<DocType> GetDocTypeListData2(string[] aSystemType, string[] aDocGroup, string[] aDocCode)
        {
            if (UtilHelper.gmIsNullOrEmpty(aSystemType) == false && aSystemType.Length > 0 && UtilHelper.gmIsNullOrEmpty(aDocGroup) == false && aDocGroup.Length > 0 && UtilHelper.gmIsNullOrEmpty(aDocCode) == false && aDocCode.Length > 0)
            {
                return _Db?.DocType?.AsNoTrackingWithIdentityResolution().Where(c => aSystemType.Contains(c.system) && aDocGroup.Contains(c.doc_group) && aDocCode.Contains(c.code))?.OrderBy(c => c.code)?.ToList() ?? new List<DocType>();
            }
            else if (UtilHelper.gmIsNullOrEmpty(aSystemType) == false && aSystemType.Length > 0 && UtilHelper.gmIsNullOrEmpty(aDocGroup) == false && aDocGroup.Length > 0)
            {
                return _Db?.DocType?.AsNoTrackingWithIdentityResolution().Where(c => aSystemType.Contains(c.system) && aDocGroup.Contains(c.doc_group))?.OrderBy(c => c.code)?.ToList() ?? new List<DocType>();
            }
            else if (UtilHelper.gmIsNullOrEmpty(aSystemType) == false && aSystemType.Length > 0)
            {
                return _Db?.DocType?.AsNoTrackingWithIdentityResolution().Where(c => aSystemType.Contains(c.system))?.OrderBy(c => c.code)?.ToList() ?? new List<DocType>();
            }
            else if (UtilHelper.gmIsNullOrEmpty(aDocGroup) == false && aDocGroup.Length > 0)
            {
                return _Db?.DocType?.AsNoTrackingWithIdentityResolution().Where(c => aDocGroup.Contains(c.doc_group))?.OrderBy(c => c.code)?.ToList() ?? new List<DocType>();
            }
            else
            {
                return _Db?.DocType?.AsNoTrackingWithIdentityResolution().OrderBy(c => c.code)?.ToList() ?? new List<DocType>();
            }
        }
        public IEnumerable<Format> LoadFormatListData(string strActive = ConstUtil.ACTIVE.YES) => GetFormatListData(strActive);
        private IList<Format> GetFormatListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Format?.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Format>();
        }
        public IEnumerable<Grade> LoadGradeListData(string strActive = ConstUtil.ACTIVE.YES) => GetGradeListData(strActive);
        private IList<Grade> GetGradeListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Grade?.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Grade>();
        }
        public IEnumerable<VatType> LoadVatTypeListData() => LoadVatTypeListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<VatType> LoadVatTypeListData(string active = ConstUtil.ACTIVE.YES) => LoadVatTypeListData(ConstUtil.TYPE_VAT.VALUE_ADDED_TAX, active);
        public IEnumerable<VatType> LoadVatTypeListData(int vtype = ConstUtil.TYPE_VAT.VALUE_ADDED_TAX, string active = ConstUtil.ACTIVE.YES) => GetVatTypeListData(vtype, active);
        private List<VatType> GetVatTypeListData(int vType = ConstUtil.TYPE_VAT.VALUE_ADDED_TAX, string active = ConstUtil.ACTIVE.YES)
        {
            List<VatType> v = new List<VatType>();
            v = _Db?.VatType.AsNoTrackingWithIdentityResolution()?.Where(c => (c.active == active || c.inactivedate >= DateTime.Now.Date) && c.vat_type == vType).OrderBy(c => c.code)?.ToList() ?? new List<VatType>();
            return v;
        }
        public IEnumerable<Models> LoadModelListData(string strActive = ConstUtil.ACTIVE.YES) => GetModelListData(strActive);
        private IList<Models> GetModelListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Models?.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Models>();
        }
        public IEnumerable<ProdType> LoadPdTypeListData() => GetPdTypeListData();
        private List<ProdType> GetPdTypeListData()
        {
            return _Db?.ProdType.AsNoTrackingWithIdentityResolution()?.OrderBy(c => c.code)?.ToList() ?? new List<ProdType>();
        }
        public IEnumerable<Product> LoadProductListData() => GetProductListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<Product> LoadProductListData(string active = ConstUtil.ACTIVE.YES) => GetProductListData(active, "");
        public IEnumerable<Product> LoadProductListData(string active = ConstUtil.ACTIVE.YES, string pdTypeCode = "") => GetProductListData(active, pdTypeCode);
        public List<Product> GetProductListData(string active = ConstUtil.ACTIVE.YES, string pdTypeCode = "")
        {
            if (UtilHelper.gmIsNullOrEmpty(pdTypeCode))
            {
                return _Db?.Product.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active == active || c.inactivedate >= DateTime.Now.Date)).OrderBy(c => c.code)?.ToList() ?? new List<Product>();
            }
            else
            {
                return _Db?.Product.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active == active || c.inactivedate >= DateTime.Now.Date) && c.prodtype.Equals(pdTypeCode)).OrderBy(c => c.code)?.ToList() ?? new List<Product>();
            }
        }
        public IEnumerable<Project> LoadProjListData() => GetProjListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<Project> LoadProjListData(string active = ConstUtil.ACTIVE.YES) => GetProjListData(active);
        private List<Project> GetProjListData(string active = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Project.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active == active || c.inactivedate >= DateTime.Now.Date)).OrderBy(c => c.code)?.ToList() ?? new List<Project>();
        }
        public IEnumerable<PostalProvince> LoadPostalProvinceListData(string strPostalCountryCode = "") => GetPostalProvinceListData(strPostalCountryCode);
        private IList<PostalProvince> GetPostalProvinceListData(string strPostalCountryCode = "")
        {
            string strUserLang = gbVar.UserLang?.Name ?? "th-TH";
            List<PostalProvince> PostalProvinces = new List<PostalProvince>();
            if (strUserLang == "en-US")
            {
                PostalProvinces = _cache.GetObject<List<PostalProvince>>(string.Format("{0}:{1}_{2}", nameof(PostalProvince), strUserLang, strPostalCountryCode));
                if (PostalProvinces is null)
                {
                    PostalProvinces = _Db?.PostalProvince?.AsNoTrackingWithIdentityResolution()?.Where(c => c.countrycode == strPostalCountryCode)?.OrderBy(c => c.name2)?.ToList() ?? new List<PostalProvince>();
                    _cache.SetObject<List<PostalProvince>>(string.Format("{0}:{1}_{2}", nameof(PostalProvince), strUserLang, strPostalCountryCode), PostalProvinces);
                }
            }
            else
            {
                PostalProvinces = _cache.GetObject<List<PostalProvince>>(string.Format("{0}:{1}_{2}", nameof(PostalProvince), strUserLang, strPostalCountryCode));
                if (PostalProvinces is null)
                {
                    PostalProvinces = _Db?.PostalProvince?.AsNoTrackingWithIdentityResolution()?.Where(c => c.countrycode == strPostalCountryCode)?.OrderBy(c => c.name1)?.ToList() ?? new List<PostalProvince>();
                    _cache.SetObject<List<PostalProvince>>(string.Format("{0}:{1}_{2}", nameof(PostalProvince), strUserLang, strPostalCountryCode), PostalProvinces);
                }
            }
            return PostalProvinces;
        }
        public IEnumerable<SaleMan> LoadSaleManListData() => GetSaleManListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<SaleMan> LoadSaleManListData(string active = ConstUtil.ACTIVE.YES) => GetSaleManListData(active);
        private List<SaleMan> GetSaleManListData() => GetSaleManListData(ConstUtil.ACTIVE.YES);
        private List<SaleMan> GetSaleManListData(string active = ConstUtil.ACTIVE.YES)
        {
            return _Db?.SaleMan.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active == active || c.inactivedate >= DateTime.Now.Date)).OrderBy(c => c.code)?.ToList() ?? new List<SaleMan>();
        }
        public IEnumerable<ProductSet> LoadSetListData() => GetSetListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<ProductSet> LoadSetListData(string active = ConstUtil.ACTIVE.YES) => GetSetListData(active, "");
        public IEnumerable<ProductSet> LoadSetListData(string active = ConstUtil.ACTIVE.YES, string pdTypeCode = "") => GetSetListData(active, pdTypeCode);
        private List<ProductSet> GetSetListData() => GetSetListData(ConstUtil.ACTIVE.YES);
        private List<ProductSet> GetSetListData(string active = ConstUtil.ACTIVE.YES) => GetSetListData(active, "");
        private List<ProductSet> GetSetListData(string active = ConstUtil.ACTIVE.YES, string pdTypeCode = "")
        {
            if (UtilHelper.gmIsNullOrEmpty(pdTypeCode))
            {
                return _Db?.ProductSet.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active == active || c.inactivedate >= DateTime.Now.Date)).OrderBy(c => c.code)?.ToList() ?? new List<ProductSet>();
            }
            else
            {
                return _Db?.ProductSet.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active == active || c.inactivedate >= DateTime.Now.Date) && c.prodtype.Equals(pdTypeCode)).OrderBy(c => c.code)?.ToList() ?? new List<ProductSet>();
            }
        }
        public IEnumerable<Shipping> LoadShippingListData() => LoadShippingListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<Shipping> LoadShippingListData(string strActive = ConstUtil.ACTIVE.YES) => GetShippingListData(strActive);
        private IList<Shipping> GetShippingListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Shipping?.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Shipping>();
        }
        public IEnumerable<PostalSubdisrict> LoadPostalSubDistrictListData(string strPostalCountryCode = "", string strPostalProvinceCode = "", string strPostalDistrictCode = "") => GetPostalSubDistrictListData(strPostalCountryCode, strPostalProvinceCode, strPostalDistrictCode);
        private IList<PostalSubdisrict> GetPostalSubDistrictListData(string strPostalCountryCode = "", string strPostalProvinceCode = "", string strPostalDistrictCode = "")
        {
            string strUserLang = gbVar.UserLang?.Name ?? "th-TH";
            List<PostalSubdisrict> subdisricts = new List<PostalSubdisrict>();
            if (strUserLang == "en-US")
            {
                subdisricts = _cache.GetObject<List<PostalSubdisrict>>(string.Format("{0}:{1}_{2}_{3}_{4}", nameof(PostalSubdisrict), strUserLang, strPostalCountryCode, strPostalProvinceCode, strPostalDistrictCode));
                if (subdisricts is null)
                {
                    subdisricts = _Db?.PostalSubdisrict?.AsNoTrackingWithIdentityResolution()?.Where(c => c.countrycode == strPostalCountryCode && c.provincecode == strPostalProvinceCode && c.disrictcode == strPostalDistrictCode)?.OrderBy(c => c.name2)?.ToList() ?? new List<PostalSubdisrict>();
                    _cache.SetObject<List<PostalSubdisrict>>(string.Format("{0}:{1}_{2}_{3}_{4}", nameof(PostalSubdisrict), strUserLang, strPostalCountryCode, strPostalProvinceCode, strPostalDistrictCode), subdisricts);
                }
            }
            else
            {
                subdisricts = _cache.GetObject<List<PostalSubdisrict>>(string.Format("{0}:{1}_{2}_{3}_{4}", nameof(PostalSubdisrict), strUserLang, strPostalCountryCode, strPostalProvinceCode, strPostalDistrictCode));
                if (subdisricts is null)
                {
                    subdisricts = _Db?.PostalSubdisrict?.AsNoTrackingWithIdentityResolution()?.Where(c => c.countrycode == strPostalCountryCode && c.provincecode == strPostalProvinceCode && c.disrictcode == strPostalDistrictCode)?.OrderBy(c => c.name1)?.ToList() ?? new List<PostalSubdisrict>();
                    _cache.SetObject<List<PostalSubdisrict>>(string.Format("{0}:{1}_{2}_{3}_{4}", nameof(PostalSubdisrict), strUserLang, strPostalCountryCode, strPostalProvinceCode, strPostalDistrictCode), subdisricts);
                }
            }
            return subdisricts;
        }
        public IEnumerable<Address> LoadTaxPayerListData(Address.enumaddresstype addressType = Address.enumaddresstype.Report_Tax) => GetTaxPayerListData(addressType);
        private IList<Address> GetTaxPayerListData(Address.enumaddresstype addressType = Address.enumaddresstype.Report_Tax)
        {
            return _Db?.Address.AsNoTrackingWithIdentityResolution().Where(c => c.addresstype == addressType && c.taxrepname.Length > 0)?.OrderBy(c => c.taxpayer)?.ToList() ?? new List<Address>();
        }
        public IEnumerable<UM> LoadUmListData() => GetUmListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<UM> LoadUmListData(string active = ConstUtil.ACTIVE.YES) => GetUmListData(active);
        private List<UM> GetUmListData() => GetUmListData(ConstUtil.ACTIVE.YES);
        private List<UM> GetUmListData(string active = ConstUtil.ACTIVE.YES)
        {
            return _Db?.UM.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && c.active == active || c.inactivedate >= DateTime.Now.Date).OrderBy(c => c.code)?.ToList() ?? new List<UM>();
        }
        public IEnumerable<Vendor> LoadVendorListData() => LoadVendorListData(ConstUtil.ACTIVE.YES);
        public IEnumerable<Vendor> LoadVendorListData(string active = ConstUtil.ACTIVE.YES) => GetVendorListData(active);
        private List<Vendor> GetVendorListData(string active = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Vendor.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && c.active.Equals(active) || c.inactivedate >= DateTime.Now.Date)?.OrderBy(c => c.code)?.ToList() ?? new List<Vendor>();
        }
        public IEnumerable<Warehouse> LoadWarehouseListData() => GetWarehouseListData(ConstUtil.ACTIVE.YES, 0);
        public IEnumerable<Warehouse> LoadWarehouseListData(string active = ConstUtil.ACTIVE.YES, int branchid = 0) => GetWarehouseListData(active, branchid);
        public List<Warehouse> GetWarehouseListData(string active = ConstUtil.ACTIVE.YES, int branchid = 0)
        {
            if (branchid==0)
            {
                return _Db?.Warehouse.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active == ConstUtil.ACTIVE.YES || c.inactivedate >= DateTime.Now.Date)).OrderBy(c => c.code)?.ToList() ?? new List<Warehouse>();
            }                                                                                                                           
            else                                                                                                                        
            {                                                                                                                           
                return _Db?.Warehouse.AsNoTrackingWithIdentityResolution()?.Where(c => c.companyid == _store.CurentCompany.id && (c.active == ConstUtil.ACTIVE.YES || c.inactivedate >= DateTime.Now.Date) && c.branchid == branchid).OrderBy(c => c.code)?.ToList() ?? new List<Warehouse>();
            }
        }
        public IEnumerable<Weight> LoadWeightListData(string strActive = ConstUtil.ACTIVE.YES) => GetWeightListData(strActive);
        private IList<Weight> GetWeightListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Weight?.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Weight>();
        }
        public IEnumerable<PayType> LoadPayTypeListData() => LoadPayTypeListData(ConstUtil.ACTIVE.YES, EnumPaymentPayType.ALL);
        public IEnumerable<PayType> LoadPayTypeListData(string strActive = ConstUtil.ACTIVE.YES, EnumPaymentPayType enumPaymentPay = EnumPaymentPayType.ALL) => GetPayTypeListData(strActive, enumPaymentPay);
        private List<PayType> GetPayTypeListData(string strActive = ConstUtil.ACTIVE.YES, EnumPaymentPayType enumPaymentPay = EnumPaymentPayType.ALL)
        {
            switch (enumPaymentPay)
            {
                case EnumPaymentPayType.ALL:
                    return _Db?.PayType.AsNoTrackingWithIdentityResolution().Where(c => (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<PayType>();
                    break;
                case EnumPaymentPayType.DEPOSIT:
                    return _Db?.PayType.AsNoTrackingWithIdentityResolution().Where(c => (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date) && c.isdeposit == ConstUtil.CONFIRM.YES)?.OrderBy(c => c.code)?.ToList() ?? new List<PayType>();
                    break;
                case EnumPaymentPayType.WITHDRAW:
                    return _Db?.PayType.AsNoTrackingWithIdentityResolution().Where(c => (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date) && c.iswithdraw == ConstUtil.CONFIRM.YES)?.OrderBy(c => c.code)?.ToList() ?? new List<PayType>();
                    break;
                default:
                    break;
            }
            return new List<PayType>();
        }
        public IEnumerable<Size> LoadSizeListData(string strActive = ConstUtil.ACTIVE.YES) => GetSizeListData(strActive);
        private IList<Size> GetSizeListData(string strActive = ConstUtil.ACTIVE.YES)
        {
            return _Db?.Size?.AsNoTrackingWithIdentityResolution().Where(c => c.companyid == _store.CurentCompany.id && (c.active.Equals(strActive) || c.inactivedate >= DateTime.Now.Date))?.OrderBy(c => c.code)?.ToList() ?? new List<Size>();
        }
        public Task<List<Company>> GetCompanyListDataAsync() => GetCompanyListDataAsync(CancellationToken.None);
        public async Task<List<Company>> GetCompanyListDataAsync(CancellationToken token = default)
        {
            await Task.Delay(gnTaskDelay, token);
            if (_Db is null) { return null; }
            return await _Db.Company.AsNoTrackingWithIdentityResolution().OrderBy(c => c.code).ToListAsync(token) ?? new List<Company>();
        }
    }
}
