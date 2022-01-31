using GaragesClient.Common.HelpForms.MessageBox;
using GaragesClient.Common.HelpFuncs;
using GaragesClient.Common.ViewModel.ComBoxModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaragesClient.Common.HelpForms
{
    public partial class CreateCar : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private ServiceWebAPI.GarageWebAPIClient Service { get; set; }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private bool closingFormStatus = false;
        private int currentId;
        private string type;
        private ServiceWebAPI.carDto currentCar;
        private List<OwnerComboxItem> listOwnersComboxView = new List<OwnerComboxItem>();
        private List<GarageComboxItem> listGaragesComboxView = new List<GarageComboxItem>();
        #endregion

        #region CTOR
        public CreateCar(ServiceWebAPI.GarageWebAPIClient service, string type = "", int currentId = -1)
        {
            try
            {
                InitializeComponent();
                log.Info("Open CreateForm.");
                this.currentId = currentId;
                this.type = type;
                Service = service;

                var garages = Service.findAllGarages().OrderBy(x => x.id).ToList();
                var owners = Service.findAllOwners().OrderBy(x => x.id).ToList();
                InitForm(garages, owners);

                if (type == "create")
                {
                    this.label_CarTittle.Text = "Create Garage :";
                    this.txtbox_CarId.Visible = false;

                }
                else if (type == "update")
                {
                    this.label_CarTittle.Text = "Update Garage :";
                    this.txtbox_CarId.Visible = true;
                    currentCar = GetCarEntity();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }
        #endregion

        #region Methods
        private void btn_SaveNewCar_Click(object sender, EventArgs e)
        {
            SaveFormEntityCar();
        }
        private ServiceWebAPI.carDto UpdateCar(ServiceWebAPI.carDto car, long ownerId, long garageId)
        {
            log.Info("Start UpdateCar(CarDto car) method.");
            try
            {
                car.id = currentId;
                car.idSpecified = true;
                car.model = this.txtbox_CarModel.Text;
                car.registrationNumber = this.txtbox_CarRegNum.Text;
                car.kilometrage = Convert.ToInt32(this.txtbox_Kilometrage.Text);
                car.kilometrageSpecified = true;
                if (ownerId > 0)
                {
                    car.ownerId = ownerId;
                    car.ownerIdSpecified = true;
                }
                if (garageId > 0)
                {
                    car.garageId = garageId;
                    car.garageIdSpecified = true;
                }
                log.Debug(String.Format("Get Entity car = [{0}]", car.ToString()));
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return car;
        }
        private ServiceWebAPI.carDto CreateNewCar(ServiceWebAPI.carDto car, long ownerId, long garageId)
        {
            log.Info("Start CreateNewCar(CarDto car) method.");
            try
            {

                if (ownerId != 0)
                {
                    car.ownerId = ownerId;
                    car.ownerIdSpecified = true;
                }

                if (garageId != 0)
                {
                    car.garageId = garageId;
                    car.garageIdSpecified = true;
                }

                car.idSpecified = true;
                car.model = this.txtbox_CarModel.Text;
                car.registrationNumber = this.txtbox_CarRegNum.Text;
                car.kilometrage = Convert.ToInt32(this.txtbox_Kilometrage.Text);
                car.kilometrageSpecified = true;
                log.Debug(String.Format("Get Entity car = [{0}]", car.ToString()));
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return car;
        }
        private ServiceWebAPI.carDto GetCarEntity()
        {
            log.Info("Start GetCarEntity() method.");
            ServiceWebAPI.carDto car = null;
            try
            {
                car = Service.findCarById(currentId);
                this.txtbox_CarId.Visible = true;
                this.txtbox_CarId.Text = car.id.ToString();
                this.txtbox_CarModel.Text = car.model;
                this.txtbox_CarRegNum.Text = car.registrationNumber;
                this.txtbox_Kilometrage.Text = car.kilometrage.ToString();
                this.combox_CarOwner.SelectedIndex = listOwnersComboxView.FindIndex(x => x.Id == car.ownerId);
                this.combox_CarGarage.SelectedIndex = listGaragesComboxView.FindIndex(x => x.Id == car.garageId);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return car;
        }
        private void SaveFormEntityCar()
        {
            log.Info("Click button 'Save' for start SaveFormEntity() method Car.");
            try
            {
                var car = new ServiceWebAPI.carDto();
                string response = "";
                string errorMessage = "";
                long ownerId = (this.combox_CarOwner.SelectedIndex > -1) ? listOwnersComboxView[this.combox_CarOwner.SelectedIndex].Id : 0;
                long garageId = (this.combox_CarGarage.SelectedIndex > -1) ? listGaragesComboxView[this.combox_CarGarage.SelectedIndex].Id : 0;
                if (this.txtbox_CarModel.Text == "" || this.txtbox_CarRegNum.Text == "" || this.txtbox_Kilometrage.Text == "" || ownerId == 0 || garageId == 0)
                {
                    errorMessage = "Some required fields is empty for save:\n";
                    errorMessage += (this.txtbox_CarModel.Text == "") ? "- Car model : empty.\n" : "";
                    errorMessage += (this.txtbox_CarRegNum.Text == "") ? "- Registration number : empty.\n" : "";
                    errorMessage += (this.txtbox_Kilometrage.Text == "") ? "- Kilometrage : empty.\n" : "";
                    errorMessage += (ownerId == 0) ? "- Car Owner : empty.\n" : "";
                    errorMessage += (garageId == 0) ? "- Car Garage : empty.\n" : "";

                    var errorBox = new HelpBoxs.ErrorMessageBox("Warnning", "Problem with saving", errorMessage);
                    errorBox.StartPosition = FormStartPosition.CenterParent;
                    errorBox.ShowDialog(this);
                    closingFormStatus = false;
                }

                if (this.txtbox_CarModel.Text != "" && this.txtbox_CarRegNum.Text != "" && this.txtbox_Kilometrage.Text != "" && ownerId != 0 && garageId != 0)
                {

                    if (type == "create")
                    {
                        car = CreateNewCar(car, ownerId, garageId);
                        response = Service.persistCar(car);
                    }
                    else if (type == "update")
                    {
                        car = UpdateCar(car, ownerId, garageId);
                        response = Service.updateCar(car);
                    }
                    log.Debug(response);
                }

                if (response == "Server problem")
                {
                    errorMessage = (errorMessage == "Server problem") ? "Problem with sever saving." : "";

                    var errorBox = new HelpBoxs.ErrorMessageBox("Error", "Problem with saving", errorMessage);
                    errorBox.StartPosition = FormStartPosition.CenterParent;
                    errorBox.ShowDialog(this);

                    closingFormStatus = false;
                }
                else if (response != "Server problem" && response != "")
                {
                    var errorBox = new HelpBoxs.ErrorMessageBox("Success", "Status", "New Garage create : Success", response);
                    errorBox.StartPosition = FormStartPosition.CenterParent;
                    errorBox.ShowDialog(this);
                    closingFormStatus = true;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                var errorBox = new HelpBoxs.ErrorMessageBox("Server problem", "Status", "Server problem", ex.Message);
                errorBox.StartPosition = FormStartPosition.CenterParent;
                errorBox.ShowDialog(this);
            }

            if (closingFormStatus)
                this.Close();
        }
        #endregion
        #region Helps
        private void InitForm(List<ServiceWebAPI.garageDto> garages, List<ServiceWebAPI.ownerDto> owners)
        {
            var ownersForComboBox = from owner in owners
                                    select new
                                    {
                                        Id = owner.id,
                                        FistName = owner.firstName,
                                        LastName = owner.lastName
                                    };
            var garagesForComboBox = from garage in garages
                                     select new
                                     {
                                         Id = garage.id,
                                         SerialNumber = garage.serialNumber
                                     };
            foreach (var ownerItem in ownersForComboBox)
            {
                listOwnersComboxView.Add(new OwnerComboxItem() { Id = ownerItem.Id, FirstName = ownerItem.FistName, LastName = ownerItem.LastName });
            }
            foreach (var garageItem in garagesForComboBox)
            {
                listGaragesComboxView.Add(new GarageComboxItem() { Id = garageItem.Id, SerialNumber = garageItem.SerialNumber });
            }
            this.combox_CarOwner.Items.AddRange(listOwnersComboxView.ToArray());
            this.combox_CarGarage.Items.AddRange(listGaragesComboxView.ToArray());
        }
        #endregion
    }
}
