using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using RichnessSoft.Service.Logs;
using RichnessSoft.Service.Store;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;
using RichnessSoft.Common;

namespace RichnessSoft.Service.BS
{
    public interface IUmService
    {
        ResultModel GetAll(int CorpId);
        Task<ResultModel> GetAllAsync(int CorpId);

        ResultModel GetById(int Id);
        ResultModel GetByCode(int CorpId,string Code );
        ResultModel GetByName(int CorpId, string Name);
        ResultModel Add(UM um);
        ResultModel Edit(UM um);
        ResultModel Delete(UM um);
    }
    public class UmService : BaseService, IUmService 
    {
        private readonly RicnessDbContext _db;
        private readonly ProfileStore _store;
        //private IerpLogService _erpLog;
        public UmService(RicnessDbContext db, ProfileStore store)
        {
            _db = db;
            _store = store;
        }
        public ResultModel Add(UM um)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext() )
                {
                   um.createby = _store.CurrentUser.username;
                    um.createatutc = DateTime.Now;
                    um.companyid = _store.CurentCompany.id;
                    db.Add(um);
                    db.SaveChanges();
                    AddLog<UM>(um);
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

        public ResultModel Delete(UM um)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    var data = db.UM.Where(x=> x.id == um.id).FirstOrDefault();
                    db.UM.Remove(data);
                    DeleteLog<UM>(data);
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

        public ResultModel Edit(UM um)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    var Olddata = db.UM.Where(x => x.id == um.id).FirstOrDefault();
                    um.updateby = _store.CurrentUser.username;
                    um.companyid = _store.CurentCompany.id;
                    um.updateatutc = DateTime.Now;
                    db.UM.Update(um);
                    db.SaveChanges();
                    _db.Entry(um).State = EntityState.Detached;
                    UpdateLog<UM>(Olddata, um);
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
            res.Data = _db.UM.Where(x => x.companyid == CorpId && (x.active.Equals(strActive) || x.inactivedate >= DateTime.Now.Date)).ToList();
            return res;
        }

        public async Task<ResultModel> GetAllAsync(int CorpId)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.UM.Where(x => x.companyid == CorpId).ToList();
            return res;
        }

        public ResultModel GetByCode(int CorpId, string Code)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.UM.Where(x => x.companyid == CorpId && x.code.Equals(Code)).FirstOrDefault();
            return res;
        }

        public ResultModel GetById(int Id)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.UM.Where(x => x.id == Id ).FirstOrDefault();
            return res;
        }

        public ResultModel GetByName(int CorpId, string Name)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.UM.Where(x => x.companyid == CorpId && x.code.Contains(Name)).ToList();
            return res;
        }
    }
}
