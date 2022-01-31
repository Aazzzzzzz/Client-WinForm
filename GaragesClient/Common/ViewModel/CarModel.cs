using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesClient.Common.ViewModel
{
    public class CarModel
    {
        public long Id { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber{ get; set; }
        public int Kilometrage { get; set; }
        public long GarageId { get; set; }
        public long OwnerId { get; set; }
        public static List<CarModel> CarDtoToCarView(List<ServiceWebAPI.carDto> cars)
        {
            List<CarModel> carsView = new List<CarModel>();
            foreach (var item in cars)
            {
                CarModel model = new CarModel() { Id = item.id, Model = item.model, RegistrationNumber = item.registrationNumber, Kilometrage = item.kilometrage, GarageId = item.garageId, OwnerId = item.ownerId };
                carsView.Add(model);
            }
            return carsView;
        }
    }
}