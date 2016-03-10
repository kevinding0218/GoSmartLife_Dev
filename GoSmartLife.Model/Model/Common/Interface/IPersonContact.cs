using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSmartLife.Model.Model
{
    public interface IPersonContact
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Gender { get; set; }
    }
}
