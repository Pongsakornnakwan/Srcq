using Microsoft.EntityFrameworkCore;
using RichnessSoft.Common;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using RichnessSoft.Service.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static log4net.Appender.ColoredConsoleAppender;

namespace RichnessSoft.Service.BS
{
    public interface IBankBranchService
    {
        ResultModel GetAll(int CorpId);
        Task<ResultModel> GetAllAsync(int CorpId);

        ResultModel GetById(int Id);
        ResultModel GetByCode(int CorpId, string Code);
        ResultModel GetByName(int CorpId, string Name);
        ResultModel Add(BankBranch um);
        ResultModel Edit(BankBranch um);
        ResultModel Delete(BankBranch um);
    }
    public class BankBranchService : BaseService, IBankBranchService
    {
        private readonly RicnessDbContext _db;
        private readonly ProfileStore _store;
        public BankBranchService(RicnessDbContext db, ProfileStore store)
        {
            _db = db;
            _store = store;
        }

        public ResultModel Add(BankBranch bankbranch)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    bankbranch.createby = _store.CurrentUser.username;
                    bankbranch.createatutc = DateTime.Now;
                    bankbranch.companyid = _store.CurentCompany.id;
                    db.Add(bankbranch);
                    db.SaveChanges();
                    AddLog<BankBranch>(bankbranch);
                    res.Success = true;
                }
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }

        public ResultModel Delete(BankBranch bankbranch)
        {
            {
                ResultModel res = new ResultModel();
                try
                {
                    using (var db = new RicnessDbContext())
                    {
                        var data = db.BankBranch.Where(x => x.id == bankbranch.id).FirstOrDefault();
                        db.BankBranch.Remove(data);
                        DeleteLog<BankBranch>(data);
                        db.SaveChanges();
                        res.Success = true;
                    }
                }
                catch (Exception ex)
                {
                    res.Success = false;
                    res.Message = ex.Message.ToString();
                }
                return res;
            }
        }

        public ResultModel Edit(BankBranch bankbranch)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    var Olddata = db.BankBranch.Where(x => x.id == bankbranch.id).FirstOrDefault();
                    bankbranch.updateby = _store.CurrentUser.username;
                    bankbranch.companyid = _store.CurentCompany.id;
                    bankbranch.updateatutc = DateTime.Now;
                    db.BankBranch.Update(bankbranch);
                    db.SaveChanges();
                    _db.Entry(bankbranch).State = EntityState.Detached;
                    UpdateLog<BankBranch>(Olddata, bankbranch);
                    res.Success = true;
                }
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }

        public ResultModel GetAll(int CorpId)
        {
            return GetAll(CorpId, ConstUtil.ACTIVE.YES);
        }
        public ResultModel GetAll(int CorpId, string strActive = ConstUtil.ACTIVE.YES)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.BankBranch.Where(x => x.companyid == CorpId && (x.active.Equals(strActive) || x.inactivedate >= DateTime.Now.Date)).ToList();
            return res;
        }

        public async Task<ResultModel> GetAllAsync(int CorpId)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.BankBranch.Where(x => x.companyid == CorpId).ToList();
            return res;
        }

        public ResultModel GetByCode(int CorpId, string Code)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.BankBranch.Where(x => x.companyid == CorpId && x.code.Equals(Code)).FirstOrDefault();
            return res;
        }

        public ResultModel GetById(int Id)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.BankBranch.Where(x => x.id == Id).FirstOrDefault();
            return res;
        }

        public ResultModel GetByName(int CorpId, string Name)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.BankBranch.Where(x => x.companyid == CorpId && x.code.Contains(Name)).ToList();
            return res;
        }
    }
}
