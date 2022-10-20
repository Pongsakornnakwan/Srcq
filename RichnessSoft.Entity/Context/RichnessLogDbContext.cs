using Microsoft.EntityFrameworkCore;
using RichnessSoft.Common;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.Context
{
    public class RichnessLogDbContext : DbContext
    {
        public DbSet<Erp_Log> erp_log { get; set; }
        public DbSet<Logs> logs { get; set; }
        public RichnessLogDbContext(DbContextOptions<RichnessLogDbContext> options)
       : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(gbVar.LogConstr)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public RichnessLogDbContext() { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
