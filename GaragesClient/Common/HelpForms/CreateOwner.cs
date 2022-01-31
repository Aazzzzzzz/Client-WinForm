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
    public partial class CreateOwner : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private ServiceWebAPI.GarageWebAPIClient Service { get; set; }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private bool closingFormStatus = false;
        private int id;
        private string type;
        private ServiceWebAPI.ownerDto currentOwner;
        #endregion

        #region CTOR
        public CreateOwner(ServiceWebAPI.GarageWebAPIClient service, string type = "", int currentId = -1)
        {
            try
            {
                log.Info("Open Create/Update Form.");
                Service = service;
                InitializeComponent();
                this.id = currentId;
                this.type = type;
                if (type == "create")
                {
                    this.label_OwnerTittle.Text = "Create Garage :";
                    this.txtbox_OwnerId.Visible = false;

                }
                else if (type == "update")
                {
                    this.label_OwnerTittle.Text = "Update Garage :";
                    this.txtbox_OwnerId.Visible = true;
                    currentOwner = GetOwnerEntity();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }
        #endregion

        #region Methods

        private void btn_SaveNewOwner_Click(object sender, EventArgs e)
        {
            if (type == "create")
            {
                log.Info("Start Create new owner.");
                CreateNewOwner();

            }
            else if (type == "update")
            {
                log.Info("Start Update exiting owner.");
                UpdateOwner();
            }

        }
        #endregion

        #region Helps
        private void UpdateOwner()
        {
            log.Info("Start to Update OwnerEntity and fill the form.");
            currentOwner.firstName = this.txtbox_OwnerFirstName.Text;
            currentOwner.lastName = this.txtbox_OwnerFirstName.Text;
            currentOwner.contactPhone = this.txtbox_OwnerContactPhone.Text;
            Service.updateOwner(currentOwner);
            closingFormStatus = true;
            if (closingFormStatus)
                this.Close();
        }
        private ServiceWebAPI.ownerDto GetOwnerEntity()
        {
            log.Info("Get OwnerEntity and fill the form.");
            var owner = Service.findOwnerById(id);
            this.txtbox_OwnerId.Visible = true;
            this.txtbox_OwnerId.Text = owner.id.ToString();
            this.txtbox_OwnerFirstName.Text = owner.firstName;
            this.txtbox_OwnerLastName.Text = owner.lastName;
            this.txtbox_OwnerContactPhone.Text = owner.contactPhone;
            return owner;
        }
        private void CreateNewOwner()
        {
            try
            {
                log.Info("Click button 'Save' for start create new Owner.");
                var owner = new ServiceWebAPI.ownerDto();
                string response = "";
                string errorMessage = "";
                if (txtbox_OwnerFirstName.Text == "" || txtbox_OwnerLastName.Text == "" || txtbox_OwnerContactPhone.Text == "")
                {
                    errorMessage = "Some required fields is empty for save:\n";
                    errorMessage += (txtbox_OwnerFirstName.Text == "") ? "- First name : empty.\n" : "";
                    errorMessage += (txtbox_OwnerLastName.Text == "") ? "- Last name : empty.\n" : "";
                    errorMessage += (txtbox_OwnerContactPhone.Text == "") ? "- Contact phone : empty.\n" : "";

                    var errorBox = new HelpBoxs.ErrorMessageBox("Warnning", "Problem with saving", errorMessage);
                    errorBox.StartPosition = FormStartPosition.CenterParent;
                    errorBox.ShowDialog(this);

                    closingFormStatus = false;
                }
                if (txtbox_OwnerFirstName.Text != "" && txtbox_OwnerLastName.Text != "" && txtbox_OwnerContactPhone.Text != "")
                {
                    owner.idSpecified = true;
                    owner.firstName = this.txtbox_OwnerFirstName.Text;
                    owner.lastName = this.txtbox_OwnerLastName.Text;
                    owner.contactPhone = this.txtbox_OwnerContactPhone.Text;
                    log.Debug(String.Format("Obj entity: [{0}]", owner.ToString()));
                    response = Service.persistOwner(owner);
                    log.Debug(response);
                }
                if (response == "Server problem" || response.Contains("OwnerDto object"))
                {
                    errorMessage = (errorMessage == "Server problem") ? "Problem with sever saving." : "";

                    var errorBox = new HelpBoxs.ErrorMessageBox("Error", "Problem with saving", response + errorMessage);
                    errorBox.StartPosition = FormStartPosition.CenterParent;
                    errorBox.ShowDialog(this);

                    closingFormStatus = false;
                }
                else if (response != "Server problem" && response != "")
                {
                    var errorBox = new HelpBoxs.ErrorMessageBox("Success", "Status", "New Owner create: Success", response);
                    errorBox.StartPosition = FormStartPosition.CenterParent;
                    errorBox.ShowDialog(this);
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
        private void InitForm(List<ServiceWebAPI.carDto> cars)
        {
            var carsForComBox = from car in cars
                                select new
                                {
                                    Id = car.id,
                                    RegNumber = car.registrationNumber
                                };

            //this.combox_OwnerCar.Items.AddRange(carsForComBox.ToArray());

        }
        #endregion
    }
}
