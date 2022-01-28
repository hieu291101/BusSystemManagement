using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    class DTO_Admin
    {
        private int _Admin_ID;
        private string _Admin_Username;
        private string _Admin_Password;
        private string _Admin_Email;
        private DateTime _Admin_Ngaytao;

        public DTO_Admin()
        {

        }
        public DTO_Admin(int admin_ID, string admin_Username, string admin_Password, string admin_Email, DateTime admin_Ngaytao)
        {
            _Admin_ID = admin_ID;
            _Admin_Username = admin_Username;
            _Admin_Password = admin_Password;
            _Admin_Email = admin_Email;
            _Admin_Ngaytao = admin_Ngaytao;
        }

        public int Admin_ID { get => _Admin_ID; set => _Admin_ID = value; }
        public string Admin_Username { get => _Admin_Username; set => _Admin_Username = value; }
        public string Admin_Password { get => _Admin_Password; set => _Admin_Password = value; }
        public string Admin_Email { get => _Admin_Email; set => _Admin_Email = value; }
        public DateTime Admin_Ngaytao { get => _Admin_Ngaytao; set => _Admin_Ngaytao = value; }
    }
}
