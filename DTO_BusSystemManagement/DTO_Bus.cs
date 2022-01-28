using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    class DTO_Bus
    {
        private int _Bus_ID;
        private string _Bus_BienKiemSoat;
        private string _Bus_HangSanXuat;
        private int _Bus_NamSanXuat;
        private int _Bus_SoGhe;
        private string _Bus_ChuKyBaoHanh;

        public DTO_Bus()
        {

        }
        public DTO_Bus(int bus_ID, string bus_BienKiemSoat, string bus_HangSanXuat, int bus_NamSanXuat, int bus_SoGhe, string bus_ChuKyBaoHanh)
        {
            _Bus_ID = bus_ID;
            _Bus_BienKiemSoat = bus_BienKiemSoat;
            _Bus_HangSanXuat = bus_HangSanXuat;
            _Bus_NamSanXuat = bus_NamSanXuat;
            _Bus_SoGhe = bus_SoGhe;
            _Bus_ChuKyBaoHanh = bus_ChuKyBaoHanh;
        }

        public int Bus_ID { get => _Bus_ID; set => _Bus_ID = value; }
        public string Bus_BienKiemSoat { get => _Bus_BienKiemSoat; set => _Bus_BienKiemSoat = value; }
        public string Bus_HangSanXuat { get => _Bus_HangSanXuat; set => _Bus_HangSanXuat = value; }
        public int Bus_NamSanXuat { get => _Bus_NamSanXuat; set => _Bus_NamSanXuat = value; }
        public int Bus_SoGhe { get => _Bus_SoGhe; set => _Bus_SoGhe = value; }
        public string Bus_ChuKyBaoHanh { get => _Bus_ChuKyBaoHanh; set => _Bus_ChuKyBaoHanh = value; }
    }
}
