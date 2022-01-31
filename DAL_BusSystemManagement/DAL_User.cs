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
            MySqlDataAdapter mySql=new MySqlDataAdapter("SELECT * FROM user", _conn);
            DataTable dtUser=new DataTable();
            mySql.Fill(dtUser);
            return dtUser;
        }

        //Lấy user 
        public DTO_User GetUserByUsername(string text)
        {
            string sql=string.Format("SELECT * FROM user WHERE username='{0}'", text);
            MySqlCommand cmd=new MySqlCommand(sql, _conn);
            DTO_User user = new DTO_User();

            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    int iduser = (int) reader.GetValue(0);
                    string username=(string) reader.GetValue(1);
                    string password=(string) reader.GetValue(2);
                    string email=(string) reader.GetValue(3);
                    DateTime created_date=(DateTime) reader.GetValue(4);
                    user = new DTO_User(iduser, username, password, email, created_date);
                } 
            }

            return user;
        }

        //Kiểm tra login
        public bool CheckLogin(string username, string password)
        {
            try
            {
                _conn.Open();

                string sql=string.Format("SELECT * FROM user WHERE username='{0}' AND password='{1}'", username, password);

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
        public bool AddUser(DTO_User user)
        {
            try
            {
                _conn.Open();
                string created_date=user.USER_CREATEDDATE.ToString("yyyy-MM-dd H:mm:ss");

                string sql=string.Format("INSERT INTO user(username, password, email, created_date) VALUES ('{0}', '{1}', '{2}', '{3}')", user.USER_USERNAME, user.USER_PASSWORD, user.USER_EMAIL, created_date);

                MySqlCommand cmd=new MySqlCommand(sql,_conn);

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

                string created_date=user.USER_CREATEDDATE.ToString("yyyy-MM-dd H:mm:ss");

                string sql=string.Format("UPDATE user SET password = '{0}', email = '{1}' WHERE username = {2}",  user.USER_PASSWORD, user.USER_EMAIL, user.USER_USERNAME);

                MySqlCommand cmd=new MySqlCommand(sql,_conn);

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
        public bool DeleteUser(int id)
        {
            try
            {
                _conn.Open();

                string sql=string.Format("DELETE FROM user WHERE iduser={0}",  id);

                MySqlCommand cmd=new MySqlCommand(sql,_conn);

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
    }
}
