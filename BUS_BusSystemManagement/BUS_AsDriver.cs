﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BusSystemManagement;
using DTO_BusSystemManagement;

namespace BUS_BusSystemManagement
{
    public class BUS_AsDriver
    {
        DAL_AsDriver dalAsDriver = new DAL_AsDriver();
        public DataTable GetAsDriver()
        {
            return dalAsDriver.GetAsDriver();
        }

        public bool AddAsDriver(DTO_AsDriver asd)
        {
            return dalAsDriver.AddAsDriver(asd);
        }

        public bool UpdateAsDriver(DTO_AsDriver asd)
        {
            return dalAsDriver.UpdateAsDriver(asd);
        }

        public bool DeleteAsDriver(int ASDRIVER_ID)
        {
            return dalAsDriver.DeleteAsDriver(ASDRIVER_ID);
        }
    }
}
