using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        BUS_BusLine BUS_BusLine = new BUS_BusLine();
        BUS_BusRide BUS_BusRide = new BUS_BusRide();

        public frmTableManager()
        {
            InitializeComponent();
        }

        private void frmTableManager_Load(object sender, EventArgs e)
        {
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

            // form load for As Driver
            dgvAsDriver.DataSource = BUS_AsDriver.GetAsDriver();
            setHeaderAsDriver(dgvAsDriver);

            // form load for Driver
            dgvDriver.DataSource = BUS_Driver.GetDriver();
            setHeaderDriver(dgvDriver);

            // form load for Bus Line
            dgvBusLine.DataSource = BUS_BusLine.GetBusLine();
            setHeaderBusLine(dgvBusLine);

            // form load for Bus Ride
            dgvBusRide.DataSource = BUS_BusRide.GetBusRide();
            dgvBusRide.Columns[0].Visible = false;
            setHeaderBusDriver(dgvBusRide);
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


        //--XXX------------------BusLine---------------XXX-------
        //**************************************************************************


        //**************************************************************************
        //----------  Bus Ride  ---------------------------------
        private static void setHeaderBusDriver(DataGridView dgvBusRide)
        {
            dgvBusRide.Columns[0].HeaderText = "Mã chuyến xe";
            dgvBusRide.Columns[1].HeaderText = "Mã tuyến xe";
            dgvBusRide.Columns[2].HeaderText = "Mã phụ xe";
            dgvBusRide.Columns[3].HeaderText = "Mã tài xế";
            dgvBusRide.Columns[4].HeaderText = "Mã xe";
            dgvBusRide.Columns[5].HeaderText = "Thời điểm";
        }
        private void btnAddBusRide_Click(object sender, EventArgs e)
        {
            if (nudBusLineID.Value != -1 && nudAsDriverID.Value != -1 && nudDriverID.Value != -1 && nudBusID.Value != -1 && dtpStartTimeBusRide.Value != null)
            {

                //create dto
                DTO_BusRide add = new DTO_BusRide(Decimal.ToInt32(nudBusLineID.Value), Decimal.ToInt32(nudAsDriverID.Value), Decimal.ToInt32(nudDriverID.Value), Decimal.ToInt32(nudBusID.Value), 0, dtpStartTimeBusRide.Value);

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
            nudBusLineID.Value = 0;
            nudAsDriverID.Value = 0;
            nudDriverID.Value = 0;
            nudBusID.Value = 0;
            dtpStartTimeBusRide.Value = DateTime.Now;
        }

        private void btnDeleteBusRide_Click(object sender, EventArgs e)
        {
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
                if (nudBusLineID.Value != -1 && nudAsDriverID.Value != -1 && nudDriverID.Value != -1 && nudBusID.Value != -1 && dtpStartTimeBusRide.Value != null)
                {
                    DataGridViewRow row = dgvBusRide.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[4].Value.ToString());
                    //create dto
                    DTO_BusRide br = new DTO_BusRide(Decimal.ToInt32(nudBusLineID.Value), Decimal.ToInt32(nudAsDriverID.Value), Decimal.ToInt32(nudDriverID.Value), Decimal.ToInt32(nudBusID.Value), ID, dtpStartTimeBusRide.Value);

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
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        //**************************************************************************
        //--XXX------------------Bus Ride---------------XXX-------
    }
}
