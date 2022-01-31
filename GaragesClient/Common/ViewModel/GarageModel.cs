using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesClient.Common.ViewModel
{
    public class GarageModel
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public string SerialNumber { get; set; }
        public int MaxCars { get; set; }
        public static List<GarageModel> GarageDtoToGarageView(List<ServiceWebAPI.garageDto> garages)
        {
            List<GarageModel> garagesView = new List<GarageModel>();
            foreach (var item in garages)
            {
                GarageModel model = new GarageModel() { Id = item.id, Address = item.address, MaxCars = item.maxCars, SerialNumber = item.serialNumber };
                garagesView.Add(model);
            }
            return garagesView;
        }
    }
}
