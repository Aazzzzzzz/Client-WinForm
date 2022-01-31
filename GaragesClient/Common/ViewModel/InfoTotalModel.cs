using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesClient.Common.ViewModel
{
    public class InfoTotalModel
    {
        public string GarageSerialNumber { get; set; }
        public string GarageAddress { get; set; }
        public string CarModel { get; set; }
        public string CarRegistrationNumber { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoneNumber { get; set; }


        public static List<InfoTotalModel> IntoTotalView(List<ServiceWebAPI.infoTotalDto> infoList)
        {
            List<InfoTotalModel> totalInfoView = new List<InfoTotalModel>();
            foreach (var item in infoList)
            {
                InfoTotalModel model = new InfoTotalModel() 
                {
                    GarageSerialNumber = item.garageSerialNumber,
                    GarageAddress = item.garageAddress,
                    CarModel = item.carModel,
                    CarRegistrationNumber = item.carRegistrationNumber,
                    OwnerName = item.ownerFirstName + " " + item.ownerLastName,
                    OwnerPhoneNumber = item.ownerPhoneNumber,
                };
                totalInfoView.Add(model);
            }
            return totalInfoView;
        }
    }
}
