using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BusSystemManagement;

namespace DAL_BusSystemManagement
{
    public class DAL_AsDriver : DBConnect
    {
        public DataTable GetAsDriver()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM as_driver WHERE idas_driver NOT IN (SELECT iddriver FROM driver)", _conn);
            DataTable dtAsDriver = new DataTable();
            msda.Fill(dtAsDriver);
            return dtAsDriver;
        }

        public string GetAsDriverById(int id)
        {
            string SQL = string.Format("SELECT asdriver_name FROM as_driver WHERE idas_driver = {0}", id);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtAsDriver = new DataTable();
            msda.Fill(dtAsDriver);
            List<string> list = new List<string>();
            foreach (DataRow row in dtAsDriver.Rows)
            {
                list.Add(row["asdriver_name"].ToString());
            }
            return list[0];
        }

        public List<string> GetListAsDriverId()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT idas_driver FROM as_driver WHERE idas_driver NOT IN (SELECT iddriver FROM driver)", _conn);
            DataTable dtAsDriver = new DataTable();
            msda.Fill(dtAsDriver);
            List<string> list = new List<string>();
            foreach (DataRow row in dtAsDriver.Rows)
            {
                list.Add(row["idas_driver"].ToString());
            }
            return list;
        }

        public bool AddAsDriver(DTO_AsDriver asd)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string dayOfBirth = asd.ASDRIVER_DAYOFBIRTH.ToString("yyyy-MM-dd H:mm:ss");
                string startDate = asd.ASDRIVER_STARTDATE.ToString("yyyy-MM-dd H:mm:ss");

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO as_driver(asdriver_name, day_of_birth, gender, address, phone_number, idcard, start_date, experience) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})",
                                           asd.ASDRIVER_NAME,
                                           dayOfBirth,
                                           asd.ASDRIVER_GENDER,
                                           asd.ASDRIVER_ADDRESS,
                                           asd.ASDRIVER_PHONENUMBER,
                                           asd.ASDRIVER_IDCARD,
                                           startDate,
                                           asd.ASDRIVER_EXPERIENCE);

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

        public bool UpdateAsDriver(DTO_AsDriver asd)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string dayOfBirth = asd.ASDRIVER_DAYOFBIRTH.ToString("yyyy-MM-dd H:mm:ss");
                string startDate = asd.ASDRIVER_STARTDATE.ToString("yyyy-MM-dd H:mm:ss");

                // Query string
                string SQL = string.Format("UPDATE as_driver SET asdriver_name = '{0}', day_of_birth = '{1}', gender = '{2}', address = '{3}', phone_number = '{4}', idcard = '{5}', start_date = '{6}', experience = {7} WHERE idas_driver = {8}",
                                           asd.ASDRIVER_NAME, dayOfBirth, asd.ASDRIVER_GENDER, asd.ASDRIVER_ADDRESS,
                                           asd.ASDRIVER_PHONENUMBER, asd.ASDRIVER_IDCARD, startDate,
                                           asd.ASDRIVER_EXPERIENCE, asd.ASDRIVER_ID);

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

        
        public bool DeleteAsDriver(int ASDRIVER_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM as_driver WHERE idas_driver = {0}", ASDRIVER_ID);

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

        public DataTable FindAsDriverByName(string kw)
        {
            string SQL = string.Format("SELECT * FROM as_driver WHERE asdriver_name LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtAsDriver = new DataTable();
            msda.Fill(dtAsDriver);
            return dtAsDriver;
        }

        public DataTable FindAsDriverByGender(string kw)
        {
            string SQL = string.Format("SELECT * FROM as_driver WHERE gender LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtAsDriver = new DataTable();
            msda.Fill(dtAsDriver);
            return dtAsDriver;
        }

        public DataTable FindAsDriverByAddress(string kw)
        {
            string SQL = string.Format("SELECT * FROM as_driver WHERE address LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtAsDriver = new DataTable();
            msda.Fill(dtAsDriver);
            return dtAsDriver;
        }

        public DataTable FindAsDriverByPhoneNumber(string kw)
        {
            string SQL = string.Format("SELECT * FROM as_driver WHERE phone_number LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtAsDriver = new DataTable();
            msda.Fill(dtAsDriver);
            return dtAsDriver;
        }

        public DataTable FindAsDriverByIdCard(string kw)
        {
            string SQL = string.Format("SELECT * FROM as_driver WHERE idcard LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtAsDriver = new DataTable();
            msda.Fill(dtAsDriver);
            return dtAsDriver;
        }

        public DataTable FindAsDriverByExperienceYear(string kw)
        {
            string SQL = string.Format("SELECT * FROM as_driver WHERE experience = {0}", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtAsDriver = new DataTable();
            msda.Fill(dtAsDriver);
            return dtAsDriver;
        }
    }
}
