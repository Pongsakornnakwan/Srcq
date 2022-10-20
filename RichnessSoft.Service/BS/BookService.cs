using RichnessSoft.Common;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using RichnessSoft.Service.Store;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RichnessSoft.Service.BS.BookService;

namespace RichnessSoft.Service.BS
{
    public interface IBookService
    {
        Book newTransaction();
        ResultModel Save(Book Book);
        ResultModel Delete(Book data);
        List<Book> GetListBookAll();
        List<Book> GetAll(int CompanyId , int BranchId , string DocType );
        Book getByid(int Id);
        ReicnessMaster LoadMaster();
        Book getByCode(string bookCode);
    }
    public class BookService : IBookService
    {
        public readonly RicnessDbContext _context;
        public readonly RichnessLogDbContext _logContext;
        public readonly IFunctional _function;
        public readonly IDataHelper cDataHelper;
        public CultureInfo _culture = new CultureInfo("th-US");
        public ProfileStore store;
        public BookService(RicnessDbContext db,
           RichnessLogDbContext logContract,
           IFunctional fn,
           DataHelper helper,
           ProfileStore st
           )
        {
            _context = db;
            _logContext = logContract;
            _function = fn;
            cDataHelper = helper;
            store = st;
        }
        public class DocSet
        {
            public Book head { get; set; } = new Book();
            public List<Book> listDoc { get; set; }
        }

        public ResultModel Delete(Book data)
        {
            ResultModel oResult = _function.Delete<Book>(data);
            return oResult;
        }

        public Book getByid(int Id)
        {
            return _context.Book.Find(Id);
        }

        public List<Book> GetListBookAll()
        {
            return _context.Book.Where(x => x.companyid == store.CurentCompany.id).OrderBy(x => x.code).ToList();
        }

        public ReicnessMaster LoadMaster()
        {
            ReicnessMaster mas = new ReicnessMaster();
            mas.listDoctype = _context.DocType.OrderBy(x => x.code).ToList();
            mas.listAccBook = _context.AccBook.Where(x => x.companyid == store.CurentCompany.id).OrderBy(x => x.code).ToList();
            mas.listWarehouse = _context.Warehouse.Where(x => x.companyid == store.CurentCompany.id ).OrderBy(x => x.code).ToList();
            mas.listSection = _context.Section.Where(x => x.companyid == store.CurentCompany.id).OrderBy(x => x.code).ToList();
            mas.listVattype = _context.VatType.Where(x => x.vat_type == 0).OrderBy(x => x.code).ToList();
            mas.listAccRole = _context.AccRoleTemplateH.Where(x => x.companyid == store.CurentCompany.id).OrderBy(x => x.code).ToList();
            mas.listBranch = _context.Branch.Where(x => x.companyid == store.CurentCompany.id).OrderBy(x => x.code).ToList();
            return mas;
        }

        public Book newTransaction()
        {
            Book h = new Book();
            h.id = 0;
            h.yearrunno = ConstUtil.cYearMode.Year_Mode_CE;
            h.companyid = store.CurentCompany.id;
            h.branchid = 0;
            return h;
        }

        public ResultModel Save(Book Book)
        {
            ResultModel results = new ResultModel();
            Book.companyid = store.CurentCompany.id;
            if (Book.id == 0)
            {
                results = _function.Insert<Book>(Book);
            }
            else
            {
                results = _function.Update<Book>(Book);
            }
            return results;
        }

        public Book getByCode(string bookCode)
        {
            return _context.Book.Where(x => x.companyid == store.CurentCompany.id && x.code == bookCode).FirstOrDefault();
        }

        public List<Book> GetAll(int CompanyId, int BranchId, string DocType)
        {
            return _context.Book
                .Where(x => x.companyid == CompanyId && x.branchid == BranchId && x.doctype == DocType)
                .OrderBy(x => x.code).ToList();
        }

        public class ReicnessMaster
        {
            public List<DocType> listDoctype = new List<DocType>();
            public List<AccBook> listAccBook = new List<AccBook>();
            public List<Warehouse> listWarehouse = new List<Warehouse>();
            public List<Section> listSection = new List<Section>();
            public List<VatType> listVattype = new List<VatType>();
            public List<AccRoleTemplateH> listAccRole = new List<AccRoleTemplateH>();
            public List<Branch> listBranch = new List<Branch>();
        }
    }
}
