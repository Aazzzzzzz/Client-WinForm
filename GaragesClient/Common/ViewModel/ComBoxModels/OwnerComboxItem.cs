using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesClient.Common.HelpFuncs
{
    public class OwnerComboxItem
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}] = {1} {2}", this.Id, this.FirstName, this.LastName);
        }
    }
}
