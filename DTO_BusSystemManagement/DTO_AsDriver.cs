using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    public class DTO_AsDriver
    {
        private int _ASDRIVER_ID;
        private string _ASDRIVER_NAME;
        private DateTime _ASDRIVER_DAYOFBIRTH;
        private DTO_Gender_Enum _ASDRIVER_GENDER;
        private string _ASDRIVER_ADDRESS;
        private string _ASDRIVER_PHONENUMBER;
        private string _ASDRIVER_IDCARD;
        private DateTime _ASDRIVER_STARTDATE;
        private int _ASDRIVER_EXPERIENCE;

        public DTO_AsDriver(int aSDRIVER_ID, string aSDRIVER_NAME, DateTime aSDRIVER_DAYOFBIRTH,
            DTO_Gender_Enum aSDRIVER_GENDER, string aSDRIVER_ADDRESS, string aSDRIVER_PHONENUMBER,
            string aSDRIVER_IDCARD, DateTime aSDRIVER_STARTDATE, int aSDRIVER_EXPERIENCE)
        {
            _ASDRIVER_ID = aSDRIVER_ID;
            _ASDRIVER_NAME = aSDRIVER_NAME;
            _ASDRIVER_DAYOFBIRTH = aSDRIVER_DAYOFBIRTH;
            _ASDRIVER_GENDER = aSDRIVER_GENDER;
            _ASDRIVER_ADDRESS = aSDRIVER_ADDRESS;
            _ASDRIVER_PHONENUMBER = aSDRIVER_PHONENUMBER;
            _ASDRIVER_IDCARD = aSDRIVER_IDCARD;
            _ASDRIVER_STARTDATE = aSDRIVER_STARTDATE;
            _ASDRIVER_EXPERIENCE = aSDRIVER_EXPERIENCE;
        }

        public int ASDRIVER_ID { get => _ASDRIVER_ID; set => _ASDRIVER_ID = value; }
        public string ASDRIVER_NAME { get => _ASDRIVER_NAME; set => _ASDRIVER_NAME = value; }
        public DateTime ASDRIVER_DAYOFBIRTH { get => _ASDRIVER_DAYOFBIRTH; set => _ASDRIVER_DAYOFBIRTH = value; }
        public string ASDRIVER_ADDRESS { get => _ASDRIVER_ADDRESS; set => _ASDRIVER_ADDRESS = value; }
        public string ASDRIVER_PHONENUMBER { get => _ASDRIVER_PHONENUMBER; set => _ASDRIVER_PHONENUMBER = value; }
        public string ASDRIVER_IDCARD { get => _ASDRIVER_IDCARD; set => _ASDRIVER_IDCARD = value; }
        public DateTime ASDRIVER_STARTDATE { get => _ASDRIVER_STARTDATE; set => _ASDRIVER_STARTDATE = value; }
        public int ASDRIVER_EXPERIENCE { get => _ASDRIVER_EXPERIENCE; set => _ASDRIVER_EXPERIENCE = value; }
        public DTO_Gender_Enum ASDRIVER_GENDER { get => _ASDRIVER_GENDER; set => _ASDRIVER_GENDER = value; }
    }
}
