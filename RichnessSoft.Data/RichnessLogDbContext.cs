using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RichnessSoft.Entity.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace RichnessSoft.Data
{
    public class RichnessLogDbContext : DbContext
    {
        public DbSet<erp_log> erp_log { get; set; }
        public DbSet<Logs> logs { get; set; }
        public RichnessLogDbContext(DbContextOptions<RichnessLogDbContext> options)
       : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
     }
}
