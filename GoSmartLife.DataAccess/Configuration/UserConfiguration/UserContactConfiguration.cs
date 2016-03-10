using System;
using System.Data.Entity.ModelConfiguration;
using GoSmartLife.Model.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoSmartLife.DataAccess.Configuration
{
    public class UserContactConfiguration : EntityTypeConfiguration<UserContact>
    {
        public UserContactConfiguration()
        {
            // Configure Table Name
            this.ToTable("UserContact");

            // Configure UserId as PK for UserPassword
            this.HasKey(p => p.UserId);

            this.Property(p => p.FirstName).IsRequired().HasMaxLength(25).HasColumnType("nvarchar");

            this.Property(p => p.MiddleName).IsOptional().HasMaxLength(25).HasColumnType("nvarchar");

            this.Property(p => p.LastName).IsRequired().HasMaxLength(25).HasColumnType("nvarchar");

            this.Property(p => p.Age).IsOptional();

            this.Property(p => p.Gender).IsOptional().HasMaxLength(6).HasColumnType("nvarchar");

            this.Property(p => p.HomePhoneNum).IsOptional().HasMaxLength(20).HasColumnType("nvarchar");

            this.Property(p => p.WorkPhoneNum).IsOptional().HasMaxLength(20).HasColumnType("nvarchar");

            this.Property(p => p.MobilePhoneNum).IsOptional().HasMaxLength(200).HasColumnType("nvarchar");

            this.Property(p => p.CreatedOn).IsRequired().HasColumnType("datetime");

            this.Property(p => p.LastModifiedOn).IsRequired().HasColumnType("datetime");

            // Configure UserId as Foreign Key for UserContact with One-To-One Relationship
            //this.HasRequired(uc => uc.User).WithOptional(u => u.UserContact);
        }
    }
}
