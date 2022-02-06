using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    public class DTO_Ticket
    {
        private int _TICKET_ID;
        private DateTime _TICKET_DATE;
        private decimal _TICKET_TURNOVER;
        private int _TICKET_AS_DRIVER_ID;

        public DTO_Ticket()
        {

        }

        public DTO_Ticket(int tICKET_ID, DateTime tICKET_DATE, decimal tICKET_TURNOVER, int tICKET_AS_DRIVER_ID)
        {
            _TICKET_ID = tICKET_ID;
            _TICKET_DATE = tICKET_DATE;
            _TICKET_TURNOVER = tICKET_TURNOVER;
            _TICKET_AS_DRIVER_ID = tICKET_AS_DRIVER_ID;
        }

        public int TICKET_ID { get => _TICKET_ID; set => _TICKET_ID = value; }
        public DateTime TICKET_DATE { get => _TICKET_DATE; set => _TICKET_DATE = value; }
        public decimal TICKET_TURNOVER { get => _TICKET_TURNOVER; set => _TICKET_TURNOVER = value; }
        public int TICKET_AS_DRIVER_ID { get => _TICKET_AS_DRIVER_ID; set => _TICKET_AS_DRIVER_ID = value; }
    }
}
