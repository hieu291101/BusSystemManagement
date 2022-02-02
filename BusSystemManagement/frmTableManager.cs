using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BusSystemManagement;
using DTO_BusSystemManagement;

namespace BusSystemManagement
{
    public partial class frmTableManager : Form
    {
        BUS_AsDriver BUS_AsDriver = new BUS_AsDriver();
        BUS_Driver BUS_Driver = new BUS_Driver();
        BUS_Bus BUS_Bus = new BUS_Bus();
        BUS_BusLine BUS_BusLine = new BUS_BusLine();
        BUS_BusRide BUS_BusRide = new BUS_BusRide();

        public frmTableManager()
        {
            InitializeComponent();
        }

        private void frmTableManager_Load(object sender, EventArgs e)
        {
            // load form for Driver, As_Driver
            List<string> listGender = new List<string> { "Nam", "Nu", "Khac" };
            List<string> listLicense = new List<string> { "B2", "C", "D", "E", "F" };
            cbGender.DataSource = listGender;
            cbGenderDriver.DataSource = listGender;
            cbGender.SelectedIndex = 2;
            cbGenderDriver.SelectedIndex = 2;

            cbLicense.DataSource = listLicense;
            cbLicense.DataSource = listLicense;
            cbLicense.SelectedIndex = 0;
            cbLicense.SelectedIndex = 0;

            // load form for Bus Ride
            cbBusLineBR.DataSource = BUS_BusLine.GetListBusLineId();
            cbAsDriverBR.DataSource = BUS_AsDriver.GetListAsDriverId();
            cbDriverBR.DataSource = BUS_Driver.GetListDriverId();
            cbBusBR.DataSource = BUS_Bus.GetListBusId();

            // form load for As Driver
            dgvAsDriver.DataSource = BUS_AsDriver.GetAsDriver();
            setHeaderAsDriver(dgvAsDriver);

            // form load for Driver
            dgvDriver.DataSource = BUS_Driver.GetDriver();
            setHeaderDriver(dgvDriver);

            //form load for Bus
            dgvBus.DataSource = BUS_Bus.GetBus();
            setHeaderBus(dgvBus);

            // form load for Bus Line
            dgvBusLine.DataSource = BUS_BusLine.GetBusLine();
            setHeaderBusLine(dgvBusLine);
            string[] cbBusLineList = {
                "Tên tuyến xe",
                "Điểm bắt đầu",
                "Điểm kết thúc",
                "Giờ bắt đầu",
                "Giờ kết thúc",
                "Chi tiết trạm"
            };
            cbBusLine.Items.AddRange(cbBusLineList);
            cbBusLine.SelectedIndex = 5;

            // form load for Bus Ride
            dgvBusRide.DataSource = BUS_BusRide.GetBusRide();
            dgvBusRide.Columns[1].Visible = false;
            dgvBusRide.Columns[3].Visible = false;
            dgvBusRide.Columns[5].Visible = false;
            dgvBusRide.Columns[7].Visible = false;
            setHeaderBusDriver(dgvBusRide);
        }

        private void frmTableManager_LoadBusRide()
        {

        }



        //**************************************************************************
        //---------- AsDriver  ---------------------------------
        private static void setHeaderAsDriver(DataGridView dgvAsDriver)
        {
            dgvAsDriver.Columns[0].HeaderText = "Mã phụ xe";
            dgvAsDriver.Columns[1].HeaderText = "Họ và tên";
            dgvAsDriver.Columns[2].HeaderText = "Ngày sinh";
            dgvAsDriver.Columns[3].HeaderText = "Giới tính";
            dgvAsDriver.Columns[4].HeaderText = "Địa chỉ";
            dgvAsDriver.Columns[5].HeaderText = "Số điện thoại";
            dgvAsDriver.Columns[6].HeaderText = "CMND";
            dgvAsDriver.Columns[7].HeaderText = "Ngày bắt đầu";
            dgvAsDriver.Columns[8].HeaderText = "Thâm niên";
        }


        private void btnDeleteAsDriver_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvAsDriver.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvAsDriver.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
              
