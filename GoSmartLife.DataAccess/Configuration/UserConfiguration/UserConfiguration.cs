using System;
using System.Data.Entity.ModelConfiguration;
using GoSmartLife.Model.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoSmartLife.DataAccess.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.ToTable("Users");

            this.HasKey(p => p.UserId);

            this.Property(p => p.UserId).HasColumnOrder(0).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.EmailAddress).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");

            this.Property(p => p.Active).IsRequired().HasColumnType("bit");

            this.Property(p => p.RoleId).IsRequired();

            this.Property(p => p.LastLogIn).IsRequired().HasColumnType("datetime");

            this.Property(p => p.CreatedOn).IsRequired().HasColumnType("datetime");

            this.Property(p => p.LastModifiedOn).IsRequired().HasColumnType("datetime");

            // Configure <User> - <UserPassword> with One to Many Relationship
            this.HasMany<UserPassword>(user => user.UserPasswords)  // User could have many UserPassword
                .WithRequired(userpassword => userpassword.User)                      // then UserPassword requires NotNull User navigation property
                .HasForeignKey(userpassword => userpassword.UserId);                // UserId in UserPassword as Foreign Key

            // Configure <UserContact> - <User> with One to One Relationship and set <UserContact>UserId as Foreign Key
            this.HasOptional(u => u.UserContact)    // Mark UserContact is optional for User
                .WithRequired(uc => uc.User);       // then UserContact requires NotNull User navigation property

            // Configure <UserRole> - <User> with Many to One Relationship
            this.HasRequired<UserRole>(ur => ur.UserRole)   // User requires NotNull UserRole navigation property
                .WithMany(u => u.Users)                     // then UserRole allows multiply Users
                .HasForeignKey(u => u.RoleId);              // RoleId in User as Foreign Key

            // Configure <UserRole> - <User> with Many to Many Relationshi[
            //this.HasMany(a => a.Roles)
            //    .WithMany(b => b.Users).Map(m =>
            //    {
            //        m.MapLeftKey("UserId");
            //        m.MapRightKey("RoleId");
            //        m.ToTable("webpages_UsersInRoles");
            //    });
        }
    }
}
