using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSmartLife.Model.Model
{
    public class MailAddressContact
    {
        string MailAddress1 { get; set; }
        string MailAddress2 { get; set; }
        string MailCity { get; set; }
        string MailState { get; set; }
        string MailPostalZip { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(": {0}, {1}, {2}  {3}", this.MailAddress1, this.MailCity, this.MailState, this.MailPostalZip);

            return sb.ToString();
        }
    }
}
