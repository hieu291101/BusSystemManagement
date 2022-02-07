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
    public class BUS_AsDriver
    {
        DAL_AsDriver dalAsDriver = new DAL_AsDriver();
        public DataTable GetAsDriver()
        {
            return dalAsDriver.GetAsDriver();
        }

        public string GetAsDriverById(int id)
        {
            return dalAsDriver.GetAsDriverById(id);
        }

        public List<string> GetListAsDriverId()
        {
            return dalAsDriver.GetListAsDriverId();
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

        public DataTable FindAsDriverByName(string kw)
        {
            return dalAsDriver.FindAsDriverByName(kw);
        }

        public DataTable FindAsDriverByGender(string kw)
        {
            return dalAsDriver.FindAsDriverByGender(kw);
        }

        public DataTable FindAsDriverByAddress(string kw)
        {
            return dalAsDriver.FindAsDriverByAddress(kw);
        }

        public DataTable FindAsDriverByPhoneNumber(string kw)
        {
            return dalAsDriver.FindAsDriverByPhoneNumber(kw);
        }

        public DataTable FindAsDriverByIdCard(string kw)
        {
            return dalAsDriver.FindAsDriverByIdCard(kw);
        }

        public DataTable FindAsDriverByExperienceYear(string kw)
        {
            return dalAsDriver.FindAsDriverByExperienceYear(kw);
        }
    }
}
