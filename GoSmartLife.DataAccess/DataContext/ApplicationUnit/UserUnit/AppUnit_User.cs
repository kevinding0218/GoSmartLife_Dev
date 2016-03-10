using GoSmartLife.DataAccess.DataContext;
using GoSmartLife.DataAccess.Repository;
using GoSmartLife.Model.Model;
using System;
using System.Data.Entity;

namespace GoSmartLife.DataAccess.DataContext
{
    public class AppUnit_User : IDisposable
    {
        private DataContext _context = new DataContext();

        #region Repository - UserRole
        private IRepository<UserRole> _userRoles = null;

        public IRepository<UserRole> UserRoles
        {
            get
            {
                if (this._userRoles == null)
                {
                    this._userRoles = new GenericRepository<UserRole>(this._context);
                }
                return this._userRoles;
            }
        }
        #endregion

        #region Repository - UserRole
        private IRepository<User> _users = null;

        public IRepository<User> Users
        {
            get
            {
                if (this._users == null)
                {
                    this._users = new GenericRepository<User>(this._context);
                }
                return this._users;
            }
        }
        #endregion

        #region Repository - UserPassword
        private IRepository<UserPassword> _userPasswords = null;

        public IRepository<UserPassword> UserPasswords
        {
            get
            {
                if (this._userPasswords == null)
                {
                    this._userPasswords = new GenericRepository<UserPassword>(this._context);
                }
                return this._userPasswords;
            }
        }
        #endregion

        #region Repository - UserContact
        private IRepository<UserContact> _userContact = null;

        public IRepository<UserContact> UserContact
        {
            get
            {
                if (this._userContact == null)
                {
                    this._userContact = new GenericRepository<UserContact>(this._context);
                }
                return this._userContact;
            }
        }
        #endregion

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public void Dispose()
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }
    }
}
