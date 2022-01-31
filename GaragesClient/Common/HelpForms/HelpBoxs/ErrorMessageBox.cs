using GaragesClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaragesClient.Common.HelpForms.HelpBoxs
{
    public partial class ErrorMessageBox : DevExpress.XtraEditors.XtraForm
    {
        public bool statusOk = false;

        private bool checkDetails = false;
        public ErrorMessageBox(string type, string tittle, string message, string details = "")
        {
            InitializeComponent();
            this.Text = type;
            this.label_ErrorHeader.Text = tittle;
            this.rtxtbox_ErrorMessage.Text = message;
            this.rtxtbox_ErrorDetails.Text = details;
            if (type == "Success")
            {
                picbox_Error.Visible = false;
            }
        }

        private void btn_ErrorOk_Click(object sender, EventArgs e)
        {
            statusOk = true;
            this.Close();
        }

        private void btn_ErrorDetails_Click(object sender, EventArgs e)
        {
            checkDetails = (checkDetails) ? false : true;
            rtxtbox_ErrorDetails.Visible = (checkDetails) ? checkDetails : false;
        }

        private void btn_ErrorCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
