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
            MySqlDataAdapter msda = new MySqlDataAdapter(
                "SELECT idas_driver, asdriver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience, driver_license " +
                "FROM as_driver, driver WHERE idas_driver = iddriver", _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            return dtDriver;
        }

        public string GetDriverById(int id)
        {
            string SQL = string.Format("SELECT asdriver_name FROM as_driver, driver WHERE idas_driver = iddriver and iddriver = {0}", id);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            List<string> list = new List<string>();
            foreach (DataRow row in dtDriver.Rows)
            {
                list.Add(row["asdriver_name"].ToString());
            }
            return list[0];
        }

        public List<string> GetListDriverId()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT iddriver FROM driver", _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            List<string> list = new List<string>();
            foreach (DataRow row in dtDriver.Rows)
            {
                list.Add(row["iddriver"].ToString());
            }
            return list;
        }

        public bool AddDriver(DTO_AsDriver ad, DTO_Driver d)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string dayOfBirth = ad.ASDRIVER_DAYOFBIRTH.ToString("yyyy-MM-dd H:mm:ss");
                string startDate = ad.ASDRIVER_STARTDATE.ToString("yyyy-MM-dd H:mm:ss");

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO as_driver(asdriver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience) " +
                                            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})",
                                           ad.ASDRIVER_NAME,
                                           dayOfBirth,
                                           ad.ASDRIVER_GENDER,
                                           ad.ASDRIVER_ADDRESS,
                                           ad.ASDRIVER_PHONENUMBER,
                                           ad.ASDRIVER_IDCARD,
                                           startDate,
                                           ad.ASDRIVER_EXPERIENCE);

                string SQL1 = "INSERT INTO driver (iddriver) " +
                              "SELECT idas_driver " +
                              "FROM as_driver " +
                              "WHERE idas_driver = LAST_INSERT_ID() ";

                string SQL2 = string.Format("UPDATE driver SET driver_license = '{0}'  WHERE iddriver = LAST_INSERT_ID()", d.DRIVER_LICENSE);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
                MySqlCommand cmd1 = new MySqlCommand(SQL1, _conn);
                MySqlCommand cmd2 = new MySqlCommand(SQL2, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0 && cmd2.ExecuteNonQuery() > 0)
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

        public bool UpdateDriver(DTO_AsDriver ad, DTO_Driver d)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string dayOfBirth = ad.ASDRIVER_DAYOFBIRTH.ToString("yyyy-MM-dd H:mm:ss");
                string startDate = ad.ASDRIVER_STARTDATE.ToString("yyyy-MM-dd H:mm:ss");

                // Query string
                string SQL = string.Format("UPDATE as_driver SET asdriver_name = '{0}', day_of_birth = '{1}', gender = '{2}', address = '{3}', phone_number = '{4}', idcard = '{5}', start_date = '{6}', experience = {7} WHERE idas_driver = {8}",
                                           ad.ASDRIVER_NAME, dayOfBirth, ad.ASDRIVER_GENDER, ad.ASDRIVER_ADDRESS,
                                           ad.ASDRIVER_PHONENUMBER, ad.ASDRIVER_IDCARD, startDate,
                                           ad.ASDRIVER_EXPERIENCE, ad.ASDRIVER_ID);
                string SQL1 = string.Format("UPDATE driver SET driver_license = '{0}'  WHERE iddriver = {1}", d.DRIVER_LICENSE, d.DRIVER_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
                MySqlCommand cmd1 = new MySqlCommand(SQL1, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
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
                string SQL = string.Format("DELETE FROM driver WHERE iddriver = {0}", DRIVER_ID);
                string SQL1 = string.Format("DELETE FROM as_driver WHERE idas_driver = {0}", DRIVER_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
                MySqlCommand cmd1 = new MySqlCommand(SQL1, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
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

        public DataTable FindDriverByName(string kw)
        {
            string SQL = string.Format("SELECT idas_driver, asdriver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience, driver_license " +
                "FROM as_driver, driver WHERE idas_driver = iddriver and asdriver_name LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            return dtDriver;
        }

        public DataTable FindDriverByGender(string kw)
        {
            string SQL = string.Format("SELECT idas_driver, asdriver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience, driver_license " +
                "FROM as_driver, driver WHERE idas_driver = iddriver and gender LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            return dtDriver;
        }

        public DataTable FindDriverByAddress(string kw)
        {
            string SQL = string.Format("SELECT idas_driver, asdriver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience, driver_license " +
                "FROM as_driver, driver WHERE idas_driver = iddriver and address LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            return dtDriver;
        }

        public DataTable FindDriverByPhoneNumber(string kw)
        {
            string SQL = string.Format("SELECT idas_driver, asdriver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience, driver_license " +
                "FROM as_driver, driver WHERE idas_driver = iddriver and phone_number LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            return dtDriver;
        }

        public DataTable FindDriverByIdCard(string kw)
        {
            string SQL = string.Format("SELECT idas_driver, asdriver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience, driver_license " +
                "FROM as_driver, driver WHERE idas_driver = iddriver and idcard LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            return dtDriver;
        }

        public DataTable FindDriverByExperienceYear(string kw)
        {
            string SQL = string.Format("SELECT idas_driver, asdriver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience, driver_license " +
                "FROM as_driver, driver WHERE idas_driver = iddriver and experience = {0}", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            return dtDriver;
        }

        public DataTable FindDriverByDriverLicense(string kw)
        {
            string SQL = string.Format("SELECT idas_driver, asdriver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience, driver_license " +
                "FROM as_driver, driver WHERE idas_driver = iddriver and driver_license LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtDriver = new DataTable();
            msda.Fill(dtDriver);
            return dtDriver;
        }
    }
}
