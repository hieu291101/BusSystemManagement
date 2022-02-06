using DAL_BusSystemManagement;
using DTO_BusSystemManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BusSystemManagement
{
    public class BUS_Ticket
    {
        DAL_Ticket dalTicket = new DAL_Ticket();
        public DataTable GetTicket()
        {
            return dalTicket.GetTicket();
        }

        public DataTable GetTicketStat()
        {
            return dalTicket.GetTicketStat();
        }

        public DataTable GetTicketStatSearch(string start, string end)
        {
            return dalTicket.GetTicketStatSearch(start, end);
        }

        public List<string> GetListYear()
        {
            return dalTicket.GetListYear();
        }

        public List<DTO_Stat> GetTicketStatForMonth(int year)
        {
            return dalTicket.GetTicketStatForMonth(year);
        }

        public bool AddTicket(DTO_Ticket t)
        {
            return dalTicket.AddTicket(t);
        }

        public bool UpdateTicket(DTO_Ticket t)
        {
            return dalTicket.UpdateTicket(t);
        }

        public bool DeleteTicket(int TICKET_ID)
        {
            return dalTicket.DeleteTicket(TICKET_ID);
        }

        public DataTable FindTickerByIdTicket(string kw)
        {
            return dalTicket.FindTickerByIdTicket(kw);
        }

        public DataTable FindTickerByPrice(string kw)
        {
            return dalTicket.FindTickerByPrice(kw);
        }

        public DataTable FindTickerByIdAsDriver(string kw)
        {
            return dalTicket.FindTickerByIdAsDriver(kw);
        }

        public DataTable FindTickerByAsDriverName(string kw)
        {
            return dalTicket.FindTickerByAsDriverName(kw);
        }
    }
}
