using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    class DTO_BusLine
    {
        private int _BusLine_ID;
        private string _BusLine_TenChuyenXe;
        private int _BusLine_GioDatDau;
        private int _BusLine_GioKetThuc;
        private string _BusLine_DiemDau;
        private string _BusLine_DiemCuoi;
        private string _BusLine_ChiTietTram;
        private int _BusLine_TanSuat;

        public int BusLine_ID { get => _BusLine_ID; set => _BusLine_ID = value; }
        public string BusLine_TenChuyenXe { get => _BusLine_TenChuyenXe; set => _BusLine_TenChuyenXe = value; }
        public int BusLine_GioDatDau { get => _BusLine_GioDatDau; set => _BusLine_GioDatDau = value; }
        public int BusLine_GioKetThuc { get => _BusLine_GioKetThuc; set => _BusLine_GioKetThuc = value; }
        public string BusLine_DiemDau { get => _BusLine_DiemDau; set => _BusLine_DiemDau = value; }
        public string BusLine_DiemCuoi { get => _BusLine_DiemCuoi; set => _BusLine_DiemCuoi = value; }
        public string BusLine_ChiTietTram { get => _BusLine_ChiTietTram; set => _BusLine_ChiTietTram = value; }
        public int BusLine_TanSuat { get => _BusLine_TanSuat; set => _BusLine_TanSuat = value; }

        public DTO_BusLine()
        {

        }
        public DTO_BusLine(int busLine_ID, string busLine_TenChuyenXe, int busLine_GioDatDau, int busLine_GioKetThuc, 
            string busLine_DiemDau, string busLine_DiemCuoi, string busLine_ChiTietTram, int busLine_TanSuat)
        {
            BusLine_ID = busLine_ID;
            BusLine_TenChuyenXe = busLine_TenChuyenXe;
            BusLine_GioDatDau = busLine_GioDatDau;
            BusLine_GioKetThuc = busLine_GioKetThuc;
            BusLine_DiemDau = busLine_DiemDau;
            BusLine_DiemCuoi = busLine_DiemCuoi;
            BusLine_ChiTietTram = busLine_ChiTietTram;
            BusLine_TanSuat = busLine_TanSuat;
        }
    }
}
