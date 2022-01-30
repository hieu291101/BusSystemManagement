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
    public class BUS_Driver
    {
        DAL_Driver dalDriver = new DAL_Driver();
        public DataTable GetDriver()
        {
            return dalDriver.GetDriver();
        }

        public bool AddDriver(DTO_Driver ad)
        {
            return dalDriver.AddDriver(ad);
        }

        public bool UpdateDriver(DTO_Driver ad)
        {
            return dalDriver.UpdateDriver(ad);
        }

        public bool DeleteDriver(int DRIVER_ID)
        {
            return dalDriver.DeleteDriver(DRIVER_ID);
        }
    }
}
