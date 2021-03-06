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

        public string GetBusLineById(int id)
        {
            return dalBusLine.GetBusLineById(id);
        }

        public List<string> GetListBusLineId()
        {
            return dalBusLine.GetListBusLineId();
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

        public DataTable FindBusLineByBusLineName(string kw)
        {
            return dalBusLine.FindBusLineByBusLineName(kw);
        }

        public DataTable FindBusLineByStartLocation(string kw)
        {
            return dalBusLine.FindBusLineByStartLocation(kw);
        }

        public DataTable FindBusLineByEndLocation(string kw)
        {
            return dalBusLine.FindBusLineByEndLocation(kw);
        }

        public DataTable FindBusLineByBusStopDetail(string kw)
        {
            return dalBusLine.FindBusLineByBusStopDetail(kw);
        }

        public DataTable FindBusLineByStartTime(string kw)
        {
            return dalBusLine.FindBusLineByStartTime(kw);
        }

        public DataTable FindBusLineByEndTime(string kw)
        {
            return dalBusLine.FindBusLineByEndTime(kw);
        }
    }
}
