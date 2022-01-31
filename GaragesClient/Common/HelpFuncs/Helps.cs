using GaragesClient.Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesClient.Common.HelpFuncs
{
    public static class Helps
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static List<GarageModel> GetAllGarages(ServiceWebAPI.GarageWebAPIClient webAPI, List<ServiceWebAPI.garageDto> allGarages)
        {
            List<GarageModel> garageModels = null;
            try
            {
                log.Info(" Start method => GetAllGarages(ServiceWebAPI.GarageWebAPIClient webAPI, List<ServiceWebAPI.garageDto> allGarages)");
                allGarages = webAPI.findAllGarages().OrderBy(x => x.id).ToList();
                garageModels = GarageModel.GarageDtoToGarageView(allGarages);
                log.Info(String.Format("Result: Get AllGarages[{0}]", garageModels.Count));
            }
            catch(Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return garageModels;
        }
        public static List<CarModel> GetAllCars(ServiceWebAPI.GarageWebAPIClient webAPI, List<ServiceWebAPI.carDto> allCars)
        {
            List<CarModel> carModels = null;
            try
            {
                log.Info(" Start method => GetAllCars(ServiceWebAPI.GarageWebAPIClient webAPI, List<ServiceWebAPI.carDto> allCars)");
                allCars = webAPI.findAllCars().OrderBy(x => x.id).ToList();
                carModels = CarModel.CarDtoToCarView(allCars);
                log.Info(String.Format("Result: Get AllCars[{0}]", carModels.Count));
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return carModels;
        }
        public static List<OwnerModel> GetAllOwners(ServiceWebAPI.GarageWebAPIClient webAPI, List<ServiceWebAPI.ownerDto> allOwners)
        {
            List<OwnerModel> ownerModels = null;
            try
            {
                log.Info(" Start method => GetAllOwners(GarageWebAPIClient webAPI, List<OwnerDto> allOwners)");
                allOwners = webAPI.findAllOwners().OrderBy(x => x.id).ToList();
                ownerModels = OwnerModel.OwnerDtoToOwnerView(allOwners);
                log.Info(String.Format("Result: Get AllOwners[{0}]", ownerModels.Count));
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return ownerModels;
        }
        public static List<InfoTotalModel> GetAllInfoTotal(ServiceWebAPI.GarageWebAPIClient webAPI, List<ServiceWebAPI.infoTotalDto> info)
        {
            List<InfoTotalModel> infoTotalModels = null;
            try
            {
                log.Info(" Start method => GetAllInfoTotal(ServiceWebAPI.GarageWebAPIClient webAPI, List<ServiceWebAPI.infoTotalDto> info)");
                info = webAPI.getInfoTotal().ToList();
                infoTotalModels = InfoTotalModel.IntoTotalView(info);
                log.Info(String.Format("Result: Get AllInfoTotal[{0}]", infoTotalModels.Count));
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return infoTotalModels;
        }
        public static List<InfoTotalModel> GetFilterInfoTotal(ServiceWebAPI.GarageWebAPIClient webAPI, List<ServiceWebAPI.infoTotalDto> info, string carRegistrationNumber = "", string ownerFirstName = "", string ownerLastName = "", string garageSerialNumber = "")
        {
            List<InfoTotalModel> infoTotalModels = null;
            try
            {
                log.Info(" Start method => GetFilterInfoTotal(ServiceWebAPI.GarageWebAPIClient webAPI, List<ServiceWebAPI.infoTotalDto> info, string carRegistrationNumber, string ownerFirstName, string ownerLastName , string garageSerialNumber");
                info = webAPI.getFilterInfoTotal(carRegistrationNumber, ownerFirstName, ownerLastName, garageSerialNumber).ToList();
                infoTotalModels = InfoTotalModel.IntoTotalView(info);
                log.Info(String.Format("Result: Get FilterInfoTotal[{0}]", infoTotalModels.Count));
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return infoTotalModels;
        }
    }
}
