using Microsoft.EntityFrameworkCore;
using RichnessSoft.Common;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using RichnessSoft.Service.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service.BS
{
    public interface IColorService
    {
        ResultModel GetAll(int CorpId);
        Task<ResultModel> GetAllAsync(int CorpId);

        ResultModel GetById(int Id);
        ResultModel GetByCode(int CorpId, string Code);
        ResultModel GetByName(int CorpId, string Name);
        ResultModel Add(Colour um);
        ResultModel Edit(Colour um);
        ResultModel Delete(Colour um);
    }
    public class ColorService : BaseService, IColorService
    {
        private readonly RicnessDbContext _db;
        private readonly ProfileStore _store;
        public ColorService(RicnessDbContext db, ProfileStore store)
        {
            _db = db;
            _store = store;
        }

        public ResultModel Add(Colour colors)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    colors.createby = _store.CurrentUser.username;
                    colors.createatutc = DateTime.Now;
                    colors.companyid = _store.CurentCompany.id;
                    db.Add(colors);
                    db.SaveChanges();
                    AddLog<Colour>(colors);
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

        public ResultModel Delete(Colour colors)
        {
            {
                ResultModel res = new ResultModel();
                try
                {
                    using (var db = new RicnessDbContext())
                    {
                        var data = db.Color.Where(x => x.id == colors.id).FirstOrDefault();
                        db.Color.Remove(data);
                        DeleteLog<Colour>(data);
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

        public ResultModel Edit(Colour colors)
        {
            ResultModel res = new ResultModel();
            try
            {
                using (var db = new RicnessDbContext())
                {
                    var Olddata = db.Color.Where(x => x.id == colors.id).FirstOrDefault();
                    colors.updateby = _store.CurrentUser.username;
                    colors.companyid = _store.CurentCompany.id;
                    colors.updateatutc = DateTime.Now;
                    db.Color.Update(colors);
                    db.SaveChanges();
                    _db.Entry(colors).State = EntityState.Detached;
                    UpdateLog<Colour>(Olddata, colors);
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
        public ResultModel GetAll(int CorpId,string strActive = ConstUtil.ACTIVE.YES)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Color.Where(x => x.companyid == CorpId && (x.active.Equals(strActive) || x.inactivedate >=DateTime.Now.Date )).ToList();
            return res;
        }

        public async Task<ResultModel> GetAllAsync(int CorpId)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Color.Where(x => x.companyid == CorpId).ToList();
            return res;
        }

        public ResultModel GetByCode(int CorpId, string Code)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Color.Where(x => x.companyid == CorpId && x.code.Equals(Code)).FirstOrDefault();
            return res;
        }

        public ResultModel GetById(int Id)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Color.Where(x => x.id == Id).FirstOrDefault();
            return res;
        }

        public ResultModel GetByName(int CorpId, string Name)
        {
            ResultModel res = new ResultModel();
            res.Data = _db.Color.Where(x => x.companyid == CorpId && x.code.Contains(Name)).ToList();
            return res;
        }
    }
}
