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
    public class BUS_Bus
    {
        DAL_Bus dalBus = new DAL_Bus();

        public DataTable GetBus()
        {
            return dalBus.GetBus();
        }

        public bool AddBus(DTO_Bus bus)
        {
            return dalBus.AddBus(bus);
        }

        public bool DeleteBus(int BUS_ID)
        {
            return dalBus.DeleteBus(BUS_ID);
        }
        
        public bool UpdateBus(DTO_Bus bus)
        {
            return dalBus.UpdateBus(bus);
        }
    }
}
