using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSmartLife.Model.Model
{
    public class UserRole
    {
        public int RoleId { get; private set; }
        public string RoleDescription { get; set; }
        public int RolePriority { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
