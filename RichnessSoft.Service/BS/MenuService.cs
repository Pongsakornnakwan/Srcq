using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RichnessSoft.Common;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service.BS
{
    public interface IMenuService
    {
        List<Menu> GetMenuHeader();
        Task<List<Menu>> GetMenuHeaderAsync();

        Task<List<Menu>> GetSubMenuAsync(string parrentMenu);
        List<Menu>  GetSubMenu(string parrentMenu);
    }
    public class MenuService : IMenuService
    {
        public readonly RicnessDbContext _context;
        public MenuService(RicnessDbContext db)
        {
            _context = db;
        }

        public List<Menu> GetMenuHeader()
        {
            List<Menu> Result = new List<Menu>();
            Result = _context.Menu
                .AsNoTrackingWithIdentityResolution()
                .Where(p => p.menutype.Equals(gbVar.gbTypeMenuHeader1) || p.menutype.Equals(gbVar.gbTypeMenuHeader2))
                .OrderBy(p => p.code).ToList() ?? new List<Menu>();
            return Result;
        }

        public async Task<List<Menu>> GetMenuHeaderAsync()
        {
            List<Menu> Result = new List<Menu>();
            Result = await Task.FromResult(_context.Menu
                .AsNoTrackingWithIdentityResolution()
                .Where(p => p.menutype.Equals(gbVar.gbTypeMenuHeader1) || p.menutype.Equals(gbVar.gbTypeMenuHeader2))
                .OrderBy(p => p.code).ToList() ?? new List<Menu>());
            return Result;
        }

        public List<Menu> GetSubMenu(string parrentMenu)
        {
            List<Menu> Result = new List<Menu>();
            Result = _context.Menu
                .AsNoTrackingWithIdentityResolution()
                .Where(p => p.menutype.Equals(gbVar.gbTypeMenuSubMenu) && p.parrentmenu.Equals(parrentMenu))
                .OrderBy(p => p.code).ToList() ?? new List<Menu>();
            return Result;
        }

        public async Task<List<Menu>> GetSubMenuAsync(string parrentMenu)
        {
            List<Menu> Result = new List<Menu>();
            Result = await Task.FromResult(_context.Menu
                .AsNoTrackingWithIdentityResolution()
                .Where(p => p.menutype.Equals(gbVar.gbTypeMenuSubMenu) && p.parrentmenu.Equals(parrentMenu))
                .OrderBy(p => p.code).ToList() ?? new List<Menu>());
            return Result;
        }
    }
}
