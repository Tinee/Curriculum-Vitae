using Database_Entities;

namespace DataService
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("MarcusCarlsson")
        {

        }

        public DbSet<Company> Companies { get; set; }
  
        public DbSet<PersonalLetter> PersonalLetters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
