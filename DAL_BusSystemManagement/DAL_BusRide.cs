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
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM busride", _conn);
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
                string SQL = string.Format("INSERT INTO busride(buslineid, busid, mdriverid, asdriverid, starttime) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    busr.BUSRIDE_BUSLINEID,
                    busr.BUSRIDE_BUSID,
                    busr.BUSRIDE_MDRIVERID,
                    busr.BUSRIDE_ASDRIVERID,
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
                string SQL = string.Format("UPDATE busride SET buslineid = '{0}', busid = '{1}', mdriverid = '{2}', asdriverid = '{3}', starttime = '{4}' WHERE idbusride = {5})",
                                            busr.BUSRIDE_BUSLINEID,
                                            busr.BUSRIDE_BUSID,
                                            busr.BUSRIDE_MDRIVERID,
                                            busr.BUSRIDE_ASDRIVERID,
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
