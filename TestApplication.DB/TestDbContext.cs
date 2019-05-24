
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TestApplication.DB.Models;

namespace TestApplication.DB
{
    [DbConfigurationType(typeof(DbConfig))]
    public class TestDbContext : DbContext
    {
        public virtual DbSet<EmployeeDbModel> Employees { get; set; }

        public TestDbContext() : base("name=test")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<EmployeeDbModel>().ToTable("employee", "dbo");
        }
    }
}
