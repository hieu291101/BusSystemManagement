using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO_BusSystemManagement;

namespace DAL_BusSystemManagement
{
    public class DAL_Bus : DBConnect
    {
        public DataTable GetBus()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT bus FROM bus", _conn);
            DataTable dtBus = new DataTable();
            msda.Fill(dtBus);
            return dtBus;
        }

        public bool AddBus(DTO_Bus bus)
        {
            try
            {
                //ket noi
                _conn.Open();

                //Query String
                string SQL = string.Format("INSERT INTO bus(license_plate, manufacturer, year_of_manufacture, seats, cure_period) VALUE ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                            bus.BUS_LICENSEPLATE,
                                            bus.BUS_MANUFACTURER,
                                            bus.BUS_YEAROFMANUFACTURE,
                                            bus.BUS_SEATS,
                                            bus.BUS_CUREPERIOD);  

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
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
                //DOng ket noi
                _conn.Close();
            }

            return false;
        }


        public bool DeleteBus(int BUS_ID)
        {
            try
            {
                //ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM bus WHERE idbus = {0}", BUS_ID);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                //Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool UpdateBus(DTO_Bus bus)
        {
            try
            {
                //ket noi
                _conn.Open();

                //Query string
                string SQL = string.Format("UPDATE bus SET license_plate = '{0}', manufacturer = '{1}', year_of_manufacture = '{2}', seats = '{3}', cure_period = '{4}' WHERE idbus = {5} ",
                                            bus.BUS_LICENSEPLATE,
                                            bus.BUS_MANUFACTURER,
                                            bus.BUS_YEAROFMANUFACTURE,
                                            bus.BUS_SEATS,
                                            bus.BUS_CUREPERIOD,
                                            bus.BUS_ID);

                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                //Dong ket
                _conn.Close();
            }

            return false;
        }
    }
}
