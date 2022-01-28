using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    class DTO_Role
    {
        private int _Role_UserID;
        private string Role;

        public DTO_Role()
        {

        }
        public DTO_Role(int role_UserID, string role)
        {
            _Role_UserID = role_UserID;
            Role = role;
        }

        public int Role_UserID { get => _Role_UserID; set => _Role_UserID = value; }
        public string Role1 { get => Role; set => Role = value; }
    }
}
