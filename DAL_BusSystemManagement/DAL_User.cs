using DTO_BusSystemManagement;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DAL_BusSystemManagement
{
    public class DAL_User : DBConnect
    {
        //Lấy danh sách tất cả user
        public DataTable GetUsers()
        {
            MySqlDataAdapter mySql = new MySqlDataAdapter("SELECT * FROM user ", _conn);
            DataTable dtUser = new DataTable();
            mySql.Fill(dtUser);
            return dtUser;
        }

        //Lấy user 
        public DTO_User GetUserByUsername(string username)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT * FROM user WHERE username='{0}'", username);

                MySqlDataAdapter mySql = new MySqlDataAdapter(sql, _conn);
                DataTable dataTable = new DataTable();
                DTO_User user = new DTO_User();
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
                string sql = string.Format("SELECT * FROM user WHERE username='{0}' AND password='{1}'", username, encodedPass);

                MySqlDataAdapter mySql = new MySqlDataAdapter(sql, _conn);
                DataTable dataTable = new DataTable();
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
        public bool AddUser(DTO_User user)
        {
            try
            {
                _conn.Open();
                //băm mật khẩu
                byte[] encData_byte = new byte[user.USER_PASSWORD.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(user.USER_PASSWORD);
                string encodedPass = Convert.ToBase64String(encData_byte);

                string created_date = user.USER_CREATEDDATE.ToString("yyyy-MM-dd H:mm:ss");

                string sql = string.Format("INSERT INTO user(username, password, email, created_date) VALUES ('{0}', '{1}', '{2}', '{3}')",
                                        user.USER_USERNAME, encodedPass, user.USER_EMAIL, created_date);

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

        //Xóa user
        public bool DeleteUser(int USER_ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM user WHERE iduser = {0}", USER_ID);
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
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

        public DataTable FindUserByUsername(string kw)
        {
            string SQL = string.Format("SELECT * FROM user WHERE username LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtUser = new DataTable();
            msda.Fill(dtUser);
            return dtUser;
        }

        public DataTable FindUserByEmail(string kw)
        {
            string SQL = string.Format("SELECT * FROM user  WHERE email LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtUser = new DataTable();
            msda.Fill(dtUser);
            return dtUser;
        }

    }
}
