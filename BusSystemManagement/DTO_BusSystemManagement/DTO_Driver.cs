using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    public class DTO_Driver
    {
        private int _DRIVER_ID;
        private DTO_License_Enum _DRIVER_LICENSE;

        public DTO_Driver()
        {

        }
        public DTO_Driver(int dRIVER_ID, DTO_License_Enum dRIVER_LICENSE)
        {
            _DRIVER_ID = dRIVER_ID;
            _DRIVER_LICENSE = dRIVER_LICENSE;
        }

        public int DRIVER_ID { get => _DRIVER_ID; set => _DRIVER_ID = value; }
        public DTO_License_Enum DRIVER_LICENSE { get => _DRIVER_LICENSE; set => _DRIVER_LICENSE = value; }
    }
}
