using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    class DTO_Driver
    {
        private int _DRIVER_ID;
        private string _DRIVER_NAME;
        private string _DRIVER_DAYOFBIRTH;
        private DTO_Gender_Enum _DRIVER_GENDER;
        private string _DRIVER_ADDRESS;
        private string _DRIVER_PHONENUMBER;
        private string _DRIVER_IDCARD;
        private DateTime _DRIVER_STARTDATE;
        private int _Driver_EXPERIENCE;
        private DTO_License_Enum _DRIVER_LICENSE;

        public DTO_Driver()
        {

        }
        public DTO_Driver(int dRIVER_ID, string dRIVER_NAME, string dRIVER_DAYOFBIRTH, DTO_Gender_Enum dRIVER_GENDER,
            string dRIVER_ADDRESS, string dRIVER_PHONENUMBER, string dRIVER_IDCARD, DateTime dRIVER_STARTDATE,
            int driver_EXPERIENCE, DTO_License_Enum dRIVER_LICENSE)
        {
            _DRIVER_ID = dRIVER_ID;
            _DRIVER_NAME = dRIVER_NAME;
            _DRIVER_DAYOFBIRTH = dRIVER_DAYOFBIRTH;
            _DRIVER_GENDER = dRIVER_GENDER;
            _DRIVER_ADDRESS = dRIVER_ADDRESS;
            _DRIVER_PHONENUMBER = dRIVER_PHONENUMBER;
            _DRIVER_IDCARD = dRIVER_IDCARD;
            _DRIVER_STARTDATE = dRIVER_STARTDATE;
            _Driver_EXPERIENCE = driver_EXPERIENCE;
            _DRIVER_LICENSE = dRIVER_LICENSE;
        }

        public int DRIVER_ID { get => _DRIVER_ID; set => _DRIVER_ID = value; }
        public string DRIVER_NAME { get => _DRIVER_NAME; set => _DRIVER_NAME = value; }
        public string DRIVER_DAYOFBIRTH { get => _DRIVER_DAYOFBIRTH; set => _DRIVER_DAYOFBIRTH = value; }
        public string DRIVER_ADDRESS { get => _DRIVER_ADDRESS; set => _DRIVER_ADDRESS = value; }
        public string DRIVER_PHONENUMBER { get => _DRIVER_PHONENUMBER; set => _DRIVER_PHONENUMBER = value; }
        public string DRIVER_IDCARD { get => _DRIVER_IDCARD; set => _DRIVER_IDCARD = value; }
        public DateTime DRIVER_STARTDATE { get => _DRIVER_STARTDATE; set => _DRIVER_STARTDATE = value; }
        public int Driver_EXPERIENCE { get => _Driver_EXPERIENCE; set => _Driver_EXPERIENCE = value; }
        internal DTO_Gender_Enum DRIVER_GENDER { get => _DRIVER_GENDER; set => _DRIVER_GENDER = value; }
        internal DTO_License_Enum DRIVER_LICENSE { get => _DRIVER_LICENSE; set => _DRIVER_LICENSE = value; }
    }
}
