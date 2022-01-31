using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using GaragesClient.Common.HelpForms;
using GaragesClient.Common.HelpFuncs;
using GaragesClient.Common.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GaragesClient
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private ServiceWebAPI.GarageWebAPIClient webAPI = new ServiceWebAPI.GarageWebAPIClient("GarageWebAPIPort");
        #endregion

        #region Properties
        private List<ServiceWebAPI.infoTotalDto> AllTotalInfo { get; set; }
        private List<ServiceWebAPI.garageDto> AllGarages { get; set; }
        private List<ServiceWebAPI.carDto> AllCars { get; set; }
        private List<ServiceWebAPI.ownerDto> AllOwners { get; set; }
        #endregion

        #region CTOR
        public MainForm()
        {
            log.Info("Start Garages Client => MainForm() method.");
            InitializeComponent();
            InitData();
        }

        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoTittleButton.Text = tabControl1.TabPages[tabControl1.SelectedIndex].Text;
            if (tabControl1.SelectedIndex != 0)
            {
                btnCreate.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
            }
            else
            {
                btnCreate.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
        }
        public void ReloadTotalInfoData()
        {
            FilterSearch();
        }
        public List<GarageModel> ReloadGaragesData(int selectedIndex = 0)
        {
            List<GarageModel> list = Helps.GetAllGarages(webAPI, AllGarages);
            try
            {
                garagesDataGridView.DataSource = list;
                garagesDataGridView.ClearSelection();
                garagesDataGridView.Rows[selectedIndex].Selected = true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            return list;
        }
        public List<OwnerModel> ReloadOwnersData(int selectedIndex = 0)
        {
            List<OwnerModel> list = new List<OwnerModel>();
            try
            {
                list = Helps.GetAllOwners(webAPI, AllOwners);
                ownersDataGridView.DataSource = list;
                ownersDataGridView.ClearSelection();
                ownersDataGridView.Rows[(selectedIndex != 0) ? selectedIndex : 0].Selected = true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            return list;
        }
        public List<CarModel> ReloadCarsData(int selectedIndex = 0)
        {
            List<CarModel> list = new List<CarModel>();
            try
            {
                list = Helps.GetAllCars(webAPI, AllCars);
                carsDataGridView.DataSource = list;
                carsDataGridView.ClearSelection();
                carsDataGridView.Rows[selectedIndex].Selected = true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            return list;
        }


        private void InitData()
        {
            try
            {
                ReloadTotalInfoData();
                List<GarageModel>  listGarage = ReloadGaragesData();
                List<OwnerModel> listOwners = ReloadOwnersData();
                List<CarModel> listCar = ReloadCarsData();

                TestLookupedit(listCar, listOwners, listGarage);

            }
            catch (Exception ex)
            {
                log.Error(ex);
                var msgBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Server Problem", "Server is Shutdown", "Server problem", ex.Message);
                msgBox.StartPosition = FormStartPosition.CenterParent;
                msgBox.ShowDialog(this);
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    log.Info("Click 'Create' button by Garages.");
                    var createGarage = new CreateGarage(webAPI, "create");
                    createGarage.StartPosition = FormStartPosition.CenterParent;
                    createGarage.ShowDialog(this);
                    break;

                case 2:
                    log.Info("Click 'Create' button by Owners.");
                    var createOwner = new CreateOwner(webAPI, "create");
                    createOwner.StartPosition = FormStartPosition.CenterParent;
                    createOwner.ShowDialog(this);
                    break;

                case 3:
                    log.Info("Click 'Create' button by Cars.");
                    var createCar = new CreateCar(webAPI, "create");
                    createCar.StartPosition = FormStartPosition.CenterParent;
                    createCar.ShowDialog(this);
                    break;
            }
            InitData();
        }
        private void btnReconnect_Click(object sender, EventArgs e)
        {
            InitData();
        }
        private void infoTittleButton_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    FilterSearch();
                    break;
                case 1:
                    ReloadGaragesData();
                    break;

                case 2:
                    ReloadOwnersData();
                    break;

                case 3:
                    ReloadCarsData();
                    break;
                case 4:
                    InitData();
                    break;
            }
        }

        private void TestLookupedit(List<CarModel> listCars = null, List<OwnerModel> listOwners = null, List<GarageModel> listGarage = null)
        {
            RepositoryItemLookUpEdit repositoryItemOwner = new RepositoryItemLookUpEdit();
            repositoryItemOwner.DataSource = listOwners;
            repositoryItemOwner.DisplayMember = "ContactPhone";
            repositoryItemOwner.ValueMember = "Id";
            repositoryItemOwner.NullText = "";
            repositoryItemOwner.PopupFormMinSize = new Size(200, 150);

            RepositoryItemLookUpEdit repositoryItemGarage = new RepositoryItemLookUpEdit();
            repositoryItemGarage.DataSource = listGarage;
            repositoryItemGarage.DisplayMember = "SerialNumber";
            repositoryItemGarage.ValueMember = "Id";
            repositoryItemGarage.NullText = "";
            repositoryItemGarage.PopupFormMinSize = new Size(200, 150);

            gridControl1.DataSource = listCars;

            gridView1.Columns["OwnerId"].ColumnEdit = repositoryItemOwner;
            gridView1.Columns["GarageId"].ColumnEdit = repositoryItemGarage;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 1:
                        int garagesId = Convert.ToInt32(garagesDataGridView.Rows[garagesDataGridView.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show(String.Format("Selected GarageId = [{0}]", garagesId));
                        log.Info("Click 'Update' button by Garages.");
                        var createGarage = new CreateGarage(webAPI, "update", garagesId);
                        createGarage.StartPosition = FormStartPosition.CenterParent;
                        createGarage.ShowDialog(this);
                        ReloadGaragesData(garagesDataGridView.SelectedRows[0].Index);
                        break;

                    case 2:
                        int ownerId = Convert.ToInt32(ownersDataGridView.Rows[ownersDataGridView.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show(String.Format("Selected 'OwnerID' = [{0}]", ownerId));
                        log.Info("Click 'Update' button by Owner.");
                        var createOwner = new CreateOwner(webAPI, "update", ownerId);
                        createOwner.StartPosition = FormStartPosition.CenterParent;
                        createOwner.ShowDialog(this);
                        ReloadOwnersData(ownersDataGridView.SelectedRows[0].Index);
                        break;

                    case 3:
                        int carId = Convert.ToInt32(carsDataGridView.Rows[carsDataGridView.SelectedRows[0].Index].Cells[0].Value);
                        MessageBox.Show(String.Format("Selected 'OwnerID' = [{0}]", carId));
                        log.Info("Click 'Update' button by Car.");
                        var createCar = new CreateCar(webAPI, "update", carId);
                        createCar.StartPosition = FormStartPosition.CenterParent;
                        createCar.ShowDialog(this);
                        ReloadCarsData(carsDataGridView.SelectedRows[0].Index);
                        break;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.Message, " Problem with update ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            string cars = "";
            try
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 1:
                        int garagesId = 0;
                        try
                        {
                            garagesId = Convert.ToInt32(garagesDataGridView.Rows[garagesDataGridView.SelectedRows[0].Index].Cells[0].Value);
                            webAPI.deleteGarageById(garagesId);
                            InitData();
                            var msgBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Succsess", "Garage", "Delete : Succsess", garagesId.ToString());
                            msgBox.StartPosition = FormStartPosition.CenterParent;
                            msgBox.ShowDialog(this);
                        }
                        catch (Exception ex)
                        {
                            var msgBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Error", "Problem with delete", "Delete : Fail", garagesId.ToString());
                            msgBox.StartPosition = FormStartPosition.CenterParent;
                            msgBox.ShowDialog(this);
                        }
                        break;

                    case 2:
                        //int selectedOwnereId = ownersDataGridView.SelectedRows[0].Index;
                        int ownerId = Convert.ToInt32(ownersDataGridView.Rows[ownersDataGridView.SelectedRows[0].Index].Cells[0].Value);
                        List<ServiceWebAPI.carDto> findList = webAPI.findAllCars().ToList();

                        findList = findList.FindAll(x => x.ownerId == ownerId).ToList();
                        errorMessage = String.Format("Owner: id [{0}]\nContinue delete?", ownerId);
                        if (findList.Count != 0)
                        {
                            errorMessage = String.Format("Owner has {0} cars.\nAll cars by this owner will be delete too.\nContinue delete?", findList.Count);
                            cars = "Cars : ";
                            findList.ForEach(x => cars += x.registrationNumber + ", ");
                        }
                        var errorOwnerBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Warnning", "Warnning", errorMessage, cars);
                        errorOwnerBox.StartPosition = FormStartPosition.CenterParent;
                        errorOwnerBox.ShowDialog(this);
                        if (errorOwnerBox.statusOk == true)
                            try
                            {
                                webAPI.deleteOwnerById(ownerId);
                                var msgBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Succsess", "Owner", "Delete : Succsess", cars);
                                msgBox.StartPosition = FormStartPosition.CenterParent;
                                msgBox.ShowDialog(this);
                            }
                            catch (Exception ex)
                            {
                                var msgBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Error", "Problem with delete", "Delete : Fail", cars);
                                msgBox.StartPosition = FormStartPosition.CenterParent;
                                msgBox.ShowDialog(this);
                            }

                        InitData();
                        break;

                    case 3:
                        int carId = Convert.ToInt32(carsDataGridView.Rows[carsDataGridView.SelectedRows[0].Index].Cells[0].Value);
                        errorMessage = String.Format("Car: id [{0}]\nContinue delete?", carId);
                        var errorCarBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Warnning", "Warnning", errorMessage);
                        errorCarBox.StartPosition = FormStartPosition.CenterParent;
                        errorCarBox.ShowDialog(this);
                        if (errorCarBox.statusOk == true)
                            try
                            {
                                webAPI.deleteCarById(carId);
                                var msgBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Succsess", "Car", "Delete : Succsess", String.Format("Car: id[{0}]", carId));
                                msgBox.StartPosition = FormStartPosition.CenterParent;
                                msgBox.ShowDialog(this);
                            }
                            catch (Exception ex)
                            {
                                var msgBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Error", "Problem with delete", "Delete : Fail", String.Format("Car: id[{0}].", carId) + ex.Message);
                                msgBox.StartPosition = FormStartPosition.CenterParent;
                                msgBox.ShowDialog(this);
                            }
                        InitData();
                        break;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                var msgBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Server Problem", "Problem server with delete", "Delete : Fail", ex.Message);
                msgBox.StartPosition = FormStartPosition.CenterParent;
                msgBox.ShowDialog(this);
            }
        }

        private void FilterSearch_Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterSearch(txtbox_filterCarRegNumber.Text, txtbox_filterOwnerFName.Text, txtbox_filterOwnerLName.Text, txtbox_filterGarageSerialNumber.Text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterSearch(txtbox_filterCarRegNumber.Text, txtbox_filterOwnerFName.Text, txtbox_filterOwnerLName.Text, txtbox_filterGarageSerialNumber.Text);
        }

        private void FilterSearch(string carRegNum = "", string ownerFN = "", string ownerLN = "", string garageSerNum = "")
        {
            try
            {
                List<InfoTotalModel> list = Helps.GetFilterInfoTotal(webAPI, AllTotalInfo, carRegNum, ownerFN, ownerLN, garageSerNum);
                int count = (list != null) ? list.Count : 0;
                InfoTotalDataGridView.DataSource = list;

                // Search Message
                //string msg = String.Format("Search result = {0} elements", count);
                //var errorBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Success", "Status", msg, count.ToString());
                //errorBox.StartPosition = FormStartPosition.CenterParent;
                //errorBox.ShowDialog(this);
            }
            catch (Exception ex)
            {
                var msgBox = new Common.HelpForms.HelpBoxs.ErrorMessageBox("Error", "Problem with Search", "Please change options", ex.Message);
                msgBox.StartPosition = FormStartPosition.CenterParent;
                msgBox.ShowDialog(this);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbox_filterCarRegNumber.Text = "";
            txtbox_filterGarageSerialNumber.Text = "";
            txtbox_filterOwnerFName.Text = "";
            txtbox_filterOwnerLName.Text = "";
            FilterSearch();
        }
    }
}
