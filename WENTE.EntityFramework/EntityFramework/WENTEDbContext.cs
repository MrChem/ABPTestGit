using System.Data.Common;
using System.Data.Entity;
using Abp.Auditing;
using Abp.Zero.EntityFramework;
using WENTE.Authorization.Roles;
using WENTE.Authorization.Users;
using WENTE.MultiTenancy;
using WENTE.PhoneBooks.PersonNumbers;
using WENTE.PhoneBooks.Persons;

namespace WENTE.EntityFramework
{
    public class WENTEDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public DbSet<Person> Persons { get; set; }

        public DbSet<PersonNumber> PersonNumbers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<PersonNumber>().ToTable("PersonNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public WENTEDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in WENTEDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of WENTEDbContext since ABP automatically handles it.
         */
        public WENTEDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public WENTEDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public WENTEDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
