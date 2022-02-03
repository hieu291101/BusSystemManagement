using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    public class DTO_Stat
    {
        private DateTime _STAT_DATE;
        private decimal _STAT_REVENUE;

        public DTO_Stat(DateTime sTAT_DATE, decimal sTAT_REVENUE)
        {
            _STAT_DATE = sTAT_DATE;
            _STAT_REVENUE = sTAT_REVENUE;
        }

        public DateTime STAT_DATE { get => _STAT_DATE; set => _STAT_DATE = value; }
        public decimal STAT_REVENUE { get => _STAT_REVENUE; set => _STAT_REVENUE = value; }
    }
}
