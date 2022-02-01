using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    public class DTO_Bus
    {
        private int _BUS_ID;
        private string _BUS_LICENSEPLATE;
        private string _BUS_MANUFACTURER;
        private int _BUS_YEAROFMANUFACTURE;
        private int _BUS_SEATS;
        private int _BUS_CUREPERIOD;

        public DTO_Bus(int bUS_ID, string bUS_LICENSEPLATE, string bUS_MANUFACTURER, int bUS_YEAROFMANUFACTURE, 
               int bUS_SEATS, int bUS_CUREPERIOD)
        {
            _BUS_ID = bUS_ID;
            _BUS_LICENSEPLATE = bUS_LICENSEPLATE;
            _BUS_MANUFACTURER = bUS_MANUFACTURER;
            _BUS_YEAROFMANUFACTURE = bUS_YEAROFMANUFACTURE;
            _BUS_SEATS = bUS_SEATS;
            _BUS_CUREPERIOD = bUS_CUREPERIOD;
        }

        public int BUS_ID { get => _BUS_ID; set => _BUS_ID = value; }
        public string BUS_LICENSEPLATE { get => _BUS_LICENSEPLATE; set => _BUS_LICENSEPLATE = value; }
        public string BUS_MANUFACTURER { get => _BUS_MANUFACTURER; set => _BUS_MANUFACTURER = value; }
        public int BUS_YEAROFMANUFACTURE { get => _BUS_YEAROFMANUFACTURE; set => _BUS_YEAROFMANUFACTURE = value; }
        public int BUS_SEATS { get => _BUS_SEATS; set => _BUS_SEATS = value; }
        public int BUS_CUREPERIOD { get => _BUS_CUREPERIOD; set => _BUS_CUREPERIOD = value; }
    }
}
