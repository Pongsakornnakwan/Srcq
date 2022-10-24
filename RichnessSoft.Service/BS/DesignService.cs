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
using static RichnessSoft.Service.BS.DesignService;

namespace RichnessSoft.Service.BS
{ 
        public interface IDesignService
        {
            ResultModel GetAll(int CorpId);
            Task<ResultModel> GetAllAsync(int CorpId);

            ResultModel GetById(int Id);
            ResultModel GetByCode(int CorpId, string Code);
            ResultModel GetByName(int CorpId, string Name);
            ResultModel Add(Design um);
            ResultModel Edit(Design um);
            ResultModel Delete(Design um);
        }

    public class DesignService : BaseService, IDesignService
    {
        private readonly RicnessDbContext _db;
        private readonly ProfileStore _store;
        public DesignService(RicnessDbContext db, ProfileStore store)
        {
            _db = db;
            _store = store;
        }

        public ResultModel Add(Design dgn)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    dgn.createby = _store.CurrentUser.username;
                    dgn.createatutc = DateTime.Now;
                    dgn.companyid = _store.CurentCompany.id;
                    db.Add(dgn);
                    db.SaveChanges();
                    AddLog<Design>(dgn);
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

        public ResultModel Delete(Design dgn)

        {
            {
                ResultModel res = new ResultModel();
                try
                {
                    using (var db = new RicnessDbContext())
                    {
                        var data = db.Design.Where(x => x.id == dgn.id).FirstOrDefault();
                        db.Design.Remove(data);
                        DeleteLog<Design>(data);
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

        public ResultModel Edit(Design dgn)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    var Olddata = db.Design.Where(x => x.id == dgn.id).FirstOrDefault();
                    dgn.updateby = _store.CurrentUser.username;
                    dgn.companyid = _store.CurentCompany.id;
                    dgn.updateatutc = DateTime.Now;
                    db.Design.Update(dgn);
                    db.SaveChanges();
                    _db.Entry(dgn).State = EntityState.Detached;
                    UpdateLog<Design>(Olddata, dgn);
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
            res.Data = _db.Design.Where(x => x.companyid == CorpId && (x.active.Equals(strActive) || x.inactivedate >= DateTime.Now.Date)).ToList();
            return res;
        }

        public async Task<ResultModel> GetAllAsync(int CorpId)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Design.Where(x => x.companyid == CorpId).ToList();
            return res;
        }

        public ResultModel GetByCode(int CorpId, string Code)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Design.Where(x => x.companyid == CorpId && x.code.Equals(Code)).FirstOrDefault();
            return res;
        }

        public ResultModel GetById(int Id)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Design.Where(x => x.id == Id).FirstOrDefault();
            return res;
        }

        public ResultModel GetByName(int CorpId, string Name)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Design.Where(x => x.companyid == CorpId && x.code.Contains(Name)).ToList();
            return res;
        }
    }
}
