using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service.BS
{
    public interface IPositionService
    {
        Positions newTransaction();
        ResultModel Save(Positions position);
        ResultModel Delete(Positions data);
        List<Positions> GetListPositionAll();
        Positions getByid(int Id);
        Positions getByCode(string positionCode);
    }

    public class PositionService : IPositionService
    {

        public readonly RicnessDbContext _context;
        public readonly RichnessLogDbContext _logContext;
        public readonly IFunctional _function;
        public readonly IDataHelper cDataHelper;
        public CultureInfo _culture = new CultureInfo("th-US");

        public PositionService(RicnessDbContext db,
            RichnessLogDbContext logContract,
            IFunctional fn,
            DataHelper helper)
        {
            _context = db;
            _logContext = logContract;
            _function = fn;
            cDataHelper = helper;
        }
        public class DocSet
        {
            public Positions head { get; set; }

            public List<Positions> listDoc { get; set; }
        }
        ResultModel IPositionService.Delete(Positions data)
        {
            ResultModel oResult = _function.Delete<Positions>(data);
            return oResult;
        }

        Positions IPositionService.getByid(int Id)
        {
            return _context.Positions.Find(Id);
        }

        Positions IPositionService.getByCode(string positionCode)
        {
            return _context.Positions.Where(x => x.code == positionCode).FirstOrDefault() ?? new Positions();
        }

        List<Positions> IPositionService.GetListPositionAll()
        {
            return _context.Positions.OrderBy(x => x.code).ToList();
        }

        Positions IPositionService.newTransaction()
        {
            Positions h = new Positions();
            h.code = "";
            h.name1 = "";
            h.name2 = "";
            return h;
        }

        ResultModel IPositionService.Save(Positions position)
        {
            ResultModel results = new ResultModel();
            if (position.id == 0)
            {
                results = _function.Insert<Positions>(position);
            }
            else
            {
                results = _function.Update<Positions>(position);
            }
            return results;
        }
    }
}
