using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSmartLife.Model.Model
{
    public class BillAddressContact
    {
        string ShipAddress1 { get; set; }
        string ShipAddress2 { get; set; }
        string ShipCity { get; set; }
        string ShipState { get; set; }
        string ShipPostalZip { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(": {0}, {1}, {2}  {3}", this.ShipAddress1, this.ShipCity, this.ShipState, this.ShipPostalZip);

            return sb.ToString();
        }
    }
}
