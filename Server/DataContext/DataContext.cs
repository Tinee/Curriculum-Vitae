using Database_Entities;

namespace DataContext
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("MarcusCarlsson")
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PersonalLetter> PersonalLetters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
