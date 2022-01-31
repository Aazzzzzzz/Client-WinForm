using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesClient.Common.ViewModel.ComBoxModels
{
    public class GarageComboxItem
    {
        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public override string ToString()
        {
            return String.Format("[{0}] = {1}", this.Id, this.SerialNumber);
        }
    }
}
