
namespace GaragesClient.Common.HelpForms
{
    partial class CreateOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOwner));
            this.label_OwnerTittle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SaveNewOwner = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_OwnerContactPhone = new System.Windows.Forms.TextBox();
            this.txtbox_OwnerLastName = new System.Windows.Forms.TextBox();
            this.txtbox_OwnerFirstName = new System.Windows.Forms.TextBox();
            this.txtbox_OwnerId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_OwnerTittle
            // 
            this.label_OwnerTittle.BackColor = System.Drawing.Color.Transparent;
            this.label_OwnerTittle.Enabled = false;
            this.label_OwnerTittle.FlatAppearance.BorderSize = 0;
            this.label_OwnerTittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_OwnerTittle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OwnerTittle.Location = new System.Drawing.Point(97, 56);
            this.label_OwnerTittle.Name = "label_OwnerTittle";
            this.label_OwnerTittle.Size = new System.Drawing.Size(260, 59);
            this.label_OwnerTittle.TabIndex = 3;
            this.label_OwnerTittle.Text = "Owner :";
            this.label_OwnerTittle.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SaveNewOwner
            // 
            this.btn_SaveNewOwner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_SaveNewOwner.FlatAppearance.BorderSize = 0;
            this.btn_SaveNewOwner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_SaveNewOwner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_SaveNewOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveNewOwner.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveNewOwner.Location = new System.Drawing.Point(0, 495);
            this.btn_SaveNewOwner.Name = "btn_SaveNewOwner";
            this.btn_SaveNewOwner.Size = new System.Drawing.Size(446, 117);
            this.btn_SaveNewOwner.TabIndex = 4;
            this.btn_SaveNewOwner.Text = "Save";
            this.btn_SaveNewOwner.UseVisualStyleBackColor = true;
            this.btn_SaveNewOwner.Click += new System.EventHandler(this.btn_SaveNewOwner_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contact phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "First name :";
            // 
            // txtbox_OwnerContactPhone
            // 
            this.txtbox_OwnerContactPhone.BackColor = System.Drawing.Color.Silver;
            this.txtbox_OwnerContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_OwnerContactPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_OwnerContactPhone.ForeColor = System.Drawing.Color.White;
            this.txtbox_OwnerContactPhone.Location = new System.Drawing.Point(22, 351);
            this.txtbox_OwnerContactPhone.Name = "txtbox_OwnerContactPhone";
            this.txtbox_OwnerContactPhone.Size = new System.Drawing.Size(402, 31);
            this.txtbox_OwnerContactPhone.TabIndex = 10;
            this.txtbox_OwnerContactPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_OwnerLastName
            // 
            this.txtbox_OwnerLastName.BackColor = System.Drawing.Color.Silver;
            this.txtbox_OwnerLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_OwnerLastName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_OwnerLastName.ForeColor = System.Drawing.Color.White;
            this.txtbox_OwnerLastName.Location = new System.Drawing.Point(22, 276);
            this.txtbox_OwnerLastName.Name = "txtbox_OwnerLastName";
            this.txtbox_OwnerLastName.Size = new System.Drawing.Size(402, 31);
            this.txtbox_OwnerLastName.TabIndex = 9;
            this.txtbox_OwnerLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_OwnerFirstName
            // 
            this.txtbox_OwnerFirstName.BackColor = System.Drawing.Color.Silver;
            this.txtbox_OwnerFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_OwnerFirstName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_OwnerFirstName.ForeColor = System.Drawing.Color.White;
            this.txtbox_OwnerFirstName.Location = new System.Drawing.Point(22, 202);
            this.txtbox_OwnerFirstName.Name = "txtbox_OwnerFirstName";
            this.txtbox_OwnerFirstName.Size = new System.Drawing.Size(402, 31);
            this.txtbox_OwnerFirstName.TabIndex = 8;
            this.txtbox_OwnerFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_OwnerId
            // 
            this.txtbox_OwnerId.BackColor = System.Drawing.Color.Silver;
            this.txtbox_OwnerId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_OwnerId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbox_OwnerId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_OwnerId.ForeColor = System.Drawing.Color.White;
            this.txtbox_OwnerId.Location = new System.Drawing.Point(177, 121);
            this.txtbox_OwnerId.Name = "txtbox_OwnerId";
            this.txtbox_OwnerId.ReadOnly = true;
            this.txtbox_OwnerId.Size = new System.Drawing.Size(100, 31);
            this.txtbox_OwnerId.TabIndex = 14;
            this.txtbox_OwnerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_OwnerId.Visible = false;
            // 
            // CreateOwner
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 612);
            this.Controls.Add(this.txtbox_OwnerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_OwnerContactPhone);
            this.Controls.Add(this.txtbox_OwnerLastName);
            this.Controls.Add(this.txtbox_OwnerFirstName);
            this.Controls.Add(this.btn_SaveNewOwner);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_OwnerTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CreateOwner.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 652);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(448, 652);
            this.Name = "CreateOwner";
            this.Text = "New Owner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button label_OwnerTittle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_SaveNewOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_OwnerContactPhone;
        private System.Windows.Forms.TextBox txtbox_OwnerLastName;
        private System.Windows.Forms.TextBox txtbox_OwnerFirstName;
        private System.Windows.Forms.TextBox txtbox_OwnerId;
    }
}