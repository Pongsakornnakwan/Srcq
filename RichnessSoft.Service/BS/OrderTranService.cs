using Microsoft.EntityFrameworkCore.Query.Internal;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service.BS
{
    public interface IOrderTranService
    {
        Task<List<OrderTrnH>> GetAllData(int CompanyId, int BranchId, string DocType, int BookId, DateTime BegDate, DateTime EndDate);
    }
    public class OrderTranService : IOrderTranService
    {
        private readonly RicnessDbContext _db;
        public OrderTranService(RicnessDbContext db)
        {
            _db = db;
        }
        async Task<List<OrderTrnH>> IOrderTranService.GetAllData(int CompanyId, int BranchId, string DocType, int BookId, DateTime BegDate, DateTime EndDate)
        {
            List<OrderTrnH> rest = new List<OrderTrnH>();
            try
            {
                rest = _db.OrderTrnH.Include(x => x.Customer).Where(x =>
                x.companyid.Equals(CompanyId)
                && x.branchid.Equals(BranchId)
                && x.doctype.Equals(DocType)
                && x.bookid.Equals(BookId)
                && x.docdate >= BegDate && x.docdate <= EndDate
                    ).ToList();
            }
            catch (Exception)
            {}
            return rest;
        }
    }
}
