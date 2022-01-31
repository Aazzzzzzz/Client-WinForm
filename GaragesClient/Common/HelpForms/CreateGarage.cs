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
    public partial class CreateGarage : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private ServiceWebAPI.GarageWebAPIClient Service { get; set; }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private bool closingFormStatus = false;
        private int currentId;
        private string type;
        private ServiceWebAPI.garageDto currentGarage;
        #endregion

        #region CTOR
        public CreateGarage(ServiceWebAPI.GarageWebAPIClient service, string type = "", int currentId = -1)
        {
            try
            {
                InitializeComponent();
                log.Info("Open CreateForm.");
                this.currentId = currentId;
                this.type = type;
                Service = service;

                if (type == "create")
                {
                    this.label_GarageTittle.Text = "Create Garage :";
                    this.txtbox_GarageId.Visible = false;

                }
                else if (type == "update")
                {
                    this.label_GarageTittle.Text = "Update Garage :";
                    this.txtbox_GarageId.Visible = true;
                    currentGarage = GetGarageEntity();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }
        #endregion
        private void btn_SaveNewGarage_Click(object sender, EventArgs e)
        {
            SaveFormGarage();
        }

        #region Helps
        private ServiceWebAPI.garageDto UpdateGarage(ServiceWebAPI.garageDto garage)
        {
            log.Info("Start UpdateGarage(GarageDto garage) method.");
            try
            {
                garage.id = currentId;
                garage.idSpecified = true;
                garage.serialNumber = this.txtbox_GarageSerialNum.Text;
                garage.address = this.txtbox_GarageAddress.Text;
                garage.maxCars = Convert.ToInt32(this.numUpDown_GarageMaxCars.Value);
                garage.maxCarsSpecified = true;
                log.Debug(String.Format("Get Entity garage = [{0}]", garage.ToString()));
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return garage;
        }
        private ServiceWebAPI.garageDto CreateNewGarage(ServiceWebAPI.garageDto garage)
        {
            log.Info("Start CreateNewGarage(GarageDto garage) method.");
            try
            {
                garage.idSpecified = true;
                garage.serialNumber = this.txtbox_GarageSerialNum.Text;
                garage.address = this.txtbox_GarageAddress.Text;
                garage.maxCars = Convert.ToInt32(this.numUpDown_GarageMaxCars.Value);
                garage.maxCarsSpecified = true;
                log.Debug(String.Format("Get Entity garage = [{0}]", garage.ToString()));
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return garage;
        }
        private ServiceWebAPI.garageDto GetGarageEntity()
        {
            log.Info("Start GetGarageEntity() method.");
            ServiceWebAPI.garageDto garage = null;
            try
            {
                garage = Service.findGarageById(currentId);
                this.txtbox_GarageId.Visible = true;
                this.txtbox_GarageId.Text = garage.id.ToString();
                this.txtbox_GarageSerialNum.Text = garage.serialNumber;
                this.txtbox_GarageAddress.Text = garage.address;
                this.numUpDown_GarageMaxCars.Value = garage.maxCars;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return garage;
        }
        private void SaveFormGarage()
        {
            log.Info("Click button 'Save' for start SaveFormEntity() method Garage.");
            try
            {
                var garage = new ServiceWebAPI.garageDto();
                string response = "";
                string errorMessage = "";
                if (this.txtbox_GarageSerialNum.Text == "" || this.txtbox_GarageAddress.Text == "")
                {
                    errorMessage = "Some required fields is empty for save:\n";
                    errorMessage += (this.txtbox_GarageSerialNum.Text == "") ? "- Serial Number : empty.\n" : "";
                    errorMessage += (this.txtbox_GarageAddress.Text == "") ? "- Addreess : empty.\n" : "";

                    var errorBox = new HelpBoxs.ErrorMessageBox("Warnning", "Problem with saving", errorMessage);
                    errorBox.StartPosition = FormStartPosition.CenterParent;
                    errorBox.ShowDialog(this);
                    closingFormStatus = false;
                }

                if (this.txtbox_GarageSerialNum.Text != "" && this.txtbox_GarageAddress.Text != "")
                {
                    if (type == "create")
                    {
                        garage = CreateNewGarage(garage);
                        response = Service.persistGarage(garage);
                    }
                    else if (type == "update")
                    {
                        garage = UpdateGarage(garage);
                        response = Service.updateGarage(garage);
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
    }
}
