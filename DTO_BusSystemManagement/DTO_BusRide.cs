using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    class DTO_BusRide
    {
        private int _BusRide_BusLineID;
        private int _BusRide_BusID;
        private int _BusRide_MDriverID;
        private int _BusRide_AsDriverID;
        private int _BusRide_ID;
        private DateTime _BusRide_ThoiDiem;

        public DTO_BusRide()
        {

        }

        public DTO_BusRide(int busRide_BusLineID, int busRide_BusID, int busRide_MDriverID, int busRide_AsDriverID, int busRide_ID, DateTime busRide_ThoiDiem)
        {
            _BusRide_BusLineID = busRide_BusLineID;
            _BusRide_BusID = busRide_BusID;
            _BusRide_MDriverID = busRide_MDriverID;
            _BusRide_AsDriverID = busRide_AsDriverID;
            _BusRide_ID = busRide_ID;
            _BusRide_ThoiDiem = busRide_ThoiDiem;
        }

        public int BusRide_BusLineID { get => _BusRide_BusLineID; set => _BusRide_BusLineID = value; }
        public int BusRide_BusID { get => _BusRide_BusID; set => _BusRide_BusID = value; }
        public int BusRide_MDriverID { get => _BusRide_MDriverID; set => _BusRide_MDriverID = value; }
        public int BusRide_AsDriverID { get => _BusRide_AsDriverID; set => _BusRide_AsDriverID = value; }
        public int BusRide_ID { get => _BusRide_ID; set => _BusRide_ID = value; }
        public DateTime BusRide_ThoiDiem { get => _BusRide_ThoiDiem; set => _BusRide_ThoiDiem = value; }
    }
}
