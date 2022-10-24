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
    public interface ICustGroupsService
    {
        ResultModel GetAll(int CorpId);
        Task<ResultModel> GetAllAsync(int CorpId);

        ResultModel GetById(int Id);
        ResultModel GetByCode(int CorpId, string Code);
        ResultModel GetByName(int CorpId, string Name);
        ResultModel Add(CustGroup um);
        ResultModel Edit(CustGroup um);
        ResultModel Delete(CustGroup um);
    }
    public class CustGroupService : BaseService, ICustGroupsService
    {
        private readonly RicnessDbContext _db;
        private readonly ProfileStore _store;
        public CustGroupService(RicnessDbContext db, ProfileStore store)
        {
            _db = db;
            _store = store;
        }
        public ResultModel Add(CustGroup custgroup)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    custgroup.createby = _store.CurrentUser.username;
                    custgroup.createatutc = DateTime.Now;
                    custgroup.companyid = _store.CurentCompany.id;
                    db.Add(custgroup);
                    db.SaveChanges();
                    AddLog<CustGroup>(custgroup);
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

        public ResultModel Delete(CustGroup custgroup)
        {
            {
                ResultModel res = new ResultModel();
                try
                {
                    using (var db = new RicnessDbContext())
                    {
                        var data = db.CustGroup.Where(x => x.id == custgroup.id).FirstOrDefault();
                        db.CustGroup.Remove(data);
                        DeleteLog<CustGroup>(data);
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

        public ResultModel Edit(CustGroup custgroup)
        {

            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    var Olddata = db.CustGroup.Where(x => x.id == custgroup.id).FirstOrDefault();
                    custgroup.updateby = _store.CurrentUser.username;
                    custgroup.companyid = _store.CurentCompany.id;
                    custgroup.updateatutc = DateTime.Now;
                    db.CustGroup.Update(custgroup);
                    db.SaveChanges();
                    _db.Entry(custgroup).State = EntityState.Detached;
                    UpdateLog<CustGroup>(Olddata, custgroup);
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
            res.Data = _db.CustGroup.Where(x => x.companyid == CorpId && (x.Active.Equals(strActive) || x.inactivedate >= DateTime.Now.Date)).ToList();
            return res;
        }

        public async Task<ResultModel> GetAllAsync(int CorpId)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.CustGroup.Where(x => x.companyid == CorpId).ToList();
            return res;
        }

        public ResultModel GetByCode(int CorpId, string Code)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.CustGroup.Where(x => x.companyid == CorpId && x.code.Equals(Code)).FirstOrDefault();
            return res;
        }

        public ResultModel GetById(int Id)
        {

            ResultModel res = new ResultModel();
            res.Data = _db.CustGroup.Where(x => x.id == Id).FirstOrDefault();
            return res;
        }

        public ResultModel GetByName(int CorpId, string Name)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.CustGroup.Where(x => x.companyid == CorpId && x.code.Contains(Name)).ToList();
            return res;
        }
    }
}
