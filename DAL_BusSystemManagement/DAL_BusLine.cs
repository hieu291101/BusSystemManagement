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
    public class DAL_BusLine : DBConnect
    {
        public DataTable GetBusLine()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM busline", _conn);
            DataTable dtBusLine = new DataTable();
            msda.Fill(dtBusLine);
            return dtBusLine;
        }

        public bool AddBusLine(DTO_BusLine bl)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO busline(busline_name, start_time, end_time, start_location, end_location, bus_stop_detail, frequency) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                           bl.BUSLINE_NAME,
                                           bl.BUSLINE_STARTTIME,
                                           bl.BUSLINE_ENDTIME,
                                           bl.BUSLINE_STARTLOCATION,
                                           bl.BUSLINE_ENDLOCATION,
                                           bl.BUSLINE_BUSSTOPDETAIL,
                                           bl.BUSLINE_FREQUENCY);

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

        public bool UpdateBusLine(DTO_BusLine bl)
        {
            try
            {
                // Ket noi
                _conn.Open();
               
                string SQL = string.Format("UPDATE `bussystemmanagement`.`busline` SET `busline_name` = '{0}', `start_time` = {1}, `end_time` = {2}, `start_location` = '{3}', `end_location` = '{4}', `bus_stop_detail` = '{5}', `frequency` = {6} WHERE(`idbusline` = {7});",
                                           bl.BUSLINE_NAME,
                                           bl.BUSLINE_STARTTIME,
                                           bl.BUSLINE_ENDTIME,
                                           bl.BUSLINE_STARTLOCATION,
                                           bl.BUSLINE_ENDLOCATION,
                                           bl.BUSLINE_BUSSTOPDETAIL,
                                           bl.BUSLINE_FREQUENCY,
                                           bl.BUSLINE_ID);

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

        public bool DeleteBusLine(int BUSLINE_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("DELETE FROM busline WHERE idbusline = {0}", BUSLINE_ID);

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

        public DataTable FindBusLineByBusLineName(string kw)
        {
            string SQL = string.Format("SELECT * FROM busline WHERE busline_name LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBusLine = new DataTable();
            msda.Fill(dtBusLine);
            return dtBusLine;
        }

        public DataTable FindBusLineByStartLocation(string kw)
        {
            string SQL = string.Format("SELECT * FROM busline WHERE start_location LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBusLine = new DataTable();
            msda.Fill(dtBusLine);
            return dtBusLine;
        }

        public DataTable FindBusLineByEndLocation(string kw)
        {
            string SQL = string.Format("SELECT * FROM busline WHERE end_location LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBusLine = new DataTable();
            msda.Fill(dtBusLine);
            return dtBusLine;
        }

        public DataTable FindBusLineByBusStopDetail(string kw)
        {
            string SQL = string.Format("SELECT * FROM busline WHERE bus_stop_detail LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBusLine = new DataTable();
            msda.Fill(dtBusLine);
            return dtBusLine;
        }

        public DataTable FindBusLineByStartTime(string kw)
        {
            string SQL = string.Format("SELECT * FROM busline WHERE start_time = {0}", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBusLine = new DataTable();
            msda.Fill(dtBusLine);
            return dtBusLine;
        }

        public DataTable FindBusLineByEndTime(string kw)
        {
            string SQL = string.Format("SELECT * FROM busline WHERE end_time = {0}", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtBusLine = new DataTable();
            msda.Fill(dtBusLine);
            return dtBusLine;
        }
    }
}
