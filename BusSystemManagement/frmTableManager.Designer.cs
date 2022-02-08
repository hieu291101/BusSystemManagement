using System;
using System.Windows.Forms;

namespace BusSystemManagement
{
    partial class frmTableManager
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableManager));
            this.tcDriver = new System.Windows.Forms.TabControl();
            this.tabPageDriver = new System.Windows.Forms.TabPage();
            this.btnExportPdfDriver = new System.Windows.Forms.Button();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel46 = new System.Windows.Forms.Panel();
            this.cbLicense = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.panel36 = new System.Windows.Forms.Panel();
            this.nudExperienceDriver = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.panel37 = new System.Windows.Forms.Panel();
            this.dtpStartDayDriver = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.panel38 = new System.Windows.Forms.Panel();
            this.tbIdCardDriver = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.tbPhoneDriver = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel40 = new System.Windows.Forms.Panel();
            this.tbAddressDriver = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.panel41 = new System.Windows.Forms.Panel();
            this.cbGenderDriver = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.panel42 = new System.Windows.Forms.Panel();
            this.dtpDayOfBirthDriver = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.panel63 = new System.Windows.Forms.Panel();
            this.tbDriverName = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.btnAddMdriver = new System.Windows.Forms.Button();
            this.btnResetDriver = new System.Windows.Forms.Button();
            this.btnUpdateDriver = new System.Windows.Forms.Button();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.panel34 = new System.Windows.Forms.Panel();
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.tbSearchDriver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageAsDriver = new System.Windows.Forms.TabPage();
            this.btnExportPdfAsDriver = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.nudExperienceAsDriver = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.tbIdCardAsDriver = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.tbPhoneAsDriver = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.tbAddressAsDriver = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel33 = new System.Windows.Forms.Panel();
            this.dtpDayOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.panel64 = new System.Windows.Forms.Panel();
            this.tbAsDriverName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnResetAsDriver = new System.Windows.Forms.Button();
            this.btnUpdateAsDriver = new System.Windows.Forms.Button();
            this.btnDeleteAsDriver = new System.Windows.Forms.Button();
            this.btnAddAsDriver = new System.Windows.Forms.Button();
            this.panel25 = new System.Windows.Forms.Panel();
            this.dgvAsDriver = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbAsDriver = new System.Windows.Forms.ComboBox();
            this.tbSearchAsDriver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageBus = new System.Windows.Forms.TabPage();
            this.btnExportPdfBus = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.nudCycle = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.nudChair = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.nudMyear = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel65 = new System.Windows.Forms.Panel();
            this.tbLicensePlate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnResetBus = new System.Windows.Forms.Button();
            this.btnUpdateBus = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBus = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbBus = new System.Windows.Forms.ComboBox();
            this.tbSearchBus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageBusLine = new System.Windows.Forms.TabPage();
            this.btnExportPdfBusLine = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tbBusLineDetail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tbEndLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tbStartLocation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.nudEndTime = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.nudStartTime = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.nudFrequency = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel66 = new System.Windows.Forms.Panel();
            this.tbBusLineName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetBusLine = new System.Windows.Forms.Button();
            this.btnUpdateBusLine = new System.Windows.Forms.Button();
            this.btnDeleteBusLine = new System.Windows.Forms.Button();
            this.btnAddBusLine = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvBusLine = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbBusLine = new System.Windows.Forms.ComboBox();
            this.tbSearchBusLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageBusRide = new System.Windows.Forms.TabPage();
            this.btnExportPdfBusRide = new System.Windows.Forms.Button();
            this.panel45 = new System.Windows.Forms.Panel();
            this.panel48 = new System.Windows.Forms.Panel();
            this.panel49 = new System.Windows.Forms.Panel();
            this.dtpStartTimeBusRide = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.panel50 = new System.Windows.Forms.Panel();
            this.tbBusBR = new System.Windows.Forms.TextBox();
            this.cbBusBR = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.panel51 = new System.Windows.Forms.Panel();
            this.tbAsDriverBR = new System.Windows.Forms.TextBox();
            this.cbAsDriverBR = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.panel52 = new System.Windows.Forms.Panel();
            this.tbDriverBR = new System.Windows.Forms.TextBox();
            this.cbDriverBR = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.panel67 = new System.Windows.Forms.Panel();
            this.tbBusLineBR = new System.Windows.Forms.TextBox();
            this.cbBusLineBR = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.btnResetBusRide = new System.Windows.Forms.Button();
            this.btnUpdateBusRide = new System.Windows.Forms.Button();
            this.btnDeleteBusRide = new System.Windows.Forms.Button();
            this.btnAddBusRide = new System.Windows.Forms.Button();
            this.panel44 = new System.Windows.Forms.Panel();
            this.dgvBusRide = new System.Windows.Forms.DataGridView();
            this.panel43 = new System.Windows.Forms.Panel();
            this.cbBusRide = new System.Windows.Forms.ComboBox();
            this.tbSearchBusRide = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageTicket = new System.Windows.Forms.TabPage();
            this.btnExportPdfTicket = new System.Windows.Forms.Button();
            this.panel55 = new System.Windows.Forms.Panel();
            this.panel56 = new System.Windows.Forms.Panel();
            this.panel57 = new System.Windows.Forms.Panel();
            this.dtpTicket = new System.Windows.Forms.DateTimePicker();
            this.label41 = new System.Windows.Forms.Label();
            this.panel59 = new System.Windows.Forms.Panel();
            this.tbTicketAsDriverName = new System.Windows.Forms.TextBox();
            this.cbTicketAsDriverId = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.panel68 = new System.Windows.Forms.Panel();
            this.nudTicket = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.btResetTicket = new System.Windows.Forms.Button();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.panel61 = new System.Windows.Forms.Panel();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.panel62 = new System.Windows.Forms.Panel();
            this.cbTicket = new System.Windows.Forms.ComboBox();
            this.tbSearchTicket = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tabPageStat = new System.Windows.Forms.TabPage();
            this.panel58 = new System.Windows.Forms.Panel();
            this.btnSumary = new System.Windows.Forms.Button();
            this.btnDatStat = new System.Windows.Forms.Button();
            this.panel60 = new System.Windows.Forms.Panel();
            this.dtpEndDayStat = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.panel72 = new System.Windows.Forms.Panel();
            this.dtpStartDayStat = new System.Windows.Forms.DateTimePicker();
            this.label43 = new System.Windows.Forms.Label();
            this.panel53 = new System.Windows.Forms.Panel();
            this.label48 = new System.Windows.Forms.Label();
            this.chartStatTicket = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel54 = new System.Windows.Forms.Panel();
            this.cbStatChart = new System.Windows.Forms.ComboBox();
            this.btnStatChart = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.panel47 = new System.Windows.Forms.Panel();
            this.label47 = new System.Windows.Forms.Label();
            this.dgvStat = new System.Windows.Forms.DataGridView();
            this.btnExportPdfStat = new System.Windows.Forms.Button();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.panel69 = new System.Windows.Forms.Panel();
            this.panel70 = new System.Windows.Forms.Panel();
            this.panel76 = new System.Windows.Forms.Panel();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.panel71 = new System.Windows.Forms.Panel();
            this.tbUserUsername = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.panel73 = new System.Windows.Forms.Panel();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.btnUserReset = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.panel74 = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.panel75 = new System.Windows.Forms.Panel();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.tbSearchUser = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcDriver.SuspendLayout();
            this.tabPageDriver.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel46.SuspendLayout();
            this.panel36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExperienceDriver)).BeginInit();
            this.panel37.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel42.SuspendLayout();
            this.panel63.SuspendLayout();
            this.panel34.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPageAsDriver.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExperienceAsDriver)).BeginInit();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel64.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsDriver)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPageBus.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCycle)).BeginInit();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChair)).BeginInit();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMyear)).BeginInit();
            this.panel24.SuspendLayout();
            this.panel65.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPageBusLine.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndTime)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTime)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).BeginInit();
            this.panel66.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusLine)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPageBusRide.SuspendLayout();
            this.panel45.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel50.SuspendLayout();
            this.panel51.SuspendLayout();
            this.panel52.SuspendLayout();
            this.panel67.SuspendLayout();
            this.panel44.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusRide)).BeginInit();
            this.panel43.SuspendLayout();
            this.tabPageTicket.SuspendLayout();
            this.panel55.SuspendLayout();
            this.panel56.SuspendLayout();
            this.panel57.SuspendLayout();
            this.panel59.SuspendLayout();
            this.panel68.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicket)).BeginInit();
            this.panel61.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.panel62.SuspendLayout();
            this.tabPageStat.SuspendLayout();
            this.panel58.SuspendLayout();
            this.panel60.SuspendLayout();
            this.panel72.SuspendLayout();
            this.panel53.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatTicket)).BeginInit();
            this.panel54.SuspendLayout();
            this.panel47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).BeginInit();
            this.tabPageUser.SuspendLayout();
            this.panel69.SuspendLayout();
            this.panel70.SuspendLayout();
            this.panel76.SuspendLayout();
            this.panel71.SuspendLayout();
            this.panel73.SuspendLayout();
            this.panel74.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panel75.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcDriver
            // 
            this.tcDriver.Controls.Add(this.tabPageDriver);
            this.tcDriver.Controls.Add(this.tabPageAsDriver);
            this.tcDriver.Controls.Add(this.tabPageBus);
            this.tcDriver.Controls.Add(this.tabPageBusLine);
            this.tcDriver.Controls.Add(this.tabPageBusRide);
            this.tcDriver.Controls.Add(this.tabPageTicket);
            this.tcDriver.Controls.Add(this.tabPageStat);
            this.tcDriver.Controls.Add(this.tabPageUser);
            this.tcDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDriver.Font = new System.Drawing.Font("Lexend Deca", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDriver.Location = new System.Drawing.Point(0, 27);
            this.tcDriver.MaximumSize = new System.Drawing.Size(993, 712);
            this.tcDriver.MinimumSize = new System.Drawing.Size(993, 712);
            this.tcDriver.Name = "tcDriver";
            this.tcDriver.SelectedIndex = 0;
            this.tcDriver.Size = new System.Drawing.Size(993, 712);
            this.tcDriver.TabIndex = 0;
            // 
            // tabPageDriver
            // 
            this.tabPageDriver.Controls.Add(this.btnExportPdfDriver);
            this.tabPageDriver.Controls.Add(this.panel27);
            this.tabPageDriver.Controls.Add(this.panel34);
            this.tabPageDriver.Controls.Add(this.panel6);
            this.tabPageDriver.Location = new System.Drawing.Point(4, 30);
            this.tabPageDriver.Name = "tabPageDriver";
            this.tabPageDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDriver.Size = new System.Drawing.Size(985, 678);
            this.tabPageDriver.TabIndex = 0;
            this.tabPageDriver.Text = "Tài xế";
            this.tabPageDriver.UseVisualStyleBackColor = true;
            // 
            // btnExportPdfDriver
            // 
            this.btnExportPdfDriver.BackColor = System.Drawing.Color.DimGray;
            this.btnExportPdfDriver.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExportPdfDriver.Location = new System.Drawing.Point(6, 16);
            this.btnExportPdfDriver.Name = "btnExportPdfDriver";
            this.btnExportPdfDriver.Size = new System.Drawing.Size(129, 35);
            this.btnExportPdfDriver.TabIndex = 2;
            this.btnExportPdfDriver.TabStop = false;
            this.btnExportPdfDriver.Text = "EXPORT TO PDF";
            this.btnExportPdfDriver.UseVisualStyleBackColor = false;
            this.btnExportPdfDriver.Click += new System.EventHandler(this.btnExportPdfDriver_Click);
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.panel35);
            this.panel27.Controls.Add(this.btnAddMdriver);
            this.panel27.Controls.Add(this.btnResetDriver);
            this.panel27.Controls.Add(this.btnUpdateDriver);
            this.panel27.Controls.Add(this.btnDeleteDriver);
            this.panel27.Location = new System.Drawing.Point(3, 394);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(976, 251);
            this.panel27.TabIndex = 0;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel35.Controls.Add(this.panel46);
            this.panel35.Controls.Add(this.panel36);
            this.panel35.Controls.Add(this.panel37);
            this.panel35.Controls.Add(this.panel38);
            this.panel35.Controls.Add(this.panel39);
            this.panel35.Controls.Add(this.panel40);
            this.panel35.Controls.Add(this.panel41);
            this.panel35.Controls.Add(this.panel42);
            this.panel35.Controls.Add(this.panel63);
            this.panel35.Location = new System.Drawing.Point(3, 3);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(708, 242);
            this.panel35.TabIndex = 1;
            // 
            // panel46
            // 
            this.panel46.Controls.Add(this.cbLicense);
            this.panel46.Controls.Add(this.label34);
            this.panel46.Location = new System.Drawing.Point(3, 175);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(339, 37);
            this.panel46.TabIndex = 8;
            // 
            // cbLicense
            // 
            this.cbLicense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicense.FormattingEnabled = true;
            this.cbLicense.Location = new System.Drawing.Point(113, 8);
            this.cbLicense.Name = "cbLicense";
            this.cbLicense.Size = new System.Drawing.Size(223, 29);
            this.cbLicense.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(12, 11);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(62, 21);
            this.label34.TabIndex = 1;
            this.label34.Text = "Bằng lái";
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.nudExperienceDriver);
            this.panel36.Controls.Add(this.label19);
            this.panel36.Location = new System.Drawing.Point(348, 132);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(339, 37);
            this.panel36.TabIndex = 7;
            // 
            // nudExperienceDriver
            // 
            this.nudExperienceDriver.Location = new System.Drawing.Point(133, 8);
            this.nudExperienceDriver.Name = "nudExperienceDriver";
            this.nudExperienceDriver.Size = new System.Drawing.Size(203, 24);
            this.nudExperienceDriver.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 21);
            this.label19.TabIndex = 1;
            this.label19.Text = "Thâm niên(năm)";
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.dtpStartDayDriver);
            this.panel37.Controls.Add(this.label26);
            this.panel37.Location = new System.Drawing.Point(3, 132);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(339, 37);
            this.panel37.TabIndex = 6;
            // 
            // dtpStartDayDriver
            // 
            this.dtpStartDayDriver.Location = new System.Drawing.Point(113, 6);
            this.dtpStartDayDriver.Name = "dtpStartDayDriver";
            this.dtpStartDayDriver.Size = new System.Drawing.Size(223, 24);
            this.dtpStartDayDriver.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 21);
            this.label26.TabIndex = 1;
            this.label26.Text = "Ngày bắt đầu ";
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.tbIdCardDriver);
            this.panel38.Controls.Add(this.label27);
            this.panel38.Location = new System.Drawing.Point(348, 89);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(339, 37);
            this.panel38.TabIndex = 5;
            // 
            // tbIdCardDriver
            // 
            this.tbIdCardDriver.Location = new System.Drawing.Point(113, 8);
            this.tbIdCardDriver.Name = "tbIdCardDriver";
            this.tbIdCardDriver.Size = new System.Drawing.Size(223, 24);
            this.tbIdCardDriver.TabIndex = 0;
            this.tbIdCardDriver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdCardDriver_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 21);
            this.label27.TabIndex = 1;
            this.label27.Text = "CMND";
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.tbPhoneDriver);
            this.panel39.Controls.Add(this.label28);
            this.panel39.Location = new System.Drawing.Point(3, 89);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(339, 37);
            this.panel39.TabIndex = 4;
            // 
            // tbPhoneDriver
            // 
            this.tbPhoneDriver.Location = new System.Drawing.Point(113, 8);
            this.tbPhoneDriver.MaxLength = 12;
            this.tbPhoneDriver.Name = "tbPhoneDriver";
            this.tbPhoneDriver.Size = new System.Drawing.Size(223, 24);
            this.tbPhoneDriver.TabIndex = 0;
            this.tbPhoneDriver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneDriver_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 11);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 21);
            this.label28.TabIndex = 1;
            this.label28.Text = "Điện thoại";
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.tbAddressDriver);
            this.panel40.Controls.Add(this.label29);
            this.panel40.Location = new System.Drawing.Point(348, 46);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(339, 37);
            this.panel40.TabIndex = 3;
            // 
            // tbAddressDriver
            // 
            this.tbAddressDriver.Location = new System.Drawing.Point(113, 8);
            this.tbAddressDriver.Name = "tbAddressDriver";
            this.tbAddressDriver.Size = new System.Drawing.Size(223, 24);
            this.tbAddressDriver.TabIndex = 0;
            this.tbAddressDriver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddressDriver_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 11);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(54, 21);
            this.label29.TabIndex = 1;
            this.label29.Text = "Địa chỉ";
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.cbGenderDriver);
            this.panel41.Controls.Add(this.label30);
            this.panel41.Location = new System.Drawing.Point(3, 46);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(339, 37);
            this.panel41.TabIndex = 2;
            // 
            // cbGenderDriver
            // 
            this.cbGenderDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenderDriver.FormattingEnabled = true;
            this.cbGenderDriver.Location = new System.Drawing.Point(113, 5);
            this.cbGenderDriver.Name = "cbGenderDriver";
            this.cbGenderDriver.Size = new System.Drawing.Size(223, 29);
            this.cbGenderDriver.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 11);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(64, 21);
            this.label30.TabIndex = 1;
            this.label30.Text = "Giới tính";
            // 
            // panel42
            // 
            this.panel42.Controls.Add(this.dtpDayOfBirthDriver);
            this.panel42.Controls.Add(this.label31);
            this.panel42.Location = new System.Drawing.Point(348, 3);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(339, 37);
            this.panel42.TabIndex = 1;
            // 
            // dtpDayOfBirthDriver
            // 
            this.dtpDayOfBirthDriver.CustomFormat = "Short";
            this.dtpDayOfBirthDriver.Location = new System.Drawing.Point(113, 8);
            this.dtpDayOfBirthDriver.Name = "dtpDayOfBirthDriver";
            this.dtpDayOfBirthDriver.Size = new System.Drawing.Size(223, 24);
            this.dtpDayOfBirthDriver.TabIndex = 0;
            this.dtpDayOfBirthDriver.Value = new System.DateTime(2022, 1, 28, 15, 17, 42, 0);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 11);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 21);
            this.label31.TabIndex = 1;
            this.label31.Text = "Ngày sinh";
            // 
            // panel63
            // 
            this.panel63.Controls.Add(this.tbDriverName);
            this.panel63.Controls.Add(this.label32);
            this.panel63.Location = new System.Drawing.Point(3, 3);
            this.panel63.Name = "panel63";
            this.panel63.Size = new System.Drawing.Size(339, 37);
            this.panel63.TabIndex = 0;
            // 
            // tbDriverName
            // 
            this.tbDriverName.Location = new System.Drawing.Point(113, 8);
            this.tbDriverName.Name = "tbDriverName";
            this.tbDriverName.Size = new System.Drawing.Size(223, 24);
            this.tbDriverName.TabIndex = 0;
            this.tbDriverName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDriverName_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(12, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 21);
            this.label32.TabIndex = 1;
            this.label32.Text = "Họ tên";
            // 
            // btnAddMdriver
            // 
            this.btnAddMdriver.BackColor = System.Drawing.Color.DimGray;
            this.btnAddMdriver.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMdriver.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnAddMdriver.Location = new System.Drawing.Point(717, 3);
            this.btnAddMdriver.Name = "btnAddMdriver";
            this.btnAddMdriver.Size = new System.Drawing.Size(256, 56);
            this.btnAddMdriver.TabIndex = 1;
            this.btnAddMdriver.Text = "Thêm";
            this.btnAddMdriver.UseVisualStyleBackColor = false;
            this.btnAddMdriver.Click += new System.EventHandler(this.btnAddMdriver_Click);
            // 
            // btnResetDriver
            // 
            this.btnResetDriver.BackColor = System.Drawing.Color.DimGray;
            this.btnResetDriver.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDriver.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnResetDriver.Location = new System.Drawing.Point(717, 189);
            this.btnResetDriver.Name = "btnResetDriver";
            this.btnResetDriver.Size = new System.Drawing.Size(256, 56);
            this.btnResetDriver.TabIndex = 4;
            this.btnResetDriver.Text = "Nhập lại";
            this.btnResetDriver.UseVisualStyleBackColor = false;
            this.btnResetDriver.Click += new System.EventHandler(this.btnResetDriver_Click);
            // 
            // btnUpdateDriver
            // 
            this.btnUpdateDriver.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateDriver.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDriver.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdateDriver.Location = new System.Drawing.Point(717, 127);
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(256, 56);
            this.btnUpdateDriver.TabIndex = 3;
            this.btnUpdateDriver.Text = "Cập nhật";
            this.btnUpdateDriver.UseVisualStyleBackColor = false;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteDriver.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDriver.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnDeleteDriver.Location = new System.Drawing.Point(717, 65);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(256, 56);
            this.btnDeleteDriver.TabIndex = 2;
            this.btnDeleteDriver.Text = "Xóa";
            this.btnDeleteDriver.UseVisualStyleBackColor = false;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.dgvDriver);
            this.panel34.Location = new System.Drawing.Point(3, 57);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(976, 334);
            this.panel34.TabIndex = 7;
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDriver.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(3, 3);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.ReadOnly = true;
            this.dgvDriver.Size = new System.Drawing.Size(970, 328);
            this.dgvDriver.TabIndex = 0;
            this.dgvDriver.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel6.Controls.Add(this.cbDriver);
            this.panel6.Controls.Add(this.tbSearchDriver);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(569, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(407, 48);
            this.panel6.TabIndex = 2;
            // 
            // cbDriver
            // 
            this.cbDriver.BackColor = System.Drawing.SystemColors.Window;
            this.cbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Location = new System.Drawing.Point(283, 10);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(121, 29);
            this.cbDriver.TabIndex = 2;
            this.cbDriver.TabStop = false;
            this.cbDriver.SelectedIndexChanged += new System.EventHandler(this.cbDriver_SelectedIndexChanged);
            // 
            // tbSearchDriver
            // 
            this.tbSearchDriver.Location = new System.Drawing.Point(88, 10);
            this.tbSearchDriver.Name = "tbSearchDriver";
            this.tbSearchDriver.Size = new System.Drawing.Size(189, 24);
            this.tbSearchDriver.TabIndex = 1;
            this.tbSearchDriver.TabStop = false;
            this.tbSearchDriver.TextChanged += new System.EventHandler(this.tbSearchDriver_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm";
            // 
            // tabPageAsDriver
            // 
            this.tabPageAsDriver.Controls.Add(this.btnExportPdfAsDriver);
            this.tabPageAsDriver.Controls.Add(this.panel26);
            this.tabPageAsDriver.Controls.Add(this.panel25);
            this.tabPageAsDriver.Controls.Add(this.panel5);
            this.tabPageAsDriver.Location = new System.Drawing.Point(4, 30);
            this.tabPageAsDriver.Name = "tabPageAsDriver";
            this.tabPageAsDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAsDriver.Size = new System.Drawing.Size(985, 678);
            this.tabPageAsDriver.TabIndex = 1;
            this.tabPageAsDriver.Text = "Phụ xe";
            this.tabPageAsDriver.UseVisualStyleBackColor = true;
            // 
            // btnExportPdfAsDriver
            // 
            this.btnExportPdfAsDriver.BackColor = System.Drawing.Color.DimGray;
            this.btnExportPdfAsDriver.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExportPdfAsDriver.Location = new System.Drawing.Point(6, 16);
            this.btnExportPdfAsDriver.Name = "btnExportPdfAsDriver";
            this.btnExportPdfAsDriver.Size = new System.Drawing.Size(129, 35);
            this.btnExportPdfAsDriver.TabIndex = 0;
            this.btnExportPdfAsDriver.TabStop = false;
            this.btnExportPdfAsDriver.Text = "EXPORT TO PDF";
            this.btnExportPdfAsDriver.UseVisualStyleBackColor = false;
            this.btnExportPdfAsDriver.Click += new System.EventHandler(this.btnExportPdfAsDriver_Click);
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.panel18);
            this.panel26.Controls.Add(this.btnResetAsDriver);
            this.panel26.Controls.Add(this.btnUpdateAsDriver);
            this.panel26.Controls.Add(this.btnDeleteAsDriver);
            this.panel26.Controls.Add(this.btnAddAsDriver);
            this.panel26.Location = new System.Drawing.Point(3, 394);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(976, 271);
            this.panel26.TabIndex = 0;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Controls.Add(this.panel28);
            this.panel18.Controls.Add(this.panel29);
            this.panel18.Controls.Add(this.panel30);
            this.panel18.Controls.Add(this.panel31);
            this.panel18.Controls.Add(this.panel32);
            this.panel18.Controls.Add(this.panel33);
            this.panel18.Controls.Add(this.panel64);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(708, 241);
            this.panel18.TabIndex = 0;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.nudExperienceAsDriver);
            this.panel19.Controls.Add(this.label12);
            this.panel19.Location = new System.Drawing.Point(348, 132);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(339, 37);
            this.panel19.TabIndex = 7;
            // 
            // nudExperienceAsDriver
            // 
            this.nudExperienceAsDriver.Location = new System.Drawing.Point(133, 8);
            this.nudExperienceAsDriver.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudExperienceAsDriver.Name = "nudExperienceAsDriver";
            this.nudExperienceAsDriver.Size = new System.Drawing.Size(203, 24);
            this.nudExperienceAsDriver.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Thâm niên(năm)";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.dtpStartDay);
            this.panel28.Controls.Add(this.label1);
            this.panel28.Location = new System.Drawing.Point(3, 132);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(339, 37);
            this.panel28.TabIndex = 6;
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Location = new System.Drawing.Point(113, 6);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(223, 24);
            this.dtpStartDay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày bắt đầu ";
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.tbIdCardAsDriver);
            this.panel29.Controls.Add(this.label20);
            this.panel29.Location = new System.Drawing.Point(348, 89);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(339, 37);
            this.panel29.TabIndex = 5;
            // 
            // tbIdCardAsDriver
            // 
            this.tbIdCardAsDriver.Location = new System.Drawing.Point(113, 8);
            this.tbIdCardAsDriver.Name = "tbIdCardAsDriver";
            this.tbIdCardAsDriver.Size = new System.Drawing.Size(223, 24);
            this.tbIdCardAsDriver.TabIndex = 0;
            this.tbIdCardAsDriver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdCardAsDriver_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 21);
            this.label20.TabIndex = 0;
            this.label20.Text = "CMND";
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.tbPhoneAsDriver);
            this.panel30.Controls.Add(this.label21);
            this.panel30.Location = new System.Drawing.Point(3, 89);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(339, 37);
            this.panel30.TabIndex = 4;
            // 
            // tbPhoneAsDriver
            // 
            this.tbPhoneAsDriver.Location = new System.Drawing.Point(113, 8);
            this.tbPhoneAsDriver.MaxLength = 12;
            this.tbPhoneAsDriver.Name = "tbPhoneAsDriver";
            this.tbPhoneAsDriver.Size = new System.Drawing.Size(223, 24);
            this.tbPhoneAsDriver.TabIndex = 0;
            this.tbPhoneAsDriver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneAsDriver_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 21);
            this.label21.TabIndex = 0;
            this.label21.Text = "Điện thoại";
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.tbAddressAsDriver);
            this.panel31.Controls.Add(this.label22);
            this.panel31.Location = new System.Drawing.Point(348, 46);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(339, 37);
            this.panel31.TabIndex = 3;
            // 
            // tbAddressAsDriver
            // 
            this.tbAddressAsDriver.Location = new System.Drawing.Point(113, 8);
            this.tbAddressAsDriver.Name = "tbAddressAsDriver";
            this.tbAddressAsDriver.Size = new System.Drawing.Size(223, 24);
            this.tbAddressAsDriver.TabIndex = 0;
            this.tbAddressAsDriver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddressAsDriver_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 21);
            this.label22.TabIndex = 0;
            this.label22.Text = "Địa chỉ";
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.cbGender);
            this.panel32.Controls.Add(this.label23);
            this.panel32.Location = new System.Drawing.Point(3, 46);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(339, 37);
            this.panel32.TabIndex = 2;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nu",
            "Khac"});
            this.cbGender.Location = new System.Drawing.Point(113, 8);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(223, 29);
            this.cbGender.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 21);
            this.label23.TabIndex = 0;
            this.label23.Text = "Giới tính";
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.dtpDayOfBirth);
            this.panel33.Controls.Add(this.label24);
            this.panel33.Location = new System.Drawing.Point(348, 3);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(339, 37);
            this.panel33.TabIndex = 1;
            // 
            // dtpDayOfBirth
            // 
            this.dtpDayOfBirth.CustomFormat = "Short";
            this.dtpDayOfBirth.Location = new System.Drawing.Point(113, 8);
            this.dtpDayOfBirth.Name = "dtpDayOfBirth";
            this.dtpDayOfBirth.Size = new System.Drawing.Size(223, 24);
            this.dtpDayOfBirth.TabIndex = 0;
            this.dtpDayOfBirth.Value = new System.DateTime(2022, 1, 28, 15, 17, 42, 0);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 11);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 21);
            this.label24.TabIndex = 0;
            this.label24.Text = "Ngày sinh";
            // 
            // panel64
            // 
            this.panel64.Controls.Add(this.tbAsDriverName);
            this.panel64.Controls.Add(this.label25);
            this.panel64.Location = new System.Drawing.Point(3, 3);
            this.panel64.Name = "panel64";
            this.panel64.Size = new System.Drawing.Size(339, 37);
            this.panel64.TabIndex = 0;
            // 
            // tbAsDriverName
            // 
            this.tbAsDriverName.Location = new System.Drawing.Point(113, 8);
            this.tbAsDriverName.Name = "tbAsDriverName";
            this.tbAsDriverName.Size = new System.Drawing.Size(223, 24);
            this.tbAsDriverName.TabIndex = 0;
            this.tbAsDriverName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAsDriverName_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 21);
            this.label25.TabIndex = 1;
            this.label25.Text = "Họ tên";
            // 
            // btnResetAsDriver
            // 
            this.btnResetAsDriver.BackColor = System.Drawing.Color.DimGray;
            this.btnResetAsDriver.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAsDriver.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnResetAsDriver.Location = new System.Drawing.Point(717, 189);
            this.btnResetAsDriver.Name = "btnResetAsDriver";
            this.btnResetAsDriver.Size = new System.Drawing.Size(256, 56);
            this.btnResetAsDriver.TabIndex = 3;
            this.btnResetAsDriver.Text = "Nhập lại";
            this.btnResetAsDriver.UseVisualStyleBackColor = false;
            this.btnResetAsDriver.Click += new System.EventHandler(this.btnResetAsDriver_Click);
            // 
            // btnUpdateAsDriver
            // 
            this.btnUpdateAsDriver.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateAsDriver.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAsDriver.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdateAsDriver.Location = new System.Drawing.Point(717, 127);
            this.btnUpdateAsDriver.Name = "btnUpdateAsDriver";
            this.btnUpdateAsDriver.Size = new System.Drawing.Size(256, 56);
            this.btnUpdateAsDriver.TabIndex = 2;
            this.btnUpdateAsDriver.Text = "Cập nhật";
            this.btnUpdateAsDriver.UseVisualStyleBackColor = false;
            this.btnUpdateAsDriver.Click += new System.EventHandler(this.btnUpdateAsDriver_Click);
            // 
            // btnDeleteAsDriver
            // 
            this.btnDeleteAsDriver.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteAsDriver.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAsDriver.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnDeleteAsDriver.Location = new System.Drawing.Point(717, 65);
            this.btnDeleteAsDriver.Name = "btnDeleteAsDriver";
            this.btnDeleteAsDriver.Size = new System.Drawing.Size(256, 56);
            this.btnDeleteAsDriver.TabIndex = 1;
            this.btnDeleteAsDriver.Text = "Xóa";
            this.btnDeleteAsDriver.UseVisualStyleBackColor = false;
            this.btnDeleteAsDriver.Click += new System.EventHandler(this.btnDeleteAsDriver_Click);
            // 
            // btnAddAsDriver
            // 
            this.btnAddAsDriver.BackColor = System.Drawing.Color.DimGray;
            this.btnAddAsDriver.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAsDriver.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnAddAsDriver.Location = new System.Drawing.Point(717, 3);
            this.btnAddAsDriver.Name = "btnAddAsDriver";
            this.btnAddAsDriver.Size = new System.Drawing.Size(256, 56);
            this.btnAddAsDriver.TabIndex = 0;
            this.btnAddAsDriver.Text = "Thêm";
            this.btnAddAsDriver.UseVisualStyleBackColor = false;
            this.btnAddAsDriver.Click += new System.EventHandler(this.btnAddAsDriver_Click);
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.dgvAsDriver);
            this.panel25.Location = new System.Drawing.Point(3, 57);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(976, 334);
            this.panel25.TabIndex = 6;
            // 
            // dgvAsDriver
            // 
            this.dgvAsDriver.AllowUserToAddRows = false;
            this.dgvAsDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsDriver.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAsDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsDriver.Location = new System.Drawing.Point(3, 3);
            this.dgvAsDriver.Name = "dgvAsDriver";
            this.dgvAsDriver.ReadOnly = true;
            this.dgvAsDriver.Size = new System.Drawing.Size(970, 328);
            this.dgvAsDriver.TabIndex = 0;
            this.dgvAsDriver.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel5.Controls.Add(this.cbAsDriver);
            this.panel5.Controls.Add(this.tbSearchAsDriver);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(569, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(407, 48);
            this.panel5.TabIndex = 2;
            // 
            // cbAsDriver
            // 
            this.cbAsDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsDriver.FormattingEnabled = true;
            this.cbAsDriver.Location = new System.Drawing.Point(283, 10);
            this.cbAsDriver.Name = "cbAsDriver";
            this.cbAsDriver.Size = new System.Drawing.Size(121, 29);
            this.cbAsDriver.TabIndex = 2;
            this.cbAsDriver.TabStop = false;
            this.cbAsDriver.SelectedIndexChanged += new System.EventHandler(this.cbAsDriver_SelectedIndexChanged);
            // 
            // tbSearchAsDriver
            // 
            this.tbSearchAsDriver.Location = new System.Drawing.Point(88, 10);
            this.tbSearchAsDriver.Name = "tbSearchAsDriver";
            this.tbSearchAsDriver.Size = new System.Drawing.Size(189, 24);
            this.tbSearchAsDriver.TabIndex = 1;
            this.tbSearchAsDriver.TabStop = false;
            this.tbSearchAsDriver.TextChanged += new System.EventHandler(this.tbSearchAsDriver_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tìm kiếm";
            // 
            // tabPageBus
            // 
            this.tabPageBus.BackColor = System.Drawing.Color.White;
            this.tabPageBus.Controls.Add(this.btnExportPdfBus);
            this.tabPageBus.Controls.Add(this.panel16);
            this.tabPageBus.Controls.Add(this.panel2);
            this.tabPageBus.Controls.Add(this.panel4);
            this.tabPageBus.Location = new System.Drawing.Point(4, 30);
            this.tabPageBus.Name = "tabPageBus";
            this.tabPageBus.Size = new System.Drawing.Size(985, 678);
            this.tabPageBus.TabIndex = 2;
            this.tabPageBus.Text = "Xe buýt";
            // 
            // btnExportPdfBus
            // 
            this.btnExportPdfBus.BackColor = System.Drawing.Color.DimGray;
            this.btnExportPdfBus.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExportPdfBus.Location = new System.Drawing.Point(6, 16);
            this.btnExportPdfBus.Name = "btnExportPdfBus";
            this.btnExportPdfBus.Size = new System.Drawing.Size(129, 35);
            this.btnExportPdfBus.TabIndex = 12;
            this.btnExportPdfBus.TabStop = false;
            this.btnExportPdfBus.Text = "EXPORT TO PDF";
            this.btnExportPdfBus.UseVisualStyleBackColor = false;
            this.btnExportPdfBus.Click += new System.EventHandler(this.btnExportPdfBus_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel20);
            this.panel16.Controls.Add(this.btnResetBus);
            this.panel16.Controls.Add(this.btnUpdateBus);
            this.panel16.Controls.Add(this.btnDeleteBus);
            this.panel16.Controls.Add(this.btnAddBus);
            this.panel16.Location = new System.Drawing.Point(3, 394);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(977, 271);
            this.panel16.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel20.Controls.Add(this.panel21);
            this.panel20.Controls.Add(this.panel22);
            this.panel20.Controls.Add(this.panel23);
            this.panel20.Controls.Add(this.panel24);
            this.panel20.Controls.Add(this.panel65);
            this.panel20.Location = new System.Drawing.Point(3, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(708, 242);
            this.panel20.TabIndex = 0;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.nudCycle);
            this.panel21.Controls.Add(this.label14);
            this.panel21.Location = new System.Drawing.Point(3, 89);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(339, 37);
            this.panel21.TabIndex = 4;
            // 
            // nudCycle
            // 
            this.nudCycle.Location = new System.Drawing.Point(187, 9);
            this.nudCycle.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudCycle.Name = "nudCycle";
            this.nudCycle.Size = new System.Drawing.Size(149, 24);
            this.nudCycle.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Chu kỳ bảo hành (tháng)";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.nudChair);
            this.panel22.Controls.Add(this.label15);
            this.panel22.Location = new System.Drawing.Point(348, 46);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(339, 37);
            this.panel22.TabIndex = 3;
            // 
            // nudChair
            // 
            this.nudChair.Location = new System.Drawing.Point(120, 8);
            this.nudChair.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudChair.Name = "nudChair";
            this.nudChair.Size = new System.Drawing.Size(216, 24);
            this.nudChair.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Số ghế";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.nudMyear);
            this.panel23.Controls.Add(this.label16);
            this.panel23.Location = new System.Drawing.Point(3, 46);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(339, 37);
            this.panel23.TabIndex = 2;
            // 
            // nudMyear
            // 
            this.nudMyear.Location = new System.Drawing.Point(124, 8);
            this.nudMyear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudMyear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudMyear.Name = "nudMyear";
            this.nudMyear.Size = new System.Drawing.Size(212, 24);
            this.nudMyear.TabIndex = 0;
            this.nudMyear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "Năm sản xuất";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.tbManufacturer);
            this.panel24.Controls.Add(this.label17);
            this.panel24.Location = new System.Drawing.Point(348, 3);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(339, 37);
            this.panel24.TabIndex = 1;
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Location = new System.Drawing.Point(120, 8);
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.Size = new System.Drawing.Size(216, 24);
            this.tbManufacturer.TabIndex = 0;
            this.tbManufacturer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbManufacturer_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Hãng sản xuất";
            // 
            // panel65
            // 
            this.panel65.Controls.Add(this.tbLicensePlate);
            this.panel65.Controls.Add(this.label18);
            this.panel65.Location = new System.Drawing.Point(3, 3);
            this.panel65.Name = "panel65";
            this.panel65.Size = new System.Drawing.Size(339, 37);
            this.panel65.TabIndex = 0;
            // 
            // tbLicensePlate
            // 
            this.tbLicensePlate.Location = new System.Drawing.Point(123, 8);
            this.tbLicensePlate.Name = "tbLicensePlate";
            this.tbLicensePlate.Size = new System.Drawing.Size(213, 24);
            this.tbLicensePlate.TabIndex = 0;
            this.tbLicensePlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLicensePlate_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Biển kiếm soát";
            // 
            // btnResetBus
            // 
            this.btnResetBus.BackColor = System.Drawing.Color.DimGray;
            this.btnResetBus.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetBus.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnResetBus.Location = new System.Drawing.Point(717, 189);
            this.btnResetBus.Name = "btnResetBus";
            this.btnResetBus.Size = new System.Drawing.Size(257, 56);
            this.btnResetBus.TabIndex = 3;
            this.btnResetBus.Text = "Nhập lại";
            this.btnResetBus.UseVisualStyleBackColor = false;
            this.btnResetBus.Click += new System.EventHandler(this.btnResetBus_Click);
            // 
            // btnUpdateBus
            // 
            this.btnUpdateBus.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateBus.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBus.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdateBus.Location = new System.Drawing.Point(717, 127);
            this.btnUpdateBus.Name = "btnUpdateBus";
            this.btnUpdateBus.Size = new System.Drawing.Size(257, 56);
            this.btnUpdateBus.TabIndex = 2;
            this.btnUpdateBus.Text = "Cập nhật";
            this.btnUpdateBus.UseVisualStyleBackColor = false;
            this.btnUpdateBus.Click += new System.EventHandler(this.btnUpdateBus_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteBus.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBus.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnDeleteBus.Location = new System.Drawing.Point(717, 65);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(257, 56);
            this.btnDeleteBus.TabIndex = 1;
            this.btnDeleteBus.Text = "Xóa";
            this.btnDeleteBus.UseVisualStyleBackColor = false;
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // btnAddBus
            // 
            this.btnAddBus.BackColor = System.Drawing.Color.DimGray;
            this.btnAddBus.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBus.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnAddBus.Location = new System.Drawing.Point(717, 3);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(257, 56);
            this.btnAddBus.TabIndex = 0;
            this.btnAddBus.Text = "Thêm";
            this.btnAddBus.UseVisualStyleBackColor = false;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBus);
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 334);
            this.panel2.TabIndex = 5;
            // 
            // dgvBus
            // 
            this.dgvBus.AllowUserToAddRows = false;
            this.dgvBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBus.Location = new System.Drawing.Point(3, 3);
            this.dgvBus.Name = "dgvBus";
            this.dgvBus.ReadOnly = true;
            this.dgvBus.Size = new System.Drawing.Size(971, 328);
            this.dgvBus.TabIndex = 0;
            this.dgvBus.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel4.Controls.Add(this.cbBus);
            this.panel4.Controls.Add(this.tbSearchBus);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(570, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 48);
            this.panel4.TabIndex = 3;
            // 
            // cbBus
            // 
            this.cbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBus.FormattingEnabled = true;
            this.cbBus.Location = new System.Drawing.Point(283, 10);
            this.cbBus.Name = "cbBus";
            this.cbBus.Size = new System.Drawing.Size(121, 29);
            this.cbBus.TabIndex = 2;
            this.cbBus.TabStop = false;
            this.cbBus.SelectedIndexChanged += new System.EventHandler(this.cbBus_SelectedIndexChanged);
            // 
            // tbSearchBus
            // 
            this.tbSearchBus.Location = new System.Drawing.Point(88, 10);
            this.tbSearchBus.Name = "tbSearchBus";
            this.tbSearchBus.Size = new System.Drawing.Size(189, 24);
            this.tbSearchBus.TabIndex = 1;
            this.tbSearchBus.TabStop = false;
            this.tbSearchBus.TextChanged += new System.EventHandler(this.tbSearchBus_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm";
            // 
            // tabPageBusLine
            // 
            this.tabPageBusLine.Controls.Add(this.btnExportPdfBusLine);
            this.tabPageBusLine.Controls.Add(this.panel9);
            this.tabPageBusLine.Controls.Add(this.panel8);
            this.tabPageBusLine.Controls.Add(this.panel7);
            this.tabPageBusLine.Controls.Add(this.panel3);
            this.tabPageBusLine.Location = new System.Drawing.Point(4, 30);
            this.tabPageBusLine.Name = "tabPageBusLine";
            this.tabPageBusLine.Size = new System.Drawing.Size(985, 678);
            this.tabPageBusLine.TabIndex = 3;
            this.tabPageBusLine.Text = "Tuyến xe";
            this.tabPageBusLine.UseVisualStyleBackColor = true;
            // 
            // btnExportPdfBusLine
            // 
            this.btnExportPdfBusLine.BackColor = System.Drawing.Color.DimGray;
            this.btnExportPdfBusLine.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExportPdfBusLine.Location = new System.Drawing.Point(6, 16);
            this.btnExportPdfBusLine.Name = "btnExportPdfBusLine";
            this.btnExportPdfBusLine.Size = new System.Drawing.Size(129, 35);
            this.btnExportPdfBusLine.TabIndex = 13;
            this.btnExportPdfBusLine.TabStop = false;
            this.btnExportPdfBusLine.Text = "EXPORT TO PDF";
            this.btnExportPdfBusLine.UseVisualStyleBackColor = false;
            this.btnExportPdfBusLine.Click += new System.EventHandler(this.btnExportPdfBusLine_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.btnResetBusLine);
            this.panel9.Controls.Add(this.btnUpdateBusLine);
            this.panel9.Controls.Add(this.btnDeleteBusLine);
            this.panel9.Controls.Add(this.btnAddBusLine);
            this.panel9.Location = new System.Drawing.Point(3, 394);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(977, 271);
            this.panel9.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel10.Controls.Add(this.panel15);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel17);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel66);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(708, 242);
            this.panel10.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.tbBusLineDetail);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Location = new System.Drawing.Point(3, 132);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(684, 110);
            this.panel15.TabIndex = 6;
            // 
            // tbBusLineDetail
            // 
            this.tbBusLineDetail.Location = new System.Drawing.Point(113, 8);
            this.tbBusLineDetail.Multiline = true;
            this.tbBusLineDetail.Name = "tbBusLineDetail";
            this.tbBusLineDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBusLineDetail.Size = new System.Drawing.Size(568, 91);
            this.tbBusLineDetail.TabIndex = 0;
            this.tbBusLineDetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBusLineDetail_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Chi tiết trạm";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.tbEndLocation);
            this.panel14.Controls.Add(this.label10);
            this.panel14.Location = new System.Drawing.Point(348, 89);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(339, 37);
            this.panel14.TabIndex = 5;
            // 
            // tbEndLocation
            // 
            this.tbEndLocation.Location = new System.Drawing.Point(113, 8);
            this.tbEndLocation.Name = "tbEndLocation";
            this.tbEndLocation.Size = new System.Drawing.Size(223, 24);
            this.tbEndLocation.TabIndex = 0;
            this.tbEndLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEndLocation_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Điểm cuối";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tbStartLocation);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Location = new System.Drawing.Point(3, 89);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(339, 37);
            this.panel11.TabIndex = 4;
            // 
            // tbStartLocation
            // 
            this.tbStartLocation.Location = new System.Drawing.Point(113, 8);
            this.tbStartLocation.Name = "tbStartLocation";
            this.tbStartLocation.Size = new System.Drawing.Size(223, 24);
            this.tbStartLocation.TabIndex = 0;
            this.tbStartLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStartLocation_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm đầu";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.nudEndTime);
            this.panel13.Controls.Add(this.label9);
            this.panel13.Location = new System.Drawing.Point(348, 46);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(339, 37);
            this.panel13.TabIndex = 3;
            // 
            // nudEndTime
            // 
            this.nudEndTime.Location = new System.Drawing.Point(113, 8);
            this.nudEndTime.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudEndTime.Name = "nudEndTime";
            this.nudEndTime.Size = new System.Drawing.Size(223, 24);
            this.nudEndTime.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giờ kết thúc";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.nudStartTime);
            this.panel17.Controls.Add(this.label13);
            this.panel17.Location = new System.Drawing.Point(3, 46);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(339, 37);
            this.panel17.TabIndex = 2;
            // 
            // nudStartTime
            // 
            this.nudStartTime.Location = new System.Drawing.Point(113, 8);
            this.nudStartTime.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudStartTime.Name = "nudStartTime";
            this.nudStartTime.Size = new System.Drawing.Size(223, 24);
            this.nudStartTime.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Giờ bắt đầu";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.nudFrequency);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Location = new System.Drawing.Point(348, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(339, 37);
            this.panel12.TabIndex = 1;
            // 
            // nudFrequency
            // 
            this.nudFrequency.Location = new System.Drawing.Point(113, 8);
            this.nudFrequency.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudFrequency.Name = "nudFrequency";
            this.nudFrequency.Size = new System.Drawing.Size(223, 24);
            this.nudFrequency.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tần suất(phút)";
            // 
            // panel66
            // 
            this.panel66.Controls.Add(this.tbBusLineName);
            this.panel66.Controls.Add(this.label6);
            this.panel66.Location = new System.Drawing.Point(3, 3);
            this.panel66.Name = "panel66";
            this.panel66.Size = new System.Drawing.Size(339, 37);
            this.panel66.TabIndex = 0;
            // 
            // tbBusLineName
            // 
            this.tbBusLineName.Location = new System.Drawing.Point(113, 8);
            this.tbBusLineName.Name = "tbBusLineName";
            this.tbBusLineName.Size = new System.Drawing.Size(223, 24);
            this.tbBusLineName.TabIndex = 0;
            this.tbBusLineName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBusLineName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên tuyến  xe";
            // 
            // btnResetBusLine
            // 
            this.btnResetBusLine.BackColor = System.Drawing.Color.DimGray;
            this.btnResetBusLine.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetBusLine.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnResetBusLine.Location = new System.Drawing.Point(717, 189);
            this.btnResetBusLine.Name = "btnResetBusLine";
            this.btnResetBusLine.Size = new System.Drawing.Size(257, 56);
            this.btnResetBusLine.TabIndex = 4;
            this.btnResetBusLine.Text = "Nhập lại";
            this.btnResetBusLine.UseVisualStyleBackColor = false;
            this.btnResetBusLine.Click += new System.EventHandler(this.btnResetBusLine_Click);
            // 
            // btnUpdateBusLine
            // 
            this.btnUpdateBusLine.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateBusLine.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBusLine.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdateBusLine.Location = new System.Drawing.Point(717, 127);
            this.btnUpdateBusLine.Name = "btnUpdateBusLine";
            this.btnUpdateBusLine.Size = new System.Drawing.Size(257, 56);
            this.btnUpdateBusLine.TabIndex = 3;
            this.btnUpdateBusLine.Text = "Cập nhật";
            this.btnUpdateBusLine.UseVisualStyleBackColor = false;
            this.btnUpdateBusLine.Click += new System.EventHandler(this.btnUpdateBusLine_Click);
            // 
            // btnDeleteBusLine
            // 
            this.btnDeleteBusLine.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteBusLine.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBusLine.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnDeleteBusLine.Location = new System.Drawing.Point(717, 65);
            this.btnDeleteBusLine.Name = "btnDeleteBusLine";
            this.btnDeleteBusLine.Size = new System.Drawing.Size(257, 56);
            this.btnDeleteBusLine.TabIndex = 2;
            this.btnDeleteBusLine.Text = "Xóa";
            this.btnDeleteBusLine.UseVisualStyleBackColor = false;
            this.btnDeleteBusLine.Click += new System.EventHandler(this.btnDeleteBusLine_Click);
            // 
            // btnAddBusLine
            // 
            this.btnAddBusLine.BackColor = System.Drawing.Color.DimGray;
            this.btnAddBusLine.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBusLine.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnAddBusLine.Location = new System.Drawing.Point(717, 3);
            this.btnAddBusLine.Name = "btnAddBusLine";
            this.btnAddBusLine.Size = new System.Drawing.Size(257, 56);
            this.btnAddBusLine.TabIndex = 1;
            this.btnAddBusLine.Text = "Thêm";
            this.btnAddBusLine.UseVisualStyleBackColor = false;
            this.btnAddBusLine.Click += new System.EventHandler(this.btnAddBusLine_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvBusLine);
            this.panel8.Location = new System.Drawing.Point(3, 57);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(977, 334);
            this.panel8.TabIndex = 4;
            // 
            // dgvBusLine
            // 
            this.dgvBusLine.AllowUserToAddRows = false;
            this.dgvBusLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusLine.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBusLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusLine.Location = new System.Drawing.Point(3, 3);
            this.dgvBusLine.Name = "dgvBusLine";
            this.dgvBusLine.ReadOnly = true;
            this.dgvBusLine.Size = new System.Drawing.Size(971, 328);
            this.dgvBusLine.TabIndex = 0;
            this.dgvBusLine.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(-39, -98);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel3.Controls.Add(this.cbBusLine);
            this.panel3.Controls.Add(this.tbSearchBusLine);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(570, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 48);
            this.panel3.TabIndex = 2;
            // 
            // cbBusLine
            // 
            this.cbBusLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusLine.FormattingEnabled = true;
            this.cbBusLine.Location = new System.Drawing.Point(283, 10);
            this.cbBusLine.Name = "cbBusLine";
            this.cbBusLine.Size = new System.Drawing.Size(121, 29);
            this.cbBusLine.TabIndex = 2;
            this.cbBusLine.TabStop = false;
            this.cbBusLine.SelectedIndexChanged += new System.EventHandler(this.cbBusLine_SelectedIndexChanged);
            // 
            // tbSearchBusLine
            // 
            this.tbSearchBusLine.Location = new System.Drawing.Point(88, 10);
            this.tbSearchBusLine.Name = "tbSearchBusLine";
            this.tbSearchBusLine.Size = new System.Drawing.Size(189, 24);
            this.tbSearchBusLine.TabIndex = 1;
            this.tbSearchBusLine.TabStop = false;
            this.tbSearchBusLine.TextChanged += new System.EventHandler(this.tbSearchBusLine_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm";
            // 
            // tabPageBusRide
            // 
            this.tabPageBusRide.Controls.Add(this.btnExportPdfBusRide);
            this.tabPageBusRide.Controls.Add(this.panel45);
            this.tabPageBusRide.Controls.Add(this.panel44);
            this.tabPageBusRide.Controls.Add(this.panel43);
            this.tabPageBusRide.Controls.Add(this.panel1);
            this.tabPageBusRide.Location = new System.Drawing.Point(4, 30);
            this.tabPageBusRide.Name = "tabPageBusRide";
            this.tabPageBusRide.Size = new System.Drawing.Size(985, 678);
            this.tabPageBusRide.TabIndex = 4;
            this.tabPageBusRide.Text = "Chuyến xe";
            this.tabPageBusRide.UseVisualStyleBackColor = true;
            // 
            // btnExportPdfBusRide
            // 
            this.btnExportPdfBusRide.BackColor = System.Drawing.Color.DimGray;
            this.btnExportPdfBusRide.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExportPdfBusRide.Location = new System.Drawing.Point(6, 16);
            this.btnExportPdfBusRide.Name = "btnExportPdfBusRide";
            this.btnExportPdfBusRide.Size = new System.Drawing.Size(129, 35);
            this.btnExportPdfBusRide.TabIndex = 14;
            this.btnExportPdfBusRide.TabStop = false;
            this.btnExportPdfBusRide.Text = "EXPORT TO PDF";
            this.btnExportPdfBusRide.UseVisualStyleBackColor = false;
            this.btnExportPdfBusRide.Click += new System.EventHandler(this.btnExportPdfBusRide_Click);
            // 
            // panel45
            // 
            this.panel45.Controls.Add(this.panel48);
            this.panel45.Controls.Add(this.btnResetBusRide);
            this.panel45.Controls.Add(this.btnUpdateBusRide);
            this.panel45.Controls.Add(this.btnDeleteBusRide);
            this.panel45.Controls.Add(this.btnAddBusRide);
            this.panel45.Location = new System.Drawing.Point(3, 394);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(977, 271);
            this.panel45.TabIndex = 0;
            // 
            // panel48
            // 
            this.panel48.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel48.Controls.Add(this.panel49);
            this.panel48.Controls.Add(this.panel50);
            this.panel48.Controls.Add(this.panel51);
            this.panel48.Controls.Add(this.panel52);
            this.panel48.Controls.Add(this.panel67);
            this.panel48.Location = new System.Drawing.Point(3, 3);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(708, 241);
            this.panel48.TabIndex = 0;
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.dtpStartTimeBusRide);
            this.panel49.Controls.Add(this.label36);
            this.panel49.Location = new System.Drawing.Point(3, 171);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(578, 37);
            this.panel49.TabIndex = 4;
            // 
            // dtpStartTimeBusRide
            // 
            this.dtpStartTimeBusRide.Location = new System.Drawing.Point(113, 6);
            this.dtpStartTimeBusRide.Name = "dtpStartTimeBusRide";
            this.dtpStartTimeBusRide.Size = new System.Drawing.Size(235, 24);
            this.dtpStartTimeBusRide.TabIndex = 0;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(12, 11);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(73, 21);
            this.label36.TabIndex = 0;
            this.label36.Text = "Thời điểm";
            // 
            // panel50
            // 
            this.panel50.Controls.Add(this.tbBusBR);
            this.panel50.Controls.Add(this.cbBusBR);
            this.panel50.Controls.Add(this.label37);
            this.panel50.Location = new System.Drawing.Point(3, 130);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(578, 37);
            this.panel50.TabIndex = 3;
            // 
            // tbBusBR
            // 
            this.tbBusBR.Location = new System.Drawing.Point(214, 8);
            this.tbBusBR.Name = "tbBusBR";
            this.tbBusBR.ReadOnly = true;
            this.tbBusBR.Size = new System.Drawing.Size(361, 24);
            this.tbBusBR.TabIndex = 17;
            this.tbBusBR.TabStop = false;
            // 
            // cbBusBR
            // 
            this.cbBusBR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusBR.FormattingEnabled = true;
            this.cbBusBR.IntegralHeight = false;
            this.cbBusBR.Location = new System.Drawing.Point(113, 6);
            this.cbBusBR.MaxDropDownItems = 5;
            this.cbBusBR.Name = "cbBusBR";
            this.cbBusBR.Size = new System.Drawing.Size(95, 29);
            this.cbBusBR.TabIndex = 0;
            this.cbBusBR.SelectedIndexChanged += new System.EventHandler(this.cbBusBR_SelectedIndexChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(12, 11);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(48, 21);
            this.label37.TabIndex = 0;
            this.label37.Text = "Mã xe";
            // 
            // panel51
            // 
            this.panel51.Controls.Add(this.tbAsDriverBR);
            this.panel51.Controls.Add(this.cbAsDriverBR);
            this.panel51.Controls.Add(this.label38);
            this.panel51.Location = new System.Drawing.Point(3, 88);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(578, 37);
            this.panel51.TabIndex = 2;
            // 
            // tbAsDriverBR
            // 
            this.tbAsDriverBR.Location = new System.Drawing.Point(214, 8);
            this.tbAsDriverBR.Name = "tbAsDriverBR";
            this.tbAsDriverBR.ReadOnly = true;
            this.tbAsDriverBR.Size = new System.Drawing.Size(361, 24);
            this.tbAsDriverBR.TabIndex = 15;
            this.tbAsDriverBR.TabStop = false;
            // 
            // cbAsDriverBR
            // 
            this.cbAsDriverBR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsDriverBR.FormattingEnabled = true;
            this.cbAsDriverBR.IntegralHeight = false;
            this.cbAsDriverBR.Location = new System.Drawing.Point(113, 7);
            this.cbAsDriverBR.MaxDropDownItems = 5;
            this.cbAsDriverBR.Name = "cbAsDriverBR";
            this.cbAsDriverBR.Size = new System.Drawing.Size(95, 29);
            this.cbAsDriverBR.TabIndex = 0;
            this.cbAsDriverBR.SelectedIndexChanged += new System.EventHandler(this.cbAsDriverBR_SelectedIndexChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(12, 11);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(76, 21);
            this.label38.TabIndex = 0;
            this.label38.Text = "Mã phụ xe";
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.tbDriverBR);
            this.panel52.Controls.Add(this.cbDriverBR);
            this.panel52.Controls.Add(this.label39);
            this.panel52.Location = new System.Drawing.Point(3, 46);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(578, 37);
            this.panel52.TabIndex = 1;
            // 
            // tbDriverBR
            // 
            this.tbDriverBR.Location = new System.Drawing.Point(214, 8);
            this.tbDriverBR.Name = "tbDriverBR";
            this.tbDriverBR.ReadOnly = true;
            this.tbDriverBR.Size = new System.Drawing.Size(361, 24);
            this.tbDriverBR.TabIndex = 14;
            this.tbDriverBR.TabStop = false;
            // 
            // cbDriverBR
            // 
            this.cbDriverBR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriverBR.FormattingEnabled = true;
            this.cbDriverBR.IntegralHeight = false;
            this.cbDriverBR.ItemHeight = 21;
            this.cbDriverBR.Location = new System.Drawing.Point(113, 7);
            this.cbDriverBR.MaxDropDownItems = 5;
            this.cbDriverBR.Name = "cbDriverBR";
            this.cbDriverBR.Size = new System.Drawing.Size(95, 29);
            this.cbDriverBR.TabIndex = 0;
            this.cbDriverBR.SelectedIndexChanged += new System.EventHandler(this.cbDriverBR_SelectedIndexChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(12, 11);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(69, 21);
            this.label39.TabIndex = 0;
            this.label39.Text = "Mã tài xế";
            // 
            // panel67
            // 
            this.panel67.Controls.Add(this.tbBusLineBR);
            this.panel67.Controls.Add(this.cbBusLineBR);
            this.panel67.Controls.Add(this.label40);
            this.panel67.Location = new System.Drawing.Point(3, 3);
            this.panel67.Name = "panel67";
            this.panel67.Size = new System.Drawing.Size(578, 37);
            this.panel67.TabIndex = 0;
            // 
            // tbBusLineBR
            // 
            this.tbBusLineBR.Location = new System.Drawing.Point(214, 8);
            this.tbBusLineBR.Name = "tbBusLineBR";
            this.tbBusLineBR.ReadOnly = true;
            this.tbBusLineBR.Size = new System.Drawing.Size(361, 24);
            this.tbBusLineBR.TabIndex = 13;
            this.tbBusLineBR.TabStop = false;
            // 
            // cbBusLineBR
            // 
            this.cbBusLineBR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusLineBR.FormattingEnabled = true;
            this.cbBusLineBR.IntegralHeight = false;
            this.cbBusLineBR.Location = new System.Drawing.Point(113, 7);
            this.cbBusLineBR.MaxDropDownItems = 5;
            this.cbBusLineBR.Name = "cbBusLineBR";
            this.cbBusLineBR.Size = new System.Drawing.Size(95, 29);
            this.cbBusLineBR.TabIndex = 0;
            this.cbBusLineBR.SelectedIndexChanged += new System.EventHandler(this.cbBusLineBR_SelectedIndexChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(12, 11);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(89, 21);
            this.label40.TabIndex = 0;
            this.label40.Text = "Mã tuyến xe";
            // 
            // btnResetBusRide
            // 
            this.btnResetBusRide.BackColor = System.Drawing.Color.DimGray;
            this.btnResetBusRide.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetBusRide.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnResetBusRide.Location = new System.Drawing.Point(717, 189);
            this.btnResetBusRide.Name = "btnResetBusRide";
            this.btnResetBusRide.Size = new System.Drawing.Size(257, 56);
            this.btnResetBusRide.TabIndex = 4;
            this.btnResetBusRide.Text = "Nhập lại";
            this.btnResetBusRide.UseVisualStyleBackColor = false;
            this.btnResetBusRide.Click += new System.EventHandler(this.btnResetBusRide_Click);
            // 
            // btnUpdateBusRide
            // 
            this.btnUpdateBusRide.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateBusRide.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBusRide.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdateBusRide.Location = new System.Drawing.Point(717, 127);
            this.btnUpdateBusRide.Name = "btnUpdateBusRide";
            this.btnUpdateBusRide.Size = new System.Drawing.Size(257, 56);
            this.btnUpdateBusRide.TabIndex = 3;
            this.btnUpdateBusRide.Text = "Cập nhật";
            this.btnUpdateBusRide.UseVisualStyleBackColor = false;
            this.btnUpdateBusRide.Click += new System.EventHandler(this.btnUpdateBusRide_Click);
            // 
            // btnDeleteBusRide
            // 
            this.btnDeleteBusRide.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteBusRide.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBusRide.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnDeleteBusRide.Location = new System.Drawing.Point(717, 65);
            this.btnDeleteBusRide.Name = "btnDeleteBusRide";
            this.btnDeleteBusRide.Size = new System.Drawing.Size(257, 56);
            this.btnDeleteBusRide.TabIndex = 2;
            this.btnDeleteBusRide.Text = "Xóa";
            this.btnDeleteBusRide.UseVisualStyleBackColor = false;
            this.btnDeleteBusRide.Click += new System.EventHandler(this.btnDeleteBusRide_Click);
            // 
            // btnAddBusRide
            // 
            this.btnAddBusRide.BackColor = System.Drawing.Color.DimGray;
            this.btnAddBusRide.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBusRide.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnAddBusRide.Location = new System.Drawing.Point(717, 3);
            this.btnAddBusRide.Name = "btnAddBusRide";
            this.btnAddBusRide.Size = new System.Drawing.Size(257, 56);
            this.btnAddBusRide.TabIndex = 1;
            this.btnAddBusRide.Text = "Thêm";
            this.btnAddBusRide.UseVisualStyleBackColor = false;
            this.btnAddBusRide.Click += new System.EventHandler(this.btnAddBusRide_Click);
            // 
            // panel44
            // 
            this.panel44.Controls.Add(this.dgvBusRide);
            this.panel44.Location = new System.Drawing.Point(3, 57);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(977, 334);
            this.panel44.TabIndex = 5;
            // 
            // dgvBusRide
            // 
            this.dgvBusRide.AllowUserToAddRows = false;
            this.dgvBusRide.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusRide.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBusRide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusRide.Location = new System.Drawing.Point(3, 3);
            this.dgvBusRide.Name = "dgvBusRide";
            this.dgvBusRide.ReadOnly = true;
            this.dgvBusRide.Size = new System.Drawing.Size(971, 328);
            this.dgvBusRide.TabIndex = 0;
            this.dgvBusRide.TabStop = false;
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel43.Controls.Add(this.cbBusRide);
            this.panel43.Controls.Add(this.tbSearchBusRide);
            this.panel43.Controls.Add(this.label33);
            this.panel43.Location = new System.Drawing.Point(570, 6);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(407, 48);
            this.panel43.TabIndex = 3;
            // 
            // cbBusRide
            // 
            this.cbBusRide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusRide.FormattingEnabled = true;
            this.cbBusRide.Location = new System.Drawing.Point(283, 10);
            this.cbBusRide.Name = "cbBusRide";
            this.cbBusRide.Size = new System.Drawing.Size(121, 29);
            this.cbBusRide.TabIndex = 2;
            this.cbBusRide.TabStop = false;
            this.cbBusRide.SelectedIndexChanged += new System.EventHandler(this.cbBusRide_SelectedIndexChanged);
            // 
            // tbSearchBusRide
            // 
            this.tbSearchBusRide.Location = new System.Drawing.Point(88, 10);
            this.tbSearchBusRide.Name = "tbSearchBusRide";
            this.tbSearchBusRide.Size = new System.Drawing.Size(189, 24);
            this.tbSearchBusRide.TabIndex = 1;
            this.tbSearchBusRide.TabStop = false;
            this.tbSearchBusRide.TextChanged += new System.EventHandler(this.tbSearchBusRide_TextChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 13);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(67, 21);
            this.label33.TabIndex = 0;
            this.label33.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-39, -98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // tabPageTicket
            // 
            this.tabPageTicket.Controls.Add(this.btnExportPdfTicket);
            this.tabPageTicket.Controls.Add(this.panel55);
            this.tabPageTicket.Controls.Add(this.panel61);
            this.tabPageTicket.Controls.Add(this.panel62);
            this.tabPageTicket.Location = new System.Drawing.Point(4, 30);
            this.tabPageTicket.Name = "tabPageTicket";
            this.tabPageTicket.Size = new System.Drawing.Size(985, 678);
            this.tabPageTicket.TabIndex = 6;
            this.tabPageTicket.Text = "Vé xe";
            this.tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // btnExportPdfTicket
            // 
            this.btnExportPdfTicket.BackColor = System.Drawing.Color.DimGray;
            this.btnExportPdfTicket.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExportPdfTicket.Location = new System.Drawing.Point(6, 16);
            this.btnExportPdfTicket.Name = "btnExportPdfTicket";
            this.btnExportPdfTicket.Size = new System.Drawing.Size(129, 35);
            this.btnExportPdfTicket.TabIndex = 18;
            this.btnExportPdfTicket.TabStop = false;
            this.btnExportPdfTicket.Text = "EXPORT TO PDF";
            this.btnExportPdfTicket.UseVisualStyleBackColor = false;
            this.btnExportPdfTicket.Click += new System.EventHandler(this.btnExportPdfTicket_Click);
            // 
            // panel55
            // 
            this.panel55.Controls.Add(this.panel56);
            this.panel55.Controls.Add(this.btResetTicket);
            this.panel55.Controls.Add(this.btnUpdateTicket);
            this.panel55.Controls.Add(this.btnDeleteTicket);
            this.panel55.Controls.Add(this.btnAddTicket);
            this.panel55.Location = new System.Drawing.Point(3, 394);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(977, 271);
            this.panel55.TabIndex = 0;
            // 
            // panel56
            // 
            this.panel56.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel56.Controls.Add(this.panel57);
            this.panel56.Controls.Add(this.panel59);
            this.panel56.Controls.Add(this.panel68);
            this.panel56.Location = new System.Drawing.Point(3, 3);
            this.panel56.Name = "panel56";
            this.panel56.Size = new System.Drawing.Size(708, 242);
            this.panel56.TabIndex = 0;
            // 
            // panel57
            // 
            this.panel57.Controls.Add(this.dtpTicket);
            this.panel57.Controls.Add(this.label41);
            this.panel57.Location = new System.Drawing.Point(3, 3);
            this.panel57.Name = "panel57";
            this.panel57.Size = new System.Drawing.Size(339, 37);
            this.panel57.TabIndex = 0;
            // 
            // dtpTicket
            // 
            this.dtpTicket.Location = new System.Drawing.Point(113, 7);
            this.dtpTicket.Name = "dtpTicket";
            this.dtpTicket.Size = new System.Drawing.Size(223, 24);
            this.dtpTicket.TabIndex = 0;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(12, 11);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(73, 21);
            this.label41.TabIndex = 0;
            this.label41.Text = "Thời điểm";
            // 
            // panel59
            // 
            this.panel59.Controls.Add(this.tbTicketAsDriverName);
            this.panel59.Controls.Add(this.cbTicketAsDriverId);
            this.panel59.Controls.Add(this.label42);
            this.panel59.Location = new System.Drawing.Point(3, 46);
            this.panel59.Name = "panel59";
            this.panel59.Size = new System.Drawing.Size(578, 37);
            this.panel59.TabIndex = 2;
            // 
            // tbTicketAsDriverName
            // 
            this.tbTicketAsDriverName.Location = new System.Drawing.Point(214, 8);
            this.tbTicketAsDriverName.Name = "tbTicketAsDriverName";
            this.tbTicketAsDriverName.ReadOnly = true;
            this.tbTicketAsDriverName.Size = new System.Drawing.Size(361, 24);
            this.tbTicketAsDriverName.TabIndex = 17;
            this.tbTicketAsDriverName.TabStop = false;
            // 
            // cbTicketAsDriverId
            // 
            this.cbTicketAsDriverId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketAsDriverId.FormattingEnabled = true;
            this.cbTicketAsDriverId.IntegralHeight = false;
            this.cbTicketAsDriverId.Location = new System.Drawing.Point(113, 6);
            this.cbTicketAsDriverId.MaxDropDownItems = 5;
            this.cbTicketAsDriverId.Name = "cbTicketAsDriverId";
            this.cbTicketAsDriverId.Size = new System.Drawing.Size(95, 29);
            this.cbTicketAsDriverId.TabIndex = 0;
            this.cbTicketAsDriverId.SelectedIndexChanged += new System.EventHandler(this.cbTicketAsDriverId_SelectedIndexChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(12, 11);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(76, 21);
            this.label42.TabIndex = 0;
            this.label42.Text = "Mã phụ xe";
            // 
            // panel68
            // 
            this.panel68.Controls.Add(this.nudTicket);
            this.panel68.Controls.Add(this.label44);
            this.panel68.Location = new System.Drawing.Point(348, 3);
            this.panel68.Name = "panel68";
            this.panel68.Size = new System.Drawing.Size(339, 37);
            this.panel68.TabIndex = 1;
            // 
            // nudTicket
            // 
            this.nudTicket.Location = new System.Drawing.Point(113, 9);
            this.nudTicket.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTicket.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTicket.Name = "nudTicket";
            this.nudTicket.Size = new System.Drawing.Size(117, 24);
            this.nudTicket.TabIndex = 0;
            this.nudTicket.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(13, 11);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(94, 21);
            this.label44.TabIndex = 0;
            this.label44.Text = "Giá vé (VNĐ)";
            // 
            // btResetTicket
            // 
            this.btResetTicket.BackColor = System.Drawing.Color.DimGray;
            this.btResetTicket.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetTicket.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btResetTicket.Location = new System.Drawing.Point(717, 189);
            this.btResetTicket.Name = "btResetTicket";
            this.btResetTicket.Size = new System.Drawing.Size(257, 56);
            this.btResetTicket.TabIndex = 4;
            this.btResetTicket.Text = "Nhập lại";
            this.btResetTicket.UseVisualStyleBackColor = false;
            this.btResetTicket.Click += new System.EventHandler(this.btResetTicket_Click);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateTicket.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTicket.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdateTicket.Location = new System.Drawing.Point(717, 127);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(257, 56);
            this.btnUpdateTicket.TabIndex = 3;
            this.btnUpdateTicket.Text = "Cập nhật";
            this.btnUpdateTicket.UseVisualStyleBackColor = false;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteTicket.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicket.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnDeleteTicket.Location = new System.Drawing.Point(717, 65);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(257, 56);
            this.btnDeleteTicket.TabIndex = 2;
            this.btnDeleteTicket.Text = "Xóa";
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BackColor = System.Drawing.Color.DimGray;
            this.btnAddTicket.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicket.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnAddTicket.Location = new System.Drawing.Point(717, 3);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(257, 56);
            this.btnAddTicket.TabIndex = 1;
            this.btnAddTicket.Text = "Thêm";
            this.btnAddTicket.UseVisualStyleBackColor = false;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.dgvTicket);
            this.panel61.Location = new System.Drawing.Point(3, 57);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(977, 334);
            this.panel61.TabIndex = 16;
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToAddRows = false;
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(3, 3);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.Size = new System.Drawing.Size(971, 328);
            this.dgvTicket.TabIndex = 0;
            this.dgvTicket.TabStop = false;
            // 
            // panel62
            // 
            this.panel62.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel62.Controls.Add(this.cbTicket);
            this.panel62.Controls.Add(this.tbSearchTicket);
            this.panel62.Controls.Add(this.label46);
            this.panel62.Location = new System.Drawing.Point(570, 6);
            this.panel62.Name = "panel62";
            this.panel62.Size = new System.Drawing.Size(407, 48);
            this.panel62.TabIndex = 15;
            // 
            // cbTicket
            // 
            this.cbTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicket.FormattingEnabled = true;
            this.cbTicket.Location = new System.Drawing.Point(283, 10);
            this.cbTicket.Name = "cbTicket";
            this.cbTicket.Size = new System.Drawing.Size(121, 29);
            this.cbTicket.TabIndex = 2;
            this.cbTicket.TabStop = false;
            this.cbTicket.SelectedIndexChanged += new System.EventHandler(this.cbTicket_SelectedIndexChanged);
            // 
            // tbSearchTicket
            // 
            this.tbSearchTicket.Location = new System.Drawing.Point(88, 10);
            this.tbSearchTicket.Name = "tbSearchTicket";
            this.tbSearchTicket.Size = new System.Drawing.Size(189, 24);
            this.tbSearchTicket.TabIndex = 1;
            this.tbSearchTicket.TabStop = false;
            this.tbSearchTicket.TextChanged += new System.EventHandler(this.tbSearchTicket_TextChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(3, 13);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(67, 21);
            this.label46.TabIndex = 0;
            this.label46.Text = "Tìm kiếm";
            // 
            // tabPageStat
            // 
            this.tabPageStat.Controls.Add(this.panel58);
            this.tabPageStat.Controls.Add(this.panel53);
            this.tabPageStat.Controls.Add(this.panel47);
            this.tabPageStat.Location = new System.Drawing.Point(4, 30);
            this.tabPageStat.Name = "tabPageStat";
            this.tabPageStat.Size = new System.Drawing.Size(985, 678);
            this.tabPageStat.TabIndex = 5;
            this.tabPageStat.Text = "Thống kê";
            this.tabPageStat.UseVisualStyleBackColor = true;
            // 
            // panel58
            // 
            this.panel58.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel58.Controls.Add(this.btnSumary);
            this.panel58.Controls.Add(this.btnDatStat);
            this.panel58.Controls.Add(this.panel60);
            this.panel58.Controls.Add(this.panel72);
            this.panel58.Location = new System.Drawing.Point(3, 9);
            this.panel58.Name = "panel58";
            this.panel58.Size = new System.Drawing.Size(860, 47);
            this.panel58.TabIndex = 0;
            // 
            // btnSumary
            // 
            this.btnSumary.BackColor = System.Drawing.Color.DimGray;
            this.btnSumary.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSumary.Location = new System.Drawing.Point(756, 3);
            this.btnSumary.Name = "btnSumary";
            this.btnSumary.Size = new System.Drawing.Size(99, 40);
            this.btnSumary.TabIndex = 3;
            this.btnSumary.Text = "Reset";
            this.btnSumary.UseVisualStyleBackColor = false;
            // 
            // btnDatStat
            // 
            this.btnDatStat.BackColor = System.Drawing.Color.DimGray;
            this.btnDatStat.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnDatStat.Location = new System.Drawing.Point(651, 3);
            this.btnDatStat.Name = "btnDatStat";
            this.btnDatStat.Size = new System.Drawing.Size(99, 40);
            this.btnDatStat.TabIndex = 2;
            this.btnDatStat.Text = "Xem kết quả";
            this.btnDatStat.UseVisualStyleBackColor = false;
            // 
            // panel60
            // 
            this.panel60.Controls.Add(this.dtpEndDayStat);
            this.panel60.Controls.Add(this.label45);
            this.panel60.Location = new System.Drawing.Point(328, 3);
            this.panel60.Name = "panel60";
            this.panel60.Size = new System.Drawing.Size(317, 37);
            this.panel60.TabIndex = 1;
            // 
            // dtpEndDayStat
            // 
            this.dtpEndDayStat.Location = new System.Drawing.Point(113, 6);
            this.dtpEndDayStat.Name = "dtpEndDayStat";
            this.dtpEndDayStat.Size = new System.Drawing.Size(200, 24);
            this.dtpEndDayStat.TabIndex = 0;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(7, 9);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(100, 21);
            this.label45.TabIndex = 0;
            this.label45.Text = "Ngày kết thúc";
            // 
            // panel72
            // 
            this.panel72.Controls.Add(this.dtpStartDayStat);
            this.panel72.Controls.Add(this.label43);
            this.panel72.Location = new System.Drawing.Point(5, 3);
            this.panel72.Name = "panel72";
            this.panel72.Size = new System.Drawing.Size(317, 37);
            this.panel72.TabIndex = 0;
            // 
            // dtpStartDayStat
            // 
            this.dtpStartDayStat.Location = new System.Drawing.Point(113, 6);
            this.dtpStartDayStat.Name = "dtpStartDayStat";
            this.dtpStartDayStat.Size = new System.Drawing.Size(200, 24);
            this.dtpStartDayStat.TabIndex = 0;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(10, 9);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(97, 21);
            this.label43.TabIndex = 0;
            this.label43.Text = "Ngày bắt đầu";
            // 
            // panel53
            // 
            this.panel53.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel53.Controls.Add(this.label48);
            this.panel53.Controls.Add(this.chartStatTicket);
            this.panel53.Controls.Add(this.panel54);
            this.panel53.Location = new System.Drawing.Point(464, 63);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(494, 575);
            this.panel53.TabIndex = 1;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(18, 7);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(254, 24);
            this.label48.TabIndex = 17;
            this.label48.Text = "Doanh thu bán vé tháng";
            // 
            // chartStatTicket
            // 
            this.chartStatTicket.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartStatTicket.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatTicket.Legends.Add(legend1);
            this.chartStatTicket.Location = new System.Drawing.Point(3, 167);
            this.chartStatTicket.Name = "chartStatTicket";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chartStatTicket.Series.Add(series1);
            this.chartStatTicket.Size = new System.Drawing.Size(488, 419);
            this.chartStatTicket.TabIndex = 0;
            this.chartStatTicket.Text = "chart1";
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.cbStatChart);
            this.panel54.Controls.Add(this.btnStatChart);
            this.panel54.Controls.Add(this.label35);
            this.panel54.Location = new System.Drawing.Point(3, 96);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(488, 48);
            this.panel54.TabIndex = 0;
            // 
            // cbStatChart
            // 
            this.cbStatChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatChart.FormattingEnabled = true;
            this.cbStatChart.Location = new System.Drawing.Point(253, 10);
            this.cbStatChart.MaxDropDownItems = 5;
            this.cbStatChart.Name = "cbStatChart";
            this.cbStatChart.Size = new System.Drawing.Size(121, 29);
            this.cbStatChart.TabIndex = 0;
            // 
            // btnStatChart
            // 
            this.btnStatChart.BackColor = System.Drawing.Color.DimGray;
            this.btnStatChart.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnStatChart.Location = new System.Drawing.Point(380, 6);
            this.btnStatChart.Name = "btnStatChart";
            this.btnStatChart.Size = new System.Drawing.Size(102, 35);
            this.btnStatChart.TabIndex = 1;
            this.btnStatChart.Text = "THỐNG KÊ";
            this.btnStatChart.UseVisualStyleBackColor = false;
            this.btnStatChart.Click += new System.EventHandler(this.btnStatChart_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 13);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(185, 21);
            this.label35.TabIndex = 0;
            this.label35.Text = "Biểu đồ theo năm (hiện có)";
            // 
            // panel47
            // 
            this.panel47.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel47.Controls.Add(this.label47);
            this.panel47.Controls.Add(this.dgvStat);
            this.panel47.Controls.Add(this.btnExportPdfStat);
            this.panel47.Location = new System.Drawing.Point(3, 63);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(455, 575);
            this.panel47.TabIndex = 0;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(15, 7);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(245, 24);
            this.label47.TabIndex = 16;
            this.label47.Text = "Doanh thu bán vé ngày";
            // 
            // dgvStat
            // 
            this.dgvStat.AllowUserToAddRows = false;
            this.dgvStat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStat.Location = new System.Drawing.Point(3, 44);
            this.dgvStat.Name = "dgvStat";
            this.dgvStat.ReadOnly = true;
            this.dgvStat.Size = new System.Drawing.Size(449, 528);
            this.dgvStat.TabIndex = 0;
            this.dgvStat.TabStop = false;
            // 
            // btnExportPdfStat
            // 
            this.btnExportPdfStat.BackColor = System.Drawing.Color.DimGray;
            this.btnExportPdfStat.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnExportPdfStat.Location = new System.Drawing.Point(323, 3);
            this.btnExportPdfStat.Name = "btnExportPdfStat";
            this.btnExportPdfStat.Size = new System.Drawing.Size(129, 35);
            this.btnExportPdfStat.TabIndex = 15;
            this.btnExportPdfStat.TabStop = false;
            this.btnExportPdfStat.Text = "EXPORT TO PDF";
            this.btnExportPdfStat.UseVisualStyleBackColor = false;
            this.btnExportPdfStat.Click += new System.EventHandler(this.btnExportPdfStat_Click);
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.panel69);
            this.tabPageUser.Controls.Add(this.panel74);
            this.tabPageUser.Controls.Add(this.panel75);
            this.tabPageUser.Location = new System.Drawing.Point(4, 30);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(985, 678);
            this.tabPageUser.TabIndex = 7;
            this.tabPageUser.Text = "Tài khoản";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // panel69
            // 
            this.panel69.Controls.Add(this.panel70);
            this.panel69.Controls.Add(this.btnUserReset);
            this.panel69.Controls.Add(this.btnUserUpdate);
            this.panel69.Controls.Add(this.btnUserDelete);
            this.panel69.Controls.Add(this.btnUserAdd);
            this.panel69.Location = new System.Drawing.Point(4, 398);
            this.panel69.Name = "panel69";
            this.panel69.Size = new System.Drawing.Size(977, 271);
            this.panel69.TabIndex = 0;
            // 
            // panel70
            // 
            this.panel70.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel70.Controls.Add(this.panel76);
            this.panel70.Controls.Add(this.panel71);
            this.panel70.Controls.Add(this.panel73);
            this.panel70.Location = new System.Drawing.Point(3, 3);
            this.panel70.Name = "panel70";
            this.panel70.Size = new System.Drawing.Size(708, 242);
            this.panel70.TabIndex = 0;
            // 
            // panel76
            // 
            this.panel76.Controls.Add(this.tbUserEmail);
            this.panel76.Controls.Add(this.label53);
            this.panel76.Location = new System.Drawing.Point(3, 46);
            this.panel76.Name = "panel76";
            this.panel76.Size = new System.Drawing.Size(378, 37);
            this.panel76.TabIndex = 2;
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Location = new System.Drawing.Point(113, 8);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(223, 24);
            this.tbUserEmail.TabIndex = 0;
            this.tbUserEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserEmail_KeyPress);
            this.tbUserEmail.Leave += new System.EventHandler(this.tbUserEmail_Leave);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(12, 11);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(45, 21);
            this.label53.TabIndex = 0;
            this.label53.Text = "Email";
            // 
            // panel71
            // 
            this.panel71.Controls.Add(this.tbUserUsername);
            this.panel71.Controls.Add(this.label49);
            this.panel71.Location = new System.Drawing.Point(3, 3);
            this.panel71.Name = "panel71";
            this.panel71.Size = new System.Drawing.Size(339, 37);
            this.panel71.TabIndex = 0;
            // 
            // tbUserUsername
            // 
            this.tbUserUsername.Location = new System.Drawing.Point(113, 8);
            this.tbUserUsername.Name = "tbUserUsername";
            this.tbUserUsername.Size = new System.Drawing.Size(223, 24);
            this.tbUserUsername.TabIndex = 0;
            this.tbUserUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserUsername_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(12, 11);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(71, 21);
            this.label49.TabIndex = 0;
            this.label49.Text = "Tài khoản";
            // 
            // panel73
            // 
            this.panel73.Controls.Add(this.tbUserPassword);
            this.panel73.Controls.Add(this.label51);
            this.panel73.Location = new System.Drawing.Point(348, 3);
            this.panel73.Name = "panel73";
            this.panel73.Size = new System.Drawing.Size(339, 37);
            this.panel73.TabIndex = 1;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(113, 8);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(223, 24);
            this.tbUserPassword.TabIndex = 0;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(12, 11);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(69, 21);
            this.label51.TabIndex = 0;
            this.label51.Text = "Mật khẩu";
            // 
            // btnUserReset
            // 
            this.btnUserReset.BackColor = System.Drawing.Color.DimGray;
            this.btnUserReset.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserReset.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUserReset.Location = new System.Drawing.Point(717, 189);
            this.btnUserReset.Name = "btnUserReset";
            this.btnUserReset.Size = new System.Drawing.Size(257, 56);
            this.btnUserReset.TabIndex = 4;
            this.btnUserReset.Text = "Nhập lại";
            this.btnUserReset.UseVisualStyleBackColor = false;
            this.btnUserReset.Click += new System.EventHandler(this.btnUserReset_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnUserUpdate.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserUpdate.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUserUpdate.Location = new System.Drawing.Point(717, 127);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(257, 56);
            this.btnUserUpdate.TabIndex = 3;
            this.btnUserUpdate.Text = "Cập nhật";
            this.btnUserUpdate.UseVisualStyleBackColor = false;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnUserDelete.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDelete.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUserDelete.Location = new System.Drawing.Point(717, 65);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(257, 56);
            this.btnUserDelete.TabIndex = 2;
            this.btnUserDelete.Text = "Xóa";
            this.btnUserDelete.UseVisualStyleBackColor = false;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnUserAdd.Font = new System.Drawing.Font("Lexend Deca SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdd.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnUserAdd.Location = new System.Drawing.Point(717, 3);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(257, 56);
            this.btnUserAdd.TabIndex = 1;
            this.btnUserAdd.Text = "Thêm";
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // panel74
            // 
            this.panel74.Controls.Add(this.dgvUser);
            this.panel74.Location = new System.Drawing.Point(4, 61);
            this.panel74.Name = "panel74";
            this.panel74.Size = new System.Drawing.Size(977, 334);
            this.panel74.TabIndex = 20;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(3, 3);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(971, 328);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.TabStop = false;
            // 
            // panel75
            // 
            this.panel75.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel75.Controls.Add(this.cbUser);
            this.panel75.Controls.Add(this.tbSearchUser);
            this.panel75.Controls.Add(this.label52);
            this.panel75.Location = new System.Drawing.Point(571, 10);
            this.panel75.Name = "panel75";
            this.panel75.Size = new System.Drawing.Size(407, 48);
            this.panel75.TabIndex = 19;
            // 
            // cbUser
            // 
            this.cbUser.BackColor = System.Drawing.SystemColors.Window;
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(283, 10);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(121, 29);
            this.cbUser.TabIndex = 2;
            this.cbUser.TabStop = false;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // tbSearchUser
            // 
            this.tbSearchUser.Location = new System.Drawing.Point(88, 10);
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.Size = new System.Drawing.Size(189, 24);
            this.tbSearchUser.TabIndex = 1;
            this.tbSearchUser.TabStop = false;
            this.tbSearchUser.TextChanged += new System.EventHandler(this.tbSearchUser_TextChanged);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(3, 13);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(67, 21);
            this.label52.TabIndex = 0;
            this.label52.Text = "Tìm kiếm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lexend Deca", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.adminToolStripMenuItem.Text = "Tùy chọn";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(996, 707);
            this.Controls.Add(this.tcDriver);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1012, 746);
            this.MinimumSize = new System.Drawing.Size(1012, 746);
            this.Name = "frmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Chương trình quản lý các chuyến xe buýt";
            this.Load += new System.EventHandler(this.frmTableManager_Load);
            this.tcDriver.ResumeLayout(false);
            this.tabPageDriver.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel46.ResumeLayout(false);
            this.panel46.PerformLayout();
            this.panel36.ResumeLayout(false);
            this.panel36.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExperienceDriver)).EndInit();
            this.panel37.ResumeLayout(false);
            this.panel37.PerformLayout();
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel40.ResumeLayout(false);
            this.panel40.PerformLayout();
            this.panel41.ResumeLayout(false);
            this.panel41.PerformLayout();
            this.panel42.ResumeLayout(false);
            this.panel42.PerformLayout();
            this.panel63.ResumeLayout(false);
            this.panel63.PerformLayout();
            this.panel34.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPageAsDriver.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExperienceAsDriver)).EndInit();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel33.ResumeLayout(false);
            this.panel33.PerformLayout();
            this.panel64.ResumeLayout(false);
            this.panel64.PerformLayout();
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsDriver)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPageBus.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCycle)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChair)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMyear)).EndInit();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel65.ResumeLayout(false);
            this.panel65.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPageBusLine.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndTime)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTime)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).EndInit();
            this.panel66.ResumeLayout(false);
            this.panel66.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusLine)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageBusRide.ResumeLayout(false);
            this.panel45.ResumeLayout(false);
            this.panel48.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            this.panel49.PerformLayout();
            this.panel50.ResumeLayout(false);
            this.panel50.PerformLayout();
            this.panel51.ResumeLayout(false);
            this.panel51.PerformLayout();
            this.panel52.ResumeLayout(false);
            this.panel52.PerformLayout();
            this.panel67.ResumeLayout(false);
            this.panel67.PerformLayout();
            this.panel44.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusRide)).EndInit();
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.tabPageTicket.ResumeLayout(false);
            this.panel55.ResumeLayout(false);
            this.panel56.ResumeLayout(false);
            this.panel57.ResumeLayout(false);
            this.panel57.PerformLayout();
            this.panel59.ResumeLayout(false);
            this.panel59.PerformLayout();
            this.panel68.ResumeLayout(false);
            this.panel68.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicket)).EndInit();
            this.panel61.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.panel62.ResumeLayout(false);
            this.panel62.PerformLayout();
            this.tabPageStat.ResumeLayout(false);
            this.panel58.ResumeLayout(false);
            this.panel60.ResumeLayout(false);
            this.panel60.PerformLayout();
            this.panel72.ResumeLayout(false);
            this.panel72.PerformLayout();
            this.panel53.ResumeLayout(false);
            this.panel53.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatTicket)).EndInit();
            this.panel54.ResumeLayout(false);
            this.panel54.PerformLayout();
            this.panel47.ResumeLayout(false);
            this.panel47.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).EndInit();
            this.tabPageUser.ResumeLayout(false);
            this.panel69.ResumeLayout(false);
            this.panel70.ResumeLayout(false);
            this.panel76.ResumeLayout(false);
            this.panel76.PerformLayout();
            this.panel71.ResumeLayout(false);
            this.panel71.PerformLayout();
            this.panel73.ResumeLayout(false);
            this.panel73.PerformLayout();
            this.panel74.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panel75.ResumeLayout(false);
            this.panel75.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcDriver;
        private System.Windows.Forms.TabPage tabPageDriver;
        private System.Windows.Forms.TabPage tabPageAsDriver;
        private System.Windows.Forms.TabPage tabPageBus;
        private System.Windows.Forms.TabPage tabPageBusLine;
        private System.Windows.Forms.TabPage tabPageBusRide;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.TextBox tbSearchDriver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbAsDriver;
        private System.Windows.Forms.TextBox tbSearchAsDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbBusLine;
        private System.Windows.Forms.TextBox tbSearchBusLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgvBusLine;
        private System.Windows.Forms.Button btnAddBusLine;
        private System.Windows.Forms.Button btnUpdateBusLine;
        private System.Windows.Forms.Button btnDeleteBusLine;
        private System.Windows.Forms.Button btnResetBusLine;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbBus;
        private System.Windows.Forms.TextBox tbSearchBus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnResetBus;
        private System.Windows.Forms.Button btnUpdateBus;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBus;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Button btnResetAsDriver;
        private System.Windows.Forms.Button btnUpdateAsDriver;
        private System.Windows.Forms.Button btnDeleteAsDriver;
        private System.Windows.Forms.Button btnAddAsDriver;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.DataGridView dgvAsDriver;
        private System.Windows.Forms.Panel panel45;
        private System.Windows.Forms.Button btnResetBusRide;
        private System.Windows.Forms.Button btnUpdateBusRide;
        private System.Windows.Forms.Button btnDeleteBusRide;
        private System.Windows.Forms.Button btnAddBusRide;
        private System.Windows.Forms.Panel panel44;
        private System.Windows.Forms.DataGridView dgvBusRide;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.ComboBox cbBusRide;
        private System.Windows.Forms.TextBox tbSearchBusRide;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Button btnResetDriver;
        private System.Windows.Forms.Button btnUpdateDriver;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.Button btnAddMdriver;
        private System.Windows.Forms.Button btnExportPdfDriver;
        private Button btnExportPdfAsDriver;
        private Button btnExportPdfBus;
        private Button btnExportPdfBusLine;
        private Button btnExportPdfBusRide;
        private TabPage tabPageStat;
        private Panel panel53;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatTicket;
        private Panel panel47;
        private DataGridView dgvStat;
        private Panel panel54;
        private Label label35;
        private Button btnStatChart;
        private ComboBox cbStatChart;
        private Button btnExportPdfStat;
        private TabPage tabPageTicket;
        private Button btnExportPdfTicket;
        private Panel panel55;
        private Button btResetTicket;
        private Button btnUpdateTicket;
        private Button btnDeleteTicket;
        private Button btnAddTicket;
        private Panel panel61;
        private DataGridView dgvTicket;
        private Panel panel62;
        private ComboBox cbTicket;
        private TextBox tbSearchTicket;
        private Label label46;
        private Label label47;
        private Label label48;
        private Panel panel35;
        private Panel panel46;
        private ComboBox cbLicense;
        private Label label34;
        private Panel panel36;
        private NumericUpDown nudExperienceDriver;
        private Label label19;
        private Panel panel37;
        private DateTimePicker dtpStartDayDriver;
        private Label label26;
        private Panel panel38;
        private TextBox tbIdCardDriver;
        private Label label27;
        private Panel panel39;
        private TextBox tbPhoneDriver;
        private Label label28;
        private Panel panel40;
        private TextBox tbAddressDriver;
        private Label label29;
        private Panel panel41;
        private ComboBox cbGenderDriver;
        private Label label30;
        private Panel panel42;
        private DateTimePicker dtpDayOfBirthDriver;
        private Label label31;
        private Panel panel63;
        private TextBox tbDriverName;
        private Label label32;
        private Panel panel18;
        private Panel panel19;
        private NumericUpDown nudExperienceAsDriver;
        private Label label12;
        private Panel panel28;
        private DateTimePicker dtpStartDay;
        private Label label1;
        private Panel panel29;
        private TextBox tbIdCardAsDriver;
        private Label label20;
        private Panel panel30;
        private TextBox tbPhoneAsDriver;
        private Label label21;
        private Panel panel31;
        private TextBox tbAddressAsDriver;
        private Label label22;
        private Panel panel32;
        private ComboBox cbGender;
        private Label label23;
        private Panel panel33;
        private DateTimePicker dtpDayOfBirth;
        private Label label24;
        private Panel panel64;
        private TextBox tbAsDriverName;
        private Label label25;
        private Panel panel20;
        private Panel panel21;
        private NumericUpDown nudCycle;
        private Label label14;
        private Panel panel22;
        private NumericUpDown nudChair;
        private Label label15;
        private Panel panel23;
        private NumericUpDown nudMyear;
        private Label label16;
        private Panel panel24;
        private TextBox tbManufacturer;
        private Label label17;
        private Panel panel65;
        private TextBox tbLicensePlate;
        private Label label18;
        private Panel panel10;
        private Panel panel15;
        private TextBox tbBusLineDetail;
        private Label label11;
        private Panel panel14;
        private TextBox tbEndLocation;
        private Label label10;
        private Panel panel11;
        private TextBox tbStartLocation;
        private Label label7;
        private Panel panel13;
        private NumericUpDown nudEndTime;
        private Label label9;
        private Panel panel17;
        private NumericUpDown nudStartTime;
        private Label label13;
        private Panel panel12;
        private NumericUpDown nudFrequency;
        private Label label8;
        private Panel panel66;
        private TextBox tbBusLineName;
        private Label label6;
        private Panel panel48;
        private Panel panel49;
        private DateTimePicker dtpStartTimeBusRide;
        private Label label36;
        private Panel panel50;
        private TextBox tbBusBR;
        private ComboBox cbBusBR;
        private Label label37;
        private Panel panel51;
        private TextBox tbAsDriverBR;
        private ComboBox cbAsDriverBR;
        private Label label38;
        private Panel panel52;
        private TextBox tbDriverBR;
        private ComboBox cbDriverBR;
        private Label label39;
        private Panel panel67;
        private TextBox tbBusLineBR;
        private ComboBox cbBusLineBR;
        private Label label40;
        private Panel panel56;
        private Panel panel57;
        private DateTimePicker dtpTicket;
        private Label label41;
        private Panel panel59;
        private TextBox tbTicketAsDriverName;
        private ComboBox cbTicketAsDriverId;
        private Label label42;
        private Panel panel68;
        private NumericUpDown nudTicket;
        private Label label44;
        private TabPage tabPageUser;
        private Panel panel69;
        private Panel panel70;
        private Panel panel76;
        private TextBox tbUserEmail;
        private Label label53;
        private Panel panel71;
        private TextBox tbUserUsername;
        private Label label49;
        private Panel panel73;
        private TextBox tbUserPassword;
        private Label label51;
        private Button btnUserReset;
        private Button btnUserUpdate;
        private Button btnUserDelete;
        private Button btnUserAdd;
        private Panel panel74;
        private DataGridView dgvUser;
        private Panel panel75;
        private ComboBox cbUser;
        private TextBox tbSearchUser;
        private Label label52;
        private Panel panel58;
        private Button btnSumary;
        private Button btnDatStat;
        private Panel panel60;
        private DateTimePicker dtpEndDayStat;
        private Label label45;
        private Panel panel72;
        private DateTimePicker dtpStartDayStat;
        private Label label43;
        private ErrorProvider errorProvider1;
    }
}