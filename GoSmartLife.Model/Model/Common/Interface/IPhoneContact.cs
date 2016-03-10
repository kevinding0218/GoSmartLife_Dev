using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSmartLife.Model.Model
{
    public interface IPhoneContact
    {
        string HomePhoneNum { get; set; }
        string WorkPhoneNum { get; set; }
        string MobilePhoneNum { get; set; }
    }
}
