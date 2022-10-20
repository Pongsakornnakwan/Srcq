using RichnessSoft.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service.Store
{
    public class AppSetting
    {
        private Action _listeners;
        private RicnessDbContext _context;
        private string _test;
        public AppSetting(RicnessDbContext context)
        {
            _context = context;
        }

        public string test
        {
            get { return test; }
            set
            {
                _test = value;
                NotifyStateChanged();
            }
        }

        #region Observable
        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
        #endregion
    }
}
