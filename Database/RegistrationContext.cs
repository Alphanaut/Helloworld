using System.Data.Entity;
using Registration.Domain;

namespace Registration.DataLayer
{
    public class RegistrationContext : DbContext
    {
        public DbSet<Registrant> Registrants { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registrant>().HasKey(p => p.Id);
            modelBuilder.Entity<Registrant>().Property(p => p.FirstName).IsRequired();
            modelBuilder.Entity<Registrant>().Property(p => p.LastName).IsRequired();
            modelBuilder.Entity<Registrant>().Property(p => p.CreatedDate).IsRequired();
            modelBuilder.Entity<Registrant>().HasMany(p => p.Addresses);

            modelBuilder.Entity<Address>().HasKey(p => p.Id);
            modelBuilder.Entity<Address>().HasRequired(x => x.AddressType);
            modelBuilder.Entity<Address>().HasRequired(x => x.State);
            modelBuilder.Entity<Address>().HasRequired(x => x.Country);
            modelBuilder.Entity<Address>().Property(p => p.Street).IsRequired();
            modelBuilder.Entity<Address>().Property(p => p.City).IsRequired();
            modelBuilder.Entity<Address>().Property(p => p.ZipCode).IsRequired().HasMaxLength(15);

            modelBuilder.Entity<AddressType>().HasMany(p => p.Addresses);
            modelBuilder.Entity<State>().HasMany(p => p.Addresses);
            modelBuilder.Entity<Country>().HasMany(p => p.Addresses);


            base.OnModelCreating(modelBuilder);
        }
    }
}
