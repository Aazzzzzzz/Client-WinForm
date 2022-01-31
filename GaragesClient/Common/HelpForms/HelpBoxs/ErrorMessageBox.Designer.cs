
namespace GaragesClient.Common.HelpForms.HelpBoxs
{
    partial class ErrorMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorMessageBox));
            this.picbox_Error = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ErrorHeader = new System.Windows.Forms.Button();
            this.rtxtbox_ErrorDetails = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ErrorDetails = new System.Windows.Forms.Button();
            this.btn_ErrorCancel = new System.Windows.Forms.Button();
            this.btn_ErrorOk = new System.Windows.Forms.Button();
            this.rtxtbox_ErrorMessage = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Error)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbox_Error
            // 
            this.picbox_Error.Dock = System.Windows.Forms.DockStyle.Left;
            this.picbox_Error.Image = ((System.Drawing.Image)(resources.GetObject("picbox_Error.Image")));
            this.picbox_Error.Location = new System.Drawing.Point(0, 0);
            this.picbox_Error.Name = "picbox_Error";
            this.picbox_Error.Size = new System.Drawing.Size(96, 80);
            this.picbox_Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_Error.TabIndex = 0;
            this.picbox_Error.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_ErrorHeader);
            this.panel1.Controls.Add(this.picbox_Error);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 80);
            this.panel1.TabIndex = 1;
            // 
            // label_ErrorHeader
            // 
            this.label_ErrorHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ErrorHeader.Enabled = false;
            this.label_ErrorHeader.FlatAppearance.BorderSize = 0;
            this.label_ErrorHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_ErrorHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ErrorHeader.Location = new System.Drawing.Point(96, 0);
            this.label_ErrorHeader.Name = "label_ErrorHeader";
            this.label_ErrorHeader.Size = new System.Drawing.Size(302, 80);
            this.label_ErrorHeader.TabIndex = 6;
            this.label_ErrorHeader.Text = "Header";
            this.label_ErrorHeader.UseVisualStyleBackColor = true;
            // 
            // rtxtbox_ErrorDetails
            // 
            this.rtxtbox_ErrorDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtbox_ErrorDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbox_ErrorDetails.Location = new System.Drawing.Point(0, 212);
            this.rtxtbox_ErrorDetails.Name = "rtxtbox_ErrorDetails";
            this.rtxtbox_ErrorDetails.ReadOnly = true;
            this.rtxtbox_ErrorDetails.Size = new System.Drawing.Size(398, 98);
            this.rtxtbox_ErrorDetails.TabIndex = 8;
            this.rtxtbox_ErrorDetails.Text = "";
            this.rtxtbox_ErrorDetails.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ErrorDetails);
            this.panel2.Controls.Add(this.btn_ErrorCancel);
            this.panel2.Controls.Add(this.btn_ErrorOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 39);
            this.panel2.TabIndex = 9;
            // 
            // btn_ErrorDetails
            // 
            this.btn_ErrorDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ErrorDetails.FlatAppearance.BorderSize = 0;
            this.btn_ErrorDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ErrorDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ErrorDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ErrorDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ErrorDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ErrorDetails.Location = new System.Drawing.Point(0, 0);
            this.btn_ErrorDetails.Name = "btn_ErrorDetails";
            this.btn_ErrorDetails.Size = new System.Drawing.Size(113, 39);
            this.btn_ErrorDetails.TabIndex = 6;
            this.btn_ErrorDetails.Text = "details";
            this.btn_ErrorDetails.UseVisualStyleBackColor = true;
            this.btn_ErrorDetails.Click += new System.EventHandler(this.btn_ErrorDetails_Click);
            // 
            // btn_ErrorCancel
            // 
            this.btn_ErrorCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_ErrorCancel.FlatAppearance.BorderSize = 0;
            this.btn_ErrorCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ErrorCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ErrorCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ErrorCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ErrorCancel.Location = new System.Drawing.Point(267, 0);
            this.btn_ErrorCancel.Name = "btn_ErrorCancel";
            this.btn_ErrorCancel.Size = new System.Drawing.Size(131, 39);
            this.btn_ErrorCancel.TabIndex = 5;
            this.btn_ErrorCancel.Text = "Cancel";
            this.btn_ErrorCancel.UseVisualStyleBackColor = true;
            this.btn_ErrorCancel.Click += new System.EventHandler(this.btn_ErrorCancel_Click);
            // 
            // btn_ErrorOk
            // 
            this.btn_ErrorOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ErrorOk.FlatAppearance.BorderSize = 0;
            this.btn_ErrorOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ErrorOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ErrorOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ErrorOk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ErrorOk.Location = new System.Drawing.Point(0, 0);
            this.btn_ErrorOk.Name = "btn_ErrorOk";
            this.btn_ErrorOk.Size = new System.Drawing.Size(398, 39);
            this.btn_ErrorOk.TabIndex = 4;
            this.btn_ErrorOk.Text = "OK";
            this.btn_ErrorOk.UseVisualStyleBackColor = true;
            this.btn_ErrorOk.Click += new System.EventHandler(this.btn_ErrorOk_Click);
            // 
            // rtxtbox_ErrorMessage
            // 
            this.rtxtbox_ErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtbox_ErrorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbox_ErrorMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbox_ErrorMessage.Location = new System.Drawing.Point(0, 80);
            this.rtxtbox_ErrorMessage.Name = "rtxtbox_ErrorMessage";
            this.rtxtbox_ErrorMessage.ReadOnly = true;
            this.rtxtbox_ErrorMessage.Size = new System.Drawing.Size(398, 93);
            this.rtxtbox_ErrorMessage.TabIndex = 10;
            this.rtxtbox_ErrorMessage.Text = "Message text";
            // 
            // ErrorMessageBox
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 310);
            this.Controls.Add(this.rtxtbox_ErrorMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rtxtbox_ErrorDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ErrorMessageBox.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorMessageBox";
            this.Text = "ErrorMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Error)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_Error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button label_ErrorHeader;
        private System.Windows.Forms.RichTextBox rtxtbox_ErrorDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ErrorDetails;
        private System.Windows.Forms.Button btn_ErrorCancel;
        private System.Windows.Forms.Button btn_ErrorOk;
        private System.Windows.Forms.RichTextBox rtxtbox_ErrorMessage;
    }
}