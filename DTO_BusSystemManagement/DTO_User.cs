using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    public class DTO_User
    {
        private int _USER_ID;
        private string _USER_USERNAME;
        private string _USER_PASSWORD;
        private string _USER_EMAIL;
        private DateTime _USER_CREATEDDATE;

        public DTO_User()
        {

        }

        public DTO_User(int uSER_ID, string uSER_USERNAME, string uSER_PASSWORD, string uSER_EMAIL, DateTime uSER_CREATEDDATE)
        {
            _USER_ID = uSER_ID;
            _USER_USERNAME = uSER_USERNAME;
            _USER_PASSWORD = uSER_PASSWORD;
            _USER_EMAIL = uSER_EMAIL;
            _USER_CREATEDDATE = uSER_CREATEDDATE;
        }

        public int USER_ID { get => _USER_ID; set => _USER_ID = value; }
        public string USER_USERNAME { get => _USER_USERNAME; set => _USER_USERNAME = value; }
        public string USER_PASSWORD { get => _USER_PASSWORD; set => _USER_PASSWORD = value; }
        public string USER_EMAIL { get => _USER_EMAIL; set => _USER_EMAIL = value; }
        public DateTime USER_CREATEDDATE { get => _USER_CREATEDDATE; set => _USER_CREATEDDATE = value; }
    }
}
