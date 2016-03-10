using System;
using System.Data.Entity.ModelConfiguration;
using GoSmartLife.Model.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoSmartLife.DataAccess.Configuration
{
    public class UserRoleConfiguration : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            this.ToTable("UserRole");

            this.HasKey(ur => ur.RoleId);

            this.Property(p => p.RoleId).HasColumnOrder(0).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.RoleDescription).IsRequired().HasMaxLength(25).HasColumnType("nvarchar");

            this.Property(p => p.RolePriority).IsRequired();
        }
    }
}
