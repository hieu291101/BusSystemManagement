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
    public class BUS_Bus
    {
        DAL_Bus dalBus = new DAL_Bus();

        public DataTable GetBus()
        {
            return dalBus.GetBus();
        }

        public string GetBusById(int id)
        {
            return dalBus.GetBusById(id);
        }

        public List<string> GetListBusId()
        {
            return dalBus.GetListBusId();
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
