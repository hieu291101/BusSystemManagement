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
    }
}
