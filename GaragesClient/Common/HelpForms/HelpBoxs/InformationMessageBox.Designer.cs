
namespace GaragesClient.Common.HelpForms.MessageBox
{
    partial class InformationMessageBox
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
            this.rtxtbox_InfoDetails = new System.Windows.Forms.RichTextBox();
            this.btn_InfoOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_InfoDetails = new System.Windows.Forms.Button();
            this.btn_InfoCancel = new System.Windows.Forms.Button();
            this.label_InfoHeader = new System.Windows.Forms.Button();
            this.rtxtbox_InfoMessage = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtbox_InfoDetails
            // 
            this.rtxtbox_InfoDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtbox_InfoDetails.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rtxtbox_InfoDetails.Location = new System.Drawing.Point(0, 198);
            this.rtxtbox_InfoDetails.Name = "rtxtbox_InfoDetails";
            this.rtxtbox_InfoDetails.ReadOnly = true;
            this.rtxtbox_InfoDetails.Size = new System.Drawing.Size(398, 112);
            this.rtxtbox_InfoDetails.TabIndex = 0;
            this.rtxtbox_InfoDetails.Text = "Text details";
            this.rtxtbox_InfoDetails.Visible = false;
            // 
            // btn_InfoOk
            // 
            this.btn_InfoOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_InfoOk.FlatAppearance.BorderSize = 0;
            this.btn_InfoOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_InfoOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_InfoOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfoOk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InfoOk.Location = new System.Drawing.Point(0, 0);
            this.btn_InfoOk.Name = "btn_InfoOk";
            this.btn_InfoOk.Size = new System.Drawing.Size(398, 38);
            this.btn_InfoOk.TabIndex = 1;
            this.btn_InfoOk.Text = "OK";
            this.btn_InfoOk.UseVisualStyleBackColor = true;
            this.btn_InfoOk.Click += new System.EventHandler(this.btn_InfoOk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_InfoDetails);
            this.panel1.Controls.Add(this.btn_InfoCancel);
            this.panel1.Controls.Add(this.btn_InfoOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 38);
            this.panel1.TabIndex = 2;
            // 
            // btn_InfoDetails
            // 
            this.btn_InfoDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_InfoDetails.FlatAppearance.BorderSize = 0;
            this.btn_InfoDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_InfoDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_InfoDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfoDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InfoDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_InfoDetails.Location = new System.Drawing.Point(0, 0);
            this.btn_InfoDetails.Name = "btn_InfoDetails";
            this.btn_InfoDetails.Size = new System.Drawing.Size(113, 38);
            this.btn_InfoDetails.TabIndex = 3;
            this.btn_InfoDetails.Text = "details";
            this.btn_InfoDetails.UseVisualStyleBackColor = true;
            this.btn_InfoDetails.Click += new System.EventHandler(this.btn_InfoDetails_Click);
            // 
            // btn_InfoCancel
            // 
            this.btn_InfoCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_InfoCancel.FlatAppearance.BorderSize = 0;
            this.btn_InfoCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_InfoCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_InfoCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfoCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InfoCancel.Location = new System.Drawing.Point(267, 0);
            this.btn_InfoCancel.Name = "btn_InfoCancel";
            this.btn_InfoCancel.Size = new System.Drawing.Size(131, 38);
            this.btn_InfoCancel.TabIndex = 2;
            this.btn_InfoCancel.Text = "Cancel";
            this.btn_InfoCancel.UseVisualStyleBackColor = true;
            this.btn_InfoCancel.Click += new System.EventHandler(this.btn_InfoOk_Click);
            // 
            // label_InfoHeader
            // 
            this.label_InfoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_InfoHeader.Enabled = false;
            this.label_InfoHeader.FlatAppearance.BorderSize = 0;
            this.label_InfoHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_InfoHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoHeader.Location = new System.Drawing.Point(0, 0);
            this.label_InfoHeader.Name = "label_InfoHeader";
            this.label_InfoHeader.Size = new System.Drawing.Size(398, 58);
            this.label_InfoHeader.TabIndex = 5;
            this.label_InfoHeader.Text = "Header";
            this.label_InfoHeader.UseVisualStyleBackColor = true;
            // 
            // rtxtbox_InfoMessage
            // 
            this.rtxtbox_InfoMessage.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtbox_InfoMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtbox_InfoMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbox_InfoMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbox_InfoMessage.Location = new System.Drawing.Point(0, 58);
            this.rtxtbox_InfoMessage.Name = "rtxtbox_InfoMessage";
            this.rtxtbox_InfoMessage.ReadOnly = true;
            this.rtxtbox_InfoMessage.Size = new System.Drawing.Size(398, 102);
            this.rtxtbox_InfoMessage.TabIndex = 6;
            this.rtxtbox_InfoMessage.Text = "Message text";
            // 
            // InformationMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 310);
            this.Controls.Add(this.rtxtbox_InfoMessage);
            this.Controls.Add(this.label_InfoHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtxtbox_InfoDetails);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "InformationMessageBox";
            this.Text = "Information";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtbox_InfoDetails;
        private System.Windows.Forms.Button btn_InfoOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_InfoCancel;
        private System.Windows.Forms.Button btn_InfoDetails;
        private System.Windows.Forms.Button label_InfoHeader;
        private System.Windows.Forms.RichTextBox rtxtbox_InfoMessage;
    }
}