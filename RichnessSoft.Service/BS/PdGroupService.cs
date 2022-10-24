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

namespace RichnessSoft.Service.BS
{
    public interface IPdGroupService
    {
        ResultModel GetAll(int CorpId);
        Task<ResultModel> GetAllAsync(int CorpId);

        ResultModel GetById(int Id);
        ResultModel GetByCode(int CorpId, string Code);
        ResultModel GetByName(int CorpId, string Name);
        ResultModel Add(ProductGroup um);
        ResultModel Edit(ProductGroup um);
        ResultModel Delete(ProductGroup um);
    }
    public class PdGroupService :BaseService, IPdGroupService
    {
        private readonly RicnessDbContext _db;
        private readonly ProfileStore _store;
        public PdGroupService(RicnessDbContext db, ProfileStore store)
        {
            _db = db;
            _store = store;
        }

        public ResultModel Add(ProductGroup pdGrp)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    pdGrp.createby = _store.CurrentUser.username;
                    pdGrp.createatutc = DateTime.Now;
                    pdGrp.companyid = _store.CurentCompany.id;
                    db.Add(pdGrp);
                    db.SaveChanges();
                    AddLog<ProductGroup>(pdGrp);
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

        public ResultModel Delete(ProductGroup pdGrp)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    var data = db.ProductGroup.Where(x => x.id == pdGrp.id).FirstOrDefault();
                    db.ProductGroup.Remove(data);
                    DeleteLog<ProductGroup>(data);
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

        public ResultModel Edit(ProductGroup pdGrp)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    var Olddata = db.ProductGroup.Where(x => x.id == pdGrp.id).FirstOrDefault();
                    pdGrp.updateby = _store.CurrentUser.username;
                    pdGrp.companyid = _store.CurentCompany.id;
                    pdGrp.updateatutc = DateTime.Now;
                    db.ProductGroup.Update(pdGrp);
                    db.SaveChanges();
                    _db.Entry(pdGrp).State = EntityState.Detached;
                    UpdateLog<ProductGroup>(Olddata, pdGrp);
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
            res.Data = _db.Color.Where(x => x.companyid == CorpId && (x.active.Equals(strActive) || x.inactivedate >= DateTime.Now.Date)).ToList();
            return res;
        }

        public async Task<ResultModel> GetAllAsync(int CorpId)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.ProductGroup.Where(x => x.companyid == CorpId).ToList();
            return res;
        }

        public ResultModel GetByCode(int CorpId, string Code)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.ProductGroup.Where(x => x.companyid == CorpId && x.code.Equals(Code)).FirstOrDefault();
            return res;
        }

        public ResultModel GetById(int Id)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.ProductGroup.Where(x => x.id == Id).FirstOrDefault();
            return res;
        }

        public ResultModel GetByName(int CorpId, string Name)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.ProductGroup.Where(x => x.companyid == CorpId && x.code.Contains(Name)).ToList();
            return res;
        }
    }
}
