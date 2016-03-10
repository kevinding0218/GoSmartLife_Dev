using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSmartLife.Model.Model
{
    public class User : IAuditInfo
    {
        public User()
        {
            UserPasswords = new List<UserPassword>();
        }
        /// <summary>
        /// PK
        /// </summary>
        public int UserId { get; private set; }

        /// <summary>
        /// Email Address also as Login Name
        /// </summary>
        public string EmailAddress { get; set; }
        public bool Active { get; set; }
        public int RoleId { get; set; }
        public DateTime LastLogIn { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }

        /// <summary>
        /// One to Many
        /// </summary>
        public virtual ICollection<UserPassword> UserPasswords { get; set; }

        /// <summary>
        /// One to One
        /// </summary>
        public virtual UserRole UserRole { get; set; }

        /// <summary>
        /// One to One
        /// </summary>
        public virtual UserContact UserContact { get; set; }
    }
}
