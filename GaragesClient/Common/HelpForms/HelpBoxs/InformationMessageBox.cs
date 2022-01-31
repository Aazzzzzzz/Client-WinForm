using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaragesClient.Common.HelpForms.MessageBox
{
    public partial class InformationMessageBox : DevExpress.XtraEditors.XtraForm
    {
        private bool checkDetails = false;
        public InformationMessageBox(string tittle, string message, string details = "")
        {
            InitializeComponent();
            this.label_InfoHeader.Text = tittle;
            this.rtxtbox_InfoMessage.Text = message;
            this.rtxtbox_InfoDetails.Text = details;
        }

        private void btn_InfoDetails_Click(object sender, EventArgs e)
        {
            checkDetails = (checkDetails) ? false : true;
            rtxtbox_InfoDetails.Visible = (checkDetails) ? checkDetails : false;
        }

        private void btn_InfoOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
