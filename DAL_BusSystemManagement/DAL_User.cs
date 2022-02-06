using DTO_BusSystemManagement;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BusSystemManagement
{
    public class DAL_User : DBConnect
    {
        //Lấy danh sách tất cả user
        public DataTable GetUsers()
        {
            MySqlDataAdapter mySql=new MySqlDataAdapter(
                "SELECT user.iduser, username, password, email, created_date, role " +
                "FROM user, role WHERE user.iduser = role.iduser", _conn);
            DataTable dtUser=new DataTable();
            mySql.Fill(dtUser);
            return dtUser;
        }

		  //Lấy user 
		  public DTO_User GetUserByUsername(string username)
        {
            try
            {
                _conn.Open();

                string sql=string.Format("SELECT * FROM user WHERE username='{0}'", username);

                MySqlDataAdapter mySql=new MySqlDataAdapter(sql, _conn);
                DataTable dataTable=new DataTable();
                DTO_User user=new DTO_User();
                mySql.Fill(dataTable);
                foreach (DataRow item in dataTable.Rows)
                {
                    return new DTO_User(item);
                }
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                _conn.Close();
            }
            return null;
        }

        //Kiểm tra login
        public bool CheckLogin(string username, string password)
        {
            try
            {
                _conn.Open();
                //băm mật khẩu
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedPass = Convert.ToBase64String(encData_byte);
                string sql=string.Format("SELECT * FROM user WHERE username='{0}' AND password='{1}'", username, encodedPass);

                MySqlDataAdapter mySql=new MySqlDataAdapter(sql, _conn);
                DataTable dataTable=new DataTable();
                mySql.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        //Thêm user
        public bool AddUser(DTO_User user, DTO_Role role)
        {
            try
            {
                _conn.Open();
                //băm mật khẩu
                byte[] encData_byte = new byte[user.USER_PASSWORD.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(user.USER_PASSWORD);
                string encodedPass = Convert.ToBase64String(encData_byte);

                string created_date=user.USER_CREATEDDATE.ToString("yyyy-MM-dd H:mm:ss");

                string sql=string.Format("INSERT INTO user(username, password, email, created_date) VALUES ('{0}', '{1}', '{2}', '{3}')", 
                                        user.USER_USERNAME, encodedPass, user.USER_EMAIL, created_date);

                string sql1 = string.Format("INSERT INTO role (iduser, role) values ((SELECT iduser FROM user WHERE iduser = LAST_INSERT_ID()), '{0}') ", role.ROLE_ROLE);

                MySqlCommand cmd=new MySqlCommand(sql,_conn);
                MySqlCommand cmd1 = new MySqlCommand(sql1, _conn);
                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0 )
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        //Xóa user
        public bool DeleteUser(int USER_ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM role WHERE iduser = {0}", USER_ID);
                string SQL1 = string.Format("DELETE FROM user WHERE iduser = {0}", USER_ID);
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
                MySqlCommand cmd1 = new MySqlCommand(SQL1, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        //Cập nhật user
        public bool UpdateUser(DTO_User user)
        {
            try
            {
                _conn.Open();

                string created_date = user.USER_CREATEDDATE.ToString("yyyy-MM-dd H:mm:ss");
                //Băm password
                byte[] encData_byte = new byte[user.USER_PASSWORD.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(user.USER_PASSWORD);
                string encodedPass = Convert.ToBase64String(encData_byte);

                string sql = string.Format("UPDATE user SET password = '{0}', email = '{1}' WHERE username = '{2}'", encodedPass, user.USER_EMAIL, user.USER_USERNAME);

                MySqlCommand cmd = new MySqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool UpdateUser(DTO_User user, DTO_Role role)
        {
            try
            {
                _conn.Open();

                string created_date=user.USER_CREATEDDATE.ToString("yyyy-MM-dd H:mm:ss");
                //Băm password
                byte[] encData_byte = new byte[user.USER_PASSWORD.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(user.USER_PASSWORD);
                string encodedPass = Convert.ToBase64String(encData_byte);

                string sql=string.Format("UPDATE user SET username = '{0}', password = '{1}', email = '{2}', created_date = '{3}' WHERE(iduser = '{4}') ",
                                          user.USER_USERNAME, encodedPass, user.USER_EMAIL, created_date, user.USER_ID);

                string sql1 = string.Format("UPDATE role SET role = '{0}' WHERE iduser = '{1}' ", role.ROLE_ROLE, role.ROLE_USERID);

                MySqlCommand cmd= new MySqlCommand(sql,_conn);
                MySqlCommand cmd1 = new MySqlCommand(sql1, _conn);

                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public DataTable FindUserByUsername(string kw)
        {
            string SQL = string.Format("SELECT user.iduser, username, password, email, created_date, role " +
                "FROM user, role WHERE user.iduser = role.iduser and username LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtUser = new DataTable();
            msda.Fill(dtUser);
            return dtUser;
        }

        public DataTable FindUserByEmail(string kw)
        {
            string SQL = string.Format("SELECT user.iduser, username, password, email, created_date, role " +
                "FROM user, role WHERE user.iduser = role.iduser and email LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtUser = new DataTable();
            msda.Fill(dtUser);
            return dtUser;
        }

        public DataTable FindUserByRole(string kw)
        {
            string SQL = string.Format("SELECT user.iduser, username, password, email, created_date, role " +
                "FROM user, role WHERE user.iduser = role.iduser and role LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtUser = new DataTable();
            msda.Fill(dtUser);
            return dtUser;
        }

    }
}
