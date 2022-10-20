using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
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
    public interface IUserLoginService
    {
        User newTransaction();
        ResultModel Save(User data);
        ResultModel Delete(User data);
        List<User> GetListAll();
        User getByid(int Id);
        User getByCode(string userName);

        ResultModel Login(LoginViewModel data);
    }
    public class UserLoginService : IUserLoginService
    {
        public readonly RicnessDbContext _context;
        public readonly RichnessLogDbContext _logContext;
        public readonly IFunctional _function;
        public readonly IDataHelper cDataHelper;
        public CultureInfo _culture = new CultureInfo("th-US");


        public UserLoginService(RicnessDbContext db,
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
            public User head { get; set; }

            public List<User> listDoc { get; set; }
        }

        public ResultModel Delete(User data)
        {
            ResultModel oResult = _function.Delete<User>(data);
            return oResult;
        }

        public User getByid(int Id)
        {
            var context = _context.User.Where(x => x.id == Id).FirstOrDefault() ?? new User();
            context.confirmpassword = context.password;
            return context;
        }

        public User getByCode(string userName)
        {
            var context = _context.User.Where(x => x.username == userName).FirstOrDefault() ?? new User();
            context.confirmpassword = context.password;
            return context;
        }

        public List<User> GetListAll()
        {
            return _context.User.OrderBy(x => x.firstname).ToList();
        }

        public User newTransaction()
        {
            User h = new User();
            h.username = "";
            h.password = "";
            h.confirmpassword = "";
            h.firstname = "";
            h.lastname = "";
            h.email = "";
            return h;
        }

        public ResultModel Save(User data)
        {
            ResultModel results = new ResultModel();
            if (data.id == 0)
            {
                data.password = CommonFunc.EncryptData(data.password);
                results = _function.Insert<User>(data);
            }
            else
            {
                results = _function.Update<User>(data);
            }
            return results;
        }

        public ResultModel Login(LoginViewModel data)
        {
            ResultModel Res = new ResultModel();
            User Data = _context.User?.Where(p => p.username.Equals(data.UserName))?.FirstOrDefault() ?? null;
            if (Data is not null)
            {
                if (Data.password.Equals(CommonFunc.EncryptData(data.Password)))
                {
                    Res.Success = true;
                    Res.Data = Data;
                }
                else
                {
                    Res.Success = false;
                    Res.Message = "Invalid password";
                    Res.Data = null;
                }
            }

            return Res;
        }
    }
}
