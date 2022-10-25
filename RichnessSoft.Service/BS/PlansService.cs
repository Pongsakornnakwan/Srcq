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
    public interface IPlansService
    {
        ResultModel GetAll(int CorpId);
        Task<ResultModel> GetAllAsync(int CorpId);

        ResultModel GetById(int Id);
        ResultModel GetByCode(int CorpId, string Code);
        ResultModel GetByName(int CorpId, string Name);
        ResultModel Add(Plans um);
        ResultModel Edit(Plans um);
        ResultModel Delete(Plans um);
    }
    public class PlansService : BaseService, IPlansService
    {
        private readonly RicnessDbContext _db;
        private readonly ProfileStore _store;
        public PlansService(RicnessDbContext db, ProfileStore store)
        {
            _db = db;
            _store = store;
        }

        public ResultModel Add(Plans plan)
        {

            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    plan.createby = _store.CurrentUser.username;
                    plan.createatutc = DateTime.Now;
                    plan.companyid = _store.CurentCompany.id;
                    db.Add(plan);
                    db.SaveChanges();
                    AddLog<Plans>(plan);
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

        public ResultModel Delete(Plans plan)
        {
            {
                ResultModel res = new ResultModel();
                try
                {
                    using (var db = new RicnessDbContext())
                    {
                        var data = db.Plans.Where(x => x.id == plan.id).FirstOrDefault();
                        db.Plans.Remove(data);
                        DeleteLog<Plans>(data);
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

        public ResultModel Edit(Plans plan)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    var Olddata = db.Plans.Where(x => x.id == plan.id).FirstOrDefault();
                    plan.updateby = _store.CurrentUser.username;
                    plan.updateatutc = DateTime.Now;
                    db.Plans.Update(plan);
                    db.SaveChanges();
                    _db.Entry(plan).State = EntityState.Detached;
                    UpdateLog<Plans>(Olddata, plan);
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
            res.Data = _db.Plans.Where(x => x.companyid == CorpId && (x.active.Equals(strActive) || x.inactivedate >= DateTime.Now.Date)).ToList();
            return res;
        }

        public async Task<ResultModel> GetAllAsync(int CorpId)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Plans.Where(x => x.companyid == CorpId).ToList();
            return res;
        }

        public ResultModel GetByCode(int CorpId, string Code)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Plans.Where(x => x.companyid == CorpId && x.code.Equals(Code)).FirstOrDefault();
            return res;
        }
    

        public ResultModel GetById(int Id)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Plans.Where(x => x.id == Id).FirstOrDefault();
            return res;
        }

        public ResultModel GetByName(int CorpId, string Name)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Plans.Where(x => x.companyid == CorpId && x.code.Contains(Name)).ToList();
            return res;
        }
    }
}
