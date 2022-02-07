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
        BUS_BusRide BUS_BusRide = new BUS_BusRide();
        BUS_Bus BUS_Bus = new BUS_Bus();
        public frmTableManager()
        {
            InitializeComponent();
        }

        private void frmTableManager_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string> { "Nam", "Nu", "Khac" };
            cbGender.DataSource = list;
            cbGender.SelectedIndex = 2;

            // form load for As Driver
            dgvAsDriver.DataSource = BUS_AsDriver.GetAsDriver();
            setHeaderAsDriver(dgvAsDriver);

            // form load for Bus Ride
            dgvBusRide.DataSource = BUS_BusRide.GetBusRide();
            setHeaderBusDriver(dgvBusRide);

            //form load for Bus
            dgvBus.DataSource = BUS_Bus.GetBus();
            setHeaderBus(dgvBus);
        }



        //**************************************************************************
        //----------  Driver  ---------------------------------
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

                // Tạo DTO
                DTO_AsDriver ad = new DTO_AsDriver(0, tbAsDriverName.Text, dtpDayOfBirth.Value, DTO_getEnum.GetGenderEnum(cbGender.Text), 
                    tbAddressAsDriver.Text, tbPhoneAsDriver.Text, tbIdCardAsDriver.Text, 
                    dtpStartDay.Value, Decimal.ToInt32(nudExperienceAsDriver.Value)); // Vì ID tự tăng nên để ID số gì cũng dc

                // Thêm
                if (BUS_AsDriver.AddAsDriver(ad))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvAsDriver.DataSource = BUS_AsDriver.GetAsDriver(); // refresh datagridview
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
            if (tbBusLineID.Text != "" && tbAsDriverID.Text != "" && tbDriverID.Text != "" && tbBusID.Text != "" && dtpStartTime.Value != null)
            {

                //create dto
                DTO_BusRide add = new DTO_BusRide(0, tbBusLineID.Text, tbBusID.Text, tbDriverID.Text, tbAsDriverID.Text,dtpStartTime.Value);

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
            tbBusLineID.Text = "";
            tbAsDriverID.Text = "";
            tbDriverID.Text = "";
            tbBusID.Text = "";
            dtpStartTime.Value = DateTime.Now;
        }

        private void btnDeleteBusRide_Click(object sender, EventArgs e)
        {
            if(dgvBusRide.SelectedRows.Count > 0)
            {
                //Lay row hien tai
                DataGridViewRow rows = dgvBusRide.SelectedRows[0];
                int id = Convert.ToInt16(rows.Cells[0].Value.ToString());

                //Xoa
                if(BUS_BusRide.DeleteBusRide(id))
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
            if(dgvBusRide.SelectedRows.Count > 0)
            {
                if (tbBusLineID.Text != "" && tbAsDriverID.Text != "" && tbDriverID.Text != "" && tbBusID.Text != "" && dtpStartTime.Value != null)
                {

                    //create dto
                    DTO_BusRide add = new DTO_BusRide(tbBusLineID.Text, tbBusID.Text, tbDriverID.Text, tbAsDriverID.Text, 0, dtpStartDay.Value);

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
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }


        private static void setHeaderBus(DataGridView dgvBus)
        {
            dgvBus.Columns[0].HeaderText = "Mã xe";
            dgvBus.Columns[1].HeaderText = "Biển kiểm soát";
            dgvBus.Columns[2].HeaderText = "Năm sản xuất";
            dgvBus.Columns[3].HeaderText = "Chu kỳ bảo hành";
            dgvBus.Columns[4].HeaderText = "Hãng sản xuất";
            dgvBus.Columns[5].HeaderText = "Số ghế";
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            if(tbLicensePlate.Text != "" && nudMyear.Value != -1 && nudCycle.Value != -1 && tbManufacturer.Text != "" && nudChair.Value != -1)
            {
                //tao DTO
                DTO_Bus adds = new DTO_Bus(0, tbLicensePlate.Text, tbManufacturer.Text, Decimal.ToInt32(nudMyear.Value), Decimal.ToInt32(nudCycle.Value), 
                     Decimal.ToInt32(nudChair.Value));

                //Them
                if(BUS_Bus.AddBus(adds))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvBus.DataSource = BUS_Bus.GetBus(); //refresh
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
            if(dgvBus.SelectedRows.Count > 0)
            {
                if(tbLicensePlate.Text != "" && nudMyear.Value != -1 && nudCycle.Value != -1 && tbManufacturer.Text != "" && nudChair.Value != -1)
                {
                    //Lay row hien tai
                    DataGridViewRow rows = dgvBus.SelectedRows[0];
                    int IDs = Convert.ToInt16(rows.Cells[0].Value.ToString());

                    //tao DTO
                    DTO_Bus adds = new DTO_Bus(0, tbLicensePlate.Text, tbManufacturer.Text, Decimal.ToInt32(nudMyear.Value), Decimal.ToInt32(nudCycle.Value),
                            Decimal.ToInt32(nudChair.Value));

                    //Sua
                    if (BUS_Bus.UpdateBus(adds))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvBus.DataSource = BUS_Bus.GetBus(); //refresh
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

        private void btnAddDriver_Click(object sender, EventArgs e)
        {

        }

        //**************************************************************************
        //--XXX------------------Driver---------------XXX-------
    }
}
