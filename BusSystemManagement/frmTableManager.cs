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
        BUS_BusLine BUS_BusLine = new BUS_BusLine();
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
        }

        #region Driver
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
            if (tbAsDriverName.Text != "" && 
                dtpDayOfBirth.Value != null && 
                cbGender.Text != "" && 
                tbAddressAsDriver.Text != "" && 
                tbPhoneAsDriver.Text != "" &&
                tbIdCardAsDriver.Text != "" && 
                dtpStartDay.Value != null &&
                nudExperienceAsDriver.Value != -1)
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
        #endregion


        #region Bus Line
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

        private void tbSearchBusLine_TextChanged(object sender, EventArgs e)
        {
            string kw = tbSearchBusLine.Text;
            if ( kw == "")
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

        #endregion


    }
}
