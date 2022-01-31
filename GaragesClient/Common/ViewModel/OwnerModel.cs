using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesClient.Common.ViewModel
{
    public class OwnerModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactPhone { get; set; }
        public static List<OwnerModel> OwnerDtoToOwnerView(List<ServiceWebAPI.ownerDto> owners)
        {
            List<OwnerModel> ownersView = new List<OwnerModel>();
            foreach (var item in owners)
            {
                OwnerModel model = new OwnerModel() { Id = item.id, FirstName = item.firstName, LastName = item.lastName, ContactPhone = item.contactPhone };
                ownersView.Add(model);
            }
            return ownersView;
        }
    }
}
