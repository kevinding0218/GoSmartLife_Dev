using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Entity;
using GoSmartLife.Model.Model;
using GoSmartLife.DataAccess.Configuration;

namespace GoSmartLife.DataAccess.DataContext
{
    public class DataContext : DbContext
    {
        #region User DataTable

        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }

        #endregion User DataTable

        #region Constructor
        static DataContext()
        {
            Database.SetInitializer(new CustomDatabaseInitializer());
        }

        public DataContext()
            : base(nameOrConnectionString: DataContext.ConnectionStringName)
        {

        }

        public static string ConnectionStringName
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionStringName"] != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionStringName"].ToString();
                }

                return "DefaultConnection";
            }
        }
        #endregion Constructor

        #region Data Model Rule
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.Configurations.Add(new UserRoleConfiguration());
                modelBuilder.Configurations.Add(new UserConfiguration());
                modelBuilder.Configurations.Add(new UserPasswordConfiguration());
                modelBuilder.Configurations.Add(new UserContactConfiguration());
                
            }
            catch (Exception ex) { }

            // Add ASP.NET WebPages SimpleSecurity tables
            //modelBuilder.Configurations.Add(new RoleConfiguration());
            //modelBuilder.Configurations.Add(new OAuthMembershipConfiguration());
            //modelBuilder.Configurations.Add(new MembershipConfiguration());
        }

        private void ApplyRules()
        {
            foreach (var entry in this.ChangeTracker.Entries()
                        .Where(
                            e => e.Entity is IAuditInfo &&
                                (e.State == EntityState.Added) ||
                                (e.State == EntityState.Modified)))
            {
                IAuditInfo e = (IAuditInfo)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    e.CreatedOn = DateTime.UtcNow;
                }

                e.LastModifiedOn = DateTime.UtcNow;
            }
        }

        public override int SaveChanges()
        {
            this.ApplyRules();
            return base.SaveChanges();
        }
        #endregion Data Model Rule


    }
}
