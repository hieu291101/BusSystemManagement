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
    public class DAL_Ticket : DBConnect
    {
        public DataTable GetTicket()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter(
                "SELECT idticket, date, price, ticket.idas_driver, as_driver.asdriver_name " +
                "FROM ticket, as_driver " +
                "WHERE ticket.idas_driver = as_driver.idas_driver", _conn);
            DataTable dtTicket = new DataTable();
            msda.Fill(dtTicket);
            return dtTicket;
        }

        public DataTable GetTicketStat()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT Date_Format(date,'%d/%m/%Y'), count(idticket), sum(price), asdriver_name  " +
                "FROM ticket, as_driver " +
                "WHERE ticket.idas_driver = as_driver.idas_driver GROUP BY year(date), month(date), day(date)", _conn);
            DataTable dtTicket = new DataTable();
            msda.Fill(dtTicket);
            return dtTicket;
        }

        public DataTable GetTicketStatSearch(string start, string end)
        {
            string SQL = string.Format("SELECT Date_Format(date,'%d/%m/%Y'), count(idticket), sum(price), asdriver_name " +
                "FROM ticket, as_driver " +
                "WHERE ticket.idas_driver = as_driver.idas_driver and date between'{0}' and '{1}' " +
                "GROUP BY year(date), month(date), day(date)", start, end);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtTicket = new DataTable();
            msda.Fill(dtTicket);
            return dtTicket;
        }

        public List<string> GetListYear()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT distinct Date_Format(date,'%Y') FROM ticket ", _conn);
            DataTable dtTicket = new DataTable();
            msda.Fill(dtTicket);
            List<string> list = new List<string>();
            foreach (DataRow row in dtTicket.Rows)
            {
                list.Add(row["Date_Format(date,'%Y')"].ToString());
            }
            return list;
        }

        public List<DTO_Stat> GetTicketStatForMonth(int year)
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT date, sum(price) " +
                "FROM ticket " +
                "WHERE year(date) = "+ year +" GROUP BY year(date), month(date)", _conn);
            DataTable dtTicket = new DataTable();
            msda.Fill(dtTicket);
            List<DTO_Stat> list = new List<DTO_Stat>();
            foreach (DataRow row in dtTicket.Rows)
            {
                DTO_Stat tk = new DTO_Stat((DateTime)row["date"], (decimal)row["sum(price)"]);
                list.Add(tk);
            }
            return list;
        }

        public bool AddTicket(DTO_Ticket t)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string date = t.TICKET_DATE.ToString("yyyy-MM-dd H:mm:ss");

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO ticket(idticket, date, price, idas_driver) VALUES ({0}, '{1}', {2}, {3})",
                                           t.TICKET_ID,
                                           date,
                                           t.TICKET_TURNOVER,
                                           t.TICKET_AS_DRIVER_ID);

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

        public bool UpdateTicket(DTO_Ticket t)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string date = t.TICKET_DATE.ToString("yyyy-MM-dd H:mm:ss");

                // Query string
                string SQL = string.Format("UPDATE ticket SET date = '{0}', price = {1}, idas_driver = {2} WHERE idticket = {3}",
                                           date, t.TICKET_TURNOVER, t.TICKET_AS_DRIVER_ID,
                                           t.TICKET_ID);

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

        public bool DeleteTicket(int TICKET_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM ticket WHERE idticket = {0}", TICKET_ID);

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

        public DataTable FindTickerByIdTicket(string kw)
        {
            string SQL = string.Format(
                "SELECT idticket, date, price, ticket.idas_driver, as_driver.asdriver_name " +
                "FROM ticket, as_driver " +
                "WHERE ticket.idas_driver = as_driver.idas_driver and idticket LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtTicket = new DataTable();
            msda.Fill(dtTicket);
            return dtTicket;
        }

        public DataTable FindTickerByPrice(string kw)
        {
            string SQL = string.Format(
                "SELECT idticket, date, price, ticket.idas_driver, as_driver.asdriver_name " +
                "FROM ticket, as_driver " +
                "WHERE ticket.idas_driver = as_driver.idas_driver and price LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtTicket = new DataTable();
            msda.Fill(dtTicket);
            return dtTicket;
        }

        public DataTable FindTickerByIdAsDriver(string kw)
        {
            string SQL = string.Format(
                "SELECT idticket, date, price, ticket.idas_driver, as_driver.asdriver_name " +
                "FROM ticket, as_driver " +
                "WHERE ticket.idas_driver = as_driver.idas_driver and ticket.idas_driver LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtTicket = new DataTable();
            msda.Fill(dtTicket);
            return dtTicket;
        }

        public DataTable FindTickerByAsDriverName(string kw)
        {
            string SQL = string.Format(
                "SELECT idticket, date, price, ticket.idas_driver, as_driver.asdriver_name " +
                "FROM ticket, as_driver " +
                "WHERE ticket.idas_driver = as_driver.idas_driver and as_driver.asdriver_name LIKE N\'%{0}%\'", kw);
            MySqlDataAdapter msda = new MySqlDataAdapter(SQL, _conn);
            DataTable dtTicket = new DataTable();
            msda.Fill(dtTicket);
            return dtTicket;
        }
    }
}
