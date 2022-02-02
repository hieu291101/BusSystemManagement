using DTO_BusSystemManagement;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BusSystemManagement
{
    public class DAL_Driver : DBConnect
    {
        public DataTable GetDriver()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM driver", _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            return dtDriver;
        }

        public string GetDriverById(int id)
        {
            string SQL = string.Format("SELECT driver_name FROM driver WHERE idDriver = {0}", id);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            List<string> list = new List<string>();
            foreach (DataRow row in dtDriver.Rows)
            {
                list.Add(row["driver_name"].ToString());
            }
            return list[0];
        }

        public List<string> GetListDriverId()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT idDriver FROM driver", _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            List<string> list = new List<string>();
            foreach (DataRow row in dtDriver.Rows)
            {
                list.Add(row["idDriver"].ToString());
            }
            return list;
        }

        public bool AddDriver(DTO_Driver ad)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string dayOfBirth = ad.DRIVER_DAYOFBIRTH.ToString("yyyy-MM-dd H:mm:ss");
                string startDate = ad.DRIVER_STARTDATE.ToString("yyyy-MM-dd H:mm:ss");

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO driver(driver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience, driver_license) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, '{8}')",
                                           ad.DRIVER_NAME,
                                           dayOfBirth,
                                           ad.DRIVER_GENDER,
                                           ad.DRIVER_ADDRESS,
                                           ad.DRIVER_PHONENUMBER,
                                           ad.DRIVER_IDCARD,
                                           startDate,
                                           ad.DRIVER_EXPERIENCE,
                                           ad.DRIVER_LICENSE);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool UpdateDriver(DTO_Driver ad)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string dayOfBirth = ad.DRIVER_DAYOFBIRTH.ToString("yyyy-MM-dd H:mm:ss");
                string startDate = ad.DRIVER_STARTDATE.ToString("yyyy-MM-dd H:mm:ss");

                // Query string
                string SQL = string.Format("UPDATE driver SET driver_name = '{0}', day_of_birth = '{1}', gender = '{2}', address = '{3}', phone_number = '{4}', idcard = '{5}', start_date = '{6}', experience = {7}, driver_license = '{8}' WHERE idDriver = {9}",
                                           ad.DRIVER_NAME, dayOfBirth, ad.DRIVER_GENDER, ad.DRIVER_ADDRESS,
                                           ad.DRIVER_PHONENUMBER, ad.DRIVER_IDCARD, startDate,
                                           ad.DRIVER_EXPERIENCE, ad.DRIVER_LICENSE, ad.DRIVER_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }


        public bool DeleteDriver(int DRIVER_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM driver WHERE idDriver = {0}", DRIVER_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}
