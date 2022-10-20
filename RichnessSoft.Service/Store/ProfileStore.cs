using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service.Store
{
    public class ProfileStore
    {
        private Action _listeners;
        private readonly RicnessDbContext _context;

        public int UserId { get; set; }
        public string UserCode;
        public Company Corp { get; set; }
        public User User { get; set; }
        public SysOption SysOption { get; set; } = default;

        private int _companyid;
        public int companyid
        {
            get { return _companyid; }
            set
            {
                _companyid = value;
                NotifyStateChanged();
            }
        }

        private SysOption _sysOption;
        public SysOption sysOption
        {
            get { return _sysOption; }
            set
            {
                _sysOption = value;
                NotifyStateChanged();
            }
        }

        private User _CurrentUser;
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set
            {
                _CurrentUser = value;
                NotifyStateChanged();
            }
        }

        private Company _CurentCompany;
        public Company CurentCompany
        {
            get { return _CurentCompany; }
            set
            {
                _CurentCompany = value;
                NotifyStateChanged();
            }
        }

        private string _CompanyName;
        public string CompanyName
        {
            get { return _CompanyName; }
            set
            {
                _CompanyName = value;
                NotifyStateChanged();
            }
        }

        public ProfileStore(RicnessDbContext Db)
        {
            _context = Db;
        }

        public async Task SetState(string userCode, string CompanyCode)
        {
            this._CurentCompany = await _context?.Company?.AsNoTrackingWithIdentityResolution()?.Where(x => x.code == CompanyCode)?.FirstOrDefaultAsync() ?? default;
            this._CurrentUser = await _context?.User?.AsNoTrackingWithIdentityResolution()?.Where(x => x.username == userCode)?.FirstOrDefaultAsync() ?? default;
            this._sysOption = await _context?.SysOption?.AsNoTrackingWithIdentityResolution()?.Where(x => x.companyid == this._CurentCompany.id)?.FirstOrDefaultAsync() ?? default;
            this._CompanyName = this._CurentCompany?.ExpCompanyFullName;
            this._companyid = this._CurentCompany?.id ?? 0;
            this.UserId = this._CurrentUser?.id ?? 0;
            this.UserCode = this._CurrentUser?.username ?? "";
            NotifyStateChanged();
        }

        #region Observable
        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
        #endregion
    }

}
