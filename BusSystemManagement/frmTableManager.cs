using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS_BusSystemManagement;
using DTO_BusSystemManagement;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BusSystemManagement
{
    public partial class frmTableManager : Form
    {
        BUS_AsDriver BUS_AsDriver = new BUS_AsDriver();
        BUS_Driver BUS_Driver = new BUS_Driver();
        BUS_Bus BUS_Bus = new BUS_Bus();
        BUS_BusLine BUS_BusLine = new BUS_BusLine();
        BUS_BusRide BUS_BusRide = new BUS_BusRide();
        BUS_Ticket BUS_Ticket = new BUS_Ticket();
        private static DTO_User account;

        public frmTableManager()
        {
            InitializeComponent();
        }

        public frmTableManager(DTO_User user) : this()
        {
            account = user;
            adminToolStripMenuItem.Text = account.USER_USERNAME;
        }

        //Nhấn chọn đăng xuất => quay về giao diện đăng nhập
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Nhấn chọn thông tin cá nhân => giao diện chỉnh sửa người dùng
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser(account);
            this.Hide();
            frmUser.ShowDialog();
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
            string[] cbAsDriverList = {
                "Họ và tên",
                "Giới tính",
                "Địa chỉ",
                "Số điện thoại",
                "CMND",
                "Thâm niên"
            };
            cbAsDriver.Items.AddRange(cbAsDriverList);
            cbAsDriver.SelectedIndex = 0;

            // form load for Driver
            dgvDriver.DataSource = BUS_Driver.GetDriver();
            setHeaderDriver(dgvDriver);
            string[] cbDriverList = {
                "Họ và tên",
                "Giới tính",
                "Địa chỉ",
                "Số điện thoại",
                "CMND",
                "Thâm niên",
                "Bằng lái"
            };
            cbDriver.Items.AddRange(cbDriverList);
            cbDriver.SelectedIndex = 0;

            //form load for Bus
            dgvBus.DataSource = BUS_Bus.GetBus();
            setHeaderBus(dgvBus);
            string[] cbBusList = {
                "Biển kiểm soát",
                "Hãng sản xuất",
                "Năm sản xuất",
                "Số ghế",
                "Chu kỳ bảo hành"
            };
            cbBus.Items.AddRange(cbBusList);
            cbBus.SelectedIndex = 1;

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
            string[] cbBusRideList = {
                "Tên tuyến xe",
                "Tên tài xế",
                "Tên phụ xe",
                "Biển kiểm soát"
            };
            cbBusRide.Items.AddRange(cbBusRideList);
            cbBusRide.SelectedIndex = 0;

            // form load for Ticket
            dgvTicket.DataSource = BUS_Ticket.GetTicket();
            setHeaderTicket(dgvTicket);
            cbTicketAsDriverId.DataSource = BUS_AsDriver.GetListAsDriverId();

            // form load for Stat
            dgvStat.DataSource = BUS_Ticket.GetTicketStat();
            setHeaderStat(dgvStat);
            cbStatChart.DataSource = BUS_Ticket.GetListYear();

            // draw stat
            fillChart(DateTime.Now.Year);
        }

        private void fillChart(int year)
        {
            //AddXY value in chart1 in series named as Salary  
            List<DTO_Stat> lst = new List<DTO_Stat>();
            lst = BUS_Ticket.GetTicketStatForMonth(year);
            chartStatTicket.Titles.Clear();

            for(int i = 1; i <= lst.Count; i++)
            {
                chartStatTicket.Series["Revenue"].Points.AddXY(lst[i - 1].STAT_DATE.Month, lst[i - 1].STAT_REVENUE);
            }

            chartStatTicket.Titles.Add("Biểu đồ doanh thu trong năm " + year);
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

        private void tbSearchAsDriver_TextChanged(object sender, EventArgs e)
        {
            string kw = tbSearchAsDriver.Text;
            if (kw == "")
                dgvAsDriver.DataSource = BUS_AsDriver.GetAsDriver();
            else
            {
                switch (cbAsDriver.SelectedItem.ToString())
                {
                    case "Họ và tên":
                        dgvAsDriver.DataSource = BUS_AsDriver.FindAsDriverByName(kw);
                        break;
                    case "Giới tính":
                        dgvAsDriver.DataSource = BUS_AsDriver.FindAsDriverByGender(kw);
                        break;
                    case "Địa chỉ":
                        dgvAsDriver.DataSource = BUS_AsDriver.FindAsDriverByAddress(kw);
                        break;
                    case "Số điện thoại":
                        dgvAsDriver.DataSource = BUS_AsDriver.FindAsDriverByPhoneNumber(kw);
                        break;
                    case "CMND":
                        dgvAsDriver.DataSource = BUS_AsDriver.FindAsDriverByIdCard(kw);
                        break;
                    case "Thâm niên":
                        dgvAsDriver.DataSource = BUS_AsDriver.FindAsDriverByExperienceYear(kw);
                        break;
                    default:
                        dgvAsDriver.DataSource = BUS_AsDriver.GetAsDriver();
                        break;
                }
            }
        }

        private void cbAsDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchAsDriver.Text = "";
            dgvAsDriver.DataSource = BUS_AsDriver.GetAsDriver();
        }

        private void btnExportPdfAsDriver_Click(object sender, EventArgs e)
        {
            ExportToPdf(dgvAsDriver, "BANG DU LIEU PHU XE", DateTime.Now.Date.ToString("MM/dd/yyyy"));
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
                    DTO_AsDriver ad = new DTO_AsDriver(ID, tbDriverName.Text, dtpDayOfBirthDriver.Value, DTO_getEnum.GetGenderEnum(cbGenderDriver.Text), tbAddressDriver.Text,
                        tbPhoneDriver.Text, tbIdCardDriver.Text, dtpStartDayDriver.Value, Decimal.ToInt32(nudExperienceDriver.Value)); // Vì ID tự tăng nên để ID số gì cũng dc
                    DTO_Driver d = new DTO_Driver(ID, DTO_getEnum.GetLicenseEnum(cbLicense.Text));
                    // Sửa
                    if (BUS_Driver.UpdateDriver(ad, d))
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
                DTO_AsDriver ad = new DTO_AsDriver(0, tbDriverName.Text, dtpDayOfBirthDriver.Value, DTO_getEnum.GetGenderEnum(cbGenderDriver.Text), tbAddressDriver.Text,
                        tbPhoneDriver.Text, tbIdCardDriver.Text, dtpStartDayDriver.Value, Decimal.ToInt32(nudExperienceDriver.Value)); // Vì ID tự tăng nên để ID số gì cũng dc
                DTO_Driver d = new DTO_Driver(0, DTO_getEnum.GetLicenseEnum(cbLicense.Text));

                // Thêm
                if (BUS_Driver.AddDriver(ad, d))
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

        private void tbSearchDriver_TextChanged(object sender, EventArgs e)
        {
            string kw = tbSearchDriver.Text;
            if (kw == "")
                dgvDriver.DataSource = BUS_Driver.GetDriver();
            else
            {
                switch (cbDriver.SelectedItem.ToString())
                {
                    case "Họ và tên":
                        dgvDriver.DataSource = BUS_Driver.FindDriverByName(kw);
                        break;
                    case "Giới tính":
                        dgvDriver.DataSource = BUS_Driver.FindDriverByGender(kw);
                        break;
                    case "Địa chỉ":
                        dgvDriver.DataSource = BUS_Driver.FindDriverByAddress(kw);
                        break;
                    case "Số điện thoại":
                        dgvDriver.DataSource = BUS_Driver.FindDriverByPhoneNumber(kw);
                        break;
                    case "CMND":
                        dgvDriver.DataSource = BUS_Driver.FindDriverByIdCard(kw);
                        break;
                    case "Thâm niên":
                        dgvDriver.DataSource = BUS_Driver.FindDriverByExperienceYear(kw);
                        break;
                    case "Bằng lái":
                        dgvDriver.DataSource = BUS_Driver.FindDriverByDriverLicense(kw);
                        break;
                    default:
                        dgvDriver.DataSource = BUS_Driver.GetDriver();
                        break;
                }
            }
        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchDriver.Text = "";
            dgvDriver.DataSource = BUS_Driver.GetDriver();
        }

        private void btnExportPdfDriver_Click(object sender, EventArgs e)
        {
            ExportToPdf(dgvDriver, "BANG DU LIEU TAI XE", DateTime.Now.Date.ToString("MM/dd/yyyy"));
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

        private void tbSearchBus_TextChanged(object sender, EventArgs e)
        {
            string kw = tbSearchBus.Text;
            if (kw == "")
                dgvBus.DataSource = BUS_Bus.GetBus();
            else
            {
                switch (cbBus.SelectedItem.ToString())
                {
                    case "Biển kiểm soát":
                        dgvBus.DataSource = BUS_Bus.FindBusByLicensePlate(kw);
                        break;
                    case "Hãng sản xuất":
                        dgvBus.DataSource = BUS_Bus.FindBusByManufacturer(kw);
                        break;
                    case "Năm sản xuất":
                        dgvBus.DataSource = BUS_Bus.FindBusByYearOfManufacture(kw);
                        break;
                    case "Số ghế":
                        dgvBus.DataSource = BUS_Bus.FindBusBySeats(kw);
                        break;
                    case "Chu kỳ bảo hành":
                        dgvBus.DataSource = BUS_Bus.FindBusByCurePeriod(kw);
                        break;
                    default:
                        dgvBus.DataSource = BUS_Bus.GetBus();
                        break;
                }
            }
        }

        private void cbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchBus.Text = "";
            dgvBus.DataSource = BUS_Bus.GetBus();
        }

        private void btnExportPdfBus_Click(object sender, EventArgs e)
        {
            ExportToPdf(dgvBus, "BANG DU LIEU XE BUYT", DateTime.Now.Date.ToString("MM/dd/yyyy"));
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

        private void btnExportPdfBusLine_Click(object sender, EventArgs e)
        {
            ExportToPdf(dgvBusLine, "BANG DU LIEU TUYEN XE", DateTime.Now.Date.ToString("MM/dd/yyyy"));
        }

        //--XXX------------------BusLine---------------XXX-------
        //**************************************************************************


        //**************************************************************************
        //----------  Bus Ride  ---------------------------------
        private static void setHeaderBusDriver(DataGridView dgvBusRide)
        {
            dgvBusRide.Columns[0].HeaderText = "Mã chuyến xe";
            dgvBusRide.Columns[2].HeaderText = "Tên tuyến xe";
            dgvBusRide.Columns[4].HeaderText = "Họ và tên";
            dgvBusRide.Columns[6].HeaderText = "Biển kiểm soát";
            dgvBusRide.Columns[7].HeaderText = "Thời điểm";
            dgvBusRide.Columns[8].HeaderText = "Loại";
        }
        private void btnAddBusRide_Click(object sender, EventArgs e)
        {
            if (cbBusLineBR.Text != "" && cbAsDriverBR.Text != "" && cbDriverBR.Text != "" && cbBusBR.Text != "" && dtpStartTimeBusRide.Value != null)
            {

                //create dto
                //DTO_BusRide add = new DTO_BusRide(int.Parse(cbBusLineBR.Text), int.Parse(cbBusBR.Text), int.Parse(cbDriverBR.Text), int.Parse(cbAsDriverBR.Text), 0, dtpStartTimeBusRide.Value);

                //add
                /*
                if (BUS_BusRide.AddBusRide(add))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvBusRide.DataSource = BUS_BusRide.GetBusRide(); //refresh
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
                */
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
                /*
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
                */
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

        private void tbSearchBusRide_TextChanged(object sender, EventArgs e)
        {
            string kw = tbSearchBusRide.Text;
            if (kw == "")
                dgvBusRide.DataSource = BUS_BusRide.GetBusRide();
            else
            {
                switch (cbBusRide.SelectedItem.ToString())
                {
                    case "Tên tuyến xe":
                        dgvBusRide.DataSource = BUS_BusRide.FindBusRideByBusLineName(kw);
                        break;
                    case "Tên tài xế":
                        dgvBusRide.DataSource = BUS_BusRide.FindBusRideByDriverName(kw);
                        break;
                    case "Tên Phụ xe":
                        dgvBusRide.DataSource = BUS_BusRide.FindBusRideByAsDriverName(kw);
                        break;
                    case "Biển kiểm soát":
                        dgvBusRide.DataSource = BUS_BusRide.FindBusRideByLicensePlate(kw);
                        break;
                    default:
                        dgvBusRide.DataSource = BUS_BusRide.GetBusRide();
                        break;
                }
            }
        }

        private void cbBusRide_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchBusRide.Text = "";
            dgvBusRide.DataSource = BUS_BusRide.GetBusRide();
        }

        private void btnExportPdfBusRide_Click(object sender, EventArgs e)
        {
            ExportToPdf(dgvBusRide, "BANG DU LIEU CHUYEN XE", DateTime.Now.Date.ToString("MM/dd/yyyy"));
        }

        //**************************************************************************
        //--XXX------------------Bus Ride---------------XXX-------

        //**************************************************************************
        //----------  Ticket  ---------------------------------
        private static void setHeaderTicket(DataGridView dgvTicket)
        {
            dgvTicket.Columns[0].HeaderText = "Mã vé";
            dgvTicket.Columns[1].HeaderText = "Ngày";
            dgvTicket.Columns[2].HeaderText = "Giá vé";
            dgvTicket.Columns[3].HeaderText = "Mã phụ xe";
            dgvTicket.Columns[4].HeaderText = "Tên phụ xe";
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            if (dtpTicket.Value != null && nudTicket.Value != -1 && cbTicketAsDriverId.Text != "")
            {

                //create dto
                DTO_Ticket add = new DTO_Ticket(0, dtpTicket.Value, nudTicket.Value, int.Parse(cbTicketAsDriverId.Text));

                //add
                if (BUS_Ticket.AddTicket(add))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvTicket.DataSource = BUS_Ticket.GetTicket(); //refresh
                    dgvStat.DataSource = BUS_Ticket.GetTicketStat();
                    cbStatChart.DataSource = BUS_Ticket.GetListYear();
                    fillChart(DateTime.Now.Year);
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

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (dgvTicket.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }


            if (dgvTicket.SelectedRows.Count > 0)
            {
                //Lay row hien tai
                DataGridViewRow rows = dgvTicket.SelectedRows[0];
                int id = Convert.ToInt16(rows.Cells[0].Value.ToString());

                //Xoa
                if (BUS_Ticket.DeleteTicket(id))
                {
                    MessageBox.Show("Xoá thành công");
                    dgvTicket.DataSource = BUS_Ticket.GetTicket(); //refresh
                    dgvStat.DataSource = BUS_Ticket.GetTicketStat();
                    cbStatChart.DataSource = BUS_Ticket.GetListYear();
                    fillChart(DateTime.Now.Year);
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

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (dgvTicket.SelectedRows.Count > 0)
            {
                if (dtpTicket.Value != null && nudTicket.Value != -1 && cbTicketAsDriverId.Text != "")
                {
                    DataGridViewRow row = dgvTicket.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //create dto
                    DTO_Ticket t = new DTO_Ticket(ID, dtpTicket.Value, nudTicket.Value, int.Parse(cbTicketAsDriverId.Text));

                    //update
                    if (BUS_Ticket.UpdateTicket(t))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvTicket.DataSource = BUS_Ticket.GetTicket(); //refresh
                        dgvStat.DataSource = BUS_Ticket.GetTicketStat();
                        cbStatChart.DataSource = BUS_Ticket.GetListYear();
                        fillChart(DateTime.Now.Year);
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

        private void btResetTicket_Click(object sender, EventArgs e)
        {
            dtpTicket.Value = DateTime.Now;
            nudTicket.Value = 0;
            cbTicketAsDriverId.SelectedIndex = 0;
        }

        private void cbTicketAsDriverId_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTicketAsDriverName.Text = BUS_AsDriver.GetAsDriverById(int.Parse(cbTicketAsDriverId.Text));
        }

        private void btnExportPdfTicket_Click(object sender, EventArgs e)
        {
            ExportToPdf(dgvStat, "BANG DU LIEU VE XE", DateTime.Now.Date.ToString("MM/dd/yyyy"));
        }

        //**************************************************************************
        //--XXX------------------Ticket---------------XXX-------

        //**************************************************************************
        //----------  Stat  ---------------------------------
        private static void setHeaderStat(DataGridView dgvStat)
        {
            dgvStat.Columns[0].HeaderText = "Ngày";
            dgvStat.Columns[1].HeaderText = "Số lượng";
            dgvStat.Columns[2].HeaderText = "Doanh thu";
            dgvStat.Columns[3].HeaderText = "Phụ xe";
        }

        private void btnStatChart_Click(object sender, EventArgs e)
        {
            foreach (var series in chartStatTicket.Series)
            {
                series.Points.Clear();
            }
            fillChart(int.Parse(cbStatChart.Text));
        }

        private void btnDatStat_Click(object sender, EventArgs e)
        {
            dgvStat.DataSource = BUS_Ticket.GetTicketStatSearch(Convert.ToDateTime(dtpStartDayStat.Value.Date).ToString("yyyy/MM/dd"), Convert.ToDateTime(dtpEndDayStat.Value.Date).ToString("yyyy/MM/dd"));
        }

        private void btnSumary_Click(object sender, EventArgs e)
        {
            dtpStartDayStat.Value = DateTime.Now;
            dtpEndDayStat.Value = DateTime.Now;
            dgvStat.DataSource = BUS_Ticket.GetTicketStat();
            foreach (var series in chartStatTicket.Series)
            {
                series.Points.Clear();
            }
            fillChart(DateTime.Now.Year);
        }

        private void btnExportPdfStat_Click(object sender, EventArgs e)
        {
            ExportToPdf(dgvStat, "BANG THONG KE DOANH THU VE THEO NGAY", DateTime.Now.Date.ToString("MM/dd/yyyy"));
        }

        //**************************************************************************
        //--XXX------------------Stat---------------XXX-------
        public void ExportToPdf(DataGridView dgv, string title, string subtitle)
        {
            if (dgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
                            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(convertToUnSign(column.HeaderText), text));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(new Phrase(convertToUnSign(cell.Value.ToString()), text));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                float marginLeft = 72;
                                float marginRight = 36;
                                float marginTop = 60;
                                float marginBottom = 50;

                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.AddTitle("Driver");
                                


                                iTextSharp.text.Font fontHeader_1 = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 30, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));
                                iTextSharp.text.Font fontHeader_2 = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 15, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(125, 125, 125));

                                PdfContentByte cb = writer.DirectContent;
                                cb.MoveTo(marginLeft, marginTop);
                                cb.LineTo(500, marginTop);
                                cb.Stroke();

                                Paragraph paraHeader_1 = new Paragraph(title, fontHeader_1);
                                paraHeader_1.Alignment = Element.ALIGN_CENTER;
                                paraHeader_1.SpacingAfter = 0f;
                                pdfDoc.Add(paraHeader_1);

                                Paragraph paraHeader_2 = new Paragraph(subtitle, fontHeader_2);
                                paraHeader_2.Alignment = Element.ALIGN_CENTER;
                                paraHeader_2.SpacingAfter = 10f;
                                pdfDoc.Add(paraHeader_2);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dữ liệu Export thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Thông báo");
            }
        }
        public static string convertToUnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}
