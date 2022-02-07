using DAL_BusSystemManagement;
using DTO_BusSystemManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BusSystemManagement
{
    public class BUS_User: DBConnect
    {
        DAL_User dAL_User = new DAL_User();

        public DataTable GetUsers()
        {
            return dAL_User.GetUsers();
        }

        public DTO_User GetUser(string username)
        {
				return dAL_User.GetUserByUsername(username);
        }

        public bool CheckLogin(string username, string password)
        {
            return dAL_User.CheckLogin(username, password);
        }

        public bool AddUser(DTO_User user)
        {
            return dAL_User.AddUser(user);
        }

        public bool UpdateUser(DTO_User user)
        {
            return dAL_User.UpdateUser(user);
        }

        public bool DeleteUser(int iduser)
        {
            return dAL_User.DeleteUser(iduser);
        }

        public DataTable FindUserByUsername(string kw)
        {
            return dAL_User.FindUserByUsername(kw);
        }

        public DataTable FindUserByEmail(string kw)
        {
            return dAL_User.FindUserByEmail(kw);
        }

    }
}
