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
    public interface IWarehouseService
    {
        ResultModel GetAll(int CorpId);
        Task<ResultModel> GetAllAsync(int CorpId);

        ResultModel GetById(int Id);
        ResultModel GetByCode(int CorpId, string Code);
        ResultModel GetByName(int CorpId, string Name);
        ResultModel Add(Warehouse um);
        ResultModel Edit(Warehouse um);
        ResultModel Delete(Warehouse um);
    }
    public class WarehouseService : BaseService, IWarehouseService
    {
        private readonly RicnessDbContext _db;
        private readonly ProfileStore _store;
        public WarehouseService(RicnessDbContext db, ProfileStore store)
        {
            _db = db;
            _store = store;
        }

        public ResultModel Add(Warehouse warehouse)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    warehouse.createby = _store.CurrentUser.username;
                    warehouse.createatutc = DateTime.Now;
                    warehouse.companyid = _store.CurentCompany.id;
                    warehouse.branchid = 1;
                    db.Add(warehouse);
                    db.SaveChanges();
                    AddLog<Warehouse>(warehouse);
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

        public ResultModel Delete(Warehouse warehouse)
        {
            {
                ResultModel res = new ResultModel();
                try
                {
                    using (var db = new RicnessDbContext())
                    {
                        var data = db.Warehouse.Where(x => x.id == warehouse.id).FirstOrDefault();
                        db.Warehouse.Remove(data);
                        DeleteLog<Warehouse>(data);
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

        public ResultModel Edit(Warehouse warehouse)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    var Olddata = db.Warehouse.Where(x => x.id == warehouse.id).FirstOrDefault();
                    warehouse.updateby = _store.CurrentUser.username;
                    warehouse.companyid = _store.CurentCompany.id;
                    warehouse.updateatutc = DateTime.Now;
                    db.Warehouse.Update(warehouse);
                    db.SaveChanges();
                    _db.Entry(warehouse).State = EntityState.Detached;
                    UpdateLog<Warehouse>(Olddata, warehouse);
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
            res.Data = _db.Warehouse.Where(x => x.companyid == CorpId && (x.active.Equals(strActive) || x.inactivedate >= DateTime.Now.Date)).ToList();
            return res;
        }

        public async Task<ResultModel> GetAllAsync(int CorpId)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Warehouse.Where(x => x.companyid == CorpId).ToList();
            return res;
        }
    

        public ResultModel GetByCode(int CorpId, string Code)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Warehouse.Where(x => x.companyid == CorpId && x.code.Equals(Code)).FirstOrDefault();
            return res;
        }

        public ResultModel GetById(int Id)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Warehouse.Where(x => x.id == Id).FirstOrDefault();
            return res;
        }

        public ResultModel GetByName(int CorpId, string Name)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Warehouse.Where(x => x.companyid == CorpId && x.code.Contains(Name)).ToList();
            return res;
        }
    }
}
