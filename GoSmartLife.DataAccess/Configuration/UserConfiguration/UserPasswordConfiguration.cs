using System;
using System.Data.Entity.ModelConfiguration;
using GoSmartLife.Model.Model;
using System.ComponentModel.DataAnnotations.Schema;


namespace GoSmartLife.DataAccess.Configuration
{
    public class UserPasswordConfiguration : EntityTypeConfiguration<UserPassword>
    {
        public UserPasswordConfiguration()
        {
            this.ToTable("UserPassword");

            // Configure UserId as PK for UserPassword
            this.HasKey(p => p.id);

            this.Property(p => p.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.UserId).IsRequired();

            this.Property(p => p.Password).IsRequired().HasMaxLength(200).HasColumnType("nvarchar");

            this.Property(p => p.ErrorLoginCount).IsRequired();

            this.Property(p => p.CreatedOn).IsRequired().HasColumnType("datetime");

            this.Property(p => p.LastModifiedOn).IsRequired().HasColumnType("datetime");
        }
    }
}
