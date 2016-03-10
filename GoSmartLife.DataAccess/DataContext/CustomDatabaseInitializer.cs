using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using GoSmartLife.Model.Model;

namespace GoSmartLife.DataAccess.DataContext
{
    public class CustomDatabaseInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var seed_create_time = DateTime.Now;
            // User Role Seeds
            var roles = new List<UserRole>
            {
                new UserRole{
                    RoleDescription = "Administrator",
                    RolePriority = 1
                },
                new UserRole{
                    RoleDescription = "Premium",
                    RolePriority = 2
                },
                new UserRole{
                    RoleDescription = "Standard",
                    RolePriority = 3
                },
                new UserRole{
                    RoleDescription = "Visitor",
                    RolePriority = 4
                }
            };
            roles.ForEach(r => context.UserRoles.Add(r));
            context.SaveChanges();

            // User Seeds
            var users = new List<User>
            {
                new User{
                    EmailAddress = "kevinding0218@gmail.com",
                    Active = true,
                    RoleId = 1,
                    LastLogIn = seed_create_time,
                    CreatedOn = seed_create_time,
                    LastModifiedOn = seed_create_time
                }
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            // User Password Seeds
            var userpasswords = new List<UserPassword>
            {
                new UserPassword{
                    UserId = 1,
                    Password = "abc",
                    ErrorLoginCount = 0,
                    CreatedOn = seed_create_time,
                    LastModifiedOn = seed_create_time
                }
            };
            userpasswords.ForEach(up => context.UserPasswords.Add(up));
            context.SaveChanges();

            //User Contact Seeds
            var userContacts = new List<UserContact>
            {
                new UserContact{
                    UserId = 1,
                    FirstName = "Kevin",
                    LastName = "Ding",
                    CreatedOn = seed_create_time,
                    LastModifiedOn = seed_create_time
                }
            };
            userContacts.ForEach(uc => context.UserContacts.Add(uc));
            context.SaveChanges();


            base.Seed(context);
        }
    }
}
