using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    class DTO_Driver
    {
        private int _Driver_ID;
        private string _Driver_Hoten;
        private string _Driver_NgaySinh;
        private DTO_Gender_Enum _Driver_GioiTinh;
        private string _Driver_DiaChi;
        private string _Driver_DienThoai;
        private string _Driver_CMND;
        private DateTime _Driver_NgayBatDau;
        private int _Driver_ThamNien;
        private DTO_License_Enum _Driver_LoaiBang;

        public int Driver_ID { get => _Driver_ID; set => _Driver_ID = value; }
        public string Driver_Hoten { get => _Driver_Hoten; set => _Driver_Hoten = value; }
        public string Driver_NgaySinh { get => _Driver_NgaySinh; set => _Driver_NgaySinh = value; }
        public string Driver_DiaChi { get => _Driver_DiaChi; set => _Driver_DiaChi = value; }
        public string Driver_DienThoai { get => _Driver_DienThoai; set => _Driver_DienThoai = value; }
        public string Driver_CMND { get => _Driver_CMND; set => _Driver_CMND = value; }
        public DateTime Driver_NgayBatDau { get => _Driver_NgayBatDau; set => _Driver_NgayBatDau = value; }
        public int Driver_ThamNien { get => _Driver_ThamNien; set => _Driver_ThamNien = value; }
        internal DTO_Gender_Enum Driver_GioiTinh { get => _Driver_GioiTinh; set => _Driver_GioiTinh = value; }
        internal DTO_License_Enum Driver_LoaiBang { get => _Driver_LoaiBang; set => _Driver_LoaiBang = value; }

        public DTO_Driver()
        {

        }
        public DTO_Driver(int driver_ID, string driver_Hoten, string driver_NgaySinh, DTO_Gender_Enum driver_GioiTinh,
            string driver_DiaChi, string driver_DienThoai, string driver_CMND, DateTime driver_NgayBatDau, int driver_ThamNien, 
            DTO_License_Enum driver_LoaiBang)
        {
            Driver_ID = driver_ID;
            Driver_Hoten = driver_Hoten;
            Driver_NgaySinh = driver_NgaySinh;
            Driver_GioiTinh = driver_GioiTinh;
            Driver_DiaChi = driver_DiaChi;
            Driver_DienThoai = driver_DienThoai;
            Driver_CMND = driver_CMND;
            Driver_NgayBatDau = driver_NgayBatDau;
            Driver_ThamNien = driver_ThamNien;
            Driver_LoaiBang = driver_LoaiBang;
        }
    }
}