                // Xóa
                if (BUS_AsDriver.DeleteAsDriver(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvAsDriver.DataSource = BUS_AsDriver.GetAsDriver(); // refresh datagridview
                    cbAsDriverBR.DataSource = BUS_AsDriver.GetListAsDriverId();
                    cbAsDriverBR.Text = BUS_AsDriver.GetListAsDriverId()[0];
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void btnAddAsDriver_Click(object sender, EventArgs e)
        {
            if (tbAsDriverName.Text != "" && dtpDayOfBirth.Value != null && cbGender.Text != "" && tbAddressAsDriver.Text != "" && tbPhoneAsDriver.Text != "" &&
                    tbIdCardAsDriver.Text != "" && dtpStartDay.Value != null && nudExperienceAsDriver.Value != -1)
            {

                // Tạo DTo
                DTO_AsDriver ad = new DTO_AsDriver(0, tbAsDriverName.Text, dtpDayOfBirth.Value, DTO_getEnum.GetGenderEnum(cbGender.Text), tbAddressAsDriver.Text,
                    tbPhoneAsDriver.Text, tbIdCardAsDriver.Text, dtpStartDay.Value, Decimal.ToInt32(nudExperienceAsDriver.Value)); // Vì ID tự tăng nên để ID số gì cũng dc

                // Thêm
                if (BUS_AsDriver.AddAsDriver(ad))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvAsDriver.DataSource = BUS_AsDriver.GetAsDriver(); // refresh datagridview
                    cbAsDriverBR.DataSource = BUS_AsDriver.GetListAsDriverId();
                    cbAsDriverBR.Text = BUS_AsDriver.GetListAsDriverId()[0];
                }
                else
                {
                    MessageBox.Show("Thêm không thành công"); ;
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnUpdateAsDriver_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvAsDriver.SelectedRows.Count > 0)
            {
                if (tbAsDriverName.Text != "" && dtpDayOfBirth.Value != null && cbGender.Text != "" && tbAddressAsDriver.Text != "" && tbPhoneAsDriver.Text != "" &&
                    tbIdCardAsDriver.Text != "" && dtpStartDay.Value != null && nudExperienceAsDriver.Value != -1)
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvAsDriver.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_AsDriver ad = new DTO_AsDriver(ID, tbAsDriverName.Text, dtpDayOfBirth.Value, DTO_getEnum.GetGenderEnum(cbGender.Text), tbAddressAsDriver.Text,
                        tbPhoneAsDriver.Text, tbIdCardAsDriver.Text, dtpStartDay.Value, Decimal.ToInt32(nudExperienceAsDriver.Value)); // Vì ID tự tăng nên để ID số gì cũng dc

                    // Sửa
                    if (BUS_AsDriver.UpdateAsDriver(ad))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvAsDriver.DataSource = BUS_AsDriver.GetAsDriver(); // refresh datagridview
                        cbAsDriverBR.DataSource = BUS_AsDriver.GetListAsDriverId();
                        cbAsDriverBR.Text = BUS_AsDriver.GetListAsDriverId()[0];
                        cbAsDriverBR.Text = BUS_AsDriver.GetListAsDriverId() == null ? BUS_AsDriver.GetListAsDriverId()[0] : "";
                        tbAsDriverBR.Text = BUS_AsDriver.GetListAsDriverId() == null ? BUS_AsDriver.GetAsDriverById(int.Parse(cbAsDriverBR.Text)) : "";
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbBusLineName.Text = "";
            nudFrequency.Value = 0;
            nudStartTime.Value = 0;
            nudEndTime.Value = 0;
            tbStartLocation.Text = "";
            tbEndLocation.Text = "";
            tbBusLineDetail.Text = "";
        }

        private void btnResetAsDriver_Click(object sender, EventArgs e)
        {
            tbAsDriverName.Text = "";
            dtpDayOfBirth.Value = DateTime.Now;
            cbGender.SelectedIndex = cbGender.Items.IndexOf("Khac");
            tbAddressAsDriver.Text = "";
            tbPhoneAsDriver.Text = "";
            tbIdCardAsDriver.Text = "";
            dtpStartDay.Value = DateTime.Now;
            nudExperienceAsDriver.Value = 0;
        }
        //**************************************************************************
        //--XXX------------------AsDriver---------------XXX-------


        //**************************************************************************
        //----------  Driver  ---------------------------------
        private static void setHeaderDriver(DataGridView dgvDriver)
        {
            dgvDriver.Columns[0].HeaderText = "Mã tài xế";
            dgvDriver.Columns[1].HeaderText = "Họ và tên";
            dgvDriver.Columns[2].HeaderText = "Ngày sinh";
            dgvDriver.Columns[3].HeaderText = "Giới tính";
            dgvDriver.Columns[4].HeaderText = "Địa chỉ";
            dgvDriver.Columns[5].HeaderText = "Số điện thoại";
            dgvDriver.Columns[6].HeaderText = "CMND";
            dgvDriver.Columns[7].HeaderText = "Ngày bắt đầu";
            dgvDriver.Columns[8].HeaderText = "Thâm niên";
            dgvDriver.Columns[9].HeaderText = "Bằng lái";
        }


        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvDriver.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvDriver.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Xóa
                if (BUS_Driver.DeleteDriver(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvDriver.DataSource = BUS_Driver.GetDriver(); // refresh datagridview
                    cbDriverBR.DataSource = BUS_Driver.GetListDriverId();
                    cbDriverBR.Text = BUS_Driver.GetListDriverId()[0];
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn tài xế muốn xóa");
            }
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvDriver.SelectedRows.Count > 0)
            {
                if (tbDriverName.Text != "" && dtpDayOfBirthDriver.Value != null && cbGenderDriver.Text != "" && tbAddressDriver.Text != "" && tbPhoneDriver.Text != "" &&
                    tbIdCardDriver.Text != "" && dtpStartDayDriver.Value != null && nudExperienceDriver.Value != -1)
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvDriver.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTo

                    // Tạo DTo
                    DTO_Driver ad = new DTO_Driver(ID, tbDriverName.Text, dtpDayOfBirthDriver.Value, DTO_getEnum.GetGenderEnum(cbGenderDriver.Text), tbAddressDriver.Text,
                        tbPhoneDriver.Text, tbIdCardDriver.Text, dtpStartDayDriver.Value, Decimal.ToInt32(nudExperienceDriver.Value), DTO_getEnum.GetLicenseEnum(cbLicense.Text)); // Vì ID tự tăng nên để ID số gì cũng dc

                    // Sửa
                    if (BUS_Driver.UpdateDriver(ad))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvDriver.DataSource = BUS_Driver.GetDriver(); // refresh datagridview
                        cbDriverBR.DataSource = BUS_Driver.GetListDriverId();
                        cbDriverBR.Text = BUS_Driver.GetListDriverId()[0];
                        cbDriverBR.Text = BUS_Driver.GetListDriverId() == null ? BUS_Driver.GetListDriverId()[0] : "";
                        tbDriverBR.Text = BUS_Driver.GetListDriverId() == null ? BUS_Driver.GetDriverById(int.Parse(cbDriverBR.Text)) : "";
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnResetDriver_Click(object sender, EventArgs e)
        {
            tbDriverName.Text = "";
            dtpDayOfBirthDriver.Value = DateTime.Now;
            cbGenderDriver.SelectedIndex = cbGenderDriver.Items.IndexOf("Khac");
            tbAddressDriver.Text = "";
            tbPhoneDriver.Text = "";
            tbIdCardDriver.Text = "";
            dtpStartDayDriver.Value = DateTime.Now;
            nudExperienceDriver.Value = 0;
            cbLicense.SelectedIndex = cbLicense.Items.IndexOf("B2");
        }

        private void btnAddMdriver_Click(object sender, EventArgs e)
        {
            if (tbDriverName.Text != "" && dtpDayOfBirthDriver.Value != null && cbGenderDriver.Text != "" && tbAddressDriver.Text != "" && tbPhoneDriver.Text != "" &&
                   tbIdCardDriver.Text != "" && dtpStartDayDriver.Value != null && nudExperienceDriver.Value != -1 && cbLicense.Text != "")
            {
                // Tạo DTo
                DTO_Driver ad = new DTO_Driver(0, tbDriverName.Text, dtpDayOfBirthDriver.Value, DTO_getEnum.GetGenderEnum(cbGenderDriver.Text), tbAddressDriver.Text,
                    tbPhoneDriver.Text, tbIdCardDriver.Text, dtpStartDayDriver.Value, Decimal.ToInt32(nudExperienceDriver.Value), DTO_getEnum.GetLicenseEnum(cbLicense.Text)); // Vì ID tự tăng nên để ID số gì cũng dc

                // Thêm
                if (BUS_Driver.AddDriver(ad))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDriver.DataSource = BUS_Driver.GetDriver(); // refresh datagridview
                    cbDriverBR.DataSource = BUS_Driver.GetListDriverId();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công"); ;
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        //**************************************************************************
        //--XXX------------------Driver---------------XXX-------


        //**************************************************************************
        //----------  Bus  ---------------------------------
        private static void setHeaderBus(DataGridView dgvBus)
        {
            dgvBus.Columns[0].HeaderText = "Mã xe";
            dgvBus.Columns[1].HeaderText = "Biển kiểm soát";
            dgvBus.Columns[3].HeaderText = "Năm sản xuất";
            dgvBus.Columns[5].HeaderText = "Chu kỳ bảo hành";
            dgvBus.Columns[2].HeaderText = "Hãng sản xuất";
            dgvBus.Columns[4].HeaderText = "Số ghế";
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            if (tbLicensePlate.Text != "" && nudMyear.Value != -1 && nudCycle.Value != -1 && tbManufacturer.Text != "" && nudChair.Value != -1)
            {
                //tao DTO
                DTO_Bus adds = new DTO_Bus(0, tbLicensePlate.Text, tbManufacturer.Text, Decimal.ToInt32(nudMyear.Value),
                     Decimal.ToInt32(nudChair.Value), Decimal.ToInt32(nudCycle.Value));

                //Them
                if (BUS_Bus.AddBus(adds))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvBus.DataSource = BUS_Bus.GetBus(); //refresh
                    cbBusBR.DataSource = BUS_Bus.GetListBusId();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if (dgvBus.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow rows = dgvBus.SelectedRows[0];
                int IDs = Convert.ToInt16(rows.Cells[0].Value.ToString());

                // Xóa
                if (BUS_Bus.DeleteBus(IDs))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvBus.DataSource = BUS_Bus.GetBus(); // refresh 
                    cbBusBR.DataSource = BUS_Bus.GetListBusId();
                    cbBusBR.Text = BUS_Bus.GetListBusId() == null ? BUS_Bus.GetListBusId()[0] : "";
                    tbBusBR.Text = BUS_Bus.GetListBusId() == null ? BUS_Bus.GetBusById(int.Parse(cbBusBR.Text)) : "" ;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn xe muốn xoá");
            }
        }

        private void btnUpdateBus_Click(object sender, EventArgs e)
        {
            if (dgvBus.SelectedRows.Count > 0)
            {
                if (tbLicensePlate.Text != "" && nudMyear.Value != -1 && nudCycle.Value != -1 && tbManufacturer.Text != "" && nudChair.Value != -1)
                {
                    //Lay row hien tai
                    DataGridViewRow rows = dgvBus.SelectedRows[0];
                    int IDs = Convert.ToInt16(rows.Cells[0].Value.ToString());

                    //tao DTO
                    DTO_Bus adds = new DTO_Bus(IDs, tbLicensePlate.Text, tbManufacturer.Text, Decimal.ToInt32(nudMyear.Value),
                                                Decimal.ToInt32(nudChair.Value), Decimal.ToInt32(nudCycle.Value));

                    //Sua
                    if (BUS_Bus.UpdateBus(adds))
                    {
                        MessageBox.Show("Sửa đổi thành công");
                        dgvBus.DataSource = BUS_Bus.GetBus(); //refresh
                        cbBusBR.DataSource = BUS_Bus.GetListBusId();
                        cbBusBR.Text = BUS_Bus.GetListBusId()[0];
                    }
                    else
                    {
                        MessageBox.Show("Sửa đổi không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Yêu cầu nhập đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thông tin xe muốn thay đổi");
            }
        }

        private void btnResetBus_Click(object sender, EventArgs e)
        {
            tbLicensePlate.Text = "";
            tbManufacturer.Text = "";
            nudChair.Value = 0;
            nudCycle.Value = 0;
            nudMyear.Value = 0;
        }

        //**************************************************************************
        //--XXX------------------Bus---------------XXX-------

        //**************************************************************************
        //----------  BusLine  ---------------------------------
        private static void setHeaderBusLine(DataGridView dtvBusLine)
        {
            dtvBusLine.Columns[0].HeaderText = "Mã chuyến xe";
            dtvBusLine.Columns[1].HeaderText = "Tên chuyến xe";
            dtvBusLine.Columns[2].HeaderText = "Giờ bắt đầu (giờ)";
            dtvBusLine.Columns[3].HeaderText = "Giờ kết thúc (giờ)";
            dtvBusLine.Columns[4].HeaderText = "Điểm bắt đầu";
            dtvBusLine.Columns[5].HeaderText = "Điểm kết thúc";
            dtvBusLine.Columns[6].HeaderText = "Chi tiết trạm dừng";
            dtvBusLine.Columns[7].HeaderText = "Tần suất (phút)";
        }

        private void btnAddBusLine_Click(object sender, EventArgs e)
        {
            if (tbBusLineName.Text != "" && nudFrequency.Value > 1 &&
                nudStartTime.Value > 1 && nudEndTime.Value > 1 &&
                tbStartLocation.Text != "" && tbEndLocation.Text != "" &&
                tbBusLineDetail.Text != "")
            {

                // Tạo DTO
                DTO_BusLine bl = new DTO_BusLine(0, tbBusLineName.Text, Decimal.ToInt32(nudStartTime.Value),
                    Decimal.ToInt32(nudEndTime.Value), tbStartLocation.Text, tbEndLocation.Text, tbBusLineDetail.Text,
                    Decimal.ToInt32(nudFrequency.Value));

                // Thêm
                if (BUS_BusLine.AddBusLine(bl))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    dgvBusLine.DataSource = BUS_BusLine.GetBusLine();
                    cbBusLineBR.DataSource = BUS_BusLine.GetListBusLineId();
                    cbBusLineBR.Text = BUS_BusLine.GetListBusLineId()[0];
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK); ;
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập thông tin đầy đủ", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteBusLine_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvBusLine.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvBusLine.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Xóa
                if (BUS_BusLine.DeleteBusLine(ID))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgvBusLine.DataSource = BUS_BusLine.GetBusLine();
                    cbBusLineBR.DataSource = BUS_BusLine.GetListBusLineId();
                    cbBusLineBR.Text = BUS_BusLine.GetListBusLineId()[0];
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnUpdateBusLine_Click(object sender, EventArgs e)
        {
            if (dgvBusLine.SelectedRows.Count > 0)
            {
                if (tbBusLineName.Text != "" && nudFrequency.Value > 1 &&
                nudStartTime.Value > 1 && nudEndTime.Value > 1 &&
                tbStartLocation.Text != "" && tbEndLocation.Text != "" &&
                tbBusLineDetail.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvBusLine.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTO
                    DTO_BusLine bl = new DTO_BusLine(ID, tbBusLineName.Text, Decimal.ToInt32(nudStartTime.Value),
                        Decimal.ToInt32(nudEndTime.Value), tbStartLocation.Text, tbEndLocation.Text, tbBusLineDetail.Text,
                        Decimal.ToInt32(nudFrequency.Value));

                    // Sửa
                    if (BUS_BusLine.UpdateBusLine(bl))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        dgvBusLine.DataSource = BUS_BusLine.GetBusLine();
                        cbBusLineBR.DataSource = BUS_BusLine.GetListBusLineId();
                        cbBusLineBR.Text = BUS_BusLine.GetListBusLineId()[0];
                        cbBusLineBR.Text = BUS_BusLine.GetListBusLineId() == null ? BUS_BusLine.GetListBusLineId()[0] : "";
                        tbBusLineBR.Text = BUS_BusLine.GetListBusLineId() == null ? BUS_BusLine.GetBusLineById(int.Parse(cbBusLineBR.Text)) : "";
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnResetBusLine_Click(object sender, EventArgs e)
        {
            tbBusLineName.Text = "";
            nudFrequency.Value = 0;
            nudStartTime.Value = 0;
            nudEndTime.Value = 0;
            tbStartLocation.Text = "";
            tbEndLocation.Text = "";
            tbBusLineDetail.Text = "";
        }

        private void tbSearchBusLine_TextChanged(object sender, EventArgs e)
        {
            string kw = tbSearchBusLine.Text;
            if (kw == "")
                dgvBusLine.DataSource = BUS_BusLine.GetBusLine();
            else
            {
                switch (cbBusLine.SelectedItem.ToString())
                {
                    case "Tên tuyến xe":
                        dgvBusLine.DataSource = BUS_BusLine.FindBusLineByBusLineName(kw);
                        break;
                    case "Điểm bắt đầu":
                        dgvBusLine.DataSource = BUS_BusLine.FindBusLineByStartLocation(kw);
                        break;
                    case "Điểm kết thúc":
                        dgvBusLine.DataSource = BUS_BusLine.FindBusLineByEndLocation(kw);
                        break;
                    case "Giờ bắt đầu":
                        dgvBusLine.DataSource = BUS_BusLine.FindBusLineByStartTime(kw);
                        break;
                    case "Giờ kết thúc":
                        dgvBusLine.DataSource = BUS_BusLine.FindBusLineByEndTime(kw);
                        break;
                    case "Chi tiết trạm":
                        dgvBusLine.DataSource = BUS_BusLine.FindBusLineByBusStopDetail(kw);
                        break;
                    default:
                        dgvBusLine.DataSource = BUS_BusLine.GetBusLine();
                        break;
                }
            }
        }

        private void cbBusLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchBusLine.Text = "";
            dgvBusLine.DataSource = BUS_BusLine.GetBusLine();
        }

        //--XXX------------------BusLine---------------XXX-------
        //**************************************************************************


        //**************************************************************************
        //----------  Bus Ride  ---------------------------------
        private static void setHeaderBusDriver(DataGridView dgvBusRide)
        {
            dgvBusRide.Columns[0].HeaderText = "Mã chuyến xe";
            dgvBusRide.Columns[2].HeaderText = "Tên tuyến xe";
            dgvBusRide.Columns[4].HeaderText = "Tên tài xế";
            dgvBusRide.Columns[6].HeaderText = "Tên phụ xe";
            dgvBusRide.Columns[8].HeaderText = "Biển kiểm soát";
            dgvBusRide.Columns[9].HeaderText = "Thời điểm";
        }
        private void btnAddBusRide_Click(object sender, EventArgs e)
        {
            if (cbBusLineBR.Text != "" && cbAsDriverBR.Text != "" && cbDriverBR.Text != "" && cbBusBR.Text != "" && dtpStartTimeBusRide.Value != null)
            {

                //create dto
                DTO_BusRide add = new DTO_BusRide(int.Parse(cbBusLineBR.Text), int.Parse(cbBusBR.Text), int.Parse(cbDriverBR.Text), int.Parse(cbAsDriverBR.Text), 0, dtpStartTimeBusRide.Value);

                //add
                if (BUS_BusRide.AddBusRide(add))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvBusRide.DataSource = BUS_BusRide.GetBusRide(); //refresh
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnResetBusRide_Click(object sender, EventArgs e)
        {
            cbBusLineBR.SelectedIndex = 0;
            cbAsDriverBR.SelectedIndex = 0;
            cbDriverBR.SelectedIndex = 0;
            cbBusBR.SelectedIndex = 0;
            dtpStartTimeBusRide.Value = DateTime.Now;
        }

        private void btnDeleteBusRide_Click(object sender, EventArgs e)
        {
            if(dgvBusRide.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
                

            if (dgvBusRide.SelectedRows.Count > 0)
            {
                //Lay row hien tai
                DataGridViewRow rows = dgvBusRide.SelectedRows[0];
                int id = Convert.ToInt16(rows.Cells[0].Value.ToString());

                //Xoa
                if (BUS_BusRide.DeleteBusRide(id))
                {
                    MessageBox.Show("Xoá thành công");
                    dgvBusRide.DataSource = BUS_BusRide.GetBusRide(); //refresh
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn chuyến xe muốn xoá");
            }
        }

        private void btnUpdateBusRide_Click(object sender, EventArgs e)
        {
            if (dgvBusRide.SelectedRows.Count > 0)
            {
                if (cbBusLineBR.Text != "" && cbAsDriverBR.Text != "" && cbDriverBR.Text != "" && cbBusBR.Text != "" && dtpStartTimeBusRide.Value != null)
                {
                    DataGridViewRow row = dgvBusRide.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                   
                    //create dto
                    DTO_BusRide br = new DTO_BusRide(int.Parse(cbBusLineBR.Text), int.Parse(cbBusBR.Text), int.Parse(cbDriverBR.Text), int.Parse(cbAsDriverBR.Text), ID, dtpStartTimeBusRide.Value);

                    //update
                    if (BUS_BusRide.UpdateBusRide(br))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvBusRide.DataSource = BUS_BusRide.GetBusRide(); //refresh
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn chuyến xe muốn sửa");
            }
        }

        private void cbBusLineBR_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBusLineBR.Text = BUS_BusLine.GetBusLineById(int.Parse(cbBusLineBR.Text));
        }

        private void cbDriverBR_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDriverBR.Text = BUS_Driver.GetDriverById(int.Parse(cbDriverBR.Text));
        }

        private void cbAsDriverBR_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbAsDriverBR.Text = BUS_AsDriver.GetAsDriverById(int.Parse(cbAsDriverBR.Text));
        }

        private void cbBusBR_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBusBR.Text = BUS_Bus.GetBusById(int.Parse(cbBusBR.Text));
        }

        //**************************************************************************
        //--XXX------------------Bus Ride---------------XXX-------



    }
}
