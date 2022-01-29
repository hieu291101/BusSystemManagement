using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    public class DTO_Role
    {
        private int _ROLE_USERID;
        private string _ROLE_ROLE;

        public DTO_Role()
        {

        }

        public DTO_Role(int rOLE_USERID, string rOLE_ROLE)
        {
            _ROLE_USERID = rOLE_USERID;
            _ROLE_ROLE = rOLE_ROLE;
        }

        public int ROLE_USERID { get => _ROLE_USERID; set => _ROLE_USERID = value; }
        public string ROLE_ROLE { get => _ROLE_ROLE; set => _ROLE_ROLE = value; }
    }
}
