using System.Data.Entity;

namespace Domain
{
    public class AwContext : DbContext
    {
        public AwContext()
            : base(@"Data Source=.\SQLExpress;Initial Catalog=AdventureWorks;Integrated Security=SSPI;MultipleActiveResultSets=True")
        {
        }

        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Contact> Contact { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendor>().ToTable("Purchasing.Vendor");
            modelBuilder.Entity<Contact>().ToTable("Person.Contact");
            modelBuilder.Entity<Vendor>().HasMany(p => p.Contacts).WithMany(t => t.Vendors).Map(
                configuration => configuration.MapLeftKey("VendorId").MapRightKey("ContactId").ToTable("VendorContact"));
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

        }
    }
}