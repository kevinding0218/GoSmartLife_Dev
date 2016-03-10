using GoSmartLife.Model.Model;
using System;
using System.Data.Entity;

namespace GoSmartLife.DataAccess.Repository
{
    public class Repo_User : GenericRepository<User>
    {
        public Repo_User(DbContext context) : base(context)
        { }
    }
}
