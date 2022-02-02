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
    public class DAL_BusRide : DBConnect
    {
        public DataTable GetBusDriver()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT idbusride, busride.idbusline, busline.busline_name, busride.iddriver, driver.driver_name, busride.idas_driver, as_driver.asdriver_name, busride.idbus, bus.license_plate, busride.start_time " +
                "FROM busride, bus, as_driver, driver, busline " +
                "WHERE busride.idbusline = busline.idbusline and busride.idbus = bus.idbus and busride.idas_driver = as_driver.idas_driver and busride.iddriver = driver.iddriver", _conn);
            DataTable dtBusRide = new DataTable();
            msda.Fill(dtBusRide);
            return dtBusRide;
        }

        public bool AddBusRide(DTO_BusRide busr)
        {
            try
            {
                //ket noi
                _conn.Open();
                string startTime = busr.BUSRIDE_STARTTIME.ToString("yyyy-MM-dd H:mm:ss");
                //
                string SQL = string.Format("INSERT INTO busride(idbusline, iddriver, idas_driver, idbus, start_time) VALUES ({0}, {1}, {2}, {3}, '{4}')",
                    busr.BUSRIDE_BUSLINEID,
                    busr.BUSRIDE_MDRIVERID,
                    busr.BUSRIDE_ASDRIVERID,
                    busr.BUSRIDE_BUSID,
                    startTime);

                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
                if(cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                //Dong
                _conn.Close();
            }

            return false;
        }


        public bool UpdateBusRide(DTO_BusRide busr)
        {
            try
            {
                //ket noi
                _conn.Open();
                string startTime = busr.BUSRIDE_STARTTIME.ToString("yyyy-MM-dd H:mm:ss");
                //
                string SQL = string.Format("UPDATE busride SET idbusline = {0}, iddriver = {1}, idas_driver = {2}, idbus = {3}, start_time = '{4}' WHERE idbusride = {5}",
                                            busr.BUSRIDE_BUSLINEID,
                                            busr.BUSRIDE_MDRIVERID,
                                            busr.BUSRIDE_ASDRIVERID,
                                            busr.BUSRIDE_BUSID,
                                            startTime,
                                            busr.BUSRIDE_ID);

                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                //Dong
                _conn.Close();
            }

            return false;
        }

        public bool DeleteBusRide(int BUSRIDE_ID)
        {
            try
            {
                //ket noi
                _conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM busride WHERE idbusride = {0}", BUSRIDE_ID);

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
                //Dong
                _conn.Close();
            }

            return false;
        }
    }
}
