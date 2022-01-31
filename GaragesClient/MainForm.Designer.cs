
namespace GaragesClient
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_TotalInfo = new System.Windows.Forms.TabPage();
            this.InfoTotalDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelGarageSerNum = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.txtbox_filterCarRegNumber = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelCarRegNum = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtbox_filterOwnerFName = new System.Windows.Forms.TextBox();
            this.labelOwnerFN = new System.Windows.Forms.Label();
            this.txtbox_filterGarageSerialNumber = new System.Windows.Forms.TextBox();
            this.txtbox_filterOwnerLName = new System.Windows.Forms.TextBox();
            this.labelOwnerLN = new System.Windows.Forms.Label();
            this.tab_Garages = new System.Windows.Forms.TabPage();
            this.garagesDataGridView = new System.Windows.Forms.DataGridView();
            this.tab_Owners = new System.Windows.Forms.TabPage();
            this.ownersDataGridView = new System.Windows.Forms.DataGridView();
            this.tab_Cars = new System.Windows.Forms.TabPage();
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infoTittleButton = new System.Windows.Forms.Button();
            this.btnReconnect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.carDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_TotalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTotalDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tab_Garages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garagesDataGridView)).BeginInit();
            this.tab_Owners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownersDataGridView)).BeginInit();
            this.tab_Cars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 715);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tab_TotalInfo);
            this.tabControl1.Controls.Add(this.tab_Garages);
            this.tabControl1.Controls.Add(this.tab_Owners);
            this.tabControl1.Controls.Add(this.tab_Cars);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 655);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_TotalInfo
            // 
            this.tab_TotalInfo.Controls.Add(this.InfoTotalDataGridView);
            this.tab_TotalInfo.Controls.Add(this.panel3);
            this.tab_TotalInfo.Location = new System.Drawing.Point(37, 4);
            this.tab_TotalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_TotalInfo.Name = "tab_TotalInfo";
            this.tab_TotalInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_TotalInfo.Size = new System.Drawing.Size(1036, 647);
            this.tab_TotalInfo.TabIndex = 0;
            this.tab_TotalInfo.Text = "Total Informations:";
            this.tab_TotalInfo.UseVisualStyleBackColor = true;
            // 
            // InfoTotalDataGridView
            // 
            this.InfoTotalDataGridView.AllowUserToAddRows = false;
            this.InfoTotalDataGridView.AllowUserToDeleteRows = false;
            this.InfoTotalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.InfoTotalDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InfoTotalDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InfoTotalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTotalDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoTotalDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InfoTotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoTotalDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.InfoTotalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTotalDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InfoTotalDataGridView.GridColor = System.Drawing.Color.Gray;
            this.InfoTotalDataGridView.Location = new System.Drawing.Point(3, 2);
            this.InfoTotalDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoTotalDataGridView.Name = "InfoTotalDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoTotalDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.InfoTotalDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InfoTotalDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.InfoTotalDataGridView.RowTemplate.Height = 24;
            this.InfoTotalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InfoTotalDataGridView.Size = new System.Drawing.Size(784, 643);
            this.InfoTotalDataGridView.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(787, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 643);
            this.panel3.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSearch);
            this.panel7.Controls.Add(this.btnClear);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 394);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(246, 100);
            this.panel7.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(78, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 100);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 100);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.labelGarageSerNum);
            this.panel6.Controls.Add(this.labelFilter);
            this.panel6.Controls.Add(this.txtbox_filterCarRegNumber);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.labelCarRegNum);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.txtbox_filterOwnerFName);
            this.panel6.Controls.Add(this.labelOwnerFN);
            this.panel6.Controls.Add(this.txtbox_filterGarageSerialNumber);
            this.panel6.Controls.Add(this.txtbox_filterOwnerLName);
            this.panel6.Controls.Add(this.labelOwnerLN);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 394);
            this.panel6.TabIndex = 13;
            // 
            // labelGarageSerNum
            // 
            this.labelGarageSerNum.AutoSize = true;
            this.labelGarageSerNum.Location = new System.Drawing.Point(37, 25);
            this.labelGarageSerNum.Name = "labelGarageSerNum";
            this.labelGarageSerNum.Size = new System.Drawing.Size(184, 23);
            this.labelGarageSerNum.TabIndex = 8;
            this.labelGarageSerNum.Text = "Garage Serial Number:";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(44, -57);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(123, 45);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "Filters:";
            // 
            // txtbox_filterCarRegNumber
            // 
            this.txtbox_filterCarRegNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbox_filterCarRegNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_filterCarRegNumber.Location = new System.Drawing.Point(22, 342);
            this.txtbox_filterCarRegNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_filterCarRegNumber.Name = "txtbox_filterCarRegNumber";
            this.txtbox_filterCarRegNumber.Size = new System.Drawing.Size(213, 23);
            this.txtbox_filterCarRegNumber.TabIndex = 1;
            this.txtbox_filterCarRegNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_filterCarRegNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterSearch_Enter_KeyDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(2, 281);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 5);
            this.panel5.TabIndex = 10;
            // 
            // labelCarRegNum
            // 
            this.labelCarRegNum.AutoSize = true;
            this.labelCarRegNum.Location = new System.Drawing.Point(26, 308);
            this.labelCarRegNum.Name = "labelCarRegNum";
            this.labelCarRegNum.Size = new System.Drawing.Size(206, 23);
            this.labelCarRegNum.TabIndex = 2;
            this.labelCarRegNum.Text = "Car Registration Number:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(-1, 101);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 5);
            this.panel4.TabIndex = 9;
            // 
            // txtbox_filterOwnerFName
            // 
            this.txtbox_filterOwnerFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbox_filterOwnerFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_filterOwnerFName.Location = new System.Drawing.Point(22, 158);
            this.txtbox_filterOwnerFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_filterOwnerFName.Name = "txtbox_filterOwnerFName";
            this.txtbox_filterOwnerFName.Size = new System.Drawing.Size(213, 23);
            this.txtbox_filterOwnerFName.TabIndex = 3;
            this.txtbox_filterOwnerFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_filterOwnerFName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterSearch_Enter_KeyDown);
            // 
            // labelOwnerFN
            // 
            this.labelOwnerFN.AutoSize = true;
            this.labelOwnerFN.Location = new System.Drawing.Point(55, 123);
            this.labelOwnerFN.Name = "labelOwnerFN";
            this.labelOwnerFN.Size = new System.Drawing.Size(148, 23);
            this.labelOwnerFN.TabIndex = 4;
            this.labelOwnerFN.Text = "Owner FirstName:";
            // 
            // txtbox_filterGarageSerialNumber
            // 
            this.txtbox_filterGarageSerialNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbox_filterGarageSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_filterGarageSerialNumber.Location = new System.Drawing.Point(22, 58);
            this.txtbox_filterGarageSerialNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_filterGarageSerialNumber.Name = "txtbox_filterGarageSerialNumber";
            this.txtbox_filterGarageSerialNumber.Size = new System.Drawing.Size(213, 23);
            this.txtbox_filterGarageSerialNumber.TabIndex = 7;
            this.txtbox_filterGarageSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_filterGarageSerialNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterSearch_Enter_KeyDown);
            // 
            // txtbox_filterOwnerLName
            // 
            this.txtbox_filterOwnerLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbox_filterOwnerLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_filterOwnerLName.Location = new System.Drawing.Point(22, 234);
            this.txtbox_filterOwnerLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_filterOwnerLName.Name = "txtbox_filterOwnerLName";
            this.txtbox_filterOwnerLName.Size = new System.Drawing.Size(213, 23);
            this.txtbox_filterOwnerLName.TabIndex = 5;
            this.txtbox_filterOwnerLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_filterOwnerLName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterSearch_Enter_KeyDown);
            // 
            // labelOwnerLN
            // 
            this.labelOwnerLN.AutoSize = true;
            this.labelOwnerLN.Location = new System.Drawing.Point(56, 199);
            this.labelOwnerLN.Name = "labelOwnerLN";
            this.labelOwnerLN.Size = new System.Drawing.Size(146, 23);
            this.labelOwnerLN.TabIndex = 6;
            this.labelOwnerLN.Text = "Owner LastName:";
            // 
            // tab_Garages
            // 
            this.tab_Garages.Controls.Add(this.garagesDataGridView);
            this.tab_Garages.Location = new System.Drawing.Point(37, 4);
            this.tab_Garages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Garages.Name = "tab_Garages";
            this.tab_Garages.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Garages.Size = new System.Drawing.Size(1036, 647);
            this.tab_Garages.TabIndex = 1;
            this.tab_Garages.Text = "Garages:";
            // 
            // garagesDataGridView
            // 
            this.garagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.garagesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.garagesDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.garagesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.garagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.garagesDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.garagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.garagesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.garagesDataGridView.Location = new System.Drawing.Point(3, 2);
            this.garagesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.garagesDataGridView.Name = "garagesDataGridView";
            this.garagesDataGridView.RowHeadersWidth = 51;
            this.garagesDataGridView.RowTemplate.Height = 24;
            this.garagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.garagesDataGridView.Size = new System.Drawing.Size(1030, 643);
            this.garagesDataGridView.TabIndex = 3;
            // 
            // tab_Owners
            // 
            this.tab_Owners.Controls.Add(this.ownersDataGridView);
            this.tab_Owners.Location = new System.Drawing.Point(37, 4);
            this.tab_Owners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Owners.Name = "tab_Owners";
            this.tab_Owners.Size = new System.Drawing.Size(1036, 647);
            this.tab_Owners.TabIndex = 2;
            this.tab_Owners.Text = "Owners:";
            this.tab_Owners.UseVisualStyleBackColor = true;
            // 
            // ownersDataGridView
            // 
            this.ownersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ownersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ownersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ownersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ownersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ownersDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.ownersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ownersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ownersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ownersDataGridView.Name = "ownersDataGridView";
            this.ownersDataGridView.RowHeadersWidth = 51;
            this.ownersDataGridView.RowTemplate.Height = 24;
            this.ownersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ownersDataGridView.Size = new System.Drawing.Size(1036, 647);
            this.ownersDataGridView.TabIndex = 3;
            // 
            // tab_Cars
            // 
            this.tab_Cars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tab_Cars.Controls.Add(this.carsDataGridView);
            this.tab_Cars.Location = new System.Drawing.Point(37, 4);
            this.tab_Cars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Cars.Name = "tab_Cars";
            this.tab_Cars.Size = new System.Drawing.Size(1036, 647);
            this.tab_Cars.TabIndex = 3;
            this.tab_Cars.Text = "Cars:";
            this.tab_Cars.UseVisualStyleBackColor = true;
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.carsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.carsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.carsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.carsDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.carsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.carsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.carsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carsDataGridView.Name = "carsDataGridView";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.carsDataGridView.RowHeadersWidth = 51;
            this.carsDataGridView.RowTemplate.Height = 24;
            this.carsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carsDataGridView.Size = new System.Drawing.Size(1036, 647);
            this.carsDataGridView.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControl1);
            this.tabPage1.Location = new System.Drawing.Point(37, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1036, 647);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Cars";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1036, 647);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.infoTittleButton);
            this.panel2.Controls.Add(this.btnReconnect);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 60);
            this.panel2.TabIndex = 1;
            // 
            // infoTittleButton
            // 
            this.infoTittleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTittleButton.FlatAppearance.BorderSize = 0;
            this.infoTittleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoTittleButton.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTittleButton.Location = new System.Drawing.Point(237, 0);
            this.infoTittleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoTittleButton.Name = "infoTittleButton";
            this.infoTittleButton.Size = new System.Drawing.Size(740, 60);
            this.infoTittleButton.TabIndex = 5;
            this.infoTittleButton.Text = "Total Informations:";
            this.infoTittleButton.UseVisualStyleBackColor = true;
            this.infoTittleButton.Click += new System.EventHandler(this.infoTittleButton_Click);
            // 
            // btnReconnect
            // 
            this.btnReconnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReconnect.FlatAppearance.BorderSize = 0;
            this.btnReconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReconnect.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReconnect.Location = new System.Drawing.Point(977, 0);
            this.btnReconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(100, 60);
            this.btnReconnect.TabIndex = 3;
            this.btnReconnect.Text = "Reconnect";
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(158, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 60);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(79, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 60);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(79, 60);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 87;
            // 
            // carDtoBindingSource
            // 
            this.carDtoBindingSource.DataSource = typeof(GaragesClient.ServiceWebAPI.carDto);
            // 
            // MainForm
            // 
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 715);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Admin - Garages";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_TotalInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoTotalDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tab_Garages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.garagesDataGridView)).EndInit();
            this.tab_Owners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownersDataGridView)).EndInit();
            this.tab_Cars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_TotalInfo;
        private System.Windows.Forms.TabPage tab_Owners;
        private System.Windows.Forms.TabPage tab_Cars;
        private System.Windows.Forms.Button btnReconnect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabPage tab_Garages;
        private System.Windows.Forms.Button infoTittleButton;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.DataGridView garagesDataGridView;
        private System.Windows.Forms.DataGridView ownersDataGridView;
        private System.Windows.Forms.DataGridView InfoTotalDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelGarageSerNum;
        private System.Windows.Forms.TextBox txtbox_filterGarageSerialNumber;
        private System.Windows.Forms.Label labelOwnerLN;
        private System.Windows.Forms.TextBox txtbox_filterOwnerLName;
        private System.Windows.Forms.Label labelOwnerFN;
        private System.Windows.Forms.TextBox txtbox_filterOwnerFName;
        private System.Windows.Forms.Label labelCarRegNum;
        private System.Windows.Forms.TextBox txtbox_filterCarRegNumber;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource carDtoBindingSource;
    }
}

