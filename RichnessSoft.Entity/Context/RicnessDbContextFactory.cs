using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace RichnessSoft.Entity.Context
{
    //public class RicnessDbContextFactory : IDbContextFactory<RicnessDbContext> 
    //{
    //    public RicnessDbContext CreateDbContext()
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<RicnessDbContext>();
    //        optionsBuilder.UseSqlServer("Data source=DESKTOP-CINCGJO\\SQLEXP;Initial Catalog=RichnessDb;User ID=fm1234; password=x2y2;MultipleActiveResultSets=true;");
    //        return new RicnessDbContext(optionsBuilder.Options);
    //    }
    //}
    public class RicnessDbContextFactory : IDesignTimeDbContextFactory<RicnessDbContext>
    {
        /// <summary>
        /// command
        /// add-migration initDb -context RicnessDbContext
        /// update-database -context RicnessDbContext
        /// </summary>
        /// <param name1="args"></param>
        /// <returns></returns>
        public RicnessDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RicnessDbContext>();
            //optionsBuilder.UseSqlServer("Data source=DESKTOP-CINCGJO\\SQLEXP;Initial Catalog=RichnessDb2;User ID=fm1234; password=x2y2;MultipleActiveResultSets=true;");
            //optionsBuilder.UseSqlServer("Data source=119.59.126.76;Initial Catalog=RichnessDb2;User ID=fm1234; password=x2y2;MultipleActiveResultSets=true");
            optionsBuilder.UseNpgsql("User ID=postgres;password=AdminWell1234;Host=119.59.127.75;Port=8888;Database=RichnessSoftDb;Pooling=true;");


            return new RicnessDbContext(optionsBuilder.Options);
        }
    }
}
