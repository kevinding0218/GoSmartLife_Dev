using GoSmartLife.Model.Model;
using System;
using System.Data.Entity;

namespace GoSmartLife.DataAccess.Repository
{
    public class Repo_UserPassword : GenericRepository<UserPassword>
    {
        public Repo_UserPassword(DbContext context) : base(context)
        {

        }
    }
}
