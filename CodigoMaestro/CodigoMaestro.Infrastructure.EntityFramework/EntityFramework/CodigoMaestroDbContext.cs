using System.Data.Entity;
using Abp.Domain.Repositories.EntityFramework;

namespace CodigoMaestro.EntityFramework
{
    public class CodigoMaestroDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //public virtual IDbSet<Person> People { get; set; } //Sample

        public CodigoMaestroDbContext()
            : base("MainDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //TODO: Make additional model setup...

            //modelBuilder.Entity<Person>().ToTable("TsPeople"); //Sample
        }
    }
}
