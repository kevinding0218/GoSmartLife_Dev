using GoSmartLife.Model.Model;
using System;
using System.Data.Entity;

namespace GoSmartLife.DataAccess.Repository
{
    public class Repo_UserRole : GenericRepository<UserRole>
    {
        public Repo_UserRole(DbContext context)
            : base(context)
        { }
    }
}
