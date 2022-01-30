using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BusSystemManagement;
using DTO_BusSystemManagement;

namespace BUS_BusSystemManagement
{
    public class BUS_BusRide
    {
        DAL_BusRide dalBusRide = new DAL_BusRide();
        public DataTable GetBusRide()
        {
            return dalBusRide.GetBusDriver();
        }

        public bool AddBusRide(DTO_BusRide busr)
        {
            return dalBusRide.AddBusRide(busr);
        }

        public bool UpdateBusRide(DTO_BusRide busr)
        {
            return dalBusRide.UpdateBusRide(busr);
        }

        public bool DeleteBusRide(int BUSRIDE_ID)
        {
            return dalBusRide.DeleteBusRide(BUSRIDE_ID);
        }
    }
}
