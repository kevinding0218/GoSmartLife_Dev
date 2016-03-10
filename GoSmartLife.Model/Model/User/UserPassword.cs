using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSmartLife.Model.Model
{
    public class UserPassword : IAuditInfo
    {
        public int id { get; private set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public int ErrorLoginCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        
        public virtual User User { get; set; }
    }
}
