using GoSmartLife.Model.Model;
using System;
using System.Data.Entity;

namespace GoSmartLife.DataAccess.Repository
{
    public class Repo_UserContact : GenericRepository<UserContact>
    {
        public Repo_UserContact(DbContext context) : base(context)
        {

        }
    }
}
