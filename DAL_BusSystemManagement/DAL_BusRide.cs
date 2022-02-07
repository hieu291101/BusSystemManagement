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
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT busride.idbusride, busride.idbusline, busline.busline_name, busride.iddriver, as_driver.asdriver_name, busride.idbus, bus.license_plate, busride.start_time, busride.type " +
                "FROM busride, bus, as_driver, busline " +
                "WHERE busride.idbusline = busline.idbusline and busride.idbus = bus.idbus and busride.iddriver = as_driver.idas_driver ", _conn);
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
                string SQL = string.Format("INSERT INTO busride( iddriver, idbus, idbusline, start_time, type) VALUES ({0}, {1}, {2}, '{3}', '{4}')",
                    busr.BUSRIDE_DRIVERID,
                    busr.BUSRIDE_BUSID,
                    busr.BUSRIDE_BUSLINEID,
                    startTime,
                    busr.BUSRIDE_TYPE);

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
                string SQL = string.Format("UPDATE busride SET idbusline = {0}, iddriver = {1}, idbus = {2}, start_time = '{3}' WHERE idbusride = {4}",
                                            busr.BUSRIDE_BUSLINEID,
                                            busr.BUSRIDE_DRIVERID,
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

        public DataTable FindBusRideByBusLineName(string kw)
        {
            string SQL = string.Format(
                "SELECT busride.idbusride, busride.idbusline, busline.busline_name, busride.iddriver, as_driver.asdriver_name, busride.idbus, bus.license_plate, busride.start_time, busride.type " +
                "FROM busride, bus, as_driver, busline " +
                "WHERE busride.idbusline = busline.idbusline and busride.idbus = bus.idbus and busride.iddriver = as_driver.idas_driver and " +
                "busline.busline_name LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBusRide = new DataTable();
            msda.Fill(dtBusRide);
            return dtBusRide;
        }

        public DataTable FindBusRideByAsDriverName(string kw)
        {
            string SQL = string.Format(
                "SELECT busride.idbusride, busride.idbusline, busline.busline_name, busride.iddriver, as_driver.asdriver_name, busride.idbus, bus.license_plate, busride.start_time, busride.type " +
                "FROM busride, bus, as_driver, busline " +
                "WHERE busride.idbusline = busline.idbusline and busride.idbus = bus.idbus and busride.iddriver = as_driver.idas_driver and " +
                "as_driver.asdriver_name LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBusRide = new DataTable();
            msda.Fill(dtBusRide);
            return dtBusRide;
        }

        public DataTable FindBusRideByLicensePlate(string kw)
        {
            string SQL = string.Format(
                "SELECT busride.idbusride, busride.idbusline, busline.busline_name, busride.iddriver, as_driver.asdriver_name, busride.idbus, bus.license_plate, busride.start_time, busride.type " +
                "FROM busride, bus, as_driver, busline " +
                "WHERE busride.idbusline = busline.idbusline and busride.idbus = bus.idbus and busride.iddriver = as_driver.idas_driver and " +
                "bus.license_plate LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBusRide = new DataTable();
            msda.Fill(dtBusRide);
            return dtBusRide;
        }

        public DataTable FindBusRideByAsDriverType(string kw)
        {
            string SQL = string.Format(
                "SELECT busride.idbusride, busride.idbusline, busline.busline_name, busride.iddriver, as_driver.asdriver_name, busride.idbus, bus.license_plate, busride.start_time, busride.type " +
                "FROM busride, bus, as_driver, busline " +
                "WHERE busride.idbusline = busline.idbusline and busride.idbus = bus.idbus and busride.iddriver = as_driver.idas_driver and " +
                "busride.type LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBusRide = new DataTable();
            msda.Fill(dtBusRide);
            return dtBusRide;
        }
    }
}
