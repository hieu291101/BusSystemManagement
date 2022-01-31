using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL_BusSystemManagement;
using DTO_BusSystemManagement;

namespace BUS_BusSystemManagement
{
    public class BUS_BusLine
    {
        DAL_BusLine dalBusLine = new DAL_BusLine();
        public DataTable GetBusLine()
        {
            return dalBusLine.GetBusLine();
        }

        public bool AddBusLine (DTO_BusLine bl)
        {
            return dalBusLine.AddBusLine(bl);
        }

        public bool UpdateBusLine(DTO_BusLine bl)
        {
            return dalBusLine.UpdateBusLine(bl);
        }

        public bool DeleteBusLine(int BUSLINE_ID)
        {
            return dalBusLine.DeleteBusLine(BUSLINE_ID);
        }
    }
}
