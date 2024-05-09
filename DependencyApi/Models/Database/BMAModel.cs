using System.Data.Entity;

namespace DependencyApi.Models.Database
{
    public partial class BMAModel : DbContext
    {
        public BMAModel()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Personnel> Personnels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}