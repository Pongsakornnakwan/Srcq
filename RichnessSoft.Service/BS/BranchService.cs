using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using RichnessSoft.Service.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service.BS
{
    public interface IBranchService
    {
        Task<ResultModel> GetAll(int CompanyId);
        ResultModel GetById(int Id);
        ResultModel GetByCode(int CorpId, string Code);
        ResultModel GetByName(int CorpId, string Name);
        ResultModel Add(Branch branch);
        ResultModel Edit(Branch branch);
        ResultModel Delete(Branch branch);

    }
    public class BranchService :BaseService , IBranchService
    {
        private readonly RicnessDbContext _db;
        private readonly ProfileStore _store;
        //private IerpLogService _erpLog;
        public BranchService(RicnessDbContext db, ProfileStore store)
        {
            _db = db;
            _store = store;
        }
        public ResultModel Add(Branch branch)
        {
            throw new NotImplementedException();
        }

        public ResultModel Delete(Branch branch)
        {
            throw new NotImplementedException();
        }

        public ResultModel Edit(Branch branch)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultModel> GetAll(int CompanyId)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Branch.Where(x => x.companyid == CompanyId).ToList();
            return res;
        }

        public ResultModel GetByCode(int CorpId, string Code)
        {
            throw new NotImplementedException();
        }

        public ResultModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public ResultModel GetByName(int CorpId, string Name)
        {
            throw new NotImplementedException();
        }
    }
}
